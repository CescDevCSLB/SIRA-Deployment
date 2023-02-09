<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSraEvidenciasMaestroEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraEvidenciasMaestroEditar))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbProfesor = New C1.Win.C1List.C1Combo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.spnOrden = New DevExpress.XtraEditors.SpinEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grdGrados = New DevExpress.XtraGrid.GridControl()
        Me.grdGradosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGradoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdEliminarGrado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarGrado = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbGradosFinal = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
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
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtdescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGradosFinal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grpDatos.Controls.Add(Me.cmbPeriodo)
        Me.grpDatos.Controls.Add(Me.Label11)
        Me.grpDatos.Controls.Add(Me.cmbProfesor)
        Me.grpDatos.Controls.Add(Me.Label10)
        Me.grpDatos.Controls.Add(Me.spnOrden)
        Me.grpDatos.Controls.Add(Me.Label9)
        Me.grpDatos.Controls.Add(Me.txtdescripcion)
        Me.grpDatos.Controls.Add(Me.Label7)
        Me.grpDatos.Controls.Add(Me.grdGrados)
        Me.grpDatos.Controls.Add(Me.cmdEliminarGrado)
        Me.grpDatos.Controls.Add(Me.cmdAgregarGrado)
        Me.grpDatos.Controls.Add(Me.cmbGradosFinal)
        Me.grpDatos.Controls.Add(Me.Label8)
        Me.grpDatos.Controls.Add(Me.chkActivo)
        Me.grpDatos.Controls.Add(Me.Label6)
        Me.grpDatos.Controls.Add(Me.txtTitulo)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 5)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(642, 476)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
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
        Me.cmbPeriodo.Location = New System.Drawing.Point(482, 16)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(143, 24)
        Me.cmbPeriodo.TabIndex = 131
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(405, 19)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 17)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Período:"
        '
        'cmbProfesor
        '
        Me.cmbProfesor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProfesor.AutoCompletion = True
        Me.cmbProfesor.AutoDropDown = True
        Me.cmbProfesor.Caption = ""
        Me.cmbProfesor.CaptionHeight = 17
        Me.cmbProfesor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProfesor.ColumnCaptionHeight = 17
        Me.cmbProfesor.ColumnFooterHeight = 17
        Me.cmbProfesor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbProfesor.ContentHeight = 18
        Me.cmbProfesor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProfesor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProfesor.EditorHeight = 18
        Me.cmbProfesor.Images.Add(CType(resources.GetObject("cmbProfesor.Images"), System.Drawing.Image))
        Me.cmbProfesor.ItemHeight = 15
        Me.cmbProfesor.Location = New System.Drawing.Point(111, 120)
        Me.cmbProfesor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProfesor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProfesor.MaxDropDownItems = CType(5, Short)
        Me.cmbProfesor.MaxLength = 32767
        Me.cmbProfesor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProfesor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProfesor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProfesor.Size = New System.Drawing.Size(415, 24)
        Me.cmbProfesor.TabIndex = 129
        Me.cmbProfesor.Tag = "OBLIGATORIO"
        Me.cmbProfesor.PropBag = resources.GetString("cmbProfesor.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 125)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 17)
        Me.Label10.TabIndex = 130
        Me.Label10.Text = "Profesor:"
        '
        'spnOrden
        '
        Me.spnOrden.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnOrden.Location = New System.Drawing.Point(111, 151)
        Me.spnOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.spnOrden.Name = "spnOrden"
        Me.spnOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnOrden.Properties.Mask.EditMask = "n0"
        Me.spnOrden.Size = New System.Drawing.Size(133, 22)
        Me.spnOrden.TabIndex = 128
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 155)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 127
        Me.Label9.Text = "Orden:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(111, 54)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtdescripcion.Size = New System.Drawing.Size(514, 55)
        Me.txtdescripcion.TabIndex = 126
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Descripción:"
        '
        'grdGrados
        '
        Me.grdGrados.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGrados.Location = New System.Drawing.Point(24, 240)
        Me.grdGrados.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGrados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGrados.MainView = Me.grdGradosTabla
        Me.grdGrados.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGrados.Name = "grdGrados"
        Me.grdGrados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemDateEdit2, Me.RepositoryItemMemoEdit2})
        Me.grdGrados.Size = New System.Drawing.Size(471, 219)
        Me.grdGrados.TabIndex = 9
        Me.grdGrados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGradosTabla, Me.GridView3})
        '
        'grdGradosTabla
        '
        Me.grdGradosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colGrado, Me.colGradoID})
        Me.grdGradosTabla.GridControl = Me.grdGrados
        Me.grdGradosTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGradosTabla.Name = "grdGradosTabla"
        Me.grdGradosTabla.OptionsSelection.MultiSelect = True
        Me.grdGradosTabla.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdGradosTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdGradosTabla.OptionsView.ShowGroupPanel = False
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
        'colGrado
        '
        Me.colGrado.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colGrado.AppearanceCell.Options.UseBackColor = True
        Me.colGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrado.AppearanceHeader.Options.UseFont = True
        Me.colGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrado.Caption = "Grado"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.Name = "colGrado"
        Me.colGrado.OptionsColumn.AllowEdit = False
        Me.colGrado.OptionsColumn.AllowFocus = False
        Me.colGrado.OptionsColumn.ReadOnly = True
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 1
        Me.colGrado.Width = 488
        '
        'colGradoID
        '
        Me.colGradoID.Caption = "GradoID"
        Me.colGradoID.FieldName = "GradoID"
        Me.colGradoID.Name = "colGradoID"
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
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView3.GridControl = Me.grdGrados
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsBehavior.ReadOnly = True
        Me.GridView3.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "SccCuentaID"
        Me.GridColumn4.FieldName = "SccCuentaID"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Producto"
        Me.GridColumn5.FieldName = "Producto"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Modelo/Marca"
        Me.GridColumn6.FieldName = "ModeloMarca"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Saldo"
        Me.GridColumn7.FieldName = "Saldo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsFilter.AllowAutoFilter = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        '
        'cmdEliminarGrado
        '
        Me.cmdEliminarGrado.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarGrado.Appearance.Options.UseFont = True
        Me.cmdEliminarGrado.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdEliminarGrado.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminarGrado.Location = New System.Drawing.Point(426, 195)
        Me.cmdEliminarGrado.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminarGrado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminarGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminarGrado.Name = "cmdEliminarGrado"
        Me.cmdEliminarGrado.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminarGrado.TabIndex = 8
        Me.cmdEliminarGrado.Tag = "AGREGAR"
        '
        'cmdAgregarGrado
        '
        Me.cmdAgregarGrado.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarGrado.Appearance.Options.UseFont = True
        Me.cmdAgregarGrado.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregarGrado.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarGrado.Location = New System.Drawing.Point(379, 195)
        Me.cmdAgregarGrado.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarGrado.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarGrado.Name = "cmdAgregarGrado"
        Me.cmdAgregarGrado.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregarGrado.TabIndex = 7
        Me.cmdAgregarGrado.Tag = "AGREGAR"
        '
        'cmbGradosFinal
        '
        Me.cmbGradosFinal.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGradosFinal.AutoCompletion = True
        Me.cmbGradosFinal.AutoDropDown = True
        Me.cmbGradosFinal.Caption = ""
        Me.cmbGradosFinal.CaptionHeight = 17
        Me.cmbGradosFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGradosFinal.ColumnCaptionHeight = 17
        Me.cmbGradosFinal.ColumnFooterHeight = 17
        Me.cmbGradosFinal.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbGradosFinal.ContentHeight = 18
        Me.cmbGradosFinal.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGradosFinal.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGradosFinal.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGradosFinal.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGradosFinal.EditorHeight = 18
        Me.cmbGradosFinal.Images.Add(CType(resources.GetObject("cmbGradosFinal.Images"), System.Drawing.Image))
        Me.cmbGradosFinal.ItemHeight = 15
        Me.cmbGradosFinal.Location = New System.Drawing.Point(111, 197)
        Me.cmbGradosFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGradosFinal.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGradosFinal.MaxDropDownItems = CType(5, Short)
        Me.cmbGradosFinal.MaxLength = 32767
        Me.cmbGradosFinal.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGradosFinal.Name = "cmbGradosFinal"
        Me.cmbGradosFinal.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGradosFinal.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGradosFinal.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGradosFinal.Size = New System.Drawing.Size(231, 24)
        Me.cmbGradosFinal.TabIndex = 6
        Me.cmbGradosFinal.Tag = "OBLIGATORIO"
        Me.cmbGradosFinal.PropBag = resources.GetString("cmbGradosFinal.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 204)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 124
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Grado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(379, 154)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 1
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 122
        Me.Label6.Text = "Título:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(111, 16)
        Me.txtTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(274, 23)
        Me.txtTitulo.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(518, 418)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 11
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(518, 376)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 10
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
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
        Me.Panel1.Location = New System.Drawing.Point(0, 495)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 20)
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
        Me.panelcliente.Size = New System.Drawing.Size(663, 515)
        Me.panelcliente.TabIndex = 27
        '
        'frmSraEvidenciasMaestroEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraEvidenciasMaestroEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar tituolo evidencia"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtdescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGradosFinal, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents cmbProfesorGuia As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSeccion As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents grdGrados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGradosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colGradoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEliminarGrado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarGrado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGradosFinal As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents spnOrden As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProfesor As C1.Win.C1List.C1Combo
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents Label11 As Label
End Class
