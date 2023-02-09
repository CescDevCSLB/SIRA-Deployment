<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbEmpleados))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdEmpleados = New DevExpress.XtraGrid.GridControl()
        Me.grdEmpleadosTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCedula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCargo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.XtraTabControlEmpleado = New DevExpress.XtraTab.XtraTabControl()
        Me.TabActivos = New DevExpress.XtraTab.XtraTabPage()
        Me.TabInactivos = New DevExpress.XtraTab.XtraTabPage()
        Me.grdEmpleadosInactivos = New DevExpress.XtraGrid.GridControl()
        Me.grdvwEmpleadosInactivos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cmdActivar = New System.Windows.Forms.ToolStripButton()
        Me.tbClientes.SuspendLayout()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEmpleadosTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControlEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControlEmpleado.SuspendLayout()
        Me.TabActivos.SuspendLayout()
        Me.TabInactivos.SuspendLayout()
        CType(Me.grdEmpleadosInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwEmpleadosInactivos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.ToolStripSeparator3, Me.cmdEditar, Me.ToolStripSeparator4, Me.cmdConsultar, Me.cmdActivar, Me.cmdInactivar, Me.ToolStripSeparator5, Me.cmdImprimir, Me.ToolStripSeparator6, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir, Me.ToolStripLabel1})
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
        Me.cmdAgregar.ToolTipText = "Agregar empleado"
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
        Me.cmdEditar.ToolTipText = "Editar empleado"
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
        Me.cmdConsultar.ToolTipText = "Consultar empleado"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar Cliente"
        Me.cmdInactivar.ToolTipText = "Inactivar empleado"
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
        Me.cmdSalir.ToolTipText = "Salir de Mantenimiento de empleados"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(184, 36)
        Me.ToolStripLabel1.Text = "Registro de empleados"
        '
        'grdEmpleados
        '
        Me.grdEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.grdEmpleados.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEmpleados.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEmpleados.MainView = Me.grdEmpleadosTabla
        Me.grdEmpleados.Name = "grdEmpleados"
        Me.grdEmpleados.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdEmpleados.Size = New System.Drawing.Size(982, 195)
        Me.grdEmpleados.TabIndex = 8
        Me.grdEmpleados.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEmpleadosTabla})
        '
        'grdEmpleadosTabla
        '
        Me.grdEmpleadosTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colNombre1, Me.colCedula, Me.colGenero, Me.colFechaIngreso, Me.colCargo, Me.colActivo})
        Me.grdEmpleadosTabla.GridControl = Me.grdEmpleados
        Me.grdEmpleadosTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdEmpleadosTabla.Name = "grdEmpleadosTabla"
        Me.grdEmpleadosTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdEmpleadosTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdEmpleadosTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdEmpleadosTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdEmpleadosTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdEmpleadosTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdEmpleadosTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "StbPersonaID"
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
        Me.colNombre1.Caption = "Nombre empleado"
        Me.colNombre1.FieldName = "NombreCompleto"
        Me.colNombre1.Name = "colNombre1"
        Me.colNombre1.OptionsColumn.AllowEdit = False
        Me.colNombre1.OptionsColumn.ReadOnly = True
        Me.colNombre1.Visible = True
        Me.colNombre1.VisibleIndex = 1
        Me.colNombre1.Width = 241
        '
        'colCedula
        '
        Me.colCedula.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCedula.AppearanceHeader.Options.UseFont = True
        Me.colCedula.AppearanceHeader.Options.UseTextOptions = True
        Me.colCedula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCedula.Caption = "No. Cédula"
        Me.colCedula.FieldName = "Cedula"
        Me.colCedula.Name = "colCedula"
        Me.colCedula.OptionsColumn.AllowEdit = False
        Me.colCedula.Visible = True
        Me.colCedula.VisibleIndex = 0
        Me.colCedula.Width = 137
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
        Me.colGenero.VisibleIndex = 3
        Me.colGenero.Width = 106
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaIngreso.AppearanceHeader.Options.UseFont = True
        Me.colFechaIngreso.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaIngreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaIngreso.Caption = "Fecha de Ingreso"
        Me.colFechaIngreso.FieldName = "FechaIngreso"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.OptionsColumn.AllowEdit = False
        Me.colFechaIngreso.Visible = True
        Me.colFechaIngreso.VisibleIndex = 4
        Me.colFechaIngreso.Width = 406
        '
        'colCargo
        '
        Me.colCargo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCargo.AppearanceHeader.Options.UseFont = True
        Me.colCargo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCargo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCargo.Caption = "Cargo"
        Me.colCargo.FieldName = "Cargo"
        Me.colCargo.Name = "colCargo"
        Me.colCargo.OptionsColumn.AllowEdit = False
        Me.colCargo.Visible = True
        Me.colCargo.VisibleIndex = 2
        Me.colCargo.Width = 80
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
        Me.colActivo.VisibleIndex = 5
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
        'XtraTabControlEmpleado
        '
        Me.XtraTabControlEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControlEmpleado.Location = New System.Drawing.Point(0, 39)
        Me.XtraTabControlEmpleado.Name = "XtraTabControlEmpleado"
        Me.XtraTabControlEmpleado.SelectedTabPage = Me.TabActivos
        Me.XtraTabControlEmpleado.Size = New System.Drawing.Size(988, 223)
        Me.XtraTabControlEmpleado.TabIndex = 9
        Me.XtraTabControlEmpleado.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabActivos, Me.TabInactivos})
        '
        'TabActivos
        '
        Me.TabActivos.Controls.Add(Me.grdEmpleados)
        Me.TabActivos.Name = "TabActivos"
        Me.TabActivos.Size = New System.Drawing.Size(982, 195)
        Me.TabActivos.Text = "Empleados activos"
        '
        'TabInactivos
        '
        Me.TabInactivos.Controls.Add(Me.grdEmpleadosInactivos)
        Me.TabInactivos.Name = "TabInactivos"
        Me.TabInactivos.Size = New System.Drawing.Size(982, 195)
        Me.TabInactivos.Text = "Empleados inactivos"
        '
        'grdEmpleadosInactivos
        '
        Me.grdEmpleadosInactivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdEmpleadosInactivos.Location = New System.Drawing.Point(0, 0)
        Me.grdEmpleadosInactivos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEmpleadosInactivos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEmpleadosInactivos.MainView = Me.grdvwEmpleadosInactivos
        Me.grdEmpleadosInactivos.Name = "grdEmpleadosInactivos"
        Me.grdEmpleadosInactivos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3, Me.RepositoryItemCheckEdit4})
        Me.grdEmpleadosInactivos.Size = New System.Drawing.Size(982, 195)
        Me.grdEmpleadosInactivos.TabIndex = 9
        Me.grdEmpleadosInactivos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwEmpleadosInactivos})
        '
        'grdvwEmpleadosInactivos
        '
        Me.grdvwEmpleadosInactivos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.grdvwEmpleadosInactivos.GridControl = Me.grdEmpleadosInactivos
        Me.grdvwEmpleadosInactivos.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdvwEmpleadosInactivos.Name = "grdvwEmpleadosInactivos"
        Me.grdvwEmpleadosInactivos.OptionsDetail.AllowZoomDetail = False
        Me.grdvwEmpleadosInactivos.OptionsDetail.EnableMasterViewMode = False
        Me.grdvwEmpleadosInactivos.OptionsDetail.ShowDetailTabs = False
        Me.grdvwEmpleadosInactivos.OptionsDetail.SmartDetailExpand = False
        Me.grdvwEmpleadosInactivos.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdvwEmpleadosInactivos.OptionsView.ShowAutoFilterRow = True
        Me.grdvwEmpleadosInactivos.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Número"
        Me.GridColumn1.FieldName = "StbPersonaID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Width = 76
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn2.AppearanceHeader.Options.UseFont = True
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Nombre empleado"
        Me.GridColumn2.FieldName = "NombreCompleto"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 241
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "No. Cédula"
        Me.GridColumn3.FieldName = "Cedula"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 137
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn4.AppearanceHeader.Options.UseFont = True
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Género"
        Me.GridColumn4.FieldName = "Genero"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 106
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn5.AppearanceHeader.Options.UseFont = True
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Fecha de Ingreso"
        Me.GridColumn5.FieldName = "FechaIngreso"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 406
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn6.AppearanceHeader.Options.UseFont = True
        Me.GridColumn6.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Cargo"
        Me.GridColumn6.FieldName = "Cargo"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 80
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn7.AppearanceHeader.Options.UseFont = True
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Activo"
        Me.GridColumn7.FieldName = "Activo"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'cmdActivar
        '
        Me.cmdActivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdActivar.Image = CType(resources.GetObject("cmdActivar.Image"), System.Drawing.Image)
        Me.cmdActivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdActivar.Name = "cmdActivar"
        Me.cmdActivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdActivar.ToolTipText = "Activar empleado"
        '
        'frmStbEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 262)
        Me.Controls.Add(Me.XtraTabControlEmpleado)
        Me.Controls.Add(Me.tbClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStbEmpleados"
        Me.Text = "Registro de empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.grdEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEmpleadosTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControlEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControlEmpleado.ResumeLayout(False)
        Me.TabActivos.ResumeLayout(False)
        Me.TabInactivos.ResumeLayout(False)
        CType(Me.grdEmpleadosInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwEmpleadosInactivos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdEmpleados As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEmpleadosTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCedula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colFechaIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents XtraTabControlEmpleado As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabActivos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabInactivos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grdEmpleadosInactivos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwEmpleadosInactivos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmdActivar As ToolStripButton
End Class
