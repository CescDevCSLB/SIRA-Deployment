<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbEditTasaCambioOficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbEditTasaCambioOficial))
        Me.cmbMoneda = New C1.Win.C1List.C1Combo()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMes = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.nmuMonto = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmuMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMoneda.Caption = ""
        Me.cmbMoneda.CaptionHeight = 17
        Me.cmbMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMoneda.ColumnCaptionHeight = 17
        Me.cmbMoneda.ColumnFooterHeight = 17
        Me.cmbMoneda.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbMoneda.ContentHeight = 15
        Me.cmbMoneda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoneda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoneda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoneda.EditorHeight = 15
        Me.cmbMoneda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.Images.Add(CType(resources.GetObject("cmbMoneda.Images"), System.Drawing.Image))
        Me.cmbMoneda.ItemHeight = 15
        Me.cmbMoneda.LimitToList = True
        Me.cmbMoneda.Location = New System.Drawing.Point(108, 21)
        Me.cmbMoneda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoneda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoneda.MaxLength = 32767
        Me.cmbMoneda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoneda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoneda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoneda.Size = New System.Drawing.Size(244, 21)
        Me.cmbMoneda.TabIndex = 0
        Me.cmbMoneda.PropBag = resources.GetString("cmbMoneda.PropBag")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(11, 54)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(43, 13)
        Me.lblMes.TabIndex = 7
        Me.lblMes.Text = "Fecha:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.nmuMonto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblMes)
        Me.GroupBox1.Controls.Add(Me.cmbMoneda)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 116)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(108, 53)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(126, 20)
        Me.dtFecha.TabIndex = 1
        '
        'nmuMonto
        '
        Me.nmuMonto.DecimalPlaces = 2
        Me.nmuMonto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmuMonto.Location = New System.Drawing.Point(108, 80)
        Me.nmuMonto.Name = "nmuMonto"
        Me.nmuMonto.Size = New System.Drawing.Size(128, 21)
        Me.nmuMonto.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Respecto al"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(391, 21)
        Me.Panel3.TabIndex = 23
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(302, 136)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.SimpleButton2.Location = New System.Drawing.Point(214, 136)
        Me.SimpleButton2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(80, 28)
        Me.SimpleButton2.TabIndex = 0
        Me.SimpleButton2.Tag = "GUARDAR"
        Me.SimpleButton2.Text = "&Guardar"
        '
        'frmStbEditTasaCambioOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 196)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbEditTasaCambioOficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Registrar tasa de cambio oficial"
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmuMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nmuMonto As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
End Class
