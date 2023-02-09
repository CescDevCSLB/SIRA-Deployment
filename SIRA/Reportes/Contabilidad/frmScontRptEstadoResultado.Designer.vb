<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScontRptEstadoResultado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScontRptEstadoResultado))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdRendimiento = New DevExpress.XtraGrid.GridControl()
        Me.grdvwRendimiento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkCondensado = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbCentroCosto = New C1.Win.C1List.C1Combo()
        Me.cmbMes = New C1.Win.C1List.C1Combo()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwRendimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdRendimiento)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(645, 146)
        Me.PanelControl1.TabIndex = 98
        '
        'grdRendimiento
        '
        Me.grdRendimiento.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRendimiento.Location = New System.Drawing.Point(101, 123)
        Me.grdRendimiento.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRendimiento.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRendimiento.MainView = Me.grdvwRendimiento
        Me.grdRendimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRendimiento.Name = "grdRendimiento"
        Me.grdRendimiento.Size = New System.Drawing.Size(472, 122)
        Me.grdRendimiento.TabIndex = 2
        Me.grdRendimiento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwRendimiento})
        '
        'grdvwRendimiento
        '
        Me.grdvwRendimiento.GridControl = Me.grdRendimiento
        Me.grdvwRendimiento.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grdvwRendimiento.Name = "grdvwRendimiento"
        Me.grdvwRendimiento.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdvwRendimiento.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdvwRendimiento.OptionsBehavior.Editable = False
        Me.grdvwRendimiento.OptionsBehavior.ReadOnly = True
        Me.grdvwRendimiento.OptionsCustomization.AllowRowSizing = True
        Me.grdvwRendimiento.OptionsView.ColumnAutoWidth = False
        Me.grdvwRendimiento.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.grdvwRendimiento.OptionsView.RowAutoHeight = True
        Me.grdvwRendimiento.OptionsView.ShowAutoFilterRow = True
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.chkCondensado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label19)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCentroCosto)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbMes)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaNacimiento)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdCancelar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdGuardar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbPeriodo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 2)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(607, 113)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'chkCondensado
        '
        Me.chkCondensado.AutoSize = True
        Me.chkCondensado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCondensado.Location = New System.Drawing.Point(176, 84)
        Me.chkCondensado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCondensado.Name = "chkCondensado"
        Me.chkCondensado.Size = New System.Drawing.Size(117, 21)
        Me.chkCondensado.TabIndex = 187
        Me.chkCondensado.Text = "Condensado"
        Me.chkCondensado.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(11, 148)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 186
        Me.Label19.Text = "Centro de costo:"
        Me.Label19.Visible = False
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCentroCosto.AutoCompletion = True
        Me.cmbCentroCosto.AutoDropDown = True
        Me.cmbCentroCosto.Caption = ""
        Me.cmbCentroCosto.CaptionHeight = 17
        Me.cmbCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCentroCosto.ColumnCaptionHeight = 17
        Me.cmbCentroCosto.ColumnFooterHeight = 17
        Me.cmbCentroCosto.ContentHeight = 18
        Me.cmbCentroCosto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCentroCosto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCentroCosto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCentroCosto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCentroCosto.EditorHeight = 18
        Me.cmbCentroCosto.Enabled = False
        Me.cmbCentroCosto.Images.Add(CType(resources.GetObject("cmbCentroCosto.Images"), System.Drawing.Image))
        Me.cmbCentroCosto.ItemHeight = 15
        Me.cmbCentroCosto.Location = New System.Drawing.Point(173, 142)
        Me.cmbCentroCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCentroCosto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCentroCosto.MaxDropDownItems = CType(5, Short)
        Me.cmbCentroCosto.MaxLength = 32767
        Me.cmbCentroCosto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCentroCosto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.Size = New System.Drawing.Size(267, 24)
        Me.cmbCentroCosto.TabIndex = 185
        Me.cmbCentroCosto.Tag = "OBLIGATORIO"
        Me.cmbCentroCosto.Visible = False
        Me.cmbCentroCosto.PropBag = resources.GetString("cmbCentroCosto.PropBag")
        '
        'cmbMes
        '
        Me.cmbMes.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMes.AutoCompletion = True
        Me.cmbMes.AutoDropDown = True
        Me.cmbMes.Caption = ""
        Me.cmbMes.CaptionHeight = 17
        Me.cmbMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMes.ColumnCaptionHeight = 17
        Me.cmbMes.ColumnFooterHeight = 17
        Me.cmbMes.ContentHeight = 18
        Me.cmbMes.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMes.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMes.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMes.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMes.EditorHeight = 18
        Me.cmbMes.Images.Add(CType(resources.GetObject("cmbMes.Images"), System.Drawing.Image))
        Me.cmbMes.ItemHeight = 15
        Me.cmbMes.Location = New System.Drawing.Point(176, 49)
        Me.cmbMes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMes.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMes.MaxDropDownItems = CType(5, Short)
        Me.cmbMes.MaxLength = 32767
        Me.cmbMes.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMes.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMes.Size = New System.Drawing.Size(245, 24)
        Me.cmbMes.TabIndex = 169
        Me.cmbMes.Tag = "OBLIGATORIO"
        Me.cmbMes.PropBag = resources.GetString("cmbMes.PropBag")
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(48, 58)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(37, 17)
        Me.lblFechaNacimiento.TabIndex = 168
        Me.lblFechaNacimiento.Text = "Mes"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(479, 58)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(479, 16)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aceptar"
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
        Me.cmbPeriodo.Location = New System.Drawing.Point(176, 17)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(245, 24)
        Me.cmbPeriodo.TabIndex = 0
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Período:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 120)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmScontRptEstadoResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 146)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScontRptEstadoResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar parámetros"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwRendimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents cmbMes As C1.Win.C1List.C1Combo
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbCentroCosto As C1.Win.C1List.C1Combo
    Friend WithEvents chkCondensado As CheckBox
    Friend WithEvents grdRendimiento As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwRendimiento As DevExpress.XtraGrid.Views.Grid.GridView
End Class
