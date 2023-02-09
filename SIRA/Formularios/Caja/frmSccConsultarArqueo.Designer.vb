<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccConsultarArqueo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccConsultarArqueo))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBilletesDolar = New System.Windows.Forms.TextBox()
        Me.txtBilletesCor = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdBilletesDolar = New DevExpress.XtraGrid.GridControl()
        Me.grdBilletesDolarTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdBilletesCor = New DevExpress.XtraGrid.GridControl()
        Me.grdBilletesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSccDenominacionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStbValorCatalogoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdConsultarDetalle = New System.Windows.Forms.Button()
        Me.cmdAprobar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmdActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkCerrado = New System.Windows.Forms.CheckBox()
        Me.cmbCajero = New C1.Win.C1List.C1Combo()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.spnFaltante = New DevExpress.XtraEditors.SpinEdit()
        Me.spnIngreso = New DevExpress.XtraEditors.SpinEdit()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAprobadoPor = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBilletesCor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdBilletesDolar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdBilletesDolarTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdBilletesCor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdBilletesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtObservaciones)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.txtBilletesDolar)
        Me.PanelControl1.Controls.Add(Me.txtBilletesCor)
        Me.PanelControl1.Controls.Add(Me.GroupBox2)
        Me.PanelControl1.Controls.Add(Me.GroupBox3)
        Me.PanelControl1.Controls.Add(Me.cmdConsultarDetalle)
        Me.PanelControl1.Controls.Add(Me.cmdAprobar)
        Me.PanelControl1.Controls.Add(Me.GroupBox1)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1387, 558)
        Me.PanelControl1.TabIndex = 99
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(161, 418)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(569, 76)
        Me.txtObservaciones.TabIndex = 180
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 420)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 179
        Me.Label6.Tag = ""
        Me.Label6.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1117, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 17)
        Me.Label3.TabIndex = 178
        Me.Label3.Text = "Total billetes ($)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(843, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 17)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "Total billetes (C$)"
        '
        'txtBilletesDolar
        '
        Me.txtBilletesDolar.Enabled = False
        Me.txtBilletesDolar.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBilletesDolar.Location = New System.Drawing.Point(1207, 407)
        Me.txtBilletesDolar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBilletesDolar.Name = "txtBilletesDolar"
        Me.txtBilletesDolar.Size = New System.Drawing.Size(151, 23)
        Me.txtBilletesDolar.TabIndex = 176
        '
        'txtBilletesCor
        '
        Me.txtBilletesCor.Enabled = False
        Me.txtBilletesCor.Location = New System.Drawing.Point(939, 407)
        Me.txtBilletesCor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBilletesCor.Name = "txtBilletesCor"
        Me.txtBilletesCor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBilletesCor.Properties.Appearance.Options.UseFont = True
        Me.txtBilletesCor.Size = New System.Drawing.Size(152, 22)
        Me.txtBilletesCor.TabIndex = 175
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdBilletesDolar)
        Me.GroupBox2.Location = New System.Drawing.Point(1111, 34)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(251, 348)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dólares"
        '
        'grdBilletesDolar
        '
        Me.grdBilletesDolar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBilletesDolar.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBilletesDolar.Location = New System.Drawing.Point(3, 18)
        Me.grdBilletesDolar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdBilletesDolar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdBilletesDolar.MainView = Me.grdBilletesDolarTabla
        Me.grdBilletesDolar.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBilletesDolar.Name = "grdBilletesDolar"
        Me.grdBilletesDolar.Size = New System.Drawing.Size(245, 328)
        Me.grdBilletesDolar.TabIndex = 97
        Me.grdBilletesDolar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdBilletesDolarTabla, Me.GridView3})
        '
        'grdBilletesDolarTabla
        '
        Me.grdBilletesDolarTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.grdBilletesDolarTabla.GridControl = Me.grdBilletesDolar
        Me.grdBilletesDolarTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdBilletesDolarTabla.Name = "grdBilletesDolarTabla"
        Me.grdBilletesDolarTabla.OptionsView.ShowAutoFilterRow = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "SccDenominacionID"
        Me.GridColumn1.FieldName = "SccDenominacionID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "StbValorCatalogoID"
        Me.GridColumn2.FieldName = "StbValorCatalogoID"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Width = 366
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Billete"
        Me.GridColumn3.FieldName = "Descripcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 113
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Cantidad"
        Me.GridColumn4.FieldName = "Cantidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 155
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.grdBilletesDolar
        Me.GridView3.Name = "GridView3"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdBilletesCor)
        Me.GroupBox3.Location = New System.Drawing.Point(840, 32)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(251, 348)
        Me.GroupBox3.TabIndex = 170
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Córdobas"
        '
        'grdBilletesCor
        '
        Me.grdBilletesCor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdBilletesCor.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBilletesCor.Location = New System.Drawing.Point(3, 18)
        Me.grdBilletesCor.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdBilletesCor.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdBilletesCor.MainView = Me.grdBilletesTabla
        Me.grdBilletesCor.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBilletesCor.Name = "grdBilletesCor"
        Me.grdBilletesCor.Size = New System.Drawing.Size(245, 328)
        Me.grdBilletesCor.TabIndex = 97
        Me.grdBilletesCor.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdBilletesTabla, Me.GridView1})
        '
        'grdBilletesTabla
        '
        Me.grdBilletesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSccDenominacionID, Me.colStbValorCatalogoID, Me.colDescripcion, Me.colCantidad})
        Me.grdBilletesTabla.GridControl = Me.grdBilletesCor
        Me.grdBilletesTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdBilletesTabla.Name = "grdBilletesTabla"
        Me.grdBilletesTabla.OptionsView.ShowAutoFilterRow = True
        '
        'colSccDenominacionID
        '
        Me.colSccDenominacionID.Caption = "SccDenominacionID"
        Me.colSccDenominacionID.FieldName = "SccDenominacionID"
        Me.colSccDenominacionID.Name = "colSccDenominacionID"
        Me.colSccDenominacionID.OptionsColumn.AllowFocus = False
        Me.colSccDenominacionID.OptionsColumn.ReadOnly = True
        '
        'colStbValorCatalogoID
        '
        Me.colStbValorCatalogoID.Caption = "StbValorCatalogoID"
        Me.colStbValorCatalogoID.FieldName = "StbValorCatalogoID"
        Me.colStbValorCatalogoID.Name = "colStbValorCatalogoID"
        Me.colStbValorCatalogoID.OptionsColumn.AllowFocus = False
        Me.colStbValorCatalogoID.OptionsColumn.ReadOnly = True
        Me.colStbValorCatalogoID.Width = 366
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Billete"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 0
        Me.colDescripcion.Width = 117
        '
        'colCantidad
        '
        Me.colCantidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCantidad.AppearanceHeader.Options.UseFont = True
        Me.colCantidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 108
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdBilletesCor
        Me.GridView1.Name = "GridView1"
        '
        'cmdConsultarDetalle
        '
        Me.cmdConsultarDetalle.Image = CType(resources.GetObject("cmdConsultarDetalle.Image"), System.Drawing.Image)
        Me.cmdConsultarDetalle.Location = New System.Drawing.Point(779, 203)
        Me.cmdConsultarDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultarDetalle.Name = "cmdConsultarDetalle"
        Me.cmdConsultarDetalle.Size = New System.Drawing.Size(31, 28)
        Me.cmdConsultarDetalle.TabIndex = 168
        Me.cmdConsultarDetalle.Text = "..."
        Me.cmdConsultarDetalle.UseVisualStyleBackColor = True
        '
        'cmdAprobar
        '
        Me.cmdAprobar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAprobar.Appearance.Options.UseFont = True
        Me.cmdAprobar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdAprobar.Location = New System.Drawing.Point(1144, 480)
        Me.cmdAprobar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAprobar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAprobar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(107, 34)
        Me.cmdAprobar.TabIndex = 0
        Me.cmdAprobar.Tag = "APROBAR"
        Me.cmdAprobar.Text = "&Aprobar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grdDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 219)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(803, 187)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'grdDetalle
        '
        Me.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalle.Location = New System.Drawing.Point(4, 20)
        Me.grdDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDetalle.MainView = Me.grdDetalleTabla
        Me.grdDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdDetalle.Size = New System.Drawing.Size(795, 163)
        Me.grdDetalle.TabIndex = 0
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleTabla})
        '
        'grdDetalleTabla
        '
        Me.grdDetalleTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConcepto, Me.colEntrada, Me.colMoneda, Me.colTipoPago})
        Me.grdDetalleTabla.GridControl = Me.grdDetalle
        Me.grdDetalleTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdDetalleTabla.Name = "grdDetalleTabla"
        Me.grdDetalleTabla.OptionsView.ShowGroupPanel = False
        Me.grdDetalleTabla.Tag = ""
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
        Me.colConcepto.OptionsColumn.ReadOnly = True
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 1
        Me.colConcepto.Width = 190
        '
        'colEntrada
        '
        Me.colEntrada.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEntrada.AppearanceHeader.Options.UseFont = True
        Me.colEntrada.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntrada.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntrada.Caption = "Entrada"
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.OptionsColumn.AllowEdit = False
        Me.colEntrada.Visible = True
        Me.colEntrada.VisibleIndex = 3
        Me.colEntrada.Width = 167
        '
        'colMoneda
        '
        Me.colMoneda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMoneda.AppearanceHeader.Options.UseFont = True
        Me.colMoneda.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoneda.Caption = "Moneda"
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.OptionsColumn.AllowEdit = False
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 2
        Me.colMoneda.Width = 136
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
        Me.colTipoPago.VisibleIndex = 0
        Me.colTipoPago.Width = 85
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 530)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1383, 26)
        Me.Panel1.TabIndex = 96
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(1259, 480)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmdActualizar)
        Me.gbxDatosGenerales.Controls.Add(Me.chkCerrado)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbCajero)
        Me.gbxDatosGenerales.Controls.Add(Me.lblCaja)
        Me.gbxDatosGenerales.Controls.Add(Me.Label4)
        Me.gbxDatosGenerales.Controls.Add(Me.spnFaltante)
        Me.gbxDatosGenerales.Controls.Add(Me.spnIngreso)
        Me.gbxDatosGenerales.Controls.Add(Me.dtFecha)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.txtAprobadoPor)
        Me.gbxDatosGenerales.Controls.Add(Me.lblDescripcion)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 14)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(803, 190)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        Me.gbxDatosGenerales.Text = "Informacion General"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.updated16x16
        Me.cmdActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdActualizar.Location = New System.Drawing.Point(428, 18)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(43, 28)
        Me.cmdActualizar.TabIndex = 167
        Me.cmdActualizar.Visible = False
        '
        'chkCerrado
        '
        Me.chkCerrado.AutoSize = True
        Me.chkCerrado.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCerrado.ForeColor = System.Drawing.Color.Black
        Me.chkCerrado.Location = New System.Drawing.Point(620, 91)
        Me.chkCerrado.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCerrado.Name = "chkCerrado"
        Me.chkCerrado.Size = New System.Drawing.Size(86, 21)
        Me.chkCerrado.TabIndex = 144
        Me.chkCerrado.Text = "Cerrado"
        Me.chkCerrado.UseVisualStyleBackColor = True
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
        Me.cmbCajero.ContentHeight = 18
        Me.cmbCajero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCajero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCajero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCajero.EditorHeight = 18
        Me.cmbCajero.Images.Add(CType(resources.GetObject("cmbCajero.Images"), System.Drawing.Image))
        Me.cmbCajero.ItemHeight = 15
        Me.cmbCajero.Location = New System.Drawing.Point(184, 53)
        Me.cmbCajero.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCajero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCajero.MaxDropDownItems = CType(5, Short)
        Me.cmbCajero.MaxLength = 32767
        Me.cmbCajero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCajero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCajero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCajero.Size = New System.Drawing.Size(372, 24)
        Me.cmbCajero.TabIndex = 1
        Me.cmbCajero.Tag = "OBLIGATORIO"
        Me.cmbCajero.PropBag = resources.GetString("cmbCajero.PropBag")
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(616, 22)
        Me.lblCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(50, 17)
        Me.lblCaja.TabIndex = 7
        Me.lblCaja.Tag = ""
        Me.lblCaja.Text = "Caja: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 142
        Me.Label4.Tag = ""
        Me.Label4.Text = "Faltante/Excedente:"
        '
        'spnFaltante
        '
        Me.spnFaltante.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnFaltante.Location = New System.Drawing.Point(184, 150)
        Me.spnFaltante.Margin = New System.Windows.Forms.Padding(4)
        Me.spnFaltante.Name = "spnFaltante"
        Me.spnFaltante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnFaltante.Properties.Mask.EditMask = "n"
        Me.spnFaltante.Size = New System.Drawing.Size(133, 22)
        Me.spnFaltante.TabIndex = 5
        '
        'spnIngreso
        '
        Me.spnIngreso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnIngreso.Enabled = False
        Me.spnIngreso.Location = New System.Drawing.Point(184, 118)
        Me.spnIngreso.Margin = New System.Windows.Forms.Padding(4)
        Me.spnIngreso.Name = "spnIngreso"
        Me.spnIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnIngreso.Properties.Mask.EditMask = "c"
        Me.spnIngreso.Size = New System.Drawing.Size(133, 22)
        Me.spnIngreso.TabIndex = 3
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(184, 21)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(236, 22)
        Me.dtFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 131
        Me.Label1.Tag = "OBLIGATORIO"
        Me.Label1.Text = "Cajero(a):"
        '
        'txtAprobadoPor
        '
        Me.txtAprobadoPor.Location = New System.Drawing.Point(184, 86)
        Me.txtAprobadoPor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAprobadoPor.Name = "txtAprobadoPor"
        Me.txtAprobadoPor.Size = New System.Drawing.Size(371, 23)
        Me.txtAprobadoPor.TabIndex = 2
        Me.txtAprobadoPor.TabStop = False
        Me.txtAprobadoPor.Tag = "BLOQUEADO"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 123)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(67, 17)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = ""
        Me.lblDescripcion.Text = "Ingreso:"
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(15, 90)
        Me.lblSfaPromocionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(112, 17)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Aprobado por:"
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccConsultarArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1387, 558)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "frmSccConsultarArqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar arqueo de Caja"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBilletesCor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdBilletesDolar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdBilletesDolarTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdBilletesCor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdBilletesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAprobadoPor As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents spnFaltante As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnIngreso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmdAprobar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbCajero As C1.Win.C1List.C1Combo
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents cmdActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdConsultarDetalle As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBilletesDolar As TextBox
    Friend WithEvents txtBilletesCor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdBilletesDolar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdBilletesDolarTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdBilletesCor As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdBilletesTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSccDenominacionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStbValorCatalogoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
