<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonasTipoPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonasTipoPersonas))
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.cmbTipoPersona = New C1.Win.C1List.C1Combo()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasificacion.Location = New System.Drawing.Point(9, 43)
        Me.lblClasificacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(104, 17)
        Me.lblClasificacion.TabIndex = 0
        Me.lblClasificacion.Tag = "OBLIGATORIO"
        Me.lblClasificacion.Text = "Clasificación:"
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoPersona.AllowColMove = False
        Me.cmbTipoPersona.AllowSort = False
        Me.cmbTipoPersona.Caption = ""
        Me.cmbTipoPersona.CaptionHeight = 17
        Me.cmbTipoPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoPersona.ColumnCaptionHeight = 17
        Me.cmbTipoPersona.ColumnFooterHeight = 17
        Me.cmbTipoPersona.ColumnHeaders = False
        Me.cmbTipoPersona.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoPersona.ContentHeight = 18
        Me.cmbTipoPersona.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoPersona.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoPersona.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoPersona.EditorHeight = 18
        Me.cmbTipoPersona.Images.Add(CType(resources.GetObject("cmbTipoPersona.Images"), System.Drawing.Image))
        Me.cmbTipoPersona.ItemHeight = 15
        Me.cmbTipoPersona.Location = New System.Drawing.Point(120, 38)
        Me.cmbTipoPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipoPersona.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPersona.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPersona.MaxLength = 32767
        Me.cmbTipoPersona.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPersona.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.Size = New System.Drawing.Size(293, 24)
        Me.cmbTipoPersona.TabIndex = 1
        Me.cmbTipoPersona.Tag = "OBLIGATORIO"
        Me.cmbTipoPersona.Text = "C1Combo1"
        Me.cmbTipoPersona.PropBag = resources.GetString("cmbTipoPersona.PropBag")
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 131)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 20)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.lblClasificacion)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(439, 151)
        Me.PanelControl1.TabIndex = 27
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(311, 87)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(196, 87)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 8
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'frmStbPersonasTipoPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 151)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbTipoPersona)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasTipoPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Clasificación"
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClasificacion As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPersona As C1.Win.C1List.C1Combo
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
