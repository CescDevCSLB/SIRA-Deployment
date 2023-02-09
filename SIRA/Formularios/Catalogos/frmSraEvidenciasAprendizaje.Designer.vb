<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraEvidenciasAprendizaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraEvidenciasAprendizaje))
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAsignarEvidencias = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdEvidenciaMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdEvidenciaMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSraEvidenciasID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreEvidencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.colProfesor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toolTramitesLegales.SuspendLayout()
        CType(Me.grdEvidenciaMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEvidenciaMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdAsignarEvidencias, Me.cmdImprimir, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(1141, 39)
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
        Me.cmdAgregar.Text = "Agregar Asignatura"
        Me.cmdAgregar.ToolTipText = "Agregar evidencia"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar Asignatura"
        Me.cmdEditar.ToolTipText = "Editar evidencia"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar Asignatura"
        Me.cmdConsultar.ToolTipText = "Consultar evidencia"
        '
        'cmdAsignarEvidencias
        '
        Me.cmdAsignarEvidencias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAsignarEvidencias.Image = CType(resources.GetObject("cmdAsignarEvidencias.Image"), System.Drawing.Image)
        Me.cmdAsignarEvidencias.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAsignarEvidencias.Name = "cmdAsignarEvidencias"
        Me.cmdAsignarEvidencias.Size = New System.Drawing.Size(36, 36)
        Me.cmdAsignarEvidencias.Text = "Asignar detalles de evidencias"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Asignaturas"
        Me.cmdImprimir.ToolTipText = "Imprimir evidencias"
        '
        'ToolSeparador1
        '
        Me.ToolSeparador1.Name = "ToolSeparador1"
        Me.ToolSeparador1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar Datos"
        Me.tsbRefrescar.ToolTipText = "Refrescar datos"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(256, 36)
        Me.ToolStripLabel1.Text = "Evidencias de aprendizaje"
        '
        'grdEvidenciaMaster
        '
        Me.grdEvidenciaMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEvidenciaMaster.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdEvidenciaMaster.Location = New System.Drawing.Point(0, 0)
        Me.grdEvidenciaMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEvidenciaMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEvidenciaMaster.MainView = Me.grdEvidenciaMasterTabla
        Me.grdEvidenciaMaster.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdEvidenciaMaster.Name = "grdEvidenciaMaster"
        Me.grdEvidenciaMaster.Size = New System.Drawing.Size(1141, 729)
        Me.grdEvidenciaMaster.TabIndex = 4
        Me.grdEvidenciaMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEvidenciaMasterTabla, Me.GridView1})
        '
        'grdEvidenciaMasterTabla
        '
        Me.grdEvidenciaMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPeriodo, Me.colSraEvidenciasID, Me.colNombreEvidencia, Me.colActiva, Me.colDescripcion, Me.colProfesor})
        Me.grdEvidenciaMasterTabla.GridControl = Me.grdEvidenciaMaster
        Me.grdEvidenciaMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdEvidenciaMasterTabla.Name = "grdEvidenciaMasterTabla"
        Me.grdEvidenciaMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdEvidenciaMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdEvidenciaMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdEvidenciaMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdEvidenciaMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdEvidenciaMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdEvidenciaMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colSraEvidenciasID
        '
        Me.colSraEvidenciasID.Caption = "SraEvidenciasID"
        Me.colSraEvidenciasID.FieldName = "SraEvidenciasID"
        Me.colSraEvidenciasID.Name = "colSraEvidenciasID"
        Me.colSraEvidenciasID.OptionsColumn.AllowFocus = False
        Me.colSraEvidenciasID.OptionsColumn.ReadOnly = True
        Me.colSraEvidenciasID.Width = 76
        '
        'colNombreEvidencia
        '
        Me.colNombreEvidencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombreEvidencia.AppearanceHeader.Options.UseFont = True
        Me.colNombreEvidencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreEvidencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreEvidencia.Caption = "Evidencia de aprendizaje"
        Me.colNombreEvidencia.FieldName = "NombreEvidencia"
        Me.colNombreEvidencia.Name = "colNombreEvidencia"
        Me.colNombreEvidencia.OptionsColumn.AllowFocus = False
        Me.colNombreEvidencia.OptionsColumn.ReadOnly = True
        Me.colNombreEvidencia.Visible = True
        Me.colNombreEvidencia.VisibleIndex = 2
        Me.colNombreEvidencia.Width = 333
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
        Me.colActiva.OptionsColumn.AllowFocus = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Width = 118
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 3
        Me.colDescripcion.Width = 408
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grdEvidenciaMaster
        Me.GridView1.Name = "GridView1"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.grdEvidenciaMaster)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "98.9026063100137:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.2988606485539:False:False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 39)
        Me.Contenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1141, 729)
        Me.Contenedor.TabIndex = 7
        Me.Contenedor.TabStop = False
        '
        'colProfesor
        '
        Me.colProfesor.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colProfesor.AppearanceHeader.Options.UseFont = True
        Me.colProfesor.AppearanceHeader.Options.UseTextOptions = True
        Me.colProfesor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colProfesor.Caption = "Profesor"
        Me.colProfesor.FieldName = "Profesor"
        Me.colProfesor.Name = "colProfesor"
        Me.colProfesor.OptionsColumn.AllowEdit = False
        Me.colProfesor.Visible = True
        Me.colProfesor.VisibleIndex = 1
        Me.colProfesor.Width = 275
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriodo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeriodo.Caption = "Periodo"
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 0
        Me.colPeriodo.Width = 105
        '
        'frmSraEvidenciasAprendizaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 768)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSraEvidenciasAprendizaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Evidencias de aprendizaje"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        CType(Me.grdEvidenciaMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEvidenciaMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents grdEvidenciaMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEvidenciaMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSraEvidenciasID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreEvidencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents cmdAsignarEvidencias As ToolStripButton
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProfesor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
End Class
