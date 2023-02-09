﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccDepositos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccDepositos))
        Me.grdArqueo = New DevExpress.XtraGrid.GridControl()
        Me.grdArqueoabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colEntradaEfectivo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaqueo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.tstND = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAprobar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.grdArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdArqueoabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstND.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdArqueo
        '
        Me.grdArqueo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdArqueo.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdArqueo.Location = New System.Drawing.Point(0, 39)
        Me.grdArqueo.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdArqueo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdArqueo.MainView = Me.grdArqueoabla
        Me.grdArqueo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grdArqueo.Name = "grdArqueo"
        Me.grdArqueo.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemCheckEdit2, Me.RepositoryItemDateEdit2})
        Me.grdArqueo.Size = New System.Drawing.Size(1193, 491)
        Me.grdArqueo.TabIndex = 12
        Me.grdArqueo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdArqueoabla})
        '
        'grdArqueoabla
        '
        Me.grdArqueoabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colFecha, Me.colEntradaEfectivo, Me.colDescripcion, Me.colFechaqueo})
        Me.grdArqueoabla.GridControl = Me.grdArqueo
        Me.grdArqueoabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdArqueoabla.Name = "grdArqueoabla"
        Me.grdArqueoabla.OptionsView.ShowAutoFilterRow = True
        Me.grdArqueoabla.Tag = ""
        '
        'colNumero
        '
        Me.colNumero.Caption = "ArqueoID"
        Me.colNumero.FieldName = "ScontDepositosID"
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
        Me.colFecha.Caption = "Fecha del deposito"
        Me.colFecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFecha.FieldName = "FechaDeposito"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 170
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colEntradaEfectivo
        '
        Me.colEntradaEfectivo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEntradaEfectivo.AppearanceHeader.Options.UseFont = True
        Me.colEntradaEfectivo.AppearanceHeader.Options.UseTextOptions = True
        Me.colEntradaEfectivo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEntradaEfectivo.Caption = "Monto del arqueo"
        Me.colEntradaEfectivo.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.colEntradaEfectivo.FieldName = "EntradaEfectivo"
        Me.colEntradaEfectivo.Name = "colEntradaEfectivo"
        Me.colEntradaEfectivo.OptionsColumn.AllowEdit = False
        Me.colEntradaEfectivo.OptionsColumn.ReadOnly = True
        Me.colEntradaEfectivo.Visible = True
        Me.colEntradaEfectivo.VisibleIndex = 3
        Me.colEntradaEfectivo.Width = 222
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
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
        Me.colDescripcion.Width = 316
        '
        'colFechaqueo
        '
        Me.colFechaqueo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFechaqueo.AppearanceHeader.Options.UseFont = True
        Me.colFechaqueo.AppearanceHeader.Options.UseTextOptions = True
        Me.colFechaqueo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFechaqueo.Caption = "Fecha del arqueo"
        Me.colFechaqueo.FieldName = "FechaArqueo"
        Me.colFechaqueo.Name = "colFechaqueo"
        Me.colFechaqueo.OptionsColumn.AllowEdit = False
        Me.colFechaqueo.Visible = True
        Me.colFechaqueo.VisibleIndex = 1
        Me.colFechaqueo.Width = 169
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
        'tstND
        '
        Me.tstND.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstND.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdAprobar, Me.cmdConsultar, Me.cmdAnular, Me.ToolStripSeparator1, Me.cmdImprimir, Me.ToolStripSeparator2, Me.cmdRefrescar, Me.ToolStripSeparator4, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tstND.Location = New System.Drawing.Point(0, 0)
        Me.tstND.Name = "tstND"
        Me.tstND.Size = New System.Drawing.Size(1193, 39)
        Me.tstND.TabIndex = 11
        Me.tstND.Text = "Nota de Débito"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Enabled = False
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar deposito"
        Me.cmdAgregar.ToolTipText = "Agregar deposito"
        '
        'cmdAprobar
        '
        Me.cmdAprobar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAprobar.Image = CType(resources.GetObject("cmdAprobar.Image"), System.Drawing.Image)
        Me.cmdAprobar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAprobar.Name = "cmdAprobar"
        Me.cmdAprobar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAprobar.Text = "Editar deposito"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Enabled = False
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar deposito"
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
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Enabled = False
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.Text = "Refrescar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.Text = "Salir"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(111, 36)
        Me.ToolStripLabel1.Text = "Depositos"
        '
        'frmSccDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 530)
        Me.Controls.Add(Me.grdArqueo)
        Me.Controls.Add(Me.tstND)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSccDepositos"
        Me.Text = "Depositos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdArqueoabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstND.ResumeLayout(False)
        Me.tstND.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdArqueo As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdArqueoabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colEntradaEfectivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents tstND As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAprobar As System.Windows.Forms.ToolStripButton
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents colFechaqueo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdAnular As ToolStripButton
End Class