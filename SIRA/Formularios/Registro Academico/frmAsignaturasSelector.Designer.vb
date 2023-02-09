<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignaturasSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsignaturasSelector))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdAsignaturas = New DevExpress.XtraGrid.GridControl()
        Me.grdvwAsignaturas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAsignaturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCodigoAsignarura = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdAsignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwAsignaturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'pnlBotones
        '
        Me.pnlBotones.Controls.Add(Me.SimpleButton1)
        Me.pnlBotones.Controls.Add(Me.cmdGuardar)
        Me.pnlBotones.Location = New System.Drawing.Point(0, 356)
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(669, 60)
        Me.pnlBotones.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(557, 16)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(443, 16)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 20)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdAsignaturas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(669, 447)
        Me.PanelControl1.TabIndex = 8
        '
        'grdAsignaturas
        '
        Me.grdAsignaturas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdAsignaturas.Location = New System.Drawing.Point(0, 0)
        Me.grdAsignaturas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdAsignaturas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdAsignaturas.MainView = Me.grdvwAsignaturas
        Me.grdAsignaturas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdAsignaturas.Name = "grdAsignaturas"
        Me.grdAsignaturas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado})
        Me.grdAsignaturas.Size = New System.Drawing.Size(669, 359)
        Me.grdAsignaturas.TabIndex = 0
        Me.grdAsignaturas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwAsignaturas})
        '
        'grdvwAsignaturas
        '
        Me.grdvwAsignaturas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAsignaturaID, Me.ColSeleccionar, Me.colCodigoAsignarura, Me.colNombre})
        Me.grdvwAsignaturas.DetailHeight = 431
        Me.grdvwAsignaturas.GridControl = Me.grdAsignaturas
        Me.grdvwAsignaturas.Name = "grdvwAsignaturas"
        Me.grdvwAsignaturas.OptionsSelection.MultiSelect = True
        Me.grdvwAsignaturas.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdvwAsignaturas.OptionsView.ColumnAutoWidth = False
        Me.grdvwAsignaturas.OptionsView.ShowAutoFilterRow = True
        Me.grdvwAsignaturas.OptionsView.ShowDetailButtons = False
        Me.grdvwAsignaturas.OptionsView.ShowGroupPanel = False
        '
        'colAsignaturaID
        '
        Me.colAsignaturaID.Caption = "AsignaturaID"
        Me.colAsignaturaID.FieldName = "AsignaturaID"
        Me.colAsignaturaID.MinWidth = 27
        Me.colAsignaturaID.Name = "colAsignaturaID"
        Me.colAsignaturaID.Width = 100
        '
        'ColSeleccionar
        '
        Me.ColSeleccionar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSeleccionar.AppearanceHeader.Options.UseFont = True
        Me.ColSeleccionar.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSeleccionar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSeleccionar.Caption = "Seleccionar"
        Me.ColSeleccionar.ColumnEdit = Me.chkSeleccionado
        Me.ColSeleccionar.FieldName = "Seleccionar"
        Me.ColSeleccionar.MinWidth = 27
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.OptionsColumn.AllowMove = False
        Me.ColSeleccionar.Width = 100
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'colCodigoAsignarura
        '
        Me.colCodigoAsignarura.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigoAsignarura.AppearanceHeader.Options.UseFont = True
        Me.colCodigoAsignarura.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigoAsignarura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoAsignarura.Caption = "Código"
        Me.colCodigoAsignarura.FieldName = "CodigoAsignarura"
        Me.colCodigoAsignarura.MinWidth = 27
        Me.colCodigoAsignarura.Name = "colCodigoAsignarura"
        Me.colCodigoAsignarura.OptionsColumn.AllowEdit = False
        Me.colCodigoAsignarura.OptionsColumn.AllowMove = False
        Me.colCodigoAsignarura.Visible = True
        Me.colCodigoAsignarura.VisibleIndex = 1
        Me.colCodigoAsignarura.Width = 144
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.MinWidth = 27
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowMove = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 400
        '
        'frmAsignaturasSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAsignaturasSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de asignaturas"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdAsignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwAsignaturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdAsignaturas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwAsignaturas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoAsignarura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colAsignaturaID As DevExpress.XtraGrid.Columns.GridColumn
End Class
