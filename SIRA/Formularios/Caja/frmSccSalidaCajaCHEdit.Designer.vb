<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccSalidaCajaCHEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccSalidaCajaCHEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbCentroCosto = New C1.Win.C1List.C1Combo()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDispoible = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbCajero = New C1.Win.C1List.C1Combo()
        Me.txtTasaCambio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbConceptoRecibo = New C1.Win.C1List.C1Combo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NumDisponible = New C1.Win.C1Input.C1NumericEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConceptoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Size = New System.Drawing.Size(949, 421)
        Me.PanelControl1.TabIndex = 98
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 393)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(945, 26)
        Me.Panel1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(807, 343)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(688, 343)
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
        Me.gbxDatosGenerales.Controls.Add(Me.Label19)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCentroCosto)
        Me.gbxDatosGenerales.Controls.Add(Me.txtBeneficiario)
        Me.gbxDatosGenerales.Controls.Add(Me.Label4)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.dtpFecha)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.txtDispoible)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.Label8)
        Me.gbxDatosGenerales.Controls.Add(Me.txtEstado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label15)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCajero)
        Me.gbxDatosGenerales.Controls.Add(Me.txtTasaCambio)
        Me.gbxDatosGenerales.Controls.Add(Me.Label13)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbConceptoRecibo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label11)
        Me.gbxDatosGenerales.Controls.Add(Me.NumDisponible)
        Me.gbxDatosGenerales.Controls.Add(Me.Label7)
        Me.gbxDatosGenerales.Controls.Add(Me.Label14)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbMoeda)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 2)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(916, 334)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(1, 206)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 185
        Me.Label19.Text = "Centro de costo:"
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCentroCosto.AutoCompletion = True
        Me.cmbCentroCosto.AutoDropDown = True
        Me.cmbCentroCosto.Caption = ""
        Me.cmbCentroCosto.CaptionHeight = 17
        Me.cmbCentroCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCentroCosto.ColumnCaptionHeight = 17
        Me.cmbCentroCosto.ColumnFooterHeight = 17
        Me.cmbCentroCosto.ContentHeight = 18
        Me.cmbCentroCosto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCentroCosto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCentroCosto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCentroCosto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCentroCosto.EditorHeight = 18
        Me.cmbCentroCosto.Images.Add(CType(resources.GetObject("cmbCentroCosto.Images"), System.Drawing.Image))
        Me.cmbCentroCosto.ItemHeight = 15
        Me.cmbCentroCosto.Location = New System.Drawing.Point(153, 199)
        Me.cmbCentroCosto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCentroCosto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCentroCosto.MaxDropDownItems = CType(5, Short)
        Me.cmbCentroCosto.MaxLength = 32767
        Me.cmbCentroCosto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCentroCosto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.Size = New System.Drawing.Size(267, 24)
        Me.cmbCentroCosto.TabIndex = 184
        Me.cmbCentroCosto.Tag = "OBLIGATORIO"
        Me.cmbCentroCosto.PropBag = resources.GetString("cmbCentroCosto.PropBag")
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Location = New System.Drawing.Point(153, 165)
        Me.txtBeneficiario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(736, 23)
        Me.txtBeneficiario.TabIndex = 160
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(1, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Beneficiario:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(153, 242)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(720, 71)
        Me.txtDescripcion.TabIndex = 156
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1, 244)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Descripción:"
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
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFecha.Location = New System.Drawing.Point(695, 129)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(196, 23)
        Me.dtpFecha.TabIndex = 7
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(540, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 154
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Fecha:"
        '
        'txtDispoible
        '
        Me.txtDispoible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispoible.Location = New System.Drawing.Point(695, 25)
        Me.txtDispoible.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDispoible.Name = "txtDispoible"
        Me.txtDispoible.ReadOnly = True
        Me.txtDispoible.Size = New System.Drawing.Size(124, 23)
        Me.txtDispoible.TabIndex = 4
        Me.txtDispoible.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(540, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Disponible:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(1, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 150
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(153, 58)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(211, 23)
        Me.txtEstado.TabIndex = 1
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(0, 33)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 17)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Cajero(a):"
        '
        'cmbCajero
        '
        Me.cmbCajero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCajero.AutoCompletion = True
        Me.cmbCajero.AutoDropDown = True
        Me.cmbCajero.Caption = ""
        Me.cmbCajero.CaptionHeight = 17
        Me.cmbCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCajero.ColumnCaptionHeight = 17
        Me.cmbCajero.ColumnFooterHeight = 17
        Me.cmbCajero.ContentHeight = 18
        Me.cmbCajero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCajero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCajero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCajero.EditorHeight = 18
        Me.cmbCajero.Enabled = False
        Me.cmbCajero.Images.Add(CType(resources.GetObject("cmbCajero.Images"), System.Drawing.Image))
        Me.cmbCajero.ItemHeight = 15
        Me.cmbCajero.Location = New System.Drawing.Point(153, 25)
        Me.cmbCajero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCajero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCajero.MaxDropDownItems = CType(5, Short)
        Me.cmbCajero.MaxLength = 32767
        Me.cmbCajero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCajero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCajero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCajero.Size = New System.Drawing.Size(267, 24)
        Me.cmbCajero.TabIndex = 0
        Me.cmbCajero.Tag = "OBLIGATORIO"
        Me.cmbCajero.PropBag = resources.GetString("cmbCajero.PropBag")
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaCambio.Location = New System.Drawing.Point(695, 60)
        Me.txtTasaCambio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.ReadOnly = True
        Me.txtTasaCambio.Size = New System.Drawing.Size(124, 23)
        Me.txtTasaCambio.TabIndex = 5
        Me.txtTasaCambio.Tag = "BLOQUEADO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(540, 64)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 17)
        Me.Label13.TabIndex = 146
        Me.Label13.Text = "Tasa de cambio:"
        '
        'cmbConceptoRecibo
        '
        Me.cmbConceptoRecibo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbConceptoRecibo.AutoCompletion = True
        Me.cmbConceptoRecibo.AutoDropDown = True
        Me.cmbConceptoRecibo.Caption = ""
        Me.cmbConceptoRecibo.CaptionHeight = 17
        Me.cmbConceptoRecibo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbConceptoRecibo.ColumnCaptionHeight = 17
        Me.cmbConceptoRecibo.ColumnFooterHeight = 17
        Me.cmbConceptoRecibo.ContentHeight = 18
        Me.cmbConceptoRecibo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConceptoRecibo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConceptoRecibo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConceptoRecibo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConceptoRecibo.EditorHeight = 18
        Me.cmbConceptoRecibo.Images.Add(CType(resources.GetObject("cmbConceptoRecibo.Images"), System.Drawing.Image))
        Me.cmbConceptoRecibo.ItemHeight = 15
        Me.cmbConceptoRecibo.Location = New System.Drawing.Point(153, 94)
        Me.cmbConceptoRecibo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbConceptoRecibo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConceptoRecibo.MaxDropDownItems = CType(5, Short)
        Me.cmbConceptoRecibo.MaxLength = 32767
        Me.cmbConceptoRecibo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConceptoRecibo.Name = "cmbConceptoRecibo"
        Me.cmbConceptoRecibo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConceptoRecibo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConceptoRecibo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConceptoRecibo.Size = New System.Drawing.Size(267, 24)
        Me.cmbConceptoRecibo.TabIndex = 2
        Me.cmbConceptoRecibo.Tag = "OBLIGATORIO"
        Me.cmbConceptoRecibo.PropBag = resources.GetString("cmbConceptoRecibo.PropBag")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1, 100)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 17)
        Me.Label11.TabIndex = 143
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Concepto:"
        '
        'NumDisponible
        '
        Me.NumDisponible.BackColor = System.Drawing.Color.Transparent
        Me.NumDisponible.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumDisponible.Location = New System.Drawing.Point(695, 92)
        Me.NumDisponible.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumDisponible.Name = "NumDisponible"
        Me.NumDisponible.Size = New System.Drawing.Size(196, 23)
        Me.NumDisponible.TabIndex = 6
        Me.NumDisponible.Tag = Nothing
        Me.NumDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumDisponible.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumDisponible.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(540, 100)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Monto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(0, 133)
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
        Me.cmbMoeda.Enabled = False
        Me.cmbMoeda.Images.Add(CType(resources.GetObject("cmbMoeda.Images"), System.Drawing.Image))
        Me.cmbMoeda.ItemHeight = 15
        Me.cmbMoeda.Location = New System.Drawing.Point(153, 127)
        Me.cmbMoeda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbMoeda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoeda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoeda.MaxLength = 32767
        Me.cmbMoeda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoeda.Name = "cmbMoeda"
        Me.cmbMoeda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoeda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoeda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoeda.Size = New System.Drawing.Size(267, 24)
        Me.cmbMoeda.TabIndex = 3
        Me.cmbMoeda.Tag = "OBLIGATORIO"
        Me.cmbMoeda.PropBag = resources.GetString("cmbMoeda.PropBag")
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccSalidaCajaCHEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 421)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccSalidaCajaCHEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida - caja chica"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConceptoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDisponible, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents NumDisponible As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbConceptoRecibo As C1.Win.C1List.C1Combo
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTasaCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbCajero As C1.Win.C1List.C1Combo
    Friend WithEvents txtDispoible As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBeneficiario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbCentroCosto As C1.Win.C1List.C1Combo
End Class
