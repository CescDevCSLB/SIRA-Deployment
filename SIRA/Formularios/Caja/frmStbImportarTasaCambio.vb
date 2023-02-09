Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Imports DevExpress.XtraGrid
Imports Proyecto.Configuracion
Imports SIRA.BO
Imports SIRA.BO.clsConsultas
Imports DAL

Public Class frmStbImportarTasaCambio
    Dim objTasaCambio As StbTasaCambioOficial

#Region "Procedimientos"

    Private Sub importarExcel(ByVal tabla As GridControl)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Excel Files|*.xls;*.xlsx"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            conn = New OleDbConnection(
                             "Provider=Microsoft.ACE.OLEDB.12.0;" &
                             "data source=" & ExcelFile & "; " &
                            "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT * FROM [Sheet$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                clsError.CaptarError(ex)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub Guardar()
        Dim dtfecha As Date
        Dim mes, anio, moneda, EstadoConfirmado, dia As Integer
        Dim myFormat = "dd MMM yy HH:mm"
        Dim dtMoneda, dtTemp As New DataTable
        Dim strSQL As String
        Dim T As New DAL.TransactionManager
        Try
            objTasaCambio = New StbTasaCambioOficial
            '-- Obtener ID de la moneda de la Tasa de Cambio           
            strSQL = clsConsultas.ObtenerCatalogoValor(" StbValorCatalogoID ", " Nombre= 'MONEDA' AND Codigo='USD' ")
            dtMoneda = SqlHelper.ExecuteQueryDT(strSQL)
            If dtMoneda.Rows.Count > 0 Then
                moneda = dtMoneda.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de la Tasa de Cambio CONFIRMADO           
            strSQL = clsConsultas.ObtenerCatalogoValor(" StbValorCatalogoID ", " Nombre= 'EstadoTasaCambio' AND Codigo='CONFIRMADO' ")
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoConfirmado = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            T.BeginTran()
            For i As Integer = 0 To grdAsignacionTable.DataRowCount - 1
                dtfecha = Format(CDate(grdAsignacionTable.GetRowCellValue(i, "Fecha").ToString), myFormat)
                mes = dtfecha.Month
                anio = dtfecha.Year
                dia = dtfecha.Day

                If Not objTasaCambio.RetrieveByFilter("Mes = " & mes & " AND Dia= " & dia & " AND Anio = " & anio & " AND objMonedaID = " & moneda, T) Then
                    objTasaCambio.Mes = mes
                    objTasaCambio.Anio = anio
                    objTasaCambio.Dia = dia
                    objTasaCambio.Fecha = dtfecha
                    objTasaCambio.Monto = Decimal.Parse(grdAsignacionTable.GetRowCellValue(i, "Tasa").ToString)
                    objTasaCambio.objMonedaID = moneda
                    objTasaCambio.objEstadoID = EstadoConfirmado
                    objTasaCambio.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objTasaCambio.Insert(T)
                End If
            Next i
            T.CommitTran()
            'MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            dtMoneda = Nothing
            dtTemp = Nothing
        End Try
    End Sub
#End Region

#Region "Eventos"

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        importarExcel(grdImportar)
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Guardar()

    End Sub
#End Region

End Class