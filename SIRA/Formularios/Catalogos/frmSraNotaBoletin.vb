Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSraNotaBoletin


#Region "Variables del formulario"
    Dim dtAranceles As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtAranceles = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraNotaBoletinID, objModalidadID, Modalidad, Periodo, objPeriodoID, Nota, Activa", "vwSraNotaBoletin", ))
            dtAranceles.PrimaryKey = New DataColumn() {Me.dtAranceles.Columns("SraNotaBoletinID")}
            dtAranceles.DefaultView.Sort = "SraNotaBoletinID desc"
            Me.grdNotas.DataSource = dtAranceles
            Me.grdNotas.Text = "Notas (" & Me.dtAranceles.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraNotaBoletin"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarNota")
            boolConsultar = objseg.TienePermiso("ConsultarNota")
            boolEditar = objseg.TienePermiso("ModificarNota")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtAranceles.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtAranceles.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub Consultar()
        Dim Consultarnota As New frmSraNotaBoletinEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdNotasTabla.GetSelectedRows()
                FilaActual = Me.grdNotasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    Consultarnota.TypeGui = 3
                    Consultarnota.NotaID = Me.dtAranceles.DefaultView.Item(FilaActual)("SraNotaBoletinID")
                    Consultarnota.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Consultarnota = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim Editarnota As New frmSraNotaBoletinEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdNotasTabla.GetSelectedRows()
                FilaActual = Me.grdNotasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    Editarnota.TypeGui = 2
                    Editarnota.NotaID = Me.dtAranceles.DefaultView.Item(FilaActual)("SraNotaBoletinID")
                    Editarnota.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Editarnota = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        'Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editarnota As frmSraNotaBoletinEdit
        Try
            Me.Cursor = WaitCursor
            editarnota = New frmSraNotaBoletinEdit
            editarnota.TypeGui = 1
            If editarnota.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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

    Private Sub grdBecasTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdNotasTabla.DoubleClick

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