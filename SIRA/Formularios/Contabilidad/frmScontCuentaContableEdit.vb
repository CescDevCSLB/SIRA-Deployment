Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmScontCuentaContableEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intCuentaID, intCuentaPadreID, intCentroCostoID As Integer
    Shared dtCuentasA, dtCuentasEliminadas, dtCuentasDatos, dtNaturaleza, dtNivel, DtCentroCosto, dtClasificacion As DataTable
    Dim IDCuenta As String


#End Region

#Region "Propiedades"

    Property TyGui() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

    Property CuentaID() As Integer
        Get
            Return intCuentaID
        End Get
        Set(ByVal value As Integer)
            intCuentaID = value
        End Set
    End Property

    Property CentroCostoID() As Integer
        Get
            Return intCentroCostoID
        End Get
        Set(ByVal value As Integer)
            intCentroCostoID = value
        End Set
    End Property


#End Region

    Private Sub CargarNaturaleza()
        Try
            dtNaturaleza = New DataTable
            dtNaturaleza = ClsCatalogos.ObtenerValCat("NATURALEZA")
            With cmbNaturaleza
                .DataSource = dtNaturaleza
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarClasificacion()
        Try
            dtClasificacion = New DataTable
            dtClasificacion = ClsCatalogos.ObtenerValCat("CLASIFICACIONCUENTAS")
            With cmbClasificacion
                .DataSource = dtClasificacion
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarNvel()
        Try
            dtNivel = New DataTable
            dtNivel = ClsCatalogos.ObtenerValCat("NivelCuenta")
            With cmbNivel
                .DataSource = dtNivel
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarCentroCosto()
        Try
            DtCentroCosto = New DataTable
            DtCentroCosto = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SconCentroCostoID, Nombre", "ScontCentrosCosto", "Activo=1"))
            With cmbCentroCosto
                .DataSource = DtCentroCosto
                .ValueMember = "SconCentroCostoID"
                .DisplayMember = "Nombre"
                .Splits(0).DisplayColumns("SconCentroCostoID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Public Sub CargarCentrosCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = " & CuentaID & " AND Activo=1"
            dtCuentasA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", strFiltro))
            dtCuentasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", "Activo=0 AND SContCuentasContablesID = " & CuentaID))

            grdCentrosCosto.DataSource = dtCuentasA
            grdCentrosCosto.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarCentroCostoEdit()
        Dim objScontCuenta As SContCuentasContables
        Try
            objScontCuenta = New SContCuentasContables
            objScontCuenta.Retrieve(CuentaID)
            txtCodigo.Text = objScontCuenta.IDCuenta
            txtDescripcion.Text = objScontCuenta.Descripcion

            If Not IsNothing(objScontCuenta.objNaturalezaID) Then
                cmbNaturaleza.SelectedValue = objScontCuenta.objNaturalezaID
            End If

            If Not IsNothing(objScontCuenta.objClasificacionID) Then
                cmbClasificacion.SelectedValue = objScontCuenta.objClasificacionID
            End If

            cmbNivel.SelectedValue = objScontCuenta.Nivel
            chkRecibeMovimiento.Checked = objScontCuenta.RecibeMovimiento
            chkTieneAuxilar.Checked = objScontCuenta.TieneAuxilar
            chkTieneCentroCosto.Checked = objScontCuenta.CentroCosto
            chkActivo.Checked = objScontCuenta.Activo
            chkCuentaBalance.Checked = objScontCuenta.CuentaBalance
            chkCuentaEstado.Checked = objScontCuenta.CuentaEstadoResultado

            ''cargar la cuenta Padre
            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", "IDCuenta = '" & objScontCuenta.CuentaPadre & "'"))
            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtCuentaSuperior.Text = dtCuentasDatos.Rows(0)("Descripcion")
                intCuentaPadreID = dtCuentasDatos.Rows(0)("SContCuentasContablesID").ToString
                IDCuenta = dtCuentasDatos.Rows(0)("IDCuenta").ToString
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CargarCentrosCuenta()
            CargarNaturaleza()
            CargarNvel()
            CargarCentroCosto()
            CargarClasificacion()

            Select Case TyGui

                Case 1
                    Me.Text = "Nueva cuenta contable"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                Case 2
                    Me.Text = "Editar cuenta contable"
                    Me.chkActivo.Enabled = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                    CargarCentroCostoEdit()

                Case 3
                    Me.Text = "Consultar cuenta contable"
                    txtCodigo.Enabled = False
                    Me.cmbPeriodo.Enabled = False
                    Me.chkActivo.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    cmdGuardar.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    cmdBuscar.Enabled = False
                    cmbCentroCosto.Enabled = False
                    cmbNaturaleza.Enabled = False
                    cmbNivel.Enabled = False
                    chkTieneCentroCosto.Enabled = False
                    chkTieneAuxilar.Enabled = False
                    chkRecibeMovimiento.Enabled = False
                    cmbClasificacion.Enabled = False
                    txtDescripcion.Enabled = False
                    CargarCentroCostoEdit()
                    'grdGradosATable.ALL = False
                Case 4
                    Me.Text = "Nueva cuenta contable"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True

                    Dim strFiltro As String = ""
                    strFiltro = "SconCentroCostoID = " & intCentroCostoID
                    dtCuentasA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SconCentroCostoID as objSconCentroCostoID, 0 as SconCentroCostoCatalogoID, 0 as SContCuentasContablesID, '' as IDCuenta, '' as Descripcion, Activo, Nombre as  CentroCosto", "ScontCentrosCosto", strFiltro))
                    dtCuentasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", "Activo=0 AND SContCuentasContablesID = " & CuentaID))

                    grdCentrosCosto.DataSource = dtCuentasA
                    grdCentrosCosto.ForceInitialize()

            End Select


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub GenerarSaldos(T As TransactionManager)
        Dim parametro(3) As SqlClient.SqlParameter
        Try
            parametro(0) = New SqlClient.SqlParameter("@IntCuentaContable ", SqlDbType.Int, 4)
            parametro(0).Value = CuentaID
            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "SP_GenerarSaldosInicial", parametro)

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objCuenta As SContCuentasContables
        Dim dtValidarCuenta As DataTable
        Dim objScontCentroCostoCuentas As ScontCentroCostoCuentas
        Try
            objScontCentroCostoCuentas = New ScontCentroCostoCuentas
            objCuenta = New SContCuentasContables
            T.BeginTran()

            If txtCodigo.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtCodigo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtDescripcion.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtDescripcion, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbNaturaleza.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbNaturaleza, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbClasificacion.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbClasificacion, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbNivel.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbNivel, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            Select Case TyGui
                Case 1, 4
                    ''Validar que el numero de cuenta no exista
                    dtValidarCuenta = New DataTable
                    dtValidarCuenta = SContCuentasContables.RetrieveDT("IDCuenta='" & txtCodigo.Text & "'")

                    If dtValidarCuenta.Rows.Count > 0 Then
                        MsgBox("No es posible guardar los cambios. Ya existe una cuenta con este código.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If

                    objCuenta.IDCuenta = txtCodigo.Text
                    objCuenta.Descripcion = txtDescripcion.Text
                    objCuenta.RecibeMovimiento = chkRecibeMovimiento.Checked
                    objCuenta.TieneAuxilar = chkTieneAuxilar.Checked
                    objCuenta.CentroCosto = chkTieneCentroCosto.Checked
                    objCuenta.CuentaPadre = IDCuenta
                    objCuenta.Activo = chkActivo.Checked
                    objCuenta.objNaturalezaID = cmbNaturaleza.SelectedValue
                    objCuenta.objClasificacionID = cmbClasificacion.SelectedValue
                    objCuenta.Nivel = cmbNivel.SelectedValue
                    objCuenta.CuentaBalance = chkCuentaBalance.Checked
                    objCuenta.CuentaEstadoResultado = chkCuentaEstado.Checked
                    objCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objCuenta.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objCuenta.Insert(T)
                    CuentaID = objCuenta.SContCuentasContablesID
                    GenerarSaldos(T)
                Case 2
                    ''Validar que el numero de cuenta no exista
                    dtValidarCuenta = New DataTable
                    dtValidarCuenta = SContCuentasContables.RetrieveDT("Activo = 1 AND SContCuentasContablesID<> " & CuentaID & " AND IDCuenta='" & txtCodigo.Text & "'")

                    If dtValidarCuenta.Rows.Count > 0 Then
                        MsgBox("No es posible guardar los cambios. Ya existe una cuenta con este código.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If

                    objCuenta.Retrieve(CuentaID)
                    objCuenta.IDCuenta = txtCodigo.Text
                    objCuenta.Descripcion = txtDescripcion.Text
                    objCuenta.RecibeMovimiento = chkRecibeMovimiento.Checked
                    objCuenta.TieneAuxilar = chkTieneAuxilar.Checked
                    objCuenta.CentroCosto = chkTieneCentroCosto.Checked
                    objCuenta.CuentaPadre = IDCuenta
                    objCuenta.Activo = chkActivo.Checked
                    objCuenta.objNaturalezaID = cmbNaturaleza.SelectedValue
                    objCuenta.objClasificacionID = cmbClasificacion.SelectedValue
                    objCuenta.Nivel = cmbNivel.SelectedValue
                    objCuenta.CuentaBalance = chkCuentaBalance.Checked
                    objCuenta.CuentaEstadoResultado = chkCuentaEstado.Checked
                    objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objCuenta.Update(T)
            End Select

            ScontCentroCostoCuentas.DeleteByFilter("objCuentaContableID=" & intCuentaID, T)

            For Each dr As DataRow In dtCuentasA.Rows
                objScontCentroCostoCuentas.objCuentaContableID = intCuentaID
                objScontCentroCostoCuentas.objSconCentroCostoID = dr("objSconCentroCostoID").ToString
                objScontCentroCostoCuentas.Activo = True
                objScontCentroCostoCuentas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontCentroCostoCuentas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontCentroCostoCuentas.Insert(T)
            Next

            For Each dr As DataRow In dtCuentasEliminadas.Rows
                objScontCentroCostoCuentas.objCuentaContableID = intCuentaID
                objScontCentroCostoCuentas.objSconCentroCostoID = dr("objSconCentroCostoID").ToString
                objScontCentroCostoCuentas.Activo = False
                objScontCentroCostoCuentas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontCentroCostoCuentas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontCentroCostoCuentas.Insert(T)
            Next
            AgregarSaldo(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub AgregarSaldo(T As DAL.TransactionManager)

        Dim parametro(3) As SqlClient.SqlParameter

        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Try
            parametro(0) = New SqlClient.SqlParameter("@IDCuenta ", SqlDbType.Int, 4)
            parametro(0).Value = CuentaID

            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario

            parametro(2) = New SqlClient.SqlParameter("@mes ", SqlDbType.Int, 4)
            parametro(2).Value = Now.Date.Month


            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_AgregarSaldoInicialCentroCosto", parametro)

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        ErrPrv.SetError(txtDescripcion, "")
    End Sub

    Private Sub cmbClasificacion_TextChanged(sender As Object, e As EventArgs) Handles cmbClasificacion.TextChanged
        ErrPrv.SetError(cmbClasificacion, "")
    End Sub

    Private Sub cmbNaturaleza_TextChanged(sender As Object, e As EventArgs) Handles cmbNaturaleza.TextChanged
        ErrPrv.SetError(cmbNaturaleza, "")
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ErrPrv.SetError(txtCodigo, "")
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try
            Dim filas As DataRow

            filas = dtCuentasA.NewRow
            filas("objSconCentroCostoID") = cmbCentroCosto.SelectedValue
            filas("CentroCosto") = cmbCentroCosto.Text
            dtCuentasA.Rows.Add(filas)
            cmbCentroCosto.Text = String.Empty

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrados_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdCentrosCostoTabla.SelectedRowsCount() - 1
                If (grdCentrosCostoTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdCentrosCostoTabla.GetDataRow(grdCentrosCostoTabla.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaGradosEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtCuentasEliminadas.NewRow
                filas("objSconCentroCostoID") = CInt(drFilaGradosEliminadas("objSconCentroCostoID"))
                filas("CentroCosto") = drFilaGradosEliminadas("CentroCosto").ToString
                dtCuentasEliminadas.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dtCuentasA.Rows.Remove(drFilaGradosE)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & intCuentaPadreID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))
            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtCuentaSuperior.Text = dtCuentasDatos.Rows(0)("Descripcion")
                intCuentaPadreID = dtCuentasDatos.Rows(0)("SContCuentasContablesID").ToString
                IDCuenta = dtCuentasDatos.Rows(0)("IDCuenta").ToString
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                intCuentaPadreID = objSeleccion.Seleccion
                CargarCuenta()
                Me.txtCuentaSuperior.Text = dtCuentasDatos.Rows(0)("Descripcion")
                intCuentaPadreID = dtCuentasDatos.Rows(0)("IDCuenta")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkTieneAuxilar_CheckedChanged(sender As Object, e As EventArgs) Handles chkTieneAuxilar.CheckedChanged
        'Try
        '    If Not chkTieneAuxilar.Checked Then
        '        cmdBuscar.Visible = True
        '        txtCuentaSuperior.Visible = True
        '        lblSuperior.Visible = True
        '    Else
        '        cmdBuscar.Visible = False
        '        txtCuentaSuperior.Visible = False
        '        lblSuperior.Visible = False
        '    End If
        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'End Try
    End Sub

    Private Sub cmbNivel_TextChanged(sender As Object, e As EventArgs) Handles cmbNivel.TextChanged
        Try
            ErrPrv.SetError(cmbNivel, "")

            'If cmbNivel.Text = "1" Then
            '    cmdBuscar.Visible = False
            '    txtCuentaSuperior.Visible = False
            '    lblSuperior.Visible = False
            'Else
            '    cmdBuscar.Visible = True
            '    txtCuentaSuperior.Visible = True
            '    lblSuperior.Visible = True
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkTieneCentroCosto_CheckedChanged(sender As Object, e As EventArgs) Handles chkTieneCentroCosto.CheckedChanged
        Try
            If chkTieneCentroCosto.Checked = True Then
                cmbCentroCosto.Enabled = True
                cmdAgregar.Enabled = True
                cmdEliminar.Enabled = True
            Else
                cmbCentroCosto.Enabled = False
                cmdAgregar.Enabled = False
                cmdEliminar.Enabled = False
                dtCuentasA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", "1=0"))

                grdCentrosCosto.DataSource = dtCuentasA
                grdCentrosCosto.ForceInitialize()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class