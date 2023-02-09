<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraAsignaturasEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraAsignaturasEditar))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkCuantitativa = New System.Windows.Forms.CheckBox()
        Me.chkCualitativa = New System.Windows.Forms.CheckBox()
        Me.cmbParcial = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbModalidad = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdGradosA = New DevExpress.XtraGrid.GridControl()
        Me.grdGradosATable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colModalidadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colParcialID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCualitativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCuantitativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spnOrden = New DevExpress.XtraEditors.SpinEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSoloGuia = New System.Windows.Forms.CheckBox()
        Me.txtAbreviatura = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
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
        Me.PanelControl1.Size = New System.Drawing.Size(751, 635)
        Me.PanelControl1.TabIndex = 98
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.Location = New System.Drawing.Point(19, 580)
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
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(627, 562)
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
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(510, 562)
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
        Me.gbxDatosGenerales.Controls.Add(Me.chkCuantitativa)
        Me.gbxDatosGenerales.Controls.Add(Me.chkCualitativa)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbParcial)
        Me.gbxDatosGenerales.Controls.Add(Me.Label4)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbModalidad)
        Me.gbxDatosGenerales.Controls.Add(Me.Label9)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdEliminar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdAgregar)
        Me.gbxDatosGenerales.Controls.Add(Me.grdGradosA)
        Me.gbxDatosGenerales.Controls.Add(Me.spnOrden)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.chkSoloGuia)
        Me.gbxDatosGenerales.Controls.Add(Me.txtAbreviatura)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.txtNombre)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(22, 4)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(705, 550)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'chkCuantitativa
        '
        Me.chkCuantitativa.AutoSize = True
        Me.chkCuantitativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCuantitativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuantitativa.Location = New System.Drawing.Point(256, 244)
        Me.chkCuantitativa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCuantitativa.Name = "chkCuantitativa"
        Me.chkCuantitativa.Size = New System.Drawing.Size(116, 21)
        Me.chkCuantitativa.TabIndex = 133
        Me.chkCuantitativa.Text = "Cuantitativa"
        Me.chkCuantitativa.UseVisualStyleBackColor = True
        '
        'chkCualitativa
        '
        Me.chkCualitativa.AutoSize = True
        Me.chkCualitativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCualitativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCualitativa.Location = New System.Drawing.Point(141, 244)
        Me.chkCualitativa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCualitativa.Name = "chkCualitativa"
        Me.chkCualitativa.Size = New System.Drawing.Size(106, 21)
        Me.chkCualitativa.TabIndex = 132
        Me.chkCualitativa.Text = "Cualitativa"
        Me.chkCualitativa.UseVisualStyleBackColor = True
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
        Me.cmbParcial.Location = New System.Drawing.Point(141, 208)
        Me.cmbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParcial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbParcial.MaxDropDownItems = CType(5, Short)
        Me.cmbParcial.MaxLength = 32767
        Me.cmbParcial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbParcial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbParcial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbParcial.Size = New System.Drawing.Size(231, 24)
        Me.cmbParcial.TabIndex = 131
        Me.cmbParcial.Tag = "OBLIGATORIO"
        Me.cmbParcial.PropBag = resources.GetString("cmbParcial.PropBag")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 22)
        Me.Label4.TabIndex = 130
        Me.Label4.Tag = ""
        Me.Label4.Text = "Parcial:"
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
        Me.cmbModalidad.Location = New System.Drawing.Point(141, 174)
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
        Me.cmbModalidad.TabIndex = 123
        Me.cmbModalidad.Tag = "OBLIGATORIO"
        Me.cmbModalidad.PropBag = resources.GetString("cmbModalidad.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 176)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Modalidad:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdEliminar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(608, 231)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminar.TabIndex = 115
        Me.cmdEliminar.Tag = "AGREGAR"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(558, 231)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 114
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'grdGradosA
        '
        Me.grdGradosA.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Location = New System.Drawing.Point(38, 278)
        Me.grdGradosA.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGradosA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGradosA.MainView = Me.grdGradosATable
        Me.grdGradosA.Margin = New System.Windows.Forms.Padding(4)
        Me.grdGradosA.Name = "grdGradosA"
        Me.grdGradosA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4, Me.RepositoryItemDateEdit2})
        Me.grdGradosA.Size = New System.Drawing.Size(618, 263)
        Me.grdGradosA.TabIndex = 113
        Me.grdGradosA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGradosATable, Me.GridView3})
        '
        'grdGradosATable
        '
        Me.grdGradosATable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colModalidadID, Me.colModalidad, Me.colParcial, Me.colParcialID, Me.ColCualitativa, Me.colCuantitativa})
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
        'colModalidadID
        '
        Me.colModalidadID.Caption = "ModalidadID"
        Me.colModalidadID.FieldName = "ModalidadID"
        Me.colModalidadID.Name = "colModalidadID"
        Me.colModalidadID.OptionsColumn.AllowEdit = False
        Me.colModalidadID.OptionsColumn.AllowFocus = False
        Me.colModalidadID.OptionsColumn.ReadOnly = True
        Me.colModalidadID.Width = 109
        '
        'colModalidad
        '
        Me.colModalidad.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colModalidad.AppearanceCell.Options.UseBackColor = True
        Me.colModalidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModalidad.AppearanceHeader.Options.UseFont = True
        Me.colModalidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModalidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModalidad.Caption = "Modalidad"
        Me.colModalidad.FieldName = "Modalidad"
        Me.colModalidad.Name = "colModalidad"
        Me.colModalidad.OptionsColumn.AllowEdit = False
        Me.colModalidad.OptionsColumn.AllowFocus = False
        Me.colModalidad.OptionsColumn.ReadOnly = True
        Me.colModalidad.Visible = True
        Me.colModalidad.VisibleIndex = 1
        Me.colModalidad.Width = 146
        '
        'colParcial
        '
        Me.colParcial.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colParcial.AppearanceHeader.Options.UseFont = True
        Me.colParcial.AppearanceHeader.Options.UseTextOptions = True
        Me.colParcial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colParcial.Caption = "Parcial"
        Me.colParcial.FieldName = "Parcial"
        Me.colParcial.Name = "colParcial"
        Me.colParcial.OptionsColumn.AllowEdit = False
        Me.colParcial.OptionsColumn.AllowFocus = False
        Me.colParcial.OptionsColumn.ReadOnly = True
        Me.colParcial.Visible = True
        Me.colParcial.VisibleIndex = 2
        Me.colParcial.Width = 144
        '
        'colParcialID
        '
        Me.colParcialID.Caption = "ParcialID"
        Me.colParcialID.FieldName = "ParcialID"
        Me.colParcialID.MinWidth = 25
        Me.colParcialID.Name = "colParcialID"
        Me.colParcialID.OptionsColumn.AllowEdit = False
        Me.colParcialID.OptionsColumn.AllowFocus = False
        Me.colParcialID.Width = 94
        '
        'ColCualitativa
        '
        Me.ColCualitativa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColCualitativa.AppearanceHeader.Options.UseFont = True
        Me.ColCualitativa.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCualitativa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCualitativa.Caption = "Cualitativa"
        Me.ColCualitativa.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.ColCualitativa.FieldName = "Cualitativa"
        Me.ColCualitativa.MinWidth = 25
        Me.ColCualitativa.Name = "ColCualitativa"
        Me.ColCualitativa.OptionsColumn.AllowEdit = False
        Me.ColCualitativa.OptionsColumn.AllowFocus = False
        Me.ColCualitativa.Visible = True
        Me.ColCualitativa.VisibleIndex = 3
        Me.ColCualitativa.Width = 115
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'colCuantitativa
        '
        Me.colCuantitativa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCuantitativa.AppearanceHeader.Options.UseFont = True
        Me.colCuantitativa.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuantitativa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuantitativa.Caption = "Cuantitativa"
        Me.colCuantitativa.ColumnEdit = Me.RepositoryItemCheckEdit4
        Me.colCuantitativa.FieldName = "Cuantitativa"
        Me.colCuantitativa.MinWidth = 25
        Me.colCuantitativa.Name = "colCuantitativa"
        Me.colCuantitativa.OptionsColumn.AllowEdit = False
        Me.colCuantitativa.OptionsColumn.AllowFocus = False
        Me.colCuantitativa.Visible = True
        Me.colCuantitativa.VisibleIndex = 4
        Me.colCuantitativa.Width = 118
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
        'spnOrden
        '
        Me.spnOrden.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnOrden.Location = New System.Drawing.Point(239, 99)
        Me.spnOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.spnOrden.Name = "spnOrden"
        Me.spnOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnOrden.Properties.Mask.EditMask = "n0"
        Me.spnOrden.Size = New System.Drawing.Size(133, 22)
        Me.spnOrden.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Orden:"
        '
        'chkSoloGuia
        '
        Me.chkSoloGuia.AutoSize = True
        Me.chkSoloGuia.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSoloGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloGuia.Location = New System.Drawing.Point(7, 133)
        Me.chkSoloGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSoloGuia.Name = "chkSoloGuia"
        Me.chkSoloGuia.Size = New System.Drawing.Size(282, 21)
        Me.chkSoloGuia.TabIndex = 4
        Me.chkSoloGuia.Text = "Calificada solo por el maestro guía"
        Me.chkSoloGuia.UseVisualStyleBackColor = True
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(239, 71)
        Me.txtAbreviatura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(371, 23)
        Me.txtAbreviatura.TabIndex = 2
        Me.txtAbreviatura.TabStop = False
        Me.txtAbreviatura.Tag = "BLOQUEADO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Abreviatura:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(239, 15)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(371, 23)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Código:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(536, 104)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 3
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(239, 43)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(371, 23)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TabStop = False
        Me.txtNombre.Tag = "BLOQUEADO"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(7, 48)
        Me.lblSfaPromocionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(69, 17)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Nombre:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 609)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraAsignaturasEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraAsignaturasEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar asignatura"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGradosATable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkSoloGuia As System.Windows.Forms.CheckBox
    Friend WithEvents spnOrden As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents grdGradosA As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGradosATable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colModalidadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colParcialID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCualitativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCuantitativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbModalidad As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As Label
    Friend WithEvents chkCuantitativa As CheckBox
    Friend WithEvents chkCualitativa As CheckBox
    Friend WithEvents cmbParcial As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As Label
End Class
