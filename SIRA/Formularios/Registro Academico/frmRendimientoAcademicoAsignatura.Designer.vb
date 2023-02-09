<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRendimientoAcademicoAsignatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRendimientoAcademicoAsignatura))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grdRendimiento = New DevExpress.XtraGrid.GridControl()
        Me.grdvwRendimiento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAsignatura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMatriculaFinal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAprobados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReprobados = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcentajeAprobado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPorcentajeReprobado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkGrupo = New System.Windows.Forms.CheckBox()
        Me.chkModalidad = New System.Windows.Forms.CheckBox()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.rbNotaFinal = New System.Windows.Forms.RadioButton()
        Me.rbSemestre = New System.Windows.Forms.RadioButton()
        Me.rbParcial = New System.Windows.Forms.RadioButton()
        Me.cmbBusqueda = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmdActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbModalidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grdRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolTramitesLegales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmbBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbModalidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(1457, 544)
        Me.PanelControl1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grdRendimiento, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.toolTramitesLegales, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.21004!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.9726!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1453, 540)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'grdRendimiento
        '
        Me.grdRendimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRendimiento.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRendimiento.Location = New System.Drawing.Point(4, 144)
        Me.grdRendimiento.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRendimiento.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRendimiento.MainView = Me.grdvwRendimiento
        Me.grdRendimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRendimiento.Name = "grdRendimiento"
        Me.grdRendimiento.Size = New System.Drawing.Size(1445, 392)
        Me.grdRendimiento.TabIndex = 0
        Me.grdRendimiento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwRendimiento})
        '
        'grdvwRendimiento
        '
        Me.grdvwRendimiento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAsignatura, Me.colGrupo, Me.colMatriculaFinal, Me.colAprobados, Me.colReprobados, Me.colPorcentajeAprobado, Me.colPorcentajeReprobado, Me.colModalidad, Me.colGenero})
        Me.grdvwRendimiento.GridControl = Me.grdRendimiento
        Me.grdvwRendimiento.Name = "grdvwRendimiento"
        Me.grdvwRendimiento.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdvwRendimiento.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdvwRendimiento.OptionsBehavior.Editable = False
        Me.grdvwRendimiento.OptionsBehavior.ReadOnly = True
        Me.grdvwRendimiento.OptionsView.RowAutoHeight = True
        Me.grdvwRendimiento.OptionsView.ShowAutoFilterRow = True
        '
        'colAsignatura
        '
        Me.colAsignatura.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAsignatura.AppearanceHeader.Options.UseFont = True
        Me.colAsignatura.Caption = "Asignatura"
        Me.colAsignatura.FieldName = "Asignatura"
        Me.colAsignatura.Name = "colAsignatura"
        Me.colAsignatura.Visible = True
        Me.colAsignatura.VisibleIndex = 1
        Me.colAsignatura.Width = 273
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrupo.AppearanceHeader.Options.UseFont = True
        Me.colGrupo.Caption = "Grupo"
        Me.colGrupo.FieldName = "Grupo"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 2
        '
        'colMatriculaFinal
        '
        Me.colMatriculaFinal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMatriculaFinal.AppearanceHeader.Options.UseFont = True
        Me.colMatriculaFinal.Caption = "Matrícula final"
        Me.colMatriculaFinal.FieldName = "MatriculaFinal"
        Me.colMatriculaFinal.Name = "colMatriculaFinal"
        Me.colMatriculaFinal.Visible = True
        Me.colMatriculaFinal.VisibleIndex = 4
        Me.colMatriculaFinal.Width = 85
        '
        'colAprobados
        '
        Me.colAprobados.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAprobados.AppearanceHeader.Options.UseFont = True
        Me.colAprobados.Caption = "Aprobados"
        Me.colAprobados.DisplayFormat.FormatString = "0"
        Me.colAprobados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAprobados.FieldName = "Aprobados"
        Me.colAprobados.Name = "colAprobados"
        Me.colAprobados.Visible = True
        Me.colAprobados.VisibleIndex = 5
        Me.colAprobados.Width = 108
        '
        'colReprobados
        '
        Me.colReprobados.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReprobados.AppearanceHeader.Options.UseFont = True
        Me.colReprobados.Caption = "Reprobados"
        Me.colReprobados.DisplayFormat.FormatString = "0"
        Me.colReprobados.FieldName = "Reprobados"
        Me.colReprobados.Name = "colReprobados"
        Me.colReprobados.Visible = True
        Me.colReprobados.VisibleIndex = 6
        Me.colReprobados.Width = 88
        '
        'colPorcentajeAprobado
        '
        Me.colPorcentajeAprobado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPorcentajeAprobado.AppearanceHeader.Options.UseFont = True
        Me.colPorcentajeAprobado.Caption = "% Aprobado"
        Me.colPorcentajeAprobado.DisplayFormat.FormatString = "0.00"
        Me.colPorcentajeAprobado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorcentajeAprobado.FieldName = "PorcentajeAprobado"
        Me.colPorcentajeAprobado.Name = "colPorcentajeAprobado"
        Me.colPorcentajeAprobado.Visible = True
        Me.colPorcentajeAprobado.VisibleIndex = 7
        Me.colPorcentajeAprobado.Width = 88
        '
        'colPorcentajeReprobado
        '
        Me.colPorcentajeReprobado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPorcentajeReprobado.AppearanceHeader.Options.UseFont = True
        Me.colPorcentajeReprobado.Caption = "% Reprobado"
        Me.colPorcentajeReprobado.DisplayFormat.FormatString = "0.00"
        Me.colPorcentajeReprobado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPorcentajeReprobado.FieldName = "PorcentajeReprobado"
        Me.colPorcentajeReprobado.Name = "colPorcentajeReprobado"
        Me.colPorcentajeReprobado.Visible = True
        Me.colPorcentajeReprobado.VisibleIndex = 8
        Me.colPorcentajeReprobado.Width = 147
        '
        'colModalidad
        '
        Me.colModalidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModalidad.AppearanceHeader.Options.UseFont = True
        Me.colModalidad.Caption = "Modalidad"
        Me.colModalidad.FieldName = "Modalidad"
        Me.colModalidad.Name = "colModalidad"
        Me.colModalidad.OptionsColumn.AllowEdit = False
        Me.colModalidad.Visible = True
        Me.colModalidad.VisibleIndex = 0
        Me.colModalidad.Width = 113
        '
        'colGenero
        '
        Me.colGenero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGenero.AppearanceHeader.Options.UseFont = True
        Me.colGenero.AppearanceHeader.Options.UseTextOptions = True
        Me.colGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGenero.Caption = "Género "
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.Name = "colGenero"
        Me.colGenero.OptionsColumn.AllowEdit = False
        Me.colGenero.Visible = True
        Me.colGenero.VisibleIndex = 3
        Me.colGenero.Width = 88
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbExportar, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(1453, 39)
        Me.toolTramitesLegales.TabIndex = 1
        Me.toolTramitesLegales.Text = "ToolStrip1"
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
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir rendimiento academico"
        Me.cmdImprimir.ToolTipText = "Imprimir rendimiento academico"
        '
        'ToolSeparador1
        '
        Me.ToolSeparador1.Name = "ToolSeparador1"
        Me.ToolSeparador1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(240, 36)
        Me.ToolStripLabel1.Text = "Rendimiento académico"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkGrupo)
        Me.Panel1.Controls.Add(Me.chkModalidad)
        Me.Panel1.Controls.Add(Me.txtGrado)
        Me.Panel1.Controls.Add(Me.cmdBuscar)
        Me.Panel1.Controls.Add(Me.rbNotaFinal)
        Me.Panel1.Controls.Add(Me.rbSemestre)
        Me.Panel1.Controls.Add(Me.rbParcial)
        Me.Panel1.Controls.Add(Me.cmbBusqueda)
        Me.Panel1.Controls.Add(Me.cmdActualizar)
        Me.Panel1.Controls.Add(Me.cmbModalidad)
        Me.Panel1.Controls.Add(Me.cmbPeriodo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 57)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1445, 79)
        Me.Panel1.TabIndex = 10
        '
        'chkGrupo
        '
        Me.chkGrupo.AutoSize = True
        Me.chkGrupo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGrupo.Location = New System.Drawing.Point(413, 50)
        Me.chkGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkGrupo.Name = "chkGrupo"
        Me.chkGrupo.Size = New System.Drawing.Size(73, 21)
        Me.chkGrupo.TabIndex = 175
        Me.chkGrupo.Text = "Grupo"
        Me.chkGrupo.UseVisualStyleBackColor = True
        '
        'chkModalidad
        '
        Me.chkModalidad.AutoSize = True
        Me.chkModalidad.Checked = True
        Me.chkModalidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkModalidad.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkModalidad.Location = New System.Drawing.Point(413, 16)
        Me.chkModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.chkModalidad.Name = "chkModalidad"
        Me.chkModalidad.Size = New System.Drawing.Size(100, 21)
        Me.chkModalidad.TabIndex = 174
        Me.chkModalidad.Text = "Modalidad"
        Me.chkModalidad.UseVisualStyleBackColor = True
        '
        'txtGrado
        '
        Me.txtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrado.Location = New System.Drawing.Point(533, 50)
        Me.txtGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(352, 23)
        Me.txtGrado.TabIndex = 169
        Me.txtGrado.Tag = "OBLIGATORIO"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(895, 48)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 171
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'rbNotaFinal
        '
        Me.rbNotaFinal.AutoSize = True
        Me.rbNotaFinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaFinal.ForeColor = System.Drawing.Color.Black
        Me.rbNotaFinal.Location = New System.Drawing.Point(276, 59)
        Me.rbNotaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNotaFinal.Name = "rbNotaFinal"
        Me.rbNotaFinal.Size = New System.Drawing.Size(98, 21)
        Me.rbNotaFinal.TabIndex = 167
        Me.rbNotaFinal.TabStop = True
        Me.rbNotaFinal.Text = "Nota Final"
        Me.rbNotaFinal.UseVisualStyleBackColor = True
        '
        'rbSemestre
        '
        Me.rbSemestre.AutoSize = True
        Me.rbSemestre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSemestre.ForeColor = System.Drawing.Color.Black
        Me.rbSemestre.Location = New System.Drawing.Point(151, 58)
        Me.rbSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSemestre.Name = "rbSemestre"
        Me.rbSemestre.Size = New System.Drawing.Size(97, 21)
        Me.rbSemestre.TabIndex = 166
        Me.rbSemestre.Text = "Semestral"
        Me.rbSemestre.UseVisualStyleBackColor = True
        '
        'rbParcial
        '
        Me.rbParcial.AutoSize = True
        Me.rbParcial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbParcial.ForeColor = System.Drawing.Color.Black
        Me.rbParcial.Location = New System.Drawing.Point(28, 57)
        Me.rbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.rbParcial.Name = "rbParcial"
        Me.rbParcial.Size = New System.Drawing.Size(73, 21)
        Me.rbParcial.TabIndex = 165
        Me.rbParcial.Text = "Parcial"
        Me.rbParcial.UseVisualStyleBackColor = True
        '
        'cmbBusqueda
        '
        Me.cmbBusqueda.Location = New System.Drawing.Point(44, 82)
        Me.cmbBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBusqueda.Name = "cmbBusqueda"
        Me.cmbBusqueda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBusqueda.Properties.NullText = ""
        Me.cmbBusqueda.Size = New System.Drawing.Size(337, 22)
        Me.cmbBusqueda.TabIndex = 168
        '
        'cmdActualizar
        '
        Me.cmdActualizar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.updated16x16
        Me.cmdActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdActualizar.Location = New System.Drawing.Point(935, 48)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(43, 28)
        Me.cmdActualizar.TabIndex = 2
        '
        'cmbModalidad
        '
        Me.cmbModalidad.Location = New System.Drawing.Point(533, 14)
        Me.cmbModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbModalidad.Properties.NullText = ""
        Me.cmbModalidad.Size = New System.Drawing.Size(353, 22)
        Me.cmbModalidad.TabIndex = 1
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
        Me.cmbPeriodo.Location = New System.Drawing.Point(135, 12)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Período:"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'frmRendimientoAcademicoAsignatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1457, 544)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRendimientoAcademicoAsignatura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rendimiento académico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.grdRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmbBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbModalidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbModalidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdRendimiento As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwRendimiento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAsignatura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMatriculaFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAprobados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReprobados As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentajeAprobado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentajeReprobado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents rbNotaFinal As RadioButton
    Friend WithEvents rbSemestre As RadioButton
    Friend WithEvents rbParcial As RadioButton
    Friend WithEvents cmbBusqueda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtGrado As TextBox
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents chkGrupo As CheckBox
    Friend WithEvents chkModalidad As CheckBox
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
End Class
