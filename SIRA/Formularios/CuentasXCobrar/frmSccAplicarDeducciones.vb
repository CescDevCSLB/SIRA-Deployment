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
Public Class frmSccAplicarDeducciones

#Region "Variables"

    Dim intCuentaID, intPagado, intPendiente, intCuentaMasterCancelada, intCuentaMasterVigente As Integer
    Dim DtDatosCuotas, DtPersona As New DataTable
    Dim strEmpleadoID As String
    Dim intType As Integer
#End Region

#Region "Propiedades"

    'Variables para tratamiento de "Reestructuración de Cuenta"

    Property CuentaID() As Integer
        Get
            CuentaID = Me.intCuentaID
        End Get
        Set(ByVal value As Integer)
            Me.intCuentaID = value
        End Set
    End Property

    Property Type() As Integer
        Get
            Type = Me.intType
        End Get
        Set(ByVal value As Integer)
            Me.intType = value
        End Set
    End Property

#End Region



#Region "Eventos del formulario"

    Private Sub frmSccEditReciboCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objCaja As New SccCajas
        Try
            Me.Cursor = Cursors.WaitCursor
            intPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02")
            intPendiente = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")

            intCuentaMasterCancelada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "02")
            intCuentaMasterVigente = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")

            Select Case intType
                Case 0
                    CargarDatos()
                Case 1
                    CargarDatosAplciados()
            End Select

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Eventos de botones"

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

#Region "Procedimientos"

    Public Sub VincularControles()
        Try
            Me.txtNombreCompleto.Text = IIf(IsDBNull(DtPersona.Rows(0)("NombreCompleto")), String.Empty, DtPersona.Rows(0)("NombreCompleto"))
            Me.txtIdentificacion.Text = IIf(IsDBNull(DtPersona.Rows(0)("Cedula")), String.Empty, DtPersona.Rows(0)("Cedula"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Public Sub CargarDatos()
        Dim dtMesesPagados As New DataTable
        Dim objSccCuenta As SccCuentaPorCobrarEmpleados
        Try

            objSccCuenta = New SccCuentaPorCobrarEmpleados

            objSccCuenta.Retrieve(CuentaID)
            Me.txtCuenta.Text = objSccCuenta.Numero
            Me.txtEstadoCuenta.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
            strEmpleadoID = objSccCuenta.objEmpleadoID
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbEmpleadoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion", "vwStbEmpleados", "StbEmpleadoID =" & strEmpleadoID))
            VincularControles()

            ''Cargar detalle de las mensualidades
            CargarDetalleMeses()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarDatosAplciados()
        Dim dtMesesPagados As New DataTable
        Dim objSccCuenta As SccCuentaPorCobrarEmpleados
        Try

            objSccCuenta = New SccCuentaPorCobrarEmpleados

            objSccCuenta.Retrieve(CuentaID)
            Me.txtCuenta.Text = objSccCuenta.Numero
            Me.txtEstadoCuenta.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
            strEmpleadoID = objSccCuenta.objEmpleadoID
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbEmpleadoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion", "vwStbEmpleados", "StbEmpleadoID =" & strEmpleadoID))
            VincularControles()
            colIncluir.Caption = "Revertir"
            cmdGuardar.Text = "Revertir"

            ''Cargar detalle de las mensualidades
            CargarDetalleMesesAplicados()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOCUENTA'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
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
    Private Sub CargarDetalleMeses()
        Dim sConsulta As String
        Try

            Me.DtDatosCuotas = New DataTable

            sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetPagosEmpleados", "objSccCuentaPorCobrarID='" & Me.CuentaID & "'")
            Me.DtDatosCuotas = SqlHelper.ExecuteQueryDT(sConsulta)
            Me.grdMensualidades.DataSource = DtDatosCuotas

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarDetalleMesesAplicados()
        Dim sConsulta As String
        Try

            Me.DtDatosCuotas = New DataTable

            sConsulta = clsConsultas.ObtenerConsultaGeneral("*,CAST(0 AS BIT) AS Seleccion,CAST(0 AS BIT) AS Abonar,CAST(0 AS BIT) AS Cancelar,CAST(0 AS DECIMAL) as CantAbonar", "vwSccReciboDetPagosEmpleadosAplicados", "objSccCuentaPorCobrarID='" & Me.CuentaID & "'")
            Me.DtDatosCuotas = SqlHelper.ExecuteQueryDT(sConsulta)
            Me.grdMensualidades.DataSource = DtDatosCuotas

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#Region "Calculo de Totales"
    ''' <summary>
    ''' Procedimiento Encargado de Llevar a Cabo el Calculo de Total a Pagar del Recibo.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalcularTotales()
        Dim DecSumMontoFactura As Decimal
        Dim obj As New Object
        Try

            '-------------------------------------------------------------------------------------------------
            '------------------Calculamos el Total por todas las facturas incluidas-------

            If Not Me.DtDatosCuotas Is Nothing Then
                If Me.DtDatosCuotas.DefaultView.Count > 0 Then
                    obj = Me.DtDatosCuotas.Compute("SUM(MontoCordobas)", " Seleccion = 'TRUE'")
                    If Not IsDBNull(obj) Then
                        DecSumMontoFactura = obj
                    End If
                End If
            End If
            txtTotalFact.Value = DecSumMontoFactura
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#End Region

#Region "Eventos de controles"

    Private Sub cmbConceptoMensualidad_TextChanged(sender As Object, e As EventArgs)
        Me.ErrorProv.Clear()
    End Sub



    Private Sub numMontoDetalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numMontoDetalle.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.numMontoDetalle.Value <> 0 Then
                Me.cmdAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub numConvertirT_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Me.numMontoDetalle.Value <> 0 Then
                Me.cmdAgregar.Focus()
            End If
        End If
    End Sub

    Private Sub cmbPeriodos_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodos.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbConceptoRecibo_TextChanged(sender As Object, e As EventArgs) Handles cmbConceptoRecibo.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbMoeda_TextChanged(sender As Object, e As EventArgs) Handles cmbMoeda.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs)
        Me.ErrorProv.Clear()
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


            CalcularTotales()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub grdMensualidadesTabla_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdMensualidadesTabla.CellValueChanged

        Try
            DtDatosCuotas.AcceptChanges()
            grdMensualidadesTabla.RefreshData()
            Me.CalcularTotales()

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
                If blnSeleccionar Then
                    Me.DtDatosCuotas.DefaultView.Item(FilaActual)("Seleccion") = True
                Else
                    Me.DtDatosCuotas.DefaultView.Item(FilaActual)("Seleccion") = False
                End If

                DtDatosCuotas.AcceptChanges()
                grdMensualidadesTabla.RefreshData()
                Me.CalcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub AplicarPagos()
        Dim objCuotaAplicadas As SccCuotasAplicadas
        Dim objCuentaDetalle As SccCuentaPorCobrarDetalleEmpleados
        Dim objCuenta As SccCuentaPorCobrarEmpleados
        Dim t As New TransactionManager
        Dim dblSaldoAplicar As Decimal
        Try
            objCuotaAplicadas = New SccCuotasAplicadas
            objCuentaDetalle = New SccCuentaPorCobrarDetalleEmpleados
            objCuenta = New SccCuentaPorCobrarEmpleados
            dblSaldoAplicar = 0

            t.BeginTran()

            If Not IsNothing(Me.DtDatosCuotas) Then
                For Each DrwDetalle As DataRow In Me.DtDatosCuotas.Rows
                    If DrwDetalle("Seleccion") Then

                        ''Insertar en la tabla de cuotas aplicadas
                        objCuotaAplicadas.objCuentaID = CuentaID
                        objCuotaAplicadas.objCuentaDetalleID = DrwDetalle("SccCuentaPorCobrarDetalleID")
                        objCuotaAplicadas.Monto = Convert.ToDouble(DrwDetalle("MontoCordobas"))
                        objCuotaAplicadas.Activa = True
                        objCuotaAplicadas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objCuotaAplicadas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objCuotaAplicadas.Insert(t)

                        ''Actualizar el detalle de la cuenta
                        objCuentaDetalle.Retrieve(DrwDetalle("SccCuentaPorCobrarDetalleID"))
                        objCuentaDetalle.MontoPagado = objCuentaDetalle.MontoPagado + Convert.ToDouble(DrwDetalle("MontoCordobas"))
                        objCuentaDetalle.objEstadoID = intPagado
                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaDetalle.Update(t)

                        dblSaldoAplicar = dblSaldoAplicar + Convert.ToDouble(DrwDetalle("MontoCordobas"))

                    End If
                Next

                ''Actualizar dato del maestro de la cuenta
                objCuenta.Retrieve(CuentaID)
                objCuenta.Saldo = objCuenta.Saldo - dblSaldoAplicar

                If objCuenta.Saldo = 0 Then
                    objCuenta.objEstadoID = intCuentaMasterCancelada
                Else
                    objCuenta.objEstadoID = intCuentaMasterVigente
                End If

                objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objCuenta.Update(t)

                t.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCuotaAplicadas = Nothing
            objCuentaDetalle = Nothing
        End Try
    End Sub

    Private Sub RevertirPagos()
        Dim objCuotaAplicadas As SccCuotasAplicadas
        Dim objCuenta As SccCuentaPorCobrarEmpleados
        Dim objCuentaDetalle As SccCuentaPorCobrarDetalleEmpleados
        Dim dblSaldoRevertir As Decimal

        Dim t As New TransactionManager
        Try
            objCuotaAplicadas = New SccCuotasAplicadas
            objCuenta = New SccCuentaPorCobrarEmpleados
            objCuentaDetalle = New SccCuentaPorCobrarDetalleEmpleados
            dblSaldoRevertir = 0

            t.BeginTran()

            If Not IsNothing(Me.DtDatosCuotas) Then
                For Each DrwDetalle As DataRow In Me.DtDatosCuotas.Rows
                    If DrwDetalle("Seleccion") Then

                        ''Insertar en la tabla de cuotas aplicadas
                        objCuotaAplicadas.Retrieve(DrwDetalle("SccAplicadoID"))
                        objCuotaAplicadas.Activa = False
                        objCuotaAplicadas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuotaAplicadas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuotaAplicadas.Update(t)

                        ''Actualizar el detalle de la cuenta
                        objCuentaDetalle.Retrieve(DrwDetalle("SccCuentaPorCobrarDetalleID"))
                        objCuentaDetalle.MontoPagado = objCuentaDetalle.MontoPagado - Convert.ToDouble(DrwDetalle("MontoPagado"))
                        objCuentaDetalle.objEstadoID = intPendiente
                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuentaDetalle.Update(t)

                        dblSaldoRevertir = dblSaldoRevertir + Convert.ToDouble(DrwDetalle("MontoPagado"))
                    End If
                Next

                ''Actualizar dato del maestro de la cuenta
                objCuenta.Retrieve(CuentaID)
                objCuenta.Saldo = objCuenta.Saldo + dblSaldoRevertir
                objCuenta.objEstadoID = intCuentaMasterVigente
                objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objCuenta.Update(t)

                t.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.DialogResult = DialogResult.OK
            End If
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objCuotaAplicadas = Nothing
            objCuentaDetalle = Nothing
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            Select Case intType
                Case 0
                    AplicarPagos()
                Case 1
                    RevertirPagos()
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region










End Class