<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditMora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditMora))
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.cmbBeca = New C1.Win.C1List.C1Combo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.grpNotaDebito = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New C1.Win.C1List.C1Combo()
        Me.numMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpNotaDebito.SuspendLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.txtGrupo)
        Me.GrpExpediente.Controls.Add(Me.txtDireccion)
        Me.GrpExpediente.Controls.Add(Me.lblCedula)
        Me.GrpExpediente.Controls.Add(Me.lblDireccion)
        Me.GrpExpediente.Controls.Add(Me.cmbBeca)
        Me.GrpExpediente.Controls.Add(Me.Label7)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.Label11)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpExpediente.Location = New System.Drawing.Point(16, 54)
        Me.GrpExpediente.Margin = New System.Windows.Forms.Padding(4)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Padding = New System.Windows.Forms.Padding(4)
        Me.GrpExpediente.Size = New System.Drawing.Size(505, 198)
        Me.GrpExpediente.TabIndex = 24
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Expediente"
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.Location = New System.Drawing.Point(119, 123)
        Me.txtGrupo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(229, 23)
        Me.txtGrupo.TabIndex = 3
        Me.txtGrupo.Tag = "BLOQUEADO"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(119, 91)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(365, 23)
        Me.txtDireccion.TabIndex = 2
        Me.txtDireccion.Tag = "BLOQUEADO"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.ForeColor = System.Drawing.Color.Black
        Me.lblCedula.Location = New System.Drawing.Point(27, 127)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(58, 17)
        Me.lblCedula.TabIndex = 115
        Me.lblCedula.Text = "Grupo:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.ForeColor = System.Drawing.Color.Black
        Me.lblDireccion.Location = New System.Drawing.Point(27, 96)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(81, 17)
        Me.lblDireccion.TabIndex = 113
        Me.lblDireccion.Text = "Dirección:"
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
        Me.cmbBeca.Location = New System.Drawing.Point(119, 156)
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
        Me.cmbBeca.TabIndex = 4
        Me.cmbBeca.Tag = "OBLIGATORIO"
        Me.cmbBeca.PropBag = resources.GetString("cmbBeca.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(25, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 110
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Beca:"
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(119, 59)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(365, 23)
        Me.txtCliente.TabIndex = 1
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(25, 63)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Alumno:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.Location = New System.Drawing.Point(119, 26)
        Me.txtNumCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(216, 23)
        Me.txtNumCuenta.TabIndex = 0
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(25, 30)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "No. Exp:"
        '
        'grpNotaDebito
        '
        Me.grpNotaDebito.Controls.Add(Me.cmbEstado)
        Me.grpNotaDebito.Controls.Add(Me.numMonto)
        Me.grpNotaDebito.Controls.Add(Me.lblMonto)
        Me.grpNotaDebito.Controls.Add(Me.txtDescripcion)
        Me.grpNotaDebito.Controls.Add(Me.lblDescripcion)
        Me.grpNotaDebito.Controls.Add(Me.txtNumero)
        Me.grpNotaDebito.Controls.Add(Me.lblNumero)
        Me.grpNotaDebito.Controls.Add(Me.lblEstado)
        Me.grpNotaDebito.Controls.Add(Me.dtpFecha)
        Me.grpNotaDebito.Controls.Add(Me.lblFecha)
        Me.grpNotaDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNotaDebito.Location = New System.Drawing.Point(541, 14)
        Me.grpNotaDebito.Margin = New System.Windows.Forms.Padding(4)
        Me.grpNotaDebito.Name = "grpNotaDebito"
        Me.grpNotaDebito.Padding = New System.Windows.Forms.Padding(4)
        Me.grpNotaDebito.Size = New System.Drawing.Size(403, 270)
        Me.grpNotaDebito.TabIndex = 23
        Me.grpNotaDebito.TabStop = False
        Me.grpNotaDebito.Text = "Datos Mora"
        '
        'cmbEstado
        '
        Me.cmbEstado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstado.AutoCompletion = True
        Me.cmbEstado.AutoDropDown = True
        Me.cmbEstado.Caption = ""
        Me.cmbEstado.CaptionHeight = 17
        Me.cmbEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstado.ColumnCaptionHeight = 17
        Me.cmbEstado.ColumnFooterHeight = 17
        Me.cmbEstado.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbEstado.ContentHeight = 18
        Me.cmbEstado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstado.DropDownWidth = 250
        Me.cmbEstado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstado.EditorHeight = 18
        Me.cmbEstado.Enabled = False
        Me.cmbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstado.Images.Add(CType(resources.GetObject("cmbEstado.Images"), System.Drawing.Image))
        Me.cmbEstado.ItemHeight = 15
        Me.cmbEstado.LimitToList = True
        Me.cmbEstado.Location = New System.Drawing.Point(112, 225)
        Me.cmbEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstado.MaxDropDownItems = CType(5, Short)
        Me.cmbEstado.MaxLength = 32767
        Me.cmbEstado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstado.Size = New System.Drawing.Size(251, 24)
        Me.cmbEstado.TabIndex = 4
        Me.cmbEstado.Tag = "BLOQUEADO"
        Me.cmbEstado.PropBag = resources.GetString("cmbEstado.PropBag")
        '
        'numMonto
        '
        Me.numMonto.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMonto.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.numMonto.ErrorInfo.ShowErrorMessage = False
        Me.numMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMonto.Location = New System.Drawing.Point(112, 193)
        Me.numMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.numMonto.Name = "numMonto"
        Me.numMonto.Size = New System.Drawing.Size(251, 23)
        Me.numMonto.TabIndex = 3
        Me.numMonto.Tag = Nothing
        Me.numMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.numMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.ForeColor = System.Drawing.Color.Black
        Me.lblMonto.Location = New System.Drawing.Point(15, 197)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(57, 17)
        Me.lblMonto.TabIndex = 76
        Me.lblMonto.Tag = "OBLIGATORIO"
        Me.lblMonto.Text = "Monto:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 87)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(268, 98)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.Tag = ""
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(9, 91)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(98, 17)
        Me.lblDescripcion.TabIndex = 74
        Me.lblDescripcion.Tag = ""
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(112, 23)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(249, 23)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.Tag = "BLOQUEADO"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.ForeColor = System.Drawing.Color.Black
        Me.lblNumero.Location = New System.Drawing.Point(15, 28)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(37, 17)
        Me.lblNumero.TabIndex = 70
        Me.lblNumero.Tag = "OBLIGATORIO"
        Me.lblNumero.Text = "Mes"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(15, 235)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(63, 17)
        Me.lblEstado.TabIndex = 68
        Me.lblEstado.Tag = ""
        Me.lblEstado.Text = "Estado:"
        '
        'dtpFecha
        '
        '
        '
        '
        Me.dtpFecha.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.ClearText = "&Clear"
        Me.dtpFecha.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(112, 55)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(251, 23)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Location = New System.Drawing.Point(8, 59)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 17)
        Me.lblFecha.TabIndex = 64
        Me.lblFecha.Tag = "OBLIGATORIO"
        Me.lblFecha.Text = "Fecha:"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 338)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(975, 26)
        Me.Panel2.TabIndex = 100
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.grpNotaDebito)
        Me.PanelControl1.Controls.Add(Me.GrpExpediente)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(975, 364)
        Me.PanelControl1.TabIndex = 101
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(845, 290)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(728, 290)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSccEditMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 364)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccEditMora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Mora"
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        CType(Me.cmbBeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpNotaDebito.ResumeLayout(False)
        Me.grpNotaDebito.PerformLayout()
        CType(Me.cmbEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grpNotaDebito As System.Windows.Forms.GroupBox
    Friend WithEvents cmbEstado As C1.Win.C1List.C1Combo
    Friend WithEvents numMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbBeca As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
End Class
