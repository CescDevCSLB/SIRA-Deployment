<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbMantTasaCambioOficial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbMantTasaCambioOficial))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditarTasa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAutorizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdTasa = New DevExpress.XtraGrid.GridControl()
        Me.grdTasaTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.TasaCambio = New DevExpress.XtraGrid.GridControl()
        Me.TasaCambioVW = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tasa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.tbClientes.SuspendLayout()
        CType(Me.grdTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTasaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasaCambioVW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditarTasa, Me.ToolStripSeparator4, Me.cmdAutorizar, Me.ToolStripSeparator5, Me.cmdImprimir, Me.cmbExportar, Me.ToolStripSeparator8, Me.ToolStripButton1, Me.cmdRefrescar, Me.ToolStripSeparator9, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(1039, 39)
        Me.tbClientes.TabIndex = 3
        Me.tbClientes.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar Cliente"
        '
        'cmdEditarTasa
        '
        Me.cmdEditarTasa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarTasa.Image = CType(resources.GetObject("cmdEditarTasa.Image"), System.Drawing.Image)
        Me.cmdEditarTasa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarTasa.Name = "cmdEditarTasa"
        Me.cmdEditarTasa.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarTasa.Text = "Editar tasa de cambio"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAutorizar
        '
        Me.cmdAutorizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAutorizar.Image = CType(resources.GetObject("cmdAutorizar.Image"), System.Drawing.Image)
        Me.cmdAutorizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAutorizar.Name = "cmdAutorizar"
        Me.cmdAutorizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAutorizar.ToolTipText = "Autorizar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir"
        Me.cmdImprimir.Visible = False
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "Exportar"
        Me.cmbExportar.ToolTipText = "Descargar plantilla"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Importar"
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
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir de Mantenimiento de Empleados"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(166, 36)
        Me.ToolStripLabel1.Text = "Tasas de cambio"
        '
        'grdTasa
        '
        Me.grdTasa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTasa.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdTasa.Location = New System.Drawing.Point(0, 39)
        Me.grdTasa.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdTasa.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdTasa.MainView = Me.grdTasaTabla
        Me.grdTasa.Margin = New System.Windows.Forms.Padding(4)
        Me.grdTasa.Name = "grdTasa"
        Me.grdTasa.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdTasa.Size = New System.Drawing.Size(1039, 445)
        Me.grdTasa.TabIndex = 8
        Me.grdTasa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdTasaTabla})
        '
        'grdTasaTabla
        '
        Me.grdTasaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colMoneda, Me.colMonto, Me.colEstado})
        Me.grdTasaTabla.GridControl = Me.grdTasa
        Me.grdTasaTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdTasaTabla.Name = "grdTasaTabla"
        Me.grdTasaTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdTasaTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdTasaTabla.OptionsBehavior.Editable = False
        Me.grdTasaTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdTasaTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdTasaTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdTasaTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdTasaTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdTasaTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdTasaTabla.OptionsView.ShowFooter = True
        Me.grdTasaTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "StbTasaCambioOficialID"
        Me.colNumero.FieldName = "StbTasaCambioOficialID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
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
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 193
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
        Me.colMoneda.OptionsColumn.ReadOnly = True
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 1
        Me.colMoneda.Width = 215
        '
        'colMonto
        '
        Me.colMonto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMonto.AppearanceHeader.Options.UseFont = True
        Me.colMonto.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.OptionsColumn.ReadOnly = True
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 2
        Me.colMonto.Width = 141
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 3
        Me.colEstado.Width = 289
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'TasaCambio
        '
        Me.TasaCambio.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaCambio.Location = New System.Drawing.Point(16, 324)
        Me.TasaCambio.MainView = Me.TasaCambioVW
        Me.TasaCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.TasaCambio.Name = "TasaCambio"
        Me.TasaCambio.Size = New System.Drawing.Size(305, 110)
        Me.TasaCambio.TabIndex = 9
        Me.TasaCambio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TasaCambioVW})
        '
        'TasaCambioVW
        '
        Me.TasaCambioVW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Fecha, Me.Tasa})
        Me.TasaCambioVW.GridControl = Me.TasaCambio
        Me.TasaCambioVW.Name = "TasaCambioVW"
        '
        'Fecha
        '
        Me.Fecha.Caption = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = True
        Me.Fecha.VisibleIndex = 0
        '
        'Tasa
        '
        Me.Tasa.Caption = "Tasa"
        Me.Tasa.Name = "Tasa"
        Me.Tasa.Visible = True
        Me.Tasa.VisibleIndex = 1
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'frmStbMantTasaCambioOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 484)
        Me.Controls.Add(Me.grdTasa)
        Me.Controls.Add(Me.tbClientes)
        Me.Controls.Add(Me.TasaCambio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStbMantTasaCambioOficial"
        Me.Tag = "CATALOGOS"
        Me.Text = "Mantenimiento de tasas de cambio oficial"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.grdTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTasaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaCambio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasaCambioVW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAutorizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdTasa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdTasaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TasaCambio As DevExpress.XtraGrid.GridControl
    Friend WithEvents TasaCambioVW As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdEditarTasa As ToolStripButton
End Class
