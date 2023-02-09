Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraGradoEditar

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intGradoID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Dim dtAsignaturasE, dtAsignaturasEliminadas As DataTable
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property GradoID() As Integer
        Get
            Return intGradoID
        End Get
        Set(ByVal value As Integer)
            intGradoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"


    '' Descripción:        Procedimiento encargado de mostrar los datos de una beca en modo de edición
    Public Sub CargarDatosGrado()
        Dim objGrado As SraGrado
        Try
            objGrado = New SraGrado
            objGrado.Retrieve(GradoID)

            txtCodigo.Text = objGrado.CodigoGrado
            If Not String.IsNullOrEmpty(objGrado.Grado) Then
                txtGrado.Text = objGrado.Grado
            End If

            If objGrado.Activo.HasValue Then
                chkActivo.Checked = objGrado.Activo
            End If
            'lblFechaIngreso.Text = "Fecha de Ingreso: " + objGrado.FechaCreacion
            txtCodigo.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objGrado = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarAsignaturasAsignadas()


        Select Case TypeGui
            Case 1
                Me.Text = "Nuevo grado"
                Me.chkActivo.Enabled = False
                Me.chkActivo.Checked = True
                txtCodigo.ReadOnly = True
            Case 2
                Me.Text = "Editar grado"
                Me.chkActivo.Enabled = True
                Me.CargarDatosGrado()
            Case 3
                Me.Text = "Consultar grado"
                Me.CargarDatosGrado()
                Me.txtCodigo.ReadOnly = True
                Me.txtGrado.ReadOnly = True
                Me.chkActivo.Enabled = False
                Me.cmdGuardar.Enabled = False
                cmdAgregar.Enabled = False
                cmdEliminar.Enabled = False

        End Select
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            txtGrado.MaxLength = SraGrado.GetMaxLength("Grado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Grado"

    '' Descripción:        Procedimiento encargado de guardar Grado
    Public Sub GuardarGrado()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearGrado(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de una asignatura
    Public Sub CrearGrado(ByVal T As DAL.TransactionManager)
        Dim objGrado As SraGrado
        Dim objAsignaturaGrado As SraAsignaturas_Grado

        Try
            objGrado = New SraGrado
            objAsignaturaGrado = New SraAsignaturas_Grado

            objGrado.Grado = txtGrado.Text.Trim
            objGrado.Activo = chkActivo.Checked
            objGrado.CodigoGrado = String.Empty
            objGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objGrado.FechaCreacion = fechaServidor
            objGrado.Insert(T)
            GradoID = objGrado.GradoID

            ''Actualizar el codigo de asignatura
            Dim arParams(1) As SqlParameter
            arParams(0) = New SqlParameter("@GradoID", SqlDbType.Int)
            arParams(0).Value = GradoID

            Try
                If T Is Nothing Then
                    SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sp_StbGenerarCodigoGrado", arParams)
                Else
                    SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "sp_StbGenerarCodigoGrado", arParams)
                End If

            Catch ex As Exception
                Throw
            End Try

            ''Eliminar Datos
            SraAsignaturas_Grado.DeleteByFilter("objAsignaturaID=" + GradoID.ToString, T)
            SraAsignaturas_Grado.DeleteByFilter("objAsignaturaID=" + GradoID.ToString, T)

            ''Guardar Asignatura por profesor
            For Each dr As DataRow In dtAsignaturasE.Rows
                objAsignaturaGrado.objGradoID = Me.GradoID
                objAsignaturaGrado.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturaGrado.Activo = True
                objAsignaturaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturaGrado.Insert(T)
            Next

            For Each dr As DataRow In dtAsignaturasEliminadas.Rows
                objAsignaturaGrado.objGradoID = Me.GradoID
                objAsignaturaGrado.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturaGrado.Activo = False
                objAsignaturaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturaGrado.Insert(T)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Grado"

    '' Descripción:        Procedimiento encargado de actualizar Grado
    Public Sub ActualizarGrado()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosGrado(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de una beca
    Public Sub ModificarDatosGrado(ByVal T As DAL.TransactionManager)
        Dim ObjGrado As SraGrado
        Dim objAsignaturaGrado As SraAsignaturas_Grado
        Try
            ObjGrado = New SraGrado
            objAsignaturaGrado = New SraAsignaturas_Grado

            ObjGrado.GradoID = GradoID
            ObjGrado.CodigoGrado = txtCodigo.Text.Trim
            ObjGrado.Grado = txtGrado.Text.Trim
            ObjGrado.Activo = chkActivo.Checked
            ObjGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
            ObjGrado.FechaCreacion = fechaServidor
            ObjGrado.UsuarioModificacion = clsProyecto.Conexion.Usuario
            ObjGrado.FechaModificacion = fechaServidor
            ObjGrado.Update(T)

            ''Eliminar Datos
            SraAsignaturas_Grado.DeleteByFilter("objGradoID=" + GradoID.ToString, T)
            SraAsignaturas_Grado.DeleteByFilter("objGradoID=" + GradoID.ToString, T)

            ''Guardar Asignatura por profesor
            For Each dr As DataRow In dtAsignaturasE.Rows
                objAsignaturaGrado.objGradoID = Me.GradoID
                objAsignaturaGrado.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturaGrado.Activo = True
                objAsignaturaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturaGrado.Insert(T)
            Next

            For Each dr As DataRow In dtAsignaturasEliminadas.Rows
                objAsignaturaGrado.objGradoID = Me.GradoID
                objAsignaturaGrado.objAsignaturaID = CInt(dr("AsignaturaID").ToString)
                objAsignaturaGrado.Activo = False
                objAsignaturaGrado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignaturaGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignaturaGrado.Insert(T)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            ObjGrado = Nothing
        End Try
    End Sub

#End Region

    Public Sub CargarAsignaturasAsignadas()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1 and objGradoID= " + GradoID.ToString
            dtAsignaturasE = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, objGradoID, AsignaturaID, CodigoAsignarura, Nombre, Activo", "vwSraAsignaturaGrado", strFiltro))
            dtAsignaturasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, objGradoID, AsignaturaID, CodigoAsignarura, Nombre, Activo", "vwSraAsignaturaGrado", "Activo=0 and objGradoID= " + GradoID.ToString))

            grdAsignaturaA.DataSource = dtAsignaturasE
            grdAsignaturaA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Try
            If txtGrado.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtGrado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerPropiedades()
        ConfigurarGUI()
        txtGrado.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarGrado()
                Case 2
                    ActualizarGrado()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.Clear()
        boolEditado = True
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ErrorProv.SetError(txtCodigo, "")
        boolEditado = True
    End Sub

    Private Sub frmBodegasEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtCodigo.Text.Trim.Length <> 0 Then
                Me.txtGrado.Focus()
            End If
        End If
    End Sub


    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub

    Private Sub txtGrado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.chkActivo.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
            End If
        End If
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(txtCodigo, "")
    End Sub

#End Region



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
End Class