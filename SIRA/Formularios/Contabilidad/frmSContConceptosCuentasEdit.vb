Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI

Public Class frmSContConceptosCuentasEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, IDconceptoCuenta, CuentaID, ContraCuentaID As Integer
    Shared dtCuentasDatos, dtContraCuentasDatos, dtConcepto, dtCentroCosto As DataTable
    Dim strIDCuenta, strIDContraCuenta As String

#End Region

#Region "Propiedades"

    Property ConceptoCuentaID() As Integer
        Get
            Return IDconceptoCuenta
        End Get
        Set(ByVal value As Integer)
            IDconceptoCuenta = value
        End Set
    End Property

    Property TypeID() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

#End Region

#Region "Procedimientos"
    Private Sub CargarDatosEditar()
        Dim objConceptoCuentas As New SContConceptosCuentas

        Try
            objConceptoCuentas.Retrieve(IDconceptoCuenta)

            If objConceptoCuentas.TipoConcepto = "ReciboCajaGeneral" Then
                rbRecibosCaja.Checked = True
            Else
                rbRecibosCaja.Checked = False
            End If

            cmbConcepto.SelectedValue = objConceptoCuentas.objConceptoID
            cmbCentroCosto.SelectedValue = objConceptoCuentas.objCentroCostoID
            CuentaID = objConceptoCuentas.objCuentaContableID
            ContraCuentaID = objConceptoCuentas.objContraCuentaID
            CargarCuenta()
            CargarContraCuenta()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub BloquearControles()
        Try
            cmbConcepto.Enabled = False
            txtCuenta.Enabled = False
            txtContraCuenta.Enabled = False
            cmbCentroCosto.Enabled = False

            cmdBuscar.Enabled = False
            cmdBuscarContracuenta.Enabled = False
            cmdGuardar.Enabled = False
            cmdCancelar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarConceptosCajaChica()
        Try
            dtConcepto = New DataTable

            dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTOCAJACHICA")

            With cmbConcepto
                .DataSource = dtConcepto
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

    Private Sub CargarConceptos()
        Try
            dtConcepto = New DataTable

            dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTORECIBO")
            With cmbConcepto
                .DataSource = dtConcepto
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

    Public Sub CargarCentrosCosto()
        Try
            dtCentroCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SconCentroCostoID, Nombre", "ScontCentrosCosto", "Activo=1  "))

            cmbCentroCosto.ValueMember = "SconCentroCostoID"
            cmbCentroCosto.DisplayMember = "Nombre"
            cmbCentroCosto.DataSource = dtCentroCosto

            cmbCentroCosto.Splits(0).DisplayColumns("SconCentroCostoID").Visible = False

            cmbCentroCosto.ColumnHeaders = False
            cmbCentroCosto.ExtendRightColumn = True
            cmbCentroCosto.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Deshabiliatar()
        Try
            cmbConcepto.Enabled = False
            txtCuenta.Enabled = False
            txtContraCuenta.Enabled = False
            cmbCentroCosto.Enabled = False

            cmdBuscar.Enabled = False
            cmdBuscarContracuenta.Enabled = False
            cmdGuardar.Enabled = False
            cmdCancelar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarRelacion()
        Dim T As New DAL.TransactionManager
        Dim objConceptoCuenta As SContConceptosCuentas
        Dim objverificar As New SContConceptosCuentas
        Try

            If cmbConcepto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbConcepto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbCentroCosto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbCentroCosto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtCuenta.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtContraCuenta.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtContraCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            ''Validar si ya existe esta relacion
            objverificar.RetrieveByFilter("Activa= 1 AND objConceptoID=" & cmbConcepto.SelectedValue)

            If objverificar.SContConceptosCuentasID <> 0 Then
                MsgBox("No es posible registrar esta asociación, el concepto seleccionado ya tiene asociada una cuenta contable.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objConceptoCuenta = New SContConceptosCuentas

            T.BeginTran()
            If rbRecibosCaja.Checked Then
                objConceptoCuenta.TipoConcepto = "ReciboCajaGeneral"
            Else
                objConceptoCuenta.TipoConcepto = "ReciboCajaChica"
            End If
            objConceptoCuenta.objConceptoID = cmbConcepto.SelectedValue
            objConceptoCuenta.objCuentaContableID = CuentaID
            objConceptoCuenta.objCentroCostoID = cmbCentroCosto.SelectedValue
            objConceptoCuenta.objContraCuentaID = ContraCuentaID
            objConceptoCuenta.Activa = True
            objConceptoCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objConceptoCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objConceptoCuenta.Insert(T)
            IDconceptoCuenta = objConceptoCuenta.SContConceptosCuentasID
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objverificar = Nothing
            objConceptoCuenta = Nothing
        End Try
    End Sub

    Private Sub EditarRelacion()
        Dim T As New DAL.TransactionManager
        Dim objConceptoCuenta As SContConceptosCuentas
        Dim objverificar As New SContConceptosCuentas
        Try

            If cmbConcepto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbConcepto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbCentroCosto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbCentroCosto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtCuenta.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtContraCuenta.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtContraCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            ''Validar si ya existe esta relacion
            objverificar.RetrieveByFilter("Activa= 1 AND objConceptoID=" & cmbConcepto.SelectedValue)

            If objverificar.SContConceptosCuentasID <> IDconceptoCuenta Then
                MsgBox("No es posible registrar esta asociación, el concepto seleccionado ya tiene asociada una cuenta contable.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objConceptoCuenta = New SContConceptosCuentas
            T.BeginTran()

            objConceptoCuenta.Retrieve(IDconceptoCuenta)
            If rbRecibosCaja.Checked Then
                objConceptoCuenta.TipoConcepto = "ReciboCajaGeneral"
            Else
                objConceptoCuenta.TipoConcepto = "ReciboCajaChica"
            End If
            objConceptoCuenta.objConceptoID = cmbConcepto.SelectedValue
            objConceptoCuenta.objCuentaContableID = CuentaID
            objConceptoCuenta.objCentroCostoID = cmbCentroCosto.SelectedValue
            objConceptoCuenta.objContraCuentaID = ContraCuentaID
            objConceptoCuenta.Activa = True
            objConceptoCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objConceptoCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objConceptoCuenta.Update(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objverificar = Nothing
            objConceptoCuenta = Nothing
        End Try
    End Sub

    Public Sub CargarCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & CuentaID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))

            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtCuenta.Text = dtCuentasDatos.Rows(0)("Descripcion")
                strIDCuenta = dtCuentasDatos.Rows(0)("IDCuenta").ToString
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarContraCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & ContraCuentaID & "'"

            dtContraCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))

            If dtContraCuentasDatos.Rows.Count > 0 Then
                Me.txtContraCuenta.Text = dtContraCuentasDatos.Rows(0)("Descripcion")
                strIDContraCuenta = dtContraCuentasDatos.Rows(0)("IDCuenta").ToString
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub rbRecibosCaja_CheckedChanged(sender As Object, e As EventArgs) Handles rbRecibosCaja.CheckedChanged
        Try
            If rbRecibosCaja.Checked Then
                CargarConceptos()
            Else
                CargarConceptosCajaChica()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Eventos del formulario"
    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargarCentrosCosto()
            rbRecibosCaja.Checked = True

            Select Case TypeID
                Case 0
                    Me.Text = "Nueva relacion concepto / cuenta"
                Case 1
                    CargarDatosEditar()
                Case 2
                    CargarDatosEditar()
                    cmdGuardar.Enabled = False
                    BloquearControles()
            End Select



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmbMoeda_VisibleChanged(sender As Object, e As EventArgs) Handles cmbConcepto.VisibleChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmdBuscarContracuenta_Click(sender As Object, e As EventArgs) Handles cmdBuscarContracuenta.Click
        Try
            Dim objSeleccion As New frmScontCuentaSelector

            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                ContraCuentaID = objSeleccion.Seleccion
                CargarContraCuenta()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbConcepto_TextChanged(sender As Object, e As EventArgs) Handles cmbConcepto.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            Select Case TypeID
                Case 0
                    GuardarRelacion()
                Case 1
                    EditarRelacion()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            Dim objSeleccion As New frmScontCuentaSelector

            objSeleccion.Opcion = 3

            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CuentaID = objSeleccion.Seleccion
                CargarCuenta()

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region



End Class