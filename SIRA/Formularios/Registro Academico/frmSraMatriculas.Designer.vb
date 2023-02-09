<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraMatriculas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraMatriculas))
        Me.tbClientes = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbMatricular = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimirSeleccionadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirConFiltroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdClientes = New DevExpress.XtraGrid.GridControl()
        Me.grdClientesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEdad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBeca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModadlidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMatricula = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjAlumnoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColCodigoMINED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.cmdretirar = New System.Windows.Forms.ToolStripButton()
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
        Me.tbClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.ToolStripSeparator3, Me.cmdEditar, Me.ToolStripSeparator4, Me.cmdConsultar, Me.ToolStripSeparator1, Me.cmbMatricular, Me.cmdretirar, Me.cmdInactivar, Me.cmdImprimir, Me.ToolStripSeparator5, Me.ToolStripSeparator6, Me.cmdRefrescar, Me.ToolStripSeparator2, Me.cmdSalir, Me.ToolStripLabel1})
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
        Me.cmdAgregar.ToolTipText = "Agregar matrícula"
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
        Me.cmdEditar.ToolTipText = "Editar matrícula"
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
        Me.cmdConsultar.ToolTipText = "Consultar matrícula"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmbMatricular
        '
        Me.cmbMatricular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbMatricular.Image = CType(resources.GetObject("cmbMatricular.Image"), System.Drawing.Image)
        Me.cmbMatricular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbMatricular.Name = "cmbMatricular"
        Me.cmbMatricular.Size = New System.Drawing.Size(36, 36)
        Me.cmbMatricular.Text = "Maticular"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar matricula"
        Me.cmdInactivar.ToolTipText = "Inactivar matrícula"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirSeleccionadoToolStripMenuItem, Me.ImprimirConFiltroToolStripMenuItem})
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(45, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'ImprimirSeleccionadoToolStripMenuItem
        '
        Me.ImprimirSeleccionadoToolStripMenuItem.Name = "ImprimirSeleccionadoToolStripMenuItem"
        Me.ImprimirSeleccionadoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ImprimirSeleccionadoToolStripMenuItem.Text = "Imprimir Seleccionado"
        '
        'ImprimirConFiltroToolStripMenuItem
        '
        Me.ImprimirConFiltroToolStripMenuItem.Name = "ImprimirConFiltroToolStripMenuItem"
        Me.ImprimirConFiltroToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ImprimirConFiltroToolStripMenuItem.Text = "Imprimir con Filtro"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(173, 36)
        Me.ToolStripLabel1.Text = "Registro de matrícula"
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
        Me.grdClientesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEdad, Me.colBeca, Me.colNumero, Me.colAlumno, Me.colGrado, Me.colModadlidad, Me.colTipoMatricula, Me.colPeriodo, Me.colobjAlumnoID, Me.GridColumn1, Me.ColCodigoMINED})
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
        Me.colEdad.Visible = True
        Me.colEdad.VisibleIndex = 6
        Me.colEdad.Width = 79
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
        Me.colBeca.VisibleIndex = 8
        Me.colBeca.Width = 154
        '
        'colNumero
        '
        Me.colNumero.Caption = "Número"
        Me.colNumero.FieldName = "SraMatriculaAlumnos"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
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
        Me.colAlumno.VisibleIndex = 4
        Me.colAlumno.Width = 174
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
        Me.colGrado.VisibleIndex = 3
        Me.colGrado.Width = 140
        '
        'colModadlidad
        '
        Me.colModadlidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModadlidad.AppearanceHeader.Options.UseFont = True
        Me.colModadlidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModadlidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModadlidad.Caption = "Modalidad"
        Me.colModadlidad.FieldName = "Modadlidad"
        Me.colModadlidad.Name = "colModadlidad"
        Me.colModadlidad.OptionsColumn.AllowEdit = False
        Me.colModadlidad.Visible = True
        Me.colModadlidad.VisibleIndex = 7
        Me.colModadlidad.Width = 298
        '
        'colTipoMatricula
        '
        Me.colTipoMatricula.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipoMatricula.AppearanceHeader.Options.UseFont = True
        Me.colTipoMatricula.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoMatricula.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoMatricula.Caption = "Tipo de matrícula"
        Me.colTipoMatricula.FieldName = "TipoMatricula"
        Me.colTipoMatricula.Name = "colTipoMatricula"
        Me.colTipoMatricula.OptionsColumn.AllowEdit = False
        Me.colTipoMatricula.Visible = True
        Me.colTipoMatricula.VisibleIndex = 1
        Me.colTipoMatricula.Width = 175
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
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 2
        Me.colPeriodo.Width = 88
        '
        'colobjAlumnoID
        '
        Me.colobjAlumnoID.Caption = "objAlumnoID"
        Me.colobjAlumnoID.FieldName = "objAlumnoID"
        Me.colobjAlumnoID.Name = "colobjAlumnoID"
        Me.colobjAlumnoID.OptionsColumn.AllowEdit = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn1.AppearanceHeader.Options.UseFont = True
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Genero"
        Me.GridColumn1.FieldName = "Genero"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 79
        '
        'ColCodigoMINED
        '
        Me.ColCodigoMINED.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColCodigoMINED.AppearanceHeader.Options.UseFont = True
        Me.ColCodigoMINED.AppearanceHeader.Options.UseTextOptions = True
        Me.ColCodigoMINED.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColCodigoMINED.Caption = "Código MINED"
        Me.ColCodigoMINED.FieldName = "CodigoMED"
        Me.ColCodigoMINED.Name = "ColCodigoMINED"
        Me.ColCodigoMINED.OptionsColumn.AllowEdit = False
        Me.ColCodigoMINED.Visible = True
        Me.ColCodigoMINED.VisibleIndex = 0
        Me.ColCodigoMINED.Width = 110
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
        'cmdretirar
        '
        Me.cmdretirar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdretirar.Image = CType(resources.GetObject("cmdretirar.Image"), System.Drawing.Image)
        Me.cmdretirar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdretirar.Name = "cmdretirar"
        Me.cmdretirar.Size = New System.Drawing.Size(36, 36)
        Me.cmdretirar.Text = "retirar matricula"
        Me.cmdretirar.ToolTipText = "retirar matricula"
        '
        'frmSraMatriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 262)
        Me.Controls.Add(Me.grdClientes)
        Me.Controls.Add(Me.tbClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSraMatriculas"
        Me.Text = "Registro de matrícula"
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
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModadlidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colBeca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoMatricula As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjAlumnoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEdad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbMatricular As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimirSeleccionadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimirConFiltroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColCodigoMINED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdretirar As ToolStripButton
End Class
