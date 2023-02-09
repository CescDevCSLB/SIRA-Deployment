Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSraGrupoAsignaturasProfesor

#Region "Declaración de Variables propias del formulario"
    Public Shared dtAsignaciones, dtModalidad, dtAsignaturas, dtAsignacionesEliminadas, DtGrados, DtSeccion, dtProfesor, dtProfesoresGuia, dtPeriodos As DataTable
    Dim TyGui_Lec, intGrupoID, intGradoID As Integer

#End Region

#Region "Propiedades"

    Property GradoID() As Integer
        Get
            Return intGradoID
        End Get
        Set(ByVal value As Integer)
            intGradoID = value
        End Set
    End Property

    Property TyGui() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property


#End Region

#Region "Busqueda"

    Public Sub CargarDatosGrupo()
        Dim objGrupo As SraGrupo
        Try
            objGrupo = New SraGrupo
            objGrupo.Retrieve(GrupoID)

            cmbPeriodo.SelectedValue = objGrupo.objPeriodoID
            cmbGrado.SelectedValue = objGrupo.objGradoID
            cmbSeccion.SelectedValue = objGrupo.objSeccionID

            If Not IsNothing(objGrupo.objGuiaID) Then
                cmbProfesorGuia.SelectedValue = objGrupo.objGuiaID
            End If

            cmbModalidad.SelectedValue = objGrupo.objModalidadID

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objGrupo = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarProfesoresGuia()
        Try
            dtProfesoresGuia = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbProfesorID, NombreCompleto", "vwSraProfesores", "1=1"))

            cmbProfesorGuia.ValueMember = "StbProfesorID"
            cmbProfesorGuia.DisplayMember = "NombreCompleto"
            cmbProfesorGuia.DataSource = dtProfesoresGuia

            cmbProfesorGuia.Splits(0).DisplayColumns("StbProfesorID").Visible = False
            cmbProfesorGuia.ColumnHeaders = False
            cmbProfesorGuia.ExtendRightColumn = True
            cmbProfesorGuia.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarAsignaturaProfesor()
        Try
            dtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" AsignaturaID, Nombre", "vwAsignaturaProfesor_Grado", "objProfesorID=" + cmbProfesor.SelectedValue.ToString & " AND objGradoID=" & GradoID))

            cmbAsignatura.ValueMember = "AsignaturaID"
            cmbAsignatura.DisplayMember = "Nombre"
            cmbAsignatura.DataSource = dtAsignaturas

            cmbAsignatura.Splits(0).DisplayColumns("AsignaturaID").Visible = False
            cmbAsignatura.ColumnHeaders = False
            cmbAsignatura.ExtendRightColumn = True
            cmbAsignatura.SelectedIndex = -1

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarProfesores()
        Try
            dtProfesor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct StbProfesorID, NombreCompleto", "vwSraProfesores_Grados", "objGradoID=" & GradoID))

            cmbProfesor.ValueMember = "StbProfesorID"
            cmbProfesor.DisplayMember = "NombreCompleto"
            cmbProfesor.DataSource = dtProfesor

            cmbProfesor.Splits(0).DisplayColumns("StbProfesorID").Visible = False
            cmbProfesor.ColumnHeaders = False
            cmbProfesor.ExtendRightColumn = True
            cmbProfesor.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarGrados()
        Try
            DtGrados = SraGrado.RetrieveDT("", "", "GradoID,Grado")

            cmbGrado.ValueMember = "GradoID"
            cmbGrado.DisplayMember = "Grado"
            cmbGrado.DataSource = DtGrados

            cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            cmbGrado.ColumnHeaders = False
            cmbGrado.ExtendRightColumn = True
            cmbGrado.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarSeccion()
        Try
            'Seccion
            DtSeccion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='SECCIÓN')"))
            Me.cmbSeccion.DataSource = DtSeccion
            Me.cmbSeccion.DisplayMember = "Descripcion"
            Me.cmbSeccion.ValueMember = "StbValorCatalogoID"
            Me.cmbSeccion.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbSeccion.ExtendRightColumn = True
            Me.cmbSeccion.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarModalidad()
        Try
            'Modalidad
            dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))
            Me.cmbModalidad.DataSource = dtModalidad
            Me.cmbModalidad.DisplayMember = "Descripcion"
            Me.cmbModalidad.ValueMember = "StbValorCatalogoID"
            Me.cmbModalidad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbModalidad.ExtendRightColumn = True
            Me.cmbModalidad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarAsignaciones()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtAsignaciones = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  StbProfesorID, AsignaturaID,  Profesor, Asignatura, objGrupoID", "vwSraGrupos_Profesor_Asignaturas", "objGrupoID=" + GrupoID.ToString + " and " + strFiltro))
            dtAsignacionesEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  StbProfesorID, AsignaturaID,  Profesor, Asignatura, objGrupoID", "vwSraGrupos_Profesor_Asignaturas", "objGrupoID=" + GrupoID.ToString + " and Activo=0"))

            If TyGui = 1 Then
                grdProfesoresInicial.DataSource = dtAsignaciones
                grdProfesoresInicial.ForceInitialize()
            Else
                grdAsigmacion.DataSource = dtAsignaciones
                grdAsigmacion.ForceInitialize()
            End If
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    


    Property GrupoID() As Integer
        Get
            Return intGrupoID
        End Get
        Set(ByVal value As Integer)
            intGrupoID = value
        End Set
    End Property

#End Region




    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarPeriodos()
            CargarSeccion()
            CargarGrados()
            CargarProfesores()
            CargarProfesoresGuia()
            CargarModalidad()
            CargarDatosGrupo()
            CargarAsignaciones()

            If TyGui = 1 Then
                cmbAsignatura.Visible = False
                lblAsignatura.Visible = False
                grdAsigmacion.Visible = False
                grdProfesoresInicial.Visible = True
            Else
                cmbAsignatura.Visible = True
                grdAsigmacion.Visible = True
                grdProfesoresInicial.Visible = False
                lblAsignatura.Visible = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Function ValidarExisteTabla(intProfesor As Integer, intAsignatura As Integer) As Boolean
        Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim filas As DataRow
        Dim ProfesorID, AsignaturaID As Integer

            Try
            filas = dtAsignaciones.NewRow
            ProfesorID = cmbProfesor.SelectedValue

            filas("Profesor") = cmbProfesor.Text
            filas("StbProfesorID") = ProfesorID

            If TyGui <> 1 Then
                AsignaturaID = cmbAsignatura.SelectedValue
                filas("Asignatura") = cmbAsignatura.Text
                filas("AsignaturaID") = AsignaturaID
                cmbAsignatura.Text = String.Empty
            End If
          
            dtAsignaciones.Rows.Add(filas)
            cmbProfesor.Text = String.Empty

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            If TyGui = 1 Then
                For I = 0 To grdProfesoresEI.SelectedRowsCount() - 1
                    If (grdProfesoresEI.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(grdProfesoresEI.GetDataRow(grdProfesoresEI.GetSelectedRows()(I)))
                    End If
                Next

                Dim filas As DataRow
                For I = 0 To Rows.Count - 1
                    Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                    filas = dtAsignacionesEliminadas.NewRow
                    filas("Profesor") = drFilaAsignaturaEliminadas("Profesor").ToString
                    filas("Asignatura") = drFilaAsignaturaEliminadas("Asignatura").ToString
                    dtAsignacionesEliminadas.Rows.Add(filas)
                Next

                For I = 0 To Rows.Count - 1
                    Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                    dtAsignaciones.Rows.Remove(drFilaAsignaturasE)
                Next
            Else
                For I = 0 To grdAsignacionTable.SelectedRowsCount() - 1
                    If (grdAsignacionTable.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(grdAsignacionTable.GetDataRow(grdAsignacionTable.GetSelectedRows()(I)))
                    End If
                Next

                Dim filas As DataRow
                For I = 0 To Rows.Count - 1
                    Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                    filas = dtAsignacionesEliminadas.NewRow

                    filas("StbProfesorID") = CInt(drFilaAsignaturaEliminadas("StbProfesorID"))
                    filas("AsignaturaID") = CInt(drFilaAsignaturaEliminadas("AsignaturaID"))
                    filas("Profesor") = drFilaAsignaturaEliminadas("Profesor").ToString
                    filas("Asignatura") = drFilaAsignaturaEliminadas("Asignatura").ToString
                    dtAsignacionesEliminadas.Rows.Add(filas)
                Next

                For I = 0 To Rows.Count - 1
                    Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                    dtAsignaciones.Rows.Remove(drFilaAsignaturasE)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

   

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objAsignar As SraGrupos_Profesor_Asignaturas

        Try
            T.BeginTran()
            objAsignar = New SraGrupos_Profesor_Asignaturas
          
            ''Eliminar Datos
            SraGrupos_Profesor_Asignaturas.DeleteByFilter("objGrupoID=" & intGrupoID.ToString, T)

            ''Guardar Asignatura por profesor
            For Each dr As DataRow In dtAsignaciones.Rows
                objAsignar.objGrupoID = intGrupoID.ToString
                objAsignar.objProfesorID = CInt(dr("StbProfesorID").ToString)

                If TyGui <> 1 Then
                    objAsignar.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                End If

                objAsignar.Activo = True
                objAsignar.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignar.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignar.Insert(T)
            Next

            'For Each dr As DataRow In dtAsignacionesEliminadas.Rows
            '    objAsignar.objGrupoID = intGrupoID.ToString
            '    objAsignar.objProfesorID = CInt(dr("StbProfesorID").ToString)

            '    If TyGui <> 1 Then
            '        objAsignar.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
            '    End If

            '    objAsignar.Activo = False
            '    objAsignar.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '    objAsignar.FechaCreacion = clsProyecto.Conexion.FechaServidor
            '    objAsignar.Insert(T)
            'Next


            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub cmbProfesor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbProfesor.SelectedValueChanged
        If cmbProfesor.Text <> String.Empty Then
            CargarAsignaturaProfesor()
        End If

    End Sub
End Class