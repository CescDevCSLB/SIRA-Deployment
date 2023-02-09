<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraNotaBoletin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraNotaBoletin))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmdTitulo = New System.Windows.Forms.ToolStripLabel()
        Me.grdNotas = New DevExpress.XtraGrid.GridControl()
        Me.grdNotasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.tsbRefrescar, Me.tsbSalir, Me.cmdTitulo})
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
        Me.cmdAgregar.Text = "Agregar nota"
        Me.cmdAgregar.ToolTipText = "Agregar nota"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar nota"
        Me.cmdEditar.ToolTipText = "Editar nota"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar nota"
        Me.cmdConsultar.ToolTipText = "Consultar nota"
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
        'cmdTitulo
        '
        Me.cmdTitulo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTitulo.ForeColor = System.Drawing.Color.Navy
        Me.cmdTitulo.Name = "cmdTitulo"
        Me.cmdTitulo.Size = New System.Drawing.Size(116, 36)
        Me.cmdTitulo.Text = "Notas-Boletín"
        '
        'grdNotas
        '
        Me.grdNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNotas.Location = New System.Drawing.Point(0, 39)
        Me.grdNotas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdNotas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdNotas.MainView = Me.grdNotasTabla
        Me.grdNotas.Name = "grdNotas"
        Me.grdNotas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdNotas.Size = New System.Drawing.Size(856, 464)
        Me.grdNotas.TabIndex = 7
        Me.grdNotas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNotasTabla})
        '
        'grdNotasTabla
        '
        Me.grdNotasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colModalidad, Me.colPeriodo, Me.colNota, Me.colActiva})
        Me.grdNotasTabla.GridControl = Me.grdNotas
        Me.grdNotasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdNotasTabla.Name = "grdNotasTabla"
        Me.grdNotasTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdNotasTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdNotasTabla.OptionsBehavior.Editable = False
        Me.grdNotasTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdNotasTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdNotasTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdNotasTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdNotasTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdNotasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdNotasTabla.OptionsView.ShowFooter = True
        Me.grdNotasTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SraNotaBoletinID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colModalidad
        '
        Me.colModalidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModalidad.AppearanceHeader.Options.UseFont = True
        Me.colModalidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModalidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModalidad.Caption = "Modalidad"
        Me.colModalidad.FieldName = "Modalidad"
        Me.colModalidad.Name = "colModalidad"
        Me.colModalidad.OptionsColumn.AllowEdit = False
        Me.colModalidad.Visible = True
        Me.colModalidad.VisibleIndex = 1
        Me.colModalidad.Width = 223
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriodo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeriodo.Caption = "Período"
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.OptionsColumn.ReadOnly = True
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 0
        Me.colPeriodo.Width = 152
        '
        'colNota
        '
        Me.colNota.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNota.AppearanceHeader.Options.UseFont = True
        Me.colNota.AppearanceHeader.Options.UseTextOptions = True
        Me.colNota.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNota.Caption = "Nota"
        Me.colNota.FieldName = "Nota"
        Me.colNota.Name = "colNota"
        Me.colNota.Visible = True
        Me.colNota.VisibleIndex = 2
        Me.colNota.Width = 357
        '
        'colActiva
        '
        Me.colActiva.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActiva.AppearanceHeader.Options.UseFont = True
        Me.colActiva.AppearanceHeader.Options.UseTextOptions = True
        Me.colActiva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActiva.Caption = "Activa"
        Me.colActiva.FieldName = "Activa"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 3
        Me.colActiva.Width = 106
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSraNotaBoletin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 503)
        Me.Controls.Add(Me.grdNotas)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSraNotaBoletin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta de nota en el boletín"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotasTabla, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grdNotas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNotasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colNota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdTitulo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
End Class
