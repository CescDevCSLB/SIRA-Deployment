Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmStbBuscarCheques

#Region "Declaracion de Variables"
    Public Dtestados, dtPeriodos As DataTable
    Private intEstadoID, intPeriodoID As Integer

#End Region

#Region "Propiedades"
    Property Periodo() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Property EstadoID() As Integer
        Get
            Return intEstadoID
        End Get
        Set(ByVal value As Integer)
            intEstadoID = value
        End Set
    End Property


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarEstado()
            CargarPeriodos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#Region "Cargar combos"

    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SContPeriodoID, Periodo, Activo", "SContPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodo.ValueMember = "SContPeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("SContPeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarEstado()
        Try

            Dtestados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='ESTADOCHEQUE')"))
            Me.cmbEstados.DataSource = Dtestados
            Me.cmbEstados.DisplayMember = "Descripcion"
            Me.cmbEstados.ValueMember = "StbValorCatalogoID"
            Me.cmbEstados.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbEstados.ExtendRightColumn = True
            Me.cmbEstados.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region


    Private Sub Seleccionarvalores()
        Try
            If cmbEstados.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbEstados, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbPeriodo.Text.ToString.Trim.Length = 0 Then
                ErrPrv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            EstadoID = cmbEstados.SelectedValue
            Periodo = cmbPeriodo.SelectedValue
            Me.DialogResult = DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmbPeriodo_TextChanged_1(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Seleccionarvalores()

    End Sub

#End Region


    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbEstados.TextChanged
        ErrPrv.Clear()
    End Sub


End Class