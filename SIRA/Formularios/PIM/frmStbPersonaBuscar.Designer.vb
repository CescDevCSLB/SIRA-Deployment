<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbPersonaBuscar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbPersonaBuscar))
        Me.grbOpciones = New System.Windows.Forms.GroupBox()
        Me.cmbGenero = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoPersona = New C1.Win.C1List.C1Combo()
        Me.lblTipoPersona = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.chkCedula = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.grbOpciones.SuspendLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbOpciones
        '
        Me.grbOpciones.Controls.Add(Me.cmbGenero)
        Me.grbOpciones.Controls.Add(Me.Label1)
        Me.grbOpciones.Controls.Add(Me.cmbTipoPersona)
        Me.grbOpciones.Controls.Add(Me.lblTipoPersona)
        Me.grbOpciones.Controls.Add(Me.txtCedula)
        Me.grbOpciones.Controls.Add(Me.chkCedula)
        Me.grbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbOpciones.Location = New System.Drawing.Point(7, 26)
        Me.grbOpciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbOpciones.Size = New System.Drawing.Size(389, 133)
        Me.grbOpciones.TabIndex = 0
        Me.grbOpciones.TabStop = False
        Me.grbOpciones.Text = "Opciones de busqueda"
        '
        'cmbGenero
        '
        Me.cmbGenero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGenero.Caption = ""
        Me.cmbGenero.CaptionHeight = 17
        Me.cmbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGenero.ColumnCaptionHeight = 17
        Me.cmbGenero.ColumnFooterHeight = 17
        Me.cmbGenero.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbGenero.ContentHeight = 18
        Me.cmbGenero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGenero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGenero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGenero.EditorHeight = 18
        Me.cmbGenero.Enabled = False
        Me.cmbGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(129, 94)
        Me.cmbGenero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(255, 24)
        Me.cmbGenero.TabIndex = 5
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Genero"
        '
        'cmbTipoPersona
        '
        Me.cmbTipoPersona.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoPersona.Caption = ""
        Me.cmbTipoPersona.CaptionHeight = 17
        Me.cmbTipoPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoPersona.ColumnCaptionHeight = 17
        Me.cmbTipoPersona.ColumnFooterHeight = 17
        Me.cmbTipoPersona.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoPersona.ContentHeight = 18
        Me.cmbTipoPersona.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoPersona.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoPersona.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoPersona.EditorHeight = 18
        Me.cmbTipoPersona.Enabled = False
        Me.cmbTipoPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPersona.Images.Add(CType(resources.GetObject("cmbTipoPersona.Images"), System.Drawing.Image))
        Me.cmbTipoPersona.ItemHeight = 15
        Me.cmbTipoPersona.Location = New System.Drawing.Point(129, 58)
        Me.cmbTipoPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbTipoPersona.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPersona.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPersona.MaxLength = 32767
        Me.cmbTipoPersona.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPersona.Name = "cmbTipoPersona"
        Me.cmbTipoPersona.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPersona.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPersona.Size = New System.Drawing.Size(252, 24)
        Me.cmbTipoPersona.TabIndex = 3
        Me.cmbTipoPersona.PropBag = resources.GetString("cmbTipoPersona.PropBag")
        '
        'lblTipoPersona
        '
        Me.lblTipoPersona.AutoSize = True
        Me.lblTipoPersona.Location = New System.Drawing.Point(13, 62)
        Me.lblTipoPersona.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoPersona.Name = "lblTipoPersona"
        Me.lblTipoPersona.Size = New System.Drawing.Size(104, 17)
        Me.lblTipoPersona.TabIndex = 2
        Me.lblTipoPersona.Text = "Tipo persona"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(129, 22)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(253, 23)
        Me.txtCedula.TabIndex = 1
        '
        'chkCedula
        '
        Me.chkCedula.AutoSize = True
        Me.chkCedula.Checked = True
        Me.chkCedula.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCedula.Location = New System.Drawing.Point(17, 26)
        Me.chkCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCedula.Name = "chkCedula"
        Me.chkCedula.Size = New System.Drawing.Size(80, 21)
        Me.chkCedula.TabIndex = 0
        Me.chkCedula.Text = "Cedula"
        Me.chkCedula.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 225)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 20)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdAceptar)
        Me.PanelControl1.Controls.Add(Me.grbOpciones)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(407, 245)
        Me.PanelControl1.TabIndex = 27
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(291, 175)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 9
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdAceptar.Location = New System.Drawing.Point(176, 175)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(107, 34)
        Me.cmdAceptar.TabIndex = 8
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'frmStbPersonaBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 245)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbPersonaBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Personas"
        Me.grbOpciones.ResumeLayout(False)
        Me.grbOpciones.PerformLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPersona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkCedula As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipoPersona As C1.Win.C1List.C1Combo
    Friend WithEvents lblTipoPersona As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
