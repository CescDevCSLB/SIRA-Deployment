Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmSraBusquedaExpediente

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, dtAlumnos, dtGrupos As DataTable
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
    End Sub

#End Region

#Region "Seleccionar Periodo"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub SeleccionarPeriodo()
        Dim T As New DAL.TransactionManager
        Try
            intPeriodoID = cmbPeriodo.SelectedValue

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


    Public Sub CargarAlumnos()
        Try
            Dim strFiltro As String = ""
            strFiltro = "PeriodoID= " & cmbPeriodo.SelectedValue & " AND StbPersonaID = '" & idPersona.ToString & "'"
            dtAlumnos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID, NombreCompleto, StbPersonaID, Grupo, PeriodoID, Guia", "vwRptGruposAlumnosEstadoCuenta", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If txtAlumno.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtAlumno, My.Resources.MsgObligatorio)
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
        Dim objjReporte As New rptEstadoCuenta()
        Try
            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccCuentaID,Beca, Numero, objAlumnoID, Alumno, objPeriodoID, Periodo, objGradoID, Grado, objEstadoID, Estado, objModalidadID, Modalidad, MesLetra, MontoPagado, FechaVencimiento, SaldoTotal, SaldoLinea,  CodigoMED, MontoInicial, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Mes,objBecaID", "vwRptEstadoCuenta", " objAlumnoID= " & IdAlumno & " AND objPeriodoID=" & cmbPeriodo.SelectedValue & " order by Mes asc"))

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

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Try
            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            txtAlumno.Text = String.Empty
            IdAlumno = 0
            objPersonas.Opcion = 3
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then
                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                End If

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

#End Region


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs)
        BuscarGrupo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAlumno.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Opcion = 6
            objSeleccion.Filtro = "PeriodoID=" & cmbPeriodo.SelectedValue
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idPersona = objSeleccion.Seleccion
                CargarAlumnos()
                Me.IdAlumno = dtAlumnos.Rows(0)("AlumnoID")
                VincularControles()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub VincularControles()
        Try
            Me.txtAlumno.DataBindings.Clear()
            Me.txtGrado.DataBindings.Clear()
          
            Me.idPersona = dtAlumnos.Rows(0)("StbPersonaID")
            Me.IdAlumno = dtAlumnos.Rows(0)("AlumnoID")
            Me.txtAlumno.DataBindings.Add("text", dtAlumnos, "NombreCompleto", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.txtGrado.DataBindings.Add("text", dtAlumnos, "Grupo", False, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

   
    Private Sub txtAlumno_TextChanged(sender As Object, e As EventArgs) Handles txtAlumno.TextChanged
        Me.ErrorProv.SetError(txtAlumno, "")
    End Sub
End Class