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

Public Class frmScontChequesEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intCuentaID, IDCheque, NumCuenta, DonanteID, intmonedaDolar, intmonedacor, intEstadoRegistrado, intContabilizado As Integer
    Shared dtCuentasA, dtCuentasDatos, dtDonanteDatos, DtTipoAsiento, dtMoneda, dtBancos As DataTable
    Dim strIDCuenta As String
    Dim intPeriodo As Integer
    Dim dblMonto As Decimal
    Dim objTasaCambio As StbTasaCambioOficial
    Dim intAcreeedora, intDeudora As Integer
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

    Property ChqeueID() As Integer
        Get
            Return IDCheque
        End Get
        Set(ByVal value As Integer)
            IDCheque = value
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

    Property PeriodoID() As Integer
        Get
            Return intPeriodo
        End Get
        Set(ByVal value As Integer)
            intPeriodo = value
        End Set
    End Property

#End Region

    Public Sub CargarChequeCuentaDatos()
        Dim strFiltro As String = ""
        strFiltro = "objSContChequeID = " & ChqeueID
        Try
            dtCuentasA = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objSContChequeID, SContCuentasContablesID, MontoAcreditar, MontoDebitar, IDCuenta, Descripcion, Centro, SconCentroCostoID", "vwScontChequeDetalleCuenta", strFiltro))
            grdGradosA.DataSource = dtCuentasA
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarChequeCuentaEsquema()

        Try
            dtCuentasA = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objSContChequeID, SContCuentasContablesID, MontoAcreditar, MontoDebitar, IDCuenta, Descripcion, Centro, SconCentroCostoID", "vwScontChequeDetalleCuenta", "1=0"))
            grdGradosA.DataSource = dtCuentasA
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosEditar()
        Dim objCheques As New ScontCheque

        Try
            objCheques.Retrieve(IDCheque)
            txtNumCheque.Text = objCheques.NumCheque
            dtpFecha.Value = objCheques.Fecha
            txtConcepto.Text = objCheques.Concepto
            txtBeneficiario.Text = objCheques.Beneficiario
            cmbMoeda.SelectedValue = objCheques.objMonedaID

            If cmbMoeda.SelectedValue = intmonedacor Then
                NumMonto.Value = objCheques.ValorCordobas
            Else
                NumMonto.Value = objCheques.ValorDolares
            End If

            txtTasaCambio.Text = objCheques.TasaCambio
            txtObservaciones.Text = objCheques.Notas
            Me.txtEstado.Text = StbValorCatalogo.RetrieveDT("StbValorCatalogoID=" & objCheques.objEstadoChequeID.ToString, , "Descripcion").DefaultView.Item(0)("Descripcion")


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub BloquearControles()
        Try
            dtpFecha.Enabled = False
            txtConcepto.Enabled = False
            txtEstado.Enabled = False
            txtBeneficiario.Enabled = False
            cmbMoeda.Enabled = False

            NumMonto.Enabled = False
            chkCentro.Enabled = False
            txtCuenta.Enabled = False
            cmdBuscar.Enabled = False
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False
            numAcreditar.Enabled = False
            numDebitar.Enabled = False
            txtObservaciones.Enabled = False

        Catch ex As Exception

        End Try
    End Sub
    Private Sub configurarCantidadMaxima()
        Try
            Me.txtNumCheque.MaxLength = ScontCheque.GetMaxLength("NumCheque")
            Me.txtBeneficiario.MaxLength = ScontCheque.GetMaxLength("Beneficiario")
            'Me.txtConcepto.MaxLength = ScontCheque.GetMaxLength("Concepto")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            configurarCantidadMaxima()
            intmonedaDolar = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "USD")
            intmonedacor = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "COR")
            intEstadoRegistrado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "01")
            intContabilizado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "02")

            intAcreeedora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "01")
            intDeudora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "02")

            CargarMonedas()
            CargarCentroCosto()

            Select Case TypeID
                Case 0
                    cmdProcesar.Enabled = False
                    objTasaCambio = New StbTasaCambioOficial
                    Me.Text = "Nuevo cheque"
                    Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "01"))
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)
                    Me.txtTasaCambio.Text = objTasaCambio.Monto
                    CargarChequeCuentaEsquema()
                    txtNumCheque.Text = GeneraraNumeroInicial()

                Case 1
                    CargarDatosEditar()
                    CargarChequeCuentaDatos()
                    calcularTotales()
                    cmdProcesar.Enabled = False

                Case 2
                    CargarDatosEditar()
                    CargarChequeCuentaDatos()
                    calcularTotales()
                    cmdProcesar.Enabled = False
                    cmdGuardar.Enabled = False
                    BloquearControles()
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOCHEQUE'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    Public Sub CargarCentroCosto()
        Try
            dtBancos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SconCentroCostoID, Nombre", "ScontCentrosCosto", "Activo=1  "))

            cmbCentroCosto.ValueMember = "SconCentroCostoID"
            cmbCentroCosto.DisplayMember = "Nombre"
            cmbCentroCosto.DataSource = dtBancos

            cmbCentroCosto.Splits(0).DisplayColumns("SconCentroCostoID").Visible = False

            cmbCentroCosto.ColumnHeaders = False
            cmbCentroCosto.ExtendRightColumn = True
            cmbCentroCosto.SelectedIndex = -1


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
            cmbMoeda.SelectedValue = intmonedacor
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Deshabiliatar()
        Try
            txtCuenta.Enabled = False
            txtObservaciones.Enabled = False
            txtConcepto.Enabled = False
            dtpFecha.Enabled = False
            numAcreditar.Enabled = False
            numDebitar.Enabled = False
            cmdBuscar.Enabled = False
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkBanco_CheckedChanged(sender As Object, e As EventArgs) Handles chkCentro.CheckedChanged
        If chkCentro.Checked Then
            Me.cmbCentroCosto.Enabled = True
        Else
            Me.cmbCentroCosto.Text = String.Empty
            Me.cmbCentroCosto.Enabled = False

        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs)
        ErrPrv.Clear()
    End Sub
    Private Sub Contabilizar()

        Dim T As New TransactionManager
        Dim parametro(3) As SqlClient.SqlParameter
        Dim objMes As New ScontMesCerrado
        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Dim Fecha As DateTime
        Dim dtValidar As DataTable

        Try
            Fecha = dtpFecha.Value
            ''Buscar si alguna de las cuentas registradas tiene un nivel distinto al 0
            dtValidar = New DataTable

            dtValidar = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta", "vwSContCuentasContables", "Nivel<>4 and SContCuentasContablesID in (select SContContablesID from SContComprobanteDetalle d where objSContCompronanteID= " & CuentaID & " )"))
            If dtValidar.Rows.Count > 0 Then
                MsgBox("Una de las cuentas registradas pertenece a un nivel distinto al 4, no es posible contabilizar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            ''Verificar que exista el periodo

            objperiodo.RetrieveByFilter("Activo=1 AND Periodo=" & Fecha.Year)
            If objperiodo.SContPeriodoID = 0 Then
                MsgBox("No es posible contabilizar movimientos en un periodo que no esta registrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objperiodo = New SContPeriodos
            ''Si el mes es enero y existe un periodo anterior, verificar que el anio anterior este cerrado.
            If Fecha.Month = 1 Then
                objperiodo.RetrieveByFilter("Activo=1 AND Cerrado=1 and Periodo=" & Fecha.Year - 1)
                If objperiodo.SContPeriodoID = 0 Then
                    MsgBox("No es posible contabilizar movimientos en este mes, ya que el periodo anterior no esta cerrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            End If

            ''Verificar que la fecha del comprobante coincida con el mes que esta abierto
            objMes.RetrieveByFilter("objPeriodoID =" & intPeriodo & " AND Cerrado=0  ORDER BY Mes asc")

                If objMes.ScontMesCerradoID <> 0 Then
                    If objMes.Mes < Fecha.Month Then
                        MsgBox("No es posible contabilizar movimientos en un mes superior al que se encuentra abierto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                End If

                parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
                parametro(0).Value = intPeriodo

                parametro(1) = New SqlClient.SqlParameter("@IDCheque ", SqlDbType.Int, 4)
                parametro(1).Value = IDCheque

                parametro(2) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
                parametro(2).Value = clsProyecto.Conexion.Usuario

                T.BeginTran()

                SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_ActualizarSaldoInicialCheque", parametro)
                SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_ContabilizarCheque", parametro)

                T.CommitTran()

                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.DialogResult = Windows.Forms.DialogResult.OK



        Catch ex As Exception

            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            parametro = Nothing
            dtValidar = Nothing
        End Try
    End Sub

    Private Sub MemoEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtConcepto.EditValueChanged
        ErrPrv.Clear()
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

    Private Sub AgregarNuevaCuenta()
        Dim editcuenta As frmScontCuentaContableEdit
        Try
            Me.Cursor = WaitCursor
            editcuenta = New frmScontCuentaContableEdit

            If cmbCentroCosto.Text.Trim.Length > 0 Then
                editcuenta.CentroCostoID = cmbCentroCosto.SelectedValue
                editcuenta.TyGui = 4
            Else
                editcuenta.TyGui = 1
            End If

            If editcuenta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                intCuentaID = editcuenta.CuentaID
                CargarCuenta()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCuentaContableAdd_Click(sender As Object, e As EventArgs) Handles cmdCuentaContableAdd.Click
        Try
            If intCuentaID <> 0 Then
                Editar()
                CargarCuenta()
            Else
                AgregarNuevaCuenta()

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdProcesar_Click(sender As Object, e As EventArgs) Handles cmdProcesar.Click
        Contabilizar()

    End Sub

    Private Sub txtBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles txtBeneficiario.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmbMoeda_VisibleChanged(sender As Object, e As EventArgs) Handles cmbMoeda.VisibleChanged
        ErrPrv.Clear()
    End Sub

    Private Function GeneraraNumero(t As TransactionManager) As String
        Dim strNum As String
        Dim dtNum As New DataTable
        Dim dtValParam As New DataTable
        Dim intNCeros As Integer
        Dim intNumero As Integer
        strNum = ""
        Try

            dtValParam = StbParametro.RetrieveDT("Nombre = 'CerosRellenoNumCheque'", , "Valor", t)
            If dtValParam.DefaultView.Count > 0 Then
                intNCeros = dtValParam.DefaultView.Item(0)("Valor")
            End If

            dtNum = StbParametro.RetrieveDT("Nombre = 'ConsecutivoNumCheque'", , "Valor", t)

            If dtNum.DefaultView.Count > 0 Then
                intNumero = dtNum.DefaultView.Item(0)("Valor")
            End If

            If intNumero = 0 Then
                For Cant As Integer = 1 To intNCeros - 1
                    strNum = strNum + "0"
                Next
                strNum = strNum + "1"
            Else
                intNumero = intNumero + 1
                intNCeros = intNCeros - intNumero.ToString.Length
                For Cant As Integer = 1 To intNCeros
                    strNum = strNum + "0"
                Next
                strNum = strNum + intNumero.ToString
            End If
            Return strNum
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtNum = Nothing
            dtValParam = Nothing
        End Try
        Return strNum
    End Function

    Private Function GeneraraNumeroInicial() As String
        Dim strNum As String
        Dim dtNum As New DataTable
        Dim dtValParam As New DataTable
        Dim intNCeros As Integer
        Dim intNumero As Integer
        strNum = ""
        Try

            dtValParam = StbParametro.RetrieveDT("Nombre = 'CerosRellenoNumCheque'", , "Valor")
            If dtValParam.DefaultView.Count > 0 Then
                intNCeros = dtValParam.DefaultView.Item(0)("Valor")
            End If

            dtNum = StbParametro.RetrieveDT("Nombre = 'ConsecutivoNumCheque'", , "Valor")

            If dtNum.DefaultView.Count > 0 Then
                intNumero = dtNum.DefaultView.Item(0)("Valor")
            End If

            If intNumero = 0 Then
                For Cant As Integer = 1 To intNCeros - 1
                    strNum = strNum + "0"
                Next
                strNum = strNum + "1"
            Else
                intNumero = intNumero + 1
                intNCeros = intNCeros - intNumero.ToString.Length
                For Cant As Integer = 1 To intNCeros
                    strNum = strNum + "0"
                Next
                strNum = strNum + intNumero.ToString
            End If
            Return strNum
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtNum = Nothing
            dtValParam = Nothing
        End Try
        Return strNum
    End Function

    Private Sub GuardarCheque()
        Dim T As New DAL.TransactionManager
        Dim objScontComprobanteID, objScontComprobanteIDUP As ScontCheque
        Dim objSContComprobanteDetalle As SContChequeDetalle
        Dim objPeriodo As SContPeriodos
        Dim strNumcheque As String
        Dim objNaturaleza As SContCuentasContables
        Try

            If dtpFecha.Value.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFecha, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtConcepto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtConcepto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtBeneficiario.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtBeneficiario, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtCuentasA.Rows.Count = 0 Then
                MsgBox("Indique las cuentas contables.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If cmbMoeda.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbMoeda, My.Resources.MsgObligatorio)
                Exit Sub
            End If


            If numTotal.Value <> 0 Then
                MsgBox("Los monton no coinciden.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Exit Sub
            End If

            objScontComprobanteID = New ScontCheque
            objScontComprobanteIDUP = New ScontCheque
            objSContComprobanteDetalle = New SContChequeDetalle
            objPeriodo = New SContPeriodos

            T.BeginTran()

            strNumcheque = GeneraraNumero(T)

            objScontComprobanteID.Fecha = dtpFecha.Value
            objScontComprobanteID.Concepto = txtConcepto.Text
            txtNumCheque.Text = strNumcheque
            objScontComprobanteID.NumCheque = strNumcheque
            objScontComprobanteID.Activo = 1
            objScontComprobanteID.Beneficiario = txtBeneficiario.Text
            objScontComprobanteID.objEstadoChequeID = intEstadoRegistrado

            ''Buscamos el periodo segun la fecha seleccionada
            objPeriodo.RetrieveByFilter(" Activo=1 and Cerrado=0 and Periodo=" & Year(dtpFecha.Value), T)

            If (objPeriodo.SContPeriodoID = 0) Then
                MsgBox("No hay un periodo registrado para la fecha seleccionada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                T.RollbackTran()
                Exit Sub
            End If

            objScontComprobanteID.objPeriodoID = objPeriodo.SContPeriodoID
            objScontComprobanteID.Notas = txtObservaciones.Text
            objScontComprobanteID.objMonedaID = cmbMoeda.SelectedValue
            objScontComprobanteID.TasaCambio = txtTasaCambio.Text

            If cmbMoeda.SelectedValue = intmonedacor Then
                objScontComprobanteID.ValorCordobas = NumMonto.Value
                objScontComprobanteID.ValorDolares = NumMonto.Value / CDec(txtTasaCambio.Text)
            Else
                objScontComprobanteID.ValorDolares = NumMonto.Value
                objScontComprobanteID.ValorCordobas = NumMonto.Value * CDec(txtTasaCambio.Text)
            End If

            objScontComprobanteID.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objScontComprobanteID.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objScontComprobanteID.Insert(T)
            IDCheque = objScontComprobanteID.ScontChequeID

            For Each dr As DataRow In dtCuentasA.Rows
                objSContComprobanteDetalle.objSContChequeID = IDCheque
                objSContComprobanteDetalle.SContCuentaContablesID = dr("SContCuentasContablesID").ToString
                objSContComprobanteDetalle.MontoAcreditar = dr("MontoAcreditar").ToString

                ''Buscar la naturaleza de la cuenta
                objNaturaleza = New SContCuentasContables
                objNaturaleza.Retrieve(dr("SContCuentasContablesID").ToString, T)

                If objNaturaleza.objNaturalezaID = intDeudora Then
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
                Else
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
                End If

                objSContComprobanteDetalle.objCentroCostoID = CInt(dr("SconCentroCostoID").ToString)

                objSContComprobanteDetalle.MontoDebitar = dr("MontoDebitar").ToString
                objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSContComprobanteDetalle.Insert(T)
            Next
            objScontComprobanteIDUP.NumCheque = txtNumCheque.Text

            ''Actualizar consecutivo
            Dim objParametro = New StbParametro
            objParametro.RetrieveByFilter("Nombre='ConsecutivoNumCheque'", T)
            objParametro.Valor = CInt(strNumcheque)
            objParametro.Update(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            TypeID = 1
            cmdProcesar.Enabled = True
            Imprimir()
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub EditarCheque()
        Dim T As New DAL.TransactionManager
        Dim objScontComprobanteID, objScontComprobanteIDUP As ScontCheque
        Dim objSContComprobanteDetalle As SContChequeDetalle
        Dim objNaturaleza As SContCuentasContables
        Dim objPeriodo As SContPeriodos
        Try

            If dtpFecha.Value.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(dtpFecha, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtConcepto.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtConcepto, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtBeneficiario.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(txtBeneficiario, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If dtCuentasA.Rows.Count = 0 Then
                MsgBox("Indique las cuentas contables.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            If cmbMoeda.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbMoeda, My.Resources.MsgObligatorio)
                Exit Sub
            End If


            If numTotal.Value <> 0 Then
                MsgBox("Los monton no coinciden.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Exit Sub
            End If

            objScontComprobanteID = New ScontCheque
            objScontComprobanteIDUP = New ScontCheque
            objSContComprobanteDetalle = New SContChequeDetalle
            objPeriodo = New SContPeriodos

            T.BeginTran()

            objScontComprobanteID.Retrieve(IDCheque)

            objScontComprobanteID.Fecha = dtpFecha.Value
            objScontComprobanteID.Concepto = txtConcepto.Text
            objScontComprobanteID.NumCheque = txtNumCheque.Text
            objScontComprobanteID.Activo = 1
            objScontComprobanteID.Beneficiario = txtBeneficiario.Text
            objScontComprobanteID.objEstadoChequeID = intEstadoRegistrado

            ''Buscamos el periodo segun la fecha seleccionada
            objPeriodo.RetrieveByFilter(" Activo=1 and Cerrado=0 and Periodo=" & Year(dtpFecha.Value), T)

            If (objPeriodo.SContPeriodoID = 0) Then
                MsgBox("No hay un periodo registrado para la fecha seleccionada.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                T.RollbackTran()
                Exit Sub
            End If

            objScontComprobanteID.objPeriodoID = objPeriodo.SContPeriodoID

            objScontComprobanteID.Notas = txtObservaciones.Text
            objScontComprobanteID.objMonedaID = cmbMoeda.SelectedValue

            If cmbMoeda.SelectedValue = intmonedacor Then
                objScontComprobanteID.ValorCordobas = NumMonto.Value
                objScontComprobanteID.ValorDolares = NumMonto.Value / CDec(txtTasaCambio.Text)
            Else
                objScontComprobanteID.ValorDolares = NumMonto.Value
                objScontComprobanteID.ValorCordobas = NumMonto.Value * CDec(txtTasaCambio.Text)
            End If
            objScontComprobanteID.TasaCambio = txtTasaCambio.Text
            objScontComprobanteID.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objScontComprobanteID.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objScontComprobanteID.Update(T)
            IDCheque = objScontComprobanteID.ScontChequeID

            SContChequeDetalle.DeleteByFilter("objSContChequeID=" & IDCheque, T)

            For Each dr As DataRow In dtCuentasA.Rows
                objSContComprobanteDetalle.objSContChequeID = IDCheque
                objSContComprobanteDetalle.SContCuentaContablesID = dr("SContCuentasContablesID").ToString
                objSContComprobanteDetalle.MontoAcreditar = dr("MontoAcreditar").ToString
                objSContComprobanteDetalle.MontoDebitar = dr("MontoDebitar").ToString

                ''Buscar la naturaleza de la cuenta
                objNaturaleza = New SContCuentasContables
                objNaturaleza.Retrieve(dr("SContCuentasContablesID").ToString, T)

                If objNaturaleza.objNaturalezaID = intDeudora Then
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
                Else
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
                End If

                If Not IsNothing(dr("SconCentroCostoID").ToString) Then
                    objSContComprobanteDetalle.objCentroCostoID = CInt(dr("SconCentroCostoID").ToString)
                End If

                objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSContComprobanteDetalle.Insert(T)
            Next

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            TypeID = 1
            cmdProcesar.Enabled = True
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
    Private Sub Imprimir()
        Try
            Dim ds As DataSet

            Dim objjReporte As New RptComprobantePago()


            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NumCheque, ScontChequeID, FechaComprobante, Concepto, IDCuenta, Cuenta, MontoAcreditar, MontoDebitar, CentroCosto, Beneficiario,Notas", "vwRptComprobanteCheque", "ScontChequeID=" & IDCheque))

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

        Try


            Select Case TypeID
                Case 0
                    GuardarCheque()
                Case 1
                    EditarCheque()
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
            If chkCentro.Checked Then
                If cmbCentroCosto.Text.Trim.Length = 0 Then
                    MsgBox("Indique el centro de costo al que se asociara la cuenta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

            End If

            If Me.txtCuenta.Text.Trim.Length = 0 Then
                MsgBox("Debe seleccionar la cuenta contable.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Exit Sub
            End If

            If Me.numAcreditar.Value = 0 And numDebitar.Value = 0 Then
                MsgBox("Indique el monto a debitar y/o acreditar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If


            Dim filas As DataRow
            filas = dtCuentasA.NewRow
            filas("SContCuentasContablesID") = CuentaID
            filas("IDCuenta") = strIDCuenta
            filas("Descripcion") = txtCuenta.Text
            filas("MontoAcreditar") = numAcreditar.Value
            filas("MontoDebitar") = numDebitar.Value

            If chkCentro.Checked Then
                filas("SconCentroCostoID") = cmbCentroCosto.SelectedValue
                filas("Centro") = cmbCentroCosto.Text
            Else
                filas("SconCentroCostoID") = 0
                filas("Centro") = String.Empty
            End If

            dtCuentasA.Rows.Add(filas)
            txtCuenta.Text = String.Empty
            CuentaID = 0
            numAcreditar.Value = 0
            numDebitar.Value = 0

            calcularTotales()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub calcularTotales()
        Try
            numCreditoT.Value = 0.0
            numDebitoT.Value = 0.0
            For Each dr As DataRow In dtCuentasA.Rows
                numCreditoT.Value = numCreditoT.Value + Decimal.Parse(dr("MontoAcreditar").ToString)
                numDebitoT.Value = numDebitoT.Value + Decimal.Parse(dr("MontoDebitar").ToString)

            Next
            numTotal.Value = numCreditoT.Value - numDebitoT.Value
            NumMonto.Value = numCreditoT.Value
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

            calcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
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



    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            Dim objSeleccion As New frmScontCuentaSelector

            If chkCentro.Checked Then
                    objSeleccion.Centro = cmbCentroCosto.SelectedValue
                    objSeleccion.Opcion = 4
                Else
                    objSeleccion.Opcion = 3
                End If
                If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                    CuentaID = objSeleccion.Seleccion
                    CargarCuenta()

                End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class