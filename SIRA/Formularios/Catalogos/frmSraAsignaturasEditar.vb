Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraSpellChecker

Public Class frmSraAsignaturasEditar

#Region "Declaracion de Variables"
    Public DtCiudad, DtJefe As DataTable
    Public intTypeGui As Integer
    Public intAsignaturaID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Private popupMenu1 As New PopupMenu()
    Private barManager1 As New BarManager()
    Public Shared dt, dtEliminadas, dtModalidad, dtParciales As DataTable
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

    Property AsignaturaID() As Integer
        Get
            Return intAsignaturaID
        End Get
        Set(ByVal value As Integer)
            intAsignaturaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"

    '' Descripción:        Procedimiento encargado de mostrar los datos de una bodega en modo de edición
    Public Sub CargarDatosAsignaturas()
        Dim objAsignatura As SraAsignaturas
        Try
            objAsignatura = New SraAsignaturas
            objAsignatura.Retrieve(AsignaturaID)

            txtNombre.Text = objAsignatura.Nombre
            txtAbreviatura.Text = objAsignatura.Abreviatura

            If Not String.IsNullOrEmpty(objAsignatura.CodigoAsignarura) Then
                txtCodigo.Text = objAsignatura.CodigoAsignarura.Trim
            End If

            If objAsignatura.Activa.HasValue Then
                chkActivo.Checked = objAsignatura.Activa
            End If

            If objAsignatura.SoloGuia.HasValue Then
                chkSoloGuia.Checked = objAsignatura.SoloGuia
            End If

            If objAsignatura.ordenboletin.HasValue Then
                spnOrden.Value = objAsignatura.ordenboletin
            End If

            lblFechaIngreso.Text = "Fecha de Ingreso: " + objAsignatura.FechaCreacion
            txtCodigo.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAsignatura = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"




    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarParcial()
            CargarModalidad()
            chkCualitativa.Checked = False
            chkCuantitativa.Checked = False

            Select Case TypeGui
                Case 1
                    Me.Text = "Nueva Asignatura"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    txtCodigo.ReadOnly = True
                Case 2
                    Me.Text = "Editar Asignatura"
                    Me.chkActivo.Enabled = True
                    Me.CargarDatosAsignaturas()
                Case 3
                    Me.Text = "Consultar Asignatura"
                    Me.CargarDatosAsignaturas()
                    Me.txtNombre.ReadOnly = True
                    Me.txtCodigo.ReadOnly = True
                    Me.chkActivo.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.cmbModalidad.Enabled = False
                    Me.cmbParcial.Enabled = False
                    Me.cmdAgregar.Enabled = False
                    Me.cmdEliminar.Enabled = False
                    chkCualitativa.Enabled = False
                    chkCuantitativa.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            txtNombre.MaxLength = SraAsignaturas.GetMaxLength("Nombre")
            txtAbreviatura.MaxLength = SraAsignaturas.GetMaxLength("Abreviatura")
            'txtCodigo.MaxLength = StbTienda.GetMaxLength("Codigo")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Asignatura"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarAsignatura()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearAsignatura(T)
            GuardarConfiguracion(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub GuardarConfiguracion(ByVal T As DAL.TransactionManager)
        Dim objConfiguracion As New SraAsignaturasConfiguracion
        Try
            ''Eliminar Datos
            SraAsignaturasConfiguracion.DeleteByFilter("objAsignaturaID=" & AsignaturaID, T)

            ''Guardar Grados
            For Each dr As DataRow In dt.Rows
                objConfiguracion.objAsignaturaID = AsignaturaID
                objConfiguracion.objModalidadID = CInt(dr("objModalidadID").ToString)
                objConfiguracion.objParcialID = CInt(dr("objParcialID").ToString)
                objConfiguracion.Cualitativa = CBool(dr("Cualitativa").ToString)
                objConfiguracion.Cuantitativa = CBool(dr("Cuantitativa").ToString)
                objConfiguracion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objConfiguracion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objConfiguracion.Insert(T)
            Next

            For Each dr As DataRow In dtEliminadas.Rows
                SraAsignaturasConfiguracion.DeleteByFilter("SraAsignaturasConfiguracion=" & CInt(dr("SraAsignaturasConfiguracion").ToString), T)
            Next
        Catch ex As Exception

        End Try
    End Sub
    '' Descripción:        Procedimiento encargado de guardar los datos de una asignatura
    Public Sub CrearAsignatura(ByVal T As DAL.TransactionManager)
        Dim objAsignatura As SraAsignaturas

        Try
            objAsignatura = New SraAsignaturas
            objAsignatura.CodigoAsignarura = String.Empty
            objAsignatura.Nombre = txtNombre.Text.Trim
            objAsignatura.Activa = chkActivo.Checked
            objAsignatura.SoloGuia = chkSoloGuia.Checked
            objAsignatura.Abreviatura = txtAbreviatura.Text
            objAsignatura.ordenboletin = spnOrden.Value

            objAsignatura.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objAsignatura.FechaCreacion = fechaServidor
            objAsignatura.Insert(T)
            AsignaturaID = objAsignatura.AsignaturaID

            ''Actualizar el codigo de asignatura
            Dim arParams(1) As SqlParameter
            arParams(0) = New SqlParameter("@AsignaturaID", SqlDbType.Int)
            arParams(0).Value = AsignaturaID

            Try
                If T Is Nothing Then
                    SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "sp_StbGenerarCodigoAsignatura", arParams)
                Else
                    SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "sp_StbGenerarCodigoAsignatura", arParams)
                End If

            Catch ex As Exception
                Throw
            End Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Asignatura"

    '' Descripción:        Procedimiento encargado de actualizar tienda
    Public Sub ActualizarAsignatura()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosAsignatura(T)
            GuardarConfiguracion(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de una tienda
    Public Sub ModificarDatosAsignatura(ByVal T As DAL.TransactionManager)
        Dim objAsignatura As SraAsignaturas
        Try
            objAsignatura = New SraAsignaturas
            objAsignatura.Retrieve(AsignaturaID)
            objAsignatura.Nombre = txtNombre.Text.Trim
            objAsignatura.CodigoAsignarura = txtCodigo.Text.Trim
            objAsignatura.Activa = chkActivo.Checked
            objAsignatura.SoloGuia = chkSoloGuia.Checked
            objAsignatura.Abreviatura = txtAbreviatura.Text
            objAsignatura.ordenboletin = spnOrden.Value


            objAsignatura.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objAsignatura.FechaModificacion = fechaServidor
            objAsignatura.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAsignatura = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar grid"
    Public Sub CargarGrid()
        Try
            dt = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, SraAsignaturasConfiguracion,objAsignaturaID, objModalidadID, Modalidad, Parcial, objParcialID, Cualitativa, Cuantitativa", "vwSraAsignaturasConfiguracion", "objAsignaturaID= " + AsignaturaID.ToString))
            dtEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar,SraAsignaturasConfiguracion, objAsignaturaID, objModalidadID, Modalidad, Parcial, objParcialID, Cualitativa, Cuantitativa", "vwSraAsignaturasConfiguracion", "objAsignaturaID= " + AsignaturaID.ToString + " and 1=0"))

            grdGradosA.DataSource = dt
            grdGradosA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
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

    Private Sub CargarParcial()
        Try
            'Modalidad
            dtParciales = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='PARCIAL')"))
            Me.cmbParcial.DataSource = dtParciales
            Me.cmbParcial.DisplayMember = "Descripcion"
            Me.cmbParcial.ValueMember = "StbValorCatalogoID"
            Me.cmbParcial.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbParcial.ExtendRightColumn = True
            Me.cmbParcial.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region
#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If txtNombre.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If txtAbreviatura.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtAbreviatura, My.Resources.MsgObligatorio)
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
        CargarGrid()
        txtNombre.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarAsignatura()
                Case 2
                    ActualizarAsignatura()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
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

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
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
                Dim drFilaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtEliminadas.NewRow
                filas("objModalidadID") = CInt(drFilaEliminadas("objModalidadID"))
                filas("Modalidad") = drFilaEliminadas("Modalidad").ToString
                filas("Parcial") = drFilaEliminadas("Parcial").ToString
                filas("objParcialID") = CInt(drFilaEliminadas("objParcialID"))
                filas("Cualitativa") = drFilaEliminadas("Cualitativa").ToString
                filas("Cuantitativa") = drFilaEliminadas("Cuantitativa").ToString

                dtEliminadas.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dt.Rows.Remove(drFilaGradosE)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.txtCodigo.Focus()
            End If
        End If
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        ErrorProv.Clear()
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        ErrorProv.Clear()
    End Sub

    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub

    Private Function ValidarEntradaConfiguracion()

        If Me.cmbModalidad.Text.Trim.Length = 0 Then
            Me.ErrorProv.SetError(Me.cmbModalidad, "Debe seleccionar la modalidad")
            Me.cmbModalidad.Focus()
            Return False
            Exit Function
        End If

        If Me.cmbParcial.Text.Trim.Length = 0 Then
            Me.ErrorProv.SetError(Me.cmbParcial, "Debe seleccionar el parcial")
            Me.cmbParcial.Focus()
            Return False
            Exit Function
        End If


        Return True
    End Function

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim filas As DataRow
        Try
            If ValidarEntradaConfiguracion() Then
                filas = dt.NewRow
                filas("objModalidadID") = cmbModalidad.SelectedValue
                filas("Modalidad") = cmbModalidad.SelectedText
                filas("Parcial") = cmbParcial.SelectedText
                filas("objParcialID") = cmbParcial.SelectedValue
                filas("Cualitativa") = chkCualitativa.Checked
                filas("Cuantitativa") = chkCuantitativa.Checked
                dt.Rows.Add(filas)

                chkCualitativa.Checked = False
                chkCuantitativa.Checked = False
                cmbModalidad.SelectedValue = -1
                cmbParcial.SelectedValue = -1
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtAbreviatura_TextChanged(sender As Object, e As EventArgs) Handles txtAbreviatura.TextChanged
        ErrorProv.Clear()
        boolEditado = True
    End Sub

#End Region




End Class