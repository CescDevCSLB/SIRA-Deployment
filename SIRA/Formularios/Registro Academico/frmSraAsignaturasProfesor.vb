Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSraAsignaturasProfesor

#Region "Declaración de Variables propias del formulario"
    Public Shared dtAsignaturasE, dtPeriodo, dtGradosA, dtProfesor, dtAsignaturasEliminadas, dtGradosEliminadas As DataTable
    Dim id_profesor, TyGui_Lec As Integer
   
#End Region

#Region "Propiedades"

    Property idprofesor() As String
        Get
            Return id_profesor
        End Get
        Set(ByVal value As String)
            id_profesor = value
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
    '' Descripción:        Procedimiento encargado de cargar la informacion del profesor seleccionado
    Public Sub CargarDatosProfesor()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbProfesorID = '" & idprofesor & "'"
            dtProfesor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto, Cedula, Direccion,objGeneroID, Genero, StbProfesorID, ISNULL(FechaIngreso,'') AS FechaIngreso", "vwSraProfesores", strFiltro))

            Me.txtNombreCompleto.DataBindings.Clear()
            Me.dtpFechaIngreso.DataBindings.Clear()
            Me.txtCedula.DataBindings.Clear()
            Me.txtDireccion.DataBindings.Clear()

            Me.txtNombreCompleto.DataBindings.Add("text", dtProfesor, "NombreCompleto", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedula.DataBindings.Add("text", dtProfesor, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)

            If dtProfesor.Rows.Count > 0 Then
                Me.dtpFechaIngreso.Value = dtProfesor.Rows(0)("FechaIngreso")
            End If

            Me.txtDireccion.DataBindings.Add("text", dtProfesor, "Direccion", False, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub CargarAsignaturasAsignadas()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtAsignaturasE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar,SraAsignatura_ProfesorID, objProfesorID, AsignaturaID, CodigoAsignarura, Nombre", "vwSraAsignaturaProfesor", "objProfesorID= " + id_profesor.ToString + " and " + strFiltro))
            dtAsignaturasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar,SraAsignatura_ProfesorID, objProfesorID, AsignaturaID, CodigoAsignarura, Nombre", "vwSraAsignaturaProfesor", "objProfesorID= " + id_profesor.ToString + " and Activo=0"))

            grdAsignaturaA.DataSource = dtAsignaturasE
            grdAsignaturaA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarGradosAsignadas()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtGradosA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, SraGrados_ProfesorID, objProfesorID, GradoID, CodigoGrado, Grado", "vwSraGradosProfesor", "objProfesorID= " + id_profesor.ToString + " and " + strFiltro))
            dtGradosEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, SraGrados_ProfesorID, objProfesorID, GradoID, CodigoGrado, Grado", "vwSraGradosProfesor", "objProfesorID= " + id_profesor.ToString + " and Activo=0"))

            grdGradosA.DataSource = dtGradosA
            grdGradosA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region




    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarDatosProfesor()
            CargarAsignaturasAsignadas()
            CargarGradosAsignadas()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try

            Dim objSeleccion As frmAsignaturasSelector
            objSeleccion = New frmAsignaturasSelector
        
            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim filas As DataRow
                For Each dr As DataRow In frmAsignaturasSelector.dtAsignaturasS.Rows
                    filas = dtAsignaturasE.NewRow
                    filas("AsignaturaID") = CInt(dr("AsignaturaID").ToString)
                    filas("CodigoAsignarura") = (dr("CodigoAsignarura").ToString)
                    filas("Nombre") = (dr("Nombre").ToString)
                    dtAsignaturasE.Rows.Add(filas)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdAsignaturaATable.SelectedRowsCount() - 1
                If (grdAsignaturaATable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdAsignaturaATable.GetDataRow(grdAsignaturaATable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtAsignaturasEliminadas.NewRow
                filas("AsignaturaID") = CInt(drFilaAsignaturaEliminadas("AsignaturaID"))
                filas("CodigoAsignarura") = drFilaAsignaturaEliminadas("CodigoAsignarura").ToString
                filas("Nombre") = drFilaAsignaturaEliminadas("Nombre").ToString
                dtAsignaturasEliminadas.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                dtAsignaturasE.Rows.Remove(drFilaAsignaturasE)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregarGrados.Click
        Try

            Dim objSeleccion As frmGradosSelector
            objSeleccion = New frmGradosSelector

            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim filas As DataRow
                For Each dr As DataRow In frmGradosSelector.dtGradosSelect.Rows
                    filas = dtGradosA.NewRow
                    filas("GradoID") = CInt(dr("GradoID").ToString)
                    filas("CodigoGrado") = (dr("CodigoGrado").ToString)
                    filas("Grado") = (dr("Grado").ToString)
                    dtGradosA.Rows.Add(filas)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrados_Click(sender As Object, e As EventArgs) Handles cmdEliminarGrados.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdGradosATable.SelectedRowsCount() - 1
                If (grdGradosATable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdGradosATable.GetDataRow(grdGradosATable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaGradosEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtGradosEliminadas.NewRow
                filas("GradoID") = CInt(drFilaGradosEliminadas("GradoID"))
                filas("CodigoGrado") = drFilaGradosEliminadas("CodigoGrado").ToString
                filas("Grado") = drFilaGradosEliminadas("Grado").ToString
                dtGradosEliminadas.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dtGradosA.Rows.Remove(drFilaGradosE)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objAsignaturasProfesor As SraAsignatura_Profesor
        Dim objGradosProfesor As SraGrados_Profesor
        Try
            T.BeginTran()
            objAsignaturasProfesor = New SraAsignatura_Profesor
            objGradosProfesor = New SraGrados_Profesor

            ''Eliminar Datos
            SraAsignatura_Profesor.DeleteByFilter("objProfesorID=" + idprofesor.ToString, T)
            SraGrados_Profesor.DeleteByFilter("objProfesorID=" + idprofesor.ToString, T)

            ''Guardar Asignatura por profesor
            For Each dr As DataRow In dtAsignaturasE.Rows
                objAsignaturasProfesor.objProfesorID = Me.idprofesor
                objAsignaturasProfesor.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturasProfesor.Activo = True
                objAsignaturasProfesor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturasProfesor.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturasProfesor.Insert(T)
            Next

            For Each dr As DataRow In dtAsignaturasEliminadas.Rows
                objAsignaturasProfesor.objProfesorID = Me.idprofesor
                objAsignaturasProfesor.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturasProfesor.Activo = False
                objAsignaturasProfesor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturasProfesor.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturasProfesor.Insert(T)
            Next

            ''Guardar Grado por profesor
            For Each dr As DataRow In dtGradosA.Rows
                objGradosProfesor.objProfesorID = Me.idprofesor
                objGradosProfesor.objGradoID = CInt(dr("GradoID").ToString)
                objGradosProfesor.Activo = True
                objGradosProfesor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosProfesor.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosProfesor.Insert(T)
            Next

            For Each dr As DataRow In dtGradosEliminadas.Rows
                objGradosProfesor.objProfesorID = Me.idprofesor
                objGradosProfesor.objGradoID = CInt(dr("GradoID").ToString)
                objGradosProfesor.Activo = False
                objGradosProfesor.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosProfesor.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosProfesor.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
End Class