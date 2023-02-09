Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmScontRptEstadoResultado

#Region "Declaracion de Variables"
    Public dtPeriodos, dtGrado, dtTipoMatricula, DtCentroCosto, dtMeses As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, intMesID As Integer
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

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Property MesID() As Integer
        Get
            Return intMesID
        End Get
        Set(ByVal value As Integer)
            intMesID = value
        End Set
    End Property

    Private Sub cmbMes_TextChanged(sender As Object, e As EventArgs) Handles cmbMes.TextChanged
        Me.ErrorProv.SetError(cmbMes, "")
    End Sub
#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarPeriodos()
        CargarMeses()
        CargarCentrosCosto()
    End Sub


#End Region


#Region "Cargar combos"

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SContPeriodoID, Periodo, Activo", "SContPeriodos", "Activo=1 ORDER BY Periodo desc"))

            cmbPeriodo.ValueMember = "SContPeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("SContPeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region


    Public Sub CargarCentrosCosto()
        Try
            DtCentroCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SconCentroCostoID, Nombre", "ScontCentrosCosto", "Activo=1  "))

            cmbCentroCosto.ValueMember = "SconCentroCostoID"
            cmbCentroCosto.DisplayMember = "Nombre"
            cmbCentroCosto.DataSource = DtCentroCosto

            cmbCentroCosto.Splits(0).DisplayColumns("SconCentroCostoID").Visible = False

            cmbCentroCosto.ColumnHeaders = False
            cmbCentroCosto.ExtendRightColumn = True
            cmbCentroCosto.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkCondensado_CheckedChanged(sender As Object, e As EventArgs) Handles chkCondensado.CheckedChanged
        Try
            If chkCondensado.Checked = True Then
                cmbMes.Text = String.Empty
                cmbMes.Enabled = False
            Else
                cmbMes.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#Region "Eventos del formulario"
    Private Sub CargarMeses()
        Try
            dtMeses = New DataTable
            dtMeses = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbMesID, NumMes, Mes", "StbMeses", "1=1"))
            With cmbMes
                .DataSource = dtMeses
                .ValueMember = "NumMes"
                .DisplayMember = "Mes"
                .Splits(0).DisplayColumns("NumMes").Visible = False
                .Splits(0).DisplayColumns("StbMesID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarGUI()

    End Sub

    Public Function ValidarEntrada() As Boolean

        Try
            If Not chkCondensado.Checked Then
                If cmbMes.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbMes, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If

            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
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

    Private Sub ImprimirEstadoCondensado()
        Dim ds As DataSet
        'Dim dt As DataTable
        Try
            Dim objjReporte As New rptEstadoResultadoCondensado()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("exec [pr_EstadoResultadoCondensado] " & cmbPeriodo.SelectedValue & ",'" & clsProyecto.Conexion.Usuario & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                grdRendimiento.DataSource = ds.Tables(0).TableName
                Dim printTool As ReportPrintTool = New ReportPrintTool(objjReporte)
                printTool.ShowPreviewDialog()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub ImprimirEstadoGeneral()
        Dim ds, dsIngresos, dsGastos, dsTotales As DataSet

        Try
            Dim objjReporte As New rptEstadoResultadoGeneralo()
            Dim objRptIngresos As New XtraOtrosIngresos
            Dim objRptGastos As New XtraGastosOperativos
            Dim objTotales As New XtraTotalesGeneral

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, SContCuentasContablesID, IDCuenta, Descripcion, Ingreso, IngresoAcumulado, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,TotalIngresos, TotalIngresosAcumulados ", "vwEstadoResultadoIngresosOrdinarios", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue))

            '' dsIngresos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, SContCuentasContablesID, IDCuenta, Descripcion, Ingreso, IngresoAcumulado, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,TotalIngresos, TotalIngresosAcumulados ", "vwEstadoResultadoIngresosOrdinarios", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue))
            ''   dsGastos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, IDCuenta, Descripcion, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha ", "vwEstadoResultadoGastos", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue))
            '' dsTotales = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("top 1 Excedente, ExcedenteAcumulado, objPeriodoID, Mes ", "VwScontGetTotalesEstadoResultas", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName

                ''    objRptIngresos.DataSource = dsIngresos
                ''  objRptIngresos.DataMember = dsIngresos.Tables(0).TableName

                ''  objRptGastos.DataSource = dsGastos
                ''  objRptGastos.DataMember = dsGastos.Tables(0).TableName

                '' objTotales.DataSource = dsTotales
                ''objTotales.DataMember = dsTotales.Tables(0).TableName

                Select Case cmbMes.SelectedValue
                    Case 1, 3, 5, 7, 8, 10, 12
                        objjReporte.txtFecha.Text = "Al 31 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                    Case 2
                        objjReporte.txtFecha.Text = "Al 28 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                    Case 4, 6, 9, 11
                        objjReporte.txtFecha.Text = "Al 30 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                End Select

                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirEstadoGeneralXCentroCosto()
        Dim ds, dsIngresos, dsGastos, dsTotales As DataSet

        Try
            Dim objjReporte As New rptEstadoResultadoGeneralo()
            Dim objRptIngresos As New XtraOtrosIngresos
            Dim objRptGastos As New XtraGastosOperativos
            Dim objTotales As New XtraTotalesGeneral

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, SContCuentasContablesID, IDCuenta, Descripcion, Ingreso, IngresoAcumulado, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha ", "vwEstadoResultadoIngresosOrdinarios", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue & " AND objSconCentroCostoID =" & cmbCentroCosto.SelectedValue))

            dsIngresos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, SContCuentasContablesID, IDCuenta, Descripcion, Ingreso, IngresoAcumulado, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha ", "vwEstadoResultadoIngresosOrdinarios", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue & " AND objSconCentroCostoID =" & cmbCentroCosto.SelectedValue))
            dsGastos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("IDCuentaPadre1, CuentaPadre1, IDCuentaPadre, CuentaPadre, IDCuenta, Descripcion, Gasto, GastoAcumulado, objPeriodoID, Mes, MesLetra, objNaturalezaID, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha ", "vwEstadoResultadoGastos", "objPeriodoID=" & cmbPeriodo.SelectedValue & " AND Mes=" & cmbMes.SelectedValue & " AND objSconCentroCostoID =" & cmbCentroCosto.SelectedValue))
            dsTotales = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("exec Sp_GetTotalesEstadoResultas " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName

                objRptIngresos.DataSource = dsIngresos
                objRptIngresos.DataMember = dsIngresos.Tables(0).TableName

                objRptGastos.DataSource = dsGastos
                objRptGastos.DataMember = dsGastos.Tables(0).TableName

                objTotales.DataSource = dsTotales
                objTotales.DataMember = dsTotales.Tables(0).TableName

                Select Case cmbMes.SelectedValue
                    Case 1, 3, 5, 7, 8, 10, 12
                        objjReporte.txtFecha.Text = "Al 31 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                    Case 2
                        objjReporte.txtFecha.Text = "Al 28 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                    Case 4, 6, 9, 11
                        objjReporte.txtFecha.Text = "Al 30 de " & cmbMes.Text & "  del " & cmbPeriodo.Text
                End Select

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
                If Not chkCondensado.Checked Then
                    ImprimirEstadoGeneral()
                Else
                    ImprimirEstadoCondensado()
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try



    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub





#End Region




End Class