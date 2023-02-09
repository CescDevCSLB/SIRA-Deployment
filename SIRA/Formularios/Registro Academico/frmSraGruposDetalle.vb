Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI


Public Class frmSraGruposDetalle


#Region "Variables del formulario"
    Dim dtGrupos, dtGruposDetalle As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolBuscar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGrupos", ))
            dtGrupos.PrimaryKey = New DataColumn() {Me.dtGrupos.Columns("SraGrupoID")}
            dtGrupos.DefaultView.Sort = "SraGrupoID desc"
            Me.grdAsignaturas.DataSource = dtGrupos
            Me.grdAsignaturas.Text = "Grupos (" & Me.dtGrupos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraGrupos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarGrupo")
            boolConsultar = objseg.TienePermiso("ConsultarGrupo")
            boolEditar = objseg.TienePermiso("EditarGrupo")
            boolImprimir = objseg.TienePermiso("ImprimirGrupo")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtGrupos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtGrupos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtGrupos.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

    '#Region "Procedimientos"

    '    ' ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    '    Public Sub CargarGrid(blnTodos As Boolean, intEstadoID As Integer, intEmpleadoID As Integer, intRutaID As Integer)
    '        Try
    '            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGrupos", ))

    '            If Not dtGrupos Is Nothing Then

    '                dtGruposDetalle = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objAplCobroID, SccCuentaID as Numero, NumeroCuenta, Producto, ModeloMarca, Saldo", "vwSfaExpedienteCliente", "1=1 order by objAplCobroID desc"))
    '                ds = New DataSet
    '                ds.Merge(dtGrupos)
    '                ds.Tables(0).TableName = "Abonos"
    '                ds.Merge(dtGruposDetalle)
    '                ds.Tables(1).TableName = "DetalleAbono"

    '                Dim keyColumn As DataColumn = ds.Tables("Abonos").Columns("AplCobroID")
    '                Dim foreignKeyColumn As DataColumn = ds.Tables("DetalleAbono").Columns("objAplCobroID")
    '                ds.Relations.Add("Expediente", keyColumn, foreignKeyColumn)

    '                grdVentas.DataSource = DtAbonos ''ds.Tables("Abonos")
    '                grdVentas.ForceInitialize()

    '                'Dim GridViewDetalle As New GridView(grdVentas)
    '                'grdVentas.LevelTree.Nodes.Add("Expediente", GridViewDetalle)
    '                'GridViewDetalle.PopulateColumns(ds.Tables("DetalleAbono"))

    '                'GridViewDetalle.Columns("objAplCobroID").Visible = False

    '                'GridViewDetalle.Columns("Numero").OptionsColumn.AllowEdit = False
    '                'GridViewDetalle.Columns("Producto").OptionsColumn.AllowEdit = False
    '                'GridViewDetalle.Columns("ModeloMarca").OptionsColumn.AllowEdit = False
    '                'GridViewDetalle.Columns("Saldo").OptionsColumn.AllowEdit = False

    '            End If

    '        Catch ex As Exception
    '            clsError.CaptarError(ex)
    '        End Try

    '    End Sub

    '    Private Sub Consultar()
    '        Dim ConsultarGrupos As New frmSraGruposEditar
    '        Dim FilaActual As Integer
    '        Try
    '            Try
    '                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
    '                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))

    '                If FilaActual >= 0 Then
    '                    ConsultarGrupos.TypeGui = 3
    '                    ConsultarGrupos.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
    '                    ConsultarGrupos.ShowDialog(Me)
    '                End If

    '            Catch ex As Exception
    '                clsError.CaptarError(ex)
    '            End Try
    '        Finally
    '            ConsultarGrupos = Nothing
    '        End Try
    '    End Sub

    '    Private Sub Editar()
    '        Dim EditarGrupos As New frmSraGruposEditar
    '        Dim FilaActual As Integer
    '        Try
    '            Try
    '                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
    '                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))
    '                If FilaActual >= 0 Then
    '                    EditarGrupos.TypeGui = 2
    '                    EditarGrupos.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
    '                    EditarGrupos.ShowDialog(Me)
    '                End If

    '            Catch ex As Exception
    '                clsError.CaptarError(ex)
    '            End Try
    '        Finally
    '            EditarGrupos = Nothing
    '        End Try
    '    End Sub


    '#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        'Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editgrado As frmSraGruposEditar
        Try
            Me.Cursor = WaitCursor
            editgrado = New frmSraGruposEditar
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
            'Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            'Me.Cursor = WaitCursor
            'Consultar()
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
        'Dim ds As DataSet
        'Try
        '    Dim objjReporte As New rptBodegas()

        '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" StbBodegaID, Codigo, Bodega, Responsable, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptBodegas", ))

        '    If ds.Tables(0).Rows.Count <> 0 Then
        '        objjReporte.DataSource = ds
        '        objjReporte.DataMember = ds.Tables(0).TableName
        '        Dim pt As New ReportPrintTool(objjReporte)
        '        pt.ShowPreview()
        '    Else
        '        MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '    End If


        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try
    End Sub
#End Region

#Region "Asignar grados y asignaturas"
    Private Sub AsignarGradosAsignaturas()
        Dim objPersonas As frmSraGrupoAsignaturasProfesor
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
            FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmSraGrupoAsignaturasProfesor
                objPersonas.TyGui = 2
                objPersonas.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    'Seguridad()
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

    Private Sub cmdAsignar_Click(sender As Object, e As EventArgs) Handles cmdAsignar.Click
        AsignarGradosAsignaturas()
    End Sub
End Class