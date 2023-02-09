<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccSalidaCajaCH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccSalidaCajaCH))
        Me.tbRecibosCajas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.objUbicacion = New System.Windows.Forms.SaveFileDialog()
        Me.grdRecibosCaja = New DevExpress.XtraGrid.GridControl()
        Me.grdRecibosCajaTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSccSalidasCajaChicaID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajaChica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colobjEstadoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCentroCosto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tbRecibosCajas.SuspendLayout()
        CType(Me.grdRecibosCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdRecibosCajaTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbRecibosCajas
        '
        Me.tbRecibosCajas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbRecibosCajas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdAnular, Me.ToolStripSeparator1, Me.cmdConsultar, Me.cmdImprimir, Me.cmdRefrescar, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbRecibosCajas.Location = New System.Drawing.Point(0, 0)
        Me.tbRecibosCajas.Name = "tbRecibosCajas"
        Me.tbRecibosCajas.Size = New System.Drawing.Size(721, 39)
        Me.tbRecibosCajas.TabIndex = 1
        Me.tbRecibosCajas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.ToolTipText = "Agregar salida"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.ToolTipText = "Editar salida"
        '
        'cmdAnular
        '
        Me.cmdAnular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAnular.Image = CType(resources.GetObject("cmdAnular.Image"), System.Drawing.Image)
        Me.cmdAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAnular.Name = "cmdAnular"
        Me.cmdAnular.Size = New System.Drawing.Size(36, 36)
        Me.cmdAnular.Text = "Anular"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar salida"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar"
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
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(167, 36)
        Me.ToolStripLabel1.Text = "Salidas de caja chica"
        '
        'grdRecibosCaja
        '
        Me.grdRecibosCaja.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdRecibosCaja.Location = New System.Drawing.Point(0, 39)
        Me.grdRecibosCaja.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdRecibosCaja.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdRecibosCaja.MainView = Me.grdRecibosCajaTabla
        Me.grdRecibosCaja.Name = "grdRecibosCaja"
        Me.grdRecibosCaja.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdRecibosCaja.Size = New System.Drawing.Size(721, 439)
        Me.grdRecibosCaja.TabIndex = 10
        Me.grdRecibosCaja.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdRecibosCajaTabla})
        '
        'grdRecibosCajaTabla
        '
        Me.grdRecibosCajaTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSccSalidasCajaChicaID, Me.colCajaChica, Me.colAlumno, Me.colMonto, Me.colFecha, Me.colEstado, Me.colobjEstadoID, Me.colConcepto, Me.colMoneda, Me.colCentroCosto})
        Me.grdRecibosCajaTabla.GridControl = Me.grdRecibosCaja
        Me.grdRecibosCajaTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdRecibosCajaTabla.Name = "grdRecibosCajaTabla"
        Me.grdRecibosCajaTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdRecibosCajaTabla.Tag = ""
        '
        'colSccSalidasCajaChicaID
        '
        Me.colSccSalidasCajaChicaID.Caption = "SccSalidasCajaChicaID"
        Me.colSccSalidasCajaChicaID.FieldName = "SccSalidasCajaChicaID"
        Me.colSccSalidasCajaChicaID.Name = "colSccSalidasCajaChicaID"
        Me.colSccSalidasCajaChicaID.OptionsColumn.AllowEdit = False
        Me.colSccSalidasCajaChicaID.OptionsColumn.ReadOnly = True
        Me.colSccSalidasCajaChicaID.Width = 108
        '
        'colCajaChica
        '
        Me.colCajaChica.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCajaChica.AppearanceHeader.Options.UseFont = True
        Me.colCajaChica.AppearanceHeader.Options.UseTextOptions = True
        Me.colCajaChica.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCajaChica.Caption = "Caja Chica"
        Me.colCajaChica.FieldName = "CajaChica"
        Me.colCajaChica.Name = "colCajaChica"
        Me.colCajaChica.OptionsColumn.AllowEdit = False
        Me.colCajaChica.Visible = True
        Me.colCajaChica.VisibleIndex = 0
        Me.colCajaChica.Width = 78
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Cajero(a)"
        Me.colAlumno.FieldName = "Cajero"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.OptionsColumn.AllowEdit = False
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 1
        Me.colAlumno.Width = 106
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
        Me.colMonto.Width = 70
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
        Me.colFecha.VisibleIndex = 6
        Me.colFecha.Width = 65
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
        Me.colEstado.VisibleIndex = 7
        Me.colEstado.Width = 91
        '
        'colobjEstadoID
        '
        Me.colobjEstadoID.Caption = "objEstadoID"
        Me.colobjEstadoID.FieldName = "objEstadoID"
        Me.colobjEstadoID.Name = "colobjEstadoID"
        Me.colobjEstadoID.OptionsColumn.AllowEdit = False
        Me.colobjEstadoID.Width = 83
        '
        'colConcepto
        '
        Me.colConcepto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colConcepto.AppearanceHeader.Options.UseFont = True
        Me.colConcepto.AppearanceHeader.Options.UseTextOptions = True
        Me.colConcepto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colConcepto.Caption = "Concepto"
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 3
        Me.colConcepto.Width = 115
        '
        'colMoneda
        '
        Me.colMoneda.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colMoneda.AppearanceHeader.Options.UseFont = True
        Me.colMoneda.AppearanceHeader.Options.UseTextOptions = True
        Me.colMoneda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMoneda.Caption = "Moneda"
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.OptionsColumn.AllowEdit = False
        Me.colMoneda.Visible = True
        Me.colMoneda.VisibleIndex = 4
        Me.colMoneda.Width = 70
        '
        'colCentroCosto
        '
        Me.colCentroCosto.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colCentroCosto.AppearanceHeader.Options.UseFont = True
        Me.colCentroCosto.AppearanceHeader.Options.UseTextOptions = True
        Me.colCentroCosto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCentroCosto.Caption = "Centro de costo"
        Me.colCentroCosto.FieldName = "CentroCosto"
        Me.colCentroCosto.Name = "colCentroCosto"
        Me.colCentroCosto.OptionsColumn.AllowEdit = False
        Me.colCentroCosto.Visible = True
        Me.colCentroCosto.VisibleIndex = 2
        Me.colCentroCosto.Width = 108
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'frmSccSalidaCajaCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 478)
        Me.Controls.Add(Me.grdRecibosCaja)
        Me.Controls.Add(Me.tbRecibosCajas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccSalidaCajaCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "AGRUPAR"
        Me.Text = "Salidas de caja chica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbRecibosCajas.ResumeLayout(False)
        Me.tbRecibosCajas.PerformLayout()
        CType(Me.grdRecibosCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdRecibosCajaTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbRecibosCajas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents objUbicacion As System.Windows.Forms.SaveFileDialog
    Friend WithEvents grdRecibosCaja As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdRecibosCajaTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSccSalidasCajaChicaID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajaChica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colobjEstadoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAnular As ToolStripButton
    Friend WithEvents colCentroCosto As DevExpress.XtraGrid.Columns.GridColumn
End Class
