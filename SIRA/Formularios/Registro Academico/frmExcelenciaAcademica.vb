Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI
Imports Seguridad.Datos

Public Class frmExcelenciaAcademica
    Dim dtGrupos, DtParcial, dtPeriodos, dtSemestres As DataTable
    Dim dtC As DataTable
    Dim GrupoID As Integer
    Dim objSeg As SsgSeguridad
    Dim blnImprimir, blnExportar As Boolean


    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarPeriodos()
        AplicarSeguridad()
        rbParcial.Checked = True
    End Sub

    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "rptExcelenciaAcademica"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If objSeg.TienePermiso("ImprimirExcelencia") Then
                blnImprimir = True
                Me.cmdImprimir.Enabled = True
            Else
                blnImprimir = False
                Me.cmdImprimir.Enabled = False
            End If

            If objSeg.TienePermiso("ExportarExcelencia") Then
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

    Private Sub CargarParcial()
        Try
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
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarSemestres()
        Try
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
        Catch ex As Exception
            clsError.CaptarError(ex)
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

    Private Function ValidarEntrada()

        If Me.cmbPeriodo.Text.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbPeriodo, "Debe seleccionar el periodo")
            Me.cmbPeriodo.Focus()
            Return False
            Exit Function
        End If



        'If Me.GrupoID.ToString.Trim.Length = 0 Then
        '    Me.ErrPrv.SetError(Me.txtGrado, "Debe seleccionar el grupo")
        '    Me.txtGrado.Focus()
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
            If rbParcial.Checked = True And Me.GrupoID = 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID= " & cmbBusqueda.EditValue & " AND PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

            ElseIf rbParcial.Checked = True And Me.GrupoID > 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND  SraGrupoID = " & GrupoID & " AND objParcialID=" & cmbBusqueda.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

            ElseIf rbSemestre.Checked = True And Me.GrupoID = 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

            ElseIf rbSemestre.Checked = True And Me.GrupoID > 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " SraGrupoID = " & GrupoID & " AND Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

            ElseIf rbNotaFinal.Checked = True And Me.GrupoID = 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia_Final", " Promedio>=90 AND  PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

            ElseIf rbNotaFinal.Checked = True And Me.GrupoID > 0 Then
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia_Final", " SraGrupoID = " & GrupoID & " AND Promedio>=90 and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))
            End If


            'If dtGrupos.Rows.Count > 0 Then
            '    For Each row As DataRow In dtGrupos.Rows
            '        dtC = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" Desde, Hasta,Valor", "vwNotasCualitativasGrupos", "SraGrupoID=" & GrupoID & " AND Desde<=" + row(3).ToString + " and hasta >=" + row(3).ToString))
            '        If dtC.Rows.Count > 0 Then
            '            row("NotaCualitativa") = dtC.Rows(0)("Valor")
            '        End If
            '    Next
            '    dtGrupos.Columns(3).SetOrdinal(dtGrupos.Columns.Count - 1)
            'End If
            dtGrupos.DefaultView.Sort = "Promedio DESC"
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

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Try
            ErrPrv.SetError(txtGrado, "")
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

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If ValidarEntrada() Then
            CargarGrid()
        End If

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        ErrPrv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs)
        ErrPrv.SetError(cmbBusqueda, "")
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As New DataSet
        Try
            Dim objjReporte As New rptExcelenciaacademica()
            If ValidarEntrada() Then
                If rbParcial.Checked = True And Me.GrupoID = 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID= " & cmbBusqueda.EditValue & " AND PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                ElseIf rbParcial.Checked = True And Me.GrupoID > 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND  SraGrupoID = " & GrupoID & " AND objParcialID=" & cmbBusqueda.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                ElseIf rbSemestre.Checked = True And Me.GrupoID = 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                ElseIf rbSemestre.Checked = True And Me.GrupoID > 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " SraGrupoID = " & GrupoID & " AND Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                ElseIf rbNotaFinal.Checked = True And Me.GrupoID = 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia_Final", " Promedio>=90 AND  PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                ElseIf rbNotaFinal.Checked = True And Me.GrupoID > 0 Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia_Final", " SraGrupoID = " & GrupoID & " AND Promedio>=90 and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))
                End If

                'If rbParcial.Checked = True And Me.GrupoID = 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID= " & cmbBusqueda.EditValue & " AND PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                'ElseIf rbParcial.Checked = True And Me.GrupoID > 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND  SraGrupoID = " & GrupoID & " AND objParcialID=" & cmbBusqueda.EditValue & " and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                'ElseIf rbSemestre.Checked = True And Me.GrupoID = 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                'ElseIf rbSemestre.Checked = True And Me.GrupoID > 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " SraGrupoID = " & GrupoID & " AND Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                'ElseIf rbNotaFinal.Checked = True And Me.GrupoID = 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))

                'ElseIf rbNotaFinal.Checked = True And Me.GrupoID > 0 Then
                '    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo,CAST(ROUND(AVG(cast(Promedio as decimal)),0)AS INT) AS Promedio ", "vwRptSraExcelencia", " SraGrupoID = " & GrupoID & " AND Promedio>=90 AND objParcialID IN (SELECT PS.objParcialID from [dbo].[StbParcialSemestreI] PS where PS.objSemestreID= " & cmbBusqueda.EditValue & ") and PeriodoID =" & cmbPeriodo.SelectedValue & " group by Periodo, Grado, Seccion, Guia, Modalidad,Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha,Codigo, CodigoMED, objAlumnoID, Alumno, Parcial, Grupo"))
                'End If

                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
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
End Class