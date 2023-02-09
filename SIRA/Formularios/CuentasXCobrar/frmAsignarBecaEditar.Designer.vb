<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarBecaEditar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignarBecaEditar))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.mMes = New DevExpress.XtraScheduler.UI.MonthEdit()
        Me.cmbBeca = New C1.Win.C1List.C1Combo()
        Me.lblBeca = New System.Windows.Forms.Label()
        Me.grdAlumnos = New DevExpress.XtraGrid.GridControl()
        Me.grdvwAlumnos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoMED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.mMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.SimpleButton1)
        Me.pnlBotones.Controls.Add(Me.cmdGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(0, 356)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(669, 60)
        Me.pnlBotones.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(557, 16)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(443, 16)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 20)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblMes)
        Me.PanelControl1.Controls.Add(Me.mMes)
        Me.PanelControl1.Controls.Add(Me.cmbBeca)
        Me.PanelControl1.Controls.Add(Me.lblBeca)
        Me.PanelControl1.Controls.Add(Me.grdAlumnos)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(669, 447)
        Me.PanelControl1.TabIndex = 8
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMes.Location = New System.Drawing.Point(341, 22)
        Me.lblMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(90, 17)
        Me.lblMes.TabIndex = 113
        Me.lblMes.Tag = "OBLIGATORIO"
        Me.lblMes.Text = "A partir de:"
        '
        'mMes
        '
        Me.mMes.Location = New System.Drawing.Point(443, 18)
        Me.mMes.Margin = New System.Windows.Forms.Padding(4)
        Me.mMes.Name = "mMes"
        Me.mMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.mMes.Size = New System.Drawing.Size(196, 22)
        Me.mMes.TabIndex = 1
        '
        'cmbBeca
        '
        Me.cmbBeca.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBeca.AutoCompletion = True
        Me.cmbBeca.AutoDropDown = True
        Me.cmbBeca.Caption = ""
        Me.cmbBeca.CaptionHeight = 17
        Me.cmbBeca.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBeca.ColumnCaptionHeight = 17
        Me.cmbBeca.ColumnFooterHeight = 17
        Me.cmbBeca.ContentHeight = 18
        Me.cmbBeca.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBeca.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBeca.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBeca.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBeca.EditorHeight = 18
        Me.cmbBeca.Images.Add(CType(resources.GetObject("cmbBeca.Images"), System.Drawing.Image))
        Me.cmbBeca.ItemHeight = 15
        Me.cmbBeca.Location = New System.Drawing.Point(77, 15)
        Me.cmbBeca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBeca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBeca.MaxDropDownItems = CType(5, Short)
        Me.cmbBeca.MaxLength = 32767
        Me.cmbBeca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBeca.Name = "cmbBeca"
        Me.cmbBeca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBeca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBeca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBeca.Size = New System.Drawing.Size(231, 24)
        Me.cmbBeca.TabIndex = 0
        Me.cmbBeca.Tag = "OBLIGATORIO"
        Me.cmbBeca.PropBag = resources.GetString("cmbBeca.PropBag")
        '
        'lblBeca
        '
        Me.lblBeca.AutoSize = True
        Me.lblBeca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeca.Location = New System.Drawing.Point(16, 22)
        Me.lblBeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBeca.Name = "lblBeca"
        Me.lblBeca.Size = New System.Drawing.Size(49, 17)
        Me.lblBeca.TabIndex = 110
        Me.lblBeca.Tag = "OBLIGATORIO"
        Me.lblBeca.Text = "Beca:"
        '
        'grdAlumnos
        '
        Me.grdAlumnos.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAlumnos.Location = New System.Drawing.Point(0, 76)
        Me.grdAlumnos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAlumnos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAlumnos.MainView = Me.grdvwAlumnos
        Me.grdAlumnos.Margin = New System.Windows.Forms.Padding(4)
        Me.grdAlumnos.Name = "grdAlumnos"
        Me.grdAlumnos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado})
        Me.grdAlumnos.Size = New System.Drawing.Size(669, 288)
        Me.grdAlumnos.TabIndex = 2
        Me.grdAlumnos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwAlumnos})
        '
        'grdvwAlumnos
        '
        Me.grdvwAlumnos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colGrado, Me.colCodigoMED, Me.colAlumno})
        Me.grdvwAlumnos.GridControl = Me.grdAlumnos
        Me.grdvwAlumnos.Name = "grdvwAlumnos"
        Me.grdvwAlumnos.OptionsView.ColumnAutoWidth = False
        Me.grdvwAlumnos.OptionsView.ShowAutoFilterRow = True
        Me.grdvwAlumnos.OptionsView.ShowDetailButtons = False
        Me.grdvwAlumnos.OptionsView.ShowGroupPanel = False
        '
        'colGrado
        '
        Me.colGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colGrado.AppearanceHeader.Options.UseFont = True
        Me.colGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrado.Caption = "Grado"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.Name = "colGrado"
        Me.colGrado.OptionsColumn.AllowEdit = False
        Me.colGrado.OptionsColumn.AllowMove = False
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 0
        Me.colGrado.Width = 97
        '
        'colCodigoMED
        '
        Me.colCodigoMED.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoMED.AppearanceHeader.Options.UseFont = True
        Me.colCodigoMED.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoMED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoMED.Caption = "Codigo MINED"
        Me.colCodigoMED.FieldName = "CodigoMED"
        Me.colCodigoMED.Name = "colCodigoMED"
        Me.colCodigoMED.OptionsColumn.AllowEdit = False
        Me.colCodigoMED.OptionsColumn.AllowMove = False
        Me.colCodigoMED.Visible = True
        Me.colCodigoMED.VisibleIndex = 1
        Me.colCodigoMED.Width = 101
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Alumno"
        Me.colAlumno.FieldName = "Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 2
        Me.colAlumno.Width = 285
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'frmAsignarBecaEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsignarBecaEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicar beca"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.mMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdAlumnos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwAlumnos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigoMED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbBeca As C1.Win.C1List.C1Combo
    Friend WithEvents lblBeca As System.Windows.Forms.Label
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents mMes As DevExpress.XtraScheduler.UI.MonthEdit
End Class
