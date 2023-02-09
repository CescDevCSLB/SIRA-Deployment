Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraSeleccionarParcial

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, dtAlumnos, dtGrupos, DtParcial, dtSemestres As DataTable
    Public intTypeGui, intEvidenciaID As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, IdAlumno As Integer
    Private strNombre As String

#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property

    Property EvidenciaID() As Integer
        Get
            Return intEvidenciaID
        End Get
        Set(ByVal value As Integer)
            intEvidenciaID = value
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

#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarParcial()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Cargar combos"


    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarParcial()
        Try
            DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
            DtParcial.DefaultView.Sort = "Descripcion"

            cmbParcial.ValueMember = "StbValorCatalogoID"
            cmbParcial.DisplayMember = "Descripcion"
            cmbParcial.DataSource = DtParcial

            cmbParcial.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            cmbParcial.ColumnHeaders = False
            cmbParcial.ExtendRightColumn = True
            cmbParcial.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region




    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If cmbParcial.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbParcial, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function


#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim editbodega As frmSraEvidenciasEditar

        Try
            Me.Cursor = WaitCursor
            If ValidarEntrada() Then
                editbodega = New frmSraEvidenciasEditar
                editbodega.EvidenciaID = Me.EvidenciaID
                editbodega.Nombre = strNombre
                editbodega.ParcialID = cmbParcial.SelectedValue
                If editbodega.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

#End Region


    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        Me.ErrorProv.SetError(cmbParcial, "")
    End Sub



End Class