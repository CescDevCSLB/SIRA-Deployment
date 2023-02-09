Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos


Public Class frmSccCuentasEmpleadosEditar

#Region "Variables del formulario"
    Public DtPersona, dtCuentasDatos, dtMensualidades, dtPeriodo, dtMeses As DataTable
    Public intTypeGUI, idpersona, intCuentaContableID, intEstadoRegistrado, intmonedacor, intContraCuentaContableID, intEstadoMesPagado, idEmpleado As Integer
    Public strCuentaID, strPersonaID, strCuentaContableID, strEmpleadoID, strContraCuentaContableID As String
    Dim foundRows() As DataRow
#End Region

#Region "Propiedades"

    Public Property CuentaID() As String
        Get
            Return strCuentaID
        End Get
        Set(ByVal value As String)
            strCuentaID = value
        End Set
    End Property

    Public Property TypeGUI() As Integer
        Get
            Return intTypeGUI
        End Get
        Set(ByVal value As Integer)
            intTypeGUI = value
        End Set
    End Property

    Public Property PersonaID() As String
        Get
            Return strPersonaID
        End Get
        Set(ByVal value As String)
            strPersonaID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & intCuentaContableID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))

            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtCuentaContable.Text = dtCuentasDatos.Rows(0)("Descripcion")
                strCuentaContableID = dtCuentasDatos.Rows(0)("IDCuenta").ToString
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub CargarMeses()
        Try
            dtMeses = New DataTable
            dtMeses = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbMesID, NumMes, Mes", "StbMeses", "1=1"))
            With cmbMes
                .DataSource = dtMeses
                .ValueMember = "NumMes"
                .DisplayMember = "Mes"
                .Splits(0).DisplayColumns("NumMes").Visible = False
                .Splits(0).DisplayColumns("StbMesID").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarInformacionEmpleado()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersona & "'"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbEmpleadoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion", "vwStbEmpleados", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ConsultarEmpleado()
        Dim objPersonas As frmStbEmpleadosEditar
        Try
            objPersonas = New frmStbEmpleadosEditar
            objPersonas.TyGui = 3
            objPersonas.idpersona = strPersonaID
            objPersonas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try
    End Sub

    Public Sub VincularControles()
        Try
            strPersonaID = IIf(IsDBNull(DtPersona.Rows(0)("StbPersonaID")), 0, DtPersona.Rows(0)("StbPersonaID"))
            strEmpleadoID = IIf(IsDBNull(DtPersona.Rows(0)("StbEmpleadoID")), 0, DtPersona.Rows(0)("StbEmpleadoID"))
            Me.txtNombreCompleto.Text = IIf(IsDBNull(DtPersona.Rows(0)("NombreCompleto")), String.Empty, DtPersona.Rows(0)("NombreCompleto"))
            Me.txtDireccionEmpleado.Text = IIf(IsDBNull(DtPersona.Rows(0)("Direccion")), String.Empty, DtPersona.Rows(0)("Direccion"))
            Me.txtIdentificacion.Text = IIf(IsDBNull(DtPersona.Rows(0)("Cedula")), String.Empty, DtPersona.Rows(0)("Cedula"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub GuardarPrestamo()
        Dim objPrestamo, objPrestamoUP As SccCuentaPorCobrarEmpleados
        Dim T As New DAL.TransactionManager
        Try
            If Me.txtNombreCompleto.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtNombreCompleto, My.Resources.MsgObligatorio)
                Exit Sub
            End If
            If Me.numMontoPrestamo.Value = 0 Then
                ErrPrv.SetError(numMontoPrestamo, My.Resources.MsgObligatorio)
                Exit Sub
            End If
            If Me.numCuotaMensual.Value = 0 Then
                ErrPrv.SetError(numCuotaMensual, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If Me.numPlazo.Value = 0 Then
                ErrPrv.SetError(numPlazo, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If Me.cmbMes.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbMes, My.Resources.MsgObligatorio)
                Exit Sub
            End If
            If Me.cmbPeriodos.Text.Trim.Length = 0 Then
                ErrPrv.SetError(cmbPeriodos, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If Me.txtCuenta.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            If Me.txtContraCuenta.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtContraCuenta, My.Resources.MsgObligatorio)
                Exit Sub
            End If

            objPrestamo = New SccCuentaPorCobrarEmpleados
            objPrestamoUP = New SccCuentaPorCobrarEmpleados
            T.BeginTran()

            objPrestamo.Retrieve(CuentaID, T)
            objPrestamo.objEmpleadoID = strEmpleadoID
            objPrestamo.objEstadoID = intEstadoRegistrado
            objPrestamo.Plazo = numPlazo.Value
            objPrestamo.PagoMensual = numCuotaMensual.Value
            objPrestamo.SaldoInicial = numMontoPrestamo.Value
            objPrestamo.Saldo = numMontoPrestamo.Value
            objPrestamo.objMonedaPagoMensualidadID = intmonedacor
            objPrestamo.Activa = 1
            objPrestamo.MesInicio = cmbMes.SelectedValue
            objPrestamo.AnioInicio = CInt(cmbPeriodos.Text)
            objPrestamo.objCuentaContableID = intCuentaContableID
            objPrestamo.objContraCuentaID = intContraCuentaContableID

            objPrestamo.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPrestamo.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objPrestamo.Update(T)

            GenerarPagos(T)

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GenerarPagos(t As TransactionManager)
        Dim parametro(1) As SqlClient.SqlParameter

        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Try

            parametro(0) = New SqlClient.SqlParameter("@IntCuentaID ", SqlDbType.Int, 4)
            parametro(0).Value = CuentaID

            parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(1).Value = clsProyecto.Conexion.Usuario

            SqlHelper.ExecuteNonQuery(t.Transaction, CommandType.StoredProcedure, "SP_GenerarSaldosPrestamoInicial", parametro)

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub

    Public Sub CargarContraCuenta()
        Try
            Dim strFiltro As String = ""
            strFiltro = "SContCuentasContablesID = '" & intContraCuentaContableID & "'"

            dtCuentasDatos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SContCuentasContablesID, IDCuenta, Descripcion", "SContCuentasContables", strFiltro))

            If dtCuentasDatos.Rows.Count > 0 Then
                Me.txtContraCuenta.Text = dtCuentasDatos.Rows(0)("Descripcion")
                strContraCuentaContableID = dtCuentasDatos.Rows(0)("IDCuenta").ToString
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCuentaContable.TextChanged

        ErrPrv.Clear()
    End Sub

    Private Sub numPlazo_TextChanged(sender As Object, e As EventArgs) Handles numPlazo.TextChanged
        ErrPrv.Clear()
        CalcularCuota()
    End Sub

    Private Sub cmbMes_TextChanged(sender As Object, e As EventArgs) Handles cmbMes.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmbPeriodos_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodos.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub numMontoPrestamo_TextChanged(sender As Object, e As EventArgs) Handles numMontoPrestamo.TextChanged
        ErrPrv.Clear()
        CalcularCuota()
    End Sub

    Private Sub numCuotaMensual_TextChanged(sender As Object, e As EventArgs) Handles numCuotaMensual.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub txtNombreCompleto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCompleto.TextChanged
        ErrPrv.Clear()
    End Sub

    Private Sub cmdBuscarCuenta_Click(sender As Object, e As EventArgs) Handles cmdBuscarCuenta.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 2
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                intCuentaContableID = objSeleccion.Seleccion
                CargarCuenta()
                ErrPrv.Clear()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        GuardarPrestamo()
    End Sub

    Private Sub cmdContraCuenta_Click(sender As Object, e As EventArgs) Handles cmdContraCuenta.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmScontCuentaSelector
            objSeleccion = New frmScontCuentaSelector
            objSeleccion.Opcion = 2
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                intContraCuentaContableID = objSeleccion.Seleccion
                CargarContraCuenta()
                ErrPrv.Clear()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



    Private Sub CalcularCuota()
        Try
            If numPlazo.EditValue <> 0 Then
                numCuotaMensual.Value = numMontoPrestamo.Value / numPlazo.EditValue
            Else
                numCuotaMensual.Value = 0
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub ConfigurarGUI()


        intEstadoRegistrado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "00")
        intmonedacor = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "COR")
        intEstadoMesPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "02")

        Select Case TypeGUI

            Case 1
                Me.Text = "Editar prestamo"
                CargarDatosEdicion()

            Case 2
                Me.Text = "Consultar prestamo"
                CargarDatosEdicion()
                numPlazo.Enabled = False
                cmbMes.Enabled = False
                cmbPeriodos.Enabled = False
                numMontoPrestamo.Enabled = False
                numCuotaMensual.Enabled = False
        End Select

    End Sub


    Public Sub CargarPeriodos()
        Try
            dtPeriodo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodos.ValueMember = "PeriodoID"
            cmbPeriodos.DisplayMember = "Periodo"
            cmbPeriodos.DataSource = dtPeriodo

            cmbPeriodos.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodos.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodos.ColumnHeaders = False
            cmbPeriodos.ExtendRightColumn = True
            cmbPeriodos.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarDatosEdicion()
        Dim dtMesesPagados As New DataTable
        Dim objSccCuenta As SccCuentaPorCobrarEmpleados
        Try

            objSccCuenta = New SccCuentaPorCobrarEmpleados

            objSccCuenta.Retrieve(CuentaID)
            Me.txtCuenta.Text = objSccCuenta.Numero
            Me.numSaldoInicial.Value = objSccCuenta.SaldoInicial
            Me.numSaldo.Value = objSccCuenta.Saldo
            Me.txtEstado.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
            Me.numPlazo.Value = objSccCuenta.Plazo
            Me.cmbMes.SelectedValue = objSccCuenta.MesInicio
            cmbPeriodos.Text = objSccCuenta.AnioInicio
            Me.numMontoPrestamo.Value = objSccCuenta.SaldoInicial
            strEmpleadoID = objSccCuenta.objEmpleadoID
            intCuentaContableID = objSccCuenta.objCuentaContableID
            intContraCuentaContableID = objSccCuenta.objContraCuentaID
            CargarCuenta()
            CargarContraCuenta()
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbEmpleadoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion", "vwStbEmpleados", "StbEmpleadoID =" & strEmpleadoID))
            VincularControles()

            ''Buscar meses pagados
            dtMesesPagados = SccCuentaPorCobrarDetalleEmpleados.RetrieveDT("objSccCuentaPorCobrarID =" & CuentaID & " AND objEstadoID=" & intEstadoMesPagado)
            numMesPagado.Value = dtMesesPagados.Rows.Count
            numMesAtrasado.Value = objSccCuenta.Plazo - dtMesesPagados.Rows.Count

            ''Cargar detalle de las mensualidades
            CargarDetalleMeses()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub




    Private Sub cmdConsultarEmpleado_Click(sender As Object, e As EventArgs) Handles cmdConsultarEmpleado.Click
        If txtNombreCompleto.Text.Trim.Length <> 0 Then
            ConsultarEmpleado()
        End If

    End Sub

#End Region


#Region "Eventos del formulario"

    Private Sub frmSccCuentasEditar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.ToolTip.Hide(Me.lblinfo)
    End Sub
    Private Sub frmSccCuentasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarMeses()
            CargarPeriodos()
            ConfigurarGUI()

            Me.grdFacturas.Splits(0).FilterBar = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub dtpFechaCredito_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.Clear()
    End Sub



#End Region

#Region "Carga de Meses"
    Private Sub CargarDetalleMeses()

        Try

            dtMensualidades = New DataTable
            dtMensualidades = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objSccCuentaPorCobrarID, SccCuentaPorCobrarDetalleID, Mes, MontoInicial, MontoPagado, Saldo, Estado,FechaVencimiento", "vwSraCuentasMesesEmpleados", " objSccCuentaPorCobrarID='" & Me.CuentaID & "' ORDER BY SccCuentaPorCobrarDetalleID"))
            Me.grdFacturas.SetDataBinding(dtMensualidades, "", True)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

    Private Function CargarEstados(ByVal IdEstado As Integer) As String
        Dim Valor As String = ""
        Try
            Valor = SqlHelper.ExecuteQueryDT("SELECT dbo.FnGetValorCatalogoID('ESTADOCUENTA'," + IdEstado.ToString + ",1) as Estado").DefaultView.Item(0)("Estado")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return Valor
    End Function

    Private Sub Consultar()
        Dim objPersonas As frmStbAlumnosEdit
        Try
            objPersonas = New frmStbAlumnosEdit
            objPersonas.TyGui = 3
            objPersonas.idpersona = strPersonaID
            objPersonas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try
    End Sub

    Private Sub cmdConsultarCliente_Click(sender As Object, e As EventArgs) Handles cmdConsultarCliente.Click
        Consultar()
    End Sub
End Class