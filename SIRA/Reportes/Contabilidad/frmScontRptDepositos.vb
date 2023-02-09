﻿Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmScontRptDepositos

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
    Private Sub ImprimirDepositos()
        Dim ds As DataSet

        Try
            Dim objjReporte As New RptDepositos()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("ScontDepositosID, FechaDeposito, FechaArqueo, Banco, Voucher, Cuenta, Monto, Moneda, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Mes, IngresoDolares, Total, IngresoCordobas ", "vwRptScontDepositos", "convert(varchar(8),FechaDeposito,112)>='" & dpDesde.DateTime.ToString("yyyyMMdd") & "' AND convert(varchar(8),FechaDeposito,112)<='" & dpHasta.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.txtRangofechas.Text = "Desde el " & dpDesde.EditValue & "  Hasta el " & dpHasta.EditValue


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

                ImprimirDepositos()


            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try



    End Sub







#End Region




End Class