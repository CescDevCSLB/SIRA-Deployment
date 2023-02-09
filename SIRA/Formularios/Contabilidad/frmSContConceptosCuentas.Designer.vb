<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSContConceptosCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContConceptosCuentas))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdConceptos = New DevExpress.XtraGrid.GridControl()
        Me.grdConceptosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCuentaContable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContraCuentaContable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCentroCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colTipoConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdConceptosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdInactivar, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(244, 36)
        Me.ToolStripLabel1.Text = "Conceptos / Cuentas contables"
        '
        'grdConceptos
        '
        Me.grdConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdConceptos.Location = New System.Drawing.Point(0, 39)
        Me.grdConceptos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdConceptos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdConceptos.MainView = Me.grdConceptosTabla
        Me.grdConceptos.Name = "grdConceptos"
        Me.grdConceptos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdConceptos.Size = New System.Drawing.Size(856, 464)
        Me.grdConceptos.TabIndex = 7
        Me.grdConceptos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdConceptosTabla})
        '
        'grdConceptosTabla
        '
        Me.grdConceptosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colConcepto, Me.colCuentaContable, Me.colNumero, Me.colContraCuentaContable, Me.colCentroCosto, Me.colTipoConcepto})
        Me.grdConceptosTabla.GridControl = Me.grdConceptos
        Me.grdConceptosTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdConceptosTabla.Name = "grdConceptosTabla"
        Me.grdConceptosTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdConceptosTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdConceptosTabla.OptionsBehavior.Editable = False
        Me.grdConceptosTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdConceptosTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdConceptosTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdConceptosTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdConceptosTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdConceptosTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdConceptosTabla.OptionsView.ShowFooter = True
        Me.grdConceptosTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
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
        Me.colConcepto.Width = 169
        '
        'colCuentaContable
        '
        Me.colCuentaContable.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCuentaContable.AppearanceHeader.Options.UseFont = True
        Me.colCuentaContable.AppearanceHeader.Options.UseTextOptions = True
        Me.colCuentaContable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCuentaContable.Caption = "Cuenta contable"
        Me.colCuentaContable.FieldName = "CuentaContable"
        Me.colCuentaContable.Name = "colCuentaContable"
        Me.colCuentaContable.OptionsColumn.AllowEdit = False
        Me.colCuentaContable.Visible = True
        Me.colCuentaContable.VisibleIndex = 3
        Me.colCuentaContable.Width = 177
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SContConceptosCuentasID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colContraCuentaContable
        '
        Me.colContraCuentaContable.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colContraCuentaContable.AppearanceHeader.Options.UseFont = True
        Me.colContraCuentaContable.AppearanceHeader.Options.UseTextOptions = True
        Me.colContraCuentaContable.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colContraCuentaContable.Caption = "Contra cuenta contable"
        Me.colContraCuentaContable.FieldName = "ContraCuentaContable"
        Me.colContraCuentaContable.Name = "colContraCuentaContable"
        Me.colContraCuentaContable.OptionsColumn.AllowEdit = False
        Me.colContraCuentaContable.Visible = True
        Me.colContraCuentaContable.VisibleIndex = 4
        Me.colContraCuentaContable.Width = 178
        '
        'colCentroCosto
        '
        Me.colCentroCosto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCentroCosto.AppearanceHeader.Options.UseFont = True
        Me.colCentroCosto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCentroCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCentroCosto.Caption = "Centro de costo"
        Me.colCentroCosto.FieldName = "CentroCosto"
        Me.colCentroCosto.Name = "colCentroCosto"
        Me.colCentroCosto.OptionsColumn.AllowEdit = False
        Me.colCentroCosto.Visible = True
        Me.colCentroCosto.VisibleIndex = 2
        Me.colCentroCosto.Width = 205
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colTipoConcepto
        '
        Me.colTipoConcepto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipoConcepto.AppearanceHeader.Options.UseFont = True
        Me.colTipoConcepto.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoConcepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoConcepto.Caption = "Tipo de Concepto"
        Me.colTipoConcepto.FieldName = "TipoConcepto"
        Me.colTipoConcepto.Name = "colTipoConcepto"
        Me.colTipoConcepto.OptionsColumn.AllowEdit = False
        Me.colTipoConcepto.Visible = True
        Me.colTipoConcepto.VisibleIndex = 0
        Me.colTipoConcepto.Width = 109
        '
        'frmSContConceptosCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdConceptos)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSContConceptosCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Relacion conceptos / cuentas contables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdConceptosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdConceptos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdConceptosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContraCuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdEditar As ToolStripButton
    Friend WithEvents cmdInactivar As ToolStripButton
    Friend WithEvents colCuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCentroCosto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoConcepto As DevExpress.XtraGrid.Columns.GridColumn
End Class
