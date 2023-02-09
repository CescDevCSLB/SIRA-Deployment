<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStbAlumnosEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStbAlumnosEdit))
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.TabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
        Me.TabEnfermedades = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.cmdNuevaEnfermedad = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbEnfermedad = New C1.Win.C1List.C1Combo()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cmdAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.grdEnfermedades = New DevExpress.XtraGrid.GridControl()
        Me.grdEnfermedadesTabla = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colobjEnfermedadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabObservaciones = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtEspera = New System.Windows.Forms.TextBox()
        Me.txtImportancia = New System.Windows.Forms.TextBox()
        Me.txtCausa = New System.Windows.Forms.TextBox()
        Me.txtInformacion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPadre = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtNivelAcademicoP = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cmbEstadoCivilP = New C1.Win.C1List.C1Combo()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.chkExtranjero = New System.Windows.Forms.CheckBox()
        Me.txtDireccionPadre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tabAdicionales = New System.Windows.Forms.TabControl()
        Me.tabContactos = New System.Windows.Forms.TabPage()
        Me.tdbContactosPadre = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.barContactos = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContacto = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContacto = New System.Windows.Forms.ToolStripButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCedulaPadre = New System.Windows.Forms.MaskedTextBox()
        Me.txtLugarTrabajoPadre = New System.Windows.Forms.TextBox()
        Me.txtOcupacionPadre = New System.Windows.Forms.TextBox()
        Me.txtProfesionPadre = New System.Windows.Forms.TextBox()
        Me.cmbReligionPadre = New C1.Win.C1List.C1Combo()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdBuscarPadre = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtApellido2Padre = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtApellido1Padre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombre2Padre = New System.Windows.Forms.TextBox()
        Me.txtNombre1Padre = New System.Windows.Forms.TextBox()
        Me.TabMadre = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtNivelAcademicoM = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cmbEstadoCivilM = New C1.Win.C1List.C1Combo()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.chkExtrajeneroM = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tdbContactosMadre = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContactoM = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContactoM = New System.Windows.Forms.ToolStripButton()
        Me.txtDireccionMadre = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCedulaMadre = New System.Windows.Forms.MaskedTextBox()
        Me.txtLugarTrabajoMadre = New System.Windows.Forms.TextBox()
        Me.txtOcupacionMadre = New System.Windows.Forms.TextBox()
        Me.txtProfesionMadre = New System.Windows.Forms.TextBox()
        Me.cmbReligionMadre = New C1.Win.C1List.C1Combo()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmdBuscarMadre = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtApellido2Madre = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtApellido1Madre = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNombre2Madre = New System.Windows.Forms.TextBox()
        Me.txtNombre1Madre = New System.Windows.Forms.TextBox()
        Me.TabResponsable = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.txtNivelAcademicoR = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cmbEstadoCivilR = New C1.Win.C1List.C1Combo()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.chkExtrajenjeroR = New System.Windows.Forms.CheckBox()
        Me.cmbParentesco = New C1.Win.C1List.C1Combo()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tdbContactosResponsable = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdAgregarContactoR = New System.Windows.Forms.ToolStrip()
        Me.cmdAgregarContactoResp = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminarContactoR = New System.Windows.Forms.ToolStripButton()
        Me.txtDireccionResponsable = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCedulaResponsable = New System.Windows.Forms.MaskedTextBox()
        Me.txtLugarTrabajoResponsable = New System.Windows.Forms.TextBox()
        Me.txtOcupacionResponsable = New System.Windows.Forms.TextBox()
        Me.txtProfesionResponsable = New System.Windows.Forms.TextBox()
        Me.cmbReligionResponsable = New C1.Win.C1List.C1Combo()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cmdBuscarResponsable = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtApellido2Responsable = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtApellido1Responsable = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtNombre2Responsable = New System.Windows.Forms.TextBox()
        Me.txtNombre1Responsable = New System.Windows.Forms.TextBox()
        Me.grpPersonaNatural = New System.Windows.Forms.GroupBox()
        Me.txtLugarNacimiento = New System.Windows.Forms.TextBox()
        Me.chkAlumnoExtranjero = New System.Windows.Forms.CheckBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.cmbResposable = New C1.Win.C1List.C1Combo()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCodigoMined = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLugarNacimiento = New C1.Win.C1List.C1Combo()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.cmbReligion = New C1.Win.C1List.C1Combo()
        Me.cmbciudad = New C1.Win.C1List.C1Combo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbGenero = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaNacimiento = New C1.Win.C1Input.C1DateEdit()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblPrimerNombre = New System.Windows.Forms.Label()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.ErrPrv = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ArchivoDialogo = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelcliente = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.grpDatos.SuspendLayout()
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane1.SuspendLayout()
        Me.TabEnfermedades.SuspendLayout()
        CType(Me.cmbEnfermedad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdEnfermedadesTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabObservaciones.SuspendLayout()
        Me.TabPadre.SuspendLayout()
        CType(Me.cmbEstadoCivilP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tabAdicionales.SuspendLayout()
        Me.tabContactos.SuspendLayout()
        CType(Me.tdbContactosPadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barContactos.SuspendLayout()
        CType(Me.cmbReligionPadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMadre.SuspendLayout()
        CType(Me.cmbEstadoCivilM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tdbContactosMadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.cmbReligionMadre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResponsable.SuspendLayout()
        CType(Me.cmbEstadoCivilR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbParentesco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.tdbContactosResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmdAgregarContactoR.SuspendLayout()
        CType(Me.cmbReligionResponsable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonaNatural.SuspendLayout()
        CType(Me.cmbResposable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLugarNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReligion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelcliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.TabPane1)
        Me.grpDatos.Controls.Add(Me.grpPersonaNatural)
        Me.grpDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatos.Location = New System.Drawing.Point(7, 6)
        Me.grpDatos.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDatos.Size = New System.Drawing.Size(1247, 681)
        Me.grpDatos.TabIndex = 0
        Me.grpDatos.TabStop = False
        '
        'TabPane1
        '
        Me.TabPane1.Controls.Add(Me.TabEnfermedades)
        Me.TabPane1.Controls.Add(Me.TabObservaciones)
        Me.TabPane1.Controls.Add(Me.TabPadre)
        Me.TabPane1.Controls.Add(Me.TabMadre)
        Me.TabPane1.Controls.Add(Me.TabResponsable)
        Me.TabPane1.Location = New System.Drawing.Point(15, 290)
        Me.TabPane1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPane1.Name = "TabPane1"
        Me.TabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.TabPadre, Me.TabMadre, Me.TabResponsable, Me.TabEnfermedades, Me.TabObservaciones})
        Me.TabPane1.RegularSize = New System.Drawing.Size(1208, 390)
        Me.TabPane1.SelectedPage = Me.TabPadre
        Me.TabPane1.Size = New System.Drawing.Size(1208, 390)
        Me.TabPane1.TabIndex = 0
        Me.TabPane1.Text = "TabPane1"
        '
        'TabEnfermedades
        '
        Me.TabEnfermedades.Caption = "Enfermedades"
        Me.TabEnfermedades.Controls.Add(Me.cmdNuevaEnfermedad)
        Me.TabEnfermedades.Controls.Add(Me.cmbEnfermedad)
        Me.TabEnfermedades.Controls.Add(Me.lblMarca)
        Me.TabEnfermedades.Controls.Add(Me.cmdAgregar)
        Me.TabEnfermedades.Controls.Add(Me.grdEnfermedades)
        Me.TabEnfermedades.Margin = New System.Windows.Forms.Padding(4)
        Me.TabEnfermedades.Name = "TabEnfermedades"
        Me.TabEnfermedades.Size = New System.Drawing.Size(1184, 308)
        '
        'cmdNuevaEnfermedad
        '
        Me.cmdNuevaEnfermedad.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNuevaEnfermedad.Appearance.Options.UseFont = True
        Me.cmdNuevaEnfermedad.Location = New System.Drawing.Point(463, 15)
        Me.cmdNuevaEnfermedad.LookAndFeel.SkinName = "Caramel"
        Me.cmdNuevaEnfermedad.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdNuevaEnfermedad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNuevaEnfermedad.Name = "cmdNuevaEnfermedad"
        Me.cmdNuevaEnfermedad.Size = New System.Drawing.Size(43, 34)
        Me.cmdNuevaEnfermedad.TabIndex = 1
        Me.cmdNuevaEnfermedad.Tag = "AGREGAR"
        '
        'cmbEnfermedad
        '
        Me.cmbEnfermedad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEnfermedad.AutoCompletion = True
        Me.cmbEnfermedad.AutoDropDown = True
        Me.cmbEnfermedad.Caption = ""
        Me.cmbEnfermedad.CaptionHeight = 17
        Me.cmbEnfermedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEnfermedad.ColumnCaptionHeight = 17
        Me.cmbEnfermedad.ColumnFooterHeight = 17
        Me.cmbEnfermedad.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbEnfermedad.ContentHeight = 18
        Me.cmbEnfermedad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEnfermedad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEnfermedad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEnfermedad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEnfermedad.EditorHeight = 18
        Me.cmbEnfermedad.Images.Add(CType(resources.GetObject("cmbEnfermedad.Images"), System.Drawing.Image))
        Me.cmbEnfermedad.ItemHeight = 15
        Me.cmbEnfermedad.Location = New System.Drawing.Point(141, 20)
        Me.cmbEnfermedad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEnfermedad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEnfermedad.MaxDropDownItems = CType(5, Short)
        Me.cmbEnfermedad.MaxLength = 32767
        Me.cmbEnfermedad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEnfermedad.Name = "cmbEnfermedad"
        Me.cmbEnfermedad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEnfermedad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEnfermedad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEnfermedad.Size = New System.Drawing.Size(313, 24)
        Me.cmbEnfermedad.TabIndex = 4
        Me.cmbEnfermedad.Tag = "OBLIGATORIO"
        Me.cmbEnfermedad.PropBag = resources.GetString("cmbEnfermedad.PropBag")
        '
        'lblMarca
        '
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.Color.Black
        Me.lblMarca.Location = New System.Drawing.Point(16, 23)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(109, 22)
        Me.lblMarca.TabIndex = 103
        Me.lblMarca.Tag = ""
        Me.lblMarca.Text = "Enfermedad:"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.Appearance.Options.UseFont = True
        Me.cmdAgregar.Location = New System.Drawing.Point(527, 49)
        Me.cmdAgregar.LookAndFeel.SkinName = "Caramel"
        Me.cmdAgregar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(43, 34)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Tag = "AGREGAR"
        '
        'grdEnfermedades
        '
        Me.grdEnfermedades.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEnfermedades.Location = New System.Drawing.Point(9, 91)
        Me.grdEnfermedades.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grdEnfermedades.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grdEnfermedades.MainView = Me.grdEnfermedadesTabla
        Me.grdEnfermedades.Margin = New System.Windows.Forms.Padding(4)
        Me.grdEnfermedades.Name = "grdEnfermedades"
        Me.grdEnfermedades.Size = New System.Drawing.Size(572, 196)
        Me.grdEnfermedades.TabIndex = 3
        Me.grdEnfermedades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdEnfermedadesTabla})
        '
        'grdEnfermedadesTabla
        '
        Me.grdEnfermedadesTabla.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colobjEnfermedadID, Me.colNombre})
        Me.grdEnfermedadesTabla.GridControl = Me.grdEnfermedades
        Me.grdEnfermedadesTabla.Name = "grdEnfermedadesTabla"
        Me.grdEnfermedadesTabla.OptionsView.ShowGroupPanel = False
        '
        'colobjEnfermedadID
        '
        Me.colobjEnfermedadID.Caption = "EnfermedadID"
        Me.colobjEnfermedadID.FieldName = "objEnfermedadID"
        Me.colobjEnfermedadID.Name = "colobjEnfermedadID"
        Me.colobjEnfermedadID.Width = 76
        '
        'colNombre
        '
        Me.colNombre.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNombre.AppearanceHeader.Options.UseFont = True
        Me.colNombre.AppearanceHeader.Options.UseTextOptions = True
        Me.colNombre.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Enfermedad"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colNombre.OptionsFilter.AllowAutoFilter = False
        Me.colNombre.OptionsFilter.AllowFilter = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 183
        '
        'TabObservaciones
        '
        Me.TabObservaciones.Caption = "Observaciones"
        Me.TabObservaciones.Controls.Add(Me.txtObservaciones)
        Me.TabObservaciones.Controls.Add(Me.txtEspera)
        Me.TabObservaciones.Controls.Add(Me.txtImportancia)
        Me.TabObservaciones.Controls.Add(Me.txtCausa)
        Me.TabObservaciones.Controls.Add(Me.txtInformacion)
        Me.TabObservaciones.Controls.Add(Me.Label11)
        Me.TabObservaciones.Controls.Add(Me.Label6)
        Me.TabObservaciones.Controls.Add(Me.Label10)
        Me.TabObservaciones.Controls.Add(Me.Label7)
        Me.TabObservaciones.Controls.Add(Me.Label8)
        Me.TabObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.TabObservaciones.Name = "TabObservaciones"
        Me.TabObservaciones.Size = New System.Drawing.Size(1184, 308)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(808, 113)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(297, 47)
        Me.txtObservaciones.TabIndex = 4
        '
        'txtEspera
        '
        Me.txtEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspera.Location = New System.Drawing.Point(808, 54)
        Me.txtEspera.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEspera.Multiline = True
        Me.txtEspera.Name = "txtEspera"
        Me.txtEspera.Size = New System.Drawing.Size(297, 47)
        Me.txtEspera.TabIndex = 3
        '
        'txtImportancia
        '
        Me.txtImportancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportancia.Location = New System.Drawing.Point(247, 160)
        Me.txtImportancia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImportancia.Multiline = True
        Me.txtImportancia.Name = "txtImportancia"
        Me.txtImportancia.Size = New System.Drawing.Size(297, 47)
        Me.txtImportancia.TabIndex = 2
        '
        'txtCausa
        '
        Me.txtCausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCausa.Location = New System.Drawing.Point(247, 105)
        Me.txtCausa.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCausa.Multiline = True
        Me.txtCausa.Name = "txtCausa"
        Me.txtCausa.Size = New System.Drawing.Size(297, 47)
        Me.txtCausa.TabIndex = 1
        '
        'txtInformacion
        '
        Me.txtInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInformacion.Location = New System.Drawing.Point(247, 49)
        Me.txtInformacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInformacion.Multiline = True
        Me.txtInformacion.Name = "txtInformacion"
        Me.txtInformacion.Size = New System.Drawing.Size(297, 47)
        Me.txtInformacion.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(605, 113)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 17)
        Me.Label11.TabIndex = 15
        Me.Label11.Tag = "OBLIGATORIO"
        Me.Label11.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(39, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Tag = "OBLIGATORIO"
        Me.Label6.Text = "Información del centro:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(605, 58)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Tag = "OBLIGATORIO"
        Me.Label10.Text = "Que espera del centro:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(39, 105)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Tag = "OBLIGATORIO"
        Me.Label7.Text = "Causa de ingreso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(39, 164)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Tag = "OBLIGATORIO"
        Me.Label8.Text = "Importancia:"
        '
        'TabPadre
        '
        Me.TabPadre.Caption = "Padre"
        Me.TabPadre.Controls.Add(Me.txtNivelAcademicoP)
        Me.TabPadre.Controls.Add(Me.Label46)
        Me.TabPadre.Controls.Add(Me.cmbEstadoCivilP)
        Me.TabPadre.Controls.Add(Me.Label43)
        Me.TabPadre.Controls.Add(Me.chkExtranjero)
        Me.TabPadre.Controls.Add(Me.txtDireccionPadre)
        Me.TabPadre.Controls.Add(Me.Label17)
        Me.TabPadre.Controls.Add(Me.GroupBox1)
        Me.TabPadre.Controls.Add(Me.Label16)
        Me.TabPadre.Controls.Add(Me.txtCedulaPadre)
        Me.TabPadre.Controls.Add(Me.txtLugarTrabajoPadre)
        Me.TabPadre.Controls.Add(Me.txtOcupacionPadre)
        Me.TabPadre.Controls.Add(Me.txtProfesionPadre)
        Me.TabPadre.Controls.Add(Me.cmbReligionPadre)
        Me.TabPadre.Controls.Add(Me.Label23)
        Me.TabPadre.Controls.Add(Me.Label22)
        Me.TabPadre.Controls.Add(Me.Label21)
        Me.TabPadre.Controls.Add(Me.Label20)
        Me.TabPadre.Controls.Add(Me.Label14)
        Me.TabPadre.Controls.Add(Me.cmdBuscarPadre)
        Me.TabPadre.Controls.Add(Me.Label15)
        Me.TabPadre.Controls.Add(Me.txtApellido2Padre)
        Me.TabPadre.Controls.Add(Me.Label13)
        Me.TabPadre.Controls.Add(Me.txtApellido1Padre)
        Me.TabPadre.Controls.Add(Me.Label12)
        Me.TabPadre.Controls.Add(Me.txtNombre2Padre)
        Me.TabPadre.Controls.Add(Me.txtNombre1Padre)
        Me.TabPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPadre.Name = "TabPadre"
        Me.TabPadre.Size = New System.Drawing.Size(1208, 360)
        '
        'txtNivelAcademicoP
        '
        Me.txtNivelAcademicoP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivelAcademicoP.Location = New System.Drawing.Point(211, 298)
        Me.txtNivelAcademicoP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNivelAcademicoP.Name = "txtNivelAcademicoP"
        Me.txtNivelAcademicoP.Size = New System.Drawing.Size(225, 23)
        Me.txtNivelAcademicoP.TabIndex = 84
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(24, 306)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(131, 17)
        Me.Label46.TabIndex = 85
        Me.Label46.Text = "Nivel académico:"
        '
        'cmbEstadoCivilP
        '
        Me.cmbEstadoCivilP.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstadoCivilP.AutoCompletion = True
        Me.cmbEstadoCivilP.AutoDropDown = True
        Me.cmbEstadoCivilP.Caption = ""
        Me.cmbEstadoCivilP.CaptionHeight = 17
        Me.cmbEstadoCivilP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstadoCivilP.ColumnCaptionHeight = 17
        Me.cmbEstadoCivilP.ColumnFooterHeight = 17
        Me.cmbEstadoCivilP.ContentHeight = 18
        Me.cmbEstadoCivilP.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstadoCivilP.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstadoCivilP.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoCivilP.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstadoCivilP.EditorHeight = 18
        Me.cmbEstadoCivilP.Images.Add(CType(resources.GetObject("cmbEstadoCivilP.Images"), System.Drawing.Image))
        Me.cmbEstadoCivilP.ItemHeight = 15
        Me.cmbEstadoCivilP.Location = New System.Drawing.Point(675, 12)
        Me.cmbEstadoCivilP.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoCivilP.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstadoCivilP.MaxDropDownItems = CType(5, Short)
        Me.cmbEstadoCivilP.MaxLength = 32767
        Me.cmbEstadoCivilP.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstadoCivilP.Name = "cmbEstadoCivilP"
        Me.cmbEstadoCivilP.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilP.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstadoCivilP.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilP.Size = New System.Drawing.Size(227, 24)
        Me.cmbEstadoCivilP.TabIndex = 52
        Me.cmbEstadoCivilP.Tag = "OBLIGATORIO"
        Me.cmbEstadoCivilP.PropBag = resources.GetString("cmbEstadoCivilP.PropBag")
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(540, 21)
        Me.Label43.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 17)
        Me.Label43.TabIndex = 53
        Me.Label43.Text = "Estado civil:"
        '
        'chkExtranjero
        '
        Me.chkExtranjero.AutoSize = True
        Me.chkExtranjero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExtranjero.ForeColor = System.Drawing.Color.Black
        Me.chkExtranjero.Location = New System.Drawing.Point(441, 142)
        Me.chkExtranjero.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExtranjero.Name = "chkExtranjero"
        Me.chkExtranjero.Size = New System.Drawing.Size(104, 21)
        Me.chkExtranjero.TabIndex = 5
        Me.chkExtranjero.Text = "Extranjero"
        Me.chkExtranjero.UseVisualStyleBackColor = True
        '
        'txtDireccionPadre
        '
        Me.txtDireccionPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionPadre.Location = New System.Drawing.Point(675, 46)
        Me.txtDireccionPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionPadre.Multiline = True
        Me.txtDireccionPadre.Name = "txtDireccionPadre"
        Me.txtDireccionPadre.Size = New System.Drawing.Size(457, 48)
        Me.txtDireccionPadre.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(541, 49)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 17)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Dirección:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tabAdicionales)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(577, 203)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'tabAdicionales
        '
        Me.tabAdicionales.Controls.Add(Me.tabContactos)
        Me.tabAdicionales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAdicionales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdicionales.Location = New System.Drawing.Point(4, 20)
        Me.tabAdicionales.Margin = New System.Windows.Forms.Padding(4)
        Me.tabAdicionales.Name = "tabAdicionales"
        Me.tabAdicionales.SelectedIndex = 0
        Me.tabAdicionales.Size = New System.Drawing.Size(569, 179)
        Me.tabAdicionales.TabIndex = 0
        '
        'tabContactos
        '
        Me.tabContactos.Controls.Add(Me.tdbContactosPadre)
        Me.tabContactos.Controls.Add(Me.barContactos)
        Me.tabContactos.Location = New System.Drawing.Point(4, 26)
        Me.tabContactos.Margin = New System.Windows.Forms.Padding(4)
        Me.tabContactos.Name = "tabContactos"
        Me.tabContactos.Padding = New System.Windows.Forms.Padding(4)
        Me.tabContactos.Size = New System.Drawing.Size(561, 149)
        Me.tabContactos.TabIndex = 0
        Me.tabContactos.Text = "¿Cómo Contactar?"
        Me.tabContactos.UseVisualStyleBackColor = True
        '
        'tdbContactosPadre
        '
        Me.tdbContactosPadre.AllowArrows = False
        Me.tdbContactosPadre.AllowColMove = False
        Me.tdbContactosPadre.AllowColSelect = False
        Me.tdbContactosPadre.AllowRowSelect = False
        Me.tdbContactosPadre.AllowUpdate = False
        Me.tdbContactosPadre.CaptionHeight = 19
        Me.tdbContactosPadre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbContactosPadre.ExtendRightColumn = True
        Me.tdbContactosPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbContactosPadre.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactosPadre.Images.Add(CType(resources.GetObject("tdbContactosPadre.Images"), System.Drawing.Image))
        Me.tdbContactosPadre.Location = New System.Drawing.Point(4, 31)
        Me.tdbContactosPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbContactosPadre.Name = "tdbContactosPadre"
        Me.tdbContactosPadre.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactosPadre.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactosPadre.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactosPadre.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactosPadre.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactosPadre.RowHeight = 17
        Me.tdbContactosPadre.Size = New System.Drawing.Size(553, 114)
        Me.tdbContactosPadre.TabIndex = 1
        Me.tdbContactosPadre.Text = "C1TrueDBGrid1"
        Me.tdbContactosPadre.PropBag = resources.GetString("tdbContactosPadre.PropBag")
        '
        'barContactos
        '
        Me.barContactos.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.barContactos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContacto, Me.cmdEliminarContacto})
        Me.barContactos.Location = New System.Drawing.Point(4, 4)
        Me.barContactos.Name = "barContactos"
        Me.barContactos.Size = New System.Drawing.Size(553, 27)
        Me.barContactos.TabIndex = 0
        Me.barContactos.Text = "ToolStrip1"
        '
        'cmdAgregarContacto
        '
        Me.cmdAgregarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarContacto.Image = CType(resources.GetObject("cmdAgregarContacto.Image"), System.Drawing.Image)
        Me.cmdAgregarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarContacto.Name = "cmdAgregarContacto"
        Me.cmdAgregarContacto.Size = New System.Drawing.Size(24, 24)
        Me.cmdAgregarContacto.Text = "ToolStripButton1"
        Me.cmdAgregarContacto.ToolTipText = "Agregar Contacto"
        '
        'cmdEliminarContacto
        '
        Me.cmdEliminarContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarContacto.Image = CType(resources.GetObject("cmdEliminarContacto.Image"), System.Drawing.Image)
        Me.cmdEliminarContacto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarContacto.Name = "cmdEliminarContacto"
        Me.cmdEliminarContacto.Size = New System.Drawing.Size(24, 24)
        Me.cmdEliminarContacto.Text = "ToolStripButton2"
        Me.cmdEliminarContacto.ToolTipText = "Eliminar Contacto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(24, 148)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 17)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "Cédula nacional:"
        '
        'txtCedulaPadre
        '
        Me.txtCedulaPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaPadre.Location = New System.Drawing.Point(211, 139)
        Me.txtCedulaPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedulaPadre.Mask = "000-000000-0000L"
        Me.txtCedulaPadre.Name = "txtCedulaPadre"
        Me.txtCedulaPadre.Size = New System.Drawing.Size(225, 23)
        Me.txtCedulaPadre.TabIndex = 4
        '
        'txtLugarTrabajoPadre
        '
        Me.txtLugarTrabajoPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajoPadre.Location = New System.Drawing.Point(211, 234)
        Me.txtLugarTrabajoPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugarTrabajoPadre.Name = "txtLugarTrabajoPadre"
        Me.txtLugarTrabajoPadre.Size = New System.Drawing.Size(225, 23)
        Me.txtLugarTrabajoPadre.TabIndex = 8
        '
        'txtOcupacionPadre
        '
        Me.txtOcupacionPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacionPadre.Location = New System.Drawing.Point(211, 202)
        Me.txtOcupacionPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOcupacionPadre.Name = "txtOcupacionPadre"
        Me.txtOcupacionPadre.Size = New System.Drawing.Size(225, 23)
        Me.txtOcupacionPadre.TabIndex = 7
        '
        'txtProfesionPadre
        '
        Me.txtProfesionPadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesionPadre.Location = New System.Drawing.Point(211, 170)
        Me.txtProfesionPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProfesionPadre.Name = "txtProfesionPadre"
        Me.txtProfesionPadre.Size = New System.Drawing.Size(225, 23)
        Me.txtProfesionPadre.TabIndex = 6
        '
        'cmbReligionPadre
        '
        Me.cmbReligionPadre.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbReligionPadre.AutoCompletion = True
        Me.cmbReligionPadre.AutoDropDown = True
        Me.cmbReligionPadre.Caption = ""
        Me.cmbReligionPadre.CaptionHeight = 17
        Me.cmbReligionPadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbReligionPadre.ColumnCaptionHeight = 17
        Me.cmbReligionPadre.ColumnFooterHeight = 17
        Me.cmbReligionPadre.ContentHeight = 18
        Me.cmbReligionPadre.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbReligionPadre.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbReligionPadre.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligionPadre.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReligionPadre.EditorHeight = 18
        Me.cmbReligionPadre.Images.Add(CType(resources.GetObject("cmbReligionPadre.Images"), System.Drawing.Image))
        Me.cmbReligionPadre.ItemHeight = 15
        Me.cmbReligionPadre.Location = New System.Drawing.Point(211, 266)
        Me.cmbReligionPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbReligionPadre.MatchEntryTimeout = CType(2000, Long)
        Me.cmbReligionPadre.MaxDropDownItems = CType(5, Short)
        Me.cmbReligionPadre.MaxLength = 32767
        Me.cmbReligionPadre.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbReligionPadre.Name = "cmbReligionPadre"
        Me.cmbReligionPadre.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbReligionPadre.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbReligionPadre.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbReligionPadre.Size = New System.Drawing.Size(227, 24)
        Me.cmbReligionPadre.TabIndex = 9
        Me.cmbReligionPadre.Tag = "OBLIGATORIO"
        Me.cmbReligionPadre.PropBag = resources.GetString("cmbReligionPadre.PropBag")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(24, 276)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 17)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Religión:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(24, 242)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(139, 17)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Lugar de Trabajo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(24, 210)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 17)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Ocupación:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(24, 178)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 17)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Profesión:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(24, 21)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 17)
        Me.Label14.TabIndex = 36
        Me.Label14.Tag = "OBLIGATORIO"
        Me.Label14.Text = "Primer nombre:"
        '
        'cmdBuscarPadre
        '
        Me.cmdBuscarPadre.Location = New System.Drawing.Point(445, 15)
        Me.cmdBuscarPadre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarPadre.Name = "cmdBuscarPadre"
        Me.cmdBuscarPadre.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscarPadre.TabIndex = 10
        Me.cmdBuscarPadre.Tag = "Buscar Existente"
        Me.cmdBuscarPadre.Text = "..."
        Me.cmdBuscarPadre.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(24, 50)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 17)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Segundo nombre:"
        '
        'txtApellido2Padre
        '
        Me.txtApellido2Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2Padre.Location = New System.Drawing.Point(211, 107)
        Me.txtApellido2Padre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido2Padre.Name = "txtApellido2Padre"
        Me.txtApellido2Padre.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido2Padre.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 82)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 17)
        Me.Label13.TabIndex = 37
        Me.Label13.Tag = "OBLIGATORIO"
        Me.Label13.Text = "Primer apellido:"
        '
        'txtApellido1Padre
        '
        Me.txtApellido1Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1Padre.Location = New System.Drawing.Point(211, 76)
        Me.txtApellido1Padre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido1Padre.Name = "txtApellido1Padre"
        Me.txtApellido1Padre.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido1Padre.TabIndex = 2
        Me.txtApellido1Padre.Tag = "OBLIGATORIO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 113)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Segundo apellido:"
        '
        'txtNombre2Padre
        '
        Me.txtNombre2Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2Padre.Location = New System.Drawing.Point(211, 46)
        Me.txtNombre2Padre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre2Padre.Name = "txtNombre2Padre"
        Me.txtNombre2Padre.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre2Padre.TabIndex = 1
        '
        'txtNombre1Padre
        '
        Me.txtNombre1Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1Padre.Location = New System.Drawing.Point(211, 15)
        Me.txtNombre1Padre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre1Padre.Name = "txtNombre1Padre"
        Me.txtNombre1Padre.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre1Padre.TabIndex = 0
        Me.txtNombre1Padre.Tag = "OBLIGATORIO"
        '
        'TabMadre
        '
        Me.TabMadre.Caption = "Madre"
        Me.TabMadre.Controls.Add(Me.txtNivelAcademicoM)
        Me.TabMadre.Controls.Add(Me.Label47)
        Me.TabMadre.Controls.Add(Me.cmbEstadoCivilM)
        Me.TabMadre.Controls.Add(Me.Label44)
        Me.TabMadre.Controls.Add(Me.chkExtrajeneroM)
        Me.TabMadre.Controls.Add(Me.GroupBox2)
        Me.TabMadre.Controls.Add(Me.txtDireccionMadre)
        Me.TabMadre.Controls.Add(Me.Label18)
        Me.TabMadre.Controls.Add(Me.Label19)
        Me.TabMadre.Controls.Add(Me.txtCedulaMadre)
        Me.TabMadre.Controls.Add(Me.txtLugarTrabajoMadre)
        Me.TabMadre.Controls.Add(Me.txtOcupacionMadre)
        Me.TabMadre.Controls.Add(Me.txtProfesionMadre)
        Me.TabMadre.Controls.Add(Me.cmbReligionMadre)
        Me.TabMadre.Controls.Add(Me.Label24)
        Me.TabMadre.Controls.Add(Me.Label25)
        Me.TabMadre.Controls.Add(Me.Label26)
        Me.TabMadre.Controls.Add(Me.Label27)
        Me.TabMadre.Controls.Add(Me.Label28)
        Me.TabMadre.Controls.Add(Me.cmdBuscarMadre)
        Me.TabMadre.Controls.Add(Me.Label29)
        Me.TabMadre.Controls.Add(Me.txtApellido2Madre)
        Me.TabMadre.Controls.Add(Me.Label30)
        Me.TabMadre.Controls.Add(Me.txtApellido1Madre)
        Me.TabMadre.Controls.Add(Me.Label31)
        Me.TabMadre.Controls.Add(Me.txtNombre2Madre)
        Me.TabMadre.Controls.Add(Me.txtNombre1Madre)
        Me.TabMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.TabMadre.Name = "TabMadre"
        Me.TabMadre.Size = New System.Drawing.Size(1184, 335)
        '
        'txtNivelAcademicoM
        '
        Me.txtNivelAcademicoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivelAcademicoM.Location = New System.Drawing.Point(208, 299)
        Me.txtNivelAcademicoM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNivelAcademicoM.Name = "txtNivelAcademicoM"
        Me.txtNivelAcademicoM.Size = New System.Drawing.Size(225, 23)
        Me.txtNivelAcademicoM.TabIndex = 86
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(21, 308)
        Me.Label47.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(131, 17)
        Me.Label47.TabIndex = 87
        Me.Label47.Text = "Nivel académico:"
        '
        'cmbEstadoCivilM
        '
        Me.cmbEstadoCivilM.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstadoCivilM.AutoCompletion = True
        Me.cmbEstadoCivilM.AutoDropDown = True
        Me.cmbEstadoCivilM.Caption = ""
        Me.cmbEstadoCivilM.CaptionHeight = 17
        Me.cmbEstadoCivilM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstadoCivilM.ColumnCaptionHeight = 17
        Me.cmbEstadoCivilM.ColumnFooterHeight = 17
        Me.cmbEstadoCivilM.ContentHeight = 18
        Me.cmbEstadoCivilM.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstadoCivilM.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstadoCivilM.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoCivilM.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstadoCivilM.EditorHeight = 18
        Me.cmbEstadoCivilM.Images.Add(CType(resources.GetObject("cmbEstadoCivilM.Images"), System.Drawing.Image))
        Me.cmbEstadoCivilM.ItemHeight = 15
        Me.cmbEstadoCivilM.Location = New System.Drawing.Point(672, 12)
        Me.cmbEstadoCivilM.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoCivilM.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstadoCivilM.MaxDropDownItems = CType(5, Short)
        Me.cmbEstadoCivilM.MaxLength = 32767
        Me.cmbEstadoCivilM.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstadoCivilM.Name = "cmbEstadoCivilM"
        Me.cmbEstadoCivilM.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstadoCivilM.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilM.Size = New System.Drawing.Size(227, 24)
        Me.cmbEstadoCivilM.TabIndex = 74
        Me.cmbEstadoCivilM.Tag = "OBLIGATORIO"
        Me.cmbEstadoCivilM.PropBag = resources.GetString("cmbEstadoCivilM.PropBag")
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(537, 17)
        Me.Label44.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 17)
        Me.Label44.TabIndex = 75
        Me.Label44.Text = "Estado civil:"
        '
        'chkExtrajeneroM
        '
        Me.chkExtrajeneroM.AutoSize = True
        Me.chkExtrajeneroM.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExtrajeneroM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExtrajeneroM.ForeColor = System.Drawing.Color.Black
        Me.chkExtrajeneroM.Location = New System.Drawing.Point(435, 143)
        Me.chkExtrajeneroM.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExtrajeneroM.Name = "chkExtrajeneroM"
        Me.chkExtrajeneroM.Size = New System.Drawing.Size(104, 21)
        Me.chkExtrajeneroM.TabIndex = 5
        Me.chkExtrajeneroM.Text = "Extranjero"
        Me.chkExtrajeneroM.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(553, 94)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(577, 203)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(4, 20)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 179)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tdbContactosMadre)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Location = New System.Drawing.Point(5, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(559, 148)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "¿Cómo Contactar?"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tdbContactosMadre
        '
        Me.tdbContactosMadre.AllowArrows = False
        Me.tdbContactosMadre.AllowColMove = False
        Me.tdbContactosMadre.AllowColSelect = False
        Me.tdbContactosMadre.AllowRowSelect = False
        Me.tdbContactosMadre.AllowUpdate = False
        Me.tdbContactosMadre.CaptionHeight = 19
        Me.tdbContactosMadre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbContactosMadre.ExtendRightColumn = True
        Me.tdbContactosMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbContactosMadre.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactosMadre.Images.Add(CType(resources.GetObject("tdbContactosMadre.Images"), System.Drawing.Image))
        Me.tdbContactosMadre.Location = New System.Drawing.Point(4, 31)
        Me.tdbContactosMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbContactosMadre.Name = "tdbContactosMadre"
        Me.tdbContactosMadre.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactosMadre.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactosMadre.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactosMadre.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactosMadre.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactosMadre.RowHeight = 17
        Me.tdbContactosMadre.Size = New System.Drawing.Size(551, 113)
        Me.tdbContactosMadre.TabIndex = 1
        Me.tdbContactosMadre.Text = "C1TrueDBGrid1"
        Me.tdbContactosMadre.PropBag = resources.GetString("tdbContactosMadre.PropBag")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContactoM, Me.cmdEliminarContactoM})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(551, 27)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cmdAgregarContactoM
        '
        Me.cmdAgregarContactoM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarContactoM.Image = CType(resources.GetObject("cmdAgregarContactoM.Image"), System.Drawing.Image)
        Me.cmdAgregarContactoM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarContactoM.Name = "cmdAgregarContactoM"
        Me.cmdAgregarContactoM.Size = New System.Drawing.Size(24, 24)
        Me.cmdAgregarContactoM.Text = "ToolStripButton1"
        Me.cmdAgregarContactoM.ToolTipText = "Agregar Contacto"
        '
        'cmdEliminarContactoM
        '
        Me.cmdEliminarContactoM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarContactoM.Image = CType(resources.GetObject("cmdEliminarContactoM.Image"), System.Drawing.Image)
        Me.cmdEliminarContactoM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarContactoM.Name = "cmdEliminarContactoM"
        Me.cmdEliminarContactoM.Size = New System.Drawing.Size(24, 24)
        Me.cmdEliminarContactoM.Text = "ToolStripButton2"
        Me.cmdEliminarContactoM.ToolTipText = "Eliminar Contacto"
        '
        'txtDireccionMadre
        '
        Me.txtDireccionMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionMadre.Location = New System.Drawing.Point(672, 46)
        Me.txtDireccionMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionMadre.Multiline = True
        Me.txtDireccionMadre.Name = "txtDireccionMadre"
        Me.txtDireccionMadre.Size = New System.Drawing.Size(457, 48)
        Me.txtDireccionMadre.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(539, 49)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 17)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "Dirección:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(21, 149)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(129, 17)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Cédula nacional:"
        '
        'txtCedulaMadre
        '
        Me.txtCedulaMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaMadre.Location = New System.Drawing.Point(208, 140)
        Me.txtCedulaMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedulaMadre.Mask = "000-000000-0000L"
        Me.txtCedulaMadre.Name = "txtCedulaMadre"
        Me.txtCedulaMadre.Size = New System.Drawing.Size(225, 23)
        Me.txtCedulaMadre.TabIndex = 4
        '
        'txtLugarTrabajoMadre
        '
        Me.txtLugarTrabajoMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajoMadre.Location = New System.Drawing.Point(208, 235)
        Me.txtLugarTrabajoMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugarTrabajoMadre.Name = "txtLugarTrabajoMadre"
        Me.txtLugarTrabajoMadre.Size = New System.Drawing.Size(225, 23)
        Me.txtLugarTrabajoMadre.TabIndex = 8
        '
        'txtOcupacionMadre
        '
        Me.txtOcupacionMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacionMadre.Location = New System.Drawing.Point(208, 203)
        Me.txtOcupacionMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOcupacionMadre.Name = "txtOcupacionMadre"
        Me.txtOcupacionMadre.Size = New System.Drawing.Size(225, 23)
        Me.txtOcupacionMadre.TabIndex = 7
        '
        'txtProfesionMadre
        '
        Me.txtProfesionMadre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesionMadre.Location = New System.Drawing.Point(208, 171)
        Me.txtProfesionMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProfesionMadre.Name = "txtProfesionMadre"
        Me.txtProfesionMadre.Size = New System.Drawing.Size(225, 23)
        Me.txtProfesionMadre.TabIndex = 6
        '
        'cmbReligionMadre
        '
        Me.cmbReligionMadre.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbReligionMadre.AutoCompletion = True
        Me.cmbReligionMadre.AutoDropDown = True
        Me.cmbReligionMadre.Caption = ""
        Me.cmbReligionMadre.CaptionHeight = 17
        Me.cmbReligionMadre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbReligionMadre.ColumnCaptionHeight = 17
        Me.cmbReligionMadre.ColumnFooterHeight = 17
        Me.cmbReligionMadre.ContentHeight = 18
        Me.cmbReligionMadre.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbReligionMadre.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbReligionMadre.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligionMadre.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReligionMadre.EditorHeight = 18
        Me.cmbReligionMadre.Images.Add(CType(resources.GetObject("cmbReligionMadre.Images"), System.Drawing.Image))
        Me.cmbReligionMadre.ItemHeight = 15
        Me.cmbReligionMadre.Location = New System.Drawing.Point(208, 267)
        Me.cmbReligionMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbReligionMadre.MatchEntryTimeout = CType(2000, Long)
        Me.cmbReligionMadre.MaxDropDownItems = CType(5, Short)
        Me.cmbReligionMadre.MaxLength = 32767
        Me.cmbReligionMadre.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbReligionMadre.Name = "cmbReligionMadre"
        Me.cmbReligionMadre.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbReligionMadre.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbReligionMadre.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbReligionMadre.Size = New System.Drawing.Size(227, 24)
        Me.cmbReligionMadre.TabIndex = 9
        Me.cmbReligionMadre.Tag = "OBLIGATORIO"
        Me.cmbReligionMadre.PropBag = resources.GetString("cmbReligionMadre.PropBag")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(21, 277)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 17)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Religión:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(21, 244)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(139, 17)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Lugar de Trabajo:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(21, 212)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 17)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Ocupación:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(21, 180)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(82, 17)
        Me.Label27.TabIndex = 61
        Me.Label27.Text = "Profesión:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(21, 22)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(119, 17)
        Me.Label28.TabIndex = 58
        Me.Label28.Tag = "OBLIGATORIO"
        Me.Label28.Text = "Primer nombre:"
        '
        'cmdBuscarMadre
        '
        Me.cmdBuscarMadre.Location = New System.Drawing.Point(443, 16)
        Me.cmdBuscarMadre.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarMadre.Name = "cmdBuscarMadre"
        Me.cmdBuscarMadre.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscarMadre.TabIndex = 10
        Me.cmdBuscarMadre.Tag = "Buscar Existente"
        Me.cmdBuscarMadre.Text = "..."
        Me.cmdBuscarMadre.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(21, 52)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 17)
        Me.Label29.TabIndex = 57
        Me.Label29.Text = "Segundo nombre:"
        '
        'txtApellido2Madre
        '
        Me.txtApellido2Madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2Madre.Location = New System.Drawing.Point(208, 108)
        Me.txtApellido2Madre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido2Madre.Name = "txtApellido2Madre"
        Me.txtApellido2Madre.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido2Madre.TabIndex = 3
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(21, 84)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(122, 17)
        Me.Label30.TabIndex = 59
        Me.Label30.Tag = "OBLIGATORIO"
        Me.Label30.Text = "Primer apellido:"
        '
        'txtApellido1Madre
        '
        Me.txtApellido1Madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1Madre.Location = New System.Drawing.Point(208, 78)
        Me.txtApellido1Madre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido1Madre.Name = "txtApellido1Madre"
        Me.txtApellido1Madre.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido1Madre.TabIndex = 2
        Me.txtApellido1Madre.Tag = "OBLIGATORIO"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(21, 114)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(139, 17)
        Me.Label31.TabIndex = 60
        Me.Label31.Text = "Segundo apellido:"
        '
        'txtNombre2Madre
        '
        Me.txtNombre2Madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2Madre.Location = New System.Drawing.Point(208, 47)
        Me.txtNombre2Madre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre2Madre.Name = "txtNombre2Madre"
        Me.txtNombre2Madre.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre2Madre.TabIndex = 1
        '
        'txtNombre1Madre
        '
        Me.txtNombre1Madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1Madre.Location = New System.Drawing.Point(208, 16)
        Me.txtNombre1Madre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre1Madre.Name = "txtNombre1Madre"
        Me.txtNombre1Madre.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre1Madre.TabIndex = 0
        Me.txtNombre1Madre.Tag = "OBLIGATORIO"
        '
        'TabResponsable
        '
        Me.TabResponsable.Caption = "Responsable"
        Me.TabResponsable.Controls.Add(Me.txtNivelAcademicoR)
        Me.TabResponsable.Controls.Add(Me.Label48)
        Me.TabResponsable.Controls.Add(Me.cmbEstadoCivilR)
        Me.TabResponsable.Controls.Add(Me.Label45)
        Me.TabResponsable.Controls.Add(Me.chkExtrajenjeroR)
        Me.TabResponsable.Controls.Add(Me.cmbParentesco)
        Me.TabResponsable.Controls.Add(Me.GroupBox3)
        Me.TabResponsable.Controls.Add(Me.txtDireccionResponsable)
        Me.TabResponsable.Controls.Add(Me.Label9)
        Me.TabResponsable.Controls.Add(Me.Label33)
        Me.TabResponsable.Controls.Add(Me.Label34)
        Me.TabResponsable.Controls.Add(Me.txtCedulaResponsable)
        Me.TabResponsable.Controls.Add(Me.txtLugarTrabajoResponsable)
        Me.TabResponsable.Controls.Add(Me.txtOcupacionResponsable)
        Me.TabResponsable.Controls.Add(Me.txtProfesionResponsable)
        Me.TabResponsable.Controls.Add(Me.cmbReligionResponsable)
        Me.TabResponsable.Controls.Add(Me.Label35)
        Me.TabResponsable.Controls.Add(Me.Label36)
        Me.TabResponsable.Controls.Add(Me.Label37)
        Me.TabResponsable.Controls.Add(Me.Label38)
        Me.TabResponsable.Controls.Add(Me.Label39)
        Me.TabResponsable.Controls.Add(Me.cmdBuscarResponsable)
        Me.TabResponsable.Controls.Add(Me.Label40)
        Me.TabResponsable.Controls.Add(Me.txtApellido2Responsable)
        Me.TabResponsable.Controls.Add(Me.Label41)
        Me.TabResponsable.Controls.Add(Me.txtApellido1Responsable)
        Me.TabResponsable.Controls.Add(Me.Label42)
        Me.TabResponsable.Controls.Add(Me.txtNombre2Responsable)
        Me.TabResponsable.Controls.Add(Me.txtNombre1Responsable)
        Me.TabResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.TabResponsable.Name = "TabResponsable"
        Me.TabResponsable.Size = New System.Drawing.Size(1184, 335)
        '
        'txtNivelAcademicoR
        '
        Me.txtNivelAcademicoR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNivelAcademicoR.Location = New System.Drawing.Point(215, 300)
        Me.txtNivelAcademicoR.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNivelAcademicoR.Name = "txtNivelAcademicoR"
        Me.txtNivelAcademicoR.Size = New System.Drawing.Size(225, 23)
        Me.txtNivelAcademicoR.TabIndex = 98
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(28, 309)
        Me.Label48.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(131, 17)
        Me.Label48.TabIndex = 99
        Me.Label48.Text = "Nivel académico:"
        '
        'cmbEstadoCivilR
        '
        Me.cmbEstadoCivilR.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbEstadoCivilR.AutoCompletion = True
        Me.cmbEstadoCivilR.AutoDropDown = True
        Me.cmbEstadoCivilR.Caption = ""
        Me.cmbEstadoCivilR.CaptionHeight = 17
        Me.cmbEstadoCivilR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbEstadoCivilR.ColumnCaptionHeight = 17
        Me.cmbEstadoCivilR.ColumnFooterHeight = 17
        Me.cmbEstadoCivilR.ContentHeight = 18
        Me.cmbEstadoCivilR.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbEstadoCivilR.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbEstadoCivilR.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstadoCivilR.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbEstadoCivilR.EditorHeight = 18
        Me.cmbEstadoCivilR.Images.Add(CType(resources.GetObject("cmbEstadoCivilR.Images"), System.Drawing.Image))
        Me.cmbEstadoCivilR.ItemHeight = 15
        Me.cmbEstadoCivilR.Location = New System.Drawing.Point(679, 9)
        Me.cmbEstadoCivilR.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEstadoCivilR.MatchEntryTimeout = CType(2000, Long)
        Me.cmbEstadoCivilR.MaxDropDownItems = CType(5, Short)
        Me.cmbEstadoCivilR.MaxLength = 32767
        Me.cmbEstadoCivilR.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbEstadoCivilR.Name = "cmbEstadoCivilR"
        Me.cmbEstadoCivilR.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilR.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbEstadoCivilR.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbEstadoCivilR.Size = New System.Drawing.Size(227, 24)
        Me.cmbEstadoCivilR.TabIndex = 96
        Me.cmbEstadoCivilR.Tag = "OBLIGATORIO"
        Me.cmbEstadoCivilR.PropBag = resources.GetString("cmbEstadoCivilR.PropBag")
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(544, 12)
        Me.Label45.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(96, 17)
        Me.Label45.TabIndex = 97
        Me.Label45.Text = "Estado civil:"
        '
        'chkExtrajenjeroR
        '
        Me.chkExtrajenjeroR.AutoSize = True
        Me.chkExtrajenjeroR.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExtrajenjeroR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExtrajenjeroR.ForeColor = System.Drawing.Color.Black
        Me.chkExtrajenjeroR.Location = New System.Drawing.Point(449, 143)
        Me.chkExtrajenjeroR.Margin = New System.Windows.Forms.Padding(4)
        Me.chkExtrajenjeroR.Name = "chkExtrajenjeroR"
        Me.chkExtrajenjeroR.Size = New System.Drawing.Size(104, 21)
        Me.chkExtrajenjeroR.TabIndex = 5
        Me.chkExtrajenjeroR.Text = "Extranjero"
        Me.chkExtrajenjeroR.UseVisualStyleBackColor = True
        '
        'cmbParentesco
        '
        Me.cmbParentesco.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbParentesco.AutoCompletion = True
        Me.cmbParentesco.AutoDropDown = True
        Me.cmbParentesco.Caption = ""
        Me.cmbParentesco.CaptionHeight = 17
        Me.cmbParentesco.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbParentesco.ColumnCaptionHeight = 17
        Me.cmbParentesco.ColumnFooterHeight = 17
        Me.cmbParentesco.ContentHeight = 18
        Me.cmbParentesco.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbParentesco.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbParentesco.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbParentesco.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbParentesco.EditorHeight = 18
        Me.cmbParentesco.Images.Add(CType(resources.GetObject("cmbParentesco.Images"), System.Drawing.Image))
        Me.cmbParentesco.ItemHeight = 15
        Me.cmbParentesco.Location = New System.Drawing.Point(679, 90)
        Me.cmbParentesco.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbParentesco.MatchEntryTimeout = CType(2000, Long)
        Me.cmbParentesco.MaxDropDownItems = CType(5, Short)
        Me.cmbParentesco.MaxLength = 32767
        Me.cmbParentesco.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbParentesco.Name = "cmbParentesco"
        Me.cmbParentesco.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbParentesco.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbParentesco.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbParentesco.Size = New System.Drawing.Size(227, 24)
        Me.cmbParentesco.TabIndex = 12
        Me.cmbParentesco.Tag = "OBLIGATORIO"
        Me.cmbParentesco.PropBag = resources.GetString("cmbParentesco.PropBag")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl2)
        Me.GroupBox3.Location = New System.Drawing.Point(560, 111)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(577, 192)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(4, 20)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(569, 168)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tdbContactosResponsable)
        Me.TabPage2.Controls.Add(Me.cmdAgregarContactoR)
        Me.TabPage2.Location = New System.Drawing.Point(5, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(559, 137)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "¿Cómo Contactar?"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tdbContactosResponsable
        '
        Me.tdbContactosResponsable.AllowArrows = False
        Me.tdbContactosResponsable.AllowColMove = False
        Me.tdbContactosResponsable.AllowColSelect = False
        Me.tdbContactosResponsable.AllowRowSelect = False
        Me.tdbContactosResponsable.AllowUpdate = False
        Me.tdbContactosResponsable.CaptionHeight = 19
        Me.tdbContactosResponsable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdbContactosResponsable.ExtendRightColumn = True
        Me.tdbContactosResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdbContactosResponsable.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbContactosResponsable.Images.Add(CType(resources.GetObject("tdbContactosResponsable.Images"), System.Drawing.Image))
        Me.tdbContactosResponsable.Location = New System.Drawing.Point(4, 31)
        Me.tdbContactosResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbContactosResponsable.Name = "tdbContactosResponsable"
        Me.tdbContactosResponsable.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbContactosResponsable.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbContactosResponsable.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbContactosResponsable.PrintInfo.PageSettings = CType(resources.GetObject("tdbContactosResponsable.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbContactosResponsable.RowHeight = 17
        Me.tdbContactosResponsable.Size = New System.Drawing.Size(551, 102)
        Me.tdbContactosResponsable.TabIndex = 1
        Me.tdbContactosResponsable.Text = "C1TrueDBGrid2"
        Me.tdbContactosResponsable.PropBag = resources.GetString("tdbContactosResponsable.PropBag")
        '
        'cmdAgregarContactoR
        '
        Me.cmdAgregarContactoR.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmdAgregarContactoR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregarContactoResp, Me.cmdEliminarContactoR})
        Me.cmdAgregarContactoR.Location = New System.Drawing.Point(4, 4)
        Me.cmdAgregarContactoR.Name = "cmdAgregarContactoR"
        Me.cmdAgregarContactoR.Size = New System.Drawing.Size(551, 27)
        Me.cmdAgregarContactoR.TabIndex = 0
        Me.cmdAgregarContactoR.Text = "ToolStrip2"
        '
        'cmdAgregarContactoResp
        '
        Me.cmdAgregarContactoResp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdAgregarContactoResp.Image = CType(resources.GetObject("cmdAgregarContactoResp.Image"), System.Drawing.Image)
        Me.cmdAgregarContactoResp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAgregarContactoResp.Name = "cmdAgregarContactoResp"
        Me.cmdAgregarContactoResp.Size = New System.Drawing.Size(24, 24)
        Me.cmdAgregarContactoResp.Text = "ToolStripButton1"
        Me.cmdAgregarContactoResp.ToolTipText = "Agregar Contacto"
        '
        'cmdEliminarContactoR
        '
        Me.cmdEliminarContactoR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEliminarContactoR.Image = CType(resources.GetObject("cmdEliminarContactoR.Image"), System.Drawing.Image)
        Me.cmdEliminarContactoR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminarContactoR.Name = "cmdEliminarContactoR"
        Me.cmdEliminarContactoR.Size = New System.Drawing.Size(24, 24)
        Me.cmdEliminarContactoR.Text = "ToolStripButton2"
        Me.cmdEliminarContactoR.ToolTipText = "Eliminar Contacto"
        '
        'txtDireccionResponsable
        '
        Me.txtDireccionResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionResponsable.Location = New System.Drawing.Point(679, 41)
        Me.txtDireccionResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionResponsable.Multiline = True
        Me.txtDireccionResponsable.Name = "txtDireccionResponsable"
        Me.txtDireccionResponsable.Size = New System.Drawing.Size(457, 45)
        Me.txtDireccionResponsable.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(545, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Parentesco:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(545, 47)
        Me.Label33.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(81, 17)
        Me.Label33.TabIndex = 95
        Me.Label33.Text = "Dirección:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(28, 149)
        Me.Label34.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(129, 17)
        Me.Label34.TabIndex = 92
        Me.Label34.Text = "Cédula nacional:"
        '
        'txtCedulaResponsable
        '
        Me.txtCedulaResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaResponsable.Location = New System.Drawing.Point(215, 140)
        Me.txtCedulaResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedulaResponsable.Mask = "000-000000-0000L"
        Me.txtCedulaResponsable.Name = "txtCedulaResponsable"
        Me.txtCedulaResponsable.Size = New System.Drawing.Size(225, 23)
        Me.txtCedulaResponsable.TabIndex = 4
        '
        'txtLugarTrabajoResponsable
        '
        Me.txtLugarTrabajoResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajoResponsable.Location = New System.Drawing.Point(215, 235)
        Me.txtLugarTrabajoResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugarTrabajoResponsable.Name = "txtLugarTrabajoResponsable"
        Me.txtLugarTrabajoResponsable.Size = New System.Drawing.Size(225, 23)
        Me.txtLugarTrabajoResponsable.TabIndex = 8
        '
        'txtOcupacionResponsable
        '
        Me.txtOcupacionResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcupacionResponsable.Location = New System.Drawing.Point(215, 203)
        Me.txtOcupacionResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOcupacionResponsable.Name = "txtOcupacionResponsable"
        Me.txtOcupacionResponsable.Size = New System.Drawing.Size(225, 23)
        Me.txtOcupacionResponsable.TabIndex = 7
        '
        'txtProfesionResponsable
        '
        Me.txtProfesionResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfesionResponsable.Location = New System.Drawing.Point(215, 171)
        Me.txtProfesionResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProfesionResponsable.Name = "txtProfesionResponsable"
        Me.txtProfesionResponsable.Size = New System.Drawing.Size(225, 23)
        Me.txtProfesionResponsable.TabIndex = 6
        '
        'cmbReligionResponsable
        '
        Me.cmbReligionResponsable.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbReligionResponsable.AutoCompletion = True
        Me.cmbReligionResponsable.AutoDropDown = True
        Me.cmbReligionResponsable.Caption = ""
        Me.cmbReligionResponsable.CaptionHeight = 17
        Me.cmbReligionResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbReligionResponsable.ColumnCaptionHeight = 17
        Me.cmbReligionResponsable.ColumnFooterHeight = 17
        Me.cmbReligionResponsable.ContentHeight = 18
        Me.cmbReligionResponsable.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbReligionResponsable.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbReligionResponsable.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligionResponsable.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReligionResponsable.EditorHeight = 18
        Me.cmbReligionResponsable.Images.Add(CType(resources.GetObject("cmbReligionResponsable.Images"), System.Drawing.Image))
        Me.cmbReligionResponsable.ItemHeight = 15
        Me.cmbReligionResponsable.Location = New System.Drawing.Point(215, 267)
        Me.cmbReligionResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbReligionResponsable.MatchEntryTimeout = CType(2000, Long)
        Me.cmbReligionResponsable.MaxDropDownItems = CType(5, Short)
        Me.cmbReligionResponsable.MaxLength = 32767
        Me.cmbReligionResponsable.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbReligionResponsable.Name = "cmbReligionResponsable"
        Me.cmbReligionResponsable.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbReligionResponsable.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbReligionResponsable.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbReligionResponsable.Size = New System.Drawing.Size(227, 24)
        Me.cmbReligionResponsable.TabIndex = 9
        Me.cmbReligionResponsable.Tag = "OBLIGATORIO"
        Me.cmbReligionResponsable.PropBag = resources.GetString("cmbReligionResponsable.PropBag")
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(28, 277)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 17)
        Me.Label35.TabIndex = 86
        Me.Label35.Text = "Religión:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(28, 244)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(134, 17)
        Me.Label36.TabIndex = 85
        Me.Label36.Text = "Lugar de trabajo:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(28, 212)
        Me.Label37.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(90, 17)
        Me.Label37.TabIndex = 84
        Me.Label37.Text = "Ocupación:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(28, 180)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(82, 17)
        Me.Label38.TabIndex = 83
        Me.Label38.Text = "Profesión:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(28, 22)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(119, 17)
        Me.Label39.TabIndex = 80
        Me.Label39.Tag = "OBLIGATORIO"
        Me.Label39.Text = "Primer nombre:"
        '
        'cmdBuscarResponsable
        '
        Me.cmdBuscarResponsable.Location = New System.Drawing.Point(449, 16)
        Me.cmdBuscarResponsable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscarResponsable.Name = "cmdBuscarResponsable"
        Me.cmdBuscarResponsable.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscarResponsable.TabIndex = 10
        Me.cmdBuscarResponsable.Tag = "Buscar Existente"
        Me.cmdBuscarResponsable.Text = "..."
        Me.cmdBuscarResponsable.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(28, 52)
        Me.Label40.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(136, 17)
        Me.Label40.TabIndex = 79
        Me.Label40.Text = "Segundo nombre:"
        '
        'txtApellido2Responsable
        '
        Me.txtApellido2Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2Responsable.Location = New System.Drawing.Point(215, 108)
        Me.txtApellido2Responsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido2Responsable.Name = "txtApellido2Responsable"
        Me.txtApellido2Responsable.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido2Responsable.TabIndex = 3
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(28, 84)
        Me.Label41.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(122, 17)
        Me.Label41.TabIndex = 81
        Me.Label41.Tag = "OBLIGATORIO"
        Me.Label41.Text = "Primer apellido:"
        '
        'txtApellido1Responsable
        '
        Me.txtApellido1Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1Responsable.Location = New System.Drawing.Point(215, 78)
        Me.txtApellido1Responsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido1Responsable.Name = "txtApellido1Responsable"
        Me.txtApellido1Responsable.Size = New System.Drawing.Size(225, 23)
        Me.txtApellido1Responsable.TabIndex = 2
        Me.txtApellido1Responsable.Tag = "OBLIGATORIO"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(28, 114)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(139, 17)
        Me.Label42.TabIndex = 82
        Me.Label42.Text = "Segundo apellido:"
        '
        'txtNombre2Responsable
        '
        Me.txtNombre2Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2Responsable.Location = New System.Drawing.Point(215, 47)
        Me.txtNombre2Responsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre2Responsable.Name = "txtNombre2Responsable"
        Me.txtNombre2Responsable.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre2Responsable.TabIndex = 1
        '
        'txtNombre1Responsable
        '
        Me.txtNombre1Responsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre1Responsable.Location = New System.Drawing.Point(215, 16)
        Me.txtNombre1Responsable.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre1Responsable.Name = "txtNombre1Responsable"
        Me.txtNombre1Responsable.Size = New System.Drawing.Size(225, 23)
        Me.txtNombre1Responsable.TabIndex = 0
        Me.txtNombre1Responsable.Tag = "OBLIGATORIO"
        '
        'grpPersonaNatural
        '
        Me.grpPersonaNatural.Controls.Add(Me.txtLugarNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.chkAlumnoExtranjero)
        Me.grpPersonaNatural.Controls.Add(Me.SimpleButton2)
        Me.grpPersonaNatural.Controls.Add(Me.chkActivo)
        Me.grpPersonaNatural.Controls.Add(Me.cmbResposable)
        Me.grpPersonaNatural.Controls.Add(Me.Label32)
        Me.grpPersonaNatural.Controls.Add(Me.txtCodigoMined)
        Me.grpPersonaNatural.Controls.Add(Me.Label3)
        Me.grpPersonaNatural.Controls.Add(Me.cmbLugarNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblEdad)
        Me.grpPersonaNatural.Controls.Add(Me.cmbReligion)
        Me.grpPersonaNatural.Controls.Add(Me.cmbciudad)
        Me.grpPersonaNatural.Controls.Add(Me.Label5)
        Me.grpPersonaNatural.Controls.Add(Me.cmbGenero)
        Me.grpPersonaNatural.Controls.Add(Me.Label4)
        Me.grpPersonaNatural.Controls.Add(Me.cmdBuscar)
        Me.grpPersonaNatural.Controls.Add(Me.dtpFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.txtDireccion)
        Me.grpPersonaNatural.Controls.Add(Me.Label2)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.Label1)
        Me.grpPersonaNatural.Controls.Add(Me.txtSegundoNombre)
        Me.grpPersonaNatural.Controls.Add(Me.txtPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblFechaNacimiento)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblGenero)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerApellido)
        Me.grpPersonaNatural.Controls.Add(Me.lblPrimerNombre)
        Me.grpPersonaNatural.Controls.Add(Me.lblSegundoNombre)
        Me.grpPersonaNatural.Location = New System.Drawing.Point(15, 15)
        Me.grpPersonaNatural.Margin = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Name = "grpPersonaNatural"
        Me.grpPersonaNatural.Padding = New System.Windows.Forms.Padding(4)
        Me.grpPersonaNatural.Size = New System.Drawing.Size(1208, 268)
        Me.grpPersonaNatural.TabIndex = 2
        Me.grpPersonaNatural.TabStop = False
        Me.grpPersonaNatural.Text = "Persona"
        '
        'txtLugarNacimiento
        '
        Me.txtLugarNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarNacimiento.Location = New System.Drawing.Point(740, 174)
        Me.txtLugarNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLugarNacimiento.Name = "txtLugarNacimiento"
        Me.txtLugarNacimiento.Size = New System.Drawing.Size(304, 23)
        Me.txtLugarNacimiento.TabIndex = 30
        Me.txtLugarNacimiento.Tag = "OBLIGATORIO"
        Me.txtLugarNacimiento.Visible = False
        '
        'chkAlumnoExtranjero
        '
        Me.chkAlumnoExtranjero.AutoSize = True
        Me.chkAlumnoExtranjero.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAlumnoExtranjero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlumnoExtranjero.Location = New System.Drawing.Point(437, 223)
        Me.chkAlumnoExtranjero.Margin = New System.Windows.Forms.Padding(4)
        Me.chkAlumnoExtranjero.Name = "chkAlumnoExtranjero"
        Me.chkAlumnoExtranjero.Size = New System.Drawing.Size(104, 21)
        Me.chkAlumnoExtranjero.TabIndex = 29
        Me.chkAlumnoExtranjero.Text = "Extranjero"
        Me.chkAlumnoExtranjero.UseVisualStyleBackColor = True
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(1052, 23)
        Me.SimpleButton2.LookAndFeel.SkinName = "Caramel"
        Me.SimpleButton2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(43, 34)
        Me.SimpleButton2.TabIndex = 28
        Me.SimpleButton2.Tag = "AGREGAR"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.Location = New System.Drawing.Point(435, 28)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(74, 21)
        Me.chkActivo.TabIndex = 1
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'cmbResposable
        '
        Me.cmbResposable.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbResposable.AutoCompletion = True
        Me.cmbResposable.AutoDropDown = True
        Me.cmbResposable.Caption = ""
        Me.cmbResposable.CaptionHeight = 17
        Me.cmbResposable.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbResposable.ColumnCaptionHeight = 17
        Me.cmbResposable.ColumnFooterHeight = 17
        Me.cmbResposable.ContentHeight = 18
        Me.cmbResposable.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbResposable.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbResposable.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbResposable.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbResposable.EditorHeight = 18
        Me.cmbResposable.Images.Add(CType(resources.GetObject("cmbResposable.Images"), System.Drawing.Image))
        Me.cmbResposable.ItemHeight = 15
        Me.cmbResposable.Location = New System.Drawing.Point(740, 207)
        Me.cmbResposable.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbResposable.MatchEntryTimeout = CType(2000, Long)
        Me.cmbResposable.MaxDropDownItems = CType(5, Short)
        Me.cmbResposable.MaxLength = 32767
        Me.cmbResposable.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbResposable.Name = "cmbResposable"
        Me.cmbResposable.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbResposable.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbResposable.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbResposable.Size = New System.Drawing.Size(305, 24)
        Me.cmbResposable.TabIndex = 14
        Me.cmbResposable.Tag = "OBLIGATORIO"
        Me.cmbResposable.PropBag = resources.GetString("cmbResposable.PropBag")
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(564, 213)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(107, 17)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Responsable:"
        '
        'txtCodigoMined
        '
        Me.txtCodigoMined.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoMined.Location = New System.Drawing.Point(200, 26)
        Me.txtCodigoMined.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoMined.Name = "txtCodigoMined"
        Me.txtCodigoMined.Size = New System.Drawing.Size(225, 23)
        Me.txtCodigoMined.TabIndex = 0
        Me.txtCodigoMined.Tag = "OBLIGATORIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Código MINED:"
        '
        'cmbLugarNacimiento
        '
        Me.cmbLugarNacimiento.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbLugarNacimiento.AutoCompletion = True
        Me.cmbLugarNacimiento.AutoDropDown = True
        Me.cmbLugarNacimiento.Caption = ""
        Me.cmbLugarNacimiento.CaptionHeight = 17
        Me.cmbLugarNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbLugarNacimiento.ColumnCaptionHeight = 17
        Me.cmbLugarNacimiento.ColumnFooterHeight = 17
        Me.cmbLugarNacimiento.ContentHeight = 18
        Me.cmbLugarNacimiento.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbLugarNacimiento.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbLugarNacimiento.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLugarNacimiento.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLugarNacimiento.EditorHeight = 18
        Me.cmbLugarNacimiento.Images.Add(CType(resources.GetObject("cmbLugarNacimiento.Images"), System.Drawing.Image))
        Me.cmbLugarNacimiento.ItemHeight = 15
        Me.cmbLugarNacimiento.Location = New System.Drawing.Point(740, 174)
        Me.cmbLugarNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLugarNacimiento.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLugarNacimiento.MaxDropDownItems = CType(5, Short)
        Me.cmbLugarNacimiento.MaxLength = 32767
        Me.cmbLugarNacimiento.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLugarNacimiento.Name = "cmbLugarNacimiento"
        Me.cmbLugarNacimiento.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbLugarNacimiento.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLugarNacimiento.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLugarNacimiento.Size = New System.Drawing.Size(305, 24)
        Me.cmbLugarNacimiento.TabIndex = 13
        Me.cmbLugarNacimiento.Tag = "OBLIGATORIO"
        Me.cmbLugarNacimiento.PropBag = resources.GetString("cmbLugarNacimiento.PropBag")
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.Location = New System.Drawing.Point(435, 224)
        Me.lblEdad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(0, 17)
        Me.lblEdad.TabIndex = 9
        Me.lblEdad.Tag = "OBLIGATORIO"
        '
        'cmbReligion
        '
        Me.cmbReligion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbReligion.AutoCompletion = True
        Me.cmbReligion.AutoDropDown = True
        Me.cmbReligion.Caption = ""
        Me.cmbReligion.CaptionHeight = 17
        Me.cmbReligion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbReligion.ColumnCaptionHeight = 17
        Me.cmbReligion.ColumnFooterHeight = 17
        Me.cmbReligion.ContentHeight = 18
        Me.cmbReligion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbReligion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbReligion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReligion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReligion.EditorHeight = 18
        Me.cmbReligion.Images.Add(CType(resources.GetObject("cmbReligion.Images"), System.Drawing.Image))
        Me.cmbReligion.ItemHeight = 15
        Me.cmbReligion.Location = New System.Drawing.Point(739, 139)
        Me.cmbReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbReligion.MatchEntryTimeout = CType(2000, Long)
        Me.cmbReligion.MaxDropDownItems = CType(5, Short)
        Me.cmbReligion.MaxLength = 32767
        Me.cmbReligion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbReligion.Name = "cmbReligion"
        Me.cmbReligion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbReligion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbReligion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbReligion.Size = New System.Drawing.Size(307, 24)
        Me.cmbReligion.TabIndex = 12
        Me.cmbReligion.Tag = "OBLIGATORIO"
        Me.cmbReligion.PropBag = resources.GetString("cmbReligion.PropBag")
        '
        'cmbciudad
        '
        Me.cmbciudad.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbciudad.AutoCompletion = True
        Me.cmbciudad.AutoDropDown = True
        Me.cmbciudad.Caption = ""
        Me.cmbciudad.CaptionHeight = 17
        Me.cmbciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbciudad.ColumnCaptionHeight = 17
        Me.cmbciudad.ColumnFooterHeight = 17
        Me.cmbciudad.ContentHeight = 18
        Me.cmbciudad.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbciudad.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbciudad.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbciudad.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbciudad.EditorHeight = 18
        Me.cmbciudad.Images.Add(CType(resources.GetObject("cmbciudad.Images"), System.Drawing.Image))
        Me.cmbciudad.ItemHeight = 15
        Me.cmbciudad.Location = New System.Drawing.Point(739, 28)
        Me.cmbciudad.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbciudad.MatchEntryTimeout = CType(2000, Long)
        Me.cmbciudad.MaxDropDownItems = CType(5, Short)
        Me.cmbciudad.MaxLength = 32767
        Me.cmbciudad.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbciudad.Name = "cmbciudad"
        Me.cmbciudad.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbciudad.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbciudad.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbciudad.Size = New System.Drawing.Size(305, 24)
        Me.cmbciudad.TabIndex = 10
        Me.cmbciudad.Tag = "OBLIGATORIO"
        Me.cmbciudad.PropBag = resources.GetString("cmbciudad.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(564, 180)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Lugar de nacimiento:"
        '
        'cmbGenero
        '
        Me.cmbGenero.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGenero.AutoCompletion = True
        Me.cmbGenero.AutoDropDown = True
        Me.cmbGenero.Caption = ""
        Me.cmbGenero.CaptionHeight = 17
        Me.cmbGenero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGenero.ColumnCaptionHeight = 17
        Me.cmbGenero.ColumnFooterHeight = 17
        Me.cmbGenero.ContentHeight = 18
        Me.cmbGenero.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGenero.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGenero.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGenero.EditorHeight = 18
        Me.cmbGenero.Images.Add(CType(resources.GetObject("cmbGenero.Images"), System.Drawing.Image))
        Me.cmbGenero.ItemHeight = 15
        Me.cmbGenero.Location = New System.Drawing.Point(200, 183)
        Me.cmbGenero.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGenero.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGenero.MaxDropDownItems = CType(5, Short)
        Me.cmbGenero.MaxLength = 32767
        Me.cmbGenero.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbGenero.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGenero.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGenero.Size = New System.Drawing.Size(227, 24)
        Me.cmbGenero.TabIndex = 7
        Me.cmbGenero.Tag = "OBLIGATORIO"
        Me.cmbGenero.PropBag = resources.GetString("cmbGenero.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(564, 145)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Religión:"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(435, 59)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(32, 28)
        Me.cmdBuscar.TabIndex = 3
        Me.cmdBuscar.Tag = "Buscar Existente"
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.AcceptsTab = True
        Me.dtpFechaNacimiento.AllowDrop = True
        Me.dtpFechaNacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        '
        '
        '
        Me.dtpFechaNacimiento.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.BoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.ClearText = "&Clear"
        Me.dtpFechaNacimiento.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.dtpFechaNacimiento.Calendar.SelectedDate = New Date(2016, 8, 17, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Calendar.ShowTodayCircle = False
        Me.dtpFechaNacimiento.Calendar.TodayText = "&Today"
        Me.dtpFechaNacimiento.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.dtpFechaNacimiento.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.dtpFechaNacimiento.DropDownFormAlign = C1.Win.C1Input.DropDownFormAlignmentEnum.Right
        Me.dtpFechaNacimiento.EmptyAsNull = True
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(200, 220)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(227, 23)
        Me.dtpFechaNacimiento.TabIndex = 8
        Me.dtpFechaNacimiento.Tag = Nothing
        Me.dtpFechaNacimiento.TrimStart = True
        Me.dtpFechaNacimiento.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.dtpFechaNacimiento.VisualStyle = C1.Win.C1Input.VisualStyle.System
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(200, 151)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoApellido.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(739, 62)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(436, 69)
        Me.txtDireccion.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(561, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Dirección:"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(200, 121)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerApellido.TabIndex = 5
        Me.txtPrimerApellido.Tag = "OBLIGATORIO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(561, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ciudad:"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(200, 90)
        Me.txtSegundoNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtSegundoNombre.TabIndex = 4
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(200, 59)
        Me.txtPrimerNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(225, 23)
        Me.txtPrimerNombre.TabIndex = 2
        Me.txtPrimerNombre.Tag = "OBLIGATORIO"
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(13, 224)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(163, 17)
        Me.lblFechaNacimiento.TabIndex = 14
        Me.lblFechaNacimiento.Text = "Fecha de nacimiento:"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.ForeColor = System.Drawing.Color.Black
        Me.lblSegundoApellido.Location = New System.Drawing.Point(13, 158)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(139, 17)
        Me.lblSegundoApellido.TabIndex = 12
        Me.lblSegundoApellido.Text = "Segundo apellido:"
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.Black
        Me.lblGenero.Location = New System.Drawing.Point(13, 191)
        Me.lblGenero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(67, 17)
        Me.lblGenero.TabIndex = 11
        Me.lblGenero.Tag = "OBLIGATORIO"
        Me.lblGenero.Text = "Género:"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.ForeColor = System.Drawing.Color.Black
        Me.lblPrimerApellido.Location = New System.Drawing.Point(13, 127)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(122, 17)
        Me.lblPrimerApellido.TabIndex = 10
        Me.lblPrimerApellido.Tag = "OBLIGATORIO"
        Me.lblPrimerApellido.Text = "Primer apellido:"
        '
        'lblPrimerNombre
        '
        Me.lblPrimerNombre.AutoSize = True
        Me.lblPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerNombre.ForeColor = System.Drawing.Color.Black
        Me.lblPrimerNombre.Location = New System.Drawing.Point(13, 65)
        Me.lblPrimerNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrimerNombre.Name = "lblPrimerNombre"
        Me.lblPrimerNombre.Size = New System.Drawing.Size(119, 17)
        Me.lblPrimerNombre.TabIndex = 9
        Me.lblPrimerNombre.Tag = "OBLIGATORIO"
        Me.lblPrimerNombre.Text = "Primer nombre:"
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.ForeColor = System.Drawing.Color.Black
        Me.lblSegundoNombre.Location = New System.Drawing.Point(13, 96)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(136, 17)
        Me.lblSegundoNombre.TabIndex = 8
        Me.lblSegundoNombre.Text = "Segundo nombre:"
        '
        'ErrPrv
        '
        Me.ErrPrv.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
        Me.ErrPrv.ContainerControl = Me
        '
        'ArchivoDialogo
        '
        Me.ArchivoDialogo.FileName = "OpenFileDialog1"
        Me.ArchivoDialogo.Filter = "JPEG Files | *.JPG"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.SIRA.My.Resources.Resources.BackgroundImage
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 736)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1269, 20)
        Me.Panel1.TabIndex = 26
        '
        'panelcliente
        '
        Me.panelcliente.Controls.Add(Me.SimpleButton1)
        Me.panelcliente.Controls.Add(Me.cmdGuardar)
        Me.panelcliente.Controls.Add(Me.grpDatos)
        Me.panelcliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcliente.Location = New System.Drawing.Point(0, 0)
        Me.panelcliente.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.panelcliente.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panelcliente.Margin = New System.Windows.Forms.Padding(4)
        Me.panelcliente.Name = "panelcliente"
        Me.panelcliente.Size = New System.Drawing.Size(1269, 756)
        Me.panelcliente.TabIndex = 27
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = Global.SIRA.My.Resources.Resources.cancel16x16
        Me.SimpleButton1.Location = New System.Drawing.Point(1147, 694)
        Me.SimpleButton1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.SimpleButton1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Tag = "CANCELAR"
        Me.SimpleButton1.Text = "&Cancelar"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Appearance.Options.UseFont = True
        Me.cmdGuardar.ImageOptions.Image = Global.SIRA.My.Resources.Resources.save16x16
        Me.cmdGuardar.Location = New System.Drawing.Point(1032, 694)
        Me.cmdGuardar.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.cmdGuardar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(107, 34)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Tag = "GUARDAR"
        Me.cmdGuardar.Text = "&Guardar"
        '
        'frmStbAlumnosEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 756)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelcliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStbAlumnosEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos"
        Me.grpDatos.ResumeLayout(False)
        CType(Me.TabPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane1.ResumeLayout(False)
        Me.TabEnfermedades.ResumeLayout(False)
        Me.TabEnfermedades.PerformLayout()
        CType(Me.cmbEnfermedad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdEnfermedadesTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabObservaciones.ResumeLayout(False)
        Me.TabObservaciones.PerformLayout()
        Me.TabPadre.ResumeLayout(False)
        Me.TabPadre.PerformLayout()
        CType(Me.cmbEstadoCivilP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.tabAdicionales.ResumeLayout(False)
        Me.tabContactos.ResumeLayout(False)
        Me.tabContactos.PerformLayout()
        CType(Me.tdbContactosPadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barContactos.ResumeLayout(False)
        Me.barContactos.PerformLayout()
        CType(Me.cmbReligionPadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMadre.ResumeLayout(False)
        Me.TabMadre.PerformLayout()
        CType(Me.cmbEstadoCivilM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.tdbContactosMadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.cmbReligionMadre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResponsable.ResumeLayout(False)
        Me.TabResponsable.PerformLayout()
        CType(Me.cmbEstadoCivilR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbParentesco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.tdbContactosResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmdAgregarContactoR.ResumeLayout(False)
        Me.cmdAgregarContactoR.PerformLayout()
        CType(Me.cmbReligionResponsable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonaNatural.ResumeLayout(False)
        Me.grpPersonaNatural.PerformLayout()
        CType(Me.cmbResposable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLugarNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReligion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbciudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGenero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFechaNacimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrPrv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelcliente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grpPersonaNatural As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrimerNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoNombre As System.Windows.Forms.Label
    Friend WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Friend WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Friend WithEvents txtPrimerNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents ErrPrv As System.Windows.Forms.ErrorProvider
    Friend WithEvents ArchivoDialogo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents dtpFechaNacimiento As C1.Win.C1Input.C1DateEdit
    Friend WithEvents panelcliente As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbciudad As C1.Win.C1List.C1Combo
    Friend WithEvents cmbReligion As C1.Win.C1List.C1Combo
    Friend WithEvents cmbGenero As C1.Win.C1List.C1Combo
    Friend WithEvents txtCodigoMined As System.Windows.Forms.TextBox
    Friend WithEvents cmbLugarNacimiento As C1.Win.C1List.C1Combo
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPane1 As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents TabEnfermedades As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents TabObservaciones As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents txtInformacion As System.Windows.Forms.TextBox
    Friend WithEvents txtImportancia As System.Windows.Forms.TextBox
    Friend WithEvents txtCausa As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtEspera As System.Windows.Forms.TextBox
    Friend WithEvents TabPadre As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents txtLugarTrabajoPadre As System.Windows.Forms.TextBox
    Friend WithEvents txtOcupacionPadre As System.Windows.Forms.TextBox
    Friend WithEvents txtProfesionPadre As System.Windows.Forms.TextBox
    Friend WithEvents cmbReligionPadre As C1.Win.C1List.C1Combo
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarPadre As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2Padre As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1Padre As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2Padre As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre1Padre As System.Windows.Forms.TextBox
    Friend WithEvents TabMadre As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCedulaPadre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tabAdicionales As System.Windows.Forms.TabControl
    Friend WithEvents tabContactos As System.Windows.Forms.TabPage
    Friend WithEvents tdbContactosPadre As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents barContactos As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContacto As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDireccionPadre As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tdbContactosMadre As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContactoM As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContactoM As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDireccionMadre As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCedulaMadre As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLugarTrabajoMadre As System.Windows.Forms.TextBox
    Friend WithEvents txtOcupacionMadre As System.Windows.Forms.TextBox
    Friend WithEvents txtProfesionMadre As System.Windows.Forms.TextBox
    Friend WithEvents cmbReligionMadre As C1.Win.C1List.C1Combo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarMadre As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2Madre As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1Madre As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2Madre As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre1Madre As System.Windows.Forms.TextBox
    Friend WithEvents cmbResposable As C1.Win.C1List.C1Combo
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TabResponsable As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tdbContactosResponsable As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAgregarContactoR As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdAgregarContactoResp As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEliminarContactoR As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDireccionResponsable As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtCedulaResponsable As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtLugarTrabajoResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtOcupacionResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtProfesionResponsable As System.Windows.Forms.TextBox
    Friend WithEvents cmbReligionResponsable As C1.Win.C1List.C1Combo
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cmdBuscarResponsable As System.Windows.Forms.Button
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtApellido2Responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1Responsable As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtNombre2Responsable As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre1Responsable As System.Windows.Forms.TextBox
    Friend WithEvents cmbEnfermedad As C1.Win.C1List.C1Combo
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents cmdAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdEnfermedades As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdEnfermedadesTabla As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colobjEnfermedadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdNuevaEnfermedad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents cmbParentesco As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkExtranjero As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtrajeneroM As System.Windows.Forms.CheckBox
    Friend WithEvents chkExtrajenjeroR As System.Windows.Forms.CheckBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbEstadoCivilP As C1.Win.C1List.C1Combo
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents cmbEstadoCivilM As C1.Win.C1List.C1Combo
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cmbEstadoCivilR As C1.Win.C1List.C1Combo
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chkAlumnoExtranjero As System.Windows.Forms.CheckBox
    Friend WithEvents txtLugarNacimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtNivelAcademicoP As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtNivelAcademicoM As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtNivelAcademicoR As TextBox
    Friend WithEvents Label48 As Label
End Class
