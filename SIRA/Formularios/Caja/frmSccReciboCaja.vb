Imports DAL
Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports SIRA.BO
Imports Seguridad.Datos
Imports C1.C1Excel
Imports SIRA.BO.clsConsultas
Imports DevExpress.XtraReports.UI

''' <summary>
''' Formulario principal de Recibos de Caja.
''' </summary>
''' <remarks></remarks>
''' 
Public Class frmSccReciboCaja

#Region "Declaracion de Variables"
    Dim DtRecibosCajas As New DataTable
    Dim m_IDReciboCaja, m_Exportar, IdExportar As Integer
    Dim SqlParametros(7) As SqlClient.SqlParameter
    Dim m_blnAprobar As Boolean
#End Region

#Region "Propiedades"

    Property IDReciboCaja() As Integer
        Get
            IDReciboCaja = m_IDReciboCaja
        End Get
        Set(ByVal value As Integer)
            m_IDReciboCaja = value
        End Set
    End Property

    Property Exportar() As Integer
        Get
            Exportar = m_Exportar
        End Get
        Set(ByVal value As Integer)
            m_Exportar = value
        End Set
    End Property

    Property blnAprobar()
        Get
            blnAprobar = Me.m_blnAprobar
        End Get
        Set(ByVal value)
            Me.m_blnAprobar = value
        End Set
    End Property
#End Region

#Region "Eventos"

    Private Sub cmdAnular_Click(sender As Object, e As EventArgs) Handles cmdAnular.Click
        Dim FilaActual As Integer
        Dim EstadoAnulada As Integer
        Dim dtDetalleRecibo As DataTable
        Dim dtDetalleMora As DataTable
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        Dim objCuenta As New SccCuentaPorCobrar
        Dim objCuentaDetalleEmpleados As New SccCuentaPorCobrarDetalleEmpleados
        Dim objCuentaEmpleados As New SccCuentaPorCobrarEmpleados
        Dim objMora As New SccMora
        Dim decSaldo As Decimal
        Try
            If DtRecibosCajas.DefaultView.Count > 0 Then
                Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
                FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then

                    Dim T As New TransactionManager
                    Dim IDTemp As Integer = 0
                    Dim objReciboAnular As SccReciboCaja
                    Select Case MsgBox("¿Seguro que desea anular el recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes

                            EstadoAnulada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "ANULADO")

                            objReciboAnular = New SccReciboCaja
                            decSaldo = 0

                            T.BeginTran()
                            objReciboAnular.Retrieve(Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID"))
                            objReciboAnular.objEstadoID = EstadoAnulada
                            objReciboAnular.Update(T)

                            If Not objReciboAnular.EsPagoPrestamo Then
                                ''Aumentar en la cuenta por pagar
                                dtDetalleRecibo = SccReciboDetalle.RetrieveDT("objReciboCajaID=" & Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID"), , , T)

                                If dtDetalleRecibo.Rows.Count > 0 Then
                                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                                        objCuentaDetalle.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"), T)

                                        objCuentaDetalle.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")
                                        objCuentaDetalle.MontoPagado = 0
                                        decSaldo = decSaldo + drwDetRecibo("Monto")
                                        objCuentaDetalle.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                        objCuentaDetalle.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                        objCuentaDetalle.Update(T)
                                    Next

                                    objCuenta.Retrieve(objReciboAnular.objSccCuentaID, T)
                                    objCuenta.Saldo = decSaldo
                                    objCuenta.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                    objCuenta.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                    objCuenta.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")

                                    objCuenta.Update(T)

                                End If

                                ''Si tiene el pago de alguna mora, regresar la mora a Pendiente
                                dtDetalleMora = SccReciboDetMora.RetrieveDT("objReciboCajaID=" & Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID"), , , T)
                                If dtDetalleMora.Rows.Count > 0 Then
                                    For Each drwDetReciboMora As DataRow In dtDetalleMora.Rows

                                        objMora.Retrieve(drwDetReciboMora("objSccMoraID"), T)
                                        objMora.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                        objMora.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                        objMora.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "AUTORIZADA")
                                        objMora.Update(T)
                                    Next

                                End If

                            Else
                                ''Aumentar en la cuenta por pagar
                                dtDetalleRecibo = SccReciboDetalle.RetrieveDT("objReciboCajaID=" & Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID"), , , T)

                                If dtDetalleRecibo.Rows.Count > 0 Then
                                    For Each drwDetRecibo As DataRow In dtDetalleRecibo.Rows

                                        objCuentaDetalleEmpleados.RetrieveByFilter("SccCuentaPorCobrarDetalleID=" & drwDetRecibo("objCuentaDetalleID"), T)

                                        objCuentaDetalleEmpleados.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMENSUALIDAD", "01")
                                        objCuentaDetalleEmpleados.MontoPagado = 0
                                        decSaldo = decSaldo + drwDetRecibo("Monto")
                                        objCuentaDetalleEmpleados.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                        objCuentaDetalleEmpleados.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                        objCuentaDetalleEmpleados.Update(T)
                                    Next

                                    objCuentaEmpleados.Retrieve(objReciboAnular.objSccCuentaID, T)
                                    objCuentaEmpleados.Saldo = decSaldo
                                    objCuentaEmpleados.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                    objCuentaEmpleados.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                    objCuentaEmpleados.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCUENTA", "01")

                                    objCuentaEmpleados.Update(T)

                                End If


                            End If

                            RecalcularSaldos(T, objReciboAnular.objSccCuentaID)

                            T.CommitTran()
                            CargarDatos()
                            Me.DtRecibosCajas.DefaultView.Find(objReciboAnular.SccReciboCajaID)
                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End Select
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub RecalcularSaldos(T As TransactionManager, CuentaID As Integer)
        Dim parametro(1) As SqlClient.SqlParameter
        Try
            parametro(0) = New SqlClient.SqlParameter("@SccCuentaID ", SqlDbType.Int, 4)
            parametro(0).Value = CuentaID
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "sp_CalcularSaldos", parametro)

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            parametro = Nothing

        End Try
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Imprimir()
    End Sub

    Private Sub cmbExportar_Click(sender As Object, e As EventArgs) Handles cmbExportar.Click
        Try
            If sfdRuta.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                grdRecibosCajaTabla.ExportToXlsx(sfdRuta.FileName)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
            FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.DtRecibosCajas.Rows.Count > 0 Then
                    'Dim IDEstadoPagado As Integer
                    'IDEstadoPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "PAGADO")

                    'If Me.DtRecibosCajas.DefaultView.Item(FilaActual)("objEstadoID").ToString.Trim.Length <> 0 Then
                    '    If Me.DtRecibosCajas.DefaultView.Item(FilaActual)("objEstadoID") = IDEstadoPagado Then
                    '        MsgBox("Solamente Recibos de caja en estado REGISTRADO pueden ser Editados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    '        Exit Sub
                    '    End If
                    'Else
                    '    MsgBox("No ha sido posible cargar el Identificador de estado (objEstadoID) del Recibo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    '    Exit Sub
                    'End If

                    Dim objRecibo As frmSccEditReciboCaja
                    objRecibo = New frmSccEditReciboCaja
                    objRecibo.TypGui = 1
                    objRecibo.ReciboCajaID = Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID")
                    If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarDatos()
                        Me.DtRecibosCajas.DefaultView.Find(objRecibo.ReciboCajaID)
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
            FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.DtRecibosCajas.Rows.Count > 0 Then
                    Dim IDEstadoPagado As Integer
                    IDEstadoPagado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "PAGADO")

                    If Me.DtRecibosCajas.DefaultView.Item(FilaActual)("objEstadoID") = IDEstadoPagado Then
                        MsgBox("Solamente Recibos de caja en estado REGISTRADO pueden ser Procesados", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    End If
                    Select Case MsgBox("¿Esta seguro de Procesar el Recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            If Me.DtRecibosCajas.DefaultView.Item(FilaActual)("objEstadoID") = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "REGISTRADO") Then
                                Me.PROCESAR_RECIBO(0, 0)
                            Else
                                MsgBox("El Recibo ha sido procesado exitosamente", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                            End If
                        Case MsgBoxResult.No
                            Exit Sub
                    End Select

                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub frmSccReciboCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
        'Me.AplicarSeguridad()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefrescar.Click
        Me.CargarDatos()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim objRecibo As frmSccEditReciboCaja
        objRecibo = New frmSccEditReciboCaja

        objRecibo.TypGui = 0
        objRecibo.ShowDialog(Me)
        Me.CargarDatos()


        'If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '    Me.CargarDatos()
        'End If
    End Sub


#End Region

#Region "Metodos"

    Private Sub Imprimir()
        Dim ds As DataSet
        Dim FilaActual As Integer
        Dim intReciboID As Integer
        Dim objjReporte As New RptSccRecibo()
        Dim objRecibo As New SccReciboCaja
        Try
            If DtRecibosCajas.Rows.Count > 0 Then

                Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
                FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    intReciboID = Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID")
                    objRecibo.Retrieve(intReciboID)

                    If objRecibo.SccReciboCajaID <> 0 Then
                        If objRecibo.EsPagoPrestamo Then
                            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccReciboCajaID, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Numero, Fecha, TotalRecibido, Alumno, Grupo, MontoDetalle, Concepto,observaciones", "vwRptReciboEmpleado", "SccReciboCajaID=" & intReciboID))
                        Else
                            ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SccReciboCajaID, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Numero, Fecha, TotalRecibido, Alumno, Grupo, MontoDetalle, Concepto,observaciones", "vwRptRecibo", "SccReciboCajaID=" & intReciboID))

                        End If
                    End If


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



    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes a los recibos de cajas. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Dim DiasRecibosRecientes As Integer
        Try
            DiasRecibosRecientes = StbParametro.RetrieveDT("Nombre = 'DiasRecibosRecientes'", , "Valor").DefaultView.Item(0)("Valor")

            Me.DtRecibosCajas = SqlHelper.ExecuteQueryDT("SELECT SccReciboCajaID, Numero, Fecha, MontoRecibidoEfectivoCordoba as TotalRecibido, objEstadoID, Expediente, objAlumnoID, Alumno, Estado, NumeroRecibo, StbPersonaID, Moneda, Grupo,Concepto FROM vwSccReciboCaja WHERE Fecha BETWEEN GETDATE()-" & DiasRecibosRecientes & " AND GETDATE()")
            Me.DtRecibosCajas.DefaultView.Sort = "SccReciboCajaID desc"
            Me.grdRecibosCaja.DataSource = Me.DtRecibosCajas
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    ''' <summary>
    ''' Procedimiento Encargado de aplicar la Seguridad.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub AplicarSeguridad()
        Dim objSeg As New SsgSeguridad
        Try
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmSccReciboCaja"
            Me.cmdAgregar.Enabled = objSeg.TienePermiso("AgregarRoc")
            Me.cmdEditar.Enabled = objSeg.TienePermiso("EditarRoc")
            Me.cmdConsultar.Enabled = objSeg.TienePermiso("ConsultarRoc")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub



    Private Sub CargarDatosFiltro(ByVal Filtro As String)
        Dim strConsulta As String
        Dim Filtro2 As String
        Try
            Filtro2 = Filtro

            strConsulta = clsConsultas.ObtenerConsultaGeneral("Expediente, Fecha, Numero, SccReciboCajaID, TotalRecibo,objEstadoId, esPagoPrima, objClienteId, Cliente, Estado, NumeroRecibo, StbPersonaID", " vwSccReciboCaja", Filtro2)
            Me.DtRecibosCajas = SqlHelper.ExecuteQueryDT(strConsulta, Me.SqlParametros)
            Me.DtRecibosCajas.DefaultView.Sort = "SccReciboCajaID desc"

            If Me.DtRecibosCajas.DefaultView.Count > 0 Then
                Me.grdRecibosCaja.DataSource = DtRecibosCajas
                Me.grdRecibosCaja.Text = "Recibos de Caja(" & Me.DtRecibosCajas.Rows.Count.ToString & ")"
            End If
            If Me.Exportar = 10 Then
                Me.ExportacionExcel()
            End If
            If Me.DtRecibosCajas.DefaultView.Count = 0 Then
                MsgBox(My.Resources.MsgBusqueda, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Procesamiento de Recibos"
    '------------------------------------------------------------------------------------------------------------
    ' Descripcion    : Esta funcion se encarga de realizar el procesamiento de los datos una vez que se haya guardado.
    '------------------------------------------------------------------------------------------------------------
    Private Sub PROCESAR_RECIBO(ByVal IntIDReciboCaja As Integer, ByVal IntOpcion As Integer)
        Dim parametro(3) As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Dim objReciboCaja As New SccReciboCaja
        Dim EsPrima As Boolean
        Dim IDReciboCaja As Integer
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRecibosCajaTabla.FocusedRowHandle
            If FilaActual >= 0 Then
                T.BeginTran()
                IDReciboCaja = Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID")
                parametro(0) = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
                parametro(0).Value = IDReciboCaja

                parametro(1) = New SqlClient.SqlParameter("@EsPrima", SqlDbType.Int, 4)
                parametro(2) = New SqlClient.SqlParameter("@MontoPrima", SqlDbType.Decimal)
                EsPrima = SccReciboCaja.RetrieveDT("SccReciboCajaID=" & parametro(0).Value.ToString, , "EsPagoPrima").DefaultView.Item(0)("EsPagoPrima")

                objReciboCaja.Retrieve(IDReciboCaja, T)

                objReciboCaja.objEstadoID = ClsCatalogos.ObtenerIDSTbCatalogo("EstadoROC", "PAGADO")
                objReciboCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objReciboCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objReciboCaja.Update(T)

                If EsPrima Then
                    parametro(1).Value = 1
                    parametro(2).Value = objReciboCaja.TotalRecibido
                Else
                    parametro(1).Value = 0
                End If
                SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrar", parametro)

                T.CommitTran()

                DisminuirSaldoDebito(IDReciboCaja)

                MsgBox("El Recibo ha sido Procesado Exitosamente.", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                Me.CargarDatos()
                Me.DtRecibosCajas.DefaultView.Find(IDReciboCaja)
            End If

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            parametro = Nothing
            T = Nothing
        End Try
    End Sub

#End Region

#Region "Consulta de Recibo de Cajas"
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
            FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.DtRecibosCajas.Rows.Count > 0 Then
                    Dim objRecibo As frmSccEditReciboCaja
                    objRecibo = New frmSccEditReciboCaja
                    objRecibo.TypGui = 2
                    objRecibo.ReciboCajaID = Me.DtRecibosCajas.DefaultView.Item(FilaActual)("SccReciboCajaID")
                    If objRecibo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarDatos()
                        Me.DtRecibosCajas.DefaultView.Find(objRecibo.ReciboCajaID)
                    End If
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Exportar Recibos de Caja a Excel"
    Private Sub ExportacionExcel()

        Dim libroExcel As New C1.C1Excel.C1XLBook
        Dim hojaExcel As C1.C1Excel.XLSheet
        Dim i As Integer = 0
        Dim fechaReporte As String = Convert.ToString(clsProyecto.Conexion.FechaServidor)
        Dim estilo As New C1.C1Excel.XLStyle(libroExcel)
        estilo.BackColor = Color.LightGreen
        Try

            hojaExcel = libroExcel.Sheets(0)
            hojaExcel(0, 0).Value = "SccReciboCajaID"
            hojaExcel(0, 0).Style = estilo
            hojaExcel(0, 1).Value = "Número"
            hojaExcel(0, 1).Style = estilo
            hojaExcel(0, 2).Value = "No. Expediente"
            hojaExcel(0, 2).Style = estilo
            hojaExcel(0, 3).Value = "Monto"
            hojaExcel(0, 3).Style = estilo
            hojaExcel(0, 4).Value = "Fecha"
            hojaExcel(0, 4).Style = estilo
            hojaExcel(0, 5).Value = "Cliente"
            hojaExcel(0, 5).Style = estilo
            hojaExcel(0, 6).Value = "Estado"
            hojaExcel(0, 6).Style = estilo

            For Each dr As DataRow In DtRecibosCajas.Rows
                i = i + 1
                hojaExcel(i, 0).Value = dr("SccReciboCajaID")
                hojaExcel(i, 1).Value = dr("Numero")
                hojaExcel(i, 2).Value = dr("Expediente")
                hojaExcel(i, 3).Value = dr("TotalRecibo")
                hojaExcel(i, 4).Value = Convert.ToString(dr("Fecha"))
                hojaExcel(i, 5).Value = dr("Cliente")
                hojaExcel(i, 6).Value = dr("Estado")
            Next

            If objUbicacion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                libroExcel.Save(objUbicacion.FileName + ".xls")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
#End Region

#Region "Disminuir el saldo de la nota de débito"
    Private Sub DisminuirSaldoDebito(ByVal IntIDReciboCaja As Integer)

        Dim parametronota(1) As SqlClient.SqlParameter
        Dim T As New TransactionManager
        Try
            T.BeginTran()
            parametronota(0) = New SqlClient.SqlParameter("@IntReciboCajaID", SqlDbType.Int, 4)
            parametronota(0).Value = IntIDReciboCaja
            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_SfaDimininuirCuentaPorCobrarDebito", parametronota)

            T.CommitTran()


        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            T = Nothing
        End Try
    End Sub
#End Region



End Class