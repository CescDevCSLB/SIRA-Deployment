<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSContSaldos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContSaldos))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdPeriodo = New DevExpress.XtraGrid.GridControl()
        Me.grdPeriodoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaierre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.ColSaldoAcreedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPeriodoTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbExportar, Me.cmdImprimir, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(856, 39)
        Me.toolTramitesLegales.TabIndex = 6
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "Exportar"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.ToolTipText = "Imprimir"
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar Datos"
        '
        'tsbSalir
        '
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(36, 36)
        Me.tsbSalir.Text = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 36)
        Me.ToolStripLabel1.Text = "Saldos"
        '
        'grdPeriodo
        '
        Me.grdPeriodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPeriodo.Location = New System.Drawing.Point(0, 39)
        Me.grdPeriodo.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdPeriodo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdPeriodo.MainView = Me.grdPeriodoTabla
        Me.grdPeriodo.Name = "grdPeriodo"
        Me.grdPeriodo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdPeriodo.Size = New System.Drawing.Size(856, 464)
        Me.grdPeriodo.TabIndex = 7
        Me.grdPeriodo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdPeriodoTabla})
        '
        'grdPeriodoTabla
        '
        Me.grdPeriodoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPeriodo, Me.colFechaierre, Me.colMonto, Me.ColSaldoAcreedor})
        Me.grdPeriodoTabla.GridControl = Me.grdPeriodo
        Me.grdPeriodoTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdPeriodoTabla.Name = "grdPeriodoTabla"
        Me.grdPeriodoTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdPeriodoTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdPeriodoTabla.OptionsBehavior.Editable = False
        Me.grdPeriodoTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdPeriodoTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdPeriodoTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdPeriodoTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdPeriodoTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdPeriodoTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdPeriodoTabla.OptionsView.ShowFooter = True
        Me.grdPeriodoTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriodo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeriodo.Caption = "Codigo"
        Me.colPeriodo.FieldName = "IDCuenta"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 0
        Me.colPeriodo.Width = 174
        '
        'colFechaierre
        '
        Me.colFechaierre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaierre.AppearanceHeader.Options.UseFont = True
        Me.colFechaierre.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaierre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaierre.Caption = "Cuenta"
        Me.colFechaierre.FieldName = "Descripcion"
        Me.colFechaierre.Name = "colFechaierre"
        Me.colFechaierre.OptionsColumn.AllowEdit = False
        Me.colFechaierre.OptionsColumn.ReadOnly = True
        Me.colFechaierre.Visible = True
        Me.colFechaierre.VisibleIndex = 1
        Me.colFechaierre.Width = 339
        '
        'colMonto
        '
        Me.colMonto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMonto.AppearanceHeader.Options.UseFont = True
        Me.colMonto.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonto.Caption = "Saldo Deudor"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "SaldoDeudor"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 2
        Me.colMonto.Width = 159
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'ColSaldoAcreedor
        '
        Me.ColSaldoAcreedor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColSaldoAcreedor.AppearanceHeader.Options.UseFont = True
        Me.ColSaldoAcreedor.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSaldoAcreedor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSaldoAcreedor.Caption = "Saldo Acreedor"
        Me.ColSaldoAcreedor.FieldName = "SaldoAcreedor"
        Me.ColSaldoAcreedor.Name = "ColSaldoAcreedor"
        Me.ColSaldoAcreedor.OptionsColumn.AllowEdit = False
        Me.ColSaldoAcreedor.Visible = True
        Me.ColSaldoAcreedor.VisibleIndex = 3
        Me.ColSaldoAcreedor.Width = 166
        '
        'frmSContSaldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdPeriodo)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSContSaldos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta de saldos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdPeriodoTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdPeriodo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPeriodoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFechaierre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbExportar As ToolStripButton
    Friend WithEvents sfdRuta As SaveFileDialog
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents tsbRefrescar As ToolStripButton
    Friend WithEvents ColSaldoAcreedor As DevExpress.XtraGrid.Columns.GridColumn
End Class
