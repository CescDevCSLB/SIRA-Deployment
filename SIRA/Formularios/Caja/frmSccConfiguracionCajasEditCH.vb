Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccConfiguracionCajasEditCH


#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intCajaID As Integer
    Public boolEditado As Boolean
    Dim dtCajeros, dtMoneda As DataTable
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

    Property CajaID() As Integer
        Get
            Return intCajaID
        End Get
        Set(ByVal value As Integer)
            intCajaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"
    Private Sub CargarMonedas()
        Try
            Me.dtMoneda = New DataTable
            Me.dtMoneda = ClsCatalogos.ObtenerValCat("MONEDA")
            With cmbMoeda
                .DataSource = Me.dtMoneda
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajeros()
        Try
            dtCajeros = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbEmpleadoID,NombreCompleto,StbPersonaID", "vwStbEmpleados", "CodigoCargo= '03' AND Activo =1"))

            cmbCajero.DataSource = dtCajeros
            cmbCajero.ValueMember = "StbEmpleadoID"
            cmbCajero.DisplayMember = "NombreCompleto"
            cmbCajero.Splits(0).DisplayColumns("StbEmpleadoID").Visible = False
            cmbCajero.Splits(0).DisplayColumns("StbPersonaID").Visible = False
            cmbCajero.ColumnHeaders = False
            cmbCajero.ExtendRightColumn = True
            cmbCajero.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            CargarCajeros()
            CargarMonedas()
            Select Case TypeGui
                Case 0
                    Me.Text = "Agregar Caja"
                    chkActivo.Checked = True
                    chkActivo.Enabled = False
                Case 1
                    Me.Text = "Editar Caja"
                    CargarDatosCaja()
                    cmbMoeda.Enabled = False
                    chkActivo.Enabled = True
                    NumDisponible.Enabled = False
                Case 2
                    Me.Text = "Consultar Caja"
                    CargarDatosCaja()
                    txtCodigo.Enabled = False
                    cmbCajero.Enabled = False
                    chkActivo.Enabled = False
                    cmdGuardar.Enabled = False
                    cmbMoeda.Enabled = False
                    NumDisponible.Enabled = False
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosCaja()
        Dim objCajas As SccCajaChica
        Try
            objCajas = New SccCajaChica
            objCajas.Retrieve(CajaID)
            txtCodigo.Text = objCajas.Codigo
            cmbMoeda.SelectedValue = objCajas.objMonedaID

            If Not IsNothing(objCajas.objCajeraID) Then
                cmbCajero.SelectedValue = objCajas.objCajeraID
            End If
            NumDisponible.Value = objCajas.Disponible

            chkActivo.Checked = objCajas.Activa
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objCajas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de Caja
    Public Sub GuardarCaja()
        Dim objCajas As SccCajaChica
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objCajas = New SccCajaChica
            objCajas.objMonedaID = cmbMoeda.SelectedValue
            objCajas.objCajeraID = cmbCajero.SelectedValue
            objCajas.FechaApertura = clsProyecto.Conexion.FechaServidor
            objCajas.Activa = chkActivo.Checked
            objCajas.Disponible = NumDisponible.Value
            objCajas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objCajas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objCajas.Insert()
            CajaID = objCajas.SccCajaChicaID

            objCajas.Retrieve(CajaID, T)
            objCajas.Codigo = "CH-" & CajaID
            objCajas.Update(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCajas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de editar la informacion de una Caja
    Public Sub EditarCaja()
        Dim objCajas As SccCajaChica
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objCajas = New SccCajaChica
            objCajas.Retrieve(CajaID)
            objCajas.objMonedaID = cmbMoeda.SelectedValue
            objCajas.objCajeraID = cmbCajero.SelectedValue
            objCajas.Codigo = txtCodigo.Text.Trim
            objCajas.Activa = chkActivo.Checked
            objCajas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objCajas.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objCajas.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCajas = Nothing
        End Try
    End Sub


#Region "Consutar Cajero"
    Public Sub ConsultarCajero()
        'Dim editEmpleado As frmSrhEmpleadoEditar
        'Dim objEmpleado As New SrhEmpleado
        'Try
        '    Me.Cursor = WaitCursor
        '    editEmpleado = New frmSrhEmpleadoEditar
        '    editEmpleado.TypeGUI = 2
        '    editEmpleado.EmpleadoID = Me.cmbCajero.SelectedValue
        '    objEmpleado.Retrieve(Me.cmbCajero.SelectedValue)
        '    editEmpleado.PersonaID = objEmpleado.objPersonaID
        '    editEmpleado.Text = "Consultar Empleado"
        '    editEmpleado.ShowDialog(Me)
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally
        '    Me.Cursor = [Default]
        'End Try
    End Sub
#End Region

#End Region

#Region "Funciones"

    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim dtVerificarCodigo As New DataTable
        Try
            If cmbMoeda.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbMoeda, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbCajero.Text.Trim.Length = 0 Or IsNothing(cmbCajero.SelectedValue) Then
                ErrorProv.SetError(cmbCajero, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            ''Validar que no existe una bodega con el mismo codigo           

            Select Case TypeGui
                Case 0
                    dtVerificarCodigo = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Codigo", "SccCajas", "Activa =1 and Ltrim(Rtrim(Codigo))='" & txtCodigo.Text.Trim & "'"))

                    If dtVerificarCodigo.Rows.Count > 0 Then
                        ErrorProv.SetError(cmbCajero, "El Código de caja ya existe. Registre uno diferente.")
                        Return False
                    End If
                Case 1
                    dtVerificarCodigo = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Codigo", "SccCajas", "Activa =1 and Ltrim(Rtrim(Codigo))='" & txtCodigo.Text.Trim & "' and SccCajaID<>" & CajaID))

                    If dtVerificarCodigo.Rows.Count > 0 Then
                        ErrorProv.SetError(txtCodigo, "El Código de caja ya existe. Registre uno diferente.")
                        Return False
                    End If
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True

    End Function
#End Region

#Region "Eventos del formulario"

    Private Sub frmSccConfiguracionCajasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
        Me.boolEditado = False
    End Sub


    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs) Handles cmbCajero.TextChanged
        ErrorProv.SetError(cmbCajero, "")
        boolEditado = True
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 0
                    GuardarCaja()
                Case 1
                    EditarCaja()
            End Select

        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub frmSccConfiguracionCajasEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub
    Private Sub cmbMoeda_TextChanged(sender As Object, e As EventArgs) Handles cmbMoeda.TextChanged
        ErrorProv.SetError(cmbMoeda, "")
        boolEditado = True
    End Sub

#End Region


End Class