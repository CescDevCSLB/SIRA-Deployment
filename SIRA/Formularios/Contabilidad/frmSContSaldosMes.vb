Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports DAL

Public Class frmSContSaldosMes


#Region "Variables del formulario"
    Dim dtSaldos As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolActivar, boolInactivar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
    Dim intPeriodo, intMes As Integer
    Dim intTipo As Integer
#End Region

#Region "Incializar GUI"

    Property Tipo() As Integer
        Get
            Return intTipo
        End Get
        Set(ByVal value As Integer)
            intTipo = value
        End Set
    End Property

    Property Periodo() As Integer
        Get
            Return intPeriodo
        End Get
        Set(ByVal value As Integer)
            intPeriodo = value
        End Set
    End Property

    Property Mes() As Integer
        Get
            Return intMes
        End Get
        Set(ByVal value As Integer)
            intMes = value
        End Set
    End Property

    Private Sub CerrarMes(ByVal IntPeriodoID As Integer, intMes As Integer)
        Dim parametro(3) As SqlClient.SqlParameter
        Try

            parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
            parametro(0).Value = IntPeriodoID
            parametro(1) = New SqlClient.SqlParameter("@IntMes", SqlDbType.Int, 4)
            parametro(1).Value = intMes
            parametro(2) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(2).Value = clsProyecto.Conexion.Usuario
            SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "SP_CerrarPeriodoMes", parametro)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Dim objMes As New ScontMesCerrado

        Try
            ''Buscar si el mes esta mayorizado
            objMes.RetrieveByFilter("Mayorizado=0 AND objPeriodoID=" & Periodo & " AND Mes=" & Mes)

            If objMes.ScontMesCerradoID <> 0 Then
                MsgBox("No es posible cerrar el mes, debe estar mayorizado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            ''Buscar si el mes esta cerrado
            objMes.RetrieveByFilter("Cerrado=1 AND objPeriodoID=" & Periodo & " AND Mes=" & Mes)

            If objMes.ScontMesCerradoID <> 0 Then
                MsgBox("El mes seleccionado ya esta cerrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            Select Case MsgBox("¿Está seguro que desea cerrar el mes contable?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    CerrarMes(Periodo, Mes)
                    CargarGrid()
                    AplicarSeguridad()
                    MsgBox("Mes cerrado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
        End Try
    End Sub

    Private Sub cmdAperturar_Click(sender As Object, e As EventArgs) Handles cmdAperturar.Click
        Dim objMes As New ScontMesCerrado
        Dim objMesUP As New ScontMesCerrado
        Dim t As New TransactionManager
        Try
            ''Buscar si el mes esta mayorizado
            objMes.RetrieveByFilter("Cerrado=0 AND objPeriodoID=" & Periodo & " AND Mes=" & Mes)

            If objMes.ScontMesCerradoID <> 0 Then
                MsgBox("No es posible aperturar un mes que no esta cerrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            Select Case MsgBox("¿Está seguro que desea aperturar el mes contable?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes

                    t.BeginTran()

                    objMesUP.RetrieveByFilter(" objPeriodoID=" & Periodo & " AND Mes=" & Mes)
                    objMesUP.Cerrado = 0
                    objMesUP.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objMesUP.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objMesUP.Update(t)

                    t.CommitTran()
                    Tipo = 0
                    CargarGrid()
                    AplicarSeguridad()
                    MsgBox("Mes aperturado correctamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
            t.RollbackTran()
        Finally
        End Try
    End Sub

    Private Sub tsbRefrescar_Click_1(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        Tipo = 0
        CargarGrid()
    End Sub

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try
            dtSaldos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("ScontSaldosID, IDCuenta, Descripcion, objCuentaContableID, objPeriodoID, Mes, Saldo, Nivel, Anio, SaldoDeudor, SaldoAcreedor", "vwSaldosMesMayorizado", "objPeriodoID=" & Periodo & " AND Mes=" & Mes & " order by IDCuenta  asc"))

            dtSaldos.PrimaryKey = New DataColumn() {Me.dtSaldos.Columns("ScontSaldosID")}

            Me.grdPeriodo.DataSource = dtSaldos
            Me.grdPeriodo.Text = "Saldos (" & Me.dtSaldos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmSraPeriodos"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarPeriodo")
            boolConsultar = objseg.TienePermiso("ConsultarPeriodo")
            boolInactivar = objseg.TienePermiso("InactivarPeriodo")
            boolActivar = objseg.TienePermiso("EditarPeriodo")


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region


#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGrid()
        'Me.AplicarSeguridad()
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs)
        CargarGrid()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub

#End Region




End Class