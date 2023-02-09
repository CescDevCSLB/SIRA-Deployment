Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSraPeriodos


#Region "Variables del formulario"
    Dim dtPeriodos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolActivar, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Periodo, Activo,FechaCreacion, Fechaierre", "SraPeriodos", ))
            dtPeriodos.PrimaryKey = New DataColumn() {Me.dtPeriodos.Columns("PeriodoID")}
            dtPeriodos.DefaultView.Sort = "PeriodoID desc"
            Me.grdPeriodo.DataSource = dtPeriodos
            Me.grdPeriodo.Text = "Periodos (" & Me.dtPeriodos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraPeriodos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarPeriodo")
            boolConsultar = objseg.TienePermiso("ConsultarPeriodo")
            boolInactivar = objseg.TienePermiso("InactivarPeriodo")
            boolActivar = objseg.TienePermiso("EditarPeriodo")

            cmdAgregar.Enabled = boolAgregar
            cmdConsultar.Enabled = boolConsultar And dtPeriodos.Rows.Count > 0
            cmdInactivar.Enabled = boolInactivar And dtPeriodos.Rows.Count > 0
            cmdActivar.Enabled = boolActivar And dtPeriodos.Rows.Count > 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarPeriodo As New frmSraPeriodoEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarPeriodo.TypeGui = 3
                    ConsultarPeriodo.PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("PeriodoID")
                    ConsultarPeriodo.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarPeriodo = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim EditarPeriodo As New frmSraPeriodoEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarPeriodo.TypeGui = 2
                    EditarPeriodo.PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("PeriodoID")
                    EditarPeriodo.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            EditarPeriodo = Nothing
        End Try
    End Sub

    Private Function VerificarActivo() As Boolean
        Dim dtActivo As New DataTable
        Try
            dtActivo = SraPeriodos.RetrieveDT("Activo=1")
            If dtActivo.Rows.Count > 1 Then
                Return True
            Else : Return False
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtActivo = Nothing
        End Try
    End Function

    Private Sub HabilidarDeshabilitarInactivo()
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.dtPeriodos.DefaultView.Item(FilaActual)("Activo").ToString.Trim.Length <> 0 Then
                    If Me.boolActivar And Boolean.Parse(Me.dtPeriodos.DefaultView.Item(FilaActual)("Activo")) = False Then

                        Me.cmdActivar.Enabled = True
                    Else
                        Me.cmdActivar.Enabled = False

                    End If
                    If Me.boolInactivar And Boolean.Parse(Me.dtPeriodos.DefaultView.Item(FilaActual)("Activo")) = True Then
                        Me.cmdInactivar.Enabled = True
                    Else
                        Me.cmdInactivar.Enabled = False
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        Me.AplicarSeguridad()
        'HabilidarDeshabilitarInactivo()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editperiodo As frmSraPeriodoEditar
        Try
            Me.Cursor = WaitCursor
            editperiodo = New frmSraPeriodoEditar
            editperiodo.TypeGui = 1
            If editperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs)
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
        Dim PeriodoID As Integer
        Dim objPeriodo As New SraPeriodos
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                ''Verificar que exista al menos un periodo activo
                If VerificarActivo() Then
                    Select Case MsgBox("¿Está seguro de Inactivar el periodo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("PeriodoID")
                            objPeriodo.Retrieve(PeriodoID)
                            objPeriodo.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objPeriodo.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objPeriodo.Activo = False
                            objPeriodo.Update()
                            CargarGrid()
                        Case MsgBoxResult.No
                            Exit Sub
                    End Select
                Else
                    MsgBox("No es posible inactivar el periodo. Debe existir al menos uno activo", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                End If
               
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPeriodo = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub


    Private Sub cmdActivar_Click(sender As Object, e As EventArgs) Handles cmdActivar.Click
        Dim PeriodoID As Integer
        Dim objPeriodo As New SraPeriodos
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                Select Case MsgBox("¿Está seguro de activar el periodo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("PeriodoID")
                        objPeriodo.Retrieve(PeriodoID)
                        objPeriodo.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objPeriodo.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objPeriodo.Activo = True
                        objPeriodo.Update()
                        CargarGrid()
                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPeriodo = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub



    Private Sub grdPeriodoTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdPeriodoTabla.FocusedRowChanged
        'HabilidarDeshabilitarInactivo()
    End Sub

    Private Sub grdPeriodoTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdPeriodoTabla.DoubleClick
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
#End Region



   
End Class