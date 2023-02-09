<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccCuentasEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentasEditar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbGrado = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbPeriodos = New C1.Win.C1List.C1Combo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.numMesAtrasado = New C1.Win.C1Input.C1NumericEdit()
        Me.numMesPagado = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numSaldoInicial = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.tbcCuentas = New System.Windows.Forms.TabControl()
        Me.pgClientes = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbBeca = New C1.Win.C1List.C1Combo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdConsultarCliente = New System.Windows.Forms.Button()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.tbFacturas = New System.Windows.Forms.TabControl()
        Me.PGFacturas = New System.Windows.Forms.TabPage()
        Me.grdFacturas = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.numMesAtrasado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMesPagado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldoInicial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcCuentas.SuspendLayout()
        Me.pgClientes.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.tbFacturas.SuspendLayout()
        Me.PGFacturas.SuspendLayout()
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbGrado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbPeriodos)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.lblCuenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(427, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Expediente"
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
        Me.cmbGrado.Location = New System.Drawing.Point(145, 119)
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
        Me.cmbGrado.TabIndex = 3
        Me.cmbGrado.Tag = "OBLIGATORIO"
        Me.cmbGrado.PropBag = resources.GetString("cmbGrado.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 129)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 114
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Grado:"
        '
        'cmbPeriodos
        '
        Me.cmbPeriodos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPeriodos.AutoCompletion = True
        Me.cmbPeriodos.AutoDropDown = True
        Me.cmbPeriodos.Caption = ""
        Me.cmbPeriodos.CaptionHeight = 17
        Me.cmbPeriodos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPeriodos.ColumnCaptionHeight = 17
        Me.cmbPeriodos.ColumnFooterHeight = 17
        Me.cmbPeriodos.ContentHeight = 18
        Me.cmbPeriodos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodos.EditorHeight = 18
        Me.cmbPeriodos.Images.Add(CType(resources.GetObject("cmbPeriodos.Images"), System.Drawing.Image))
        Me.cmbPeriodos.ItemHeight = 15
        Me.cmbPeriodos.Location = New System.Drawing.Point(145, 86)
        Me.cmbPeriodos.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodos.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodos.MaxLength = 32767
        Me.cmbPeriodos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodos.Name = "cmbPeriodos"
        Me.cmbPeriodos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodos.Size = New System.Drawing.Size(231, 24)
        Me.cmbPeriodos.TabIndex = 2
        Me.cmbPeriodos.Tag = "OBLIGATORIO"
        Me.cmbPeriodos.PropBag = resources.GetString("cmbPeriodos.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Período:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(145, 54)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.ReadOnly = True
        Me.txtEstado.Size = New System.Drawing.Size(245, 23)
        Me.txtEstado.TabIndex = 1
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(145, 23)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(161, 23)
        Me.txtCuenta.TabIndex = 0
        Me.txtCuenta.Tag = "BLOQUEADO"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.ForeColor = System.Drawing.Color.Black
        Me.lblCuenta.Location = New System.Drawing.Point(11, 27)
        Me.lblCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(123, 17)
        Me.lblCuenta.TabIndex = 0
        Me.lblCuenta.Text = "No. Expediente:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.numMesAtrasado)
        Me.GroupBox4.Controls.Add(Me.numMesPagado)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.numSaldoInicial)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.numSaldo)
        Me.GroupBox4.Controls.Add(Me.lblSaldo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(455, 26)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(407, 162)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Información Financiera del Expediente"
        '
        'numMesAtrasado
        '
        Me.numMesAtrasado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numMesAtrasado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMesAtrasado.EmptyAsNull = True
        Me.numMesAtrasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMesAtrasado.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMesAtrasado.Location = New System.Drawing.Point(187, 122)
        Me.numMesAtrasado.Margin = New System.Windows.Forms.Padding(4)
        Me.numMesAtrasado.Name = "numMesAtrasado"
        Me.numMesAtrasado.ReadOnly = True
        Me.numMesAtrasado.Size = New System.Drawing.Size(196, 21)
        Me.numMesAtrasado.TabIndex = 3
        Me.numMesAtrasado.Tag = "BLOQUEADO"
        Me.numMesAtrasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMesAtrasado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMesAtrasado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numMesAtrasado.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'numMesPagado
        '
        Me.numMesPagado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numMesPagado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numMesPagado.EmptyAsNull = True
        Me.numMesPagado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMesPagado.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMesPagado.Location = New System.Drawing.Point(187, 92)
        Me.numMesPagado.Margin = New System.Windows.Forms.Padding(4)
        Me.numMesPagado.Name = "numMesPagado"
        Me.numMesPagado.ReadOnly = True
        Me.numMesPagado.Size = New System.Drawing.Size(196, 21)
        Me.numMesPagado.TabIndex = 2
        Me.numMesPagado.Tag = "BLOQUEADO"
        Me.numMesPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMesPagado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMesPagado.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numMesPagado.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Meses atrasados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Meses pagados:"
        '
        'numSaldoInicial
        '
        Me.numSaldoInicial.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldoInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldoInicial.EmptyAsNull = True
        Me.numSaldoInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSaldoInicial.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldoInicial.Location = New System.Drawing.Point(188, 27)
        Me.numSaldoInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldoInicial.Name = "numSaldoInicial"
        Me.numSaldoInicial.ReadOnly = True
        Me.numSaldoInicial.Size = New System.Drawing.Size(196, 21)
        Me.numSaldoInicial.TabIndex = 0
        Me.numSaldoInicial.Tag = "BLOQUEADO"
        Me.numSaldoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSaldoInicial.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numSaldoInicial.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numSaldoInicial.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Saldo Inicial:"
        '
        'numSaldo
        '
        Me.numSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numSaldo.EmptyAsNull = True
        Me.numSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numSaldo.Location = New System.Drawing.Point(187, 60)
        Me.numSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.numSaldo.Name = "numSaldo"
        Me.numSaldo.ReadOnly = True
        Me.numSaldo.Size = New System.Drawing.Size(196, 21)
        Me.numSaldo.TabIndex = 1
        Me.numSaldo.Tag = "BLOQUEADO"
        Me.numSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.numSaldo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.ForeColor = System.Drawing.Color.Black
        Me.lblSaldo.Location = New System.Drawing.Point(13, 57)
        Me.lblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(54, 17)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo:"
        '
        'tbcCuentas
        '
        Me.tbcCuentas.Controls.Add(Me.pgClientes)
        Me.tbcCuentas.Location = New System.Drawing.Point(15, 196)
        Me.tbcCuentas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcCuentas.Name = "tbcCuentas"
        Me.tbcCuentas.SelectedIndex = 0
        Me.tbcCuentas.Size = New System.Drawing.Size(861, 174)
        Me.tbcCuentas.TabIndex = 8
        '
        'pgClientes
        '
        Me.pgClientes.Controls.Add(Me.GroupBox6)
        Me.pgClientes.Location = New System.Drawing.Point(4, 25)
        Me.pgClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Name = "pgClientes"
        Me.pgClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.pgClientes.Size = New System.Drawing.Size(853, 145)
        Me.pgClientes.TabIndex = 0
        Me.pgClientes.Text = "Estudiante"
        Me.pgClientes.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cmbBeca)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.cmdConsultarCliente)
        Me.GroupBox6.Controls.Add(Me.txtCedula)
        Me.GroupBox6.Controls.Add(Me.txtDireccion)
        Me.GroupBox6.Controls.Add(Me.lblCedula)
        Me.GroupBox6.Controls.Add(Me.lblDireccion)
        Me.GroupBox6.Controls.Add(Me.txtNombre)
        Me.GroupBox6.Controls.Add(Me.lblNombre)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(845, 137)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Tag = "BLOQUEADO"
        Me.GroupBox6.Text = "Datos de estudiante"
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
        Me.cmbBeca.Location = New System.Drawing.Point(528, 95)
        Me.cmbBeca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBeca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBeca.MaxDropDownItems = CType(5, Short)
        Me.cmbBeca.MaxLength = 32767
        Me.cmbBeca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBeca.Name = "cmbBeca"
        Me.cmbBeca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBeca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBeca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBeca.Size = New System.Drawing.Size(239, 24)
        Me.cmbBeca.TabIndex = 4
        Me.cmbBeca.Tag = "OBLIGATORIO"
        Me.cmbBeca.PropBag = resources.GetString("cmbBeca.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(467, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 112
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Beca:"
        '
        'cmdConsultarCliente
        '
        Me.cmdConsultarCliente.Image = CType(resources.GetObject("cmdConsultarCliente.Image"), System.Drawing.Image)
        Me.cmdConsultarCliente.Location = New System.Drawing.Point(735, 28)
        Me.cmdConsultarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultarCliente.Name = "cmdConsultarCliente"
        Me.cmdConsultarCliente.Size = New System.Drawing.Size(31, 28)
        Me.cmdConsultarCliente.TabIndex = 3
        Me.cmdConsultarCliente.Text = "..."
        Me.cmdConsultarCliente.UseVisualStyleBackColor = True
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(256, 96)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(197, 23)
        Me.txtCedula.TabIndex = 2
        Me.txtCedula.Tag = "BLOQUEADO"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(256, 64)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(509, 23)
        Me.txtDireccion.TabIndex = 1
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(4, 100)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(58, 17)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Grupo:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(4, 69)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 17)
        Me.lblDireccion.TabIndex = 2
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(256, 30)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(468, 23)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.Tag = "BLOQUEADO"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(0, 33)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 17)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre Completo"
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
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
        'tbFacturas
        '
        Me.tbFacturas.Controls.Add(Me.PGFacturas)
        Me.tbFacturas.Location = New System.Drawing.Point(15, 388)
        Me.tbFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFacturas.Name = "tbFacturas"
        Me.tbFacturas.SelectedIndex = 0
        Me.tbFacturas.Size = New System.Drawing.Size(856, 203)
        Me.tbFacturas.TabIndex = 0
        '
        'PGFacturas
        '
        Me.PGFacturas.Controls.Add(Me.grdFacturas)
        Me.PGFacturas.Location = New System.Drawing.Point(4, 25)
        Me.PGFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.PGFacturas.Name = "PGFacturas"
        Me.PGFacturas.Padding = New System.Windows.Forms.Padding(4)
        Me.PGFacturas.Size = New System.Drawing.Size(848, 174)
        Me.PGFacturas.TabIndex = 0
        Me.PGFacturas.Text = "Mensualidades"
        Me.PGFacturas.UseVisualStyleBackColor = True
        '
        'grdFacturas
        '
        Me.grdFacturas.CaptionHeight = 17
        Me.grdFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFacturas.ExtendRightColumn = True
        Me.grdFacturas.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdFacturas.Images.Add(CType(resources.GetObject("grdFacturas.Images"), System.Drawing.Image))
        Me.grdFacturas.Location = New System.Drawing.Point(4, 4)
        Me.grdFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.grdFacturas.Name = "grdFacturas"
        Me.grdFacturas.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdFacturas.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdFacturas.PreviewInfo.ZoomFactor = 75.0R
        Me.grdFacturas.PrintInfo.PageSettings = CType(resources.GetObject("grdFacturas.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdFacturas.RowHeight = 15
        Me.grdFacturas.Size = New System.Drawing.Size(840, 166)
        Me.grdFacturas.TabIndex = 0
        Me.grdFacturas.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.grdFacturas.PropBag = resources.GetString("grdFacturas.PropBag")
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 648)
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
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.GroupBox4)
        Me.PanelControl1.Controls.Add(Me.tbcCuentas)
        Me.PanelControl1.Controls.Add(Me.tbFacturas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(883, 673)
        Me.PanelControl1.TabIndex = 17
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(759, 607)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'frmSccCuentasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 673)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccCuentasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expedientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.numMesAtrasado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMesPagado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldoInicial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcCuentas.ResumeLayout(False)
        Me.pgClientes.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tbFacturas.ResumeLayout(False)
        Me.PGFacturas.ResumeLayout(False)
        CType(Me.grdFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents tbcCuentas As System.Windows.Forms.TabControl
    Friend WithEvents pgClientes As System.Windows.Forms.TabPage
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents numSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbFacturas As System.Windows.Forms.TabControl
    Friend WithEvents PGFacturas As System.Windows.Forms.TabPage
    Friend WithEvents grdFacturas As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents numSaldoInicial As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents ToolTip As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodos As C1.Win.C1List.C1Combo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numMesAtrasado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents numMesPagado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdConsultarCliente As System.Windows.Forms.Button
    Friend WithEvents cmbBeca As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
