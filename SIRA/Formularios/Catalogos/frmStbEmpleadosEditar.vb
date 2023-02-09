Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmStbEmpleadosEditar

#Region "Declaración de Variables propias del formulario"
    Public dtGenero, dtCiudad, dtRutas As DataTable
    Public Shared dtContactos As DataTable
    Public dtOcupacion As DataTable
    Public DtPersona, dtCargos As DataTable
    Dim intTelefonoCliente, intResultado As Integer
    Public boolPersonaExistente As Boolean
#End Region

#Region "Busqueda"
    '' Descripción:        Procedimiento encargado de cargar la informacion de personas que aun no han sido ingresadas en profesores
    Public Sub CargarPersona()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersona & "'"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControles()
        Try
            Me.txtPrimerNombre.DataBindings.Clear()
            Me.txtSegundoNombre.DataBindings.Clear()
            Me.txtCedula.DataBindings.Clear()
            Me.txtPrimerApellido.DataBindings.Clear()
            Me.txtSegundoApellido.DataBindings.Clear()
            Me.cmbGenero.DataBindings.Clear()
            Me.dtpFechaNacimiento.DataBindings.Clear()
            Me.cmbciudad.DataBindings.Clear()
            Me.txtDireccion.DataBindings.Clear()

            Me.idpersona = DtPersona.Rows(0)("StbPersonaID")
            boolPersonaExistente = True
            Me.txtPrimerNombre.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoNombre.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedula.DataBindings.Add("text", DtPersona, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtPrimerApellido.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoApellido.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtDireccion.DataBindings.Add("text", DtPersona, "Direccion", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.cmbGenero.SelectedValue = DtPersona.Rows(0)("objGeneroID")
            Me.cmbciudad.SelectedValue = DtPersona.Rows(0)("objCiudadID")
            Me.dtpFechaNacimiento.Value = DtPersona.Rows(0)("FechaNacimiento")


            'Cargar Contactos
            dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.idpersona))
            Me.tdbContactos.SetDataBinding(dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & dtContactos.Rows.Count & ")"

            If dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactos.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar Combos"
    Private Sub CargarGenero()
        Try
            'Género
            dtGenero = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='GÉNERO')"))
            Me.cmbGenero.DataSource = dtGenero
            Me.cmbGenero.DisplayMember = "Descripcion"
            Me.cmbGenero.ValueMember = "StbValorCatalogoID"
            Me.cmbGenero.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbGenero.ExtendRightColumn = True
            Me.cmbGenero.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarCargos()
        Try
            'Cargo
            dtCargos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='CARGO')"))
            Me.cmbCargo.DataSource = dtCargos
            Me.cmbCargo.DisplayMember = "Descripcion"
            Me.cmbCargo.ValueMember = "StbValorCatalogoID"
            Me.cmbCargo.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbCargo.ExtendRightColumn = True
            Me.cmbCargo.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarCiudad()
        Dim objparametro As StbParametro
        Dim objPais As StbPais
        Try
            objparametro = New StbParametro
            objPais = New StbPais

            'Ciudad
            objparametro.RetrieveByFilter("Nombre='Pais'")
            objPais.RetrieveByFilter("Nombre='" & objparametro.Valor & "'")

            dtCiudad = StbCiudad.RetrieveDT("objPaisID=" & objPais.StbPaisID, "", "StbCiudadID,Nombre")
            Me.cmbciudad.DataSource = dtCiudad
            Me.cmbciudad.DisplayMember = "Nombre"
            Me.cmbciudad.ValueMember = "StbCiudadID"
            Me.cmbciudad.Splits(0).DisplayColumns("StbCiudadID").Visible = False
            Me.cmbciudad.ExtendRightColumn = True
            Me.cmbciudad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPais = Nothing
            objparametro = Nothing
            Me.Cursor = [Default]
        End Try
    End Sub



#End Region

#Region "Cargar Longitudes Máximas"
    Private Sub CargarLongitudesMaximas()
        Try
            Me.txtPrimerNombre.MaxLength = StbPersona.GetMaxLength("Nombre1")
            Me.txtSegundoNombre.MaxLength = StbPersona.GetMaxLength("Nombre2")
            Me.txtPrimerApellido.MaxLength = StbPersona.GetMaxLength("Apellido1")
            Me.txtSegundoApellido.MaxLength = StbPersona.GetMaxLength("Apellido2")
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Validar Ingresos"
    Public Function ValidarNumeroTelefono()
        Try
            Me.intResultado = 0

            If dtContactos.Rows.Count = 0 Then
                Me.intResultado = 1


            End If



        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return intResultado
    End Function
#End Region

#Region "Bloquear Controles"
    Private Sub BloquearControlesPersonaNatural()
        Me.txtPrimerNombre.Enabled = False
        Me.txtSegundoNombre.Enabled = False
        Me.txtPrimerApellido.Enabled = False
        Me.txtSegundoApellido.Enabled = False
        Me.cmbGenero.Enabled = False
        Me.dtpFechaNacimiento.Enabled = False
        Me.txtCedula.Enabled = False
    End Sub
    Private Sub BloquearAdicional()
        Me.tdbContactos.Enabled = False
        Me.cmdAgregarContacto.Enabled = False
        Me.cmdEliminarContacto.Enabled = False
    End Sub
#End Region

#Region "Habilitar/Deshabilitar"
    Private Sub tdbContactos_AfterFilter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles tdbContactos.AfterFilter
        Try
            Me.tdbContactos.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.DefaultView.Count & ")"
            If frmStbAlumnosEdit.dtContactos.DefaultView.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar Personas"
    Private Sub AgregarPersonas()
        Try
            Select Case Me.ValidarNumeroTelefono
                Case 0
                    If Me.ValidarPersonasNaturales() Then
                        If Not boolPersonaExistente Then
                            Me.InsertarPersonas()
                        Else
                            AsociarPersonaClientes()
                        End If
                    End If
                Case 1
                    MsgBox("No se puede ingresar el registro del empleado." + vbCrLf + "Debe definir al menos un tipo de Contacto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.GuardarContactosTemp()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Asociar Personas"
    Private Sub AsociarPersonaClientes()
        Dim objPersonas, objPCompara As StbPersona
        Dim ObjProfesores, objComparaProfesor As StbProfesores
        Dim objEmpleado As StbEmpleados
        Dim dtTemp As New DataTable
        Dim intCargoProfesor As Integer
        Dim strSQL As String
        Dim T As New DAL.TransactionManager
        Try
            objPersonas = New StbPersona
            objPCompara = New StbPersona
            ObjProfesores = New StbProfesores
            objComparaProfesor = New StbProfesores
            objEmpleado = New StbEmpleados

            '1.2 Validar que no exista  una persona con la misma cédula
            If TyGui <> 2 Then
                objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersona & " AND Cedula='" + Me.txtCedula.Text + "'")
                If objPCompara.Cedula <> Nothing Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                    Me.txtCedula.Focus()
                    Exit Sub
                End If
            End If

            T.BeginTran()
            objPersonas = New StbPersona
            objPersonas.Retrieve(Me.idpersona)
            objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor

            objPersonas.Nombre1 = Me.txtPrimerNombre.Text.Trim
            objPersonas.Nombre2 = Me.txtSegundoNombre.Text.Trim
            objPersonas.Apellido1 = Me.txtPrimerApellido.Text.Trim
            objPersonas.Apellido2 = Me.txtSegundoApellido.Text.Trim
            objPersonas.objGeneroID = Me.cmbGenero.SelectedValue

            If Me.txtCedula.Text.Trim <> "-      -" Then
                objPersonas.Cedula = Me.txtCedula.Text
            Else
                objPersonas.Cedula = Nothing
            End If
            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbciudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbciudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.Update(T)

            ''Insertar Empleado
            objEmpleado.objPersonaID = objPersonas.StbPersonaID
            objEmpleado.FechaIngreso = dtpFechaIngreso.Value

            If Me.dtpFechaEgreso.Text.Trim.Length <> 0 Then
                objEmpleado.FechaEgreso = dtpFechaEgreso.Value
            End If

            objEmpleado.objCargoID = cmbCargo.SelectedValue
            objEmpleado.Activo = True
            objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objEmpleado.Insert(T)

            strSQL = clsConsultas.ObtenerCatalogoValor(" StbValorCatalogoID ", " Nombre= 'CARGO' AND Codigo='01' ")
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                intCargoProfesor = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            If cmbCargo.SelectedValue = intCargoProfesor Then
                ObjProfesores.objEmpleadoID = objEmpleado.StbEmpleadoID
                ObjProfesores.objModalidadID = cmbCargo.SelectedValue
                ObjProfesores.UsuarioCreacion = clsProyecto.Conexion.Usuario
                ObjProfesores.FechaCreacion = clsProyecto.Conexion.FechaServidor
                ObjProfesores.Insert(T)
            End If

            Me.idpersona = objPersonas.StbPersonaID
            Me.ModificarDetalle()
            Me.InsertarDetalle(Me.idpersona, T)
            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try

    End Sub
#End Region

#Region "Insertar Personas"
    Private Sub InsertarPersonas()

        Dim objPersonas, objPCompara As StbPersona
        Dim ObjProfesores, objComparaProfesores As StbProfesores
        Dim objEmpleado As StbEmpleados
        Dim dtTemp As New DataTable
        Dim T As New DAL.TransactionManager
        Dim strSQL As String
        Dim intCargoProfesor As Integer
        Try
            T.BeginTran()
            objPersonas = New StbPersona
            objPCompara = New StbPersona
            ObjProfesores = New StbProfesores
            objComparaProfesores = New StbProfesores
            objEmpleado = New StbEmpleados

            If TyGui <> 2 Then
                '1.2 Validar que no exista  una persona con la misma cédula
                objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedula.Text + "'")
                If objPCompara.Cedula <> Nothing Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                    Me.txtCedula.Focus()
                    Exit Sub
                End If
            End If
            

            ''PROCEDER A INGRESAR
            objPersonas.Nombre1 = txtPrimerNombre.Text
            objPersonas.Nombre2 = txtSegundoNombre.Text
            objPersonas.Apellido1 = txtPrimerApellido.Text
            objPersonas.Apellido2 = txtSegundoApellido.Text
            objPersonas.objGeneroID = cmbGenero.SelectedValue

            If Me.txtCedula.Text.Trim <> "-      -" Then
                objPersonas.Cedula = Me.txtCedula.Text
            Else
                objPersonas.Cedula = Nothing
            End If

            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbciudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbciudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.PersonaJuridica = False
            objPersonas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objPersonas.Insert(T)

            ''Insertar Empleados

            objEmpleado.objPersonaID = objPersonas.StbPersonaID
            objEmpleado.FechaIngreso = dtpFechaIngreso.Value

            If Me.dtpFechaEgreso.Text.Trim.Length <> 0 Then
                objEmpleado.FechaEgreso = dtpFechaEgreso.Value
            End If

            objEmpleado.objCargoID = cmbCargo.SelectedValue
            objEmpleado.Activo = True
            objEmpleado.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objEmpleado.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objEmpleado.Insert(T)

            ''Si es un maestro se inserta en la tabla de Profesores     


            strSQL = clsConsultas.ObtenerCatalogoValor(" StbValorCatalogoID ", " Nombre= 'CARGO' AND Codigo='01' ")
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                intCargoProfesor = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            If cmbCargo.SelectedValue = intCargoProfesor Then
                ObjProfesores.objEmpleadoID = objEmpleado.StbEmpleadoID
                ObjProfesores.objModalidadID = cmbCargo.SelectedValue
                ObjProfesores.UsuarioCreacion = clsProyecto.Conexion.Usuario
                ObjProfesores.FechaCreacion = clsProyecto.Conexion.FechaServidor
                ObjProfesores.Insert(T)
            End If
            Me.idpersona = objPersonas.StbPersonaID
            Me.InsertarDetalle(Me.idpersona, T)

            ''Si no se digito la cedula entonces pponer un codigo del cliente
            If Me.txtCedula.Text.Trim = "-      -" Then
                Dim objPersonacedula As New StbPersona
                objPersonacedula.Retrieve(idpersona, T)
                objPersonacedula.Cedula = idpersona
                objPersonacedula.Update(T)
            End If

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing
            objPCompara = Nothing
        End Try


    End Sub
#End Region

#Region "Insertar Detalle de Personas"

    Private Sub InsertarDetalle(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmStbEmpleadosEditar.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Profesor'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = clsProyecto.Conexion.FechaServidor
            objClasifica.Insert(t)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try

    End Sub

#End Region

#Region "Cargar Datos a Editar"

    Private Sub CargarDatosEditar()
        Dim objPersonas As StbPersona
        Dim objProfesor As StbProfesores
        Dim objEmpleado As StbEmpleados
        Try

            objPersonas = New StbPersona
            objProfesor = New StbProfesores
            objEmpleado = New StbEmpleados

            objPersonas.RetrieveByFilter("StbPersonaID=" + Me.idpersona)

            Me.txtPrimerNombre.Text = objPersonas.Nombre1
            Me.txtSegundoNombre.Text = objPersonas.Nombre2
            Me.txtPrimerApellido.Text = objPersonas.Apellido1
            Me.txtSegundoApellido.Text = objPersonas.Apellido2

            If Not IsNothing(objPersonas.objGeneroID) Then
                Me.cmbGenero.SelectedValue = objPersonas.objGeneroID
            End If

            Me.txtCedula.Text = objPersonas.Cedula

            If objPersonas.FechaNacimiento.ToString.Length <> 0 Then
                Me.dtpFechaNacimiento.Value = objPersonas.FechaNacimiento
            End If

            If Not IsNothing(objPersonas.objCiudadID) Then
                Me.cmbciudad.SelectedValue = objPersonas.objCiudadID
            End If

            Me.txtDireccion.Text = objPersonas.Direccion
            objEmpleado.RetrieveByFilter("objPersonaID=" & Me.idpersona)

            If Not IsNothing(objEmpleado.FechaIngreso) Then
                dtpFechaIngreso.Value = objEmpleado.FechaIngreso
            End If

            If Not IsNothing(objEmpleado.FechaEgreso) Then
                dtpFechaEgreso.Value = objEmpleado.FechaEgreso
            End If

            chkActivo.Checked = objEmpleado.Activo

            objProfesor.RetrieveByFilter("objEmpleadoID=" & objEmpleado.StbEmpleadoID)

            If Not IsNothing(objEmpleado.objCargoID) Then
                Me.cmbCargo.SelectedValue = objEmpleado.objCargoID
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing
        End Try

    End Sub

#End Region

#Region "Editar Personas"

    Private Sub EditarPersonas()
        Try
            Select Case Me.ValidarNumeroTelefono
                Case 0
                    If Me.ValidarPersonasNaturales() Then
                        Me.ModificarPersonas()
                    End If
                Case 1
                    MsgBox("No se puede ingresar el registro de persona." + vbCrLf + "Debe definir al menos un teléfono como Contacto del Cliente", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Me.GuardarContactosTemp()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Modificar Personas"
    Private Sub ModificarPersonas()
        Dim objPersonas, objPCompara As StbPersona
        Dim ObjProfesores, objComparaProfesores As StbProfesores
        Dim objEmpleado As StbEmpleados
        Dim T As New DAL.TransactionManager
        Dim strSQL As String
        Dim intCargoProfesor As Integer
        Dim dtTemp As New DataTable

        Try
            objPersonas = New StbPersona
            objPCompara = New StbPersona
            ObjProfesores = New StbProfesores
            objComparaProfesores = New StbProfesores
            objEmpleado = New StbEmpleados

            '1.2 Validar que no exista  una persona con la misma cédula
            If TyGui <> 2 Then
                If Me.txtCedula.Text.Trim.Length <> 0 Then
                    objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersona & " AND Cedula='" + Me.txtCedula.Text + "'")
                    If objPCompara.Cedula <> Nothing Then
                        Me.ErrPrv.SetError(Me.txtCedula, "Ya existe una persona con la misma cédula.")
                        Me.txtCedula.Focus()
                    End If
                End If
            End If
            T.BeginTran()
            objPersonas = New StbPersona
            objPersonas.Retrieve(Me.idpersona)
            objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaModificacion = clsProyecto.Conexion.FechaServidor

            objPersonas.Nombre1 = Me.txtPrimerNombre.Text.Trim
            objPersonas.Nombre2 = Me.txtSegundoNombre.Text.Trim
            objPersonas.Apellido1 = Me.txtPrimerApellido.Text.Trim
            objPersonas.Apellido2 = Me.txtSegundoApellido.Text.Trim
            objPersonas.objGeneroID = Me.cmbGenero.SelectedValue

            If Me.txtCedula.Text.Trim <> "-      -" Then
                objPersonas.Cedula = Me.txtCedula.Text
            Else
                objPersonas.Cedula = Nothing
            End If
            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbciudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbciudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.Update(T)

            ' ''Actualizar Empleados
            objEmpleado.RetrieveByFilter("objPersonaID=" & idpersona)
            objEmpleado.objPersonaID = objPersonas.StbPersonaID
            objEmpleado.FechaIngreso = dtpFechaIngreso.Value

            If Me.dtpFechaEgreso.Text.Trim.Length <> 0 Then
                objEmpleado.FechaEgreso = dtpFechaEgreso.Value
            End If
            objEmpleado.objCargoID = cmbCargo.SelectedValue
            objEmpleado.Activo = chkActivo.Checked
            objEmpleado.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objEmpleado.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objEmpleado.Update(T)

            ''Si es un maestro se inserta en la tabla de Profesores     

            '-- Obtener ID de la moneda de la Tasa de Cambio           
            strSQL = clsConsultas.ObtenerCatalogoValor(" StbValorCatalogoID ", " Nombre= 'CARGO' AND Codigo='01' ")
            dtTemp = SqlHelper.ExecuteQueryDT(strSQL)
            If dtTemp.Rows.Count > 0 Then
                intCargoProfesor = dtTemp.Rows(0).Item("StbValorCatalogoID")
            End If

            '' ''Actualizar Profesores
            'ObjProfesores.RetrieveByFilter("objEmpleadoID=" & objEmpleado.StbEmpleadoID)

            'ObjProfesores.UsuarioModificacion = clsProyecto.Conexion.Usuario
            'ObjProfesores.FechaModificacion = clsProyecto.Conexion.FechaServidor
            'ObjProfesores.Update(T)

            If cmbCargo.SelectedValue = intCargoProfesor Then
                ' ''Actualizar Profesores
                ObjProfesores.RetrieveByFilter("objEmpleadoID=" & objEmpleado.StbEmpleadoID)

                If ObjProfesores.objEmpleadoID <> 0 Then
                    ObjProfesores.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    ObjProfesores.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    ObjProfesores.Update(T)
                Else
                    ObjProfesores.objEmpleadoID = objEmpleado.StbEmpleadoID
                    ObjProfesores.objModalidadID = cmbCargo.SelectedValue
                    ObjProfesores.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    ObjProfesores.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    ObjProfesores.Insert(T)
                End If

            End If

            Me.ModificarDetalle()
            Me.InsertarDetalle(Me.idpersona, T)
            T.CommitTran()

            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing
        End Try

    End Sub
#End Region

#Region "Modificar Detalle de Personas"
    Private Sub ModificarDetalle()

        Try
            StbPersonaClasificacion.DeleteByFilter("objTipoPersonaID = (SELECT StbTipoPersonaID FROM StbTipoPersona WHERE Descripcion='Profesor') AND objPersonaID=" + Me.idpersona)
            StbContactos.DeleteByFilter("objPersonaID='" + Me.idpersona + "'")

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub
#End Region

#Region "Validar Fechas en General"
    ' Descripción			   	:	Función para verificar la validez de una fecha
    ' -----------------------------------------------------------------------------------------
    Private Function FechaValida(ByVal day As Integer, ByVal month As Integer, ByVal year As Integer)
        Try
            If month > 12 Or month = 0 Or day > 31 Or day = 0 Then
                Return False
                Exit Function
            Else
                Select Case month
                    Case 2
                        If year Mod 4 = 0 Then
                            If day > 29 Then
                                Return False
                                Exit Function
                            Else
                                Return True
                                Exit Function
                            End If
                        Else
                            If day > 28 Then
                                Return False
                                Exit Function
                            Else
                                Return True
                                Exit Function
                            End If
                        End If
                    Case 4, 6, 9, 11
                        If day > 30 Then
                            Return False
                            Exit Function
                        Else
                            Return True
                            Exit Function
                        End If
                    Case 1, 3, 5, 7, 8, 10, 12
                        Return True
                        Exit Function
                End Select
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True

    End Function
#End Region

#Region "Validar Cédulas en General"
    ' Descripción			   	:	Función para verificar la validez de una cédula
    ' -----------------------------------------------------------------------------------------
    Private Function CedulaValida(ByVal cedula As String)
        If Me.FechaValida(CInt(cedula.Substring(4, 2)), CInt(cedula.Substring(6, 2)), CInt(cedula.Substring(8, 2))) = True Then
            Return True
            Exit Function
        Else
            Return False
            Exit Function
        End If
        Return True

    End Function
#End Region

#Region "Validar Cédulas"
    Private Function ValidarCedula()
        Try
            'Validar que haya algo en la cédula
            If Me.txtCedula.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedula, My.Resources.MsgObligatorio)
                Me.txtCedula.Focus()
                Return False
                Exit Function
            End If
            'Validar que no haya espacios intermedios
            For intCaracter As Integer = 0 To Me.txtCedula.Text.Trim.Length - 1
                If Me.txtCedula.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Número de Cédula no válido")
                    Me.txtCedula.Focus()
                    Return False
                    Exit Function
                End If
            Next
            'Validar que la fecha de la cédula sea válida
            If Me.txtCedula.Text.Trim.Length = 16 Then
                If Me.CedulaValida(Me.txtCedula.Text) = False Then
                    Me.ErrPrv.SetError(Me.txtCedula, "Número de Cédula no válido")
                    Me.txtCedula.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Return False
                Exit Function
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#Region "Validar Profesor "
    Private Function ValidarPersonasNaturales()
        'Validar el nombre
        If Me.txtPrimerNombre.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtPrimerNombre, "Debe ingresar el nombre de la persona")
            Me.txtPrimerNombre.Focus()
            Return False
            Exit Function
        End If
        'Validar el apellido
        If Me.txtPrimerApellido.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtPrimerApellido, "Debe ingresar el apellido de la persona")
            Me.txtPrimerApellido.Focus()
            Return False
            Exit Function
        End If
        'Validar el Género
        If Me.cmbGenero.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar el género del cliente")
            Me.cmbGenero.Focus()
            Return False
            Exit Function
        End If

        'Validar Ciudad
        If Me.cmbciudad.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbciudad, "Debe especificar la ciudad del profesor")
            Me.cmbciudad.Focus()
            Return False
            Exit Function
        End If


        'Validar Direccion
        If Me.txtDireccion.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.txtDireccion, "Debe especificar la direccion")
            Me.txtDireccion.Focus()
            Return False
            Exit Function
        End If

        '' Validar la cédula
        If Me.ValidarCedula = False Then
            Me.txtCedula.Focus()
            Return False
            Exit Function
        End If

        'Validar Fecha Ingreso
        If Me.dtpFechaIngreso.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.dtpFechaIngreso, "Debe especificar la fecha de ingreso")
            Me.dtpFechaIngreso.Focus()
            Return False
            Exit Function
        End If


        'Validar Cargo
        If Me.cmbCargo.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbCargo, "Debe especificar el cargo")
            Me.cmbCargo.Focus()
            Return False
            Exit Function
        End If

        '' Validar que la fecha de nacimiento sea igual al número de cédula
        'If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 And Me.txtCedula.Text.Trim.Length = 16 Then
        '    Dim TestString As String = Me.dtpFechaNacimiento.Text
        '    Dim TestArray() As String = Split(TestString, "/")

        '    Dim Dia As String = TestArray(0)
        '    Dim Mes As String
        '    If TestArray(1).Length = 1 Then
        '        Mes = "0" & TestArray(1)
        '    Else
        '        Mes = TestArray(1)
        '    End If

        '    Dim Anio As String = TestArray(2).Substring(2, 2)

        '    If Dia & "/" & Mes & "/" & Anio <> (Me.txtCedula.Text.Substring(4, 2) & "/" & Me.txtCedula.Text.Substring(6, 2) & "/" & Me.txtCedula.Text.Substring(8, 2)) Then
        '        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "La fecha de nacimiento debe coincidir con los dígitos centrales de la cédula")
        '        Me.dtpFechaNacimiento.Focus()
        '        Return False
        '        Exit Function
        '    End If
        'End If

        Return True
    End Function
#End Region

#Region "Cargar Grid Contactos"
    Private Sub CargarGridContactos()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID=" & Me.idpersona
            End Select

            frmStbEmpleadosEditar.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactos.SetDataBinding(frmStbEmpleadosEditar.dtContactos, "", True)
            Me.tdbContactos.Caption = "Contactos (" & frmStbEmpleadosEditar.dtContactos.Rows.Count & ")"

            If frmStbEmpleadosEditar.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactos.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Eliminar Contactos"
    Private Sub EliminarContactos()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmStbAlumnosEdit.dtContactos.Rows.RemoveAt(Me.tdbContactos.Row)
            Else
                Exit Sub
            End If
            If frmStbAlumnosEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Guardar Contactos Temporalmente"
    Private Sub GuardarContactosTemp()
        Try
            Dim objContactos As frmStbPersonasContactos
            objContactos = New frmStbPersonasContactos
            objContactos.frmLLamado = 3
            objContactos.ShowDialog()
            If frmStbEmpleadosEditar.dtContactos.Rows.Count > 0 Then
                Me.cmdEliminarContacto.Enabled = True
            End If
            Me.tdbContactos.Caption = "Contactos (" & frmStbEmpleadosEditar.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Propertys"
    Dim id_perLec As String
    Dim TyGui_Lec, TyGuiEsc, Llamado_Lec As Integer

    Property idpersona() As String
        Get
            Return id_perLec
        End Get
        Set(ByVal value As String)
            id_perLec = value
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

#Region "Eventos de los Controles"

#Region "Poner en mayúscula la primer letra"

    Private Sub txtPrimerNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrimerNombre.Leave
        Me.txtPrimerNombre.Text = Me.txtPrimerNombre.Text.Trim
        If Me.txtPrimerNombre.Text.Trim.Length > 0 Then
            Me.txtPrimerNombre.Text = Me.txtPrimerNombre.Text.Substring(0, 1).ToUpper & Me.txtPrimerNombre.Text.Substring(1, Me.txtPrimerNombre.Text.Length - 1)
        End If
    End Sub

    Private Sub txtSegundoNombre_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSegundoNombre.Leave
        Me.txtSegundoNombre.Text = Me.txtSegundoNombre.Text.Trim
        If Me.txtSegundoNombre.Text.Trim.Length > 0 Then
            Me.txtSegundoNombre.Text = Me.txtSegundoNombre.Text.Substring(0, 1).ToUpper & Me.txtSegundoNombre.Text.Substring(1, Me.txtSegundoNombre.Text.Length - 1)
        End If
    End Sub

    Private Sub txtPrimerApellido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrimerApellido.Leave
        Me.txtPrimerApellido.Text = Me.txtPrimerApellido.Text.Trim
        If Me.txtPrimerApellido.Text.Trim.Length > 0 Then
            Me.txtPrimerApellido.Text = Me.txtPrimerApellido.Text.Substring(0, 1).ToUpper & Me.txtPrimerApellido.Text.Substring(1, Me.txtPrimerApellido.Text.Length - 1)
        End If
    End Sub

    Private Sub txtSegundoApellido_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSegundoApellido.Leave
        Me.txtSegundoApellido.Text = Me.txtSegundoApellido.Text.Trim
        If Me.txtSegundoApellido.Text.Trim.Length > 0 Then
            Me.txtSegundoApellido.Text = Me.txtSegundoApellido.Text.Substring(0, 1).ToUpper & Me.txtSegundoApellido.Text.Substring(1, Me.txtSegundoApellido.Text.Length - 1)
        End If
    End Sub
#End Region

#Region "Pasar enfoques y quitar errores"

    Private Sub txtPrimerNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerNombre.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtPrimerNombre.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtSegundoNombre.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtPrimerNombre, "")
        End If
    End Sub

    Private Sub txtSegundoNombre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoNombre.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtSegundoNombre.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtPrimerApellido.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtSegundoNombre, "")
        End If
    End Sub

    Private Sub txtPrimerApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtPrimerApellido.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.txtSegundoApellido.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtPrimerApellido, "")
        End If
    End Sub

    Private Sub txtSegundoApellido_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegundoApellido.KeyPress
        If (Asc(e.KeyChar) = 32 And Me.txtSegundoApellido.Text.Length = 0) Then
            e.KeyChar = Convert.ToChar(0)
        End If
        If Asc(e.KeyChar) = 13 Then
            Me.cmbGenero.Focus()
        End If
        If Not clsProyecto.LetrasYEspacio(e.KeyChar) Then
            e.KeyChar = Convert.ToChar(0)
        Else
            Me.ErrPrv.SetError(Me.txtSegundoApellido, "")
        End If
    End Sub

    Private Sub cmbGenero_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaNacimiento.Focus()
        End If
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub cmbGenero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtCedula.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCedula.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
        Me.ErrPrv.SetError(Me.txtCedula, "")
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyUp
        Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            Me.txtCedula.Focus()
        End If
    End Sub
    Private Sub dtpFechaNacimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub cmbGenero_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

    Private Sub cmbGenero_ValueMemberChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.cmbGenero, "")
    End Sub

#End Region

#Region "Varios"

    Private Sub cmbGenero_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.cmbGenero, "")
        If Asc(e.KeyChar) = 13 Then
            Me.dtpFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dtpFechaNacimiento.Text.Trim.Length = 0 Then
            Me.dtpFechaNacimiento.Value = Nothing
        End If
    End Sub

#End Region

#End Region

#Region "Eventos de los botones"
    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Select Case Me.TyGui
                Case 1
                    Me.AgregarPersonas()
                Case 2
                    Me.EditarPersonas()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cmdEliminarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminarContacto.Click
        Try
            Me.EliminarContactos()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregarContacto.Click
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub txtPrimerNombre_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerNombre.TextChanged
        Me.ErrPrv.SetError(txtPrimerNombre, "")
    End Sub

    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged
        Me.ErrPrv.SetError(txtPrimerApellido, "")
    End Sub

    Private Sub cmbCiudad_TextChanged(sender As Object, e As EventArgs) Handles cmbciudad.TextChanged
        Me.ErrPrv.SetError(cmbciudad, "")
    End Sub

    Private Sub cmbGenero_TextChanged(sender As Object, e As EventArgs) Handles cmbGenero.TextChanged
        Me.ErrPrv.SetError(cmbGenero, "")
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged
        Me.ErrPrv.SetError(txtDireccion, "")
    End Sub

#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            boolPersonaExistente = False
            Me.CargarLongitudesMaximas()
            CargarGenero()
            CargarCiudad()
            CargarCargos()
            Me.CargarGridContactos()

            Select Case Me.TyGui
                Case 1
                    Me.Text = "Agregar nuevo empleado"
                Case 2
                    Me.Text = "Editanto datos del empleado: " & Me.idpersona
                    Me.CargarDatosEditar()
                    Me.txtPrimerNombre.Focus()
                    Me.cmdBuscar.Enabled = False
                Case 3
                    Me.Text = "Consultando datos del empleado: " & Me.idpersona

                    Me.CargarDatosEditar()

                    Me.barContactos.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.cmbGenero.Enabled = False
                    Me.dtpFechaNacimiento.Enabled = False
                    Me.txtCedula.Enabled = False
                    Me.txtPrimerNombre.Enabled = False
                    Me.txtSegundoNombre.Enabled = False
                    Me.txtPrimerApellido.Enabled = False
                    Me.txtSegundoApellido.Enabled = False
                    Me.cmbGenero.Enabled = False
                    Me.cmbciudad.Enabled = False
                    Me.txtDireccion.Enabled = False
                    Me.cmdBuscar.Enabled = False
                    Me.dtpFechaEgreso.Enabled = False
                    Me.dtpFechaIngreso.Enabled = False

                    clsProyecto.CargarTemaDefinido(Me)
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  StbPersonaID NOT IN (SELECT objPersonaID FROM StbEmpleados) "
            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idpersona = objSeleccion.Seleccion
                CargarPersona()
                VincularControles()
                ErrPrv.SetError(cmdBuscar, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region




    Private Sub cmbCargo_TextChanged(sender As Object, e As EventArgs) Handles cmbCargo.TextChanged
        Me.ErrPrv.SetError(cmbCargo, "")
    End Sub

    Private Sub dtpFechaIngreso_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaIngreso.TextChanged
        Me.ErrPrv.SetError(dtpFechaIngreso, "")
    End Sub
End Class