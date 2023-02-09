Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccConsultarArqueoCH

#Region "Declaracion de Variables"

    Public intTypeGui As Integer
    Public intArqueoID As Integer
    Dim dtCajeros, dtDetalle As DataTable
    Dim dtDetalleAbonos, dtDetallaFacturas, dtDetalleComisiones, deDetalleSalidas, deRecibosEfectivo, deDetalleIngreso As DataTable

#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property ArqueoID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    Public Sub CargarInformacionArqueoInicial()
        Dim dblIngreso, dblSalida As Decimal
        Try

            dblIngreso = 0
            dblSalida = 0

            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("ISNULL(SUM(Entrada),0) as Entrada, ISNULL(SUM(Salida),0) as Salida, Moneda, Concepto, convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidadoCH", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY Moneda,Concepto,convert(varchar(10),Fecha,103)"))

            grdDetalle.DataSource = dtDetalle

            For Each drw As DataRow In Me.dtDetalle.Rows
                dblIngreso = dblIngreso + drw("Entrada")
                dblSalida = dblSalida + drw("Salida")
            Next

            spnIngreso.Value = dblIngreso
            spnEgreso.Value = dblSalida

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Public Sub CargarCajeros()
        Try
            Try
                dtCajeros = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("StbEmpleadoID,NombreCompleto,StbPersonaID", "vwStbEmpleados", "CodigoCargo= '03' AND Activo =1"))

                cmbCajero.DataSource = dtCajeros
                cmbCajero.ValueMember = "StbEmpleadoID"
                cmbCajero.DisplayMember = "NombreCompleto"
                cmbCajero.Splits(0).DisplayColumns("StbEmpleadoID").Visible = False
                cmbCajero.Splits(0).DisplayColumns("StbPersonaID").Visible = False
                cmbCajero.ColumnHeaders = False
                cmbCajero.ExtendRightColumn = True
                cmbCajero.SelectedIndex = -1
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Dim objCajero As New SccCajaChica
        Try
            CargarCajeros()

            Select Case TypeGui
                Case 0
                    Me.dtFecha.DateTime = clsProyecto.Conexion.FechaServidor
                    Me.Text = "Visualizar arqueo"
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    chkCerrado.Enabled = False
                    Me.cmbCajero.Enabled = False
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCajaChica

                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCajaChica & "'")

                    If Not IsNothing(objCajero.objCajeraID) Then
                        cmbCajero.SelectedValue = objCajero.objCajeraID
                    End If
                    spnDisponible.Value = objCajero.Disponible

                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 1
                    Me.Text = "Aprobar arqueo"
                    Me.dtFecha.DateTime = clsProyecto.Conexion.FechaServidor
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCajaChica
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCajaChica & "'")
                    chkCerrado.Enabled = False
                    chkCerrado.Checked = True
                    If Not IsNothing(objCajero.objCajeraID) Then
                        cmbCajero.SelectedValue = objCajero.objCajeraID
                    End If
                    spnDisponible.Value = objCajero.Disponible

                    txtAprobadoPor.Enabled = True
                    spnFaltante.Enabled = True
                    CargarInformacionArqueoInicial()
                    '' Me.cmbCajas.SelectedValue = ClsCatalogos.GetStbCajaID(frmPrincipal.gblCaja)
                Case 2
                    Me.Text = "Consultar Caja"
                    lblCaja.Text = "Caja: " & frmPrincipal.gblCajaChica
                    objCajero.RetrieveByFilter("Codigo='" & frmPrincipal.gblCajaChica & "'")
                    CargarDatosArqueo()
                    cmdAprobar.Visible = False
                    spnFaltante.Enabled = False
                    txtAprobadoPor.Enabled = False
                    cmbCajero.Enabled = False
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de una Caja
    Public Sub CargarDatosArqueo()
        Dim objArqueo As SccArqueoCajaCH
        Dim objcaja As SccCajaChica
        Dim objCajero As New SccCajas

        Try
            objArqueo = New SccArqueoCajaCH
            objcaja = New SccCajaChica

            objArqueo.Retrieve(ArqueoID)
            txtAprobadoPor.Text = objArqueo.AprobadoPor
            chkCerrado.Checked = objArqueo.Cerrado
            spnIngreso.Value = objArqueo.Entrada
            spnEgreso.Value = objArqueo.Salida

            If Not IsNothing(objArqueo.objCajeroID) Then
                cmbCajero.SelectedValue = objArqueo.objCajeroID
            End If

            dtFecha.DateTime = objArqueo.Fecha
            spnFaltante.Value = objArqueo.Faltante
            chkCerrado.Checked = objArqueo.Cerrado

            If Not IsNothing(objArqueo.objCajaID) Then
                objcaja.Retrieve(objArqueo.objCajaID)
                lblCaja.Text = "Caja: " & objcaja.Codigo
            Else
                lblCaja.Text = "Caja: Migracion "
            End If

           
            dtDetalle = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Concepto, SUM(Entrada) as Entrada, SUM(Salida) as Salida,Moneda,  convert(varchar(10),Fecha,103) AS Fecha", "vwArqueoConsolidadoFinalCH", "convert(varchar(10),Fecha,112) =" & dtFecha.DateTime.ToString("yyyyMMdd") & "  GROUP BY Concepto, Moneda, convert(varchar(10),Fecha,103)"))
            grdDetalle.DataSource = dtDetalle

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    '' Descripción:        Procedimie   nto encargado de crear un nuevo arqueo
    Public Sub GuardarArqueo()
        Dim objArqueo As SccArqueoCajaCH

        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            objArqueo = New SccArqueoCajaCH

            objArqueo.Fecha = dtFecha.DateTime
            objArqueo.Entrada = spnIngreso.Value
            objArqueo.Salida = spnEgreso.Value
            objArqueo.Faltante = spnFaltante.Value
            objArqueo.AprobadoPor = txtAprobadoPor.Text
            objArqueo.objCajaID = ClsCatalogos.GetStbCajaCHID(frmPrincipal.gblCajaChica)
            objArqueo.objCajeroID = cmbCajero.SelectedValue
            objArqueo.Cerrado = chkCerrado.Checked
            objArqueo.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objArqueo.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objArqueo.Insert(T)
            ArqueoID = objArqueo.ArqueoCHID

            Dim objArqueoDetalle As New SccArqueoCajaDetalleCH
            If Not IsNothing(dtDetalle) Then
                For Each DrwDetalle As DataRow In Me.dtDetalle.Rows
                    objArqueoDetalle.objArqueoCHID = ArqueoID
                    objArqueoDetalle.Moneda = DrwDetalle("Moneda")
                    objArqueoDetalle.Concepto = DrwDetalle("Concepto")
                    objArqueoDetalle.Entrada = DrwDetalle("Entrada")
                    objArqueoDetalle.Salida = DrwDetalle("Salida")
                    objArqueoDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objArqueoDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objArqueoDetalle.Insert(T)
                Next
            End If

            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objArqueo = Nothing
        End Try
    End Sub

    Private Function ValidarDatos() As Boolean
        Try
            If Me.cmbCajero.Text = String.Empty Or IsNothing(cmbCajero.SelectedValue) Then
                Me.ErrorProv.SetError(Me.cmbCajero, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.txtAprobadoPor.Text = String.Empty Then
                Me.ErrorProv.SetError(Me.txtAprobadoPor, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Eventos del formulario"
    Private Sub frmSccConsultarArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub

    Private Sub cmdAprobar_Click(sender As Object, e As EventArgs) Handles cmdAprobar.Click
        If Me.ValidarDatos Then
            GuardarArqueo()
        End If
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub txtAprobadoPor_TextChanged(sender As Object, e As EventArgs) Handles txtAprobadoPor.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbCajero_TextChanged(sender As Object, e As EventArgs)
        Me.ErrorProv.Clear()
    End Sub
#End Region

End Class