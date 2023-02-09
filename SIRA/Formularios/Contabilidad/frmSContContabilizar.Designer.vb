<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSContContabilizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContContabilizar))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAsignarGrupo = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barButtonVerGrupos = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.TabControlGrupos = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPageCajaGeneral = New DevExpress.XtraTab.XtraTabPage()
        Me.grdCajaGeneral = New DevExpress.XtraGrid.GridControl()
        Me.grdCajaGeneralTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCordobas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContabilizado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabPageCajaChica = New DevExpress.XtraTab.XtraTabPage()
        Me.grdCajaChica = New DevExpress.XtraGrid.GridControl()
        Me.grdCajaChicaTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSccSalidasCajaChicaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConceptoCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMontoCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComprobanteGeneradoCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMesCC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.XtraTabPagePrestamos = New DevExpress.XtraTab.XtraTabPage()
        Me.grdPrestamos = New DevExpress.XtraGrid.GridControl()
        Me.grdPrestamosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumReciboPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArqueoPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagoPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColComprobantePrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColFechaPagoPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMesPagoPrestamo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbClientes.SuspendLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlGrupos.SuspendLayout()
        Me.XtraTabPageCajaGeneral.SuspendLayout()
        CType(Me.grdCajaGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCajaGeneralTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPageCajaChica.SuspendLayout()
        CType(Me.grdCajaChica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCajaChicaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPagePrestamos.SuspendLayout()
        CType(Me.grdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPrestamosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.cmdAsignarGrupo, Me.cmdBuscar, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(988, 39)
        Me.tbClientes.TabIndex = 1
        Me.tbClientes.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAsignarGrupo
        '
        Me.cmdAsignarGrupo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAsignarGrupo.Image = CType(resources.GetObject("cmdAsignarGrupo.Image"), System.Drawing.Image)
        Me.cmdAsignarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAsignarGrupo.Name = "cmdAsignarGrupo"
        Me.cmdAsignarGrupo.Size = New System.Drawing.Size(36, 36)
        Me.cmdAsignarGrupo.Text = "Generar comprobante"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.ToolTipText = "Buscar"
        Me.cmdBuscar.Visible = False
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Mantenimiento de Matriculas"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(184, 36)
        Me.ToolStripLabel1.Text = "Generar comprobantes"
        '
        'objUbicacion
        '
        Me.objUbicacion.Filter = "Microsoft Excel | *.xls"
        '
        'barManager1
        '
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonVerGrupos, Me.barButtonItem2})
        Me.barManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 453)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 453)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(988, 0)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 453)
        '
        'barButtonVerGrupos
        '
        Me.barButtonVerGrupos.Caption = "Ver Grupo"
        Me.barButtonVerGrupos.Id = 0
        Me.barButtonVerGrupos.Name = "barButtonVerGrupos"
        '
        'barButtonItem2
        '
        Me.barButtonItem2.Caption = "Item 2"
        Me.barButtonItem2.Id = 1
        Me.barButtonItem2.Name = "barButtonItem2"
        Me.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'popupMenu1
        '
        Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonVerGrupos), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
        Me.popupMenu1.Manager = Me.barManager1
        Me.popupMenu1.Name = "popupMenu1"
        '
        'TabControlGrupos
        '
        Me.TabControlGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGrupos.Location = New System.Drawing.Point(0, 39)
        Me.TabControlGrupos.Name = "TabControlGrupos"
        Me.TabControlGrupos.SelectedTabPage = Me.XtraTabPageCajaGeneral
        Me.TabControlGrupos.Size = New System.Drawing.Size(988, 414)
        Me.TabControlGrupos.TabIndex = 13
        Me.TabControlGrupos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageCajaGeneral, Me.XtraTabPageCajaChica, Me.XtraTabPagePrestamos})
        '
        'XtraTabPageCajaGeneral
        '
        Me.XtraTabPageCajaGeneral.Controls.Add(Me.grdCajaGeneral)
        Me.XtraTabPageCajaGeneral.Name = "XtraTabPageCajaGeneral"
        Me.XtraTabPageCajaGeneral.Size = New System.Drawing.Size(982, 386)
        Me.XtraTabPageCajaGeneral.Text = "Caja General"
        '
        'grdCajaGeneral
        '
        Me.grdCajaGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCajaGeneral.Location = New System.Drawing.Point(0, 0)
        Me.grdCajaGeneral.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdCajaGeneral.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdCajaGeneral.MainView = Me.grdCajaGeneralTabla
        Me.grdCajaGeneral.Name = "grdCajaGeneral"
        Me.grdCajaGeneral.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdCajaGeneral.Size = New System.Drawing.Size(982, 386)
        Me.grdCajaGeneral.TabIndex = 9
        Me.grdCajaGeneral.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCajaGeneralTabla})
        '
        'grdCajaGeneralTabla
        '
        Me.grdCajaGeneralTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumRecibo, Me.colNumero, Me.colAlumno, Me.colCaja, Me.colTipoPago, Me.colConcepto, Me.colTotalCordobas, Me.colContabilizado, Me.colFecha, Me.colMes})
        Me.grdCajaGeneralTabla.GridControl = Me.grdCajaGeneral
        Me.grdCajaGeneralTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdCajaGeneralTabla.Name = "grdCajaGeneralTabla"
        Me.grdCajaGeneralTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdCajaGeneralTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdCajaGeneralTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdCajaGeneralTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdCajaGeneralTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdCajaGeneralTabla.OptionsSelection.MultiSelect = True
        Me.grdCajaGeneralTabla.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdCajaGeneralTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdCajaGeneralTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumRecibo
        '
        Me.colNumRecibo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumRecibo.AppearanceHeader.Options.UseFont = True
        Me.colNumRecibo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumRecibo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumRecibo.Caption = "Numero de recibo"
        Me.colNumRecibo.FieldName = "NumRecibo"
        Me.colNumRecibo.Name = "colNumRecibo"
        Me.colNumRecibo.OptionsColumn.AllowEdit = False
        Me.colNumRecibo.OptionsColumn.ReadOnly = True
        Me.colNumRecibo.Visible = True
        Me.colNumRecibo.VisibleIndex = 2
        Me.colNumRecibo.Width = 121
        '
        'colNumero
        '
        Me.colNumero.Caption = "SccArqueoReciboID"
        Me.colNumero.FieldName = "SccArqueoReciboID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Alumno y/o Atencion a"
        Me.colAlumno.FieldName = "Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.OptionsColumn.AllowEdit = False
        Me.colAlumno.OptionsColumn.ReadOnly = True
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 5
        Me.colAlumno.Width = 138
        '
        'colCaja
        '
        Me.colCaja.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCaja.AppearanceHeader.Options.UseFont = True
        Me.colCaja.AppearanceHeader.Options.UseTextOptions = True
        Me.colCaja.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCaja.Caption = "Caja"
        Me.colCaja.FieldName = "Caja"
        Me.colCaja.Name = "colCaja"
        Me.colCaja.OptionsColumn.AllowEdit = False
        Me.colCaja.Visible = True
        Me.colCaja.VisibleIndex = 1
        Me.colCaja.Width = 97
        '
        'colTipoPago
        '
        Me.colTipoPago.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipoPago.AppearanceHeader.Options.UseFont = True
        Me.colTipoPago.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoPago.Caption = "Tipo de pago"
        Me.colTipoPago.FieldName = "TipoPago"
        Me.colTipoPago.Name = "colTipoPago"
        Me.colTipoPago.OptionsColumn.AllowEdit = False
        Me.colTipoPago.Visible = True
        Me.colTipoPago.VisibleIndex = 3
        Me.colTipoPago.Width = 101
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
        Me.colConcepto.VisibleIndex = 4
        Me.colConcepto.Width = 78
        '
        'colTotalCordobas
        '
        Me.colTotalCordobas.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTotalCordobas.AppearanceHeader.Options.UseFont = True
        Me.colTotalCordobas.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalCordobas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalCordobas.Caption = "Total (C$)"
        Me.colTotalCordobas.FieldName = "TotalCordobas"
        Me.colTotalCordobas.Name = "colTotalCordobas"
        Me.colTotalCordobas.OptionsColumn.AllowEdit = False
        Me.colTotalCordobas.Visible = True
        Me.colTotalCordobas.VisibleIndex = 8
        Me.colTotalCordobas.Width = 72
        '
        'colContabilizado
        '
        Me.colContabilizado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colContabilizado.AppearanceHeader.Options.UseFont = True
        Me.colContabilizado.AppearanceHeader.Options.UseTextOptions = True
        Me.colContabilizado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContabilizado.Caption = "Comprobante Generado"
        Me.colContabilizado.FieldName = "Contabilizado"
        Me.colContabilizado.Name = "colContabilizado"
        Me.colContabilizado.Visible = True
        Me.colContabilizado.VisibleIndex = 9
        '
        'colFecha
        '
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 7
        Me.colFecha.Width = 59
        '
        'colMes
        '
        Me.colMes.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMes.AppearanceHeader.Options.UseFont = True
        Me.colMes.AppearanceHeader.Options.UseTextOptions = True
        Me.colMes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "Mes"
        Me.colMes.Name = "colMes"
        Me.colMes.OptionsColumn.AllowEdit = False
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 6
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'XtraTabPageCajaChica
        '
        Me.XtraTabPageCajaChica.Controls.Add(Me.grdCajaChica)
        Me.XtraTabPageCajaChica.Name = "XtraTabPageCajaChica"
        Me.XtraTabPageCajaChica.Size = New System.Drawing.Size(982, 386)
        Me.XtraTabPageCajaChica.Text = "Caja chica"
        '
        'grdCajaChica
        '
        Me.grdCajaChica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCajaChica.Location = New System.Drawing.Point(0, 0)
        Me.grdCajaChica.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdCajaChica.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdCajaChica.MainView = Me.grdCajaChicaTabla
        Me.grdCajaChica.Name = "grdCajaChica"
        Me.grdCajaChica.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4})
        Me.grdCajaChica.Size = New System.Drawing.Size(982, 386)
        Me.grdCajaChica.TabIndex = 10
        Me.grdCajaChica.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCajaChicaTabla})
        '
        'grdCajaChicaTabla
        '
        Me.grdCajaChicaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSccSalidasCajaChicaID, Me.colConceptoCC, Me.colDescripcionCC, Me.colFechaCC, Me.colMontoCC, Me.colComprobanteGeneradoCC, Me.colMesCC})
        Me.grdCajaChicaTabla.GridControl = Me.grdCajaChica
        Me.grdCajaChicaTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdCajaChicaTabla.Name = "grdCajaChicaTabla"
        Me.grdCajaChicaTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdCajaChicaTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdCajaChicaTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdCajaChicaTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdCajaChicaTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdCajaChicaTabla.OptionsSelection.MultiSelect = True
        Me.grdCajaChicaTabla.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdCajaChicaTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdCajaChicaTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colSccSalidasCajaChicaID
        '
        Me.colSccSalidasCajaChicaID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSccSalidasCajaChicaID.AppearanceHeader.Options.UseFont = True
        Me.colSccSalidasCajaChicaID.AppearanceHeader.Options.UseTextOptions = True
        Me.colSccSalidasCajaChicaID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSccSalidasCajaChicaID.Caption = "Numero "
        Me.colSccSalidasCajaChicaID.FieldName = "SccSalidasCajaChicaID"
        Me.colSccSalidasCajaChicaID.Name = "colSccSalidasCajaChicaID"
        Me.colSccSalidasCajaChicaID.OptionsColumn.AllowEdit = False
        Me.colSccSalidasCajaChicaID.OptionsColumn.ReadOnly = True
        Me.colSccSalidasCajaChicaID.Visible = True
        Me.colSccSalidasCajaChicaID.VisibleIndex = 1
        Me.colSccSalidasCajaChicaID.Width = 117
        '
        'colConceptoCC
        '
        Me.colConceptoCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colConceptoCC.AppearanceHeader.Options.UseFont = True
        Me.colConceptoCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colConceptoCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConceptoCC.Caption = "Concepto"
        Me.colConceptoCC.FieldName = "Concepto"
        Me.colConceptoCC.Name = "colConceptoCC"
        Me.colConceptoCC.OptionsColumn.AllowEdit = False
        Me.colConceptoCC.OptionsColumn.ReadOnly = True
        Me.colConceptoCC.Visible = True
        Me.colConceptoCC.VisibleIndex = 5
        Me.colConceptoCC.Width = 178
        '
        'colDescripcionCC
        '
        Me.colDescripcionCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcionCC.AppearanceHeader.Options.UseFont = True
        Me.colDescripcionCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcionCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcionCC.Caption = "Descripcion"
        Me.colDescripcionCC.FieldName = "Descripcion"
        Me.colDescripcionCC.Name = "colDescripcionCC"
        Me.colDescripcionCC.OptionsColumn.AllowEdit = False
        Me.colDescripcionCC.Visible = True
        Me.colDescripcionCC.VisibleIndex = 4
        Me.colDescripcionCC.Width = 142
        '
        'colFechaCC
        '
        Me.colFechaCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaCC.AppearanceHeader.Options.UseFont = True
        Me.colFechaCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaCC.Caption = "Fecha"
        Me.colFechaCC.FieldName = "Fecha"
        Me.colFechaCC.Name = "colFechaCC"
        Me.colFechaCC.OptionsColumn.AllowEdit = False
        Me.colFechaCC.Visible = True
        Me.colFechaCC.VisibleIndex = 3
        Me.colFechaCC.Width = 115
        '
        'colMontoCC
        '
        Me.colMontoCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMontoCC.AppearanceHeader.Options.UseFont = True
        Me.colMontoCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colMontoCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMontoCC.Caption = "Monto (C$)"
        Me.colMontoCC.FieldName = "Monto"
        Me.colMontoCC.Name = "colMontoCC"
        Me.colMontoCC.OptionsColumn.AllowEdit = False
        Me.colMontoCC.Visible = True
        Me.colMontoCC.VisibleIndex = 6
        Me.colMontoCC.Width = 116
        '
        'colComprobanteGeneradoCC
        '
        Me.colComprobanteGeneradoCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colComprobanteGeneradoCC.AppearanceHeader.Options.UseFont = True
        Me.colComprobanteGeneradoCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colComprobanteGeneradoCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colComprobanteGeneradoCC.Caption = "Comprobante Generado"
        Me.colComprobanteGeneradoCC.FieldName = "Generado"
        Me.colComprobanteGeneradoCC.Name = "colComprobanteGeneradoCC"
        Me.colComprobanteGeneradoCC.Visible = True
        Me.colComprobanteGeneradoCC.VisibleIndex = 7
        Me.colComprobanteGeneradoCC.Width = 135
        '
        'colMesCC
        '
        Me.colMesCC.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMesCC.AppearanceHeader.Options.UseFont = True
        Me.colMesCC.AppearanceHeader.Options.UseTextOptions = True
        Me.colMesCC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMesCC.Caption = "Mes"
        Me.colMesCC.FieldName = "Mes"
        Me.colMesCC.Name = "colMesCC"
        Me.colMesCC.OptionsColumn.AllowEdit = False
        Me.colMesCC.Visible = True
        Me.colMesCC.VisibleIndex = 2
        Me.colMesCC.Width = 86
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'XtraTabPagePrestamos
        '
        Me.XtraTabPagePrestamos.Controls.Add(Me.grdPrestamos)
        Me.XtraTabPagePrestamos.Name = "XtraTabPagePrestamos"
        Me.XtraTabPagePrestamos.Size = New System.Drawing.Size(982, 386)
        Me.XtraTabPagePrestamos.Text = "Pago de prestamos"
        '
        'grdPrestamos
        '
        Me.grdPrestamos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPrestamos.Location = New System.Drawing.Point(0, 0)
        Me.grdPrestamos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdPrestamos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdPrestamos.MainView = Me.grdPrestamosTabla
        Me.grdPrestamos.Name = "grdPrestamos"
        Me.grdPrestamos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit5, Me.RepositoryItemCheckEdit6})
        Me.grdPrestamos.Size = New System.Drawing.Size(982, 386)
        Me.grdPrestamos.TabIndex = 10
        Me.grdPrestamos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdPrestamosTabla})
        '
        'grdPrestamosTabla
        '
        Me.grdPrestamosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumReciboPrestamo, Me.colArqueoPrestamo, Me.colEmpleado, Me.colOrigen, Me.colNumPrestamo, Me.colPagoPrestamo, Me.ColComprobantePrestamo, Me.ColFechaPagoPrestamo, Me.colMesPagoPrestamo, Me.colCuentaID})
        Me.grdPrestamosTabla.GridControl = Me.grdPrestamos
        Me.grdPrestamosTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdPrestamosTabla.Name = "grdPrestamosTabla"
        Me.grdPrestamosTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdPrestamosTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdPrestamosTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdPrestamosTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdPrestamosTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdPrestamosTabla.OptionsSelection.MultiSelect = True
        Me.grdPrestamosTabla.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdPrestamosTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdPrestamosTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumReciboPrestamo
        '
        Me.colNumReciboPrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumReciboPrestamo.AppearanceHeader.Options.UseFont = True
        Me.colNumReciboPrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumReciboPrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumReciboPrestamo.Caption = "Numero de recibo"
        Me.colNumReciboPrestamo.FieldName = "NumRecibo"
        Me.colNumReciboPrestamo.Name = "colNumReciboPrestamo"
        Me.colNumReciboPrestamo.OptionsColumn.AllowEdit = False
        Me.colNumReciboPrestamo.OptionsColumn.ReadOnly = True
        Me.colNumReciboPrestamo.Visible = True
        Me.colNumReciboPrestamo.VisibleIndex = 4
        Me.colNumReciboPrestamo.Width = 130
        '
        'colArqueoPrestamo
        '
        Me.colArqueoPrestamo.Caption = "SccArqueoReciboID"
        Me.colArqueoPrestamo.FieldName = "SccArqueoReciboID"
        Me.colArqueoPrestamo.Name = "colArqueoPrestamo"
        Me.colArqueoPrestamo.OptionsColumn.AllowFocus = False
        Me.colArqueoPrestamo.OptionsColumn.ReadOnly = True
        Me.colArqueoPrestamo.Width = 76
        '
        'colEmpleado
        '
        Me.colEmpleado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEmpleado.AppearanceHeader.Options.UseFont = True
        Me.colEmpleado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmpleado.Caption = "Empleado"
        Me.colEmpleado.FieldName = "Alumno"
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.OptionsColumn.AllowEdit = False
        Me.colEmpleado.OptionsColumn.ReadOnly = True
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 2
        Me.colEmpleado.Width = 172
        '
        'colOrigen
        '
        Me.colOrigen.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colOrigen.AppearanceHeader.Options.UseFont = True
        Me.colOrigen.AppearanceHeader.Options.UseTextOptions = True
        Me.colOrigen.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOrigen.Caption = "Forma de pago"
        Me.colOrigen.FieldName = "FormaPago"
        Me.colOrigen.Name = "colOrigen"
        Me.colOrigen.OptionsColumn.AllowEdit = False
        Me.colOrigen.Visible = True
        Me.colOrigen.VisibleIndex = 3
        Me.colOrigen.Width = 125
        '
        'colNumPrestamo
        '
        Me.colNumPrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumPrestamo.AppearanceHeader.Options.UseFont = True
        Me.colNumPrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumPrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumPrestamo.Caption = "No. Expediente"
        Me.colNumPrestamo.FieldName = "NumPrestamo"
        Me.colNumPrestamo.Name = "colNumPrestamo"
        Me.colNumPrestamo.OptionsColumn.AllowEdit = False
        Me.colNumPrestamo.Visible = True
        Me.colNumPrestamo.VisibleIndex = 1
        Me.colNumPrestamo.Width = 97
        '
        'colPagoPrestamo
        '
        Me.colPagoPrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagoPrestamo.AppearanceHeader.Options.UseFont = True
        Me.colPagoPrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPagoPrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagoPrestamo.Caption = "Total (C$)"
        Me.colPagoPrestamo.FieldName = "TotalCordobas"
        Me.colPagoPrestamo.Name = "colPagoPrestamo"
        Me.colPagoPrestamo.OptionsColumn.AllowEdit = False
        Me.colPagoPrestamo.Visible = True
        Me.colPagoPrestamo.VisibleIndex = 7
        Me.colPagoPrestamo.Width = 95
        '
        'ColComprobantePrestamo
        '
        Me.ColComprobantePrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColComprobantePrestamo.AppearanceHeader.Options.UseFont = True
        Me.ColComprobantePrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColComprobantePrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColComprobantePrestamo.Caption = "Comprobante Generado"
        Me.ColComprobantePrestamo.FieldName = "Contabilizado"
        Me.ColComprobantePrestamo.Name = "ColComprobantePrestamo"
        Me.ColComprobantePrestamo.Visible = True
        Me.ColComprobantePrestamo.VisibleIndex = 8
        Me.ColComprobantePrestamo.Width = 107
        '
        'ColFechaPagoPrestamo
        '
        Me.ColFechaPagoPrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColFechaPagoPrestamo.AppearanceHeader.Options.UseFont = True
        Me.ColFechaPagoPrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.ColFechaPagoPrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColFechaPagoPrestamo.Caption = "Fecha"
        Me.ColFechaPagoPrestamo.FieldName = "Fecha"
        Me.ColFechaPagoPrestamo.Name = "ColFechaPagoPrestamo"
        Me.ColFechaPagoPrestamo.OptionsColumn.AllowEdit = False
        Me.ColFechaPagoPrestamo.Visible = True
        Me.ColFechaPagoPrestamo.VisibleIndex = 6
        Me.ColFechaPagoPrestamo.Width = 76
        '
        'colMesPagoPrestamo
        '
        Me.colMesPagoPrestamo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMesPagoPrestamo.AppearanceHeader.Options.UseFont = True
        Me.colMesPagoPrestamo.AppearanceHeader.Options.UseTextOptions = True
        Me.colMesPagoPrestamo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMesPagoPrestamo.Caption = "Mes"
        Me.colMesPagoPrestamo.FieldName = "Mes"
        Me.colMesPagoPrestamo.Name = "colMesPagoPrestamo"
        Me.colMesPagoPrestamo.OptionsColumn.AllowEdit = False
        Me.colMesPagoPrestamo.Visible = True
        Me.colMesPagoPrestamo.VisibleIndex = 5
        Me.colMesPagoPrestamo.Width = 98
        '
        'colCuentaID
        '
        Me.colCuentaID.Caption = "SccCuentaID"
        Me.colCuentaID.FieldName = "SccCuentaID"
        Me.colCuentaID.Name = "colCuentaID"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Caption = "Check"
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.Caption = "Check"
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'frmSContContabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 453)
        Me.Controls.Add(Me.TabControlGrupos)
        Me.Controls.Add(Me.tbClientes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSContContabilizar"
        Me.Text = "Generar comprobantes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlGrupos.ResumeLayout(False)
        Me.XtraTabPageCajaGeneral.ResumeLayout(False)
        CType(Me.grdCajaGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCajaGeneralTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPageCajaChica.ResumeLayout(False)
        CType(Me.grdCajaChica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCajaChicaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPagePrestamos.ResumeLayout(False)
        CType(Me.grdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPrestamosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdAsignarGrupo As System.Windows.Forms.ToolStripButton
    Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents barButtonVerGrupos As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TabControlGrupos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPageCajaGeneral As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdCajaGeneral As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCajaGeneralTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCordobas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContabilizado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents XtraTabPageCajaChica As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents grdCajaChica As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCajaChicaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSccSalidasCajaChicaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConceptoCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComprobanteGeneradoCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMesCC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabPagePrestamos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdPrestamos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPrestamosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumReciboPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArqueoPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagoPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColComprobantePrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColFechaPagoPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMesPagoPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCuentaID As DevExpress.XtraGrid.Columns.GridColumn
End Class
