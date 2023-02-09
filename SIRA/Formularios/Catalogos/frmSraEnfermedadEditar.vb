Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos

Public Class frmSraEnfermedadEditar

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
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
#End Region

#Region "Procedimientos"

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Select Case TypeGui
            Case 1
                Me.Text = "Nueva Enfermedad"
        End Select
    End Sub

#End Region

#Region "Guardar Enfermedad"

    '' Descripción:        Procedimiento encargado de guardar la enfermedad
    Public Sub GuardarEnfermedad()
        Dim T As New DAL.TransactionManager
        Dim intCatalogoID As Integer
        Dim objValorCatalogo, objValorCatalogoUP As StbValorCatalogo
        Dim row As DataRow
        Try
            T.BeginTran()
            'Buscar el codido de catalogo para enfermedades
            row = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbCatalogoID", "StbCatalogo", "Nombre='ENFERMEDAD'"), T).Rows(0)
            intCatalogoID = row("StbCatalogoID")

            objValorCatalogo = New StbValorCatalogo
            objValorCatalogo.objCatalogoID = intCatalogoID
            objValorCatalogo.Codigo = String.Empty
            objValorCatalogo.Descripcion = txtNombre.Text
            objValorCatalogo.Activo = True
            objValorCatalogo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objValorCatalogo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objValorCatalogo.Insert(T)

            'Buscar el codido de catalogo para enfermedades
            objValorCatalogoUP = New StbValorCatalogo
            objValorCatalogoUP.Retrieve(objValorCatalogo.StbValorCatalogoID, T)
            objValorCatalogoUP.Codigo = objValorCatalogo.StbValorCatalogoID
            objValorCatalogoUP.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objValorCatalogoUP.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objValorCatalogoUP.Update(T)

            T.CommitTran()
            frmStbAlumnosEdit.enfermedadID = objValorCatalogo.StbValorCatalogoID

            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If txtNombre.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNombre, My.Resources.MsgObligatorio)
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
    Public Sub EstablecerPropiedades()
        Try
            txtNombre.MaxLength = StbValorCatalogo.GetMaxLength("Descripcion")
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerPropiedades()
        ConfigurarGUI()
        txtNombre.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarEnfermedad()
            
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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.txtNombre.Text.Trim.Length <> 0 Then
                Me.cmdGuardar.Focus()
            End If
        End If
    End Sub



#End Region


End Class