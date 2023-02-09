Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSccArquo

#Region "Variables del formulario"
    Dim dtArqueos As DataTable
    Dim EsNotaDebito As Integer
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAprobar, boolImprimir As Boolean

    Private m_DiasArqueosRecientes As Integer

    Property DiasArqueosRecientes() As Integer
        Get
            DiasArqueosRecientes = Me.m_DiasArqueosRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasArqueosRecientes = value
        End Set
    End Property
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Dim strFiltro As String = String.Empty
        Try
            Me.DiasArqueosRecientes = ClsCatalogos.GetValorParametro("DiasArqueosRecientes")

            strFiltro = " Fecha BETWEEN GETDATE()- " & Me.DiasArqueosRecientes.ToString & " AND GETDATE() "

            dtArqueos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ArqueoID, Fecha, EntradaEfectivo, Faltante, AprobadoPor, Cajero, objMonedaID, Moneda, objTipoPagoID, TipoPago, Cerrado", "vwSccArqueoCaja", strFiltro))
            dtArqueos.DefaultView.Sort = "Fecha Desc"
            Me.grdArqueo.DataSource = dtArqueos
            Me.grdArqueo.Text = "Arqueos (" & Me.dtArqueos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            'objseg.ServicioUsuario = "frmSccArqueoCaja"
            'objseg.Usuario = clsProyecto.Conexion.Usuario
            'boolAgregar = objseg.TienePermiso("AgregarCierre")
            'boolConsultar = objseg.TienePermiso("ConsultarArqueo")
            'boolAprobar = objseg.TienePermiso("AprobarArqueo")
            'boolImprimir = objseg.TienePermiso("ImprimirArqueo")

            cmdAgregar.Enabled = True
            cmdConsultar.Enabled = dtArqueos.Rows.Count > 0
            cmdAprobar.Enabled = True
            cmdImprimir.Enabled = dtArqueos.Rows.Count > 0

            'cmdAgregar.Enabled = boolAgregar
            'cmdConsultar.Enabled = boolConsultar And dtArqueos.Rows.Count > 0
            'cmdAprobar.Enabled = boolAprobar ''And dtArqueos.Rows.Count > 0
            'cmdImprimir.Enabled = boolImprimir And dtArqueos.Rows.Count > 0

            'If dtArqueos.Rows.Count > 0 Then

            '    Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            '    FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

            '    If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado").ToString.Trim.Length <> 0 Then

            '        If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado") Then
            '            Me.cmdAprobar.Enabled = False
            '        Else
            '            Me.cmdAprobar.Enabled = True
            '        End If

            '    End If

            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub



    Private Sub Consultar()
        Dim Consultararqueo As New frmSccConsultarArqueo
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
                FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    Consultararqueo.ArqueoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ArqueoID")
                    Consultararqueo.TypeGui = 2

                    If Consultararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                    End If
                End If
               

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Consultararqueo = Nothing
        End Try
    End Sub

    Private Sub GenerarArqueoAnterior()
        Dim aprobararqueo As New frmSccConsultarArqueo
        Try
            Try
                aprobararqueo.TypeGui = 3
                If aprobararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    AplicarSeguridad()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            aprobararqueo = Nothing
        End Try
    End Sub

    Private Sub Abprobar()
        Dim aprobararqueo As New frmSccConsultarArqueo
        ''  Dim FilaActual As Integer
        Dim dtArqueoAprobado As New DataTable
        Try
            Try
                dtArqueoAprobado = SccArqueoCaja.RetrieveDT("convert(varchar(10),Fecha,112)='" & clsProyecto.Conexion.FechaServidor.ToString("yyyyMMdd") & "'")
                If dtArqueoAprobado.Rows.Count > 0 Then
                    MsgBox("Ya se realizo el cierre de caja del dia en curso.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Else
                    aprobararqueo.TypeGui = 1
                    If aprobararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            aprobararqueo = Nothing
        End Try
    End Sub

    Private Sub AperturarArqueo()
        Dim FilaActual As Integer
        Dim objArqueo As SccArqueoCaja
        Try
            objArqueo = New SccArqueoCaja
            Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objArqueo.Retrieve(Me.dtArqueos.DefaultView.Item(FilaActual)("ArqueoID"))
                objArqueo.Cerrado = False
                objArqueo.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objArqueo.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objArqueo.Update()
                CargarGrid()
                MsgBox("El arqueo del dia " & objArqueo.Fecha.ToString() & " se ha aperturado.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Agregar()
        Dim aprobararqueo As New frmSccConsultarArqueo

        Try
            Try

                aprobararqueo.TypeGui = 0
                If aprobararqueo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    AplicarSeguridad()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            aprobararqueo = Nothing
        End Try
    End Sub

#End Region

#Region "eventos del formulario"

    Private Sub frmSccArquo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Agregar()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Abprobar()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub grdArqueoabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdArqueoabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.dtArqueos.DefaultView.Item(FilaActual)("Cerrado").ToString.Trim.Length <> 0 Then

                If Me.dtArqueos.DefaultView.Item(FilaActual)("Cerrado") Then
                    Me.cmdAprobar.Enabled = False
                    Me.cmdAperturar.Enabled = True
                Else
                    Me.cmdAprobar.Enabled = True
                    Me.cmdAperturar.Enabled = False
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Consultar()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds, dscor, dsdol As DataSet
        Dim FilaActual As Integer
        Dim ArqueoID As Integer
        Try
            Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                ArqueoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ArqueoID")

                Dim objjReporte As New RptArqueoCaja()
                Dim objRptCor As New XtraArqueoDesCor
                Dim objRptDol As New XtraArqueoDesDol

                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("objCajaID, ArqueoID, Faltante, AprobadoPor, EntradaEfectivo, Concepto, TipoPago, Moneda, Cajero, Ingreso, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, NumRecibo, Alumno, CONVERT(VARCHAR(10), Fecha, 103) AS Fecha, Observaciones ", "vwRptArqueoCaja", "ArqueoID=" & ArqueoID))
                dscor = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccDenominacionID, Billete, Moneda, Cantidad, ArqueoID, Total ", "vwRptArqueoDesgloseCor", "ArqueoID=" & ArqueoID))
                dsdol = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccDenominacionID, Billete, Moneda, Cantidad, ArqueoID, Total ", "vwRptArqueoDesgloseDol", "ArqueoID=" & ArqueoID))

                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName

                    objRptCor.DataSource = dscor
                    objRptCor.DataMember = dscor.Tables(0).TableName

                    objRptDol.DataSource = dsdol
                    objRptDol.DataMember = dsdol.Tables(0).TableName

                    objjReporte.txtRangofechas.Visible = False
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If
           


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub cmdAperturar_Click(sender As Object, e As EventArgs) Handles cmdAperturar.Click
        AperturarArqueo()
    End Sub

    Private Sub cmdArqueoAnterior_Click(sender As Object, e As EventArgs) Handles cmdArqueoAnterior.Click
        GenerarArqueoAnterior()
    End Sub
#End Region


End Class