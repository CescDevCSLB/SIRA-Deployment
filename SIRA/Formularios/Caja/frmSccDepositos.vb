Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos

Public Class frmSccDepositos

#Region "Variables del formulario"
    Dim dtArqueos As DataTable
    Dim EsNotaDebito As Integer
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAprobar, boolImprimir As Boolean

    Private m_DiasArqueosRecientes As Integer

    Property DiasArqueosRecientes() As Integer
        Get
            DiasArqueosRecientes = Me.m_DiasArqueosRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasArqueosRecientes = value
        End Set
    End Property
#End Region

#Region "Incializar GUI"

    Private Sub Inactivar()
        Dim objDepositos As New ScontDepositos
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox(My.Resources.MsgConfirmarInactivar, MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
                    FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        objDepositos.Retrieve(Me.dtArqueos.DefaultView.Item(FilaActual)("ScontDepositosID"))
                        objDepositos.Activo = False
                        objDepositos.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objDepositos.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objDepositos.Update()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDepositos = Nothing
        End Try
    End Sub

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Dim strFiltro As String = String.Empty
        Try
            Me.DiasArqueosRecientes = ClsCatalogos.GetValorParametro("DiasArqueosRecientes")

            strFiltro = " FechaDeposito BETWEEN GETDATE()- " & Me.DiasArqueosRecientes.ToString & " AND GETDATE() "

            dtArqueos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("distinct EntradaEfectivo, ScontDepositosID, FechaDeposito, FechaArqueo,Descripcion", "vwRptScontDepositos", strFiltro))
            dtArqueos.DefaultView.Sort = "FechaDeposito Desc"
            Me.grdArqueo.DataSource = dtArqueos
            Me.grdArqueo.Text = "Depositos (" & Me.dtArqueos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            'objseg.ServicioUsuario = "frmSccArqueoCaja"
            'objseg.Usuario = clsProyecto.Conexion.Usuario
            'boolAgregar = objseg.TienePermiso("AgregarCierre")
            'boolConsultar = objseg.TienePermiso("ConsultarArqueo")
            'boolAprobar = objseg.TienePermiso("AprobarArqueo")
            'boolImprimir = objseg.TienePermiso("ImprimirArqueo")

            cmdAgregar.Enabled = True
            cmdConsultar.Enabled = dtArqueos.Rows.Count > 0
            cmdAprobar.Enabled = True
            cmdAnular.Enabled = dtArqueos.Rows.Count > 0
            cmdImprimir.Enabled = dtArqueos.Rows.Count > 0

            'cmdAgregar.Enabled = boolAgregar
            'cmdConsultar.Enabled = boolConsultar And dtArqueos.Rows.Count > 0
            'cmdAprobar.Enabled = boolAprobar ''And dtArqueos.Rows.Count > 0
            'cmdImprimir.Enabled = boolImprimir And dtArqueos.Rows.Count > 0

            'If dtArqueos.Rows.Count > 0 Then

            '    Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
            '    FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

            '    If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado").ToString.Trim.Length <> 0 Then

            '        If Me.dtArqueos.DefaultView.Item(FilaActual)("Aprobado") Then
            '            Me.cmdAprobar.Enabled = False
            '        Else
            '            Me.cmdAprobar.Enabled = True
            '        End If

            '    End If

            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub Consultar()
        Dim objDepisitar As New frmSccDepositosEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
                FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    objDepisitar.DepositoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ScontDepositosID")
                    objDepisitar.TypeID = 2

                    If objDepisitar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDepisitar = Nothing
        End Try
    End Sub

    Private Sub Editar()
        Dim objDepisitar As New frmSccDepositosEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdArqueoabla.GetSelectedRows()
                FilaActual = Me.grdArqueoabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    objDepisitar.DepositoID = Me.dtArqueos.DefaultView.Item(FilaActual)("ScontDepositosID")
                    objDepisitar.TypeID = 1

                    If objDepisitar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDepisitar = Nothing
        End Try
    End Sub

    Private Sub Agregar()
        Dim objDepisitar As New frmSccDepositosEdit
        Try
            Try
                objDepisitar.TypeID = 0
                If objDepisitar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGrid()
                    AplicarSeguridad()
                End If
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objDepisitar = Nothing
        End Try
    End Sub

#End Region

#Region "Eventos del formulario"

    Private Sub frmSccArquo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Editar()
        CargarGrid()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim objDepisitar As New frmScontRptDepositos
        Try
            objDepisitar.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAnular_Click(sender As Object, e As EventArgs) Handles cmdAnular.Click
        Inactivar()
        CargarGrid()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Agregar()
    End Sub


    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Consultar()
    End Sub


    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
        AplicarSeguridad()
    End Sub

#End Region

End Class