<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScontComprobanteEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScontComprobanteEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.txtConcepto = New DevExpress.XtraEditors.MemoEdit()
        Me.lblContabilizar = New System.Windows.Forms.Label()
        Me.numNontoContabilizar = New System.Windows.Forms.TextBox()
        Me.cmbTipoAsiento = New C1.Win.C1List.C1Combo()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdProcesar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtTasaCambio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdCuentaContableAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbCentroCosto = New C1.Win.C1List.C1Combo()
        Me.chkCentro = New System.Windows.Forms.CheckBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numAcreditar = New C1.Win.C1Input.C1NumericEdit()
        Me.numDebitar = New C1.Win.C1Input.C1NumericEdit()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.numTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numCreditoT = New C1.Win.C1Input.C1NumericEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.numDebitoT = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNumCheque = New System.Windows.Forms.TextBox()
        Me.grdGradosA = New DevExpress.XtraGrid.GridControl()
        Me.grdGradosATable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colobjSContSubCuentasContablesID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoAcreditar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoDebitar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCentroCosto = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAcreditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDebitar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCreditoT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDebitoT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpDatos.Controls.Add(Me.txtConcepto)
        Me.grpDatos.Controls.Add(Me.lblContabilizar)
        Me.grpDatos.Controls.Add(Me.numNontoContabilizar)
        Me.grpDatos.Controls.Add(Me.cmbTipoAsiento)
        Me.grpDatos.Controls.Add(Me.Label22)
        Me.grpDatos.Controls.Add(Me.cmdProcesar)
        Me.grpDatos.Controls.Add(Me.Label21)
        Me.grpDatos.Controls.Add(Me.txtEstado)
        Me.grpDatos.Controls.Add(Me.txtTasaCambio)
        Me.grpDatos.Controls.Add(Me.Label20)
        Me.grpDatos.Controls.Add(Me.Label11)
        Me.grpDatos.Controls.Add(Me.cmbMoeda)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.numTotal)
        Me.grpDatos.Controls.Add(Me.Label17)
        Me.grpDatos.Controls.Add(Me.numCreditoT)
        Me.grpDatos.Controls.Add(Me.Label16)
        Me.grpDatos.Controls.Add(Me.numDebitoT)
        Me.grpDatos.Controls.Add(Me.Label15)
        Me.grpDatos.Controls.Add(Me.NumMonto)
        Me.grpDatos.Controls.Add(Me.Label12)
        Me.grpDatos.Controls.Add(Me.txtObservaciones)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.dtpFecha)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.txtNumCheque)
        Me.grpDatos.Controls.Add(Me.grdGradosA)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(5, 4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(902, 562)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(133, 97)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(351, 48)
        Me.txtConcepto.TabIndex = 192
        '
        'lblContabilizar
        '
        Me.lblContabilizar.AutoSize = True
        Me.lblContabilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContabilizar.ForeColor = System.Drawing.Color.Black
        Me.lblContabilizar.Location = New System.Drawing.Point(757, 78)
        Me.lblContabilizar.Name = "lblContabilizar"
        Me.lblContabilizar.Size = New System.Drawing.Size(126, 13)
        Me.lblContabilizar.TabIndex = 191
        Me.lblContabilizar.Text = "Monto a contabilizar:"
        '
        'numNontoContabilizar
        '
        Me.numNontoContabilizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNontoContabilizar.Location = New System.Drawing.Point(787, 101)
        Me.numNontoContabilizar.Name = "numNontoContabilizar"
        Me.numNontoContabilizar.ReadOnly = True
        Me.numNontoContabilizar.Size = New System.Drawing.Size(96, 20)
        Me.numNontoContabilizar.TabIndex = 190
        Me.numNontoContabilizar.Tag = "BLOQUEADO"
        '
        'cmbTipoAsiento
        '
        Me.cmbTipoAsiento.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoAsiento.AutoCompletion = True
        Me.cmbTipoAsiento.AutoDropDown = True
        Me.cmbTipoAsiento.Caption = ""
        Me.cmbTipoAsiento.CaptionHeight = 17
        Me.cmbTipoAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoAsiento.ColumnCaptionHeight = 17
        Me.cmbTipoAsiento.ColumnFooterHeight = 17
        Me.cmbTipoAsiento.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbTipoAsiento.ContentHeight = 15
        Me.cmbTipoAsiento.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoAsiento.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoAsiento.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAsiento.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoAsiento.EditorHeight = 15
        Me.cmbTipoAsiento.Images.Add(CType(resources.GetObject("cmbTipoAsiento.Images"), System.Drawing.Image))
        Me.cmbTipoAsiento.ItemHeight = 15
        Me.cmbTipoAsiento.Location = New System.Drawing.Point(595, 48)
        Me.cmbTipoAsiento.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoAsiento.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoAsiento.MaxLength = 32767
        Me.cmbTipoAsiento.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoAsiento.Name = "cmbTipoAsiento"
        Me.cmbTipoAsiento.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoAsiento.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoAsiento.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoAsiento.Size = New System.Drawing.Size(200, 21)
        Me.cmbTipoAsiento.TabIndex = 189
        Me.cmbTipoAsiento.Tag = "OBLIGATORIO"
        Me.cmbTipoAsiento.PropBag = resources.GetString("cmbTipoAsiento.PropBag")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(490, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 13)
        Me.Label22.TabIndex = 188
        Me.Label22.Text = "Tipo de asiento:"
        '
        'cmdProcesar
        '
        Me.cmdProcesar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcesar.Appearance.Options.UseFont = True
        Me.cmdProcesar.ImageOptions.Image = CType(resources.GetObject("cmdProcesar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdProcesar.Location = New System.Drawing.Point(688, 520)
        Me.cmdProcesar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdProcesar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdProcesar.Name = "cmdProcesar"
        Me.cmdProcesar.Size = New System.Drawing.Size(93, 28)
        Me.cmdProcesar.TabIndex = 186
        Me.cmdProcesar.Tag = "PROCESAR"
        Me.cmdProcesar.Text = "&Contabilizar"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(16, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 185
        Me.Label21.Tag = "OBLIGATORIO"
        Me.Label21.Text = "Estado:"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(133, 71)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(159, 20)
        Me.txtEstado.TabIndex = 184
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaCambio.Location = New System.Drawing.Point(597, 101)
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.ReadOnly = True
        Me.txtTasaCambio.Size = New System.Drawing.Size(72, 20)
        Me.txtTasaCambio.TabIndex = 182
        Me.txtTasaCambio.Tag = "BLOQUEADO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(490, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(101, 13)
        Me.Label20.TabIndex = 183
        Me.Label20.Text = "Tasa de cambio:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(490, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 181
        Me.Label11.Text = "Moneda:"
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
        Me.cmbMoeda.ContentHeight = 15
        Me.cmbMoeda.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbMoeda.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbMoeda.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoeda.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMoeda.EditorHeight = 15
        Me.cmbMoeda.Images.Add(CType(resources.GetObject("cmbMoeda.Images"), System.Drawing.Image))
        Me.cmbMoeda.ItemHeight = 15
        Me.cmbMoeda.Location = New System.Drawing.Point(597, 21)
        Me.cmbMoeda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoeda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoeda.MaxLength = 32767
        Me.cmbMoeda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoeda.Name = "cmbMoeda"
        Me.cmbMoeda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoeda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoeda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoeda.Size = New System.Drawing.Size(200, 21)
        Me.cmbMoeda.TabIndex = 180
        Me.cmbMoeda.Tag = "OBLIGATORIO"
        Me.cmbMoeda.PropBag = resources.GetString("cmbMoeda.PropBag")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdCuentaContableAdd)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbCentroCosto)
        Me.GroupBox1.Controls.Add(Me.chkCentro)
        Me.GroupBox1.Controls.Add(Me.txtCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.numAcreditar)
        Me.GroupBox1.Controls.Add(Me.numDebitar)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.cmdEliminar)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(863, 81)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar"
        '
        'cmdCuentaContableAdd
        '
        Me.cmdCuentaContableAdd.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCuentaContableAdd.Appearance.Options.UseFont = True
        Me.cmdCuentaContableAdd.ImageOptions.Image = CType(resources.GetObject("cmdCuentaContableAdd.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCuentaContableAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdCuentaContableAdd.Location = New System.Drawing.Point(484, 53)
        Me.cmdCuentaContableAdd.LookAndFeel.SkinName = "Caramel"
        Me.cmdCuentaContableAdd.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCuentaContableAdd.Name = "cmdCuentaContableAdd"
        Me.cmdCuentaContableAdd.Size = New System.Drawing.Size(32, 28)
        Me.cmdCuentaContableAdd.TabIndex = 184
        Me.cmdCuentaContableAdd.Tag = "AGREGAR"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(172, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 13)
        Me.Label19.TabIndex = 183
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
        Me.cmbCentroCosto.ContentHeight = 15
        Me.cmbCentroCosto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCentroCosto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCentroCosto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCentroCosto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCentroCosto.EditorHeight = 15
        Me.cmbCentroCosto.Enabled = False
        Me.cmbCentroCosto.Images.Add(CType(resources.GetObject("cmbCentroCosto.Images"), System.Drawing.Image))
        Me.cmbCentroCosto.ItemHeight = 15
        Me.cmbCentroCosto.Location = New System.Drawing.Point(278, 26)
        Me.cmbCentroCosto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCentroCosto.MaxDropDownItems = CType(5, Short)
        Me.cmbCentroCosto.MaxLength = 32767
        Me.cmbCentroCosto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCentroCosto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.Size = New System.Drawing.Size(200, 21)
        Me.cmbCentroCosto.TabIndex = 182
        Me.cmbCentroCosto.Tag = "OBLIGATORIO"
        Me.cmbCentroCosto.PropBag = resources.GetString("cmbCentroCosto.PropBag")
        '
        'chkCentro
        '
        Me.chkCentro.AutoSize = True
        Me.chkCentro.Location = New System.Drawing.Point(4, 30)
        Me.chkCentro.Name = "chkCentro"
        Me.chkCentro.Size = New System.Drawing.Size(161, 17)
        Me.chkCentro.TabIndex = 168
        Me.chkCentro.Text = "Asociar centro de costo"
        Me.chkCentro.UseVisualStyleBackColor = True
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(116, 56)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(332, 20)
        Me.txtCuenta.TabIndex = 121
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(1, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Cuenta contable:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(529, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "Acreditar:"
        '
        'numAcreditar
        '
        Me.numAcreditar.BackColor = System.Drawing.Color.Transparent
        Me.numAcreditar.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numAcreditar.Location = New System.Drawing.Point(597, 24)
        Me.numAcreditar.Name = "numAcreditar"
        Me.numAcreditar.Size = New System.Drawing.Size(147, 20)
        Me.numAcreditar.TabIndex = 164
        Me.numAcreditar.Tag = Nothing
        Me.numAcreditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numAcreditar.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numAcreditar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'numDebitar
        '
        Me.numDebitar.BackColor = System.Drawing.Color.Transparent
        Me.numDebitar.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numDebitar.Location = New System.Drawing.Point(597, 53)
        Me.numDebitar.Name = "numDebitar"
        Me.numDebitar.Size = New System.Drawing.Size(147, 20)
        Me.numDebitar.TabIndex = 166
        Me.numDebitar.Tag = Nothing
        Me.numDebitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebitar.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numDebitar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(454, 56)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscar.TabIndex = 167
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(531, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 165
        Me.Label14.Text = "Debitar:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.ImageOptions.Image = CType(resources.GetObject("cmdAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(762, 45)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregar.TabIndex = 125
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.ImageOptions.Image = CType(resources.GetObject("cmdEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(800, 45)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(32, 28)
        Me.cmdEliminar.TabIndex = 126
        Me.cmdEliminar.Tag = "AGREGAR"
        '
        'numTotal
        '
        Me.numTotal.BackColor = System.Drawing.Color.Transparent
        Me.numTotal.Enabled = False
        Me.numTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numTotal.Location = New System.Drawing.Point(731, 485)
        Me.numTotal.Name = "numTotal"
        Me.numTotal.Size = New System.Drawing.Size(131, 20)
        Me.numTotal.TabIndex = 173
        Me.numTotal.Tag = Nothing
        Me.numTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTotal.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(663, 488)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 172
        Me.Label17.Text = "Saldo:"
        '
        'numCreditoT
        '
        Me.numCreditoT.BackColor = System.Drawing.Color.Transparent
        Me.numCreditoT.Enabled = False
        Me.numCreditoT.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numCreditoT.Location = New System.Drawing.Point(731, 459)
        Me.numCreditoT.Name = "numCreditoT"
        Me.numCreditoT.Size = New System.Drawing.Size(131, 20)
        Me.numCreditoT.TabIndex = 171
        Me.numCreditoT.Tag = Nothing
        Me.numCreditoT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numCreditoT.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numCreditoT.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(663, 462)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 170
        Me.Label16.Text = "Credito:"
        '
        'numDebitoT
        '
        Me.numDebitoT.BackColor = System.Drawing.Color.Transparent
        Me.numDebitoT.Enabled = False
        Me.numDebitoT.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numDebitoT.Location = New System.Drawing.Point(731, 436)
        Me.numDebitoT.Name = "numDebitoT"
        Me.numDebitoT.Size = New System.Drawing.Size(131, 20)
        Me.numDebitoT.TabIndex = 169
        Me.numDebitoT.Tag = Nothing
        Me.numDebitoT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numDebitoT.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numDebitoT.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(663, 439)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 168
        Me.Label15.Text = "Debito:"
        '
        'NumMonto
        '
        Me.NumMonto.BackColor = System.Drawing.Color.Transparent
        Me.NumMonto.Enabled = False
        Me.NumMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMonto.Location = New System.Drawing.Point(597, 75)
        Me.NumMonto.Name = "NumMonto"
        Me.NumMonto.Size = New System.Drawing.Size(147, 20)
        Me.NumMonto.TabIndex = 162
        Me.NumMonto.Tag = Nothing
        Me.NumMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMonto.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(490, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 161
        Me.Label12.Text = "Monto:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(80, 433)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(432, 64)
        Me.txtObservaciones.TabIndex = 160
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Notas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Concepto:"
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
        Me.dtpFecha.Location = New System.Drawing.Point(134, 45)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(147, 20)
        Me.dtpFecha.TabIndex = 155
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 156
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "Número de asiento:"
        '
        'txtNumCheque
        '
        Me.txtNumCheque.Enabled = False
        Me.txtNumCheque.Location = New System.Drawing.Point(134, 19)
        Me.txtNumCheque.Name = "txtNumCheque"
        Me.txtNumCheque.Size = New System.Drawing.Size(107, 20)
        Me.txtNumCheque.TabIndex = 147
        '
        'grdGradosA
        '
        Me.grdGradosA.Location = New System.Drawing.Point(56, 244)
        Me.grdGradosA.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGradosA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGradosA.MainView = Me.grdGradosATable
        Me.grdGradosA.Name = "grdGradosA"
        Me.grdGradosA.Size = New System.Drawing.Size(806, 182)
        Me.grdGradosA.TabIndex = 124
        Me.grdGradosA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGradosATable, Me.GridView3})
        '
        'grdGradosATable
        '
        Me.grdGradosATable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colobjSContSubCuentasContablesID, Me.colIDCuenta, Me.colDescripcion, Me.colMontoAcreditar, Me.colMontoDebitar, Me.colCentroCosto})
        Me.grdGradosATable.DetailHeight = 284
        Me.grdGradosATable.GridControl = Me.grdGradosA
        Me.grdGradosATable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGradosATable.Name = "grdGradosATable"
        Me.grdGradosATable.OptionsSelection.MultiSelect = True
        Me.grdGradosATable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdGradosATable.OptionsView.ShowAutoFilterRow = True
        Me.grdGradosATable.OptionsView.ShowGroupPanel = False
        '
        'colobjSContSubCuentasContablesID
        '
        Me.colobjSContSubCuentasContablesID.Caption = "objSContSubCuentasContablesID"
        Me.colobjSContSubCuentasContablesID.FieldName = "objSContSubCuentasContablesID"
        Me.colobjSContSubCuentasContablesID.MinWidth = 15
        Me.colobjSContSubCuentasContablesID.Name = "colobjSContSubCuentasContablesID"
        Me.colobjSContSubCuentasContablesID.Width = 56
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
        Me.colIDCuenta.MinWidth = 15
        Me.colIDCuenta.Name = "colIDCuenta"
        Me.colIDCuenta.OptionsColumn.AllowEdit = False
        Me.colIDCuenta.OptionsColumn.AllowFocus = False
        Me.colIDCuenta.OptionsColumn.ReadOnly = True
        Me.colIDCuenta.Visible = True
        Me.colIDCuenta.VisibleIndex = 2
        Me.colIDCuenta.Width = 61
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Nombre"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.MinWidth = 15
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 259
        '
        'colMontoAcreditar
        '
        Me.colMontoAcreditar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoAcreditar.AppearanceHeader.Options.UseFont = True
        Me.colMontoAcreditar.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoAcreditar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoAcreditar.Caption = "Haber"
        Me.colMontoAcreditar.FieldName = "MontoAcreditar"
        Me.colMontoAcreditar.MinWidth = 15
        Me.colMontoAcreditar.Name = "colMontoAcreditar"
        Me.colMontoAcreditar.OptionsColumn.AllowEdit = False
        Me.colMontoAcreditar.Visible = True
        Me.colMontoAcreditar.VisibleIndex = 5
        Me.colMontoAcreditar.Width = 67
        '
        'colMontoDebitar
        '
        Me.colMontoDebitar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoDebitar.AppearanceHeader.Options.UseFont = True
        Me.colMontoDebitar.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoDebitar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoDebitar.Caption = "Debe"
        Me.colMontoDebitar.FieldName = "MontoDebitar"
        Me.colMontoDebitar.MinWidth = 15
        Me.colMontoDebitar.Name = "colMontoDebitar"
        Me.colMontoDebitar.OptionsColumn.AllowEdit = False
        Me.colMontoDebitar.Visible = True
        Me.colMontoDebitar.VisibleIndex = 4
        Me.colMontoDebitar.Width = 77
        '
        'colCentroCosto
        '
        Me.colCentroCosto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCentroCosto.AppearanceHeader.Options.UseFont = True
        Me.colCentroCosto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCentroCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCentroCosto.Caption = "Centro de costo"
        Me.colCentroCosto.FieldName = "Centro"
        Me.colCentroCosto.MinWidth = 15
        Me.colCentroCosto.Name = "colCentroCosto"
        Me.colCentroCosto.OptionsColumn.AllowEdit = False
        Me.colCentroCosto.Visible = True
        Me.colCentroCosto.VisibleIndex = 1
        Me.colCentroCosto.Width = 85
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.GridView3.DetailHeight = 284
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
        Me.GridColumn5.MinWidth = 15
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 56
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Producto"
        Me.GridColumn6.FieldName = "Producto"
        Me.GridColumn6.MinWidth = 15
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 56
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Modelo/Marca"
        Me.GridColumn7.FieldName = "ModeloMarca"
        Me.GridColumn7.MinWidth = 15
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 2
        Me.GridColumn7.Width = 56
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Saldo"
        Me.GridColumn8.FieldName = "Saldo"
        Me.GridColumn8.MinWidth = 15
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 56
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(787, 520)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(602, 520)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
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
        Me.cmbPeriodo.ContentHeight = 15
        Me.cmbPeriodo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodo.EditorHeight = 15
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
        Me.cmbPeriodo.Size = New System.Drawing.Size(154, 21)
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
        Me.cmbProfesorGuia.ContentHeight = 15
        Me.cmbProfesorGuia.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProfesorGuia.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesorGuia.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesorGuia.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProfesorGuia.EditorHeight = 15
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
        Me.cmbProfesorGuia.Size = New System.Drawing.Size(235, 21)
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
        Me.cmbSeccion.ContentHeight = 15
        Me.cmbSeccion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSeccion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSeccion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeccion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSeccion.EditorHeight = 15
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
        Me.cmbSeccion.Size = New System.Drawing.Size(154, 21)
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
        Me.cmbGrado.ContentHeight = 15
        Me.cmbGrado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGrado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGrado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGrado.EditorHeight = 15
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
        Me.cmbGrado.Size = New System.Drawing.Size(154, 21)
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
        Me.cmbciudad.ContentHeight = 15
        Me.cmbciudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbciudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbciudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbciudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbciudad.EditorHeight = 15
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
        Me.cmbciudad.Size = New System.Drawing.Size(229, 21)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 562)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(924, 16)
        Me.Panel1.TabIndex = 26
        '
        'panelcliente
        '
        Me.panelcliente.Controls.Add(Me.grpDatos)
        Me.panelcliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcliente.Location = New System.Drawing.Point(0, 0)
        Me.panelcliente.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panelcliente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panelcliente.Name = "panelcliente"
        Me.panelcliente.Size = New System.Drawing.Size(924, 578)
        Me.panelcliente.TabIndex = 27
        '
        'frmScontComprobanteEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 578)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScontComprobanteEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.txtConcepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAcreditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDebitar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCreditoT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDebitoT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents colobjSContSubCuentasContablesID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoAcreditar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoDebitar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNumCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NumMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numDebitar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents numAcreditar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents numTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents numCreditoT As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents numDebitoT As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbCentroCosto As C1.Win.C1List.C1Combo
    Friend WithEvents chkCentro As CheckBox
    Friend WithEvents txtTasaCambio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents cmdProcesar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label22 As Label
    Friend WithEvents cmbTipoAsiento As C1.Win.C1List.C1Combo
    Friend WithEvents colCentroCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblContabilizar As Label
    Friend WithEvents numNontoContabilizar As TextBox
    Friend WithEvents txtConcepto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdCuentaContableAdd As DevExpress.XtraEditors.SimpleButton
End Class
