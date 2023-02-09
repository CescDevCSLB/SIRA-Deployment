<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSccConsultarDetalleArqueo
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSccConsultarDetalleArqueo))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grdDetalle = New DevExpress.XtraGrid.GridControl()
        Me.grdDetalleTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colAlumno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroRecibo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalRecibido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbCajero = New C1.Win.C1List.C1Combo()
        Me.lblCaja = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.spnFaltante = New DevExpress.XtraEditors.SpinEdit()
        Me.spnIngreso = New DevExpress.XtraEditors.SpinEdit()
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAprobadoPor = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grdDetalle)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(717, 280)
        Me.PanelControl1.TabIndex = 99
        '
        'grdDetalle
        '
        Me.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDetalle.Location = New System.Drawing.Point(2, 2)
        Me.grdDetalle.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdDetalle.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdDetalle.MainView = Me.grdDetalleTabla
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.grdDetalle.Size = New System.Drawing.Size(713, 255)
        Me.grdDetalle.TabIndex = 97
        Me.grdDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdDetalleTabla})
        '
        'grdDetalleTabla
        '
        Me.grdDetalleTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAlumno, Me.colConcepto, Me.colMoneda, Me.colNumeroRecibo, Me.colTipoPago, Me.colTotalRecibido})
        Me.grdDetalleTabla.GridControl = Me.grdDetalle
        Me.grdDetalleTabla.GroupPanelText = "Arrastrar un encabezado de columna aquí para agrupar por esa columna"
        Me.grdDetalleTabla.Name = "grdDetalleTabla"
        Me.grdDetalleTabla.OptionsView.ShowGroupPanel = False
        Me.grdDetalleTabla.Tag = ""
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
        Me.colAlumno.OptionsColumn.ReadOnly = True
        Me.colAlumno.Visible = True
        Me.colAlumno.VisibleIndex = 2
        Me.colAlumno.Width = 120
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
        Me.colConcepto.VisibleIndex = 4
        Me.colConcepto.Width = 123
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
        Me.colMoneda.VisibleIndex = 3
        Me.colMoneda.Width = 124
        '
        'colNumeroRecibo
        '
        Me.colNumeroRecibo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNumeroRecibo.AppearanceHeader.Options.UseFont = True
        Me.colNumeroRecibo.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroRecibo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroRecibo.Caption = "Número"
        Me.colNumeroRecibo.FieldName = "NumeroRecibo"
        Me.colNumeroRecibo.Name = "colNumeroRecibo"
        Me.colNumeroRecibo.OptionsColumn.AllowEdit = False
        Me.colNumeroRecibo.Visible = True
        Me.colNumeroRecibo.VisibleIndex = 0
        Me.colNumeroRecibo.Width = 70
        '
        'colTipoPago
        '
        Me.colTipoPago.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTipoPago.AppearanceHeader.Options.UseFont = True
        Me.colTipoPago.AppearanceHeader.Options.UseTextOptions = True
        Me.colTipoPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTipoPago.Caption = "Tipo de pago"
        Me.colTipoPago.FieldName = "TipoPago"
        Me.colTipoPago.Name = "colTipoPago"
        Me.colTipoPago.OptionsColumn.AllowEdit = False
        Me.colTipoPago.Visible = True
        Me.colTipoPago.VisibleIndex = 1
        Me.colTipoPago.Width = 81
        '
        'colTotalRecibido
        '
        Me.colTotalRecibido.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colTotalRecibido.AppearanceHeader.Options.UseFont = True
        Me.colTotalRecibido.AppearanceHeader.Options.UseTextOptions = True
        Me.colTotalRecibido.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colTotalRecibido.Caption = "Total Recibido"
        Me.colTotalRecibido.FieldName = "TotalRecibido"
        Me.colTotalRecibido.Name = "colTotalRecibido"
        Me.colTotalRecibido.OptionsColumn.AllowEdit = False
        Me.colTotalRecibido.Visible = True
        Me.colTotalRecibido.VisibleIndex = 5
        Me.colTotalRecibido.Width = 89
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(2, 257)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 21)
        Me.Panel1.TabIndex = 96
        '
        'cmbCajero
        '
        Me.cmbCajero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCajero.AutoCompletion = True
        Me.cmbCajero.AutoDropDown = True
        Me.cmbCajero.Caption = ""
        Me.cmbCajero.CaptionHeight = 17
        Me.cmbCajero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCajero.ColumnCaptionHeight = 17
        Me.cmbCajero.ColumnFooterHeight = 17
        Me.cmbCajero.ContentHeight = 15
        Me.cmbCajero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCajero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCajero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCajero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCajero.EditorHeight = 15
        Me.cmbCajero.Images.Add(CType(resources.GetObject("cmbCajero.Images"), System.Drawing.Image))
        Me.cmbCajero.ItemHeight = 15
        Me.cmbCajero.Location = New System.Drawing.Point(138, 43)
        Me.cmbCajero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCajero.MaxDropDownItems = CType(5, Short)
        Me.cmbCajero.MaxLength = 32767
        Me.cmbCajero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCajero.Name = "cmbCajero"
        Me.cmbCajero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCajero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCajero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCajero.Size = New System.Drawing.Size(279, 21)
        Me.cmbCajero.TabIndex = 1
        Me.cmbCajero.Tag = "OBLIGATORIO"
        Me.cmbCajero.PropBag = resources.GetString("cmbCajero.PropBag")
        '
        'lblCaja
        '
        Me.lblCaja.AutoSize = True
        Me.lblCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaja.Location = New System.Drawing.Point(462, 18)
        Me.lblCaja.Name = "lblCaja"
        Me.lblCaja.Size = New System.Drawing.Size(40, 13)
        Me.lblCaja.TabIndex = 7
        Me.lblCaja.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Tag = ""
        '
        'spnFaltante
        '
        Me.spnFaltante.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnFaltante.Location = New System.Drawing.Point(138, 122)
        Me.spnFaltante.Name = "spnFaltante"
        Me.spnFaltante.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnFaltante.Properties.Mask.EditMask = "n"
        Me.spnFaltante.Size = New System.Drawing.Size(100, 20)
        Me.spnFaltante.TabIndex = 5
        '
        'spnIngreso
        '
        Me.spnIngreso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spnIngreso.Enabled = False
        Me.spnIngreso.Location = New System.Drawing.Point(138, 96)
        Me.spnIngreso.Name = "spnIngreso"
        Me.spnIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnIngreso.Properties.Mask.EditMask = "c"
        Me.spnIngreso.Size = New System.Drawing.Size(100, 20)
        Me.spnIngreso.TabIndex = 3
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(138, 17)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Size = New System.Drawing.Size(177, 20)
        Me.dtFecha.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Tag = "OBLIGATORIO"
        '
        'txtAprobadoPor
        '
        Me.txtAprobadoPor.Location = New System.Drawing.Point(138, 70)
        Me.txtAprobadoPor.Name = "txtAprobadoPor"
        Me.txtAprobadoPor.Size = New System.Drawing.Size(279, 20)
        Me.txtAprobadoPor.TabIndex = 2
        Me.txtAprobadoPor.TabStop = False
        Me.txtAprobadoPor.Tag = "BLOQUEADO"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(11, 100)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(53, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Tag = ""
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(11, 73)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(87, 13)
        Me.lblSfaPromocionID.TabIndex = 0
        '
        'ErrorProv
        '
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSccConsultarDetalleArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 280)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSccConsultarDetalleArqueo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de recibos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetalleTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCajero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnFaltante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAprobadoPor As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents spnFaltante As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnIngreso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblCaja As System.Windows.Forms.Label
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbCajero As C1.Win.C1List.C1Combo
    Friend WithEvents grdDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdDetalleTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colAlumno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroRecibo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colTipoPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalRecibido As DevExpress.XtraGrid.Columns.GridColumn
End Class
