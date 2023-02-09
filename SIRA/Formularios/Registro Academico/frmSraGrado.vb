Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSraGrado


#Region "Variables del formulario"
    Dim dtGrados As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtGrados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID, CodigoGrado, Grado, Activo", "SraGrado", ))
            dtGrados.PrimaryKey = New DataColumn() {Me.dtGrados.Columns("GradoID")}
            dtGrados.DefaultView.Sort = "GradoID desc"
            Me.grdGrados.DataSource = dtGrados
            Me.grdGrados.Text = "Grados (" & Me.dtGrados.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraGrado"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarGrado")
            boolConsultar = objseg.TienePermiso("ConsultarGrado")
            boolEditar = objseg.TienePermiso("EditarGrado")
            boolImprimir = objseg.TienePermiso("ImprimirGrado")
            boolInactivar = objseg.TienePermiso("InactivarGrado")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtGrados.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtGrados.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtGrados.Rows.Count > 0
            cmdInactivar.Enabled = boolInactivar And dtGrados.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarGrado As New frmSraGradoEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdGradosTabla.GetSelectedRows()
                FilaActual = Me.grdGradosTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrado.TypeGui = 3
                    ConsultarGrado.GradoID = Me.dtGrados.DefaultView.Item(FilaActual)("GradoID")
                    ConsultarGrado.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarGrado = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarGrado As New frmSraGradoEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdGradosTabla.GetSelectedRows()
                FilaActual = Me.grdGradosTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrado.TypeGui = 2
                    EditarGrado.GradoID = Me.dtGrados.DefaultView.Item(FilaActual)("GradoID")
                    EditarGrado.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarGrado = Nothing
        End Try
    End Sub

    Private Sub Inactivar()
        Dim objGrado As New SraGrado
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdGradosTabla.GetSelectedRows()
                    FilaActual = Me.grdGradosTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objGrado.Retrieve(Me.dtGrados.DefaultView.Item(FilaActual)("GradoID"))
                        objGrado.Activo = False
                        objGrado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objGrado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objGrado.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                    End If
                End If
               

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objGrado = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editGrado As frmSraGradoEditar
        Try
            Me.Cursor = WaitCursor
            editGrado = New frmSraGradoEditar
            editGrado.TypeGui = 1
            If editGrado.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Inactivar()
        CargarGrid()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptGrados()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, GradoID, CodigoGrado, Grado, AsignaturaID, CodigoAsignarura, Asignatura", "vwRptSraGradosAsignaturas", ))

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



    
    Private Sub grdGradosTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdGradosTabla.DoubleClick
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