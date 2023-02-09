Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmScontCentroCostoEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intCentroID As Integer
    Shared dtCuentasA, dtCuentasEliminadas As DataTable

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

    Property CentroID() As Integer
        Get
            Return intCentroID
        End Get
        Set(ByVal value As Integer)
            intCentroID = value
        End Set
    End Property


#End Region
    Public Sub CargarCentrosCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "objSconCentroCostoID = " & CentroID & " AND Activo=1"
            dtCuentasA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", strFiltro))
            dtCuentasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, objSconCentroCostoID, SconCentroCostoCatalogoID, SContCuentasContablesID, IDCuenta, Descripcion, Activo, CentroCosto", "vwSContCentroCostoCuentas", "Activo=0 AND objSconCentroCostoID = " & CentroID))

            grdGradosA.DataSource = dtCuentasA
            grdGradosA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarCentroCostoEdit()
        Dim objScontCentro As ScontCentrosCosto
        Try
            objScontCentro = New ScontCentrosCosto
            objScontCentro.Retrieve(CentroID)
            txtCodigo.Text = objScontCentro.Codigo
            txtTitulo.Text = objScontCentro.Nombre
            chkActivo.Checked = objScontCentro.Activo
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CargarCentrosCuenta()
            Select Case TyGui

                Case 1
                    Me.Text = "Nuevo centro de costo"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                Case 2
                    Me.Text = "Editar centro de costo"
                    Me.chkActivo.Enabled = True
                    cmdAgregar.Enabled = True
                    cmdEliminar.Enabled = True
                    cmdGuardar.Enabled = True
                    CargarCentroCostoEdit()

                Case 3
                    Me.Text = "Consultar centro de costo"
                    txtTitulo.Enabled = False
                    Me.cmbPeriodo.Enabled = False
                    Me.chkActivo.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    cmdGuardar.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdEliminar.Enabled = False
                    CargarCentroCostoEdit()
                    'grdGradosATable.ALL = False
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
        Dim objCentroCosto As ScontCentrosCosto
        Dim objScontCentroCostoCuentas As ScontCentroCostoCuentas
        Try
            objScontCentroCostoCuentas = New ScontCentroCostoCuentas
            objCentroCosto = New ScontCentrosCosto
            T.BeginTran()

            If txtTitulo.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtTitulo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If txtCodigo.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtCodigo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            Select Case TyGui
                Case 1
                    objCentroCosto.Codigo = txtCodigo.Text
                    objCentroCosto.Nombre = txtTitulo.Text
                    objCentroCosto.Activo = chkActivo.Checked
                    objCentroCosto.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objCentroCosto.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objCentroCosto.Insert(T)
                    CentroID = objCentroCosto.SconCentroCostoID
                Case 2
                    objCentroCosto.Retrieve(CentroID)
                    objCentroCosto.Codigo = txtCodigo.Text
                    objCentroCosto.Nombre = txtTitulo.Text
                    objCentroCosto.Activo = chkActivo.Checked
                    objCentroCosto.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCentroCosto.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objCentroCosto.Update(T)
            End Select

            ScontCentroCostoCuentas.DeleteByFilter("objSconCentroCostoID=" & intCentroID, T)

            For Each dr As DataRow In dtCuentasA.Rows
                objScontCentroCostoCuentas.objSconCentroCostoID = intCentroID
                objScontCentroCostoCuentas.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objScontCentroCostoCuentas.Activo = True
                objScontCentroCostoCuentas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontCentroCostoCuentas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontCentroCostoCuentas.Insert(T)
            Next

            For Each dr As DataRow In dtCuentasEliminadas.Rows
                objScontCentroCostoCuentas.objSconCentroCostoID = intCentroID
                objScontCentroCostoCuentas.objCuentaContableID = dr("SContCuentasContablesID").ToString
                objScontCentroCostoCuentas.Activo = False
                objScontCentroCostoCuentas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objScontCentroCostoCuentas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objScontCentroCostoCuentas.Insert(T)
            Next

            ''Ingresar saldos por centros de costo en 0
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
            parametro(0) = New SqlClient.SqlParameter("@IDCentro ", SqlDbType.Int, 4)
            parametro(0).Value = CentroID

            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario

            parametro(2) = New SqlClient.SqlParameter("@mes ", SqlDbType.Int, 4)
            parametro(2).Value = Now.Date.Month

            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_AgregarSaldoInicialCentroCostoCC", parametro)

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
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