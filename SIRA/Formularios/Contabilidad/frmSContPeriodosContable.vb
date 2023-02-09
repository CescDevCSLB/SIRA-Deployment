Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports DAL

Public Class frmSContPeriodosContable


#Region "Variables del formulario"
    Dim dtPeriodos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolAperturar, boolCerrar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContPeriodoID, Periodo, CAST(Cerrado AS BIT) AS Cerrado ,FechaCreacion, Fechaierre", "SContPeriodos", ))
            dtPeriodos.PrimaryKey = New DataColumn() {Me.dtPeriodos.Columns("SContPeriodoID")}
            dtPeriodos.DefaultView.Sort = "SContPeriodoID desc"
            Me.grdPeriodo.DataSource = dtPeriodos
            Me.grdPeriodo.Text = "Periodos (" & Me.dtPeriodos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmScontPeriodos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarPeriodo")
            boolAperturar = objseg.TienePermiso("AperturarPeriodo")
            boolCerrar = objseg.TienePermiso("CerrarPeriodo")


            cmdAgregar.Enabled = boolAgregar
            cmdAperturar.Enabled = boolAperturar And dtPeriodos.Rows.Count > 0
            cmdCerrar.Enabled = boolCerrar And dtPeriodos.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarPeriodo As New frmSContPeriodoContableEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarPeriodo.TypeGui = 3
                    ConsultarPeriodo.PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID")
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
        Dim EditarPeriodo As New frmSContPeriodoContableEditar
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarPeriodo.TypeGui = 2
                    EditarPeriodo.PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID")
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
            dtActivo = SContPeriodos.RetrieveDT("Activo=1")
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

    Private Sub HabilidarDeshabilitarCerrado()
        Dim FilaActual As Integer
        Try
            If dtPeriodos.Rows.Count > 0 Then
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    If Me.dtPeriodos.DefaultView.Item(FilaActual)("Cerrado").ToString.Trim.Length <> 0 Then
                        If Me.boolCerrar And Boolean.Parse(Me.dtPeriodos.DefaultView.Item(FilaActual)("Cerrado")) = False Then

                            Me.cmdCerrar.Enabled = True
                        Else
                            Me.cmdCerrar.Enabled = False

                        End If
                        'If Me.boolCerrar And Boolean.Parse(Me.dtPeriodos.DefaultView.Item(FilaActual)("Cerrado")) = True Then
                        '    Me.cmdCerrar.Enabled = True
                        'Else
                        '    Me.cmdCerrar.Enabled = False
                        'End If
                    Else
                        Me.cmdCerrar.Enabled = True
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
        HabilidarDeshabilitarCerrado()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editperiodo As frmSContPeriodoContableEditar
        Try
            Me.Cursor = WaitCursor
            editperiodo = New frmSContPeriodoContableEditar
            editperiodo.TypeGui = 1
            If editperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
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

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs)
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

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs)
        Dim PeriodoID As Integer
        Dim objPeriodo As New SContPeriodos
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                ''Verificar que exista al menos un periodo activo
                If VerificarActivo() Then
                    Select Case MsgBox("¿Está seguro de Inactivar el periodo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID")
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

    Private Sub cmdAperturar_Click(sender As Object, e As EventArgs) Handles cmdAperturar.Click
        Dim PeriodoID As Integer
        Dim objPeriodo As New SContPeriodos
        Dim FilaActual As Integer

        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                Select Case MsgBox("¿Está seguro que desea aperurar el periodo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes

                        PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID")
                        objPeriodo.Retrieve(PeriodoID)
                        objPeriodo.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objPeriodo.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objPeriodo.Cerrado = False
                        objPeriodo.Update()

                        CargarGrid()
                        AplicarSeguridad()
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



    Private Sub CerrarPeriodo(ByVal IntPeriodoID As Integer, t As TransactionManager)
        Dim parametro(3) As SqlClient.SqlParameter
        Try

            parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
            parametro(0).Value = IntPeriodoID
            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario
            SqlHelper.ExecuteNonQuery(t.Transaction, CommandType.StoredProcedure, "SP_CerrarPeriodo", parametro)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub


    Private Sub cmdActivar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Dim PeriodoID As Integer
        Dim objPeriodo As New SContPeriodos
        Dim objPeriodoV As New SContPeriodos
        Dim FilaActual As Integer
        Dim T As New DAL.TransactionManager
        Try
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
            T.BeginTran()
            ''Verificar si existe un periodo abierto
            objPeriodoV.RetrieveByFilter("Activo=1 AND SContPeriodoID >" & Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID"))
            If objPeriodoV.SContPeriodoID = 0 Then
                MsgBox("No es posible cerrar el periodo. Debe existir al otro activo donde se cargaran los saldos.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If
            If FilaActual >= 0 Then
                Select Case MsgBox("¿Está seguro que desea cerrar el periodo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        PeriodoID = Me.dtPeriodos.DefaultView.Item(FilaActual)("SContPeriodoID")
                        CerrarPeriodo(PeriodoID, T)
                        T.CommitTran()
                        CargarGrid()
                        AplicarSeguridad()
                        MsgBox("Periodo cerrado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPeriodo = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub



    Private Sub grdPeriodoTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdPeriodoTabla.FocusedRowChanged
        HabilidarDeshabilitarCerrado()
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