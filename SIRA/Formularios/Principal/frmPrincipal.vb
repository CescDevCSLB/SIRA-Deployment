Imports DAL
Imports Proyecto.Configuracion
Imports Seguridad.Datos
Imports Seguridad.Formularios
Imports Proyecto.Catalogos.Formularios
Imports System.ComponentModel
Imports SIRA.BO 'Uso de clsConsultas
Imports Proyecto.Catalogos
Imports System.Globalization
Imports System.Threading


Public Class frmPrincipal

    Public Shared glbGerencia As Boolean = False
    Public Shared glbObjTiendaSessionId As Integer
    Public Shared glbEstadoFacturaRegistrada As Integer
    Public Shared glbVentanaSolicDescuentoAbierta As Boolean
    Public Shared glbVentanaSolicRepuestoAbierta As Boolean
    Public Shared glbObjTiendaCentralID As Integer
    Public Shared glbPeriodoSeleccionado As Integer
    Public Shared glbParcialSeleccionado As Integer
    Public Shared glbGrupoSeleccionado As Integer
    Public Shared glbProfesor As Integer
    Public Shared glbTodasEvidencias As Boolean
    Public Shared gblCaja As String
    Public Shared gblCajaChica As String
    Public Shared glbModalidad As Integer

#Region "Declaracion de Variables Locales y Objetos"
    Dim BkColor As System.Drawing.Color
    Dim clsAppConfig As clsAppconfiguration
    Dim ImagenFondo As System.Drawing.Image = Nothing
#End Region

#Region "Eventos del Formulario"

    ''' <summary>
    ''' Cargar el Formulario Principal
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FnOcultarNavBarPrincipal()
        Try
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-sv")
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("es-sv")

            Me.InicializarPropiedades()
            Me.IniciarSesion()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Public Sub FnOcultarNavBarPrincipal()
        NavBarPrincipal.Visible = False
    End Sub
    Public Sub FnVisibleNavBarPrincipal()
        NavBarPrincipal.Visible = True
    End Sub

#End Region

#Region "Metodos de Configuración"
    ''' <summary>
    ''' Este metodo tiene como objetivo inicializar las propiedades con que 
    ''' se conecto el sistema
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub InicializarPropiedades()
        Try
            Dim info As ConnectionInfo = SqlHelper.GetConnectionInfo()
            Me.clsAppConfig = New clsAppconfiguration
            Me.BkColor = New System.Drawing.Color

            'clsProyecto.SiglasSistema = Me.clsAppConfig.Getkey("NombreSistema")
            'clsProyecto.Sucursal = Me.clsAppConfig.Getkey("Bodega")
            gblCaja = Me.clsAppConfig.Getkey("Caja")
            gblCajaChica = Me.clsAppConfig.Getkey("CajaChica")
            cmdSeguridad.Visible = False

            clsProyecto.RESOURCE_PATH = Application.StartupPath
            clsProyecto.Conexion.BaseDeDatos = info.DatabaseName
            clsProyecto.Conexion.Servidor = info.ServerName
            clsProyecto.blnAplicarSeguridad = True
            Me.Text = clsProyecto.SiglasSistema
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Se configura el estatus bar con todos los valores de coneccion
    ''' que fueron alimentados con el metodo de inicializacion
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CagarInformacionConeccion()
        Try
            'Me.lblBaseDatos.Text = " Base de Datos : " & clsProyecto.Conexion.BaseDeDatos
            'Me.lblServidor.Text = " Servidor : " & clsProyecto.Conexion.Servidor
            Me.lblUsuario1.Text = " Usuario : " & clsProyecto.Conexion.Usuario
            Me.lblFecha.Text = " Fecha : " + clsProyecto.Conexion.FechaServidor.ToShortDateString()
            Me.lblHora.Text = " Hora : " + clsProyecto.Conexion.FechaServidor.ToShortTimeString

            Me.tmrPrincipal.Start()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub tmrPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPrincipal.Tick
        Try
            Me.lblHora.Text = " Hora : " + DateTime.Now.ToShortTimeString
            Me.ClearMemory()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Apariencia"

    Private Sub ConfigMdiChild()
        Try
            For Each ChildForm As Form In Me.MdiChildren
                clsProyecto.CargarTemaDefinido(ChildForm)
            Next
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seguridad"

    Private Sub cmdSeguridad_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSeguridad.Click
        Dim objfrm As frmSsgPrincipalSeguridad
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSsgPrincipalSeguridad
            objfrm.Show()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdIniciarSesion_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdIniciarSesion.Click
        Me.IniciarSesion()
    End Sub

    Private Sub cmdCerrarSesion_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCerrarSesion.Click
        Try
            If Me.MdiChildren.Length > 0 Then
                Select Case MsgBox("Todas las ventanas activas se cerrarán. ¿Desea cerrar sesión?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                    Case MsgBoxResult.Yes
                        '--- Cerrar todos los formulario hijos
                        For Each ChildForm As Form In Me.MdiChildren
                            ChildForm.Close()
                            'FnOcultarNavBarPrincipal()
                        Next
                        ''Me.DeshabilitarOpciones(False)
                        '-----
                        System.Windows.Forms.Application.Restart()
                        'FnOcultarNavBarPrincipal()
                        'Me.lblUsuario.Text = ""
                        'Me.cmdCerrarSesion.Enabled = False
                        'Me.cmdIniciarSesion.Enabled = True
                        '-----
                    Case MsgBoxResult.No
                End Select
            Else
                System.Windows.Forms.Application.Restart()
                'Me.DeshabilitarOpciones(False)
                '-----
                'clsProyecto.Conexion.Usuario = ""
                'Me.lblUsuario.Text = ""
                'Me.cmdCerrarSesion.Enabled = False
                'Me.cmdIniciarSesion.Enabled = True
                '-----              
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub IniciarSesion()
        Dim objfrm As LoginForm
        Try
            objfrm = New LoginForm
            objfrm.BackColor = Me.BkColor
            If objfrm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not objfrm.EstaVigente Then
                    MsgBox("Su cuenta ha expirado. Consulte con su administrador", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                End If
                If Not objfrm.Activa Then
                    MsgBox("Su cuenta ha sido inactivada. Consulte con su administrador", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    Me.Close()
                End If

                Me.CagarInformacionConeccion()
                Me.AplicarSeguridad()
                Me.BackgroundImageLayout = ImageLayout.Zoom
                Me.cmdCerrarSesion.Enabled = True
                Me.cmdIniciarSesion.Enabled = False
                '-----
            Else
                'Me.DeshabilitarOpciones(False)
                ''-----
                Me.cmdCerrarSesion.Enabled = False
                Me.cmdIniciarSesion.Enabled = True
                '-----
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub AplicarSeguridad()
        Dim objSeg As SsgSeguridad
        Dim optConfiguraciones As Integer = 0
        Dim optRegistro As Integer = 0
        Dim optCatalogos As Integer = 0
        Dim optCartera As Integer = 0
        Dim optCaja As Integer = 0
        Dim optContabilidad As Integer = 0
        Try
            objSeg = New SsgSeguridad
            objSeg.Usuario = clsProyecto.Conexion.Usuario
            objSeg.ServicioUsuario = "frmPrincipal"

            'Me.DeshabilitarOpciones(True)

            '----- Opcion Seguridad
            Me.cmdSeguridad.Enabled = objSeg.TienePermiso("OpcionSeguridad")

#Region "Opcion Configuraciones"
            '----- Opcion Configuraciones
            FnVisibleNavBarPrincipal()
            If objSeg.TienePermiso("MantCatalogos") Then
                Me.navBarCatalogos.Visible = True
                'optConfiguraciones = optConfiguraciones + 1
            Else
                Me.navBarCatalogos.Visible = False
            End If

            If objSeg.TienePermiso("OpcionParametros") Then
                Me.NavBarParametros.Visible = True
                optConfiguraciones = optConfiguraciones + 1
            Else
                Me.NavBarParametros.Visible = False
            End If

            If optConfiguraciones = 0 Then
                grpConfiguraciones.Visible = False
            End If
#End Region

#Region "Opcion catalogos"
            'Catálogos
            If objSeg.TienePermiso("OpcionAsignaturas") Then
                Me.NavBarAsignaturas.Visible = True
                optCatalogos += 1
            Else
                Me.NavBarAsignaturas.Visible = False
            End If

            If objSeg.TienePermiso("OpcionPeriodo") Then
                Me.NavBarPeriodo.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarPeriodo.Visible = False
            End If

            If objSeg.TienePermiso("OpcionBeca") Then
                Me.NavBarBecas.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarBecas.Visible = False
            End If

            If objSeg.TienePermiso("OpcionNotasCualitativas") Then
                Me.NavBarNotaCualitativa.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarNotaCualitativa.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEvidenciasAprendizaje") Then
                Me.NavBarEvidencias.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarEvidencias.Visible = False
            End If

            If objSeg.TienePermiso("OpcionAranceles") Then
                Me.NavBarAranceles.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarAranceles.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEmpleados") Then
                Me.NavBarEmpleados.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarEmpleados.Visible = False
            End If

            If objSeg.TienePermiso("OpcionNotasBoletin") Then
                Me.NavBarNotas.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarNotas.Visible = False
            End If

            If objSeg.TienePermiso("OpcionGrado") Then
                Me.NavBarActivarParcial.Visible = True
                optCatalogos = optCatalogos + 1
            Else
                Me.NavBarActivarParcial.Visible = False
            End If

            If optCatalogos = 0 Then
                grpCatalogos.Visible = False
            End If
#End Region

#Region "Opcion registro academico"
            'Rendimiento academico
            If objSeg.TienePermiso("OpcionAlumnos") Then
                Me.NavBarAlumnos.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarAlumnos.Visible = False
            End If
            If objSeg.TienePermiso("OpcionGrado") Then
                Me.NavBarGrado.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarGrado.Visible = False
            End If

            If objSeg.TienePermiso("OpcionProfesores") Then
                Me.NavBarProfesor.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarProfesor.Visible = False
            End If

            If objSeg.TienePermiso("OpcionGrupo") Then
                Me.NavGrupo.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavGrupo.Visible = False
            End If

            If objSeg.TienePermiso("OpcionMatricula") Then
                Me.NavBarMatricula.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarMatricula.Visible = False
            End If

            If objSeg.TienePermiso("OpcionAsignarGrupo") Then
                Me.NavBarListaGrupos.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarListaGrupos.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEvaluacion") Then
                Me.NavBarEvaluacion.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarEvaluacion.Visible = False
            End If

            '-- Reportes
            If objSeg.TienePermiso("OpcionCalificaciones") Then
                Me.NavBarCalificaciones.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarCalificaciones.Visible = False
            End If

            If objSeg.TienePermiso("OpcionNotasBoletin") Then
                optRegistro = optRegistro + 1
                Me.NavBarNotasParametro.Visible = True
            Else
                Me.NavBarNotasParametro.Visible = False
            End If

            If objSeg.TienePermiso("OpcionRendimiento") Then
                Me.NavBarRendimiento.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarRendimiento.Visible = False
            End If

            If objSeg.TienePermiso("OpcionRendimientoAsignaturas") Then
                Me.NavBarRendimientoAsig.Visible = True
                optRegistro = optRegistro + 1
            Else
                Me.NavBarRendimientoAsig.Visible = False
            End If

            If objSeg.TienePermiso("OpcionExcelencia") Then
                optRegistro = optRegistro + 3
                Me.NavBarExcelencia.Visible = True
                Me.NavBarRptAlumnos.Visible = True
                Me.NavBarConsolidado.Visible = True
            Else
                Me.NavBarExcelencia.Visible = True
                Me.NavBarRptAlumnos.Visible = True
                Me.NavBarConsolidado.Visible = True
            End If

            If optRegistro = 0 Then
                grpRegistroAcademico.Visible = False
            End If


#End Region

#Region "Cartera y cobro"
            'Cartera y Cobro
            If objSeg.TienePermiso("OpcionExpediente") Then
                Me.NavBarCuentas.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarCuentas.Visible = False
            End If
            If objSeg.TienePermiso("OpcionAplicarBeca") Then
                Me.NavBarAplicarBeca.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarAplicarBeca.Visible = False
            End If

            If objSeg.TienePermiso("OpcionMorosidad") Then
                Me.NavBarMorosidad.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarMorosidad.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEstadoCuenta") Then
                Me.NavBarImprimirEC.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarImprimirEC.Visible = False
            End If

            If objSeg.TienePermiso("OpcionReporteMora") Then
                Me.NavBarESMora.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarESMora.Visible = False
            End If
            If objSeg.TienePermiso("OpcionReporteSolventes") Then
                Me.NavBarESolventes.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarESolventes.Visible = False
            End If

            If objSeg.TienePermiso("OpcionPrestamos") Then
                Me.NavBarPrestamos.Visible = True
                Me.NavBarIDivisionEm.Visible = True
                optCartera = optCartera + 1
            Else
                Me.NavBarPrestamos.Visible = False
                Me.NavBarIDivisionEm.Visible = False
            End If

            If optCartera = 0 Then
                grpCartera.Visible = False
            End If

#End Region

#Region "Opcion Caja"
            '-- Caja
            If objSeg.TienePermiso("OpcionTasaCambio") Then
                Me.NavTasaCambio.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavTasaCambio.Visible = False
            End If

            If objSeg.TienePermiso("OpcionConfiguracionCajas") Then
                Me.NavBarConfiguracionCaja.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarConfiguracionCaja.Visible = False
            End If

            If objSeg.TienePermiso("OpcionConfiguracionCajasCH") Then
                Me.NavBarCajaChica.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarCajaChica.Visible = False
            End If

            If objSeg.TienePermiso("OpcionReciboCaja") Then
                Me.NavBarReciboCaja.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarReciboCaja.Visible = False
            End If

            If objSeg.TienePermiso("OpcionArqueoCajaGeneral") Then
                Me.NavBarArqueo.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarArqueo.Visible = False
            End If

            If objSeg.TienePermiso("OpcionArqueoCajaChica") Then
                Me.NavBarArqueoCajaCH.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarArqueoCajaCH.Visible = False
            End If

            If objSeg.TienePermiso("OpcionSalidaCajaChica") Then
                Me.NavBarSalidaCajaChica.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarSalidaCajaChica.Visible = False
            End If
            If objSeg.TienePermiso("OpcionArqueoCajaGeneral") Then
                Me.NavBarDepositos.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarDepositos.Visible = False
            End If

            If objSeg.TienePermiso("OpcionSalidaCajaChica") Then
                Me.NavBarReporteGastos.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarReporteGastos.Visible = False
            End If

            If objSeg.TienePermiso("OpcionArqueoCajaGeneral") Then
                Me.NavBarArqueoDeposito.Visible = True
                optCaja = optCaja + 1
            Else
                Me.NavBarArqueoDeposito.Visible = False
            End If

            If optCaja = 0 Then
                grpCaja.Visible = False
            End If

#End Region

#Region "Opcion contabilidad"
            'Contabilidad
            If objSeg.TienePermiso("OpcionPeriodoContable") Then
                Me.NavBarPeriodoContable.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarPeriodoContable.Visible = False
            End If

            If objSeg.TienePermiso("OpcionCentroCosto") Then
                Me.NavBarCentroCosto.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarCentroCosto.Visible = False
            End If

            If objSeg.TienePermiso("OpcionCatCuentas") Then
                optContabilidad = optContabilidad + 1
                Me.NavBarCatCuentas.Visible = True
            Else
                Me.NavBarCatCuentas.Visible = False
            End If

            If objSeg.TienePermiso("OpcionContabilizar") Then
                Me.NavBarContabilizar.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarContabilizar.Visible = False
            End If

            If objSeg.TienePermiso("OpcionComprobante") Then
                Me.NavBarComprobante.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarComprobante.Visible = False
            End If

            If objSeg.TienePermiso("OpcionCheques") Then
                Me.NavBarCheque.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarCheque.Visible = False
            End If

            If objSeg.TienePermiso("OpcionConceptosCuentas") Then
                Me.NavBarRelacionConceptos.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarRelacionConceptos.Visible = False
            End If


            If objSeg.TienePermiso("OpcionMayorizar") Then
                Me.NavBarMayorizar.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarMayorizar.Visible = False
            End If

            If objSeg.TienePermiso("OpcionMayorizar") Then
                Me.NavBarCerrarMes.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarCerrarMes.Visible = False
            End If

            If objSeg.TienePermiso("OpcionBalance") Then
                Me.NavBarBalance.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarBalance.Visible = False
            End If

            If objSeg.TienePermiso("OpcionBalance") Then
                Me.NavBarBComprobacion.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarBComprobacion.Visible = False
            End If

            If objSeg.TienePermiso("OpcionBalance") Then
                Me.NavBarAuxiliar.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarAuxiliar.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEstadoResultado") Then
                Me.NavBarEstadoResultado.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarEstadoResultado.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEstadoResultado") Then
                Me.NavBarFlujo.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarFlujo.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEstadoResultado") Then
                Me.NavBarMatriz.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarMatriz.Visible = False
            End If

            If objSeg.TienePermiso("OpcionSaldos") Then
                Me.NavBarCSaldos.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarCSaldos.Visible = False
            End If

            If objSeg.TienePermiso("OpcionEstadoResultado") Then
                Me.NavBarDepositosRpt.Visible = True
                cmdSeguridad.Visible = True
                optContabilidad = optContabilidad + 1
            Else
                Me.NavBarDepositosRpt.Visible = False
            End If

            If optContabilidad = 0 Then
                grpContabilidad.Visible = False
            End If

#End Region



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    'Private Sub DeshabilitarOpciones(blnhabilitar As Boolean)
    '    Try
    '        Me.cmdSeguridad.Enabled = False

    '        '-- Barra de Menus

    '        ''-- Barra Lateral
    '        '-- Catálogos
    '        Me.navBarCatalogos.Enabled = blnhabilitar
    '        Me.NavBarParametros.Enabled = blnhabilitar

    '        Me.NavBarAsignaturas.Enabled = blnhabilitar
    '        NavBarPeriodo.Enabled = blnhabilitar
    '        Me.NavBarBecas.Enabled = blnhabilitar
    '        Me.NavBarNotaCualitativa.Enabled = blnhabilitar
    '        Me.NavBarEvidencias.Enabled = blnhabilitar
    '        Me.NavBarEmpleados.Enabled = blnhabilitar
    '        Me.NavBarAranceles.Enabled = blnhabilitar
    '        Me.NavBarNotas.Enabled = blnhabilitar
    '        Me.NavBarNotasParametro.Enabled = blnhabilitar
    '        Me.NavBarActivarParcial.Visible = blnhabilitar

    '        '-- Registro academico
    '        Me.NavBarAlumnos.Enabled = blnhabilitar
    '        Me.NavBarGrado.Enabled = blnhabilitar
    '        Me.NavBarProfesor.Enabled = blnhabilitar
    '        Me.NavGrupo.Enabled = blnhabilitar
    '        Me.NavBarMatricula.Enabled = blnhabilitar
    '        Me.NavBarListaGrupos.Enabled = blnhabilitar
    '        Me.NavBarEvaluacion.Enabled = blnhabilitar

    '        '-- Caja
    '        Me.NavTasaCambio.Enabled = blnhabilitar
    '        Me.NavBarConfiguracionCaja.Enabled = blnhabilitar
    '        Me.NavBarReciboCaja.Enabled = blnhabilitar
    '        Me.NavBarCajaChica.Enabled = blnhabilitar
    '        Me.NavBarArqueo.Enabled = blnhabilitar
    '        Me.NavBarDepositos.Enabled = blnhabilitar
    '        Me.NavBarArqueoCajaCH.Enabled = blnhabilitar
    '        Me.NavBarSalidaCajaChica.Enabled = blnhabilitar
    '        Me.NavBarReporteGastos.Enabled = blnhabilitar
    '        Me.NavBarArqueoDeposito.Enabled = blnhabilitar

    '        '--Cuentas por cobrar
    '        Me.NavBarAplicarBeca.Enabled = blnhabilitar
    '        Me.NavBarCuentas.Enabled = blnhabilitar
    '        Me.NavBarMorosidad.Enabled = blnhabilitar
    '        Me.NavBarImprimirEC.Enabled = blnhabilitar
    '        Me.NavBarESolventes.Enabled = blnhabilitar
    '        Me.NavBarESMora.Enabled = blnhabilitar
    '        Me.NavBarPrestamos.Enabled = blnhabilitar

    '        '-- Reportes
    '        Me.NavBarCalificaciones.Enabled = blnhabilitar
    '        Me.NavBarRendimiento.Enabled = blnhabilitar
    '        Me.NavBarRendimientoAsig.Enabled = blnhabilitar
    '        Me.NavBarExcelencia.Enabled = blnhabilitar
    '        Me.NavBarConsolidado.Enabled = blnhabilitar

    '        '--Contabilidad
    '        Me.NavBarPeriodoContable.Enabled = blnhabilitar
    '        Me.NavBarCentroCosto.Enabled = blnhabilitar
    '        Me.NavBarCatCuentas.Enabled = blnhabilitar
    '        Me.NavBarContabilizar.Enabled = blnhabilitar
    '        Me.NavBarComprobante.Enabled = blnhabilitar
    '        Me.NavBarBalance.Enabled = blnhabilitar
    '        Me.NavBarBComprobacion.Enabled = blnhabilitar
    '        Me.NavBarAuxiliar.Enabled = blnhabilitar
    '        Me.NavBarDepositosRpt.Enabled = blnhabilitar
    '        Me.NavBarEstadoResultado.Enabled = blnhabilitar
    '        Me.NavBarFlujo.Enabled = blnhabilitar
    '        Me.NavBarMatriz.Enabled = blnhabilitar
    '        Me.NavBarMayorizar.Enabled = blnhabilitar
    '        Me.NavBarCerrarMes.Enabled = blnhabilitar
    '        Me.NavBarCSaldos.Enabled = blnhabilitar
    '        Me.NavBarCheque.Visible = blnhabilitar
    '        Me.NavBarRelacionConceptos.Visible = blnhabilitar

    '    Catch ex As Exception
    '        clsError.CaptarError(ex)
    '    End Try
    'End Sub

#End Region

#Region "Opciones del Menu Principal"

#Region "Catalogos Generales"

    Private Sub navBarCatalogos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles navBarCatalogos.LinkClicked
        Me.CargarCatalogoValor()
    End Sub

    Private Sub NavBarParametros_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarParametros.LinkClicked
        CargarParametros()
    End Sub

    Private Sub NavBarAsignaturas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAsignaturas.LinkClicked
        CargarAsignaturas()
    End Sub

    Private Sub NavBarBecas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarBecas.LinkClicked
        CargarBecas()
    End Sub

    Private Sub NavBarGrado_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarGrado.LinkClicked
        CargarGrados()
    End Sub

    Private Sub NavBarPeriodo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarPeriodo.LinkClicked
        CargarPeriodos()
    End Sub

    Private Sub NavGrupo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavGrupo.LinkClicked
        CargarGrupos()
    End Sub

    Private Sub NavBarProfesor_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarProfesor.LinkClicked
        CargarProfesores()
    End Sub

    Private Sub NavBarNotaCualitativa_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarNotaCualitativa.LinkClicked
        CargarNotasCualitativas()
    End Sub

    Private Sub NavBarAlumnos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAlumnos.LinkClicked
        CargarAlumnoa()
    End Sub
#End Region

#Region "Inventario"

    Private Sub NavBarOrdenCompra_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarOrdenCompra.LinkClicked

    End Sub

    Private Sub NavBarEntrada_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEntrada.LinkClicked

    End Sub

    Private Sub NavBarSalidas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSalidas.LinkClicked

    End Sub

    Private Sub NavBarSolicitud_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSolicitud.LinkClicked

    End Sub

    Private Sub NavBarDespacho_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDespacho.LinkClicked

    End Sub

    Private Sub NavBarRecepcion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRecepcion.LinkClicked

    End Sub
#End Region

#Region "Ventanas"

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

#End Region

#Region "Ayuda"
    Private Sub CargarAyuda()
        'Dim EjecutarProceso As Process
        Try
            'EjecutarProceso = New Process
            'EjecutarProceso.StartInfo.FileName = My.Application.Info.DirectoryPath & "\prjSCCUMHELP_Help"
            'EjecutarProceso.Start()

        Catch ex As Win32Exception
            Select Case ex.NativeErrorCode
                Case 2
                    MsgBox("El archivo prjSCCUMHELP_Help no existe.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Case 5
                    MsgBox("Acceso denegado al prjSCCUMHELP_Help.", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
            End Select
        End Try
    End Sub

    Private Sub tsmAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAyuda.Click
        Me.CargarAyuda()
    End Sub
#End Region

#Region "Salir"

    Private Sub tsmSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSalir.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

#End Region

#End Region

#Region "Cargar Catalogos"

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Catalogos Valor
    '----------------------------------------------------------------------------------
    Private Sub CargarCatalogoValor()
        Dim objfrm As frmStbMantCatalogo
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbMantCatalogo", Me) Then
                objfrm = New frmStbMantCatalogo
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Parametros
    '----------------------------------------------------------------------------------
    Private Sub CargarParametros()
        Dim objfrm As frmStbMantParametro
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbMantParametro", Me) Then
                objfrm = New frmStbMantParametro
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Asignaturas
    '----------------------------------------------------------------------------------
    Private Sub CargarAsignaturas()
        Dim objfrm As frmSraAsignaturas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraAsignaturas", Me) Then
                objfrm = New frmSraAsignaturas
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarEvidencias()

        Dim selectperiodo As frmSraSeleccionarPeriodoEvidencias
        Try
            selectperiodo = New frmSraSeleccionarPeriodoEvidencias
            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                glbPeriodoSeleccionado = selectperiodo.PeriodoID
                glbProfesor = selectperiodo.intProfesor
                glbTodasEvidencias = selectperiodo.blnTodos

                CargarCatalogoEvidencias()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try


    End Sub

    Private Sub CargarCatalogoEvidencias()
        Dim objfrm As frmSraEvidenciasAprendizaje
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraEvidenciasAprendizaje", Me) Then
                objfrm = New frmSraEvidenciasAprendizaje
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Becas
    '----------------------------------------------------------------------------------
    Private Sub CargarBecas()
        Dim objfrm As frmSraBecas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraBecas", Me) Then
                objfrm = New frmSraBecas
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Grados
    '----------------------------------------------------------------------------------
    Private Sub CargarGrados()
        Dim objfrm As frmSraGrado
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraGrado", Me) Then
                objfrm = New frmSraGrado
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub



    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   periodos
    '----------------------------------------------------------------------------------
    Private Sub CargarPeriodos()
        Dim objfrm As frmSraPeriodos
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraPeriodos", Me) Then
                objfrm = New frmSraPeriodos
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarPeriodosContable()
        Dim objfrm As frmSContPeriodosContable
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSContPeriodosContable", Me) Then
                objfrm = New frmSContPeriodosContable
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarCentrosCosto()
        Dim objfrm As frmSContCentroCosto
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSContCentroCosto", Me) Then
                objfrm = New frmSContCentroCosto
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   grupos
    '----------------------------------------------------------------------------------
    Private Sub CargarGrupos()
        Dim objfrm As frmSraGrupos
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraGrupos", Me) Then
                objfrm = New frmSraGrupos
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   rangos de notas cualitativas
    '----------------------------------------------------------------------------------
    Private Sub CargarNotasCualitativas()
        Dim objfrm As frmSraNotasCualitativas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraNotasCualitativas", Me) Then
                objfrm = New frmSraNotasCualitativas
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   catalogo de aranceles
    '----------------------------------------------------------------------------------
    Private Sub CargarNotasBoletin()
        Dim objfrm As frmSraNotaBoletin
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraNotaBoletin", Me) Then
                objfrm = New frmSraNotaBoletin
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   catalogo de aranceles
    '----------------------------------------------------------------------------------
    Private Sub CargarAranceles()
        Dim objfrm As frmSraAranceles
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraAranceles", Me) Then
                objfrm = New frmSraAranceles
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarActivarParcial()
        Dim objfrm As frmSraActivarParcial
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSraActivarParcial", Me) Then
                objfrm = New frmSraActivarParcial
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


#End Region

#Region "Cargar Catálogo de Profesores"
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Profesores
    '----------------------------------------------------------------------------------
    Private Sub CargarProfesores()
        Dim objProfesores As frmStbProfesores
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbProfesores", Me) Then
                objProfesores = New frmStbProfesores
                objProfesores.Width = Me.Width - Me.NavBarPrincipal.Width
                objProfesores.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objProfesores.MdiParent = Me
                objProfesores.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Empleados"
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Empleados
    '----------------------------------------------------------------------------------
    Private Sub CargarEmpleados()
        Dim objProfesores As frmStbEmpleados
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbEmpleados", Me) Then
                objProfesores = New frmStbEmpleados
                objProfesores.Width = Me.Width - Me.NavBarPrincipal.Width
                objProfesores.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objProfesores.MdiParent = Me
                objProfesores.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Cargar Catálogo de Alumnos"
    '-- Descripcion             :   Cargar la pantalla principal de catálogo de Alumnos
    '----------------------------------------------------------------------------------
    Private Sub CargarAlumnoa()
        Dim objProfesores As frmStbAlumnos
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmStbAlumnos", Me) Then
                objProfesores = New frmStbAlumnos
                objProfesores.Width = Me.Width - Me.NavBarPrincipal.Width
                objProfesores.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objProfesores.MdiParent = Me
                objProfesores.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarTasaCambio()
        Dim objTasaCambio As frmStbMantTasaCambioOficial
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmStbMantTasaCambioOficial", Me) Then
                    objTasaCambio = New frmStbMantTasaCambioOficial
                    objTasaCambio.Width = Me.Width - Me.NavBarPrincipal.Width
                    objTasaCambio.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objTasaCambio.MdiParent = Me
                    objTasaCambio.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarConfiguracionCajas()
        Dim objCajas As frmSccConfiguracionCajas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccConfiguracionCajas", Me) Then
                    objCajas = New frmSccConfiguracionCajas
                    objCajas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCajas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCajas.MdiParent = Me
                    objCajas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarConfiguracionCajasCH()
        Dim objCajas As frmSccConfiguracionCajasCH
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccConfiguracionCajasCH", Me) Then
                    objCajas = New frmSccConfiguracionCajasCH
                    objCajas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCajas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCajas.MdiParent = Me
                    objCajas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarRecibos()
        Dim objRecibos As frmSccReciboCaja
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccReciboCaja", Me) Then
                    objRecibos = New frmSccReciboCaja
                    objRecibos.Width = Me.Width - Me.NavBarPrincipal.Width
                    objRecibos.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objRecibos.MdiParent = Me
                    objRecibos.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarSalidas()
        Dim objSalidas As frmSccSalidaCajaCH
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccSalidaCajaCH", Me) Then
                    objSalidas = New frmSccSalidaCajaCH
                    objSalidas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objSalidas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objSalidas.MdiParent = Me
                    objSalidas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarPrestamosEmpleados()
        Dim objCuentas As frmSccCuentasEmpleado
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccCuentasEmpleado", Me) Then
                    objCuentas = New frmSccCuentasEmpleado
                    objCuentas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCuentas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCuentas.MdiParent = Me
                    objCuentas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarConceptosCuentas()
        Dim objCuentas As frmSContConceptosCuentas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSContConceptosCuentas", Me) Then
                    objCuentas = New frmSContConceptosCuentas
                    objCuentas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCuentas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCuentas.MdiParent = Me
                    objCuentas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarAgrupacionesBalance()
        Dim objAgrupaciones As frmSContAgrupacionBalance
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSContAgrupacionBalance", Me) Then
                    objAgrupaciones = New frmSContAgrupacionBalance
                    objAgrupaciones.Width = Me.Width - Me.NavBarPrincipal.Width
                    objAgrupaciones.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objAgrupaciones.MdiParent = Me
                    objAgrupaciones.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarCatalogo()
        Dim objCuentas As frmSContCuentasContables
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSContCuentasContables", Me) Then
                    objCuentas = New frmSContCuentasContables
                    objCuentas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCuentas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCuentas.MdiParent = Me
                    objCuentas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarContabilizar()
        Dim objContablizar As frmSContContabilizar
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSContContabilizar", Me) Then
                    objContablizar = New frmSContContabilizar
                    objContablizar.Width = Me.Width - Me.NavBarPrincipal.Width
                    objContablizar.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objContablizar.MdiParent = Me
                    objContablizar.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarComprobantes()
        Dim objContablizar As frmSContComprobantes
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSContComprobantes", Me) Then
                    objContablizar = New frmSContComprobantes
                    objContablizar.Width = Me.Width - Me.NavBarPrincipal.Width
                    objContablizar.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objContablizar.MdiParent = Me
                    objContablizar.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Procedimiento para Cargar REPORTES"
    ''' <summary>
    ''' Procedimiento encargado de Presentar la pantalla correspondiente de Reportes.
    ''' </summary>
    ''' <param name="Reporte"></param>
    ''' <remarks></remarks>
    Public Sub Reportes(ByVal Reporte As String)
        Dim objReportes As New frmStbVisor
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                objReportes.IDReporte = Reporte
                objReportes.Width = Me.Width - Me.NavBarPrincipal.Width
                objReportes.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objReportes.MdiParent = Me
                objReportes.Show()
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub
#End Region

#Region "Eventos"

    Private Sub NavBarEncargos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEncargos.LinkClicked

    End Sub

    Private Sub NavBarSincroVentas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroVentas.LinkClicked

    End Sub

    Private Sub NavBarFacturasXCuenta_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub

    Private Sub NavBarReciboCaja_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub

    Private Sub NavBarDevoluciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub

    Private Sub NavBarSincroAbonos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroAbonos.LinkClicked

    End Sub

    Private Sub NavBarSincroDevoluciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSincroDevoluciones.LinkClicked

    End Sub
    Private Sub NavBarConfiguracionCaja_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub

    Private Sub NavBarComisiones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub
    Private Sub NavBarSalidasEfectivo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub

    Private Sub NavBarArqueo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)

    End Sub
#End Region

#Region "Liberar Memoria"
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean

    Public Sub ClearMemory()
        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            'Control de errores
        End Try
    End Sub
#End Region

#Region "Cargar Opciones Registro academico"
    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Matriculas
    '----------------------------------------------------------------------------------
    Private Sub CargarMatriculas()
        Dim objfrm As frmSraMatriculas
        Dim selectperiodo As frmSraSeleccionarPeriodo
        Try
            selectperiodo = New frmSraSeleccionarPeriodo
            selectperiodo.TypeGui = 1
            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                objfrm = New frmSraMatriculas
                objfrm.PeriodoID = selectperiodo.intPeriodoID
                frmPrincipal.glbPeriodoSeleccionado = selectperiodo.intPeriodoID
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objfrm = Nothing
            selectperiodo = Nothing
        End Try

    End Sub

    Private Sub CargarPivot()
        Dim objfrm As frmSraPivotNotas
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmSraPivotNotas
            objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            objfrm.MdiParent = Me
            objfrm.Show()


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '----------------------------------------------------------------------------------
    '-- Descripcion             :   Cargar la pantalla principal de mantenimiento de 
    '--                         :   Matriculas
    '----------------------------------------------------------------------------------
    Private Sub CargarEvaluacionSecundaria()
        Dim objfrm As frmEvaluacionSecundaria2
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmEvaluacionSecundaria2

            objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            objfrm.MdiParent = Me
            objfrm.Show()

            'If Not clsProyecto.MostrarFormulario("frmSraAsignaturas", Me) Then
            '    objfrm = New frmSraAsignaturas
            '    objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            '    objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            '    objfrm.MdiParent = Me
            '    objfrm.Show()
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarRendimientoacademico()

        Dim objfrmRendimiento As frmRendimiento
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmRendimiento", Me) Then
                objfrmRendimiento = New frmRendimiento
                objfrmRendimiento.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrmRendimiento.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrmRendimiento.MdiParent = Me
                objfrmRendimiento.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub


    Private Sub CargarRendimientoacademicoAsignatura()

        Dim objfrmRendimientoA As frmRendimientoAcademicoAsignatura
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmRendimientoAcademicoAsignatura", Me) Then
                objfrmRendimientoA = New frmRendimientoAcademicoAsignatura
                objfrmRendimientoA.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrmRendimientoA.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrmRendimientoA.MdiParent = Me
                objfrmRendimientoA.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarExcelenciaacademica()
        Dim objfrm As frmExcelenciaAcademica
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmExcelenciaAcademica

            objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            objfrm.MdiParent = Me
            objfrm.Show()

            'If Not clsProyecto.MostrarFormulario("frmSraAsignaturas", Me) Then
            '    objfrm = New frmSraAsignaturas
            '    objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            '    objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            '    objfrm.MdiParent = Me
            '    objfrm.Show()
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarEvaluacionInicial(intModalidad As Integer)
        Dim objfrm As frmEvaluacionNivel
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            objfrm = New frmEvaluacionNivel
            objfrm.ModaidadID = intModalidad
            objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            objfrm.MdiParent = Me
            objfrm.Show()

            'If Not clsProyecto.MostrarFormulario("frmSraAsignaturas", Me) Then
            '    objfrm = New frmSraAsignaturas
            '    objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
            '    objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
            '    objfrm.MdiParent = Me
            '    objfrm.Show()
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "Cargar Notas de Debito"

    Private Sub CargarNotasDebito()
        Dim objNotasDebito As frmSccMantMora
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccMantNotaDebito", Me) Then
                    objNotasDebito = New frmSccMantMora
                    objNotasDebito.Width = Me.Width - Me.NavBarPrincipal.Width
                    objNotasDebito.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objNotasDebito.MdiParent = Me
                    objNotasDebito.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region


    Private Sub CargarNotascredito()
        Dim objNotasCredito As frmSccMantMora
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccMantMora", Me) Then
                    objNotasCredito = New frmSccMantMora
                    objNotasCredito.Width = Me.Width - Me.NavBarPrincipal.Width
                    objNotasCredito.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objNotasCredito.MdiParent = Me
                    objNotasCredito.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarDepositos()
        Dim objfrmArqueo As frmSccDepositos
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccDepositos", Me) Then
                    objfrmArqueo = New frmSccDepositos
                    objfrmArqueo.Width = Me.Width - Me.NavBarPrincipal.Width
                    objfrmArqueo.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objfrmArqueo.MdiParent = Me
                    objfrmArqueo.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarArqueoCaja()
        Dim objfrmArqueo As frmSccArquo
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccArquo", Me) Then
                    objfrmArqueo = New frmSccArquo
                    objfrmArqueo.Width = Me.Width - Me.NavBarPrincipal.Width
                    objfrmArqueo.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objfrmArqueo.MdiParent = Me
                    objfrmArqueo.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarArqueoCajaCH()
        Dim objfrmArqueo As frmSccArqueoCH
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccArqueoCH", Me) Then
                    objfrmArqueo = New frmSccArqueoCH
                    objfrmArqueo.Width = Me.Width - Me.NavBarPrincipal.Width
                    objfrmArqueo.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objfrmArqueo.MdiParent = Me
                    objfrmArqueo.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub CargarCuentas()
        Dim objCuentas As frmSccCuentas
        Try
            Try
                Me.Cursor = Cursors.WaitCursor
                If Not clsProyecto.MostrarFormulario("frmSccCuentas", Me) Then
                    objCuentas = New frmSccCuentas
                    objCuentas.Width = Me.Width - Me.NavBarPrincipal.Width
                    objCuentas.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                    objCuentas.MdiParent = Me
                    objCuentas.Show()
                End If

            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub NavTasaCambio_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavTasaCambio.LinkClicked
        CargarTasaCambio()
    End Sub

    Private Sub NavBarMatricula_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMatricula.LinkClicked
        CargarMatriculas()
    End Sub

    Private Sub NavBarListaGrupos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarListaGrupos.LinkClicked
        Dim selectperiodo As frmSraSeleccionarPeriodo
        Try
            selectperiodo = New frmSraSeleccionarPeriodo
            selectperiodo.TypeGui = 1
            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim objfrm As frmSraAsignarGrupos

                objfrm = New frmSraAsignarGrupos
                objfrm.PeriodoID = selectperiodo.intPeriodoID
                frmPrincipal.glbPeriodoSeleccionado = selectperiodo.intPeriodoID
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarEvaluacion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEvaluacion.LinkClicked

        Dim selectperiodo As frmSraSeleccionarPeriodo
        Try
            selectperiodo = New frmSraSeleccionarPeriodo
            selectperiodo.TypeGui = 0
            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                glbPeriodoSeleccionado = selectperiodo.PeriodoID
                glbModalidad = selectperiodo.ModaidadID

                If selectperiodo.Pantalla = 0 Then

                    CargarEvaluacionSecundaria()
                Else
                    CargarEvaluacionInicial(selectperiodo.ModaidadID)
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try


    End Sub

    Private Sub NavBarEvidencias_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEvidencias.LinkClicked
        CargarEvidencias()

    End Sub

    Private Sub NavBarCalificaciones_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCalificaciones.LinkClicked
        Dim selectperiodo As frmSraSeleccionarParametros
        Try
            selectperiodo = New frmSraSeleccionarParametros
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try

    End Sub

    Private Sub NavBarRendimiento_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRendimiento.LinkClicked

        Try
            CargarRendimientoacademico()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try



        'Dim selectperiodo As frmSraSeleccionarRendimiento
        'Try
        '    selectperiodo = New frmSraSeleccionarRendimiento
        '    selectperiodo.ShowDialog(Me)

        'Catch ex As Exception
        '    clsError.CaptarError(ex)
        'Finally

        'End Try
    End Sub

    Private Sub NavBarConsolidado_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarConsolidado.LinkClicked
        CargarPivot()
    End Sub

    Private Sub NavBarExcelencia_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarExcelencia.LinkClicked
        CargarExcelenciaacademica()
    End Sub

    Private Sub NavBarRendimientoAsig_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRendimientoAsig.LinkClicked
        CargarRendimientoacademicoAsignatura()
    End Sub

    Private Sub NavBarEmpleados_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEmpleados.LinkClicked
        CargarEmpleados()
    End Sub

    Private Sub NavBarCajas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarConfiguracionCaja.LinkClicked
        CargarConfiguracionCajas()
    End Sub

    Private Sub NavBarNotaDebito_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMorosidad.LinkClicked
        CargarNotasDebito()
    End Sub

    Private Sub NavBarNotaCredito_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        CargarNotascredito()
    End Sub

    Private Sub NavBarAranceles_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAranceles.LinkClicked
        CargarAranceles()
    End Sub

    Private Sub NavBarCuentas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCuentas.LinkClicked

        Dim selectperiodo As frmSraSeleccionarPeriodo
        Try
            selectperiodo = New frmSraSeleccionarPeriodo
            selectperiodo.TypeGui = 1

            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                frmPrincipal.glbPeriodoSeleccionado = selectperiodo.intPeriodoID
                CargarCuentas()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try


    End Sub

    Private Sub NavBarAplicarBeca_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAplicarBeca.LinkClicked
        Dim selectperiodo As frmSraSeleccionarPeriodo
        Try
            selectperiodo = New frmSraSeleccionarPeriodo
            selectperiodo.TypeGui = 2
            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim objfrm As frmSraAplicarBecas

                objfrm = New frmSraAplicarBecas
                objfrm.PeriodoID = selectperiodo.intPeriodoID
                frmPrincipal.glbPeriodoSeleccionado = selectperiodo.intPeriodoID
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarReciboCaja_LinkClicked_1(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarReciboCaja.LinkClicked
        CargarRecibos()
    End Sub

    Private Sub NavBarCatCuentas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCatCuentas.LinkClicked
        CargarCatalogo()
    End Sub

    Private Sub NavBarNotas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarNotas.LinkClicked
        CargarNotasBoletin()
    End Sub

    Private Sub NavBarImprimirEC_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarImprimirEC.LinkClicked
        Dim selectperiodo As frmSraBusquedaExpediente
        Try
            selectperiodo = New frmSraBusquedaExpediente
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarESolventes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarESolventes.LinkClicked
        Dim selectperiodo As frmSraAlumnosSolventes
        Try
            selectperiodo = New frmSraAlumnosSolventes
            selectperiodo.TypeGui = 1

            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarESMora_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarESMora.LinkClicked
        Dim selectperiodo As frmSraAlumnosSolventes
        Try
            selectperiodo = New frmSraAlumnosSolventes
            selectperiodo.TypeGui = 2

            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarArqueo_LinkClicked_1(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarArqueo.LinkClicked
        CargarArqueoCaja()
    End Sub

    Private Sub NavBarCajaChica_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCajaChica.LinkClicked
        CargarConfiguracionCajasCH()
    End Sub

    Private Sub NavBarSalidaCajaChica_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarSalidaCajaChica.LinkClicked
        CargarSalidas()
    End Sub

    Private Sub NavBarArqueoCajaCH_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarArqueoCajaCH.LinkClicked
        CargarArqueoCajaCH()
    End Sub

    Private Sub NavBarPeriodoContable_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarPeriodoContable.LinkClicked
        CargarPeriodosContable()
    End Sub

    Private Sub NavBarCentroCosto_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCentroCosto.LinkClicked
        CargarCentrosCosto()
    End Sub

    Private Sub NavBarContabilizar_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarContabilizar.LinkClicked
        CargarContabilizar()
    End Sub

    Private Sub NavBarComprobante_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarComprobante.LinkClicked
        CargarComprobantes()
    End Sub

    Private Sub NavBarNotasParametro_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarNotasParametro.LinkClicked
        Dim selectnotas As frmSraRptNotas
        Try
            selectnotas = New frmSraRptNotas
            selectnotas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarRptAlumnos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRptAlumnos.LinkClicked
        Dim selectnotas As frmSraRptAlumnos
        Try
            selectnotas = New frmSraRptAlumnos
            selectnotas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub
    Private Sub CargarCheques()
        Dim objCheques As frmSContCheques
        Try
            '-- Instanciar
            Me.Cursor = Cursors.WaitCursor
            If Not clsProyecto.MostrarFormulario("frmSContCheques", Me) Then
                objCheques = New frmSContCheques
                objCheques.Width = Me.Width - Me.NavBarPrincipal.Width
                objCheques.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objCheques.MdiParent = Me
                objCheques.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub NavBarCheque_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCheque.LinkClicked
        CargarCheques()
    End Sub

    Private Sub CargarSaldosMayorizados(intPeriodo As Integer, intMes As Integer)
        Dim objfrm As frmSContSaldosMesMayorizar
        Try

            If Not clsProyecto.MostrarFormulario("frmSContSaldosMesMayorizar", Me) Then
                objfrm = New frmSContSaldosMesMayorizar
                objfrm.Mes = intMes
                objfrm.Periodo = intPeriodo
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarSaldosCerrarMes(intPeriodo As Integer, intMes As Integer)
        Dim objfrm As frmSContSaldosMes
        Try

            If Not clsProyecto.MostrarFormulario("frmSContSaldosMes", Me) Then
                objfrm = New frmSContSaldosMes
                objfrm.Mes = intMes
                objfrm.Periodo = intPeriodo
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CargarSaldos(intPeriodo As Integer, intMes As Integer)
        Dim objfrm As frmSContSaldos
        Try

            If Not clsProyecto.MostrarFormulario("frmSContSaldos", Me) Then
                objfrm = New frmSContSaldos
                objfrm.Mes = intMes
                objfrm.PeriodoID = intPeriodo
                objfrm.Width = Me.Width - Me.NavBarPrincipal.Width
                objfrm.Height = Me.Height - Me.MenuPrincipal.Height - Me.stbPrincipal.Height
                objfrm.MdiParent = Me
                objfrm.Show()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub NavBarCSaldos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCSaldos.LinkClicked
        Dim selectperiodo As frmScontParametrosSaldos
        Try
            selectperiodo = New frmScontParametrosSaldos

            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CargarSaldos(selectperiodo.PeriodoID, selectperiodo.MesID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarMayorizar_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMayorizar.LinkClicked
        Dim selectperiodo As frmScontParametrosSaldos
        Try
            selectperiodo = New frmScontParametrosSaldos

            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CargarSaldosMayorizados(selectperiodo.PeriodoID, selectperiodo.MesID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarCerrarMes_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarCerrarMes.LinkClicked
        Dim selectperiodo As frmScontParametrosSaldos
        Try
            selectperiodo = New frmScontParametrosSaldos
            selectperiodo.TypeGui = 4

            If selectperiodo.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                CargarSaldosCerrarMes(selectperiodo.PeriodoID, selectperiodo.MesID)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarEstadoResultado_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarEstadoResultado.LinkClicked
        Dim selectperiodo As frmScontRptEstadoResultado
        Try
            selectperiodo = New frmScontRptEstadoResultado
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarBalance_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarBalance.LinkClicked
        Dim selectperiodo As frmScontRptBalanceGeneral
        Try
            selectperiodo = New frmScontRptBalanceGeneral
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarBComprobacion_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarBComprobacion.LinkClicked
        Dim selectperiodo As frmScontRptBalanzaComprobacion
        Try
            selectperiodo = New frmScontRptBalanzaComprobacion
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarActivarParcial_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarActivarParcial.LinkClicked
        CargarActivarParcial()
    End Sub

    Private Sub NavBarDepositos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDepositos.LinkClicked
        CargarDepositos()
    End Sub

    Private Sub NavBarDepositosRpt_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarDepositosRpt.LinkClicked
        Dim selectperiodo As frmScontRptDepositos
        Try
            selectperiodo = New frmScontRptDepositos
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarReporteGastos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarReporteGastos.LinkClicked
        Dim selectperiodo As frmScontRptGastos
        Try
            selectperiodo = New frmScontRptGastos
            selectperiodo.TypeGui = 0
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarRelacionConceptos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarRelacionConceptos.LinkClicked
        CargarConceptosCuentas()
    End Sub

    Private Sub NavBarPrestamos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarPrestamos.LinkClicked
        CargarPrestamosEmpleados()
    End Sub

    Private Sub NavBarAuxiliar_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAuxiliar.LinkClicked
        Dim selectperiodo As frmScontRptAuxiliar
        Try
            selectperiodo = New frmScontRptAuxiliar
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarArqueoDeposito_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarArqueoDeposito.LinkClicked
        Dim selectperiodo As frmScontRptGastos
        Try
            selectperiodo = New frmScontRptGastos
            selectperiodo.TypeGui = 1
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarAgrupacionesBalance_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarAgrupacionesBalance.LinkClicked
        CargarAgrupacionesBalance()
    End Sub

    Private Sub NavBarFlujo_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarFlujo.LinkClicked
        Dim selectperiodo As frmScontRptFlujoNeto
        Try
            selectperiodo = New frmScontRptFlujoNeto
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub

    Private Sub NavBarMatriz_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarMatriz.LinkClicked
        Dim selectperiodo As frmScontRptIngresosEgresos
        Try
            selectperiodo = New frmScontRptIngresosEgresos
            selectperiodo.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

        End Try
    End Sub
End Class
