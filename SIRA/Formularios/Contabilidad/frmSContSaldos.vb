Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSContSaldos


#Region "Variables del formulario"
    Dim dtSaldos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolActivar, boolInactivar As Boolean
    Dim intPeriodoID, intMes As Integer
    Dim SqlParametros(5) As SqlClient.SqlParameter
    Dim intTipo As Integer

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Property Mes() As Integer
        Get
            Return intMes
        End Get
        Set(ByVal value As Integer)
            intMes = value
        End Set
    End Property

#End Region

#Region "Incializar GUI"

    Property Tipo() As Integer
        Get
            Return intTipo
        End Get
        Set(ByVal value As Integer)
            intTipo = value
        End Set
    End Property

    Private Sub ExportarExcel()
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.grdPeriodo.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptSaldos()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, IDCuenta, Descripcion, Saldo, Mes, Anio, Nivel, objPeriodoID, NombreMes, Cerrado", "vwRptSContSaldosCuentas", "1=1"))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tsbRefrescar_Click_1(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            If Tipo = 1 Then
                dtSaldos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("IDCuenta, Descripcion, Saldo, Mes, Anio, Nivel, objPeriodoID, SaldoDeudor, SaldoAcreedor", "vwSContSaldosCuentas", "objPeriodoID=" & intPeriodoID & " AND Mes= " & intMes & " order by IDCuenta  asc"))
            Else
                dtSaldos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("IDCuenta, Descripcion, Saldo, Mes, Anio, Nivel, objPeriodoID, SaldoDeudor, SaldoAcreedor", "vwSContSaldosCuentas", "objPeriodoID=" & intPeriodoID & " AND Mes= " & intMes & " order by IDCuenta  asc"))

            End If

            Me.grdPeriodo.DataSource = dtSaldos
            Me.grdPeriodo.Text = "Saldos (" & Me.dtSaldos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraPeriodos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarPeriodo")
            boolConsultar = objseg.TienePermiso("ConsultarPeriodo")
            boolInactivar = objseg.TienePermiso("InactivarPeriodo")
            boolActivar = objseg.TienePermiso("EditarPeriodo")


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs)
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub



#End Region




End Class