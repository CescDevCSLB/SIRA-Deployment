Imports DAL
Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Windows.Forms.Cursors
Imports Proyecto.Catalogos.Datos

Public Class frmSccConsultarDetalleArqueo

#Region "Declaracion de Variables"

    Public dpFecha As DateTime
    Public intArqueoID, intTypeGui As Integer
    Public intCajaID As Integer
    Dim dtDetallaRecibos As DataTable

#End Region

#Region "Propiedades"

    Property PdtDetallaRecibos() As DataTable
        Get
            Return dtDetallaRecibos
        End Get
        Set(ByVal value As DataTable)
            dtDetallaRecibos = value
        End Set
    End Property

    Property Fecha() As DateTime
        Get
            Return dpFecha
        End Get
        Set(ByVal value As DateTime)
            dpFecha = value
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

    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property CajaID() As Integer
        Get
            Return intArqueoID
        End Get
        Set(ByVal value As Integer)
            intArqueoID = value
        End Set
    End Property

#End Region

#Region "Procedimientos del formulario"

    '' Descripción:        Procedimiento encargado de configurar la interfaz del formulario
    Public Sub ConfigurarGUI()
        Try
            If TypeGui = 0 Then
                dtDetallaRecibos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("NumeroRecibo, Alumno, objCajaID, TipoPago, TotalRecibido, Moneda, Concepto, Fecha", "vwArqueoDetalle", "convert(varchar(10),Fecha,112) =" & Fecha.ToString("yyyyMMdd")))
            Else
                dtDetallaRecibos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("NumeroRecibo, Alumno, objCajaID, TipoPago, TotalRecibido, Moneda, Concepto, Fecha", "vwArqueoDetalleFinal", "objArqueoID =" & ArqueoID))
            End If
          grdDetalle.DataSource = dtDetallaRecibos

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSccConsultarArqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()
    End Sub
   
#End Region

    

   
End Class