Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraSeleccionarRendimiento

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, DtParcial, dtGrupos As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, ParcialID As Integer
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
        CargarParcial()
       
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

    Private Sub CargarParcial()
        DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
        DtParcial.DefaultView.Sort = "Descripcion"
        With cmbParcial
            .Properties.DataSource = DtParcial
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
        End With



    End Sub




#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            ParcialID = cmbParcial.EditValue
            intPeriodoID = cmbPeriodo.SelectedValue

            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try


        'Dim ds As DataSet
        'Try
        '    Dim objjReporte As New rptRendimientoacademico()

        '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico " & cmbParcial.EditValue & " , " & GrupoID & ", " & cmbPeriodo.SelectedValue))

        '    If ds.Tables(0).Rows.Count <> 0 Then
        '        objjReporte.DataSource = ds
        '        objjReporte.DataMember = ds.Tables(0).TableName
        '        Dim pt As New ReportPrintTool(objjReporte)
        '        pt.ShowPreview()
        '    Else
        '        MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '    End If




        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try
    End Sub

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Try
            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            objPersonas.Opcion = 2
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then
                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                End If

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

#End Region


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub
End Class