<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSraActivarParcial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraActivarParcial))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdActivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdActivarReportes = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdPeriodo = New DevExpress.XtraGrid.GridControl()
        Me.grdPeriodoTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdActivar, Me.cmdInactivar, Me.cmdActivarReportes, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(856, 39)
        Me.toolTramitesLegales.TabIndex = 6
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdActivar
        '
        Me.cmdActivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActivar.Image = CType(resources.GetObject("cmdActivar.Image"), System.Drawing.Image)
        Me.cmdActivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActivar.Name = "cmdActivar"
        Me.cmdActivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActivar.Text = "Activar parcial"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar parcial"
        '
        'cmdActivarReportes
        '
        Me.cmdActivarReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActivarReportes.Image = CType(resources.GetObject("cmdActivarReportes.Image"), System.Drawing.Image)
        Me.cmdActivarReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActivarReportes.Name = "cmdActivarReportes"
        Me.cmdActivarReportes.Size = New System.Drawing.Size(36, 36)
        Me.cmdActivarReportes.Text = "Activar por rol"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(194, 36)
        Me.ToolStripLabel1.Text = "Activar/Inactivar parcial"
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
        Me.grdPeriodoTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colPeriodo, Me.colActiva})
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
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "ParcialID"
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
        Me.colPeriodo.Caption = "Parcial"
        Me.colPeriodo.FieldName = "Parcial"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 0
        Me.colPeriodo.Width = 193
        '
        'colActiva
        '
        Me.colActiva.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActiva.AppearanceHeader.Options.UseFont = True
        Me.colActiva.AppearanceHeader.Options.UseTextOptions = True
        Me.colActiva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActiva.Caption = "Activo"
        Me.colActiva.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActiva.FieldName = "Activo"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 1
        Me.colActiva.Width = 289
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSraActivarParcial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdPeriodo)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSraActivarParcial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Activar/Inactivar Parcial"
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
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdPeriodo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdPeriodoTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdActivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdActivarReportes As ToolStripButton
End Class
