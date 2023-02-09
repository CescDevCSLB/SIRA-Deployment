<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraCapturarFoto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraCapturarFoto))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.VideoSourcePlayer1 = New AForge.Controls.VideoSourcePlayer()
        Me.cmdFoto = New System.Windows.Forms.Button()
        Me.cmdDetener = New System.Windows.Forms.Button()
        Me.cmdIniciar = New System.Windows.Forms.Button()
        Me.cmbDispositivos = New System.Windows.Forms.ComboBox()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.cmdFoto)
        Me.PanelControl1.Controls.Add(Me.cmdDetener)
        Me.PanelControl1.Controls.Add(Me.cmdIniciar)
        Me.PanelControl1.Controls.Add(Me.cmbDispositivos)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(310, 324)
        Me.PanelControl1.TabIndex = 98
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.VideoSourcePlayer1)
        Me.PanelControl2.Location = New System.Drawing.Point(30, 69)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(250, 200)
        Me.PanelControl2.TabIndex = 7
        '
        'VideoSourcePlayer1
        '
        Me.VideoSourcePlayer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoSourcePlayer1.Location = New System.Drawing.Point(2, 2)
        Me.VideoSourcePlayer1.Name = "VideoSourcePlayer1"
        Me.VideoSourcePlayer1.Size = New System.Drawing.Size(246, 196)
        Me.VideoSourcePlayer1.TabIndex = 0
        Me.VideoSourcePlayer1.Text = "VideoSourcePlayer2"
        Me.VideoSourcePlayer1.VideoSource = Nothing
        '
        'cmdFoto
        '
        Me.cmdFoto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFoto.ForeColor = System.Drawing.Color.Black
        Me.cmdFoto.Location = New System.Drawing.Point(192, 40)
        Me.cmdFoto.Name = "cmdFoto"
        Me.cmdFoto.Size = New System.Drawing.Size(75, 23)
        Me.cmdFoto.TabIndex = 3
        Me.cmdFoto.Text = "Foto"
        Me.cmdFoto.UseVisualStyleBackColor = True
        '
        'cmdDetener
        '
        Me.cmdDetener.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetener.ForeColor = System.Drawing.Color.Black
        Me.cmdDetener.Location = New System.Drawing.Point(111, 40)
        Me.cmdDetener.Name = "cmdDetener"
        Me.cmdDetener.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetener.TabIndex = 2
        Me.cmdDetener.Text = "Detener"
        Me.cmdDetener.UseVisualStyleBackColor = True
        '
        'cmdIniciar
        '
        Me.cmdIniciar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIniciar.ForeColor = System.Drawing.Color.Black
        Me.cmdIniciar.Location = New System.Drawing.Point(30, 40)
        Me.cmdIniciar.Name = "cmdIniciar"
        Me.cmdIniciar.Size = New System.Drawing.Size(75, 23)
        Me.cmdIniciar.TabIndex = 1
        Me.cmdIniciar.Text = "Iniciar"
        Me.cmdIniciar.UseVisualStyleBackColor = True
        '
        'cmbDispositivos
        '
        Me.cmbDispositivos.FormattingEnabled = True
        Me.cmbDispositivos.Location = New System.Drawing.Point(30, 13)
        Me.cmbDispositivos.Name = "cmbDispositivos"
        Me.cmbDispositivos.Size = New System.Drawing.Size(241, 21)
        Me.cmbDispositivos.TabIndex = 0
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = CType(resources.GetObject("cmdCancelar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdCancelar.Location = New System.Drawing.Point(209, 273)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 28)
        Me.cmdCancelar.TabIndex = 5
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = CType(resources.GetObject("cmdGuardar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdGuardar.Location = New System.Drawing.Point(121, 273)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(80, 28)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 21)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraCapturarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 324)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraCapturarFoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tomar foto"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdFoto As System.Windows.Forms.Button
    Friend WithEvents cmdDetener As System.Windows.Forms.Button
    Friend WithEvents cmdIniciar As System.Windows.Forms.Button
    Friend WithEvents cmbDispositivos As System.Windows.Forms.ComboBox
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents VideoSourcePlayer1 As AForge.Controls.VideoSourcePlayer
End Class
