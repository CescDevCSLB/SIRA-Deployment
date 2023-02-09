<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSraGradoEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraGradoEditar))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdAsignaturaA = New DevExpress.XtraGrid.GridControl()
        Me.grdAsignaturaATable = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colAsignaturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoAsignarura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSccCuentaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModeloMarca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdAsignaturaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdAsignaturaATable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdAsignaturaA)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.cmdEliminar)
        Me.PanelControl1.Controls.Add(Me.cmdAgregar)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(542, 398)
        Me.PanelControl1.TabIndex = 98
        '
        'grdAsignaturaA
        '
        Me.grdAsignaturaA.Location = New System.Drawing.Point(26, 141)
        Me.grdAsignaturaA.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAsignaturaA.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAsignaturaA.MainView = Me.grdAsignaturaATable
        Me.grdAsignaturaA.Name = "grdAsignaturaA"
        Me.grdAsignaturaA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit1})
        Me.grdAsignaturaA.Size = New System.Drawing.Size(475, 192)
        Me.grdAsignaturaA.TabIndex = 3
        Me.grdAsignaturaA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdAsignaturaATable, Me.GridView2})
        '
        'grdAsignaturaATable
        '
        Me.grdAsignaturaATable.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccionar, Me.colAsignaturaID, Me.colCodigoAsignarura, Me.ColNombre})
        Me.grdAsignaturaATable.GridControl = Me.grdAsignaturaA
        Me.grdAsignaturaATable.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdAsignaturaATable.Name = "grdAsignaturaATable"
        Me.grdAsignaturaATable.OptionsSelection.MultiSelect = True
        Me.grdAsignaturaATable.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdAsignaturaATable.OptionsView.ShowAutoFilterRow = True
        Me.grdAsignaturaATable.OptionsView.ShowGroupPanel = False
        '
        'colSeleccionar
        '
        Me.colSeleccionar.Caption = "Seleccionar"
        Me.colSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSeleccionar.FieldName = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'colAsignaturaID
        '
        Me.colAsignaturaID.Caption = "AsignaturaID"
        Me.colAsignaturaID.FieldName = "AsignaturaID"
        Me.colAsignaturaID.Name = "colAsignaturaID"
        Me.colAsignaturaID.OptionsColumn.AllowEdit = False
        Me.colAsignaturaID.OptionsColumn.AllowFocus = False
        Me.colAsignaturaID.OptionsColumn.ReadOnly = True
        Me.colAsignaturaID.Width = 109
        '
        'colCodigoAsignarura
        '
        Me.colCodigoAsignarura.AppearanceCell.BackColor = System.Drawing.Color.Transparent
        Me.colCodigoAsignarura.AppearanceCell.Options.UseBackColor = True
        Me.colCodigoAsignarura.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigoAsignarura.AppearanceHeader.Options.UseFont = True
        Me.colCodigoAsignarura.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoAsignarura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoAsignarura.Caption = "Código"
        Me.colCodigoAsignarura.FieldName = "CodigoAsignarura"
        Me.colCodigoAsignarura.Name = "colCodigoAsignarura"
        Me.colCodigoAsignarura.OptionsColumn.AllowEdit = False
        Me.colCodigoAsignarura.OptionsColumn.AllowFocus = False
        Me.colCodigoAsignarura.OptionsColumn.ReadOnly = True
        Me.colCodigoAsignarura.Visible = True
        Me.colCodigoAsignarura.VisibleIndex = 1
        Me.colCodigoAsignarura.Width = 86
        '
        'ColNombre
        '
        Me.ColNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColNombre.AppearanceHeader.Options.UseFont = True
        Me.ColNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNombre.Caption = "Nombre"
        Me.ColNombre.FieldName = "Nombre"
        Me.ColNombre.Name = "ColNombre"
        Me.ColNombre.OptionsColumn.AllowEdit = False
        Me.ColNombre.OptionsColumn.AllowFocus = False
        Me.ColNombre.OptionsColumn.ReadOnly = True
        Me.ColNombre.Visible = True
        Me.ColNombre.VisibleIndex = 2
        Me.ColNombre.Width = 245
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
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSccCuentaID, Me.colProducto, Me.colModeloMarca, Me.colSaldo})
        Me.GridView2.GridControl = Me.grdAsignaturaA
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Asignaturas"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEliminar.Appearance.Options.UseFont = True
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdEliminar.Location = New System.Drawing.Point(463, 109)
        Me.cmdEliminar.LookAndFeel.SkinName = "Caramel"
        Me.cmdEliminar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(32, 28)
        Me.cmdEliminar.TabIndex = 1
        Me.cmdEliminar.Tag = "AGREGAR"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdAgregar.Location = New System.Drawing.Point(425, 109)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(32, 28)
        Me.cmdAgregar.TabIndex = 0
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(452, 340)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(364, 340)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.txtGrado)
        Me.gbxDatosGenerales.Controls.Add(Me.txtCodigo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(23, 8)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(500, 83)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'txtGrado
        '
        Me.txtGrado.Location = New System.Drawing.Point(121, 42)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.Size = New System.Drawing.Size(279, 21)
        Me.txtGrado.TabIndex = 1
        Me.txtGrado.TabStop = False
        Me.txtGrado.Tag = "BLOQUEADO"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(121, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(279, 21)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TabStop = False
        Me.txtCodigo.Tag = "BLOQUEADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Código:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(416, 27)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(62, 17)
        Me.chkActivo.TabIndex = 2
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.ForeColor = System.Drawing.Color.Black
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(5, 44)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(45, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Grado:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 377)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 21)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraGradoEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 398)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraGradoEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar grado"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.grdAsignaturaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdAsignaturaATable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGrado As System.Windows.Forms.TextBox
    Friend WithEvents grdAsignaturaA As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdAsignaturaATable As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colAsignaturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoAsignarura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSccCuentaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModeloMarca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
End Class
