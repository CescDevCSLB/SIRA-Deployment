<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraMatriculaEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraMatriculaEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.cmdTomar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCargarFoto = New DevExpress.XtraEditors.SimpleButton()
        Me.PBFoto = New System.Windows.Forms.PictureBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkIngresoPosterior = New System.Windows.Forms.CheckBox()
        Me.dtFechaIngreso = New C1.Win.C1Input.C1DateEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtFechaMatricula = New C1.Win.C1Input.C1DateEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbPeriodos = New C1.Win.C1List.C1Combo()
        Me.txtEscuelaProcedencia = New System.Windows.Forms.TextBox()
        Me.cmbBeca = New C1.Win.C1List.C1Combo()
        Me.cmbModalidad = New C1.Win.C1List.C1Combo()
        Me.cmbGrado = New C1.Win.C1List.C1Combo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTipoMatricula = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRecomendaciones = New System.Windows.Forms.TextBox()
        Me.txtNumRecibo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpPersonaNatural = New System.Windows.Forms.GroupBox()
        Me.cmdEditarAlumno = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAddAlumno = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigoMined = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaNacimiento = New C1.Win.C1Input.C1DateEdit()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.OFDFoto = New System.Windows.Forms.OpenFileDialog()
        Me.grpDatos.SuspendLayout()
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtFechaIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFechaMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoMatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonaNatural.SuspendLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.cmdTomar)
        Me.grpDatos.Controls.Add(Me.cmdCargarFoto)
        Me.grpDatos.Controls.Add(Me.PBFoto)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.grpPersonaNatural)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(977, 574)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'cmdTomar
        '
        Me.cmdTomar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTomar.Appearance.Options.UseFont = True
        Me.cmdTomar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.empleado16x16
        Me.cmdTomar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdTomar.Location = New System.Drawing.Point(903, 190)
        Me.cmdTomar.LookAndFeel.SkinName = "Caramel"
        Me.cmdTomar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdTomar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTomar.Name = "cmdTomar"
        Me.cmdTomar.Size = New System.Drawing.Size(32, 28)
        Me.cmdTomar.TabIndex = 0
        Me.cmdTomar.Tag = "AGREGAR"
        '
        'cmdCargarFoto
        '
        Me.cmdCargarFoto.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCargarFoto.Appearance.Options.UseFont = True
        Me.cmdCargarFoto.ImageOptions.Image = Global.SIRA.My.Resources.Resources.if_Load_132741
        Me.cmdCargarFoto.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdCargarFoto.Location = New System.Drawing.Point(903, 223)
        Me.cmdCargarFoto.LookAndFeel.SkinName = "Caramel"
        Me.cmdCargarFoto.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCargarFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCargarFoto.Name = "cmdCargarFoto"
        Me.cmdCargarFoto.Size = New System.Drawing.Size(32, 28)
        Me.cmdCargarFoto.TabIndex = 1
        Me.cmdCargarFoto.Tag = "AGREGAR"
        '
        'PBFoto
        '
        Me.PBFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBFoto.Location = New System.Drawing.Point(633, 25)
        Me.PBFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.PBFoto.Name = "PBFoto"
        Me.PBFoto.Size = New System.Drawing.Size(261, 226)
        Me.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFoto.TabIndex = 108
        Me.PBFoto.TabStop = False
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.Cancel16
        Me.cmdCancelar.Location = New System.Drawing.Point(861, 514)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(747, 514)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIngresoPosterior)
        Me.GroupBox1.Controls.Add(Me.dtFechaIngreso)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dtFechaMatricula)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbPeriodos)
        Me.GroupBox1.Controls.Add(Me.txtEscuelaProcedencia)
        Me.GroupBox1.Controls.Add(Me.cmbBeca)
        Me.GroupBox1.Controls.Add(Me.cmbModalidad)
        Me.GroupBox1.Controls.Add(Me.cmbGrado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTipoMatricula)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtRecomendaciones)
        Me.GroupBox1.Controls.Add(Me.txtNumRecibo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 258)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(955, 235)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de la matrícula"
        '
        'chkIngresoPosterior
        '
        Me.chkIngresoPosterior.AutoSize = True
        Me.chkIngresoPosterior.Location = New System.Drawing.Point(484, 172)
        Me.chkIngresoPosterior.Margin = New System.Windows.Forms.Padding(4)
        Me.chkIngresoPosterior.Name = "chkIngresoPosterior"
        Me.chkIngresoPosterior.Size = New System.Drawing.Size(154, 21)
        Me.chkIngresoPosterior.TabIndex = 110
        Me.chkIngresoPosterior.Text = "Ingreso posterior"
        Me.chkIngresoPosterior.UseVisualStyleBackColor = True
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.AcceptsTab = True
        Me.dtFechaIngreso.AllowDrop = True
        Me.dtFechaIngreso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtFechaIngreso.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtFechaIngreso.Calendar.BoldedDates = New Date(-1) {}
        Me.dtFechaIngreso.Calendar.ClearText = "&Clear"
        Me.dtFechaIngreso.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtFechaIngreso.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtFechaIngreso.Calendar.ShowTodayCircle = False
        Me.dtFechaIngreso.Calendar.TodayText = "&Today"
        Me.dtFechaIngreso.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtFechaIngreso.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtFechaIngreso.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtFechaIngreso.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtFechaIngreso.EmptyAsNull = True
        Me.dtFechaIngreso.Enabled = False
        Me.dtFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaIngreso.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtFechaIngreso.Location = New System.Drawing.Point(701, 203)
        Me.dtFechaIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaIngreso.Size = New System.Drawing.Size(231, 23)
        Me.dtFechaIngreso.TabIndex = 109
        Me.dtFechaIngreso.Tag = Nothing
        Me.dtFechaIngreso.TrimStart = True
        Me.dtFechaIngreso.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtFechaIngreso.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(480, 206)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 17)
        Me.Label12.TabIndex = 108
        Me.Label12.Text = "Fecha de ingreso:"
        '
        'dtFechaMatricula
        '
        Me.dtFechaMatricula.AcceptsTab = True
        Me.dtFechaMatricula.AllowDrop = True
        Me.dtFechaMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtFechaMatricula.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtFechaMatricula.Calendar.BoldedDates = New Date(-1) {}
        Me.dtFechaMatricula.Calendar.ClearText = "&Clear"
        Me.dtFechaMatricula.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtFechaMatricula.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtFechaMatricula.Calendar.ShowTodayCircle = False
        Me.dtFechaMatricula.Calendar.TodayText = "&Today"
        Me.dtFechaMatricula.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtFechaMatricula.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtFechaMatricula.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtFechaMatricula.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtFechaMatricula.EmptyAsNull = True
        Me.dtFechaMatricula.Enabled = False
        Me.dtFechaMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaMatricula.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtFechaMatricula.Location = New System.Drawing.Point(701, 124)
        Me.dtFechaMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFechaMatricula.Name = "dtFechaMatricula"
        Me.dtFechaMatricula.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtFechaMatricula.Size = New System.Drawing.Size(231, 23)
        Me.dtFechaMatricula.TabIndex = 107
        Me.dtFechaMatricula.Tag = Nothing
        Me.dtFechaMatricula.TrimStart = True
        Me.dtFechaMatricula.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtFechaMatricula.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(480, 127)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(151, 17)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Fecha de matricula:"
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
        Me.cmbPeriodos.Location = New System.Drawing.Point(701, 90)
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
        Me.cmbPeriodos.TabIndex = 7
        Me.cmbPeriodos.Tag = "OBLIGATORIO"
        Me.cmbPeriodos.PropBag = resources.GetString("cmbPeriodos.PropBag")
        '
        'txtEscuelaProcedencia
        '
        Me.txtEscuelaProcedencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEscuelaProcedencia.Location = New System.Drawing.Point(701, 58)
        Me.txtEscuelaProcedencia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEscuelaProcedencia.Name = "txtEscuelaProcedencia"
        Me.txtEscuelaProcedencia.Size = New System.Drawing.Size(225, 23)
        Me.txtEscuelaProcedencia.TabIndex = 6
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
        Me.cmbBeca.Location = New System.Drawing.Point(200, 123)
        Me.cmbBeca.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBeca.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBeca.MaxDropDownItems = CType(5, Short)
        Me.cmbBeca.MaxLength = 32767
        Me.cmbBeca.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBeca.Name = "cmbBeca"
        Me.cmbBeca.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBeca.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBeca.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBeca.Size = New System.Drawing.Size(231, 24)
        Me.cmbBeca.TabIndex = 3
        Me.cmbBeca.Tag = "OBLIGATORIO"
        Me.cmbBeca.PropBag = resources.GetString("cmbBeca.PropBag")
        '
        'cmbModalidad
        '
        Me.cmbModalidad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbModalidad.AutoCompletion = True
        Me.cmbModalidad.AutoDropDown = True
        Me.cmbModalidad.Caption = ""
        Me.cmbModalidad.CaptionHeight = 17
        Me.cmbModalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbModalidad.ColumnCaptionHeight = 17
        Me.cmbModalidad.ColumnFooterHeight = 17
        Me.cmbModalidad.ContentHeight = 18
        Me.cmbModalidad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbModalidad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbModalidad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModalidad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModalidad.EditorHeight = 18
        Me.cmbModalidad.Images.Add(CType(resources.GetObject("cmbModalidad.Images"), System.Drawing.Image))
        Me.cmbModalidad.ItemHeight = 15
        Me.cmbModalidad.Location = New System.Drawing.Point(200, 90)
        Me.cmbModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbModalidad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbModalidad.MaxDropDownItems = CType(5, Short)
        Me.cmbModalidad.MaxLength = 32767
        Me.cmbModalidad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbModalidad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbModalidad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbModalidad.Size = New System.Drawing.Size(231, 24)
        Me.cmbModalidad.TabIndex = 2
        Me.cmbModalidad.Tag = "OBLIGATORIO"
        Me.cmbModalidad.PropBag = resources.GetString("cmbModalidad.PropBag")
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
        Me.cmbGrado.Location = New System.Drawing.Point(200, 57)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(480, 96)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Período:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 166)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Recomendaciones:"
        '
        'cmbTipoMatricula
        '
        Me.cmbTipoMatricula.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoMatricula.AutoCompletion = True
        Me.cmbTipoMatricula.AutoDropDown = True
        Me.cmbTipoMatricula.Caption = ""
        Me.cmbTipoMatricula.CaptionHeight = 17
        Me.cmbTipoMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoMatricula.ColumnCaptionHeight = 17
        Me.cmbTipoMatricula.ColumnFooterHeight = 17
        Me.cmbTipoMatricula.ContentHeight = 18
        Me.cmbTipoMatricula.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoMatricula.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoMatricula.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoMatricula.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoMatricula.EditorHeight = 18
        Me.cmbTipoMatricula.Images.Add(CType(resources.GetObject("cmbTipoMatricula.Images"), System.Drawing.Image))
        Me.cmbTipoMatricula.ItemHeight = 15
        Me.cmbTipoMatricula.Location = New System.Drawing.Point(200, 26)
        Me.cmbTipoMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoMatricula.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoMatricula.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoMatricula.MaxLength = 32767
        Me.cmbTipoMatricula.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoMatricula.Name = "cmbTipoMatricula"
        Me.cmbTipoMatricula.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoMatricula.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoMatricula.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoMatricula.Size = New System.Drawing.Size(231, 24)
        Me.cmbTipoMatricula.TabIndex = 0
        Me.cmbTipoMatricula.Tag = "OBLIGATORIO"
        Me.cmbTipoMatricula.PropBag = resources.GetString("cmbTipoMatricula.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Tipo de matrícula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(435, 224)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Tag = "OBLIGATORIO"
        '
        'txtRecomendaciones
        '
        Me.txtRecomendaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendaciones.Location = New System.Drawing.Point(200, 162)
        Me.txtRecomendaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecomendaciones.Multiline = True
        Me.txtRecomendaciones.Name = "txtRecomendaciones"
        Me.txtRecomendaciones.Size = New System.Drawing.Size(269, 64)
        Me.txtRecomendaciones.TabIndex = 4
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRecibo.Location = New System.Drawing.Point(701, 27)
        Me.txtNumRecibo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.Size = New System.Drawing.Size(225, 23)
        Me.txtNumRecibo.TabIndex = 5
        Me.txtNumRecibo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(480, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Escuela de procedencia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(480, 30)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Número de recibo:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 127)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Beca:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Grado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 96)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Modalidad:"
        '
        'grpPersonaNatural
        '
        Me.grpPersonaNatural.Controls.Add(Me.cmdEditarAlumno)
        Me.grpPersonaNatural.Controls.Add(Me.cmdAddAlumno)
        Me.grpPersonaNatural.Controls.Add(Me.txtCodigoMined)
        Me.grpPersonaNatural.Controls.Add(Me.Label3)
        Me.grpPersonaNatural.Controls.Add(Me.cmdBuscar)
        Me.grpPersonaNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoNombre)
        Me.grpPersonaNatural.Location = New System.Drawing.Point(15, 15)
        Me.grpPersonaNatural.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Name = "grpPersonaNatural"
        Me.grpPersonaNatural.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Size = New System.Drawing.Size(597, 235)
        Me.grpPersonaNatural.TabIndex = 2
        Me.grpPersonaNatural.TabStop = False
        Me.grpPersonaNatural.Text = "Informacion General"
        '
        'cmdEditarAlumno
        '
        Me.cmdEditarAlumno.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditarAlumno.Appearance.Options.UseFont = True
        Me.cmdEditarAlumno.ImageOptions.Image = Global.SIRA.My.Resources.Resources.edit16x16
        Me.cmdEditarAlumno.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEditarAlumno.Location = New System.Drawing.Point(516, 22)
        Me.cmdEditarAlumno.LookAndFeel.SkinName = "Caramel"
        Me.cmdEditarAlumno.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEditarAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEditarAlumno.Name = "cmdEditarAlumno"
        Me.cmdEditarAlumno.Size = New System.Drawing.Size(32, 28)
        Me.cmdEditarAlumno.TabIndex = 3
        Me.cmdEditarAlumno.Tag = "AGREGAR"
        '
        'cmdAddAlumno
        '
        Me.cmdAddAlumno.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddAlumno.Appearance.Options.UseFont = True
        Me.cmdAddAlumno.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAddAlumno.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAddAlumno.Location = New System.Drawing.Point(476, 22)
        Me.cmdAddAlumno.LookAndFeel.SkinName = "Caramel"
        Me.cmdAddAlumno.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAddAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAddAlumno.Name = "cmdAddAlumno"
        Me.cmdAddAlumno.Size = New System.Drawing.Size(32, 28)
        Me.cmdAddAlumno.TabIndex = 2
        Me.cmdAddAlumno.Tag = "AGREGAR"
        '
        'txtCodigoMined
        '
        Me.txtCodigoMined.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMined.Location = New System.Drawing.Point(200, 26)
        Me.txtCodigoMined.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoMined.Name = "txtCodigoMined"
        Me.txtCodigoMined.Size = New System.Drawing.Size(225, 23)
        Me.txtCodigoMined.TabIndex = 0
        Me.txtCodigoMined.Tag = "OBLIGATORIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Código MINED:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(439, 23)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 1
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
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
        Me.dtpFechaNacimiento.Enabled = False
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(200, 183)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(227, 23)
        Me.dtpFechaNacimiento.TabIndex = 8
        Me.dtpFechaNacimiento.Tag = Nothing
        Me.dtpFechaNacimiento.TrimStart = True
        Me.dtpFechaNacimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaNacimiento.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(200, 151)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoApellido.TabIndex = 7
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(200, 121)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerApellido.TabIndex = 6
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(200, 90)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoNombre.TabIndex = 5
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(200, 59)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerNombre.TabIndex = 4
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(13, 187)
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
        Me.lblSegundoApellido.ForeColor = System.Drawing.Color.Black
        Me.lblSegundoApellido.Location = New System.Drawing.Point(13, 158)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(139, 17)
        Me.lblSegundoApellido.TabIndex = 12
        Me.lblSegundoApellido.Text = "Segundo apellido:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.ForeColor = System.Drawing.Color.Black
        Me.lblPrimerApellido.Location = New System.Drawing.Point(13, 127)
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
        Me.lblPrimerNombre.ForeColor = System.Drawing.Color.Black
        Me.lblPrimerNombre.Location = New System.Drawing.Point(13, 65)
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
        Me.lblSegundoNombre.ForeColor = System.Drawing.Color.Black
        Me.lblSegundoNombre.Location = New System.Drawing.Point(13, 96)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(1016, 586)
        Me.panelcliente.TabIndex = 27
        '
        'OFDFoto
        '
        Me.OFDFoto.FileName = "OpenFileDialog1"
        '
        'frmSraMatriculaEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 586)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraMatriculaEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matrícula"
        Me.grpDatos.ResumeLayout(False)
        CType(Me.PBFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtFechaIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFechaMatricula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoMatricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonaNatural.ResumeLayout(False)
        Me.grpPersonaNatural.PerformLayout()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonaNatural As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents panelcliente As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCodigoMined As System.Windows.Forms.TextBox
    Friend WithEvents txtRecomendaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoMatricula As C1.Win.C1List.C1Combo
    Friend WithEvents cmdAddAlumno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNumRecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEscuelaProcedencia As System.Windows.Forms.TextBox
    Friend WithEvents cmbBeca As C1.Win.C1List.C1Combo
    Friend WithEvents cmbModalidad As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEditarAlumno As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PBFoto As System.Windows.Forms.PictureBox
    Friend WithEvents cmdCargarFoto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents OFDFoto As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbPeriodos As C1.Win.C1List.C1Combo
    Friend WithEvents cmdTomar As DevExpress.XtraEditors.SimpleButton
    Public WithEvents dtFechaMatricula As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents dtFechaIngreso As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label12 As Label
    Friend WithEvents chkIngresoPosterior As CheckBox
End Class
