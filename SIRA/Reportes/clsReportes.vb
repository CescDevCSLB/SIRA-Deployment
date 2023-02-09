'-- Clase para procedimientos y funciones globales usadas en reportes


Imports DataDynamics.ActiveReports

Public Class clsReportes

#Region "Enmarcar"
    ''' Procedimiento para crear borde en los cuatro lados de una etiqueta de active Report
    ''' <param name="etiqueta">Etiqueta (Label) de Active report que desea enmarcar</param>
    Public Overloads Shared Sub Enmarcar(ByRef etiqueta As DataDynamics.ActiveReports.Label)
        Enmarcar(etiqueta, Nothing)
    End Sub

    ''' Procedimiento para crear borde en los cuatro lados de una etiqueta de active Report
    Public Overloads Shared Sub Enmarcar(ByRef etiqueta As DataDynamics.ActiveReports.Label, ByVal Color As System.Drawing.Color)
        With etiqueta.Border
            .TopStyle = BorderLineStyle.Solid
            .BottomStyle = BorderLineStyle.Solid
            .LeftStyle = BorderLineStyle.Solid
            .RightStyle = BorderLineStyle.Solid
        End With
        If Not Color = Nothing Then
            etiqueta.Border.Color = Color
        End If
    End Sub


    ''' Procedimiento para crear borde en los cuatro lados de un textbox de ActiveReport

    '
    Public Overloads Shared Sub Enmarcar(ByRef Textbox As DataDynamics.ActiveReports.TextBox)
        Enmarcar(Textbox, Nothing)
    End Sub


    ''' Procedimiento para crear borde en los cuatro lados de un textbox de ActiveReport

    Public Overloads Shared Sub Enmarcar(ByRef Textbox As DataDynamics.ActiveReports.TextBox, ByVal color As System.Drawing.Color)
        With Textbox.Border
            .TopStyle = BorderLineStyle.Solid
            .BottomStyle = BorderLineStyle.Solid
            .LeftStyle = BorderLineStyle.Solid
            .RightStyle = BorderLineStyle.Solid
        End With
        If Not color = Nothing Then
            Textbox.Border.Color = color
        End If
    End Sub
#End Region

#Region "Borde Superior"

    ''' Procedimiento para crear borde en la parte superior de un textbox de ActiveReport
    Public Overloads Shared Sub BordeSuperior(ByRef Textbox As DataDynamics.ActiveReports.TextBox)
        BordeSuperior(Textbox, Nothing)
    End Sub


    ''' Procedimiento para crear borde en la parte superior de un textbox de ActiveReport
    Public Overloads Shared Sub BordeSuperior(ByRef Textbox As DataDynamics.ActiveReports.TextBox, ByVal color As System.Drawing.Color)
        With Textbox
            .Border.TopStyle = BorderLineStyle.Solid
            If color <> Nothing Then
                .Border.Color = color
            End If
        End With
    End Sub
#End Region

End Class
