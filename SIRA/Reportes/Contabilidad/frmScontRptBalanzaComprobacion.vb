Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmScontRptBalanzaComprobacion

#Region "Declaracion de Variables"
    Public dtPeriodos, dtGrado, dtTipoMatricula, DtCentroCosto, dtNivel As DataTable
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

    Private Sub frmScontRptBalanzaComprobacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNvel()
    End Sub

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Private Sub cmbNivel_TextChanged(sender As Object, e As EventArgs) Handles cmbNivel.TextChanged
        Me.ErrorProv.SetError(cmbNivel, "")
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

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Try
            If chkTodos.Checked Then
                cmbNivel.Text = String.Empty
                cmbNivel.Enabled = False
            Else
                cmbNivel.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Configruacion"


    Private Sub CargarNvel()
        Try
            dtNivel = New DataTable
            dtNivel = ClsCatalogos.ObtenerValCat("NivelCuenta")
            With cmbNivel
                .DataSource = dtNivel
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

#End Region







#Region "Eventos del formulario"



    Public Function ValidarEntrada() As Boolean

        Try
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

            If Not chkTodos.Checked Then
                If cmbNivel.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbNivel, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
    Private Sub ImprimirBalanzaNivel1()
        Dim ds As DataSet

        Try
            Dim objjReporte As New rptBalanzaComprobacion()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptBalanzaComprobacion_Nivel1'" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirBalanzaNivel2()
        Dim ds As DataSet

        Try
            Dim objjReporte As New rptBalanzaComprobacion()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptBalanzaComprobacion_Nivel2 '" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirBalanzaNivel3()
        Dim ds As DataSet

        Try
            Dim objjReporte As New rptBalanzaComprobacion()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptBalanzaComprobacion_Nivel3 '" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirBalanzaNivel4()
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptBalanzaComprobacion()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptBalanzaComprobacion_Nivel4 '" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub ImprimirBalanzaNivelTodos()
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptBalanzaComprobacionAll()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC sp_RptBalanzaComprobacion_All '" & dpDesde.DateTime.ToString("yyyyMMdd") & "','" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtFecha.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


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
                If Not chkTodos.Checked Then
                    Select Case cmbNivel.Text
                        Case "1"
                            ImprimirBalanzaNivel1()
                        Case "2"
                            ImprimirBalanzaNivel2()
                        Case "3"
                            ImprimirBalanzaNivel3()
                        Case "4"
                            ImprimirBalanzaNivel4()
                    End Select
                Else
                    ImprimirBalanzaNivelTodos()
                End If


            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try



    End Sub







#End Region




End Class