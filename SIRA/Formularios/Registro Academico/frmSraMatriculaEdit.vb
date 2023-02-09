Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos
Imports DevExpress.XtraGrid.Views.Grid


Public Class frmSraMatriculaEdit

#Region "Declaración de Variables propias del formulario"
    Public dtTipoMatricula, dtGrado, dtModalidad, dtBeca, dtPeriodo, DtPersona As DataTable
    Dim intTipoMatricula, intEstadoRegistradaCuenta, intArancelMatricula, intArancelMensualidad, intEstadoPagoMensual As Integer
#End Region

#Region "Procedimientos"
    Public Sub VincularControles()
        Try
            Me.txtPrimerNombre.DataBindings.Clear()
            Me.txtSegundoNombre.DataBindings.Clear()
            Me.txtPrimerApellido.DataBindings.Clear()
            Me.txtSegundoApellido.DataBindings.Clear()
            Me.dtpFechaNacimiento.DataBindings.Clear()

            Me.idpersona = DtPersona.Rows(0)("StbPersonaID")
            Me.idalumno = DtPersona.Rows(0)("AlumnoID")
            Me.txtPrimerNombre.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoNombre.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.txtPrimerApellido.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoApellido.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.dtpFechaNacimiento.Value = DtPersona.Rows(0)("FechaNacimiento")

            If Not IsNothing(DtPersona.Rows(0)("cedula")) Then
                Me.txtCodigoMined.DataBindings.Add("text", DtPersona, "cedula", False, DataSourceUpdateMode.OnPropertyChanged)

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:      Procedimiento encargado de cargar la informacion de personas con clasificacion alumno 
    Public Sub CargarAlumnos()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersona & "'"

            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacionAlumnos", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function ValidarMonedaMensualidad(Grado As Integer)
        Dim dtValidacion As DataTable

        ''Buscar aranceles a pagar           
        dtValidacion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor,objMonedaID", "vwSraAranceles", "objGradoID=" & Grado & " and objTipoArancelID = " & intArancelMensualidad))

        If dtValidacion.Rows.Count > 0 Then
            Return True
        Else
            Me.ErrPrv.SetError(Me.cmbGrado, "El grado seleccionado no tiene registrado un arancel para generar el expediente.")
            Me.cmbGrado.Focus()
            Return False
        End If
    End Function

    Private Sub GuardarMatricula()
        Dim objMatricula As SraMatricula_Alumnos
        Dim T As New DAL.TransactionManager
        Dim objCuentaverificar As SccCuentaPorCobrar
        Dim intMesBeca As Integer
        Try
            Dim MS As New System.IO.MemoryStream
            If Not IsNothing(PBFoto.Image) Then
                PBFoto.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If

            intMesBeca = ClsCatalogos.GetValorParametro("AplicaBecaMes")

            T.BeginTran()
            objMatricula = New SraMatricula_Alumnos

            objMatricula.objAlumnoID = idalumno
            objMatricula.objTipoMatriculaID = cmbTipoMatricula.SelectedValue
            objMatricula.objGradoID = cmbGrado.SelectedValue
            objMatricula.objModalidadlD = cmbModalidad.SelectedValue
            objMatricula.objBecaID = cmbBeca.SelectedValue
            objMatricula.Activo = True
            objMatricula.NumRecibo = String.Empty
            objMatricula.EscuelaProcedente = txtEscuelaProcedencia.Text
            objMatricula.objPeriodoID = cmbPeriodos.SelectedValue
            objMatricula.IngresoPosterior = chkIngresoPosterior.Checked

            If chkIngresoPosterior.Checked Then
                objMatricula.FechaIngreso = dtFechaIngreso.Value
            Else
                objMatricula.FechaIngreso = clsProyecto.Conexion.FechaServidor
            End If

            If Not IsNothing(PBFoto.Image) Then
                objMatricula.Foto = MS.GetBuffer

            End If

            objMatricula.Recomendaciones = txtRecomendaciones.Text

            objMatricula.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objMatricula.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objMatricula.Insert(T)

            ''Generar expediente
            ''Buscar si existe
            objCuentaverificar = New SccCuentaPorCobrar

            objCuentaverificar.RetrieveByFilter("objAlumnoID=" & idalumno & " and objPeriodoID=" & cmbPeriodos.SelectedValue & " and Activa=1", T)
            If objCuentaverificar.SccCuentaID = 0 Then
                GenerarExpediente(T, idalumno, cmbGrado.SelectedValue, cmbPeriodos.SelectedValue, cmbPeriodos.Text, cmbModalidad.SelectedValue, intMesBeca)
            End If

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objMatricula = Nothing
        End Try
    End Sub


    Private Sub GenerarExpediente(T As DAL.TransactionManager, idalumno As Integer, Grado As Integer, Periodo As Integer, strPeriodo As String, Modalidad As Integer, intMesBeca As Integer)
        Dim objCuenta, objCuentaUP As SccCuentaPorCobrar
        Dim objCuentaDetalle As SccCuentaPorCobrarDetalle
        Dim objAranceles As New SraAranceles
        Dim objBeca As New SraBecas
        Dim dtMensualidad As New DataTable
        Dim CuentaID, objMonedaMensualidadID As Integer
        Dim dblMensualidad, dblBeca As Decimal
        Dim fechaServidor As Date
        Dim fechafin As DateTime
        Dim fechaIngreso As DateTime
        Try

            fechaServidor = clsProyecto.Conexion.FechaServidor
            objCuenta = New SccCuentaPorCobrar
            objCuentaUP = New SccCuentaPorCobrar
            objCuentaDetalle = New SccCuentaPorCobrarDetalle

            objCuenta.objAlumnoID = idalumno
            objCuenta.objPeriodoID = Periodo
            objCuenta.objGradoID = Grado
            objCuenta.objEstadoID = intEstadoRegistradaCuenta
            objCuenta.Activa = True
            objCuenta.objModalidadID = Modalidad

            ''Buscar aranceles a pagar           
            dtMensualidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Valor,objMonedaID", "vwSraAranceles", "objGradoID=" & Grado & " and objTipoArancelID = " & intArancelMensualidad), T)

            If dtMensualidad.Rows.Count > 0 Then
                dblMensualidad = Decimal.Parse(dtMensualidad.Rows(0)("Valor").ToString)
                objMonedaMensualidadID = Integer.Parse(dtMensualidad.Rows(0)("objMonedaID").ToString)
            Else
                dblMensualidad = 0.0
            End If

            If cmbBeca.Text <> String.Empty Then
                objBeca.Retrieve(cmbBeca.SelectedValue)
                dblBeca = objBeca.Porcentaje
            Else
                dblBeca = 0.0
            End If

            objCuenta.Saldo = ((dblMensualidad * (1 - (dblBeca / 100)) * 11))
            objCuenta.SaldoInicial = ((dblMensualidad * (1 - (dblBeca / 100)) * 12))
            objCuenta.objMonedaPagoMensualidadID = objMonedaMensualidadID
            objCuenta.PagoMensual = dblMensualidad * (1 - (dblBeca / 100))
            objCuenta.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objCuenta.FechaCreacion = fechaServidor
            objCuenta.Insert(T)
            CuentaID = objCuenta.SccCuentaID

            ''Actualizar Numero
            objCuentaUP.Retrieve(CuentaID, T)
            objCuentaUP.Numero = strPeriodo & "-" & objCuenta.objAlumnoID.ToString & "-" & objCuenta.SccCuentaID.ToString
            objCuentaUP.Update(T)

            If chkIngresoPosterior.Checked Then
                ''Buscar el mes en que ingreso
                Dim mesingreso As Integer
                fechaIngreso = dtFechaIngreso.Value
                mesingreso = fechaIngreso.Month

                ''Generar detalle de los pagos
                For mes As Integer = mesingreso To 12

                    fechafin = New DateTime(strPeriodo, mes, DateTime.DaysInMonth(strPeriodo, mes))
                    objCuentaDetalle.objSccCuentaPorCobrarID = CuentaID
                    objCuentaDetalle.FechaVencimiento = fechafin
                    objCuentaDetalle.Mes = mes
                    objCuentaDetalle.Activo = True
                    objCuentaDetalle.MontoInicial = objCuenta.PagoMensual
                    objCuentaDetalle.MontoPagado = 0
                    objCuentaDetalle.objBecaID = cmbBeca.SelectedValue
                    objCuentaDetalle.objEstadoID = intEstadoPagoMensual
                    objCuentaDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objCuentaDetalle.FechaCreacion = fechaServidor
                    objCuentaDetalle.Insert(T)
                Next

            Else
                ''Generar detalle de los pagos
                For mes As Integer = intMesBeca To 12

                    fechafin = New DateTime(strPeriodo, mes, DateTime.DaysInMonth(strPeriodo, mes))
                    objCuentaDetalle.objSccCuentaPorCobrarID = CuentaID
                    objCuentaDetalle.FechaVencimiento = fechafin
                    objCuentaDetalle.Mes = mes
                    objCuentaDetalle.Activo = True
                    objCuentaDetalle.MontoInicial = objCuenta.PagoMensual
                    objCuentaDetalle.MontoPagado = 0
                    objCuentaDetalle.objBecaID = cmbBeca.SelectedValue
                    objCuentaDetalle.objEstadoID = intEstadoPagoMensual
                    objCuentaDetalle.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objCuentaDetalle.FechaCreacion = fechaServidor
                    objCuentaDetalle.Insert(T)
                Next

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objCuenta = Nothing
            objAranceles = Nothing
            dtMensualidad = Nothing
            objCuentaUP = Nothing
        End Try

    End Sub

    Private Sub ActualizarMatricula()
        Dim objMatricula As SraMatricula_Alumnos
        Dim dtBecasAlumnos As New DataTable
        Dim objCuentaverificar As SccCuentaPorCobrar
        Dim objCuentaverificarDetalle As SccCuentaPorCobrarDetalle
        Dim T As New DAL.TransactionManager
        Dim intMesBeca As Integer
        Try
            Dim MS As New System.IO.MemoryStream
            If Not IsNothing(PBFoto.Image) Then
                PBFoto.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)

            End If
            intMesBeca = ClsCatalogos.GetValorParametro("AplicaBecaMes")

            T.BeginTran()
            objMatricula = New SraMatricula_Alumnos
            objMatricula.Retrieve(idMatriculaAlumno)

            objMatricula.objTipoMatriculaID = cmbTipoMatricula.SelectedValue
            objMatricula.objGradoID = cmbGrado.SelectedValue
            objMatricula.objModalidadlD = cmbModalidad.SelectedValue
            objMatricula.objBecaID = cmbBeca.SelectedValue
            objMatricula.Activo = True
            objMatricula.NumRecibo = String.Empty
            objMatricula.EscuelaProcedente = txtEscuelaProcedencia.Text
            objMatricula.objPeriodoID = cmbPeriodos.SelectedValue

            objMatricula.IngresoPosterior = chkIngresoPosterior.Checked

            If chkIngresoPosterior.Checked Then
                objMatricula.FechaIngreso = dtFechaIngreso.Value
            Else
                objMatricula.FechaIngreso = clsProyecto.Conexion.FechaServidor
            End If

            If Not IsNothing(PBFoto.Image) Then
                objMatricula.Foto = MS.GetBuffer
            End If

            objMatricula.Recomendaciones = txtRecomendaciones.Text
            objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objMatricula.Update(T)

            ''Generar expediente
            ''Buscar si existe
            objCuentaverificar = New SccCuentaPorCobrar
            objCuentaverificarDetalle = New SccCuentaPorCobrarDetalle
            objCuentaverificar.RetrieveByFilter("objAlumnoID=" & idalumno & " and objPeriodoID=" & cmbPeriodos.SelectedValue & " and Activa=1", T)

            If objCuentaverificar.SccCuentaID = 0 Then
                GenerarExpediente(T, idalumno, cmbGrado.SelectedValue, cmbPeriodos.SelectedValue, cmbPeriodos.Text, cmbModalidad.SelectedValue, intMesBeca)
                'Else
                '    ''Verificar si la cuenta no tienen ningun movimiento y se puede eliminar para generar una nueva
                '    objCuentaverificarDetalle.RetrieveByFilter("objSccCuentaPorCobrarID=" & objCuentaverificar.SccCuentaID & " AND MontoPagado <> 0", T)

                '    If objCuentaverificarDetalle.SccCuentaPorCobrarDetalleID = 0 Then
                '        ''Eliminar la cuenta y su detalle
                '        SccCuentaPorCobrarDetalle.DeleteByFilter("objSccCuentaPorCobrarID= " & objCuentaverificar.SccCuentaID, T)
                '        SccCuentaPorCobrar.DeleteByFilter("SccCuentaID=" & objCuentaverificar.SccCuentaID, T)
                '        GenerarExpediente(T, idalumno, cmbGrado.SelectedValue, cmbPeriodos.SelectedValue, cmbPeriodos.Text, cmbModalidad.SelectedValue, intMesBeca)

                '    End If
            Else
                ''Si existe verificamos que el grado es el mismo.
                If objCuentaverificar.objGradoID <> cmbGrado.SelectedValue Then
                    ''Procedemos a actualizar la cabecera de la cuenta
                    Dim objCuentaActualizar As New SccCuentaPorCobrar
                    objCuentaActualizar.Retrieve(objCuentaverificar.SccCuentaID, T)
                    objCuentaActualizar.objGradoID = cmbGrado.SelectedValue
                    objCuentaActualizar.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objCuentaActualizar.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objCuentaActualizar.Update(T)
                End If
            End If

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objMatricula = Nothing
        End Try
    End Sub


#End Region

#Region "Cargar Combos"
    Private Sub CargarTipoMatricula()
        Try
            'Género
            dtTipoMatricula = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='TIPOMATRÍCULA')"))
            Me.cmbTipoMatricula.DataSource = dtTipoMatricula
            Me.cmbTipoMatricula.DisplayMember = "Descripcion"
            Me.cmbTipoMatricula.ValueMember = "StbValorCatalogoID"
            Me.cmbTipoMatricula.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbTipoMatricula.ExtendRightColumn = True
            Me.cmbTipoMatricula.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarModalidad()
        Try
            'Modalidad
            dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))
            Me.cmbModalidad.DataSource = dtModalidad
            Me.cmbModalidad.DisplayMember = "Descripcion"
            Me.cmbModalidad.ValueMember = "StbValorCatalogoID"
            Me.cmbModalidad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbModalidad.ExtendRightColumn = True
            Me.cmbModalidad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarGrados()
        Try
            dtGrado = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("GradoID,Grado", "SraGrado", "Activo=1"))
            Me.cmbGrado.DataSource = dtGrado
            Me.cmbGrado.DisplayMember = "Grado"
            Me.cmbGrado.ValueMember = "GradoID"
            Me.cmbGrado.Splits(0).DisplayColumns("GradoID").Visible = False
            Me.cmbGrado.ExtendRightColumn = True
            Me.cmbGrado.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarBecas()
        Try
            dtBeca = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("BecaID,Descripcion", "SraBecas", "Activo=1"))
            Me.cmbBeca.DataSource = dtBeca
            Me.cmbBeca.DisplayMember = "Descripcion"
            Me.cmbBeca.ValueMember = "BecaID"
            Me.cmbBeca.Splits(0).DisplayColumns("BecaID").Visible = False
            Me.cmbBeca.ExtendRightColumn = True
            Me.cmbBeca.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally

            Me.Cursor = [Default]
        End Try
    End Sub

    Public Sub CargarPeriodos()
        Try
            dtPeriodo = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodos.ValueMember = "PeriodoID"
            cmbPeriodos.DisplayMember = "Periodo"
            cmbPeriodos.DataSource = dtPeriodo

            cmbPeriodos.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodos.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodos.ColumnHeaders = False
            cmbPeriodos.ExtendRightColumn = True
            cmbPeriodos.SelectedIndex = 0


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Bloquear Controles"
    Private Sub BloquearControles()
        cmbTipoMatricula.ReadOnly = True
        Me.cmbModalidad.ReadOnly = True
        cmbBeca.ReadOnly = True
        cmbPeriodos.ReadOnly = True
        cmbGrado.ReadOnly = True
        txtRecomendaciones.ReadOnly = True
        txtNumRecibo.ReadOnly = True
        txtEscuelaProcedencia.ReadOnly = True
        cmdCargarFoto.Enabled = False
        cmdAddAlumno.Enabled = False
        cmdBuscar.Enabled = False
        Me.dtFechaMatricula.Enabled = False
        Me.dtFechaIngreso.Enabled = False
    End Sub
#End Region

#Region "Cargar Datos a Editar"

    Private Sub CargarDatosEditar()
        Dim objMatricula As SraMatricula_Alumnos
        Dim MS As System.IO.MemoryStream
        Try

            objMatricula = New SraMatricula_Alumnos
            objMatricula.RetrieveByFilter("SraMatriculaAlumnos=" + Me.idMatriculaAlumno.ToString)
            Me.idalumno = objMatricula.objAlumnoID

            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID,StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacionAlumnos", "AlumnoID=" + Me.idalumno.ToString))

            VincularControles()

            Me.cmbTipoMatricula.SelectedValue = objMatricula.objTipoMatriculaID
            Me.cmbModalidad.SelectedValue = objMatricula.objModalidadlD
            Me.cmbGrado.SelectedValue = objMatricula.objGradoID
            Me.dtFechaMatricula.Value = objMatricula.FechaCreacion
            Me.dtFechaIngreso.Value = objMatricula.FechaIngreso
            Me.chkIngresoPosterior.Checked = objMatricula.IngresoPosterior

            If Not IsNothing(objMatricula.objBecaID) Then
                Me.cmbBeca.SelectedValue = objMatricula.objBecaID
            End If

            Me.cmbPeriodos.SelectedValue = objMatricula.objPeriodoID
            Me.txtRecomendaciones.Text = objMatricula.Recomendaciones
            Me.txtNumRecibo.Text = objMatricula.NumRecibo
            Me.txtEscuelaProcedencia.Text = objMatricula.EscuelaProcedente

            If Not IsNothing(objMatricula.Foto) Then
                MS = New System.IO.MemoryStream(objMatricula.Foto)
                If Not IsNothing(MS) Then
                    Me.PBFoto.Image = Image.FromStream(MS)
                End If

            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objMatricula = Nothing
        End Try

    End Sub

#End Region

#Region "Propertys"
    Dim id_perLec As String
    Dim TyGui_Lec, TyGuiEsc, Llamado_Lec, id_alumno, id_MatriculaAlumno As Integer

    Property idpersona() As String
        Get
            Return id_perLec
        End Get
        Set(ByVal value As String)
            id_perLec = value
        End Set
    End Property

    Property idalumno() As Integer
        Get
            Return id_alumno
        End Get
        Set(ByVal value As Integer)
            id_alumno = value
        End Set
    End Property

    Property idMatriculaAlumno() As Integer
        Get
            Return id_MatriculaAlumno
        End Get
        Set(ByVal value As Integer)
            id_MatriculaAlumno = value
        End Set
    End Property


    Property TyGui() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

#End Region

#Region "Eventos de los botones"


    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub txtPrimerNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.TextChanged
        Me.ErrPrv.SetError(txtPrimerNombre, "")
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged
        Me.ErrPrv.SetError(txtPrimerApellido, "")
    End Sub

#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CargarModalidad()
            CargarTipoMatricula()
            CargarPeriodos()
            CargarBecas()
            CargarGrados()
            txtCodigoMined.ReadOnly = True
            txtPrimerApellido.ReadOnly = True
            txtSegundoApellido.ReadOnly = True
            txtPrimerNombre.ReadOnly = True
            txtSegundoNombre.ReadOnly = True
            dtpFechaNacimiento.ReadOnly = True
            txtCodigoMined.Focus()

            intTipoMatricula = ClsCatalogos.GetValorCatalogoID("TIPOMATRICULA", "02")
            intEstadoRegistradaCuenta = ClsCatalogos.GetValorCatalogoID("ESTADOCUENTA", "00")

            intArancelMatricula = ClsCatalogos.GetValorCatalogoID("TIPOARANCEL", "02")
            intArancelMensualidad = ClsCatalogos.GetValorCatalogoID("TIPOARANCEL", "03")

            intEstadoPagoMensual = ClsCatalogos.GetValorCatalogoID("ESTADOMENSUALIDAD", "01")

            Select Case TyGui
                Case 1
                    Me.Text = "Registrar Matricula"
                    cmdEditarAlumno.Enabled = False
                Case 2
                    Me.Text = "Editando Matricula..."
                    CargarDatosEditar()
                Case 3
                    Me.Text = "Consultando Matricula..."
                    CargarDatosEditar()
                    BloquearControles()

            End Select

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub dtFechaIngreso_TextChanged(sender As Object, e As EventArgs) Handles dtFechaIngreso.TextChanged
        Me.ErrPrv.SetError(dtFechaIngreso, "")
    End Sub

    Private Sub chkIngresoPosterior_CheckedChanged(sender As Object, e As EventArgs) Handles chkIngresoPosterior.CheckedChanged
        If chkIngresoPosterior.Checked Then
            dtFechaIngreso.Enabled = True
        Else
            dtFechaIngreso.Enabled = False
        End If
    End Sub




#End Region

#Region "Eventos Generales"

    Private Sub cmdCargarFoto_Click(sender As Object, e As EventArgs) Handles cmdCargarFoto.Click
        Try
            If Me.OFDFoto.ShowDialog = Windows.Forms.DialogResult.OK Then
                PBFoto.Image = Image.FromFile(OFDFoto.FileName)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click_1(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Opcion = 5
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                Me.idpersona = objSeleccion.Seleccion
                CargarAlumnos()
                Me.idalumno = DtPersona.Rows(0)("AlumnoID")

                ''Verificar que el alumno no esta matriculado
                objverificarMatricula.RetrieveByFilter("Activo=1 AND objAlumnoID=" & idalumno & " and objPeriodoID=" & Me.cmbPeriodos.SelectedValue)
                If objverificarMatricula.SraMatriculaAlumnos <> 0 Then
                    MsgBox("Este alumno ya esta matriculado.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Else
                    VincularControles()
                    cmdEditarAlumno.Enabled = True
                    ErrPrv.SetError(cmdBuscar, "")
                End If

            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Try
            If Me.ValidarAsignar() Then
                If Me.ValidarMonedaMensualidad(cmbGrado.SelectedValue) Then
                    Select Case Me.TyGui
                        Case 1
                            GuardarMatricula()
                        Case 2
                            ActualizarMatricula()
                    End Select
                End If

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbTipoMatricula_TextChanged(sender As Object, e As EventArgs) Handles cmbTipoMatricula.TextChanged
        Me.ErrPrv.SetError(cmbTipoMatricula, "")
    End Sub

    Private Sub cmbGrado_TextChanged(sender As Object, e As EventArgs) Handles cmbGrado.TextChanged
        Me.ErrPrv.SetError(cmbGrado, "")
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        ErrPrv.SetError(cmbModalidad, "")
    End Sub

    Private Sub txtNumRecibo_TextChanged(sender As Object, e As EventArgs) Handles txtNumRecibo.TextChanged
        ErrPrv.SetError(txtNumRecibo, "")
    End Sub

    Private Sub cmbPeriodos_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodos.TextChanged
        ErrPrv.SetError(cmbPeriodos, "")
    End Sub
#End Region

#Region "Validar Datos "
    Private Function ValidarAsignar()

        'Validar el tipo de matricula
        If Me.cmbTipoMatricula.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbTipoMatricula, "Debe ingresar el tipo de matricula")
            Me.cmbTipoMatricula.Focus()
            Return False
            Exit Function
        End If

        'Validar el grado
        If Me.cmbGrado.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGrado, "Debe ingresar el grado")
            Me.cmbGrado.Focus()
            Return False
            Exit Function
        End If
        'Validar la modalidad
        If Me.cmbModalidad.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbModalidad, "Debe ingresar la modalidad")
            Me.cmbModalidad.Focus()
            Return False
            Exit Function
        End If

        'Validar el numero de recibo
        'If Me.txtNumRecibo.Text.Trim.Length = 0 Then
        '    Me.ErrPrv.SetError(Me.txtNumRecibo, "Debe ingresar el numero de recibo")
        '    Me.txtNumRecibo.Focus()
        '    Return False
        '    Exit Function
        'End If

        'Validar el periodo
        If Me.cmbPeriodos.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbPeriodos, "Debe ingresar el periodo")
            Me.cmbPeriodos.Focus()
            Return False
            Exit Function
        End If

        If chkIngresoPosterior.Checked Then
            If Me.dtFechaIngreso.Text.Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.dtFechaIngreso, "Debe ingresar la fecha de ingreso")
                Me.dtFechaIngreso.Focus()
                Return False
                Exit Function
            End If
        End If


        Return True
    End Function


#End Region

    Private Sub cmdAddAlumno_Click(sender As Object, e As EventArgs) Handles cmdAddAlumno.Click
        Dim objPersonas As frmStbAlumnosEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbAlumnosEdit
            objPersonas.TyGui = 1
            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                idpersona = objPersonas.idpersona
                CargarAlumnos()
                VincularControles()
                cmdEditarAlumno.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdEditarAlumno_Click(sender As Object, e As EventArgs) Handles cmdEditarAlumno.Click
        Dim objPersonas As frmStbAlumnosEdit
        Try
            Me.Cursor = WaitCursor
            objPersonas = New frmStbAlumnosEdit
            Select Case TyGui
                Case 1
                    objPersonas.TyGui = 2
                Case 2
                    objPersonas.TyGui = 3
            End Select
            objPersonas.idpersona = Me.idpersona
            objPersonas.ShowDialog(Me)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdTomar_Click(sender As Object, e As EventArgs) Handles cmdTomar.Click
        Dim objFoto As New frmSraCapturarFoto
        Try
            If objFoto.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.PBFoto.Image = objFoto.imgFoto
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class