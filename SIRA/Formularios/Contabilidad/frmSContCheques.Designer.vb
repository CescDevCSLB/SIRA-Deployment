<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSContCheques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContCheques))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdPeriodo = New DevExpress.XtraGrid.GridControl()
        Me.grdPeriodoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCreacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaierre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdPeriodoTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdContabilizar, Me.cmdConsultar, Me.cmdInactivar, Me.cmdBuscar, Me.cmdImprimir, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(856, 39)
        Me.toolTramitesLegales.TabIndex = 6
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar Cheque"
        Me.cmdAgregar.ToolTipText = "Agregar Cheque"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar Cheque"
        Me.cmdEditar.ToolTipText = "Editar Cheque"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdContabilizar.Image = CType(resources.GetObject("cmdContabilizar.Image"), System.Drawing.Image)
        Me.cmdContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdContabilizar.Text = "Contabilizar cheque"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar cheque"
        Me.cmdConsultar.ToolTipText = "Consultar cheque"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Anular cheque"
        Me.cmdInactivar.ToolTipText = "Anular cheque"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(36, 36)
        Me.cmdBuscar.Text = "Buscar cheque"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir cheque"
        Me.cmdImprimir.ToolTipText = "Imprimir cheque"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 36)
        Me.ToolStripLabel1.Text = "Cheques"
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
        Me.grdPeriodoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstado, Me.colMoneda, Me.colNumero, Me.colPeriodo, Me.colFechaCreacion, Me.colFechaierre, Me.colActiva, Me.colMonto, Me.colObservaciones})
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
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 1
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
        Me.colMoneda.VisibleIndex = 5
        Me.colMoneda.Width = 64
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "ScontChequeID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriodo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeriodo.Caption = "Numero de cheque"
        Me.colPeriodo.FieldName = "NumCheque"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 0
        Me.colPeriodo.Width = 114
        '
        'colFechaCreacion
        '
        Me.colFechaCreacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaCreacion.AppearanceHeader.Options.UseFont = True
        Me.colFechaCreacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaCreacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaCreacion.Caption = "Fecha"
        Me.colFechaCreacion.FieldName = "Fecha"
        Me.colFechaCreacion.Name = "colFechaCreacion"
        Me.colFechaCreacion.OptionsColumn.AllowEdit = False
        Me.colFechaCreacion.OptionsColumn.ReadOnly = True
        Me.colFechaCreacion.Visible = True
        Me.colFechaCreacion.VisibleIndex = 2
        Me.colFechaCreacion.Width = 77
        '
        'colFechaierre
        '
        Me.colFechaierre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaierre.AppearanceHeader.Options.UseFont = True
        Me.colFechaierre.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaierre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaierre.Caption = "Concepto"
        Me.colFechaierre.FieldName = "Concepto"
        Me.colFechaierre.Name = "colFechaierre"
        Me.colFechaierre.OptionsColumn.AllowEdit = False
        Me.colFechaierre.OptionsColumn.ReadOnly = True
        Me.colFechaierre.Visible = True
        Me.colFechaierre.VisibleIndex = 4
        Me.colFechaierre.Width = 137
        '
        'colActiva
        '
        Me.colActiva.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActiva.AppearanceHeader.Options.UseFont = True
        Me.colActiva.AppearanceHeader.Options.UseTextOptions = True
        Me.colActiva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActiva.Caption = "Activo"
        Me.colActiva.FieldName = "Activo"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 7
        Me.colActiva.Width = 129
        '
        'colMonto
        '
        Me.colMonto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMonto.AppearanceHeader.Options.UseFont = True
        Me.colMonto.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonto.Caption = "Monto C$"
        Me.colMonto.FieldName = "ValorCordobas"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 6
        Me.colMonto.Width = 105
        '
        'colObservaciones
        '
        Me.colObservaciones.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colObservaciones.AppearanceHeader.Options.UseFont = True
        Me.colObservaciones.AppearanceHeader.Options.UseTextOptions = True
        Me.colObservaciones.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colObservaciones.Caption = "Beneficiario"
        Me.colObservaciones.FieldName = "Beneficiario"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.OptionsColumn.AllowEdit = False
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 3
        Me.colObservaciones.Width = 212
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSContCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdPeriodo)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSContCheques"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Registro de cheques"
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
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdPeriodo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPeriodoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaCreacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFechaierre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdEditar As ToolStripButton
    Friend WithEvents cmdInactivar As ToolStripButton
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdBuscar As ToolStripButton
    Friend WithEvents cmdContabilizar As ToolStripButton
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
End Class
