Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO
Imports System.Data
Imports Proyecto.Catalogos.Datos

''' <summary>
''' Formulario de Selección de Cuentas para Generacion de Recibos de Cajas.
''' </summary>
''' <remarks></remarks>
Public Class frmSccSeleccionCuentasEmpleados
    Dim DtDatosCuentas As New DataTable
    Dim m_SccCuentaID, strSeleccion As String
    Dim m_NumeroCuenta As String
    Dim m_Empleado As String
    Dim m_EmpleadoID, m_PeriodoID As Integer


#Region "Propiedades"

    Public Property Seleccion() As String
        Get
            Return strSeleccion
        End Get
        Set(ByVal value As String)
            strSeleccion = value
        End Set
    End Property
    Property SccCuentaID() As String
        Get
            SccCuentaID = m_SccCuentaID
        End Get
        Set(ByVal value As String)
            m_SccCuentaID = value
        End Set
    End Property

    Property PeriodoID() As String
        Get
            PeriodoID = m_PeriodoID
        End Get
        Set(ByVal value As String)
            m_PeriodoID = value
        End Set
    End Property


    Property AlumnoID() As String
        Get
            AlumnoID = m_EmpleadoID
        End Get
        Set(ByVal value As String)
            m_EmpleadoID = value
        End Set
    End Property

    Property NumeroCuenta() As String
        Get
            NumeroCuenta = m_NumeroCuenta
        End Get
        Set(ByVal value As String)
            m_NumeroCuenta = value
        End Set
    End Property


    Property Empleado() As String
        Get
            Empleado = m_Empleado
        End Get
        Set(ByVal value As String)
            m_Empleado = value
        End Set
    End Property
#End Region

#Region "Carga de Datos"
    ''' <summary>
    ''' Procedimiento de Carga Total de las cuentas en Estado Diferente a Cancelada.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Dim strConsulta As String = ""
        Try
            strConsulta = clsConsultas.ObtenerConsultaGeneral(" Cast(0 as Bit) as Seleccion,Numero, PagoMensual, Plazo, SccCuentaID, Llave, StbEmpleadoID, Empleado, Saldo, objEstadoID, Estado, Activa,Cedula", "vwSccCuentaEmpleado", "objEstadoID<> 21014 and Activa=1")
            Me.DtDatosCuentas = SqlHelper.ExecuteQueryDT(strConsulta)
            Me.grdSeleccion.DataSource = Me.DtDatosCuentas

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkSeleccionado_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionado.CheckedChanged
        Try
            Dim blnSeleccionar As Boolean
            Dim Filas() As DataRow = Nothing

            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            If blnSeleccionar Then
                Filas = DtDatosCuentas.Select("Seleccion=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccion") = 0
                    DtDatosCuentas.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub frmSccSeleccionCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
    End Sub


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Dim objCant As New Object
        Dim DtDatos(1) As DataRow
        Try
            objCant = Me.DtDatosCuentas.Compute("Count(Seleccion)", "Seleccion= 1")
            If objCant = 0 Then
                Me.DialogResult = Windows.Forms.DialogResult.None
            Else
                DtDatos = Me.DtDatosCuentas.Select("Seleccion=1")
                Me.AlumnoID = DtDatos(0)("StbEmpleadoID")

                If Not IsDBNull(DtDatos(0)("SccCuentaID")) Then
                    Me.SccCuentaID = DtDatos(0)("SccCuentaID")
                    Me.NumeroCuenta = DtDatos(0)("Numero")
                Else
                    Me.SccCuentaID = 0
                    Me.NumeroCuenta = String.Empty
                End If

                Me.Empleado = DtDatos(0)("Empleado")

                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class