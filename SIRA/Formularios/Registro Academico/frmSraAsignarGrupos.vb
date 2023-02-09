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


Public Class frmSraAsignarGrupos
#Region "Declaración de Variables propias del formulario"
    Dim dtMatriculas, dtGruposMaster, dtGrupoDetail, dtSeleccionados As DataTable
    Dim dsGrupos As DataSet
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir As Boolean
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

    Private Sub GuardarCodigo()
        Dim objGrupoAlumno As New SraAlumno_Grupo
        Dim valor, codigo As Integer
        Dim selectedRow As Integer()
        Try
            selectedRow = grdGrupoDetalleTabla.GetSelectedRows()
            If Not IsNothing(selectedRow(0)) Then
                valor = grdGrupoDetalleTabla.GetRowCellValue(selectedRow(0), "SraAlumno_GrupoID")
                codigo = grdGrupoDetalleTabla.GetRowCellValue(selectedRow(0), "Codigo")

                If selectedRow(0) >= 0 Then
                    objGrupoAlumno.Retrieve(valor)
                    objGrupoAlumno.Codigo = codigo
                    objGrupoAlumno.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objGrupoAlumno.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objGrupoAlumno.Update()

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objGrupoAlumno = Nothing
        End Try
    End Sub
    Private Sub CargarGruposAlumnos()
        Try

            dtGruposMaster = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct SraGrupoID,PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad", "vwGrupoMaster", "Activo=1 AND PeriodoID=" & PeriodoID.ToString & "  ORDER BY SraGrupoID DESC"))
            dtGrupoDetail = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraAlumno_GrupoID, objGrupoID, Codigo, NombreCompleto, Genero, Edad,Escuela", "vwGrupoDetail", "1=1 "))

            dsGrupos = New DataSet

            dsGrupos.Merge(dtGruposMaster)
            dsGrupos.Tables(0).TableName = "SraGrupoMaster"

            dsGrupos.Merge(dtGrupoDetail)
            dsGrupos.Tables(1).TableName = "SraGrupoDetail"

            dsGrupos.Relations.Add("SraGrupo_SraGrupoDetalle", dsGrupos.Tables(0).Columns("SraGrupoID"), dsGrupos.Tables(1).Columns("objGrupoID"), False)

            Me.grdGrupoMaster.DataSource = dsGrupos
            Me.grdGrupoMaster.DataMember = "SraGrupoMaster"

            Me.grdGrupoDetalle.DataSource = dsGrupos
            Me.grdGrupoDetalle.DataMember = "SraGrupoMaster.SraGrupo_SraGrupoDetalle"

            Me.grdGrupoMaster.Text = "Grupos (" & Me.grdGrupoMasterTabla.RowCount & ")"

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub CargarGridMatriculas()

        Try
            Me.dtMatriculas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" CodigoMED, objGrupoID, SraMatriculaAlumnos,GradoID, objAlumnoID, Alumno, Grado, Modadlidad, Beca, objPeriodoID,TipoMatricula, Periodo, Edad,TieneGrupo, objModalidadlD,Genero,Direccion,EscuelaProcedente", "vwMatriculasAsignar", " Activo=1 AND  objPeriodoID=" + PeriodoID.ToString))
            frmGrupoSelector.dtAlumnosSeleccioandos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objAlumnoID,SraMatriculaAlumnos,objModalidadlD", "vwMatriculas", "1=0"))
            dtSeleccionados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CodigoMED, objGrupoID, SraMatriculaAlumnos,GradoID, objAlumnoID, Alumno, Grado, Modadlidad, Beca, objPeriodoID,TipoMatricula, Periodo, Edad,TieneGrupo, objModalidadlD,Genero,Direccion,EscuelaProcedente", "vwMatriculasAsignar", "1=0"))

            Me.dtMatriculas.DefaultView.Sort = "SraMatriculaAlumnos desc"
            Me.grdMatriculas.DataSource = dtMatriculas

            Me.grdSeleccion.DataSource = dtSeleccionados

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

    Private Sub VerDetalleGrupo()
        Dim VerDetalle As New frmSraGruposEditar
        Dim FilaActual As Integer
        Dim intSeleccionados As Integer = 0
        Dim Rows As New ArrayList()
        Dim I As Integer
        Dim valor As Integer
        Try
            Try
                For I = 0 To grdMatriculasTabla.SelectedRowsCount() - 1
                    If (grdMatriculasTabla.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(grdMatriculasTabla.GetDataRow(grdMatriculasTabla.GetSelectedRows()(I)))
                        intSeleccionados = intSeleccionados + 1
                    End If
                Next

                If intSeleccionados = 1 Then
                    Dim selectedRow As Integer() = grdMatriculasTabla.GetSelectedRows()
                    FilaActual = Me.grdMatriculasTabla.GetDataSourceRowIndex(selectedRow(0))

                    If Not IsDBNull(grdMatriculasTabla.GetRowCellValue(selectedRow(0), "objGrupoID")) Then
                        valor = grdMatriculasTabla.GetRowCellValue(selectedRow(0), "objGrupoID")
                        If selectedRow(0) >= 0 Then
                            VerDetalle.GrupoID = valor
                            VerDetalle.TypeGui = 3
                            VerDetalle.ShowDialog(Me)
                        End If
                    Else
                        MsgBox("El alumno seleccionado no tiene grupo asignado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If
                Else
                    If intSeleccionados = 0 Then
                        MsgBox("Debe seleccionar un registro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Else
                        MsgBox("Debe seleccionar unicamente un registro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If

                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            VerDetalle = Nothing
        End Try
    End Sub

    Private Sub EliminarAlumnoGrupo()
        Dim objGrupoDetalle As New SraAlumno_Grupo
        Dim intSeleccionados As Integer = 0
        Dim Rows As New ArrayList()
        Dim I As Integer
        Try
            Try
             
                For I = 0 To grdGrupoDetalleTabla.SelectedRowsCount() - 1
                    If (grdGrupoDetalleTabla.GetSelectedRows()(I) >= 0) Then
                        Rows.Add(grdGrupoDetalleTabla.GetDataRow(grdGrupoDetalleTabla.GetSelectedRows()(I)))
                        intSeleccionados = intSeleccionados + 1
                    End If
                Next

                If intSeleccionados = 1 Then
                    If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then

                        Dim selectedRow As Integer() = grdGrupoDetalleTabla.GetSelectedRows()
                        Dim valor As Integer = grdGrupoDetalleTabla.GetRowCellValue(selectedRow(0), "SraAlumno_GrupoID")
                        If selectedRow(0) >= 0 Then
                            objGrupoDetalle.Retrieve(valor)
                            objGrupoDetalle.Activo = False
                            objGrupoDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objGrupoDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objGrupoDetalle.Update()
                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                            CargarGruposAlumnos()
                            CargarGridMatriculas()
                        End If
                    End If
                Else
                    If intSeleccionados = 0 Then
                        MsgBox("Debe seleccionar un registro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Else
                        MsgBox("Debe seleccionar unicamente un registro.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If

                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objGrupoDetalle = Nothing
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
                Me.cmdAsignarGrupo.Enabled = False
            End If

            If Not objSeg.TienePermiso("CambiarGrupo") Then
                Me.cmdEditar.Enabled = False
            End If

            If Not objSeg.TienePermiso("ImprimirGrupos") Then
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
    Private Function ValidarGrupo() As Boolean
        Dim congrupo As Integer = 0
        Try
            Dim I As Integer
            For I = 0 To dtSeleccionados.Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(dtSeleccionados.Rows(I), DataRow)
                If CBool(drFilaAsignaturaEliminadas("TieneGrupo")) Then
                    congrupo = congrupo + 1
                End If
            Next
            If congrupo > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub SeleccionarAlumnos()
        Try
            'Dim Rows As New ArrayList()
            Dim I As Integer

            'For I = 0 To grdvwSeleccion.SelectedRowsCount() - 1
            '    If (grdvwSeleccion.GetSelectedRows()(I) >= 0) Then
            '        Rows.Add(grdvwSeleccion.GetDataRow(grdvwSeleccion.GetSelectedRows()(I)))
            '    End If
            'Next

            Dim filas As DataRow
            For I = 0 To dtSeleccionados.Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(dtSeleccionados.Rows(I), DataRow)
                filas = frmGrupoSelector.dtAlumnosSeleccioandos.NewRow
                filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                filas("SraMatriculaAlumnos") = CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))
                filas("objModalidadlD") = CInt(drFilaAsignaturaEliminadas("objModalidadlD"))
                frmGrupoSelector.dtAlumnosSeleccioandos.Rows.Add(filas)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub Asignar()
        Dim objPersonas As frmGrupoSelector
        Try
            Me.Cursor = WaitCursor
            If Not ValidarGrupo() Then
                If MsgBox("Existen alumnos en la lista que ya estan asignado a un grupo. Esta seguro que desea cambiarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    objPersonas = New frmGrupoSelector
                    objPersonas.Periodo = PeriodoID
                    objPersonas.Opcion = 0
                    SeleccionarAlumnos()
                    If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGridMatriculas()
                        'Seguridad()
                    End If
                End If
            Else
                objPersonas = New frmGrupoSelector
                objPersonas.Periodo = PeriodoID
                objPersonas.Opcion = 0
                SeleccionarAlumnos()
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

    Private Sub Cambiar()
        Dim objPersonas As frmGrupoSelector
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = PeriodoID
            objPersonas.Opcion = 1
            SeleccionarAlumnos()
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

#Region "Consultar"
    Private Sub Consultar()
        Dim objPersonas As frmSraMatriculaEdit
        Dim FilaActual As Integer
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdMatriculasTabla.GetSelectedRows()
            FilaActual = Me.grdMatriculasTabla.GetDataSourceRowIndex(selectedRow(0))
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
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.Cursor = WaitCursor
                Dim selectedRow As Integer() = grdMatriculasTabla.GetSelectedRows()
                FilaActual = Me.grdMatriculasTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    T.BeginTran()
                    IDMatricula = Me.dtMatriculas.DefaultView(FilaActual).Item("SraMatriculaAlumnos")
                    objMatricula.Retrieve(IDMatricula)
                    objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objMatricula.Activo = False
                    objMatricula.Update()
                    T.CommitTran()
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
            CargarGruposAlumnos()
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
        CargarGruposAlumnos()
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Me.Imprimir()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs)
        Me.Eliminar()
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs)
        Me.Consultar()
    End Sub
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            If dtSeleccionados.Rows.Count > 0 Then
                Me.Cursor = WaitCursor
                Cambiar()
                CargarGridMatriculas()
                CargarGruposAlumnos()
            Else
                MsgBox("Debe seleccionar los alumnos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


#End Region

    Private Sub grdMatriculasTabla_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdMatriculasTabla.RowStyle

        Dim View As GridView = TryCast(sender, GridView)
        Try
            If e.RowHandle >= 0 Then
                Dim estado As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TieneGrupo"))

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

    Private Sub cmdAsignarGrupo_Click(sender As Object, e As EventArgs) Handles cmdAsignarGrupo.Click
        Try
            If dtSeleccionados.Rows.Count > 0 Then
                Me.Cursor = WaitCursor
                If TabControlGrupos.SelectedTabPage.Name = "TabControlGrupos" Then
                ElseIf TabControlGrupos.SelectedTabPage.Name = "XtraTabPageMatricula" Then
                    Asignar()
                End If
                CargarGridMatriculas()
                CargarGruposAlumnos()
            Else
                MsgBox("Debe seleccionar los alumnos.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub


    
    Private Sub grdMatriculasTabla_MouseUp(sender As Object, e As MouseEventArgs) Handles grdMatriculasTabla.MouseUp
        If e.Button <> System.Windows.Forms.MouseButtons.Right Then Return
        popupMenu1.ShowPopup(Control.MousePosition)

    End Sub

    Private Sub barButtonVerGrupos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonVerGrupos.ItemClick
        VerDetalleGrupo()
    End Sub
    Function VerficarExistencia(MatriculaID As Integer) As Boolean
        Dim I As Integer
        Try
            For I = 0 To dtSeleccionados.Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(dtSeleccionados.Rows(I), DataRow)
                If drFilaAsignaturaEliminadas("SraMatriculaAlumnos") = MatriculaID Then
                    Return True

                End If
            Next
            Return False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    Private Sub Seleccionar()
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

                If Not VerficarExistencia(CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))) Then
                    filas = dtSeleccionados.NewRow
                    filas("CodigoMED") = (drFilaAsignaturaEliminadas("CodigoMED"))

                    If Not IsDBNull(drFilaAsignaturaEliminadas("objGrupoID")) Then
                        filas("objGrupoID") = CInt(drFilaAsignaturaEliminadas("objGrupoID"))
                    Else
                        filas("objGrupoID") = 0
                    End If

                    filas("SraMatriculaAlumnos") = CInt(drFilaAsignaturaEliminadas("SraMatriculaAlumnos"))
                    filas("GradoID") = CInt(drFilaAsignaturaEliminadas("GradoID"))
                    filas("objAlumnoID") = CInt(drFilaAsignaturaEliminadas("objAlumnoID"))
                    filas("Alumno") = (drFilaAsignaturaEliminadas("Alumno"))
                    filas("Grado") = (drFilaAsignaturaEliminadas("Grado"))
                    filas("Modadlidad") = (drFilaAsignaturaEliminadas("Modadlidad"))
                    filas("objModalidadlD") = CInt(drFilaAsignaturaEliminadas("objModalidadlD"))
                    filas("objPeriodoID") = CInt(drFilaAsignaturaEliminadas("objPeriodoID"))
                    filas("Beca") = (drFilaAsignaturaEliminadas("Beca"))
                    filas("TipoMatricula") = (drFilaAsignaturaEliminadas("TipoMatricula"))
                    filas("Periodo") = (drFilaAsignaturaEliminadas("Periodo"))
                    filas("Edad") = (drFilaAsignaturaEliminadas("Edad"))
                    filas("TieneGrupo") = (drFilaAsignaturaEliminadas("TieneGrupo"))
                    filas("Genero") = (drFilaAsignaturaEliminadas("Genero"))
                    filas("Direccion") = (drFilaAsignaturaEliminadas("Direccion"))
                    filas("EscuelaProcedente") = (drFilaAsignaturaEliminadas("EscuelaProcedente"))

                    dtSeleccionados.Rows.Add(filas)
                End If
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub cmdAgregar_Click_1(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try
            Seleccionar()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdvwSeleccion.SelectedRowsCount() - 1
                If (grdvwSeleccion.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdvwSeleccion.GetDataRow(grdvwSeleccion.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                dtSeleccionados.Rows.Remove(drFilaAsignaturasE)
            Next

           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdvwSeleccion_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grdvwSeleccion.RowStyle
        Dim View As GridView = TryCast(sender, GridView)
        Try
            If e.RowHandle >= 0 Then
                Dim estado As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("TieneGrupo"))

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



    Private Sub cmdInactivar_Click_1(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        EliminarAlumnoGrupo()
    End Sub

   
    Private Sub TabControlGrupos_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabControlGrupos.SelectedPageChanged
        Try
            Dim activo As Integer = TabControlGrupos.SelectedTabPageIndex
            If TabControlGrupos.TabPages(activo).Name = "XtraTabPageGrupos" Then
                cmdInactivar.Enabled = True
            ElseIf TabControlGrupos.TabPages(activo).Name = "XtraTabPageMatricula" Then
                cmdInactivar.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdGrupoDetalleTabla_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdGrupoDetalleTabla.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim bValidarEntero As Boolean = False
        Try
            If View.FocusedColumn.FieldName = "Codigo" Then
                'Obtener el valor actualmente editado
                Valor = Convert.ToDouble(e.Value)
                bValidarEntero = True
            End If

            If bValidarEntero Then
                'Si es negativo, asignar cero
                If Valor < 0 Then
                    e.Valid = True
                    e.Value = 0
                    e.ErrorText = "Debe ingresar un valor positivo"
                End If

                If Valor > 100 Then
                    e.Value = 0
                    e.Valid = True
                    e.ErrorText = "Debe ingresar un valor menor o igual a 100"
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdGrupoDetalleTabla_MouseLeave(sender As Object, e As EventArgs) Handles grdGrupoDetalleTabla.MouseLeave
        Try
            GuardarCodigo()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdGrupoDetalleTabla_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdGrupoDetalleTabla.CellValueChanged
        Try
            GuardarCodigo()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdGrupoDetalleTabla_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grdGrupoDetalleTabla.CellValueChanging
        Try
            GuardarCodigo()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdGrupoDetalleTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles grdGrupoDetalleTabla.KeyDown
        Try
            GuardarCodigo()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class