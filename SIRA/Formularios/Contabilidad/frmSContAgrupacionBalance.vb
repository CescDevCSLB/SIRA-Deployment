Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO

Public Class frmSContAgrupacionBalance


#Region "Variables del formulario"
    Dim dtGrupos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ScontAgrupacionBalanceID, Agrupacion, Activo, Clasificacion", "vwScontAgrupacionBalance", "Activo=1"))
            dtGrupos.PrimaryKey = New DataColumn() {Me.dtGrupos.Columns("ScontAgrupacionBalanceID")}
            dtGrupos.DefaultView.Sort = "ScontAgrupacionBalanceID desc"
            Me.grdAgrupaciones.DataSource = dtGrupos
            Me.grdAgrupaciones.Text = "Agrupaciones (" & Me.dtGrupos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSContAgrupacionBalance"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarAgrupacionBalance")
            boolConsultar = objseg.TienePermiso("ConsultarAgrupacionBalance")
            boolEditar = objseg.TienePermiso("EditarAgrupacionBalance")
            boolInactivar = objseg.TienePermiso("InactivarAgrupacionBalance")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtGrupos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtGrupos.Rows.Count > 0
            cmdInactivar.Enabled = boolInactivar And dtGrupos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarGrupos As New frmSContAgrupacionBalanceEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAgrupacionesTabla.GetSelectedRows()
                FilaActual = Me.grdAgrupacionesTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrupos.TyGui = 3
                    ConsultarGrupos.AgrupacionID = Me.dtGrupos.DefaultView.Item(FilaActual)("ScontAgrupacionBalanceID")
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
        Dim EditarGrupos As New frmSContAgrupacionBalanceEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdAgrupacionesTabla.GetSelectedRows()
                FilaActual = Me.grdAgrupacionesTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrupos.TyGui = 2
                    EditarGrupos.AgrupacionID = Me.dtGrupos.DefaultView.Item(FilaActual)("ScontAgrupacionBalanceID")
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
        Dim editgrado As frmSContAgrupacionBalanceEdit
        Try
            Me.Cursor = WaitCursor
            editgrado = New frmSContAgrupacionBalanceEdit
            editgrado.TyGui = 1
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
    Private Sub Inactivar()
        Dim objagrupacion As New ScontAgrupacionBalanceGeneral
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdAgrupacionesTabla.GetSelectedRows()
                    FilaActual = Me.grdAgrupacionesTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objagrupacion.Retrieve(Me.dtGrupos.DefaultView.Item(FilaActual)("ScontAgrupacionBalanceID"))
                        objagrupacion.Activo = False
                        objagrupacion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objagrupacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objagrupacion.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objagrupacion = Nothing
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Inactivar()
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

#End Region

End Class