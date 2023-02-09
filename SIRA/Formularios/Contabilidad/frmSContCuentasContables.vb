Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO


Public Class frmSContCuentasContables


#Region "Variables del formulario"
    Dim dtCuentas As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolImprimir, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion, objNaturalezaID, Nivel, RecibeMovimiento, CentroCosto, TieneAuxilar, Activo, CuentaPadre, Naturaleza", "vwSContCuentasContables", "Activo=1 order by IDCuenta asc"))
            dtCuentas.PrimaryKey = New DataColumn() {Me.dtCuentas.Columns("SContCuentasContablesID")}

            Me.grdCuentas.DataSource = dtCuentas
            Me.grdCuentas.Text = "Cuentas contables (" & Me.dtCuentas.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmScontCuentas"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCuentaContable")
            boolConsultar = objseg.TienePermiso("ConsultarCuentaContable")
            boolEditar = objseg.TienePermiso("ModificarCuentaContable")
            boolImprimir = objseg.TienePermiso("ImprimirCuentasContable")
            boolInactivar = objseg.TienePermiso("InactivarCuentasContable")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtCuentas.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtCuentas.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtCuentas.Rows.Count > 0
            cmdInactivar.Enabled = boolInactivar And dtCuentas.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Consultar()
        Dim ConsultarGrado As New frmScontCuentaContableEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCuentasTabla.GetSelectedRows()
                FilaActual = Me.grdCuentasTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrado.TyGui = 3
                    ConsultarGrado.CuentaID = Me.dtCuentas.DefaultView.Item(FilaActual)("SContCuentasContablesID")
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
        Dim EditarGrado As New frmScontCuentaContableEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCuentasTabla.GetSelectedRows()
                FilaActual = Me.grdCuentasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrado.TyGui = 2
                    EditarGrado.CuentaID = Me.dtCuentas.DefaultView.Item(FilaActual)("SContCuentasContablesID")
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
        Dim objGrado As New SContCuentasContables
        Dim FilaActual As Integer
        Try
            Try
                ''Primero validamos que esta cuenta no tenga movimientos en un mes abierto


                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdCuentasTabla.GetSelectedRows()
                    FilaActual = Me.grdCuentasTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objGrado.Retrieve(Me.dtCuentas.DefaultView.Item(FilaActual)("SContCuentasContablesID"))
                        objGrado.Activo = False
                        objGrado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objGrado.FechaModificacion = clsProyecto.Conexion.FechaServidor
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
        Dim editcuenta As frmScontCuentaContableEdit
        Try
            Me.Cursor = WaitCursor
            editcuenta = New frmScontCuentaContableEdit
            editcuenta.TyGui = 1
            If editcuenta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
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
            Dim objjReporte As New rptCuentasContables()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" SContCuentasContablesID, IDCuenta, Descripcion, objNaturalezaID, Nivel, RecibeMovimiento, TieneAuxilar, Activo, CuentaPadre, Naturaleza, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa", "vwRptSContCuentasContables", "Activo=1"))

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




    Private Sub grdGradosTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdCuentasTabla.DoubleClick
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