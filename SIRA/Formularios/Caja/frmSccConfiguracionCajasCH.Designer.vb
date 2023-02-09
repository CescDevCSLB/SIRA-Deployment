<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccConfiguracionCajasCH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccConfiguracionCajasCH))
        Me.grdCajas = New DevExpress.XtraGrid.GridControl()
        Me.grdCajasTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajera = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.toolTramitesLegales = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmbReembolsar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAmpliartecho = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.ToolSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.colDisponible = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdCajasTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolTramitesLegales.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdCajas
        '
        Me.grdCajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCajas.Location = New System.Drawing.Point(0, 39)
        Me.grdCajas.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdCajas.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdCajas.MainView = Me.grdCajasTabla
        Me.grdCajas.Name = "grdCajas"
        Me.grdCajas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdCajas.Size = New System.Drawing.Size(694, 374)
        Me.grdCajas.TabIndex = 9
        Me.grdCajas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdCajasTabla})
        '
        'grdCajasTabla
        '
        Me.grdCajasTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colCajera, Me.coMoneda, Me.colCodigo, Me.colDisponible})
        Me.grdCajasTabla.GridControl = Me.grdCajas
        Me.grdCajasTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdCajasTabla.Name = "grdCajasTabla"
        Me.grdCajasTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdCajasTabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "Numero"
        Me.colNumero.FieldName = "SccCajaChicaID"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Width = 84
        '
        'colCajera
        '
        Me.colCajera.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCajera.AppearanceHeader.Options.UseFont = True
        Me.colCajera.AppearanceHeader.Options.UseTextOptions = True
        Me.colCajera.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCajera.Caption = "Cajera"
        Me.colCajera.FieldName = "NombreCompleto"
        Me.colCajera.Name = "colCajera"
        Me.colCajera.OptionsColumn.AllowEdit = False
        Me.colCajera.OptionsColumn.ReadOnly = True
        Me.colCajera.Visible = True
        Me.colCajera.VisibleIndex = 1
        Me.colCajera.Width = 301
        '
        'coMoneda
        '
        Me.coMoneda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coMoneda.AppearanceHeader.Options.UseFont = True
        Me.coMoneda.AppearanceHeader.Options.UseTextOptions = True
        Me.coMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.coMoneda.Caption = "Moneda"
        Me.coMoneda.FieldName = "Moneda"
        Me.coMoneda.Name = "coMoneda"
        Me.coMoneda.OptionsColumn.AllowEdit = False
        Me.coMoneda.OptionsColumn.ReadOnly = True
        Me.coMoneda.Visible = True
        Me.coMoneda.VisibleIndex = 2
        Me.coMoneda.Width = 158
        '
        'colCodigo
        '
        Me.colCodigo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCodigo.AppearanceHeader.Options.UseFont = True
        Me.colCodigo.AppearanceHeader.Options.UseTextOptions = True
        Me.colCodigo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.AllowEdit = False
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 83
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'toolTramitesLegales
        '
        Me.toolTramitesLegales.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolTramitesLegales.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmbReembolsar, Me.cmdAmpliartecho, Me.cmdConsultar, Me.cmdInactivar, Me.ToolSeparador1, Me.tsbRefrescar, Me.tsbSalir, Me.ToolStripLabel1})
        Me.toolTramitesLegales.Location = New System.Drawing.Point(0, 0)
        Me.toolTramitesLegales.Name = "toolTramitesLegales"
        Me.toolTramitesLegales.Size = New System.Drawing.Size(694, 39)
        Me.toolTramitesLegales.TabIndex = 8
        Me.toolTramitesLegales.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar caja chica"
        Me.cmdAgregar.ToolTipText = "Agregar Caja"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar caja chica"
        Me.cmdEditar.ToolTipText = "Editar Caja"
        '
        'cmbReembolsar
        '
        Me.cmbReembolsar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmbReembolsar.Image = CType(resources.GetObject("cmbReembolsar.Image"), System.Drawing.Image)
        Me.cmbReembolsar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbReembolsar.Name = "cmbReembolsar"
        Me.cmbReembolsar.Size = New System.Drawing.Size(36, 36)
        Me.cmbReembolsar.Text = "Reembolsar"
        '
        'cmdAmpliartecho
        '
        Me.cmdAmpliartecho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAmpliartecho.Image = CType(resources.GetObject("cmdAmpliartecho.Image"), System.Drawing.Image)
        Me.cmdAmpliartecho.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAmpliartecho.Name = "cmdAmpliartecho"
        Me.cmdAmpliartecho.Size = New System.Drawing.Size(36, 36)
        Me.cmdAmpliartecho.Text = "Ampliar techo"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar caja chica"
        Me.cmdConsultar.ToolTipText = "Consultar Caja"
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Inactivar caja chica"
        Me.cmdInactivar.ToolTipText = "Inactivar Caja"
        '
        'ToolSeparador1
        '
        Me.ToolSeparador1.Name = "ToolSeparador1"
        Me.ToolSeparador1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRefrescar
        '
        Me.tsbRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRefrescar.Image = CType(resources.GetObject("tsbRefrescar.Image"), System.Drawing.Image)
        Me.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRefrescar.Name = "tsbRefrescar"
        Me.tsbRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.tsbRefrescar.Text = "Refrescar Datos"
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(235, 36)
        Me.ToolStripLabel1.Text = "Configuracion de cajas chicas"
        '
        'colDisponible
        '
        Me.colDisponible.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDisponible.AppearanceHeader.Options.UseFont = True
        Me.colDisponible.AppearanceHeader.Options.UseTextOptions = True
        Me.colDisponible.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDisponible.Caption = "Disponible"
        Me.colDisponible.FieldName = "Disponible"
        Me.colDisponible.Name = "colDisponible"
        Me.colDisponible.OptionsColumn.AllowEdit = False
        Me.colDisponible.Visible = True
        Me.colDisponible.VisibleIndex = 3
        Me.colDisponible.Width = 134
        '
        'frmSccConfiguracionCajasCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 413)
        Me.Controls.Add(Me.grdCajas)
        Me.Controls.Add(Me.toolTramitesLegales)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccConfiguracionCajasCH"
        Me.Text = "Configuracion de cajas chicas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdCajasTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolTramitesLegales.ResumeLayout(False)
        Me.toolTramitesLegales.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdCajasTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajera As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents toolTramitesLegales As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdInactivar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolSeparador1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbReembolsar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAmpliartecho As System.Windows.Forms.ToolStripButton
    Friend WithEvents colDisponible As DevExpress.XtraGrid.Columns.GridColumn
End Class
