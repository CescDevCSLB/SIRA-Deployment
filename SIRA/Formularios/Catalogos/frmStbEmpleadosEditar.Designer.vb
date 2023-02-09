<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbEmpleadosEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbEmpleadosEditar))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.cmbCargo = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaEgreso = New C1.Win.C1Input.C1DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New C1.Win.C1Input.C1DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbciudad = New C1.Win.C1List.C1Combo()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabAdicionales = New System.Windows.Forms.TabControl()
        Me.tabContactos = New System.Windows.Forms.TabPage()
        Me.tdbContactos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barContactos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.grpPersonaNatural = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.cmbGenero = New C1.Win.C1List.C1Combo()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New C1.Win.C1Input.C1DateEdit()
        Me.txtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.grpDatos.SuspendLayout()
        CType(Me.cmbCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        Me.grpPersonaNatural.SuspendLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.cmbCargo)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.dtpFechaEgreso)
        Me.grpDatos.Controls.Add(Me.Label5)
        Me.grpDatos.Controls.Add(Me.dtpFechaIngreso)
        Me.grpDatos.Controls.Add(Me.SimpleButton1)
        Me.grpDatos.Controls.Add(Me.Label4)
        Me.grpDatos.Controls.Add(Me.GroupBox2)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Controls.Add(Me.grpPersonaNatural)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(1247, 465)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'cmbCargo
        '
        Me.cmbCargo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCargo.AutoCompletion = True
        Me.cmbCargo.AutoDropDown = True
        Me.cmbCargo.Caption = ""
        Me.cmbCargo.CaptionHeight = 17
        Me.cmbCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCargo.ColumnCaptionHeight = 17
        Me.cmbCargo.ColumnFooterHeight = 17
        Me.cmbCargo.ContentHeight = 18
        Me.cmbCargo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCargo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCargo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCargo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCargo.EditorHeight = 18
        Me.cmbCargo.Images.Add(CType(resources.GetObject("cmbCargo.Images"), System.Drawing.Image))
        Me.cmbCargo.ItemHeight = 15
        Me.cmbCargo.Location = New System.Drawing.Point(887, 361)
        Me.cmbCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCargo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCargo.MaxDropDownItems = CType(5, Short)
        Me.cmbCargo.MaxLength = 32767
        Me.cmbCargo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCargo.Name = "cmbCargo"
        Me.cmbCargo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCargo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCargo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCargo.Size = New System.Drawing.Size(231, 24)
        Me.cmbCargo.TabIndex = 3
        Me.cmbCargo.Tag = "OBLIGATORIO"
        Me.cmbCargo.PropBag = resources.GetString("cmbCargo.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(700, 363)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "Cargo:"
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.AcceptsTab = True
        Me.dtpFechaEgreso.AllowDrop = True
        Me.dtpFechaEgreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaEgreso.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaEgreso.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaEgreso.Calendar.ClearText = "&Clear"
        Me.dtpFechaEgreso.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaEgreso.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtpFechaEgreso.Calendar.ShowTodayCircle = False
        Me.dtpFechaEgreso.Calendar.TodayText = "&Today"
        Me.dtpFechaEgreso.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaEgreso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaEgreso.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaEgreso.EmptyAsNull = True
        Me.dtpFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEgreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(887, 329)
        Me.dtpFechaEgreso.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(227, 23)
        Me.dtpFechaEgreso.TabIndex = 2
        Me.dtpFechaEgreso.Tag = Nothing
        Me.dtpFechaEgreso.TrimStart = True
        Me.dtpFechaEgreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaEgreso.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(700, 332)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha de egreso:"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.AcceptsTab = True
        Me.dtpFechaIngreso.AllowDrop = True
        Me.dtpFechaIngreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaIngreso.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.ClearText = "&Clear"
        Me.dtpFechaIngreso.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaIngreso.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtpFechaIngreso.Calendar.ShowTodayCircle = False
        Me.dtpFechaIngreso.Calendar.TodayText = "&Today"
        Me.dtpFechaIngreso.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaIngreso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaIngreso.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaIngreso.EmptyAsNull = True
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(887, 292)
        Me.dtpFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(227, 23)
        Me.dtpFechaIngreso.TabIndex = 1
        Me.dtpFechaIngreso.Tag = Nothing
        Me.dtpFechaIngreso.TrimStart = True
        Me.dtpFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaIngreso.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(1139, 405)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(700, 295)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Fecha de ingreso:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbciudad)
        Me.GroupBox2.Controls.Add(Me.txtDireccion)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 295)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(653, 145)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ubicación"
        '
        'cmbciudad
        '
        Me.cmbciudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbciudad.AutoCompletion = True
        Me.cmbciudad.AutoDropDown = True
        Me.cmbciudad.Caption = ""
        Me.cmbciudad.CaptionHeight = 17
        Me.cmbciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbciudad.ColumnCaptionHeight = 17
        Me.cmbciudad.ColumnFooterHeight = 17
        Me.cmbciudad.ContentHeight = 18
        Me.cmbciudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbciudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbciudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbciudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbciudad.EditorHeight = 18
        Me.cmbciudad.Images.Add(CType(resources.GetObject("cmbciudad.Images"), System.Drawing.Image))
        Me.cmbciudad.ItemHeight = 15
        Me.cmbciudad.Location = New System.Drawing.Point(189, 20)
        Me.cmbciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbciudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbciudad.MaxDropDownItems = CType(5, Short)
        Me.cmbciudad.MaxLength = 32767
        Me.cmbciudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbciudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbciudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbciudad.Size = New System.Drawing.Size(305, 24)
        Me.cmbciudad.TabIndex = 0
        Me.cmbciudad.Tag = "OBLIGATORIO"
        Me.cmbciudad.PropBag = resources.GetString("cmbciudad.PropBag")
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(189, 53)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(436, 69)
        Me.txtDireccion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ciudad:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabAdicionales)
        Me.GroupBox1.Location = New System.Drawing.Point(655, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(545, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'tabAdicionales
        '
        Me.tabAdicionales.Controls.Add(Me.tabContactos)
        Me.tabAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicionales.Location = New System.Drawing.Point(4, 20)
        Me.tabAdicionales.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAdicionales.Name = "tabAdicionales"
        Me.tabAdicionales.SelectedIndex = 0
        Me.tabAdicionales.Size = New System.Drawing.Size(537, 237)
        Me.tabAdicionales.TabIndex = 0
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tdbContactos)
        Me.tabContactos.Controls.Add(Me.barContactos)
        Me.tabContactos.Location = New System.Drawing.Point(4, 26)
        Me.tabContactos.Margin = New System.Windows.Forms.Padding(4)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.Padding = New System.Windows.Forms.Padding(4)
        Me.tabContactos.Size = New System.Drawing.Size(529, 207)
        Me.tabContactos.TabIndex = 0
        Me.tabContactos.Text = "¿Cómo Contactar?"
        Me.tabContactos.UseVisualStyleBackColor = True
        '
        'tdbContactos
        '
        Me.tdbContactos.AllowArrows = False
        Me.tdbContactos.AllowColMove = False
        Me.tdbContactos.AllowColSelect = False
        Me.tdbContactos.AllowRowSelect = False
        Me.tdbContactos.AllowUpdate = False
        Me.tdbContactos.CaptionHeight = 19
        Me.tdbContactos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbContactos.ExtendRightColumn = True
        Me.tdbContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbContactos.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactos.Images.Add(CType(resources.GetObject("tdbContactos.Images"), System.Drawing.Image))
        Me.tdbContactos.Location = New System.Drawing.Point(4, 31)
        Me.tdbContactos.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbContactos.Name = "tdbContactos"
        Me.tdbContactos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactos.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactos.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactos.RowHeight = 17
        Me.tdbContactos.Size = New System.Drawing.Size(521, 172)
        Me.tdbContactos.TabIndex = 1
        Me.tdbContactos.Text = "C1TrueDBGrid1"
        Me.tdbContactos.PropBag = resources.GetString("tdbContactos.PropBag")
        '
        'barContactos
        '
        Me.barContactos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.barContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContacto, Me.cmdEliminarContacto})
        Me.barContactos.Location = New System.Drawing.Point(4, 4)
        Me.barContactos.Name = "barContactos"
        Me.barContactos.Size = New System.Drawing.Size(521, 27)
        Me.barContactos.TabIndex = 0
        Me.barContactos.Text = "ToolStrip1"
        '
        'cmdAgregarContacto
        '
        Me.cmdAgregarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarContacto.Image = CType(resources.GetObject("cmdAgregarContacto.Image"), System.Drawing.Image)
        Me.cmdAgregarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarContacto.Name = "cmdAgregarContacto"
        Me.cmdAgregarContacto.Size = New System.Drawing.Size(24, 24)
        Me.cmdAgregarContacto.Text = "ToolStripButton1"
        Me.cmdAgregarContacto.ToolTipText = "Agregar Contacto"
        '
        'cmdEliminarContacto
        '
        Me.cmdEliminarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarContacto.Image = CType(resources.GetObject("cmdEliminarContacto.Image"), System.Drawing.Image)
        Me.cmdEliminarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarContacto.Name = "cmdEliminarContacto"
        Me.cmdEliminarContacto.Size = New System.Drawing.Size(24, 24)
        Me.cmdEliminarContacto.Text = "ToolStripButton2"
        Me.cmdEliminarContacto.ToolTipText = "Eliminar Contacto"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(1024, 405)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'grpPersonaNatural
        '
        Me.grpPersonaNatural.Controls.Add(Me.chkActivo)
        Me.grpPersonaNatural.Controls.Add(Me.cmbGenero)
        Me.grpPersonaNatural.Controls.Add(Me.cmdBuscar)
        Me.grpPersonaNatural.Controls.Add(Me.Label3)
        Me.grpPersonaNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.txtCedula)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblGenero)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoNombre)
        Me.grpPersonaNatural.Location = New System.Drawing.Point(15, 22)
        Me.grpPersonaNatural.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Name = "grpPersonaNatural"
        Me.grpPersonaNatural.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Size = New System.Drawing.Size(587, 268)
        Me.grpPersonaNatural.TabIndex = 2
        Me.grpPersonaNatural.TabStop = False
        Me.grpPersonaNatural.Text = "Persona"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(496, 28)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cmbGenero
        '
        Me.cmbGenero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGenero.AutoCompletion = True
        Me.cmbGenero.AutoDropDown = True
        Me.cmbGenero.Caption = ""
        Me.cmbGenero.CaptionHeight = 17
        Me.cmbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGenero.ColumnCaptionHeight = 17
        Me.cmbGenero.ColumnFooterHeight = 17
        Me.cmbGenero.ContentHeight = 18
        Me.cmbGenero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGenero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGenero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGenero.EditorHeight = 18
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(200, 153)
        Me.cmbGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(227, 24)
        Me.cmbGenero.TabIndex = 6
        Me.cmbGenero.Tag = "OBLIGATORIO"
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(435, 28)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Cédula nacional:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.AcceptsTab = True
        Me.dtpFechaNacimiento.AllowDrop = True
        Me.dtpFechaNacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaNacimiento.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.ClearText = "&Clear"
        Me.dtpFechaNacimiento.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Calendar.ShowTodayCircle = False
        Me.dtpFechaNacimiento.Calendar.TodayText = "&Today"
        Me.dtpFechaNacimiento.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaNacimiento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaNacimiento.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaNacimiento.EmptyAsNull = True
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(200, 190)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(227, 23)
        Me.dtpFechaNacimiento.TabIndex = 7
        Me.dtpFechaNacimiento.Tag = Nothing
        Me.dtpFechaNacimiento.TrimStart = True
        Me.dtpFechaNacimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaNacimiento.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'txtCedula
        '
        Me.txtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedula.Location = New System.Drawing.Point(200, 223)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedula.Mask = "000-000000-0000L"
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(225, 23)
        Me.txtCedula.TabIndex = 8
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(200, 121)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoApellido.TabIndex = 5
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(200, 90)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerApellido.TabIndex = 4
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(200, 59)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoNombre.TabIndex = 3
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(200, 28)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerNombre.TabIndex = 0
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(13, 193)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(163, 17)
        Me.lblFechaNacimiento.TabIndex = 14
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(13, 127)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(139, 17)
        Me.lblSegundoApellido.TabIndex = 12
        Me.lblSegundoApellido.Text = "Segundo apellido:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(13, 160)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(67, 17)
        Me.lblGenero.TabIndex = 11
        Me.lblGenero.Tag = "OBLIGATORIO"
        Me.lblGenero.Text = "Género:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(13, 96)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(122, 17)
        Me.lblPrimerApellido.TabIndex = 10
        Me.lblPrimerApellido.Tag = "OBLIGATORIO"
        Me.lblPrimerApellido.Text = "Primer apellido:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.Location = New System.Drawing.Point(13, 34)
        Me.lblPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(119, 17)
        Me.lblPrimerNombre.TabIndex = 9
        Me.lblPrimerNombre.Tag = "OBLIGATORIO"
        Me.lblPrimerNombre.Text = "Primer nombre:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.Location = New System.Drawing.Point(13, 65)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(136, 17)
        Me.lblSegundoNombre.TabIndex = 8
        Me.lblSegundoNombre.Text = "Segundo nombre:"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'ArchivoDialogo
        '
        Me.ArchivoDialogo.FileName = "OpenFileDialog1"
        Me.ArchivoDialogo.Filter = "JPEG Files | *.JPG"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 453)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 20)
        Me.Panel1.TabIndex = 26
        '
        'panelcliente
        '
        Me.panelcliente.Controls.Add(Me.grpDatos)
        Me.panelcliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcliente.Location = New System.Drawing.Point(0, 0)
        Me.panelcliente.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panelcliente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panelcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.panelcliente.Name = "panelcliente"
        Me.panelcliente.Size = New System.Drawing.Size(1269, 473)
        Me.panelcliente.TabIndex = 27
        '
        'frmStbEmpleadosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 473)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbEmpleadosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cmbCargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabAdicionales.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabContactos.PerformLayout()
        CType(Me.tdbContactos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barContactos.ResumeLayout(False)
        Me.barContactos.PerformLayout()
        Me.grpPersonaNatural.ResumeLayout(False)
        Me.grpPersonaNatural.PerformLayout()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonaNatural As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents barContactos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents tdbContactos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents panelcliente As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbciudad As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Public WithEvents dtpFechaEgreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents dtpFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCargo As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
