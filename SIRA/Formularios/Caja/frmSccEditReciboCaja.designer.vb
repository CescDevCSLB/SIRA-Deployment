<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccEditReciboCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccEditReciboCaja))
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
        Me.RepositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdNotaDebito = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbpFormasPago = New System.Windows.Forms.TabPage()
        Me.grpFormaPago = New System.Windows.Forms.GroupBox()
        Me.cmbConceptoMensualidad = New C1.Win.C1List.C1Combo()
        Me.lblConceptoRecibo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkDólares = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.numConvertirT = New C1.Win.C1Input.C1NumericEdit()
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
        Me.NumMontoDolares = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMontoRecibo = New System.Windows.Forms.Label()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalFact = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        Me.txtTotalFact = New C1.Win.C1Input.C1NumericEdit()
        Me.txtTotalPagar = New C1.Win.C1Input.C1NumericEdit()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpDatosRecibos = New System.Windows.Forms.GroupBox()
        Me.cmbPeriodos = New C1.Win.C1List.C1Combo()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtNumRecibo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblRecibo = New System.Windows.Forms.Label()
        Me.cmbMoeda = New C1.Win.C1List.C1Combo()
        Me.dtpFecha = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpExpediente = New System.Windows.Forms.GroupBox()
        Me.chkEsPrestamo = New System.Windows.Forms.CheckBox()
        Me.SpnPorcentaje = New DevExpress.XtraEditors.SpinEdit()
        Me.txtAtencionA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.cmdExpediente = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNumCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMontRest = New System.Windows.Forms.Label()
        Me.lblMontAbon = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMontoRestante = New System.Windows.Forms.Label()
        Me.lblMontoAbonado = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdBuscarCuenta = New System.Windows.Forms.Button()
        Me.lblCuenta = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbTipoPago = New C1.Win.C1List.C1Combo()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbCajero = New C1.Win.C1List.C1Combo()
        Me.txtTasaCambio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTotalDB = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.tbControl.SuspendLayout()
        Me.tbpDetMensualidades.SuspendLayout()
        CType(Me.grdMensualidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMensualidadesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAbonar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpFormasPago.SuspendLayout()
        Me.grpFormaPago.SuspendLayout()
        CType(Me.cmbConceptoMensualidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numConvertirT, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDatosRecibos.SuspendLayout()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpExpediente.SuspendLayout()
        CType(Me.SpnPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbControl
        '
        Me.tbControl.Controls.Add(Me.tbpDetMensualidades)
        Me.tbControl.Controls.Add(Me.tbpFormasPago)
        Me.tbControl.Location = New System.Drawing.Point(7, 152)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.SelectedIndex = 0
        Me.tbControl.Size = New System.Drawing.Size(1023, 249)
        Me.tbControl.TabIndex = 2
        '
        'tbpDetMensualidades
        '
        Me.tbpDetMensualidades.Controls.Add(Me.grdMensualidades)
        Me.tbpDetMensualidades.Controls.Add(Me.grdNotaDebito)
        Me.tbpDetMensualidades.Location = New System.Drawing.Point(4, 22)
        Me.tbpDetMensualidades.Name = "tbpDetMensualidades"
        Me.tbpDetMensualidades.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpDetMensualidades.Size = New System.Drawing.Size(1015, 223)
        Me.tbpDetMensualidades.TabIndex = 0
        Me.tbpDetMensualidades.Text = "Detalle de mensalidades"
        Me.tbpDetMensualidades.UseVisualStyleBackColor = True
        '
        'grdMensualidades
        '
        Me.grdMensualidades.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdMensualidades.Location = New System.Drawing.Point(3, 3)
        Me.grdMensualidades.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdMensualidades.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdMensualidades.MainView = Me.grdMensualidadesTabla
        Me.grdMensualidades.Name = "grdMensualidades"
        Me.grdMensualidades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkIncluir, Me.chkCancelar, Me.chkAbonar, Me.RepositoryItemSpinEdit2})
        Me.grdMensualidades.Size = New System.Drawing.Size(1009, 124)
        Me.grdMensualidades.TabIndex = 98
        Me.grdMensualidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdMensualidadesTabla, Me.GridView1})
        '
        'grdMensualidadesTabla
        '
        Me.grdMensualidadesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMontoCordobas, Me.colIncluir, Me.colMes, Me.colMontoTotal, Me.colAbonar, Me.colCancelar, Me.colMontoAbonar, Me.colFecha, Me.colSaldos})
        Me.grdMensualidadesTabla.DetailHeight = 284
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
        Me.colMontoCordobas.MinWidth = 15
        Me.colMontoCordobas.Name = "colMontoCordobas"
        Me.colMontoCordobas.OptionsColumn.AllowEdit = False
        Me.colMontoCordobas.Visible = True
        Me.colMontoCordobas.VisibleIndex = 8
        Me.colMontoCordobas.Width = 65
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
        Me.colIncluir.MinWidth = 15
        Me.colIncluir.Name = "colIncluir"
        Me.colIncluir.Visible = True
        Me.colIncluir.VisibleIndex = 0
        Me.colIncluir.Width = 55
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
        Me.colMes.MinWidth = 15
        Me.colMes.Name = "colMes"
        Me.colMes.OptionsColumn.AllowEdit = False
        Me.colMes.OptionsColumn.ReadOnly = True
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 1
        Me.colMes.Width = 115
        '
        'colMontoTotal
        '
        Me.colMontoTotal.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoTotal.AppearanceHeader.Options.UseFont = True
        Me.colMontoTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoTotal.Caption = "Monto Total"
        Me.colMontoTotal.FieldName = "MontoInicial"
        Me.colMontoTotal.MinWidth = 15
        Me.colMontoTotal.Name = "colMontoTotal"
        Me.colMontoTotal.OptionsColumn.AllowEdit = False
        Me.colMontoTotal.OptionsColumn.AllowFocus = False
        Me.colMontoTotal.OptionsColumn.ReadOnly = True
        Me.colMontoTotal.Visible = True
        Me.colMontoTotal.VisibleIndex = 2
        Me.colMontoTotal.Width = 100
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
        Me.colAbonar.MinWidth = 15
        Me.colAbonar.Name = "colAbonar"
        Me.colAbonar.Visible = True
        Me.colAbonar.VisibleIndex = 3
        Me.colAbonar.Width = 62
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
        Me.colCancelar.MinWidth = 15
        Me.colCancelar.Name = "colCancelar"
        Me.colCancelar.Visible = True
        Me.colCancelar.VisibleIndex = 4
        Me.colCancelar.Width = 61
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
        Me.colMontoAbonar.MinWidth = 15
        Me.colMontoAbonar.Name = "colMontoAbonar"
        Me.colMontoAbonar.Visible = True
        Me.colMontoAbonar.VisibleIndex = 5
        Me.colMontoAbonar.Width = 103
        '
        'colFecha
        '
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "FechaVencimiento"
        Me.colFecha.MinWidth = 15
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 6
        Me.colFecha.Width = 90
        '
        'colSaldos
        '
        Me.colSaldos.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSaldos.AppearanceHeader.Options.UseFont = True
        Me.colSaldos.AppearanceHeader.Options.UseTextOptions = True
        Me.colSaldos.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaldos.Caption = "Saldo $"
        Me.colSaldos.FieldName = "Saldo"
        Me.colSaldos.MinWidth = 15
        Me.colSaldos.Name = "colSaldos"
        Me.colSaldos.OptionsColumn.AllowEdit = False
        Me.colSaldos.OptionsColumn.AllowFocus = False
        Me.colSaldos.Visible = True
        Me.colSaldos.VisibleIndex = 7
        Me.colSaldos.Width = 73
        '
        'RepositoryItemSpinEdit2
        '
        Me.RepositoryItemSpinEdit2.AutoHeight = False
        Me.RepositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatString = "#,##"
        Me.RepositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit2.Name = "RepositoryItemSpinEdit2"
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 284
        Me.GridView1.GridControl = Me.grdMensualidades
        Me.GridView1.Name = "GridView1"
        '
        'grdNotaDebito
        '
        Me.grdNotaDebito.AllowColMove = False
        Me.grdNotaDebito.Caption = "Mora"
        Me.grdNotaDebito.CaptionHeight = 17
        Me.grdNotaDebito.ExtendRightColumn = True
        Me.grdNotaDebito.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdNotaDebito.Images.Add(CType(resources.GetObject("grdNotaDebito.Images"), System.Drawing.Image))
        Me.grdNotaDebito.Location = New System.Drawing.Point(3, 124)
        Me.grdNotaDebito.Name = "grdNotaDebito"
        Me.grdNotaDebito.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdNotaDebito.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdNotaDebito.PreviewInfo.ZoomFactor = 75.0R
        Me.grdNotaDebito.PrintInfo.PageSettings = CType(resources.GetObject("grdNotaDebito.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdNotaDebito.RowHeight = 15
        Me.grdNotaDebito.Size = New System.Drawing.Size(1009, 102)
        Me.grdNotaDebito.TabIndex = 1
        Me.grdNotaDebito.PropBag = resources.GetString("grdNotaDebito.PropBag")
        '
        'tbpFormasPago
        '
        Me.tbpFormasPago.Controls.Add(Me.grpFormaPago)
        Me.tbpFormasPago.Controls.Add(Me.cmdEliminar)
        Me.tbpFormasPago.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormasPago.Name = "tbpFormasPago"
        Me.tbpFormasPago.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpFormasPago.Size = New System.Drawing.Size(1015, 223)
        Me.tbpFormasPago.TabIndex = 2
        Me.tbpFormasPago.Text = "Pago"
        Me.tbpFormasPago.UseVisualStyleBackColor = True
        '
        'grpFormaPago
        '
        Me.grpFormaPago.Controls.Add(Me.cmbConceptoMensualidad)
        Me.grpFormaPago.Controls.Add(Me.lblConceptoRecibo)
        Me.grpFormaPago.Controls.Add(Me.GroupBox2)
        Me.grpFormaPago.Controls.Add(Me.NumMontoDolares)
        Me.grpFormaPago.Controls.Add(Me.lblMontoRecibo)
        Me.grpFormaPago.Location = New System.Drawing.Point(8, 18)
        Me.grpFormaPago.Name = "grpFormaPago"
        Me.grpFormaPago.Size = New System.Drawing.Size(978, 199)
        Me.grpFormaPago.TabIndex = 14
        Me.grpFormaPago.TabStop = False
        '
        'cmbConceptoMensualidad
        '
        Me.cmbConceptoMensualidad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbConceptoMensualidad.AutoCompletion = True
        Me.cmbConceptoMensualidad.AutoDropDown = True
        Me.cmbConceptoMensualidad.Caption = ""
        Me.cmbConceptoMensualidad.CaptionHeight = 17
        Me.cmbConceptoMensualidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbConceptoMensualidad.ColumnCaptionHeight = 17
        Me.cmbConceptoMensualidad.ColumnFooterHeight = 17
        Me.cmbConceptoMensualidad.ContentHeight = 15
        Me.cmbConceptoMensualidad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbConceptoMensualidad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbConceptoMensualidad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbConceptoMensualidad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbConceptoMensualidad.EditorHeight = 15
        Me.cmbConceptoMensualidad.Images.Add(CType(resources.GetObject("cmbConceptoMensualidad.Images"), System.Drawing.Image))
        Me.cmbConceptoMensualidad.ItemHeight = 15
        Me.cmbConceptoMensualidad.Location = New System.Drawing.Point(6, 54)
        Me.cmbConceptoMensualidad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbConceptoMensualidad.MaxDropDownItems = CType(5, Short)
        Me.cmbConceptoMensualidad.MaxLength = 32767
        Me.cmbConceptoMensualidad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbConceptoMensualidad.Name = "cmbConceptoMensualidad"
        Me.cmbConceptoMensualidad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbConceptoMensualidad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbConceptoMensualidad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbConceptoMensualidad.Size = New System.Drawing.Size(177, 21)
        Me.cmbConceptoMensualidad.TabIndex = 117
        Me.cmbConceptoMensualidad.Tag = "OBLIGATORIO"
        Me.cmbConceptoMensualidad.PropBag = resources.GetString("cmbConceptoMensualidad.PropBag")
        '
        'lblConceptoRecibo
        '
        Me.lblConceptoRecibo.AutoSize = True
        Me.lblConceptoRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConceptoRecibo.ForeColor = System.Drawing.Color.Black
        Me.lblConceptoRecibo.Location = New System.Drawing.Point(2, 32)
        Me.lblConceptoRecibo.Name = "lblConceptoRecibo"
        Me.lblConceptoRecibo.Size = New System.Drawing.Size(139, 13)
        Me.lblConceptoRecibo.TabIndex = 116
        Me.lblConceptoRecibo.Tag = "OBLIGATORIO"
        Me.lblConceptoRecibo.Text = "Concepto mensualidad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkDólares)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.numConvertirT)
        Me.GroupBox2.Controls.Add(Me.cmbConceptoRecibo)
        Me.GroupBox2.Controls.Add(Me.grdAsigmacion)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.numMontoDetalle)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(220, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(743, 176)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Otros pagos"
        '
        'chkDólares
        '
        Me.chkDólares.AutoSize = True
        Me.chkDólares.Location = New System.Drawing.Point(13, 66)
        Me.chkDólares.Name = "chkDólares"
        Me.chkDólares.Size = New System.Drawing.Size(69, 17)
        Me.chkDólares.TabIndex = 178
        Me.chkDólares.Text = "Dólares"
        Me.chkDólares.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(166, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(14, 13)
        Me.Label20.TabIndex = 177
        Me.Label20.Tag = ""
        Me.Label20.Text = "="
        '
        'numConvertirT
        '
        Me.numConvertirT.BackColor = System.Drawing.Color.Transparent
        Me.numConvertirT.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numConvertirT.Location = New System.Drawing.Point(76, 92)
        Me.numConvertirT.Name = "numConvertirT"
        Me.numConvertirT.Size = New System.Drawing.Size(88, 21)
        Me.numConvertirT.TabIndex = 175
        Me.numConvertirT.Tag = Nothing
        Me.numConvertirT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numConvertirT.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.numConvertirT.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
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
        Me.grdAsignacionTable.DetailHeight = 284
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
        Me.colSeleccionar.MinWidth = 15
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Width = 56
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
        Me.colNombre.MinWidth = 15
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowFocus = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 98
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
        Me.colConceptoID.MinWidth = 15
        Me.colConceptoID.Name = "colConceptoID"
        Me.colConceptoID.Width = 56
        '
        'colConcepto
        '
        Me.colConcepto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colConcepto.AppearanceHeader.Options.UseFont = True
        Me.colConcepto.AppearanceHeader.Options.UseTextOptions = True
        Me.colConcepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.MinWidth = 15
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 1
        Me.colConcepto.Width = 137
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
        Me.GridView2.DetailHeight = 284
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
        Me.ColSccCuentaID.MinWidth = 15
        Me.ColSccCuentaID.Name = "ColSccCuentaID"
        Me.ColSccCuentaID.Visible = True
        Me.ColSccCuentaID.VisibleIndex = 0
        Me.ColSccCuentaID.Width = 56
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.MinWidth = 15
        Me.colProducto.Name = "colProducto"
        Me.colProducto.OptionsColumn.AllowEdit = False
        Me.colProducto.OptionsFilter.AllowAutoFilter = False
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        Me.colProducto.Width = 56
        '
        'colModeloMarca
        '
        Me.colModeloMarca.Caption = "Modelo/Marca"
        Me.colModeloMarca.FieldName = "ModeloMarca"
        Me.colModeloMarca.MinWidth = 15
        Me.colModeloMarca.Name = "colModeloMarca"
        Me.colModeloMarca.OptionsColumn.AllowEdit = False
        Me.colModeloMarca.OptionsFilter.AllowAutoFilter = False
        Me.colModeloMarca.Visible = True
        Me.colModeloMarca.VisibleIndex = 2
        Me.colModeloMarca.Width = 56
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.MinWidth = 15
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowEdit = False
        Me.colSaldo.OptionsFilter.AllowAutoFilter = False
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 3
        Me.colSaldo.Width = 56
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
        Me.Label11.Text = "Concepto:"
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
        Me.Label17.Text = "Monto:"
        '
        'numMontoDetalle
        '
        Me.numMontoDetalle.BackColor = System.Drawing.Color.Transparent
        Me.numMontoDetalle.Enabled = False
        Me.numMontoDetalle.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.numMontoDetalle.Location = New System.Drawing.Point(182, 92)
        Me.numMontoDetalle.Name = "numMontoDetalle"
        Me.numMontoDetalle.Size = New System.Drawing.Size(88, 21)
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
        Me.cmdAgregar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.add16x16
        Me.cmdAgregar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
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
        Me.cmdDelete.ImageOptions.Image = Global.SIRA.My.Resources.Resources.disabled16x16
        Me.cmdDelete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdDelete.Location = New System.Drawing.Point(259, 129)
        Me.cmdDelete.LookAndFeel.SkinName = "Caramel"
        Me.cmdDelete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(32, 28)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Tag = "AGREGAR"
        '
        'NumMontoDolares
        '
        Me.NumMontoDolares.BackColor = System.Drawing.Color.Transparent
        Me.NumMontoDolares.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.NumMontoDolares.Location = New System.Drawing.Point(36, 129)
        Me.NumMontoDolares.Name = "NumMontoDolares"
        Me.NumMontoDolares.Size = New System.Drawing.Size(147, 21)
        Me.NumMontoDolares.TabIndex = 17
        Me.NumMontoDolares.Tag = Nothing
        Me.NumMontoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumMontoDolares.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.NumMontoDolares.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMontoRecibo
        '
        Me.lblMontoRecibo.AutoSize = True
        Me.lblMontoRecibo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoRecibo.Location = New System.Drawing.Point(2, 107)
        Me.lblMontoRecibo.Name = "lblMontoRecibo"
        Me.lblMontoRecibo.Size = New System.Drawing.Size(134, 13)
        Me.lblMontoRecibo.TabIndex = 11
        Me.lblMontoRecibo.Text = "Monto Mensualidades:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.ImageIndex = 0
        Me.cmdEliminar.ImageList = Me.ListaImagenes
        Me.cmdEliminar.Location = New System.Drawing.Point(6, 304)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(31, 26)
        Me.cmdEliminar.TabIndex = 13
        Me.cmdEliminar.Tag = ""
        Me.cmdEliminar.Text = "&D"
        Me.ToolTip1.SetToolTip(Me.cmdEliminar, "Eliminar formas de pago")
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'ListaImagenes
        '
        Me.ListaImagenes.ImageStream = CType(resources.GetObject("ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagenes.Images.SetKeyName(0, "Eliminar.ico")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(817, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total Pagar:"
        '
        'lblTotalFact
        '
        Me.lblTotalFact.AutoSize = True
        Me.lblTotalFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFact.ForeColor = System.Drawing.Color.Black
        Me.lblTotalFact.Location = New System.Drawing.Point(817, 409)
        Me.lblTotalFact.Name = "lblTotalFact"
        Me.lblTotalFact.Size = New System.Drawing.Size(44, 13)
        Me.lblTotalFact.TabIndex = 7
        Me.lblTotalFact.Text = "Total :"
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
        Me.txtTotalFact.Location = New System.Drawing.Point(904, 407)
        Me.txtTotalFact.Name = "txtTotalFact"
        Me.txtTotalFact.Size = New System.Drawing.Size(123, 21)
        Me.txtTotalFact.TabIndex = 0
        Me.txtTotalFact.Tag = "BLOQUEADO"
        Me.txtTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalFact.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalFact.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtTotalPagar
        '
        Me.txtTotalPagar.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalPagar.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalPagar.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalPagar.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalPagar.Enabled = False
        Me.txtTotalPagar.FormatType = C1.Win.C1Input.FormatTypeEnum.Percent
        Me.txtTotalPagar.Location = New System.Drawing.Point(904, 458)
        Me.txtTotalPagar.Name = "txtTotalPagar"
        Me.txtTotalPagar.Size = New System.Drawing.Size(123, 21)
        Me.txtTotalPagar.TabIndex = 1
        Me.txtTotalPagar.Tag = "BLOQUEADO"
        Me.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalPagar.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalPagar.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'grpDatosRecibos
        '
        Me.grpDatosRecibos.Controls.Add(Me.cmbPeriodos)
        Me.grpDatosRecibos.Controls.Add(Me.Label10)
        Me.grpDatosRecibos.Controls.Add(Me.Label8)
        Me.grpDatosRecibos.Controls.Add(Me.txtEstado)
        Me.grpDatosRecibos.Controls.Add(Me.txtNumRecibo)
        Me.grpDatosRecibos.Controls.Add(Me.Label14)
        Me.grpDatosRecibos.Controls.Add(Me.lblRecibo)
        Me.grpDatosRecibos.Controls.Add(Me.cmbMoeda)
        Me.grpDatosRecibos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatosRecibos.Location = New System.Drawing.Point(15, 9)
        Me.grpDatosRecibos.Name = "grpDatosRecibos"
        Me.grpDatosRecibos.Size = New System.Drawing.Size(287, 126)
        Me.grpDatosRecibos.TabIndex = 19
        Me.grpDatosRecibos.TabStop = False
        Me.grpDatosRecibos.Text = "&DatosRecibos"
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
        Me.Label10.Text = "Periodo:"
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
        Me.Label8.Text = "Estado:"
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
        Me.Label14.Text = "Moneda:"
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
        Me.lblRecibo.Text = "No.Recibo:"
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
        Me.dtpFecha.Location = New System.Drawing.Point(565, 68)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(152, 20)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Tag = Nothing
        Me.dtpFecha.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(440, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Fecha:"
        '
        'GrpExpediente
        '
        Me.GrpExpediente.Controls.Add(Me.chkEsPrestamo)
        Me.GrpExpediente.Controls.Add(Me.SpnPorcentaje)
        Me.GrpExpediente.Controls.Add(Me.txtAtencionA)
        Me.GrpExpediente.Controls.Add(Me.Label12)
        Me.GrpExpediente.Controls.Add(Me.Label2)
        Me.GrpExpediente.Controls.Add(Me.dtpFecha)
        Me.GrpExpediente.Controls.Add(Me.Label1)
        Me.GrpExpediente.Controls.Add(Me.txtGrupo)
        Me.GrpExpediente.Controls.Add(Me.lblCedula)
        Me.GrpExpediente.Controls.Add(Me.cmdExpediente)
        Me.GrpExpediente.Controls.Add(Me.txtCliente)
        Me.GrpExpediente.Controls.Add(Me.lblNombre)
        Me.GrpExpediente.Controls.Add(Me.txtNumCuenta)
        Me.GrpExpediente.Controls.Add(Me.Label5)
        Me.GrpExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpExpediente.Location = New System.Drawing.Point(309, 9)
        Me.GrpExpediente.Name = "GrpExpediente"
        Me.GrpExpediente.Size = New System.Drawing.Size(721, 93)
        Me.GrpExpediente.TabIndex = 18
        Me.GrpExpediente.TabStop = False
        Me.GrpExpediente.Text = "Datos Persona"
        '
        'chkEsPrestamo
        '
        Me.chkEsPrestamo.AutoSize = True
        Me.chkEsPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEsPrestamo.Location = New System.Drawing.Point(311, 17)
        Me.chkEsPrestamo.Name = "chkEsPrestamo"
        Me.chkEsPrestamo.Size = New System.Drawing.Size(128, 17)
        Me.chkEsPrestamo.TabIndex = 111
        Me.chkEsPrestamo.Text = "Pago de prestamo"
        Me.chkEsPrestamo.UseVisualStyleBackColor = True
        '
        'SpnPorcentaje
        '
        Me.SpnPorcentaje.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpnPorcentaje.Enabled = False
        Me.SpnPorcentaje.Location = New System.Drawing.Point(568, 38)
        Me.SpnPorcentaje.Name = "SpnPorcentaje"
        Me.SpnPorcentaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpnPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.SpnPorcentaje.TabIndex = 110
        '
        'txtAtencionA
        '
        Me.txtAtencionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAtencionA.Location = New System.Drawing.Point(114, 68)
        Me.txtAtencionA.Name = "txtAtencionA"
        Me.txtAtencionA.Size = New System.Drawing.Size(249, 20)
        Me.txtAtencionA.TabIndex = 8
        Me.txtAtencionA.Tag = "BLOQUEADO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(17, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Tag = "OBLIGATORIO"
        Me.Label12.Text = "Atencion a: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(440, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Tag = "OBLIGATORIO"
        Me.Label2.Text = "Porcentaje de beca:"
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.Location = New System.Drawing.Point(568, 11)
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.ReadOnly = True
        Me.txtGrupo.Size = New System.Drawing.Size(149, 20)
        Me.txtGrupo.TabIndex = 5
        Me.txtGrupo.Tag = "BLOQUEADO"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.Black
        Me.lblCedula.Location = New System.Drawing.Point(440, 17)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(45, 13)
        Me.lblCedula.TabIndex = 6
        Me.lblCedula.Text = "Grupo:"
        '
        'cmdExpediente
        '
        Me.cmdExpediente.Location = New System.Drawing.Point(283, 14)
        Me.cmdExpediente.Name = "cmdExpediente"
        Me.cmdExpediente.Size = New System.Drawing.Size(24, 23)
        Me.cmdExpediente.TabIndex = 1
        Me.cmdExpediente.Text = "..."
        Me.cmdExpediente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(114, 41)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(249, 20)
        Me.txtCliente.TabIndex = 2
        Me.txtCliente.Tag = "BLOQUEADO"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(16, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(52, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Tag = "OBLIGATORIO"
        Me.lblNombre.Text = "Alumno:"
        '
        'txtNumCuenta
        '
        Me.txtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCuenta.Location = New System.Drawing.Point(114, 16)
        Me.txtNumCuenta.Name = "txtNumCuenta"
        Me.txtNumCuenta.Size = New System.Drawing.Size(163, 20)
        Me.txtNumCuenta.TabIndex = 0
        Me.txtNumCuenta.Tag = "BLOQUEADO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Tag = "OBLIGATORIO"
        Me.Label5.Text = "No. Exp:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMontRest)
        Me.GroupBox1.Controls.Add(Me.lblMontAbon)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblMontoRestante)
        Me.GroupBox1.Controls.Add(Me.lblMontoAbonado)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 59)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculadora"
        Me.GroupBox1.Visible = False
        '
        'lblMontRest
        '
        Me.lblMontRest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontRest.Location = New System.Drawing.Point(110, 37)
        Me.lblMontRest.Name = "lblMontRest"
        Me.lblMontRest.Size = New System.Drawing.Size(109, 16)
        Me.lblMontRest.TabIndex = 27
        Me.lblMontRest.Tag = "LAYOUT"
        '
        'lblMontAbon
        '
        Me.lblMontAbon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontAbon.Location = New System.Drawing.Point(110, 17)
        Me.lblMontAbon.Name = "lblMontAbon"
        Me.lblMontAbon.Size = New System.Drawing.Size(109, 16)
        Me.lblMontAbon.TabIndex = 26
        Me.lblMontAbon.Tag = "LAYOUT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(9, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Monto Abarcado:"
        '
        'lblMontoRestante
        '
        Me.lblMontoRestante.AutoSize = True
        Me.lblMontoRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoRestante.ForeColor = System.Drawing.Color.Black
        Me.lblMontoRestante.Location = New System.Drawing.Point(9, 40)
        Me.lblMontoRestante.Name = "lblMontoRestante"
        Me.lblMontoRestante.Size = New System.Drawing.Size(101, 13)
        Me.lblMontoRestante.TabIndex = 23
        Me.lblMontoRestante.Text = "Monto Restante:"
        '
        'lblMontoAbonado
        '
        Me.lblMontoAbonado.AutoSize = True
        Me.lblMontoAbonado.Location = New System.Drawing.Point(-96, 24)
        Me.lblMontoAbonado.Name = "lblMontoAbonado"
        Me.lblMontoAbonado.Size = New System.Drawing.Size(87, 13)
        Me.lblMontoAbonado.TabIndex = 21
        Me.lblMontoAbonado.Text = "Monto Abonado:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1049, 18)
        Me.Panel1.TabIndex = 22
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtObservaciones)
        Me.PanelControl1.Controls.Add(Me.Label18)
        Me.PanelControl1.Controls.Add(Me.cmdBuscarCuenta)
        Me.PanelControl1.Controls.Add(Me.lblCuenta)
        Me.PanelControl1.Controls.Add(Me.txtCuenta)
        Me.PanelControl1.Controls.Add(Me.Label16)
        Me.PanelControl1.Controls.Add(Me.cmbTipoPago)
        Me.PanelControl1.Controls.Add(Me.lblCaja)
        Me.PanelControl1.Controls.Add(Me.Label15)
        Me.PanelControl1.Controls.Add(Me.cmbCajero)
        Me.PanelControl1.Controls.Add(Me.txtTasaCambio)
        Me.PanelControl1.Controls.Add(Me.Label13)
        Me.PanelControl1.Controls.Add(Me.txtTotalDB)
        Me.PanelControl1.Controls.Add(Me.txtTotalPagar)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.txtTotalFact)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.tbControl)
        Me.PanelControl1.Controls.Add(Me.GrpExpediente)
        Me.PanelControl1.Controls.Add(Me.lblTotalFact)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.grpDatosRecibos)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1049, 559)
        Me.PanelControl1.TabIndex = 99
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(132, 487)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(306, 43)
        Me.txtObservaciones.TabIndex = 172
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 491)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 13)
        Me.Label18.TabIndex = 171
        Me.Label18.Text = "Observaciones:"
        '
        'cmdBuscarCuenta
        '
        Me.cmdBuscarCuenta.Location = New System.Drawing.Point(755, 128)
        Me.cmdBuscarCuenta.Name = "cmdBuscarCuenta"
        Me.cmdBuscarCuenta.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscarCuenta.TabIndex = 170
        Me.cmdBuscarCuenta.Tag = "Buscar Existente"
        Me.cmdBuscarCuenta.Text = "..."
        Me.cmdBuscarCuenta.UseVisualStyleBackColor = True
        Me.cmdBuscarCuenta.Visible = False
        '
        'lblCuenta
        '
        Me.lblCuenta.AutoSize = True
        Me.lblCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuenta.ForeColor = System.Drawing.Color.Black
        Me.lblCuenta.Location = New System.Drawing.Point(314, 132)
        Me.lblCuenta.Name = "lblCuenta"
        Me.lblCuenta.Size = New System.Drawing.Size(104, 13)
        Me.lblCuenta.TabIndex = 169
        Me.lblCuenta.Text = "Cuenta contable:"
        Me.lblCuenta.Visible = False
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(420, 129)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(332, 21)
        Me.txtCuenta.TabIndex = 168
        Me.txtCuenta.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(313, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Tipo de pago:"
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTipoPago.AutoCompletion = True
        Me.cmbTipoPago.AutoDropDown = True
        Me.cmbTipoPago.Caption = ""
        Me.cmbTipoPago.CaptionHeight = 17
        Me.cmbTipoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTipoPago.ColumnCaptionHeight = 17
        Me.cmbTipoPago.ColumnFooterHeight = 17
        Me.cmbTipoPago.ContentHeight = 15
        Me.cmbTipoPago.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTipoPago.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTipoPago.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoPago.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTipoPago.EditorHeight = 15
        Me.cmbTipoPago.Images.Add(CType(resources.GetObject("cmbTipoPago.Images"), System.Drawing.Image))
        Me.cmbTipoPago.ItemHeight = 15
        Me.cmbTipoPago.Location = New System.Drawing.Point(420, 103)
        Me.cmbTipoPago.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTipoPago.MaxDropDownItems = CType(5, Short)
        Me.cmbTipoPago.MaxLength = 32767
        Me.cmbTipoPago.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTipoPago.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTipoPago.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTipoPago.Size = New System.Drawing.Size(200, 21)
        Me.cmbTipoPago.TabIndex = 148
        Me.cmbTipoPago.Tag = "OBLIGATORIO"
        Me.cmbTipoPago.PropBag = resources.GetString("cmbTipoPago.PropBag")
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.ForeColor = System.Drawing.Color.Black
        Me.lblCaja.Location = New System.Drawing.Point(353, 442)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(40, 13)
        Me.lblCaja.TabIndex = 147
        Me.lblCaja.Tag = ""
        Me.lblCaja.Text = "Caja: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(353, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 134
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
        Me.cmbCajero.ContentHeight = 15
        Me.cmbCajero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCajero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCajero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCajero.EditorHeight = 15
        Me.cmbCajero.Images.Add(CType(resources.GetObject("cmbCajero.Images"), System.Drawing.Image))
        Me.cmbCajero.ItemHeight = 15
        Me.cmbCajero.Location = New System.Drawing.Point(421, 409)
        Me.cmbCajero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCajero.MaxDropDownItems = CType(5, Short)
        Me.cmbCajero.MaxLength = 32767
        Me.cmbCajero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCajero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCajero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCajero.Size = New System.Drawing.Size(200, 21)
        Me.cmbCajero.TabIndex = 133
        Me.cmbCajero.Tag = "OBLIGATORIO"
        Me.cmbCajero.PropBag = resources.GetString("cmbCajero.PropBag")
        '
        'txtTasaCambio
        '
        Me.txtTasaCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasaCambio.Location = New System.Drawing.Point(876, 106)
        Me.txtTasaCambio.Name = "txtTasaCambio"
        Me.txtTasaCambio.ReadOnly = True
        Me.txtTasaCambio.Size = New System.Drawing.Size(94, 20)
        Me.txtTasaCambio.TabIndex = 129
        Me.txtTasaCambio.Tag = "BLOQUEADO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(751, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 13)
        Me.Label13.TabIndex = 130
        Me.Label13.Text = "Tasa de cambio:"
        '
        'txtTotalDB
        '
        Me.txtTotalDB.BackColor = System.Drawing.SystemColors.Info
        Me.txtTotalDB.DisplayFormat.CustomFormat = "$ #,##0.00"
        Me.txtTotalDB.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalDB.Enabled = False
        Me.txtTotalDB.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtTotalDB.Location = New System.Drawing.Point(904, 434)
        Me.txtTotalDB.Name = "txtTotalDB"
        Me.txtTotalDB.Size = New System.Drawing.Size(123, 21)
        Me.txtTotalDB.TabIndex = 128
        Me.txtTotalDB.Tag = "BLOQUEADO"
        Me.txtTotalDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalDB.Value = New Decimal(New Integer() {0, 0, 0, 65536})
        Me.txtTotalDB.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(817, 437)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Total ND:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(957, 502)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(871, 502)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmSccEditReciboCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 559)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccEditReciboCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "CATALOGOS"
        Me.Text = "Modificar Recibo Caja"
        Me.tbControl.ResumeLayout(False)
        Me.tbpDetMensualidades.ResumeLayout(False)
        CType(Me.grdMensualidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMensualidadesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAbonar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotaDebito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpFormasPago.ResumeLayout(False)
        Me.grpFormaPago.ResumeLayout(False)
        Me.grpFormaPago.PerformLayout()
        CType(Me.cmbConceptoMensualidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numConvertirT, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.NumMontoDolares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalFact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDatosRecibos.ResumeLayout(False)
        Me.grpDatosRecibos.PerformLayout()
        CType(Me.cmbPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMoeda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpExpediente.ResumeLayout(False)
        Me.GrpExpediente.PerformLayout()
        CType(Me.SpnPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpDetMensualidades As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFact As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ListaImagenes As System.Windows.Forms.ImageList
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents txtTotalFact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtTotalPagar As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpDatosRecibos As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumRecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblRecibo As System.Windows.Forms.Label
    Friend WithEvents GrpExpediente As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExpediente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNumCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As C1.Win.C1List.C1Combo
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblMontoRestante As System.Windows.Forms.Label
    Friend WithEvents lblMontoAbonado As System.Windows.Forms.Label
    Friend WithEvents lblMontRest As System.Windows.Forms.Label
    Friend WithEvents lblMontAbon As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tbpFormasPago As System.Windows.Forms.TabPage
    Friend WithEvents grpFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents NumMontoDolares As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMontoRecibo As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents grdNotaDebito As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtTotalDB As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents lblCedula As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodos As C1.Win.C1List.C1Combo
    Friend WithEvents cmbConceptoRecibo As C1.Win.C1List.C1Combo
    Friend WithEvents txtAtencionA As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SpnPorcentaje As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtTasaCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbMoeda As C1.Win.C1List.C1Combo
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbCajero As C1.Win.C1List.C1Combo
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPago As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
    Friend WithEvents cmdBuscarCuenta As System.Windows.Forms.Button
    Friend WithEvents lblCuenta As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents cmbConceptoMensualidad As C1.Win.C1List.C1Combo
    Friend WithEvents lblConceptoRecibo As System.Windows.Forms.Label
    Friend WithEvents chkDólares As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents numConvertirT As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
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
    Friend WithEvents chkEsPrestamo As CheckBox
    Friend WithEvents RepositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
