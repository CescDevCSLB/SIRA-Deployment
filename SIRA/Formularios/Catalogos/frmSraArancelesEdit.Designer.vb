<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraArancelesEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraArancelesEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbMoneda = New C1.Win.C1List.C1Combo()
        Me.cmbTipoArancel = New C1.Win.C1List.C1Combo()
        Me.cmbGrado = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.spnValor = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoArancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(608, 226)
        Me.PanelControl1.TabIndex = 98
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(484, 148)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(367, 148)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbMoneda)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbTipoArancel)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbGrado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label9)
        Me.gbxDatosGenerales.Controls.Add(Me.spnValor)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(7, 15)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(585, 126)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'cmbMoneda
        '
        Me.cmbMoneda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMoneda.AutoCompletion = True
        Me.cmbMoneda.AutoDropDown = True
        Me.cmbMoneda.Caption = ""
        Me.cmbMoneda.CaptionHeight = 17
        Me.cmbMoneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMoneda.ColumnCaptionHeight = 17
        Me.cmbMoneda.ColumnFooterHeight = 17
        Me.cmbMoneda.ContentHeight = 18
        Me.cmbMoneda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoneda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoneda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoneda.EditorHeight = 18
        Me.cmbMoneda.Images.Add(CType(resources.GetObject("cmbMoneda.Images"), System.Drawing.Image))
        Me.cmbMoneda.ItemHeight = 15
        Me.cmbMoneda.Location = New System.Drawing.Point(399, 85)
        Me.cmbMoneda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMoneda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoneda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoneda.MaxLength = 32767
        Me.cmbMoneda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoneda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoneda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoneda.Size = New System.Drawing.Size(179, 24)
        Me.cmbMoneda.TabIndex = 3
        Me.cmbMoneda.Tag = "OBLIGATORIO"
        Me.cmbMoneda.PropBag = resources.GetString("cmbMoneda.PropBag")
        '
        'cmbTipoArancel
        '
        Me.cmbTipoArancel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoArancel.AutoCompletion = True
        Me.cmbTipoArancel.AutoDropDown = True
        Me.cmbTipoArancel.Caption = ""
        Me.cmbTipoArancel.CaptionHeight = 17
        Me.cmbTipoArancel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoArancel.ColumnCaptionHeight = 17
        Me.cmbTipoArancel.ColumnFooterHeight = 17
        Me.cmbTipoArancel.ContentHeight = 18
        Me.cmbTipoArancel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoArancel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoArancel.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoArancel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoArancel.EditorHeight = 18
        Me.cmbTipoArancel.Images.Add(CType(resources.GetObject("cmbTipoArancel.Images"), System.Drawing.Image))
        Me.cmbTipoArancel.ItemHeight = 15
        Me.cmbTipoArancel.Location = New System.Drawing.Point(145, 15)
        Me.cmbTipoArancel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoArancel.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoArancel.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoArancel.MaxLength = 32767
        Me.cmbTipoArancel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoArancel.Name = "cmbTipoArancel"
        Me.cmbTipoArancel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoArancel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoArancel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoArancel.Size = New System.Drawing.Size(231, 24)
        Me.cmbTipoArancel.TabIndex = 0
        Me.cmbTipoArancel.Tag = "OBLIGATORIO"
        Me.cmbTipoArancel.PropBag = resources.GetString("cmbTipoArancel.PropBag")
        '
        'cmbGrado
        '
        Me.cmbGrado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGrado.AutoCompletion = True
        Me.cmbGrado.AutoDropDown = True
        Me.cmbGrado.Caption = ""
        Me.cmbGrado.CaptionHeight = 17
        Me.cmbGrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGrado.ColumnCaptionHeight = 17
        Me.cmbGrado.ColumnFooterHeight = 17
        Me.cmbGrado.ContentHeight = 18
        Me.cmbGrado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGrado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGrado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGrado.EditorHeight = 18
        Me.cmbGrado.Images.Add(CType(resources.GetObject("cmbGrado.Images"), System.Drawing.Image))
        Me.cmbGrado.ItemHeight = 15
        Me.cmbGrado.Location = New System.Drawing.Point(145, 48)
        Me.cmbGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGrado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGrado.MaxDropDownItems = CType(5, Short)
        Me.cmbGrado.MaxLength = 32767
        Me.cmbGrado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGrado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGrado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGrado.Size = New System.Drawing.Size(231, 24)
        Me.cmbGrado.TabIndex = 1
        Me.cmbGrado.Tag = "OBLIGATORIO"
        Me.cmbGrado.PropBag = resources.GetString("cmbGrado.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 57)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Grado:"
        '
        'spnValor
        '
        Me.spnValor.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnValor.Location = New System.Drawing.Point(145, 81)
        Me.spnValor.Margin = New System.Windows.Forms.Padding(4)
        Me.spnValor.Name = "spnValor"
        Me.spnValor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnValor.Properties.DisplayFormat.FormatString = "0.00"
        Me.spnValor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnValor.Size = New System.Drawing.Size(133, 22)
        Me.spnValor.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Valor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Moneda:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(8, 20)
        Me.lblSfaPromocionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(127, 17)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Tipo de arancel:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 200)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraArancelesEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 226)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraArancelesEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar aranceles"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoArancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents spnValor As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTipoArancel As C1.Win.C1List.C1Combo
End Class
