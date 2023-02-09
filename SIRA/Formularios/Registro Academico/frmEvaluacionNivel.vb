Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Card
Imports SIRA.BO

Public Class frmEvaluacionNivel

#Region "Declaracion de Variables"
    Public DtSeccion, DtGrados, DtBusquedaProfesor, DtParcial, DtAsignaturas, dtGrupos, dtNotas, DtPersona As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolExportar, boolImprimir As Boolean
    Dim intEstadoAbonoRegistrado As Integer
    Dim intModalidad As Integer
    Dim intGrupo, intGrado, intPersonaID, intProfesor, intAlumno As Integer
    'Dim objReciboCaja As SccReciboCaja
    'Dim objReciboDetFactura As SccReciboDetFactura
    Public ds As DataSet

    Property ProfesorID() As String
        Get
            Return intProfesor
        End Get
        Set(ByVal value As String)
            intProfesor = value
        End Set

    End Property

    Property ModaidadID() As String
        Get
            Return intModalidad
        End Get
        Set(ByVal value As String)
            intModalidad = value
        End Set

    End Property
    Property GrupoID() As String
        Get
            Return intGrupo
        End Get
        Set(ByVal value As String)
            intGrupo = value
        End Set
    End Property

    Property PersonaID() As String
        Get
            Return intPersonaID
        End Get
        Set(ByVal value As String)
            intPersonaID = value
        End Set
    End Property

    Property GradoID() As String
        Get
            Return intGrado
        End Get
        Set(ByVal value As String)
            intGrado = value
        End Set
    End Property
#End Region

#Region "Procedimientos"


    Private Sub CargarParcial()
        DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))

        DtParcial.DefaultView.Sort = "Descripcion"
        With cmbParcial
            .Properties.DataSource = DtParcial
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
        End With



    End Sub

    Public Sub CargarCategoriasEvidencias()
        Try
            If GrupoID.ToString.Trim.Length <> 0 Then
                If intProfesor = 0 Then
                    DtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SraEvidenciasID,  NombreEvidencia", "vwSraEvidenciasXGrado", "Activo=1 and Activa=1 and objPeriodoID= " & frmPrincipal.glbPeriodoSeleccionado & " and objGradoID=" + GradoID.ToString))
                Else
                    DtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SraEvidenciasID,  NombreEvidencia", "vwSraEvidenciasXGrado", "Activo=1 and Activa=1 and objProfesorID = " & intProfesor & " and objPeriodoID= " & frmPrincipal.glbPeriodoSeleccionado & " and objGradoID=" + GradoID.ToString))

                End If

            End If

            DtAsignaturas.DefaultView.Sort = "NombreEvidencia"
            With cmbCategoriaEvidencia
                .Properties.DataSource = DtAsignaturas
                .Properties.DisplayMember = "NombreEvidencia"
                .Properties.ValueMember = "SraEvidenciasID"
                .Properties.PopulateColumns()
                .Properties.Columns("SraEvidenciasID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarGridEsquema()
        Try
            dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwSraEvidenciasNotas", "1=0"))
            grdNotas.DataSource = dtNotas
            grdNotas.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Dim dtVerificar As DataTable
        Dim objNotas As New SraNotasEvidencias
        Dim T As New DAL.TransactionManager
        Dim DtEvidenciasRestantes As New DataTable
        Try
            ''Buscamos si existen notas para este parcial y la asignatura seleccionada
            dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("EXEC Sp_GetEvidenciasNotas " & cmbParcial.EditValue & "," & intAlumno & "," & GradoID & ", " + cmbCategoriaEvidencia.EditValue.ToString))
            dtNotas.DefaultView.Sort = "objEvidenciaDetalleID asc"

            If dtNotas.Rows.Count = 0 Then
                ''Registrar en la tabla de notas los datos con 0
                dtVerificar = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("distinct  objGrupoID, objEvidenciaDetalleID, objEvidenciasID", "vwSraEvidenciasNotas", " objEvidenciasID= " & cmbCategoriaEvidencia.EditValue & " and objGradoID=" & GradoID & " AND objParcialID= " & cmbParcial.EditValue))
                T.BeginTran()
                For Each row As DataRow In dtVerificar.Rows
                    objNotas.objGrupoID = GrupoID
                    objNotas.objAlumnoID = intAlumno
                    objNotas.objCategoriaID = cmbCategoriaEvidencia.EditValue
                    objNotas.objEvidenciaDetalleID = row("objEvidenciaDetalleID")
                    objNotas.objParcialID = cmbParcial.EditValue
                    objNotas.Nota = String.Empty.Trim
                    objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objNotas.Insert(T)
                Next
                T.CommitTran()
                dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwSraEvidenciasNotas", " objParcialID= " & cmbParcial.EditValue & " AND objAlumnoID= " & intAlumno & " and objGradoID=" & GradoID & " AND objEvidenciasID = " + cmbCategoriaEvidencia.EditValue.ToString))
                dtNotas.DefaultView.Sort = "objEvidenciaDetalleID asc"
            Else
                DtEvidenciasRestantes = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwSraEvidenciasNotas", " objParcialID= " & cmbParcial.EditValue & " AND objAlumnoID= " & intAlumno & " and objGradoID=" & GradoID & " AND objEvidenciasID = " + cmbCategoriaEvidencia.EditValue.ToString))

                If dtNotas.Rows.Count <> DtEvidenciasRestantes.Rows.Count Then
                    ''Registrar en la tabla de notas los datos con 0
                    dtVerificar = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("EXEC Sp_GetEvidenciasNotasInsertar " & cmbParcial.EditValue & "," & intAlumno & "," & GradoID & ", " + cmbCategoriaEvidencia.EditValue.ToString))
                    T.BeginTran()
                    For Each row As DataRow In dtVerificar.Rows
                        objNotas.objGrupoID = GrupoID
                        objNotas.objAlumnoID = intAlumno
                        objNotas.objCategoriaID = cmbCategoriaEvidencia.EditValue
                        objNotas.objEvidenciaDetalleID = row("objEvidenciaDetalleID")
                        objNotas.objParcialID = cmbParcial.EditValue
                        objNotas.Nota = String.Empty.Trim
                        objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                        objNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                        objNotas.Insert(T)
                    Next
                    T.CommitTran()
                    dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("*", "vwSraEvidenciasNotas", " objParcialID= " & cmbParcial.EditValue & " AND objAlumnoID= " & intAlumno & " and objGradoID=" & GradoID & " AND objEvidenciasID = " + cmbCategoriaEvidencia.EditValue.ToString))
                    dtNotas.DefaultView.Sort = "objEvidenciaDetalleID asc"

                End If
            End If

            If Not dtNotas Is Nothing Then

                grdNotas.DataSource = dtNotas
                grdNotas.ForceInitialize()

            End If

        Catch ex As Exception

            clsError.CaptarError(ex)

        End Try

    End Sub

    Private Sub ExportarExcel()
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.grdNotas.ExportToXls(sfdRuta.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmEvaluacionSecundaria"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAprobar = objseg.TienePermiso("Aprobar")
            boolImprimir = objseg.TienePermiso("Imprimir")
            boolExportar = objseg.TienePermiso("ExportarExcel")

            cmdAprobar.Enabled = boolAprobar
            cmbExportar.Enabled = boolExportar

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub BuscarProfesor()
        Try
            DtBusquedaProfesor = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbProfesorID, Login", "vwCuentaProfesor", " Login='" & clsProyecto.Conexion.Usuario & "'"))
            If DtBusquedaProfesor.Rows.Count > 0 Then
                intProfesor = DtBusquedaProfesor.Rows(0)("StbProfesorID")
            Else
                intProfesor = 0
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Dim evalCualitativa, evalCuantitativa As Boolean
        Try
            ErrPrv.SetError(txtGrado, "")
            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = frmPrincipal.glbPeriodoSeleccionado
            objPersonas.Opcion = 3
            objPersonas.Profesor = intProfesor
            objPersonas.ModaidadID = ModaidadID
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID))
                If dtGrupos.Rows.Count > 0 Then

                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                    Me.GradoID = dtGrupos.Rows(0)("GradoID")
                    intGrupo = dtGrupos.Rows(0)("SraGrupoID")

                    evalCualitativa = dtGrupos.Rows(0)("EvaluacionCualitativa")
                    evalCuantitativa = dtGrupos.Rows(0)("EvaluacionCuantitativa")
                    CargarCategoriasEvidencias()
                    CargarGridEsquema()
                End If
                'Seguridad()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

    Private Function ValidarEntrada()

        If Me.cmbParcial.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbParcial, "Debe seleccionar el parcial")
            Me.cmbParcial.Focus()
            Return False
            Exit Function
        End If

        If Me.GrupoID.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtGrado, "Debe seleccionar el grupo")
            Me.txtGrado.Focus()
            Return False
            Exit Function
        End If

        If Me.cmbCategoriaEvidencia.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbCategoriaEvidencia, "Debe seleccionar la asignatura")
            Me.cmbCategoriaEvidencia.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

#End Region

#Region "Eventos del formulario"

    Private Sub frmSincronizarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarParcial()
            BuscarProfesor()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If ValidarEntrada() Then
            CargarGrid()
        End If

    End Sub



    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs)
        'AnularAbonos()
        'CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.SelectedValue, cmbRuta.SelectedValue)
    End Sub

    Private Sub grdVentasTable_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdNotasTable.RowStyle
        'Dim Promedio As Integer = 0
        'Dim vista As GridView = sender

        'Try

        '    Promedio = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns("Promedio")))
        'Catch ex As Exception

        'End Try
        'Select Case Promedio
        '    Case Is < 60
        '        e.Appearance.BackColor = Color.Red
        '        e.Appearance.BackColor2 = Color.White

        '    Case Is >= 60
        '        e.Appearance.BackColor = Color.LimeGreen
        '        e.Appearance.BackColor2 = Color.White



        'End Select
    End Sub

    Private Sub grdNotasTable_MouseLeave(sender As Object, e As EventArgs) Handles grdNotasTable.MouseLeave
        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdNotasTable.FocusedRowHandle
            If FilaActual >= 0 Then
                Me.dtNotas.DefaultView.Item(FilaActual)("Nota") = Me.grdNotasTable.GetRowCellValue(grdNotasTable.FocusedRowHandle, "Nota")

                dtNotas.AcceptChanges()
                grdNotasTable.RefreshData()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_LostFocus(sender As Object, e As EventArgs) Handles grdNotasTable.LostFocus
        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdNotasTable.FocusedRowHandle
            If FilaActual >= 0 Then
                Me.dtNotas.DefaultView.Item(FilaActual)("Nota") = Me.grdNotasTable.GetRowCellValue(grdNotasTable.FocusedRowHandle, "Nota")

                dtNotas.AcceptChanges()
                grdNotasTable.RefreshData()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Inactivar()
    End Sub

    Private Sub Inactivar()
        Dim objGrado As New SraGrado
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox("Esta seguro que desea eliminar el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdNotasTable.GetSelectedRows()
                    FilaActual = Me.grdNotasTable.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        SraNotasEvidencias.DeleteByFilter("SraNotasEvidenciasID=" & Me.dtNotas.DefaultView.Item(FilaActual)("SraNotasEvidenciasID"))

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objGrado = Nothing
        End Try
    End Sub

    Private Sub grdNotasTable_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles grdNotasTable.CellValueChanging

        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdNotasTable.FocusedRowHandle
            Me.dtNotas.DefaultView.Item(FilaActual)("Nota") = Me.grdNotasTable.GetRowCellValue(grdNotasTable.FocusedRowHandle, "Nota")

            dtNotas.AcceptChanges()
            grdNotasTable.RefreshData()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CalcularPromedio()

        Dim TotalNotas As Decimal
        Dim SumTieneValor As Integer
        Dim dblPromedio As Decimal
        Try

            If Not Me.dtNotas Is Nothing Then


                For Each row As DataRow In Me.dtNotas.Rows

                    If row("IND1") > 0 And row("NotaFinal") = False Then
                        row("TieneValorIND1") = 1
                    ElseIf row("NotaFinal") = True Then
                        row("TieneValorIND1") = 1
                    Else
                        row("TieneValorIND1") = 0
                    End If

                    If row("IND2") > 0 And row("NotaFinal") = False Then
                        row("TieneValorIND2") = 1
                    ElseIf row("NotaFinal") = True Then
                        row("TieneValorIND2") = 1
                    Else
                        row("TieneValorIND2") = 0
                    End If

                    If row("IND3") > 0 And row("NotaFinal") = False Then
                        row("TieneValorIND3") = 1
                    ElseIf row("NotaFinal") = True Then
                        row("TieneValorIND3") = 1
                    Else
                        row("TieneValorIND3") = 0
                    End If

                    If row("IND4") > 0 And row("NotaFinal") = False Then
                        row("TieneValorIND4") = 1
                    ElseIf row("NotaFinal") = True Then
                        row("TieneValorIND4") = 1
                    Else
                        row("TieneValorIND4") = 0
                    End If

                    If row("IND5") > 0 And row("NotaFinal") = False Then
                        row("TieneValorIND5") = 1
                    ElseIf row("NotaFinal") = True Then
                        row("TieneValorIND5") = 1
                    Else
                        row("TieneValorIND5") = 0
                    End If

                    If Boolean.Parse(row("NotaFinal")) Then
                        TotalNotas = row("IND1") + row("IND2") + row("IND3") + row("IND4") + row("IND5")
                        row("Promedio") = TotalNotas / 5
                    Else

                        SumTieneValor = row("TieneValorIND1") + row("TieneValorIND2") + row("TieneValorIND3") + row("TieneValorIND4") + row("TieneValorIND5")
                        TotalNotas = row("IND1") + row("IND2") + row("IND3") + row("IND4") + row("IND5")
                        If SumTieneValor > 0 Then
                            dblPromedio = TotalNotas / SumTieneValor
                            row("Promedio") = dblPromedio.ToString
                        End If


                    End If

                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub cmbGrado_EditValueChanged(sender As Object, e As EventArgs)
        CargarCategoriasEvidencias()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Function TieneValor(ByVal Valor As Object) As Boolean
        If Not Valor Is Nothing Then
            Return (Not IsDBNull(Valor)) AndAlso Valor.ToString.Trim.Length <> 0
        Else
            Return False
        End If
    End Function

    Private Function NumeroValido(ByVal valor As Object) As Boolean
        If Not valor Is Nothing Then
            If Me.TieneValor(valor) Then
                If valor <> 0 Then
                    Return True
                Else
                    Return False
                End If
            End If
        Else
            Return False
        End If
    End Function

    Private Sub grdNotasTable_KeyDown(sender As Object, e As KeyEventArgs) Handles grdNotasTable.KeyDown
        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdNotasTable.FocusedRowHandle
            Me.dtNotas.DefaultView.Item(FilaActual)("Nota") = Me.grdNotasTable.GetRowCellValue(grdNotasTable.FocusedRowHandle, "Nota")

            dtNotas.AcceptChanges()
            grdNotasTable.RefreshData()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdNotasTable.CellValueChanged
        Dim FilaActual As Integer

        Try
            FilaActual = Me.grdNotasTable.FocusedRowHandle
            Me.dtNotas.DefaultView.Item(FilaActual)("Nota") = Me.grdNotasTable.GetRowCellValue(grdNotasTable.FocusedRowHandle, "Nota")

            dtNotas.AcceptChanges()
            grdNotasTable.RefreshData()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarPersona()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & PersonaID & "'"

            '' strFiltro = " Descripcion <> 'Cliente' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SccClientes) and PersonaJuridica=0"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID, StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacionAlumnos", strFiltro))

            Me.txtAlumno.Text = DtPersona.Rows(0)("NombreCompleto").ToString
            intAlumno = DtPersona.Rows(0)("AlumnoID")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  StbPersonaID IN (SELECT objPersonaID FROM StbAlumnos) AND SraGrupoID = " & intGrupo
            objSeleccion.Opcion = 6
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.PersonaID = objSeleccion.Seleccion
                CargarPersona()

                ErrPrv.SetError(cmdBuscar, "")
                CargarGridEsquema()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbParcial_EditValueChanged(sender As Object, e As EventArgs) Handles cmbParcial.EditValueChanged
        ErrPrv.SetError(cmbParcial, "")
        CargarGridEsquema()
    End Sub

    Private Sub cmbCategoriaEvidencia_EditValueChanged(sender As Object, e As EventArgs) Handles cmbCategoriaEvidencia.EditValueChanged

        ErrPrv.SetError(cmbCategoriaEvidencia, "")
        CargarGridEsquema()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Dim T As New DAL.TransactionManager
        Try
            Dim objNotas As New SraNotasEvidencias
            T.BeginTran()
            If Not Me.dtNotas Is Nothing Then
                For Each row As DataRow In Me.dtNotas.Rows
                    objNotas.Retrieve(Integer.Parse(row("SraNotasEvidenciasID")))
                    objNotas.objAlumnoID = intAlumno
                    objNotas.objGrupoID = GrupoID
                    objNotas.objParcialID = cmbParcial.EditValue
                    objNotas.objCategoriaID = cmbCategoriaEvidencia.EditValue
                    objNotas.objEvidenciaDetalleID = row("objEvidenciaDetalleID")
                    objNotas.Nota = row("Nota").ToString.Trim
                    objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objNotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objNotas.Update(T)
                Next
            End If
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
End Class