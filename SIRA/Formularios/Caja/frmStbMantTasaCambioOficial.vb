
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports SIRA.BO
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos

Public Class frmStbMantTasaCambioOficial

#Region "Declaracion de Variables Locales y Objetos"
    Dim objSeg As SsgSeguridad
    Dim dtTCO As DataTable
    Dim TCOID As Integer
    Dim NumMes As Integer
    Dim MonedaID As Integer
    Dim Anio As Integer
    Dim EstadoTCO As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoConfirmado As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnRegistrarTCO As Boolean = False
    Dim blnConfirmarTCO As Boolean = False
    Dim blnImprimirTCO As Boolean = False
#End Region

#Region "Eventos del Formulario"

     Private Sub frmStbMantTasaCambioOficial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            AplicarSeguridad()
            clsProyecto.CargarTemaDefinido(Me)
            PropiedadesFormulario()
            CargarGrid()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Seguridad"

     Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmStbMantTasaCambioOficial"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If objSeg.TienePermiso("AgregarTasaCambio") Then
                blnRegistrarTCO = True
                Me.cmdAgregar.Enabled = True
                Me.cmdEditarTasa.Enabled = True
            Else
                blnRegistrarTCO = False
                Me.cmdAgregar.Enabled = False
                Me.cmdEditarTasa.Enabled = False
            End If
            If objSeg.TienePermiso("AutorizarTasaCambio") Then
                blnConfirmarTCO = True
            Else
                blnConfirmarTCO = False
            End If
           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try
            '-- Obtener ID del Estado de la Tasa de Cambio REGISTRADO
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoTasaCambio' AND Codigo='REGISTRADO' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de la Tasa de Cambio CONFIRMADO
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'EstadoTasaCambio' AND Codigo='CONFIRMADO' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoConfirmado = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Grid"

   Private Sub CargarGrid()
        Try
            strCampos = "StbTasaCambioOficialID,Fecha, Mes, Anio, Moneda, Monto,Estado"
            strOrden = " Moneda, Anio DESC, Mes DESC "
            strSQL = clsConsultas.ObtenerTasaCambioOficial(strCampos, , strOrden)
            dtTCO = SqlHelper.ExecuteQueryDT(strSQL)
            dtTCO.PrimaryKey = New DataColumn() {Me.dtTCO.Columns("StbTasaCambioOficialID")}
            dtTCO.DefaultView.Sort = "StbTasaCambioOficialID DESC"
            If dtTCO.Rows.Count > 0 Then
                Me.grdTasa.DataSource = dtTCO
            End If
            HabilitarToolbar()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

   '-----------------------------------------------------------------------------------
    Private Sub grdTCO_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs)
        Try
            If Me.grdTasaTabla.RowCount > 0 Then
                HabilitarToolbar()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub HabilitarToolbar()
        Try
           
            If Me.blnRegistrarTCO Then
                Me.cmdAgregar.Enabled = True
            Else
                Me.cmdAgregar.Enabled = False
            End If

            If Me.blnConfirmarTCO And Me.dtTCO.DefaultView.Count > 0 Then
                Me.cmdAutorizar.Enabled = True
            Else
                Me.cmdAutorizar.Enabled = False
            End If

            'If Me.blnImprimirTCO And Me.dtTCO.DefaultView.Count > 0 Then
            '    Me.cmdImprimir.Enabled = True
            'Else
            '    Me.cmdImprimir.Enabled = False
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Toolbar"

    Private Sub tsbRegistrarTCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Nuevo()
    End Sub
    Private Sub tsbConfirmarTCO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAutorizar.Click
        Dim objTasaCambio As New StbTasaCambioOficial
        Dim T As New TransactionManager
        Dim FilaActual As Integer
        Try
            If Me.blnConfirmarTCO And Me.dtTCO.Rows.Count > 0 Then
                Dim selectedRow As Integer() = grdTasaTabla.GetSelectedRows()
                FilaActual = Me.grdTasaTabla.GetDataSourceRowIndex(selectedRow(0))

                '-- Verificar si hay registros que Confirmar
                objTasaCambio.RetrieveByFilter("StbTasaCambioOficialID = " & Me.dtTCO.DefaultView.Item(FilaActual)("StbTasaCambioOficialID"))
                If objTasaCambio.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoTasaCambio", "REGISTRADO") Then
                    Select Case MsgBox("¿Desea confirmar las tasas de cambio registradas?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            T.BeginTran()
                            objTasaCambio.objEstadoID = Me.EstadoConfirmado
                            objTasaCambio.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objTasaCambio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objTasaCambio.Update(T)
                            T.CommitTran()
                            CargarGrid()

                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End Select
                Else
                    MsgBox("Las tasas de cambio ya se encuentran en estado Confirmado.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()

        End Try
    End Sub

    Private Sub tsbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImprimir.Click
        Dim objfrm As New frmParamImpDestinoReporte
        Dim dtRptTCO As DataTable
        Try
            If Me.blnImprimirTCO Then
                Me.Cursor = Cursors.WaitCursor
                strCampos = "Mes, Anio, Monto, Moneda, Estado, Confirmado "
                strOrden = " Mes"
                strSQL = clsConsultas.ObtenerTasaCambioOficial(strCampos, , strOrden)
                dtRptTCO = SqlHelper.ExecuteQueryDT(strSQL)
                For Each dr As DataRow In dtRptTCO.Rows
                    If dr("Estado") = "Confirmado" Then
                        dr("Confirmado") = True
                    Else
                        dr("Confirmado") = False
                    End If
                Next
                '-- Asignar el datatable al formulario de destino del reporte
                objfrm.dtRpt = dtRptTCO.Copy

                '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
                objfrm.rptNombre = "rptStbTasaCambioOficial"
                If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    '*******************
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

       Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        CargarGrid()
    End Sub

     Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim pivotExportOptions As New DevExpress.XtraPivotGrid.PivotXlsxExportOptions()
                pivotExportOptions.ExportType = DevExpress.Export.ExportType.WYSIWYG
                TasaCambio.ExportToXlsx(sfdRuta.FileName, pivotExportOptions)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim objfrm As frmStbImportarTasaCambio
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmStbImportarTasaCambio
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                MsgBox("Tasas de cambio importadas correctamete.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub grdTasaTabla_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grdTasaTabla.FocusedRowChanged
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdTasaTabla.GetSelectedRows()
            FilaActual = Me.grdTasaTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.dtTCO.DefaultView.Item(FilaActual)("Estado").ToString.Trim.Length <> 0 Then
                    cmdAutorizar.Enabled = Me.blnConfirmarTCO And (Me.dtTCO.DefaultView.Item(FilaActual)("Estado") = "REGISTRADA")

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub

    Private Sub cmdEditarTasa_Click(sender As Object, e As EventArgs) Handles cmdEditarTasa.Click
        Editar()
    End Sub
#End Region

#Region "Procedimientos"
    Private Sub Editar()
        Dim objTasa As New frmStbEditTasaCambioOficial
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdTasaTabla.GetSelectedRows()
                FilaActual = Me.grdTasaTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    objTasa.TasaCambioOficialID = Me.dtTCO.DefaultView.Item(FilaActual)("StbTasaCambioOficialID")
                    objTasa.TypeID = 1

                    If objTasa.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                        AplicarSeguridad()
                        MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End If
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            objTasa = Nothing
        End Try
    End Sub

    Private Sub Nuevo()
        Dim objfrm As frmStbEditTasaCambioOficial
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmStbEditTasaCambioOficial
            objfrm.TipoEstadoRegistarda = Me.EstadoRegistrada
            objfrm.TipoEstadoConfirmada = Me.EstadoConfirmado
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrid()
                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class