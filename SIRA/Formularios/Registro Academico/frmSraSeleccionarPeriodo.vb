Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraSeleccionarPeriodo

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, DtBusquedaProfesor As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, intProfesor As Integer
    Dim intModalidad As Integer
#End Region

#Region "Propiedades"

    Property ModaidadID() As String
        Get
            Return intModalidad
        End Get
        Set(ByVal value As String)
            intModalidad = value
        End Set

    End Property

    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property Pantalla() As Integer
        Get
            Return intPantalla
        End Get
        Set(ByVal value As Integer)
            intPantalla = value
        End Set
    End Property

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

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarPeriodos()

        If TypeGui = 0 Then
            CargarModalidad()
        Else
            If TypeGui = 2 Then
                cmbModalidad.Visible = False
                lblModalidad.Visible = False
            Else
                If TypeGui = 3 Then
                    cmbModalidad.Visible = False
                    lblModalidad.Visible = False
                Else
                    BuscarProfesor()
                    cmbModalidad.Visible = False
                    lblModalidad.Visible = False
                End If

            End If
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
        Dim T As New DAL.TransactionManager
        Try
            intPeriodoID = cmbPeriodo.SelectedValue

            Select Case TypeGui
                Case 0
                    If cmbModalidad.Text <> "Educacion Inicial" Then
                        Pantalla = 0
                        ModaidadID = cmbModalidad.SelectedValue
                    Else
                        Pantalla = 1
                        ModaidadID = cmbModalidad.SelectedValue
                    End If

            End Select
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar combos"

    Private Sub CargarModalidad()
        Try
            If ProfesorID <> 0 Then
                dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbValorCatalogoID,Descripcion", "StbProfesores_Modalidad", "StbProfesorID=" & ProfesorID))
            Else
                dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))

            End If
            'Modalidad
           Me.cmbModalidad.DataSource = dtModalidad
            Me.cmbModalidad.DisplayMember = "Descripcion"
            Me.cmbModalidad.ValueMember = "StbValorCatalogoID"
            Me.cmbModalidad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbModalidad.ExtendRightColumn = True
            Me.cmbModalidad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

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
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
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

#End Region


    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        Me.ErrorProv.SetError(cmbModalidad, "")
    End Sub
End Class