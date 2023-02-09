Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports AForge.Video.DirectShow

Public Class frmSraCapturarFoto

    Private Dispositivos As FilterInfoCollection
    Private FuenteDeVideo As VideoCaptureDevice
    Dim img_Imagen As Bitmap

    Property imgFoto() As Bitmap
        Get
            Return img_Imagen
        End Get
        Set(ByVal value As Bitmap)
            img_Imagen = value
        End Set
    End Property

#Region "Eventos del formulario"


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

   


#End Region


    Private Sub frmSraCapturarFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dispositivos = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            For Each x As FilterInfo In Dispositivos
                cmbDispositivos.Items.Add(x.Name)
            Next
            cmbDispositivos.SelectedIndex = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdIniciar_Click(sender As Object, e As EventArgs) Handles cmdIniciar.Click
        Try
            'Dim WebcamForm As New AForge.Video.DirectShow.VideoCaptureDeviceForm
            'WebcamForm.ShowDialog()
            'Dim WebCam As New AForge.Video.DirectShow.VideoCaptureDevice(WebcamForm.VideoDeviceMoniker)
            'WebCam.Start()
            'Me.VideoSourcePlayer1.VideoSource = WebCam
            'VideoSourcePlayer1.Start()

            FuenteDeVideo = New VideoCaptureDevice(Dispositivos(cmbDispositivos.SelectedIndex).MonikerString)
            FuenteDeVideo.VideoResolution = FuenteDeVideo.VideoCapabilities(cmbDispositivos.SelectedIndex)
            VideoSourcePlayer1.VideoSource = FuenteDeVideo
            VideoSourcePlayer1.Start()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdDetener_Click(sender As Object, e As EventArgs) Handles cmdDetener.Click
        Try
            VideoSourcePlayer1.SignalToStop()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdFoto_Click(sender As Object, e As EventArgs) Handles cmdFoto.Click
        Try
            Dim img As Bitmap = VideoSourcePlayer1.GetCurrentVideoFrame()
            imgFoto = img

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        VideoSourcePlayer1.Stop()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class