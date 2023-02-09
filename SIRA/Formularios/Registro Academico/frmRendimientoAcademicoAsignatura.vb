Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports Seguridad.Datos
Imports DevExpress.XtraReports.UI

Public Class frmRendimientoAcademicoAsignatura
    Dim dtGrupos, DtModalidad, dtPeriodos, DtParcial, dtSemestres As DataTable
    Dim GrupoID, idModalidad As Integer
    Dim dsGrupos As DataSet
    Dim objSeg As SsgSeguridad
    Dim blnImprimir, blnExportar As Boolean

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        rbParcial.Checked = True
        CargarPeriodos()
        CargarModalidad()
        AplicarSeguridad()
    End Sub

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Try
            ErrPrv.SetError(txtGrado, "")

            If Me.cmbPeriodo.ToString.Trim.Length = 0 Then
                MsgBox("Debe seleccionar el período lectivo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Me.cmbPeriodo.Focus()
                Exit Sub
            End If

            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            objPersonas.Opcion = 2
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa,objModalidadIDGrupo", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then
                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    idModalidad = dtGrupos.Rows(0)("objModalidadIDGrupo")
                End If

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "rptRendimientoAcademicoAsignatura"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If objSeg.TienePermiso("ImprimirRendimientoAsignatura") Then
                blnImprimir = True
                Me.cmdImprimir.Enabled = True
            Else
                blnImprimir = False
                Me.cmdImprimir.Enabled = False
            End If

            If objSeg.TienePermiso("ExportarRendimientoAsignatura") Then
                blnExportar = True
                Me.cmbExportar.Enabled = True
            Else
                blnExportar = False
                Me.cmbExportar.Enabled = False
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarModalidad()
        DtModalidad = ClsCatalogos.GetValoresCatalogo("MODALIDAD", "StbValorCatalogoID,Descripcion", "")
        DtModalidad.DefaultView.Sort = "Descripcion"
        With cmbModalidad
            .Properties.DataSource = DtModalidad
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
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

    Private Function ValidarEntrada()

        If Me.cmbPeriodo.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbPeriodo, "Debe seleccionar el periodo")
            Me.cmbPeriodo.Focus()
            Return False
            Exit Function
        End If


        'If Me.cmbModalidad.Text.Trim.Length = 0 Then
        '    Me.ErrPrv.SetError(Me.cmbModalidad, "Debe seleccionar el parcial")
        '    Me.cmbModalidad.Focus()
        '    Return False
        '    Exit Function
        'End If

        Return True
    End Function

    Public Sub CargarGrid()
        Dim nota As Integer = 0
        Dim contador As Integer = 0
        Dim objNotascualitavias As New SraNotas_Cualitativas
        Try

            If rbParcial.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then

                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue))
                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal, Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue & " AND SraGrupoID =" & GrupoID))

                    End If
                Else
                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal, Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue))
                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal, Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue & " AND SraGrupoID =" & GrupoID))

                    End If
                End If

            ElseIf rbSemestre.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then
                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")"))

                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")" & " AND SraGrupoID =" & GrupoID))

                    End If
                Else
                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")"))
                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal, Genero,Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")" & " AND SraGrupoID =" & GrupoID))

                    End If

                End If
            ElseIf rbNotaFinal.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then
                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue))
                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND SraGrupoID =" & GrupoID))

                    End If
                Else
                    If GrupoID = 0 Then
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue))
                    Else
                        dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("PeriodoID, Asignatura, objModalidadID, Modalidad, SraGrupoID, Grupo, MatriculaFinal,Genero, Aprobados, Reprobados, PorcentajeAprobado, PorcentajeReprobado", "vwRptRendimientoXAsignatura", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND SraGrupoID =" & GrupoID))

                    End If

                End If
            End If

            Me.grdRendimiento.DataSource = dtGrupos
            Me.grdRendimiento.Text = "Notas (" & Me.dtGrupos.Rows.Count & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmRendimientoAcademico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs)
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim pivotExportOptions As New DevExpress.XtraPivotGrid.PivotXlsxExportOptions()
                pivotExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
                grdRendimiento.ExportToXlsx(sfdRuta.FileName, pivotExportOptions)

                'Me.PivotConsolidado.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarParcial()
        DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
        DtParcial.DefaultView.Sort = "Descripcion"
        With cmbBusqueda
            .Properties.DataSource = DtParcial
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
            .ItemIndex = 0
        End With
    End Sub

    Private Sub CargarSemestres()
        dtSemestres = ClsCatalogos.GetValoresCatalogo("SEMESTRES", "StbValorCatalogoID,Descripcion", "")
        dtSemestres.DefaultView.Sort = "Descripcion"
        With cmbBusqueda
            .Properties.DataSource = dtSemestres
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
            .ItemIndex = 0
        End With
    End Sub

    Private Sub rbSemestre_CheckedChanged(sender As Object, e As EventArgs) Handles rbSemestre.CheckedChanged
        If rbSemestre.Checked Then
            cmbBusqueda.Enabled = True
            CargarSemestres()
        Else
            If rbParcial.Checked Then
                cmbBusqueda.Enabled = True
                CargarParcial()
            Else
                cmbBusqueda.Text = String.Empty
                cmbBusqueda.Enabled = False
            End If
        End If
    End Sub

    Private Sub rbNotaFinal_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotaFinal.CheckedChanged
        If rbNotaFinal.Checked Then
            cmbBusqueda.Text = String.Empty
            cmbBusqueda.Enabled = False
        End If
    End Sub

    Private Sub chkGrupo_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrupo.CheckedChanged
        If chkGrupo.Checked Then
            chkModalidad.Checked = False
            cmbModalidad.Enabled = False
            cmdBuscar.Enabled = True
        Else
            chkModalidad.Checked = True
            cmdBuscar.Enabled = False
        End If
    End Sub

    Private Sub chkModalidad_CheckedChanged(sender As Object, e As EventArgs) Handles chkModalidad.CheckedChanged
        If chkModalidad.Checked Then
            chkGrupo.Checked = False
            cmbModalidad.Enabled = True
            cmdBuscar.Enabled = False
        Else
            chkGrupo.Checked = True
            cmbModalidad.Enabled = False
            cmdBuscar.Enabled = True
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If ValidarEntrada() Then
            CargarGrid()
        End If

    End Sub

    Private Sub rbParcial_CheckedChanged(sender As Object, e As EventArgs) Handles rbParcial.CheckedChanged
        If rbNotaFinal.Checked Then
            cmbBusqueda.Text = String.Empty
            cmbBusqueda.Enabled = False
        Else
            If rbSemestre.Checked Then
                cmbBusqueda.Enabled = True
                CargarSemestres()
            Else
                cmbBusqueda.Enabled = True
                CargarParcial()
            End If
        End If
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        ErrPrv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        ErrPrv.SetError(cmbModalidad, "")
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Try
            Dim report As rptRendimientoacademicoAsig = New rptRendimientoacademicoAsig()

            If rbParcial.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then

                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1  objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue))
                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1  objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue & " AND SraGrupoID =" & GrupoID))
                    End If
                Else
                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue))

                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID=" & cmbBusqueda.EditValue & " AND SraGrupoID =" & GrupoID))
                    End If
                End If

            ElseIf rbSemestre.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then
                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")"))

                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")" & " AND SraGrupoID =" & GrupoID))

                    End If
                Else
                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")"))

                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID = " & cmbBusqueda.EditValue & ")" & " AND SraGrupoID =" & GrupoID))

                    End If

                End If
            ElseIf rbNotaFinal.Checked = True Then

                If cmbModalidad.Text.Trim.Length > 0 Then
                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue))
                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", "  objModalidadID=" & cmbModalidad.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " AND SraGrupoID =" & GrupoID))

                    End If
                Else
                    If GrupoID = 0 Then
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue))

                    Else
                        dsGrupos = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("TOP 1 objParcialID, GradoID, SraGrupoID, Empresa, DireccionEmpresa, EmailEmpresa, TelefonosEmpresa, Periodo, PeriodoID, Grado, Seccion", "vwRptGeneral", " PeriodoID =" & cmbPeriodo.SelectedValue & " AND SraGrupoID =" & GrupoID))

                    End If

                End If
            End If


            report.DataSource = dsGrupos
            report.DataMember = dsGrupos.Tables(0).TableName
            report.GridControl = grdRendimiento
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class