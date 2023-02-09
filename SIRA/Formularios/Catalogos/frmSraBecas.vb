Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSraBecas


#Region "Variables del formulario"
    Dim dtBecas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtBecas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("BecaID, Descripcion, Porcentaje,  Activo", "SraBecas", ))
            dtBecas.PrimaryKey = New DataColumn() {Me.dtBecas.Columns("BecaID")}
            dtBecas.DefaultView.Sort = "BecaID desc"
            Me.grdBecas.DataSource = dtBecas
            Me.grdBecas.Text = "Becas (" & Me.dtBecas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraBecas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarBeca")
            boolConsultar = objseg.TienePermiso("ConsultarBeca")
            boolEditar = objseg.TienePermiso("ModificarBeca")
            boolImprimir = objseg.TienePermiso("ImprimirBeca")
            boolInactivar = objseg.TienePermiso("InactivarBeca")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtBecas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtBecas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtBecas.Rows.Count > 0
            cmdInactivar.Enabled = boolInactivar And dtBecas.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"

    Private Sub Inactivar()
        Dim objBecas As New SraBecas
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdBecasTabla.GetSelectedRows()
                    FilaActual = Me.grdBecasTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objBecas.Retrieve(Me.dtBecas.DefaultView.Item(FilaActual)("BecaID"))
                        objBecas.Activo = False
                        objBecas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objBecas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objBecas.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objBecas = Nothing
        End Try
    End Sub


    Private Sub Consultar()
        Dim ConsultarBeca As New frmSraBecasEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdBecasTabla.GetSelectedRows()
                FilaActual = Me.grdBecasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarBeca.TypeGui = 3
                    ConsultarBeca.BecaID = Me.dtBecas.DefaultView.Item(FilaActual)("BecaID")
                    ConsultarBeca.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarBeca = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarBeca As New frmSraBecasEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdBecasTabla.GetSelectedRows()
                FilaActual = Me.grdBecasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarBeca.TypeGui = 2
                    EditarBeca.BecaID = Me.dtBecas.DefaultView.Item(FilaActual)("BecaID")
                    EditarBeca.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarBeca = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Inactivar()
        CargarGrid()
    End Sub

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editbeca As frmSraBecasEditar
        Try
            Me.Cursor = WaitCursor
            editbeca = New frmSraBecasEditar
            editbeca.TypeGui = 1
            If editbeca.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
            editbeca.TypeGui = 1
            editbeca.ShowDialog(Me)


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub grdBecasTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdBecasTabla.DoubleClick

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