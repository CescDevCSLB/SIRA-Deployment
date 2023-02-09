<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScontRptBalanzaComprobacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScontRptBalanzaComprobacion))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.cmbNivel = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dpHasta = New DevExpress.XtraEditors.DateEdit()
        Me.dpDesde = New DevExpress.XtraEditors.DateEdit()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(716, 182)
        Me.PanelControl1.TabIndex = 98
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.chkTodos)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbNivel)
        Me.gbxDatosGenerales.Controls.Add(Me.Label9)
        Me.gbxDatosGenerales.Controls.Add(Me.dpHasta)
        Me.gbxDatosGenerales.Controls.Add(Me.dpDesde)
        Me.gbxDatosGenerales.Controls.Add(Me.lblFechaNacimiento)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdCancelar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdGuardar)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 6)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(684, 138)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodos.Location = New System.Drawing.Point(229, 113)
        Me.chkTodos.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(146, 21)
        Me.chkTodos.TabIndex = 174
        Me.chkTodos.Text = "Todos los niveles"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'cmbNivel
        '
        Me.cmbNivel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbNivel.AutoCompletion = True
        Me.cmbNivel.AutoDropDown = True
        Me.cmbNivel.Caption = ""
        Me.cmbNivel.CaptionHeight = 17
        Me.cmbNivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbNivel.ColumnCaptionHeight = 17
        Me.cmbNivel.ColumnFooterHeight = 17
        Me.cmbNivel.ContentHeight = 18
        Me.cmbNivel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbNivel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbNivel.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNivel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbNivel.EditorHeight = 18
        Me.cmbNivel.Images.Add(CType(resources.GetObject("cmbNivel.Images"), System.Drawing.Image))
        Me.cmbNivel.ItemHeight = 15
        Me.cmbNivel.Location = New System.Drawing.Point(228, 80)
        Me.cmbNivel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNivel.MatchEntryTimeout = CType(2000, Long)
        Me.cmbNivel.MaxDropDownItems = CType(5, Short)
        Me.cmbNivel.MaxLength = 32767
        Me.cmbNivel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbNivel.Name = "cmbNivel"
        Me.cmbNivel.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbNivel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbNivel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbNivel.Size = New System.Drawing.Size(243, 24)
        Me.cmbNivel.TabIndex = 173
        Me.cmbNivel.Tag = "OBLIGATORIO"
        Me.cmbNivel.PropBag = resources.GetString("cmbNivel.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 85)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 17)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "Nivel de las cuentas:"
        '
        'dpHasta
        '
        Me.dpHasta.EditValue = Nothing
        Me.dpHasta.Location = New System.Drawing.Point(229, 48)
        Me.dpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dpHasta.Name = "dpHasta"
        Me.dpHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpHasta.Size = New System.Drawing.Size(241, 22)
        Me.dpHasta.TabIndex = 171
        '
        'dpDesde
        '
        Me.dpDesde.EditValue = Nothing
        Me.dpDesde.Location = New System.Drawing.Point(229, 16)
        Me.dpDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dpDesde.Name = "dpDesde"
        Me.dpDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDesde.Size = New System.Drawing.Size(241, 22)
        Me.dpDesde.TabIndex = 170
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(52, 52)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(55, 17)
        Me.lblFechaNacimiento.TabIndex = 168
        Me.lblFechaNacimiento.Text = "Hasta:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(541, 62)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(107, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(541, 20)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Desde:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 156)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmScontRptBalanzaComprobacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 182)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScontRptBalanzaComprobacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar parámetros"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents dpHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dpDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbNivel As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As Label
    Friend WithEvents chkTodos As CheckBox
End Class
