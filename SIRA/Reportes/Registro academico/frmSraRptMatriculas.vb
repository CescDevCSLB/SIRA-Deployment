Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmSraRptMatriculas

#Region "Declaracion de Variables"
    Public dtPeriodos, dtGrado, dtTipoMatricula As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, IdAlumno As Integer
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
        CargarTipoMatricula()
        CargarGrados()
    End Sub

#End Region


#Region "Cargar combos"
    Private Sub CargarGrados()
        Try
            dtGrado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID,Grado", "SraGrado", "Activo=1"))
            Me.cmbGrado.DataSource = dtGrado
            Me.cmbGrado.DisplayMember = "Grado"
            Me.cmbGrado.ValueMember = "GradoID"
            Me.cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            Me.cmbGrado.ExtendRightColumn = True
            Me.cmbGrado.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarTipoMatricula()
        Try
            'Género
            dtTipoMatricula = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOMATRÍCULA')"))
            Me.cmbTipoMatricula.DataSource = dtTipoMatricula
            Me.cmbTipoMatricula.DisplayMember = "Descripcion"
            Me.cmbTipoMatricula.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoMatricula.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoMatricula.ExtendRightColumn = True
            Me.cmbTipoMatricula.SelectedValue = -1
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



    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If dtpFechaInicial.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dtpFechaInicial, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If dtpFechaFinal.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dtpFechaFinal, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbGrado.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbGrado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbTipoMatricula.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbTipoMatricula, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Sub GenerarReporte()
        Dim ds As New DataSet
        Try
            Dim objjReporte As New rptMatriculasLista()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, CodigoMED, objPeriodoID, Alumno, Grado, Modadlidad, Edad, Genero, Periodo, FechaMatricula, GradoID,objTipoMatriculaID", "vwRptMatriculaAll", "objTipoMatriculaID= " & cmbTipoMatricula.SelectedValue & " AND GradoID=" & cmbGrado.SelectedValue & " AND objPeriodoID=" & cmbPeriodo.SelectedValue & " AND convert(varchar(10),FechaMatricula,112) >='" & dtpFechaInicial.DateTime.ToString("yyyyMMdd") & "' AND convert(varchar(10),FechaMatricula,112) <='" & dtpFechaFinal.DateTime.ToString("yyyyMMdd") & "'"))

            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            GenerarReporte()
        End If

    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub dtpFechaInicial_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaInicial.EditValueChanged
        Me.ErrorProv.SetError(dtpFechaInicial, "")
    End Sub

    Private Sub dtpFechaFinal_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaFinal.EditValueChanged
        Me.ErrorProv.SetError(dtpFechaFinal, "")
    End Sub

    Private Sub cmbGrado_TextChanged(sender As Object, e As EventArgs) Handles cmbGrado.TextChanged
        Me.ErrorProv.SetError(cmbGrado, "")
    End Sub

    Private Sub cmbTipoMatricula_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoMatricula.TextChanged
        Me.ErrorProv.SetError(cmbTipoMatricula, "")
    End Sub

#End Region


    
    
End Class