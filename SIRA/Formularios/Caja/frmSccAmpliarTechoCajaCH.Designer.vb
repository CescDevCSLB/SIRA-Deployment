<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccAmpliarTechoCajaCH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccAmpliarTechoCajaCH))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtJustificacion = New DevExpress.XtraEditors.MemoEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumDisponible = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumTecho = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.txtJustificacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumTecho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(580, 347)
        Me.PanelControl1.TabIndex = 98
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 319)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 26)
        Me.Panel1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(459, 277)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(344, 277)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.txtJustificacion)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.NumDisponible)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.NumTecho)
        Me.gbxDatosGenerales.Controls.Add(Me.Label7)
        Me.gbxDatosGenerales.Controls.Add(Me.Label14)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbMoeda)
        Me.gbxDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 6)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(543, 263)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'txtJustificacion
        '
        Me.txtJustificacion.Location = New System.Drawing.Point(168, 160)
        Me.txtJustificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJustificacion.Name = "txtJustificacion"
        Me.txtJustificacion.Size = New System.Drawing.Size(347, 96)
        Me.txtJustificacion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 170)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 145
        Me.Label2.Text = "Justificacion:"
        '
        'NumDisponible
        '
        Me.NumDisponible.BackColor = System.Drawing.Color.Transparent
        Me.NumDisponible.Enabled = False
        Me.NumDisponible.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumDisponible.Location = New System.Drawing.Point(168, 92)
        Me.NumDisponible.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumDisponible.Name = "NumDisponible"
        Me.NumDisponible.Size = New System.Drawing.Size(196, 23)
        Me.NumDisponible.TabIndex = 2
        Me.NumDisponible.Tag = Nothing
        Me.NumDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDisponible.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumDisponible.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Disponible:"
        '
        'NumTecho
        '
        Me.NumTecho.BackColor = System.Drawing.Color.Transparent
        Me.NumTecho.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumTecho.Location = New System.Drawing.Point(168, 126)
        Me.NumTecho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumTecho.Name = "NumTecho"
        Me.NumTecho.Size = New System.Drawing.Size(196, 23)
        Me.NumTecho.TabIndex = 3
        Me.NumTecho.Tag = Nothing
        Me.NumTecho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumTecho.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumTecho.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(15, 129)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 17)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Ampliar a:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(15, 65)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 17)
        Me.Label14.TabIndex = 140
        Me.Label14.Text = "Moneda:"
        '
        'cmbMoeda
        '
        Me.cmbMoeda.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbMoeda.AutoCompletion = True
        Me.cmbMoeda.AutoDropDown = True
        Me.cmbMoeda.Caption = ""
        Me.cmbMoeda.CaptionHeight = 17
        Me.cmbMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbMoeda.ColumnCaptionHeight = 17
        Me.cmbMoeda.ColumnFooterHeight = 17
        Me.cmbMoeda.ContentHeight = 18
        Me.cmbMoeda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoeda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoeda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoeda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoeda.EditorHeight = 18
        Me.cmbMoeda.Images.Add(CType(resources.GetObject("cmbMoeda.Images"), System.Drawing.Image))
        Me.cmbMoeda.ItemHeight = 15
        Me.cmbMoeda.Location = New System.Drawing.Point(168, 59)
        Me.cmbMoeda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMoeda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoeda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoeda.MaxLength = 32767
        Me.cmbMoeda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoeda.Name = "cmbMoeda"
        Me.cmbMoeda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoeda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoeda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoeda.Size = New System.Drawing.Size(225, 24)
        Me.cmbMoeda.TabIndex = 1
        Me.cmbMoeda.Tag = "OBLIGATORIO"
        Me.cmbMoeda.PropBag = resources.GetString("cmbMoeda.PropBag")
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(168, 26)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(224, 23)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Tag = "BLOQUEADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Código:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccAmpliarTechoCajaCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 347)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccAmpliarTechoCajaCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ampliar techo"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.txtJustificacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumTecho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents NumTecho As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJustificacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumDisponible As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
