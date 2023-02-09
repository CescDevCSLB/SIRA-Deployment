Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel
Imports DevExpress.XtraReports.UI

Public Class frmStbAlumnos
#Region "Declaración de Variables propias del formulario"
    Dim dtAlumnos As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir As Boolean
#End Region

#Region "Cargar Grid Alumnos"
    Private Sub CargarGridClientes()

        Try
            Me.dtAlumnos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID, NombreCompleto, Cedula, objGeneroID, Genero, AlumnoID, CodigoMED, Edad, Activo", "vwSraAlumnosTodos", "LEN(RTRIM(LTRIM(NombreCompleto)))>0"))
            Me.dtAlumnos.DefaultView.Sort = "AlumnoID DESC"
            Me.grdClientes.DataSource = dtAlumnos

            If Me.dtAlumnos.DefaultView.Count = 0 Then
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

            objSeg.ServicioUsuario = "frmStbAlumnos"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AgregarAlumnos") Then
                Me.cmdAgregar.Enabled = False
            End If

            If Not objSeg.TienePermiso("ModificarAlumnos") Then
                Me.cmdEditar.Enabled = False
                bolEditar = False
            Else
                bolEditar = True
            End If

            If Not objSeg.TienePermiso("ConsultarAlumnos") Then
                Me.cmdConsultar.Enabled = False
                bolConsultar = False
            Else
                bolConsultar = True
            End If

            If Not objSeg.TienePermiso("DesactivarAlumnos") Then
                Me.cmdInactivar.Enabled = False
                bolEliminar = False
            Else
                bolEliminar = True
            End If

            If Not objSeg.TienePermiso("ImprimirAlumnos") Then
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
        Dim objPersonas As frmStbAlumnosEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbAlumnosEdit
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridClientes()
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
        Dim objPersonas As frmStbAlumnosEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmStbAlumnosEdit
                objPersonas.TyGui = 2
                objPersonas.idpersona = Me.dtAlumnos.DefaultView(FilaActual).Item("StbPersonaID")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGridClientes()
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
        Dim objPersonas As frmStbAlumnosEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmStbAlumnosEdit
                objPersonas.TyGui = 3
                objPersonas.idpersona = Me.dtAlumnos.DefaultView(FilaActual).Item("StbPersonaID")

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
        'Dim T As New TransactionManager
        'Dim objClientes As New SccClientes
        'Dim IDCliente As Integer
        'Dim FilaActual As Integer
        'Try
        '    If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
        '        Me.Cursor = WaitCursor
        '        Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
        '        FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
        '        If FilaActual >= 0 Then
        '            T.BeginTran()
        '            IDCliente = Me.dtCliente.DefaultView(FilaActual).Item("ClienteID")
        '            objClientes.Retrieve(IDCliente)
        '            objClientes.UsuarioModificacion = clsProyecto.Conexion.Usuario
        '            objClientes.FechaModificacion = clsProyecto.Conexion.FechaServidor
        '            objClientes.Activo = False
        '            objClientes.Update()
        '            T.CommitTran()
        '            MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
        '        End If

        '    End If
        'Catch ex As SqlClient.SqlException
        '    T.RollbackTran()
        '    clsError.CaptarError(ex)
        'Finally
        '    Me.Cursor = [Default]
        'End Try
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim ds As DataSet
        Try
            Dim objjReporte As New rptAlumnos()

            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, StbPersonaID, NombreCompleto, objGeneroID, Genero, AlumnoID, CodigoMED, Edad", "vwSraAlumnos", ))

            If ds.Tables(0).Rows.Count <> 0 Then
                objjReporte.DataSource = ds
                objjReporte.DataMember = ds.Tables(0).TableName
                Dim pt As New ReportPrintTool(objjReporte)
                pt.ShowPreview()
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Evento LOAD del Form"

    Private Sub frmSccClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor

            Me.CargarGridClientes()
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
        Me.dtAlumnos = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGridClientes()
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

    Private Sub grdClientesTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdClientesTabla.DoubleClick
        Me.Editar()
    End Sub

    Private Sub cmdDescargar_Click(sender As Object, e As EventArgs) Handles cmdDescargar.Click
        Dim selectperiodo As frmSraSeleccionarPeriodo
        Dim FilaActual As Integer
        Dim MS As System.IO.MemoryStream
        Try
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                selectperiodo = New frmSraSeleccionarPeriodo
                selectperiodo.TypeGui = 3
                If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim objSraMatricula_Alumnos As New SraMatricula_Alumnos
                    frmPrincipal.glbPeriodoSeleccionado = selectperiodo.intPeriodoID
                    objSraMatricula_Alumnos.RetrieveByFilter("objPeriodoID=" & frmPrincipal.glbPeriodoSeleccionado & " AND objAlumnoID=" & Me.dtAlumnos.DefaultView(FilaActual).Item("AlumnoID") & " AND Activo=1")

                    If Not IsNothing(objSraMatricula_Alumnos.Foto) Then
                        MS = New System.IO.MemoryStream(objSraMatricula_Alumnos.Foto)
                        If Not IsNothing(MS) Then
                            OFDFoto.Filter = "Jpg Image|*.jpg|Bmp Image|*.bmp|Png Image|*.png"
                            OFDFoto.FileName = "Foto"
                            OFDFoto.AddExtension = True
                            If Me.OFDFoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                                Image.FromStream(MS).Save(OFDFoto.FileName, Imaging.ImageFormat.Jpeg)
                            End If
                        End If
                    Else
                        MsgBox("No existe foto para descargar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub
End Class