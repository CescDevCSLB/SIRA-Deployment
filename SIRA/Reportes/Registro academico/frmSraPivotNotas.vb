Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports Proyecto.Catalogos.Datos
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraPivotGrid
Imports Seguridad.Datos

Public Class frmSraPivotNotas
    Public dtPeriodos, dtModalidad, DtParcial, dtGrupos As DataTable
    Public intPeriodoID, GrupoID As Integer
    Dim objSeg As SsgSeguridad
    Dim blnImprimir, blnExportar As Boolean

    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "rptConsolidado"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If objSeg.TienePermiso("ImprimirConsolidado") Then
                blnImprimir = True
                Me.cmdImprimir.Enabled = True
            Else
                blnImprimir = False
                Me.cmdImprimir.Enabled = False
            End If

            If objSeg.TienePermiso("ExportarConsolidado") Then
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

    Private Function ValidarEntrada()

        If Me.cmbPeriodo.Text.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbPeriodo, "Debe seleccionar el periodo")
            Me.cmbPeriodo.Focus()
            Return False
            Exit Function
        End If

        If Me.cmbParcial.Text.Trim.Length = 0 And rbNotaFinal.Checked = False Then
            Me.ErrPrv.SetError(Me.cmbParcial, "Debe seleccionar el parcial")
            Me.cmbParcial.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function



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

    Private Sub CargarParcial()
        Try
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

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    'Private Sub BuscarGrupo()
    '    Dim objPersonas As frmGrupoSelector
    '    Dim dtGradoE As New DataTable
    '    Try
    '        objPersonas = New frmGrupoSelector
    '        objPersonas.Periodo = cmbPeriodo.SelectedValue
    '        objPersonas.Opcion = 2
    '        If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
    '            GrupoID = objPersonas.Seleccion

    '            dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

    '            If dtGrupos.Rows.Count > 0 Then
    '                Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
    '                Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
    '            End If

    '        End If


    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    Finally
    '        objPersonas = Nothing

    '    End Try
    'End Sub

    Public Sub ConfigurarGUI()
        Try
            CargarPeriodos()
            CargarParcial()
            AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub frmSraPivotNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'BuscarGrupo()
    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click
        Dim ds As DataTable
        Try
            If ValidarEntrada() Then
                ds = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" AlumnoID,Codigo, NombreCompleto, CodigoMED, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, objParcialID, Promedio, Parcial, Edad, Genero, Profesor", "vwSraRendimientoAcademicoAsig_Pivot", "isCualitativo=0 AND objParcialID=" & cmbParcial.EditValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue))

                If ds.Rows.Count <> 0 Then
                    PivotConsolidado.DataSource = ds
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub rbNotaFinal_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotaFinal.CheckedChanged
        'ErrPrv.SetError(cmbParcial, "")
        'If rbNotaFinal.Checked Then
        '    cmbParcial.Text = String.Empty
        '    cmbParcial.Enabled = False
        'Else
        '    cmbParcial.Enabled = True
        'End If
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        ErrPrv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        ErrPrv.SetError(cmbParcial, "")
    End Sub

    Private Sub rbParcial_CheckedChanged(sender As Object, e As EventArgs) Handles rbParcial.CheckedChanged
        'ErrPrv.SetError(cmbParcial, "")
        'If rbParcial.Checked Then
        '    cmbParcial.Enabled = True
        'Else
        '    cmbParcial.Text = String.Empty
        '    cmbParcial.Enabled = False
        'End If
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim pivotExportOptions As New DevExpress.XtraPivotGrid.PivotXlsxExportOptions()
                pivotExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
                PivotConsolidado.ExportToXlsx(sfdRuta.FileName, pivotExportOptions)

                'Me.PivotConsolidado.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                PivotConsolidado.ExportToPdf(sfdRuta.FileName)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub PivotConsolidado_CustomDrawCell(sender As Object, e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles PivotConsolidado.CustomDrawCell
        Try
            Dim r As Rectangle

            ' Paints Row Grand Totals.
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                e.GraphicsCache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.LemonChiffon, _
                   Color.Blue, LinearGradientMode.Vertical), e.Bounds)
                r = Rectangle.Inflate(e.Bounds, -3, -3)
                e.GraphicsCache.FillRectangle(New LinearGradientBrush(e.Bounds, Color.LemonChiffon, _
                   Color.LightSkyBlue, LinearGradientMode.Vertical), r)
                e.GraphicsCache.DrawString(e.DisplayText, e.Appearance.Font, New SolidBrush(Color.Black), _
                   r, e.Appearance.GetStringFormat())
                e.Handled = True
                Exit Sub
            End If

            '' Paints the data cells.
            'Dim backBrush As Brush
            'r = e.Bounds

            'If e.Focused Then
            '    ' Initializes the brush used to paint the focused cell.
            '    backBrush = e.GraphicsCache.GetSolidBrush(Color.Pink)
            'ElseIf e.Selected Then
            '    ' Initializes the brush used to paint selected cells.
            '    backBrush = e.GraphicsCache.GetSolidBrush(Color.PaleGreen)
            'Else
            '    ' Initializes the brush used to paint data cells.
            '    backBrush = e.GraphicsCache.GetSolidBrush(Color.LemonChiffon)
            'End If

            'e.GraphicsCache.DrawRectangle(New Pen(New SolidBrush(Color.DimGray), 1), r)
            'r.Inflate(-1, -1)
            'e.GraphicsCache.FillRectangle(backBrush, r)
            'e.Appearance.DrawString(e.GraphicsCache, e.DisplayText, r)

            'e.Handled = True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub PivotConsolidado_CustomAppearance(sender As Object, e As PivotCustomAppearanceEventArgs) Handles PivotConsolidado.CustomAppearance
        Try
            If e.DataField Is colPromedio And e.ColumnValueType = PivotGridValueType.Value _
       And e.RowValueType = PivotGridValueType.Value Then
                If Not e.Value Is Nothing And Convert.ToInt32(e.Value) < 60 Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)


                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class