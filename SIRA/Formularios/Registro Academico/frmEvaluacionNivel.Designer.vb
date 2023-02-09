<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEvaluacionNivel
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvaluacionNivel))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.grdNotas = New DevExpress.XtraGrid.GridControl()
        Me.grdNotasTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEvidencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColIndicadorC5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeloMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbProductos = New System.Windows.Forms.ToolStrip()
        Me.cmdVerDetalle = New System.Windows.Forms.ToolStripButton()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmbExportar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCerrar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEvaluacion = New System.Windows.Forms.ToolStripLabel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmbCategoriaEvidencia = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbParcial = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblModeloCompatible = New System.Windows.Forms.Label()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNotasTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbProductos.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.cmbCategoriaEvidencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbParcial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ReadOnly = True
        '
        'grdNotas
        '
        Me.grdNotas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdNotas.Location = New System.Drawing.Point(2, 190)
        Me.grdNotas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdNotas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdNotas.MainView = Me.grdNotasTable
        Me.grdNotas.Name = "grdNotas"
        Me.grdNotas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.RepositoryItemSpinEdit1})
        Me.grdNotas.Size = New System.Drawing.Size(932, 247)
        Me.grdNotas.TabIndex = 0
        Me.grdNotas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNotasTable, Me.GridView1})
        '
        'grdNotasTable
        '
        Me.grdNotasTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEvidencia, Me.ColIndicadorC5})
        Me.grdNotasTable.GridControl = Me.grdNotas
        Me.grdNotasTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdNotasTable.Name = "grdNotasTable"
        Me.grdNotasTable.OptionsCustomization.AllowFilter = False
        Me.grdNotasTable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdNotasTable.OptionsView.ShowAutoFilterRow = True
        Me.grdNotasTable.OptionsView.ShowFooter = True
        '
        'colEvidencia
        '
        Me.colEvidencia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEvidencia.AppearanceHeader.Options.UseFont = True
        Me.colEvidencia.AppearanceHeader.Options.UseTextOptions = True
        Me.colEvidencia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEvidencia.Caption = "Evidencia de aprendizaje"
        Me.colEvidencia.FieldName = "Evidencia"
        Me.colEvidencia.Name = "colEvidencia"
        Me.colEvidencia.OptionsColumn.AllowEdit = False
        Me.colEvidencia.OptionsColumn.AllowFocus = False
        Me.colEvidencia.OptionsColumn.ReadOnly = True
        Me.colEvidencia.Visible = True
        Me.colEvidencia.VisibleIndex = 0
        Me.colEvidencia.Width = 426
        '
        'ColIndicadorC5
        '
        Me.ColIndicadorC5.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColIndicadorC5.AppearanceHeader.Options.UseFont = True
        Me.ColIndicadorC5.AppearanceHeader.Options.UseTextOptions = True
        Me.ColIndicadorC5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColIndicadorC5.Caption = "Clave"
        Me.ColIndicadorC5.FieldName = "Nota"
        Me.ColIndicadorC5.Name = "ColIndicadorC5"
        Me.ColIndicadorC5.Visible = True
        Me.ColIndicadorC5.VisibleIndex = 1
        Me.ColIndicadorC5.Width = 59
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatString = "0.00"
        Me.RepositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSccCuentaID, Me.colProducto, Me.colModeloMarca, Me.colSaldo})
        Me.GridView1.GridControl = Me.grdNotas
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'ColSccCuentaID
        '
        Me.ColSccCuentaID.Caption = "SccCuentaID"
        Me.ColSccCuentaID.FieldName = "SccCuentaID"
        Me.ColSccCuentaID.Name = "ColSccCuentaID"
        Me.ColSccCuentaID.Visible = True
        Me.ColSccCuentaID.VisibleIndex = 0
        '
        'colProducto
        '
        Me.colProducto.Caption = "Producto"
        Me.colProducto.FieldName = "Producto"
        Me.colProducto.Name = "colProducto"
        Me.colProducto.OptionsColumn.AllowEdit = False
        Me.colProducto.OptionsFilter.AllowAutoFilter = False
        Me.colProducto.Visible = True
        Me.colProducto.VisibleIndex = 1
        '
        'colModeloMarca
        '
        Me.colModeloMarca.Caption = "Modelo/Marca"
        Me.colModeloMarca.FieldName = "ModeloMarca"
        Me.colModeloMarca.Name = "colModeloMarca"
        Me.colModeloMarca.OptionsColumn.AllowEdit = False
        Me.colModeloMarca.OptionsFilter.AllowAutoFilter = False
        Me.colModeloMarca.Visible = True
        Me.colModeloMarca.VisibleIndex = 2
        '
        'colSaldo
        '
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowEdit = False
        Me.colSaldo.OptionsFilter.AllowAutoFilter = False
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 3
        '
        'tbProductos
        '
        Me.tbProductos.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdVerDetalle, Me.cmdAprobar, Me.cmdConsultar, Me.cmdEditar, Me.cmdInactivar, Me.ToolStripSeparator1, Me.cmbExportar, Me.ToolStripSeparator3, Me.cmdCerrar, Me.cmdEvaluacion})
        Me.tbProductos.Location = New System.Drawing.Point(0, 0)
        Me.tbProductos.Name = "tbProductos"
        Me.tbProductos.Size = New System.Drawing.Size(936, 39)
        Me.tbProductos.TabIndex = 0
        '
        'cmdVerDetalle
        '
        Me.cmdVerDetalle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdVerDetalle.Image = CType(resources.GetObject("cmdVerDetalle.Image"), System.Drawing.Image)
        Me.cmdVerDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVerDetalle.Name = "cmdVerDetalle"
        Me.cmdVerDetalle.Size = New System.Drawing.Size(36, 36)
        Me.cmdVerDetalle.Tag = "Ver Detalle venta"
        Me.cmdVerDetalle.ToolTipText = "Ver Detalle venta"
        Me.cmdVerDetalle.Visible = False
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Aprobar"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar Producto"
        Me.cmdConsultar.Visible = False
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Visible = False
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar Grado"
        Me.cmdInactivar.ToolTipText = "Inactivar grado"
        Me.cmdInactivar.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmbExportar
        '
        Me.cmbExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbExportar.Image = CType(resources.GetObject("cmbExportar.Image"), System.Drawing.Image)
        Me.cmbExportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbExportar.Name = "cmbExportar"
        Me.cmbExportar.Size = New System.Drawing.Size(36, 36)
        Me.cmbExportar.Text = "Exportar"
        Me.cmbExportar.ToolTipText = "Exportar a excel"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCerrar
        '
        Me.cmdCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCerrar.Image = CType(resources.GetObject("cmdCerrar.Image"), System.Drawing.Image)
        Me.cmdCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(36, 36)
        Me.cmdCerrar.ToolTipText = "Salir"
        '
        'cmdEvaluacion
        '
        Me.cmdEvaluacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEvaluacion.ForeColor = System.Drawing.Color.Navy
        Me.cmdEvaluacion.Name = "cmdEvaluacion"
        Me.cmdEvaluacion.Size = New System.Drawing.Size(94, 36)
        Me.cmdEvaluacion.Text = "Evaluación"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdNotas)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Caramel"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(936, 439)
        Me.PanelControl1.TabIndex = 11
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Button1)
        Me.PanelControl2.Controls.Add(Me.txtAlumno)
        Me.PanelControl2.Controls.Add(Me.Label4)
        Me.PanelControl2.Controls.Add(Me.Label2)
        Me.PanelControl2.Controls.Add(Me.txtGuia)
        Me.PanelControl2.Controls.Add(Me.txtGrado)
        Me.PanelControl2.Controls.Add(Me.cmdBuscar)
        Me.PanelControl2.Controls.Add(Me.cmbCategoriaEvidencia)
        Me.PanelControl2.Controls.Add(Me.cmbParcial)
        Me.PanelControl2.Controls.Add(Me.Label3)
        Me.PanelControl2.Controls.Add(Me.cmdActualizar)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.lblModeloCompatible)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(932, 188)
        Me.PanelControl2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Tag = "Buscar Existente"
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAlumno
        '
        Me.txtAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlumno.Location = New System.Drawing.Point(168, 128)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.ReadOnly = True
        Me.txtAlumno.Size = New System.Drawing.Size(204, 20)
        Me.txtAlumno.TabIndex = 4
        Me.txtAlumno.Tag = "OBLIGATORIO"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 152
        Me.Label4.Tag = ""
        Me.Label4.Text = "Alumno:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.TabIndex = 151
        Me.Label2.Tag = ""
        Me.Label2.Text = "Guía:"
        '
        'txtGuia
        '
        Me.txtGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuia.Location = New System.Drawing.Point(168, 99)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.ReadOnly = True
        Me.txtGuia.Size = New System.Drawing.Size(204, 20)
        Me.txtGuia.TabIndex = 3
        Me.txtGuia.Tag = "OBLIGATORIO"
        '
        'txtGrado
        '
        Me.txtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrado.Location = New System.Drawing.Point(168, 73)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(204, 20)
        Me.txtGrado.TabIndex = 1
        Me.txtGrado.Tag = "OBLIGATORIO"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(378, 71)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(24, 23)
        Me.cmdBuscar.TabIndex = 2
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmbCategoriaEvidencia
        '
        Me.cmbCategoriaEvidencia.Location = New System.Drawing.Point(168, 153)
        Me.cmbCategoriaEvidencia.Name = "cmbCategoriaEvidencia"
        Me.cmbCategoriaEvidencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCategoriaEvidencia.Properties.NullText = ""
        Me.cmbCategoriaEvidencia.Size = New System.Drawing.Size(265, 20)
        Me.cmbCategoriaEvidencia.TabIndex = 6
        '
        'cmbParcial
        '
        Me.cmbParcial.Location = New System.Drawing.Point(168, 48)
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbParcial.Properties.NullText = ""
        Me.cmbParcial.Size = New System.Drawing.Size(166, 20)
        Me.cmbParcial.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Tag = ""
        Me.Label3.Text = "Grupo:"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Image = CType(resources.GetObject("cmdActualizar.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdActualizar.Location = New System.Drawing.Point(439, 148)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(32, 30)
        Me.cmdActualizar.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.TabIndex = 128
        Me.Label1.Tag = ""
        Me.Label1.Text = "Parcial:"
        '
        'lblModeloCompatible
        '
        Me.lblModeloCompatible.BackColor = System.Drawing.Color.Transparent
        Me.lblModeloCompatible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloCompatible.Location = New System.Drawing.Point(5, 156)
        Me.lblModeloCompatible.Name = "lblModeloCompatible"
        Me.lblModeloCompatible.Size = New System.Drawing.Size(163, 17)
        Me.lblModeloCompatible.TabIndex = 125
        Me.lblModeloCompatible.Tag = ""
        Me.lblModeloCompatible.Text = "Categoría de la evidencia:"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'frmEvaluacionNivel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 439)
        Me.Controls.Add(Me.tbProductos)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvaluacionNivel"
        Me.Text = "Evaluación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNotasTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbProductos.ResumeLayout(False)
        Me.tbProductos.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.cmbCategoriaEvidencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbParcial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbProductos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmbExportar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdNotas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNotasTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEvidencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeloMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdVerDetalle As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbParcial As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtGrado As System.Windows.Forms.TextBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents ColIndicadorC5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbCategoriaEvidencia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblModeloCompatible As System.Windows.Forms.Label
    Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdEvaluacion As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdInactivar As ToolStripButton
End Class
