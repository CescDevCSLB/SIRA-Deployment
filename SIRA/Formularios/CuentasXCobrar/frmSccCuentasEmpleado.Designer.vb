<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccCuentasEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentasEmpleado))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdContabilizar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRevertir = New System.Windows.Forms.ToolStripButton()
        Me.cmdInactivar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.grdExpedienteMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdExpedienteMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagoMensual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlazo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tbCuentas.SuspendLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1Sizer1.SuspendLayout()
        CType(Me.grdExpedienteMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdExpedienteMasterTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbCuentas
        '
        Me.tbCuentas.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.cmdEditar, Me.cmdConsultar, Me.cmdContabilizar, Me.cmdRevertir, Me.cmdInactivar, Me.cmdImprimir, Me.cmdRefrescar, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(863, 39)
        Me.tbCuentas.TabIndex = 0
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregar.Image = CType(resources.GetObject("cmdAgregar.Image"), System.Drawing.Image)
        Me.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(36, 36)
        Me.cmdAgregar.Text = "Agregar prestamo"
        Me.cmdAgregar.ToolTipText = "Agregar prestamo"
        '
        'cmdEditar
        '
        Me.cmdEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(36, 36)
        Me.cmdEditar.Text = "Editar prestamo"
        Me.cmdEditar.ToolTipText = "Editar prestamo"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.Text = "Consultar prestamo"
        Me.cmdConsultar.ToolTipText = "Consultar prestamo"
        '
        'cmdContabilizar
        '
        Me.cmdContabilizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdContabilizar.Image = CType(resources.GetObject("cmdContabilizar.Image"), System.Drawing.Image)
        Me.cmdContabilizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdContabilizar.Name = "cmdContabilizar"
        Me.cmdContabilizar.Size = New System.Drawing.Size(36, 36)
        Me.cmdContabilizar.Text = "Aplicar pago por deducción "
        '
        'cmdRevertir
        '
        Me.cmdRevertir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRevertir.Image = CType(resources.GetObject("cmdRevertir.Image"), System.Drawing.Image)
        Me.cmdRevertir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRevertir.Name = "cmdRevertir"
        Me.cmdRevertir.Size = New System.Drawing.Size(36, 36)
        Me.cmdRevertir.Text = "Revertir pago por deducción "
        '
        'cmdInactivar
        '
        Me.cmdInactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdInactivar.Image = CType(resources.GetObject("cmdInactivar.Image"), System.Drawing.Image)
        Me.cmdInactivar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInactivar.Name = "cmdInactivar"
        Me.cmdInactivar.Size = New System.Drawing.Size(36, 36)
        Me.cmdInactivar.Text = "Anular prestamo"
        Me.cmdInactivar.ToolTipText = "Anular prestamo"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdImprimir.Image = CType(resources.GetObject("cmdImprimir.Image"), System.Drawing.Image)
        Me.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprimir.Name = "cmdImprimir"
        Me.cmdImprimir.Size = New System.Drawing.Size(36, 36)
        Me.cmdImprimir.Text = "Imprimir estado de cuenta"
        Me.cmdImprimir.ToolTipText = "Imprimir estado de cuenta"
        '
        'cmdRefrescar
        '
        Me.cmdRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdRefrescar.Image = CType(resources.GetObject("cmdRefrescar.Image"), System.Drawing.Image)
        Me.cmdRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRefrescar.Name = "cmdRefrescar"
        Me.cmdRefrescar.Size = New System.Drawing.Size(36, 36)
        Me.cmdRefrescar.ToolTipText = "Refrescar Datos"
        '
        'cmdSalir
        '
        Me.cmdSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSalir.Image = CType(resources.GetObject("cmdSalir.Image"), System.Drawing.Image)
        Me.cmdSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(36, 36)
        Me.cmdSalir.ToolTipText = "Salir "
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(190, 36)
        Me.ToolStripLabel1.Text = "Prestamos a empleados"
        '
        'C1Sizer1
        '
        Me.C1Sizer1.Controls.Add(Me.grdExpedienteMaster)
        Me.C1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Sizer1.GridDefinition = "98.3805668016194:False:False;" & Global.Microsoft.VisualBasic.ChrW(9) & "99.0730011587486:False:False;"
        Me.C1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.C1Sizer1.Location = New System.Drawing.Point(0, 39)
        Me.C1Sizer1.Name = "C1Sizer1"
        Me.C1Sizer1.Size = New System.Drawing.Size(863, 494)
        Me.C1Sizer1.TabIndex = 1
        Me.C1Sizer1.TabStop = False
        '
        'grdExpedienteMaster
        '
        Me.grdExpedienteMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdExpedienteMaster.Location = New System.Drawing.Point(0, 0)
        Me.grdExpedienteMaster.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdExpedienteMaster.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdExpedienteMaster.MainView = Me.grdExpedienteMasterTabla
        Me.grdExpedienteMaster.Name = "grdExpedienteMaster"
        Me.grdExpedienteMaster.Size = New System.Drawing.Size(863, 494)
        Me.grdExpedienteMaster.TabIndex = 13
        Me.grdExpedienteMaster.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdExpedienteMasterTabla})
        '
        'grdExpedienteMasterTabla
        '
        Me.grdExpedienteMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colEmpleado, Me.colSaldo, Me.colEstado, Me.colPagoMensual, Me.colPlazo})
        Me.grdExpedienteMasterTabla.GridControl = Me.grdExpedienteMaster
        Me.grdExpedienteMasterTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdExpedienteMasterTabla.Name = "grdExpedienteMasterTabla"
        Me.grdExpedienteMasterTabla.OptionsDetail.AllowZoomDetail = False
        Me.grdExpedienteMasterTabla.OptionsDetail.EnableMasterViewMode = False
        Me.grdExpedienteMasterTabla.OptionsDetail.ShowDetailTabs = False
        Me.grdExpedienteMasterTabla.OptionsDetail.SmartDetailExpand = False
        Me.grdExpedienteMasterTabla.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckDefaultDetail
        Me.grdExpedienteMasterTabla.OptionsView.ShowAutoFilterRow = True
        Me.grdExpedienteMasterTabla.ViewCaption = "Arrastre hacia acá la etiqueta del campo por la cual desea agrupar los datos"
        '
        'colNumero
        '
        Me.colNumero.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumero.AppearanceHeader.Options.UseFont = True
        Me.colNumero.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumero.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumero.Caption = "No Expediente" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.OptionsColumn.AllowFocus = False
        Me.colNumero.OptionsColumn.ReadOnly = True
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 0
        Me.colNumero.Width = 118
        '
        'colEmpleado
        '
        Me.colEmpleado.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEmpleado.AppearanceHeader.Options.UseFont = True
        Me.colEmpleado.AppearanceHeader.Options.UseTextOptions = True
        Me.colEmpleado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEmpleado.Caption = "Empleado"
        Me.colEmpleado.FieldName = "Empleado"
        Me.colEmpleado.Name = "colEmpleado"
        Me.colEmpleado.OptionsColumn.AllowEdit = False
        Me.colEmpleado.OptionsColumn.AllowFocus = False
        Me.colEmpleado.OptionsColumn.ReadOnly = True
        Me.colEmpleado.Visible = True
        Me.colEmpleado.VisibleIndex = 1
        Me.colEmpleado.Width = 251
        '
        'colSaldo
        '
        Me.colSaldo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colSaldo.AppearanceHeader.Options.UseFont = True
        Me.colSaldo.AppearanceHeader.Options.UseTextOptions = True
        Me.colSaldo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSaldo.Caption = "Saldo"
        Me.colSaldo.FieldName = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.OptionsColumn.AllowEdit = False
        Me.colSaldo.OptionsColumn.AllowFocus = False
        Me.colSaldo.OptionsColumn.ReadOnly = True
        Me.colSaldo.Visible = True
        Me.colSaldo.VisibleIndex = 4
        Me.colSaldo.Width = 129
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
        Me.colEstado.OptionsColumn.AllowFocus = False
        Me.colEstado.OptionsColumn.ReadOnly = True
        Me.colEstado.Visible = True
        Me.colEstado.VisibleIndex = 5
        Me.colEstado.Width = 115
        '
        'colPagoMensual
        '
        Me.colPagoMensual.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagoMensual.AppearanceHeader.Options.UseFont = True
        Me.colPagoMensual.AppearanceHeader.Options.UseTextOptions = True
        Me.colPagoMensual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPagoMensual.Caption = "Pago mensual"
        Me.colPagoMensual.FieldName = "PagoMensual"
        Me.colPagoMensual.Name = "colPagoMensual"
        Me.colPagoMensual.OptionsColumn.AllowEdit = False
        Me.colPagoMensual.OptionsColumn.AllowFocus = False
        Me.colPagoMensual.OptionsColumn.ReadOnly = True
        Me.colPagoMensual.Visible = True
        Me.colPagoMensual.VisibleIndex = 3
        Me.colPagoMensual.Width = 137
        '
        'colPlazo
        '
        Me.colPlazo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPlazo.AppearanceHeader.Options.UseFont = True
        Me.colPlazo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPlazo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPlazo.Caption = "Plazo"
        Me.colPlazo.FieldName = "Plazo"
        Me.colPlazo.Name = "colPlazo"
        Me.colPlazo.OptionsColumn.AllowEdit = False
        Me.colPlazo.Visible = True
        Me.colPlazo.VisibleIndex = 2
        Me.colPlazo.Width = 95
        '
        'frmSccCuentasEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 533)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.tbCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccCuentasEmpleado"
        Me.Text = "Prestamos a empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbCuentas.ResumeLayout(False)
        Me.tbCuentas.PerformLayout()
        CType(Me.C1Sizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1Sizer1.ResumeLayout(False)
        CType(Me.grdExpedienteMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdExpedienteMasterTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCuentas As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdConsultar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents C1Sizer1 As C1.Win.C1Sizer.C1Sizer
    Friend WithEvents grdExpedienteMaster As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdExpedienteMasterTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagoMensual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlazo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdAgregar As ToolStripButton
    Friend WithEvents cmdEditar As ToolStripButton
    Friend WithEvents cmdContabilizar As ToolStripButton
    Friend WithEvents cmdInactivar As ToolStripButton
    Friend WithEvents cmdImprimir As ToolStripButton
    Friend WithEvents cmdRevertir As ToolStripButton
End Class
