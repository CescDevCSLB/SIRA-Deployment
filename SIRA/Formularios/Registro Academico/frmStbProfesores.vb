Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel

Public Class frmStbProfesores
#Region "Declaración de Variables propias del formulario"
    Dim dtProfesores As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir, bolAsignar As Boolean
#End Region

#Region "Cargar Grid Profesores"
    Private Sub CargarGridProfesores()

        Try
            Me.dtProfesores = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, Nombre1, Nombre2, Apellido1, Apellido2, NombreCompleto, Cedula, objGeneroID, Genero, StbProfesorID, FechaIngreso,Activo", "vwSraProfesores"))
            Me.dtProfesores.DefaultView.Sort = "NombreCompleto asc"
            Me.grdProfesores.DataSource = dtProfesores

            If Me.dtProfesores.DefaultView.Count = 0 Then
                Me.cmdEditar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdInactivar.Enabled = False
                Me.cmdImprimir.Enabled = False
            Else
                If Me.bolEditar Then Me.cmdEditar.Enabled = True
                If Me.bolConsultar Then Me.cmdConsultar.Enabled = True
                If Me.bolEliminar Then Me.cmdInactivar.Enabled = True
                If Me.bolImprimir Then Me.cmdImprimir.Enabled = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Seguridad"
    Private Sub Seguridad()
        Try

            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "frmStbProfesores"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AgregarProfesor") Then
                Me.cmdAgregar.Enabled = False
            End If

            If Not objSeg.TienePermiso("ModificarProfesor") Then
                Me.cmdEditar.Enabled = False
                bolEditar = False
            Else
                bolEditar = True
            End If

            If Not objSeg.TienePermiso("ConsultarProfesor") Then
                Me.cmdConsultar.Enabled = False
                bolConsultar = False
            Else
                bolConsultar = True
            End If

            If Not objSeg.TienePermiso("AnularProfesor") Then
                Me.cmdInactivar.Enabled = False
                bolEliminar = False
            Else
                bolEliminar = True
            End If

            If Not objSeg.TienePermiso("ImprimirProfesor") Then
                Me.cmdImprimir.Enabled = False
                bolImprimir = False
            Else
                bolImprimir = True
            End If

            If Not objSeg.TienePermiso("AsignarAsignaturas") Then
                Me.cmdAsignarAsignaturas.Enabled = False
                bolAsignar = False
            Else
                bolAsignar = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar"
    Private Sub Agregar()
        Dim objPersonas As frmStbProfesorEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbProfesorEditar
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridProfesores()
                Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Editar"
    Private Sub Editar()
        Dim objPersonas As frmStbProfesorEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdProfesoresTabla.GetSelectedRows()
            FilaActual = Me.grdProfesoresTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmStbProfesorEditar
                objPersonas.TyGui = 2
                objPersonas.idpersona = Me.dtProfesores.DefaultView(FilaActual).Item("StbPersonaID")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGridProfesores()
                    Seguridad()
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Consultar"
    Private Sub Consultar()
        Dim objPersonas As frmStbProfesorEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdProfesoresTabla.GetSelectedRows()
            FilaActual = Me.grdProfesoresTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmStbProfesorEditar
                objPersonas.TyGui = 3
                objPersonas.idpersona = Me.dtProfesores.DefaultView(FilaActual).Item("StbPersonaID")

                objPersonas.ShowDialog(Me)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Eliminar"
    Private Sub Eliminar()
        Dim T As New TransactionManager
        Dim objProfesores As New StbProfesores
        Dim objEmpleado As New StbEmpleados
        Dim IDCliente As Integer
        Dim FilaActual As Integer
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                Me.Cursor = WaitCursor
                Dim selectedRow As Integer() = grdProfesoresTabla.GetSelectedRows()
                FilaActual = Me.grdProfesoresTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    T.BeginTran()
                    IDCliente = Me.dtProfesores.DefaultView(FilaActual).Item("StbProfesorID")
                    objProfesores.Retrieve(IDCliente)
                    objProfesores.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objProfesores.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objProfesores.Activo = False
                    objProfesores.Update(T)

                    objEmpleado.Retrieve(objProfesores.objEmpleadoID)
                    objEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objEmpleado.Activo = False
                    objEmpleado.Update(T)

                    T.CommitTran()
                    CargarGridProfesores()
                    MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If

            End If
        Catch ex As SqlClient.SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim objVisorReporte As frmSraTipoReporteProfesor
        Try
            objVisorReporte = New frmSraTipoReporteProfesor
            objVisorReporte.ShowDialog(Me)
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Asignar grados y asignaturas"
    Private Sub AsignarGradosAsignaturas()
        Dim objPersonas As frmSraAsignaturasProfesor
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdProfesoresTabla.GetSelectedRows()
            FilaActual = Me.grdProfesoresTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmSraAsignaturasProfesor
                objPersonas.TyGui = 2
                objPersonas.idprofesor = Me.dtProfesores.DefaultView(FilaActual).Item("StbProfesorID")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGridProfesores()
                    Seguridad()
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Evento LOAD del Form"

    Private Sub frmSccClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor

            Me.CargarGridProfesores()
            Me.Seguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Otros eventos"

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.dtProfesores = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGridProfesores()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Me.Eliminar()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Me.Consultar()
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Me.Editar()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Me.Agregar()
    End Sub

#End Region

    Private Sub cmdAsignarAsignaturas_Click(sender As Object, e As EventArgs) Handles cmdAsignarAsignaturas.Click
        AsignarGradosAsignaturas()
    End Sub

    Private Sub grdProfesoresTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdProfesoresTabla.DoubleClick
        Me.Editar()
    End Sub
End Class