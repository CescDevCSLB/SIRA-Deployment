<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraAsignarGrupos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraAsignarGrupos))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.cmdAsignarGrupo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.barButtonVerGrupos = New DevExpress.XtraBars.BarButtonItem()
        Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.XtraTabPageGrupos = New DevExpress.XtraTab.XtraTabPage()
        Me.Contenedor = New C1.Win.C1Sizer.C1Sizer()
        Me.grdGrupoMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdGrupoMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.grdGrupoDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdGrupoDetalleTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSraAlumno_GrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGeneros = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEscuelaProcedencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grdSeleccion = New DevExpress.XtraGrid.GridControl()
        Me.grdvwSeleccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colBecaSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumnoSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGradoSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalidadSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMEDSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdadSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObjAlumnoSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTieneGrupoSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGeneroSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMatriculaIDSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccionSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColEscuelaSelect = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPageMatricula = New DevExpress.XtraTab.XtraTabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grdMatriculas = New DevExpress.XtraGrid.GridControl()
        Me.grdMatriculasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colestado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBeca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModadlidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoMED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjAlumnoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTieneGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSraMatriculaAlumnos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEscuela = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.TabControlGrupos = New DevExpress.XtraTab.XtraTabControl()
        Me.tbClientes.SuspendLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPageGrupos.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.SuspendLayout()
        CType(Me.grdGrupoMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupoMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGrupoDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPageMatricula.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grdMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMatriculasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAsignarGrupo, Me.ToolStripSeparator3, Me.cmdEditar, Me.cmdInactivar, Me.cmdImprimir, Me.ToolStripSeparator6, Me.cmdRefrescar, Me.cmdSalir, Me.ToolStripSeparator2, Me.ToolStripLabel1})
        Me.tbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(1317, 39)
        Me.tbClientes.TabIndex = 1
        Me.tbClientes.Text = "ToolStrip1"
        '
        'cmdAsignarGrupo
        '
        Me.cmdAsignarGrupo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAsignarGrupo.Image = CType(resources.GetObject("cmdAsignarGrupo.Image"), System.Drawing.Image)
        Me.cmdAsignarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAsignarGrupo.Name = "cmdAsignarGrupo"
        Me.cmdAsignarGrupo.Size = New System.Drawing.Size(36, 36)
        Me.cmdAsignarGrupo.Text = "Aisgnar grupo"
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
        Me.cmdEditar.ToolTipText = "Cambiar de grupo"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Enabled = False
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.ToolTipText = "Eliminar alumno del grupo"
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
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(155, 36)
        Me.ToolStripLabel1.Text = "Asignar grupos"
        '
        'objUbicacion
        '
        Me.objUbicacion.Filter = "Microsoft Excel | *.xls"
        '
        'barManager1
        '
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonVerGrupos, Me.barButtonItem2})
        Me.barManager1.MaxItemId = 2
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1317, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 558)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1317, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 558)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1317, 0)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 558)
        '
        'barButtonVerGrupos
        '
        Me.barButtonVerGrupos.Caption = "Ver Grupo"
        Me.barButtonVerGrupos.Id = 0
        Me.barButtonVerGrupos.Name = "barButtonVerGrupos"
        '
        'barButtonItem2
        '
        Me.barButtonItem2.Caption = "Item 2"
        Me.barButtonItem2.Id = 1
        Me.barButtonItem2.Name = "barButtonItem2"
        Me.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'popupMenu1
        '
        Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonVerGrupos), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2)})
        Me.popupMenu1.Manager = Me.barManager1
        Me.popupMenu1.Name = "popupMenu1"
        '
        'XtraTabPageGrupos
        '
        Me.XtraTabPageGrupos.Controls.Add(Me.Contenedor)
        Me.XtraTabPageGrupos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPageGrupos.Name = "XtraTabPageGrupos"
        Me.XtraTabPageGrupos.Size = New System.Drawing.Size(1315, 480)
        Me.XtraTabPageGrupos.Text = "Grupos asignados"
        '
        'Contenedor
        '
        Me.Contenedor.Controls.Add(Me.grdGrupoMaster)
        Me.Contenedor.Controls.Add(Me.grdGrupoDetalle)
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.GridDefinition = "32.2916666666667:False:False;65.2083333333333:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.3916349809886:False" &
    ":False;"
        Me.Contenedor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Contenedor.Location = New System.Drawing.Point(0, 0)
        Me.Contenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Size = New System.Drawing.Size(1315, 480)
        Me.Contenedor.TabIndex = 8
        Me.Contenedor.TabStop = False
        '
        'grdGrupoMaster
        '
        Me.grdGrupoMaster.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdGrupoMaster.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGrupoMaster.Location = New System.Drawing.Point(4, 4)
        Me.grdGrupoMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGrupoMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGrupoMaster.MainView = Me.grdGrupoMasterTabla
        Me.grdGrupoMaster.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGrupoMaster.Name = "grdGrupoMaster"
        Me.grdGrupoMaster.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit3})
        Me.grdGrupoMaster.Size = New System.Drawing.Size(1307, 155)
        Me.grdGrupoMaster.TabIndex = 8
        Me.grdGrupoMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGrupoMasterTabla})
        '
        'grdGrupoMasterTabla
        '
        Me.grdGrupoMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colSeccion, Me.colGuia, Me.colActiva})
        Me.grdGrupoMasterTabla.DetailHeight = 431
        Me.grdGrupoMasterTabla.GridControl = Me.grdGrupoMaster
        Me.grdGrupoMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGrupoMasterTabla.Name = "grdGrupoMasterTabla"
        Me.grdGrupoMasterTabla.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdGrupoMasterTabla.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grdGrupoMasterTabla.OptionsBehavior.Editable = False
        Me.grdGrupoMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdGrupoMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdGrupoMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdGrupoMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdGrupoMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdGrupoMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdGrupoMasterTabla.OptionsView.ShowFooter = True
        Me.grdGrupoMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Número"
        Me.GridColumn1.FieldName = "SraGrupoID"
        Me.GridColumn1.MinWidth = 27
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowFocus = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Width = 101
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Grado"
        Me.GridColumn2.FieldName = "Grado"
        Me.GridColumn2.MinWidth = 27
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 189
        '
        'colSeccion
        '
        Me.colSeccion.Caption = "Seccion"
        Me.colSeccion.FieldName = "Seccion"
        Me.colSeccion.MinWidth = 27
        Me.colSeccion.Name = "colSeccion"
        Me.colSeccion.OptionsColumn.AllowEdit = False
        Me.colSeccion.OptionsColumn.ReadOnly = True
        Me.colSeccion.Visible = True
        Me.colSeccion.VisibleIndex = 1
        Me.colSeccion.Width = 185
        '
        'colGuia
        '
        Me.colGuia.Caption = "Guia"
        Me.colGuia.FieldName = "Guia"
        Me.colGuia.MinWidth = 27
        Me.colGuia.Name = "colGuia"
        Me.colGuia.OptionsColumn.AllowEdit = False
        Me.colGuia.OptionsColumn.ReadOnly = True
        Me.colGuia.Visible = True
        Me.colGuia.VisibleIndex = 2
        Me.colGuia.Width = 364
        '
        'colActiva
        '
        Me.colActiva.Caption = "Modadlidad"
        Me.colActiva.FieldName = "Modalidad"
        Me.colActiva.MinWidth = 27
        Me.colActiva.Name = "colActiva"
        Me.colActiva.OptionsColumn.AllowEdit = False
        Me.colActiva.OptionsColumn.ReadOnly = True
        Me.colActiva.Visible = True
        Me.colActiva.VisibleIndex = 3
        Me.colActiva.Width = 217
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'grdGrupoDetalle
        '
        Me.grdGrupoDetalle.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGrupoDetalle.Location = New System.Drawing.Point(4, 163)
        Me.grdGrupoDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGrupoDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGrupoDetalle.MainView = Me.grdGrupoDetalleTabla
        Me.grdGrupoDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdGrupoDetalle.Name = "grdGrupoDetalle"
        Me.grdGrupoDetalle.Size = New System.Drawing.Size(1307, 313)
        Me.grdGrupoDetalle.TabIndex = 3
        Me.grdGrupoDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdGrupoDetalleTabla, Me.GridView1})
        '
        'grdGrupoDetalleTabla
        '
        Me.grdGrupoDetalleTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSraAlumno_GrupoID, Me.colobjGrupoID, Me.colNombre, Me.colGeneros, Me.colEdades, Me.colCodigoAlumno, Me.colEscuelaProcedencia})
        Me.grdGrupoDetalleTabla.DetailHeight = 431
        Me.grdGrupoDetalleTabla.GridControl = Me.grdGrupoDetalle
        Me.grdGrupoDetalleTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdGrupoDetalleTabla.Name = "grdGrupoDetalleTabla"
        Me.grdGrupoDetalleTabla.OptionsView.ShowAutoFilterRow = True
        '
        'colSraAlumno_GrupoID
        '
        Me.colSraAlumno_GrupoID.Caption = "SraAlumno_GrupoID"
        Me.colSraAlumno_GrupoID.FieldName = "SraAlumno_GrupoID"
        Me.colSraAlumno_GrupoID.MinWidth = 27
        Me.colSraAlumno_GrupoID.Name = "colSraAlumno_GrupoID"
        Me.colSraAlumno_GrupoID.OptionsColumn.AllowFocus = False
        Me.colSraAlumno_GrupoID.OptionsColumn.ReadOnly = True
        Me.colSraAlumno_GrupoID.Width = 100
        '
        'colobjGrupoID
        '
        Me.colobjGrupoID.Caption = "objGrupoID"
        Me.colobjGrupoID.FieldName = "objGrupoID"
        Me.colobjGrupoID.MinWidth = 27
        Me.colobjGrupoID.Name = "colobjGrupoID"
        Me.colobjGrupoID.OptionsColumn.AllowFocus = False
        Me.colobjGrupoID.OptionsColumn.ReadOnly = True
        Me.colobjGrupoID.Width = 100
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "NombreCompleto"
        Me.colNombre.MinWidth = 27
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowFocus = False
        Me.colNombre.OptionsColumn.ReadOnly = True
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 488
        '
        'colGeneros
        '
        Me.colGeneros.Caption = "Genero"
        Me.colGeneros.FieldName = "Genero"
        Me.colGeneros.MinWidth = 27
        Me.colGeneros.Name = "colGeneros"
        Me.colGeneros.OptionsColumn.AllowEdit = False
        Me.colGeneros.OptionsColumn.AllowFocus = False
        Me.colGeneros.OptionsColumn.ReadOnly = True
        Me.colGeneros.Visible = True
        Me.colGeneros.VisibleIndex = 2
        Me.colGeneros.Width = 444
        '
        'colEdades
        '
        Me.colEdades.Caption = "Edad"
        Me.colEdades.FieldName = "Edad"
        Me.colEdades.MinWidth = 27
        Me.colEdades.Name = "colEdades"
        Me.colEdades.OptionsColumn.AllowEdit = False
        Me.colEdades.OptionsColumn.ReadOnly = True
        Me.colEdades.Visible = True
        Me.colEdades.VisibleIndex = 3
        Me.colEdades.Width = 177
        '
        'colCodigoAlumno
        '
        Me.colCodigoAlumno.Caption = "Codigo"
        Me.colCodigoAlumno.FieldName = "Codigo"
        Me.colCodigoAlumno.MinWidth = 27
        Me.colCodigoAlumno.Name = "colCodigoAlumno"
        Me.colCodigoAlumno.Visible = True
        Me.colCodigoAlumno.VisibleIndex = 0
        Me.colCodigoAlumno.Width = 184
        '
        'colEscuelaProcedencia
        '
        Me.colEscuelaProcedencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colEscuelaProcedencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEscuelaProcedencia.Caption = "Escuela de procedencia"
        Me.colEscuelaProcedencia.FieldName = "Escuela"
        Me.colEscuelaProcedencia.MinWidth = 27
        Me.colEscuelaProcedencia.Name = "colEscuelaProcedencia"
        Me.colEscuelaProcedencia.OptionsColumn.AllowEdit = False
        Me.colEscuelaProcedencia.Visible = True
        Me.colEscuelaProcedencia.VisibleIndex = 4
        Me.colEscuelaProcedencia.Width = 416
        '
        'GridView1
        '
        Me.GridView1.DetailHeight = 431
        Me.GridView1.GridControl = Me.grdGrupoDetalle
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.DetailHeight = 431
        Me.GridView2.GridControl = Me.grdSeleccion
        Me.GridView2.Name = "GridView2"
        '
        'grdSeleccion
        '
        Me.grdSeleccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSeleccion.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdSeleccion.Location = New System.Drawing.Point(4, 314)
        Me.grdSeleccion.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdSeleccion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdSeleccion.MainView = Me.grdvwSeleccion
        Me.grdSeleccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdSeleccion.Name = "grdSeleccion"
        Me.grdSeleccion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit4, Me.RepositoryItemCheckEdit5})
        Me.grdSeleccion.Size = New System.Drawing.Size(1307, 171)
        Me.grdSeleccion.TabIndex = 143
        Me.grdSeleccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwSeleccion, Me.GridView4, Me.GridView2})
        '
        'grdvwSeleccion
        '
        Me.grdvwSeleccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colBecaSelect, Me.colAlumnoSelect, Me.colGradoSelect, Me.colModalidadSelect, Me.colMEDSelect, Me.colEdadSelect, Me.colObjAlumnoSelect, Me.colTieneGrupoSelect, Me.colGeneroSelect, Me.colMatriculaIDSelect, Me.colDireccionSelect, Me.ColEscuelaSelect})
        Me.grdvwSeleccion.DetailHeight = 431
        Me.grdvwSeleccion.GridControl = Me.grdSeleccion
        Me.grdvwSeleccion.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdvwSeleccion.Name = "grdvwSeleccion"
        Me.grdvwSeleccion.OptionsDetail.AllowZoomDetail = False
        Me.grdvwSeleccion.OptionsDetail.EnableMasterViewMode = False
        Me.grdvwSeleccion.OptionsDetail.ShowDetailTabs = False
        Me.grdvwSeleccion.OptionsDetail.SmartDetailExpand = False
        Me.grdvwSeleccion.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdvwSeleccion.OptionsSelection.MultiSelect = True
        Me.grdvwSeleccion.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdvwSeleccion.OptionsView.ShowAutoFilterRow = True
        Me.grdvwSeleccion.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colBecaSelect
        '
        Me.colBecaSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBecaSelect.AppearanceHeader.Options.UseFont = True
        Me.colBecaSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colBecaSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBecaSelect.Caption = "Beca"
        Me.colBecaSelect.FieldName = "Beca"
        Me.colBecaSelect.MinWidth = 27
        Me.colBecaSelect.Name = "colBecaSelect"
        Me.colBecaSelect.OptionsColumn.AllowEdit = False
        Me.colBecaSelect.OptionsColumn.ReadOnly = True
        Me.colBecaSelect.Visible = True
        Me.colBecaSelect.VisibleIndex = 7
        Me.colBecaSelect.Width = 105
        '
        'colAlumnoSelect
        '
        Me.colAlumnoSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumnoSelect.AppearanceHeader.Options.UseFont = True
        Me.colAlumnoSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumnoSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumnoSelect.Caption = "Nombre Alumno"
        Me.colAlumnoSelect.FieldName = "Alumno"
        Me.colAlumnoSelect.MinWidth = 27
        Me.colAlumnoSelect.Name = "colAlumnoSelect"
        Me.colAlumnoSelect.OptionsColumn.AllowEdit = False
        Me.colAlumnoSelect.OptionsColumn.ReadOnly = True
        Me.colAlumnoSelect.Visible = True
        Me.colAlumnoSelect.VisibleIndex = 2
        Me.colAlumnoSelect.Width = 140
        '
        'colGradoSelect
        '
        Me.colGradoSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGradoSelect.AppearanceHeader.Options.UseFont = True
        Me.colGradoSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colGradoSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGradoSelect.Caption = "Grado"
        Me.colGradoSelect.FieldName = "Grado"
        Me.colGradoSelect.MinWidth = 27
        Me.colGradoSelect.Name = "colGradoSelect"
        Me.colGradoSelect.OptionsColumn.AllowEdit = False
        Me.colGradoSelect.Visible = True
        Me.colGradoSelect.VisibleIndex = 5
        Me.colGradoSelect.Width = 88
        '
        'colModalidadSelect
        '
        Me.colModalidadSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModalidadSelect.AppearanceHeader.Options.UseFont = True
        Me.colModalidadSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colModalidadSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModalidadSelect.Caption = "Modalidad"
        Me.colModalidadSelect.FieldName = "Modadlidad"
        Me.colModalidadSelect.MinWidth = 27
        Me.colModalidadSelect.Name = "colModalidadSelect"
        Me.colModalidadSelect.OptionsColumn.AllowEdit = False
        Me.colModalidadSelect.Visible = True
        Me.colModalidadSelect.VisibleIndex = 6
        Me.colModalidadSelect.Width = 111
        '
        'colMEDSelect
        '
        Me.colMEDSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMEDSelect.AppearanceHeader.Options.UseFont = True
        Me.colMEDSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colMEDSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMEDSelect.Caption = "Código MINED"
        Me.colMEDSelect.FieldName = "CodigoMED"
        Me.colMEDSelect.MinWidth = 27
        Me.colMEDSelect.Name = "colMEDSelect"
        Me.colMEDSelect.OptionsColumn.AllowEdit = False
        Me.colMEDSelect.Visible = True
        Me.colMEDSelect.VisibleIndex = 1
        Me.colMEDSelect.Width = 107
        '
        'colEdadSelect
        '
        Me.colEdadSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEdadSelect.AppearanceHeader.Options.UseFont = True
        Me.colEdadSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colEdadSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEdadSelect.Caption = "Edad"
        Me.colEdadSelect.FieldName = "Edad"
        Me.colEdadSelect.MinWidth = 27
        Me.colEdadSelect.Name = "colEdadSelect"
        Me.colEdadSelect.OptionsColumn.AllowEdit = False
        Me.colEdadSelect.Visible = True
        Me.colEdadSelect.VisibleIndex = 4
        Me.colEdadSelect.Width = 57
        '
        'colObjAlumnoSelect
        '
        Me.colObjAlumnoSelect.Caption = "objAlumnoID"
        Me.colObjAlumnoSelect.FieldName = "objAlumnoID"
        Me.colObjAlumnoSelect.MinWidth = 27
        Me.colObjAlumnoSelect.Name = "colObjAlumnoSelect"
        Me.colObjAlumnoSelect.Width = 100
        '
        'colTieneGrupoSelect
        '
        Me.colTieneGrupoSelect.Caption = "TieneGrupo"
        Me.colTieneGrupoSelect.FieldName = "TieneGrupo"
        Me.colTieneGrupoSelect.MinWidth = 27
        Me.colTieneGrupoSelect.Name = "colTieneGrupoSelect"
        Me.colTieneGrupoSelect.Width = 100
        '
        'colGeneroSelect
        '
        Me.colGeneroSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGeneroSelect.AppearanceHeader.Options.UseFont = True
        Me.colGeneroSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colGeneroSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGeneroSelect.Caption = "Género"
        Me.colGeneroSelect.FieldName = "Genero"
        Me.colGeneroSelect.MinWidth = 27
        Me.colGeneroSelect.Name = "colGeneroSelect"
        Me.colGeneroSelect.OptionsColumn.AllowEdit = False
        Me.colGeneroSelect.Visible = True
        Me.colGeneroSelect.VisibleIndex = 3
        Me.colGeneroSelect.Width = 61
        '
        'colMatriculaIDSelect
        '
        Me.colMatriculaIDSelect.Caption = "SraMatriculaAlumnos"
        Me.colMatriculaIDSelect.FieldName = "SraMatriculaAlumnos"
        Me.colMatriculaIDSelect.MinWidth = 27
        Me.colMatriculaIDSelect.Name = "colMatriculaIDSelect"
        Me.colMatriculaIDSelect.Width = 100
        '
        'colDireccionSelect
        '
        Me.colDireccionSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDireccionSelect.AppearanceHeader.Options.UseFont = True
        Me.colDireccionSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.colDireccionSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDireccionSelect.Caption = "Dirección"
        Me.colDireccionSelect.FieldName = "Direccion"
        Me.colDireccionSelect.MinWidth = 27
        Me.colDireccionSelect.Name = "colDireccionSelect"
        Me.colDireccionSelect.OptionsColumn.AllowEdit = False
        Me.colDireccionSelect.Visible = True
        Me.colDireccionSelect.VisibleIndex = 8
        Me.colDireccionSelect.Width = 224
        '
        'ColEscuelaSelect
        '
        Me.ColEscuelaSelect.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColEscuelaSelect.AppearanceHeader.Options.UseFont = True
        Me.ColEscuelaSelect.AppearanceHeader.Options.UseTextOptions = True
        Me.ColEscuelaSelect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColEscuelaSelect.Caption = "Escuela de procedencia"
        Me.ColEscuelaSelect.FieldName = "EscuelaProcedente"
        Me.ColEscuelaSelect.MinWidth = 27
        Me.ColEscuelaSelect.Name = "ColEscuelaSelect"
        Me.ColEscuelaSelect.OptionsColumn.AllowEdit = False
        Me.ColEscuelaSelect.Visible = True
        Me.ColEscuelaSelect.VisibleIndex = 9
        Me.ColEscuelaSelect.Width = 181
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Caption = "Check"
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
        '
        'GridView4
        '
        Me.GridView4.DetailHeight = 431
        Me.GridView4.GridControl = Me.grdSeleccion
        Me.GridView4.Name = "GridView4"
        '
        'XtraTabPageMatricula
        '
        Me.XtraTabPageMatricula.Controls.Add(Me.TableLayoutPanel1)
        Me.XtraTabPageMatricula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPageMatricula.Name = "XtraTabPageMatricula"
        Me.XtraTabPageMatricula.Size = New System.Drawing.Size(1315, 489)
        Me.XtraTabPageMatricula.Text = "Alumnos matriculados"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grdSeleccion, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.grdMatriculas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelControl1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1315, 489)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'grdMatriculas
        '
        Me.grdMatriculas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMatriculas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdMatriculas.Location = New System.Drawing.Point(4, 4)
        Me.grdMatriculas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdMatriculas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdMatriculas.MainView = Me.grdMatriculasTabla
        Me.grdMatriculas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdMatriculas.Name = "grdMatriculas"
        Me.grdMatriculas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdMatriculas.Size = New System.Drawing.Size(1307, 258)
        Me.grdMatriculas.TabIndex = 142
        Me.grdMatriculas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdMatriculasTabla, Me.GridView3})
        '
        'grdMatriculasTabla
        '
        Me.grdMatriculasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colestado, Me.colBeca, Me.colNumero, Me.colAlumno, Me.colGrado, Me.colModadlidad, Me.colCodigoMED, Me.colEdad, Me.colobjAlumnoID, Me.colTieneGrupo, Me.colGenero, Me.colSraMatriculaAlumnos, Me.colDireccion, Me.colEscuela})
        Me.grdMatriculasTabla.DetailHeight = 431
        Me.grdMatriculasTabla.GridControl = Me.grdMatriculas
        Me.grdMatriculasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdMatriculasTabla.Name = "grdMatriculasTabla"
        Me.grdMatriculasTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdMatriculasTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdMatriculasTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdMatriculasTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdMatriculasTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdMatriculasTabla.OptionsSelection.MultiSelect = True
        Me.grdMatriculasTabla.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdMatriculasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdMatriculasTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colestado
        '
        Me.colestado.Caption = "TieneGrupo"
        Me.colestado.FieldName = "TieneGrupo"
        Me.colestado.MinWidth = 27
        Me.colestado.Name = "colestado"
        Me.colestado.Width = 100
        '
        'colBeca
        '
        Me.colBeca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBeca.AppearanceHeader.Options.UseFont = True
        Me.colBeca.AppearanceHeader.Options.UseTextOptions = True
        Me.colBeca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBeca.Caption = "Beca"
        Me.colBeca.FieldName = "Beca"
        Me.colBeca.MinWidth = 27
        Me.colBeca.Name = "colBeca"
        Me.colBeca.OptionsColumn.AllowEdit = False
        Me.colBeca.OptionsColumn.ReadOnly = True
        Me.colBeca.Visible = True
        Me.colBeca.VisibleIndex = 7
        Me.colBeca.Width = 105
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SraMatriculaAlumnos"
        Me.colNumero.MinWidth = 27
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 101
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Nombre Alumno"
        Me.colAlumno.FieldName = "Alumno"
        Me.colAlumno.MinWidth = 27
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.OptionsColumn.AllowEdit = False
        Me.colAlumno.OptionsColumn.ReadOnly = True
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 2
        Me.colAlumno.Width = 140
        '
        'colGrado
        '
        Me.colGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrado.AppearanceHeader.Options.UseFont = True
        Me.colGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrado.Caption = "Grado"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.MinWidth = 27
        Me.colGrado.Name = "colGrado"
        Me.colGrado.OptionsColumn.AllowEdit = False
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 5
        Me.colGrado.Width = 88
        '
        'colModadlidad
        '
        Me.colModadlidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModadlidad.AppearanceHeader.Options.UseFont = True
        Me.colModadlidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModadlidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModadlidad.Caption = "Modalidad"
        Me.colModadlidad.FieldName = "Modadlidad"
        Me.colModadlidad.MinWidth = 27
        Me.colModadlidad.Name = "colModadlidad"
        Me.colModadlidad.OptionsColumn.AllowEdit = False
        Me.colModadlidad.Visible = True
        Me.colModadlidad.VisibleIndex = 6
        Me.colModadlidad.Width = 111
        '
        'colCodigoMED
        '
        Me.colCodigoMED.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoMED.AppearanceHeader.Options.UseFont = True
        Me.colCodigoMED.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoMED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoMED.Caption = "Código MINED"
        Me.colCodigoMED.FieldName = "CodigoMED"
        Me.colCodigoMED.MinWidth = 27
        Me.colCodigoMED.Name = "colCodigoMED"
        Me.colCodigoMED.OptionsColumn.AllowEdit = False
        Me.colCodigoMED.Visible = True
        Me.colCodigoMED.VisibleIndex = 1
        Me.colCodigoMED.Width = 107
        '
        'colEdad
        '
        Me.colEdad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEdad.AppearanceHeader.Options.UseFont = True
        Me.colEdad.AppearanceHeader.Options.UseTextOptions = True
        Me.colEdad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEdad.Caption = "Edad"
        Me.colEdad.FieldName = "Edad"
        Me.colEdad.MinWidth = 27
        Me.colEdad.Name = "colEdad"
        Me.colEdad.OptionsColumn.AllowEdit = False
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 4
        Me.colEdad.Width = 57
        '
        'colobjAlumnoID
        '
        Me.colobjAlumnoID.Caption = "objAlumnoID"
        Me.colobjAlumnoID.FieldName = "objAlumnoID"
        Me.colobjAlumnoID.MinWidth = 27
        Me.colobjAlumnoID.Name = "colobjAlumnoID"
        Me.colobjAlumnoID.Width = 100
        '
        'colTieneGrupo
        '
        Me.colTieneGrupo.Caption = "TieneGrupo"
        Me.colTieneGrupo.FieldName = "TieneGrupo"
        Me.colTieneGrupo.MinWidth = 27
        Me.colTieneGrupo.Name = "colTieneGrupo"
        Me.colTieneGrupo.Width = 100
        '
        'colGenero
        '
        Me.colGenero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGenero.AppearanceHeader.Options.UseFont = True
        Me.colGenero.AppearanceHeader.Options.UseTextOptions = True
        Me.colGenero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGenero.Caption = "Género"
        Me.colGenero.FieldName = "Genero"
        Me.colGenero.MinWidth = 27
        Me.colGenero.Name = "colGenero"
        Me.colGenero.OptionsColumn.AllowEdit = False
        Me.colGenero.Visible = True
        Me.colGenero.VisibleIndex = 3
        Me.colGenero.Width = 61
        '
        'colSraMatriculaAlumnos
        '
        Me.colSraMatriculaAlumnos.Caption = "SraMatriculaAlumnos"
        Me.colSraMatriculaAlumnos.FieldName = "SraMatriculaAlumnos"
        Me.colSraMatriculaAlumnos.MinWidth = 27
        Me.colSraMatriculaAlumnos.Name = "colSraMatriculaAlumnos"
        Me.colSraMatriculaAlumnos.Width = 100
        '
        'colDireccion
        '
        Me.colDireccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDireccion.AppearanceHeader.Options.UseFont = True
        Me.colDireccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.MinWidth = 27
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.OptionsColumn.AllowEdit = False
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 8
        Me.colDireccion.Width = 224
        '
        'colEscuela
        '
        Me.colEscuela.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEscuela.AppearanceHeader.Options.UseFont = True
        Me.colEscuela.AppearanceHeader.Options.UseTextOptions = True
        Me.colEscuela.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEscuela.Caption = "Escuela de procedencia"
        Me.colEscuela.FieldName = "EscuelaProcedente"
        Me.colEscuela.MinWidth = 27
        Me.colEscuela.Name = "colEscuela"
        Me.colEscuela.OptionsColumn.AllowEdit = False
        Me.colEscuela.Visible = True
        Me.colEscuela.VisibleIndex = 9
        Me.colEscuela.Width = 181
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
        'GridView3
        '
        Me.GridView3.DetailHeight = 431
        Me.GridView3.GridControl = Me.grdMatriculas
        Me.GridView3.Name = "GridView3"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdEliminar)
        Me.PanelControl1.Controls.Add(Me.cmdAgregar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(4, 270)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1307, 36)
        Me.PanelControl1.TabIndex = 144
        '
        'cmdEliminar
        '
        Me.cmdEliminar.BackgroundImage = CType(resources.GetObject("cmdEliminar.BackgroundImage"), System.Drawing.Image)
        Me.cmdEliminar.ImageOptions.Image = CType(resources.GetObject("cmdEliminar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdEliminar.Location = New System.Drawing.Point(51, 0)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(43, 34)
        Me.cmdEliminar.TabIndex = 1
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackgroundImage = CType(resources.GetObject("cmdAgregar.BackgroundImage"), System.Drawing.Image)
        Me.cmdAgregar.ImageOptions.Image = CType(resources.GetObject("cmdAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregar.Location = New System.Drawing.Point(0, 0)
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 0
        '
        'TabControlGrupos
        '
        Me.TabControlGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGrupos.Location = New System.Drawing.Point(0, 39)
        Me.TabControlGrupos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControlGrupos.Name = "TabControlGrupos"
        Me.TabControlGrupos.SelectedTabPage = Me.XtraTabPageMatricula
        Me.TabControlGrupos.Size = New System.Drawing.Size(1317, 519)
        Me.TabControlGrupos.TabIndex = 13
        Me.TabControlGrupos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageMatricula, Me.XtraTabPageGrupos})
        '
        'frmSraAsignarGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 558)
        Me.Controls.Add(Me.TabControlGrupos)
        Me.Controls.Add(Me.tbClientes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSraAsignarGrupos"
        Me.Text = "Asignar grupos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPageGrupos.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.grdGrupoMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupoMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGrupoDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPageMatricula.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grdMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMatriculasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlGrupos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdAsignarGrupo As System.Windows.Forms.ToolStripButton
    Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents barButtonVerGrupos As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControlGrupos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPageMatricula As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grdSeleccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwSeleccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colBecaSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumnoSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGradoSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalidadSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMEDSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdadSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObjAlumnoSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTieneGrupoSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGeneroSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMatriculaIDSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccionSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColEscuelaSelect As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdMatriculas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdMatriculasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colestado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModadlidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoMED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjAlumnoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTieneGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSraMatriculaAlumnos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEscuela As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabPageGrupos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Contenedor As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdGrupoMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGrupoMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents grdGrupoDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdGrupoDetalleTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSraAlumno_GrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGeneros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEscuelaProcedencia As DevExpress.XtraGrid.Columns.GridColumn
End Class
