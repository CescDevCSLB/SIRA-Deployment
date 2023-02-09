Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports Proyecto.Catalogos.Datos

Public Class frmAsignarBecaEditar

#Region "Variables del formulario"
    Dim TyGui_Lec, intEstadoPagoMensual, intEstadoRegistradaCuenta, intArancelMensualidad, intArancelMatricula, intNingunaBeca As Integer
    Public dtBeca As DataTable
    Public Shared dtAlumnosSeleccioandos As DataTable
#End Region


#Region "Procedimientos"

    Property TyGui() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property

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

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas 
    ''                     de una determinada clasificacion
    Public Sub CargarDatos()
        Try
            CargarBecas()

            intEstadoPagoMensual = ClsCatalogos.GetValorCatalogoID("ESTADOMENSUALIDAD", "01")
            intEstadoRegistradaCuenta = ClsCatalogos.GetValorCatalogoID("ESTADOCUENTA", "00")
            intArancelMensualidad = ClsCatalogos.GetValorCatalogoID("TIPOARANCEL", "03")
            intArancelMatricula = ClsCatalogos.GetValorCatalogoID("TIPOARANCEL", "02")

            Me.grdAlumnos.DataSource = dtAlumnosSeleccioandos
            Me.grdAlumnos.Text = "Alumnos (" & dtAlumnosSeleccioandos.Rows.Count & ")"
            Me.grdAlumnos.Refresh()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function ValidarMatricula()

        'Validar la beca
        If Me.cmbBeca.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbBeca, "Debe ingresar el tipo de beca")
            Me.cmbBeca.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Function ValidarMES()

        'Validar la beca
        If Me.mMes.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.mMes, "Debe ingresar el mes.")
            Me.mMes.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub GenerarExpediente(T As DAL.TransactionManager, idalumno As Integer, Grado As Integer, Periodo As Integer, strPeriodo As String, Modalidad As Integer, intMesBeca As Integer, intMatricula As Integer)
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
        Dim objMatricula As New SraMatricula_Alumnos
        Try

            fechaServidor = clsProyecto.Conexion.FechaServidor
            objCuenta = New SccCuentaPorCobrar
            objCuentaUP = New SccCuentaPorCobrar
            objCuentaDetalle = New SccCuentaPorCobrarDetalle

            objCuenta.objAlumnoID = idalumno
            objCuenta.objPeriodoID = Periodo
            objCuenta.objGradoID = Grado
            objCuenta.objModalidadID = Modalidad
            objCuenta.objEstadoID = intEstadoRegistradaCuenta
            objCuenta.Activa = True

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

            objMatricula.Retrieve(intMatricula)

            If objMatricula.IngresoPosterior Then

                ''Buscar el mes en que ingreso
                Dim mesingreso As Integer
                fechaIngreso = objMatricula.FechaIngreso
                mesingreso = fechaIngreso.Month


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
    Private Sub AsignarBeca()
        Dim T As New DAL.TransactionManager
        Dim objAsignarBeca As New SraAlumnos_Becas
        Dim objMatricula As SraMatricula_Alumnos
        Dim objCuentaverificar As SccCuentaPorCobrar
        Dim dtBecasAlumnos As DataTable
        Dim objAlumnoBeca As SraAlumnos_Becas
        Dim intMesBeca As Integer
        Try
            T.BeginTran()

            For Each dr As DataRow In dtAlumnosSeleccioandos.Rows

                ''Actualizar Beca en matricula
                objMatricula = New SraMatricula_Alumnos
                objMatricula.Retrieve(CInt(dr("SraMatriculaAlumnos").ToString), T)
                objMatricula.objBecaID = cmbBeca.SelectedValue
                objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objMatricula.Update(T)

                dtBecasAlumnos = SraAlumnos_Becas.RetrieveDT("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " AND Activa=1 AND objBecaID<>" & cmbBeca.SelectedValue, , , T)

                If dtBecasAlumnos.Rows.Count > 0 Then
                    objAlumnoBeca = New SraAlumnos_Becas
                    For Each drI As DataRow In dtBecasAlumnos.Rows

                        objAlumnoBeca.Retrieve(CInt(drI("SraAlumnosBecasID").ToString), T)
                        objAlumnoBeca.Activa = False
                        objAlumnoBeca.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objAlumnoBeca.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objAlumnoBeca.Update(T)



                    Next
                End If

                ''Buscar a partir de que mes se aplica beca

                intMesBeca = mMes.Month

                'If TyGui = 0 Then
                '    intMesBeca = ClsCatalogos.GetValorParametro("AplicaBecaMes")
                'Else
                '    intMesBeca = mMes.Month
                'End If

                objAsignarBeca.objAlumnoID = CInt(dr("objAlumnoID").ToString)
                objAsignarBeca.objBecaID = cmbBeca.SelectedValue
                objAsignarBeca.Activa = True
                objAsignarBeca.Desde = intMesBeca
                objAsignarBeca.objPeriodoID = CInt(dr("objPeriodoID").ToString)
                objAsignarBeca.objGradoID = CInt(dr("GradoID").ToString)
                objAsignarBeca.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignarBeca.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignarBeca.Insert(T)

                ''Generar expediente
                ''Buscar si existe
                objCuentaverificar = New SccCuentaPorCobrar

                objCuentaverificar.RetrieveByFilter("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " and objPeriodoID=" & CInt(dr("objPeriodoID").ToString) & " and objGradoID= " & CInt(dr("GradoID").ToString) & " and Activa=1", T)
                If objCuentaverificar.SccCuentaID = 0 Then
                    GenerarExpediente(T, CInt(dr("objAlumnoID").ToString), CInt(dr("GradoID").ToString), CInt(dr("objPeriodoID").ToString), dr("Periodo").ToString, CInt(dr("objModalidadlD").ToString), intMesBeca, CInt(dr("SraMatriculaAlumnos").ToString))
                End If

                ModificarSaldos(T, CInt(dr("objPeriodoID").ToString), cmbBeca.SelectedValue, CInt(dr("objAlumnoID").ToString), CInt(dr("GradoID").ToString), intMesBeca)


            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub GenerarExpediente()
        Dim T As New DAL.TransactionManager
        Dim objAsignarBeca As New SraAlumnos_Becas
        Dim objMatricula As SraMatricula_Alumnos
        Dim objCuentaverificar As SccCuentaPorCobrar
        Dim dtBecasAlumnos As DataTable
        Dim objAlumnoBeca As SraAlumnos_Becas
        Dim intMesBeca As Integer
        Try
            T.BeginTran()

            For Each dr As DataRow In dtAlumnosSeleccioandos.Rows

                ''Actualizar Beca en matricula
                objMatricula = New SraMatricula_Alumnos
                objMatricula.Retrieve(CInt(dr("SraMatriculaAlumnos").ToString), T)
                objMatricula.objBecaID = intNingunaBeca
                objMatricula.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objMatricula.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objMatricula.Update(T)

                dtBecasAlumnos = SraAlumnos_Becas.RetrieveDT("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " AND Activa=1 AND objBecaID<>" & intNingunaBeca, , , T)

                If dtBecasAlumnos.Rows.Count > 0 Then
                    objAlumnoBeca = New SraAlumnos_Becas
                    For Each drI As DataRow In dtBecasAlumnos.Rows

                        objAlumnoBeca.Retrieve(CInt(drI("SraAlumnosBecasID").ToString), T)
                        objAlumnoBeca.Activa = False
                        objAlumnoBeca.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objAlumnoBeca.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objAlumnoBeca.Update(T)

                    Next
                End If

                intMesBeca = mMes.Month
                objAsignarBeca.objAlumnoID = CInt(dr("objAlumnoID").ToString)
                objAsignarBeca.objBecaID = intNingunaBeca
                objAsignarBeca.Activa = True
                objAsignarBeca.Desde = intMesBeca
                objAsignarBeca.objPeriodoID = CInt(dr("objPeriodoID").ToString)
                objAsignarBeca.objGradoID = CInt(dr("GradoID").ToString)
                objAsignarBeca.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignarBeca.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignarBeca.Insert(T)

                ''Generar expediente
                ''Buscar si existe
                objCuentaverificar = New SccCuentaPorCobrar

                objCuentaverificar.RetrieveByFilter("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " and objPeriodoID=" & CInt(dr("objPeriodoID").ToString) & " and objGradoID= " & CInt(dr("GradoID").ToString) & " and Activa=1", T)
                If objCuentaverificar.SccCuentaID = 0 Then
                    GenerarExpediente(T, CInt(dr("objAlumnoID").ToString), CInt(dr("GradoID").ToString), CInt(dr("objPeriodoID").ToString), dr("Periodo").ToString, CInt(dr("objModalidadlD").ToString), intMesBeca, CInt(dr("SraMatriculaAlumnos").ToString))
                End If
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub mMes_TextChanged(sender As Object, e As EventArgs) Handles mMes.TextChanged
        Me.ErrPrv.SetError(mMes, "")
    End Sub

    Private Sub CambiarBeca()
        Dim T As New DAL.TransactionManager
        Dim objAsignarBeca As New SraAlumnos_Becas
        Dim objAlumnoBeca As SraAlumnos_Becas
        Dim objAlumnoBecaUP As SraAlumnos_Becas
        Dim dtBecasAlumnos As New DataTable
        Try
            T.BeginTran()

            ''Registar beca
            For Each dr As DataRow In dtAlumnosSeleccioandos.Rows
                dtBecasAlumnos = SraAlumnos_Becas.RetrieveDT("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " AND Activa=1 AND objBecaID<>" & cmbBeca.SelectedValue,,, T)

                If dtBecasAlumnos.Rows.Count > 0 Then
                    objAlumnoBeca = New SraAlumnos_Becas
                    For Each drI As DataRow In dtBecasAlumnos.Rows

                        objAlumnoBeca.Retrieve(CInt(drI("SraAlumnosBecasID").ToString), T)
                        objAlumnoBeca.Activa = False
                        objAlumnoBeca.FechaModificacion = clsProyecto.Conexion.FechaServidor
                        objAlumnoBeca.UsuarioModificacion = clsProyecto.Conexion.Usuario
                        objAlumnoBeca.Update(T)

                    Next
                End If

                objAlumnoBecaUP = New SraAlumnos_Becas
                objAlumnoBecaUP.RetrieveByFilter("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " AND Activa=1 AND objBecaID=" & cmbBeca.SelectedValue, T)

                If objAlumnoBecaUP.SraAlumnosBecasID <> 0 Then
                    objAlumnoBecaUP.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objAlumnoBecaUP.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objAlumnoBecaUP.Update(T)
                Else
                    objAlumnoBecaUP.objAlumnoID = CInt(dr("objAlumnoID").ToString)
                    objAlumnoBecaUP.objBecaID = cmbBeca.SelectedValue
                    objAlumnoBecaUP.Activa = True
                    objAlumnoBecaUP.Desde = mMes.Month
                    objAlumnoBecaUP.objPeriodoID = CInt(dr("objPeriodoID").ToString)
                    objAlumnoBecaUP.objGradoID = CInt(dr("GradoID").ToString)
                    objAlumnoBecaUP.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objAlumnoBecaUP.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objAlumnoBecaUP.Insert(T)
                End If

                ''Modificar saldos
                ModificarSaldos(T, CInt(dr("objPeriodoID").ToString), cmbBeca.SelectedValue, CInt(dr("objAlumnoID").ToString), CInt(dr("GradoID").ToString), mMes.Month)
            Next


            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
#End Region

    Private Sub ModificarSaldos(T As TransactionManager, intPeriodoID As Integer, intBeca As Integer, intAlumno As Integer, intGrado As Integer, intMes As Integer)
        Dim parametro(6) As SqlClient.SqlParameter

        Dim dtPeriodo As New DataTable
        Dim objperiodo As New SContPeriodos
        Try


            parametro(0) = New SqlClient.SqlParameter("@IntPeriodoID ", SqlDbType.Int, 4)
            parametro(0).Value = intPeriodoID

            parametro(1) = New SqlClient.SqlParameter("@IDAlumno ", SqlDbType.Int, 4)
            parametro(1).Value = intAlumno

            parametro(2) = New SqlClient.SqlParameter("@IDBeca ", SqlDbType.Int, 4)
            parametro(2).Value = intBeca

            parametro(3) = New SqlClient.SqlParameter("@intGrado ", SqlDbType.Int, 4)
            parametro(3).Value = intGrado

            parametro(4) = New SqlClient.SqlParameter("@intMes ", SqlDbType.Int, 4)
            parametro(4).Value = intMes

            parametro(5) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar)
            parametro(5).Value = clsProyecto.Conexion.Usuario

            SqlHelper.ExecuteNonQuery(T.Transaction, CommandType.StoredProcedure, "Sp_ActualizarSaldosBeca", parametro)
            'MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            'Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception

            clsError.CaptarError(ex)
        Finally
            parametro = Nothing

        End Try
    End Sub

#Region "Eventos del Formulario"

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click

        Select Case Me.TyGui
                Case 0
                    If ValidarMatricula() Then
                        AsignarBeca()
                    End If

                Case 1
                If ValidarMatricula() Then
                    CambiarBeca()
                End If
            Case 2

                If ValidarMES() Then
                    GenerarExpediente()
                End If

        End Select


    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            intNingunaBeca = SraBecas.RetrieveDT("Descripcion='NINGUNA' AND  Activo=1").Rows(0)("BecaID")

            Select Case TyGui
                Case 0
                    Me.mMes.SelectedItem = ClsCatalogos.GetValorParametro("AplicaBecaMes")
                    'lblMes.Visible = False
                    'mMes.Visible = False
                Case 1
                   '' Me.mMes.SelectedItem = ClsCatalogos.GetValorParametro("AplicaBecaMes")
                    'lblMes.Visible = True
                    'mMes.Visible = True
                Case 2
                    lblBeca.Visible = False
                    cmbBeca.Visible = False
                    lblMes.Visible = True
                    mMes.Visible = True
            End Select

            CargarDatos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
    Private Sub cmbBeca_TextChanged(sender As Object, e As EventArgs) Handles cmbBeca.TextChanged
        Me.ErrPrv.SetError(cmbBeca, "")
    End Sub

#End Region



End Class