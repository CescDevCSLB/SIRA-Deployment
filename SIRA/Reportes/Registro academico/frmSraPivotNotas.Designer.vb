<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraPivotNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraPivotNotas))
        Dim XyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmdCargar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbParcial = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PivotConsolidado = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.colNombreCompleto = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCodigoMED = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colAsignatura = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colPromedio = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colEdad = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colGenero = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colProfesor = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colCodigo = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colGrado = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.colSeccion = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.CharPivot = New DevExpress.XtraCharts.ChartControl()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.rbNotaFinal = New System.Windows.Forms.RadioButton()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.rbParcial = New System.Windows.Forms.RadioButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tbProductos.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbParcial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharPivot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1243, 922)
        Me.PanelControl1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbProductos, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.gbxDatosGenerales, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1239, 918)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdImprimir, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar, Me.ToolStripLabel1})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(1239, 39)
        Me.tbProductos.TabIndex = 0
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "Exportar"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCerrar.ToolTipText = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(215, 36)
        Me.ToolStripLabel1.Text = "Consolidado de notas"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.rbParcial)
        Me.gbxDatosGenerales.Controls.Add(Me.rbNotaFinal)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdCargar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbParcial)
        Me.gbxDatosGenerales.Controls.Add(Me.Label5)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbPeriodo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label8)
        Me.gbxDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(4, 59)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(1231, 83)
        Me.gbxDatosGenerales.TabIndex = 12
        Me.gbxDatosGenerales.TabStop = False
        '
        'cmdCargar
        '
        Me.cmdCargar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.updated16x16
        Me.cmdCargar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.cmdCargar.Location = New System.Drawing.Point(840, 28)
        Me.cmdCargar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(43, 28)
        Me.cmdCargar.TabIndex = 3
        '
        'cmbParcial
        '
        Me.cmbParcial.Location = New System.Drawing.Point(589, 31)
        Me.cmbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbParcial.Properties.NullText = ""
        Me.cmbParcial.Size = New System.Drawing.Size(231, 22)
        Me.cmbParcial.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 22)
        Me.Label5.TabIndex = 1
        Me.Label5.Tag = ""
        Me.Label5.Text = "Parcial:"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPeriodo.AutoCompletion = True
        Me.cmbPeriodo.AutoDropDown = True
        Me.cmbPeriodo.Caption = ""
        Me.cmbPeriodo.CaptionHeight = 17
        Me.cmbPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPeriodo.ColumnCaptionHeight = 17
        Me.cmbPeriodo.ColumnFooterHeight = 17
        Me.cmbPeriodo.ContentHeight = 18
        Me.cmbPeriodo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodo.EditorHeight = 18
        Me.cmbPeriodo.Images.Add(CType(resources.GetObject("cmbPeriodo.Images"), System.Drawing.Image))
        Me.cmbPeriodo.ItemHeight = 15
        Me.cmbPeriodo.Location = New System.Drawing.Point(161, 30)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(231, 24)
        Me.cmbPeriodo.TabIndex = 0
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 30)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = "Período:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PivotConsolidado, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CharPivot, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(4, 150)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1231, 764)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'PivotConsolidado
        '
        Me.PivotConsolidado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PivotConsolidado.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.colNombreCompleto, Me.colCodigoMED, Me.colAsignatura, Me.colPromedio, Me.colEdad, Me.colGenero, Me.colProfesor, Me.colCodigo, Me.colGrado, Me.colSeccion})
        Me.PivotConsolidado.Location = New System.Drawing.Point(4, 4)
        Me.PivotConsolidado.Margin = New System.Windows.Forms.Padding(4)
        Me.PivotConsolidado.Name = "PivotConsolidado"
        Me.PivotConsolidado.OptionsDataField.RowHeaderWidth = 133
        Me.PivotConsolidado.OptionsView.RowTreeOffset = 28
        Me.PivotConsolidado.OptionsView.RowTreeWidth = 133
        Me.PivotConsolidado.Size = New System.Drawing.Size(853, 756)
        Me.PivotConsolidado.TabIndex = 0
        '
        'colNombreCompleto
        '
        Me.colNombreCompleto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.colNombreCompleto.AreaIndex = 0
        Me.colNombreCompleto.Caption = "Alumno"
        Me.colNombreCompleto.FieldName = "NombreCompleto"
        Me.colNombreCompleto.MinWidth = 27
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colNombreCompleto.Width = 267
        '
        'colCodigoMED
        '
        Me.colCodigoMED.AreaIndex = 2
        Me.colCodigoMED.Caption = "Código MINED"
        Me.colCodigoMED.FieldName = "CodigoMED"
        Me.colCodigoMED.MinWidth = 27
        Me.colCodigoMED.Name = "colCodigoMED"
        Me.colCodigoMED.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCodigoMED.Width = 147
        '
        'colAsignatura
        '
        Me.colAsignatura.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.colAsignatura.AreaIndex = 0
        Me.colAsignatura.Caption = "Asignatura"
        Me.colAsignatura.FieldName = "Asignatura"
        Me.colAsignatura.MinWidth = 27
        Me.colAsignatura.Name = "colAsignatura"
        Me.colAsignatura.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colAsignatura.Width = 200
        '
        'colPromedio
        '
        Me.colPromedio.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.colPromedio.AreaIndex = 0
        Me.colPromedio.CellFormat.FormatString = "#,##"
        Me.colPromedio.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPromedio.FieldName = "Promedio"
        Me.colPromedio.GrandTotalCellFormat.FormatString = "0"
        Me.colPromedio.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPromedio.GrandTotalText = "Promedio"
        Me.colPromedio.MinWidth = 27
        Me.colPromedio.Name = "colPromedio"
        Me.colPromedio.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colPromedio.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
        Me.colPromedio.TotalCellFormat.FormatString = "0"
        Me.colPromedio.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPromedio.TotalValueFormat.FormatString = "0"
        Me.colPromedio.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPromedio.Width = 133
        '
        'colEdad
        '
        Me.colEdad.AreaIndex = 1
        Me.colEdad.Caption = "Edad"
        Me.colEdad.FieldName = "Edad"
        Me.colEdad.MinWidth = 27
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colEdad.Width = 133
        '
        'colGenero
        '
        Me.colGenero.AreaIndex = 3
        Me.colGenero.Caption = "Género "
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.MinWidth = 27
        Me.colGenero.Name = "colGenero"
        Me.colGenero.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colGenero.Width = 133
        '
        'colProfesor
        '
        Me.colProfesor.AreaIndex = 4
        Me.colProfesor.Caption = "Profesor"
        Me.colProfesor.FieldName = "Profesor"
        Me.colProfesor.MinWidth = 27
        Me.colProfesor.Name = "colProfesor"
        Me.colProfesor.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colProfesor.Width = 240
        '
        'colCodigo
        '
        Me.colCodigo.AreaIndex = 0
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.MinWidth = 27
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[True]
        Me.colCodigo.Width = 133
        '
        'colGrado
        '
        Me.colGrado.AreaIndex = 5
        Me.colGrado.Caption = "Grado"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.MinWidth = 27
        Me.colGrado.Name = "colGrado"
        Me.colGrado.Width = 133
        '
        'colSeccion
        '
        Me.colSeccion.AreaIndex = 6
        Me.colSeccion.Caption = "Sección"
        Me.colSeccion.FieldName = "Seccion"
        Me.colSeccion.MinWidth = 27
        Me.colSeccion.Name = "colSeccion"
        Me.colSeccion.Width = 133
        '
        'CharPivot
        '
        Me.CharPivot.DataSource = Me.PivotConsolidado
        XyDiagram2.AxisX.Title.Text = "Alumno"
        XyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram2.AxisY.Title.Text = "Promedio"
        XyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
        Me.CharPivot.Diagram = XyDiagram2
        Me.CharPivot.Dock = System.Windows.Forms.DockStyle.Top
        Me.CharPivot.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
        Me.CharPivot.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
        Me.CharPivot.Legend.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CharPivot.Legend.MaxVerticalPercentage = 30.0R
        Me.CharPivot.Legend.Name = "Default Legend"
        Me.CharPivot.Location = New System.Drawing.Point(865, 4)
        Me.CharPivot.Margin = New System.Windows.Forms.Padding(4)
        Me.CharPivot.Name = "CharPivot"
        Me.CharPivot.SeriesDataMember = "Series"
        Me.CharPivot.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.CharPivot.SeriesTemplate.ArgumentDataMember = "Arguments"
        Me.CharPivot.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
        Me.CharPivot.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.CharPivot.SeriesTemplate.LegendName = "Default Legend"
        Me.CharPivot.SeriesTemplate.SeriesDataMember = "Series"
        Me.CharPivot.SeriesTemplate.ToolTipHintDataMember = "Values"
        Me.CharPivot.SeriesTemplate.ValueDataMembersSerializable = "Values"
        Me.CharPivot.Size = New System.Drawing.Size(362, 246)
        Me.CharPivot.TabIndex = 1
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'rbNotaFinal
        '
        Me.rbNotaFinal.AutoSize = True
        Me.rbNotaFinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaFinal.ForeColor = System.Drawing.Color.Black
        Me.rbNotaFinal.Location = New System.Drawing.Point(722, 62)
        Me.rbNotaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNotaFinal.Name = "rbNotaFinal"
        Me.rbNotaFinal.Size = New System.Drawing.Size(98, 21)
        Me.rbNotaFinal.TabIndex = 167
        Me.rbNotaFinal.TabStop = True
        Me.rbNotaFinal.Text = "Nota Final"
        Me.rbNotaFinal.UseVisualStyleBackColor = True
        Me.rbNotaFinal.Visible = False
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'rbParcial
        '
        Me.rbParcial.AutoSize = True
        Me.rbParcial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbParcial.ForeColor = System.Drawing.Color.Black
        Me.rbParcial.Location = New System.Drawing.Point(589, 62)
        Me.rbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.rbParcial.Name = "rbParcial"
        Me.rbParcial.Size = New System.Drawing.Size(73, 21)
        Me.rbParcial.TabIndex = 168
        Me.rbParcial.TabStop = True
        Me.rbParcial.Text = "Parcial"
        Me.rbParcial.UseVisualStyleBackColor = True
        Me.rbParcial.Visible = False
        '
        'frmSraPivotNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 922)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSraPivotNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consolidado de notas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbParcial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PivotConsolidado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharPivot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbParcial As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PivotConsolidado As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents CharPivot As DevExpress.XtraCharts.ChartControl
    Friend WithEvents colNombreCompleto As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCodigoMED As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colAsignatura As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colPromedio As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colEdad As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGenero As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colProfesor As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colCodigo As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colGrado As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents colSeccion As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents rbNotaFinal As RadioButton
    Friend WithEvents ErrPrv As ErrorProvider
    Friend WithEvents rbParcial As RadioButton
End Class
