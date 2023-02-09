Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSraAranceles


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
            dtAranceles = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraArancelID, Grado, objGradoID, Moneda, TipoArancel, objTipoArancelID, objMonedaID, Valor", "vwSraAranceles", ))
            dtAranceles.PrimaryKey = New DataColumn() {Me.dtAranceles.Columns("SraArancelID")}
            dtAranceles.DefaultView.Sort = "SraArancelID desc"
            Me.grdAranceles.DataSource = dtAranceles
            Me.grdAranceles.Text = "Aranceles (" & Me.dtAranceles.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraAranceles"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarArancel")
            boolConsultar = objseg.TienePermiso("ConsultarArancel")
            boolEditar = objseg.TienePermiso("ModificarArancel")
           
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
        Dim ConsultarArancel As New frmSraArancelesEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArancelesTabla.GetSelectedRows()
                FilaActual = Me.grdArancelesTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarArancel.TypeGui = 3
                    ConsultarArancel.ArancelID = Me.dtAranceles.DefaultView.Item(FilaActual)("SraArancelID")
                    ConsultarArancel.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarArancel = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarArancel As New frmSraArancelesEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArancelesTabla.GetSelectedRows()
                FilaActual = Me.grdArancelesTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarArancel.TypeGui = 2
                    EditarArancel.ArancelID = Me.dtAranceles.DefaultView.Item(FilaActual)("SraArancelID")
                    EditarArancel.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarArancel = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editarancel As frmSraArancelesEdit
        Try
            Me.Cursor = WaitCursor
            editarancel = New frmSraArancelesEdit
            editarancel.TypeGui = 1
            If editarancel.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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

    Private Sub grdBecasTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdArancelesTabla.DoubleClick

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