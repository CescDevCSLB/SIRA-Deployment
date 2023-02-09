Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraNotaBoletinEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intNotaID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Dim dtModalidad, dtPeriodos As DataTable
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

    Property NotaID() As Integer
        Get
            Return intNotaID
        End Get
        Set(ByVal value As Integer)
            intNotaID = value
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

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = -1


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
   


    '' Descripción:        Procedimiento encargado de mostrar los datos de un grupo en modo de edición
    Public Sub CargarDatosArancel()
        Dim objNotas As SraNotaBoletin
        Try
            objNotas = New SraNotaBoletin
            objNotas.Retrieve(NotaID)
            chkActivo.Checked = objNotas.Activo
            txtNota.Text = objNotas.Nota
            cmbPeriodo.SelectedValue = objNotas.objPeriodoID
            cmbModalidad.SelectedValue = objNotas.objModalidadID
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objNotas = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarModalidad()
            CargarPeriodos()

            Select Case TypeGui

                Case 1
                    chkActivo.Checked = True
                    Me.Text = "Nuevo nota de Boletín"

                Case 2
                    Me.Text = "Editar nota de Boletín"
                    Me.CargarDatosArancel()
                Case 3
                    Me.Text = "Consultar nota de Boletín"
                    Me.CargarDatosArancel()
                    Me.cmdGuardar.Enabled = False
                    Me.cmbPeriodo.Enabled = False
                    Me.cmbModalidad.Enabled = False
                    Me.txtNota.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar nota"

    '' Descripción:        Procedimiento encargado de guardar aranceles
    Public Sub GuardarNota()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearNota(T)
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
    Public Sub CrearNota(ByVal T As DAL.TransactionManager)
        Dim objNota As SraNotaBoletin

        Try
            objNota = New SraNotaBoletin
            objNota.objModalidadID = cmbModalidad.SelectedValue
            objNota.objPeriodoID = cmbPeriodo.SelectedValue
            objNota.Nota = txtNota.Text
            objNota.Activo = chkActivo.Checked
            objNota.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objNota.FechaCreacion = fechaServidor
            objNota.Insert(T)
            NotaID = objNota.SraNotaBoletinID

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Notas_Cualitativas"

    '' Descripción:        Procedimiento encargado de actualizar Notas_Cualitativas
    Public Sub Actualizarnota()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosNota(T)
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
    Public Sub ModificarDatosNota(ByVal T As DAL.TransactionManager)
        Dim objNota As SraNotaBoletin
        Try

            objNota = New SraNotaBoletin
            objNota.Retrieve(NotaID)

            objNota.objModalidadID = cmbModalidad.SelectedValue
            objNota.objPeriodoID = cmbPeriodo.SelectedValue
            objNota.Nota = txtNota.Text
            objNota.Activo = chkActivo.Checked
            objNota.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objNota.FechaModificacion = fechaServidor
            objNota.Update(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objNota = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean
      
        Try
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If cmbModalidad.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbModalidad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

            If txtNota.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtNota, My.Resources.MsgObligatorio)
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
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarNota()
                Case 2
                    Actualizarnota()
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

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        ErrorProv.SetError(cmbModalidad, "")
    End Sub

    Private Sub cmbTipoArancel_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        ErrorProv.SetError(cmbPeriodo, "")
    End Sub
    Private Sub txtNota_TextChanged(sender As Object, e As EventArgs) Handles txtNota.TextChanged
        ErrorProv.SetError(txtNota, "")
    End Sub

#End Region



   
End Class