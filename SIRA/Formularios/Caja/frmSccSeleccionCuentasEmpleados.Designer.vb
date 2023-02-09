<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccSeleccionCuentasEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccSeleccionCuentasEmpleados))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdSeleccion = New DevExpress.XtraGrid.GridControl()
        Me.grdvwSeleccion = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ColSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chkSeleccionado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCompleto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrupo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdvwSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancelar)
        Me.Panel1.Controls.Add(Me.cmdAceptar)
        Me.Panel1.Location = New System.Drawing.Point(0, 300)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 33)
        Me.Panel1.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(595, 4)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAceptar.Appearance.Options.UseFont = True
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.Location = New System.Drawing.Point(507, 4)
        Me.cmdAceptar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdAceptar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(80, 28)
        Me.cmdAceptar.TabIndex = 0
        Me.cmdAceptar.Tag = "ACEPTAR"
        Me.cmdAceptar.Text = "&Aceptar"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 336)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(692, 18)
        Me.Panel3.TabIndex = 23
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdSeleccion)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(692, 354)
        Me.PanelControl1.TabIndex = 99
        '
        'grdSeleccion
        '
        Me.grdSeleccion.Location = New System.Drawing.Point(4, 0)
        Me.grdSeleccion.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdSeleccion.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdSeleccion.MainView = Me.grdvwSeleccion
        Me.grdSeleccion.Name = "grdSeleccion"
        Me.grdSeleccion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSeleccionado})
        Me.grdSeleccion.Size = New System.Drawing.Size(688, 266)
        Me.grdSeleccion.TabIndex = 1
        Me.grdSeleccion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdvwSeleccion})
        '
        'grdvwSeleccion
        '
        Me.grdvwSeleccion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColSeleccionar, Me.colCodigo, Me.colNombreCompleto, Me.colGrupo})
        Me.grdvwSeleccion.GridControl = Me.grdSeleccion
        Me.grdvwSeleccion.Name = "grdvwSeleccion"
        Me.grdvwSeleccion.OptionsView.ColumnAutoWidth = False
        Me.grdvwSeleccion.OptionsView.ShowAutoFilterRow = True
        Me.grdvwSeleccion.OptionsView.ShowDetailButtons = False
        Me.grdvwSeleccion.OptionsView.ShowGroupPanel = False
        '
        'ColSeleccionar
        '
        Me.ColSeleccionar.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ColSeleccionar.AppearanceHeader.Options.UseFont = True
        Me.ColSeleccionar.AppearanceHeader.Options.UseTextOptions = True
        Me.ColSeleccionar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColSeleccionar.Caption = "Seleccionar"
        Me.ColSeleccionar.ColumnEdit = Me.chkSeleccionado
        Me.ColSeleccionar.FieldName = "Seleccion"
        Me.ColSeleccionar.Name = "ColSeleccionar"
        Me.ColSeleccionar.OptionsColumn.AllowMove = False
        Me.ColSeleccionar.Visible = True
        Me.ColSeleccionar.VisibleIndex = 0
        Me.ColSeleccionar.Width = 78
        '
        'chkSeleccionado
        '
        Me.chkSeleccionado.AutoHeight = False
        Me.chkSeleccionado.Caption = "Check"
        Me.chkSeleccionado.Name = "chkSeleccionado"
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Cédula"
        Me.colCodigo.FieldName = "Cedula"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.OptionsColumn.AllowMove = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 2
        Me.colCodigo.Width = 164
        '
        'colNombreCompleto
        '
        Me.colNombreCompleto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.colNombreCompleto.AppearanceHeader.Options.UseFont = True
        Me.colNombreCompleto.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombreCompleto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombreCompleto.Caption = "Empleado"
        Me.colNombreCompleto.FieldName = "Empleado"
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.OptionsColumn.AllowEdit = False
        Me.colNombreCompleto.OptionsColumn.AllowMove = False
        Me.colNombreCompleto.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.colNombreCompleto.Visible = True
        Me.colNombreCompleto.VisibleIndex = 3
        Me.colNombreCompleto.Width = 337
        '
        'colGrupo
        '
        Me.colGrupo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGrupo.AppearanceHeader.Options.UseFont = True
        Me.colGrupo.AppearanceHeader.Options.UseTextOptions = True
        Me.colGrupo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colGrupo.Caption = "Prestamo"
        Me.colGrupo.FieldName = "Numero"
        Me.colGrupo.Name = "colGrupo"
        Me.colGrupo.OptionsColumn.AllowEdit = False
        Me.colGrupo.Visible = True
        Me.colGrupo.VisibleIndex = 1
        Me.colGrupo.Width = 90
        '
        'frmSccSeleccionCuentasEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 354)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccSeleccionCuentasEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selección de Prestamo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdvwSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdSeleccion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdvwSeleccion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkSeleccionado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCompleto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrupo As DevExpress.XtraGrid.Columns.GridColumn
End Class
