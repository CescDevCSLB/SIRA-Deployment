<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonasContactos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonasContactos))
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblTipoContacto = New System.Windows.Forms.Label()
        Me.cmbTipoPersona = New C1.Win.C1List.C1Combo()
        Me.txtValor = New System.Windows.Forms.MaskedTextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'lblTipoContacto
        '
        Me.lblTipoContacto.AutoSize = True
        Me.lblTipoContacto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoContacto.Location = New System.Drawing.Point(17, 31)
        Me.lblTipoContacto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoContacto.Name = "lblTipoContacto"
        Me.lblTipoContacto.Size = New System.Drawing.Size(137, 17)
        Me.lblTipoContacto.TabIndex = 0
        Me.lblTipoContacto.Text = "Tipo de Contacto:"
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
        Me.cmbTipoPersona.Location = New System.Drawing.Point(171, 27)
        Me.cmbTipoPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipoPersona.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPersona.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPersona.MaxLength = 32767
        Me.cmbTipoPersona.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPersona.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.Size = New System.Drawing.Size(292, 24)
        Me.cmbTipoPersona.TabIndex = 3
        Me.cmbTipoPersona.Text = "C1Combo1"
        Me.cmbTipoPersona.PropBag = resources.GetString("cmbTipoPersona.PropBag")
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(171, 58)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(291, 22)
        Me.txtValor.TabIndex = 4
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValor.Location = New System.Drawing.Point(21, 62)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(51, 17)
        Me.lblValor.TabIndex = 5
        Me.lblValor.Text = "Valor:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 141)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 20)
        Me.Panel1.TabIndex = 26
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(363, 100)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 28
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(248, 100)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 27
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblTipoContacto)
        Me.PanelControl1.Controls.Add(Me.lblValor)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(497, 161)
        Me.PanelControl1.TabIndex = 29
        '
        'frmStbPersonasContactos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 161)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.cmbTipoPersona)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonasContactos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Contactos"
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblTipoContacto As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPersona As C1.Win.C1List.C1Combo
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
