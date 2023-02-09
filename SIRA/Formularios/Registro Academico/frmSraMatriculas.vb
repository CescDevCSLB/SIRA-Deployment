Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraMatriculas
#Region "Declaración de Variables propias del formulario"
    Dim dtMatriculas As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir, boolMatricular As Boolean
    Dim intPeriodoID As Integer

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

#End Region

#Region "Cargar Grid Matriculas"
    Private Sub CargarGridMatriculas()

        Try
            Me.dtMatriculas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraMatriculaAlumnos,CodigoMED,objAlumnoID,Alumno,Grado,Modadlidad,Beca,TipoMatricula,Periodo, Edad, Genero", "vwMatriculas	", "Activo=1 AND PeriodoID=" & intPeriodoID))
            Me.dtMatriculas.DefaultView.Sort = "SraMatriculaAlumnos desc"
            Me.grdClientes.DataSource = dtMatriculas

            If Me.dtMatriculas.DefaultView.Count = 0 Then
                Me.cmdEditar.Enabled = False
                Me.cmdConsultar.Enabled = False
                Me.cmdInactivar.Enabled = False
                Me.cmdImprimir.Enabled = False
                Me.cmdretirar.Enabled = False
            Else
                'If Me.bolEditar Then Me.cmdEditar.Enabled = True
                'If Me.bolConsultar Then Me.cmdConsultar.Enabled = True
                'If Me.bolEliminar Then Me.cmdInactivar.Enabled = True
                'If Me.bolImprimir Then Me.cmdImprimir.Enabled = True
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

            objSeg.ServicioUsuario = "frmSraMatriculas"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AgregarMatricula") Then
                Me.cmdAgregar.Enabled = False
            End If

            If Not objSeg.TienePermiso("EditarMatricula") Then
                Me.cmdEditar.Enabled = False
                bolEditar = False
            Else
                bolEditar = True
            End If

            If Not objSeg.TienePermiso("ConsultarMatricula") Then
                Me.cmdConsultar.Enabled = False
                bolConsultar = False
            Else
                bolConsultar = True
            End If

            If Not objSeg.TienePermiso("InactivarMatricula") Then
                Me.cmdInactivar.Enabled = False
                bolEliminar = False
            Else
                bolEliminar = True
            End If

            If Not objSeg.TienePermiso("InactivarMatricula") Then
                Me.cmdretirar.Enabled = False
                bolEliminar = False
            Else
                bolEliminar = True
            End If

            If Not objSeg.TienePermiso("ImprimirMatricula") Then
                Me.cmdImprimir.Enabled = False
                bolImprimir = False
            Else
                bolImprimir = True
            End If

            If Not objSeg.TienePermiso("Matricular") Then
                Me.cmbMatricular.Enabled = False
                boolMatricular = False
            Else
                boolMatricular = True
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar"
    Private Sub Agregar()
        Dim objPersonas As frmSraMatriculaEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmSraMatriculaEdit
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridMatriculas()
                'Seguridad()
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
        Dim objPersonas As frmSraMatriculaEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmSraMatriculaEdit
                objPersonas.TyGui = 2
                objPersonas.idMatriculaAlumno = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGridMatriculas()
                    'Seguridad()
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

#Region "Retirar"

    Private Sub Retirar()
        Dim objPersonas As frmRetirarMatricula
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmRetirarMatricula

                objPersonas.MatriculaID = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")
                objPersonas.Alumno = Me.dtMatriculas.DefaultView(FilaActual).Item("Alumno")
                objPersonas.Grupo = Me.dtMatriculas.DefaultView(FilaActual).Item("Grado")

                If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    CargarGridMatriculas()
                    'Seguridad()
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
        Dim objPersonas As frmSraMatriculaEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                objPersonas = New frmSraMatriculaEdit
                objPersonas.TyGui = 3
                objPersonas.idMatriculaAlumno = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")

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
        Dim objMatricula As New SraMatricula_Alumnos
        Dim IDMatricula As Integer
        Dim FilaActual As Integer
        Dim objCuentaCobrar As SccCuentaPorCobrar
        Dim objCuentaverificarDetalle As SccCuentaPorCobrarDetalle
        Dim objrecibo As SccReciboCaja
        Dim intReciboAnulado As Integer
        Try

            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.Cursor = WaitCursor
                Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
                FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    T.BeginTran()
                    IDMatricula = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")
                    intReciboAnulado = ClsCatalogos.GetValorCatalogoID("ESTADOROC", "ANULADO")

                    ''Buscamos la cuenta relacionada a esta matricula
                    objCuentaCobrar = New SccCuentaPorCobrar
                    objCuentaverificarDetalle = New SccCuentaPorCobrarDetalle

                    objMatricula.Retrieve(IDMatricula)
                    objCuentaCobrar.RetrieveByFilter("objAlumnoID=" & objMatricula.objAlumnoID & " and objPeriodoID=" & objMatricula.objPeriodoID & " and objGradoID= " & objMatricula.objGradoID & " and Activa=1", T)

                    ''Verificar si la cuenta no tienen ningun movimiento y se puede eliminar para generar una nueva
                    objCuentaverificarDetalle.RetrieveByFilter("objSccCuentaPorCobrarID=" & objCuentaCobrar.SccCuentaID & " AND MontoPagado <> 0", T)
                    objrecibo = New SccReciboCaja

                    If objCuentaverificarDetalle.SccCuentaPorCobrarDetalleID = 0 Then
                        ''Verificar si hay recibos asociados a el
                        objrecibo.RetrieveByFilter("objSccCuentaID=" & objCuentaCobrar.SccCuentaID & " AND EsPagoPrestamo=0 AND objEstadoID <> " & intReciboAnulado, T)

                        If objrecibo.SccReciboCajaID = 0 Then
                            ''Eliminar la cuenta y su detalle
                            SccCuentaPorCobrarDetalle.DeleteByFilter("objSccCuentaPorCobrarID= " & objCuentaCobrar.SccCuentaID, T)
                            SccCuentaPorCobrar.DeleteByFilter("SccCuentaID=" & objCuentaCobrar.SccCuentaID, T)

                            objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor

                            objMatricula.Activo = False
                            objMatricula.Update(T)
                            T.CommitTran()
                            MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                            CargarGridMatriculas()
                        Else
                            MsgBox("No es posible eliminar la matricula, tiene expediente con movimientos.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        End If
                    Else
                        MsgBox("No es posible eliminar la matricula, tiene expediente con movimientos.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    End If
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
        Dim ds As DataSet
        Dim FilaActual As Integer
        Dim idMatricula As Integer
        Try
            Dim objjReporte As New rptMatricula()
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                idMatricula = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" SraMatriculaAlumnos, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, Nombres, Apellido1, Apellido2, CodigoMED, Periodo, LugarNacimiento, FechaNacimiento, Direccion, Modalidad, LugarFecha, CentroProcedencia, Grado, cedula, Parentesto, ParienteID, NombreFamiliar, NivelAcademico, Ocupacion, EstadoCivil, TelefonoCasa, TelefonoTrabajo, TelefonoCelular, Recomendaciones, CausaIngreso, Espera, InformacionCentro, Importancia, Foto,Observaciones,Profesion", "vwRptMatricula", "SraMatriculaAlumnos=" + idMatricula.ToString))

                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
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

            Me.CargarGridMatriculas()
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
        Me.dtMatriculas = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGridMatriculas()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs)
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

    Private Sub cmdretirar_Click(sender As Object, e As EventArgs) Handles cmdretirar.Click
        Retirar()
    End Sub

#End Region

    Private Sub cmbMatricular_Click(sender As Object, e As EventArgs) Handles cmbMatricular.Click
        Me.Editar()
    End Sub

    Private Sub grdClientesTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdClientesTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdClientesTabla.GetSelectedRows()
            FilaActual = Me.grdClientesTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.dtMatriculas.DefaultView.Item(FilaActual)("TipoMatricula").ToString.Trim.Length <> 0 Then
                    Me.cmbMatricular.Enabled = Me.boolMatricular And (Me.dtMatriculas.DefaultView.Item(FilaActual)("TipoMatricula") = "Pre matrícula")
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ImprimirSeleccionadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirSeleccionadoToolStripMenuItem.Click
        Imprimir()
    End Sub

    Private Sub ImprimirConFiltroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirConFiltroToolStripMenuItem.Click
        Dim objReporteMatriculas As frmSraRptMatriculas
        Try
            Me.Cursor = WaitCursor
            objReporteMatriculas = New frmSraRptMatriculas
            objReporteMatriculas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objReporteMatriculas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
End Class