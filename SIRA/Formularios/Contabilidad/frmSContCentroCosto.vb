Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO

Public Class frmSContCentroCosto


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
            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SconCentroCostoID,Codigo, Nombre, Activo", "ScontCentrosCosto", "Activo=1"))
            dtGrupos.PrimaryKey = New DataColumn() {Me.dtGrupos.Columns("SconCentroCostoID")}
            dtGrupos.DefaultView.Sort = "SconCentroCostoID desc"
            Me.grdCentrosCosto.DataSource = dtGrupos
            Me.grdCentrosCosto.Text = "Centros de costo (" & Me.dtGrupos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmScontCentroCosto"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCentroCosto")
            boolConsultar = objseg.TienePermiso("ConsultarCentroCosto")
            boolEditar = objseg.TienePermiso("EditarCentroCosto")
            boolImprimir = objseg.TienePermiso("ImprimirCentroCosto")
            boolInactivar = objseg.TienePermiso("InactivarCentroCosto")

            cmdAgregar.Enabled = boolAgregar
            cmdEditar.Enabled = boolEditar And dtGrupos.Rows.Count > 0
            cmdConsultar.Enabled = boolConsultar And dtGrupos.Rows.Count > 0
            cmdImprimir.Enabled = boolImprimir And dtGrupos.Rows.Count > 0
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
        Dim ConsultarGrupos As New frmScontCentroCostoEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCentrosCostoTabla.GetSelectedRows()
                FilaActual = Me.grdCentrosCostoTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarGrupos.TyGui = 3
                    ConsultarGrupos.CentroID = Me.dtGrupos.DefaultView.Item(FilaActual)("SconCentroCostoID")
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
        Dim EditarGrupos As New frmScontCentroCostoEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdCentrosCostoTabla.GetSelectedRows()
                FilaActual = Me.grdCentrosCostoTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    EditarGrupos.TyGui = 2
                    EditarGrupos.CentroID = Me.dtGrupos.DefaultView.Item(FilaActual)("SconCentroCostoID")
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
        Dim editgrado As frmScontCentroCostoEdit
        Try
            Me.Cursor = WaitCursor
            editgrado = New frmScontCentroCostoEdit
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
        Dim objCentro As New ScontCentrosCosto
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdCentrosCostoTabla.GetSelectedRows()
                    FilaActual = Me.grdCentrosCostoTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objCentro.Retrieve(Me.dtGrupos.DefaultView.Item(FilaActual)("SconCentroCostoID"))
                        objCentro.Activo = False
                        objCentro.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objCentro.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objCentro.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objCentro = Nothing
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

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptCentroCosto()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Naturaleza, Nivel", "vwRptSContCentroCostoCuentas", "Activo=1"))

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

#Region "Asignar grados y asignaturas"
    Private Sub AsignarGradosAsignaturas()
        Dim objPersonas As frmSraGrupoAsignaturasProfesor
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdCentrosCostoTabla.GetSelectedRows()
            FilaActual = Me.grdCentrosCostoTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmSraGrupoAsignaturasProfesor
                objPersonas.TyGui = 2
                objPersonas.GrupoID = Me.dtGrupos.DefaultView.Item(FilaActual)("SraGrupoID")
                objPersonas.GradoID = Me.dtGrupos.DefaultView.Item(FilaActual)("GradoID")

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

    Private Sub cmdAsignar_Click(sender As Object, e As EventArgs)
        AsignarGradosAsignaturas()
    End Sub
End Class