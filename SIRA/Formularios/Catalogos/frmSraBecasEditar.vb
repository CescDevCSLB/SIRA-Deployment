Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraBecasEditar

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intBecaID As Integer
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

    Property BecaID() As Integer
        Get
            Return intBecaID
        End Get
        Set(ByVal value As Integer)
            intBecaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"

    '' Descripción:        Procedimiento encargado de mostrar los datos de una beca en modo de edición
    Public Sub CargarDatosBeca()
        Dim objBeca As SraBecas
        Try
            objBeca = New SraBecas
            objBeca.Retrieve(BecaID)

            txtDescripcion.Text = objBeca.Descripcion
            If Not String.IsNullOrEmpty(objBeca.Porcentaje) Then
                SpnPorcentaje.Value = objBeca.Porcentaje
            End If

            If objBeca.Activo.HasValue Then
                chkActivo.Checked = objBeca.Activo
            End If

            lblFechaIngreso.Text = "Fecha de Ingreso: " + objBeca.FechaCreacion

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objBeca = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Select Case TypeGui
            Case 1
                Me.Text = "Nueva beca"
                Me.chkActivo.Enabled = False
                Me.chkActivo.Checked = True

            Case 2
                Me.Text = "Editar beca"
                Me.chkActivo.Enabled = True
                Me.CargarDatosBeca()
            Case 3
                Me.Text = "Consultar beca"
                Me.CargarDatosBeca()
                Me.txtDescripcion.ReadOnly = True
                Me.SpnPorcentaje.ReadOnly = True
                Me.chkActivo.Enabled = False
                Me.cmdGuardar.Enabled = False
        End Select
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            txtDescripcion.MaxLength = SraBecas.GetMaxLength("Descripcion")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Becas"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub GuardarAsignatura()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearBeca(T)
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
    Public Sub CrearBeca(ByVal T As DAL.TransactionManager)
        Dim objBecas As SraBecas

        Try
            objBecas = New SraBecas

            objBecas.Descripcion = txtDescripcion.Text.Trim
            objBecas.Porcentaje = SpnPorcentaje.Value
            objBecas.Activo = chkActivo.Checked

            objBecas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objBecas.FechaCreacion = fechaServidor
            objBecas.Insert(T)
            BecaID = objBecas.BecaID


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Becas"

    '' Descripción:        Procedimiento encargado de actualizar beca
    Public Sub ActualizarAsignatura()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosAsignatura(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de una beca
    Public Sub ModificarDatosAsignatura(ByVal T As DAL.TransactionManager)
        Dim ObjBecas As SraBecas
        Try
            ObjBecas = New SraBecas
            ObjBecas.BecaID = BecaID
            ObjBecas.Descripcion = txtDescripcion.Text.Trim
            ObjBecas.Porcentaje = SpnPorcentaje.Value
            ObjBecas.Activo = chkActivo.Checked
            ObjBecas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            ObjBecas.FechaCreacion = fechaServidor
            ObjBecas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            ObjBecas.FechaModificacion = fechaServidor
            ObjBecas.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            ObjBecas = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
        Try
            If txtDescripcion.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtDescripcion, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If SpnPorcentaje.Value = 0 Then
                ErrorProv.SetError(SpnPorcentaje, My.Resources.MsgObligatorio)
                Return False
                Exit Function

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
        txtDescripcion.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarAsignatura()
                Case 2
                    ActualizarAsignatura()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.Clear()
        boolEditado = True
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ErrorProv.SetError(txtDescripcion, "")
        boolEditado = True
    End Sub

    Private Sub SpnPorcentaje_EditValueChanged(sender As Object, e As EventArgs) Handles SpnPorcentaje.EditValueChanged
        ErrorProv.SetError(SpnPorcentaje, "")
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
            If Me.txtDescripcion.Text.Trim.Length <> 0 Then
                Me.SpnPorcentaje.Focus()
            End If
        End If
    End Sub


    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub


#End Region


   
End Class