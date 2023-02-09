<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSraSeleccionarParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSraSeleccionarParametros))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.spnDesde = New DevExpress.XtraEditors.SpinEdit()
        Me.spnHasta = New DevExpress.XtraEditors.SpinEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbNotaFinal = New System.Windows.Forms.RadioButton()
        Me.rbSemestre = New System.Windows.Forms.RadioButton()
        Me.rbParcial = New System.Windows.Forms.RadioButton()
        Me.cmbBusqueda = New DevExpress.XtraEditors.LookUpEdit()
        Me.gbxDatosGenerales = New System.Windows.Forms.GroupBox()
        Me.cmdAlumno = New System.Windows.Forms.Button()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.chkTodosGrupos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuia = New System.Windows.Forms.TextBox()
        Me.txtGrado = New System.Windows.Forms.TextBox()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblModeloCompatible = New System.Windows.Forms.Label()
        Me.cmbModalidad = New C1.Win.C1List.C1Combo()
        Me.lblModalidad = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProv = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.spnDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBusqueda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDatosGenerales.SuspendLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cmdCancelar)
        Me.PanelControl1.Controls.Add(Me.cmdGuardar)
        Me.PanelControl1.Controls.Add(Me.spnDesde)
        Me.PanelControl1.Controls.Add(Me.spnHasta)
        Me.PanelControl1.Controls.Add(Me.Label6)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.rbNotaFinal)
        Me.PanelControl1.Controls.Add(Me.rbSemestre)
        Me.PanelControl1.Controls.Add(Me.rbParcial)
        Me.PanelControl1.Controls.Add(Me.cmbBusqueda)
        Me.PanelControl1.Controls.Add(Me.gbxDatosGenerales)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(636, 396)
        Me.PanelControl1.TabIndex = 98
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelar.Appearance.Options.UseFont = True
        Me.cmdCancelar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.cmdCancelar.Location = New System.Drawing.Point(514, 309)
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
        Me.cmdGuardar.Location = New System.Drawing.Point(397, 309)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Aceptar"
        '
        'spnDesde
        '
        Me.spnDesde.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnDesde.Location = New System.Drawing.Point(109, 334)
        Me.spnDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.spnDesde.Name = "spnDesde"
        Me.spnDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnDesde.Properties.IsFloatValue = False
        Me.spnDesde.Properties.Mask.EditMask = "N00"
        Me.spnDesde.Size = New System.Drawing.Size(133, 22)
        Me.spnDesde.TabIndex = 158
        Me.spnDesde.Visible = False
        '
        'spnHasta
        '
        Me.spnHasta.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.spnHasta.Location = New System.Drawing.Point(351, 334)
        Me.spnHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.spnHasta.Name = "spnHasta"
        Me.spnHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spnHasta.Properties.IsFloatValue = False
        Me.spnHasta.Properties.Mask.EditMask = "N00"
        Me.spnHasta.Size = New System.Drawing.Size(133, 22)
        Me.spnHasta.TabIndex = 157
        Me.spnHasta.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 299)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 22)
        Me.Label6.TabIndex = 156
        Me.Label6.Tag = ""
        Me.Label6.Text = "Impresión parcial:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 334)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 22)
        Me.Label5.TabIndex = 155
        Me.Label5.Tag = ""
        Me.Label5.Text = "Hasta:"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 335)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 22)
        Me.Label4.TabIndex = 154
        Me.Label4.Tag = ""
        Me.Label4.Text = "Desde:"
        Me.Label4.Visible = False
        '
        'rbNotaFinal
        '
        Me.rbNotaFinal.AutoSize = True
        Me.rbNotaFinal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNotaFinal.ForeColor = System.Drawing.Color.Black
        Me.rbNotaFinal.Location = New System.Drawing.Point(284, 245)
        Me.rbNotaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNotaFinal.Name = "rbNotaFinal"
        Me.rbNotaFinal.Size = New System.Drawing.Size(98, 21)
        Me.rbNotaFinal.TabIndex = 7
        Me.rbNotaFinal.Text = "Nota Final"
        Me.rbNotaFinal.UseVisualStyleBackColor = True
        '
        'rbSemestre
        '
        Me.rbSemestre.AutoSize = True
        Me.rbSemestre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSemestre.ForeColor = System.Drawing.Color.Black
        Me.rbSemestre.Location = New System.Drawing.Point(159, 243)
        Me.rbSemestre.Margin = New System.Windows.Forms.Padding(4)
        Me.rbSemestre.Name = "rbSemestre"
        Me.rbSemestre.Size = New System.Drawing.Size(97, 21)
        Me.rbSemestre.TabIndex = 6
        Me.rbSemestre.Text = "Semestral"
        Me.rbSemestre.UseVisualStyleBackColor = True
        '
        'rbParcial
        '
        Me.rbParcial.AutoSize = True
        Me.rbParcial.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbParcial.ForeColor = System.Drawing.Color.Black
        Me.rbParcial.Location = New System.Drawing.Point(36, 242)
        Me.rbParcial.Margin = New System.Windows.Forms.Padding(4)
        Me.rbParcial.Name = "rbParcial"
        Me.rbParcial.Size = New System.Drawing.Size(73, 21)
        Me.rbParcial.TabIndex = 5
        Me.rbParcial.Text = "Parcial"
        Me.rbParcial.UseVisualStyleBackColor = True
        '
        'cmbBusqueda
        '
        Me.cmbBusqueda.Location = New System.Drawing.Point(52, 268)
        Me.cmbBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBusqueda.Name = "cmbBusqueda"
        Me.cmbBusqueda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbBusqueda.Properties.NullText = ""
        Me.cmbBusqueda.Size = New System.Drawing.Size(337, 22)
        Me.cmbBusqueda.TabIndex = 8
        '
        'gbxDatosGenerales
        '
        Me.gbxDatosGenerales.Controls.Add(Me.cmdAlumno)
        Me.gbxDatosGenerales.Controls.Add(Me.txtAlumno)
        Me.gbxDatosGenerales.Controls.Add(Me.chkTodosGrupos)
        Me.gbxDatosGenerales.Controls.Add(Me.Label2)
        Me.gbxDatosGenerales.Controls.Add(Me.txtGuia)
        Me.gbxDatosGenerales.Controls.Add(Me.txtGrado)
        Me.gbxDatosGenerales.Controls.Add(Me.cmdBuscar)
        Me.gbxDatosGenerales.Controls.Add(Me.Label1)
        Me.gbxDatosGenerales.Controls.Add(Me.lblModeloCompatible)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbModalidad)
        Me.gbxDatosGenerales.Controls.Add(Me.lblModalidad)
        Me.gbxDatosGenerales.Controls.Add(Me.cmbPeriodo)
        Me.gbxDatosGenerales.Controls.Add(Me.Label3)
        Me.gbxDatosGenerales.Location = New System.Drawing.Point(16, 5)
        Me.gbxDatosGenerales.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Name = "gbxDatosGenerales"
        Me.gbxDatosGenerales.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxDatosGenerales.Size = New System.Drawing.Size(604, 223)
        Me.gbxDatosGenerales.TabIndex = 1
        Me.gbxDatosGenerales.TabStop = False
        '
        'cmdAlumno
        '
        Me.cmdAlumno.Location = New System.Drawing.Point(543, 122)
        Me.cmdAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAlumno.Name = "cmdAlumno"
        Me.cmdAlumno.Size = New System.Drawing.Size(32, 28)
        Me.cmdAlumno.TabIndex = 3
        Me.cmdAlumno.Tag = "Buscar Existente"
        Me.cmdAlumno.Text = "..."
        Me.cmdAlumno.UseVisualStyleBackColor = True
        '
        'txtAlumno
        '
        Me.txtAlumno.Enabled = False
        Me.txtAlumno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlumno.Location = New System.Drawing.Point(179, 124)
        Me.txtAlumno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(352, 23)
        Me.txtAlumno.TabIndex = 2
        Me.txtAlumno.Tag = "OBLIGATORIO"
        '
        'chkTodosGrupos
        '
        Me.chkTodosGrupos.AutoSize = True
        Me.chkTodosGrupos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTodosGrupos.Location = New System.Drawing.Point(20, 92)
        Me.chkTodosGrupos.Margin = New System.Windows.Forms.Padding(4)
        Me.chkTodosGrupos.Name = "chkTodosGrupos"
        Me.chkTodosGrupos.Size = New System.Drawing.Size(134, 21)
        Me.chkTodosGrupos.TabIndex = 159
        Me.chkTodosGrupos.Text = "Imprimir todos"
        Me.chkTodosGrupos.UseVisualStyleBackColor = True
        Me.chkTodosGrupos.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 192)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 22)
        Me.Label2.TabIndex = 158
        Me.Label2.Tag = ""
        Me.Label2.Text = "Guía:"
        '
        'txtGuia
        '
        Me.txtGuia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuia.Location = New System.Drawing.Point(179, 188)
        Me.txtGuia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGuia.Name = "txtGuia"
        Me.txtGuia.ReadOnly = True
        Me.txtGuia.Size = New System.Drawing.Size(352, 23)
        Me.txtGuia.TabIndex = 6
        Me.txtGuia.Tag = "OBLIGATORIO"
        '
        'txtGrado
        '
        Me.txtGrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrado.Location = New System.Drawing.Point(179, 156)
        Me.txtGrado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrado.Name = "txtGrado"
        Me.txtGrado.ReadOnly = True
        Me.txtGrado.Size = New System.Drawing.Size(352, 23)
        Me.txtGrado.TabIndex = 4
        Me.txtGrado.Tag = "OBLIGATORIO"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(543, 154)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 5
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 153
        Me.Label1.Tag = ""
        Me.Label1.Text = "Grupo:"
        '
        'lblModeloCompatible
        '
        Me.lblModeloCompatible.BackColor = System.Drawing.Color.Transparent
        Me.lblModeloCompatible.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModeloCompatible.Location = New System.Drawing.Point(16, 128)
        Me.lblModeloCompatible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModeloCompatible.Name = "lblModeloCompatible"
        Me.lblModeloCompatible.Size = New System.Drawing.Size(137, 22)
        Me.lblModeloCompatible.TabIndex = 152
        Me.lblModeloCompatible.Tag = ""
        Me.lblModeloCompatible.Text = "Alumno:"
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
        Me.cmbModalidad.Location = New System.Drawing.Point(179, 58)
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
        Me.cmbModalidad.TabIndex = 1
        Me.cmbModalidad.Tag = "OBLIGATORIO"
        Me.cmbModalidad.PropBag = resources.GetString("cmbModalidad.PropBag")
        '
        'lblModalidad
        '
        Me.lblModalidad.AutoSize = True
        Me.lblModalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModalidad.Location = New System.Drawing.Point(17, 63)
        Me.lblModalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModalidad.Name = "lblModalidad"
        Me.lblModalidad.Size = New System.Drawing.Size(87, 17)
        Me.lblModalidad.TabIndex = 119
        Me.lblModalidad.Text = "Modalidad:"
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
        Me.cmbPeriodo.Size = New System.Drawing.Size(231, 24)
        Me.cmbPeriodo.TabIndex = 0
        Me.cmbPeriodo.Tag = "OBLIGATORIO"
        Me.cmbPeriodo.PropBag = resources.GetString("cmbPeriodo.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Período:"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 370)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(636, 26)
        Me.Panel1.TabIndex = 99
        '
        'ErrorProv
        '
        Me.ErrorProv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrorProv.ContainerControl = Me
        '
        'frmSraSeleccionarParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSraSeleccionarParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar parámetros"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.spnDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBusqueda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDatosGenerales.ResumeLayout(False)
        Me.gbxDatosGenerales.PerformLayout()
        CType(Me.cmbModalidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbPeriodo As C1.Win.C1List.C1Combo
    Friend WithEvents cmbModalidad As C1.Win.C1List.C1Combo
    Friend WithEvents lblModalidad As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGuia As System.Windows.Forms.TextBox
    Friend WithEvents txtGrado As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblModeloCompatible As System.Windows.Forms.Label
    Friend WithEvents chkTodosGrupos As System.Windows.Forms.CheckBox
    Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
    Friend WithEvents cmdAlumno As System.Windows.Forms.Button
    Friend WithEvents rbNotaFinal As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemestre As System.Windows.Forms.RadioButton
    Friend WithEvents rbParcial As System.Windows.Forms.RadioButton
    Friend WithEvents cmbBusqueda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents spnDesde As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents spnHasta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
