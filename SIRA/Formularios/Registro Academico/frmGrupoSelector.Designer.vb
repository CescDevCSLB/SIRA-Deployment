<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupoSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupoSelector))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.pnlBotones = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdGrupos = New DevExpress.XtraGrid.GridControl()
        Me.grdvwGrupos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colSraGrupoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGuia = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBotones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlBotones.Location = New System.Drawing.Point(0, 289)
        Me.pnlBotones.Name = "pnlBotones"
        Me.pnlBotones.Size = New System.Drawing.Size(502, 49)
        Me.pnlBotones.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(418, 13)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 28)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(332, 13)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "ACEPTAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 347)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 16)
        Me.Panel1.TabIndex = 26
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdGrupos)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(502, 363)
        Me.PanelControl1.TabIndex = 8
        '
        'grdGrupos
        '
        Me.grdGrupos.Location = New System.Drawing.Point(0, 0)
        Me.grdGrupos.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdGrupos.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdGrupos.MainView = Me.grdvwGrupos
        Me.grdGrupos.Name = "grdGrupos"
        Me.grdGrupos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado})
        Me.grdGrupos.Size = New System.Drawing.Size(502, 292)
        Me.grdGrupos.TabIndex = 0
        Me.grdGrupos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwGrupos})
        '
        'grdvwGrupos
        '
        Me.grdvwGrupos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSeleccionar, Me.colSraGrupoID, Me.colSeccion, Me.colGrado, Me.colGuia})
        Me.grdvwGrupos.GridControl = Me.grdGrupos
        Me.grdvwGrupos.Name = "grdvwGrupos"
        Me.grdvwGrupos.OptionsView.ColumnAutoWidth = False
        Me.grdvwGrupos.OptionsView.ShowAutoFilterRow = True
        Me.grdvwGrupos.OptionsView.ShowDetailButtons = False
        Me.grdvwGrupos.OptionsView.ShowGroupPanel = False
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
        Me.ColSeleccionar.Visible = True
        Me.ColSeleccionar.VisibleIndex = 0
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'colSraGrupoID
        '
        Me.colSraGrupoID.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSraGrupoID.AppearanceHeader.Options.UseFont = True
        Me.colSraGrupoID.AppearanceHeader.Options.UseTextOptions = True
        Me.colSraGrupoID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSraGrupoID.Caption = "SraGrupoID"
        Me.colSraGrupoID.FieldName = "SraGrupoID"
        Me.colSraGrupoID.Name = "colSraGrupoID"
        Me.colSraGrupoID.OptionsColumn.AllowEdit = False
        Me.colSraGrupoID.OptionsColumn.AllowMove = False
        Me.colSraGrupoID.Width = 108
        '
        'colSeccion
        '
        Me.colSeccion.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colSeccion.AppearanceHeader.Options.UseFont = True
        Me.colSeccion.AppearanceHeader.Options.UseTextOptions = True
        Me.colSeccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSeccion.Caption = "Sección"
        Me.colSeccion.FieldName = "Seccion"
        Me.colSeccion.Name = "colSeccion"
        Me.colSeccion.OptionsColumn.AllowEdit = False
        Me.colSeccion.OptionsColumn.AllowMove = False
        Me.colSeccion.Visible = True
        Me.colSeccion.VisibleIndex = 2
        Me.colSeccion.Width = 97
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
        Me.colGrado.OptionsColumn.AllowMove = False
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 1
        '
        'colGuia
        '
        Me.colGuia.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGuia.AppearanceHeader.Options.UseFont = True
        Me.colGuia.AppearanceHeader.Options.UseTextOptions = True
        Me.colGuia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGuia.Caption = "Guía"
        Me.colGuia.FieldName = "Guia"
        Me.colGuia.Name = "colGuia"
        Me.colGuia.Visible = True
        Me.colGuia.VisibleIndex = 3
        Me.colGuia.Width = 235
        '
        'frmGrupoSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 363)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBotones)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGrupoSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selección de grupos"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBotones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBotones As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grdGrupos As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwGrupos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSraGrupoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGuia As DevExpress.XtraGrid.Columns.GridColumn
End Class
