<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScontCuentaContableEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScontCuentaContableEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.cmbClasificacion = New C1.Win.C1List.C1Combo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkCuentaEstado = New System.Windows.Forms.CheckBox()
        Me.chkCuentaBalance = New System.Windows.Forms.CheckBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.chkTieneCentroCosto = New System.Windows.Forms.CheckBox()
        Me.chkTieneAuxilar = New System.Windows.Forms.CheckBox()
        Me.chkRecibeMovimiento = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbCentroCosto = New C1.Win.C1List.C1Combo()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdCentrosCosto = New DevExpress.XtraGrid.GridControl()
        Me.grdCentrosCostoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colobjEnfermedadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbNivel = New C1.Win.C1List.C1Combo()
        Me.cmbNaturaleza = New C1.Win.C1List.C1Combo()
        Me.lblSuperior = New System.Windows.Forms.Label()
        Me.txtCuentaSuperior = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
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
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.grpDatos.SuspendLayout()
        CType(Me.cmbClasificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCentrosCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCentrosCostoTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNaturaleza, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpDatos.Controls.Add(Me.cmbClasificacion)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.chkCuentaEstado)
        Me.grpDatos.Controls.Add(Me.chkCuentaBalance)
        Me.grpDatos.Controls.Add(Me.cmdBuscar)
        Me.grpDatos.Controls.Add(Me.chkTieneCentroCosto)
        Me.grpDatos.Controls.Add(Me.chkTieneAuxilar)
        Me.grpDatos.Controls.Add(Me.chkRecibeMovimiento)
        Me.grpDatos.Controls.Add(Me.GroupBox1)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmbNivel)
        Me.grpDatos.Controls.Add(Me.cmbNaturaleza)
        Me.grpDatos.Controls.Add(Me.lblSuperior)
        Me.grpDatos.Controls.Add(Me.txtCuentaSuperior)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.txtDescripcion)
        Me.grpDatos.Controls.Add(Me.chkActivo)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtCodigo)
        Me.grpDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(2, 2)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(831, 602)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbClasificacion.AutoCompletion = True
        Me.cmbClasificacion.AutoDropDown = True
        Me.cmbClasificacion.Caption = ""
        Me.cmbClasificacion.CaptionHeight = 17
        Me.cmbClasificacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbClasificacion.ColumnCaptionHeight = 17
        Me.cmbClasificacion.ColumnFooterHeight = 17
        Me.cmbClasificacion.ContentHeight = 18
        Me.cmbClasificacion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbClasificacion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbClasificacion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClasificacion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClasificacion.EditorHeight = 18
        Me.cmbClasificacion.Images.Add(CType(resources.GetObject("cmbClasificacion.Images"), System.Drawing.Image))
        Me.cmbClasificacion.ItemHeight = 15
        Me.cmbClasificacion.Location = New System.Drawing.Point(133, 89)
        Me.cmbClasificacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbClasificacion.MatchEntryTimeout = CType(2000, Long)
        Me.cmbClasificacion.MaxDropDownItems = CType(5, Short)
        Me.cmbClasificacion.MaxLength = 32767
        Me.cmbClasificacion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbClasificacion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbClasificacion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbClasificacion.Size = New System.Drawing.Size(243, 24)
        Me.cmbClasificacion.TabIndex = 172
        Me.cmbClasificacion.Tag = "OBLIGATORIO"
        Me.cmbClasificacion.PropBag = resources.GetString("cmbClasificacion.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 95)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "Clasificación:"
        '
        'chkCuentaEstado
        '
        Me.chkCuentaEstado.AutoSize = True
        Me.chkCuentaEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCuentaEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuentaEstado.Location = New System.Drawing.Point(240, 473)
        Me.chkCuentaEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCuentaEstado.Name = "chkCuentaEstado"
        Me.chkCuentaEstado.Size = New System.Drawing.Size(254, 21)
        Me.chkCuentaEstado.TabIndex = 170
        Me.chkCuentaEstado.Text = "Cuenta de estado de resultado"
        Me.chkCuentaEstado.UseVisualStyleBackColor = True
        '
        'chkCuentaBalance
        '
        Me.chkCuentaBalance.AutoSize = True
        Me.chkCuentaBalance.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCuentaBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuentaBalance.Location = New System.Drawing.Point(329, 501)
        Me.chkCuentaBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCuentaBalance.Name = "chkCuentaBalance"
        Me.chkCuentaBalance.Size = New System.Drawing.Size(166, 21)
        Me.chkCuentaBalance.TabIndex = 169
        Me.chkCuentaBalance.Text = "Cuenta de balance"
        Me.chkCuentaBalance.UseVisualStyleBackColor = True
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(525, 155)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 168
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'chkTieneCentroCosto
        '
        Me.chkTieneCentroCosto.AutoSize = True
        Me.chkTieneCentroCosto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTieneCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTieneCentroCosto.Location = New System.Drawing.Point(53, 501)
        Me.chkTieneCentroCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTieneCentroCosto.Name = "chkTieneCentroCosto"
        Me.chkTieneCentroCosto.Size = New System.Drawing.Size(145, 21)
        Me.chkTieneCentroCosto.TabIndex = 152
        Me.chkTieneCentroCosto.Text = "Centro de costo"
        Me.chkTieneCentroCosto.UseVisualStyleBackColor = True
        '
        'chkTieneAuxilar
        '
        Me.chkTieneAuxilar.AutoSize = True
        Me.chkTieneAuxilar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTieneAuxilar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTieneAuxilar.Location = New System.Drawing.Point(76, 529)
        Me.chkTieneAuxilar.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTieneAuxilar.Name = "chkTieneAuxilar"
        Me.chkTieneAuxilar.Size = New System.Drawing.Size(124, 21)
        Me.chkTieneAuxilar.TabIndex = 151
        Me.chkTieneAuxilar.Text = "Tiene auxilar"
        Me.chkTieneAuxilar.UseVisualStyleBackColor = True
        '
        'chkRecibeMovimiento
        '
        Me.chkRecibeMovimiento.AutoSize = True
        Me.chkRecibeMovimiento.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRecibeMovimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecibeMovimiento.Location = New System.Drawing.Point(23, 473)
        Me.chkRecibeMovimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRecibeMovimiento.Name = "chkRecibeMovimiento"
        Me.chkRecibeMovimiento.Size = New System.Drawing.Size(174, 21)
        Me.chkRecibeMovimiento.TabIndex = 150
        Me.chkRecibeMovimiento.Text = "Recibe movimientos"
        Me.chkRecibeMovimiento.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdEliminar)
        Me.GroupBox1.Controls.Add(Me.cmbCentroCosto)
        Me.GroupBox1.Controls.Add(Me.lblMarca)
        Me.GroupBox1.Controls.Add(Me.cmdAgregar)
        Me.GroupBox1.Controls.Add(Me.grdCentrosCosto)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 197)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(644, 260)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Centros de costo asociados"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.ImageOptions.Image = CType(resources.GetObject("cmdEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(549, 33)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminar.TabIndex = 128
        Me.cmdEliminar.Tag = "AGREGAR"
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
        Me.cmbCentroCosto.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCentroCosto.ContentHeight = 18
        Me.cmbCentroCosto.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCentroCosto.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCentroCosto.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCentroCosto.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCentroCosto.EditorHeight = 18
        Me.cmbCentroCosto.Images.Add(CType(resources.GetObject("cmbCentroCosto.Images"), System.Drawing.Image))
        Me.cmbCentroCosto.ItemHeight = 15
        Me.cmbCentroCosto.Location = New System.Drawing.Point(179, 39)
        Me.cmbCentroCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCentroCosto.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCentroCosto.MaxDropDownItems = CType(5, Short)
        Me.cmbCentroCosto.MaxLength = 32767
        Me.cmbCentroCosto.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCentroCosto.Name = "cmbCentroCosto"
        Me.cmbCentroCosto.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCentroCosto.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCentroCosto.Size = New System.Drawing.Size(313, 24)
        Me.cmbCentroCosto.TabIndex = 106
        Me.cmbCentroCosto.Tag = "OBLIGATORIO"
        Me.cmbCentroCosto.PropBag = resources.GetString("cmbCentroCosto.PropBag")
        '
        'lblMarca
        '
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(28, 42)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(165, 22)
        Me.lblMarca.TabIndex = 107
        Me.lblMarca.Tag = ""
        Me.lblMarca.Text = "Centro de costo:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.ImageOptions.Image = CType(resources.GetObject("cmdAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(499, 33)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 104
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'grdCentrosCosto
        '
        Me.grdCentrosCosto.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdCentrosCosto.Location = New System.Drawing.Point(27, 78)
        Me.grdCentrosCosto.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdCentrosCosto.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdCentrosCosto.MainView = Me.grdCentrosCostoTabla
        Me.grdCentrosCosto.Margin = New System.Windows.Forms.Padding(4)
        Me.grdCentrosCosto.Name = "grdCentrosCosto"
        Me.grdCentrosCosto.Size = New System.Drawing.Size(572, 175)
        Me.grdCentrosCosto.TabIndex = 105
        Me.grdCentrosCosto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCentrosCostoTabla})
        '
        'grdCentrosCostoTabla
        '
        Me.grdCentrosCostoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colobjEnfermedadID, Me.colNombre})
        Me.grdCentrosCostoTabla.GridControl = Me.grdCentrosCosto
        Me.grdCentrosCostoTabla.Name = "grdCentrosCostoTabla"
        Me.grdCentrosCostoTabla.OptionsView.ShowGroupPanel = False
        '
        'colobjEnfermedadID
        '
        Me.colobjEnfermedadID.Caption = "EnfermedadID"
        Me.colobjEnfermedadID.FieldName = "objSconCentroCostoID"
        Me.colobjEnfermedadID.Name = "colobjEnfermedadID"
        Me.colobjEnfermedadID.Width = 76
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "CentroCosto"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombre.OptionsFilter.AllowAutoFilter = False
        Me.colNombre.OptionsFilter.AllowFilter = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 183
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(684, 272)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(684, 315)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmbNivel
        '
        Me.cmbNivel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbNivel.AutoCompletion = True
        Me.cmbNivel.AutoDropDown = True
        Me.cmbNivel.Caption = ""
        Me.cmbNivel.CaptionHeight = 17
        Me.cmbNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbNivel.ColumnCaptionHeight = 17
        Me.cmbNivel.ColumnFooterHeight = 17
        Me.cmbNivel.ContentHeight = 18
        Me.cmbNivel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbNivel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbNivel.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNivel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNivel.EditorHeight = 18
        Me.cmbNivel.Images.Add(CType(resources.GetObject("cmbNivel.Images"), System.Drawing.Image))
        Me.cmbNivel.ItemHeight = 15
        Me.cmbNivel.Location = New System.Drawing.Point(525, 57)
        Me.cmbNivel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNivel.MatchEntryTimeout = CType(2000, Long)
        Me.cmbNivel.MaxDropDownItems = CType(5, Short)
        Me.cmbNivel.MaxLength = 32767
        Me.cmbNivel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbNivel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbNivel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbNivel.Size = New System.Drawing.Size(243, 24)
        Me.cmbNivel.TabIndex = 148
        Me.cmbNivel.Tag = "OBLIGATORIO"
        Me.cmbNivel.PropBag = resources.GetString("cmbNivel.PropBag")
        '
        'cmbNaturaleza
        '
        Me.cmbNaturaleza.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbNaturaleza.AutoCompletion = True
        Me.cmbNaturaleza.AutoDropDown = True
        Me.cmbNaturaleza.Caption = ""
        Me.cmbNaturaleza.CaptionHeight = 17
        Me.cmbNaturaleza.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbNaturaleza.ColumnCaptionHeight = 17
        Me.cmbNaturaleza.ColumnFooterHeight = 17
        Me.cmbNaturaleza.ContentHeight = 18
        Me.cmbNaturaleza.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbNaturaleza.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbNaturaleza.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNaturaleza.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNaturaleza.EditorHeight = 18
        Me.cmbNaturaleza.Images.Add(CType(resources.GetObject("cmbNaturaleza.Images"), System.Drawing.Image))
        Me.cmbNaturaleza.ItemHeight = 15
        Me.cmbNaturaleza.Location = New System.Drawing.Point(133, 55)
        Me.cmbNaturaleza.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNaturaleza.MatchEntryTimeout = CType(2000, Long)
        Me.cmbNaturaleza.MaxDropDownItems = CType(5, Short)
        Me.cmbNaturaleza.MaxLength = 32767
        Me.cmbNaturaleza.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbNaturaleza.Name = "cmbNaturaleza"
        Me.cmbNaturaleza.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbNaturaleza.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbNaturaleza.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbNaturaleza.Size = New System.Drawing.Size(243, 24)
        Me.cmbNaturaleza.TabIndex = 147
        Me.cmbNaturaleza.Tag = "OBLIGATORIO"
        Me.cmbNaturaleza.PropBag = resources.GetString("cmbNaturaleza.PropBag")
        '
        'lblSuperior
        '
        Me.lblSuperior.AutoSize = True
        Me.lblSuperior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuperior.ForeColor = System.Drawing.Color.Black
        Me.lblSuperior.Location = New System.Drawing.Point(12, 161)
        Me.lblSuperior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuperior.Name = "lblSuperior"
        Me.lblSuperior.Size = New System.Drawing.Size(111, 17)
        Me.lblSuperior.TabIndex = 129
        Me.lblSuperior.Text = "Cuenta padre:"
        '
        'txtCuentaSuperior
        '
        Me.txtCuentaSuperior.Enabled = False
        Me.txtCuentaSuperior.Location = New System.Drawing.Point(133, 158)
        Me.txtCuentaSuperior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCuentaSuperior.Name = "txtCuentaSuperior"
        Me.txtCuentaSuperior.Size = New System.Drawing.Size(383, 23)
        Me.txtCuentaSuperior.TabIndex = 128
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(453, 64)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Nivel:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 63)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 126
        Me.Label8.Text = "Naturaleza:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(384, 25)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 23)
        Me.txtDescripcion.TabIndex = 125
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(601, 118)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 123
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 17)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(133, 25)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(241, 23)
        Me.txtCodigo.TabIndex = 121
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
        'ArchivoDialogo
        '
        Me.ArchivoDialogo.FileName = "OpenFileDialog1"
        Me.ArchivoDialogo.Filter = "JPEG Files | *.JPG"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 586)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(835, 606)
        Me.panelcliente.TabIndex = 27
        '
        'frmScontCuentaContableEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 606)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScontCuentaContableEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Cuenta contable"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cmbClasificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCentrosCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCentrosCostoTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNaturaleza, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
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
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSuperior As System.Windows.Forms.Label
    Friend WithEvents txtCuentaSuperior As System.Windows.Forms.TextBox
    Friend WithEvents cmbNivel As C1.Win.C1List.C1Combo
    Friend WithEvents cmbNaturaleza As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbCentroCosto As C1.Win.C1List.C1Combo
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdCentrosCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCentrosCostoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colobjEnfermedadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkTieneCentroCosto As System.Windows.Forms.CheckBox
    Friend WithEvents chkTieneAuxilar As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecibeMovimiento As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents chkCuentaEstado As System.Windows.Forms.CheckBox
    Friend WithEvents chkCuentaBalance As System.Windows.Forms.CheckBox
    Friend WithEvents cmbClasificacion As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As Label
End Class
