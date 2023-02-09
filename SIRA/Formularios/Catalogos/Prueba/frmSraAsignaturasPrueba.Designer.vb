<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraAsignaturasPrueba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraAsignaturasPrueba))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnuAsignatura = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmdActualizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdAsignaturas = New DevExpress.XtraGrid.GridControl()
        Me.grdvwAsignaturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCalificaDocente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Panel1.SuspendLayout()
        Me.mnuAsignatura.SuspendLayout()
        CType(Me.grdAsignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwAsignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grdAsignaturas)
        Me.Panel1.Controls.Add(Me.mnuAsignatura)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'mnuAsignatura
        '
        Me.mnuAsignatura.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuAsignatura.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdImprimir, Me.cmdActualizar, Me.cmdSalir, Me.ToolStripLabel1})
        Me.mnuAsignatura.Location = New System.Drawing.Point(0, 0)
        Me.mnuAsignatura.Name = "mnuAsignatura"
        Me.mnuAsignatura.Size = New System.Drawing.Size(800, 39)
        Me.mnuAsignatura.TabIndex = 0
        Me.mnuAsignatura.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar asignatura"
        Me.cmdAgregar.ToolTipText = "Agregar asignatura"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar Asignatura"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar Asignatura"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir Asignaturas"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActualizar.Text = "Refrescar"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.Text = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(158, 36)
        Me.ToolStripLabel1.Text = "Asignaturas Prueba"
        '
        'grdAsignaturas
        '
        Me.grdAsignaturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdAsignaturas.Location = New System.Drawing.Point(0, 39)
        Me.grdAsignaturas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAsignaturas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAsignaturas.MainView = Me.grdvwAsignaturas
        Me.grdAsignaturas.Name = "grdAsignaturas"
        Me.grdAsignaturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdAsignaturas.Size = New System.Drawing.Size(800, 411)
        Me.grdAsignaturas.TabIndex = 1
        Me.grdAsignaturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwAsignaturas})
        '
        'grdvwAsignaturas
        '
        Me.grdvwAsignaturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colNombre, Me.colCalificaDocente, Me.colActiva})
        Me.grdvwAsignaturas.GridControl = Me.grdAsignaturas
        Me.grdvwAsignaturas.Name = "grdvwAsignaturas"
        Me.grdvwAsignaturas.OptionsView.ShowAutoFilterRow = True
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "CodigoAsignatura"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        '
        'colCalificaDocente
        '
        Me.colCalificaDocente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCalificaDocente.AppearanceHeader.Options.UseFont = True
        Me.colCalificaDocente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCalificaDocente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCalificaDocente.Caption = "Califica Docente/Guia"
        Me.colCalificaDocente.FieldName = "SoloGuia"
        Me.colCalificaDocente.Name = "colCalificaDocente"
        Me.colCalificaDocente.OptionsColumn.AllowEdit = False
        Me.colCalificaDocente.Visible = True
        Me.colCalificaDocente.VisibleIndex = 2
        '
        'colActiva
        '
        Me.colActiva.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActiva.AppearanceHeader.Options.UseFont = True
        Me.colActiva.AppearanceHeader.Options.UseTextOptions = True
        Me.colActiva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActiva.Caption = "Activa"
        Me.colActiva.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colActiva.FieldName = "Activa"
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 3
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSraAsignaturasPrueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSraAsignaturasPrueba"
        Me.Text = "Consulta de asignaturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.mnuAsignatura.ResumeLayout(False)
        Me.mnuAsignatura.PerformLayout()
        CType(Me.grdAsignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwAsignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnuAsignatura As ToolStrip
    Friend WithEvents cmdAgregar As ToolStripButton
    Friend WithEvents cmdEditar As ToolStripButton
    Friend WithEvents cmdConsultar As ToolStripButton
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents cmdActualizar As ToolStripButton
    Friend WithEvents cmdSalir As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents grdAsignaturas As GridControl
    Friend WithEvents grdvwAsignaturas As GridView
    Friend WithEvents colCodigo As GridColumn
    Friend WithEvents colNombre As GridColumn
    Friend WithEvents colCalificaDocente As GridColumn
    Friend WithEvents colActiva As GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As RepositoryItemCheckEdit
End Class
