Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class frmScontRptBalanceGeneral

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
            If cmbMes.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbMes, My.Resources.MsgObligatorio)
                Return False
                Exit Function
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
    Private Sub ImprimirEstadoGeneral()
        Dim ds, dsActivos, dsCapital, dsPasivos, dsTotalFinal As DataSet

        Try
            Dim objjReporte As New rptBalanceGeneral()
            Dim objRptActivos As New XtraActivos
            Dim objRptCapital As New XtraCapital
            Dim objRptPasivos As New XtraPasivos
            Dim objRptTotalFinal As New XtraTotalBalance

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC [dbo].[sp_RptBalanceActivosEncabezado] " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))
            'dsPasivos = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC [dbo].[sp_RptBalancePasivo] " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))
            'dsActivos = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC [dbo].[sp_RptBalanceActivos] " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))
            'dsCapital = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC [dbo].[sp_RptBalancePatrimonio] " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))
            'dsTotalFinal = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC [dbo].[SP_TotalesBalance] " & cmbPeriodo.SelectedValue & " ," & cmbMes.SelectedValue))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName

                'objRptPasivos.DataSource = dsPasivos
                'objRptPasivos.DataMember = dsPasivos.Tables(0).TableName

                'objRptActivos.DataSource = dsActivos
                'objRptActivos.DataMember = dsActivos.Tables(0).TableName

                'objRptCapital.DataSource = dsCapital
                'objRptCapital.DataMember = dsCapital.Tables(0).TableName

                'objRptTotalFinal.DataSource = dsTotalFinal
                'objRptTotalFinal.DataMember = dsTotalFinal.Tables(0).TableName

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

                ImprimirEstadoGeneral()


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