Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSContPeriodoContableEditar

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intPeriodoID As Integer
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

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos"

#Region "Carga de Datos"

    '' Descripción:        Procedimiento encargado de mostrar los datos de una bodega en modo de edición
    Public Sub CargarDatosPeriodo()
        Dim objPeriodo As SContPeriodos
        Try
            objPeriodo = New SContPeriodos
            objPeriodo.Retrieve(PeriodoID)

            spnPeriodo.Value = objPeriodo.Periodo

            If objPeriodo.Activo.HasValue Then
                chkActivo.Checked = objPeriodo.Activo
            End If

            lblFechaIngreso.Text = "Fecha de Ingreso: " + objPeriodo.FechaCreacion

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPeriodo = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Select Case TypeGui
            Case 1
                Me.Text = "Nuevo Periodo contable"
                Me.chkActivo.Enabled = False
                Me.chkActivo.Checked = True

            Case 2
                Me.Text = "Editar Periodo contable"
                Me.chkActivo.Enabled = True
                Me.CargarDatosPeriodo()
            Case 3
                Me.Text = "Consultar Periodo contable"
                Me.CargarDatosPeriodo()
                Me.spnPeriodo.Enabled = False
                Me.chkActivo.Enabled = False
                Me.cmdGuardar.Enabled = False
        End Select
    End Sub

#End Region

#Region "Guardar Periodo"

    '' Descripción:        Procedimiento encargado de guardar periodo
    Public Sub Guardarperiodo()
        Dim T As New DAL.TransactionManager
        Try

            T.BeginTran()
            CrearPeriodo(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de un periodo
    Public Sub CrearPeriodo(ByVal T As DAL.TransactionManager)
        Dim objPeriodo As SContPeriodos
        Dim parametro(3) As SqlClient.SqlParameter
        Try
            objPeriodo = New SContPeriodos

            objPeriodo.Periodo = spnPeriodo.Value
            objPeriodo.Activo = chkActivo.Checked

            objPeriodo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objPeriodo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objPeriodo.Insert(T)
            PeriodoID = objPeriodo.SContPeriodoID
            PeriodoID = objPeriodo.SContPeriodoID

            parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
            parametro(0).Value = intPeriodoID
            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "SP_InsertarPeriodoMes", parametro)



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Asignatura"

    '' Descripción:        Procedimiento encargado de actualizar tienda
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

    '' Descripción:        Procedimiento encargado de modificar los datos de una tienda
    Public Sub ModificarDatosAsignatura(ByVal T As DAL.TransactionManager)
        Dim objPeriodo As SContPeriodos
        Try
            objPeriodo = New SContPeriodos
            objPeriodo.SContPeriodoID = PeriodoID
            objPeriodo.Periodo = spnPeriodo.Value
            objPeriodo.Activo = chkActivo.Checked
            objPeriodo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objPeriodo.FechaCreacion = fechaServidor
            objPeriodo.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPeriodo.FechaModificacion = fechaServidor
            objPeriodo.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPeriodo = Nothing
        End Try
    End Sub

#End Region

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If spnPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(spnPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If spnPeriodo.Value = 0 Then
                ErrorProv.SetError(spnPeriodo, My.Resources.MsgObligatorio)
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

        ConfigurarGUI()
        spnPeriodo.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    Guardarperiodo()
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
            If Me.spnPeriodo.Text.Trim.Length <> 0 Then
                Me.chkActivo.Focus()
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