Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI

Public Class frmSccCuentasEmpleado

#Region "Variables del formulario"
    Dim dtCuentas As DataTable
    Dim dsCuentas As DataSet
    Dim boolAgregar, boolEditar, boolEliminar, boolImprimir As Boolean
    Dim intEstadoAnulada As Integer

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarCuentas()
        Try
            dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Numero, PagoMensual, Plazo, SccCuentaID, Llave, StbEmpleadoID, Empleado, Saldo, objEstadoID, Estado", "vwSccCuentaEmpleado", "Activa=1"))
            dtCuentas.DefaultView.Sort = "SccCuentaID desc"
            Me.grdExpedienteMaster.DataSource = dtCuentas
            Me.grdExpedienteMaster.Text = "Expedientes (" & Me.grdExpedienteMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub frmSccCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            intEstadoAnulada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")

            Call CargarCuentas()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub




    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Call Close()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim addprestamo As frmSccCuentasEmpleadosAgregar
        Try
            Me.Cursor = WaitCursor
            addprestamo = New frmSccCuentasEmpleadosAgregar

            addprestamo.TypeGUI = 1
            If addprestamo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarCuentas()
                AplicarSeguridad()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Dim editprestamo As frmSccCuentasEmpleadosEditar
        Dim dtVerificar As New DataTable
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
            FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                ''Verificar que la cuenta no tenga movimientos
                dtVerificar = SccCuentaPorCobrarDetalleEmpleados.RetrieveDT("MontoPagado <> 0 AND objSccCuentaPorCobrarID=" & Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID")))
                If dtVerificar.Rows.Count > 0 Then
                    MsgBox("Solamente prestamos que no tienen pagos aplicados pueden ser Editados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                Else
                    editprestamo = New frmSccCuentasEmpleadosEditar
                    editprestamo.TypeGUI = 1
                    editprestamo.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))

                    If editprestamo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarCuentas()
                        AplicarSeguridad()
                    End If
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Dim FilaActual As Integer
        Dim objCuenta As SccCuentaPorCobrarEmpleados
        Try
            Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
            FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                Select Case MsgBox("¿Seguro que desea inectivar el prestamo seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        objCuenta = New SccCuentaPorCobrarEmpleados
                        objCuenta.Retrieve(Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID")))
                        objCuenta.Activa = False
                        objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objCuenta.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                End Select
                CargarCuentas()
                AplicarSeguridad()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Imprimir()
        Dim ds As DataSet
        Dim FilaActual As Integer
        Dim intCuentaID As Integer
        Dim objjReporte As New rptEstadoCuentaEmpleado()
        Try
            If dtCuentas.Rows.Count > 0 Then

                Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
                FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    intCuentaID = Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID")

                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccCuentaID, Numero, objEmpleadoID, Empleado, objEstadoID, Estado, Plazo, MesLetra, MontoPagado, FechaVencimiento, SaldoTotal, SaldoLinea, Cedula, MontoInicial, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptEstadoCuentaEmpleado", "SccCuentaID=" & intCuentaID))

                    If ds.Tables(0).Rows.Count <> 0 Then
                        objjReporte.DataSource = ds
                        objjReporte.DataMember = ds.Tables(0).TableName
                        Dim pt As New ReportPrintTool(objjReporte)
                        pt.ShowPreview()
                    Else
                        MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Imprimir()
    End Sub

    Private Sub cmdContabilizar_Click(sender As Object, e As EventArgs) Handles cmdContabilizar.Click
        Dim consultprestamo As frmSccAplicarDeducciones
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
            FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                consultprestamo = New frmSccAplicarDeducciones
                consultprestamo.Type = 0
                consultprestamo.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))
                consultprestamo.ShowDialog(Me)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRevertir_Click(sender As Object, e As EventArgs) Handles cmdRevertir.Click
        Dim consultprestamo As frmSccAplicarDeducciones
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
            FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                consultprestamo = New frmSccAplicarDeducciones
                consultprestamo.Type = 1
                consultprestamo.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))
                consultprestamo.ShowDialog(Me)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Call CargarCuentas()
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim consultprestamo As frmSccCuentasEmpleadosEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdExpedienteMasterTabla.GetSelectedRows()
            FilaActual = Me.grdExpedienteMasterTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                consultprestamo = New frmSccCuentasEmpleadosEditar
                consultprestamo.TypeGUI = 2
                consultprestamo.CuentaID = Integer.Parse(Me.dtCuentas.DefaultView.Item(FilaActual)("SccCuentaID"))
                consultprestamo.ShowDialog(Me)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccCuentasPorCobrarEmpleados"

            Me.cmdAgregar.Enabled = objSeg.TienePermiso("AgregarPrestamo")
            Me.cmdEditar.Enabled = objSeg.TienePermiso("EditarPrestamo") And dtCuentas.Rows.Count > 0
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarPrestamo") And dtCuentas.Rows.Count > 0
            Me.cmdImprimir.Enabled = objSeg.TienePermiso("ImprimirDetallePrestamo") And dtCuentas.Rows.Count > 0
            Me.cmdInactivar.Enabled = objSeg.TienePermiso("AnularPrestamo") And dtCuentas.Rows.Count > 0
            Me.cmdContabilizar.Enabled = objSeg.TienePermiso("AplicarPagoPlanilla") And dtCuentas.Rows.Count > 0
            Me.cmdRevertir.Enabled = objSeg.TienePermiso("AplicarPagoPlanilla") And dtCuentas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub






End Class