Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI

Public Class frmSraTipoReporteProfesor


#Region "Eventos del formulario"

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim ds As DataSet
        Try
            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, StbProfesorID, Cedula, NombreCompleto, FechaIngreso, Direccion, CodigoGrado, Grado, CodigoAsignarura, Asignatura", "vwRptProfesoresGradosAsignaturas", ))

            If rbasignaturas.Checked Then
                Dim objjReporte As New rptProfesoresAsignaturas()
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                If rbGrados.Checked Then
                    Dim objjReporte As New rptProfesores()
                    If ds.Tables(0).Rows.Count <> 0 Then
                        objjReporte.DataSource = ds
                        objjReporte.DataMember = ds.Tables(0).TableName
                        Dim pt As New ReportPrintTool(objjReporte)
                        pt.ShowPreview()
                    Else
                        MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub



#End Region


End Class