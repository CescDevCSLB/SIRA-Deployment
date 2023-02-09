<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbImportarTasaCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbImportarTasaCambio))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.grdImportar = New DevExpress.XtraGrid.GridControl()
        Me.grdAsignacionTable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.coltasa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeloMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.sfdRuta = New System.Windows.Forms.SaveFileDialog()
        Me.grpDatos.SuspendLayout()
        CType(Me.grdImportar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAsignacionTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.grdImportar)
        Me.grpDatos.Controls.Add(Me.cmdAgregar)
        Me.grpDatos.Controls.Add(Me.cmdCancelar)
        Me.grpDatos.Controls.Add(Me.cmdGuardar)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(6, 8)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(346, 368)
        Me.grpDatos.TabIndex = 1
        Me.grpDatos.TabStop = False
        '
        'grdImportar
        '
        Me.grdImportar.Location = New System.Drawing.Point(10, 53)
        Me.grdImportar.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdImportar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdImportar.MainView = Me.grdAsignacionTable
        Me.grdImportar.Name = "grdImportar"
        Me.grdImportar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemMemoEdit1})
        Me.grdImportar.Size = New System.Drawing.Size(332, 279)
        Me.grdImportar.TabIndex = 1
        Me.grdImportar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdAsignacionTable, Me.GridView2})
        '
        'grdAsignacionTable
        '
        Me.grdAsignacionTable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coltasa, Me.colFecha})
        Me.grdAsignacionTable.GridControl = Me.grdImportar
        Me.grdAsignacionTable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdAsignacionTable.Name = "grdAsignacionTable"
        Me.grdAsignacionTable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdAsignacionTable.OptionsView.ShowAutoFilterRow = True
        Me.grdAsignacionTable.OptionsView.ShowGroupPanel = False
        '
        'coltasa
        '
        Me.coltasa.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.coltasa.AppearanceCell.Options.UseBackColor = True
        Me.coltasa.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coltasa.AppearanceHeader.Options.UseFont = True
        Me.coltasa.AppearanceHeader.Options.UseTextOptions = True
        Me.coltasa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coltasa.Caption = "Tasa"
        Me.coltasa.FieldName = "Tasa"
        Me.coltasa.Name = "coltasa"
        Me.coltasa.OptionsColumn.AllowEdit = False
        Me.coltasa.OptionsColumn.AllowFocus = False
        Me.coltasa.OptionsColumn.ReadOnly = True
        Me.coltasa.Visible = True
        Me.coltasa.VisibleIndex = 1
        Me.coltasa.Width = 188
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
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 126
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
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ReadOnly = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSccCuentaID, Me.colProducto, Me.colModeloMarca, Me.colSaldo})
        Me.GridView2.GridControl = Me.grdImportar
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AutoPopulateColumns = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
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
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAgregar.Location = New System.Drawing.Point(151, 12)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(189, 28)
        Me.cmdAgregar.TabIndex = 0
        Me.cmdAgregar.Tag = ""
        Me.cmdAgregar.Text = "Importar desde archivo"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(266, 338)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(180, 338)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'sfdRuta
        '
        Me.sfdRuta.Filter = "Archivos Excel | *.xls"
        '
        'frmStbImportarTasaCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 383)
        Me.Controls.Add(Me.grpDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbImportarTasaCambio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importar desde archivo"
        Me.grpDatos.ResumeLayout(False)
        CType(Me.grdImportar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAsignacionTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grdImportar As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdAsignacionTable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents coltasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeloMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sfdRuta As System.Windows.Forms.SaveFileDialog
End Class
