Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI

Public Class frmSccSalidaCajaCHEdit


#Region "Declaracion de Variables"
    Public intTypeGui, intCajaChicaID As Integer
    Public intSalidaID As Integer
    Public boolEditado As Boolean
    Dim dtCajeros, dtMoneda, dtConcepto, dtCentrosCosto As DataTable
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

    Property SalidaID() As Integer
        Get
            Return intSalidaID
        End Get
        Set(ByVal value As Integer)
            intSalidaID = value
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

    Private Sub CargarConcepto()
        Try
            Me.dtConcepto = New DataTable
            Me.dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTOCAJACHICA")
            With cmbConceptoRecibo
                .DataSource = Me.dtConcepto
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

    Private Sub PROCESAR_RECIBO(ByVal IntIDSalida As Integer, ByVal IntOpcion As Integer)
        Dim T As New TransactionManager
        Dim objCaja As SccCajaChica
        Dim objSalida As SccSalidasCajaChica

        Try
            objCaja = New SccCajaChica
            objSalida = New SccSalidasCajaChica

            T.BeginTran()

            objSalida.Retrieve(IntIDSalida, T)
            objSalida.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objSalida.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objSalida.Disponible = txtDispoible.Text
            objSalida.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOSAL", "PAGADO")
            objSalida.Update(T)

            objCaja.Retrieve(intCajaChicaID)
            objCaja.Disponible = objCaja.Disponible - NumDisponible.Value
            objCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objCaja.Update(T)

            Me.cmdGuardar.Enabled = False

            T.CommitTran()
            MsgBox("El Recibo ha sido Procesado Exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            T = Nothing
            objCaja = Nothing
            objSalida = Nothing
        End Try
    End Sub

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
        Dim objTasaCambio As StbTasaCambioOficial
        Dim objCaja As New SccCajaChica
        Try
            CargarMonedas()
            CargarCajeros()
            CargarConcepto()
            CargarCentrosCosto()
            Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor

            Select Case TypeGui
                Case 1
                    objTasaCambio = New StbTasaCambioOficial
                    Me.Text = "Agregar Salida - Caja chica"
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)
                    txtDispoible.Enabled = False
                    Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOSAL", "REGISTRADO"))
                    objCaja.RetrieveByFilter("Codigo='" & frmPrincipal.gblCajaChica & "'")
                    If Not IsNothing(objCaja.objCajeraID) Then
                        cmbCajero.SelectedValue = objCaja.objCajeraID
                    End If
                    intCajaChicaID = objCaja.SccCajaChicaID

                    If Not IsNothing(objCaja.Disponible) Then
                        txtDispoible.Text = objCaja.Disponible
                    End If

                    If Not IsNothing(objCaja.objMonedaID) Then
                        cmbMoeda.SelectedValue = objCaja.objMonedaID
                    End If

                    If IsNothing(objTasaCambio.Monto) Or objTasaCambio.Monto = 0 Then
                        MsgBox("Defina una tasa de cambio valida.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Else
                        Me.txtTasaCambio.Text = objTasaCambio.Monto
                    End If

                Case 2
                    Me.Text = "Editar Salida - Caja chica"
                    CargarDatosCaja()
                    txtDispoible.Enabled = False
                Case 3
                    Me.Text = "Consultar Salida - Caja chica"
                    CargarDatosCaja()
                    txtDispoible.Enabled = False
                    Me.cmbCajero.Enabled = False
                    Me.NumDisponible.Enabled = False
                    Me.cmbConceptoRecibo.Enabled = False
                    Me.cmbMoeda.Enabled = False
                    Me.NumDisponible.Enabled = False
                    Me.cmbConceptoRecibo.Enabled = False
                    Me.txtBeneficiario.Enabled = False
                    Me.cmbCentroCosto.Enabled = False

            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOSAL'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosCaja()
        Dim objSalida As SccSalidasCajaChica
        Dim objCaja As New SccCajaChica
        Try
            objSalida = New SccSalidasCajaChica
            objSalida.Retrieve(SalidaID)

            objCaja.Retrieve(intCajaChicaID)
            txtDispoible.Text = objCaja.Disponible

            txtBeneficiario.Text = objSalida.Beneficiario
            cmbCentroCosto.SelectedValue = objSalida.objCentroCostoID

            cmbMoeda.SelectedValue = objSalida.objMonedaID
            cmbCajero.SelectedValue = objSalida.objCajeroID
            intCajaChicaID = objSalida.objCajaChicaID
            cmbConceptoRecibo.SelectedValue = objSalida.objConceptoID
            NumDisponible.Value = objSalida.Monto
            txtTasaCambio.Text = objSalida.TasaCambio
            Me.txtEstado.Text = StbValorCatalogo.RetrieveDT("StbValorCatalogoID=" & objSalida.objEstadoID.ToString, , "Descripcion").DefaultView.Item(0)("Descripcion")
            Me.dtpFecha.Value = objSalida.Fecha
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objSalida = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de crear un nuevo registro de Caja
    Public Sub GuardarRSalida()
        Dim objSalida As SccSalidasCajaChica
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objSalida = New SccSalidasCajaChica

            objSalida.objCajaChicaID = intCajaChicaID
            objSalida.Monto = NumDisponible.Value
            objSalida.TasaCambio = txtTasaCambio.Text
            objSalida.Fecha = dtpFecha.Value
            objSalida.objCajeroID = cmbCajero.SelectedValue
            objSalida.objCentroCostoID = cmbCentroCosto.SelectedValue
            objSalida.Beneficiario = txtBeneficiario.Text
            objSalida.Generado = False

            objSalida.objMonedaID = cmbMoeda.SelectedValue
            objSalida.objConceptoID = cmbConceptoRecibo.SelectedValue
            objSalida.Descripcion = txtDescripcion.Text
            objSalida.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOSAL", "REGISTRADO")
            objSalida.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSalida.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSalida.Insert(T)
            Me.intSalidaID = objSalida.SccSalidasCajaChicaID
            T.CommitTran()
            'MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objSalida = Nothing
        End Try
    End Sub

    Public Sub ModificarSalida()
        Dim objSalida As SccSalidasCajaChica
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objSalida = New SccSalidasCajaChica

            objSalida.Retrieve(SalidaID)
            objSalida.objCajaChicaID = intCajaChicaID
            objSalida.Monto = NumDisponible.Value
            objSalida.TasaCambio = txtTasaCambio.Text
            objSalida.Fecha = dtpFecha.Value
            objSalida.objCajeroID = cmbCajero.SelectedValue
            objSalida.objMonedaID = cmbMoeda.SelectedValue
            objSalida.objConceptoID = cmbConceptoRecibo.SelectedValue
            objSalida.Descripcion = txtDescripcion.Text
            objSalida.objCentroCostoID = cmbCentroCosto.SelectedValue
            objSalida.Beneficiario = txtBeneficiario.Text

            objSalida.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objSalida.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objSalida.Update(T)
            Me.intSalidaID = objSalida.SccSalidasCajaChicaID

            T.CommitTran()
            'MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objSalida = Nothing
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
    Public Sub CargarCentrosCosto()
        Try
            dtCentrosCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SconCentroCostoID, Nombre", "ScontCentrosCosto", "Activo=1  "))

            cmbCentroCosto.ValueMember = "SconCentroCostoID"
            cmbCentroCosto.DisplayMember = "Nombre"
            cmbCentroCosto.DataSource = dtCentrosCosto

            cmbCentroCosto.Splits(0).DisplayColumns("SconCentroCostoID").Visible = False

            cmbCentroCosto.ColumnHeaders = False
            cmbCentroCosto.ExtendRightColumn = True
            cmbCentroCosto.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim dtVerificarCodigo As New DataTable
        Try
            If cmbConceptoRecibo.SelectedValue = 0 Then
                ErrorProv.SetError(cmbConceptoRecibo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If NumDisponible.Value = 0 Then
                ErrorProv.SetError(NumDisponible, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If txtBeneficiario.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtBeneficiario, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbCentroCosto.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbCentroCosto, My.Resources.MsgObligatorio)
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
    Private Sub cmbMoeda_TextChanged(sender As Object, e As EventArgs) Handles cmbMoeda.TextChanged
        ErrorProv.SetError(cmbMoeda, "")
        boolEditado = True
    End Sub

    Private Sub NumDisponible_TextChanged(sender As Object, e As EventArgs) Handles NumDisponible.TextChanged
        ErrorProv.SetError(NumDisponible, "")
        boolEditado = True
    End Sub

    Private Sub cmbConceptoRecibo_TextChanged(sender As Object, e As EventArgs) Handles cmbConceptoRecibo.TextChanged
        ErrorProv.SetError(cmbConceptoRecibo, "")
        boolEditado = True
    End Sub

    Private Sub frmSccConfiguracionCajasEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
        Me.boolEditado = False

    End Sub

    Private Sub Imprimir()
        Dim ds As DataSet
        Try
            Dim objjReporte As New RptSccReciboCH()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Concepto, SccSalidasCajaChicaID, Moneda, Monto, Descripcion, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptReciboCH", "SccSalidasCajaChicaID=" & intSalidaID))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarRSalida()

                Case 2
                    ModificarSalida()

            End Select
            Me.PROCESAR_RECIBO(Me.intSalidaID, 0)
            Imprimir()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles txtBeneficiario.TextChanged
        ErrorProv.SetError(txtBeneficiario, "")
        boolEditado = True
    End Sub

    Private Sub cmbCentroCosto_TextChanged(sender As Object, e As EventArgs) Handles cmbCentroCosto.TextChanged
        ErrorProv.SetError(cmbCentroCosto, "")
        boolEditado = True
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


#End Region




End Class