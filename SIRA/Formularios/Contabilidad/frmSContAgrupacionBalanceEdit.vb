Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSContAgrupacionBalanceEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intAgrupacionID As Integer
    Shared dtCuentasA, dtCuentasEliminadas, dtClasificacion As DataTable

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

    Property AgrupacionID() As Integer
        Get
            Return intAgrupacionID
        End Get
        Set(ByVal value As Integer)
            intAgrupacionID = value
        End Set
    End Property


#End Region

    Public Sub CargarAgrupacionesCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "objAgrupacionBalanceGeneralID = " & AgrupacionID & " AND Activo=1"
            dtCuentasA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objAgrupacionBalanceGeneralID, ScontAgrupacionBalanceDetalleID, SContCuentasContablesID, IDCuenta, Descripcion, Activo", "vwSContAgrupacionCuentas", strFiltro))
            dtCuentasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objAgrupacionBalanceGeneralID, ScontAgrupacionBalanceDetalleID, SContCuentasContablesID, IDCuenta, Descripcion, Activo", "vwSContAgrupacionCuentas", "Activo=0 AND objAgrupacionBalanceGeneralID = " & AgrupacionID))

            grdGradosA.DataSource = dtCuentasA
            grdGradosA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarClasificacion()
        Try
            dtClasificacion = New DataTable
            dtClasificacion = ClsCatalogos.ObtenerValCat("AGRUPACIONBALANCEGENERAL")
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

    Private Sub CargarAgrupacionEdit()
        Dim objScontAgrupacion As ScontAgrupacionBalanceGeneral
        Try
            objScontAgrupacion = New ScontAgrupacionBalanceGeneral
            objScontAgrupacion.Retrieve(AgrupacionID)
            txtTitulo.Text = objScontAgrupacion.Descripcion
            chkActivo.Checked = objScontAgrupacion.Activo
            cmbClasificacion.SelectedValue = objScontAgrupacion.objAgrupacioBalanceID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CargarClasificacion()
            CargarAgrupacionesCuenta()
            Select Case TyGui

                Case 1
                    Me.Text = "Nuevo agrupacion"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                Case 2
                    Me.Text = "Editar agrupacion"
                    Me.chkActivo.Enabled = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                    CargarAgrupacionEdit()

                Case 3
                    Me.Text = "Consultar agrupacion"
                    txtTitulo.Enabled = False
                    Me.cmbPeriodo.Enabled = False
                    Me.chkActivo.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    cmdGuardar.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    cmbClasificacion.Enabled = False
                    CargarAgrupacionEdit()
            End Select


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objagrupacion As ScontAgrupacionBalanceGeneral
        Dim objScontAgrupacionDetalle As ScontAgrupacionBalanceDetalle
        Try
            objScontAgrupacionDetalle = New ScontAgrupacionBalanceDetalle
            objagrupacion = New ScontAgrupacionBalanceGeneral
            T.BeginTran()

            If txtTitulo.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtTitulo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If cmbClasificacion.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbClasificacion, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            Select Case TyGui
                Case 1
                    objagrupacion.objAgrupacioBalanceID = cmbClasificacion.SelectedValue
                    objagrupacion.Descripcion = txtTitulo.Text
                    objagrupacion.Activo = chkActivo.Checked
                    objagrupacion.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objagrupacion.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objagrupacion.Insert(T)
                    AgrupacionID = objagrupacion.ScontAgrupacionBalanceID
                Case 2
                    objagrupacion.Retrieve(AgrupacionID)
                    objagrupacion.objAgrupacioBalanceID = cmbClasificacion.SelectedValue
                    objagrupacion.Descripcion = txtTitulo.Text
                    objagrupacion.Activo = chkActivo.Checked
                    objagrupacion.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objagrupacion.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objagrupacion.Update(T)
            End Select

            ScontAgrupacionBalanceDetalle.DeleteByFilter("objAgrupacionBalanceGeneralID=" & intAgrupacionID, T)

            For Each dr As DataRow In dtCuentasA.Rows
                objScontAgrupacionDetalle.objAgrupacionBalanceGeneralID = intAgrupacionID
                objScontAgrupacionDetalle.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objScontAgrupacionDetalle.Activo = True
                objScontAgrupacionDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontAgrupacionDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontAgrupacionDetalle.Insert(T)
            Next

            For Each dr As DataRow In dtCuentasEliminadas.Rows
                objScontAgrupacionDetalle.objAgrupacionBalanceGeneralID = intAgrupacionID
                objScontAgrupacionDetalle.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objScontAgrupacionDetalle.Activo = False
                objScontAgrupacionDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontAgrupacionDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontAgrupacionDetalle.Insert(T)
            Next

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub cmbClasificacion_TextChanged(sender As Object, e As EventArgs) Handles cmbClasificacion.TextChanged
        ErrPrv.SetError(cmbClasificacion, "")
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        ErrPrv.SetError(txtTitulo, "")
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try

            Dim objSeleccion As frmCuentaSelector
            objSeleccion = New frmCuentaSelector

            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim filas As DataRow
                For Each dr As DataRow In frmCuentaSelector.dtCuentasSelect.Rows

                    filas = dtCuentasA.NewRow
                    filas("SContCuentasContablesID") = CInt(dr("SContCuentasContablesID").ToString)
                    filas("IDCuenta") = (dr("IDCuenta").ToString)
                    filas("Descripcion") = (dr("Descripcion").ToString)
                    dtCuentasA.Rows.Add(filas)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrados_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdGradosATable.SelectedRowsCount() - 1
                If (grdGradosATable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdGradosATable.GetDataRow(grdGradosATable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaGradosEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtCuentasEliminadas.NewRow
                filas("SContCuentasContablesID") = CInt(drFilaGradosEliminadas("SContCuentasContablesID"))
                filas("IDCuenta") = drFilaGradosEliminadas("IDCuenta").ToString
                filas("Descripcion") = drFilaGradosEliminadas("Descripcion").ToString
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
End Class