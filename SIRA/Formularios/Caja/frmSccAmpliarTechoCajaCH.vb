Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccAmpliarTechoCajaCH


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
    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            CargarMonedas()
            Select Case TypeGui
                Case 1
                    Me.Text = "Ampliar techo de Caja chica"
                    CargarDatosCaja()
                    cmbMoeda.Enabled = False
                    txtCodigo.Enabled = False

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
            NumDisponible.Value = objCajas.Disponible

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objCajas = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de Caja
    Public Sub GuardarTecho()
        Dim objampliar As SccAmpliarTecho
        Dim objCajas As SccCajaChica
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objampliar = New SccAmpliarTecho
            objCajas = New SccCajaChica

            objampliar.objCajaCHID = CajaID
            objampliar.Techo = NumTecho.Value
            objampliar.Justificacion = txtJustificacion.Text
            objampliar.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objampliar.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objampliar.Insert(T)

            objCajas.Retrieve(CajaID, T)
            objCajas.Disponible = objampliar.Techo
            objCajas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objCajas.FechaModificacion = clsProyecto.Conexion.FechaServidor
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
            If NumTecho.Value = 0 Then
                ErrorProv.SetError(NumTecho, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


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


    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarTecho()
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