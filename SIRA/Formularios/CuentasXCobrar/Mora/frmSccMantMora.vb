''-------------------------------------------------------------------------------------------------
''----------------------------------------------------------------------
''--    Formulario Principal Cátalgo Notas de Débito
''----------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Data.SqlClient
Imports Proyecto.Catalogos.Datos
Imports SIRA.BO

Public Class frmSccMantMora

#Region "Declaracion de Variables Locales y Objetos"
    '' Dim objND As SccNotaDebito
    Dim objSeg As SsgSeguridad
    Dim dtND As DataTable
    Dim IDND As Integer
    Dim EstadoND As Integer
    Dim CerosRellenoND As Integer
    Dim EstadoRegistrada As Integer
    Dim EstadoAutorizada As Integer
    Dim EstadoAnulada As Integer
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Dim blnModificarND As Boolean = False
    Dim blnAutorizarND As Boolean = False
    Dim blnAnularND As Boolean = False
    Dim blnBuscarND As Boolean = False
    Dim blnConsultarND As Boolean = False
    Dim blnImprimirND As Boolean = False
    Dim blnBusqueda As Boolean = False
    Dim intEstadoMo
    Private m_DiasNotaDebitoRecientes As Integer

    Property DiasNotaDebitoRecientes() As Integer
        Get
            DiasNotaDebitoRecientes = Me.m_DiasNotaDebitoRecientes
        End Get
        Set(ByVal value As Integer)
            Me.m_DiasNotaDebitoRecientes = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"
    
    Private Sub frmSccMantNotaDebito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            AplicarSeguridad()
            PropiedadesFormulario()
            CargarMoraPendiente()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Seguridad"
    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Aplica la Seguridad al Formulario
    '-----------------------------------------------------------------------------------
    Private Sub AplicarSeguridad()
        Try
            objSeg = New SsgSeguridad
            objSeg.ServicioUsuario = "frmSccMantNotaDebito"
            objSeg.Usuario = clsProyecto.Conexion.Usuario
           
            ''If objSeg.TienePermiso("ModificarND") Then
            ''    blnModificarND = True
            ''Else
            ''    blnModificarND = False
            ''End If
            'If objSeg.TienePermiso("AutorizarND") Then
            '    blnAutorizarND = True
            'Else
            '    blnAutorizarND = False
            'End If
            'If objSeg.TienePermiso("AnularND") Then
            '    blnAnularND = True
            'Else
            '    blnAnularND = False
            'End If

            'If objSeg.TienePermiso("ImprimirND") Then
            '    blnImprimirND = True
            'Else
            '    blnImprimirND = False
            'End If
            'Me.cmdDeshacerNota.Enabled = objSeg.TienePermiso("DeshacerNota")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

    
    Private Sub PropiedadesFormulario()
        Dim dtTemp As DataTable
        Try

            '-- Obtener ID del Estado de Nota de Debito REGISTRADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'ESTADOMORA' AND Codigo='REGISTRADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoRegistrada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito AUTORIZADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'ESTADOMORA' AND Codigo='AUTORIZADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAutorizada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '-- Obtener ID del Estado de Nota de Debito ANULADA
            strCampos = " StbValorCatalogoID "
            strFiltro = " Nombre= 'ESTADOMORA' AND Codigo='ANULADA' "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro)
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                EstadoAnulada = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Grid"

    Private Sub CargarMoraPendiente()
        Dim FilaActual As Integer
        Dim strFiltroCargaInicia As String
        Try
            If Not blnBusqueda Then
                Me.DiasNotaDebitoRecientes = ClsCatalogos.GetValorParametro("DiasNotasDebitoRecientes")

                strFiltroCargaInicia = " Estado='Autorizada' AND Fecha BETWEEN GETDATE()- " & Me.DiasNotaDebitoRecientes.ToString & " AND GETDATE()  "
                strCampos = " * "
                strOrden = " Fecha DESC "
                dtND = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("distinct Mes, SccMoraID, Fecha, Monto, Descripcion, objEstadoID, SccCuentaID, StbPersonaID, Alumno, Estado, NumCuenta", "vwSccMora", strFiltroCargaInicia))
            End If

            If dtND.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                dtND.PrimaryKey = New DataColumn() {dtND.Columns("SccMoraID")}
                Me.dtND.DefaultView.Sort = "SccMoraID"

                Me.grdND.DataSource = dtND
                Me.grdND.Text = "Moras (" & dtND.Rows.Count & ")"


                If Me.grdNDTabla.RowCount > 0 Then

                    Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                    FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        IDND = Me.dtND.DefaultView.Item(FilaActual)("SccMoraID")
                        EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")
                    End If
                    Me.tsbModificarND.Enabled = True
                    '-- Habilitar Opciones
                    'If blnModificarND And EstadoND = EstadoRegistrada Then
                    '    Me.tsbModificarND.Enabled = True
                    'Else
                    '    Me.tsbModificarND.Enabled = False
                    'End If

                    If blnImprimirND And EstadoND = EstadoAutorizada Then
                        Me.tsbImprimirND.Enabled = True
                    Else
                        Me.tsbImprimirND.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub CargarMoraPagada()
        Dim FilaActual As Integer
        Dim strFiltroCargaInicia As String
        Try
            If Not blnBusqueda Then
                Me.DiasNotaDebitoRecientes = ClsCatalogos.GetValorParametro("DiasNotasDebitoRecientes")

                strFiltroCargaInicia = " Estado='Pagada' AND Fecha BETWEEN GETDATE()- " & Me.DiasNotaDebitoRecientes.ToString & " AND GETDATE()  "
                strCampos = " * "
                strOrden = " Fecha DESC "
                dtND = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("distinct Mes, SccMoraID, Fecha, Monto, Descripcion, objEstadoID, SccCuentaID, StbPersonaID, Alumno, Estado, NumCuenta", "vwSccMora", strFiltroCargaInicia))
            End If

            If dtND.Rows.Count > 0 Then

                '-- Mostrar los datos en el Grid
                dtND.PrimaryKey = New DataColumn() {dtND.Columns("SccMoraID")}
                Me.dtND.DefaultView.Sort = "SccMoraID"

                Me.grdND.DataSource = dtND
                Me.grdND.Text = "Moras (" & dtND.Rows.Count & ")"


                If Me.grdNDTabla.RowCount > 0 Then

                    Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                    FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        IDND = Me.dtND.DefaultView.Item(FilaActual)("SccMoraID")
                        EstadoND = Me.dtND.DefaultView.Item(FilaActual)("objEstadoID")
                    End If
                    Me.tsbModificarND.Enabled = True
                    '-- Habilitar Opciones
                    'If blnModificarND And EstadoND = EstadoRegistrada Then
                    '    Me.tsbModificarND.Enabled = True
                    'Else
                    '    Me.tsbModificarND.Enabled = False
                    'End If

                    If blnImprimirND And EstadoND = EstadoAutorizada Then
                        Me.tsbImprimirND.Enabled = True
                    Else
                        Me.tsbImprimirND.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region




#Region "Eventos del Toolbar"

    '-----------------------------------------------------------------------

    ''----------------------------------------------------------------------
    '-- Descripcion         :   Agregar una Nota de Debito
    '-----------------------------------------------------------------------------------
    Private Sub tsbAgregarND_Click(ByVal stender As System.Object, ByVal e As System.EventArgs)
        Dim objfrm As frmSccEditMora
        '' Dim strRecibo As String = ""
        ''Dim ReciboID As Integer
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditMora
            objfrm.TypeGui = 0
            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarMoraPendiente()
                Me.dtND.DefaultView.Find(objfrm.IDNotaDebito)
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'Me.IDND = objfrm.TipoNDID
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            Else
                'strRecibo = objfrm.strRecibo
                'ReciboID = objfrm.ReciboID
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''  LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
            ''-- Liberar Recibo
            'If Not strRecibo = "" And Not ReciboID = 0 Then
            '    If strRecibo = "Colector" Then
            '        LiberarRegistro("SccReciboColector", ReciboID)
            '    ElseIf strRecibo = "Caja" Then
            '        LiberarRegistro("SccReciboCaja", ReciboID)
            '    End If
            'End If
        End Try
    End Sub

    Private Sub tsbModificarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbModificarND.Click
        Try
            If dtND.DefaultView.Count > 0 Then ''And blnModificarND And EstadoND = EstadoRegistrada Then
                ''objND.Retrieve(Me.IDND)
                ''If Not objND.Reservado Then
                ModificarND()
                'Else
                '    MsgBox(My.Resources.MsgReservado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                'End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
   
    Private Sub ModificarND()
        Dim objfrm As frmSccEditMora
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSccEditMora
            objfrm.IDNotaDebito = IDND
            objfrm.TypeGui = 2
            '-- Reservar Registro
            ''  ReservarRegistro("SccNotaDebito", Me.IDND)

            If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarMoraPendiente()
                Me.dtND.DefaultView.Find(objfrm.IDNotaDebito)

                MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            ''   LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
   
    '-----------------------------------------------------------------------------------
    Private Sub tsbAnularND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If dtND.DefaultView.Count > 0 And blnAnularND And EstadoND = EstadoRegistrada Then
                AnularND()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AnularND()
        Dim T As New TransactionManager
        Dim IDTemp As Integer = 0
        Try
            Select Case MsgBox("¿Seguro que desea anular la nota de débito?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    Me.Cursor = Cursors.WaitCursor
                    MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            '-- Liberar Registro
            '' LiberarRegistro("SccNotaDebito", Me.IDND)
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Consultar una Nota de Debito. 
    '-----------------------------------------------------------------------------------
    Private Sub tsbConsultarND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objfrm As New frmSccEditMora
        Try
            Me.Cursor = Cursors.WaitCursor
            If dtND.DefaultView.Count > 0 And blnConsultarND And dtND.Rows.Count > 0 Then
                objfrm.TypeGui = 2
                objfrm.IDNotaDebito = Me.IDND
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

    '-----------------------------------------------------------------------
    ''----------------------------------------------------------------------
    '-- Descripcion         :   Imprimir una Nota de Debito. 
    '--                     :   Solo para ND con Estado AUTORIZADA
    '-----------------------------------------------------------------------------------
    Private Sub tsbImprimirND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbImprimirND.Click
        Dim objfrm As frmParamImpDestinoReporte
        Dim dtRpt As DataTable
        Try
            Me.Cursor = Cursors.WaitCursor
            If blnImprimirND And EstadoND = EstadoAutorizada Then
                objfrm = New frmParamImpDestinoReporte
                dtRpt = New DataTable
                ''   strSQL = clsConsultas.ObtenerNotaDebito(" * ", "SccNotaDebitoID=" & Me.IDND)
                dtRpt = SqlHelper.ExecuteQueryDT(strSQL)

                If dtRpt.Rows.Count > 0 Then
                    '-- Rellenar con Ceros el Codigo de la Nota de Debito a Mostrar
                    dtRpt.Rows(0).Item("Codigo") = RellenarConCeros(dtRpt.Rows(0).Item("Numero"), Me.CerosRellenoND)

                    '-- Concatenar los Datos del Cliente a mostrar
                    If IsDBNull(dtRpt.Rows(0).Item("RazonSocial")) Then
                        dtRpt.Rows(0).Item("DatosClienteRpt") = dtRpt.Rows(0).Item("CodigoCliente") & "  /    /  " & dtRpt.Rows(0).Item("Cliente")
                    Else
                        dtRpt.Rows(0).Item("DatosClienteRpt") = dtRpt.Rows(0).Item("CodigoCliente") & "  /  " & dtRpt.Rows(0).Item("RazonSocial") & "  /  " & dtRpt.Rows(0).Item("Cliente")
                    End If

                    '-- Concatenar los datos de la Sucursal a mostrar
                    dtRpt.Rows(0).Item("DatosSucursalRpt") = dtRpt.Rows(0).Item("CodigoSucursal") & "  /  " & dtRpt.Rows(0).Item("Sucursal")

                    '-- Concatenar los Datos de la Direccion de la Sucursal a mostrar
                    dtRpt.Rows(0).Item("DatosDireccionRpt") = dtRpt.Rows(0).Item("Direccion") & "  /  " & dtRpt.Rows(0).Item("Municipio") & "  /  " & dtRpt.Rows(0).Item("Departamento")

                    '-- Asignar el datatable al formulario de destino del reporte
                    objfrm.dtRpt = dtRpt.Copy

                    '-- Pasar el nombre del formulario de reporte al formulario de destino del reporte
                    objfrm.rptNombre = "rptSccNotaDebito"
                    If objfrm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                        '*******************
                    End If
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '-- Descripcion         :   Refrescar el grid
    '-----------------------------------------------------------------------------------
    Private Sub tsbRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbRefrescar.Click
        Try
            blnBusqueda = False
            CargarMoraPendiente()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '-----------------------------------------------------------------------

    '-- Descripcion         :   Salir Catalogo Nota de Debito.
    '-----------------------------------------------------------------------------------
    Private Sub tsbSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

#End Region

    Private Sub cmdDeshacerNota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeshacerNota.Click
        Dim objCuentaPorCobrar As New SccCuentaPorCobrar
        Dim objCuentaDetalle As New SccCuentaPorCobrarDetalle
        Dim NotaDebito As New SccMora
        Dim T As New TransactionManager
        Dim FilaActual As Integer
        Try
            Try
                If Me.grdNDTabla.RowCount > 0 Then
                    Dim selectedRow As Integer() = grdNDTabla.GetSelectedRows()
                    FilaActual = Me.grdNDTabla.GetDataSourceRowIndex(selectedRow(0))
                    If FilaActual >= 0 Then
                        If Me.dtND.DefaultView.Item(FilaActual)("Estado") = "Autorizada" Then
                            T.BeginTran()
                            NotaDebito.Retrieve(Me.dtND.DefaultView.Item(FilaActual)("SccMoraID"))
                            NotaDebito.objEstadoID = EstadoAnulada
                            NotaDebito.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            NotaDebito.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            NotaDebito.Update(T)
                            T.CommitTran()
                            MsgBox(My.Resources.MsgEliminado, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                            Me.CargarMoraPendiente()
                        End If
                    End If

                End If

            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            objCuentaPorCobrar = Nothing
            objCuentaDetalle = Nothing
            NotaDebito = Nothing
        End Try

    End Sub


    Private Sub cmdMoraPagada_Click(sender As Object, e As EventArgs) Handles cmdMoraPagada.Click
        CargarMoraPagada()
    End Sub
End Class