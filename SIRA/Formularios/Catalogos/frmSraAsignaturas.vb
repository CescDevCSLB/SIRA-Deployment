Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI


Public Class frmSraAsignaturas


#Region "Variables del formulario"
    Dim dtAsignaturas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AsignaturaID, CodigoAsignarura, Nombre, Activa,SoloGuia", "SraAsignaturas", ))
            dtAsignaturas.PrimaryKey = New DataColumn() {Me.dtAsignaturas.Columns("AsignaturaID")}
            dtAsignaturas.DefaultView.Sort = "AsignaturaID desc"
            Me.grdAsignaturas.DataSource = dtAsignaturas
            Me.grdAsignaturas.Text = "Asignaturas (" & Me.dtAsignaturas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraAsignaturas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarAsignatura")
            boolConsultar = objseg.TienePermiso("ConsultarAsignatura")
            boolEditar = objseg.TienePermiso("EditarAsignatura")
            boolImprimir = objseg.TienePermiso("ImprimirAsignatura")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtAsignaturas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtAsignaturas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtAsignaturas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarAsignaturas As New frmSraAsignaturasEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarAsignaturas.TypeGui = 3
                    ConsultarAsignaturas.AsignaturaID = Me.dtAsignaturas.DefaultView.Item(FilaActual)("AsignaturaID")
                    ConsultarAsignaturas.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarAsignaturas = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarAsignatura As New frmSraAsignaturasEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarAsignatura.TypeGui = 2
                    EditarAsignatura.AsignaturaID = Me.dtAsignaturas.DefaultView.Item(FilaActual)("AsignaturaID")
                    EditarAsignatura.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarAsignatura = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editbodega As frmSraAsignaturasEditar
        Try
            Me.Cursor = WaitCursor
            editbodega = New frmSraAsignaturasEditar
            editbodega.TypeGui = 1
            If editbodega.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
            Dim objjReporte As New rptAsignaturas()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AsignaturaID, CodigoAsignarura, Nombre, Activa", "vwrptAsignaturas", ))

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

    Private Sub grdAsignaturasTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdAsignaturasTabla.DoubleClick
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
#End Region



   
End Class