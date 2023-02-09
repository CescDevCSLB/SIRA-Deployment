<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccDepositosEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccDepositosEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.dtpFechaArqueo = New DevExpress.XtraEditors.DateEdit()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.lblContabilizar = New System.Windows.Forms.Label()
        Me.numNontoarqueo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvoucher = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grdGradosA = New DevExpress.XtraGrid.GridControl()
        Me.grdGradosATable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVoucher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjCuentaContableID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoAcreditar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBanco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.cmbProfesorGuia = New C1.Win.C1List.C1Combo()
        Me.cmbSeccion = New C1.Win.C1List.C1Combo()
        Me.cmbGrado = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.cmbciudad = New C1.Win.C1List.C1Combo()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.grpDatos.SuspendLayout()
        CType(Me.dtpFechaArqueo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaArqueo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProfesorGuia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.dtpFechaArqueo)
        Me.grpDatos.Controls.Add(Me.dtpFecha)
        Me.grpDatos.Controls.Add(Me.Label13)
        Me.grpDatos.Controls.Add(Me.txtDescripcion)
        Me.grpDatos.Controls.Add(Me.lblContabilizar)
        Me.grpDatos.Controls.Add(Me.numNontoarqueo)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.grdGradosA)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 5)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(1117, 598)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'dtpFechaArqueo
        '
        Me.dtpFechaArqueo.EditValue = Nothing
        Me.dtpFechaArqueo.Location = New System.Drawing.Point(181, 23)
        Me.dtpFechaArqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaArqueo.Name = "dtpFechaArqueo"
        Me.dtpFechaArqueo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaArqueo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFechaArqueo.Size = New System.Drawing.Size(236, 22)
        Me.dtpFechaArqueo.TabIndex = 198
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
        Me.dtpFecha.Calendar.SelectedDate = New Date(2016, 10, 3, 0, 0, 0, 0)
        Me.dtpFecha.Calendar.TodayText = "&Today"
        Me.dtpFecha.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFecha.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(181, 91)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(196, 23)
        Me.dtpFecha.TabIndex = 195
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 95)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 17)
        Me.Label13.TabIndex = 196
        Me.Label13.Tag = "OBLIGATORIO"
        Me.Label13.Text = "Fecha deposito:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(647, 38)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(439, 59)
        Me.txtDescripcion.TabIndex = 192
        '
        'lblContabilizar
        '
        Me.lblContabilizar.AutoSize = True
        Me.lblContabilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContabilizar.ForeColor = System.Drawing.Color.Black
        Me.lblContabilizar.Location = New System.Drawing.Point(23, 62)
        Me.lblContabilizar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContabilizar.Name = "lblContabilizar"
        Me.lblContabilizar.Size = New System.Drawing.Size(144, 17)
        Me.lblContabilizar.TabIndex = 191
        Me.lblContabilizar.Text = "Monto a depositar:"
        '
        'numNontoarqueo
        '
        Me.numNontoarqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNontoarqueo.Location = New System.Drawing.Point(181, 58)
        Me.numNontoarqueo.Margin = New System.Windows.Forms.Padding(4)
        Me.numNontoarqueo.Name = "numNontoarqueo"
        Me.numNontoarqueo.ReadOnly = True
        Me.numNontoarqueo.Size = New System.Drawing.Size(127, 23)
        Me.numNontoarqueo.TabIndex = 190
        Me.numNontoarqueo.Tag = "BLOQUEADO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtvoucher)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBanco)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.numMonto)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbMoeda)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.cmdEliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 133)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1075, 143)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar"
        '
        'txtvoucher
        '
        Me.txtvoucher.Location = New System.Drawing.Point(792, 68)
        Me.txtvoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvoucher.Name = "txtvoucher"
        Me.txtvoucher.Size = New System.Drawing.Size(265, 23)
        Me.txtvoucher.TabIndex = 185
        Me.txtvoucher.TabStop = False
        Me.txtvoucher.Tag = "BLOQUEADO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(705, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 17)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "Voucher:"
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(155, 95)
        Me.txtBanco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(265, 23)
        Me.txtBanco.TabIndex = 183
        Me.txtBanco.TabStop = False
        Me.txtBanco.Tag = "BLOQUEADO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 182
        Me.Label7.Text = "Banco:"
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(155, 63)
        Me.txtCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(441, 23)
        Me.txtCuenta.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 68)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Cuenta contable:"
        '
        'numMonto
        '
        Me.numMonto.BackColor = System.Drawing.Color.Transparent
        Me.numMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMonto.Location = New System.Drawing.Point(792, 34)
        Me.numMonto.Margin = New System.Windows.Forms.Padding(4)
        Me.numMonto.Name = "numMonto"
        Me.numMonto.Size = New System.Drawing.Size(196, 23)
        Me.numMonto.TabIndex = 166
        Me.numMonto.Tag = Nothing
        Me.numMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMonto.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(605, 62)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 167
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 34)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 17)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Moneda:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(705, 34)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "Monto:"
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
        Me.cmbMoeda.Location = New System.Drawing.Point(155, 30)
        Me.cmbMoeda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMoeda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoeda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoeda.MaxLength = 32767
        Me.cmbMoeda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoeda.Name = "cmbMoeda"
        Me.cmbMoeda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoeda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoeda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoeda.Size = New System.Drawing.Size(267, 24)
        Me.cmbMoeda.TabIndex = 180
        Me.cmbMoeda.Tag = "OBLIGATORIO"
        Me.cmbMoeda.PropBag = resources.GetString("cmbMoeda.PropBag")
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(965, 106)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 125
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdEliminar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(1016, 105)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminar.TabIndex = 126
        Me.cmdEliminar.Tag = "AGREGAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(477, 41)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 17)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Descripcion:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(24, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 156
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Fecha arqueo:"
        '
        'grdGradosA
        '
        Me.grdGradosA.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Location = New System.Drawing.Point(11, 287)
        Me.grdGradosA.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGradosA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGradosA.MainView = Me.grdGradosATable
        Me.grdGradosA.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Name = "grdGradosA"
        Me.grdGradosA.Size = New System.Drawing.Size(1075, 224)
        Me.grdGradosA.TabIndex = 124
        Me.grdGradosA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGradosATable, Me.GridView3})
        '
        'grdGradosATable
        '
        Me.grdGradosATable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVoucher, Me.colobjCuentaContableID, Me.colIDCuenta, Me.colDescripcion, Me.colMontoAcreditar, Me.colMoneda, Me.colBanco})
        Me.grdGradosATable.GridControl = Me.grdGradosA
        Me.grdGradosATable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGradosATable.Name = "grdGradosATable"
        Me.grdGradosATable.OptionsSelection.MultiSelect = True
        Me.grdGradosATable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdGradosATable.OptionsView.ShowAutoFilterRow = True
        Me.grdGradosATable.OptionsView.ShowGroupPanel = False
        '
        'colVoucher
        '
        Me.colVoucher.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colVoucher.AppearanceHeader.Options.UseFont = True
        Me.colVoucher.AppearanceHeader.Options.UseTextOptions = True
        Me.colVoucher.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colVoucher.Caption = "Voucher"
        Me.colVoucher.FieldName = "Voucher"
        Me.colVoucher.Name = "colVoucher"
        Me.colVoucher.OptionsColumn.AllowEdit = False
        Me.colVoucher.Visible = True
        Me.colVoucher.VisibleIndex = 4
        Me.colVoucher.Width = 81
        '
        'colobjCuentaContableID
        '
        Me.colobjCuentaContableID.Caption = "objCuentaContableID"
        Me.colobjCuentaContableID.FieldName = "objCuentaContableID"
        Me.colobjCuentaContableID.Name = "colobjCuentaContableID"
        '
        'colIDCuenta
        '
        Me.colIDCuenta.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colIDCuenta.AppearanceCell.Options.UseBackColor = True
        Me.colIDCuenta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colIDCuenta.AppearanceHeader.Options.UseFont = True
        Me.colIDCuenta.AppearanceHeader.Options.UseTextOptions = True
        Me.colIDCuenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIDCuenta.Caption = "Codigo"
        Me.colIDCuenta.FieldName = "IDCuenta"
        Me.colIDCuenta.Name = "colIDCuenta"
        Me.colIDCuenta.OptionsColumn.AllowEdit = False
        Me.colIDCuenta.OptionsColumn.AllowFocus = False
        Me.colIDCuenta.OptionsColumn.ReadOnly = True
        Me.colIDCuenta.Visible = True
        Me.colIDCuenta.VisibleIndex = 1
        Me.colIDCuenta.Width = 73
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Cuenta "
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 246
        '
        'colMontoAcreditar
        '
        Me.colMontoAcreditar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoAcreditar.AppearanceHeader.Options.UseFont = True
        Me.colMontoAcreditar.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoAcreditar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoAcreditar.Caption = "Monto"
        Me.colMontoAcreditar.FieldName = "Monto"
        Me.colMontoAcreditar.Name = "colMontoAcreditar"
        Me.colMontoAcreditar.OptionsColumn.AllowEdit = False
        Me.colMontoAcreditar.Visible = True
        Me.colMontoAcreditar.VisibleIndex = 6
        Me.colMontoAcreditar.Width = 105
        '
        'colMoneda
        '
        Me.colMoneda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMoneda.AppearanceHeader.Options.UseFont = True
        Me.colMoneda.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoneda.Caption = "Moneda"
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.OptionsColumn.AllowEdit = False
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 5
        Me.colMoneda.Width = 111
        '
        'colBanco
        '
        Me.colBanco.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBanco.AppearanceHeader.Options.UseFont = True
        Me.colBanco.AppearanceHeader.Options.UseTextOptions = True
        Me.colBanco.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBanco.Caption = "Banco"
        Me.colBanco.FieldName = "Banco"
        Me.colBanco.Name = "colBanco"
        Me.colBanco.OptionsColumn.AllowEdit = False
        Me.colBanco.Visible = True
        Me.colBanco.VisibleIndex = 3
        Me.colBanco.Width = 122
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.GridControl = Me.grdGradosA
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "SccCuentaID"
        Me.GridColumn5.FieldName = "SccCuentaID"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Producto"
        Me.GridColumn6.FieldName = "Producto"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Modelo/Marca"
        Me.GridColumn7.FieldName = "ModeloMarca"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Saldo"
        Me.GridColumn8.FieldName = "Saldo"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(981, 523)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(867, 523)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
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
        Me.cmbPeriodo.Location = New System.Drawing.Point(92, 22)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.ReadOnly = True
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(154, 24)
        Me.cmbPeriodo.TabIndex = 118
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'cmbProfesorGuia
        '
        Me.cmbProfesorGuia.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProfesorGuia.AutoCompletion = True
        Me.cmbProfesorGuia.AutoDropDown = True
        Me.cmbProfesorGuia.Caption = ""
        Me.cmbProfesorGuia.CaptionHeight = 17
        Me.cmbProfesorGuia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProfesorGuia.ColumnCaptionHeight = 17
        Me.cmbProfesorGuia.ColumnFooterHeight = 17
        Me.cmbProfesorGuia.ContentHeight = 18
        Me.cmbProfesorGuia.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProfesorGuia.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesorGuia.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesorGuia.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProfesorGuia.EditorHeight = 18
        Me.cmbProfesorGuia.Images.Add(CType(resources.GetObject("cmbProfesorGuia.Images"), System.Drawing.Image))
        Me.cmbProfesorGuia.ItemHeight = 15
        Me.cmbProfesorGuia.Location = New System.Drawing.Point(364, 46)
        Me.cmbProfesorGuia.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProfesorGuia.MaxDropDownItems = CType(5, Short)
        Me.cmbProfesorGuia.MaxLength = 32767
        Me.cmbProfesorGuia.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProfesorGuia.Name = "cmbProfesorGuia"
        Me.cmbProfesorGuia.ReadOnly = True
        Me.cmbProfesorGuia.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProfesorGuia.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProfesorGuia.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProfesorGuia.Size = New System.Drawing.Size(235, 24)
        Me.cmbProfesorGuia.TabIndex = 116
        Me.cmbProfesorGuia.Tag = "OBLIGATORIO"
        Me.cmbProfesorGuia.PropBag = resources.GetString("cmbProfesorGuia.PropBag")
        '
        'cmbSeccion
        '
        Me.cmbSeccion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSeccion.AutoCompletion = True
        Me.cmbSeccion.AutoDropDown = True
        Me.cmbSeccion.Caption = ""
        Me.cmbSeccion.CaptionHeight = 17
        Me.cmbSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSeccion.ColumnCaptionHeight = 17
        Me.cmbSeccion.ColumnFooterHeight = 17
        Me.cmbSeccion.ContentHeight = 18
        Me.cmbSeccion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSeccion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSeccion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeccion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSeccion.EditorHeight = 18
        Me.cmbSeccion.Images.Add(CType(resources.GetObject("cmbSeccion.Images"), System.Drawing.Image))
        Me.cmbSeccion.ItemHeight = 15
        Me.cmbSeccion.Location = New System.Drawing.Point(364, 19)
        Me.cmbSeccion.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSeccion.MaxDropDownItems = CType(5, Short)
        Me.cmbSeccion.MaxLength = 32767
        Me.cmbSeccion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSeccion.Name = "cmbSeccion"
        Me.cmbSeccion.ReadOnly = True
        Me.cmbSeccion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSeccion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSeccion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSeccion.Size = New System.Drawing.Size(154, 24)
        Me.cmbSeccion.TabIndex = 115
        Me.cmbSeccion.Tag = "OBLIGATORIO"
        Me.cmbSeccion.PropBag = resources.GetString("cmbSeccion.PropBag")
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
        Me.cmbGrado.Location = New System.Drawing.Point(92, 49)
        Me.cmbGrado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGrado.MaxDropDownItems = CType(5, Short)
        Me.cmbGrado.MaxLength = 32767
        Me.cmbGrado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.ReadOnly = True
        Me.cmbGrado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGrado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGrado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGrado.Size = New System.Drawing.Size(154, 24)
        Me.cmbGrado.TabIndex = 114
        Me.cmbGrado.Tag = "OBLIGATORIO"
        Me.cmbGrado.PropBag = resources.GetString("cmbGrado.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 110
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 108
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(275, 22)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(57, 13)
        Me.lblSfaPromocionID.TabIndex = 0
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
        Me.cmbciudad.Location = New System.Drawing.Point(142, 16)
        Me.cmbciudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbciudad.MaxDropDownItems = CType(5, Short)
        Me.cmbciudad.MaxLength = 32767
        Me.cmbciudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbciudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbciudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbciudad.Size = New System.Drawing.Size(229, 24)
        Me.cmbciudad.TabIndex = 0
        Me.cmbciudad.Tag = "OBLIGATORIO"
        Me.cmbciudad.PropBag = resources.GetString("cmbciudad.PropBag")
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(142, 43)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(328, 57)
        Me.txtDireccion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 17
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 576)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1133, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(1133, 596)
        Me.panelcliente.TabIndex = 27
        '
        'frmSccDepositosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccDepositosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposito"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.dtpFechaArqueo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaArqueo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProfesorGuia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelcliente As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbciudad As C1.Win.C1List.C1Combo
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents cmbProfesorGuia As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSeccion As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdGradosA As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGradosATable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colobjCuentaContableID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoAcreditar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents numMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents colBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblContabilizar As Label
    Friend WithEvents numNontoarqueo As TextBox
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colVoucher As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvoucher As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBanco As TextBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaArqueo As DevExpress.XtraEditors.DateEdit
End Class
