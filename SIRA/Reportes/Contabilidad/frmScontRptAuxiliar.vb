Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmScontRptAuxiliar

#Region "Declaracion de Variables"
    Public dtPeriodos, dtGrado, dtTipoMatricula, DtCentroCosto, dtCuentasDatos As DataTable
    Public intTypeGui, intCuentaContableID As Integer
    Public intPeriodoID, intPantalla, intMesID As Integer
    Dim strCuentaCompleta, strCuentaPadre As String
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

    Property Pantalla() As Integer
        Get
            Return intPantalla
        End Get
        Set(ByVal value As Integer)
            intPantalla = value
        End Set
    End Property

    Private Sub cmdBuscarCuenta_Click(sender As Object, e As EventArgs) Handles cmdBuscarCuenta.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 2
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                intCuentaContableID = objSeleccion.Seleccion
                CargarCuenta()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarCuenta()
        Dim objcuenta As New SContCuentasContables
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & intCuentaContableID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion, CuentaPadre", "SContCuentasContables", strFiltro))

            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtCuenta.Text = dtCuentasDatos.Rows(0)("Descripcion")
                strCuentaCompleta = dtCuentasDatos.Rows(0)("IDCuenta") & " - " & dtCuentasDatos.Rows(0)("Descripcion")
            End If

            ''Si tiene Padre buscar la cuenta Padre
            If Not IsDBNull(dtCuentasDatos.Rows(0)("CuentaPadre")) Then
                If dtCuentasDatos.Rows(0)("CuentaPadre").ToString.Trim.Length > 0 Then
                    objcuenta.RetrieveByFilter("IDCuenta= " & dtCuentasDatos.Rows(0)("CuentaPadre").ToString)
                    If objcuenta.SContCuentasContablesID <> 0 Then
                        strCuentaPadre = objcuenta.IDCuenta & " - " & objcuenta.Descripcion
                    End If
                End If
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Private Sub txtCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        Me.ErrorProv.SetError(txtCuenta, "")
    End Sub

    Property MesID() As Integer
        Get
            Return intMesID
        End Get
        Set(ByVal value As Integer)
            intMesID = value
        End Set
    End Property

    Private Sub dpHasta_EditValueChanged(sender As Object, e As EventArgs) Handles dpHasta.EditValueChanged
        Me.ErrorProv.SetError(dpHasta, "")
    End Sub

    Private Sub dpDesde_EditValueChanged(sender As Object, e As EventArgs) Handles dpDesde.EditValueChanged
        Me.ErrorProv.SetError(dpDesde, "")
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre



#End Region







#Region "Eventos del formulario"



    Public Function ValidarEntrada() As Boolean

        Try
            If txtCuenta.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtCuenta, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If dpDesde.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dpDesde, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


            If dpHasta.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dpHasta, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub ImprimirAuxiliar()
        Dim ds As DataSet

        Try
            Dim objjReporte As New rptScontAuxiliarCuentas()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptSccAuxilarContable '" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "','" & intCuentaContableID & "'"))


            'ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SContComprobanteDetalleID, IsCheque, ScontComprobanteID, NumAsiento, Fecha, Concepto, TipoAsiento, SContCuentasContablesID, IDCuenta, Cuenta, Debe, Haber, Saldo, fechacontabilizacion, Empresa, DireccionEmpresa, TelefonosEmpresa,SaldoFinal ", "vwRptSccAuxilarContable", "SContCuentasContablesID = " & intCuentaContableID & " AND convert(varchar(8),fecha,112)>='" & dpDesde.DateTime.ToString("yyyyMMdd") & "' AND convert(varchar(8),fecha,112)<='" & dpHasta.DateTime.ToString("yyyyMMdd") & "'  order by Fecha asc"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue
                objjReporte.txtCuenta.Text = strCuentaPadre
                objjReporte.txtCuentaDetalle.Text = strCuentaCompleta

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
            If ValidarEntrada() Then

                ImprimirAuxiliar()


            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try



    End Sub







#End Region




End Class