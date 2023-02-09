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

Public Class frmSccDepositosEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intCuentaID, IDDeposito, NumCuenta As Integer
    Shared dtCuentasA, dtMoneda, dtCuentasDatos As DataTable
    Dim strIDCuenta As String
    Dim intArqueoID As Integer
    Dim dblMonto As Decimal

#End Region

#Region "Propiedades"

    Property Monto() As Decimal
        Get
            Return dblMonto
        End Get
        Set(ByVal value As Decimal)
            dblMonto = value
        End Set
    End Property

    Property DepositoID() As Integer
        Get
            Return IDDeposito
        End Get
        Set(ByVal value As Integer)
            IDDeposito = value
        End Set
    End Property

    Property CuentaID() As Integer
        Get
            Return intCuentaID
        End Get
        Set(ByVal value As Integer)
            intCuentaID = value
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

    Property ArqueoID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

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

    Private Sub GuardarDepositos()
        Dim T As New DAL.TransactionManager
        Dim objDepositos As ScontDepositos
        Dim objDepositosDetalle As ScontDepositoDetalle
        Try

            If dtpFechaArqueo.DateTime.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFechaArqueo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtpFecha.Value.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFecha, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtCuentasA.Rows.Count = 0 Then
                MsgBox("Indique los depositos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objDepositos = New ScontDepositos
            objDepositosDetalle = New ScontDepositoDetalle

            T.BeginTran()

            objDepositos.objArqueoID = intArqueoID
            objDepositos.FechaDeposito = dtpFecha.Value
            objDepositos.Descripcion = txtDescripcion.Text
            objDepositos.Activo = True
            objDepositos.Monto = dtCuentasA.Compute("SUM(Monto)", "")
            objDepositos.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objDepositos.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objDepositos.Insert(T)

            IDDeposito = objDepositos.ScontDepositosID

            For Each dr As DataRow In dtCuentasA.Rows
                objDepositosDetalle.objDepositoID = IDDeposito
                objDepositosDetalle.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objDepositosDetalle.Banco = dr("Banco").ToString
                objDepositosDetalle.Voucher = dr("Voucher").ToString
                objDepositosDetalle.Monto = dr("Monto").ToString
                objDepositosDetalle.objMonedaID = dr("objMonedaID").ToString

                objDepositosDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objDepositosDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objDepositosDetalle.Insert(T)
            Next

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub EditarDeposito()
        Dim T As New DAL.TransactionManager
        Dim objDepositos As ScontDepositos
        Dim objDepositosDetalle As ScontDepositoDetalle
        Try

            If dtpFechaArqueo.DateTime.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFechaArqueo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtpFecha.Value.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFecha, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtCuentasA.Rows.Count = 0 Then
                MsgBox("Indique los depositos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objDepositos = New ScontDepositos
            objDepositosDetalle = New ScontDepositoDetalle

            T.BeginTran()

            objDepositos.Retrieve(IDDeposito)

            objDepositos.objArqueoID = intArqueoID
            objDepositos.FechaDeposito = dtpFecha.Value
            objDepositos.Descripcion = txtDescripcion.Text
            objDepositos.Monto = dtCuentasA.Compute("SUM(Monto)", "")
            objDepositos.Activo = True
            objDepositos.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objDepositos.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objDepositos.Update(T)
            IDDeposito = objDepositos.ScontDepositosID

            ScontDepositoDetalle.DeleteByFilter("objDepositoID=" & IDDeposito, T)

            For Each dr As DataRow In dtCuentasA.Rows
                objDepositosDetalle.objDepositoID = IDDeposito
                objDepositosDetalle.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objDepositosDetalle.Banco = dr("Banco").ToString
                objDepositosDetalle.Voucher = dr("Voucher").ToString
                objDepositosDetalle.Monto = dr("Monto").ToString
                objDepositosDetalle.objMonedaID = dr("objMonedaID").ToString

                objDepositosDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objDepositosDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objDepositosDetalle.Insert(T)
            Next

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Public Sub CargarDepositouentaDatos()
        Dim strFiltro As String = ""
        strFiltro = "objDepositoID = " & DepositoID
        Try
            dtCuentasA = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion, objMonedaID, Moneda, Banco, Voucher, Monto", "vwScontDepositoDetalle", strFiltro))
            grdGradosA.DataSource = dtCuentasA
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarDepositoCuentaEsquema()

        Try
            dtCuentasA = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion, objMonedaID, Moneda, Banco, Voucher, Monto", "vwScontDepositoDetalle", "1=0"))
            grdGradosA.DataSource = dtCuentasA
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosEditar()
        Dim objDepositos As New ScontDepositos
        Dim objarqueo As New SccArqueoCaja
        Try

            objDepositos.Retrieve(IDDeposito)

            ''Buscamos la fecha del arqueo asociado
            objarqueo.Retrieve(objDepositos.objArqueoID)
            dtpFechaArqueo.DateTime = objarqueo.Fecha
            dtpFecha.Value = objDepositos.FechaDeposito

            If Not IsNothing(objDepositos.Descripcion) Then
                txtDescripcion.Text = objDepositos.Descripcion
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub BloquearControles()
        Try
            dtpFechaArqueo.Enabled = False
            txtDescripcion.Enabled = False
            dtpFecha.Enabled = False
            cmbMoeda.Enabled = False
            numMonto.Enabled = False
            txtBanco.Enabled = False
            txtCuenta.Enabled = False
            cmdBuscar.Enabled = False
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False
            txtvoucher.Enabled = False
            numMonto.Enabled = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub configurarCantidadMaxima()
        Try
            Me.txtBanco.MaxLength = ScontDepositoDetalle.GetMaxLength("Banco")
            Me.txtvoucher.MaxLength = ScontDepositoDetalle.GetMaxLength("Voucher")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarMonedas()
        Try
            dtMoneda = New DataTable
            dtMoneda = ClsCatalogos.ObtenerValCat("MONEDA")
            With cmbMoeda
                .DataSource = dtMoneda
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

    Private Sub Deshabiliatar()
        Try
            txtCuenta.Enabled = False
            txtDescripcion.Enabled = False
            txtDescripcion.Enabled = False
            dtpFechaArqueo.Enabled = False
            numMonto.Enabled = False
            numMonto.Enabled = False
            cmdBuscar.Enabled = False
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarGrado As New frmScontCuentaContableEdit
        Dim FilaActual As Integer
        Try
            Try
                If FilaActual >= 0 Then
                    EditarGrado.TyGui = 2
                    EditarGrado.CuentaID = intCuentaID
                    EditarGrado.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarGrado = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            configurarCantidadMaxima()
            CargarMonedas()

            Select Case TypeID
                Case 0
                    Me.Text = "Nuevo Deposito"
                    CargarDepositoCuentaEsquema()
                    'Me.dtpFechaArqueo.DateTime = clsProyecto.Conexion.FechaServidor
                Case 1
                    CargarDatosEditar()
                    CargarDepositouentaDatos()


                Case 2
                    CargarDatosEditar()
                    CargarDepositouentaDatos()
                    cmdGuardar.Enabled = False
                    BloquearControles()

            End Select



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub dtpFechaArqueo_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaArqueo.EditValueChanged
        ErrPrv.Clear()
        Dim dtarqueo As DataTable
        Try
            If dtpFechaArqueo.Text.Trim.Length <> 0 Then
                ''Buscar arqueo de caja
                dtarqueo = New DataTable
                dtarqueo = SccArqueoCaja.RetrieveDT("convert(varchar(10), Fecha,112)='" & dtpFechaArqueo.DateTime.ToString("yyyyMMdd") & "'")
                If dtarqueo.Rows.Count > 0 Then
                    numNontoarqueo.Text = dtarqueo.Rows(0)("EntradaEfectivo").ToString()
                    intArqueoID = CInt(dtarqueo.Rows(0)("ArqueoID").ToString())
                Else
                    MsgBox("La fecha seleccionada no tiene arqueo registrado. Seleccione una fecha valdia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    dtpFechaArqueo.Text = String.Empty
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFecha_TextChanged(sender As Object, e As EventArgs) Handles dtpFecha.TextChanged
        ErrPrv.Clear()
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs)
        ErrPrv.Clear()
    End Sub

    Private Sub MemoEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtDescripcion.EditValueChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmbMoeda_VisibleChanged(sender As Object, e As EventArgs) Handles cmbMoeda.VisibleChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim objMes As New ScontMesCerrado

        Try
            Select Case TypeID
                Case 0
                    GuardarDepositos()
                Case 1
                    EditarDeposito()

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        ErrPrv.SetError(txtCuenta, "")
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try

            If cmbMoeda.Text.Trim.Length = 0 Then
                MsgBox("Indique la moneda.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If Me.txtCuenta.Text.Trim.Length = 0 Then
                MsgBox("Debe seleccionar la cuenta contable.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If Me.txtBanco.Text.Trim.Length = 0 Then
                MsgBox("Debe indicar el banco.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If Me.txtvoucher.Text.Trim.Length = 0 Then
                MsgBox("Debe inidicar el numero de Voucher.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If Me.numMonto.Value = 0 Then
                MsgBox("Indique el monto depositado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If


            Dim filas As DataRow
            filas = dtCuentasA.NewRow
            filas("SContCuentasContablesID") = CuentaID
            filas("IDCuenta") = strIDCuenta
            filas("Descripcion") = txtCuenta.Text
            filas("Moneda") = cmbMoeda.Text
            filas("objMonedaID") = cmbMoeda.SelectedValue

            filas("Banco") = txtBanco.Text
            filas("Voucher") = txtvoucher.Text
            filas("Monto") = numMonto.Value

            dtCuentasA.Rows.Add(filas)
            cmbMoeda.Text = String.Empty
            txtvoucher.Text = String.Empty
            txtBanco.Text = String.Empty
            txtCuenta.Text = String.Empty
            CuentaID = 0
            numMonto.Value = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrados_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdGradosATable.SelectedRowsCount() - 1
                If (grdGradosATable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdGradosATable.GetDataRow(grdGradosATable.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dtCuentasA.Rows.Remove(drFilaGradosE)
            Next

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