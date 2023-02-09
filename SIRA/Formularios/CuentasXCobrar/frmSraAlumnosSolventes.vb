Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmSraAlumnosSolventes

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, dtAlumnos, dtGrupos, dtMes As DataTable
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
        Try
            CargarMes()
            CargarPeriodos()
            CargarModalidad()
            cmbMes.SelectedValue = Date.Now.Month
            If TypeGui = 1 Then
                rbInSolventes.Visible = True
                rbSolventes.Visible = True
            Else
                rbInSolventes.Visible = False
                rbSolventes.Visible = False
            End If
        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Seleccionar Periodo"

    Private Sub CargarModalidad()
        Try
            'Modalidad
            dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))
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
            dtAlumnos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID, NombreCompleto, StbPersonaID, Grupo, PeriodoID, Guia", "vwSraAlumnosCalificaciones", strFiltro))
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

            If rbGrupo.Checked Then
                If txtGrado.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(txtGrado, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If
            If rbModalidad.Checked Then
                If cmbModalidad.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbModalidad, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Sub GenerarReporteMorosos()
        Dim ds As New DataSet
        Dim objjReporte As New rptGruposAlumnosMorosos()
        Try
            If rbModalidad.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, objAlumnoID, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, objModalidadID, Fecha,CantidadMesesMora,Mora,SaldoLinea", "vwRptGruposAlumnosMorosos", " objModalidadID= " & cmbModalidad.SelectedValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue))
            Else
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID,Beca, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, objAlumnoID, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, objModalidadID, Fecha,CantidadMesesMora,Mora,SaldoLinea", "vwRptGruposAlumnosMorosos", " SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

            End If
           
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
    Public Sub CargarMes()
        Try
            dtMes = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" NumMes, Mes", "StbMeses", "1=1 ORDER BY NumMes ASC"))

            cmbMes.ValueMember = "NumMes"
            cmbMes.DisplayMember = "Mes"
            cmbMes.DataSource = dtMes

            cmbMes.Splits(0).DisplayColumns("NumMes").Visible = False
            cmbMes.ColumnHeaders = False
            cmbMes.ExtendRightColumn = True
            cmbMes.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub GenerarReportesSolventes()
        Dim ds As New DataSet
        Dim objjReporte As New rptGruposAlumnosSolventes()
        Try
            If rbModalidad.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,objModalidadID", "vwRptGruposAlumnosSolventes", " Mes= " & cmbMes.SelectedValue & "  AND objModalidadID= " & cmbModalidad.SelectedValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

            Else
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,objModalidadID", "vwRptGruposAlumnosSolventes", "Mes= " & cmbMes.SelectedValue & "  AND  SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

            End If

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.rptTitulo.Text = "Alumnos solventes del mes de " & cmbMes.Text
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GenerarReportesInSolventes()
        Dim ds As New DataSet
        Dim objjReporte As New rptGruposAlumnosSolventes()
        Try
            If rbModalidad.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,objModalidadID", "vwRptGruposAlumnosInSolventes", " Mes= " & cmbMes.SelectedValue & "  AND objModalidadID= " & cmbModalidad.SelectedValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

            Else
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,objModalidadID", "vwRptGruposAlumnosInSolventes", "Mes= " & cmbMes.SelectedValue & "  AND  SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

            End If

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                objjReporte.rptTitulo.Text = "Alumnos insolventes del mes de " & cmbMes.Text
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
            If TypeGui = 1 Then
                If rbSolventes.Checked Then
                    GenerarReportesSolventes()
                ElseIf rbInSolventes.Checked Then
                    GenerarReportesInSolventes()
                End If

            ElseIf TypeGui = 2 Then
                GenerarReporteMorosos()
            End If

        End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Opcion = 2

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
            Me.txtGrado.DataBindings.Clear()
            Me.txtGuia.DataBindings.Clear()

            Me.idPersona = dtAlumnos.Rows(0)("StbPersonaID")
            Me.IdAlumno = dtAlumnos.Rows(0)("AlumnoID")
            Me.txtGrado.DataBindings.Add("text", dtAlumnos, "Grupo", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtGuia.DataBindings.Add("text", dtAlumnos, "Guia", False, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

    
    Private Sub rbModalidad_CheckedChanged(sender As Object, e As EventArgs) Handles rbModalidad.CheckedChanged
        If rbModalidad.Checked Then
            cmdBuscar.Enabled = False
            cmbModalidad.Enabled = True
        Else : cmdBuscar.Enabled = True
        End If
    End Sub

    Private Sub rbGrupo_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrupo.CheckedChanged
        If rbGrupo.Checked Then
            cmdBuscar.Enabled = True
            cmbModalidad.Enabled = False
        Else : cmdBuscar.Enabled = False
        End If
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        Me.ErrorProv.SetError(cmbModalidad, "")
    End Sub
End Class