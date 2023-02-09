Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmScontCuentaSelector

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion, intCentro As Integer
    Public dtCuentas As DataTable
#End Region

#Region "Propiedades"
    Public Property Filtro() As String
        Get
            Return strFiltro
        End Get
        Set(ByVal value As String)
            strFiltro = value
        End Set
    End Property

    Public Property Seleccion() As String
        Get
            Return strSeleccion
        End Get
        Set(ByVal value As String)
            strSeleccion = value
        End Set
    End Property
    Public Property Centro() As Integer
        Get
            Return intCentro
        End Get
        Set(ByVal value As Integer)
            intCentro = value
        End Set
    End Property


    Public Property Opcion() As Integer
        Get
            Return intOpcion
        End Get
        Set(ByVal value As Integer)
            intOpcion = value
        End Set
    End Property
#End Region

#Region "Procedimientos"

    Public Sub CargarCuentasContables()
        Try
            Dim strFiltro As String = ""
            Select Case Opcion
                Case 1
                    strFiltro = "Activo =1 AND TieneAuxilar=1"
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContables", strFiltro))

                Case 2
                    strFiltro = "Activo =1 AND TieneAuxilar=0"
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContables", strFiltro))

                Case 3
                    strFiltro = "Activo =1 AND Nivel='4' and RecibeMovimiento=1 "
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContables", strFiltro))
                Case 4
                    strFiltro = "Activo =1 AND Nivel='4' AND RecibeMovimiento=1 and objSconCentroCostoID = " & Centro
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContablescentro", strFiltro))
                Case 5
                    strFiltro = "Activo =1"
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContables", strFiltro))
                Case 6
                    strFiltro = "Activo =1 AND  Nivel='4'"
                    dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Nivel, Activo", "vwSContCuentasContables", strFiltro))

            End Select


            Me.grdCuentas.DataSource = dtCuentas
            Me.grdCuentas.Text = "Cuentas (" & dtCuentas.Rows.Count & ")"
            Me.grdCuentas.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim objClienteID As New Object
        Dim Cantidad As New Object

        Cantidad = Me.dtCuentas.Compute("Count(Seleccionar)", "Seleccionar=1")
        If Cantidad = 0 Then
            Exit Sub
        End If
        objClienteID = Me.dtCuentas.Select("Seleccionar = 1")(0)("SContCuentasContablesID")
        If Not IsDBNull(objClienteID) Then
            Seleccion = objClienteID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CargarCuentasContables()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
#End Region

    Private Sub chkSeleccionado_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionado.CheckedChanged
        Try
            Dim blnSeleccionar As Boolean
            Dim Filas() As DataRow = Nothing

            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            If blnSeleccionar Then
                Filas = dtCuentas.Select("Seleccionar=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccionar") = 0
                    dtCuentas.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class