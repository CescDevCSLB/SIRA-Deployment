Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports DAL

Public Class frmSContConceptosCuentas


#Region "Variables del formulario"
    Dim dtConceptosCuentas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAnular As Boolean

#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try

            dtConceptosCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TipoConcepto, SContConceptosCuentasID, CentroCosto, objConceptoID, Concepto, objCuentaContableID, CuentaContable, objContraCuentaID, ContraCuentaContable", "vwScontConceptosCuentas", ))
            dtConceptosCuentas.PrimaryKey = New DataColumn() {Me.dtConceptosCuentas.Columns("SContConceptosCuentasID")}
            dtConceptosCuentas.DefaultView.Sort = "SContConceptosCuentasID desc"
            Me.grdConceptos.DataSource = dtConceptosCuentas
            Me.grdConceptos.Text = "Conceptos/Cuentas (" & Me.dtConceptosCuentas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSContConceptosCuentas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarRelacionConceptoCuenta")
            boolEditar = objseg.TienePermiso("EditarRelacionConceptoCuenta")
            boolConsultar = objseg.TienePermiso("ConsultarRelacionConceptoCuenta")
            boolAnular = objseg.TienePermiso("EliminarRelacionConceptoCuenta")

            cmdAgregar.Enabled = boolAgregar
            cmdConsultar.Enabled = boolConsultar And dtConceptosCuentas.Rows.Count > 0
            cmdEditar.Enabled = boolEditar And dtConceptosCuentas.Rows.Count > 0
            cmdInactivar.Enabled = boolAnular And dtConceptosCuentas.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Editar()
        Dim ConsultarConcepto As New frmSContConceptosCuentasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdConceptosTabla.GetSelectedRows()
                FilaActual = Me.grdConceptosTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then

                    ConsultarConcepto.ConceptoCuentaID = Me.dtConceptosCuentas.DefaultView.Item(FilaActual)("SContConceptosCuentasID")
                    ConsultarConcepto.TypeID = 1

                    If ConsultarConcepto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarConcepto = Nothing
        End Try
    End Sub



    Private Sub Consultar()
        Dim ConsultarConcepto As New frmSContConceptosCuentasEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdConceptosTabla.GetSelectedRows()
                FilaActual = Me.grdConceptosTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarConcepto.TypeID = 2
                    ConsultarConcepto.ConceptoCuentaID = Me.dtConceptosCuentas.DefaultView.Item(FilaActual)("SContConceptosCuentasID")
                    ConsultarConcepto.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarConcepto = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CargarGrid()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub




    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim agregarconcepto As frmSContConceptosCuentasEdit
        Try
            Me.Cursor = WaitCursor
            agregarconcepto = New frmSContConceptosCuentasEdit
            agregarconcepto.TypeID = 0

            If agregarconcepto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                AplicarSeguridad()
            End If

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

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Dim objConcepto As New SContConceptosCuentas
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdConceptosTabla.GetSelectedRows()
            FilaActual = Me.grdConceptosTabla.GetDataSourceRowIndex(selectedRow(0))

            Select Case MsgBox("¿Está seguro que desea anular la relacion seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    objConcepto.Retrieve(Me.dtConceptosCuentas.DefaultView.Item(FilaActual)("SContConceptosCuentasID"))
                    objConcepto.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objConcepto.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objConcepto.Activa = False
                    objConcepto.Update()
                    CargarGrid()
                    AplicarSeguridad()

                Case MsgBoxResult.No
                    Exit Sub
            End Select


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


    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

    Private Sub grdPeriodoTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdConceptosTabla.DoubleClick
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