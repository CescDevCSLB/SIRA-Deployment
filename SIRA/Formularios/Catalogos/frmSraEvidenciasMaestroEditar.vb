Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSraEvidenciasMaestroEditar

#Region "Declaración de Variables propias del formulario"
    Public Shared dtDetalleEdidencias, dtDetalleEdidenciasEliminadas, dtGrados, dtGradosAsignados, dtGradoEliminados, dtProfesor, dtPeriodos As DataTable
    Dim TyGui_Lec, intEvidenciaID As Integer

#End Region

#Region "Propiedades"

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

    Public Sub CargarDatosEvidencias()
        Dim objEvidencias As SraEvidencias
        Try
            objEvidencias = New SraEvidencias
            objEvidencias.Retrieve(EvidenciaID)

            txtTitulo.Text = objEvidencias.NombreEvidencia
            chkActivo.Checked = objEvidencias.Activa

            If Not IsDBNull(objEvidencias.Descripcion) Then
                txtdescripcion.Text = objEvidencias.Descripcion
            End If

            If Not IsNothing(objEvidencias.objProfesorID) Then
                cmbProfesor.SelectedValue = objEvidencias.objProfesorID
            End If

            If Not IsNothing(objEvidencias.objPeriodoID) Then
                cmbPeriodo.SelectedValue = objEvidencias.objPeriodoID
            End If

            If Not IsDBNull(objEvidencias.OrdenEvidencia) Then
                spnOrden.Value = objEvidencias.OrdenEvidencia
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objEvidencias = Nothing
        End Try
    End Sub

    Public Sub CargarGradosAsignados()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtGradosAsignados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  GradoID, objEvidenciaID, Grado, Activo", "vwEvidenciasGrados", "objEvidenciaID=" + EvidenciaID.ToString + " AND " + strFiltro))
            dtGradoEliminados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  GradoID, objEvidenciaID, Grado, Activo", "vwEvidenciasGrados", "objEvidenciaID=" + EvidenciaID.ToString + " AND Activo=0"))

            grdGrados.DataSource = dtGradosAsignados
            grdGrados.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Property EvidenciaID() As Integer
        Get
            Return intEvidenciaID
        End Get
        Set(ByVal value As Integer)
            intEvidenciaID = value
        End Set
    End Property

    Private Sub CargarGrados()
        Try
            dtGrados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID,Grado", "SraGrado", "Activo=1"))
            Me.cmbGradosFinal.DataSource = dtGrados
            Me.cmbGradosFinal.DisplayMember = "Grado"
            Me.cmbGradosFinal.ValueMember = "GradoID"
            Me.cmbGradosFinal.Splits(0).DisplayColumns("GradoID").Visible = False
            Me.cmbGradosFinal.ExtendRightColumn = True
            Me.cmbGradosFinal.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub

#End Region

    Public Sub CargarProfesores()
        Try
            dtProfesor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct StbProfesorID, NombreCompleto", "vwSraProfesores_Grados", "1=1"))

            cmbProfesor.ValueMember = "StbProfesorID"
            cmbProfesor.DisplayMember = "NombreCompleto"
            cmbProfesor.DataSource = dtProfesor

            cmbProfesor.Splits(0).DisplayColumns("StbProfesorID").Visible = False
            cmbProfesor.ColumnHeaders = False
            cmbProfesor.ExtendRightColumn = True

            If frmPrincipal.glbProfesor <> 0 Then
                cmbProfesor.SelectedValue = frmPrincipal.glbProfesor
                cmbProfesor.Enabled = False
            Else
                cmbProfesor.SelectedIndex = -1
                cmbProfesor.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True

            If frmPrincipal.glbPeriodoSeleccionado <> 0 Then
                cmbPeriodo.SelectedValue = frmPrincipal.glbPeriodoSeleccionado
                cmbPeriodo.Enabled = False
            Else
                cmbPeriodo.SelectedIndex = -1
                cmbPeriodo.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub EstablecerPropiedades()
        Try
            txtTitulo.MaxLength = SraEvidencias.GetMaxLength("NombreEvidencia")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()
            Select Case TyGui
                Case 1
                    Me.Text = "Nueva evidencia"
                    CargarGrados()
                    CargarGradosAsignados()
                    CargarProfesores()
                    CargarPeriodos()
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmdGuardar.Enabled = True
                Case 2
                    Me.Text = "Editar evidencia"
                    CargarGrados()
                    CargarProfesores()
                    CargarPeriodos()
                    Me.chkActivo.Enabled = True
                    CargarDatosEvidencias()
                    CargarGradosAsignados()
                    cmdGuardar.Enabled = True

                Case 3
                    Me.Text = "Consultar evidencia"
                    CargarGrados()
                    CargarProfesores()
                    CargarPeriodos()
                    Me.CargarDatosEvidencias()
                    CargarGradosAsignados()
                    txtTitulo.Enabled = False
                    txtdescripcion.Enabled = False
                    Me.cmbPeriodo.Enabled = False
                    Me.chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
                    spnOrden.Enabled = False
                    cmdAgregarGrado.Enabled = False
                    cmdEliminarGrado.Enabled = False
                    cmbPeriodo.Enabled = False
                    cmbProfesor.Enabled = False
            End Select


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub



    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objEvidenciaMaestro As SraEvidencias
        Dim objEvidenciaGrado As SraEvidenciaGrados
        Try
            If txtTitulo.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtTitulo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            T.BeginTran()

            objEvidenciaMaestro = New SraEvidencias
            objEvidenciaGrado = New SraEvidenciaGrados

            Select Case TyGui
                Case 1
                    objEvidenciaMaestro.NombreEvidencia = txtTitulo.Text
                    objEvidenciaMaestro.Activa = chkActivo.Checked
                    If spnOrden.Value <> 0 Then
                        objEvidenciaMaestro.OrdenEvidencia = spnOrden.Value
                    End If

                    If (cmbProfesor.SelectedText <> String.Empty) Then
                        objEvidenciaMaestro.objProfesorID = cmbProfesor.SelectedValue
                    End If
                    objEvidenciaMaestro.objPeriodoID = cmbPeriodo.SelectedValue
                    objEvidenciaMaestro.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objEvidenciaMaestro.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objEvidenciaMaestro.Descripcion = txtdescripcion.Text
                    objEvidenciaMaestro.Insert(T)
                    EvidenciaID = objEvidenciaMaestro.SraEvidenciasID
                Case 2
                    objEvidenciaMaestro.Retrieve(EvidenciaID)
                    objEvidenciaMaestro.NombreEvidencia = txtTitulo.Text
                    objEvidenciaMaestro.Activa = chkActivo.Checked
                    objEvidenciaMaestro.Descripcion = txtdescripcion.Text

                    If (cmbProfesor.SelectedText <> String.Empty) Then
                        objEvidenciaMaestro.objProfesorID = cmbProfesor.SelectedValue
                    End If

                    If spnOrden.Value <> 0 Then
                        objEvidenciaMaestro.OrdenEvidencia = spnOrden.Value
                    End If
                    objEvidenciaMaestro.objPeriodoID = cmbPeriodo.SelectedValue
                    objEvidenciaMaestro.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objEvidenciaMaestro.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objEvidenciaMaestro.Update(T)
            End Select

            SraEvidenciaGrados.DeleteByFilter("objEvidenciaID=" + intEvidenciaID.ToString, T)

            For Each dr As DataRow In dtGradosAsignados.Rows
                objEvidenciaGrado.objEvidenciaID = intEvidenciaID.ToString
                objEvidenciaGrado.objGradoID = dr("GradoID").ToString
                objEvidenciaGrado.Activo = True
                objEvidenciaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEvidenciaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEvidenciaGrado.Insert(T)
            Next

            For Each dr As DataRow In dtGradoEliminados.Rows
                objEvidenciaGrado.objEvidenciaID = intEvidenciaID.ToString
                objEvidenciaGrado.objGradoID = dr("GradoID").ToString
                objEvidenciaGrado.Activo = False
                objEvidenciaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEvidenciaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objEvidenciaGrado.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub


    Private Sub cmdAgregarGrado_Click(sender As Object, e As EventArgs) Handles cmdAgregarGrado.Click
        Dim filas As DataRow

        Try
            If cmbGradosFinal.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbGradosFinal, My.Resources.MsgObligatorio)
                Exit Sub

            Else
                filas = dtGradosAsignados.NewRow
                filas("GradoID") = cmbGradosFinal.SelectedValue
                filas("Grado") = cmbGradosFinal.Text
                filas("objEvidenciaID") = EvidenciaID
                filas("Activo") = True
                dtGradosAsignados.Rows.Add(filas)

                ''Limpiar Controles
                cmbGradosFinal.Text = String.Empty
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrado_Click(sender As Object, e As EventArgs) Handles cmdEliminarGrado.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdGradosTabla.SelectedRowsCount() - 1
                If (grdGradosTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdGradosTabla.GetDataRow(grdGradosTabla.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaGradosEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtGradoEliminados.NewRow

                filas("GradoID") = Int(drFilaGradosEliminadas("GradoID").ToString)
                filas("Grado") = drFilaGradosEliminadas("Grado").ToString
                filas("objEvidenciaID") = Int(drFilaGradosEliminadas("objEvidenciaID"))
                filas("Activo") = False
                dtGradoEliminados.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGrados As DataRow = CType(Rows(I), DataRow)
                dtGradosAsignados.Rows.Remove(drFilaGrados)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        ErrPrv.SetError(txtTitulo, "")
    End Sub

    Private Sub cmbGradosFinal_TextChanged(sender As Object, e As EventArgs) Handles cmbGradosFinal.TextChanged
        ErrPrv.SetError(cmbGradosFinal, "")
    End Sub
End Class