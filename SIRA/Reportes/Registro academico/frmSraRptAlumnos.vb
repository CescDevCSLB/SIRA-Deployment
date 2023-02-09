Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraRptAlumnos

#Region "Declaracion de Variables"
    Public dtPeriodos, DtAsignaturas, dtAlumnos, dtGrupos As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, IdAlumno, GradoID As Integer
#End Region


#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarPeriodos()
     
    End Sub

#End Region


#Region "Cargar combos"

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable

        Try
            If (cmbPeriodo.Text.Trim.Length = 0) Then
                MsgBox("Debe seleccionar el periodo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            objPersonas.Opcion = 2

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then

                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.GradoID = dtGrupos.Rows(0)("GradoID")
                End If
                'Seguridad()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

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


    Private Sub GenerarReporte()
        Dim ds As New DataSet
        Try
            Dim objjReporte As New rptAlumnosPadres()

            If IdAlumno = 0 Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("distinct Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, NombreCompleto, Nombres, Apellido1, Apellido2, CodigoMED, FechaNacimiento, Direccion, Familiar, Celular, TelefonoParticular, TelefonoTrabajo, Parentesco", "vwRptAlumnosPadresGrupos", " SraGrupoID=" & GrupoID))
            Else
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("distinct Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, NombreCompleto, Nombres, Apellido1, Apellido2, CodigoMED, FechaNacimiento, Direccion, Familiar, Celular, TelefonoParticular, TelefonoTrabajo, Parentesco", "vwRptAlumnosPadres", " AlumnoID=" & IdAlumno))
            End If

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
        GenerarReporte()

    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs)
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub



#End Region




    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub txtGrado_TextChanged(sender As Object, e As EventArgs) Handles txtGrado.TextChanged
        Me.ErrorProv.SetError(txtGrado, "")
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

    Public Sub CargarAlumnos()
        Try
            Dim strFiltro As String = ""
            strFiltro = "PeriodoID= " & cmbPeriodo.SelectedValue & " AND StbPersonaID = '" & idPersona.ToString & "'"
            dtAlumnos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID, NombreCompleto, StbPersonaID, Grupo, PeriodoID, Guia", "vwSraAlumnosCalificaciones", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAlumno_Click(sender As Object, e As EventArgs) Handles cmdAlumno.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Opcion = 4
            objSeleccion.PeriodoID = cmbPeriodo.SelectedValue
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
End Class