Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports C1.C1Excel
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports Proyecto.Catalogos.Datos

Public Class frmSContContabilizar
#Region "Declaración de Variables propias del formulario"
    Dim dtCajaGeneral, dtCajaChica, dtPrestamos As DataTable
    Dim objSeg As SsgSeguridad
    Dim bolEditar, bolConsultar, bolEliminar, bolImprimir As Boolean
    Dim intPeriodoID As Integer
    Dim dblSaldos, dblTasaCambio As Decimal
    Dim strRecibos, strRecibosCC, strcuotasCC As String
    Dim intEstadoRegistrado, intmonedacor, intTipoAsientoIngreso, intAcreeedora, intDeudora, intTipoAsientoPago As Integer
#End Region

#Region "Cargar Grid Matriculas"

    Private Sub CargarGrdCajaGeneral()
        Dim objTasaCambio As StbTasaCambioOficial
        Try
            intEstadoRegistrado = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOCHEQUE", "01")
            intmonedacor = ClsCatalogos.ObtenerIDSTbCatalogo("MONEDA", "COR")
            intTipoAsientoIngreso = ClsCatalogos.ObtenerIDSTbCatalogo("TIPOASIENTO", "03")
            intTipoAsientoPago = ClsCatalogos.ObtenerIDSTbCatalogo("TIPOASIENTO", "02")

            intAcreeedora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "01")
            intDeudora = ClsCatalogos.ObtenerIDSTbCatalogo("NATURALEZA", "02")

            objTasaCambio = New StbTasaCambioOficial
            objTasaCambio.RetrieveByFilter("Anio=" & clsProyecto.Conexion.FechaServidor.Year.ToString & " and Mes =" & clsProyecto.Conexion.FechaServidor.Month.ToString & " and Dia=" & clsProyecto.Conexion.FechaServidor.Day.ToString)
            dblTasaCambio = objTasaCambio.Monto

            Me.dtCajaGeneral = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccArqueoReciboID, Contabilizado, NumRecibo, Alumno, Caja, TipoPago, Concepto, TotalCordobas, Fecha, objConceptoID, Mes", "vwRecibosContabilizarCajaGeneral", "Contabilizado=0"))
            Me.dtCajaGeneral.DefaultView.Sort = "SccArqueoReciboID desc"
            Me.grdCajaGeneral.DataSource = dtCajaGeneral

            Me.dtCajaChica = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("CentroCosto, Descripcion, SccSalidasCajaChicaID, CajaChica, Fecha, Disponible, Cajero, SccCajaChicaID, Monto, Concepto, Moneda, Estado, objEstadoID, objConceptoID, Generado, TotalCordobas, Mes", "vwSccCajaChica", " objEstadoID= 21045 AND Generado=0"))
            Me.dtCajaChica.DefaultView.Sort = "SccSalidasCajaChicaID desc"
            Me.grdCajaChica.DataSource = dtCajaChica

            Me.dtPrestamos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SccCuentaID, SccArqueoReciboID, Contabilizado, NumRecibo, Empleado, FormaPago, TotalCordobas, Fecha, Mes, NumPrestamo", "vwScontGenerarComprobantePrestamos", "1=1"))
            Me.dtPrestamos.DefaultView.Sort = "Fecha desc"
            Me.grdPrestamos.DataSource = dtPrestamos

            'If Me.dtMatriculas.DefaultView.Count = 0 objPeriodoID
            '    Me.cmdEditar.Enabled = False
            '    Me.cmdConsultar.Enabled = False
            '    Me.cmdInactivar.Enabled = False
            '    Me.cmdImprimir.Enabled = False
            'Else
            'If Me.bolEditar Then Me.cmdEditar.Enabled = True
            'If Me.bolConsultar Then Me.cmdConsultar.Enabled = True
            'If Me.bolEliminar Then Me.cmdInactivar.Enabled = True
            'If Me.bolImprimir Then Me.cmdImprimir.Enabled = True
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seguridad"
    Private Sub Seguridad()
        Try

            objSeg = New SsgSeguridad

            objSeg.ServicioUsuario = "frmSraAsignarGrupos"
            objSeg.Usuario = clsProyecto.Conexion.Usuario

            If Not objSeg.TienePermiso("AsignarGrupo") Then
                Me.cmdAsignarGrupo.Enabled = False
            End If

            If Not objSeg.TienePermiso("CambiarGrupo") Then
                Me.cmdBuscar.Enabled = False
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar"
    Private Sub Agregar()
        Dim objPersonas As frmSraMatriculaEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmSraMatriculaEdit
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarGrdCajaGeneral()
                'Seguridad()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Editar"
    Private Sub SeleccionarSaldos()

        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            dblSaldos = 0
            strRecibos = String.Empty

            For I = 0 To grdCajaGeneralTabla.SelectedRowsCount() - 1
                If (grdCajaGeneralTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdCajaGeneralTabla.GetDataRow(grdCajaGeneralTabla.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)
                dblSaldos = dblSaldos + Decimal.Parse(drFilaSeleccioanadas("TotalCordobas"))

                If strRecibos.Trim.Length > 0 Then
                    strRecibos = strRecibos + ", " + (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                Else
                    strRecibos = (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                End If
            Next



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function GeneraraNumero(t As TransactionManager) As String
        Dim strNum As String
        Dim dtNum As New DataTable
        Dim dtValParam As New DataTable
        Dim intNCeros As Integer
        Dim intNumero As Integer
        strNum = ""
        Try

            dtValParam = StbParametro.RetrieveDT("Nombre = 'CerosRellenoNumAsiento'", , "Valor", t)
            If dtValParam.DefaultView.Count > 0 Then
                intNCeros = dtValParam.DefaultView.Item(0)("Valor")
            End If

            dtNum = StbParametro.RetrieveDT("Nombre = 'ConsecutivoNumAsiento'", , "Valor", t)

            If dtNum.DefaultView.Count > 0 Then
                intNumero = dtNum.DefaultView.Item(0)("Valor")
            End If

            If intNumero = 0 Then
                For Cant As Integer = 1 To intNCeros - 1
                    strNum = strNum + "0"
                Next
                strNum = strNum + "1"
            Else
                intNumero = intNumero + 1
                intNCeros = intNCeros - intNumero.ToString.Length
                For Cant As Integer = 1 To intNCeros
                    strNum = strNum + "0"
                Next
                strNum = strNum + intNumero.ToString
            End If
            Return strNum
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            dtNum = Nothing
            dtValParam = Nothing
        End Try
        Return strNum
    End Function

    Private Sub GenerarComprobantePrestamos(intPeriodo As Integer)
        Dim objScontComprobante As ScontComprobanteID
        Dim objSContComprobanteDetalle As SContComprobanteDetalle
        Dim objNaturaleza As SContCuentasContables
        Dim T As New DAL.TransactionManager
        Dim strNumcheque As String
        Dim intCuenta, intContraCuenta, intCentroCosto As Integer
        Dim idComprobante As Integer
        Dim objComprobantegenerado As SccArqueoRecibo
        Dim objComprobantegeneradoCuotas As SccCuotasAplicadas
        Dim dtcont As New DataTable
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            dblSaldos = 0
            strRecibos = String.Empty
            strRecibosCC = String.Empty
            strcuotasCC = String.Empty
            Dim strConcepto = String.Empty

            For I = 0 To grdCajaChicaTabla.SelectedRowsCount() - 1
                If (grdCajaChicaTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdCajaChicaTabla.GetDataRow(grdCajaChicaTabla.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)

                '' Verificar si seleccionaron cuentas diferentes
                If strConcepto.Trim.Length <> 0 Then
                    If strConcepto <> drFilaSeleccioanadas("SccCuentaID").ToString Then
                        MsgBox("Debe seleccionar registros del mismo expediente y/o prestamo.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    Else
                        strConcepto = drFilaSeleccioanadas("SccCuentaID").ToString
                    End If
                Else
                    strConcepto = drFilaSeleccioanadas("SccCuentaID").ToString

                End If
            Next


            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)
                dblSaldos = dblSaldos + Decimal.Parse(drFilaSeleccioanadas("TotalCordobas"))

                If drFilaSeleccioanadas("SccArqueoReciboID").ToString <> "0" Then
                    If strRecibosCC.Trim.Length > 0 Then

                        strRecibosCC = strRecibosCC + ", " + (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                    Else
                        strRecibosCC = (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                    End If
                Else
                    If strcuotasCC.Trim.Length > 0 Then

                        strcuotasCC = strcuotasCC + ", " + (drFilaSeleccioanadas("SccAplicadoID").ToString)
                    Else
                        strcuotasCC = (drFilaSeleccioanadas("SccAplicadoID").ToString)
                    End If
                End If
            Next

            objScontComprobante = New ScontComprobanteID

            T.BeginTran()

            strNumcheque = GeneraraNumero(T)

            objScontComprobante.Fecha = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Concepto = strConcepto
            objScontComprobante.NumAsiento = strNumcheque
            objScontComprobante.objTipoAsientoID = intTipoAsientoPago
            objScontComprobante.objEstadoID = intEstadoRegistrado
            objScontComprobante.objPeriodoID = intPeriodo
            objScontComprobante.Observaciones = strConcepto
            objScontComprobante.objMonedaID = intmonedacor
            objScontComprobante.TasaCambio = dblTasaCambio
            objScontComprobante.ValorCordobas = dblSaldos
            objScontComprobante.ValorDolares = dblSaldos / dblTasaCambio
            objScontComprobante.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objScontComprobante.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Insert(T)
            idComprobante = objScontComprobante.ScontComprobanteID
            ''Cuenta principal
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intCuenta
            objSContComprobanteDetalle.MontoAcreditar = 0
            objSContComprobanteDetalle.MontoDebitar = dblSaldos

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)

            ''Contra cuenta
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intContraCuenta
            objSContComprobanteDetalle.MontoAcreditar = dblSaldos
            objSContComprobanteDetalle.MontoDebitar = 0

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intContraCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)

            ''Actualizar Comprobante generado
            dtcont = SccArqueoRecibo.RetrieveDT("SccArqueoReciboID IN (" + strRecibosCC + ")")

            For Each dr As DataRow In dtcont.Rows
                objComprobantegenerado = New SccArqueoRecibo
                objComprobantegenerado.Retrieve(CInt(dr("SccArqueoReciboID")))
                objComprobantegenerado.Contabilizado = 1
                objComprobantegenerado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objComprobantegenerado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objComprobantegenerado.Update(T)
            Next

            dtcont = New DataTable
            dtcont = SccCuotasAplicadas.RetrieveDT("SccAplicadoID IN (" + strcuotasCC + ")")

            For Each dr As DataRow In dtcont.Rows
                objComprobantegeneradoCuotas = New SccCuotasAplicadas
                objComprobantegeneradoCuotas.Retrieve(CInt(dr("SccAplicadoID")))
                objComprobantegeneradoCuotas.ComprobanteGenerado = 1
                objComprobantegeneradoCuotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objComprobantegeneradoCuotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objComprobantegeneradoCuotas.Update(T)

            Next

            T.CommitTran()
            MsgBox("Comprobante generado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            CargarGrdCajaGeneral()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteCajaChica(intPeriodo As Integer)
        Dim objScontComprobante As ScontComprobanteID
        Dim objSContComprobanteDetalle As SContComprobanteDetalle
        Dim objNaturaleza As SContCuentasContables
        Dim T As New DAL.TransactionManager
        Dim strNumcheque As String
        Dim intCuenta, intContraCuenta, intCentroCosto As Integer
        Dim idComprobante As Integer
        Dim objComprobantegenerado As SccSalidasCajaChica
        Dim dtcont As New DataTable
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            dblSaldos = 0
            strRecibos = String.Empty
            strRecibosCC = String.Empty
            Dim strConcepto = String.Empty

            For I = 0 To grdCajaChicaTabla.SelectedRowsCount() - 1
                If (grdCajaChicaTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdCajaChicaTabla.GetDataRow(grdCajaChicaTabla.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)

                '' Verificar si seleccionaron conceptos diferentes
                If strConcepto.Trim.Length <> 0 Then
                    If strConcepto <> drFilaSeleccioanadas("Concepto").ToString Then
                        MsgBox("Debe seleccionar registros con el mismo concepto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    Else
                        strConcepto = drFilaSeleccioanadas("Concepto").ToString
                    End If
                Else
                    strConcepto = drFilaSeleccioanadas("Concepto").ToString

                End If
            Next

            'Verificar que el concepto seleccionado tenga relacionado cuentas contables
            Dim drFilaSeleccioanadaConcepto As DataRow = CType(Rows(0), DataRow)
            Dim objConcepto As Integer
            Dim objConceptoCuenta As New SContConceptosCuentas

            objConcepto = CInt(drFilaSeleccioanadaConcepto("objConceptoID").ToString)
            strConcepto = drFilaSeleccioanadaConcepto("Concepto").ToString

            objConceptoCuenta.RetrieveByFilter("Activa=1 AND objConceptoID=" & objConcepto)

            If objConceptoCuenta.SContConceptosCuentasID = 0 Then
                MsgBox("El concepto seleccionado no tiene asociado ninguna cuenta contable.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            Else
                intCuenta = objConceptoCuenta.objCuentaContableID
                intContraCuenta = objConceptoCuenta.objContraCuentaID
                intCentroCosto = objConceptoCuenta.objCentroCostoID

            End If

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)
                dblSaldos = dblSaldos + Decimal.Parse(drFilaSeleccioanadas("TotalCordobas"))

                If strRecibosCC.Trim.Length > 0 Then
                    strRecibosCC = strRecibosCC + ", " + (drFilaSeleccioanadas("SccSalidasCajaChicaID").ToString)
                Else
                    strRecibosCC = (drFilaSeleccioanadas("SccSalidasCajaChicaID").ToString)
                End If

            Next

            objScontComprobante = New ScontComprobanteID

            T.BeginTran()

            strNumcheque = GeneraraNumero(T)

            objScontComprobante.Fecha = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Concepto = strConcepto
            objScontComprobante.NumAsiento = strNumcheque
            objScontComprobante.objTipoAsientoID = intTipoAsientoPago
            objScontComprobante.objEstadoID = intEstadoRegistrado
            objScontComprobante.objPeriodoID = intPeriodo
            objScontComprobante.Observaciones = strConcepto
            objScontComprobante.objMonedaID = intmonedacor
            objScontComprobante.TasaCambio = dblTasaCambio
            objScontComprobante.ValorCordobas = dblSaldos
            objScontComprobante.ValorDolares = dblSaldos / dblTasaCambio
            objScontComprobante.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objScontComprobante.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Insert(T)
            idComprobante = objScontComprobante.ScontComprobanteID
            ''Cuenta principal
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intCuenta
            objSContComprobanteDetalle.MontoAcreditar = 0
            objSContComprobanteDetalle.MontoDebitar = dblSaldos

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)

            ''Contra cuenta
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intContraCuenta
            objSContComprobanteDetalle.MontoAcreditar = dblSaldos
            objSContComprobanteDetalle.MontoDebitar = 0

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intContraCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)

            ''Actualizar Comprobante generado
            dtcont = SccSalidasCajaChica.RetrieveDT("SccSalidasCajaChicaID IN (" + strRecibosCC + ")")

            For Each dr As DataRow In dtcont.Rows
                objComprobantegenerado = New SccSalidasCajaChica
                objComprobantegenerado.Retrieve(CInt(dr("SccSalidasCajaChicaID")))
                objComprobantegenerado.Generado = 1
                objComprobantegenerado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objComprobantegenerado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objComprobantegenerado.Update(T)
            Next

            T.CommitTran()
            MsgBox("Comprobante generado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            CargarGrdCajaGeneral()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GenerarComprobanteCajaGeneral(intPeriodo As Integer)
        Dim objScontComprobante As ScontComprobanteID
        Dim objSContComprobanteDetalle As SContComprobanteDetalle
        Dim objNaturaleza As SContCuentasContables
        Dim T As New DAL.TransactionManager
        Dim strNumcheque As String
        Dim intCuenta, intContraCuenta, intCentroCosto As Integer
        Dim idComprobante As Integer
        Dim objComprobanteGenerado As SccArqueoRecibo
        Dim dtcont As New DataTable
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            dblSaldos = 0
            strRecibos = String.Empty
            Dim strConcepto = String.Empty

            For I = 0 To grdCajaGeneralTabla.SelectedRowsCount() - 1
                If (grdCajaGeneralTabla.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdCajaGeneralTabla.GetDataRow(grdCajaGeneralTabla.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)

                '' Verificar si seleccionaron conceptos diferentes
                If strConcepto.Trim.Length <> 0 Then
                    If strConcepto <> drFilaSeleccioanadas("Concepto").ToString Then
                        MsgBox("Debe seleccionar registros con el mismo concepto.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Exit Sub
                    Else
                        strConcepto = drFilaSeleccioanadas("Concepto").ToString
                    End If
                Else
                    strConcepto = drFilaSeleccioanadas("Concepto").ToString
                End If
            Next

            'Verificar que el concepto seleccionado tenga relacionado cuentas contables
            Dim drFilaSeleccioanadaConcepto As DataRow = CType(Rows(0), DataRow)
            Dim objConcepto As Integer
            Dim objConceptoCuenta As New SContConceptosCuentas

            objConcepto = CInt(drFilaSeleccioanadaConcepto("objConceptoID").ToString)
            strConcepto = drFilaSeleccioanadaConcepto("Concepto").ToString

            objConceptoCuenta.RetrieveByFilter("Activa=1 AND objConceptoID=" & objConcepto)

            If objConceptoCuenta.SContConceptosCuentasID = 0 Then
                MsgBox("El concepto seleccionado no tiene asociado ninguna cuenta contable.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            Else
                intCuenta = objConceptoCuenta.objCuentaContableID
                intContraCuenta = objConceptoCuenta.objContraCuentaID
                intCentroCosto = objConceptoCuenta.objCentroCostoID

            End If

            For I = 0 To Rows.Count - 1
                Dim drFilaSeleccioanadas As DataRow = CType(Rows(I), DataRow)
                dblSaldos = dblSaldos + Decimal.Parse(drFilaSeleccioanadas("TotalCordobas"))

                If strRecibos.Trim.Length > 0 Then
                    strRecibos = strRecibos + ", " + (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                Else
                    strRecibos = (drFilaSeleccioanadas("SccArqueoReciboID").ToString)
                End If

            Next

            objScontComprobante = New ScontComprobanteID

            T.BeginTran()

            strNumcheque = GeneraraNumero(T)

            objScontComprobante.Fecha = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Concepto = strConcepto
            objScontComprobante.NumAsiento = strNumcheque
            objScontComprobante.objTipoAsientoID = intTipoAsientoIngreso
            objScontComprobante.objEstadoID = intEstadoRegistrado
            objScontComprobante.objPeriodoID = intPeriodo
            objScontComprobante.Observaciones = strConcepto
            objScontComprobante.objMonedaID = intmonedacor
            objScontComprobante.TasaCambio = dblTasaCambio
            objScontComprobante.ValorCordobas = dblSaldos
            objScontComprobante.ValorDolares = dblSaldos / dblTasaCambio
            objScontComprobante.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objScontComprobante.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objScontComprobante.Insert(T)
            idComprobante = objScontComprobante.ScontComprobanteID
            ''Cuenta principal
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intCuenta
            objSContComprobanteDetalle.MontoDebitar = 0
            objSContComprobanteDetalle.MontoAcreditar = dblSaldos

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)

            ''Contra cuenta
            objSContComprobanteDetalle = New SContComprobanteDetalle

            objSContComprobanteDetalle.objSContCompronanteID = idComprobante
            objSContComprobanteDetalle.SContContablesID = intContraCuenta
            objSContComprobanteDetalle.MontoDebitar = dblSaldos
            objSContComprobanteDetalle.MontoAcreditar = 0

            ''Buscar la naturaleza de la cuenta
            objNaturaleza = New SContCuentasContables
            objNaturaleza.Retrieve(intContraCuenta, T)

            If objNaturaleza.objNaturalezaID = intDeudora Then
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoDebitar - objSContComprobanteDetalle.MontoAcreditar
            Else
                objSContComprobanteDetalle.Saldo = objSContComprobanteDetalle.MontoAcreditar - objSContComprobanteDetalle.MontoDebitar
            End If
            objSContComprobanteDetalle.objCentroCostoID = intCentroCosto

            objSContComprobanteDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objSContComprobanteDetalle.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objSContComprobanteDetalle.Insert(T)


            ''Actualizar consecutivo
            Dim objParametro = New StbParametro
            objParametro.RetrieveByFilter("Nombre='ConsecutivoNumAsiento'", T)
            objParametro.Valor = CInt(strNumcheque)
            objParametro.Update(T)

            ''Actualizar contabilizar
            dtcont = SccArqueoRecibo.RetrieveDT("SccArqueoReciboID IN (" + strRecibos + ")")

            For Each dr As DataRow In dtcont.Rows
                objComprobanteGenerado = New SccArqueoRecibo
                objComprobanteGenerado.Retrieve(CInt(dr("SccArqueoReciboID")))
                objComprobanteGenerado.Contabilizado = 1
                objComprobanteGenerado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objComprobanteGenerado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objComprobanteGenerado.Update(T)
            Next

            T.CommitTran()
            MsgBox("Comprobante generado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            CargarGrdCajaGeneral()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region



#Region "Evento LOAD del Form"

    Private Sub frmSccClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = WaitCursor
            CargarGrdCajaGeneral()
            Me.Seguridad()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Otros eventos"

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.dtCajaGeneral = Nothing
        objSeg = Nothing
        bolEditar = Nothing
        bolConsultar = Nothing
        bolEliminar = Nothing
        bolImprimir = Nothing
        Me.Close()
    End Sub

    Private Sub cmdRefrescar_Click(sender As Object, e As EventArgs) Handles cmdRefrescar.Click
        Me.CargarGrdCajaGeneral()

    End Sub



#End Region


    Private Sub cmdAsignarGrupo_Click(sender As Object, e As EventArgs) Handles cmdAsignarGrupo.Click

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

                    If TabControlGrupos.SelectedTabPage.Name = "XtraTabPageCajaChica" Then
                        If grdCajaChicaTabla.SelectedRowsCount() > 0 Then
                            GenerarComprobanteCajaChica(intPeriodo)
                        End If
                    ElseIf TabControlGrupos.SelectedTabPage.Name = "XtraTabPageCajaGeneral" Then

                        If grdCajaGeneralTabla.SelectedRowsCount() > 0 Then
                            GenerarComprobanteCajaGeneral(intPeriodo)
                        End If
                    ElseIf TabControlGrupos.SelectedTabPage.Name = "XtraTabPagePrestamos" Then

                        If grdPrestamosTabla.SelectedRowsCount() > 0 Then
                            GenerarComprobantePrestamos(intPeriodo)
                        End If

                    End If


                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try


    End Sub




End Class