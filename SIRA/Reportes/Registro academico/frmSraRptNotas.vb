Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraRptNotas

#Region "Declaracion de Variables"
    Public dtPeriodos, DtAsignaturas, DtParcial, dtGrupos As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, IdAlumno, GradoID, modalidad As Integer
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
        CargarAsignaturas()
    End Sub

#End Region


#Region "Cargar combos"

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable

        Try

            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            objPersonas.Opcion = 2

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa,objModalidadIDGrupo", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then

                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.GradoID = dtGrupos.Rows(0)("GradoID")
                    Me.modalidad = dtGrupos.Rows(0)("objModalidadIDGrupo")
                    CargarAsignaturas()
                End If
                'Seguridad()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub


    Public Sub CargarAsignaturas()
        Try
            If GrupoID.ToString.Trim.Length <> 0 Then
                DtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct AsignaturaID,  Nombre", "vwSraGruposProfesoresAsignaturas_Evaluacion", "Activo=1 and objGrupoID=" & GrupoID))
            End If

            DtAsignaturas.DefaultView.Sort = "Nombre"
            With cmbAsignatura
                .Properties.DataSource = DtAsignaturas
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "AsignaturaID"
                .Properties.PopulateColumns()
                .Properties.Columns("AsignaturaID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarParcial()
        DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
        DtParcial.DefaultView.Sort = "Descripcion"
        With cmbParcial
            .DataSource = DtParcial
            .DisplayMember = "Descripcion"
            .ValueMember = "StbValorCatalogoID"
            .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            .ColumnHeaders = False
            .ExtendRightColumn = True
        End With
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
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If Not chkNotaFinal.Checked Then
                If cmbParcial.Text.Trim.Length = 0 Then
                    ErrorProv.SetError(cmbParcial, My.Resources.MsgObligatorio)
                    Return False
                    Exit Function
                End If
            End If


            If Me.GrupoID.ToString.Trim.Length = 0 Then
                Me.ErrorProv.SetError(Me.txtGrado, "Debe seleccionar el grupo")
                Me.txtGrado.Focus()
                Return False
                Exit Function
                End
            End If
            If cmbAsignatura.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbAsignatura, My.Resources.MsgObligatorio)
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
        Dim DtVerificacion As DataTable
        Dim isCualitativa As Boolean = False
        Try
            Dim objjReporte As New rptNotas()

            ''Verificar si la asignatura es con nota cualitativa
            DtVerificacion = New DataTable()
            DtVerificacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGVerificarUnCualitativo(" & cmbAsignatura.EditValue & ", " & modalidad & ") "))

            If DtVerificacion.Rows.Count > 0 Then
                If DtVerificacion.Rows(0)(0) = "1" Then
                    isCualitativa = True
                Else
                    isCualitativa = False
                End If
            End If

            If Not isCualitativa Then
                If Not chkNotaFinal.Checked Then
                    If chkAplazados.Checked Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable", "Promedio<60 AND SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbParcial.SelectedValue & " AND AsignaturaID=" & cmbAsignatura.EditValue))
                    Else
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable", "SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbParcial.SelectedValue & " AND AsignaturaID=" & cmbAsignatura.EditValue))
                    End If
                Else
                    If chkAplazados.Checked Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable_NotaFinal", "Promedio<60 AND SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND AsignaturaID=" & cmbAsignatura.EditValue))
                    Else
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable_NotaFinal", "SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND AsignaturaID=" & cmbAsignatura.EditValue))
                    End If

                End If
            Else
                If chkAplazados.Checked Then
                    MsgBox("No es posible mostrar reporte de aplazados para una asignatura cualitativa.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Else
                    If Not chkNotaFinal.Checked Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable", "SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbParcial.SelectedValue & " AND AsignaturaID=" & cmbAsignatura.EditValue))
                    Else
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, AlumnoID, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Promedio, Parcial", "vwRptSraCalificacionesParametrizable_NotaFinal", " SraGrupoID= " & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & "  AND AsignaturaID=" & cmbAsignatura.EditValue))

                    End If
                End If

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

    Private Sub chkNotaFinal_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotaFinal.CheckedChanged
        If chkNotaFinal.Checked Then
            cmbParcial.Text = String.Empty
            cmbParcial.Enabled = False
        Else
            cmbParcial.Enabled = True
        End If
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

   

#End Region




    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        Me.ErrorProv.SetError(cmbParcial, "")
    End Sub

    Private Sub cmbAsignatura_TextChanged(sender As Object, e As EventArgs) Handles cmbAsignatura.TextChanged
        Me.ErrorProv.SetError(cmbAsignatura, "")
    End Sub

    Private Sub cmdBuscar_TextChanged(sender As Object, e As EventArgs) Handles cmdBuscar.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub txtGrado_TextChanged(sender As Object, e As EventArgs) Handles txtGrado.TextChanged
        Me.ErrorProv.SetError(txtGrado, "")
    End Sub
End Class