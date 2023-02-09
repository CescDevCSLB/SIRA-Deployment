<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraGruposEditar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraGruposEditar))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmbModalidad = New C1.Win.C1List.C1Combo()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkCuantitativa = New System.Windows.Forms.CheckBox()
        Me.cmdAsignar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.chkCualitativa = New System.Windows.Forms.CheckBox()
        Me.cmbProfesor = New C1.Win.C1List.C1Combo()
        Me.cmbSeccion = New C1.Win.C1List.C1Combo()
        Me.cmbGrado = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.lblSfaPromocionID = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProfesor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSeccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblFechaIngreso)
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(703, 409)
        Me.PanelControl1.TabIndex = 98
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.ForeColor = System.Drawing.Color.Black
        Me.lblFechaIngreso.Location = New System.Drawing.Point(45, 332)
        Me.lblFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(116, 17)
        Me.lblFechaIngreso.TabIndex = 2
        Me.lblFechaIngreso.Text = "Fecha Ingreso:"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(581, 324)
        Me.cmdCancelar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdCancelar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(100, 34)
        Me.cmdCancelar.TabIndex = 1
        Me.cmdCancelar.Tag = "CANCELAR"
        Me.cmdCancelar.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(464, 324)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmbModalidad)
        Me.gbxDatosGenerales.Controls.Add(Me.Label9)
        Me.gbxDatosGenerales.Controls.Add(Me.chkCuantitativa)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdAsignar)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbPeriodo)
        Me.gbxDatosGenerales.Controls.Add(Me.chkCualitativa)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbProfesor)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbSeccion)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbGrado)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.chkActivo)
        Me.gbxDatosGenerales.Controls.Add(Me.lblSfaPromocionID)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(31, 15)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(648, 292)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'cmbModalidad
        '
        Me.cmbModalidad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbModalidad.AutoCompletion = True
        Me.cmbModalidad.AutoDropDown = True
        Me.cmbModalidad.Caption = ""
        Me.cmbModalidad.CaptionHeight = 17
        Me.cmbModalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbModalidad.ColumnCaptionHeight = 17
        Me.cmbModalidad.ColumnFooterHeight = 17
        Me.cmbModalidad.ContentHeight = 18
        Me.cmbModalidad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbModalidad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbModalidad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModalidad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbModalidad.EditorHeight = 18
        Me.cmbModalidad.Images.Add(CType(resources.GetObject("cmbModalidad.Images"), System.Drawing.Image))
        Me.cmbModalidad.ItemHeight = 15
        Me.cmbModalidad.Location = New System.Drawing.Point(179, 128)
        Me.cmbModalidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbModalidad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbModalidad.MaxDropDownItems = CType(5, Short)
        Me.cmbModalidad.MaxLength = 32767
        Me.cmbModalidad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbModalidad.Name = "cmbModalidad"
        Me.cmbModalidad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbModalidad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbModalidad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbModalidad.Size = New System.Drawing.Size(231, 24)
        Me.cmbModalidad.TabIndex = 5
        Me.cmbModalidad.Tag = "OBLIGATORIO"
        Me.cmbModalidad.PropBag = resources.GetString("cmbModalidad.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 138)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Modalidad:"
        '
        'chkCuantitativa
        '
        Me.chkCuantitativa.AutoSize = True
        Me.chkCuantitativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCuantitativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCuantitativa.ForeColor = System.Drawing.Color.Black
        Me.chkCuantitativa.Location = New System.Drawing.Point(8, 223)
        Me.chkCuantitativa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCuantitativa.Name = "chkCuantitativa"
        Me.chkCuantitativa.Size = New System.Drawing.Size(200, 21)
        Me.chkCuantitativa.TabIndex = 7
        Me.chkCuantitativa.Text = "Evaluacion Cuantitativa"
        Me.chkCuantitativa.UseVisualStyleBackColor = True
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAsignar.Appearance.Options.UseFont = True
        Me.cmdAsignar.ImageOptions.Image = CType(resources.GetObject("cmdAsignar.ImageOptions.Image"), System.Drawing.Image)
        Me.cmdAsignar.Location = New System.Drawing.Point(529, 22)
        Me.cmdAsignar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAsignar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAsignar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(32, 28)
        Me.cmdAsignar.TabIndex = 2
        Me.cmdAsignar.Tag = "AGREGAR"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPeriodo.AutoCompletion = True
        Me.cmbPeriodo.AutoDropDown = True
        Me.cmbPeriodo.Caption = ""
        Me.cmbPeriodo.CaptionHeight = 17
        Me.cmbPeriodo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPeriodo.ColumnCaptionHeight = 17
        Me.cmbPeriodo.ColumnFooterHeight = 17
        Me.cmbPeriodo.ContentHeight = 18
        Me.cmbPeriodo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPeriodo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPeriodo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPeriodo.EditorHeight = 18
        Me.cmbPeriodo.Images.Add(CType(resources.GetObject("cmbPeriodo.Images"), System.Drawing.Image))
        Me.cmbPeriodo.ItemHeight = 15
        Me.cmbPeriodo.Location = New System.Drawing.Point(179, 25)
        Me.cmbPeriodo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPeriodo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPeriodo.MaxDropDownItems = CType(5, Short)
        Me.cmbPeriodo.MaxLength = 32767
        Me.cmbPeriodo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPeriodo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPeriodo.Size = New System.Drawing.Size(205, 24)
        Me.cmbPeriodo.TabIndex = 0
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'chkCualitativa
        '
        Me.chkCualitativa.AutoSize = True
        Me.chkCualitativa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCualitativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCualitativa.ForeColor = System.Drawing.Color.Black
        Me.chkCualitativa.Location = New System.Drawing.Point(9, 251)
        Me.chkCualitativa.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCualitativa.Name = "chkCualitativa"
        Me.chkCualitativa.Size = New System.Drawing.Size(198, 21)
        Me.chkCualitativa.TabIndex = 8
        Me.chkCualitativa.Text = "Evaluacion Cualitativas"
        Me.chkCualitativa.UseVisualStyleBackColor = True
        '
        'cmbProfesor
        '
        Me.cmbProfesor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProfesor.AutoCompletion = True
        Me.cmbProfesor.AutoDropDown = True
        Me.cmbProfesor.Caption = ""
        Me.cmbProfesor.CaptionHeight = 17
        Me.cmbProfesor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProfesor.ColumnCaptionHeight = 17
        Me.cmbProfesor.ColumnFooterHeight = 17
        Me.cmbProfesor.ContentHeight = 18
        Me.cmbProfesor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProfesor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProfesor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProfesor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProfesor.EditorHeight = 18
        Me.cmbProfesor.Images.Add(CType(resources.GetObject("cmbProfesor.Images"), System.Drawing.Image))
        Me.cmbProfesor.ItemHeight = 15
        Me.cmbProfesor.Location = New System.Drawing.Point(179, 161)
        Me.cmbProfesor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProfesor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProfesor.MaxDropDownItems = CType(5, Short)
        Me.cmbProfesor.MaxLength = 32767
        Me.cmbProfesor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProfesor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProfesor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProfesor.Size = New System.Drawing.Size(405, 24)
        Me.cmbProfesor.TabIndex = 6
        Me.cmbProfesor.Tag = "OBLIGATORIO"
        Me.cmbProfesor.PropBag = resources.GetString("cmbProfesor.PropBag")
        '
        'cmbSeccion
        '
        Me.cmbSeccion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSeccion.AutoCompletion = True
        Me.cmbSeccion.AutoDropDown = True
        Me.cmbSeccion.Caption = ""
        Me.cmbSeccion.CaptionHeight = 17
        Me.cmbSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSeccion.ColumnCaptionHeight = 17
        Me.cmbSeccion.ColumnFooterHeight = 17
        Me.cmbSeccion.ContentHeight = 18
        Me.cmbSeccion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSeccion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSeccion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSeccion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSeccion.EditorHeight = 18
        Me.cmbSeccion.Images.Add(CType(resources.GetObject("cmbSeccion.Images"), System.Drawing.Image))
        Me.cmbSeccion.ItemHeight = 15
        Me.cmbSeccion.Location = New System.Drawing.Point(179, 95)
        Me.cmbSeccion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSeccion.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSeccion.MaxDropDownItems = CType(5, Short)
        Me.cmbSeccion.MaxLength = 32767
        Me.cmbSeccion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSeccion.Name = "cmbSeccion"
        Me.cmbSeccion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSeccion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSeccion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSeccion.Size = New System.Drawing.Size(205, 24)
        Me.cmbSeccion.TabIndex = 4
        Me.cmbSeccion.Tag = "OBLIGATORIO"
        Me.cmbSeccion.PropBag = resources.GetString("cmbSeccion.PropBag")
        '
        'cmbGrado
        '
        Me.cmbGrado.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGrado.AutoCompletion = True
        Me.cmbGrado.AutoDropDown = True
        Me.cmbGrado.Caption = ""
        Me.cmbGrado.CaptionHeight = 17
        Me.cmbGrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGrado.ColumnCaptionHeight = 17
        Me.cmbGrado.ColumnFooterHeight = 17
        Me.cmbGrado.ContentHeight = 18
        Me.cmbGrado.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGrado.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGrado.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGrado.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGrado.EditorHeight = 18
        Me.cmbGrado.Images.Add(CType(resources.GetObject("cmbGrado.Images"), System.Drawing.Image))
        Me.cmbGrado.ItemHeight = 15
        Me.cmbGrado.Location = New System.Drawing.Point(179, 62)
        Me.cmbGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGrado.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGrado.MaxDropDownItems = CType(5, Short)
        Me.cmbGrado.MaxLength = 32767
        Me.cmbGrado.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGrado.Name = "cmbGrado"
        Me.cmbGrado.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGrado.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGrado.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGrado.Size = New System.Drawing.Size(205, 24)
        Me.cmbGrado.TabIndex = 3
        Me.cmbGrado.Tag = "OBLIGATORIO"
        Me.cmbGrado.PropBag = resources.GetString("cmbGrado.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Período:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Mestro guía:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Grado:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(415, 25)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 1
        Me.chkActivo.Text = "Activa"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'lblSfaPromocionID
        '
        Me.lblSfaPromocionID.AutoSize = True
        Me.lblSfaPromocionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSfaPromocionID.ForeColor = System.Drawing.Color.Black
        Me.lblSfaPromocionID.Location = New System.Drawing.Point(8, 98)
        Me.lblSfaPromocionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSfaPromocionID.Name = "lblSfaPromocionID"
        Me.lblSfaPromocionID.Size = New System.Drawing.Size(70, 17)
        Me.lblSfaPromocionID.TabIndex = 0
        Me.lblSfaPromocionID.Text = "Sección:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 383)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(703, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraGruposEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 409)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraGruposEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar grupo"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProfesor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSeccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gbxDatosGenerales As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents lblSfaPromocionID As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorProv As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProfesor As C1.Win.C1List.C1Combo
    Friend WithEvents cmbSeccion As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGrado As C1.Win.C1List.C1Combo
    Friend WithEvents chkCualitativa As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents cmdAsignar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkCuantitativa As System.Windows.Forms.CheckBox
    Friend WithEvents cmbModalidad As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
