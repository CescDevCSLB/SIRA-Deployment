Imports Seguridad.Datos
Imports SIRA.BO.clsConsultas
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports DevExpress.XtraReports.UI
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos
Imports DAL

Public Class frmSContComprobantes


#Region "Variables del formulario"
    Dim dtCheques As DataTable
    Dim objseg As SsgSeguridad
    Dim boolAgregar, boolEditar, boolConsultar, boolAnular, boolImprimir, boolBuscar, boolContabilizar As Boolean
    Dim SqlParametros(5) As SqlClient.SqlParameter
    Dim IDEstadoRegistrado, IDEstadoContabilizado, IDEstadoAnulado As Integer
#End Region

#Region "Incializar GUI"

    ''Descripción:      Metodo encargado de cargar la informacion de Bodegas registrados en la grilla
    Public Sub CargarGrid()
        Try

            dtCheques = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TipoAsiento, ScontComprobanteID, NumAsiento, Fecha, Concepto, ValorCordobas, ValorDolares, objMonedaID, Observaciones, Moneda, Estado, objEstadoID", "vwSContComprobantes", ))
            dtCheques.PrimaryKey = New DataColumn() {Me.dtCheques.Columns("ScontComprobanteID")}
            dtCheques.DefaultView.Sort = "ScontComprobanteID desc"
            Me.grdPeriodo.DataSource = dtCheques
            Me.grdPeriodo.Text = "Comprobantes (" & Me.dtCheques.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarGridBusqueda(strfiltro As String)
        Try
            dtCheques = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("TipoAsiento, ScontComprobanteID, NumAsiento, Fecha, Concepto, ValorCordobas, ValorDolares, objMonedaID, Observaciones, Moneda, Estado, objEstadoID", "vwSContComprobantes", strfiltro))
            dtCheques.PrimaryKey = New DataColumn() {Me.dtCheques.Columns("ScontComprobanteID")}
            dtCheques.DefaultView.Sort = "ScontComprobanteID desc"
            Me.grdPeriodo.DataSource = dtCheques
            Me.grdPeriodo.Text = "Comprobantes (" & Me.dtCheques.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub AplicarSeguridad()
        objseg = New SsgSeguridad
        Try
            objseg.ServicioUsuario = "frmScontCheques"
            objseg.Usuario = clsProyecto.Conexion.Usuario
            boolAgregar = objseg.TienePermiso("AgregarCheque")
            boolEditar = objseg.TienePermiso("EditarCheques")
            boolConsultar = objseg.TienePermiso("ConsultarCheques")
            boolAnular = objseg.TienePermiso("AnularCheque")
            boolImprimir = objseg.TienePermiso("ImprimirCheques")
            boolBuscar = objseg.TienePermiso("BuscarCheque")
            boolContabilizar = objseg.TienePermiso("ContabilizarCheque")


            cmdAgregar.Enabled = boolAgregar
            cmdConsultar.Enabled = boolConsultar And dtCheques.Rows.Count > 0
            cmdEditar.Enabled = boolEditar And dtCheques.Rows.Count > 0
            cmdInactivar.Enabled = boolAnular And dtCheques.Rows.Count > 0
            cmdImprimir.Enabled = boolAnular And dtCheques.Rows.Count > 0
            cmdBuscar.Enabled = boolBuscar And dtCheques.Rows.Count > 0
            cmdContabilizar.Enabled = boolContabilizar And dtCheques.Rows.Count > 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objseg = Nothing
        End Try
    End Sub

#End Region

#Region "Procedimientos"
    Private Sub Editar()

        Dim objTasaCambio As StbTasaCambioOficial
        Dim objPeriodo As SContPeriodos
        Dim intPeriodo As Integer
        Dim ConsultarPeriodo As New frmScontComprobanteEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
                objTasaCambio = New StbTasaCambioOficial
                objPeriodo = New SContPeriodos

                If FilaActual >= 0 Then

                    objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)

                    If IsNothing(objTasaCambio.Monto) Or objTasaCambio.Monto = 0 Then
                        MsgBox("Defina una tasa de cambio valida.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)

                    Else
                        objPeriodo.RetrieveByFilter("Activo=1 AND Cerrado=0")
                        If objPeriodo.SContPeriodoID = 0 Then
                            MsgBox("No existe un período activo, para generar el comprobante.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Else

                            If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                                If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID") <> IDEstadoRegistrado Then
                                    MsgBox("Solamente comprobantes en estado REGISTRADO pueden ser Editados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                                    Exit Sub
                                End If
                            Else
                                MsgBox("No ha sido posible cargar el Identificador de estado (objEstadoID) del cheque.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                            Exit Sub
                        End If
                            ConsultarPeriodo.ChqeueID = Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID")
                            intPeriodo = objPeriodo.SContPeriodoID
                            ConsultarPeriodo.PeriodoID = intPeriodo
                            ConsultarPeriodo.TypeID = 1

                            If ConsultarPeriodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                                CargarGrid()
                            End If
                        End If

                    End If

                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarPeriodo = Nothing
        End Try
    End Sub



    Private Sub Consultar()
        Dim ConsultarPeriodo As New frmScontComprobanteEdit
        Dim FilaActual As Integer
        Try
            Try
                Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
                FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

                If FilaActual >= 0 Then
                    ConsultarPeriodo.TypeID = 2
                    ConsultarPeriodo.ChqeueID = Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID")
                    ConsultarPeriodo.ShowDialog(Me)
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            ConsultarPeriodo = Nothing
        End Try
    End Sub


#End Region

#Region "Eventos del Formulario"

    Private Sub frmStbBodegas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            IDEstadoRegistrado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "01")
            IDEstadoContabilizado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "02")
            IDEstadoAnulado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "03")
            CargarGrid()
            Me.AplicarSeguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub Contabilizar(periodo As Integer)
        Dim parametro(3) As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Dim FilaActual As Integer
        Try

            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

            If FilaActual >= 0 Then

                If Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID").ToString.Trim.Length <> 0 Then

                    parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
                    parametro(0).Value = periodo

                    parametro(1) = New SqlClient.SqlParameter("@IDComprobante ", SqlDbType.Int, 4)
                    parametro(1).Value = Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID")

                    parametro(2) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
                    parametro(2).Value = clsProyecto.Conexion.Usuario


                    T.BeginTran()

                    SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_ActualizarSaldoInicialComprobante", parametro)
                    SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_ContabilizarComprobantes", parametro)

                    T.CommitTran()

                    MsgBox("Comprobante contabilizado correctamente.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            parametro = Nothing

        End Try
    End Sub

    Private Sub AnularCheque(periodo As Integer)
        Dim parametro(2) As SqlClient.SqlParameter
        Dim mes As Integer

        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Dim FilaActual As Integer
        Try
            mes = Date.Now.Month
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

            If FilaActual >= 0 Then

                If Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID").ToString.Trim.Length <> 0 Then


                    parametro(0) = New SqlClient.SqlParameter("@IDComprobante ", SqlDbType.Int, 4)
                    parametro(0).Value = Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID")

                    parametro(1) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
                    parametro(1).Value = clsProyecto.Conexion.Usuario

                    SqlHelper.ExecuteNonQuery(CommandType.StoredProcedure, "Sp_AnularComprobante", parametro)
                    MsgBox("Comprobante anulado correctamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                End If

            End If

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub



    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim editperiodo As frmScontComprobanteEdit
        Dim objTasaCambio As StbTasaCambioOficial
        Dim objPeriodo As SContPeriodos
        Dim intPeriodo As Integer
        Try
            Me.Cursor = WaitCursor
            editperiodo = New frmScontComprobanteEdit
            objTasaCambio = New StbTasaCambioOficial
            objPeriodo = New SContPeriodos

            objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)

            If IsNothing(objTasaCambio.Monto) Or objTasaCambio.Monto = 0 Then
                MsgBox("Defina una tasa de cambio valida.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)

            Else
                objPeriodo.RetrieveByFilter("Activo=1 AND Cerrado=0")
                If objPeriodo.SContPeriodoID = 0 Then
                    MsgBox("No existe un período activo, para generar el comprobante.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Else
                    intPeriodo = objPeriodo.SContPeriodoID
                    editperiodo.PeriodoID = intPeriodo
                    editperiodo.TypeID = 0

                    If editperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        CargarGrid()
                    End If
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdConsultar_Click(sender As Object, e As EventArgs) Handles cmdConsultar.Click
        Try
            Me.Cursor = WaitCursor
            Consultar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim ds As DataSet
        Dim FilaActual As Integer
        Try
            Dim objjReporte As New RptComprobante()
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

            If FilaActual >= 0 Then

                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Tipo, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NumAsiento, ScontComprobanteID, FechaComprobante, Concepto, IDCuenta, Cuenta, MontoAcreditar, MontoDebitar, CentroCosto,Observaciones, UsuarioCreacion", "vwRptComprobante", "ScontComprobanteID=" & Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID")))

                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdContabilizar_Click(sender As Object, e As EventArgs) Handles cmdContabilizar.Click
        Dim objPeriodo As New SContPeriodos
        Dim intPeriodo As Integer
        Dim FilaActual As Integer
        Dim objMes As New ScontMesCerrado
        Dim Fecha As DateTime
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID") <> IDEstadoRegistrado Then
                    MsgBox("Solamente comprobantes en estado REGISTRADO pueden ser contabilizados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            Else
                MsgBox("No ha sido posible cargar el Identificador de estado (objEstadoID) del cheque.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If
            objPeriodo.RetrieveByFilter("Activo=1 AND Cerrado=0")
            If objPeriodo.SContPeriodoID = 0 Then
                MsgBox("No existe un período activo, para generar el comprobante.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Else
                intPeriodo = objPeriodo.SContPeriodoID
            End If

            Fecha = Me.dtCheques.DefaultView.Item(FilaActual)("Fecha")


            ''Verificar que exista el periodo
            objPeriodo.RetrieveByFilter("Activo=1 AND Periodo=" & Fecha.Year)
            If objPeriodo.SContPeriodoID = 0 Then
                MsgBox("No es posible contabilizar movimientos en un periodo que no esta registrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objPeriodo = New SContPeriodos
            ''Si el mes es enero y existe un periodo anterior, verificar que el anio anterior este cerrado.
            If Fecha.Month = 1 Then
                objPeriodo.RetrieveByFilter("Activo=1 AND Cerrado=1 and Periodo=" & Fecha.Year - 1)
                If objPeriodo.SContPeriodoID = 0 Then
                    MsgBox("No es posible contabilizar movimientos en este mes, ya que el periodo anterior no esta cerrado.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            End If

            ''Verificar que la fecha del comprobante coincida con el mes que esta abierto
            objMes.RetrieveByFilter("objPeriodoID =" & intPeriodo & " AND Cerrado=0  ORDER BY Mes asc")

            If objMes.ScontMesCerradoID <> 0 Then
                If objMes.Mes < Fecha.Month Then
                    MsgBox("No es posible contabilizar movimientos en un mes superior al que se encuentra abierto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            End If

            Select Case MsgBox("¿Está seguro que desea contablizar el comprobante seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Contabilizar(intPeriodo)
                    CargarGrid()
                    AplicarSeguridad()

                Case MsgBoxResult.No
                    Exit Sub
            End Select

            '''Verificar que la fecha del comprobante coincida con el mes que esta abierto
            'objMes.RetrieveByFilter("Cerrado=0  ORDER BY Mes asc")
            'If objMes.ScontMesCerradoID <> 0 Then
            '    If objMes.Mes < Fecha.Month Then
            '        MsgBox("No es posible contabilizar movimientos en un mes superior al que se encuentra abierto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            '    Else


            '    End If
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub cmdInactivar_Click(sender As Object, e As EventArgs) Handles cmdInactivar.Click
        Dim objComprobante As New ScontComprobanteID
        Dim intPeriodo As Integer
        Dim FilaActual As Integer
        Dim objPeriodo As New SContPeriodos
        Try
            Me.Cursor = WaitCursor
            Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
            FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))

            If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID") = IDEstadoAnulado Then
                    MsgBox("Solamente comprobantes en estado REGISTRADO o CONTABILIZADO pueden ser anulados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If
            Else
                MsgBox("No ha sido posible cargar el Identificador de estado (objEstadoID) del cheque.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            objPeriodo.RetrieveByFilter("Activo=1 AND Cerrado=0")
            If objPeriodo.SContPeriodoID = 0 Then
                MsgBox("No existe un período activo, para generar el comprobante.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            Else
                intPeriodo = objPeriodo.SContPeriodoID
            End If

            If Me.dtCheques.DefaultView.Item(FilaActual)("objEstadoID") = IDEstadoContabilizado Then
                Select Case MsgBox("¿Está seguro que desea anular el comprobante seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        AnularCheque(intPeriodo)
                        CargarGrid()
                        AplicarSeguridad()

                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            Else
                Select Case MsgBox("¿Está seguro que desea anular el comprobante seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        objComprobante.Retrieve(Me.dtCheques.DefaultView.Item(FilaActual)("ScontComprobanteID"))
                        objComprobante.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objComprobante.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objComprobante.objEstadoID = IDEstadoAnulado
                        objComprobante.Update()
                        CargarGrid()
                        AplicarSeguridad()

                    Case MsgBoxResult.No
                        Exit Sub
                End Select
            End If




        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim BuscarCheques As New frmStbBuscarCheques
        Dim strFiltro As String = String.Empty

        Try
            Try
                If BuscarCheques.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    strFiltro = strFiltro & " AND datepart(year,fecha) = " & BuscarCheques.Periodo & " AND objEstadoID=" & BuscarCheques.EstadoID
                    CargarGridBusqueda(strFiltro)
                    AplicarSeguridad()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            BuscarCheques = Nothing
        End Try
    End Sub

    Private Sub tsbRefrescar_Click(sender As Object, e As EventArgs) Handles tsbRefrescar.Click
        CargarGrid()
        AplicarSeguridad()
    End Sub

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Close()
    End Sub


    'Private Sub cmdActivar_Click(sender As Object, e As EventArgs)
    '    Dim ChequeID As Integer
    '    Dim objCheque As New ScontComprobanteID
    '    Dim FilaActual As Integer
    '    Try
    '        Dim selectedRow As Integer() = grdPeriodoTabla.GetSelectedRows()
    '        FilaActual = Me.grdPeriodoTabla.GetDataSourceRowIndex(selectedRow(0))
    '        If FilaActual >= 0 Then
    '            Select Case MsgBox("¿Está seguro de anular el comprobante seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
    '                Case MsgBoxResult.Yes
    '                    ChequeID = Me.dtCheques.DefaultView.Item(FilaActual)("SScontComprobanteID")
    '                    objCheque.Retrieve(ChequeID)
    '                    objCheque.UsuarioModificacion = clsProyecto.Conexion.Usuario
    '                    objCheque.FechaModificacion = clsProyecto.Conexion.FechaServidor
    '                    objCheque.Activo = True
    '                    objCheque.Update()
    '                    CargarGrid()
    '                Case MsgBoxResult.No
    '                    Exit Sub
    '            End Select
    '        End If

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    Finally
    '        objCheque = Nothing
    '        Me.Cursor = [Default]
    '    End Try
    'End Sub


    Private Sub grdPeriodoTabla_DoubleClick(sender As Object, e As EventArgs) Handles grdPeriodoTabla.DoubleClick
        Try
            Me.Cursor = WaitCursor
            Editar()
            CargarGrid()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region




End Class