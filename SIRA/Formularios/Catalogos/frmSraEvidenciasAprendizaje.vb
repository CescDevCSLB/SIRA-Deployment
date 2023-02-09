Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI


Public Class frmSraEvidenciasAprendizaje


#Region "Variables del formulario"
    Dim dtEvidencias As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Private Sub CargarEvidencias()
        Dim strFiltro As String
        Try
            If Not frmPrincipal.glbTodasEvidencias Then
                If (frmPrincipal.glbProfesor = 0) Then
                    strFiltro = "Activa=1 AND objPeriodoID=" & frmPrincipal.glbPeriodoSeleccionado
                Else
                    strFiltro = "Activa=1 AND objPeriodoID=" & frmPrincipal.glbPeriodoSeleccionado & " AND objProfesorID =" & frmPrincipal.glbProfesor
                End If
            Else
                strFiltro = "Activa=1"
            End If

            dtEvidencias = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraEvidenciasID, NombreEvidencia,Descripcion, Activa, Profesor, Periodo", "vwSraEvidencias", strFiltro & "  ORDER BY SraEvidenciasID DESC"), Me.SqlParametros)
            Me.grdEvidenciaMaster.DataSource = dtEvidencias
            Me.grdEvidenciaMaster.Text = "Evidencias (" & Me.grdEvidenciaMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraEvidenciasAprendizaje"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarEvidencia")
            boolConsultar = objseg.TienePermiso("ConsultarEvidencia")
            boolEditar = objseg.TienePermiso("EditarEvidencia")
            boolImprimir = objseg.TienePermiso("ImprimirEvidencia")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtEvidencias.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtEvidencias.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtEvidencias.Rows.Count > 0
            cmdAsignarEvidencias.Enabled = dtEvidencias.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarAsignaturas As New frmSraEvidenciasMaestroEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdEvidenciaMasterTabla.GetSelectedRows()
                FilaActual = Me.grdEvidenciaMasterTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarAsignaturas.TyGui = 3
                    ConsultarAsignaturas.EvidenciaID = Me.dtEvidencias.DefaultView.Item(FilaActual)("SraEvidenciasID")
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
        Dim EditarAsignatura As New frmSraEvidenciasMaestroEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdEvidenciaMasterTabla.GetSelectedRows()
                FilaActual = Me.grdEvidenciaMasterTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarAsignatura.TyGui = 2
                    EditarAsignatura.EvidenciaID = Me.dtEvidencias.DefaultView.Item(FilaActual)("SraEvidenciasID")
                    EditarAsignatura.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarAsignatura = Nothing
        End Try
    End Sub

    Private Sub CargarXParcial()
        Dim objParemetroParcial As New frmSraSeleccionarParcial
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdEvidenciaMasterTabla.GetSelectedRows()
                FilaActual = Me.grdEvidenciaMasterTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    objParemetroParcial.EvidenciaID = Me.dtEvidencias.DefaultView.Item(FilaActual)("SraEvidenciasID")
                    objParemetroParcial.Nombre = Me.dtEvidencias.DefaultView.Item(FilaActual)("NombreEvidencia")
                    objParemetroParcial.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objParemetroParcial = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEvidencias()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editbodega As frmSraEvidenciasMaestroEditar
        Try
            Me.Cursor = WaitCursor
            editbodega = New frmSraEvidenciasMaestroEditar
            editbodega.TyGui = 1
            If editbodega.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEvidencias()
                AplicarSeguridad()
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
            CargarEvidencias()
            AplicarSeguridad()
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
            CargarEvidencias()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdAsignarAsignaturas_Click(sender As Object, e As EventArgs) Handles cmdAsignarEvidencias.Click
        Try
            CargarXParcial()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarEvidencias()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptEvidencias()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" SraEvidenciasID, NombreEvidencia, objEvidenciasID, DetalleEvidencia, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptEvidencias", ))

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



    Private Sub grdFacturaDetalleTable_DoubleClick(sender As Object, e As EventArgs)
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarEvidencias()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
End Class