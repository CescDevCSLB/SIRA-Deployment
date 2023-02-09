<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSContAgrupacionBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSContAgrupacionBalance))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdAgrupaciones = New DevExpress.XtraGrid.GridControl()
        Me.grdAgrupacionesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAgrupacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colClasificacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableAdapterManager1 = New SIRA.SIRADataSetTableAdapters.TableAdapterManager()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdAgrupaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAgrupacionesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cmdAgregar.Text = "Agregar agrupacion"
        Me.cmdAgregar.ToolTipText = "Agregar agrupacion"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar agrupacion"
        Me.cmdEditar.ToolTipText = "Editar agrupacion"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar agrupacion"
        Me.cmdConsultar.ToolTipText = "Consultar agrupacion"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar agrupacion"
        Me.cmdInactivar.ToolTipText = "Inactivar agrupacion"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(279, 36)
        Me.ToolStripLabel1.Text = "Agrupaciones para balance general"
        '
        'grdAgrupaciones
        '
        Me.grdAgrupaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAgrupaciones.Location = New System.Drawing.Point(0, 39)
        Me.grdAgrupaciones.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAgrupaciones.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAgrupaciones.MainView = Me.grdAgrupacionesTabla
        Me.grdAgrupaciones.Name = "grdAgrupaciones"
        Me.grdAgrupaciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdAgrupaciones.Size = New System.Drawing.Size(856, 464)
        Me.grdAgrupaciones.TabIndex = 7
        Me.grdAgrupaciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdAgrupacionesTabla})
        '
        'grdAgrupacionesTabla
        '
        Me.grdAgrupacionesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colAgrupacion, Me.colActiva, Me.colClasificacion})
        Me.grdAgrupacionesTabla.GridControl = Me.grdAgrupaciones
        Me.grdAgrupacionesTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdAgrupacionesTabla.Name = "grdAgrupacionesTabla"
        Me.grdAgrupacionesTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdAgrupacionesTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdAgrupacionesTabla.OptionsBehavior.Editable = False
        Me.grdAgrupacionesTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdAgrupacionesTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdAgrupacionesTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdAgrupacionesTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdAgrupacionesTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdAgrupacionesTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdAgrupacionesTabla.OptionsView.ShowFooter = True
        Me.grdAgrupacionesTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "ScontAgrupacionBalanceID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colAgrupacion
        '
        Me.colAgrupacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAgrupacion.AppearanceHeader.Options.UseFont = True
        Me.colAgrupacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colAgrupacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAgrupacion.Caption = "Agrupaciones"
        Me.colAgrupacion.FieldName = "Agrupacion"
        Me.colAgrupacion.Name = "colAgrupacion"
        Me.colAgrupacion.OptionsColumn.AllowEdit = False
        Me.colAgrupacion.OptionsColumn.ReadOnly = True
        Me.colAgrupacion.Visible = True
        Me.colAgrupacion.VisibleIndex = 0
        Me.colAgrupacion.Width = 281
        '
        'colActiva
        '
        Me.colActiva.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActiva.AppearanceHeader.Options.UseFont = True
        Me.colActiva.AppearanceHeader.Options.UseTextOptions = True
        Me.colActiva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActiva.Caption = "Activa"
        Me.colActiva.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActiva.FieldName = "Activo"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 2
        Me.colActiva.Width = 376
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colClasificacion
        '
        Me.colClasificacion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colClasificacion.AppearanceHeader.Options.UseFont = True
        Me.colClasificacion.AppearanceHeader.Options.UseTextOptions = True
        Me.colClasificacion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colClasificacion.Caption = "Clasificacion"
        Me.colClasificacion.FieldName = "Clasificacion"
        Me.colClasificacion.Name = "colClasificacion"
        Me.colClasificacion.OptionsColumn.AllowEdit = False
        Me.colClasificacion.Visible = True
        Me.colClasificacion.VisibleIndex = 1
        Me.colClasificacion.Width = 181
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = SIRA.SIRADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmSContAgrupacionBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdAgrupaciones)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSContAgrupacionBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Agrupaciones balance general"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdAgrupaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAgrupacionesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdAgrupaciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdAgrupacionesTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAgrupacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TableAdapterManager1 As SIRA.SIRADataSetTableAdapters.TableAdapterManager
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdInactivar As ToolStripButton
    Friend WithEvents colClasificacion As DevExpress.XtraGrid.Columns.GridColumn
End Class
