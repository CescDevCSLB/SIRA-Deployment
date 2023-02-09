<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSraNotasCualitativasEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraNotasCualitativasEdit))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdEliminarGrados = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregarGrados = New DevExpress.XtraEditors.SimpleButton()
        Me.grdGradosA = New DevExpress.XtraGrid.GridControl()
        Me.grdGradosATable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colGradoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbModalidad = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.spnHasta = New DevExpress.XtraEditors.SpinEdit()
        Me.spnDesde = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdEliminarGrados)
        Me.PanelControl1.Controls.Add(Me.cmdAgregarGrados)
        Me.PanelControl1.Controls.Add(Me.grdGradosA)
        Me.PanelControl1.Controls.Add(Me.Label7)
        Me.PanelControl1.Controls.Add(Me.lblFechaIngreso)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(597, 591)
        Me.PanelControl1.TabIndex = 98
        '
        'cmdEliminarGrados
        '
        Me.cmdEliminarGrados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminarGrados.Appearance.Options.UseFont = True
        Me.cmdEliminarGrados.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdEliminarGrados.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminarGrados.Location = New System.Drawing.Point(509, 175)
        Me.cmdEliminarGrados.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminarGrados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminarGrados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminarGrados.Name = "cmdEliminarGrados"
        Me.cmdEliminarGrados.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminarGrados.TabIndex = 9
        Me.cmdEliminarGrados.Tag = "AGREGAR"
        '
        'cmdAgregarGrados
        '
        Me.cmdAgregarGrados.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregarGrados.Appearance.Options.UseFont = True
        Me.cmdAgregarGrados.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregarGrados.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregarGrados.Location = New System.Drawing.Point(459, 175)
        Me.cmdAgregarGrados.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregarGrados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregarGrados.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregarGrados.Name = "cmdAgregarGrados"
        Me.cmdAgregarGrados.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregarGrados.TabIndex = 8
        Me.cmdAgregarGrados.Tag = "AGREGAR"
        '
        'grdGradosA
        '
        Me.grdGradosA.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Location = New System.Drawing.Point(39, 213)
        Me.grdGradosA.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGradosA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGradosA.MainView = Me.grdGradosATable
        Me.grdGradosA.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Name = "grdGradosA"
        Me.grdGradosA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemDateEdit2})
        Me.grdGradosA.Size = New System.Drawing.Size(521, 263)
        Me.grdGradosA.TabIndex = 11
        Me.grdGradosA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGradosATable, Me.GridView3})
        '
        'grdGradosATable
        '
        Me.grdGradosATable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colGradoID, Me.colCodigoGrado, Me.colGrado})
        Me.grdGradosATable.GridControl = Me.grdGradosA
        Me.grdGradosATable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGradosATable.Name = "grdGradosATable"
        Me.grdGradosATable.OptionsSelection.MultiSelect = True
        Me.grdGradosATable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdGradosATable.OptionsView.ShowAutoFilterRow = True
        Me.grdGradosATable.OptionsView.ShowGroupPanel = False
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
        'colGradoID
        '
        Me.colGradoID.Caption = "GradoID"
        Me.colGradoID.FieldName = "GradoID"
        Me.colGradoID.Name = "colGradoID"
        Me.colGradoID.OptionsColumn.AllowEdit = False
        Me.colGradoID.OptionsColumn.AllowFocus = False
        Me.colGradoID.OptionsColumn.ReadOnly = True
        Me.colGradoID.Width = 109
        '
        'colCodigoGrado
        '
        Me.colCodigoGrado.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colCodigoGrado.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoGrado.AppearanceHeader.Options.UseFont = True
        Me.colCodigoGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoGrado.Caption = "Código"
        Me.colCodigoGrado.FieldName = "CodigoGrado"
        Me.colCodigoGrado.Name = "colCodigoGrado"
        Me.colCodigoGrado.OptionsColumn.AllowEdit = False
        Me.colCodigoGrado.OptionsColumn.AllowFocus = False
        Me.colCodigoGrado.OptionsColumn.ReadOnly = True
        Me.colCodigoGrado.Visible = True
        Me.colCodigoGrado.VisibleIndex = 1
        Me.colCodigoGrado.Width = 81
        '
        'colGrado
        '
        Me.colGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrado.AppearanceHeader.Options.UseFont = True
        Me.colGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrado.Caption = "Nombre"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.Name = "colGrado"
        Me.colGrado.OptionsColumn.AllowEdit = False
        Me.colGrado.OptionsColumn.AllowFocus = False
        Me.colGrado.OptionsColumn.ReadOnly = True
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 2
        Me.colGrado.Width = 237
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(40, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Grados"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(43, 508)
        Me.lblFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(116, 17)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(460, 500)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(345, 500)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbModalidad)
        Me.gbxDatosGenerales.Controls.Add(Me.Label9)
        Me.gbxDatosGenerales.Controls.Add(Me.txtValor)
        Me.gbxDatosGenerales.Controls.Add(Me.spnHasta)
        Me.gbxDatosGenerales.Controls.Add(Me.spnDesde)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(31, 15)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(564, 140)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
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
        Me.cmbModalidad.Location = New System.Drawing.Point(112, 25)
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
        Me.cmbModalidad.TabIndex = 0
        Me.cmbModalidad.Tag = "OBLIGATORIO"
        Me.cmbModalidad.PropBag = resources.GetString("cmbModalidad.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "Modalidad:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(112, 59)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(205, 23)
        Me.txtValor.TabIndex = 1
        Me.txtValor.TabStop = False
        Me.txtValor.Tag = "BLOQUEADO"
        '
        'spnHasta
        '
        Me.spnHasta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnHasta.Location = New System.Drawing.Point(396, 92)
        Me.spnHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.spnHasta.Name = "spnHasta"
        Me.spnHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnHasta.Properties.DisplayFormat.FormatString = "0.00"
        Me.spnHasta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnHasta.Size = New System.Drawing.Size(133, 22)
        Me.spnHasta.TabIndex = 4
        '
        'spnDesde
        '
        Me.spnDesde.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnDesde.Location = New System.Drawing.Point(112, 92)
        Me.spnDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.spnDesde.Name = "spnDesde"
        Me.spnDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnDesde.Properties.DisplayFormat.FormatString = "0.00"
        Me.spnDesde.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spnDesde.Size = New System.Drawing.Size(133, 22)
        Me.spnDesde.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Escala:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Desde:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(396, 25)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 3
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(317, 101)
        Me.lblSfaPromocionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(55, 17)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Hasta:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 565)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraNotasCualitativasEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 591)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraNotasCualitativasEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar rango de notas cualitativas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents spnHasta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnDesde As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents cmbModalidad As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminarGrados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregarGrados As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdGradosA As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGradosATable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colGradoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label7 As Label
End Class
