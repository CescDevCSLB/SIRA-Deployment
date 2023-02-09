Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraReports.UI
Imports Seguridad.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting

Public Class frmRendimiento
    Dim dtGrupos, DtParcial, dtPeriodos, dtSemestres As DataTable
    Dim dsGrupo As DataSet
    Dim dtC As DataTable
    Dim GrupoID As Integer
    Dim objSeg As SsgSeguridad
    Dim blnImprimir, blnExportar As Boolean
    Dim idModalidad As Integer

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        CargarPeriodos()
        rbParcial.Checked = True

        AplicarSeguridad()
    End Sub

    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "rptRendimientoAcademico"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If objSeg.TienePermiso("ImprimirRendimiento") Then
                blnImprimir = True
                Me.cmdImprimir.Enabled = True
            Else
                blnImprimir = False
                Me.cmdImprimir.Enabled = False
            End If

            If objSeg.TienePermiso("ExportarRendimiento") Then
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


        If Me.cmbBusqueda.Text.Trim.Length = 0 And Not rbNotaFinal.Checked Then
            Me.ErrPrv.SetError(Me.cmbBusqueda, "Debe seleccionar el parcial")
            Me.cmbBusqueda.Focus()
            Return False
            Exit Function
        End If

        If Me.GrupoID = 0 Then
            Me.ErrPrv.SetError(Me.txtGrado, "Debe seleccionar el grupo")
            Me.txtGrado.Focus()
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Function Redondeo(ByVal Numero, ByVal Decimales)
        Redondeo = Int(Numero * 10 ^ Decimales + 1 / 2) / 10 ^ Decimales
    End Function


    Public Sub CargarGrid()
        Dim nota As Integer = 0
        Dim contador As Integer = 0
        Dim objNotascualitavias As New SraNotas_Cualitativas
        Dim SearchForThis As String = "-"
        Dim FirstCharacter As Integer = 0
        Dim LengthString As Integer = 0
        Dim letra As String = String.Empty
        Dim intIDAsignatura As String = String.Empty
        Dim DtVerificacion As DataTable
        Dim DtNotaCualitativa As DataTable

        Try
            Me.grdRendimiento.DataSource = Nothing

            If rbParcial.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico " & cmbBusqueda.EditValue & " , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",1"))
            ElseIf rbSemestre.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico " & cmbBusqueda.EditValue & " , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",2"))
            ElseIf rbNotaFinal.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico 0 , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",3"))
            End If

            If dsGrupo.Tables.Count > 0 Then
                dtGrupos = dsGrupo.Tables(0)
                Dim dt2 As New DataTable
                dt2 = dtGrupos.Clone()


                For Each columna As DataColumn In dt2.Columns
                    If Not IsNothing(dt2.Columns.IndexOf(columna)) Then
                        Dim indice As Integer = CInt(dt2.Columns.IndexOf(columna))
                        If indice > 4 Then
                            dt2.Columns(indice).DataType = GetType(System.String)

                        End If
                    End If
                Next

                ''llenamos el dt clonado
                For Each row As DataRow In dtGrupos.Rows
                    dt2.ImportRow(row)
                Next

                ''Procedemos a recorrer la tabla nueva
                For Each row As DataRow In dt2.Rows
                    For Each columna As DataColumn In dt2.Columns
                        If Not IsNothing(dt2.Columns.IndexOf(columna)) Then
                            Dim indice As Integer = CInt(dt2.Columns.IndexOf(columna))
                            If indice > 4 Then

                                ''Cortar el nombre
                                FirstCharacter = columna.ColumnName.IndexOf(SearchForThis)
                                intIDAsignatura = columna.ColumnName.Substring(0, FirstCharacter)

                                ''Buscamos si la asignatura es cualitativa
                                DtVerificacion = New DataTable()
                                DtVerificacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGVerificarUnCualitativo(" & intIDAsignatura & ", " & idModalidad & ") "))

                                If Not IsDBNull(DtVerificacion) Then

                                    If DtVerificacion.Rows(0)(0) <> "1" Then
                                        nota = nota + CInt(row(indice))
                                        contador = contador + 1
                                    Else
                                        ''Buscamos la nota cualitativa
                                        DtNotaCualitativa = New DataTable()

                                        If rbParcial.Checked = True Then
                                            DtNotaCualitativa = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGetNotaCualitativa(0," & intIDAsignatura & ", " & cmbBusqueda.EditValue & " , " & GrupoID & ", '" & row(1) & "', " & row(0) & ") "))
                                        ElseIf rbSemestre.Checked = True Then
                                            DtNotaCualitativa = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGetNotaCualitativa(" & cmbBusqueda.EditValue & "," & intIDAsignatura & ", 1 , " & GrupoID & ", '" & row(1) & "', " & row(0) & ") "))
                                        ElseIf rbNotaFinal.Checked = True Then
                                            DtNotaCualitativa = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGetNotaCualitativa(0," & intIDAsignatura & ", 0 , " & GrupoID & ", '" & row(1) & "', " & row(0) & ") "))
                                        End If

                                        If DtNotaCualitativa.Rows.Count > 0 Then
                                            row(columna.ColumnName) = DtNotaCualitativa.Rows(0)(0).ToString()
                                        End If


                                    End If
                                End If


                            End If
                            End If
                    Next

                    row(3) = CInt(Redondeo(CDec(nota) / CDec(contador), 0))
                    dtC = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" Desde, Hasta, Valor", "vwNotasCualitativasGrupos", "SraGrupoID=" & GrupoID & " And Desde<=" + row(3).ToString + " And hasta >=" + row(3).ToString))
                    If dtC.Rows.Count > 0 Then
                        row(4) = dtC.Rows(0)("Valor")
                    End If

                Next
                ''Cambiamos el nombre de a las columnas
                For Each row As DataRow In dt2.Rows
                    For Each columna As DataColumn In dt2.Columns
                        Dim indice As Integer = CInt(dt2.Columns.IndexOf(columna))
                        If indice > 4 Then
                            FirstCharacter = columna.ColumnName.IndexOf(SearchForThis) + 1
                            letra = columna.ColumnName.Substring(FirstCharacter)
                            columna.ColumnName = letra
                        End If
                    Next
                Next


                Me.grdRendimiento.DataSource = dt2
                Me.grdRendimiento.Text = "Notas (" & dt2.Rows.Count & ")"
                dt2.Columns(3).SetOrdinal(dt2.Columns.Count - 1)
                dt2.Columns(3).SetOrdinal(dt2.Columns.Count - 1)

                ''Modificar tamaño de las columnas
                If dsGrupo.Tables.Count > 0 Then
                    For Each columna As DataColumn In dt2.Columns
                        Dim indice As Integer = CInt(dt2.Columns.IndexOf(columna))
                        Select Case indice
                            Case 1
                                Me.grdvwRendimiento.Columns(indice).Width = 150
                            Case 2
                                Me.grdvwRendimiento.Columns(indice).Width = 250
                        End Select

                        'If indice > 2 Then
                        '    Me.grdvwRendimiento.Columns(indice).Width = 150
                        'End If
                    Next
                End If

            End If



            'If dsGrupo.Tables.Count > 0 Then
            '    dtGrupos = dsGrupo.Tables(0)

            '    Dim dt2 As New DataTable
            '    dt2 = dtGrupos.Clone()
            '}

            '                For Each row As DataRow In dtGrupos.Rows
            '        nota = 0
            '        contador = 0
            '        For Each columna As DataColumn In dtGrupos.Columns

            '            If Not IsNothing(dtGrupos.Columns.IndexOf(columna)) Then
            '                Dim indice As Integer = CInt(dtGrupos.Columns.IndexOf(columna))

            '                If indice > 4 Then

            '                    ''Cortar el nombre
            '                    FirstCharacter = columna.ColumnName.IndexOf(SearchForThis)
            '                    intIDAsignatura = columna.ColumnName.Substring(0, FirstCharacter)

            '                    ''Buscamos si la asignatura es cualitativa
            '                    DtVerificacion = New DataTable()
            '                    DtVerificacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("SELECT [dbo].FnGVerificarUnCualitativo(" & intIDAsignatura & ", " & idModalidad & ") "))

            '                    If DtVerificacion.Rows(0)(0) <> "1" Then
            '                        nota = nota + CInt(row(indice))
            '                        contador = contador + 1

            '                        'If Not IsDBNull((row(indice))) Then
            '                        '    ''Si es de primaria que no tome en cuenta la conducta
            '                        '    If idModalidad <> 20978 Then
            '                        '        nota = nota + CInt(row(indice))
            '                        '        contador = contador + 1
            '                        '    Else
            '                        '        If columna.ColumnName <> "CONDUCTA" Then
            '                        '            nota = nota + CInt(row(indice))
            '                        '            contador = contador + 1
            '                        '        End If
            '                        '    End If
            '                        'End If
            '                    Else
            '                        ''dsGrupo.Tables(0).Columns(columna.ColumnName).DataType = System.Type.GetType(“System.String”)
            '                        ''  Dim column As DataColumn = 
            '                        dt2.Columns.Add("Column1 " & columna.ColumnName, GetType(System.String))

            '                        'For Each fila As DataRow In Me.dsGrupo.Tables(0).Rows
            '                        '    row(columna.ColumnName) = "A"
            '                        'Next

            '                    End If



            '                End If
            '            End If
            '        Next

            '        ''   row(3) = CInt(Redondeo(CDec(nota) / CDec(contador), 0))


            '        dtC = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" Desde, Hasta, Valor", "vwNotasCualitativasGrupos", "SraGrupoID=" & GrupoID & " And Desde<=" + row(3).ToString + " And hasta >=" + row(3).ToString))
            '        If dtC.Rows.Count > 0 Then
            '            row(4) = dtC.Rows(0)("Valor")
            '        End If
            '    Next
            '    dt2.Columns(3).SetOrdinal(dt2.Columns.Count - 1)
            '    dt2.Columns(3).SetOrdinal(dt2.Columns.Count - 1)
            '    Me.grdRendimiento.DataSource = dt2
            '    Me.grdRendimiento.Text = "Notas (" & dt2.Rows.Count & ")"


            'End If


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
            'grdRendimiento.ShowPrintPreview()

            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                grdRendimiento.ExportToXlsx(sfdRuta.FileName)

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
                    If Not IsNothing(dtGrupos.Rows(0)("Guia")) Then
                        Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                    End If

                End If

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

    Private Function FillDatasetFromGrid() As DataSet
        Dim ds As New DataSet()
        Dim rowHandle As Integer
        Dim gridRow As DataRow
        For i As Integer = 0 To grdvwRendimiento.RowCount - 1
            rowHandle = grdvwRendimiento.GetVisibleRowHandle(i)
            If Not grdvwRendimiento.IsGroupRow(rowHandle) Then
                gridRow = grdvwRendimiento.GetDataRow(rowHandle)
                ds.Tables(0).Rows.Add(gridRow.ItemArray)
            End If
        Next i
        Return ds
    End Function

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

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbBusqueda.TextChanged
        ErrPrv.SetError(cmbBusqueda, "")
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Try
            Dim report As rptRendimientoacademico = New rptRendimientoacademico()

            If rbParcial.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico_Rpt " & cmbBusqueda.EditValue & " , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",1"))
            ElseIf rbSemestre.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico_Rpt " & cmbBusqueda.EditValue & " , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",2"))
            ElseIf rbNotaFinal.Checked = True Then
                dsGrupo = DAL.SqlHelper.ExecuteQueryDS(ObtenerProcedimientoGeneral("EXEC pr_RendimientoAcademico_Dinamico_Rpt 0 , " & GrupoID & ", " & cmbPeriodo.SelectedValue & ",3"))
            End If

            'ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" distinct  Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, SraGrupoID, Grado, Seccion, Periodo, PeriodoID,Parcial, objParcialID", "vwRptRendimientoAcademico", "objParcialID=" & cmbBusqueda.EditValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " AND SraGrupoID=" & GrupoID))
            report.DataSource = dsGrupo
            report.DataMember = dsGrupo.Tables(0).TableName
            report.GridControl = grdRendimiento
            Dim printTool As ReportPrintTool = New ReportPrintTool(report)
            printTool.ShowPreviewDialog()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

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

    Private Sub grdvwRendimiento_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdvwRendimiento.RowStyle
        'Dim Promedio As Integer = 0
        'Dim vista As GridView = sender
        'Dim dtVerificacion As DataTable
        'Try
        '    dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
        '    If dtVerificacion.Rows.Count = 0 Then

        '        Try

        '            Promedio = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns(vista.Columns.Count - 2)).ToString())

        '        Catch ex As Exception

        '        End Try
        '        Select Case Promedio
        '            Case Is < 60
        '                e.Appearance.BackColor = Color.Red
        '                e.Appearance.BackColor2 = Color.White

        '            Case Is >= 60
        '                e.Appearance.BackColor = Color.White
        '                e.Appearance.BackColor2 = Color.White



        '        End Select
        '    End If
        'Catch ex As Exception

        'End Try

    End Sub
End Class