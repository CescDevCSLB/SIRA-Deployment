Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmRptBecas

#Region "Declaracion de Variables"
    Public dtPeriodos As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla As Integer
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
        CargarPeriodos()


    End Sub

#End Region

#Region "Seleccionar Periodo"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub SeleccionarPeriodo()
        Dim T As New DAL.TransactionManager
        Try
            intPeriodoID = cmbPeriodo.SelectedValue
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar combos"

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = -1


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
        Dim ds As DataSet
        Try
            Select Case TypeGui
                Case 1
                    Dim objjReporte As New RptBecas()
                    If ValidarEntrada() Then
                        intPeriodoID = cmbPeriodo.SelectedValue
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, CodigoMED, NombreCompleto, Genero, Edad, objPeriodoID, objGradoID, Beca, objBecaID, Grado", "vwRptStbBecas", "objPeriodoID=" + intPeriodoID.ToString))

                        If ds.Tables(0).Rows.Count <> 0 Then
                            objjReporte.DataSource = ds
                            objjReporte.DataMember = ds.Tables(0).TableName
                            Dim pt As New ReportPrintTool(objjReporte)
                            pt.ShowPreview()
                        Else
                            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        End If

                    End If

                Case 2
                    Dim objjReporte As New rptGruposAsignaturas()
                    If ValidarEntrada() Then
                        intPeriodoID = cmbPeriodo.SelectedValue
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCuantitativa, SraGrupos_ProfesorID, objGrupoID, StbProfesorID, AsignaturaID, Profesor, Asignatura", "vwRptGruposProfesorAsignaturas", "PeriodoID=" + intPeriodoID.ToString))

                        If ds.Tables(0).Rows.Count <> 0 Then
                            objjReporte.DataSource = ds
                            objjReporte.DataMember = ds.Tables(0).TableName
                            Dim pt As New ReportPrintTool(objjReporte)
                            pt.ShowPreview()
                        Else
                            MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        End If

                    End If
            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub



#End Region


End Class