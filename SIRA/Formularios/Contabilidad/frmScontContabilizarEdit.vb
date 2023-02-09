Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmScontContabilizarEdit

#Region "Declaración de Variables propias del formulario"
    Dim TyGui_Lec, intCuentaID, IDComprobante, NumCuenta As Integer
    Shared dtCuentasA, dtCuentasDatos, DtTipoAsiento, DtCentroCosto As DataTable
    Dim intAcreeedora, intDeudora As Integer
    Dim dblMonto As Decimal
#End Region

#Region "Propiedades"

    Property Monto() As Decimal
        Get
            Return dblMonto
        End Get
        Set(ByVal value As Decimal)
            dblMonto = value
        End Set
    End Property

    Property ComprobanteID() As Integer
        Get
            Return IDComprobante
        End Get
        Set(ByVal value As Integer)
            IDComprobante = value
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

    Property TypeID() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

#End Region

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

    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarTipoAsiento()
            dtCuentasA = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("SContContablesID, MontoAcreditar, MontoDebitar, IDCuenta, Descripcion", "vwScontComprobanteDetalleCuenta", "1=0"))
            grdGradosA.DataSource = dtCuentasA

            intAcreeedora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "01")
            intDeudora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "02")

            NumMonto.Value = Monto
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Deshabiliatar()
        Try
            txtCuenta.Enabled = False
            cmbTipoasiento.Enabled = False
            txtObservaciones.Enabled = False
            txtConcepto.Enabled = False
            dtpFecha.Enabled = False
            numAcreditar.Enabled = False
            numDebitar.Enabled = False
            cmdBuscar.Enabled = False
            cmdAgregar.Enabled = False
            cmdEliminar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objScontComprobanteID, objScontComprobanteIDUP As ScontComprobanteID
        Dim objSContComprobanteDetalle As SContComprobanteDetalle
        Dim objNaturaleza As SContCuentasContables
        Try
            objScontComprobanteID = New ScontComprobanteID
            objScontComprobanteIDUP = New ScontComprobanteID
            objSContComprobanteDetalle = New SContComprobanteDetalle
            T.BeginTran()

            If dtCuentasA.Rows.Count = 0 Then
                MsgBox("Indique las cuentas contables.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Exit Sub
            End If

            objScontComprobanteID.Fecha = dtpFecha.Value
            objScontComprobanteID.Concepto = txtConcepto.Text
            objScontComprobanteID.objTipoAsientoID = cmbTipoasiento.SelectedValue
            objScontComprobanteID.Observaciones = txtObservaciones.Text
            objScontComprobanteID.ValorCordobas = numTotal.Value
            objScontComprobanteID.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objScontComprobanteID.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objScontComprobanteID.Insert(T)
            IDComprobante = objScontComprobanteID.ScontComprobanteID

            For Each dr As DataRow In dtCuentasA.Rows
                objSContComprobanteDetalle.objSContCompronanteID = IDComprobante
                objSContComprobanteDetalle.SContContablesID = dr("SContContablesID").ToString
                objSContComprobanteDetalle.MontoAcreditar = dr("MontoAcreditar").ToString
                objSContComprobanteDetalle.MontoDebitar = dr("MontoDebitar").ToString

                ''Buscar la naturaleza de la cuenta
                objNaturaleza = New SContCuentasContables
                objNaturaleza.Retrieve(dr("SContContablesID").ToString, T)

                If objNaturaleza.objNaturalezaID = intDeudora Then
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
                Else
                    objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
                End If

                objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objSContComprobanteDetalle.Insert(T)
            Next
            objScontComprobanteIDUP.Retrieve(IDComprobante, T)
            objScontComprobanteIDUP.NumAsiento = IDComprobante
            objScontComprobanteIDUP.Update(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            cmdGuardar.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub


    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtCuenta.TextChanged
        ErrPrv.SetError(txtCuenta, "")
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Try
            If Me.txtCuenta.Text.Trim.Length = 0 Then
                MsgBox("Debe seleccionar la cuenta contable.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
               
                Exit Sub
            End If

            If Me.numAcreditar.Value = 0 And numDebitar.Value = 0 Then
                MsgBox("Indique el monto a debitar y/o acreditar.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If


            Dim filas As DataRow
            filas = dtCuentasA.NewRow
            filas("SContContablesID") = CuentaID
            filas("IDCuenta") = NumCuenta
            filas("Descripcion") = txtCuenta.Text
            filas("MontoAcreditar") = numAcreditar.Value
            filas("MontoDebitar") = numDebitar.Value
            dtCuentasA.Rows.Add(filas)
            txtCuenta.Text = String.Empty
            CuentaID = 0
            numAcreditar.Value = 0
            numDebitar.Value = 0

            calcularTotales()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub calcularTotales()
        Try
            For Each dr As DataRow In dtCuentasA.Rows
                numCreditoT.Value = numCreditoT.Value + Decimal.Parse(dr("MontoAcreditar").ToString)
                numDebitoT.Value = numDebitoT.Value + Decimal.Parse(dr("MontoDebitar").ToString)

            Next
            numTotal.Value = numCreditoT.Value - numDebitoT.Value
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

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dtCuentasA.Rows.Remove(drFilaGradosE)
            Next

            calcularTotales()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarTipoAsiento()
        Try
            DtTipoAsiento = New DataTable
            DtTipoAsiento = ClsCatalogos.ObtenerValCat("TIPOASIENTO")
            With cmbTipoasiento
                .DataSource = DtTipoAsiento
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

    Public Sub CargarCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContContablesID = '" & CuentaID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContContablesID, IDCuenta, Descripcion", "SContSubSubCuentasContables", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 2
            objSeleccion.Centro = cmbCentroCosto.SelectedValue
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CuentaID = objSeleccion.Seleccion
                CargarCuenta()
                Me.txtCuenta.Text = dtCuentasDatos.Rows(0)("Descripcion")
                NumCuenta = dtCuentasDatos.Rows(0)("IDCuenta")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class