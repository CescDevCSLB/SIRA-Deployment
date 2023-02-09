<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccAplicarDeducciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccAplicarDeducciones))
        Me.tbControl = New System.Windows.Forms.TabControl()
        Me.tbpDetMensualidades = New System.Windows.Forms.TabPage()
        Me.grdMensualidades = New DevExpress.XtraGrid.GridControl()
        Me.grdMensualidadesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMontoCordobas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIncluir = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkIncluir = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbonar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkAbonar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCancelar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkCancelar = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colMontoAbonar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmbConceptoRecibo = New C1.Win.C1List.C1Combo()
        Me.grdAsigmacion = New DevExpress.XtraGrid.GridControl()
        Me.grdAsignacionTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.colConceptoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeloMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numMontoDetalle = New C1.Win.C1Input.C1NumericEdit()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTotalFact = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtTotalFact = New C1.Win.C1Input.C1NumericEdit()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbPeriodos = New C1.Win.C1List.C1Combo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNumRecibo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblRecibo = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstadoCuenta = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.tbControl.SuspendLayout()
        Me.tbpDetMensualidades.SuspendLayout()
        CType(Me.grdMensualidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMensualidadesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAbonar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbConceptoRecibo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAsigmacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAsignacionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMontoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.tbpDetMensualidades)
        Me.tbControl.Location = New System.Drawing.Point(12, 110)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(636, 289)
        Me.tbControl.TabIndex = 2
        '
        'tbpDetMensualidades
        '
        Me.tbpDetMensualidades.Controls.Add(Me.grdMensualidades)
        Me.tbpDetMensualidades.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetMensualidades.Name = "tbpDetMensualidades"
        Me.tbpDetMensualidades.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDetMensualidades.Size = New System.Drawing.Size(628, 263)
        Me.tbpDetMensualidades.TabIndex = 0
        Me.tbpDetMensualidades.Text = "Detalle de mensalidades"
        Me.tbpDetMensualidades.UseVisualStyleBackColor = True
        '
        'grdMensualidades
        '
        Me.grdMensualidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMensualidades.Location = New System.Drawing.Point(3, 3)
        Me.grdMensualidades.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdMensualidades.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdMensualidades.MainView = Me.grdMensualidadesTabla
        Me.grdMensualidades.Name = "grdMensualidades"
        Me.grdMensualidades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkIncluir, Me.chkCancelar, Me.chkAbonar})
        Me.grdMensualidades.Size = New System.Drawing.Size(622, 257)
        Me.grdMensualidades.TabIndex = 98
        Me.grdMensualidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdMensualidadesTabla, Me.GridView1})
        '
        'grdMensualidadesTabla
        '
        Me.grdMensualidadesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMontoCordobas, Me.colIncluir, Me.colMes, Me.colMontoTotal, Me.colAbonar, Me.colCancelar, Me.colMontoAbonar, Me.colFecha, Me.colSaldos})
        Me.grdMensualidadesTabla.GridControl = Me.grdMensualidades
        Me.grdMensualidadesTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdMensualidadesTabla.Name = "grdMensualidadesTabla"
        Me.grdMensualidadesTabla.OptionsView.ColumnAutoWidth = False
        Me.grdMensualidadesTabla.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdMensualidadesTabla.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
        Me.grdMensualidadesTabla.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.grdMensualidadesTabla.OptionsView.ShowGroupPanel = False
        Me.grdMensualidadesTabla.OptionsView.ShowGroupPanelColumnsAsSingleRow = True
        '
        'colMontoCordobas
        '
        Me.colMontoCordobas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoCordobas.AppearanceHeader.Options.UseFont = True
        Me.colMontoCordobas.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoCordobas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoCordobas.Caption = "Saldo C$"
        Me.colMontoCordobas.FieldName = "MontoCordobas"
        Me.colMontoCordobas.Name = "colMontoCordobas"
        Me.colMontoCordobas.OptionsColumn.AllowEdit = False
        Me.colMontoCordobas.Visible = True
        Me.colMontoCordobas.VisibleIndex = 4
        Me.colMontoCordobas.Width = 101
        '
        'colIncluir
        '
        Me.colIncluir.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colIncluir.AppearanceHeader.Options.UseFont = True
        Me.colIncluir.AppearanceHeader.Options.UseTextOptions = True
        Me.colIncluir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colIncluir.Caption = "Incluir"
        Me.colIncluir.ColumnEdit = Me.chkIncluir
        Me.colIncluir.FieldName = "Seleccion"
        Me.colIncluir.Name = "colIncluir"
        Me.colIncluir.Visible = True
        Me.colIncluir.VisibleIndex = 0
        Me.colIncluir.Width = 73
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoHeight = False
        Me.chkIncluir.Name = "chkIncluir"
        '
        'colMes
        '
        Me.colMes.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMes.AppearanceHeader.Options.UseFont = True
        Me.colMes.AppearanceHeader.Options.UseTextOptions = True
        Me.colMes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "MesLetra"
        Me.colMes.Name = "colMes"
        Me.colMes.OptionsColumn.AllowEdit = False
        Me.colMes.OptionsColumn.ReadOnly = True
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 1
        Me.colMes.Width = 180
        '
        'colMontoTotal
        '
        Me.colMontoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoTotal.AppearanceHeader.Options.UseFont = True
        Me.colMontoTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoTotal.Caption = "Monto Total"
        Me.colMontoTotal.FieldName = "MontoInicial"
        Me.colMontoTotal.Name = "colMontoTotal"
        Me.colMontoTotal.OptionsColumn.AllowEdit = False
        Me.colMontoTotal.OptionsColumn.AllowFocus = False
        Me.colMontoTotal.OptionsColumn.ReadOnly = True
        Me.colMontoTotal.Visible = True
        Me.colMontoTotal.VisibleIndex = 3
        Me.colMontoTotal.Width = 121
        '
        'colAbonar
        '
        Me.colAbonar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAbonar.AppearanceHeader.Options.UseFont = True
        Me.colAbonar.AppearanceHeader.Options.UseTextOptions = True
        Me.colAbonar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAbonar.Caption = "Abonar"
        Me.colAbonar.ColumnEdit = Me.chkAbonar
        Me.colAbonar.FieldName = "Abonar"
        Me.colAbonar.Name = "colAbonar"
        Me.colAbonar.Width = 83
        '
        'chkAbonar
        '
        Me.chkAbonar.AutoHeight = False
        Me.chkAbonar.Name = "chkAbonar"
        '
        'colCancelar
        '
        Me.colCancelar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCancelar.AppearanceHeader.Options.UseFont = True
        Me.colCancelar.AppearanceHeader.Options.UseTextOptions = True
        Me.colCancelar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCancelar.Caption = "Cancelar"
        Me.colCancelar.ColumnEdit = Me.chkCancelar
        Me.colCancelar.FieldName = "Cancelar"
        Me.colCancelar.Name = "colCancelar"
        Me.colCancelar.Width = 81
        '
        'chkCancelar
        '
        Me.chkCancelar.AutoHeight = False
        Me.chkCancelar.Name = "chkCancelar"
        '
        'colMontoAbonar
        '
        Me.colMontoAbonar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoAbonar.AppearanceHeader.Options.UseFont = True
        Me.colMontoAbonar.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoAbonar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoAbonar.Caption = "Monto Abonar"
        Me.colMontoAbonar.FieldName = "CantAbonar"
        Me.colMontoAbonar.Name = "colMontoAbonar"
        Me.colMontoAbonar.Width = 137
        '
        'colFecha
        '
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "FechaVencimiento"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 2
        Me.colFecha.Width = 107
        '
        'colSaldos
        '
        Me.colSaldos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSaldos.AppearanceHeader.Options.UseFont = True
        Me.colSaldos.AppearanceHeader.Options.UseTextOptions = True
        Me.colSaldos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaldos.Caption = "Saldo $"
        Me.colSaldos.FieldName = "Saldo"
        Me.colSaldos.Name = "colSaldos"
        Me.colSaldos.OptionsColumn.AllowEdit = False
        Me.colSaldos.OptionsColumn.AllowFocus = False
        Me.colSaldos.Width = 98
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdMensualidades
        Me.GridView1.Name = "GridView1"
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
        Me.cmbConceptoRecibo.ContentHeight = 15
        Me.cmbConceptoRecibo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConceptoRecibo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConceptoRecibo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConceptoRecibo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConceptoRecibo.EditorHeight = 15
        Me.cmbConceptoRecibo.Images.Add(CType(resources.GetObject("cmbConceptoRecibo.Images"), System.Drawing.Image))
        Me.cmbConceptoRecibo.ItemHeight = 15
        Me.cmbConceptoRecibo.Location = New System.Drawing.Point(76, 39)
        Me.cmbConceptoRecibo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConceptoRecibo.MaxDropDownItems = CType(5, Short)
        Me.cmbConceptoRecibo.MaxLength = 32767
        Me.cmbConceptoRecibo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConceptoRecibo.Name = "cmbConceptoRecibo"
        Me.cmbConceptoRecibo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConceptoRecibo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConceptoRecibo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConceptoRecibo.Size = New System.Drawing.Size(200, 21)
        Me.cmbConceptoRecibo.TabIndex = 115
        Me.cmbConceptoRecibo.Tag = "OBLIGATORIO"
        Me.cmbConceptoRecibo.PropBag = resources.GetString("cmbConceptoRecibo.PropBag")
        '
        'grdAsigmacion
        '
        Me.grdAsigmacion.Location = New System.Drawing.Point(307, 13)
        Me.grdAsigmacion.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAsigmacion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAsigmacion.MainView = Me.grdAsignacionTable
        Me.grdAsigmacion.Name = "grdAsigmacion"
        Me.grdAsigmacion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoEdit1, Me.RepositoryItemSpinEdit1})
        Me.grdAsigmacion.Size = New System.Drawing.Size(407, 158)
        Me.grdAsigmacion.TabIndex = 20
        Me.grdAsigmacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdAsignacionTable, Me.GridView2})
        '
        'grdAsignacionTable
        '
        Me.grdAsignacionTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccionar, Me.colNombre, Me.colConceptoID, Me.colConcepto})
        Me.grdAsignacionTable.GridControl = Me.grdAsigmacion
        Me.grdAsignacionTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdAsignacionTable.Name = "grdAsignacionTable"
        Me.grdAsignacionTable.OptionsSelection.MultiSelect = True
        Me.grdAsignacionTable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdAsignacionTable.OptionsView.ShowAutoFilterRow = True
        Me.grdAsignacionTable.OptionsView.ShowGroupPanel = False
        '
        'colSeleccionar
        '
        Me.colSeleccionar.Caption = "Seleccionar"
        Me.colSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSeleccionar.FieldName = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colNombre
        '
        Me.colNombre.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colNombre.AppearanceCell.Options.UseBackColor = True
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Monto"
        Me.colNombre.ColumnEdit = Me.RepositoryItemSpinEdit1
        Me.colNombre.FieldName = "Monto"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowFocus = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 131
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'colConceptoID
        '
        Me.colConceptoID.Caption = "objEvidenciasID"
        Me.colConceptoID.FieldName = "objConceptoID"
        Me.colConceptoID.Name = "colConceptoID"
        '
        'colConcepto
        '
        Me.colConcepto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colConcepto.AppearanceHeader.Options.UseFont = True
        Me.colConcepto.AppearanceHeader.Options.UseTextOptions = True
        Me.colConcepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 1
        Me.colConcepto.Width = 183
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ReadOnly = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSccCuentaID, Me.colProducto, Me.colModeloMarca, Me.colSaldo})
        Me.GridView2.GridControl = Me.grdAsigmacion
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'ColSccCuentaID
        '
        Me.ColSccCuentaID.Caption = "SccCuentaID"
        Me.ColSccCuentaID.FieldName = "SccCuentaID"
        Me.ColSccCuentaID.Name = "ColSccCuentaID"
        Me.ColSccCuentaID.Visible = True
        Me.ColSccCuentaID.VisibleIndex = 0
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.OptionsColumn.AllowEdit = False
        Me.colProducto.OptionsFilter.AllowAutoFilter = False
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        '
        'colModeloMarca
        '
        Me.colModeloMarca.Caption = "Modelo/Marca"
        Me.colModeloMarca.FieldName = "ModeloMarca"
        Me.colModeloMarca.Name = "colModeloMarca"
        Me.colModeloMarca.OptionsColumn.AllowEdit = False
        Me.colModeloMarca.OptionsFilter.AllowAutoFilter = False
        Me.colModeloMarca.Visible = True
        Me.colModeloMarca.VisibleIndex = 2
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowEdit = False
        Me.colSaldo.OptionsFilter.AllowAutoFilter = False
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Tag = "OBLIGATORIO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(10, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 21
        '
        'numMontoDetalle
        '
        Me.numMontoDetalle.BackColor = System.Drawing.Color.Transparent
        Me.numMontoDetalle.Enabled = False
        Me.numMontoDetalle.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoDetalle.Location = New System.Drawing.Point(182, 92)
        Me.numMontoDetalle.Name = "numMontoDetalle"
        Me.numMontoDetalle.Size = New System.Drawing.Size(88, 20)
        Me.numMontoDetalle.TabIndex = 22
        Me.numMontoDetalle.Tag = Nothing
        Me.numMontoDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numMontoDetalle.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numMontoDetalle.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.Location = New System.Drawing.Point(223, 129)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregar.TabIndex = 18
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Appearance.Options.UseFont = True
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(259, 129)
        Me.cmdDelete.LookAndFeel.SkinName = "Caramel"
        Me.cmdDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(32, 28)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Tag = "AGREGAR"
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "Eliminar.ico")
        '
        'lblTotalFact
        '
        Me.lblTotalFact.AutoSize = True
        Me.lblTotalFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFact.ForeColor = System.Drawing.Color.Black
        Me.lblTotalFact.Location = New System.Drawing.Point(421, 402)
        Me.lblTotalFact.Name = "lblTotalFact"
        Me.lblTotalFact.Size = New System.Drawing.Size(97, 13)
        Me.lblTotalFact.TabIndex = 7
        Me.lblTotalFact.Text = "Total  a aplicar:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'lblError
        '
        Me.lblError.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblError.Location = New System.Drawing.Point(12, 448)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(18, 18)
        Me.lblError.TabIndex = 14
        '
        'txtTotalFact
        '
        Me.txtTotalFact.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalFact.DisplayFormat.CustomFormat = "$ #,##0.00"
        Me.txtTotalFact.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalFact.Enabled = False
        Me.txtTotalFact.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalFact.Location = New System.Drawing.Point(521, 399)
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.Size = New System.Drawing.Size(123, 21)
        Me.txtTotalFact.TabIndex = 0
        Me.txtTotalFact.Tag = "BLOQUEADO"
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFact.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalFact.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cmbPeriodos
        '
        Me.cmbPeriodos.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPeriodos.AutoCompletion = True
        Me.cmbPeriodos.AutoDropDown = True
        Me.cmbPeriodos.Caption = ""
        Me.cmbPeriodos.CaptionHeight = 17
        Me.cmbPeriodos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPeriodos.ColumnCaptionHeight = 17
        Me.cmbPeriodos.ColumnFooterHeight = 17
        Me.cmbPeriodos.ContentHeight = 15
        Me.cmbPeriodos.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodos.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodos.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodos.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodos.EditorHeight = 15
        Me.cmbPeriodos.Images.Add(CType(resources.GetObject("cmbPeriodos.Images"), System.Drawing.Image))
        Me.cmbPeriodos.ItemHeight = 15
        Me.cmbPeriodos.Location = New System.Drawing.Point(80, 69)
        Me.cmbPeriodos.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodos.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodos.MaxLength = 32767
        Me.cmbPeriodos.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodos.Name = "cmbPeriodos"
        Me.cmbPeriodos.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodos.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodos.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodos.Size = New System.Drawing.Size(160, 21)
        Me.cmbPeriodos.TabIndex = 114
        Me.cmbPeriodos.Tag = "OBLIGATORIO"
        Me.cmbPeriodos.PropBag = resources.GetString("cmbPeriodos.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Tag = "OBLIGATORIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Tag = "OBLIGATORIO"
        '
        'txtEstado
        '
        Me.txtEstado.Enabled = False
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(80, 43)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(159, 20)
        Me.txtEstado.TabIndex = 1
        Me.txtEstado.Tag = "BLOQUEADO"
        '
        'txtNumRecibo
        '
        Me.txtNumRecibo.Enabled = False
        Me.txtNumRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRecibo.Location = New System.Drawing.Point(80, 17)
        Me.txtNumRecibo.Name = "txtNumRecibo"
        Me.txtNumRecibo.Size = New System.Drawing.Size(159, 20)
        Me.txtNumRecibo.TabIndex = 0
        Me.txtNumRecibo.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(7, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 132
        '
        'lblRecibo
        '
        Me.lblRecibo.AutoSize = True
        Me.lblRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibo.ForeColor = System.Drawing.Color.Black
        Me.lblRecibo.Location = New System.Drawing.Point(6, 20)
        Me.lblRecibo.Name = "lblRecibo"
        Me.lblRecibo.Size = New System.Drawing.Size(71, 13)
        Me.lblRecibo.TabIndex = 0
        Me.lblRecibo.Tag = "OBLIGATORIO"
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
        Me.cmbMoeda.Location = New System.Drawing.Point(80, 96)
        Me.cmbMoeda.MatchEntryTimeout = CType(2000, Long)
        Me.cmbMoeda.MaxDropDownItems = CType(5, Short)
        Me.cmbMoeda.MaxLength = 32767
        Me.cmbMoeda.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbMoeda.Name = "cmbMoeda"
        Me.cmbMoeda.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbMoeda.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbMoeda.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbMoeda.Size = New System.Drawing.Size(200, 21)
        Me.cmbMoeda.TabIndex = 131
        Me.cmbMoeda.Tag = "OBLIGATORIO"
        Me.cmbMoeda.PropBag = resources.GetString("cmbMoeda.PropBag")
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.Label3)
        Me.GrpExpediente.Controls.Add(Me.txtEstadoCuenta)
        Me.GrpExpediente.Controls.Add(Me.txtCuenta)
        Me.GrpExpediente.Controls.Add(Me.lblCuenta)
        Me.GrpExpediente.Controls.Add(Me.txtIdentificacion)
        Me.GrpExpediente.Controls.Add(Me.Label5)
        Me.GrpExpediente.Controls.Add(Me.txtNombreCompleto)
        Me.GrpExpediente.Controls.Add(Me.Label9)
        Me.GrpExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpExpediente.Location = New System.Drawing.Point(15, 8)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(634, 96)
        Me.GrpExpediente.TabIndex = 18
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Persona"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(309, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Estado:"
        '
        'txtEstadoCuenta
        '
        Me.txtEstadoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoCuenta.Location = New System.Drawing.Point(374, 15)
        Me.txtEstadoCuenta.Name = "txtEstadoCuenta"
        Me.txtEstadoCuenta.ReadOnly = True
        Me.txtEstadoCuenta.Size = New System.Drawing.Size(205, 20)
        Me.txtEstadoCuenta.TabIndex = 118
        Me.txtEstadoCuenta.Tag = "BLOQUEADO"
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(148, 19)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(122, 20)
        Me.txtCuenta.TabIndex = 115
        Me.txtCuenta.Tag = "BLOQUEADO"
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.ForeColor = System.Drawing.Color.Black
        Me.lblCuenta.Location = New System.Drawing.Point(15, 22)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(98, 13)
        Me.lblCuenta.TabIndex = 116
        Me.lblCuenta.Text = "No. Expediente:"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.Location = New System.Drawing.Point(148, 66)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.ReadOnly = True
        Me.txtIdentificacion.Size = New System.Drawing.Size(211, 20)
        Me.txtIdentificacion.TabIndex = 121
        Me.txtIdentificacion.Tag = "BLOQUEADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(15, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "Cédula:"
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompleto.Location = New System.Drawing.Point(148, 42)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.ReadOnly = True
        Me.txtNombreCompleto.Size = New System.Drawing.Size(431, 20)
        Me.txtNombreCompleto.TabIndex = 120
        Me.txtNombreCompleto.Tag = "BLOQUEADO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Nombre Completo"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 470)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 18)
        Me.Panel1.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTotalFact)
        Me.PanelControl1.Controls.Add(Me.tbControl)
        Me.PanelControl1.Controls.Add(Me.GrpExpediente)
        Me.PanelControl1.Controls.Add(Me.lblTotalFact)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(666, 488)
        Me.PanelControl1.TabIndex = 99
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(577, 436)
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
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(491, 436)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aplicar"
        '
        'frmSccAplicarDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 488)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSccAplicarDeducciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Aplicar deducciones"
        Me.tbControl.ResumeLayout(False)
        Me.tbpDetMensualidades.ResumeLayout(False)
        CType(Me.grdMensualidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMensualidadesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAbonar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbConceptoRecibo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAsigmacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAsignacionTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMontoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetMensualidades As System.Windows.Forms.TabPage
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtNumRecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblRecibo As System.Windows.Forms.Label
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodos As C1.Win.C1List.C1Combo
    Friend WithEvents cmbConceptoRecibo As C1.Win.C1List.C1Combo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents grdAsigmacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdAsignacionTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents colConceptoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeloMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents numMontoDetalle As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdMensualidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdMensualidadesTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIncluir As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkIncluir As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbonar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkAbonar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCancelar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCancelar As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMontoAbonar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMontoCordobas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEstadoCuenta As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents lblCuenta As Label
    Friend WithEvents txtIdentificacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents Label9 As Label
End Class
