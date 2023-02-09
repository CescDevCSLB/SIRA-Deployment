<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSraParcialPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraParcialPermisos))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.grdRolesAsignados = New DevExpress.XtraGrid.GridControl()
        Me.grdRolesAsignadosTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbRoles = New C1.Win.C1List.C1Combo()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbParcial = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbciudad = New C1.Win.C1List.C1Combo()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.grpDatos.SuspendLayout()
        CType(Me.grdRolesAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRolesAsignadosTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.grdRolesAsignados)
        Me.grpDatos.Controls.Add(Me.cmbRoles)
        Me.grpDatos.Controls.Add(Me.gbxDatosGenerales)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.cmdEliminar)
        Me.grpDatos.Controls.Add(Me.cmdAgregar)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 4)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(640, 491)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'grdRolesAsignados
        '
        Me.grdRolesAsignados.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRolesAsignados.Location = New System.Drawing.Point(24, 170)
        Me.grdRolesAsignados.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRolesAsignados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRolesAsignados.MainView = Me.grdRolesAsignadosTable
        Me.grdRolesAsignados.Margin = New System.Windows.Forms.Padding(4)
        Me.grdRolesAsignados.Name = "grdRolesAsignados"
        Me.grdRolesAsignados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemDateEdit2})
        Me.grdRolesAsignados.Size = New System.Drawing.Size(592, 263)
        Me.grdRolesAsignados.TabIndex = 4
        Me.grdRolesAsignados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdRolesAsignadosTable, Me.GridView3})
        '
        'grdRolesAsignadosTable
        '
        Me.grdRolesAsignadosTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.grdRolesAsignadosTable.GridControl = Me.grdRolesAsignados
        Me.grdRolesAsignadosTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdRolesAsignadosTable.Name = "grdRolesAsignadosTable"
        Me.grdRolesAsignadosTable.OptionsSelection.MultiSelect = True
        Me.grdRolesAsignadosTable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdRolesAsignadosTable.OptionsView.ShowAutoFilterRow = True
        Me.grdRolesAsignadosTable.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Seleccionar"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEdit3
        Me.GridColumn1.FieldName = "Seleccionar"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "SsgRolID"
        Me.GridColumn2.FieldName = "SsgRolID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Width = 109
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.GridColumn3.AppearanceCell.Options.UseBackColor = True
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Rol"
        Me.GridColumn3.FieldName = "Rol"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 269
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        Me.RepositoryItemDateEdit2.ReadOnly = True
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView3.GridControl = Me.grdRolesAsignados
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "SccCuentaID"
        Me.GridColumn6.FieldName = "SccCuentaID"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Producto"
        Me.GridColumn7.FieldName = "Producto"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 1
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Modelo/Marca"
        Me.GridColumn8.FieldName = "ModeloMarca"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 2
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Saldo"
        Me.GridColumn9.FieldName = "Saldo"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 3
        '
        'cmbRoles
        '
        Me.cmbRoles.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRoles.AutoCompletion = True
        Me.cmbRoles.AutoDropDown = True
        Me.cmbRoles.Caption = ""
        Me.cmbRoles.CaptionHeight = 17
        Me.cmbRoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRoles.ColumnCaptionHeight = 17
        Me.cmbRoles.ColumnFooterHeight = 17
        Me.cmbRoles.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbRoles.ContentHeight = 18
        Me.cmbRoles.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRoles.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRoles.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRoles.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRoles.EditorHeight = 18
        Me.cmbRoles.Images.Add(CType(resources.GetObject("cmbRoles.Images"), System.Drawing.Image))
        Me.cmbRoles.ItemHeight = 15
        Me.cmbRoles.Location = New System.Drawing.Point(135, 97)
        Me.cmbRoles.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbRoles.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRoles.MaxDropDownItems = CType(5, Short)
        Me.cmbRoles.MaxLength = 32767
        Me.cmbRoles.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRoles.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRoles.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRoles.Size = New System.Drawing.Size(348, 24)
        Me.cmbRoles.TabIndex = 0
        Me.cmbRoles.Tag = "OBLIGATORIO"
        Me.cmbRoles.PropBag = resources.GetString("cmbRoles.PropBag")
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbParcial)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(12, 6)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(604, 71)
        Me.gbxDatosGenerales.TabIndex = 113
        Me.gbxDatosGenerales.TabStop = False
        '
        'cmbParcial
        '
        Me.cmbParcial.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbParcial.AutoCompletion = True
        Me.cmbParcial.AutoDropDown = True
        Me.cmbParcial.Caption = ""
        Me.cmbParcial.CaptionHeight = 17
        Me.cmbParcial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbParcial.ColumnCaptionHeight = 17
        Me.cmbParcial.ColumnFooterHeight = 17
        Me.cmbParcial.ContentHeight = 18
        Me.cmbParcial.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbParcial.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbParcial.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParcial.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbParcial.EditorHeight = 18
        Me.cmbParcial.Images.Add(CType(resources.GetObject("cmbParcial.Images"), System.Drawing.Image))
        Me.cmbParcial.ItemHeight = 15
        Me.cmbParcial.Location = New System.Drawing.Point(123, 27)
        Me.cmbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParcial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbParcial.MaxDropDownItems = CType(5, Short)
        Me.cmbParcial.MaxLength = 32767
        Me.cmbParcial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.ReadOnly = True
        Me.cmbParcial.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbParcial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbParcial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbParcial.Size = New System.Drawing.Size(293, 24)
        Me.cmbParcial.TabIndex = 0
        Me.cmbParcial.Tag = "OBLIGATORIO"
        Me.cmbParcial.PropBag = resources.GetString("cmbParcial.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Parcial:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Rol:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(567, 128)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminar.TabIndex = 3
        Me.cmdEliminar.Tag = "AGREGAR"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(516, 128)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(513, 441)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 6
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(399, 441)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 5
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
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
        Me.Panel1.Location = New System.Drawing.Point(0, 491)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(664, 511)
        Me.panelcliente.TabIndex = 27
        '
        'frmSraParcialPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraParcialPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar permisos al parcial"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.grdRolesAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRolesAsignadosTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbRoles As C1.Win.C1List.C1Combo
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grdRolesAsignados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdRolesAsignadosTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbParcial As C1.Win.C1List.C1Combo
End Class
