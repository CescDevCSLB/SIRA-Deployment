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
Imports DevExpress.XtraGrid.Columns

Public Class frmEvaluacionSecundaria

#Region "Declaracion de Variables"
    Public DtSeccion, DtGrados, DtParcial, DtAsignaturas, dtGrupos, dtNotas, DtBusquedaProfesor As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolImprimir, boolExportar, boolDesactivar As Boolean
    Dim intEstadoAbonoRegistrado As Integer
    Dim intGrupo, intGrado, intProfesor As Integer
    Dim boolGuardado As Boolean
    'Dim IdModalidad As Integer
    'Dim IdGrado As Integer
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
    Property GrupoID() As String
        Get
            Return intGrupo
        End Get
        Set(ByVal value As String)
            intGrupo = value
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

    Private Sub Inactivar()
        Dim objGrado As New SraGrado
        Dim FilaActual As Integer
        Try
            Try
                If MsgBox("Esta seguro que desea eliminar el registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                    Dim selectedRow As Integer() = grdNotasTable.GetSelectedRows()
                    FilaActual = Me.grdNotasTable.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        SraNotas.DeleteByFilter("SraNotasID=" & Me.dtNotas.DefaultView.Item(FilaActual)("SraNotasID"))

                    End If
                End If


            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objGrado = Nothing
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

    Private Sub CargarParcial()
        Try
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
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub

    Public Sub CargarAsignaturas()
        Try
            If GrupoID.ToString.Trim.Length <> 0 Then
                If intProfesor <> 0 Then
                    DtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct AsignaturaID,  Nombre", "vwSraGruposProfesoresAsignaturas_Evaluacion", "Activo=1 and objGrupoID=" & GrupoID & " and objProfesorID=" & intProfesor))
                Else
                    DtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" distinct AsignaturaID,  Nombre", "vwSraGruposProfesoresAsignaturas_Evaluacion", "Activo=1 and objGrupoID=" & GrupoID))
                End If

            End If

            DtAsignaturas.DefaultView.Sort = "Nombre"
            With cmbAsignatura
                .Properties.DataSource = DtAsignaturas
                .Properties.DisplayMember = "Nombre"
                .Properties.ValueMember = "AsignaturaID"
                .Properties.PopulateColumns()
                .Properties.Columns("AsignaturaID").Visible = False
                .Properties.AutoHeight = True
                .Properties.ShowHeader = False
            End With


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''Descripción:      Metodo encargado de cargar la informacion de productos registrados en la grilla
    Public Sub CargarGrid()
        Dim dtVerificar As New DataTable
        Dim objNotas As New SraNotas
        Dim T As New DAL.TransactionManager
        Dim dtVerificacion As New DataTable
        Try
            ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
            dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")

            ''Configurar grid de acuerdo a las asignaturas
            If dtVerificacion.Rows.Count > 0 Then
                ''If ((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad <> 20977 And frmPrincipal.glbModalidad <> 20978 Then

                colPromedio.Visible = False
                colPromedioFinal.Visible = False
                colNotaCualitativa.Visible = False

                colIndicador1.Visible = False
                ColIndicador2.Visible = False
                colIndicador3.Visible = False
                colIndicador4.Visible = False
                colIndicador5.Visible = False

                colNotaC.Visible = True


            Else
                colPromedio.Visible = True
                colPromedioFinal.Visible = True
                colNotaCualitativa.Visible = True

                colIndicador1.Visible = True
                ColIndicador2.Visible = True
                colIndicador3.Visible = True
                colIndicador4.Visible = True
                colIndicador5.Visible = True

                colNotaC.Visible = False

                colCodigo.VisibleIndex = 0
                ColAlumno.VisibleIndex = 1
                colIndicador1.VisibleIndex = 2
                ColIndicador2.VisibleIndex = 3
                colIndicador3.VisibleIndex = 4
                colIndicador4.VisibleIndex = 5
                colIndicador5.VisibleIndex = 6
                colPromedio.VisibleIndex = 7
                colNotaCualitativa.VisibleIndex = 8

            End If

            ''Buscamos si existen notas para este parcial y la asignatura seleccionada

            dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("EXEC pr_NotasEvaluacion " & GrupoID & " , " & cmbAsignatura.EditValue.ToString & ", " & cmbParcial.EditValue.ToString))
            dtNotas.DefaultView.Sort = "Codigo asc"
            If dtNotas.Rows.Count > 0 Then
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
            cmdImprimir.Enabled = boolImprimir

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Dim evalCualitativa, evalCuantitativa As Boolean
        Try

            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = frmPrincipal.glbPeriodoSeleccionado
            objPersonas.Opcion = 2
            objPersonas.Profesor = intProfesor

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa,objModalidadID", "vwSraGrupos", "PeriodoID= " & frmPrincipal.glbPeriodoSeleccionado & " AND SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then

                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                    Me.GradoID = dtGrupos.Rows(0)("GradoID")
                    evalCualitativa = dtGrupos.Rows(0)("EvaluacionCualitativa")
                    evalCuantitativa = dtGrupos.Rows(0)("EvaluacionCuantitativa")
                    frmPrincipal.glbModalidad = dtGrupos.Rows(0)("objModalidadID")

                    If Not evalCualitativa Then
                        colNotaCualitativa.Visible = False
                    End If

                    If Not evalCuantitativa Then
                        colNotaCualitativa.Visible = True
                    End If
                    ''Buscaar modalidad de este grupo

                    CargarAsignaturas()
                    dtNotas = New DataTable
                    grdNotas.DataSource = dtNotas
                  
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

        If Me.cmbAsignatura.ToString.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbAsignatura, "Debe seleccionar la asignatura")
            Me.cmbAsignatura.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

#End Region

#Region "Eventos del formulario"

    Private Sub frmSincronizarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            boolGuardado = False
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
            boolGuardado = False
        End If

    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        ExportarExcel()
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmdDesactivar_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click

        'AnularAbonos()
        'CargarGrid(chkTodos.Checked, cmbEstado.EditValue, cmbEmpleado.SelectedValue, cmbRuta.SelectedValue)
    End Sub

    Private Sub grdVentasTable_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grdNotasTable.RowStyle
        'Dim Promedio As Integer = 0
        'Dim Activo As Integer = 0
        'Dim vista As GridView = sender
        'Dim dtVerificacion As DataTable

        'Try
        '    dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
        '    If dtVerificacion.Rows.Count = 0 Then
        '        ''If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
        '        Try

        '            Promedio = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns("Promedio")))
        '            Activo = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns("Activo")))

        '        Catch ex As Exception

        '        End Try

        '        If (Promedio < 60 And Activo = 1) Then
        '            e.Appearance.BackColor = Color.Red
        '            e.Appearance.BackColor2 = Color.White

        '        ElseIf (Promedio >= 60 And Activo = 1) Then
        '            e.Appearance.BackColor = Color.LimeGreen
        '            e.Appearance.BackColor2 = Color.White
        '        Else
        '            If (Activo = 0) Then
        '                e.Appearance.BackColor = Color.Orange
        '                e.Appearance.BackColor2 = Color.White
        '            End If
        '        End If
        '    Else
        '        Try
        '            Activo = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns("Activo")))

        '        Catch ex As Exception

        '        End Try

        '        If (Activo = 0) Then
        '            e.Appearance.BackColor = Color.Orange
        '            e.Appearance.BackColor2 = Color.White
        '        End If

        '    End If
        'Catch ex As Exception

        'End Try
        'If dtVerificacion.Rows.Count = 0 Then
        '    CalcularPromedio()
        'End If




    End Sub

    Private Function Redondeo(ByVal Numero, ByVal Decimales)
        Redondeo = Int(Numero * 10 ^ Decimales + 1 / 2) / 10 ^ Decimales
    End Function

    Private Sub CalcularPromedio()

        Dim TotalNotas As Decimal
        Dim SumTieneValor As Integer
        Dim dblPromedio As Integer
        Dim objAlumnoGrupo As New SraGrupo
        Dim IdModalidad As Integer
        Dim objNotascualitavias As New SraNotas_Cualitativas
        Dim objGradosModalidad As New SraRangosGrados
        Dim dtRangos As DataTable
        Try

            If Not Me.dtNotas Is Nothing Then

                For Each row As DataRow In Me.dtNotas.Rows
                    If row("Activo") Then

                        If row("IND1").ToString <> String.Empty Then
                        If row("IND1") > 0 Then
                            row("TieneValorIND1") = 1
                        Else
                            row("TieneValorIND1") = 0
                        End If
                    Else
                        row("IND1") = 0
                    End If

                    If row("IND2").ToString <> String.Empty Then
                        If row("IND2") > 0 Then
                            row("TieneValorIND2") = 1
                        Else
                            row("TieneValorIND2") = 0
                        End If
                    Else
                        row("IND2") = 0

                    End If

                    If row("IND3").ToString <> String.Empty Then
                        If row("IND3") > 0 Then
                            row("TieneValorIND3") = 1
                        Else
                            row("TieneValorIND3") = 0
                        End If
                    Else
                        row("IND3") = 0
                    End If

                    If row("IND4").ToString <> String.Empty Then
                        If row("IND4") > 0 Then
                            row("TieneValorIND4") = 1
                        Else
                            row("TieneValorIND4") = 0
                        End If
                    Else
                        row("IND4") = 0
                    End If

                    If row("IND5").ToString <> String.Empty Then
                        If row("IND5") > 0 Then
                            row("TieneValorIND5") = 1
                        Else
                            row("TieneValorIND5") = 0
                        End If
                    Else
                        row("IND5") = 0
                    End If


                    SumTieneValor = row("TieneValorIND1") + row("TieneValorIND2") + row("TieneValorIND3") + row("TieneValorIND4") + row("TieneValorIND5")
                    TotalNotas = row("IND1") + row("IND2") + row("IND3") + row("IND4") + row("IND5")
                    If SumTieneValor > 0 Then
                        dblPromedio = Redondeo(CDbl(TotalNotas) / CDbl(SumTieneValor), 0)
                        row("Promedio") = dblPromedio.ToString


                    End If

                    ''Buscar la modalidad 
                    'objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                    'If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                    '    IdModalidad = objAlumnoGrupo.objModalidadID
                    'End If

                    ''Si la asignatura es distinta a conducta la modalidad se toma de los rangos del sistema
                    If cmbAsignatura.EditValue <> "23" Then
                        ''Buscar si la modalidad es por grado
                        dtRangos = New DataTable
                            'objGradosModalidad.RetrieveByFilter("objModalidadID=" & IdModalidad & " AND objGradoID=" & objAlumnoGrupo.objGradoID)

                            If (row("Promedio").ToString.Length > 0) Then
                                dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND  Desde<=" + row("Promedio").ToString + " and hasta >=" + row("Promedio").ToString))
                            Else
                                dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND  Desde<=0 and hasta >=0"))

                            End If

                            If dtRangos.Rows.Count > 0 Then
                            row("PromedioC") = dtRangos.Rows(0)("Valor").ToString
                        End If

                    Else
                        ''Buscar la modalidad 
                        objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                        If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                            IdModalidad = objAlumnoGrupo.objModalidadID
                        End If
                            If Not (IsDBNull(row("Promedio"))) Then
                                If IdModalidad <> 20978 Then
                                    Select Case row("Promedio")
                                        Case 90 To 100
                                            row("PromedioC") = "E"
                                        Case 80 To 89
                                            row("PromedioC") = "MB"
                                        Case 70 To 79
                                            row("PromedioC") = "B"
                                        Case 60 To 69
                                            row("PromedioC") = "R"
                                        Case < 60
                                            row("PromedioC") = "D"

                                    End Select
                                Else
                                    Select Case row("Promedio")
                                        Case 90 To 100
                                            row("PromedioC") = "E"
                                        Case 70 To 89
                                            row("PromedioC") = "MB"
                                        Case 60 To 69
                                            row("PromedioC") = "B"
                                        Case < 60
                                            row("PromedioC") = "D"

                                    End Select
                                End If

                            End If
                        End If
                        ''Buscar la nota cualitativa correspondiente
                        'If objGradosModalidad.SraRangosGradosID <> 0 Then

                        'Else
                        '    objNotascualitavias.RetrieveByFilter("objModalidadID=" + IdModalidad.ToString + " and Desde<=" + row("Promedio").ToString + " and hasta >=" + row("Promedio").ToString)
                        '    row("PromedioC") = objNotascualitavias.Valor
                        'End If

                    End If

                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Private Sub cmbGrado_EditValueChanged(sender As Object, e As EventArgs)
        CargarAsignaturas()
    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Inactivar()
        CargarGrid()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub cmbAsignatura_TextChanged(sender As Object, e As EventArgs) Handles cmbAsignatura.TextChanged
        Dim intAsignatura As Integer
        Try

            If Not boolGuardado Then
                intAsignatura = cmbAsignatura.OldEditValue
                If intAsignatura <> 0 Then
                    If intAsignatura <> cmbAsignatura.EditValue Then
                        If Not MsgBox("Esta seguro que desea cambiar la asignatura?. Aun no ha guardado las calificaciones", MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            cmbAsignatura.EditValue = intAsignatura
                        Else
                            CargarGrid()
                        End If
                    End If

                End If
            Else
                CargarGrid()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        Dim intParcial As Integer
        Try

            If Not boolGuardado Then
                intParcial = cmbParcial.OldEditValue
                If intParcial <> 0 Then
                    If intParcial <> cmbParcial.EditValue Then
                        If Not MsgBox("Esta seguro que desea cambiar el parcial?. Aun no ha guardado las calificaciones", MsgBoxStyle.Information + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                            cmbParcial.EditValue = intParcial
                        Else
                            CargarGrid()
                        End If
                    End If

                End If
            Else
                CargarGrid()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
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
        'Dim FilaActual As Integer
        'Try
        '    FilaActual = Me.grdNotasTable.FocusedRowHandle
        '    'Dim blnEnfoque As Boolean
        '    If e.KeyCode = Keys.Enter Then
        '        If Me.grdNotasTable.FocusedColumn.Equals(Me.colIndicador1) Then
        '            If Me.TieneValor(Me.grdNotasTable.FocusedColumn.View.FocusedValue) Then

        '                CalcularPromedio()
        '                Exit Sub

        '            End If

        '        End If
        '    End If


        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try
    End Sub

    Private Sub grdNotasTable_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles grdNotasTable.CellValueChanged
        'Dim FilaActual As Integer
        Dim dtVerificacion As DataTable
        Try
            'FilaActual = Me.grdNotasTable.FocusedRowHandle
            'If e.Column.Equals(Me.colIndicador1) Then
            '    Me.dtNotas.DefaultView.Item(FilaActual)("IND1") = Me.grdNotasTable.EditingValue
            'End If

            ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
            dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
            If dtVerificacion.Rows.Count = 0 Then
                CalcularPromedio()

            End If

            'If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
            '    CalcularPromedio()
            'End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit2.CheckedChanged
        CalcularPromedio()
    End Sub

    Private Sub AprobarNotasCualitativas()
        Dim T As New DAL.TransactionManager
        Dim objConsolidado As New SraConsolidadoNotas
        Dim notaID As Integer
        Try
            Dim objNotas As New SraNotas

            If Not Me.dtNotas Is Nothing Then

                For Each row As DataRow In Me.dtNotas.Rows
                    T = New DAL.TransactionManager
                    T.BeginTran()
                    notaID = row("SraNotasID")
                    If (row("Alumno") <> "TRASLADO DE SECCION") Then

                        If row("SraNotasID") = 0 Or IsNothing(row("SraNotasID") = 0) Then
                            Dim Filas() As DataRow

                            Filas = dtNotas.Select("Activo=1 AND AlumnoID = " & row("AlumnoID") & " AND SraNotasID=0")
                            If Filas.Length = 1 Then
                                objNotas.objAlumnoID = row("AlumnoID")
                                objNotas.objGrupoID = GrupoID
                                objNotas.objParcialID = cmbParcial.EditValue
                                objNotas.objAsignaturaID = cmbAsignatura.EditValue

                                objNotas.IND2 = 0
                                objNotas.IND3 = 0
                                objNotas.IND4 = 0
                                objNotas.IND5 = 0
                                objNotas.Promedio = 0

                                objNotas.PromedioC = row("PromedioC").ToString().Trim()

                                objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                                objNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                                objNotas.Insert(T)

                            End If

                        Else
                            objNotas.Retrieve(Integer.Parse(row("SraNotasID")), T)
                            objNotas.objAlumnoID = row("AlumnoID")
                            objNotas.objGrupoID = GrupoID
                            objNotas.objParcialID = cmbParcial.EditValue
                            objNotas.objAsignaturaID = cmbAsignatura.EditValue

                            objNotas.IND2 = 0
                            objNotas.IND3 = 0
                            objNotas.IND4 = 0
                            objNotas.IND5 = 0
                            objNotas.Promedio = 0
                            objNotas.PromedioC = row("PromedioC").ToString().Trim()

                            objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objNotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objNotas.Update(T)

                        End If

                        objConsolidado = New SraConsolidadoNotas
                        objConsolidado.RetrieveByFilter("objAlumnoID= " & row("AlumnoID") & " AND objGrupoID=" & GrupoID & " AND objAsignaturaID=" & cmbAsignatura.EditValue, T)
                        If objConsolidado.SraConsolidadoNotasID = 0 Then
                            ''Agregar al consolidado
                            objConsolidado.objAlumnoID = row("AlumnoID")
                            objConsolidado.objGrupoID = GrupoID
                            objConsolidado.objAsignaturaID = cmbAsignatura.EditValue

                            If cmbParcial.Text = "I PARCIAL" Then
                                objConsolidado.Parcial_I_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "II PARCIAL" Then
                                objConsolidado.Parcial_II_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "III PARCIAL" Then
                                objConsolidado.Parcial_III_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                objConsolidado.Parcial_IV_C = row("PromedioC").ToString().Trim()
                            End If
                            objConsolidado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objConsolidado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objConsolidado.Insert(T)
                        Else
                            objConsolidado.Retrieve(objConsolidado.SraConsolidadoNotasID, T)
                            objConsolidado.objAlumnoID = row("AlumnoID")
                            objConsolidado.objGrupoID = GrupoID
                            objConsolidado.objAsignaturaID = cmbAsignatura.EditValue

                            If cmbParcial.Text = "I PARCIAL" Then
                                objConsolidado.Parcial_I_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "II PARCIAL" Then
                                objConsolidado.Parcial_II_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "III PARCIAL" Then
                                objConsolidado.Parcial_III_C = row("PromedioC").ToString().Trim()

                            ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                objConsolidado.Parcial_IV_C = row("PromedioC").ToString().Trim()
                            End If
                            objConsolidado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objConsolidado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objConsolidado.Update(T)
                        End If
                    End If
                    T.CommitTran()
                Next
            End If

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)


        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub Aprobar()
        Dim T As New DAL.TransactionManager
        Dim IdModalidad As Integer
        Dim notaID As Integer
        Try
            Dim objNotas As New SraNotas
            Dim objAlumnoGrupo As New SraGrupo
            Dim objConsolidado As SraConsolidadoNotas
            Dim objescala As New SraNotas_Cualitativas
            Dim objAlumnosgrupos As New SraAlumno_Grupo
            Dim objgradosnotas As New SraRangosGrados
            Dim dtRangos As DataTable

            Dim IncluirParcial1 As Boolean = False
            Dim IncluirParcial2 As Boolean = False
            Dim IncluirParcial3 As Boolean = False
            Dim IncluirParcial4 As Boolean = False

            If Not Me.dtNotas Is Nothing Then

                For Each row As DataRow In Me.dtNotas.Rows
                    T.BeginTran()
                    objConsolidado = New SraConsolidadoNotas

                    notaID = row("SraNotasID")

                    If row("SraNotasID") = 0 Or IsNothing(row("SraNotasID") = 0) Then
                            Dim Filas() As DataRow

                        Filas = dtNotas.Select("Activo=1 AND AlumnoID = " & row("AlumnoID") & " AND SraNotasID=0")
                        If row("AlumnoID") = 327 Then
                            objNotas.objAlumnoID = row("AlumnoID")
                        End If
                        If Filas.Length = 1 Then

                            If (row("Alumno") <> "TRASLADO DE SECCION") Then
                                objNotas.objAlumnoID = row("AlumnoID")
                                objNotas.objGrupoID = GrupoID
                                objNotas.objParcialID = cmbParcial.EditValue
                                objNotas.objAsignaturaID = cmbAsignatura.EditValue
                                objNotas.IND1 = row("IND1")
                                objNotas.IND2 = row("IND2")
                                objNotas.IND3 = row("IND3")
                                objNotas.IND4 = row("IND4")
                                objNotas.IND5 = row("IND5")
                                objNotas.Promedio = row("Promedio")
                                If Not IsDBNull(row("PromedioC")) Then
                                    objNotas.PromedioC = row("PromedioC")
                                End If

                                objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                                objNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                                objNotas.Insert(T)

                                ''Actualizar consolidado
                                objConsolidado.RetrieveByFilter("objAlumnoID= " & row("AlumnoID") & " AND objGrupoID=" & GrupoID & " AND objAsignaturaID=" & cmbAsignatura.EditValue, T)

                                If objConsolidado.SraConsolidadoNotasID = 0 Then
                                    ''Agregar al consolidado
                                    objConsolidado.objAlumnoID = row("AlumnoID")
                                    objConsolidado.objGrupoID = GrupoID
                                    objConsolidado.objAsignaturaID = cmbAsignatura.EditValue

                                    If cmbParcial.Text = "I PARCIAL" Then
                                        objConsolidado.Parcial_I = row("Promedio")
                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_I_C = row("PromedioC")
                                        End If
                                        objConsolidado.Parcial_II = 0
                                        objConsolidado.Parcial_III = 0
                                        objConsolidado.Parcial_IV = 0

                                    ElseIf cmbParcial.Text = "II PARCIAL" Then
                                        objConsolidado.Parcial_I = 0
                                        objConsolidado.Parcial_II = row("Promedio")

                                        If Not IsDBNull(row("Promedio")) Then
                                            objConsolidado.Parcial_II_C = row("PromedioC")
                                        End If

                                        objConsolidado.Parcial_III = 0
                                        objConsolidado.Parcial_IV = 0
                                    ElseIf cmbParcial.Text = "III PARCIAL" Then
                                        objConsolidado.Parcial_I = 0
                                        objConsolidado.Parcial_II = 0
                                        objConsolidado.Parcial_III = row("Promedio")

                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_III_C = row("PromedioC")
                                        End If

                                        objConsolidado.Parcial_IV = 0
                                    ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                        objConsolidado.Parcial_I = 0
                                        objConsolidado.Parcial_II = 0
                                        objConsolidado.Parcial_III = 0
                                        objConsolidado.Parcial_IV = row("Promedio")
                                        If Not IsNothing(row("PromedioC")) Then
                                            objConsolidado.Parcial_IV_C = row("PromedioC")
                                        End If

                                    End If

                                    '' Verificamos si para ambos parciales es nota cuantitativa
                                    IncluirParcial1 = False ''20952
                                    IncluirParcial2 = False ''20953
                                    IncluirParcial3 = False ''20954
                                    IncluirParcial4 = False ''20955

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20952 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial1 = True
                                    Else
                                        IncluirParcial1 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20953 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial2 = True
                                    Else
                                        IncluirParcial2 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20954 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial3 = True
                                    Else
                                        IncluirParcial3 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20955 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial4 = True
                                    Else
                                        IncluirParcial4 = False
                                    End If

                                    If (IncluirParcial1 And IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                                    ElseIf (Not IncluirParcial1 And IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))
                                    ElseIf (IncluirParcial1 And Not IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))
                                    End If

                                    If (IncluirParcial3 And IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                                    ElseIf (Not IncluirParcial3 And IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))
                                    ElseIf (IncluirParcial3 And Not IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))
                                    End If

                                    If (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))

                                    ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))

                                    ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III) / 2), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_IV) / 2), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III) / 2), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 2), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                                    End If

                                    'objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                                    'objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                                    'objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                                    'objConsolidado.Semestre_I = (objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2
                                    'objConsolidado.Semestre_II = (objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2
                                    'objConsolidado.Nota_Final = (objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4

                                    If cmbAsignatura.EditValue <> "23" Then

                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND Desde<=" & objConsolidado.Semestre_I & " and hasta >=" & objConsolidado.Semestre_I))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Semestre_I_C = dtRangos.Rows(0)("Valor").ToString
                                        End If

                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Semestre_II & " and hasta >=" & objConsolidado.Semestre_II))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Semestre_II_C = dtRangos.Rows(0)("Valor").ToString
                                        End If

                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Nota_Final & " and hasta >=" & objConsolidado.Nota_Final))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Nota_Final_C = dtRangos.Rows(0)("Valor").ToString
                                        End If
                                    Else
                                        ''Buscar la modalidad 
                                        objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                                        If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                                            IdModalidad = objAlumnoGrupo.objModalidadID
                                        End If

                                        If IdModalidad <> 20978 Then

                                            Select Case objConsolidado.Semestre_I
                                                Case 90 To 100
                                                    objConsolidado.Semestre_I_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Semestre_I_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Semestre_I_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_I_C = "R"
                                                Case < 60
                                                    objConsolidado.Semestre_I_C = "D"
                                            End Select


                                            Select Case objConsolidado.Semestre_II
                                                Case 90 To 100
                                                    objConsolidado.Semestre_II_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Semestre_II_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Semestre_II_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_II_C = "R"
                                                Case < 60
                                                    objConsolidado.Semestre_II_C = "D"

                                            End Select

                                            Select Case objConsolidado.Nota_Final
                                                Case 90 To 100
                                                    objConsolidado.Nota_Final_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Nota_Final_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Nota_Final_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Nota_Final_C = "R"
                                                Case < 60
                                                    objConsolidado.Nota_Final_C = "D"

                                            End Select
                                        Else


                                            Select Case objConsolidado.Semestre_I
                                                Case 90 To 100
                                                    objConsolidado.Semestre_I_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Semestre_I_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_I_C = "B"
                                                Case < 60
                                                    objConsolidado.Semestre_I_C = "D"
                                            End Select


                                            Select Case objConsolidado.Semestre_II
                                                Case 90 To 100
                                                    objConsolidado.Semestre_II_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Semestre_II_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_II_C = "B"
                                                Case < 60
                                                    objConsolidado.Semestre_II_C = "D"
                                            End Select


                                            Select Case objConsolidado.Nota_Final
                                                Case 90 To 100
                                                    objConsolidado.Nota_Final_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Nota_Final_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Nota_Final_C = "B"
                                                Case < 60
                                                    objConsolidado.Nota_Final_C = "D"
                                            End Select

                                        End If
                                    End If

                                    objConsolidado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                                    objConsolidado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                                    objConsolidado.Insert(T)
                                Else
                                    If cmbParcial.Text = "I PARCIAL" Then
                                        objConsolidado.Parcial_I = row("Promedio")

                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_I_C = row("PromedioC")
                                        End If


                                    ElseIf cmbParcial.Text = "II PARCIAL" Then

                                        objConsolidado.Parcial_II = row("Promedio")
                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_II_C = row("PromedioC")
                                        End If

                                    ElseIf cmbParcial.Text = "III PARCIAL" Then
                                        objConsolidado.Parcial_III = row("Promedio")
                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_III_C = row("PromedioC")
                                        End If

                                    ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                        objConsolidado.Parcial_IV = row("Promedio")
                                        If Not IsDBNull(row("PromedioC")) Then
                                            objConsolidado.Parcial_IV_C = row("PromedioC")
                                        End If

                                    End If
                                    '' Verificamos si para ambos parciales es nota cuantitativa
                                    IncluirParcial1 = False ''20952
                                    IncluirParcial2 = False ''20953
                                    IncluirParcial3 = False ''20954
                                    IncluirParcial4 = False ''20955

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20952 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial1 = True
                                    Else
                                        IncluirParcial1 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20953 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial2 = True
                                    Else
                                        IncluirParcial2 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20954 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial3 = True
                                    Else
                                        IncluirParcial3 = False
                                    End If

                                    If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20955 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                        IncluirParcial4 = True
                                    Else
                                        IncluirParcial4 = False
                                    End If

                                    If (IncluirParcial1 And IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                                    ElseIf (Not IncluirParcial1 And IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))
                                    ElseIf (IncluirParcial1 And Not IncluirParcial2) Then
                                        objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))
                                    End If

                                    If (IncluirParcial3 And IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                                    ElseIf (Not IncluirParcial3 And IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))
                                    ElseIf (IncluirParcial3 And Not IncluirParcial4) Then
                                        objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))
                                    End If

                                    If (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))

                                    ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))

                                    ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III) / 2), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_IV) / 2), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III) / 2), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 2), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                                    ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                        objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                                    End If
                                    'objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                                    'objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                                    'objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                                    'objConsolidado.Semestre_I = (objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2
                                    'objConsolidado.Semestre_II = (objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2
                                    'objConsolidado.Nota_Final = (objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4

                                    If cmbAsignatura.EditValue <> "23" Then

                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND Desde<=" & objConsolidado.Semestre_I & " and hasta >=" & objConsolidado.Semestre_I))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Semestre_I_C = dtRangos.Rows(0)("Valor").ToString
                                        End If


                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Semestre_II & " and hasta >=" & objConsolidado.Semestre_II))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Semestre_II_C = dtRangos.Rows(0)("Valor").ToString
                                        End If

                                        dtRangos = New DataTable
                                        dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Nota_Final & " and hasta >=" & objConsolidado.Nota_Final))

                                        If dtRangos.Rows.Count > 0 Then
                                            objConsolidado.Nota_Final_C = dtRangos.Rows(0)("Valor").ToString
                                        End If
                                    Else
                                        ''Buscar la modalidad 
                                        objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                                        If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                                            IdModalidad = objAlumnoGrupo.objModalidadID
                                        End If

                                        If IdModalidad <> 20978 Then

                                            Select Case objConsolidado.Semestre_I
                                                Case 90 To 100
                                                    objConsolidado.Semestre_I_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Semestre_I_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Semestre_I_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_I_C = "R"
                                                Case < 60
                                                    objConsolidado.Semestre_I_C = "D"
                                            End Select


                                            Select Case objConsolidado.Semestre_II
                                                Case 90 To 100
                                                    objConsolidado.Semestre_II_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Semestre_II_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Semestre_II_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_II_C = "R"
                                                Case < 60
                                                    objConsolidado.Semestre_II_C = "D"

                                            End Select

                                            Select Case objConsolidado.Nota_Final
                                                Case 90 To 100
                                                    objConsolidado.Nota_Final_C = "E"
                                                Case 80 To 89
                                                    objConsolidado.Nota_Final_C = "MB"
                                                Case 70 To 79
                                                    objConsolidado.Nota_Final_C = "B"
                                                Case 60 To 69
                                                    objConsolidado.Nota_Final_C = "R"
                                                Case < 60
                                                    objConsolidado.Nota_Final_C = "D"

                                            End Select
                                        Else


                                            Select Case objConsolidado.Semestre_I
                                                Case 90 To 100
                                                    objConsolidado.Semestre_I_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Semestre_I_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_I_C = "B"
                                                Case < 60
                                                    objConsolidado.Semestre_I_C = "D"
                                            End Select


                                            Select Case objConsolidado.Semestre_II
                                                Case 90 To 100
                                                    objConsolidado.Semestre_II_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Semestre_II_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Semestre_II_C = "B"
                                                Case < 60
                                                    objConsolidado.Semestre_II_C = "D"
                                            End Select


                                            Select Case objConsolidado.Nota_Final
                                                Case 90 To 100
                                                    objConsolidado.Nota_Final_C = "E"
                                                Case 70 To 89
                                                    objConsolidado.Nota_Final_C = "MB"
                                                Case 60 To 69
                                                    objConsolidado.Nota_Final_C = "B"
                                                Case < 60
                                                    objConsolidado.Nota_Final_C = "D"
                                            End Select

                                        End If
                                    End If


                                    objConsolidado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                    objConsolidado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                    objConsolidado.Update(T)
                                End If
                            End If
                        End If

                    Else
                        objNotas.Retrieve(Integer.Parse(row("SraNotasID")), T)
                        objNotas.objAlumnoID = row("AlumnoID")
                        objNotas.objGrupoID = GrupoID
                        objNotas.objParcialID = cmbParcial.EditValue
                        objNotas.objAsignaturaID = cmbAsignatura.EditValue
                        objNotas.IND1 = row("IND1")
                        objNotas.IND2 = row("IND2")
                        objNotas.IND3 = row("IND3")
                        objNotas.IND4 = row("IND4")
                        objNotas.IND5 = row("IND5")

                        If Not IsDBNull(row("Promedio")) Then
                            objNotas.Promedio = row("Promedio")
                        End If

                        'objNotas.Promedio = row("Promedio")
                        If Not IsDBNull(row("PromedioC")) Then
                            objNotas.PromedioC = row("PromedioC")
                        End If

                        objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objNotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objNotas.Update(T)


                        ''Actualizar consolidado
                        objConsolidado.RetrieveByFilter("objAlumnoID= " & row("AlumnoID") & " AND objGrupoID=" & GrupoID & " AND objAsignaturaID=" & cmbAsignatura.EditValue, T)

                        If objConsolidado.SraConsolidadoNotasID = 0 Then
                            ''Agregar al consolidado
                            objConsolidado.objAlumnoID = row("AlumnoID")
                            objConsolidado.objGrupoID = GrupoID
                            objConsolidado.objAsignaturaID = cmbAsignatura.EditValue

                            If cmbParcial.Text = "I PARCIAL" Then
                                objConsolidado.Parcial_I = row("Promedio")
                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_I_C = row("PromedioC")
                                End If

                                objConsolidado.Parcial_II = 0
                                objConsolidado.Parcial_III = 0
                                objConsolidado.Parcial_IV = 0

                            ElseIf cmbParcial.Text = "II PARCIAL" Then
                                objConsolidado.Parcial_I = 0
                                objConsolidado.Parcial_II = row("Promedio")
                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_II_C = row("PromedioC")
                                End If

                                objConsolidado.Parcial_III = 0
                                objConsolidado.Parcial_IV = 0
                            ElseIf cmbParcial.Text = "III PARCIAL" Then
                                objConsolidado.Parcial_I = 0
                                objConsolidado.Parcial_II = 0
                                objConsolidado.Parcial_III = row("Promedio")
                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_III_C = row("PromedioC")
                                End If

                                objConsolidado.Parcial_IV = 0
                            ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                objConsolidado.Parcial_I = 0
                                objConsolidado.Parcial_II = 0
                                objConsolidado.Parcial_III = 0
                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_IV = row("Promedio")
                                End If

                                objConsolidado.Parcial_IV_C = row("PromedioC")
                            End If

                            '' Verificamos si para ambos parciales es nota cuantitativa
                            IncluirParcial1 = False ''20952
                            IncluirParcial2 = False ''20953
                            IncluirParcial3 = False ''20954
                            IncluirParcial4 = False ''20955

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20952 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial1 = True
                            Else
                                IncluirParcial1 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20953 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial2 = True
                            Else
                                IncluirParcial2 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20954 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial3 = True
                            Else
                                IncluirParcial3 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20955 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial4 = True
                            Else
                                IncluirParcial4 = False
                            End If

                            If (IncluirParcial1 And IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                            ElseIf (Not IncluirParcial1 And IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))
                            ElseIf (IncluirParcial1 And Not IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))
                            End If

                            If (IncluirParcial3 And IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                            ElseIf (Not IncluirParcial3 And IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))
                            ElseIf (IncluirParcial3 And Not IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))
                            End If

                            If (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))

                            ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))

                            ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III) / 2), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_IV) / 2), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III) / 2), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 2), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                            End If

                            'objConsolidado.Semestre_I = (objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2
                            'objConsolidado.Semestre_II = (objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2
                            'objConsolidado.Nota_Final = (objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4

                            If cmbAsignatura.EditValue <> "23" Then

                                dtRangos = New DataTable
                                dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND Desde<=" & objConsolidado.Semestre_I & " and hasta >=" & objConsolidado.Semestre_I))

                                If dtRangos.Rows.Count > 0 Then
                                    objConsolidado.Semestre_I_C = dtRangos.Rows(0)("Valor").ToString
                                End If


                                dtRangos = New DataTable
                                dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Semestre_II & " and hasta >=" & objConsolidado.Semestre_II))

                                If dtRangos.Rows.Count > 0 Then
                                    objConsolidado.Semestre_II_C = dtRangos.Rows(0)("Valor").ToString
                                End If

                                dtRangos = New DataTable
                                dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Nota_Final & " and hasta >=" & objConsolidado.Nota_Final))

                                If dtRangos.Rows.Count > 0 Then
                                    objConsolidado.Nota_Final_C = dtRangos.Rows(0)("Valor").ToString
                                End If
                            Else
                                ''Buscar la modalidad 
                                objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                                If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                                    IdModalidad = objAlumnoGrupo.objModalidadID
                                End If

                                If IdModalidad <> 20978 Then

                                    Select Case objConsolidado.Semestre_I
                                        Case 90 To 100
                                            objConsolidado.Semestre_I_C = "E"
                                        Case 80 To 89
                                            objConsolidado.Semestre_I_C = "MB"
                                        Case 70 To 79
                                            objConsolidado.Semestre_I_C = "B"
                                        Case 60 To 69
                                            objConsolidado.Semestre_I_C = "R"
                                        Case < 60
                                            objConsolidado.Semestre_I_C = "D"
                                    End Select


                                    Select Case objConsolidado.Semestre_II
                                        Case 90 To 100
                                            objConsolidado.Semestre_II_C = "E"
                                        Case 80 To 89
                                            objConsolidado.Semestre_II_C = "MB"
                                        Case 70 To 79
                                            objConsolidado.Semestre_II_C = "B"
                                        Case 60 To 69
                                            objConsolidado.Semestre_II_C = "R"
                                        Case < 60
                                            objConsolidado.Semestre_II_C = "D"

                                    End Select

                                    Select Case objConsolidado.Nota_Final
                                        Case 90 To 100
                                            objConsolidado.Nota_Final_C = "E"
                                        Case 80 To 89
                                            objConsolidado.Nota_Final_C = "MB"
                                        Case 70 To 79
                                            objConsolidado.Nota_Final_C = "B"
                                        Case 60 To 69
                                            objConsolidado.Nota_Final_C = "R"
                                        Case < 60
                                            objConsolidado.Nota_Final_C = "D"

                                    End Select
                                Else


                                    Select Case objConsolidado.Semestre_I
                                        Case 90 To 100
                                            objConsolidado.Semestre_I_C = "E"
                                        Case 70 To 89
                                            objConsolidado.Semestre_I_C = "MB"
                                        Case 60 To 69
                                            objConsolidado.Semestre_I_C = "B"
                                        Case < 60
                                            objConsolidado.Semestre_I_C = "D"
                                    End Select


                                    Select Case objConsolidado.Semestre_II
                                        Case 90 To 100
                                            objConsolidado.Semestre_II_C = "E"
                                        Case 70 To 89
                                            objConsolidado.Semestre_II_C = "MB"
                                        Case 60 To 69
                                            objConsolidado.Semestre_II_C = "B"
                                        Case < 60
                                            objConsolidado.Semestre_II_C = "D"
                                    End Select


                                    Select Case objConsolidado.Nota_Final
                                        Case 90 To 100
                                            objConsolidado.Nota_Final_C = "E"
                                        Case 70 To 89
                                            objConsolidado.Nota_Final_C = "MB"
                                        Case 60 To 69
                                            objConsolidado.Nota_Final_C = "B"
                                        Case < 60
                                            objConsolidado.Nota_Final_C = "D"
                                    End Select

                                End If
                            End If


                            objConsolidado.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objConsolidado.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objConsolidado.Insert(T)
                        Else
                            If cmbParcial.Text = "I PARCIAL" Then

                                If (IsDBNull(row("Promedio")) Or IsNothing(row("Promedio")) Or (row("Promedio").ToString.Length = 0)) Then
                                    objConsolidado.Parcial_I = 0
                                Else
                                    objConsolidado.Parcial_I = row("Promedio")
                                End If

                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_I_C = row("PromedioC")
                                End If


                            ElseIf cmbParcial.Text = "II PARCIAL" Then

                                If (IsDBNull(row("Promedio")) Or IsNothing(row("Promedio")) Or (row("Promedio").ToString.Length = 0)) Then
                                    objConsolidado.Parcial_II = 0
                                Else
                                    objConsolidado.Parcial_II = row("Promedio")
                                End If

                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_II_C = row("PromedioC")
                                End If

                            ElseIf cmbParcial.Text = "III PARCIAL" Then
                                If (IsDBNull(row("Promedio")) Or IsNothing(row("Promedio")) Or (row("Promedio").ToString.Length = 0)) Then
                                    objConsolidado.Parcial_III = 0
                                Else
                                    objConsolidado.Parcial_III = row("Promedio")
                                End If

                                If Not IsDBNull(row("PromedioC")) Then
                                        objConsolidado.Parcial_III_C = row("PromedioC")
                                    End If

                                ElseIf cmbParcial.Text = "IV PARCIAL" Then
                                If (IsDBNull(row("Promedio")) Or IsNothing(row("Promedio")) Or (row("Promedio").ToString.Length = 0)) Then
                                    objConsolidado.Parcial_IV = 0
                                Else
                                    objConsolidado.Parcial_IV = row("Promedio")
                                End If

                                If Not IsDBNull(row("PromedioC")) Then
                                    objConsolidado.Parcial_IV_C = row("PromedioC")
                                End If

                            End If

                            If IsDBNull(objConsolidado.Parcial_I) Then objConsolidado.Parcial_I = 0
                            If IsDBNull(objConsolidado.Parcial_II) Then objConsolidado.Parcial_II = 0
                            If IsDBNull(objConsolidado.Parcial_III) Then objConsolidado.Parcial_III = 0
                            If IsDBNull(objConsolidado.Parcial_IV) Then objConsolidado.Parcial_IV = 0

                            If IsNothing(objConsolidado.Parcial_I) Then objConsolidado.Parcial_I = 0
                            If IsNothing(objConsolidado.Parcial_II) Then objConsolidado.Parcial_II = 0
                            If IsNothing(objConsolidado.Parcial_III) Then objConsolidado.Parcial_III = 0
                            If IsNothing(objConsolidado.Parcial_IV) Then objConsolidado.Parcial_IV = 0

                            '' Verificamos si para ambos parciales es nota cuantitativa
                            IncluirParcial1 = False ''20952
                            IncluirParcial2 = False ''20953
                            IncluirParcial3 = False ''20954
                            IncluirParcial4 = False ''20955

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20952 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial1 = True
                            Else
                                IncluirParcial1 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20953 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial2 = True
                            Else
                                IncluirParcial2 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20954 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial3 = True
                            Else
                                IncluirParcial3 = False
                            End If

                            If (SraAsignaturasConfiguracion.RetrieveDT("objParcialID=20955 AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cuantitativa=1")).Rows.Count > 0 Then
                                IncluirParcial4 = True
                            Else
                                IncluirParcial4 = False
                            End If

                            If (IncluirParcial1 And IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                            ElseIf (Not IncluirParcial1 And IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))
                            ElseIf (IncluirParcial1 And Not IncluirParcial2) Then
                                objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))
                            End If

                            If (IncluirParcial3 And IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                            ElseIf (Not IncluirParcial3 And IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))
                            ElseIf (IncluirParcial3 And Not IncluirParcial4) Then
                                objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))
                            End If

                            If (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I)), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II)), 0))

                            ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III)), 0))

                            ElseIf (Not IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_IV)), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III) / 2), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_IV) / 2), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III) / 2), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 2), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And Not IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (Not IncluirParcial1 And IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (IncluirParcial1 And Not IncluirParcial2 And IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 3), 0))

                            ElseIf (IncluirParcial1 And IncluirParcial2 And Not IncluirParcial3 And IncluirParcial4) Then

                                objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_IV) / 3), 0))

                            End If

                            'objConsolidado.Semestre_I = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2), 0))
                            'objConsolidado.Semestre_II = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2), 0))
                            'objConsolidado.Nota_Final = Integer.Parse(Redondeo(CDbl((objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4), 0))

                            'objConsolidado.Semestre_I = (objConsolidado.Parcial_I + objConsolidado.Parcial_II) / 2
                            'objConsolidado.Semestre_II = (objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 2
                            'objConsolidado.Nota_Final = (objConsolidado.Parcial_I + objConsolidado.Parcial_II + objConsolidado.Parcial_III + objConsolidado.Parcial_IV) / 4

                            If cmbAsignatura.EditValue <> "23" Then

                                    dtRangos = New DataTable
                                    dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1 AND Desde<=" & objConsolidado.Semestre_I & " and hasta >=" & objConsolidado.Semestre_I))

                                    If dtRangos.Rows.Count > 0 Then
                                        objConsolidado.Semestre_I_C = dtRangos.Rows(0)("Valor").ToString
                                    End If


                                    dtRangos = New DataTable
                                    dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Semestre_II & " and hasta >=" & objConsolidado.Semestre_II))

                                    If dtRangos.Rows.Count > 0 Then
                                        objConsolidado.Semestre_II_C = dtRangos.Rows(0)("Valor").ToString
                                    End If

                                    dtRangos = New DataTable
                                    dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "objGradoID= " & GradoID & " AND Activo=1  and Desde<=" & objConsolidado.Nota_Final & " and hasta >=" & objConsolidado.Nota_Final))

                                    If dtRangos.Rows.Count > 0 Then
                                        objConsolidado.Nota_Final_C = dtRangos.Rows(0)("Valor").ToString
                                    End If
                                Else
                                    ''Buscar la modalidad 
                                    objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                                    If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                                        IdModalidad = objAlumnoGrupo.objModalidadID
                                    End If

                                    If IdModalidad <> 20978 Then

                                        Select Case objConsolidado.Semestre_I
                                            Case 90 To 100
                                                objConsolidado.Semestre_I_C = "E"
                                            Case 80 To 89
                                                objConsolidado.Semestre_I_C = "MB"
                                            Case 70 To 79
                                                objConsolidado.Semestre_I_C = "B"
                                            Case 60 To 69
                                                objConsolidado.Semestre_I_C = "R"
                                            Case < 60
                                                objConsolidado.Semestre_I_C = "D"
                                        End Select


                                        Select Case objConsolidado.Semestre_II
                                            Case 90 To 100
                                                objConsolidado.Semestre_II_C = "E"
                                            Case 80 To 89
                                                objConsolidado.Semestre_II_C = "MB"
                                            Case 70 To 79
                                                objConsolidado.Semestre_II_C = "B"
                                            Case 60 To 69
                                                objConsolidado.Semestre_II_C = "R"
                                            Case < 60
                                                objConsolidado.Semestre_II_C = "D"

                                        End Select

                                        Select Case objConsolidado.Nota_Final
                                            Case 90 To 100
                                                objConsolidado.Nota_Final_C = "E"
                                            Case 80 To 89
                                                objConsolidado.Nota_Final_C = "MB"
                                            Case 70 To 79
                                                objConsolidado.Nota_Final_C = "B"
                                            Case 60 To 69
                                                objConsolidado.Nota_Final_C = "R"
                                            Case < 60
                                                objConsolidado.Nota_Final_C = "D"
                                                objConsolidado.Nota_Final_C = "D"

                                        End Select
                                    Else


                                        Select Case objConsolidado.Semestre_I
                                            Case 90 To 100
                                                objConsolidado.Semestre_I_C = "E"
                                            Case 70 To 89
                                                objConsolidado.Semestre_I_C = "MB"
                                            Case 60 To 69
                                                objConsolidado.Semestre_I_C = "B"
                                            Case < 60
                                                objConsolidado.Semestre_I_C = "D"
                                        End Select


                                        Select Case objConsolidado.Semestre_II
                                            Case 90 To 100
                                                objConsolidado.Semestre_II_C = "E"
                                            Case 70 To 89
                                                objConsolidado.Semestre_II_C = "MB"
                                            Case 60 To 69
                                                objConsolidado.Semestre_II_C = "B"
                                            Case < 60
                                                objConsolidado.Semestre_II_C = "D"
                                        End Select


                                        Select Case objConsolidado.Nota_Final
                                            Case 90 To 100
                                                objConsolidado.Nota_Final_C = "E"
                                            Case 70 To 89
                                                objConsolidado.Nota_Final_C = "MB"
                                            Case 60 To 69
                                                objConsolidado.Nota_Final_C = "B"
                                            Case < 60
                                                objConsolidado.Nota_Final_C = "D"
                                        End Select

                                    End If
                                End If


                                objConsolidado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objConsolidado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objConsolidado.Update(T)
                            End If


                        End If

                        T.CommitTran()
                Next
            End If

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)


        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Dim dtVerificacion As New DataTable
        Try
            ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
            dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
            If dtVerificacion.Rows.Count > 0 Then
                AprobarNotasCualitativas()
            Else
                Aprobar()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        'If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
        '    Aprobar()
        'Else
        '    AprobarNotasCualitativas()
        'End If
        CargarGrid()
        boolGuardado = True
    End Sub


    Private Sub grdNotasTable_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles grdNotasTable.CellValueChanging
        Dim dtVerificacion As DataTable
        Try
            ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
            dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
            If dtVerificacion.Rows.Count = 0 Then
                CalcularPromedio()
            End If

            'If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
            '    CalcularPromedio()
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_MouseLeave(sender As Object, e As EventArgs) Handles grdNotasTable.MouseLeave
        Dim dtVerificacion As DataTable
        Try
            If (Not IsNothing(cmbParcial.EditValue) And Not IsNothing(cmbAsignatura.EditValue)) Then
                If (cmbParcial.EditValue.ToString.Length > 0 And cmbAsignatura.EditValue.ToString.Length > 0) Then
                    ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
                    dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")
                    If dtVerificacion.Rows.Count = 0 Then
                        CalcularPromedio()
                    End If
                    'If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
                    '    CalcularPromedio()
                    'End If
                End If
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdNotasTable.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim bValidarEntero As Boolean = False
        Dim dtVerificacion As DataTable
        Try
            ''Buscamos si la asignatura seleccionada para la modalidad seleccionada y el parcial seleccionado tiene evaluacion cualitativa o cuantitativa
            dtVerificacion = SraAsignaturasConfiguracion.RetrieveDT("objParcialID=" & cmbParcial.EditValue.ToString & " AND objModalidadID=" & frmPrincipal.glbModalidad & " AND objAsignaturaID = " & cmbAsignatura.EditValue.ToString & "AND Cualitativa=1")

            ''  If Not (((cmbAsignatura.EditValue = 20) Or (cmbAsignatura.EditValue = 26) Or (cmbAsignatura.EditValue = 27) Or (cmbAsignatura.EditValue = 23) Or (cmbAsignatura.EditValue = 3)) And frmPrincipal.glbModalidad = 20979) Then
            If dtVerificacion.Rows.Count = 0 Then
                    If View.FocusedColumn.FieldName = "IND1" Then
                        'Obtener el valor actualmente editado
                        If e.Value.ToString = String.Empty Then
                            Valor = Convert.ToDouble(0)
                        Else
                            Valor = Convert.ToDouble(e.Value)
                        End If

                        bValidarEntero = True
                    End If

                    If View.FocusedColumn.FieldName = "IND2" Then
                        'Obtener el valor actualmente editado
                        If e.Value.ToString = String.Empty Then
                            Valor = Convert.ToDouble(0)
                        Else
                            Valor = Convert.ToDouble(e.Value)
                        End If
                        bValidarEntero = True
                    End If

                    If View.FocusedColumn.FieldName = "IND3" Then
                        'Obtener el valor actualmente editado
                        If e.Value.ToString = String.Empty Then
                            Valor = Convert.ToDouble(0)
                        Else
                            Valor = Convert.ToDouble(e.Value)
                        End If
                        bValidarEntero = True
                    End If

                    If View.FocusedColumn.FieldName = "IND4" Then
                        'Obtener el valor actualmente editado
                        If e.Value.ToString = String.Empty Then
                            Valor = Convert.ToDouble(0)
                        Else
                            Valor = Convert.ToDouble(e.Value)
                        End If
                        bValidarEntero = True
                    End If

                    If View.FocusedColumn.FieldName = "IND5" Then
                        'Obtener el valor actualmente editado
                        If e.Value.ToString = String.Empty Then
                            Valor = Convert.ToDouble(0)
                        Else
                            Valor = Convert.ToDouble(e.Value)
                        End If
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
                End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_ValidateRow(sender As Object, e As ValidateRowEventArgs) Handles grdNotasTable.ValidateRow
        'Dim viewCodigoRepuesto As ColumnView = CType(sender, ColumnView)
        'Dim viewDescripcion As ColumnView = CType(sender, ColumnView)
        'Dim viewCantidad As ColumnView = CType(sender, ColumnView)
        'Dim viewCostoDolares As ColumnView = CType(sender, ColumnView)
        'Try
        '    Dim columnCodigoRepuesto As GridColumn = viewCodigoRepuesto.Columns("Codigo")
        '    Dim columnDescripcion As GridColumn = viewDescripcion.Columns("Codigo")
        '    Dim columnCantidad As GridColumn = viewCantidad.Columns("Cantidad")
        '    Dim columnCostoDolares As GridColumn = viewCostoDolares.Columns("Costo")

        '    If IsDBNull(viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto)) Then
        '        e.Valid = False
        '        viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código no puede ser nulo.")
        '        boolExisteErroresGrid = True
        '    Else
        '        'If viewCodigoRepuesto.GetRowCellValue(e.RowHandle, columnCodigoRepuesto) >= Int32.MaxValue Then
        '        '    e.Valid = False
        '        '    viewCodigoRepuesto.SetColumnError(columnCodigoRepuesto, "El Código ingresado no es soportado.")
        '        '    boolExisteErroresGrid = True
        '        'Else
        '        '    boolExisteErroresGrid = False
        '        'End If
        '    End If

        '    If IsDBNull(viewDescripcion.GetRowCellValue(e.RowHandle, columnDescripcion)) Then
        '        e.Valid = False
        '        viewDescripcion.SetColumnError(columnDescripcion, "La descripcion no puede ser nula.")
        '        boolExisteErroresGrid = True
        '    Else
        '        boolExisteErroresGrid = False
        '    End If

        '    If IsDBNull(viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad)) OrElse viewCantidad.GetRowCellValue(e.RowHandle, columnCantidad) <= 0 Then
        '        e.Valid = False
        '        viewCantidad.SetColumnError(columnCantidad, "La Cantidad no puede contener un valor NULO, CERO o NEGATIVO.")
        '        boolExisteErroresGrid = True
        '    Else
        '        boolExisteErroresGrid = False
        '    End If

        '    If IsDBNull(viewCostoDolares.GetRowCellValue(e.RowHandle, columnCostoDolares)) Then
        '        e.Valid = False
        '        viewCostoDolares.SetColumnError(columnCostoDolares, "El Costo Dolares no puede ser nulo.")
        '        boolExisteErroresGrid = True
        '    Else
        '        If viewCostoDolares.GetRowCellValue(e.RowHandle, columnCostoDolares) >= Double.MaxValue Then
        '            e.Valid = False
        '            viewCostoDolares.SetColumnError(columnCostoDolares, "El Costo Dolares ingresado no es soportado.")
        '            boolExisteErroresGrid = True
        '        Else
        '            boolExisteErroresGrid = False
        '        End If
        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try

    End Sub
End Class