Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccConsultarArqueo

#Region "Declaracion de Variables"

    Public intTypeGui As Integer
    Public intArqueoID As Integer
    Public intCajaID As Integer
    Dim dtCajeros, dtDetalle, dtDetalleRecibos As DataTable
    Public intmonedaDol, intmonedacor As Integer
    Public intTotalArqueo As Decimal
    Dim dtDesgloseCordobas, dtDesgloseDolares As DataTable
    Dim intNuevoCor, intNuevoDol As Boolean


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

    Property ArqueoID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

    Property CajaID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Private Sub CalcularPromedio()
        Dim TotalCor As Integer = 0
        Dim TotalDol As Integer = 0
        Try
            If Not Me.dtDesgloseCordobas Is Nothing Then
                For Each row As DataRow In Me.dtDesgloseCordobas.Rows
                    TotalCor = TotalCor + (row("Cantidad") * row("Descripcion"))
                Next
            End If

            If Not Me.dtDesgloseDolares Is Nothing Then
                For Each row As DataRow In Me.dtDesgloseDolares.Rows
                    TotalDol = TotalDol + (row("Cantidad") * row("Descripcion"))
                Next
            End If

            txtBilletesCor.Text = TotalCor
            txtBilletesDolar.Text = TotalDol
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Function ValidarEntrada() As Boolean

        Try
            If dtFecha.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dtFecha, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True

    End Function

    Public Sub CargarInformacionArqueoInicial()
        Dim dblIngreso As Decimal

        Try
            dblIngreso = 0
            dtDetalleRecibos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccReciboCajaID, NumeroRecibo, Alumno, objCajaID, objTipoPagoID, objConceptoID, objMonedaID, TipoPago, TotalRecibido, Moneda, Concepto, Fecha, TipoCambio, TotalCordobas", "vwArqueoDetalle", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("TipoPago,ISNULL(SUM(Entrada),0) as Entrada, Moneda, Concepto, convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidado", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY TipoPago,Moneda,Concepto,convert(varchar(10),Fecha,103)"))
            grdDetalle.DataSource = dtDetalle

            For Each drw As DataRow In Me.dtDetalle.Rows
                dblIngreso = dblIngreso + drw("Entrada")
            Next

            spnIngreso.Value = dblIngreso
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarInformacionArqueoAnterior()
        Dim dblIngreso As Decimal
        Dim dtDetalleConsultar As DataTable
        Try

            dblIngreso = 0
            'dtDetallaFacturas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccReciboCajaID, TipoPago,Fecha, TotalRecibido, objEstadoID,  Moneda, Concepto", "vwSccReciboCaja", "Estado= 'Pagado' and convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))
            dtDetalleRecibos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccReciboCajaID, NumeroRecibo, Alumno, objCajaID, objTipoPagoID, objConceptoID, objMonedaID, TipoPago, TotalRecibido, Moneda, Concepto, Fecha, TipoCambio, TotalCordobas", "vwArqueoDetalle", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            dtDetalleConsultar = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Concepto, SUM(Entrada) as Entrada, Moneda, TipoPago, convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidadoFinal", "Cerrado= 1 and convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY Concepto, Moneda, TipoPago,convert(varchar(10),Fecha,103)"))
            If dtDetalleConsultar.Rows.Count > 0 Then
                MsgBox("La fecha seleccionada ya tiene un arqueo cerrado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return
            End If

            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("TipoPago,ISNULL(SUM(Entrada),0) as Entrada, Moneda, Concepto, convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidado", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY TipoPago,Moneda,Concepto,convert(varchar(10),Fecha,103)"))

            If dtDetalle.Rows.Count = 0 Then
                MsgBox("No hay datos para generar el arqueo a esta fecha.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return
            End If

            grdDetalle.DataSource = dtDetalle

            For Each drw As DataRow In Me.dtDetalle.Rows
                dblIngreso = dblIngreso + drw("Entrada")
            Next

            spnIngreso.Value = dblIngreso

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajeros()
        Try
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
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Dim objCajero As New SccCajas
        Try
            CargarCajeros()
            cmbCajero.Enabled = False
            Select Case TypeGui
                Case 0
                    Me.dtFecha.DateTime = clsProyecto.Conexion.FechaServidor
                    Me.Text = "Visualizar arqueo"
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    chkCerrado.Enabled = False
                    Me.cmbCajero.Enabled = False
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja

                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")

                    If Not IsNothing(objCajero.objCajeroID) Then
                        cmbCajero.SelectedValue = objCajero.objCajeroID
                    End If
                    txtObservaciones.Enabled = False
                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 1
                    Me.Text = "Aprobar arqueo"
                    Me.dtFecha.DateTime = clsProyecto.Conexion.FechaServidor
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
                    chkCerrado.Enabled = False
                    chkCerrado.Checked = True
                    If Not IsNothing(objCajero.objCajeroID) Then
                        cmbCajero.SelectedValue = objCajero.objCajeroID
                    End If

                    txtAprobadoPor.Enabled = True
                    spnFaltante.Enabled = True
                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 2
                    Me.Text = "Consultar Caja"
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
                    CargarDatosArqueo()
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    cmbCajero.Enabled = False
                    txtObservaciones.Enabled = False
                Case 3
                    Me.Text = "Aprobar arqueo"
                    Me.dtFecha.DateTime = clsProyecto.Conexion.FechaServidor
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCaja
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")
                    chkCerrado.Enabled = False
                    chkCerrado.Checked = True
                    dtFecha.Enabled = True

                    If Not IsNothing(objCajero.objCajeroID) Then
                        cmbCajero.SelectedValue = objCajero.objCajeroID
                    End If
                    CargarInformacionArqueoInicial()
                    txtAprobadoPor.Enabled = True
                    spnFaltante.Enabled = True
                    cmdActualizar.Visible = True
            End Select

            intmonedaDol = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "USD")
            intmonedacor = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "COR")
            CargarGrid()
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarGrid()
        intNuevoCor = False
        intNuevoDol = False
        Try
            dtDesgloseCordobas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccDenominacionID, StbValorCatalogoID, Descripcion, Cantidad, objArqueoCajaID", "vwSccDenominacionCordoba", " objArqueoCajaID=" & ArqueoID))

            If dtDesgloseCordobas.Rows.Count = 0 Then
                intNuevoCor = True
                dtDesgloseCordobas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccDenominacionID, StbValorCatalogoID, Descripcion, Cantidad, objArqueoCajaID", "vwSccDenominacionCordobaES", " 1=1"))
            End If

            dtDesgloseDolares = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccDenominacionID, StbValorCatalogoID, Descripcion, Cantidad, objArqueoCajaID", "vwSccDenominacionDolar", " objArqueoCajaID=" & ArqueoID))

            If dtDesgloseDolares.Rows.Count = 0 Then
                intNuevoDol = True
                dtDesgloseDolares = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccDenominacionID, StbValorCatalogoID, Descripcion, Cantidad, objArqueoCajaID", "vwSccDenominacionDolarES", " 1=1"))
            End If

            grdBilletesCor.DataSource = dtDesgloseCordobas
            grdBilletesCor.ForceInitialize()

            grdBilletesDolar.DataSource = dtDesgloseDolares
            grdBilletesDolar.ForceInitialize()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim objcaja As SccCajas
        Dim objCajero As New SccCajas

        Try
            objArqueo = New SccArqueoCaja
            objcaja = New SccCajas

            objArqueo.Retrieve(ArqueoID)
            txtAprobadoPor.Text = objArqueo.AprobadoPor
            chkCerrado.Checked = objArqueo.Cerrado
            spnIngreso.Value = objArqueo.EntradaEfectivo

            If Not IsNothing(objArqueo.objCajeroID) Then
                cmbCajero.SelectedValue = objArqueo.objCajeroID
            End If

            If Not IsNothing(objArqueo.Observaciones) Then
                txtObservaciones.Text = objArqueo.Observaciones
            End If

            dtFecha.DateTime = objArqueo.Fecha
            spnFaltante.Value = objArqueo.Faltante
            chkCerrado.Checked = objArqueo.Cerrado

            If Not IsNothing(objArqueo.objCajaID) Then
                objcaja.Retrieve(objArqueo.objCajaID)
                lblCaja.Text = "Caja: " & objcaja.Codigo
            Else
                lblCaja.Text = "Caja: Migracion "
            End If

            'dtDetallaFacturas = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SccReciboCajaID, TipoPago,Fecha, TotalRecibido, objEstadoID,  Moneda, Concepto", "vwSccReciboCaja", "Estado= 'Pagado' and convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd")))

            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Concepto, SUM(Entrada) as Entrada, Moneda, TipoPago, convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidadoFinal", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY Concepto, Moneda, TipoPago,convert(varchar(10),Fecha,103)"))
            grdDetalle.DataSource = dtDetalle

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    Private Sub GuardarDatosDesglose(T As DAL.TransactionManager)
        Try
            Dim objDenominacion As New SccDenominacionBilletes
            If intNuevoCor Then
                For Each row As DataRow In Me.dtDesgloseCordobas.Rows

                    objDenominacion.objArqueoCajaID = intArqueoID
                    objDenominacion.objMonedaID = intmonedacor
                    objDenominacion.objBilleteID = row("StbValorCatalogoID")
                    objDenominacion.Cantidad = row("Cantidad")
                    objDenominacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objDenominacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objDenominacion.Insert(T)
                Next
            Else
                For Each row As DataRow In Me.dtDesgloseCordobas.Rows
                    If row("SccDenominacionID") = 0 Then
                        objDenominacion.objArqueoCajaID = intArqueoID
                        objDenominacion.objMonedaID = intmonedacor
                        objDenominacion.objBilleteID = row("StbValorCatalogoID")
                        objDenominacion.Cantidad = row("Cantidad")
                        objDenominacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDenominacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDenominacion.Insert(T)
                    Else
                        objDenominacion.Retrieve(row("SccDenominacionID"))

                        objDenominacion.objArqueoCajaID = intArqueoID
                        objDenominacion.objMonedaID = intmonedacor
                        objDenominacion.objBilleteID = row("StbValorCatalogoID")
                        objDenominacion.Cantidad = row("Cantidad")
                        objDenominacion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objDenominacion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objDenominacion.Update(T)
                    End If

                Next
            End If

            If intNuevoDol Then
                For Each row As DataRow In Me.dtDesgloseDolares.Rows

                    objDenominacion.objArqueoCajaID = intArqueoID
                    objDenominacion.objMonedaID = intmonedaDol
                    objDenominacion.objBilleteID = row("StbValorCatalogoID")
                    objDenominacion.Cantidad = row("Cantidad")
                    objDenominacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objDenominacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objDenominacion.Insert(T)
                Next
            Else
                For Each row As DataRow In Me.dtDesgloseDolares.Rows
                    If row("SccDenominacionID") = 0 Then
                        objDenominacion.objArqueoCajaID = intArqueoID
                        objDenominacion.objMonedaID = intmonedaDol
                        objDenominacion.objBilleteID = row("StbValorCatalogoID")
                        objDenominacion.Cantidad = row("Cantidad")
                        objDenominacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objDenominacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objDenominacion.Insert(T)
                    Else
                        objDenominacion.Retrieve(row("SccDenominacionID"))

                        objDenominacion.objArqueoCajaID = intArqueoID
                        objDenominacion.objMonedaID = intmonedaDol
                        objDenominacion.objBilleteID = row("StbValorCatalogoID")
                        objDenominacion.Cantidad = row("Cantidad")
                        objDenominacion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objDenominacion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objDenominacion.Update(T)
                    End If
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub

    '' Descripción:        Procedimie   nto encargado de crear un nuevo arqueo
    Public Sub GuardarArqueo()
        Dim objArqueo As SccArqueoCaja
        Dim objArqueoBuscar As SccArqueoCaja
        Dim T As New DAL.TransactionManager
        Dim intArqueoEliminar As Integer
        Try
            T.BeginTran()
            objArqueo = New SccArqueoCaja
            objArqueoBuscar = New SccArqueoCaja

            If TypeGui = 3 Then
                objArqueoBuscar.RetrieveByFilter("convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd"), T)
                intArqueoEliminar = objArqueoBuscar.ArqueoID
                ''Verificamos si el arqueo tiene asociado un deposito

                SccDenominacionBilletes.DeleteByFilter("objArqueoCajaID=" & intArqueoEliminar, T)
                SccArqueoCajaDetalle.DeleteByFilter("objArqueoID =" & intArqueoEliminar, T)
                SccArqueoRecibo.DeleteByFilter("objArqueoID =" & intArqueoEliminar, T)
                SccArqueoCaja.DeleteByFilter("ArqueoID =" & intArqueoEliminar, T)

            End If

            objArqueo.Fecha = dtFecha.DateTime
            objArqueo.EntradaEfectivo = spnIngreso.Value
            objArqueo.Faltante = spnFaltante.Value
            objArqueo.AprobadoPor = txtAprobadoPor.Text
            objArqueo.objCajaID = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
            objArqueo.objCajeroID = cmbCajero.SelectedValue
            objArqueo.Cerrado = chkCerrado.Checked
            objArqueo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objArqueo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objArqueo.Insert(T)
            ArqueoID = objArqueo.ArqueoID

            Dim objArqueoDetalle As New SccArqueoCajaDetalle
            If Not IsNothing(dtDetalle) Then
                For Each DrwDetalle As DataRow In Me.dtDetalle.Rows
                    objArqueoDetalle.objArqueoID = ArqueoID
                    objArqueoDetalle.TipoPago = DrwDetalle("TipoPago")
                    objArqueoDetalle.Moneda = DrwDetalle("Moneda")
                    objArqueoDetalle.Concepto = DrwDetalle("Concepto")
                    objArqueoDetalle.Entrada = DrwDetalle("Entrada")
                    objArqueoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objArqueoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objArqueoDetalle.Insert(T)
                Next
            End If

            ''Guardar en la tabla detalle del arqueo
            Dim objRecibos As New SccArqueoRecibo
            If Not IsNothing(dtDetalleRecibos) Then
                For Each DrwDetalleR As DataRow In Me.dtDetalleRecibos.Rows
                    objRecibos.objArqueoID = ArqueoID
                    objRecibos.objConceptoID = DrwDetalleR("objConceptoID")
                    objRecibos.objMonedaID = DrwDetalleR("objMonedaID")
                    objRecibos.objTipoPagoID = DrwDetalleR("objTipoPagoID")
                    objRecibos.objCajaID = DrwDetalleR("objCajaID")
                    objRecibos.objSccReciboCajaID = DrwDetalleR("SccReciboCajaID")
                    objRecibos.Alumno = DrwDetalleR("Alumno")
                    objRecibos.NumRecibo = DrwDetalleR("NumeroRecibo")
                    objRecibos.TotalRecibido = DrwDetalleR("TotalRecibido")
                    objRecibos.TotalCordobas = DrwDetalleR("TotalCordobas")
                    objRecibos.Contabilizado = False
                    objRecibos.Fecha = dtFecha.DateTime
                    objRecibos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objRecibos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objRecibos.Insert(T)
                Next
            End If

            GuardarDatosDesglose(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If Me.cmbCajero.Text = String.Empty Or IsNothing(cmbCajero.SelectedValue) Then
                Me.ErrorProv.SetError(Me.cmbCajero, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.txtAprobadoPor.Text = String.Empty Then
                Me.ErrorProv.SetError(Me.txtAprobadoPor, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos del formulario"

    Private Sub frmSccConsultarArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        If Me.ValidarDatos Then
            GuardarArqueo()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtAprobadoPor_TextChanged(sender As Object, e As EventArgs) Handles txtAprobadoPor.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs)
        Me.ErrorProv.Clear()
    End Sub

    Private Sub grdBilletesTabla_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdBilletesTabla.CellValueChanged
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If ValidarEntrada() Then
            CargarInformacionArqueoAnterior()
        End If

    End Sub

    Private Sub grdBilletesTabla_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdBilletesTabla.CellValueChanging
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdBilletesDolarTabla_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdBilletesDolarTabla.CellValueChanged
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdBilletesDolarTabla_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdBilletesDolarTabla.CellValueChanging
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdConsultarDetalle_Click(sender As Object, e As EventArgs) Handles cmdConsultarDetalle.Click
        Dim objConsultarDetalle As frmSccConsultarDetalleArqueo
        Dim objCaja As New SccCajas
        Try
            objConsultarDetalle = New frmSccConsultarDetalleArqueo
            objConsultarDetalle.Fecha = dtFecha.EditValue

            objCaja.RetrieveByFilter("Codigo='" & frmPrincipal.gblCaja & "'")

            If Not IsNothing(objCaja.objCajeroID) Then
                cmbCajero.SelectedValue = objCaja.objCajeroID
            End If
            If Not IsNothing(objCaja.SccCajaID) Then
                intCajaID = objCaja.SccCajaID
            End If

            objConsultarDetalle.CajaID = intCajaID

            If TypeGui = 0 Or TypeGui = 1 Or TypeGui = 3 Then
                objConsultarDetalle.TypeGui = 0
                objConsultarDetalle.PdtDetallaRecibos = Me.dtDetalleRecibos
            Else
                objConsultarDetalle.TypeGui = 1
                objConsultarDetalle.ArqueoID = ArqueoID
            End If

            objConsultarDetalle.ShowDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region


End Class