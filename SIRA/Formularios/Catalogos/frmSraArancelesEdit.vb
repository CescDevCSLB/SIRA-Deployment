Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraArancelesEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intArancelID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Dim dtGrado, dtMoneda, dtTipoArancel As DataTable
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

    Property ArancelID() As Integer
        Get
            Return intArancelID
        End Get
        Set(ByVal value As Integer)
            intArancelID = value
        End Set
    End Property

#End Region

#Region "Carga de Datos"

    Private Sub CargarGrados()
        Try
            dtGrado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID,Grado", "SraGrado", "Activo=1"))
            Me.cmbGrado.DataSource = dtGrado
            Me.cmbGrado.DisplayMember = "Grado"
            Me.cmbGrado.ValueMember = "GradoID"
            Me.cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            Me.cmbGrado.ExtendRightColumn = True
            Me.cmbGrado.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarMoneda()
        Try
            'Moneda
            dtMoneda = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MONEDA')"))
            Me.cmbMoneda.DataSource = dtMoneda
            Me.cmbMoneda.DisplayMember = "Descripcion"
            Me.cmbMoneda.ValueMember = "StbValorCatalogoID"
            Me.cmbMoneda.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbMoneda.ExtendRightColumn = True
            Me.cmbMoneda.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarTipoArancel()
        Try
            'Tipo de arancel
            dtTipoArancel = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOARANCEL')"))
            Me.cmbTipoArancel.DataSource = dtTipoArancel
            Me.cmbTipoArancel.DisplayMember = "Descripcion"
            Me.cmbTipoArancel.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoArancel.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoArancel.ExtendRightColumn = True
            Me.cmbTipoArancel.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


    '' Descripción:        Procedimiento encargado de mostrar los datos de un grupo en modo de edición
    Public Sub CargarDatosArancel()
        Dim objAranceles As SraAranceles
        Try
            objAranceles = New SraAranceles
            objAranceles.Retrieve(ArancelID)

            spnValor.Text = objAranceles.Valor
            cmbMoneda.SelectedValue = objAranceles.objMonedaID
            cmbTipoArancel.SelectedValue = objAranceles.objTipoArancelID
            cmbGrado.SelectedValue = objAranceles.objGradoID
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAranceles = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarGrados()
            CargarMoneda()
            CargarTipoArancel()
            Select Case TypeGui

                Case 1
                    Me.Text = "Nuevo catalogo de arancel"

                Case 2
                    Me.Text = "Editar catalogo de arancel"
                    Me.CargarDatosArancel()
                Case 3
                    Me.Text = "Consultar catalogo de arancel"
                    Me.CargarDatosArancel()
                    Me.cmdGuardar.Enabled = False

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar aranceles"

    '' Descripción:        Procedimiento encargado de guardar aranceles
    Public Sub GuardarArancel()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearArancel(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos del arancel
    Public Sub CrearArancel(ByVal T As DAL.TransactionManager)
        Dim objArancel As SraAranceles

        Try
            objArancel = New SraAranceles
            objArancel.objGradoID = cmbGrado.SelectedValue
            objArancel.objMonedaID = cmbMoneda.SelectedValue
            objArancel.objTipoArancelID = cmbTipoArancel.SelectedValue
            objArancel.Valor = spnValor.EditValue
            objArancel.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objArancel.FechaCreacion = fechaServidor
            objArancel.Insert(T)
            ArancelID = objArancel.SraArancelID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Notas_Cualitativas"

    '' Descripción:        Procedimiento encargado de actualizar Notas_Cualitativas
    Public Sub ActualizarArancel()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosArancel(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de un grNotas_Cualitativasupo
    Public Sub ModificarDatosArancel(ByVal T As DAL.TransactionManager)
        Dim objArancel As SraAranceles
        Try

            objArancel = New SraAranceles
            objArancel.Retrieve(ArancelID)

            objArancel.objGradoID = cmbGrado.SelectedValue
            objArancel.objMonedaID = cmbMoneda.SelectedValue
            objArancel.objTipoArancelID = cmbTipoArancel.SelectedValue
            objArancel.Valor = spnValor.EditValue
            objArancel.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objArancel.FechaModificacion = fechaServidor
            objArancel.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objArancel = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Dim objArancel As New SraAranceles
        Dim dtValidar As DataTable
        Try
            If cmbTipoArancel.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbTipoArancel, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbGrado.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbGrado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If spnValor.Text.Trim.Length = 0 Then
                ErrorProv.SetError(spnValor, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbMoneda.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbMoneda, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If TypeGui = 1 Then
                ''verificar si existe un arancel de este tipo
                dtValidar = SraAranceles.RetrieveDT("objGradoID=" & cmbGrado.SelectedValue & " AND objTipoArancelID=" & cmbTipoArancel.SelectedValue)
                If dtValidar.Rows.Count > 0 Then
                    MsgBox("Ya Existe un arancel de este tipo en dicha modalidad.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If

            If TypeGui = 2 Then
                ''verificar si existe un arancel de este tipo
                dtValidar = SraAranceles.RetrieveDT("SraArancelID <> " & intArancelID & " AND objGradoID=" & cmbGrado.SelectedValue & " AND objTipoArancelID=" & cmbTipoArancel.SelectedValue)
                If dtValidar.Rows.Count = 1 Then
                    MsgBox("Ya Existe un arancel de este tipo en dicha modalidad.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
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
        ConfigurarGUI()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarArancel()
                Case 2
                    ActualizarArancel()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.Clear()
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

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbGrado.TextChanged
        ErrorProv.SetError(cmbGrado, "")
    End Sub

    Private Sub spnHasta_TextChanged(sender As Object, e As EventArgs) Handles spnValor.TextChanged
        ErrorProv.SetError(spnValor, "")
    End Sub

    Private Sub cmbTipoArancel_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoArancel.TextChanged
        ErrorProv.SetError(cmbTipoArancel, "")
    End Sub

    Private Sub cmbMoneda_TextChanged(sender As Object, e As EventArgs) Handles cmbMoneda.TextChanged
        ErrorProv.SetError(cmbMoneda, "")
    End Sub
#End Region


   
End Class