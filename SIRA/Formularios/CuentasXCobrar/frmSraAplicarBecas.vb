Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors


Public Class frmSraAplicarBecas
#Region "Declaración de Variables propias del formulario"
    Dim dtMatriculas, dtGruposMaster, dtGrupoDetail As DataTable
    Dim dsGrupos As DataSet
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolImprimir As Boolean
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
            Me.dtMatriculas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoMED, objGrupoID, SraMatriculaAlumnos,GradoID, objAlumnoID, Alumno, Grado, Modadlidad, Beca, objPeriodoID,TipoMatricula, Periodo, Edad,TieneGrupo, objModalidadlD,Genero,Direccion, TieneBeca", "vwMatriculasBecas", "objPeriodoID=" + PeriodoID.ToString))
            frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))

            Me.dtMatriculas.DefaultView.Sort = "SraMatriculaAlumnos desc"
            Me.grdMatriculas.DataSource = dtMatriculas

            'If Me.dtMatriculas.DefaultView.Count = 0 objPeriodoID
            '    Me.cmdEditar.Enabled = False
            '    Me.cmdConsultar.Enabled = False
            '    Me.cmdInactivar.Enabled = False
            '    Me.cmdImprimir.Enabled = False
            'Else
            'If Me.bolEditar Then Me.cmdEditar.Enabled = True
            'If Me.bolConsultar Then Me.cmdConsultar.Enabled = True
            'If Me.bolEliminar Then Me.cmdInactivar.Enabled = True
            'If Me.bolImprimir Then Me.cmdImprimir.Enabled = True
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

   
#End Region

#Region "Seguridad"
    Private Sub Seguridad()
        Try

            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "frmSraAsignarGrupos"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AsignarGrupo") Then
                Me.cmdAsignarBeca.Enabled = False
            End If

            If Not objSeg.TienePermiso("CambiarGrupo") Then
                Me.cmdEditarBeca.Enabled = False
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Asignar"

    Private Function VerificarExisteExpediente()
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            Dim filas As DataRow

            frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))

            For I = 0 To grdMatriculasTabla.SelectedRowsCount() - 1
                If (grdMatriculasTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdMatriculasTabla.GetDataRow(grdMatriculasTabla.GetSelectedRows()(I)))
                End If
            Next

            If Rows.Count = 0 Then
                MsgBox("Debe seleccionar un alumno", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
            End If

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = frmAsignarBecaEditar.dtAlumnosSeleccioandos.NewRow
                filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                filas("CodigoMED") = drFilaAsignaturaEliminadas("CodigoMED")
                filas("Alumno") = drFilaAsignaturaEliminadas("Alumno")
                filas("Grado") = drFilaAsignaturaEliminadas("Grado")
                filas("objPeriodoID") = CInt(drFilaAsignaturaEliminadas("objPeriodoID"))
                filas("GradoID") = CInt(drFilaAsignaturaEliminadas("GradoID"))
                filas("Periodo") = CInt(drFilaAsignaturaEliminadas("Periodo"))
                filas("objModalidadlD") = CInt(drFilaAsignaturaEliminadas("objModalidadlD"))
                filas("SraMatriculaAlumnos") = CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))

                ''Buscar alumnos con expediente
                ' ''Generar expediente
                ' ''Buscar si existe
                Dim objCuentaverificar As SccCuentaPorCobrar = New SccCuentaPorCobrar
                objCuentaverificar.RetrieveByFilter("objAlumnoID=" & filas("objAlumnoID") & " and objPeriodoID=" & filas("objPeriodoID") & " and objGradoID= " & filas("GradoID") & " and Activa=1")

                If objCuentaverificar.SccCuentaID <> 0 Then
                    MsgBox("Selecciono alumnos con expedientes, es permitido unicamente alumnos que no tienen expediente.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                Else
                    frmAsignarBecaEditar.dtAlumnosSeleccioandos.Rows.Add(filas)
                End If
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Function VerificarSeleccion()
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            Dim filas As DataRow

            frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))


            For I = 0 To grdMatriculasTabla.SelectedRowsCount() - 1
                If (grdMatriculasTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdMatriculasTabla.GetDataRow(grdMatriculasTabla.GetSelectedRows()(I)))
                End If
            Next

            If Rows.Count = 0 Then
                MsgBox("Debe seleccionar un alumno", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
            End If

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = frmAsignarBecaEditar.dtAlumnosSeleccioandos.NewRow
                filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                filas("CodigoMED") = drFilaAsignaturaEliminadas("CodigoMED")
                filas("Alumno") = drFilaAsignaturaEliminadas("Alumno")
                filas("Grado") = drFilaAsignaturaEliminadas("Grado")
                filas("objPeriodoID") = CInt(drFilaAsignaturaEliminadas("objPeriodoID"))
                filas("GradoID") = CInt(drFilaAsignaturaEliminadas("GradoID"))
                filas("Periodo") = CInt(drFilaAsignaturaEliminadas("Periodo"))
                filas("objModalidadlD") = CInt(drFilaAsignaturaEliminadas("objModalidadlD"))
                filas("SraMatriculaAlumnos") = CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))

                If CInt(drFilaAsignaturaEliminadas("TieneBeca")) = 1 Then
                    frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))
                    MsgBox("Selecciono alumnos con becas asignadas. Debe seleccionar la opcion de cambio de beca.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                Else
                    filas("TieneBeca") = CInt(drFilaAsignaturaEliminadas("TieneBeca"))
                    frmAsignarBecaEditar.dtAlumnosSeleccioandos.Rows.Add(filas)
                End If
               
            Next
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Function VerificarSeleccionCambio()
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            Dim filas As DataRow

            frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))


            For I = 0 To grdMatriculasTabla.SelectedRowsCount() - 1
                If (grdMatriculasTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdMatriculasTabla.GetDataRow(grdMatriculasTabla.GetSelectedRows()(I)))
                End If
            Next

            If Rows.Count = 0 Then
                MsgBox("Debe seleccionar un alumno", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
            End If

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = frmAsignarBecaEditar.dtAlumnosSeleccioandos.NewRow
                filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                filas("CodigoMED") = drFilaAsignaturaEliminadas("CodigoMED")
                filas("Alumno") = drFilaAsignaturaEliminadas("Alumno")
                filas("Grado") = drFilaAsignaturaEliminadas("Grado")
                filas("objPeriodoID") = CInt(drFilaAsignaturaEliminadas("objPeriodoID"))
                filas("GradoID") = CInt(drFilaAsignaturaEliminadas("GradoID"))
                filas("Periodo") = CInt(drFilaAsignaturaEliminadas("Periodo"))
                filas("objModalidadlD") = CInt(drFilaAsignaturaEliminadas("objModalidadlD"))
                filas("SraMatriculaAlumnos") = CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))

                If CInt(drFilaAsignaturaEliminadas("TieneBeca")) = 0 Then
                    frmAsignarBecaEditar.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TieneBeca,objAlumnoID,CodigoMED,Alumno,Grado,objPeriodoID,GradoID,Periodo,objModalidadlD,SraMatriculaAlumnos", "vwMatriculasBecas", "1=0"))

                    MsgBox("Debe seleccionar alumnos con becas asignadas.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                Else
                    filas("TieneBeca") = CInt(drFilaAsignaturaEliminadas("TieneBeca"))
                    frmAsignarBecaEditar.dtAlumnosSeleccioandos.Rows.Add(filas)
                End If

            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Sub GenerarExpediente()
        Dim objAsignar As frmAsignarBecaEditar
        Try
            Me.Cursor = WaitCursor
            objAsignar = New frmAsignarBecaEditar
            objAsignar.TyGui = 2
            If objAsignar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridMatriculas()
                'Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAsignar = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub AsignarBeca()
        Dim objAsignar As frmAsignarBecaEditar
        Try
            Me.Cursor = WaitCursor
            objAsignar = New frmAsignarBecaEditar
            objAsignar.TyGui = 0
            If objAsignar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridMatriculas()
                'Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAsignar = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CambiarBeca()
        Dim objAsignar As frmAsignarBecaEditar
        Try
            Me.Cursor = WaitCursor
            objAsignar = New frmAsignarBecaEditar
            objAsignar.TyGui = 1
            If objAsignar.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGridMatriculas()
                'Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objAsignar = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Editar"
    Private Sub SeleccionarAlumnos()
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdMatriculasTabla.SelectedRowsCount() - 1
                If (grdMatriculasTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdMatriculasTabla.GetDataRow(grdMatriculasTabla.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = frmAsignarBecaEditar.dtAlumnosSeleccioandos.NewRow
                filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                filas("CodigoMED") = drFilaAsignaturaEliminadas("CodigoMED")
                filas("Alumno") = drFilaAsignaturaEliminadas("Alumno")
                filas("Grado") = drFilaAsignaturaEliminadas("Grado")
                filas("objPeriodoID") = CInt(drFilaAsignaturaEliminadas("objPeriodoID"))
                filas("GradoID") = CInt(drFilaAsignaturaEliminadas("GradoID"))
                frmAsignarBecaEditar.dtAlumnosSeleccioandos.Rows.Add(filas)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
   

    
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim imprimirgrupo As frmRptGruposAlumnos
        Try
            Me.Cursor = WaitCursor
            imprimirgrupo = New frmRptGruposAlumnos
            imprimirgrupo.PeriodoID = PeriodoID
            imprimirgrupo.ShowDialog(Me)


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
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

        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGridMatriculas()

    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs)
        Me.Imprimir()
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdEditarBeca.Click
        Try
            Me.Cursor = WaitCursor
            If VerificarSeleccionCambio() Then
                CambiarBeca()
                CargarGridMatriculas()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdGenerar_Click(sender As Object, e As EventArgs) Handles cmdGenerar.Click
        If VerificarExisteExpediente() Then
            GenerarExpediente()
        End If
    End Sub

    Private Sub grdMatriculasTabla_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdMatriculasTabla.RowStyle

        Dim View As GridView = TryCast(sender, GridView)
        Try
            If e.RowHandle >= 0 Then
                Dim estado As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TieneBeca"))

                If estado = "0" Then
                    e.Appearance.BackColor = Color.LightSteelBlue
                    e.Appearance.BackColor2 = Color.White
                ElseIf estado = "1" Then
                    e.Appearance.BackColor = Color.Aquamarine
                    e.Appearance.BackColor2 = Color.White
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub grdMatriculasTabla_MouseUp(sender As Object, e As MouseEventArgs) Handles grdMatriculasTabla.MouseUp
        If e.Button <> System.Windows.Forms.MouseButtons.Right Then Return
        popupMenu1.ShowPopup(Control.MousePosition)

    End Sub


    Private Sub cmdAsignarGrupo_Click(sender As Object, e As EventArgs) Handles cmdAsignarBeca.Click
        If VerificarSeleccion() Then
            AsignarBeca()
        End If
    End Sub

#End Region

   
End Class