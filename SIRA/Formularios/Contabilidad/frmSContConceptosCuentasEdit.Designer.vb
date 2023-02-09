<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSContConceptosCuentasEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContConceptosCuentasEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.rbRecibosCajaChica = New System.Windows.Forms.RadioButton()
        Me.rbRecibosCaja = New System.Windows.Forms.RadioButton()
        Me.txtContraCuenta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdBuscarContracuenta = New System.Windows.Forms.Button()
        Me.cmbCentroCosto = New C1.Win.C1List.C1Combo()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbConcepto = New C1.Win.C1List.C1Combo()
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
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpDatos.Controls.Add(Me.rbRecibosCajaChica)
        Me.grpDatos.Controls.Add(Me.rbRecibosCaja)
        Me.grpDatos.Controls.Add(Me.txtContraCuenta)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.cmdBuscarContracuenta)
        Me.grpDatos.Controls.Add(Me.cmbCentroCosto)
        Me.grpDatos.Controls.Add(Me.txtCuenta)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.Label19)
        Me.grpDatos.Controls.Add(Me.cmdBuscar)
        Me.grpDatos.Controls.Add(Me.Label11)
        Me.grpDatos.Controls.Add(Me.cmbConcepto)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 5)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(784, 210)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'rbRecibosCajaChica
        '
        Me.rbRecibosCajaChica.AutoSize = True
        Me.rbRecibosCajaChica.Location = New System.Drawing.Point(543, 41)
        Me.rbRecibosCajaChica.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRecibosCajaChica.Name = "rbRecibosCajaChica"
        Me.rbRecibosCajaChica.Size = New System.Drawing.Size(188, 21)
        Me.rbRecibosCajaChica.TabIndex = 188
        Me.rbRecibosCajaChica.Text = "Recibos de caja chica"
        Me.rbRecibosCajaChica.UseVisualStyleBackColor = True
        '
        'rbRecibosCaja
        '
        Me.rbRecibosCaja.AutoSize = True
        Me.rbRecibosCaja.Location = New System.Drawing.Point(543, 11)
        Me.rbRecibosCaja.Margin = New System.Windows.Forms.Padding(4)
        Me.rbRecibosCaja.Name = "rbRecibosCaja"
        Me.rbRecibosCaja.Size = New System.Drawing.Size(205, 21)
        Me.rbRecibosCaja.TabIndex = 187
        Me.rbRecibosCaja.Text = "Recibos de caja general"
        Me.rbRecibosCaja.UseVisualStyleBackColor = True
        '
        'txtContraCuenta
        '
        Me.txtContraCuenta.Location = New System.Drawing.Point(216, 108)
        Me.txtContraCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraCuenta.Name = "txtContraCuenta"
        Me.txtContraCuenta.Size = New System.Drawing.Size(441, 23)
        Me.txtContraCuenta.TabIndex = 184
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 17)
        Me.Label7.TabIndex = 185
        Me.Label7.Text = "Contra cuenta:"
        '
        'cmdBuscarContracuenta
        '
        Me.cmdBuscarContracuenta.Location = New System.Drawing.Point(667, 107)
        Me.cmdBuscarContracuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarContracuenta.Name = "cmdBuscarContracuenta"
        Me.cmdBuscarContracuenta.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscarContracuenta.TabIndex = 186
        Me.cmdBuscarContracuenta.Tag = "Buscar Existente"
        Me.cmdBuscarContracuenta.Text = "..."
        Me.cmdBuscarContracuenta.UseVisualStyleBackColor = True
        '
        'cmbCentroCosto
        '
        Me.cmbCentroCosto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCentroCosto.AutoCompletion = True
        Me.cmbCentroCosto.AutoDropDown = True
        Me.cmbCentroCosto.AutoSelect = True
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
        Me.cmbCentroCosto.Location = New System.Drawing.Point(216, 43)
        Me.cmbCentroCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCentroCosto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCentroCosto.MaxDropDownItems = CType(5, Short)
        Me.cmbCentroCosto.MaxLength = 32767
        Me.cmbCentroCosto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCentroCosto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.Size = New System.Drawing.Size(267, 24)
        Me.cmbCentroCosto.TabIndex = 182
        Me.cmbCentroCosto.Tag = "OBLIGATORIO"
        Me.cmbCentroCosto.PropBag = resources.GetString("cmbCentroCosto.PropBag")
        '
        'txtCuenta
        '
        Me.txtCuenta.Location = New System.Drawing.Point(216, 76)
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
        Me.Label6.Location = New System.Drawing.Point(29, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 17)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Cuenta contable:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(29, 43)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(128, 17)
        Me.Label19.TabIndex = 183
        Me.Label19.Text = "Centro de costo:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(667, 75)
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
        Me.Label11.Location = New System.Drawing.Point(29, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 17)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Concepto de recibo:"
        '
        'cmbConcepto
        '
        Me.cmbConcepto.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbConcepto.AutoCompletion = True
        Me.cmbConcepto.AutoDropDown = True
        Me.cmbConcepto.Caption = ""
        Me.cmbConcepto.CaptionHeight = 17
        Me.cmbConcepto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbConcepto.ColumnCaptionHeight = 17
        Me.cmbConcepto.ColumnFooterHeight = 17
        Me.cmbConcepto.ContentHeight = 18
        Me.cmbConcepto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConcepto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConcepto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConcepto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConcepto.EditorHeight = 18
        Me.cmbConcepto.Images.Add(CType(resources.GetObject("cmbConcepto.Images"), System.Drawing.Image))
        Me.cmbConcepto.ItemHeight = 15
        Me.cmbConcepto.Location = New System.Drawing.Point(216, 10)
        Me.cmbConcepto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbConcepto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConcepto.MaxDropDownItems = CType(5, Short)
        Me.cmbConcepto.MaxLength = 32767
        Me.cmbConcepto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConcepto.Name = "cmbConcepto"
        Me.cmbConcepto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConcepto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConcepto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConcepto.Size = New System.Drawing.Size(267, 24)
        Me.cmbConcepto.TabIndex = 180
        Me.cmbConcepto.Tag = "OBLIGATORIO"
        Me.cmbConcepto.PropBag = resources.GetString("cmbConcepto.PropBag")
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(592, 156)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(477, 156)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 236)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(805, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(805, 256)
        Me.panelcliente.TabIndex = 27
        '
        'frmSContConceptosCuentasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 256)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSContConceptosCuentasEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concepto / Cuentas contables"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConcepto, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbConcepto As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbCentroCosto As C1.Win.C1List.C1Combo
    Friend WithEvents txtContraCuenta As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdBuscarContracuenta As Button
    Friend WithEvents rbRecibosCajaChica As RadioButton
    Friend WithEvents rbRecibosCaja As RadioButton
End Class
