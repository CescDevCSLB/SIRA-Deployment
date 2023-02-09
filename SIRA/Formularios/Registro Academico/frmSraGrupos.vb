Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos


Public Class frmSraGrupos


#Region "Variables del formulario"
    Dim dtGrupos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolAsignar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
    Dim intEducacionInicial As Integer
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia,Activo,Modalidad,objModalidadID", "vwSraGrupos", ))
            dtGrupos.PrimaryKey = New DataColumn() {Me.dtGrupos.Columns("SraGrupoID")}
            dtGrupos.DefaultView.Sort = "SraGrupoID desc"
            Me.grdAsignaturas.DataSource = dtGrupos
            Me.grdAsignaturas.Text = "Grupos (" & Me.dtGrupos.Rows.Count & ")"

            intEducacionInicial = ClsCatalogos.ObtenerIDSTbCatalogo("MODALIDAD", "01")

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
            boolAsignar = objseg.TienePermiso("AsignarProfesoresAsignaturas")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtGrupos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtGrupos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtGrupos.Rows.Count > 0
            cmdAsignar.Enabled = boolAsignar And dtGrupos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarGrupos As New frmSraGruposEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrupos.TypeGui = 3
                    ConsultarGrupos.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
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
        Dim EditarGrupos As New frmSraGruposEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAsignaturasTabla.GetSelectedRows()
                FilaActual = Me.grdAsignaturasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrupos.TypeGui = 2
                    EditarGrupos.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
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
        Dim editbeca As frmRptBecas
        Try
            Me.Cursor = WaitCursor
            editbeca = New frmRptBecas
            editbeca.TypeGui = 2
            editbeca.ShowDialog(Me)


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
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

                objPersonas.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
                objPersonas.GradoID = Me.dtGrupos.DefaultView.Item(FilaActual)("GradoID")

                If intEducacionInicial = Me.dtGrupos.DefaultView.Item(FilaActual)("objModalidadID") Then
                    objPersonas.TyGui = 1
                Else
                    objPersonas.TyGui = 2
                End If
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