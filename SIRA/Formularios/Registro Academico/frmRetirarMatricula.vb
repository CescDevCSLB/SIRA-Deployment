Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmRetirarMatricula

#Region "Declaracion de Variables"
    Public dtPeriodos, dtMeses As DataTable
    Public intMatricula As Integer
    Public strAlumno, strGrupo As String
#End Region

#Region "Propiedades"
    Property MatriculaID() As Integer
        Get
            Return intMatricula
        End Get
        Set(ByVal value As Integer)
            intMatricula = value
        End Set
    End Property

    Property Alumno() As String
        Get
            Return strAlumno
        End Get
        Set(ByVal value As String)
            strAlumno = value
        End Set
    End Property

    Property Grupo() As String
        Get
            Return strGrupo
        End Get
        Set(ByVal value As String)
            strGrupo = value
        End Set
    End Property

#End Region

#Region "Configruacion"


    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            Me.txtCedula.Text = strGrupo
            Me.txtNombre.Text = strAlumno
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub



    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If dtFechaMatricula.Text.Trim.Length = 0 Then
                ErrorProv.SetError(dtFechaMatricula, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function



    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtFechaMatricula_TextChanged(sender As Object, e As EventArgs) Handles dtFechaMatricula.TextChanged
        Me.ErrorProv.SetError(dtFechaMatricula, "")
    End Sub

    Private Sub ActualizarSaldo(T As DAL.TransactionManager, intCuentaID As Integer, intMes As Integer)

        Dim parametro(3) As SqlClient.SqlParameter

        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Try
            parametro(0) = New SqlClient.SqlParameter("@CuentaID ", SqlDbType.Int, 4)
            parametro(0).Value = intCuentaID

            parametro(1) = New SqlClient.SqlParameter("@Mes ", SqlDbType.Int, 4)
            parametro(1).Value = intMes

            parametro(2) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(2).Value = clsProyecto.Conexion.Usuario

            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "sp_SccActualizarDetalleCuentas_Retiro", parametro)

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New TransactionManager
        Dim objMatricula As New SraMatricula_Alumnos
        Dim objRetiro As New SraRetiroMatricula
        Dim intMes, intPeriodo, intAlumnoID, intGradoID, IntCuenta As Integer
        Dim dtFecha As DateTime
        Dim objCuentaCobrar As New SccCuentaPorCobrar
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        '' Dim dtDetalleCuenta As 
        Try

            If ValidarEntrada() Then
                ''Inactivar Matricula
                T.BeginTran()
                objMatricula.Retrieve(intMatricula)
                objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objMatricula.Activo = False
                objMatricula.Update(T)

                ''Insertar registro
                objRetiro.objMatriculaID = intMatricula
                objRetiro.FechaEgreso = dtFechaMatricula.Value
                objRetiro.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objRetiro.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objRetiro.Insert(T)

                ''Inactivar expediente
                ''Buscar el mes en que se retiro
                dtFecha = dtFechaMatricula.Value
                intMes = dtFecha.Date.Month

                intAlumnoID = objMatricula.objAlumnoID
                intPeriodo = objMatricula.objPeriodoID
                intGradoID = objMatricula.objGradoID

                objCuentaCobrar.RetrieveByFilter("objAlumnoID=" & intAlumnoID & " AND objPeriodoID=" & intPeriodo & " AND objGradoID=" & intGradoID, T)
                IntCuenta = objCuentaCobrar.SccCuentaID

                ActualizarSaldo(T, IntCuenta, intMes)

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub
#End Region









End Class