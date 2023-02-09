Imports DAL
Imports SIRA.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Data
Imports SIRA.BO.clsConsultas
Imports DevExpress.XtraReports.UI

''' <summary>
''' Pantalla de Guardado y Edicion de Recibos de Caja.
''' </summary>
''' <remarks></remarks>
Public Class frmSccEditReciboCaja

#Region "Variables"

    Dim DtDatosReciboCaja As New DataTable
    Dim DtDatosNotasCredito, dtCajeros As DataTable
    Dim DtdatosNotasDebito As DataTable
    Dim dtRutas As New DataTable
    Dim DtCobrador As New DataTable
    Dim DtDatosFactRecibo As New DataTable
    Dim m_IDCuenta As String
    Dim m_TyGui As Integer
    Dim MontoPrima As Decimal
    Dim m_ReciboCajaID As Integer
    Dim m_BoolResult As Boolean
    Dim dtCuentasDatos As New DataTable
    Dim montoMensualidad As Decimal
    '-------------------Variables de Totalizacion de Datos ------------------------
    Dim DecTotalFact As Decimal
    Dim DecTotalND As Decimal
    Dim DecTotalRecibo As Decimal
    Dim DecTotalAbonado As Decimal
    Dim DecTotalEfect As Decimal
    Dim DecTotalNC As Decimal
    Dim DecTotalOtros As Decimal
    Dim objReciboCaja As SccReciboCaja
    Dim objSeg As SsgSeguridad
    Dim dtPeriodo, dtConcepto, dtMoneda, dtTipoPago As DataTable
    Dim m_Alumno, intCajaID As Integer
    'Variables para tratamiento de "Reestructuración de Cuenta"
    Public blnReestructurarCuenta As Boolean = False
    Dim intmoneda, intmonedacor As Integer
    Dim dtOtrosPagos As DataTable
    Dim intCheque, intEfectivo As Integer
    Dim CuentaID As Integer
    Dim NumCuenta As String
    Dim dtConceptoMensualidad As DataTable
    Dim EmpleadoID As Integer
    Dim intConceptoPrestamo As Integer

#End Region

#Region "Propiedades"

    'Variables para tratamiento de "Reestructuración de Cuenta"

    Property ReciboCajaID() As Integer
        Get
            ReciboCajaID = Me.m_ReciboCajaID
        End Get
        Set(ByVal value As Integer)
            Me.m_ReciboCajaID = value
        End Set
    End Property

    Property IDCuenta() As String
        Get
            IDCuenta = m_IDCuenta
        End Get
        Set(ByVal value As String)
            m_IDCuenta = value
        End Set
    End Property

    Property TypGui() As Integer
        Get
            TypGui = m_TyGui
        End Get
        Set(ByVal value As Integer)
            m_TyGui = value
        End Set
    End Property

    Property BoolResult() As Boolean
        Get
            BoolResult = Me.m_BoolResult
        End Get
        Set(ByVal value As Boolean)
            Me.m_BoolResult = value
        End Set
    End Property

    Property AlumnoID()
        Get
            AlumnoID = Me.m_Alumno
        End Get
        Set(ByVal value)
            Me.m_Alumno = value
        End Set
    End Property

#End Region

#Region "Cargar Combos"

    Private Sub CargarConceptoMensualidad()
        Try
            Me.dtConceptoMensualidad = New DataTable
            Me.dtConceptoMensualidad = ClsCatalogos.ObtenerValCat("CONCEPTORECIBO")
            With cmbConceptoMensualidad
                .DataSource = Me.dtConceptoMensualidad
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
            Me.dtConcepto = ClsCatalogos.ObtenerValCat("CONCEPTORECIBO")
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
    Private Sub CargarTipoPago()
        Try
            Me.dtTipoPago = New DataTable
            Me.dtTipoPago = ClsCatalogos.ObtenerValCat("TIPOPAGO")
            With cmbTipoPago
                .DataSource = Me.dtTipoPago
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
    Public Sub CargarPeriodos()
        Try
            dtPeriodo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodos.ValueMember = "PeriodoID"
            cmbPeriodos.DisplayMember = "Periodo"
            cmbPeriodos.DataSource = dtPeriodo

            cmbPeriodos.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodos.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodos.ColumnHeaders = False
            cmbPeriodos.ExtendRightColumn = True
            cmbPeriodos.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
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


#End Region

#Region "Cargar Grid"

    Public Sub CargarOtrosPagos()
        Try

            dtOtrosPagos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  SccOtrosPagosID, objConceptoID, Monto, Concepto", "vwSraOtrosPagosRecibo", "objSccReciboID=" & ReciboCajaID))
            grdAsigmacion.DataSource = dtOtrosPagos
            grdAsigmacion.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarMora()
        Dim Autorizada As Integer
        Try
            Autorizada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "AUTORIZADA")
            Me.DtdatosNotasDebito = New DataTable
            DtdatosNotasDebito = New DataTable

            If Me.TypGui = 0 Then
                DtdatosNotasDebito = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboNotaDB", "SccCuentaID='" + Me.IDCuenta.ToString + "' AND objEstadoID= " & Autorizada.ToString))
            Else
                DtdatosNotasDebito = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion", "vwReciboNotaDBEditar", "SccCuentaID='" + Me.IDCuenta.ToString + "'  AND (objReciboCajaID = " & ReciboCajaID & " OR objReciboCajaID=0) ORDER BY SccMoraID "))

            End If

            Me.grdNotaDebito.SetDataBinding(DtdatosNotasDebito, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub


#End Region

#Region "Eventos del formulario"

    Private Sub frmSccEditReciboCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objTasaCambio As StbTasaCambioOficial
        Dim objCaja As New SccCajas
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.txtNumRecibo.MaxLength = SccReciboCaja.GetMaxLength("Numero")
            CargarConcepto()
            CargarConceptoMensualidad()
            CargarMonedas()
            CargarPeriodos()
            CargarCajeros()
            CargarTipoPago()

            intmoneda = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "USD")
            intmonedacor = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "COR")
            intCheque = ClsCatalogos.ObtenerIDSTbCatalogo("TIPOPAGO", "02")
            intEfectivo = ClsCatalogos.ObtenerIDSTbCatalogo("TIPOPAGO", "01")
            intConceptoPrestamo = ClsCatalogos.ObtenerIDSTbCatalogo("CONCEPTORECIBO", "41")

            lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
            objCaja.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")

            If Not IsNothing(objCaja.objCajeroID) Then
                cmbCajero.SelectedValue = objCaja.objCajeroID
            End If
            If Not IsNothing(objCaja.SccCajaID) Then
                intCajaID = objCaja.SccCajaID
            End If

            CargarOtrosPagos()

            Select Case Me.TypGui
                Case 0
                    cmbTipoPago.SelectedValue = intEfectivo
                    objTasaCambio = New StbTasaCambioOficial
                    Me.Text = "Nuevo Recibo de Caja"
                    Me.txtEstado.Text = Me.CargarEstados(ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "REGISTRADO"))
                    Me.dtpFecha.Value = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)

                    If IsNothing(objTasaCambio.Monto) Or objTasaCambio.Monto = 0 Then
                        MsgBox("Defina una tasa de cambio valida.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Else
                        Me.txtTasaCambio.Text = objTasaCambio.Monto
                    End If

                    Me.cmbMoeda.SelectedIndex = 0
                Case 1
                    Me.Text = "Edicion de Recibo de Caja"
                    Me.CargarDatosEdicion()
                    Me.cmdExpediente.Enabled = False
                Case 2
                    Me.Text = "Consultar Recibo de Caja"
                    Me.CargarDatosEdicion()
                    Me.BloquearColumnasModoConsulta()
                    Me.cmdExpediente.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.txtNumRecibo.Enabled = False
                    clsProyecto.CargarTemaDefinido(Me)
            End Select

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Eventos de botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Select Case Me.TypGui
            Case 0
                Me.GuardarReciboCaja()

            Case 1
                Me.ModificarRecibo()

        End Select
    End Sub

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExpediente.Click
        Try
            If chkEsPrestamo.Checked Then
                SeleccionarCuentaEmpleado()
            Else
                Me.SeleccionarCuenta()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If Me.BoolResult Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub RecalcularSaldos(T As TransactionManager, CuentaID As Integer)
        Dim parametro(1) As SqlClient.SqlParameter
        Try
            parametro(0) = New SqlClient.SqlParameter("@SccCuentaID ", SqlDbType.Int, 4)
            parametro(0).Value = CuentaID
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "sp_CalcularSaldos", parametro)

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            parametro = Nothing

        End Try
    End Sub

    Private Sub RevertirSaldo(T As TransactionManager)

        Dim dtDetalleRecibo As New DataTable
        Dim dtDetalleMora As New DataTable
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        Dim objCuenta As New SccCuentaPorCobrar
        Dim objCuentaDetalleEmpleados As New SccCuentaPorCobrarDetalleEmpleados
        Dim objCuentaEmpleados As New SccCuentaPorCobrarEmpleados
        Dim objMora As New SccMora
        Dim decSaldo As Decimal
        Try
            Dim IDTemp As Integer = 0
            Dim objReciboAnular As SccReciboCaja
            objReciboAnular = New SccReciboCaja
            decSaldo = 0
            objReciboAnular.Retrieve(ReciboCajaID, T)

            If Not objReciboAnular.EsPagoPrestamo Then
                ''Aumentar en la cuenta por pagar
                dtDetalleRecibo = SccReciboDetalle.RetrieveDT("objReciboCajaID=" & ReciboCajaID, , , T)

                If dtDetalleRecibo.Rows.Count > 0 Then
                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                        objCuentaDetalle.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"), T)

                        objCuentaDetalle.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")
                        objCuentaDetalle.MontoPagado = 0
                        decSaldo = decSaldo + drwDetRecibo("Monto")
                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaDetalle.Update(T)
                    Next

                    objCuenta.Retrieve(objReciboAnular.objSccCuentaID, T)
                    objCuenta.Saldo = decSaldo
                    objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                    objCuenta.Update(T)

                End If

                ''Si tiene el pago de alguna mora, regresar la mora a Pendiente
                dtDetalleMora = SccReciboDetMora.RetrieveDT("objReciboCajaID=" & ReciboCajaID, , , T)
                If dtDetalleMora.Rows.Count > 0 Then
                    For Each drwDetReciboMora As DataRow In dtDetalleMora.Rows

                        objMora.Retrieve(drwDetReciboMora("objSccMoraID"), T)
                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objMora.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "AUTORIZADA")
                        objMora.Update(T)
                    Next

                End If

            Else
                ''Aumentar en la cuenta por pagar
                dtDetalleRecibo = SccReciboDetalle.RetrieveDT("objReciboCajaID=" & ReciboCajaID, , , T)

                If dtDetalleRecibo.Rows.Count > 0 Then
                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                        objCuentaDetalleEmpleados.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"), T)

                        objCuentaDetalleEmpleados.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")
                        objCuentaDetalleEmpleados.MontoPagado = 0
                        decSaldo = decSaldo + drwDetRecibo("Monto")
                        objCuentaDetalleEmpleados.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalleEmpleados.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaDetalleEmpleados.Update(T)
                    Next

                    objCuentaEmpleados.Retrieve(objReciboAnular.objSccCuentaID, T)
                    objCuentaEmpleados.Saldo = decSaldo
                    objCuentaEmpleados.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objCuentaEmpleados.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCuentaEmpleados.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")
                    objCuentaEmpleados.Update(T)

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Public Sub CargarCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & CuentaID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procedimiento encargado de Cargar los datos principales del Recibo en Nuevo,Edicion y Consulta.   
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializacionDatos()
        Try
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccReciboCaja"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub SeleccionarCuentaEmpleado()
        Dim objSccRecibo As New SccReciboCaja
        Try
            Dim objCuentasSeleccion As New frmSccSeleccionCuentasEmpleados

            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then


                If Not IsNothing(objCuentasSeleccion.SccCuentaID) Then
                    Me.txtNumCuenta.Text = objCuentasSeleccion.NumeroCuenta
                    Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                Else
                    Me.txtNumCuenta.Text = String.Empty
                    Me.IDCuenta = 0
                End If

                Me.txtCliente.Text = objCuentasSeleccion.Empleado
                Me.txtAtencionA.Text = objCuentasSeleccion.Empleado
                Me.EmpleadoID = objCuentasSeleccion.AlumnoID

                Me.CargarFacturasEmpleados()

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Procedimiento encargado de llamar la pantalla para seleccion de cuentas.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Dim objSccRecibo As New SccReciboCaja
        Try
            Dim objCuentasSeleccion As New frmSccSeleccionCuentas
            objCuentasSeleccion.PeriodoID = cmbPeriodos.SelectedValue

            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then


                If Not IsNothing(objCuentasSeleccion.SccCuentaID) Then
                    Me.txtNumCuenta.Text = objCuentasSeleccion.NumeroCuenta
                    Me.IDCuenta = objCuentasSeleccion.SccCuentaID
                Else
                    Me.txtNumCuenta.Text = String.Empty
                    Me.IDCuenta = 0
                End If

                Me.txtCliente.Text = objCuentasSeleccion.Alumno
                Me.txtAtencionA.Text = objCuentasSeleccion.Alumno
                Me.AlumnoID = objCuentasSeleccion.AlumnoID
                Me.txtGrupo.Text = objCuentasSeleccion.Grupo
                Me.SpnPorcentaje.Value = objCuentasSeleccion.PorcentajeBeca

                Me.CargarFacturas()
                Me.CargarMora()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    ''' <summary>
    ''' Procedimiento encargado de cargar los estados de un recibo de caja
    ''' </summary>
    ''' <param name="IdEstado"></param>
    ''' <remarks></remarks>

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOROC'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    ''' <summary>
    ''' Procedimiento encargado de cargar las facturas correspondientes.
    ''' Fecha : 3 de Abril de 2009.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarFacturas()
        Dim sConsulta As String
        Try

            Me.DtDatosFactRecibo = New DataTable
            If Me.TypGui = 0 Then
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar, MontoCordobas", "vwSccReciboDetPagos", "Saldo>0 AND objSccCuentaPorCobrarID='" & Me.IDCuenta & "'")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            Else
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar, MontoCordobas", "vwSccReciboDetPagosEditar", "objSccCuentaPorCobrarID='" & Me.IDCuenta & "' AND (objReciboCajaID = " & ReciboCajaID & " OR objReciboCajaID=0) ORDER BY Mes")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)

                'sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "'")
                'Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            End If

            Me.grdMensualidades.DataSource = DtDatosFactRecibo

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarFacturasEmpleados()
        Dim sConsulta As String
        Try

            Me.DtDatosFactRecibo = New DataTable
            If Me.TypGui = 0 Then
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar, MontoCordobas", "vwSccReciboDetPagosEmpleados", "MontoCordobas>0 AND objSccCuentaPorCobrarID='" & Me.IDCuenta & "'")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            Else
                sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar, MontoCordobas", "vwSccReciboDetPagosEmpleados", "objSccCuentaPorCobrarID='" & Me.IDCuenta & "'")
                Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)

                'sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetFactura", "objSccCuentaID='" & Me.IDCuenta & "'")
                'Me.DtDatosFactRecibo = SqlHelper.ExecuteQueryDT(sConsulta)
            End If

            Me.grdMensualidades.DataSource = DtDatosFactRecibo

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Guardado de Datos"
    '----------------------------------------------------------------------------------------------------------------------
    ' Descripcion    : Esta funcion se encarga de realizar el proceso completo de guardado de los datos.
    '----------------------------------------------------------------------------------------------------------------------
    Private Function GuardarReciboCaja() As Boolean
        Dim Boolrst As Boolean
        Dim objDetNotaDebito As SccReciboDetMora
        Dim T As New TransactionManager
        Dim Pagado, Pendiente As Integer
        Dim MoraPagada, MoraPendiente As Integer
        Dim objOtrosPagos As SccOtrosPagosRecibo
        Dim intNumRecibo As Integer
        Dim objParametro As StbParametro
        Try
            Pagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02")
            Pendiente = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")

            MoraPagada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "PAGADA")
            MoraPendiente = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "AUTORIZADA")

            Boolrst = False
            CalcularTotales()

            If (Me.dtpFecha.Value.Date > clsProyecto.Conexion.FechaServidor.Date) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha Incorrecta")
                Exit Function
            End If

            If Not ValidarDetalleFact() Then
                Me.ErrorProv.SetError(Me.lblError, "Datos Imcompletos")
                Exit Function
            End If

            If Trim(Me.cmbPeriodos.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbPeriodos, "Campo Obligatorio.")
                Exit Function
            End If

            If Trim(Me.cmbCajero.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbCajero, "Campo Obligatorio.")
                Exit Function
            End If

            If txtCliente.Text.Trim.Length = 0 And txtAtencionA.Text.Trim.Length = 0 Then
                MsgBox("Defina un expediente y/o Atencion A.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Function
            End If

            'If Trim(Me.cmbConceptoRecibo.Text) = "" Then
            '    Me.ErrorProv.SetError(Me.cmbConceptoRecibo, "Campo Obligatorio.")
            '    Exit Function
            'End If

            If Trim(Me.cmbMoeda.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbMoeda, "Campo Obligatorio.")
                Exit Function
            End If

            If Trim(Me.cmbTipoPago.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbTipoPago, "Campo Obligatorio.")
                Exit Function
            End If

            If cmbTipoPago.SelectedValue = intCheque Then
                If Trim(Me.txtCuenta.Text) = "" Then
                    Me.ErrorProv.SetError(Me.txtCuenta, "Campo Obligatorio.")
                    Exit Function
                End If
            End If

            Dim contador As Integer = 0

            If Not IsNothing(Me.DtDatosFactRecibo) Then
                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        contador = contador + 1
                    End If
                Next
            Else
                contador = 0
            End If

            'If contador > 0 Then
            '    If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
            '        Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
            '        Exit Function
            '    End If
            'End If

            If cmbConceptoMensualidad.Text.Trim.Length = 0 And NumMontoDolares.Value <> 0 Then
                Me.ErrorProv.SetError(Me.cmbConceptoMensualidad, "Campo Obligatorio.")
                Exit Function
            End If

            T.BeginTran()

            '--------------------------- Creamos el encabezado del recibo colector--------------------------
            Me.objReciboCaja = New SccReciboCaja

            intNumRecibo = GeneraraNumero(T)
            Me.objReciboCaja.Numero = intNumRecibo '' Trim(Me.txtNumRecibo.Text)
            Me.objReciboCaja.Fecha = Me.dtpFecha.Value
            Me.objReciboCaja.AtencionA = txtAtencionA.Text
            Me.objReciboCaja.objCuentaID = CuentaID
            Me.objReciboCaja.Observaciones = txtObservaciones.Text

            If intmoneda = cmbMoeda.SelectedValue Then

                If contador = 0 Then
                    Me.objReciboCaja.TotalRecibido = txtTotalPagar.Text
                    Me.objReciboCaja.TotalRecibidoCordoba = txtTotalPagar.Text * Convert.ToDouble(txtTasaCambio.Text)
                Else
                    Me.objReciboCaja.TotalRecibido = Me.DecTotalRecibo
                    Me.objReciboCaja.TotalRecibidoCordoba = Me.DecTotalRecibo * Convert.ToDouble(txtTasaCambio.Text)
                End If

                Me.objReciboCaja.MontoRecibidoEfectivo = Convert.ToDouble(Me.txtTotalPagar.Value)
                Me.objReciboCaja.MontoRecibidoEfectivoCordoba = Convert.ToDouble(Me.txtTotalPagar.Value) * Convert.ToDouble(txtTasaCambio.Text)
            Else
                If contador = 0 Then
                    Me.objReciboCaja.TotalRecibido = txtTotalPagar.Text / Convert.ToDouble(txtTasaCambio.Text)
                    Me.objReciboCaja.TotalRecibidoCordoba = txtTotalPagar.Text
                Else
                    Me.objReciboCaja.TotalRecibido = Me.DecTotalRecibo / Convert.ToDouble(txtTasaCambio.Text)
                    Me.objReciboCaja.TotalRecibidoCordoba = Me.DecTotalRecibo
                End If
                Me.objReciboCaja.MontoRecibidoEfectivo = Convert.ToDouble(Me.txtTotalPagar.Value) / Convert.ToDouble(txtTasaCambio.Text)
                Me.objReciboCaja.MontoRecibidoEfectivoCordoba = Convert.ToDouble(Me.txtTotalPagar.Value)
            End If

            Me.objReciboCaja.objTipoPagoID = cmbTipoPago.SelectedValue
            Me.objReciboCaja.UsuarioCreacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaCreacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
            Me.objReciboCaja.objSccCuentaID = Me.IDCuenta

            If chkEsPrestamo.Checked Then
                objReciboCaja.objEmpleadoID = EmpleadoID
                Me.objReciboCaja.objAlumnoID = Nothing
            Else
                Me.objReciboCaja.objAlumnoID = Me.AlumnoID
            End If

            Me.objReciboCaja.objCajeroID = cmbCajero.SelectedValue
            Me.objReciboCaja.objMonedaID = cmbMoeda.SelectedValue
            Me.objReciboCaja.objPeriodoID = cmbPeriodos.SelectedValue
            Me.objReciboCaja.objCajaID = intCajaID
            Me.objReciboCaja.TipoCambio = txtTasaCambio.Text
            Me.objReciboCaja.EsPagoPrestamo = chkEsPrestamo.Checked

            '-------------------------------------------------------------------- ---------------------------
            Me.objReciboCaja.Insert(T)
            Me.ReciboCajaID = Me.objReciboCaja.SccReciboCajaID
            If chkEsPrestamo.Checked Then
                Dim objReciboDetalle As New SccReciboDetallePrestamo
                If Not IsNothing(Me.DtDatosFactRecibo) Then
                    For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                        If DrwDetalle("Seleccion") Then
                            objReciboDetalle.objCuentaDetalleID = DrwDetalle("SccCuentaPorCobrarDetalleID")
                            objReciboDetalle.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID

                            objReciboDetalle.MontoCordobas = Convert.ToDouble(DrwDetalle("CantAbonar"))
                            objReciboDetalle.Monto = Convert.ToDouble(DrwDetalle("CantAbonar"))

                            If DrwDetalle("CantAbonar") = DrwDetalle("MontoInicial") Then
                                objReciboDetalle.EsAbono = False
                            Else
                                objReciboDetalle.EsAbono = True

                            End If
                            objReciboDetalle.objConceptoID = cmbConceptoMensualidad.SelectedValue
                            objReciboDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objReciboDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objReciboDetalle.Insert(T)
                        End If
                    Next
                End If
            Else
                Dim objReciboDetalle As New SccReciboDetalle
                If Not IsNothing(Me.DtDatosFactRecibo) Then
                    For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                        If DrwDetalle("Seleccion") Then
                            objReciboDetalle.objCuentaDetalleID = DrwDetalle("SccCuentaPorCobrarDetalleID")
                            objReciboDetalle.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID

                            objReciboDetalle.MontoCordobas = Convert.ToDouble(DrwDetalle("CantAbonar")) * Convert.ToDouble(txtTasaCambio.Text)
                            objReciboDetalle.Monto = Convert.ToDouble(DrwDetalle("CantAbonar"))

                            If DrwDetalle("CantAbonar") = DrwDetalle("MontoInicial") Then
                                objReciboDetalle.EsAbono = False
                            Else
                                objReciboDetalle.EsAbono = True

                            End If
                            objReciboDetalle.objConceptoID = cmbConceptoMensualidad.SelectedValue
                            objReciboDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objReciboDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objReciboDetalle.Insert(T)
                        End If
                    Next
                End If
            End If

            '-------------------------------------------------------------------------------------------
            '---------------Creamos los detalles para las notas de debito-------------------------------
            Dim objMora As New SccMora

            If Not IsNothing(Me.DtdatosNotasDebito) Then
                objDetNotaDebito = New SccReciboDetMora
                For Each DrwNDINC As DataRow In Me.DtdatosNotasDebito.Rows
                    If DrwNDINC("Seleccion") Then
                        objDetNotaDebito.objSccMoraID = DrwNDINC("SccMoraID")
                        objDetNotaDebito.objSccCuentaPorCobrarDetalleID = DrwNDINC("objSccCuentaPorCobrarDetalleID")
                        objDetNotaDebito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                        objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaDebito.Insert(T)

                        ''Modificar Mora
                        objMora.Retrieve(DrwNDINC("SccMoraID"))
                        objMora.objEstadoID = MoraPagada
                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objMora.Update(T)
                    Else
                        ''Modificar Mora
                        objMora.Retrieve(DrwNDINC("SccMoraID"))
                        objMora.objEstadoID = MoraPendiente
                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objMora.Update(T)
                    End If
                Next
            End If

            If Not IsNothing(Me.dtOtrosPagos) Then
                objOtrosPagos = New SccOtrosPagosRecibo
                For Each DrwOtros As DataRow In Me.dtOtrosPagos.Rows
                    objOtrosPagos.objSccReciboID = ReciboCajaID
                    objOtrosPagos.objConceptoID = DrwOtros("objConceptoID")
                    objOtrosPagos.Monto = DrwOtros("Monto")
                    objOtrosPagos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objOtrosPagos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objOtrosPagos.Insert(T)
                Next
            End If
            ''Actualizar consecutivo
            objParametro = New StbParametro
            objParametro.RetrieveByFilter("Nombre='ConsecutivoRecibo'", T)
            objParametro.Valor = intNumRecibo
            objParametro.Update(T)

            Me.PROCESAR_RECIBO(Me.ReciboCajaID, 0, T)

            T.CommitTran()


            Me.BoolResult = True
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            'BloquearColumnasModoConsulta()

            Me.cmdGuardar.Enabled = False
            Boolrst = True
            'Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return Boolrst
    End Function

    Private Function ValidarDetalleFact() As Boolean
        Dim boolrst As Boolean
        Try
            boolrst = True
            If Not Me.DtDatosFactRecibo Is Nothing Then
                For Each drw As DataRow In Me.DtDatosFactRecibo.Rows
                    If drw("Seleccion") Then
                        If Not drw("Cancelar") And Not drw("Abonar") Then
                            boolrst = False
                            Exit For
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return boolrst
    End Function

    '--------------------------------------------------------------------------------------------------------------
    ' Descripcion     : Esta funcion se encarga de ir a generar el numero del recibo creado.
    '--------------------------------------------------------------------------------------------------------------
    Private Function GeneraraNumero(t As TransactionManager) As String
        Dim strNum As String
        Dim dtNum As New DataTable
        Dim dtValParam As New DataTable
        Dim intNCeros As Integer
        Dim intNumero As Integer
        strNum = ""
        Try
            
            dtValParam = StbParametro.RetrieveDT("Nombre = 'CerosRellenoReciboCaja'", , "Valor", t)
            If dtValParam.DefaultView.Count > 0 Then
                intNCeros = dtValParam.DefaultView.Item(0)("Valor")
            End If

            dtNum = StbParametro.RetrieveDT("Nombre = 'ConsecutivoRecibo'", , "Valor", t)

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


#End Region

#Region "Calculo de Totales"
    ''' <summary>
    ''' Procedimiento Encargado de Llevar a Cabo el Calculo de Total a Pagar del Recibo.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalcularTotales()
        Dim DecSumTotalND As Decimal
        Dim DecSumMontoFactura As Decimal
        Dim DecOtros As Decimal
        Dim obj As New Object
        Dim contador As Integer
        Try
            If Not Me.DtDatosFactRecibo Is Nothing Then

                '---------------------Calculamos el monto original de cada factura--------------------------------
                If Not IsNothing(Me.DtDatosFactRecibo) Then
                    If Me.DtDatosFactRecibo.DefaultView.Count > 0 Then
                        Try
                            obj = Me.DtDatosFactRecibo.Compute("SUM(CantAbonar)", "Seleccion = 'TRUE'")
                            If Not IsDBNull(obj) Then
                                DecSumMontoFactura = obj
                            End If
                        Catch ex As Exception
                            Throw
                        End Try
                       

                    End If

                    If Not Me.DtDatosNotasCredito Is Nothing Then
                        If Me.DtDatosNotasCredito.DefaultView.Count > 0 Then
                            obj = Me.DtDatosNotasCredito.Compute("SUM(Monto)", "Seleccion= 'TRUE'")
                            If Not IsDBNull(obj) Then
                                Me.DecTotalNC = obj
                            End If
                        End If
                    End If

                End If
            End If

            '-------------------------------------------------------------------------------------------------
            '------------------Calculamos el Total por todas las facturas incluidas-------
            If Not chkEsPrestamo.Checked Then
                If intmonedacor = cmbMoeda.SelectedValue Then
                    If txtTasaCambio.Text.Trim.Length <> 0 Then
                        Me.DecTotalFact = DecSumMontoFactura * Convert.ToDouble(txtTasaCambio.Text)
                    End If
                Else
                    Me.DecTotalFact = DecSumMontoFactura
                End If
            Else
                If intmoneda = cmbMoeda.SelectedValue Then
                    If txtTasaCambio.Text.Trim.Length <> 0 Then
                        Me.DecTotalFact = Decimal.Round(Decimal.Parse(DecSumMontoFactura / Convert.ToDouble(txtTasaCambio.Text)), 2)
                    End If
                Else
                    Me.DecTotalFact = DecSumMontoFactura
                End If
            End If


            If Not Me.DtdatosNotasDebito Is Nothing Then
                If Me.DtdatosNotasDebito.DefaultView.Count > 0 Then
                    obj = Me.DtdatosNotasDebito.Compute("SUM(Monto)", " Seleccion = 'TRUE'")
                    If Not IsDBNull(obj) Then
                        If intmonedacor = cmbMoeda.SelectedValue Then
                            If txtTasaCambio.Text.Trim.Length <> 0 Then
                                DecSumTotalND = obj * Convert.ToDouble(txtTasaCambio.Text)
                            End If
                        Else
                            DecSumTotalND = obj
                        End If

                    End If
                End If
            End If

            If Not Me.dtOtrosPagos Is Nothing Then
                If Me.dtOtrosPagos.DefaultView.Count > 0 Then
                    obj = Me.dtOtrosPagos.Compute("SUM(Monto)", " 1 = 1")
                    If Not IsDBNull(obj) Then
                        DecOtros = obj
                    End If
                End If
            End If

            If intmonedacor = cmbMoeda.SelectedValue Then

                If txtTasaCambio.Text.Trim.Length > 0 Then
                    Me.DecTotalND = DecSumTotalND
                    Me.DecTotalRecibo = (Me.DecTotalFact) + Me.DecTotalND
                    Me.txtTotalFact.Value = Decimal.Round(Decimal.Parse(Me.DecTotalFact + DecOtros), 2)
                End If
            Else
                Me.DecTotalND = DecSumTotalND
                Me.DecTotalRecibo = (Me.DecTotalFact + Me.DecTotalND) / Convert.ToDouble(txtTasaCambio.Text)
                Me.txtTotalFact.Value = Decimal.Round(Me.DecTotalFact + DecOtros, 2) / Convert.ToDouble(txtTasaCambio.Text)
            End If

            Me.txtTotalDB.Value = Decimal.Round(Me.DecTotalND, 2)
            Me.txtTotalPagar.Value = Decimal.Round(Me.DecTotalRecibo + DecOtros, 2)

            If Not IsNothing(Me.DtDatosFactRecibo) Then
                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        contador = contador + 1
                    End If
                Next
            Else
                contador = 0
            End If

            If contador = 0 Then

                Me.DecTotalFact = Decimal.Round(Me.NumMontoDolares.Value + DecOtros, 2)
                Me.txtTotalFact.Value = Decimal.Round(Me.NumMontoDolares.Value + DecOtros, 2)
                Me.txtTotalPagar.Value = Decimal.Round(Me.NumMontoDolares.Value + DecOtros, 2)
            End If

            Me.NumMontoDolares.Value = Me.DecTotalRecibo
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#End Region

#Region "Eventos de controles"

    Private Sub cmbConceptoMensualidad_TextChanged(sender As Object, e As EventArgs) Handles cmbConceptoMensualidad.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub chkDólares_CheckedChanged(sender As Object, e As EventArgs) Handles chkDólares.CheckedChanged
        Try
            If txtTasaCambio.Text.Trim.Length > 0 Then
                If chkDólares.Checked Then
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value * Decimal.Parse(txtTasaCambio.Text)

                Else
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub numConvertirT_TextChanged(sender As Object, e As EventArgs) Handles numConvertirT.TextChanged
        Try
            If txtTasaCambio.Text.Trim.Length > 0 Then
                If chkDólares.Checked Then
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value * Decimal.Parse(txtTasaCambio.Text)

                Else
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub numMontoDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numMontoDetalle.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.numMontoDetalle.Value <> 0 Then
                Me.cmdAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub numConvertirT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numConvertirT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.numMontoDetalle.Value <> 0 Then
                Me.cmdAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub cmbPeriodos_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodos.TextChanged
        Try
            Me.txtNumCuenta.Text = String.Empty
            Me.IDCuenta = 0

            Me.txtCliente.Text = String.Empty
            Me.txtAtencionA.Text = String.Empty
            Me.AlumnoID = 0
            Me.txtGrupo.Text = String.Empty
            Me.SpnPorcentaje.Value = 0

            Me.CargarFacturas()
            Me.CargarMora()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbConceptoRecibo_TextChanged(sender As Object, e As EventArgs) Handles cmbConceptoRecibo.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbMoeda_TextChanged(sender As Object, e As EventArgs) Handles cmbMoeda.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs) Handles cmbCajero.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim filas As DataRow

        Try
            If cmbConceptoRecibo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbConceptoRecibo, My.Resources.MsgObligatorio)
                Exit Sub
            Else
                filas = dtOtrosPagos.NewRow

                filas("Concepto") = cmbConceptoRecibo.Text
                filas("objConceptoID") = cmbConceptoRecibo.SelectedValue
                filas("Monto") = numMontoDetalle.Value
                dtOtrosPagos.Rows.Add(filas)

                ''Limpiar Controles
                cmbConceptoRecibo.Text = String.Empty
                numMontoDetalle.Value = 0
                numConvertirT.Value = 0
            End If

            CalcularTotales()
            CalculoMontoAbonado()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdAsignacionTable.SelectedRowsCount() - 1
                If (grdAsignacionTable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdAsignacionTable.GetDataRow(grdAsignacionTable.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                dtOtrosPagos.Rows.Remove(drFilaAsignaturasE)
            Next

            CalcularTotales()
            CalculoMontoAbonado()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbTipoPago_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.TextChanged
        Try
            Me.ErrorProv.Clear()
            If cmbTipoPago.SelectedValue = intCheque Then
                lblCuenta.Visible = True
                txtCuenta.Visible = True
                cmdBuscarCuenta.Visible = True
            Else
                lblCuenta.Visible = False
                txtCuenta.Visible = False
                cmdBuscarCuenta.Visible = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub grdMensualidadesTabla_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdMensualidadesTabla.CellValueChanged
        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdMensualidadesTabla.FocusedRowHandle
            Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = Me.grdMensualidadesTabla.GetRowCellValue(grdMensualidadesTabla.FocusedRowHandle, "CantAbonar")

            If Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") < 0 Then
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = 0.0
            End If

            If Not chkEsPrestamo.Checked Then
                If Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") > Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Saldo") Then
                    Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = 0.0
                End If
            Else
                If Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") > Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("MontoCordobas") Then
                    Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = 0.0
                End If
            End If


            DtDatosFactRecibo.AcceptChanges()
            grdMensualidadesTabla.RefreshData()

            Me.CalcularTotales()
            Me.CalculoMontoAbonado()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkIncluir_CheckedChanged(sender As Object, e As EventArgs) Handles chkIncluir.CheckedChanged
        Dim FilaActual As Integer
        Dim blnSeleccionar As Boolean
        Try
            FilaActual = Me.grdMensualidadesTabla.FocusedRowHandle
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked

            If blnSeleccionar And (Not (Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Abonar"))) Then

                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Seleccion") = True
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Cancelar") = True

                If Not chkEsPrestamo.Checked Then
                    Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = Me.grdMensualidadesTabla.GetRowCellValue(grdMensualidadesTabla.FocusedRowHandle, "Saldo")
                Else
                    Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = Me.grdMensualidadesTabla.GetRowCellValue(grdMensualidadesTabla.FocusedRowHandle, "MontoCordobas")
                End If

                If Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") < 0 Then
                    Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = 0.0
                End If
                DtDatosFactRecibo.AcceptChanges()

                grdMensualidadesTabla.RefreshData()

                Me.CalcularTotales()
                Me.CalculoMontoAbonado()

            ElseIf Not blnSeleccionar Then

                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Seleccion") = False
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Cancelar") = False
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = 0.0
                DtDatosFactRecibo.AcceptChanges()
                grdMensualidadesTabla.RefreshData()

                Me.CalcularTotales()
                Me.CalculoMontoAbonado()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    Private Sub chkCancelar_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancelar.CheckedChanged
        Dim FilaActual As Integer
        Dim blnSeleccionar As Boolean
        Try
            FilaActual = Me.grdMensualidadesTabla.FocusedRowHandle
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked

            If blnSeleccionar Then
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Seleccion") = True
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Abonar") = False
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Cancelar") = True
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("CantAbonar") = Me.grdMensualidadesTabla.GetRowCellValue(grdMensualidadesTabla.FocusedRowHandle, "Saldo")

                DtDatosFactRecibo.AcceptChanges()
                grdMensualidadesTabla.RefreshData()

                Me.CalcularTotales()
                Me.CalculoMontoAbonado()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkAbonar_CheckedChanged(sender As Object, e As EventArgs) Handles chkAbonar.CheckedChanged
        Dim FilaActual As Integer
        Dim blnSeleccionar As Boolean
        Try
            FilaActual = Me.grdMensualidadesTabla.FocusedRowHandle
            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked

            If blnSeleccionar Then
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Seleccion") = True
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Abonar") = True
                Me.DtDatosFactRecibo.DefaultView.Item(FilaActual)("Cancelar") = False
                DtDatosFactRecibo.AcceptChanges()
                grdMensualidadesTabla.RefreshData()

                Me.CalcularTotales()
                Me.CalculoMontoAbonado()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtNumRecibo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumRecibo.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub NumMontoDolares_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Me.cmdGuardar.Focus()
        End If
    End Sub

    Private Sub NumMontoDolares_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccReciboCaja.GetMaxLength("TotalRecibo")
            s = SccReciboCaja.GetScale("TotalRecibo")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.NumMontoDolares.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.NumMontoDolares, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.NumMontoDolares.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.NumMontoDolares, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.NumMontoDolares.Value = 0
        End Try
    End Sub

    Private Sub NumMontoDolares_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NumMontoDolares.ValueChanged

        Try
            Me.ErrorProv.Clear()
            If Not IsDBNull(Me.NumMontoDolares.Value) Then
                If Me.NumMontoDolares.Value < 0 Then
                    Me.NumMontoDolares.Value = 0.0
                Else
                    Me.DecTotalEfect = Me.NumMontoDolares.Value
                End If

                CalculoMontoAbonado()
                CalcularTotales()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub grdNotaDebito_Error(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ErrorEventArgs)
        e.Handled = True
        e.Continue = True
    End Sub

    Private Sub grdNotaDebito_AfterColEdit(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotaDebito.AfterColEdit
        Try
            Select Case Me.grdNotaDebito.Columns("Incluir").Value
                Case True
                    Me.DtdatosNotasDebito.DefaultView.Item(Me.grdNotaDebito.Row)("Seleccion") = True
                Case False
                    Me.DtdatosNotasDebito.DefaultView.Item(Me.grdNotaDebito.Row)("Seleccion") = False
            End Select
            Me.DtdatosNotasDebito.AcceptChanges()
            Me.CalcularTotales()
            CalculoMontoAbonado()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotaDebito_AfterColUpdate(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles grdNotaDebito.AfterColUpdate
        Try
            CalculoMontoAbonado()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotaDebito_Error_1(sender As Object, e As C1.Win.C1TrueDBGrid.ErrorEventArgs) Handles grdNotaDebito.Error
        e.Handled = True
        e.Continue = True
    End Sub

    Private Sub cmdBuscarCuenta_Click(sender As Object, e As EventArgs) Handles cmdBuscarCuenta.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 6
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CuentaID = objSeleccion.Seleccion
                CargarCuenta()
                Me.txtCuenta.Text = dtCuentasDatos.Rows(0)("Descripcion")
                NumCuenta = dtCuentasDatos.Rows(0)("IDCuenta")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkEsPrestamo.CheckedChanged
        Try
            If chkEsPrestamo.Checked Then
                lblNombre.Text = "Empleado:"
                lblConceptoRecibo.Text = "Concepto"
                lblMontoRecibo.Text = "Monto a pagar"
                cmbConceptoMensualidad.SelectedValue = intConceptoPrestamo
                grdNotaDebito.Visible = False
                grdMensualidades.Dock = DockStyle.Fill
                CargarFacturasEmpleados()
                grdNotaDebito.Visible = False
                txtNumCuenta.Text = String.Empty
                txtCliente.Text = String.Empty
                txtAtencionA.Text = String.Empty

            Else
                IDCuenta = 0
                lblNombre.Text = "Alumno:"
                lblConceptoRecibo.Text = "Concepto mensualidad:"
                Me.txtNumCuenta.Text = String.Empty
                Me.IDCuenta = 0
                Me.txtCliente.Text = String.Empty
                Me.txtAtencionA.Text = String.Empty
                Me.AlumnoID = 0
                Me.txtGrupo.Text = String.Empty
                Me.SpnPorcentaje.Value = 0
                lblMontoRecibo.Text = "Monto Mensualidades:"
                cmbConceptoMensualidad.Text = String.Empty
                Me.CargarFacturas()
                Me.CargarMora()
                grdNotaDebito.Visible = True
                grdMensualidades.Dock = DockStyle.Top

            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Bloqueo de Columnas"
    Private Sub BloquearColumnasModoConsulta()
        Try
            Me.cmdEliminar.Enabled = False
            Me.cmdGuardar.Enabled = False
            Me.dtpFecha.Enabled = False
            Me.cmdExpediente.Enabled = False
            Me.txtNumRecibo.Enabled = False
            Me.NumMontoDolares.Enabled = False
            Me.txtCliente.Enabled = False
            Me.txtEstado.Enabled = False
            Me.txtNumCuenta.Enabled = False
            Me.cmbCajero.Enabled = False
            Me.cmbMoeda.Enabled = False
            Me.txtTasaCambio.Enabled = False
            Me.cmbConceptoRecibo.Enabled = False
            txtAtencionA.Enabled = False
            Me.cmbPeriodos.Enabled = False
            Me.cmbTipoPago.Enabled = False
            Me.chkEsPrestamo.Checked = False

            For intCantCol As Integer = 0 To Me.grdNotaDebito.Columns.Count - 1
                Me.grdNotaDebito.Columns(intCantCol).Tag = "BLOQUEADO"
            Next

            Me.cmbMoeda.Enabled = False
            Me.NumMontoDolares.Enabled = False
            Me.cmdAgregar.Enabled = False
            Me.cmdDelete.Enabled = False
            Me.numMontoDetalle.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Procesamiento de Recibos"


    '------------------------------------------------------------------------------------------------------------
    ' Descripcion    : Esta funcion se encarga de realizar el procesamiento de los datos una vez que se haya guardado.
    '------------------------------------------------------------------------------------------------------------
    Private Sub PROCESAR_RECIBO(ByVal IntIDReciboCaja As Integer, ByVal IntOpcion As Integer, T As TransactionManager)
        Dim parametro(3) As SqlClient.SqlParameter
        Dim objCuenta As SccCuentaPorCobrar
        Dim objCuentaEmpleado As SccCuentaPorCobrarEmpleados
        Dim dtDetalleRecibo As DataTable
        Dim objCuentaDetalle As SccCuentaPorCobrarDetalle
        Dim objCuentaDetalleEmpleado As SccCuentaPorCobrarDetalleEmpleados
        Dim decSaldo As Decimal
        Dim dtPagosPendientes As DataTable
        Try
            objCuentaDetalle = New SccCuentaPorCobrarDetalle
            objCuenta = New SccCuentaPorCobrar
            Me.objReciboCaja = New SccReciboCaja
            decSaldo = 0.0
            objCuentaDetalleEmpleado = New SccCuentaPorCobrarDetalleEmpleados
            objCuentaEmpleado = New SccCuentaPorCobrarEmpleados

            Me.objReciboCaja.Retrieve(IntIDReciboCaja, T)
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
            Me.objReciboCaja.Update(T)

            If Not chkEsPrestamo.Checked Then
                dtDetalleRecibo = SccReciboDetalle.RetrieveDT("objReciboCajaID=" & IntIDReciboCaja, , , T)
                If dtDetalleRecibo.Rows.Count > 0 Then
                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                        objCuentaDetalle.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"), T)

                        objCuentaDetalle.MontoPagado = objCuentaDetalle.MontoPagado + drwDetRecibo("Monto")

                        If objCuentaDetalle.MontoPagado >= objCuentaDetalle.MontoInicial Then
                            objCuentaDetalle.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02")
                        End If

                        decSaldo = decSaldo + objCuentaDetalle.MontoPagado

                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        'objCuentaDetalle.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
                        objCuentaDetalle.Update(T)
                    Next
                End If

                objCuenta.Retrieve(objReciboCaja.objSccCuentaID, T)
                objCuenta.Saldo = objCuenta.Saldo - decSaldo
                objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario

                dtPagosPendientes = SccCuentaPorCobrarDetalle.RetrieveDT("objSccCuentaPorCobrarID=" & objReciboCaja.objSccCuentaID & " AND objEstadoID <> " & ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02"), , , T)

                If dtPagosPendientes.Rows.Count = 0 Then
                    objCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")
                End If
                objCuenta.Update(T)
            Else
                dtDetalleRecibo = SccReciboDetallePrestamo.RetrieveDT("objReciboCajaID=" & IntIDReciboCaja, , , T)
                If dtDetalleRecibo.Rows.Count > 0 Then
                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                        objCuentaDetalleEmpleado.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"))

                        objCuentaDetalleEmpleado.MontoPagado = objCuentaDetalleEmpleado.MontoPagado + drwDetRecibo("Monto")

                        If objCuentaDetalleEmpleado.MontoPagado >= objCuentaDetalleEmpleado.MontoInicial Then
                            objCuentaDetalleEmpleado.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02")
                        End If

                        decSaldo = decSaldo + objCuentaDetalleEmpleado.MontoPagado

                        objCuentaDetalleEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalleEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor

                        objCuentaDetalleEmpleado.Update(T)
                    Next
                End If

                objCuentaEmpleado.Retrieve(objReciboCaja.objSccCuentaID, T)
                objCuentaEmpleado.Saldo = objCuenta.Saldo - decSaldo
                objCuentaEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objCuentaEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario

                dtPagosPendientes = SccCuentaPorCobrarDetalleEmpleados.RetrieveDT("objSccCuentaPorCobrarID=" & objReciboCaja.objSccCuentaID & " AND objEstadoID <> " & ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02"), , , T)

                If dtPagosPendientes.Rows.Count = 0 Then
                    objCuentaEmpleado.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")
                End If
                objCuenta.Update(T)
            End If

            ''Recalcular Saldo
            RecalcularSaldos(T, objReciboCaja.objSccCuentaID)
            Me.cmdGuardar.Enabled = False

            'MsgBox("El Recibo ha sido Procesado Exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            If chkEsPrestamo.Checked Then
                ImprimirReciboEmpleado(T)
            Else
                Imprimir(T)
            End If

            'Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing

        End Try
    End Sub

    Private Sub numConvertirT_ValueChanged(sender As Object, e As EventArgs) Handles numConvertirT.ValueChanged
        Try
            If txtTasaCambio.Text.Trim.Length > 0 Then
                If chkDólares.Checked Then
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value * Decimal.Parse(txtTasaCambio.Text)

                Else
                    Me.numMontoDetalle.Value = Me.numConvertirT.Value
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Imprimir(T As TransactionManager)
        Dim ds As DataSet
        Try
            Dim objjReporte As New RptSccRecibo()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccReciboCajaID, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Numero, Fecha, TotalRecibido, Alumno, Grupo, MontoDetalle, Concepto,observaciones", "vwRptRecibo", "SccReciboCajaID=" & ReciboCajaID), T)

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

    Private Sub ImprimirReciboEmpleado(T As TransactionManager)
        Dim ds As DataSet
        Try
            Dim objjReporte As New RptSccRecibo()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccReciboCajaID, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Numero, Fecha, TotalRecibido, Alumno, Grupo, MontoDetalle, Concepto,observaciones", "vwRptReciboEmpleado", "SccReciboCajaID=" & ReciboCajaID), T)

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

#End Region

#Region "Calculo de Montos Abonado en un Pago"
    '------------------------------------------------------------------------------------------------------------------
    ' Descripcion    : Esta procedimiento se encarga de realizar el proceso de calculo y actualizacion de los montos abonados 
    '----------------: en formas de pago incluidas.
    '------------------------------------------------------------------------------------------------------------------
    Public Sub CalculoMontoAbonado()
        Dim DecMontoAbonado As Decimal
        Dim DecMontoNotcred As Decimal
        Dim DecOtros As Decimal
        DecMontoAbonado = 0.0
        Dim obj As Object
        Dim contador As Integer
        Try

            Me.DecTotalAbonado = 0.0
            'If Not DtdatosNotasDebito Is Nothing Then
            If Not DtDatosNotasCredito Is Nothing Then
                If Me.DtDatosNotasCredito.DefaultView.Count > 0 Then
                    obj = (Me.DtDatosNotasCredito.Compute("Sum(Monto)", "Seleccion = 'true'"))
                    If Not IsDBNull(obj) Then
                        DecMontoNotcred = obj
                    End If
                End If
            End If

            DecMontoAbonado = Me.NumMontoDolares.Value

            If Not chkEsPrestamo.Checked Then
                If intmonedacor = cmbMoeda.SelectedValue Then
                    If txtTasaCambio.Text.Trim.Length > 0 Then
                        Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred * Convert.ToDouble(txtTasaCambio.Text)
                    Else
                        Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
                    End If
                Else
                    Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
                End If
            Else
                If intmoneda = cmbMoeda.SelectedValue Then
                    If txtTasaCambio.Text.Trim.Length > 0 Then
                        Me.DecTotalAbonado = Decimal.Round(Decimal.Parse(DecMontoAbonado + DecMontoNotcred / Convert.ToDouble(txtTasaCambio.Text)), 2)
                    Else
                        Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
                    End If
                Else
                    Me.DecTotalAbonado = DecMontoAbonado + DecMontoNotcred
                End If
            End If


            If Not Me.dtOtrosPagos Is Nothing Then
                If Me.dtOtrosPagos.DefaultView.Count > 0 Then
                    obj = Me.dtOtrosPagos.Compute("SUM(Monto)", " 1 = 1")
                    If Not IsDBNull(obj) Then
                        DecOtros = obj
                    End If
                End If
            End If
            'If TypGui = 1 Or TypGui = 2 Then
            '    Me.lblMontAbon.Text = Decimal.Round(Me.DecTotalAbonado, 2).ToString

            'Else
            '    Me.lblMontAbon.Text = Decimal.Round(Me.DecTotalAbonado + DecOtros, 2).ToString

            'End If
            Me.lblMontAbon.Text = Decimal.Round(Me.DecTotalAbonado, 2).ToString
            Me.lblMontRest.Text = Decimal.Round((Me.DecTotalRecibo - Me.DecTotalAbonado), 2).ToString

            If Not IsNothing(Me.DtDatosFactRecibo) Then
                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        contador = contador + 1
                    End If
                Next
            Else
                contador = 0
            End If

            If contador = 0 Then
                Me.DecTotalAbonado = NumMontoDolares.Value
                Me.lblMontAbon.Text = Decimal.Round(Me.DecTotalAbonado + DecOtros, 2).ToString
                Me.lblMontRest.Text = Decimal.Round((Me.DecTotalAbonado - Me.DecTotalAbonado), 2).ToString
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDatosEdicion()
        Dim objSccRecibo As New SccReciboCaja
        'Dim objTasaCambio As New StbTasaCambioOficial
        Dim dtDatos As New DataTable
        Try
            Try
                objSccRecibo.Retrieve(Me.ReciboCajaID)
                txtTasaCambio.Text = objSccRecibo.TipoCambio
                Me.txtNumRecibo.Text = objSccRecibo.Numero
                Me.dtpFecha.Value = objSccRecibo.Fecha
                Me.cmbMoeda.SelectedValue = objSccRecibo.objMonedaID
                Me.cmbPeriodos.SelectedValue = objSccRecibo.objPeriodoID
                Me.cmbTipoPago.SelectedValue = objSccRecibo.objTipoPagoID

                Me.chkEsPrestamo.Checked = objSccRecibo.EsPagoPrestamo

                If Not IsNothing(objSccRecibo.Observaciones) Then
                    txtObservaciones.Text = objSccRecibo.Observaciones
                End If

                If Not IsNothing(objSccRecibo.AtencionA) Then
                    txtAtencionA.Text = objSccRecibo.AtencionA
                End If

                Me.txtEstado.Text = StbValorCatalogo.RetrieveDT("StbValorCatalogoID=" & objSccRecibo.objEstadoID.ToString, , "Descripcion").DefaultView.Item(0)("Descripcion")
                Me.IDCuenta = objSccRecibo.objSccCuentaID

                If chkEsPrestamo.Checked Then
                    CargarFacturasEmpleados()

                    dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Numero, PagoMensual, Plazo, SccCuentaID, Llave, StbEmpleadoID, Empleado, Saldo, objEstadoID, Estado, Activa, Cedula", "vwSccCuentaEmpleado", "SccCuentaID='" & Me.IDCuenta.ToString & "'"))

                    If dtDatos.Rows.Count > 0 Then
                        Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("Numero")
                        Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Empleado")
                        Me.IDCuenta = dtDatos.DefaultView.Item(0)("SccCuentaID")
                        Me.EmpleadoID = dtDatos.DefaultView.Item(0)("StbEmpleadoID")

                    End If
                    DetallesAgregadosEmpleados()


                    If intmoneda = cmbMoeda.SelectedValue Then

                        Me.NumMontoDolares.Value = montoMensualidad ''objSccRecibo.MontoRecibidoEfectivo
                        Me.DecTotalRecibo = objSccRecibo.TotalRecibido
                    Else
                        Me.NumMontoDolares.Value = montoMensualidad ''objSccRecibo.MontoRecibidoEfectivoCordoba
                        Me.DecTotalRecibo = objSccRecibo.TotalRecibidoCordoba
                    End If
                Else

                    Me.CargarFacturas()
                    CargarMora()

                    dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("AlumnoID, NombreCompleto, Codigo, ISNULL(Grupo,'') AS Grupo , SccCuentaID, NumCuenta, Porcentaje", "vwSeleccionEstudianteCuenta", "SccCuentaID='" & Me.IDCuenta.ToString & "'"))

                    If dtDatos.Rows.Count > 0 Then
                        Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("NumCuenta")
                        Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("NombreCompleto")
                        Me.IDCuenta = dtDatos.DefaultView.Item(0)("SccCuentaID")
                        Me.AlumnoID = dtDatos.DefaultView.Item(0)("AlumnoID")
                        Me.txtGrupo.Text = dtDatos.DefaultView.Item(0)("Grupo")
                        Me.SpnPorcentaje.Value = dtDatos.DefaultView.Item(0)("Porcentaje")
                    End If
                    Me.DetallesAgregados()


                    If intmoneda = cmbMoeda.SelectedValue Then

                        Me.NumMontoDolares.Value = montoMensualidad ''objSccRecibo.MontoRecibidoEfectivo
                        Me.DecTotalRecibo = objSccRecibo.TotalRecibido
                    Else
                        Me.NumMontoDolares.Value = montoMensualidad ''objSccRecibo.MontoRecibidoEfectivoCordoba
                        Me.DecTotalRecibo = objSccRecibo.TotalRecibidoCordoba
                    End If
                End If




            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objSccRecibo = Nothing

        End Try
    End Sub

#Region " Detalles de Edicion"

    '--------------------------------------------------------------------------------------------------------------
    ' Descripcion     : Esta funcion se encarga de realizar el proceso de actualizar y poner en estado seleccionado
    '-----------------: todos aquellos detalles que fueron incluidos cuando se creo el recibo.
    '--------------------------------------------------------------------------------------------------------------



    '--------------------------------------------------------------------------------------------------------------
    ' Descripcion     : Esta funcion se encarga de realizar el proceso de actualizar y poner en estado seleccionado
    '-----------------: todos aquellos detalles que fueron incluidos cuando se creo el recibo.
    '--------------------------------------------------------------------------------------------------------------
    Private Sub DetallesAgregados()
        Dim dtTablaProv, dtNotaDebitoProv, dtNotaCreditoProv As New DataTable

        Try
            montoMensualidad = 0

            dtTablaProv = SccReciboDetalle.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objCuentaDetalleID,EsAbono,objReciboCajaID,objConceptoID,Monto,MontoCordobas")

            If dtTablaProv.DefaultView.Count > 0 Then
                If Not IsNothing(dtTablaProv.DefaultView.Item(0)("objConceptoID")) Then
                    cmbConceptoMensualidad.SelectedValue = dtTablaProv.DefaultView.Item(0)("objConceptoID")
                End If

                For Each drwDetAct As DataRow In Me.DtDatosFactRecibo.Rows
                    dtTablaProv.DefaultView.RowFilter = "objCuentaDetalleID=" & drwDetAct("SccCuentaPorCobrarDetalleID")
                    If dtTablaProv.DefaultView.Count <> 0 Then
                        If dtTablaProv.DefaultView.Item(0)("EsAbono") Then
                            drwDetAct("Abonar") = True
                        Else
                            drwDetAct("Cancelar") = True
                        End If
                        drwDetAct("CantAbonar") = dtTablaProv.DefaultView.Item(0)("Monto")
                        montoMensualidad = montoMensualidad + dtTablaProv.DefaultView.Item(0)("MontoCordobas")
                        drwDetAct("Seleccion") = True
                    End If
                Next
                '-----------------------------------------------------------------------------------------------------
            End If


            dtNotaDebitoProv = SccReciboDetMora.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objReciboCajaID,objSccMoraID")
            If dtNotaDebitoProv.DefaultView.Count > 0 Then
                For Each drwDetND As DataRow In Me.DtdatosNotasDebito.Rows
                    dtNotaDebitoProv.DefaultView.RowFilter = "objSccMoraID=" & drwDetND("SccMoraID")
                    If dtNotaDebitoProv.DefaultView.Count <> 0 Then
                        drwDetND("Seleccion") = True
                    Else
                        drwDetND("Seleccion") = False
                    End If
                Next
                '-----------------------------------------------------------------------------------------------------
            End If

            CalcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtTablaProv = Nothing
        End Try
    End Sub

    Private Sub DetallesAgregadosEmpleados()
        Dim dtTablaProv, dtNotaDebitoProv, dtNotaCreditoProv As New DataTable

        Try
            montoMensualidad = 0

            dtTablaProv = SccReciboDetallePrestamo.RetrieveDT("objReciboCajaID = " & Me.ReciboCajaID, , "objCuentaDetalleID,EsAbono,objReciboCajaID,objConceptoID,Monto,MontoCordobas")

            If dtTablaProv.DefaultView.Count > 0 Then
                If Not IsNothing(dtTablaProv.DefaultView.Item(0)("objConceptoID")) Then
                    cmbConceptoMensualidad.SelectedValue = dtTablaProv.DefaultView.Item(0)("objConceptoID")
                End If

                For Each drwDetAct As DataRow In Me.DtDatosFactRecibo.Rows
                    dtTablaProv.DefaultView.RowFilter = "objCuentaDetalleID=" & drwDetAct("SccCuentaPorCobrarDetalleID")
                    If dtTablaProv.DefaultView.Count <> 0 Then
                        If dtTablaProv.DefaultView.Item(0)("EsAbono") Then
                            drwDetAct("Abonar") = True
                        Else
                            drwDetAct("Cancelar") = True
                        End If
                        drwDetAct("CantAbonar") = dtTablaProv.DefaultView.Item(0)("Monto")
                        montoMensualidad = montoMensualidad + dtTablaProv.DefaultView.Item(0)("MontoCordobas")
                        drwDetAct("Seleccion") = True
                    End If
                Next
                '-----------------------------------------------------------------------------------------------------
            End If

            CalcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtTablaProv = Nothing
        End Try
    End Sub

#End Region

#Region "Modificacion de Recibo"
    '--------------------------------------------------------------------------------------------------------------------------
    ' Descripcion       : Esta funcion se encarga de realizar el proceso de modificacion de un recibo X.
    '--------------------------------------------------------------------------------------------------------------------------
    Private Function ModificarRecibo() As Boolean
        Dim boolRst As Boolean
        Dim objDetNotaDebito As SccReciboDetMora
        Dim dtDetalles As New DataTable
        Dim objOtrosPagos As SccOtrosPagosRecibo
        Dim MoraPagada, MoraPendiente As Integer
        Dim T As New TransactionManager
        Try
            MoraPagada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "PAGADA")
            MoraPendiente = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "AUTORIZADA")

            If (Me.dtpFecha.Value.Date > clsProyecto.Conexion.FechaServidor.Date) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha Incorrecta")
                Exit Function
            End If

            If Not ValidarDetalleFact() Then
                Me.ErrorProv.SetError(Me.lblError, "Datos Imcompletos")
                Exit Function
            End If

            If Trim(Me.cmbPeriodos.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbPeriodos, "Campo Obligatorio.")
                Exit Function
            End If

            If Trim(Me.cmbCajero.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbCajero, "Campo Obligatorio.")
                Exit Function
            End If

            If txtCliente.Text.Trim.Length = 0 And txtAtencionA.Text.Trim.Length = 0 Then
                MsgBox("Defina un expediente y/o Atencion A.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Function
            End If

            'If Trim(Me.cmbConceptoRecibo.Text) = "" Then
            '    Me.ErrorProv.SetError(Me.cmbConceptoRecibo, "Campo Obligatorio.")
            '    Exit Function
            'End If

            If Trim(Me.cmbMoeda.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbMoeda, "Campo Obligatorio.")
                Exit Function
            End If

            If Trim(Me.cmbTipoPago.Text) = "" Then
                Me.ErrorProv.SetError(Me.cmbTipoPago, "Campo Obligatorio.")
                Exit Function
            End If

            Dim contador As Integer = 0

            If Not IsNothing(Me.DtDatosFactRecibo) Then
                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        contador = contador + 1
                    End If
                Next
            Else
                contador = 0
            End If

            'If contador > 0 Then
            '    If (Decimal.Round(Me.DecTotalAbonado, 2) <> Decimal.Round(Me.DecTotalRecibo, 2)) Or (Me.txtTotalPagar.Value = 0) Then
            '        Me.ErrorProv.SetError(Me.lblError, "Montos no coinciden")
            '        Exit Function
            '    End If
            'End If

            If cmbConceptoMensualidad.Text.Trim.Length = 0 And NumMontoDolares.Value <> 0 Then
                Me.ErrorProv.SetError(Me.cmbConceptoMensualidad, "Campo Obligatorio.")
                Exit Function
            End If

            T.BeginTran()

            RevertirSaldo(T)
            '---------------------------Actualizamos el recibo---------------------------------------
            Me.objReciboCaja = New SccReciboCaja
            Me.objReciboCaja.Retrieve(Me.ReciboCajaID, T)
            Me.objReciboCaja.Numero = Trim(Me.txtNumRecibo.Text)
            Me.objReciboCaja.Fecha = Me.dtpFecha.Value
            Me.objReciboCaja.AtencionA = txtAtencionA.Text
            Me.objReciboCaja.Observaciones = txtObservaciones.Text

            If intmoneda = cmbMoeda.SelectedValue Then

                If contador = 0 Then
                    Me.objReciboCaja.TotalRecibido = txtTotalPagar.Text
                    Me.objReciboCaja.TotalRecibidoCordoba = txtTotalPagar.Text * Convert.ToDouble(txtTasaCambio.Text)
                Else
                    Me.objReciboCaja.TotalRecibido = Me.DecTotalRecibo
                    Me.objReciboCaja.TotalRecibidoCordoba = Me.DecTotalRecibo * Convert.ToDouble(txtTasaCambio.Text)
                End If

                Me.objReciboCaja.MontoRecibidoEfectivo = Convert.ToDouble(Me.txtTotalPagar.Value)
                Me.objReciboCaja.MontoRecibidoEfectivoCordoba = Convert.ToDouble(Me.txtTotalPagar.Value) * Convert.ToDouble(txtTasaCambio.Text)
            Else
                If contador = 0 Then
                    Me.objReciboCaja.TotalRecibido = txtTotalPagar.Text / Convert.ToDouble(txtTasaCambio.Text)
                    Me.objReciboCaja.TotalRecibidoCordoba = txtTotalPagar.Text
                Else
                    Me.objReciboCaja.TotalRecibido = Me.DecTotalRecibo / Convert.ToDouble(txtTasaCambio.Text)
                    Me.objReciboCaja.TotalRecibidoCordoba = Me.DecTotalRecibo
                End If
                Me.objReciboCaja.MontoRecibidoEfectivo = Convert.ToDouble(Me.txtTotalPagar.Value) / Convert.ToDouble(txtTasaCambio.Text)
                Me.objReciboCaja.MontoRecibidoEfectivoCordoba = Convert.ToDouble(Me.txtTotalPagar.Value)
            End If

            Me.objReciboCaja.objTipoPagoID = cmbTipoPago.SelectedValue
            Me.objReciboCaja.objCajeroID = cmbCajero.SelectedValue
            Me.objReciboCaja.objMonedaID = cmbMoeda.SelectedValue
            Me.objReciboCaja.objPeriodoID = cmbPeriodos.SelectedValue
            Me.objReciboCaja.objCajaID = intCajaID
            Me.objReciboCaja.TipoCambio = txtTasaCambio.Text
            Me.objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
            Me.objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
            Me.objReciboCaja.objSccCuentaID = Me.IDCuenta
            Me.objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO")
            Me.objReciboCaja.Update(T)

            Dim objReciboDetalle As New SccReciboDetalle
            SccReciboDetalle.DeleteByFilter("objReciboCajaID=" & Me.objReciboCaja.SccReciboCajaID, T)
            If chkEsPrestamo.Checked Then

                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        objReciboDetalle.objCuentaDetalleID = DrwDetalle("SccCuentaPorCobrarDetalleID")
                        objReciboDetalle.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID

                        objReciboDetalle.Monto = DrwDetalle("CantAbonar")
                        objReciboDetalle.MontoCordobas = Convert.ToDouble(DrwDetalle("CantAbonar"))

                        'If intmoneda = cmbMoeda.SelectedValue Then

                        'Else
                        '    objReciboDetalle.MontoCordobas = DrwDetalle("CantAbonar")
                        '    objReciboDetalle.Monto = Convert.ToDouble(DrwDetalle("CantAbonar")) / Convert.ToDouble(txtTasaCambio.Text)
                        'End If

                        If DrwDetalle("CantAbonar") = DrwDetalle("MontoInicial") Then
                            objReciboDetalle.EsAbono = False
                        Else
                            objReciboDetalle.EsAbono = True

                        End If
                        objReciboDetalle.objConceptoID = cmbConceptoMensualidad.SelectedValue
                        objReciboDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objReciboDetalle.Insert(T)
                    End If
                Next
            Else

                For Each DrwDetalle As DataRow In Me.DtDatosFactRecibo.Rows
                    If DrwDetalle("Seleccion") Then
                        objReciboDetalle.objCuentaDetalleID = DrwDetalle("SccCuentaPorCobrarDetalleID")
                        objReciboDetalle.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID

                        objReciboDetalle.Monto = DrwDetalle("CantAbonar")
                        objReciboDetalle.MontoCordobas = Convert.ToDouble(DrwDetalle("CantAbonar")) * Convert.ToDouble(txtTasaCambio.Text)

                        If DrwDetalle("CantAbonar") = DrwDetalle("MontoInicial") Then
                            objReciboDetalle.EsAbono = False
                        Else
                            objReciboDetalle.EsAbono = True

                        End If
                        objReciboDetalle.objConceptoID = cmbConceptoMensualidad.SelectedValue
                        objReciboDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objReciboDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objReciboDetalle.Insert(T)
                    End If
                Next
            End If

            '-------------------------------------------------------------------------------------------
            '---------------Creamos los detalles para las notas de debito-------------------------------
            Dim objMora As New SccMora

            SccReciboDetMora.DeleteByFilter("objReciboCajaID=" & Me.objReciboCaja.SccReciboCajaID, T)
            If Not IsNothing(Me.DtdatosNotasDebito) Then
                objDetNotaDebito = New SccReciboDetMora
                For Each DrwNDINC As DataRow In Me.DtdatosNotasDebito.Rows
                    If DrwNDINC("Seleccion") Then
                        objDetNotaDebito.objSccMoraID = DrwNDINC("SccMoraID")
                        objDetNotaDebito.objReciboCajaID = Me.objReciboCaja.SccReciboCajaID
                        objDetNotaDebito.objSccCuentaPorCobrarDetalleID = DrwNDINC("objSccCuentaPorCobrarDetalleID")
                        objDetNotaDebito.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDetNotaDebito.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDetNotaDebito.Insert(T)

                        ''Modificar Mora
                        objMora.Retrieve(DrwNDINC("SccMoraID"), T)
                        objMora.objEstadoID = MoraPagada
                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objMora.Update(T)
                    Else
                        ''Modificar Mora
                        objMora.Retrieve(DrwNDINC("SccMoraID"), T)
                        objMora.objEstadoID = MoraPendiente
                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objMora.Update(T)
                    End If
                Next
            End If

            SccOtrosPagosRecibo.DeleteByFilter("objSccReciboID=" & Me.objReciboCaja.SccReciboCajaID, T)
            If Not IsNothing(Me.dtOtrosPagos) Then
                objOtrosPagos = New SccOtrosPagosRecibo
                For Each DrwOtros As DataRow In Me.dtOtrosPagos.Rows
                    objOtrosPagos.objSccReciboID = ReciboCajaID
                    objOtrosPagos.objConceptoID = DrwOtros("objConceptoID")
                    objOtrosPagos.Monto = DrwOtros("Monto")
                    objOtrosPagos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objOtrosPagos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objOtrosPagos.Insert(T)
                Next
            End If

            Me.PROCESAR_RECIBO(Me.ReciboCajaID, 0, T)
            T.CommitTran()
            Me.BoolResult = True
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            'BloquearColumnasModoConsulta()
            clsProyecto.CargarTemaDefinido(Me)
            Me.cmdGuardar.Enabled = False
            boolRst = True

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            dtDetalles = Nothing
            T = Nothing
        End Try
        Return boolRst
    End Function

#End Region

#End Region









End Class