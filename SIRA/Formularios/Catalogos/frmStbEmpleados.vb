Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel

Public Class frmStbEmpleados
#Region "Declaración de Variables propias del formulario"
    Dim dtEmpleados, dtEmpleadosInactivos As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir, bolAsignar As Boolean
#End Region

#Region "Cargar Grid Empleados"
    Private Sub CargarGridEmpleados()

        Try
            Me.dtEmpleados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Activo, Seleccionar, StbPersonaID, Nombre1, Nombre2, Apellido1, Apellido2, NombreCompleto, Cedula, objGeneroID, Genero, StbEmpleadoID, FechaIngreso, Direccion,Cargo", "vwStbEmpleados"))
            Me.dtEmpleados.DefaultView.Sort = "StbEmpleadoID desc"
            Me.grdEmpleados.DataSource = dtEmpleados

            If Me.dtEmpleados.DefaultView.Count = 0 Then
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

    Private Sub CargarGridEmpleadosInactivos()

        Try
            Me.dtEmpleadosInactivos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Activo, Seleccionar, StbPersonaID, Nombre1, Nombre2, Apellido1, Apellido2, NombreCompleto, Cedula, objGeneroID, Genero, StbEmpleadoID, FechaIngreso, Direccion,Cargo", "vwStbEmpleadosInactivos"))
            Me.dtEmpleadosInactivos.DefaultView.Sort = "StbEmpleadoID desc"
            Me.grdEmpleadosInactivos.DataSource = dtEmpleadosInactivos

            If Me.dtEmpleadosInactivos.DefaultView.Count = 0 Then
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

           

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar"
    Private Sub Agregar()
        Dim objPersonas As frmStbEmpleadosEditar
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbEmpleadosEditar
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridEmpleados()
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
        Dim objPersonas As frmStbEmpleadosEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor

            If XtraTabControlEmpleado.SelectedTabPage.Name = "TabActivos" Then
                Dim selectedRow As Integer() = grdEmpleadosTabla.GetSelectedRows()
                FilaActual = Me.grdEmpleadosTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    objPersonas = New frmStbEmpleadosEditar
                    objPersonas.TyGui = 2
                    objPersonas.idpersona = Me.dtEmpleados.DefaultView(FilaActual).Item("StbPersonaID")

                    If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGridEmpleados()
                        CargarGridEmpleadosInactivos()
                        Seguridad()
                    End If
                End If
            Else
                Dim selectedRow As Integer() = grdvwEmpleadosInactivos.GetSelectedRows()
                FilaActual = Me.grdvwEmpleadosInactivos.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    objPersonas = New frmStbEmpleadosEditar
                    objPersonas.TyGui = 2
                    objPersonas.idpersona = Me.dtEmpleadosInactivos.DefaultView(FilaActual).Item("StbPersonaID")

                    If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGridEmpleados()
                        CargarGridEmpleadosInactivos()
                        Seguridad()
                    End If
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
        Dim objPersonas As frmStbEmpleadosEditar
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            If XtraTabControlEmpleado.SelectedTabPage.Name = "TabActivos" Then
                Dim selectedRow As Integer() = grdEmpleadosTabla.GetSelectedRows()
                FilaActual = Me.grdEmpleadosTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    objPersonas = New frmStbEmpleadosEditar
                    objPersonas.TyGui = 3
                    objPersonas.idpersona = Me.dtEmpleados.DefaultView(FilaActual).Item("StbPersonaID")

                    objPersonas.ShowDialog(Me)
                End If
            Else
                Dim selectedRow As Integer() = grdvwEmpleadosInactivos.GetSelectedRows()
                FilaActual = Me.grdvwEmpleadosInactivos.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    objPersonas = New frmStbEmpleadosEditar
                    objPersonas.TyGui = 3
                    objPersonas.idpersona = Me.dtEmpleadosInactivos.DefaultView(FilaActual).Item("StbPersonaID")

                    objPersonas.ShowDialog(Me)
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

#Region "Eliminar"
    Private Sub Eliminar()
        Dim T As New TransactionManager
        Dim objProfesores As New StbProfesores
        Dim objEmpleado As New StbEmpleados
        Dim IDCliente As Integer
        Dim FilaActual As Integer
        Try
            If XtraTabControlEmpleado.SelectedTabPage.Name = "TabActivos" Then
                If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                    Me.Cursor = WaitCursor
                    Dim selectedRow As Integer() = grdEmpleadosTabla.GetSelectedRows()
                    FilaActual = Me.grdEmpleadosTabla.GetDataSourceRowIndex(selectedRow(0))

                    If FilaActual >= 0 Then
                        T.BeginTran()
                        IDCliente = Me.dtEmpleados.DefaultView(FilaActual).Item("StbEmpleadoID")
                        objEmpleado.Retrieve(IDCliente)
                        objEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objEmpleado.Activo = False
                        objEmpleado.Update(T)

                        objProfesores.RetrieveByFilter("objEmpleadoID=" & IDCliente)
                        objProfesores.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objProfesores.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objProfesores.Activo = False
                        objProfesores.Update(T)

                        T.CommitTran()
                        MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        CargarGridEmpleados()
                        CargarGridEmpleadosInactivos()
                    End If
                End If
            Else
                MsgBox("El empleado seleccionado ya se encuentra inactivo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)

            End If

        Catch ex As SqlClient.SqlException
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub Activar()
        Dim T As New TransactionManager
        Dim objProfesores As New StbProfesores
        Dim objEmpleado As New StbEmpleados
        Dim IDCliente As Integer
        Dim FilaActual As Integer
        Try
            If XtraTabControlEmpleado.SelectedTabPage.Name = "TabInactivos" Then
                If MsgBox("¿Está seguro de activar el registro seleccionado?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                    Me.Cursor = WaitCursor
                    Dim selectedRow As Integer() = grdvwEmpleadosInactivos.GetSelectedRows()
                    FilaActual = Me.grdvwEmpleadosInactivos.GetDataSourceRowIndex(selectedRow(0))

                    If FilaActual >= 0 Then
                        T.BeginTran()
                        IDCliente = Me.dtEmpleadosInactivos.DefaultView(FilaActual).Item("StbEmpleadoID")
                        objEmpleado.Retrieve(IDCliente)
                        objEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objEmpleado.Activo = True
                        objEmpleado.Update(T)

                        objProfesores.RetrieveByFilter("objEmpleadoID=" & IDCliente)
                        objProfesores.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objProfesores.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objProfesores.Activo = True
                        objProfesores.Update(T)

                        T.CommitTran()
                        MsgBox("Empleado activado satisfactoriamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                        CargarGridEmpleados()
                        CargarGridEmpleadosInactivos()
                    End If

                End If
            Else
                MsgBox("El empleado seleccionado ya se encuentra activo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)

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

#Region "Evento LOAD del Form"

    Private Sub frmSccClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor

            Me.CargarGridEmpleados()
            CargarGridEmpleadosInactivos()
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
        Me.dtEmpleados = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        CargarGridEmpleados()
        CargarGridEmpleadosInactivos()
        Me.Seguridad()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Me.Eliminar()
    End Sub

    Private Sub cmdActivar_Click(sender As Object, e As EventArgs) Handles cmdActivar.Click
        Activar()
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



    Private Sub grdProfesoresTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdEmpleadosTabla.DoubleClick
        Me.Editar()
    End Sub
End Class