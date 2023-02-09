<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBuscarEvidencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEvidencias))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbCategoria = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbParcial = New C1.Win.C1List.C1Combo()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grdCuentas = New DevExpress.XtraGrid.GridControl()
        Me.grdvwGrados = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAsignaturaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwGrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlBotones.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(789, 60)
        Me.pnlBotones.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(664, 11)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(550, 11)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 6
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 427)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(789, 20)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdActualizar)
        Me.PanelControl1.Controls.Add(Me.cmbCategoria)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Controls.Add(Me.cmbParcial)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.cmbPeriodo)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.grdCuentas)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(789, 447)
        Me.PanelControl1.TabIndex = 8
        '
        'cmdActualizar
        '
        Me.cmdActualizar.ImageOptions.Image = CType(resources.GetObject("cmdActualizar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdActualizar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdActualizar.Location = New System.Drawing.Point(373, 53)
        Me.cmdActualizar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdActualizar.Name = "cmdActualizar"
        Me.cmdActualizar.Size = New System.Drawing.Size(43, 37)
        Me.cmdActualizar.TabIndex = 117
        '
        'cmbCategoria
        '
        Me.cmbCategoria.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCategoria.AutoCompletion = True
        Me.cmbCategoria.AutoDropDown = True
        Me.cmbCategoria.Caption = ""
        Me.cmbCategoria.CaptionHeight = 17
        Me.cmbCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCategoria.ColumnCaptionHeight = 17
        Me.cmbCategoria.ColumnFooterHeight = 17
        Me.cmbCategoria.ContentHeight = 18
        Me.cmbCategoria.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCategoria.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCategoria.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCategoria.EditorHeight = 18
        Me.cmbCategoria.Images.Add(CType(resources.GetObject("cmbCategoria.Images"), System.Drawing.Image))
        Me.cmbCategoria.ItemHeight = 15
        Me.cmbCategoria.Location = New System.Drawing.Point(473, 21)
        Me.cmbCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategoria.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCategoria.MaxDropDownItems = CType(5, Short)
        Me.cmbCategoria.MaxLength = 32767
        Me.cmbCategoria.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCategoria.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCategoria.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCategoria.Size = New System.Drawing.Size(286, 24)
        Me.cmbCategoria.TabIndex = 115
        Me.cmbCategoria.Tag = "OBLIGATORIO"
        Me.cmbCategoria.PropBag = resources.GetString("cmbCategoria.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(370, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Categoría:"
        '
        'cmbParcial
        '
        Me.cmbParcial.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbParcial.AutoCompletion = True
        Me.cmbParcial.AutoDropDown = True
        Me.cmbParcial.Caption = ""
        Me.cmbParcial.CaptionHeight = 17
        Me.cmbParcial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbParcial.ColumnCaptionHeight = 17
        Me.cmbParcial.ColumnFooterHeight = 17
        Me.cmbParcial.ContentHeight = 18
        Me.cmbParcial.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbParcial.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbParcial.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParcial.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbParcial.EditorHeight = 18
        Me.cmbParcial.Images.Add(CType(resources.GetObject("cmbParcial.Images"), System.Drawing.Image))
        Me.cmbParcial.ItemHeight = 15
        Me.cmbParcial.Location = New System.Drawing.Point(117, 56)
        Me.cmbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParcial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbParcial.MaxDropDownItems = CType(5, Short)
        Me.cmbParcial.MaxLength = 32767
        Me.cmbParcial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbParcial.Name = "cmbParcial"
        Me.cmbParcial.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbParcial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbParcial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbParcial.Size = New System.Drawing.Size(231, 24)
        Me.cmbParcial.TabIndex = 113
        Me.cmbParcial.Tag = "OBLIGATORIO"
        Me.cmbParcial.PropBag = resources.GetString("cmbParcial.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Parcial:"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPeriodo.AutoCompletion = True
        Me.cmbPeriodo.AutoDropDown = True
        Me.cmbPeriodo.Caption = ""
        Me.cmbPeriodo.CaptionHeight = 17
        Me.cmbPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPeriodo.ColumnCaptionHeight = 17
        Me.cmbPeriodo.ColumnFooterHeight = 17
        Me.cmbPeriodo.ContentHeight = 18
        Me.cmbPeriodo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodo.EditorHeight = 18
        Me.cmbPeriodo.Images.Add(CType(resources.GetObject("cmbPeriodo.Images"), System.Drawing.Image))
        Me.cmbPeriodo.ItemHeight = 15
        Me.cmbPeriodo.Location = New System.Drawing.Point(117, 18)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(231, 24)
        Me.cmbPeriodo.TabIndex = 111
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Período:"
        '
        'grdCuentas
        '
        Me.grdCuentas.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdCuentas.Location = New System.Drawing.Point(0, 109)
        Me.grdCuentas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdCuentas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdCuentas.MainView = Me.grdvwGrados
        Me.grdCuentas.Margin = New System.Windows.Forms.Padding(4)
        Me.grdCuentas.Name = "grdCuentas"
        Me.grdCuentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado, Me.RepositoryItemMemoEdit1})
        Me.grdCuentas.Size = New System.Drawing.Size(759, 250)
        Me.grdCuentas.TabIndex = 0
        Me.grdCuentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwGrados})
        '
        'grdvwGrados
        '
        Me.grdvwGrados.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAsignaturaID, Me.ColSeleccionar, Me.colDescripcion})
        Me.grdvwGrados.GridControl = Me.grdCuentas
        Me.grdvwGrados.Name = "grdvwGrados"
        Me.grdvwGrados.OptionsSelection.MultiSelect = True
        Me.grdvwGrados.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grdvwGrados.OptionsView.ColumnAutoWidth = False
        Me.grdvwGrados.OptionsView.ShowAutoFilterRow = True
        Me.grdvwGrados.OptionsView.ShowDetailButtons = False
        Me.grdvwGrados.OptionsView.ShowGroupPanel = False
        '
        'colAsignaturaID
        '
        Me.colAsignaturaID.Caption = "AsignaturaID"
        Me.colAsignaturaID.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colAsignaturaID.FieldName = "GradoID"
        Me.colAsignaturaID.Name = "colAsignaturaID"
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
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
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.OptionsColumn.AllowMove = False
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'colDescripcion
        '
        Me.colDescripcion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colDescripcion.AppearanceHeader.Options.UseFont = True
        Me.colDescripcion.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcion.Caption = "Nombre"
        Me.colDescripcion.FieldName = "Nombre"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowMove = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 454
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'frmBuscarEvidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBuscarEvidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar evidencias"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbParcial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwGrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdCuentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwGrados As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colAsignaturaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbParcial As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As Label
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents cmbCategoria As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrPrv As ErrorProvider
End Class
