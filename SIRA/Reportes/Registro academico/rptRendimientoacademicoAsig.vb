Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports Proyecto.Configuracion
Imports System.Drawing.Font
Imports System.Windows.Forms.VisualStyles
Imports System.Web.UI.WebControls

Public Class rptRendimientoacademicoAsig

    Private control As GridControl
    Public view As New DevExpress.XtraGrid.Views.Grid.GridView

    Public Property GridControl As GridControl
        Get
            Return control
        End Get
        Set(ByVal value As GridControl)
            control = value
            PrintableComponentContainer1.PrintableComponent = control
            view = New DevExpress.XtraGrid.Views.Grid.GridView
        End Set
    End Property

    Private Sub ReportHeaderBand1_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeaderBand1.BeforePrint

        Try

            view = GridControl.MainView
            view.OptionsView.ColumnAutoWidth = False

            If view.Columns.Count > 0 Then
                For Each columna As GridColumn In view.Columns
                    Dim indice As Integer = CInt(view.Columns.IndexOf(columna))
                    columna.AppearanceHeader.Font = New Font("Arial", 7, FontStyle.Bold)
                    columna.AppearanceCell.Font = New Font("Arial", 7, FontStyle.Regular)

                    columna.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top


                    Select Case indice
                        Case 0
                            view.Columns(indice).Width = 150
                        Case 1
                            view.Columns(indice).Width = 250
                    End Select

                    If indice > 1 Then
                        view.Columns(indice).Width = 150
                    End If


                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


End Class