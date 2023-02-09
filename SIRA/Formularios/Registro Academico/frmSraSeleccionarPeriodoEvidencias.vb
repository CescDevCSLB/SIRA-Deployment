Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraSeleccionarPeriodoEvidencias

#Region "Declaracion de Variables"
    Public dtPeriodos, DtBusquedaProfesor As DataTable
    Public intPeriodoID As Integer
    Public intProfesor As Integer
    Public blnTodos As Boolean
#End Region

#Region "Propiedades"

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Property ProfesorID() As String
        Get
            Return intProfesor
        End Get
        Set(ByVal value As String)
            intProfesor = value
        End Set

    End Property

#End Region

#Region "Configruacion"

    Public Sub ConfigurarGUI()
        CargarPeriodos()
        BuscarProfesor()

        If intProfesor = 0 Then
            chkTodas.Visible = True

        Else
            chkTodas.Visible = False
        End If
    End Sub


    Private Sub BuscarProfesor()
        Try
            DtBusquedaProfesor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbProfesorID, Login", "vwCuentaProfesor", " Login='" & clsProyecto.Conexion.Usuario & "'"))
            If DtBusquedaProfesor.Rows.Count > 0 Then
                intProfesor = DtBusquedaProfesor.Rows(0)("StbProfesorID")
            Else
                intProfesor = 0
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seleccionar Periodo"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub SeleccionarPeriodo()
        Try

            blnTodos = chkTodas.Checked
            If blnTodos Then
                intPeriodoID = 0
            Else
                intPeriodoID = cmbPeriodo.SelectedValue
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar combos"

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If Not chkTodas.Checked Then
                If cmbPeriodo.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            SeleccionarPeriodo()
        End If
    End Sub

    Private Sub chkTodas_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodas.CheckedChanged
        If chkTodas.Checked Then
            cmbPeriodo.Text = String.Empty
            cmbPeriodo.Enabled = False
        Else
            cmbPeriodo.Enabled = True
        End If
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

#End Region




End Class