<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccMantMora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccMantMora))
        Me.tstND = New System.Windows.Forms.ToolStrip()
        Me.tsbModificarND = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDeshacerNota = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbImprimirND = New System.Windows.Forms.ToolStripButton()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdMoraPagada = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdND = New DevExpress.XtraGrid.GridControl()
        Me.grdNDTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjConceptoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tstND.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdNDTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstND
        '
        Me.tstND.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstND.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbModificarND, Me.ToolStripSeparator1, Me.cmdDeshacerNota, Me.ToolStripSeparator3, Me.tsbImprimirND, Me.tsbRefrescar, Me.cmdMoraPagada, Me.ToolStripSeparator4, Me.tsbSalir})
        Me.tstND.Location = New System.Drawing.Point(0, 0)
        Me.tstND.Name = "tstND"
        Me.tstND.Size = New System.Drawing.Size(1133, 39)
        Me.tstND.TabIndex = 2
        Me.tstND.Text = "Nota de Débito"
        '
        'tsbModificarND
        '
        Me.tsbModificarND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbModificarND.Image = CType(resources.GetObject("tsbModificarND.Image"), System.Drawing.Image)
        Me.tsbModificarND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbModificarND.Name = "tsbModificarND"
        Me.tsbModificarND.Size = New System.Drawing.Size(36, 36)
        Me.tsbModificarND.Text = "Consultar mora"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDeshacerNota
        '
        Me.cmdDeshacerNota.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDeshacerNota.Image = CType(resources.GetObject("cmdDeshacerNota.Image"), System.Drawing.Image)
        Me.cmdDeshacerNota.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDeshacerNota.Name = "cmdDeshacerNota"
        Me.cmdDeshacerNota.Size = New System.Drawing.Size(36, 36)
        Me.cmdDeshacerNota.Text = "Exonerar mora"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbImprimirND
        '
        Me.tsbImprimirND.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbImprimirND.Enabled = False
        Me.tsbImprimirND.Image = CType(resources.GetObject("tsbImprimirND.Image"), System.Drawing.Image)
        Me.tsbImprimirND.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbImprimirND.Name = "tsbImprimirND"
        Me.tsbImprimirND.Size = New System.Drawing.Size(36, 36)
        Me.tsbImprimirND.Text = "Imprimir"
        Me.tsbImprimirND.Visible = False
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Ver mora pendiente"
        '
        'cmdMoraPagada
        '
        Me.cmdMoraPagada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdMoraPagada.Image = CType(resources.GetObject("cmdMoraPagada.Image"), System.Drawing.Image)
        Me.cmdMoraPagada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMoraPagada.Name = "cmdMoraPagada"
        Me.cmdMoraPagada.Size = New System.Drawing.Size(36, 36)
        Me.cmdMoraPagada.Text = "Ver mora pagada"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1133, 624)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grdND)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1125, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Moras"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grdND
        '
        Me.grdND.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdND.Location = New System.Drawing.Point(3, 3)
        Me.grdND.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdND.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdND.MainView = Me.grdNDTabla
        Me.grdND.Name = "grdND"
        Me.grdND.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdND.Size = New System.Drawing.Size(1119, 592)
        Me.grdND.TabIndex = 9
        Me.grdND.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdNDTabla})
        '
        'grdNDTabla
        '
        Me.grdNDTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colMonto, Me.colobjConceptoID, Me.colNumCuenta, Me.colCliente, Me.colDescripcion, Me.colEstado, Me.colMes})
        Me.grdNDTabla.GridControl = Me.grdND
        Me.grdNDTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdNDTabla.Name = "grdNDTabla"
        Me.grdNDTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdNDTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "SccNotaDebitoID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        '
        'colFecha
        '
        Me.colFecha.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFecha.AppearanceHeader.Options.UseFont = True
        Me.colFecha.AppearanceHeader.Options.UseTextOptions = True
        Me.colFecha.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 130
        '
        'colMonto
        '
        Me.colMonto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMonto.AppearanceHeader.Options.UseFont = True
        Me.colMonto.AppearanceHeader.Options.UseTextOptions = True
        Me.colMonto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMonto.Caption = "Monto"
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.OptionsColumn.AllowEdit = False
        Me.colMonto.OptionsColumn.ReadOnly = True
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 5
        Me.colMonto.Width = 188
        '
        'colobjConceptoID
        '
        Me.colobjConceptoID.Caption = "objConceptoID"
        Me.colobjConceptoID.FieldName = "objConceptoID"
        Me.colobjConceptoID.Name = "colobjConceptoID"
        Me.colobjConceptoID.OptionsColumn.AllowEdit = False
        Me.colobjConceptoID.OptionsColumn.ReadOnly = True
        Me.colobjConceptoID.Width = 158
        '
        'colNumCuenta
        '
        Me.colNumCuenta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumCuenta.AppearanceHeader.Options.UseFont = True
        Me.colNumCuenta.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumCuenta.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumCuenta.Caption = "Expediente"
        Me.colNumCuenta.FieldName = "NumCuenta"
        Me.colNumCuenta.Name = "colNumCuenta"
        Me.colNumCuenta.OptionsColumn.AllowEdit = False
        Me.colNumCuenta.Visible = True
        Me.colNumCuenta.VisibleIndex = 0
        Me.colNumCuenta.Width = 98
        '
        'colCliente
        '
        Me.colCliente.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCliente.AppearanceHeader.Options.UseFont = True
        Me.colCliente.AppearanceHeader.Options.UseTextOptions = True
        Me.colCliente.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCliente.Caption = "Alumno"
        Me.colCliente.FieldName = "Alumno"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.OptionsColumn.AllowEdit = False
        Me.colCliente.Visible = True
        Me.colCliente.VisibleIndex = 1
        Me.colCliente.Width = 241
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
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 166
        '
        'colEstado
        '
        Me.colEstado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEstado.AppearanceHeader.Options.UseFont = True
        Me.colEstado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEstado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEstado.Caption = "Estado"
        Me.colEstado.FieldName = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.OptionsColumn.AllowEdit = False
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 6
        Me.colEstado.Width = 191
        '
        'colMes
        '
        Me.colMes.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMes.AppearanceHeader.Options.UseFont = True
        Me.colMes.AppearanceHeader.Options.UseTextOptions = True
        Me.colMes.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMes.Caption = "Mes"
        Me.colMes.FieldName = "Mes"
        Me.colMes.Name = "colMes"
        Me.colMes.OptionsColumn.AllowEdit = False
        Me.colMes.Visible = True
        Me.colMes.VisibleIndex = 4
        Me.colMes.Width = 87
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSccMantMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 663)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tstND)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccMantMora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "CATALOGOS"
        Me.Text = "Mora"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tstND.ResumeLayout(False)
        Me.tstND.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdNDTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tstND As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbModificarND As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbImprimirND As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdDeshacerNota As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdND As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdNDTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjConceptoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colNumCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdMoraPagada As ToolStripButton
End Class
