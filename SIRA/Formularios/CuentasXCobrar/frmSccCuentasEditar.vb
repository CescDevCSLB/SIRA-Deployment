Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos


Public Class frmSccCuentasEditar

#Region "Variables del formulario"
    Public dtAlumno, dtBeca, dtMensualidades, dtPeriodo, dtGrado As DataTable
    Public intTypeGUI, intobjRutaID As Integer
    Public strCuentaID, FiltroCliente, strAlumnoID, strPersonaID As String
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
   
    Private Sub CargarBecas()
        Try
            dtBeca = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("BecaID,Descripcion", "SraBecas", "Activo=1"))
            Me.cmbBeca.DataSource = dtBeca
            Me.cmbBeca.DisplayMember = "Descripcion"
            Me.cmbBeca.ValueMember = "BecaID"
            Me.cmbBeca.Splits(0).DisplayColumns("BecaID").Visible = False
            Me.cmbBeca.ExtendRightColumn = True
            Me.cmbBeca.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub
    Public Sub VincularControles()
        Try
            strPersonaID = IIf(IsDBNull(dtAlumno.Rows(0)("StbPersonaID")), 0, dtAlumno.Rows(0)("StbPersonaID"))
            strAlumnoID = IIf(IsDBNull(dtAlumno.Rows(0)("AlumnoID")), 0, dtAlumno.Rows(0)("AlumnoID"))
            Me.txtNombre.Text = IIf(IsDBNull(dtAlumno.Rows(0)("NombreCompleto")), String.Empty, dtAlumno.Rows(0)("NombreCompleto"))
            Me.txtDireccion.Text = IIf(IsDBNull(dtAlumno.Rows(0)("Direccion")), String.Empty, dtAlumno.Rows(0)("Direccion"))
            Me.txtCedula.Text = IIf(IsDBNull(dtAlumno.Rows(0)("Grupo")), String.Empty, dtAlumno.Rows(0)("Grupo"))
            Me.cmbBeca.SelectedValue = IIf(IsDBNull(dtAlumno.Rows(0)("objBecaID")), String.Empty, dtAlumno.Rows(0)("objBecaID"))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Public Sub ConfigurarGUI()
        Select Case TypeGUI
           
            Case 2
                Me.Text = "Consulta de Expediente"
                CargarDatosEdicion()
                Call Me.CargarDetalleMeses()

                txtNombre.ReadOnly = True
                txtDireccion.ReadOnly = True
                txtCedula.ReadOnly = True
                Me.cmbGrado.ReadOnly = True
                Me.cmbPeriodos.ReadOnly = True
                Me.numMesAtrasado.ReadOnly = True
                Me.numMesPagado.ReadOnly = True

        End Select

    End Sub


    Private Sub CargarGrados()
        Try
            dtGrado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID,Grado", "SraGrado", "Activo=1"))
            Me.cmbGrado.DataSource = dtGrado
            Me.cmbGrado.DisplayMember = "Grado"
            Me.cmbGrado.ValueMember = "GradoID"
            Me.cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            Me.cmbGrado.ExtendRightColumn = True
            Me.cmbGrado.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
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
        Dim objSccCuenta As SccCuentaPorCobrar
        Try

            objSccCuenta = New SccCuentaPorCobrar

            objSccCuenta.Retrieve(CuentaID, )
            Me.txtCuenta.Text = objSccCuenta.Numero
            Me.cmbGrado.SelectedValue = objSccCuenta.objGradoID
            Me.cmbPeriodos.SelectedValue = objSccCuenta.objPeriodoID
            Me.numSaldoInicial.Value = objSccCuenta.SaldoInicial
            Me.numSaldo.Value = objSccCuenta.Saldo
            Me.txtEstado.Text = Me.CargarEstados(objSccCuenta.objEstadoID)
            strAlumnoID = objSccCuenta.objAlumnoID

            dtAlumno = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objPeriodoID, AlumnoID, NombreCompleto, Codigo, Grupo, SccCuentaID, NumCuenta, Porcentaje, StbPersonaID,Direccion,objBecaID", "vwSeleccionEstudianteCuenta", "AlumnoID=" & strAlumnoID))

            Call VincularControles()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region


#Region "Eventos del formulario"

    Private Sub frmSccCuentasEditar_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.ToolTip.Hide(Me.lblinfo)
    End Sub
    Private Sub frmSccCuentasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarGrados()
            CargarPeriodos()
            CargarBecas()
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
        Me.ErrorProv.Clear()
    End Sub



#End Region

#Region "Carga de Meses"
    Private Sub CargarDetalleMeses()

        Try

            dtMensualidades = New DataTable
            dtMensualidades = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objSccCuentaPorCobrarID, SccCuentaPorCobrarDetalleID, Mes, MontoInicial, MontoPagado, Saldo, Estado,FechaVencimiento", "vwSraCuentasMeses", " objSccCuentaPorCobrarID='" & Me.CuentaID & "' ORDER BY FechaVencimiento"))
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