<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccCuentasEmpleadosAgregar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentasEmpleadosAgregar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numPlazo = New DevExpress.XtraEditors.SpinEdit()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbMes = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.numCuotaMensual = New C1.Win.C1Input.C1NumericEdit()
        Me.numMontoPrestamo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtContraCuenta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdContraCuenta = New System.Windows.Forms.Button()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBuscarCuenta = New System.Windows.Forms.Button()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.tbcCuentas = New System.Windows.Forms.TabControl()
        Me.pgClientes = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdConsultarEmpleado = New System.Windows.Forms.Button()
        Me.txtDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.cmdConsultarCliente = New System.Windows.Forms.Button()
        Me.cmbBeca = New C1.Win.C1List.C1Combo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.numPlazo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuotaMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.tbcCuentas.SuspendLayout()
        Me.pgClientes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numPlazo)
        Me.GroupBox1.Controls.Add(Me.cmbPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.numCuotaMensual)
        Me.GroupBox1.Controls.Add(Me.numMontoPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 196)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(843, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Prestamo"
        '
        'numPlazo
        '
        Me.numPlazo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numPlazo.Location = New System.Drawing.Point(147, 54)
        Me.numPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.numPlazo.Name = "numPlazo"
        Me.numPlazo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.numPlazo.Size = New System.Drawing.Size(133, 22)
        Me.numPlazo.TabIndex = 173
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
        Me.cmbPeriodo.Location = New System.Drawing.Point(616, 84)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(196, 24)
        Me.cmbPeriodo.TabIndex = 5
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(447, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 172
        Me.Label11.Text = "Período:"
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
        Me.cmbMes.Location = New System.Drawing.Point(147, 91)
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
        Me.cmbMes.TabIndex = 2
        Me.cmbMes.Tag = "OBLIGATORIO"
        Me.cmbMes.PropBag = resources.GetString("cmbMes.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 96)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "A partir de:"
        '
        'numCuotaMensual
        '
        Me.numCuotaMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numCuotaMensual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numCuotaMensual.EmptyAsNull = True
        Me.numCuotaMensual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuotaMensual.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numCuotaMensual.Location = New System.Drawing.Point(616, 54)
        Me.numCuotaMensual.Margin = New System.Windows.Forms.Padding(4)
        Me.numCuotaMensual.Name = "numCuotaMensual"
        Me.numCuotaMensual.ReadOnly = True
        Me.numCuotaMensual.Size = New System.Drawing.Size(196, 21)
        Me.numCuotaMensual.TabIndex = 4
        Me.numCuotaMensual.Tag = "BLOQUEADO"
        Me.numCuotaMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCuotaMensual.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numCuotaMensual.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numCuotaMensual.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numMontoPrestamo
        '
        Me.numMontoPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numMontoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMontoPrestamo.EmptyAsNull = True
        Me.numMontoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMontoPrestamo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoPrestamo.Location = New System.Drawing.Point(616, 21)
        Me.numMontoPrestamo.Margin = New System.Windows.Forms.Padding(4)
        Me.numMontoPrestamo.Name = "numMontoPrestamo"
        Me.numMontoPrestamo.Size = New System.Drawing.Size(196, 21)
        Me.numMontoPrestamo.TabIndex = 3
        Me.numMontoPrestamo.Tag = "BLOQUEADO"
        Me.numMontoPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMontoPrestamo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMontoPrestamo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numMontoPrestamo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(447, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Cuota mensual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(445, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 17)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Monto del prestamo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(15, 60)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 17)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Plazo (Meses):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(147, 26)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(245, 23)
        Me.txtEstado.TabIndex = 0
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.C1TrueDBGrid1)
        Me.TabPage2.Controls.Add(Me.ToolStrip1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(600, 149)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Fiadores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowColMove = False
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.Caption = "Fiadores"
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(3, 30)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(594, 116)
        Me.C1TrueDBGrid1.TabIndex = 4
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(594, 27)
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.ToolTipText = "AGREGAR"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.ToolTipText = "ELIMINAR"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 466)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 25)
        Me.Panel1.TabIndex = 12
        '
        'ToolTip
        '
        Me.ToolTip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.ToolTip.IsBalloon = True
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Location = New System.Drawing.Point(11, 640)
        Me.lblinfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(0, 17)
        Me.lblinfo.TabIndex = 16
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtContraCuenta)
        Me.PanelControl1.Controls.Add(Me.Label14)
        Me.PanelControl1.Controls.Add(Me.cmdContraCuenta)
        Me.PanelControl1.Controls.Add(Me.txtCuenta)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.cmdBuscarCuenta)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.tbcCuentas)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(883, 491)
        Me.PanelControl1.TabIndex = 17
        '
        'txtContraCuenta
        '
        Me.txtContraCuenta.Enabled = False
        Me.txtContraCuenta.Location = New System.Drawing.Point(213, 375)
        Me.txtContraCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraCuenta.Name = "txtContraCuenta"
        Me.txtContraCuenta.Size = New System.Drawing.Size(441, 23)
        Me.txtContraCuenta.TabIndex = 190
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 379)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 17)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "Contra cuenta contable:"
        '
        'cmdContraCuenta
        '
        Me.cmdContraCuenta.Location = New System.Drawing.Point(664, 373)
        Me.cmdContraCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdContraCuenta.Name = "cmdContraCuenta"
        Me.cmdContraCuenta.Size = New System.Drawing.Size(32, 28)
        Me.cmdContraCuenta.TabIndex = 189
        Me.cmdContraCuenta.Tag = "Buscar Existente"
        Me.cmdContraCuenta.Text = "..."
        Me.cmdContraCuenta.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(213, 342)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(441, 23)
        Me.txtCuenta.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(61, 348)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 169
        Me.Label4.Text = "Cuenta contable:"
        '
        'cmdBuscarCuenta
        '
        Me.cmdBuscarCuenta.Location = New System.Drawing.Point(664, 340)
        Me.cmdBuscarCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarCuenta.Name = "cmdBuscarCuenta"
        Me.cmdBuscarCuenta.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscarCuenta.TabIndex = 0
        Me.cmdBuscarCuenta.Tag = "Buscar Existente"
        Me.cmdBuscarCuenta.Text = "..."
        Me.cmdBuscarCuenta.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(748, 425)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 2
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(632, 425)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 1
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'tbcCuentas
        '
        Me.tbcCuentas.Controls.Add(Me.pgClientes)
        Me.tbcCuentas.Location = New System.Drawing.Point(7, 7)
        Me.tbcCuentas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcCuentas.Name = "tbcCuentas"
        Me.tbcCuentas.SelectedIndex = 0
        Me.tbcCuentas.Size = New System.Drawing.Size(861, 176)
        Me.tbcCuentas.TabIndex = 9
        '
        'pgClientes
        '
        Me.pgClientes.Controls.Add(Me.GroupBox2)
        Me.pgClientes.Location = New System.Drawing.Point(4, 25)
        Me.pgClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Name = "pgClientes"
        Me.pgClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Size = New System.Drawing.Size(853, 147)
        Me.pgClientes.TabIndex = 0
        Me.pgClientes.Text = "Empleado"
        Me.pgClientes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtIdentificacion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmdBuscar)
        Me.GroupBox2.Controls.Add(Me.cmdConsultarEmpleado)
        Me.GroupBox2.Controls.Add(Me.txtDireccionEmpleado)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(845, 139)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "BLOQUEADO"
        Me.GroupBox2.Text = "Datos del empleado"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.Location = New System.Drawing.Point(255, 59)
        Me.txtIdentificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.ReadOnly = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(468, 23)
        Me.txtIdentificacion.TabIndex = 3
        Me.txtIdentificacion.Tag = "BLOQUEADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "Cédula:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(768, 28)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdConsultarEmpleado
        '
        Me.cmdConsultarEmpleado.Image = CType(resources.GetObject("cmdConsultarEmpleado.Image"), System.Drawing.Image)
        Me.cmdConsultarEmpleado.Location = New System.Drawing.Point(735, 28)
        Me.cmdConsultarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultarEmpleado.Name = "cmdConsultarEmpleado"
        Me.cmdConsultarEmpleado.Size = New System.Drawing.Size(31, 28)
        Me.cmdConsultarEmpleado.TabIndex = 1
        Me.cmdConsultarEmpleado.Text = "..."
        Me.cmdConsultarEmpleado.UseVisualStyleBackColor = True
        '
        'txtDireccionEmpleado
        '
        Me.txtDireccionEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionEmpleado.Location = New System.Drawing.Point(255, 89)
        Me.txtDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionEmpleado.Name = "txtDireccionEmpleado"
        Me.txtDireccionEmpleado.ReadOnly = True
        Me.txtDireccionEmpleado.Size = New System.Drawing.Size(468, 23)
        Me.txtDireccionEmpleado.TabIndex = 4
        Me.txtDireccionEmpleado.Tag = "BLOQUEADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Dirección:"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(256, 30)
        Me.txtNombreCompleto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(468, 23)
        Me.txtNombreCompleto.TabIndex = 2
        Me.txtNombreCompleto.Tag = "BLOQUEADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre Completo"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(0, 27)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 13)
        Me.lblNombre.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(192, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(352, 23)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Tag = "BLOQUEADO"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(3, 56)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(0, 13)
        Me.lblDireccion.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(192, 52)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(383, 23)
        Me.txtDireccion.TabIndex = 1
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Image = CType(resources.GetObject("cmdConsultarCliente.Image"), System.Drawing.Image)
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(551, 23)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(23, 23)
        Me.cmdConsultarCliente.TabIndex = 3
        Me.cmdConsultarCliente.Text = "..."
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
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
        Me.cmbBeca.Enabled = False
        Me.cmbBeca.Images.Add(CType(resources.GetObject("cmbBeca.Images"), System.Drawing.Image))
        Me.cmbBeca.ItemHeight = 15
        Me.cmbBeca.Location = New System.Drawing.Point(396, 77)
        Me.cmbBeca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBeca.MaxDropDownItems = CType(5, Short)
        Me.cmbBeca.MaxLength = 32767
        Me.cmbBeca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBeca.Name = "cmbBeca"
        Me.cmbBeca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBeca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBeca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBeca.Size = New System.Drawing.Size(179, 24)
        Me.cmbBeca.TabIndex = 4
        Me.cmbBeca.Tag = "OBLIGATORIO"
        Me.cmbBeca.PropBag = resources.GetString("cmbBeca.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(350, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Tag = "OBLIGATORIO"
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(192, 20)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(149, 23)
        Me.txtCedula.TabIndex = 2
        Me.txtCedula.Tag = "BLOQUEADO"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(3, 81)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(45, 13)
        Me.lblCedula.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Tag = "Buscar Existente"
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(626, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 21)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Activo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBox1)
        Me.GroupBox6.Controls.Add(Me.cmbBeca)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(632, 303)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Tag = "BLOQUEADO"
        Me.GroupBox6.Text = "Datos de estudiante"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'frmSccCuentasEmpleadosAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 491)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccCuentasEmpleadosAgregar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expedientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numPlazo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuotaMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.tbcCuentas.ResumeLayout(False)
        Me.pgClientes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbBeca As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdConsultarCliente As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents numCuotaMensual As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numMontoPrestamo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcCuentas As TabControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdBuscarCuenta As Button
    Friend WithEvents pgClientes As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdConsultarEmpleado As Button
    Friend WithEvents txtDireccionEmpleado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbMes As C1.Win.C1List.C1Combo
    Friend WithEvents ErrPrv As ErrorProvider
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents Label11 As Label
    Friend WithEvents numPlazo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtContraCuenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmdContraCuenta As Button
End Class
