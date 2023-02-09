<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSccCuentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccCuentas))
        Me.tbCuentas = New System.Windows.Forms.ToolStrip()
        Me.cmdConsultar = New System.Windows.Forms.ToolStripButton()
        Me.cmdRefrescar = New System.Windows.Forms.ToolStripButton()
        Me.cmdSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.C1Sizer1 = New C1.Win.C1Sizer.C1Sizer()
        Me.grdExpedienteMaster = New DevExpress.XtraGrid.GridControl()
        Me.grdExpedienteMasterTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPeriodo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaldo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModalidad = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.tbCuentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdConsultar, Me.cmdRefrescar, Me.cmdSalir, Me.ToolStripLabel1})
        Me.tbCuentas.Location = New System.Drawing.Point(0, 0)
        Me.tbCuentas.Name = "tbCuentas"
        Me.tbCuentas.Size = New System.Drawing.Size(863, 39)
        Me.tbCuentas.TabIndex = 0
        Me.tbCuentas.Text = "ToolStrip1"
        '
        'cmdConsultar
        '
        Me.cmdConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConsultar.Image = CType(resources.GetObject("cmdConsultar.Image"), System.Drawing.Image)
        Me.cmdConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(36, 36)
        Me.cmdConsultar.ToolTipText = "Consultar expediente"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(103, 36)
        Me.ToolStripLabel1.Text = "Expedientes"
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
        Me.grdExpedienteMasterTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNumero, Me.colPeriodo, Me.colAlumno, Me.colSaldo, Me.colEstado, Me.colGrado, Me.colModalidad})
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
        Me.colNumero.Width = 106
        '
        'colPeriodo
        '
        Me.colPeriodo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPeriodo.AppearanceHeader.Options.UseFont = True
        Me.colPeriodo.AppearanceHeader.Options.UseTextOptions = True
        Me.colPeriodo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPeriodo.Caption = "Período"
        Me.colPeriodo.FieldName = "Periodo"
        Me.colPeriodo.Name = "colPeriodo"
        Me.colPeriodo.OptionsColumn.AllowEdit = False
        Me.colPeriodo.OptionsColumn.AllowFocus = False
        Me.colPeriodo.OptionsColumn.ReadOnly = True
        Me.colPeriodo.Visible = True
        Me.colPeriodo.VisibleIndex = 1
        Me.colPeriodo.Width = 90
        '
        'colAlumno
        '
        Me.colAlumno.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAlumno.AppearanceHeader.Options.UseFont = True
        Me.colAlumno.AppearanceHeader.Options.UseTextOptions = True
        Me.colAlumno.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAlumno.Caption = "Alumno"
        Me.colAlumno.FieldName = "Alumno"
        Me.colAlumno.Name = "colAlumno"
        Me.colAlumno.OptionsColumn.AllowEdit = False
        Me.colAlumno.OptionsColumn.AllowFocus = False
        Me.colAlumno.OptionsColumn.ReadOnly = True
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 4
        Me.colAlumno.Width = 225
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
        Me.colSaldo.VisibleIndex = 5
        Me.colSaldo.Width = 137
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
        Me.colEstado.VisibleIndex = 6
        Me.colEstado.Width = 119
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
        Me.colGrado.OptionsColumn.AllowFocus = False
        Me.colGrado.OptionsColumn.ReadOnly = True
        Me.colGrado.Visible = True
        Me.colGrado.VisibleIndex = 3
        Me.colGrado.Width = 83
        '
        'colModalidad
        '
        Me.colModalidad.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colModalidad.AppearanceHeader.Options.UseFont = True
        Me.colModalidad.AppearanceHeader.Options.UseTextOptions = True
        Me.colModalidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colModalidad.Caption = "Modalidad"
        Me.colModalidad.FieldName = "Modalidad"
        Me.colModalidad.Name = "colModalidad"
        Me.colModalidad.OptionsColumn.AllowEdit = False
        Me.colModalidad.Visible = True
        Me.colModalidad.VisibleIndex = 2
        Me.colModalidad.Width = 85
        '
        'frmSccCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 533)
        Me.Controls.Add(Me.C1Sizer1)
        Me.Controls.Add(Me.tbCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSccCuentas"
        Me.Text = "Expedientes"
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
    Friend WithEvents colPeriodo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModalidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
End Class
