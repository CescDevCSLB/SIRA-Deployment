<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbAlumnos))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdDescargar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdClientes = New DevExpress.XtraGrid.GridControl()
        Me.grdClientesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoMED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.OFDFoto = New System.Windows.Forms.SaveFileDialog()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbClientes.SuspendLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdClientesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.ToolStripSeparator3, Me.cmdEditar, Me.ToolStripSeparator4, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmdInactivar, Me.cmdDescargar, Me.ToolStripSeparator5, Me.cmdImprimir, Me.ToolStripSeparator6, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(988, 39)
        Me.tbClientes.TabIndex = 1
        Me.tbClientes.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar alumno"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar alumno"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar alumno"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar Cliente"
        Me.cmdInactivar.ToolTipText = "Inactivar alumno"
        '
        'cmdDescargar
        '
        Me.cmdDescargar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDescargar.Image = CType(resources.GetObject("cmdDescargar.Image"), System.Drawing.Image)
        Me.cmdDescargar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDescargar.Name = "cmdDescargar"
        Me.cmdDescargar.Size = New System.Drawing.Size(36, 36)
        Me.cmdDescargar.ToolTipText = "Descargar foto"
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
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(166, 36)
        Me.ToolStripLabel1.Text = "Registro de alumnos"
        '
        'grdClientes
        '
        Me.grdClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdClientes.Location = New System.Drawing.Point(0, 39)
        Me.grdClientes.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdClientes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdClientes.MainView = Me.grdClientesTabla
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdClientes.Size = New System.Drawing.Size(988, 223)
        Me.grdClientes.TabIndex = 8
        Me.grdClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdClientesTabla})
        '
        'grdClientesTabla
        '
        Me.grdClientesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEdad, Me.colNumero, Me.colNombre1, Me.colCodigoMED, Me.colGenero, Me.colActivo})
        Me.grdClientesTabla.GridControl = Me.grdClientes
        Me.grdClientesTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdClientesTabla.Name = "grdClientesTabla"
        Me.grdClientesTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdClientesTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdClientesTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdClientesTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdClientesTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdClientesTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdClientesTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colEdad
        '
        Me.colEdad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEdad.AppearanceHeader.Options.UseFont = True
        Me.colEdad.AppearanceHeader.Options.UseTextOptions = True
        Me.colEdad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEdad.Caption = "Edad"
        Me.colEdad.FieldName = "Edad"
        Me.colEdad.Name = "colEdad"
        Me.colEdad.OptionsColumn.AllowEdit = False
        Me.colEdad.OptionsColumn.ReadOnly = True
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 3
        Me.colEdad.Width = 93
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "AlumnoID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colNombre1
        '
        Me.colNombre1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre1.AppearanceHeader.Options.UseFont = True
        Me.colNombre1.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre1.Caption = "Nombre Alumno"
        Me.colNombre1.FieldName = "NombreCompleto"
        Me.colNombre1.Name = "colNombre1"
        Me.colNombre1.OptionsColumn.AllowEdit = False
        Me.colNombre1.OptionsColumn.ReadOnly = True
        Me.colNombre1.Visible = True
        Me.colNombre1.VisibleIndex = 2
        Me.colNombre1.Width = 504
        '
        'colCodigoMED
        '
        Me.colCodigoMED.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoMED.AppearanceHeader.Options.UseFont = True
        Me.colCodigoMED.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoMED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoMED.Caption = "Código MINED"
        Me.colCodigoMED.FieldName = "CodigoMED"
        Me.colCodigoMED.Name = "colCodigoMED"
        Me.colCodigoMED.OptionsColumn.AllowEdit = False
        Me.colCodigoMED.Visible = True
        Me.colCodigoMED.VisibleIndex = 0
        Me.colCodigoMED.Width = 131
        '
        'colGenero
        '
        Me.colGenero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGenero.AppearanceHeader.Options.UseFont = True
        Me.colGenero.AppearanceHeader.Options.UseTextOptions = True
        Me.colGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGenero.Caption = "Género"
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.Name = "colGenero"
        Me.colGenero.OptionsColumn.AllowEdit = False
        Me.colGenero.Visible = True
        Me.colGenero.VisibleIndex = 1
        Me.colGenero.Width = 159
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'objUbicacion
        '
        Me.objUbicacion.Filter = "Microsoft Excel | *.xls"
        '
        'colActivo
        '
        Me.colActivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colActivo.AppearanceHeader.Options.UseFont = True
        Me.colActivo.AppearanceHeader.Options.UseTextOptions = True
        Me.colActivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActivo.Caption = "Activo"
        Me.colActivo.FieldName = "Activo"
        Me.colActivo.Name = "colActivo"
        Me.colActivo.OptionsColumn.AllowEdit = False
        Me.colActivo.Visible = True
        Me.colActivo.VisibleIndex = 4
        Me.colActivo.Width = 83
        '
        'frmStbAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 262)
        Me.Controls.Add(Me.grdClientes)
        Me.Controls.Add(Me.tbClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStbAlumnos"
        Me.Text = "Registro de Alumnos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.grdClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdClientesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdClientesTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigoMED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdDescargar As System.Windows.Forms.ToolStripButton
    Friend WithEvents OFDFoto As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
End Class
