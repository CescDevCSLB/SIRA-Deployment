Imports DAL
Imports Proyecto.Catalogos.Datos
Imports Proyecto.Configuracion
Imports SIRA.BO
Imports Seguridad.Datos
Imports C1.C1Excel
Imports DevExpress.XtraReports.UI
Imports SIRA.BO.clsConsultas
''' <summary>
''' Formulario principal de Recibos de Caja.
''' </summary>
''' <remarks></remarks>
''' 
Public Class frmSccSalidaCajaCH

#Region "Declaracion de Variables"
    Dim DtSalidasCaja As New DataTable
    Dim m_IDSalidaCaja As Integer
    Dim m_blnAprobar As Boolean
#End Region

#Region "Propiedades"

    Property IDSalida() As Integer
        Get
            IDSalida = m_IDSalidaCaja
        End Get
        Set(ByVal value As Integer)
            m_IDSalidaCaja = value
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

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim FilaActual As Integer
        Try
            Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
            FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
            If FilaActual >= 0 Then
                If Me.DtSalidasCaja.Rows.Count > 0 Then
                    Dim objSalida As frmSccSalidaCajaCHEdit
                    objSalida = New frmSccSalidaCajaCHEdit
                    objSalida.TypeGui = 2
                    objSalida.SalidaID = Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccSalidasCajaChicaID")
                    objSalida.intCajaChicaID = Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccCajaChicaID")
                    If objSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarDatos()
                        Me.DtSalidasCaja.DefaultView.Find(objSalida.SalidaID)
                    End If
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
        Dim objSalida As frmSccSalidaCajaCHEdit
        objSalida = New frmSccSalidaCajaCHEdit
        objSalida.TypeGui = 1
        If objSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Imprimir()
    End Sub

    Private Sub cmdAnular_Click(sender As Object, e As EventArgs) Handles cmdAnular.Click
        Dim FilaActual As Integer
        Dim EstadoAnulada As Integer
        Dim dtDetalleRecibo As DataTable
        Dim objCaja As New SccCajaChica
        Dim objCuenta As New SccCuentaPorCobrar
        Dim decSaldo As Decimal
        Try
            If DtSalidasCaja.DefaultView.Count > 0 Then
                Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
                FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then

                    Dim T As New TransactionManager
                    Dim IDTemp As Integer = 0
                    Dim objReciboAnular As SccSalidasCajaChica
                    Select Case MsgBox("¿Seguro que desea anular el recibo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes

                            EstadoAnulada = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOROC", "ANULADO")

                            objReciboAnular = New SccSalidasCajaChica
                            decSaldo = 0

                            T.BeginTran()
                            objReciboAnular.Retrieve(Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccSalidasCajaChicaID"))
                            objReciboAnular.objEstadoID = EstadoAnulada
                            objReciboAnular.Update(T)

                            ''Aumentar el disponible de la caja chica
                            dtDetalleRecibo = SccSalidasCajaChica.RetrieveDT("SccSalidasCajaChicaID=" & Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccSalidasCajaChicaID"), , , T)

                            If dtDetalleRecibo.Rows.Count > 0 Then
                                objCaja.RetrieveByFilter("SccCajaChicaID=" & dtDetalleRecibo.Rows(0)("objCajaChicaID"), T)

                                objCaja.Disponible = objCaja.Disponible + dtDetalleRecibo.Rows(0)("Monto")
                                objCaja.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objCaja.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objCaja.Update(T)

                                objCuenta.Update(T)

                            End If

                            T.CommitTran()
                            CargarDatos()
                            Me.DtSalidasCaja.DefaultView.Find(objReciboAnular.SccSalidasCajaChicaID)
                            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    End Select
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Metodos"
    '------------------------------------------------------------------------------------------------------------


    ''' <summary>
    ''' Procedimiento encargado de cargar los datos correspondientes a los recibos de cajas. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Dim DiasSalidasRecientes As Integer
        Try
            DiasSalidasRecientes = StbParametro.RetrieveDT("Nombre = 'DiasRecibosRecientes'", , "Valor").DefaultView.Item(0)("Valor")

            Me.DtSalidasCaja = SqlHelper.ExecuteQueryDT("SELECT CentroCosto, Concepto,SccSalidasCajaChicaID, CajaChica,Estado,objEstadoID, Fecha, Cajero, Monto, Moneda,SccCajaChicaID FROM vwSccCajaChica WHERE Fecha BETWEEN GETDATE()-" & DiasSalidasRecientes & " AND GETDATE()")
            Me.DtSalidasCaja.DefaultView.Sort = "SccSalidasCajaChicaID desc"
            Me.grdRecibosCaja.DataSource = Me.DtSalidasCaja
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

    Private Sub Imprimir()
        Dim ds As DataSet
        Dim FilaActual As Integer
        Dim intSalidaID As Integer
        Dim objjReporte As New RptSccReciboCH()
        Try
            If DtSalidasCaja.Rows.Count > 0 Then

                Dim selectedRow As Integer() = grdRecibosCajaTabla.GetSelectedRows()
                FilaActual = Me.grdRecibosCajaTabla.GetDataSourceRowIndex(selectedRow(0))
                If FilaActual >= 0 Then
                    intSalidaID = Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccSalidasCajaChicaID")

                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("Concepto, SccSalidasCajaChicaID, Moneda, Monto, Descripcion, RUC, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptReciboCH", "SccSalidasCajaChicaID=" & intSalidaID))

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

#Region "Consulta de Salidas"
    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim FilaActual As Integer
        Try
            FilaActual = Me.grdRecibosCajaTabla.FocusedRowHandle
            If FilaActual >= 0 Then
                If Me.DtSalidasCaja.Rows.Count > 0 Then
                    Dim objSalida As frmSccSalidaCajaCHEdit
                    objSalida = New frmSccSalidaCajaCHEdit
                    objSalida.TypeGui = 2
                    objSalida.SalidaID = Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccSalidasCajaChicaID")
                    objSalida.intCajaChicaID = Me.DtSalidasCaja.DefaultView.Item(FilaActual)("SccCajaChicaID")
                    If objSalida.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        Me.CargarDatos()
                        Me.DtSalidasCaja.DefaultView.Find(objSalida.SalidaID)
                    End If
                End If
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