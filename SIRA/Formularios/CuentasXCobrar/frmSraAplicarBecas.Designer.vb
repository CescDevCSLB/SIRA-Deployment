<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraAplicarBecas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraAplicarBecas))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAsignarBeca = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditarBeca = New System.Windows.Forms.ToolStripButton()
        Me.cmdGenerar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
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
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XtraTabPageMatricula = New DevExpress.XtraTab.XtraTabPage()
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
        Me.colTieneBeca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGenero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSraMatriculaAlumnos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControlGrupos = New DevExpress.XtraTab.XtraTabControl()
        Me.tbClientes.SuspendLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPageMatricula.SuspendLayout()
        CType(Me.grdMatriculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMatriculasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlGrupos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbClientes
        '
        Me.tbClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.cmdAsignarBeca, Me.cmdEditarBeca, Me.cmdGenerar, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbClientes.Location = New System.Drawing.Point(0, 0)
        Me.tbClientes.Name = "tbClientes"
        Me.tbClientes.Size = New System.Drawing.Size(988, 39)
        Me.tbClientes.TabIndex = 1
        Me.tbClientes.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAsignarBeca
        '
        Me.cmdAsignarBeca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAsignarBeca.Image = CType(resources.GetObject("cmdAsignarBeca.Image"), System.Drawing.Image)
        Me.cmdAsignarBeca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAsignarBeca.Name = "cmdAsignarBeca"
        Me.cmdAsignarBeca.Size = New System.Drawing.Size(36, 36)
        Me.cmdAsignarBeca.Text = "Aisgnar beca"
        Me.cmdAsignarBeca.ToolTipText = "Aisgnar beca"
        '
        'cmdEditarBeca
        '
        Me.cmdEditarBeca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditarBeca.Image = CType(resources.GetObject("cmdEditarBeca.Image"), System.Drawing.Image)
        Me.cmdEditarBeca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditarBeca.Name = "cmdEditarBeca"
        Me.cmdEditarBeca.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditarBeca.ToolTipText = "Cambiar beca"
        '
        'cmdGenerar
        '
        Me.cmdGenerar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdGenerar.Image = CType(resources.GetObject("cmdGenerar.Image"), System.Drawing.Image)
        Me.cmdGenerar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenerar.Name = "cmdGenerar"
        Me.cmdGenerar.Size = New System.Drawing.Size(36, 36)
        Me.cmdGenerar.Text = "Generar expediente"
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
        Me.cmdSalir.ToolTipText = "Salir de Mantenimiento de Matriculas"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(265, 36)
        Me.ToolStripLabel1.Text = "Generar expediente/ Aplicar beca"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 453)
        Me.barDockControlBottom.Manager = Me.barManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(988, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 453)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(988, 0)
        Me.barDockControlRight.Manager = Me.barManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 453)
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
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'XtraTabPageMatricula
        '
        Me.XtraTabPageMatricula.Controls.Add(Me.grdMatriculas)
        Me.XtraTabPageMatricula.Name = "XtraTabPageMatricula"
        Me.XtraTabPageMatricula.Size = New System.Drawing.Size(982, 386)
        Me.XtraTabPageMatricula.Text = "Alumnos matriculados"
        '
        'grdMatriculas
        '
        Me.grdMatriculas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMatriculas.Location = New System.Drawing.Point(0, 0)
        Me.grdMatriculas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdMatriculas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdMatriculas.MainView = Me.grdMatriculasTabla
        Me.grdMatriculas.Name = "grdMatriculas"
        Me.grdMatriculas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdMatriculas.Size = New System.Drawing.Size(982, 386)
        Me.grdMatriculas.TabIndex = 9
        Me.grdMatriculas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdMatriculasTabla, Me.GridView3})
        '
        'grdMatriculasTabla
        '
        Me.grdMatriculasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colestado, Me.colBeca, Me.colNumero, Me.colAlumno, Me.colGrado, Me.colModadlidad, Me.colCodigoMED, Me.colEdad, Me.colobjAlumnoID, Me.colTieneBeca, Me.colGenero, Me.colSraMatriculaAlumnos, Me.colDireccion})
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
        Me.colestado.Name = "colestado"
        '
        'colBeca
        '
        Me.colBeca.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colBeca.AppearanceHeader.Options.UseFont = True
        Me.colBeca.AppearanceHeader.Options.UseTextOptions = True
        Me.colBeca.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colBeca.Caption = "Beca"
        Me.colBeca.FieldName = "Beca"
        Me.colBeca.Name = "colBeca"
        Me.colBeca.OptionsColumn.AllowEdit = False
        Me.colBeca.OptionsColumn.ReadOnly = True
        Me.colBeca.Visible = True
        Me.colBeca.VisibleIndex = 7
        Me.colBeca.Width = 145
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SraMatriculaAlumnos"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 76
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Nombre Alumno"
        Me.colAlumno.FieldName = "Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.OptionsColumn.AllowEdit = False
        Me.colAlumno.OptionsColumn.ReadOnly = True
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 2
        Me.colAlumno.Width = 138
        '
        'colGrado
        '
        Me.colGrado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrado.AppearanceHeader.Options.UseFont = True
        Me.colGrado.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrado.Caption = "Grado"
        Me.colGrado.FieldName = "Grado"
        Me.colGrado.Name = "colGrado"
        Me.colGrado.OptionsColumn.AllowEdit = False
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 5
        Me.colGrado.Width = 113
        '
        'colModadlidad
        '
        Me.colModadlidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModadlidad.AppearanceHeader.Options.UseFont = True
        Me.colModadlidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModadlidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModadlidad.Caption = "Modadlidad"
        Me.colModadlidad.FieldName = "Modadlidad"
        Me.colModadlidad.Name = "colModadlidad"
        Me.colModadlidad.OptionsColumn.AllowEdit = False
        Me.colModadlidad.Visible = True
        Me.colModadlidad.VisibleIndex = 6
        Me.colModadlidad.Width = 120
        '
        'colCodigoMED
        '
        Me.colCodigoMED.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoMED.AppearanceHeader.Options.UseFont = True
        Me.colCodigoMED.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoMED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoMED.Caption = "Codigo MINED"
        Me.colCodigoMED.FieldName = "CodigoMED"
        Me.colCodigoMED.Name = "colCodigoMED"
        Me.colCodigoMED.OptionsColumn.AllowEdit = False
        Me.colCodigoMED.Visible = True
        Me.colCodigoMED.VisibleIndex = 1
        Me.colCodigoMED.Width = 87
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
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 4
        Me.colEdad.Width = 72
        '
        'colobjAlumnoID
        '
        Me.colobjAlumnoID.Caption = "objAlumnoID"
        Me.colobjAlumnoID.FieldName = "objAlumnoID"
        Me.colobjAlumnoID.Name = "colobjAlumnoID"
        '
        'colTieneBeca
        '
        Me.colTieneBeca.Caption = "TieneGrupo"
        Me.colTieneBeca.FieldName = "TieneBeca"
        Me.colTieneBeca.Name = "colTieneBeca"
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
        Me.colGenero.Width = 58
        '
        'colSraMatriculaAlumnos
        '
        Me.colSraMatriculaAlumnos.Caption = "SraMatriculaAlumnos"
        Me.colSraMatriculaAlumnos.FieldName = "SraMatriculaAlumnos"
        Me.colSraMatriculaAlumnos.Name = "colSraMatriculaAlumnos"
        '
        'colDireccion
        '
        Me.colDireccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDireccion.AppearanceHeader.Options.UseFont = True
        Me.colDireccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDireccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDireccion.Caption = "Dirección"
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.OptionsColumn.AllowEdit = False
        Me.colDireccion.Visible = True
        Me.colDireccion.VisibleIndex = 8
        Me.colDireccion.Width = 169
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
        Me.GridView3.GridControl = Me.grdMatriculas
        Me.GridView3.Name = "GridView3"
        '
        'TabControlGrupos
        '
        Me.TabControlGrupos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGrupos.Location = New System.Drawing.Point(0, 39)
        Me.TabControlGrupos.Name = "TabControlGrupos"
        Me.TabControlGrupos.SelectedTabPage = Me.XtraTabPageMatricula
        Me.TabControlGrupos.Size = New System.Drawing.Size(988, 414)
        Me.TabControlGrupos.TabIndex = 13
        Me.TabControlGrupos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPageMatricula})
        '
        'frmSraAplicarBecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 453)
        Me.Controls.Add(Me.TabControlGrupos)
        Me.Controls.Add(Me.tbClientes)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSraAplicarBecas"
        Me.Text = "Aplicar beca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbClientes.ResumeLayout(False)
        Me.tbClientes.PerformLayout()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPageMatricula.ResumeLayout(False)
        CType(Me.grdMatriculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMatriculasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControlGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlGrupos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdEditarBeca As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cmdAsignarBeca As System.Windows.Forms.ToolStripButton
    Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents barButtonVerGrupos As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents popupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents TabControlGrupos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPageMatricula As DevExpress.XtraTab.XtraTabPage
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
    Friend WithEvents colTieneBeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGenero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSraMatriculaAlumnos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdGenerar As ToolStripButton
End Class
