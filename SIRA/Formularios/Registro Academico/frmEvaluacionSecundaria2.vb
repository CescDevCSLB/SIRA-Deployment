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

Public Class frmEvaluacionSecundaria2

#Region "Declaracion de Variables"
    Public DtSeccion, DtGrados, DtParcial, DtAsignaturas, dtGrupos, dtNotas, DtBusquedaProfesor As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAprobar, boolImprimir, boolExportar, boolDesactivar As Boolean
    Dim intEstadoAbonoRegistrado As Integer
    Dim intGrupo, intGrado, intProfesor As Integer
    Dim boolGuardado As Boolean
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

        Try
            ''Buscamos si existen notas para este parcial y la asignatura seleccionada

            dtNotas = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral("EXEC pr_NotasEvaluacion2 " & GrupoID & " , " & cmbAsignatura.EditValue.ToString & ", " & cmbParcial.EditValue.ToString))
            dtNotas.DefaultView.Sort = "Codigo, SraNotasID asc"
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
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "PeriodoID= " & frmPrincipal.glbPeriodoSeleccionado & " AND SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then

                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                    Me.GradoID = dtGrupos.Rows(0)("GradoID")
                    evalCualitativa = dtGrupos.Rows(0)("EvaluacionCualitativa")
                    evalCuantitativa = dtGrupos.Rows(0)("EvaluacionCuantitativa")

                    If Not evalCualitativa Then
                        colNotaCualitativa.Visible = False
                    End If

                    If Not evalCuantitativa Then
                        colNotaCualitativa.Visible = True
                    End If

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
        Dim Promedio As Integer = 0
        Dim vista As GridView = sender

        Try

            Promedio = Integer.Parse(vista.GetRowCellValue(e.RowHandle, vista.Columns("Promedio")))
        Catch ex As Exception

        End Try
        Select Case Promedio
            Case Is < 60
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.White

            Case Is >= 60
                e.Appearance.BackColor = Color.LimeGreen
                e.Appearance.BackColor2 = Color.White



        End Select
    End Sub

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
                        dblPromedio = Math.Round(TotalNotas / SumTieneValor, 0)
                        row("Promedio") = dblPromedio.ToString
                    End If

                    ''Buscar la modalidad 
                    objAlumnoGrupo.RetrieveByFilter("SraGrupoID= " + GrupoID.ToString)

                    If Not IsNothing(objAlumnoGrupo.objModalidadID) Then
                        IdModalidad = objAlumnoGrupo.objModalidadID
                    End If


                    ''Buscar si la modalidad es por grado
                    dtRangos = New DataTable
                    objGradosModalidad.RetrieveByFilter("objModalidadID=" & IdModalidad & " AND objGradoID=" & objAlumnoGrupo.objGradoID)

                    dtRangos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor", "vwSraRangosModalidad", "Activo=1 AND  Desde<=" + row("Promedio").ToString + " and hasta >=" + row("Promedio").ToString))

                    If dtRangos.Rows.Count > 0 Then
                        row("PromedioC") = dtRangos.Rows(0)("Valor").ToString
                    End If

                    ''Buscar la nota cualitativa correspondiente
                    'If objGradosModalidad.SraRangosGradosID <> 0 Then

                    'Else
                    '    objNotascualitavias.RetrieveByFilter("objModalidadID=" + IdModalidad.ToString + " and Desde<=" + row("Promedio").ToString + " and hasta >=" + row("Promedio").ToString)
                    '    row("PromedioC") = objNotascualitavias.Valor
                    'End If


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
                        End If
                    End If

                End If

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
        Try
            'FilaActual = Me.grdNotasTable.FocusedRowHandle
            'If e.Column.Equals(Me.colIndicador1) Then
            '    Me.dtNotas.DefaultView.Item(FilaActual)("IND1") = Me.grdNotasTable.EditingValue
            'End If

            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub RepositoryItemCheckEdit2_CheckedChanged(sender As Object, e As EventArgs) Handles RepositoryItemCheckEdit2.CheckedChanged
        CalcularPromedio()
    End Sub

    Private Sub Aprobar()
        Dim Rows As New ArrayList()
        Dim I As Integer
        Dim objNotasrepetidas As New SraNotasReepetidas
        Try
            For I = 0 To grdNotasTable.SelectedRowsCount() - 1
                If (grdNotasTable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdNotasTable.GetDataRow(grdNotasTable.GetSelectedRows()(I)))
                End If
            Next
            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                objNotasrepetidas.SraNotasID = CInt(drFilaAsignaturaEliminadas("SraNotasID"))
                objNotasrepetidas.objGrupoID = GrupoID
                objNotasrepetidas.objAlumnoID = CInt(drFilaAsignaturaEliminadas("AlumnoID"))
                objNotasrepetidas.objAsignaturaID = cmbAsignatura.EditValue
                objNotasrepetidas.objParcialID = cmbParcial.EditValue
                objNotasrepetidas.IND1 = CInt(drFilaAsignaturaEliminadas("IND1"))
                objNotasrepetidas.IND2 = CInt(drFilaAsignaturaEliminadas("IND2"))
                objNotasrepetidas.IND3 = CInt(drFilaAsignaturaEliminadas("IND3"))
                objNotasrepetidas.IND4 = CInt(drFilaAsignaturaEliminadas("IND4"))
                objNotasrepetidas.IND5 = CInt(drFilaAsignaturaEliminadas("IND5"))
                objNotasrepetidas.Insert()

            Next

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)


        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub
    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        Aprobar()
        CargarGrid()
        boolGuardado = True
    End Sub


    Private Sub grdNotasTable_CellValueChanging(sender As Object, e As CellValueChangedEventArgs) Handles grdNotasTable.CellValueChanging
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_MouseLeave(sender As Object, e As EventArgs) Handles grdNotasTable.MouseLeave
        Try
            CalcularPromedio()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub grdNotasTable_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles grdNotasTable.ValidatingEditor
        Dim View As GridView = sender
        Dim Valor As Double
        Dim bValidarEntero As Boolean = False
        Try
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