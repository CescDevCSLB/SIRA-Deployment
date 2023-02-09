Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraGruposEditar

#Region "Declaracion de Variables"
    Public DtGrados, DtSeccion, dtProfesores, dtPeriodos, dtModalidad As DataTable
    Public intTypeGui As Integer
    Public intGrupoID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property GrupoID() As Integer
        Get
            Return intGrupoID
        End Get
        Set(ByVal value As Integer)
            intGrupoID = value
        End Set
    End Property

#End Region

#Region "Carga de Datos"

    Private Sub CargarModalidad()
        Try
            'Modalidad
            dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))
            Me.cmbModalidad.DataSource = dtModalidad
            Me.cmbModalidad.DisplayMember = "Descripcion"
            Me.cmbModalidad.ValueMember = "StbValorCatalogoID"
            Me.cmbModalidad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbModalidad.ExtendRightColumn = True
            Me.cmbModalidad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de mostrar los datos de un grupo en modo de edición
    Public Sub CargarDatosGrupo()
        Dim objGrupo As SraGrupo
        Try
            objGrupo = New SraGrupo
            objGrupo.Retrieve(GrupoID)

            cmbPeriodo.SelectedValue = objGrupo.objPeriodoID
            cmbGrado.SelectedValue = objGrupo.objGradoID
            cmbSeccion.SelectedValue = objGrupo.objSeccionID

            If Not IsNothing(objGrupo.objGuiaID) Then
                cmbProfesor.SelectedValue = objGrupo.objGuiaID
            End If

            chkActivo.Checked = objGrupo.Activo
            chkCualitativa.Checked = objGrupo.EvaluacionCualitativa
            chkCuantitativa.Checked = objGrupo.EvaluacionCuantitativa

            If Not IsNothing(objGrupo.objModalidadID) Then
                cmbModalidad.SelectedValue = objGrupo.objModalidadID
            End If

            lblFechaIngreso.Text = "Fecha de Ingreso: " + objGrupo.FechaCreacion
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objGrupo = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarGrados()
            CargarSeccion()
            CargarProfesores()
            CargarPeriodos()
            CargarModalidad()
            Select Case TypeGui

                Case 1
                    Me.Text = "Nuevo Grupo"
                    'cmbPeriodo.SelectedValue = dtPeriodos.Select("Activo=1")(0)
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmbPeriodo.Enabled = False
                    cmdAsignar.Enabled = False
                Case 2
                    Me.Text = "Editar Grupo"
                    Me.chkActivo.Enabled = True
                    Me.CargarDatosGrupo()
                    cmdAsignar.Enabled = True
                Case 3
                    Me.Text = "Consultar Grupo"
                    Me.CargarDatosGrupo()

                    Me.cmbPeriodo.Enabled = False
                    Me.chkActivo.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    cmbSeccion.Enabled = False
                    cmbGrado.Enabled = False
                    cmbModalidad.Enabled = False
                    cmbProfesor.Enabled = False
                    chkCualitativa.Enabled = False
                    cmdAsignar.Visible = False
                    chkCuantitativa.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            'txtNombre.MaxLength = StbTienda.GetMaxLength("Nombre")
            'txtCodigo.MaxLength = StbTienda.GetMaxLength("Codigo")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Grupo"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarGrupo()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearGrupo(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de una asignatura
    Public Sub CrearGrupo(ByVal T As DAL.TransactionManager)
        Dim objGrupo As SraGrupo

        Try
            objGrupo = New SraGrupo
            objGrupo.objPeriodoID = cmbPeriodo.SelectedValue
            objGrupo.objGradoID = cmbGrado.SelectedValue
            objGrupo.objSeccionID = cmbSeccion.SelectedValue

            If cmbProfesor.Text.Trim.Length <> 0 Then
                objGrupo.objGuiaID = cmbProfesor.SelectedValue
            End If

            objGrupo.objModalidadID = cmbModalidad.SelectedValue

            objGrupo.EvaluacionCualitativa = chkCualitativa.Checked
            objGrupo.EvaluacionCuantitativa = chkCuantitativa.Checked
            objGrupo.Activo = chkActivo.Checked
            objGrupo.objModalidadID = cmbModalidad.SelectedValue

            objGrupo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objGrupo.FechaCreacion = fechaServidor
            objGrupo.Insert(T)
            GrupoID = objGrupo.SraGrupoID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Asignatura"

    '' Descripción:        Procedimiento encargado de actualizar grupo
    Public Sub ActualizarGrupo()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosGrupo(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de un grupo
    Public Sub ModificarDatosGrupo(ByVal T As DAL.TransactionManager)
        Dim objGrupo As SraGrupo
        Try

            objGrupo = New SraGrupo
            objGrupo.Retrieve(GrupoID)

            objGrupo.objPeriodoID = cmbPeriodo.SelectedValue
            objGrupo.objGradoID = cmbGrado.SelectedValue
            objGrupo.objSeccionID = cmbSeccion.SelectedValue

            If cmbProfesor.Text.Trim.Length <> 0 Then
                objGrupo.objGuiaID = cmbProfesor.SelectedValue
            End If

            objGrupo.objModalidadID = cmbModalidad.SelectedValue

            objGrupo.EvaluacionCualitativa = chkCualitativa.Checked
            objGrupo.EvaluacionCuantitativa = chkCuantitativa.Checked
            objGrupo.Activo = chkActivo.Checked

            objGrupo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objGrupo.FechaCreacion = fechaServidor
            objGrupo.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objGrupo.FechaModificacion = fechaServidor
            objGrupo.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objGrupo = Nothing
        End Try
    End Sub

#End Region

#Region "Cargar combos"

    '' Descripción:        Procedimiento encargado de cargar los valores de Grados
    Public Sub CargarGrados()
        Try
            DtGrados = SraGrado.RetrieveDT("Activo=1", "", "GradoID,Grado")

            cmbGrado.ValueMember = "GradoID"
            cmbGrado.DisplayMember = "Grado"
            cmbGrado.DataSource = DtGrados

            cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            cmbGrado.ColumnHeaders = False
            cmbGrado.ExtendRightColumn = True
            cmbGrado.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarSeccion()
        Try
            'Seccion
            DtSeccion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='SECCIÓN')"))
            Me.cmbSeccion.DataSource = DtSeccion
            Me.cmbSeccion.DisplayMember = "Descripcion"
            Me.cmbSeccion.ValueMember = "StbValorCatalogoID"
            Me.cmbSeccion.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbSeccion.ExtendRightColumn = True
            Me.cmbSeccion.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarProfesores()
        Try
            dtProfesores = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbProfesorID, NombreCompleto", "vwSraProfesores", "1=1"))

            cmbProfesor.ValueMember = "StbProfesorID"
            cmbProfesor.DisplayMember = "NombreCompleto"
            cmbProfesor.DataSource = dtProfesores

            cmbProfesor.Splits(0).DisplayColumns("StbProfesorID").Visible = False
            cmbProfesor.ColumnHeaders = False
            cmbProfesor.ExtendRightColumn = True
            cmbProfesor.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY PeriodoID DESC "))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim objGrupo As New SraGrupo
        Try
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If cmbGrado.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbGrado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If cmbSeccion.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbSeccion, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbModalidad.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbModalidad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            ''Buscar un grupo con las mismas caracteristicas en este periodo
            If TypeGui = 1 Then
                objGrupo.RetrieveByFilter("objGradoID=" & cmbGrado.SelectedValue & " AND objSeccionID=" & cmbSeccion.SelectedValue & " AND objPeriodoID=" & cmbPeriodo.SelectedValue)
                If objGrupo.SraGrupoID <> 0 Then
                    MsgBox("Ya existe un grupo con la mismo grado y sección en este período", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerPropiedades()
        ConfigurarGUI()
        'txtNombre.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarGrupo()
                Case 2
                    ActualizarGrupo()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.Clear()
        boolEditado = True
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(cmbPeriodo, "")
        boolEditado = True
    End Sub

    Private Sub frmBodegasEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'If Me.txtNombre.Text.Trim.Length <> 0 Then
            '    Me.txtCodigo.Focus()
            'End If
        End If
    End Sub


    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub


#End Region


    Private Sub cmdAsignar_Click(sender As Object, e As EventArgs) Handles cmdAsignar.Click
        Try
            Dim objPersonas As frmSraGrupoAsignaturasProfesor
            Try
                Me.Cursor = WaitCursor
                objPersonas = New frmSraGrupoAsignaturasProfesor
                objPersonas.GrupoID = intGrupoID
                objPersonas.GradoID = cmbGrado.SelectedValue
                objPersonas.ShowDialog(Me)
            Catch ex As Exception
                clsError.CaptarError(ex)
            Finally
                objPersonas = Nothing
                Me.Cursor = [Default]
            End Try
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class