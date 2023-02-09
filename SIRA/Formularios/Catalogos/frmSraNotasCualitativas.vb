Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI


Public Class frmSraNotasCualitativas


#Region "Variables del formulario"
    Dim dtNotasCualitativas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtNotasCualitativas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraNotas_CualitativaID , Valor , Desde , Hasta,Activo , Modalidad", "vwSraNotas_Cualitativas", ))
            dtNotasCualitativas.PrimaryKey = New DataColumn() {Me.dtNotasCualitativas.Columns("SraNotas_CualitativaID")}
            dtNotasCualitativas.DefaultView.Sort = "SraNotas_CualitativaID desc"
            Me.grdNotasCualitativas.DataSource = dtNotasCualitativas
            Me.grdNotasCualitativas.Text = "Notas CualitativaID (" & Me.dtNotasCualitativas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraNotasCualitativas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarNotasCualitativas")
            boolConsultar = objseg.TienePermiso("ConsultarNotasCualitativas")
            boolEditar = objseg.TienePermiso("EditarNotasCualitativas")
            boolImprimir = objseg.TienePermiso("ImprimirNotasCualitativas")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtNotasCualitativas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtNotasCualitativas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtNotasCualitativas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarGrupos As New frmSraNotasCualitativasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdNotasCualitativasTabla.GetSelectedRows()
                FilaActual = Me.grdNotasCualitativasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrupos.TypeGui = 3
                    ConsultarGrupos.NotaID = Me.dtNotasCualitativas.DefaultView.Item(FilaActual)("SraNotas_CualitativaID")
                    ConsultarGrupos.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarGrupos = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarGrupos As New frmSraNotasCualitativasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdNotasCualitativasTabla.GetSelectedRows()
                FilaActual = Me.grdNotasCualitativasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrupos.TypeGui = 2
                    EditarGrupos.NotaID = Me.dtNotasCualitativas.DefaultView.Item(FilaActual)("SraNotas_CualitativaID")
                    EditarGrupos.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarGrupos = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editgrado As frmSraNotasCualitativasEdit
        Try
            Me.Cursor = WaitCursor
            editgrado = New frmSraNotasCualitativasEdit
            editgrado.TypeGui = 1
            If editgrado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            Me.Cursor = WaitCursor
            Consultar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptRangosCualitativos()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, SraNotas_CualitativaID, objModalidadID, Valor, Desde, Hasta, Activo, Modalidad", "vwRptSraNotas_Cualitativas", ))

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
#End Region



    Private Sub grdNotasCualitativasTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdNotasCualitativasTabla.DoubleClick
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
End Class