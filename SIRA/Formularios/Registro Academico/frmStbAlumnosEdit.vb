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


Public Class frmStbAlumnosEdit

#Region "Declaración de Variables propias del formulario"
    Public dtGenero, dtResponsable, dtCiudad, dtReligion, dtReligionPadre, dtEnfermedad, dtReligionMadre, dtReligionResponsable, dtLugarNacimiento As DataTable
    Public Shared dtContactos, dtContactosResponsable, dtContactosMadre, dtParentesco As DataTable
    Public dtOcupacion, dtEstadoCivilP, dtEstadoCivilM, dtEstadoCivilR As DataTable
    Public Shared CiudadID, enfermedadID As Integer
    Public DtPersona, DtPersonaPadre, DtPersonaMadre, DtPersonaResponsable As DataTable
    Public DtDetalleEnfermedades, dtEnfermedades As DataTable
    Dim fechaServidor As Date
    Dim intTelefonoCliente, intResultado, boolExisteErroresGrid As Integer
    Public boolPersonaExistente, boolPersonaExistenteMadre, boolPersonaExistenteResponsable, boolPersonaExistentePadre As Boolean

#End Region

#Region "Busqueda"
    Dim Contactos As Object

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersona()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersona & "'"

            '' strFiltro = " Descripcion <> 'Cliente' AND StbPersonaID NOT IN (SELECT objPersonaID FROM SccClientes) and PersonaJuridica=0"
            DtPersona = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersonaPadre()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersonaPadre & "'"

            DtPersonaPadre = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersonaMadre()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersonaMadre & "'"

            DtPersonaMadre = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas con clasificacion empleado que aun no han sido ingresadas en empleado
    Public Sub CargarPersonaResponsable()
        Try
            Dim strFiltro As String = ""
            strFiltro = "StbPersonaID = '" & idpersonaResponsable & "'"

            DtPersonaResponsable = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbPersonaID,NombreCompleto,Nombre1,Nombre2,Apellido1,Apellido2,Cedula,Genero,Direccion,objCiudadID,FechaNacimiento,objGeneroID", "vwPersonaClasificacion", strFiltro))
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControles()
        Try
            Me.txtPrimerNombre.DataBindings.Clear()
            Me.txtSegundoNombre.DataBindings.Clear()
            'Me.txtCedula.DataBindings.Clear()
            Me.txtPrimerApellido.DataBindings.Clear()
            Me.txtSegundoApellido.DataBindings.Clear()
            Me.cmbGenero.DataBindings.Clear()
            Me.dtpFechaNacimiento.DataBindings.Clear()
            Me.cmbciudad.DataBindings.Clear()
            Me.txtDireccion.DataBindings.Clear()
            Me.cmbReligion.DataBindings.Clear()


            Me.idpersona = DtPersona.Rows(0)("StbPersonaID")
            boolPersonaExistente = True
            Me.txtPrimerNombre.DataBindings.Add("text", DtPersona, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoNombre.DataBindings.Add("text", DtPersona, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)

            Me.txtPrimerApellido.DataBindings.Add("text", DtPersona, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtSegundoApellido.DataBindings.Add("text", DtPersona, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtDireccion.DataBindings.Add("text", DtPersona, "Direccion", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.cmbGenero.SelectedValue = DtPersona.Rows(0)("objGeneroID")
            Me.cmbciudad.SelectedValue = DtPersona.Rows(0)("objCiudadID")
            Me.dtpFechaNacimiento.Value = DtPersona.Rows(0)("FechaNacimiento")


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControlesPadre()
        Try
            Me.txtNombre1Padre.DataBindings.Clear()
            Me.txtNombre2Padre.DataBindings.Clear()
            Me.txtCedulaPadre.DataBindings.Clear()
            Me.txtApellido1Padre.DataBindings.Clear()
            Me.txtApellido2Padre.DataBindings.Clear()

            Me.idpersonaPadre = DtPersonaPadre.Rows(0)("StbPersonaID")
            boolPersonaExistentePadre = True
            Me.txtNombre1Padre.DataBindings.Add("text", DtPersonaPadre, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtNombre2Padre.DataBindings.Add("text", DtPersonaPadre, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido1Padre.DataBindings.Add("text", DtPersonaPadre, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido2Padre.DataBindings.Add("text", DtPersonaPadre, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedulaPadre.DataBindings.Add("text", DtPersonaPadre, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)

            'Cargar Contactos
            frmStbAlumnosEdit.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.idpersonaPadre))
            Me.tdbContactosPadre.SetDataBinding(frmStbAlumnosEdit.dtContactos, "", True)
            Me.tdbContactosPadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactosPadre.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControlesMadre()
        Try
            Me.txtNombre1Madre.DataBindings.Clear()
            Me.txtNombre2Madre.DataBindings.Clear()
            Me.txtCedulaMadre.DataBindings.Clear()
            Me.txtApellido1Madre.DataBindings.Clear()
            Me.txtApellido2Madre.DataBindings.Clear()

            Me.idpersonaMadre = DtPersonaMadre.Rows(0)("StbPersonaID")
            boolPersonaExistenteMadre = True
            Me.txtNombre1Madre.DataBindings.Add("text", DtPersonaMadre, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtNombre2Madre.DataBindings.Add("text", DtPersonaMadre, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido1Madre.DataBindings.Add("text", DtPersonaMadre, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido2Madre.DataBindings.Add("text", DtPersonaMadre, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedulaMadre.DataBindings.Add("text", DtPersonaMadre, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)

            'Cargar Contactos
            frmStbAlumnosEdit.dtContactosMadre = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.idpersonaMadre))
            Me.tdbContactosMadre.SetDataBinding(frmStbAlumnosEdit.dtContactosMadre, "", True)
            Me.tdbContactosMadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosMadre.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactosMadre.Rows.Count = 0 Then
                Me.cmdEliminarContactoM.Enabled = False
            Else
                Me.cmdEliminarContactoM.Enabled = True
            End If

            Me.tdbContactosMadre.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de vincular los controles al origen de datos
    Public Sub VincularControlesResponsable()
        Try
            Me.txtNombre1Responsable.DataBindings.Clear()
            Me.txtNombre2Responsable.DataBindings.Clear()
            Me.txtCedulaResponsable.DataBindings.Clear()
            Me.txtApellido1Responsable.DataBindings.Clear()
            Me.txtApellido2Responsable.DataBindings.Clear()

            Me.idpersonaResponsable = DtPersonaResponsable.Rows(0)("StbPersonaID")
            boolPersonaExistenteResponsable = True
            Me.txtNombre1Responsable.DataBindings.Add("text", DtPersonaResponsable, "Nombre1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtNombre2Responsable.DataBindings.Add("text", DtPersonaResponsable, "Nombre2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido1Responsable.DataBindings.Add("text", DtPersonaResponsable, "Apellido1", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtApellido2Responsable.DataBindings.Add("text", DtPersonaResponsable, "Apellido2", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtCedulaResponsable.DataBindings.Add("text", DtPersonaResponsable, "Cedula", False, DataSourceUpdateMode.OnPropertyChanged)

            'Cargar Contactos
            frmStbAlumnosEdit.dtContactosResponsable = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", "objPersonaID=" & Me.idpersonaResponsable))
            Me.tdbContactosResponsable.SetDataBinding(frmStbAlumnosEdit.dtContactosResponsable, "", True)
            Me.tdbContactosResponsable.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosResponsable.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactosResponsable.Rows.Count = 0 Then
                Me.cmdEliminarContactoR.Enabled = False
            Else
                Me.cmdEliminarContactoR.Enabled = True
            End If

            Me.tdbContactosResponsable.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Cargar Combos"
    Private Sub CargarReligion()
        Try
            'dtReligion
            dtReligion = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='RELIGIÓN')"))
            Me.cmbReligion.DataSource = dtReligion
            Me.cmbReligion.DisplayMember = "Descripcion"
            Me.cmbReligion.ValueMember = "StbValorCatalogoID"
            Me.cmbReligion.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbReligion.ExtendRightColumn = True
            Me.cmbReligion.SelectedValue = -1

            dtReligionMadre = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='RELIGIÓN')"))
            Me.cmbReligionMadre.DataSource = dtReligionMadre
            Me.cmbReligionMadre.DisplayMember = "Descripcion"
            Me.cmbReligionMadre.ValueMember = "StbValorCatalogoID"
            Me.cmbReligionMadre.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbReligionMadre.ExtendRightColumn = True
            Me.cmbReligionMadre.SelectedValue = -1

            dtReligionPadre = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='RELIGIÓN')"))
            Me.cmbReligionPadre.DataSource = dtReligionPadre
            Me.cmbReligionPadre.DisplayMember = "Descripcion"
            Me.cmbReligionPadre.ValueMember = "StbValorCatalogoID"
            Me.cmbReligionPadre.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbReligionPadre.ExtendRightColumn = True
            Me.cmbReligionPadre.SelectedValue = -1

            dtReligionResponsable = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='RELIGIÓN')"))
            Me.cmbReligionResponsable.DataSource = dtReligionResponsable
            Me.cmbReligionResponsable.DisplayMember = "Descripcion"
            Me.cmbReligionResponsable.ValueMember = "StbValorCatalogoID"
            Me.cmbReligionResponsable.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbReligionResponsable.ExtendRightColumn = True
            Me.cmbReligionResponsable.SelectedValue = -1

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarParentesco()
        Try
            'Parentesco
            dtParentesco = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='PARENTESCO')"))
            Me.cmbParentesco.DataSource = dtParentesco
            Me.cmbParentesco.DisplayMember = "Descripcion"
            Me.cmbParentesco.ValueMember = "StbValorCatalogoID"
            Me.cmbParentesco.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbParentesco.ExtendRightColumn = True
            Me.cmbParentesco.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

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

    Private Sub CargarEstadoCivilPadre()
        Try
            'Estado civil
            dtEstadoCivilP = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='ESTADOCIVIL')"))
            Me.cmbEstadoCivilP.DataSource = dtEstadoCivilP
            Me.cmbEstadoCivilP.DisplayMember = "Descripcion"
            Me.cmbEstadoCivilP.ValueMember = "StbValorCatalogoID"
            Me.cmbEstadoCivilP.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbEstadoCivilP.ExtendRightColumn = True
            Me.cmbEstadoCivilP.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarEstadoCivilMadre()
        Try
            'Estado civil
            dtEstadoCivilM = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='ESTADOCIVIL')"))
            Me.cmbEstadoCivilM.DataSource = dtEstadoCivilM
            Me.cmbEstadoCivilM.DisplayMember = "Descripcion"
            Me.cmbEstadoCivilM.ValueMember = "StbValorCatalogoID"
            Me.cmbEstadoCivilM.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbEstadoCivilM.ExtendRightColumn = True
            Me.cmbEstadoCivilM.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarEstadoCivilResponsable()
        Try
            'Estado civil
            dtEstadoCivilR = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='ESTADOCIVIL')"))
            Me.cmbEstadoCivilR.DataSource = dtEstadoCivilR
            Me.cmbEstadoCivilR.DisplayMember = "Descripcion"
            Me.cmbEstadoCivilR.ValueMember = "StbValorCatalogoID"
            Me.cmbEstadoCivilR.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbEstadoCivilR.ExtendRightColumn = True
            Me.cmbEstadoCivilR.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarResponsable()
        Try
            'Responsable
            dtResponsable = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='RESPONSABLE')"))
            Me.cmbResposable.DataSource = dtResponsable
            Me.cmbResposable.DisplayMember = "Descripcion"
            Me.cmbResposable.ValueMember = "StbValorCatalogoID"
            Me.cmbResposable.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbResposable.ExtendRightColumn = True
            Me.cmbResposable.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub CargarEnfermedad()
        Try
            'Enfermedad
            dtEnfermedad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='ENFERMEDAD')"))
            Me.cmbEnfermedad.DataSource = dtEnfermedad
            Me.cmbEnfermedad.DisplayMember = "Descripcion"
            Me.cmbEnfermedad.ValueMember = "StbValorCatalogoID"
            Me.cmbEnfermedad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbEnfermedad.ExtendRightColumn = True
            Me.cmbEnfermedad.SelectedValue = -1
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

    Private Sub CargarLugarNacimiento()
        Dim objparametro As StbParametro
        Dim objPais As StbPais
        Try
            objparametro = New StbParametro
            objPais = New StbPais

            'Ciudad
            objparametro.RetrieveByFilter("Nombre='Pais'")
            objPais.RetrieveByFilter("Nombre='" & objparametro.Valor & "'")

            dtLugarNacimiento = StbCiudad.RetrieveDT("objPaisID=" & objPais.StbPaisID, "", "StbCiudadID,Nombre")
            Me.cmbLugarNacimiento.DataSource = dtLugarNacimiento
            Me.cmbLugarNacimiento.DisplayMember = "Nombre"
            Me.cmbLugarNacimiento.ValueMember = "StbCiudadID"
            Me.cmbLugarNacimiento.Splits(0).DisplayColumns("StbCiudadID").Visible = False
            Me.cmbLugarNacimiento.ExtendRightColumn = True
            Me.cmbLugarNacimiento.SelectedValue = -1
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
            txtLugarNacimiento.MaxLength = StbAlumnos.GetMaxLength("LugarNacimientoExtranjero")
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

            If dtContactos.Rows.Count = 0 And dtContactosMadre.Rows.Count = 0 And dtContactosResponsable.Rows.Count = 0 Then
                MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe definir al menos un tipo de Contacto.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                Return False
                Exit Function
            End If

            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
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
        'Me.txtCedula.Enabled = False
    End Sub
    Private Sub BloquearAdicional()
        'Me.tdbContactos.Enabled = False
        'Me.cmdAgregarContacto.Enabled = False
        'Me.cmdEliminarContacto.Enabled = False
    End Sub
#End Region

#Region "Habilitar/Deshabilitar"
    Private Sub tdbContactos_AfterFilter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs)
        Try
            'Me.tdbContactos.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.DefaultView.Count & ")"
            'If frmStbAlumnosEdit.dtContactos.DefaultView.Count = 0 Then
            '    Me.cmdEliminarContacto.Enabled = False
            'Else
            '    Me.cmdEliminarContacto.Enabled = True
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Agregar Personas"
    Private Sub AgregarAlumno()
        Try
            ''Agregar informacion principal del alumno
            If ValidarPersonasAlumno() Then
                If Me.ValidarNumeroTelefono Then
                    If Not boolPersonaExistente Then
                        Me.InsertarAlumno()
                    Else
                        AsociarPersonaAlumno()
                    End If
                Else
                    Me.GuardarContactosTemp()
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Asociar Personas"
    Private Sub AsociarPersonaAlumno()
        Dim objPersonas As StbPersona
        Dim objAlumno As StbAlumnos
        Dim T As New DAL.TransactionManager

        Try
            T.BeginTran()
            objAlumno = New StbAlumnos
            ' ''Insertar Alumnos
            objAlumno.objPersonaID = idpersona
            objAlumno.CodigoMED = txtCodigoMined.Text
            objAlumno.objLugarNacimientoID = cmbLugarNacimiento.SelectedValue
            objAlumno.objReligionID = cmbReligion.SelectedValue
            objAlumno.objResponsableID = cmbResposable.SelectedValue
            objAlumno.InformacionCentro = txtInformacion.Text
            objAlumno.CausaIngreso = txtCausa.Text
            objAlumno.Importancia = txtImportancia.Text
            objAlumno.Espera = txtEspera.Text
            objAlumno.Observaciones = txtObservaciones.Text
            objAlumno.Activo = True
            objAlumno.Extranjero = chkAlumnoExtranjero.Checked
            objAlumno.LugarNacimientoExtranjero = txtLugarNacimiento.Text
            objAlumno.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objAlumno.FechaCreacion = fechaServidor
            objAlumno.Insert(T)

            Me.idalumno = objAlumno.AlumnoID
            InsertarDetalleAlumno(idpersona, T)

            ActualizarPadre(T)
            ActualizarMadre(T)
            ActualizarResponsable(T)

#Region "se omitio por datos duplicados"
            '''Registrar Padre
            'If Not boolPersonaExistentePadre Then

            '    Dim objPersonasPadre As New StbPersona

            '    If ValidarPersonasPadre() Then
            '        objPersonasPadre.Nombre1 = txtNombre1Padre.Text
            '        objPersonasPadre.Nombre2 = txtNombre2Padre.Text
            '        objPersonasPadre.Apellido1 = txtApellido1Padre.Text
            '        objPersonasPadre.Apellido2 = txtApellido2Padre.Text
            '        objPersonasPadre.Cedula = txtCedulaPadre.Text
            '        objPersonasPadre.Direccion = txtDireccionPadre.Text
            '        objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '        objPersonasPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objPersonasPadre.FechaCreacion = fechaServidor
            '        objPersonasPadre.Insert(T)
            '        idpersonaPadre = objPersonasPadre.StbPersonaID

            '        Me.InsertarDetallePadre(Me.idpersonaPadre, T)
            '        Dim objPadre As New StbPadres
            '        objPadre.objAlumnoID = idalumno
            '        objPadre.objPersonaID = Me.idpersonaPadre
            '        objPadre.objReligionID = cmbReligionPadre.SelectedValue
            '        objPadre.Ocupacion = txtOcupacionPadre.Text
            '        objPadre.Profesion = txtProfesionPadre.Text
            '        objPadre.Madre = False
            '        objPadre.NivelAcademico = txtNivelAcademicoP.Text

            '        objPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objPadre.FechaCreacion = fechaServidor
            '        objPadre.Insert(T)
            '    Else
            '        T.RollbackTran()
            '        Exit Sub
            '    End If
            'End If


            '''Registrar Madre
            'If Not boolPersonaExistenteMadre Then
            '    Dim objPersonasMadre As New StbPersona

            '    If ValidarPersonasMadre() Then
            '        objPersonasMadre.Nombre1 = txtNombre1Madre.Text
            '        objPersonasMadre.Nombre2 = txtNombre2Madre.Text
            '        objPersonasMadre.Apellido1 = txtApellido1Madre.Text
            '        objPersonasMadre.Apellido2 = txtApellido2Madre.Text
            '        objPersonasMadre.Cedula = txtCedulaMadre.Text
            '        objPersonasMadre.Direccion = txtDireccionMadre.Text
            '        objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
            '        objPersonasMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objPersonasMadre.FechaCreacion = fechaServidor
            '        objPersonasMadre.Insert(T)
            '        idpersonaMadre = objPersonasMadre.StbPersonaID

            '        Me.InsertarDetalleMadre(Me.idpersonaMadre, T)

            '        Dim objMadre As New StbPadres
            '        objMadre.objAlumnoID = idalumno
            '        objMadre.objPersonaID = Me.idpersonaMadre
            '        objMadre.objReligionID = cmbReligionMadre.SelectedValue
            '        objMadre.Ocupacion = txtOcupacionMadre.Text
            '        objMadre.Profesion = txtProfesionMadre.Text
            '        objMadre.NivelAcademico = txtNivelAcademicoM.Text
            '        objMadre.Madre = True
            '        objMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objMadre.FechaCreacion = fechaServidor
            '        objMadre.Insert(T)
            '    Else
            '        T.RollbackTran()
            '        Exit Sub
            '    End If

            'End If

            '''Registrar Responsable
            'If Not boolPersonaExistenteResponsable Then
            '    Dim objPersonasResponsable As New StbPersona

            '    If ValidarPersonasResponsable() Then
            '        objPersonasResponsable.Nombre1 = txtNombre1Madre.Text
            '        objPersonasResponsable.Nombre2 = txtNombre2Madre.Text
            '        objPersonasResponsable.Apellido1 = txtApellido1Madre.Text
            '        objPersonasResponsable.Apellido2 = txtApellido2Madre.Text
            '        objPersonasResponsable.Cedula = txtCedulaMadre.Text
            '        objPersonasResponsable.Direccion = txtDireccionResponsable.Text
            '        objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilR.SelectedValue
            '        objPersonasResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objPersonasResponsable.FechaCreacion = fechaServidor
            '        objPersonasResponsable.Insert(T)
            '        idpersonaResponsable = objPersonasResponsable.StbPersonaID

            '        Me.InsertarDetalleReponsable(Me.idpersonaResponsable, T)
            '        Dim objResponsable As New StbResponsable
            '        objResponsable.objAlumnoID = idalumno
            '        objResponsable.objPersonaID = Me.idpersonaResponsable
            '        objResponsable.objReligionID = cmbReligionResponsable.SelectedValue
            '        objResponsable.Ocupacion = txtOcupacionResponsable.Text
            '        objResponsable.Profesion = txtProfesionResponsable.Text
            '        objResponsable.NivelAcademico = txtNivelAcademicoR.Text
            '        objResponsable.objParentescoID = cmbParentesco.SelectedValue
            '        objResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '        objResponsable.FechaCreacion = fechaServidor
            '        objResponsable.Insert(T)
            '    End If
            'Else
            '    T.RollbackTran()
            '    Exit Sub


            'End If
#End Region


            ''Registrar Enfermedades
            Dim objEnfermedades As New StbAlumno_Enfermedad

            For Each dr As DataRow In DtDetalleEnfermedades.Rows
                objEnfermedades.objAumnoID = Me.idalumno
                objEnfermedades.objEnfermedadID = CInt(dr("objEnfermedadID").ToString)
                objEnfermedades.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEnfermedades.FechaCreacion = fechaServidor
                objEnfermedades.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing

        End Try
      

    End Sub
#End Region

#Region "Insertar Personas"
    Private Sub InsertarAlumno()

        Dim objPersonas As StbPersona
        Dim objAlumno As StbAlumnos
        Dim T As New DAL.TransactionManager

        Try
            T.BeginTran()
            objPersonas = New StbPersona
            objAlumno = New StbAlumnos

            ''PROCEDER A INGRESAR
            objPersonas.Nombre1 = txtPrimerNombre.Text
            objPersonas.Nombre2 = txtSegundoNombre.Text
            objPersonas.Apellido1 = txtPrimerApellido.Text
            objPersonas.Apellido2 = txtSegundoApellido.Text
            objPersonas.objGeneroID = cmbGenero.SelectedValue

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
            objPersonas.FechaCreacion = fechaServidor
            objPersonas.Insert(T)

            ' ''Insertar Alumnos
            objAlumno.objPersonaID = objPersonas.StbPersonaID
            objAlumno.CodigoMED = txtCodigoMined.Text
            objAlumno.objLugarNacimientoID = cmbLugarNacimiento.SelectedValue
            objAlumno.objReligionID = cmbReligion.SelectedValue
            objAlumno.objResponsableID = cmbResposable.SelectedValue
            objAlumno.InformacionCentro = txtInformacion.Text
            objAlumno.CausaIngreso = txtCausa.Text
            objAlumno.Importancia = txtImportancia.Text
            objAlumno.Espera = txtEspera.Text
            objAlumno.Observaciones = txtObservaciones.Text
            objAlumno.Activo = True
            objAlumno.Extranjero = chkAlumnoExtranjero.Checked
            objAlumno.LugarNacimientoExtranjero = txtLugarNacimiento.Text
            objAlumno.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objAlumno.FechaCreacion = fechaServidor
            objAlumno.Insert(T)

            Me.idpersona = objPersonas.StbPersonaID
            Me.idalumno = objAlumno.AlumnoID
            InsertarDetalleAlumno(idpersona, T)

            ActualizarPadre(T)
            ActualizarMadre(T)
            ActualizarResponsable(T)

#Region "PADRE"

            '''Registrar Padre
            'If Not boolPersonaExistentePadre Then
            '    Dim objPersonasPadre As New StbPersona

            '    'If ValidarPersonasPadre() Then
            '    objPersonasPadre.Nombre1 = txtNombre1Padre.Text
            '    objPersonasPadre.Nombre2 = txtNombre2Padre.Text
            '    objPersonasPadre.Apellido1 = txtApellido1Padre.Text
            '    objPersonasPadre.Apellido2 = txtApellido2Padre.Text

            '    If chkExtranjero.Checked Then
            '        objPersonasPadre.Cedula = String.Empty
            '    Else
            '        Dim objPCompara As New StbPersona
            '        '1.2 Validar que no exista  una persona con la misma cédula
            '        If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
            '            If Me.txtCedulaPadre.Text <> "   -      -" Then
            '                objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedulaPadre.Text + "'", T)
            '                If objPCompara.Cedula <> Nothing Then
            '                    If objPCompara.Cedula.Trim <> String.Empty Then
            '                        Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del padre ya existe en el sistema.")
            '                        Me.txtCedulaPadre.Focus()
            '                        Exit Sub
            '                    End If
            '                End If
            '            End If
            '        End If

            '        objPersonasPadre.Cedula = txtCedulaPadre.Text
            '    End If

            '    objPersonasPadre.Direccion = txtDireccionPadre.Text
            '    objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '    objPersonasPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '    objPersonasPadre.FechaCreacion = fechaServidor
            '    objPersonasPadre.Extranjero = chkExtranjero.Checked
            '    objPersonasPadre.Insert(T)
            '    idpersonaPadre = objPersonasPadre.StbPersonaID

            '    Me.InsertarDetallePadre(Me.idpersonaPadre, T)
            'Else
            '    Dim objPersonasPadre As New StbPersona
            '    objPersonasPadre.Retrieve(idpersonaPadre, T)

            '    objPersonasPadre.Nombre1 = txtNombre1Padre.Text
            '    objPersonasPadre.Nombre2 = txtNombre2Padre.Text
            '    objPersonasPadre.Apellido1 = txtApellido1Padre.Text
            '    objPersonasPadre.Apellido2 = txtApellido2Padre.Text

            '    'validamos que la cedula que se esta actualizando no exista
            '    Dim objPCompara = New StbPersona
            '    If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
            '        If Me.txtCedulaPadre.Text <> "   -      -" Then
            '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaPadre & " AND Cedula='" + Me.txtCedulaPadre.Text + "'", T)
            '            If objPCompara.Cedula <> Nothing Then
            '                If objPCompara.Cedula.Trim <> String.Empty Then
            '                    Me.ErrPrv.SetError(Me.txtCedulaPadre, "La cédula del padre ya existe en el sistema.")
            '                    Me.txtCedulaPadre.Focus()
            '                    T.RollbackTran()
            '                    Exit Sub
            '                End If
            '            End If
            '        End If
            '    End If
            '    objPersonasPadre.Cedula = txtCedulaPadre.Text
            '    objPersonasPadre.Direccion = txtDireccionPadre.Text
            '    objPersonasPadre.Extranjero = chkExtranjero.Checked
            '    objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '    objPersonasPadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
            '    objPersonasPadre.FechaModificacion = fechaServidor
            '    objPersonasPadre.Update(T)
            'End If

            'Dim objPadre As New StbPadres
            'objPadre.objAlumnoID = idalumno
            'objPadre.objPersonaID = Me.idpersonaPadre
            'objPadre.objReligionID = cmbReligionPadre.SelectedValue
            'objPadre.Ocupacion = txtOcupacionPadre.Text
            'objPadre.Profesion = txtProfesionPadre.Text
            'objPadre.NivelAcademico = txtNivelAcademicoP.Text

            'objPadre.Madre = False
            'objPadre.LugarTrabajo = txtLugarTrabajoResponsable.Text
            'objPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            'objPadre.FechaCreacion = fechaServidor
            'objPadre.Insert(T)
            ''Else
            ''    T.RollbackTran()
            ''    Exit Sub
            ''End If
#End Region

#Region "MADRE"

            '''Registrar Madre
            'If Not boolPersonaExistenteMadre Then
            '    Dim objPersonasMadre As New StbPersona

            '    'If ValidarPersonasMadre() Then
            '    objPersonasMadre.Nombre1 = txtNombre1Madre.Text
            '    objPersonasMadre.Nombre2 = txtNombre2Madre.Text
            '    objPersonasMadre.Apellido1 = txtApellido1Madre.Text
            '    objPersonasMadre.Apellido2 = txtApellido2Madre.Text

            '    If chkExtrajeneroM.Checked Then
            '        objPersonasMadre.Cedula = String.Empty
            '    Else
            '        'validamos que la cedula que se esta actualizando no exista
            '        Dim objPCompara = New StbPersona
            '        If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
            '            If Me.txtCedulaMadre.Text <> "   -      -" Then
            '                objPCompara.RetrieveByFilter(" Cedula='" + Me.txtCedulaMadre.Text + "'", T)
            '                If objPCompara.Cedula <> Nothing Then
            '                    If objPCompara.Cedula.Trim <> String.Empty Then
            '                        Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula de la madre ya existe en el sistema.")
            '                        Me.txtCedulaMadre.Focus()
            '                        T.RollbackTran()
            '                        Exit Sub
            '                    End If
            '                End If
            '            End If
            '        End If
            '        objPersonasMadre.Cedula = txtCedulaMadre.Text
            '    End If

            '    objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
            '    objPersonasMadre.Direccion = txtDireccionMadre.Text
            '    objPersonasMadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '    objPersonasMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '    objPersonasMadre.FechaCreacion = fechaServidor
            '    objPersonasMadre.Insert(T)
            '    idpersonaMadre = objPersonasMadre.StbPersonaID

            '    Me.InsertarDetalleMadre(Me.idpersonaMadre, T)
            'Else
            '    Dim objPersonasMadre As New StbPersona
            '    objPersonasMadre.Retrieve(idpersonaMadre, T)

            '    objPersonasMadre.Nombre1 = txtNombre1Madre.Text
            '    objPersonasMadre.Nombre2 = txtNombre2Madre.Text
            '    objPersonasMadre.Apellido1 = txtApellido1Madre.Text
            '    objPersonasMadre.Apellido2 = txtApellido2Madre.Text

            '    'validamos que la cedula que se esta actualizando no exista
            '    Dim objPCompara = New StbPersona
            '    If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
            '        If Me.txtCedulaMadre.Text <> "   -      -" Then

            '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaMadre & " AND Cedula='" + Me.txtCedulaMadre.Text + "'", T)
            '            If objPCompara.Cedula <> Nothing Then
            '                If objPCompara.Cedula.Trim <> String.Empty Then
            '                    Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula del padre ya existe en el sistema.")
            '                    Me.txtCedulaMadre.Focus()
            '                    T.RollbackTran()
            '                    Exit Sub
            '                End If
            '            End If
            '        End If
            '    End If
            '    objPersonasMadre.Cedula = txtCedulaMadre.Text
            '    objPersonasMadre.Direccion = txtDireccionMadre.Text
            '    objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
            '    objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
            '    objPersonasMadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
            '    objPersonasMadre.FechaModificacion = fechaServidor
            '    objPersonasMadre.Update(T)
            'End If

            'Dim objMadre As New StbPadres
            'objMadre.objAlumnoID = idalumno
            'objMadre.objPersonaID = Me.idpersonaMadre
            'objMadre.objReligionID = cmbReligionMadre.SelectedValue
            'objMadre.Ocupacion = txtOcupacionMadre.Text
            'objMadre.Profesion = txtProfesionMadre.Text
            'objMadre.NivelAcademico = txtNivelAcademicoM.Text

            'objMadre.Madre = True
            'objMadre.LugarTrabajo = txtLugarTrabajoResponsable.Text
            'objMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            'objMadre.FechaCreacion = fechaServidor
            '    objMadre.Insert(T)
            ''Else
            ''    T.RollbackTran()
            ''    Exit Sub
            ''End If
#End Region

#Region "RESPONSABLE"

            '''Registrar Responsable
            'If Not boolPersonaExistenteResponsable Then
            '    Dim objPersonasResponsable As New StbPersona

            '    'If ValidarPersonasResponsable() Then
            '    objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
            '    objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
            '    objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
            '    objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text

            '    If chkExtrajenjeroR.Checked Then
            '        objPersonasResponsable.Cedula = String.Empty
            '    Else
            '        'validamos que la cedula que se esta actualizando no exista
            '        Dim objPCompara = New StbPersona
            '        If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
            '            If Me.txtCedulaResponsable.Text <> "   -      -" Then
            '                objPCompara.RetrieveByFilter(" Cedula='" + Me.txtCedulaResponsable.Text + "'", T)
            '                If objPCompara.Cedula <> Nothing Then
            '                    If objPCompara.Cedula.Trim <> String.Empty Then
            '                        Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del responsable ya existe en el sistema.")
            '                        Me.txtCedulaResponsable.Focus()
            '                        T.RollbackTran()
            '                        Exit Sub
            '                    End If
            '                End If
            '            End If
            '        End If
            '        objPersonasResponsable.Cedula = txtCedulaResponsable.Text
            '    End If

            '    objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked
            '    objPersonasResponsable.Direccion = txtDireccionResponsable.Text
            '    objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '    objPersonasResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
            '    objPersonasResponsable.FechaCreacion = fechaServidor
            '    objPersonasResponsable.Insert(T)
            '    idpersonaResponsable = objPersonasResponsable.StbPersonaID

            '    Me.InsertarDetalleReponsable(Me.idpersonaResponsable, T)
            'Else
            '    Dim objPersonasResponsable As New StbPersona
            '    objPersonasResponsable.Retrieve(idpersonaResponsable, T)

            '    objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
            '    objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
            '    objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
            '    objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text

            '    'validamos que la cedula que se esta actualizando no exista
            '    Dim objPCompara = New StbPersona
            '    If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
            '        If Me.txtCedulaResponsable.Text <> "   -      -" Then
            '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaResponsable & " AND Cedula='" + Me.txtCedulaResponsable.Text + "'", T)
            '            If objPCompara.Cedula <> Nothing Then
            '                If objPCompara.Cedula.Trim <> String.Empty Then
            '                    Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del responsable ya existe en el sistema.")
            '                    Me.txtCedulaResponsable.Focus()
            '                    T.RollbackTran()
            '                    Exit Sub
            '                End If
            '            End If
            '        End If
            '    End If

            '        objPersonasResponsable.Cedula = txtCedulaResponsable.Text
            '    objPersonasResponsable.Direccion = txtDireccionResponsable.Text
            '    objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            '    objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked

            '    objPersonasResponsable.UsuarioModificacion = clsProyecto.Conexion.Usuario
            '    objPersonasResponsable.FechaModificacion = fechaServidor
            '    objPersonasResponsable.Update(T)
            'End If


            'Dim objResponsable As New StbResponsable
            'objResponsable.objAlumnoID = idalumno
            'objResponsable.objPersonaID = Me.idpersonaResponsable
            'objResponsable.objReligionID = cmbReligionResponsable.SelectedValue
            'objResponsable.Ocupacion = txtOcupacionResponsable.Text
            'objResponsable.Profesion = txtProfesionResponsable.Text
            'objResponsable.NivelAcademico = txtNivelAcademicoR.Text
            'objResponsable.LugarTrabajo = txtLugarTrabajoResponsable.Text
            'objResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
            'objResponsable.FechaCreacion = fechaServidor
            'objResponsable.Insert(T)
            ''Else
            ''    T.RollbackTran()
            ''    Exit Sub
            ''End If
#End Region

            ''Registrar Enfermedades
            Dim objEnfermedades As New StbAlumno_Enfermedad

            For Each dr As DataRow In DtDetalleEnfermedades.Rows
                objEnfermedades.objAumnoID = Me.idalumno
                objEnfermedades.objEnfermedadID = CInt(dr("objEnfermedadID").ToString)
                objEnfermedades.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEnfermedades.FechaCreacion = fechaServidor
                objEnfermedades.Insert(T)
            Next

            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonas = Nothing

        End Try


    End Sub
#End Region

#Region "Insertar Detalle de Personas"

    Private Sub InsertarDetallePadre(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            StbContactos.DeleteByFilter("objPersonaID=" & IDGenerado, t)
            StbPersonaClasificacion.DeleteByFilter("objPersonaID=" & IDGenerado, t)

            'Guardar Contactos
            For Each dr As DataRow In dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = fechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Padre'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = fechaServidor
            objClasifica.Insert(t)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try
    End Sub


    Private Sub InsertarDetalleMadre(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            StbContactos.DeleteByFilter("objPersonaID=" & IDGenerado, t)
            StbPersonaClasificacion.DeleteByFilter("objPersonaID=" & IDGenerado, t)

            'Guardar Contactos
            For Each dr As DataRow In dtContactosMadre.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = fechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Madre'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = fechaServidor
            objClasifica.Insert(t)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try
    End Sub

    Private Sub InsertarDetalleAlumno(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            StbContactos.DeleteByFilter("objPersonaID=" & IDGenerado, t)
            StbPersonaClasificacion.DeleteByFilter("objPersonaID=" & IDGenerado, t)

            'Guardar Contactos
            For Each dr As DataRow In dtContactosResponsable.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = fechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Alumno'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = fechaServidor
            objClasifica.Insert(t)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try
    End Sub

    Private Sub InsertarDetalleReponsable(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            StbContactos.DeleteByFilter("objPersonaID=" & IDGenerado, t)
            StbPersonaClasificacion.DeleteByFilter("objPersonaID=" & IDGenerado, t)

            'Guardar Contactos
            For Each dr As DataRow In dtContactosResponsable.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = fechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='OtroResponsable'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = fechaServidor
            objClasifica.Insert(t)
        Catch ex As Exception
            t.RollbackTran()
            clsError.CaptarError(ex)
        Finally
            objContactos = Nothing
            objClasifica = Nothing
        End Try
    End Sub

    Private Sub InsertarDetalle(ByVal IDGenerado As String, t As TransactionManager)

        Dim objContactos As StbContactos
        Dim objClasifica As StbPersonaClasificacion

        Try
            objContactos = New StbContactos
            objClasifica = New StbPersonaClasificacion

            'Guardar Contactos
            For Each dr As DataRow In frmStbAlumnosEdit.dtContactos.Rows
                objContactos.objPersonaID = IDGenerado
                objContactos.SecuencialContacto = CInt(dr("SecuencialContacto").ToString)
                objContactos.objTipoEntradaID = CInt(dr("objTipoEntradaID").ToString)
                objContactos.Valor = dr("Valor").ToString
                objContactos.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objContactos.FechaCreacion = fechaServidor
                objContactos.Insert(t)
            Next

            objClasifica.objPersonaID = IDGenerado
            objClasifica.objTipoPersonaID = StbTipoPersona.RetrieveDT("Descripcion='Cliente'").DefaultView.Item(0)("StbTipoPersonaID")
            objClasifica.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objClasifica.FechaCreacion = fechaServidor
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
        Dim objPersonasAlumno As StbPersona
        Dim objAlumno As StbAlumnos
        Dim objPadre As StbPadres
        Dim objMadre As StbPadres
        Dim objResponsable As StbResponsable
        Dim objPersonaPadre As StbPersona
        Dim objPersonaMadre As StbPersona
        Dim objPersonaResponsable As StbPersona

        Try
            'Cargar datos de la persona - alumno

            objPersonasAlumno = New StbPersona
            objPersonasAlumno.RetrieveByFilter("StbPersonaID=" + Me.idpersona)

            Me.txtPrimerNombre.Text = objPersonasAlumno.Nombre1
            Me.txtSegundoNombre.Text = objPersonasAlumno.Nombre2
            Me.txtPrimerApellido.Text = objPersonasAlumno.Apellido1
            Me.txtSegundoApellido.Text = objPersonasAlumno.Apellido2

            If Not IsNothing(objPersonasAlumno.objGeneroID) Then
                Me.cmbGenero.SelectedValue = objPersonasAlumno.objGeneroID
            End If
           
            If objPersonasAlumno.FechaNacimiento.ToString.Length <> 0 Then
                Me.dtpFechaNacimiento.Value = objPersonasAlumno.FechaNacimiento
            End If

            If Not IsNothing(objPersonasAlumno.objCiudadID) Then
                Me.cmbciudad.SelectedValue = objPersonasAlumno.objCiudadID
            End If

            Me.txtDireccion.Text = objPersonasAlumno.Direccion

            'Cargar datos del alumno
            objAlumno = New StbAlumnos
            objAlumno.RetrieveByFilter("objPersonaID=" + Me.idpersona)

            If Not IsNothing(objAlumno.CodigoMED) Then
                txtCodigoMined.Text = objAlumno.CodigoMED
            End If

            chkActivo.Checked = objAlumno.Activo

            If Not IsNothing(objAlumno.Extranjero) Then
                chkAlumnoExtranjero.Checked = objAlumno.Extranjero
            End If

            If Not IsNothing(objAlumno.LugarNacimientoExtranjero) Then
                txtLugarNacimiento.Text = objAlumno.LugarNacimientoExtranjero
            End If

            If Not IsNothing(objAlumno.objLugarNacimientoID) Then
                cmbLugarNacimiento.SelectedValue = objAlumno.objLugarNacimientoID
            End If

            If Not IsNothing(objAlumno.objReligionID) Then
                cmbReligion.SelectedValue = objAlumno.objReligionID
            End If

            If Not IsNothing(objAlumno.objResponsableID) Then
                cmbResposable.SelectedValue = objAlumno.objResponsableID
            End If

            txtCausa.Text = objAlumno.CausaIngreso
            txtObservaciones.Text = objAlumno.Observaciones
            txtImportancia.Text = objAlumno.Importancia
            txtInformacion.Text = objAlumno.InformacionCentro
            txtEspera.Text = objAlumno.Espera
            Me.idalumno = objAlumno.AlumnoID

            ''Cargar Informacion del padre
            objPadre = New StbPadres
            objPadre.RetrieveByFilter("objAlumnoID=" + Me.idalumno.ToString + " AND Madre=0")

            txtProfesionPadre.Text = objPadre.Profesion
            txtOcupacionPadre.Text = objPadre.Ocupacion
            txtLugarTrabajoPadre.Text = objPadre.LugarTrabajo

            If Not IsNothing(objPadre.NivelAcademico) Then
                txtNivelAcademicoP.Text = objPadre.NivelAcademico
            End If

            If Not IsNothing(objPadre.objReligionID) Then
                cmbReligionPadre.SelectedValue = objPadre.objReligionID
            End If

            If Not IsNothing(objPadre.objPersonaID) Then
                Me.idpersonaPadre = objPadre.objPersonaID
            Else
                Me.idpersonaPadre = 0
            End If


            objPersonaPadre = New StbPersona
            objPersonaPadre.RetrieveByFilter("StbPersonaID=" + idpersonaPadre)

            txtNombre1Padre.Text = objPersonaPadre.Nombre1
            txtNombre2Padre.Text = objPersonaPadre.Nombre2
            txtApellido1Padre.Text = objPersonaPadre.Apellido1
            txtApellido2Padre.Text = objPersonaPadre.Apellido2
            txtCedulaPadre.Text = objPersonaPadre.Cedula
            txtDireccionPadre.Text = objPersonaPadre.Direccion

            If Not IsNothing(objPersonaPadre.Extranjero) Then
                chkExtranjero.Checked = objPersonaPadre.Extranjero
            End If

            If Not IsNothing(objPersonaPadre.objEstadoCivilID) Then
                cmbEstadoCivilP.SelectedValue = objPersonaPadre.objEstadoCivilID
            End If

            ''Cargar Informacion de la madre
            objMadre = New StbPadres
            objMadre.RetrieveByFilter("objAlumnoID=" + Me.idalumno.ToString + " AND Madre=1")

            txtProfesionMadre.Text = objMadre.Profesion
            txtOcupacionMadre.Text = objMadre.Ocupacion
            txtLugarTrabajoMadre.Text = objMadre.LugarTrabajo

            If Not IsNothing(objMadre.NivelAcademico) Then
                txtNivelAcademicoM.Text = objMadre.NivelAcademico
            End If

            If Not IsNothing(objMadre.objReligionID) Then
                cmbReligionMadre.SelectedValue = objMadre.objReligionID
            End If

            If Not IsNothing(objMadre.objPersonaID) Then
                Me.idpersonaMadre = objMadre.objPersonaID
            Else
                Me.idpersonaMadre = 0
            End If


            objPersonaMadre = New StbPersona
            objPersonaMadre.RetrieveByFilter("StbPersonaID=" + idpersonaMadre)

            txtNombre1Madre.Text = objPersonaMadre.Nombre1
            txtNombre2Madre.Text = objPersonaMadre.Nombre2
            txtApellido1Madre.Text = objPersonaMadre.Apellido1
            txtApellido2Madre.Text = objPersonaMadre.Apellido2
            txtCedulaMadre.Text = objPersonaMadre.Cedula
            txtDireccionMadre.Text = objPersonaMadre.Direccion

            If Not IsNothing(objPersonaMadre.Extranjero) Then
                chkExtrajeneroM.Checked = objPersonaMadre.Extranjero
            End If

            If Not IsNothing(objPersonaMadre.objEstadoCivilID) Then
                cmbEstadoCivilM.SelectedValue = objPersonaMadre.objEstadoCivilID
            End If

            ''Cargar Informacion del responsable
            objResponsable = New StbResponsable
            objResponsable.RetrieveByFilter("objAlumnoID=" + Me.idalumno.ToString)

            txtProfesionResponsable.Text = objResponsable.Profesion
            txtOcupacionResponsable.Text = objResponsable.Ocupacion
            txtLugarTrabajoResponsable.Text = objResponsable.LugarTrabajo

            If Not IsNothing(objResponsable.NivelAcademico) Then
                txtNivelAcademicoR.Text = objResponsable.NivelAcademico
            End If

            If Not IsNothing(objResponsable.objReligionID) Then
                cmbReligionResponsable.SelectedValue = objResponsable.objReligionID
            End If


            If Not IsNothing(objResponsable.objPersonaID) Then
                Me.idpersonaResponsable = objResponsable.objPersonaID
            Else
                Me.idpersonaResponsable = 0
            End If

            If Not IsNothing(objResponsable.objParentescoID) Then
                Me.cmbParentesco.SelectedValue = objResponsable.objParentescoID
            End If

            objPersonaResponsable = New StbPersona
            objPersonaResponsable.RetrieveByFilter("StbPersonaID=" + idpersonaResponsable)

            txtNombre1Responsable.Text = objPersonaResponsable.Nombre1
            txtNombre2Responsable.Text = objPersonaResponsable.Nombre2
            txtApellido1Responsable.Text = objPersonaResponsable.Apellido1
            txtApellido2Responsable.Text = objPersonaResponsable.Apellido2
            txtCedulaResponsable.Text = objPersonaResponsable.Cedula
            txtDireccionResponsable.Text = objPersonaResponsable.Direccion

            If Not IsNothing(objPersonaResponsable.Extranjero) Then
                chkExtrajenjeroR.Checked = objPersonaResponsable.Extranjero
            End If

            If Not IsNothing(objPersonaResponsable.objEstadoCivilID) Then
                cmbEstadoCivilR.SelectedValue = objPersonaResponsable.objEstadoCivilID
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonasAlumno = Nothing
        End Try

    End Sub

#End Region

#Region "Editar Alumnos"

    Private Sub EditarPersonas()
        Try
            If Me.ValidarNumeroTelefono Then
                If Me.ValidarPersonasAlumno() Then
                    Me.ModificarAlumno()
                End If
            Else
                Me.GuardarContactosTemp()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Actualizar persona padre"
    Private Sub ActualizarPadre(t As TransactionManager)
        Dim objPersonasPadre As StbPersona
        Try
            objPersonasPadre = New StbPersona
            If Not boolPersonaExistentePadre Then

                objPersonasPadre.Nombre1 = txtNombre1Padre.Text
                objPersonasPadre.Nombre2 = txtNombre2Padre.Text
                objPersonasPadre.Apellido1 = txtApellido1Padre.Text
                objPersonasPadre.Apellido2 = txtApellido2Padre.Text
                objPersonasPadre.Cedula = txtCedulaPadre.Text
                objPersonasPadre.Direccion = txtDireccionPadre.Text
                objPersonasPadre.Extranjero = chkExtranjero.Checked
                objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
                objPersonasPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPersonasPadre.FechaCreacion = fechaServidor
                objPersonasPadre.Insert(t)

#Region "Se omite esta validacion por datos duplicados"
                '''Buscamos una persona con esta identificacion si no esta en blanco
                'If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaPadre.Text <> "   -      -" Then
                '        objPersonasPadre.RetrieveByFilter("cedula='" + Me.txtCedulaPadre.Text.Trim + "'", t)
                '    End If
                'End If

                'idpersonaPadre = objPersonasPadre.StbPersonaID

                'If idpersonaPadre <> 0 Then

                '    objPersonasPadre.Retrieve(idpersonaPadre, t)
                '    objPersonasPadre.Nombre1 = txtNombre1Padre.Text
                '    objPersonasPadre.Nombre2 = txtNombre2Padre.Text
                '    objPersonasPadre.Apellido1 = txtApellido1Padre.Text
                '    objPersonasPadre.Apellido2 = txtApellido2Padre.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaPadre.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaPadre & " AND Cedula='" + Me.txtCedulaPadre.Text + "'", t)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then
                '                    Me.ErrPrv.SetError(Me.txtCedulaPadre, "La cédula del padre ya existe en el sistema.")
                '                    Me.txtCedulaPadre.Focus()
                '                    t.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If
                '    objPersonasPadre.Cedula = txtCedulaPadre.Text
                '    objPersonasPadre.Direccion = txtDireccionPadre.Text
                '    objPersonasPadre.Extranjero = chkExtranjero.Checked
                '    objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
                '    objPersonasPadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
                '    objPersonasPadre.FechaModificacion = fechaServidor
                '    objPersonasPadre.Update(t)
                'Else

                '    objPersonasPadre.Nombre1 = txtNombre1Padre.Text
                '    objPersonasPadre.Nombre2 = txtNombre2Padre.Text
                '    objPersonasPadre.Apellido1 = txtApellido1Padre.Text
                '    objPersonasPadre.Apellido2 = txtApellido2Padre.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaPadre.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter(" Cedula='" + Me.txtCedulaPadre.Text + "'", t)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then
                '                    Me.ErrPrv.SetError(Me.txtCedulaPadre, "La cédula del padre ya existe en el sistema.")
                '                    Me.txtCedulaPadre.Focus()
                '                    t.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If

                '    objPersonasPadre.Cedula = txtCedulaPadre.Text
                '    objPersonasPadre.Direccion = txtDireccionPadre.Text
                '    objPersonasPadre.Extranjero = chkExtranjero.Checked
                '    objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
                '    objPersonasPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
                '    objPersonasPadre.FechaCreacion = fechaServidor
                '    objPersonasPadre.Insert(t)
                'End If
#End Region

            Else
                objPersonasPadre.Retrieve(idpersonaPadre, t)
                objPersonasPadre.Nombre1 = txtNombre1Padre.Text
                objPersonasPadre.Nombre2 = txtNombre2Padre.Text
                objPersonasPadre.Apellido1 = txtApellido1Padre.Text
                objPersonasPadre.Apellido2 = txtApellido2Padre.Text

                ''validamos que la cedula que se esta actualizando no exista
                'Dim objPCompara = New StbPersona
                'If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaPadre.Text <> "   -      -" Then
                '        objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaPadre & " AND Cedula='" + Me.txtCedulaPadre.Text + "'", t)
                '        If objPCompara.Cedula <> Nothing Then
                '            If objPCompara.Cedula.Trim <> String.Empty Then
                '                Me.ErrPrv.SetError(Me.txtCedulaPadre, "La cédula del padre ya existe en el sistema.")
                '                Me.txtCedulaPadre.Focus()
                '                t.RollbackTran()
                '                Exit Sub
                '            End If
                '        End If
                '    End If
                'End If
                objPersonasPadre.Cedula = txtCedulaPadre.Text
            objPersonasPadre.Direccion = txtDireccionPadre.Text
            objPersonasPadre.Extranjero = chkExtranjero.Checked
            objPersonasPadre.objEstadoCivilID = cmbEstadoCivilP.SelectedValue
            objPersonasPadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonasPadre.FechaModificacion = fechaServidor
            objPersonasPadre.Update(t)
        End If

        Me.idpersonaPadre = objPersonasPadre.StbPersonaID
        Me.InsertarDetallePadre(Me.idpersonaPadre, t)

        Dim objPadre As New StbPadres
            StbPadres.DeleteByFilter("objAlumnoID=" + idalumno.ToString + " AND Madre=0", t)

            If idpersonaPadre <> 0 Then
                ''Actualizar al Padre
                objPadre.objAlumnoID = idalumno
                objPadre.objPersonaID = Me.idpersonaPadre
                objPadre.objReligionID = cmbReligionPadre.SelectedValue
                objPadre.Ocupacion = txtOcupacionPadre.Text
                objPadre.Profesion = txtProfesionPadre.Text
                objPadre.LugarTrabajo = txtLugarTrabajoPadre.Text
                objPadre.NivelAcademico = txtNivelAcademicoP.Text
                objPadre.Madre = False
                objPadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPadre.FechaCreacion = fechaServidor
                objPadre.Insert(t)
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
            t.RollbackTran()
        Finally
            objPersonasPadre = Nothing

        End Try
    End Sub
#End Region

#Region "Actualizar persona Madre"

    Private Sub ActualizarMadre(T As TransactionManager)
        Dim objPersonasMadre As New StbPersona
        Try
            If Not boolPersonaExistenteMadre Then

                objPersonasMadre.Nombre1 = txtNombre1Madre.Text
                objPersonasMadre.Nombre2 = txtNombre2Madre.Text
                objPersonasMadre.Apellido1 = txtApellido1Madre.Text
                objPersonasMadre.Apellido2 = txtApellido2Madre.Text
                objPersonasMadre.Cedula = txtCedulaMadre.Text
                objPersonasMadre.Direccion = txtDireccionMadre.Text
                objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
                objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
                objPersonasMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPersonasMadre.FechaCreacion = fechaServidor
                objPersonasMadre.Insert(T)

#Region "Se omite esta validacion por duplicados"

                ''Buscamos una persona con esta identificacion si no esta en blanco
                'If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaMadre.Text <> "   -      -" Then
                '        objPersonasMadre.RetrieveByFilter("cedula='" + Me.txtCedulaMadre.Text.Trim + "'", T)
                '    End If
                'End If
                'idpersonaMadre = objPersonasMadre.StbPersonaID
                'If idpersonaMadre <> 0 Then

                '    objPersonasMadre.Retrieve(idpersonaMadre, T)
                '    objPersonasMadre.Nombre1 = txtNombre1Madre.Text
                '    objPersonasMadre.Nombre2 = txtNombre2Madre.Text
                '    objPersonasMadre.Apellido1 = txtApellido1Madre.Text
                '    objPersonasMadre.Apellido2 = txtApellido2Madre.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaMadre.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaMadre & " AND Cedula='" + Me.txtCedulaMadre.Text + "'", T)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then
                '                    Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula del padre ya existe en el sistema.")
                '                    Me.txtCedulaMadre.Focus()
                '                    T.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If
                '    objPersonasMadre.Cedula = txtCedulaMadre.Text
                '    objPersonasMadre.Direccion = txtDireccionMadre.Text
                '    objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
                '    objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
                '    objPersonasMadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
                '    objPersonasMadre.FechaModificacion = fechaServidor
                '    objPersonasMadre.Update(T)
                'Else
                '    objPersonasMadre.Nombre1 = txtNombre1Madre.Text
                '    objPersonasMadre.Nombre2 = txtNombre2Madre.Text
                '    objPersonasMadre.Apellido1 = txtApellido1Madre.Text
                '    objPersonasMadre.Apellido2 = txtApellido2Madre.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaMadre.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter(" Cedula='" + Me.txtCedulaMadre.Text + "'", T)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then
                '                    Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula del padre ya existe en el sistema.")
                '                    Me.txtCedulaMadre.Focus()
                '                    T.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If
                '    objPersonasMadre.Cedula = txtCedulaMadre.Text
                '    objPersonasMadre.Direccion = txtDireccionMadre.Text
                '    objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
                '    objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
                '    objPersonasMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
                '    objPersonasMadre.FechaCreacion = fechaServidor
                '    objPersonasMadre.Insert(T)
                'End If

#End Region

            Else
                objPersonasMadre.Retrieve(idpersonaMadre, T)
            objPersonasMadre.Nombre1 = txtNombre1Madre.Text
            objPersonasMadre.Nombre2 = txtNombre2Madre.Text
            objPersonasMadre.Apellido1 = txtApellido1Madre.Text
            objPersonasMadre.Apellido2 = txtApellido2Madre.Text

                ''validamos que la cedula que se esta actualizando no exista
                'Dim objPCompara = New StbPersona
                'If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaMadre.Text <> "   -      -" Then
                '        objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaMadre & " AND Cedula='" + Me.txtCedulaMadre.Text + "'", T)
                '        If objPCompara.Cedula <> Nothing Then
                '            If objPCompara.Cedula.Trim <> String.Empty Then
                '                Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula del padre ya existe en el sistema.")
                '                Me.txtCedulaMadre.Focus()
                '                T.RollbackTran()
                '                Exit Sub
                '            End If
                '        End If
                '    End If
                'End If
                objPersonasMadre.Cedula = txtCedulaMadre.Text
            objPersonasMadre.Direccion = txtDireccionMadre.Text
            objPersonasMadre.Extranjero = chkExtrajeneroM.Checked
            objPersonasMadre.objEstadoCivilID = cmbEstadoCivilM.SelectedValue
            objPersonasMadre.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonasMadre.FechaModificacion = fechaServidor
            objPersonasMadre.Update(T)
        End If

        Me.idpersonaMadre = objPersonasMadre.StbPersonaID
        Me.InsertarDetalleMadre(Me.idpersonaMadre, T)

        Dim objMadre As New StbPadres
            StbPadres.DeleteByFilter("objAlumnoID=" + idalumno.ToString + " AND Madre=1", T)
            ''Actualizar Madre
            objMadre.objAlumnoID = idalumno
            objMadre.objPersonaID = Me.idpersonaMadre
            objMadre.objReligionID = cmbReligionMadre.SelectedValue
            objMadre.Ocupacion = txtOcupacionMadre.Text
            objMadre.Profesion = txtProfesionMadre.Text
            objMadre.LugarTrabajo = txtLugarTrabajoMadre.Text
            objMadre.NivelAcademico = txtNivelAcademicoM.Text
            objMadre.Madre = True
            objMadre.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objMadre.FechaCreacion = fechaServidor
            objMadre.Insert(T)

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        Finally
            objPersonasMadre = Nothing

        End Try
    End Sub
#End Region

#Region "Actualizar persona Responsable"
    Private Sub ActualizarResponsable(t As TransactionManager)
        Dim objPersonasResponsable As StbPersona
        Try
            objPersonasResponsable = New StbPersona

            If Not boolPersonaExistenteResponsable Then

                objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
                objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
                objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
                objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text
                objPersonasResponsable.Cedula = txtCedulaResponsable.Text
                objPersonasResponsable.Direccion = txtDireccionResponsable.Text
                objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked
                objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilR.SelectedValue
                objPersonasResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objPersonasResponsable.FechaCreacion = fechaServidor
                objPersonasResponsable.Insert(t)

#Region "Se omite esta validacion por datos duplicados"

                '''Buscamos una persona con esta identificacion si no esta en blanco
                'If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaResponsable.Text <> "   -      -" Then
                '        objPersonasResponsable.RetrieveByFilter("cedula='" + Me.txtCedulaResponsable.Text.Trim + "'", t)
                '    End If
                'End If

                'idpersonaResponsable = objPersonasResponsable.StbPersonaID

                'If idpersonaResponsable <> 0 Then
                '    objPersonasResponsable.Retrieve(idpersonaResponsable, t)
                '    objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
                '    objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
                '    objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
                '    objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaResponsable.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaResponsable & " AND Cedula='" + Me.txtCedulaResponsable.Text + "'", t)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then
                '                    Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del responsable ya existe en el sistema.")
                '                    Me.txtCedulaResponsable.Focus()
                '                    t.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If
                '    objPersonasResponsable.Cedula = txtCedulaResponsable.Text
                '    objPersonasResponsable.Direccion = txtDireccionResponsable.Text
                '    objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked
                '    objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilR.SelectedValue
                '    objPersonasResponsable.UsuarioModificacion = clsProyecto.Conexion.Usuario
                '    objPersonasResponsable.FechaModificacion = fechaServidor
                '    objPersonasResponsable.Update(t)
                'Else
                '    objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
                '    objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
                '    objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
                '    objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text

                '    'validamos que la cedula que se esta actualizando no exista
                '    Dim objPCompara = New StbPersona
                '    If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
                '        If Me.txtCedulaResponsable.Text <> "   -      -" Then
                '            objPCompara.RetrieveByFilter(" Cedula='" + Me.txtCedulaResponsable.Text + "'", t)
                '            If objPCompara.Cedula <> Nothing Then
                '                If objPCompara.Cedula.Trim <> String.Empty Then

                '                    Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del responsable ya existe en el sistema.")
                '                    Me.txtCedulaResponsable.Focus()
                '                    t.RollbackTran()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    End If

                '    objPersonasResponsable.Cedula = txtCedulaResponsable.Text
                '    objPersonasResponsable.Direccion = txtDireccionResponsable.Text
                '    objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked
                '    objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilR.SelectedValue
                '    objPersonasResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
                '    objPersonasResponsable.FechaCreacion = fechaServidor
                '    objPersonasResponsable.Insert(t)
                'End If

#End Region

            Else
                objPersonasResponsable.Retrieve(idpersonaResponsable, t)

                objPersonasResponsable.Nombre1 = txtNombre1Responsable.Text
                objPersonasResponsable.Nombre2 = txtNombre2Responsable.Text
                objPersonasResponsable.Apellido1 = txtApellido1Responsable.Text
                objPersonasResponsable.Apellido2 = txtApellido2Responsable.Text

                ''validamos que la cedula que se esta actualizando no exista
                'Dim objPCompara = New StbPersona
                'If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
                '    If Me.txtCedulaResponsable.Text <> "   -      -" Then
                '        objPCompara.RetrieveByFilter("StbPersonaID<> " & idpersonaResponsable & " AND Cedula='" + Me.txtCedulaResponsable.Text + "'", t)
                '        If objPCompara.Cedula <> Nothing Then
                '            If objPCompara.Cedula.Trim <> String.Empty Then
                '                Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del responsable ya existe en el sistema.")
                '                Me.txtCedulaResponsable.Focus()
                '                t.RollbackTran()
                '                Exit Sub
                '            End If
                '        End If
                '    End If
                'End If
                objPersonasResponsable.Cedula = txtCedulaResponsable.Text
                objPersonasResponsable.Direccion = txtDireccionResponsable.Text
                objPersonasResponsable.Extranjero = chkExtrajenjeroR.Checked
                objPersonasResponsable.objEstadoCivilID = cmbEstadoCivilR.SelectedValue
                objPersonasResponsable.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objPersonasResponsable.FechaModificacion = fechaServidor
                objPersonasResponsable.Update(t)
            End If

            idpersonaResponsable = objPersonasResponsable.StbPersonaID
            Me.InsertarDetalleReponsable(Me.idpersonaResponsable, t)

            Dim objResponsable As New StbResponsable
            StbResponsable.DeleteByFilter("objAlumnoID=" + idalumno.ToString, t)

            ''Actualizar responsable
            objResponsable.objAlumnoID = idalumno
            objResponsable.objPersonaID = Me.idpersonaResponsable
            objResponsable.objReligionID = cmbReligionResponsable.SelectedValue
            objResponsable.Ocupacion = txtOcupacionResponsable.Text
            objResponsable.Profesion = txtProfesionResponsable.Text
            objResponsable.LugarTrabajo = txtLugarTrabajoResponsable.Text
            objResponsable.NivelAcademico = txtNivelAcademicoR.Text
            objResponsable.objParentescoID = cmbParentesco.SelectedValue
            objResponsable.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objResponsable.FechaCreacion = fechaServidor
            objResponsable.Insert(t)

        Catch ex As Exception
            clsError.CaptarError(ex)
            t.RollbackTran()
        Finally
            objPersonasResponsable = Nothing

        End Try
    End Sub
#End Region

#Region "Modificar Personas"
    Private Sub ModificarAlumno()
        Dim objPersonas, objPersonasPadre As StbPersona

        Dim objAlumno As StbAlumnos
        Dim T As New DAL.TransactionManager
        Dim da As DateTime = DateTime.Now
        Try
            T.BeginTran()
            objPersonas = New StbPersona
            objPersonas.Retrieve(idpersona, T)

            objAlumno = New StbAlumnos
            objPersonasPadre = New StbPersona

            ''PROCEDER A ACTUALIZAR
            objPersonas.Nombre1 = txtPrimerNombre.Text
            objPersonas.Nombre2 = txtSegundoNombre.Text
            objPersonas.Apellido1 = txtPrimerApellido.Text
            objPersonas.Apellido2 = txtSegundoApellido.Text
            objPersonas.objGeneroID = cmbGenero.SelectedValue

            If Me.dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                objPersonas.FechaNacimiento = Me.dtpFechaNacimiento.Text
            Else
                objPersonas.FechaNacimiento = Nothing
            End If

            objPersonas.objPaisID = StbCiudad.RetrieveDT("StbCiudadID=" & cmbciudad.SelectedValue).DefaultView(0)("objPaisID")
            objPersonas.objCiudadID = cmbciudad.SelectedValue
            objPersonas.Direccion = txtDireccion.Text
            objPersonas.PersonaJuridica = False
            objPersonas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objPersonas.FechaModificacion = fechaServidor
            objPersonas.Update(T)

            objAlumno.RetrieveByFilter("objPersonaID=" + idpersona, T)

            ' ''Actualizar Alumnos
            objAlumno.objPersonaID = objPersonas.StbPersonaID
            objAlumno.CodigoMED = txtCodigoMined.Text
            objAlumno.objLugarNacimientoID = cmbLugarNacimiento.SelectedValue
            objAlumno.objReligionID = cmbReligion.SelectedValue
            objAlumno.objResponsableID = cmbResposable.SelectedValue
            objAlumno.InformacionCentro = txtInformacion.Text
            objAlumno.CausaIngreso = txtCausa.Text
            objAlumno.Importancia = txtImportancia.Text
            objAlumno.Espera = txtEspera.Text
            objAlumno.Observaciones = txtObservaciones.Text
            objAlumno.Activo = chkActivo.Checked
            objAlumno.Extranjero = chkAlumnoExtranjero.Checked
            objAlumno.LugarNacimientoExtranjero = txtLugarNacimiento.Text
            objAlumno.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objAlumno.FechaModificacion = fechaServidor
            objAlumno.Update(T)

            Me.idalumno = objAlumno.AlumnoID

            ActualizarPadre(T)
            ActualizarMadre(T)
            ActualizarResponsable(T)

            ''Registrar Enfermedades
            Dim objEnfermedades As New StbAlumno_Enfermedad
            StbAlumno_Enfermedad.DeleteByFilter("objAumnoID=" + Me.idalumno.ToString, T)

            For Each dr As DataRow In DtDetalleEnfermedades.Rows
                objEnfermedades.objAumnoID = Me.idalumno
                objEnfermedades.objEnfermedadID = CInt(dr("objEnfermedadID").ToString)
                objEnfermedades.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objEnfermedades.FechaCreacion = fechaServidor
                objEnfermedades.Insert(T)
            Next

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
            StbPersonaClasificacion.DeleteByFilter("objTipoPersonaID = (SELECT StbTipoPersonaID FROM StbTipoPersona WHERE Descripcion='Cliente') AND objPersonaID=" + Me.idpersona)
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
    Private Function ValidarCedulaPadre()
        Dim objPCompara = New StbPersona
        Try
            'Validar que haya algo en la cédula
            If Me.txtCedulaPadre.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedulaPadre, My.Resources.MsgObligatorio)
                Me.txtCedulaPadre.Focus()
                Return False
                Exit Function
            End If
            'Validar que no haya espacios intermedios
            For intCaracter As Integer = 0 To Me.txtCedulaPadre.Text.Trim.Length - 1
                If Me.txtCedulaPadre.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtCedulaPadre, "Número de Cédula no válido")
                    Me.txtCedulaPadre.Focus()
                    Return False
                    Exit Function
                End If
            Next
            'Validar que la fecha de la cédula sea válida
            If Me.txtCedulaPadre.Text.Trim.Length = 16 Then
                If Me.CedulaValida(Me.txtCedulaPadre.Text) = False Then
                    Me.ErrPrv.SetError(Me.txtCedulaPadre, "Número de Cédula no válido")
                    Me.txtCedulaPadre.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Return False
                Exit Function
            End If

            ''1.2 Validar que no exista  una persona con la misma cédula
            'If Me.txtCedulaPadre.Text.Trim.Length <> 0 Then
            '    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedulaPadre.Text + "'")
            '    If objPCompara.Cedula <> Nothing Then
            '        If objPCompara.Cedula.Trim <> String.Empty Then
            '            Me.ErrPrv.SetError(Me.txtCedulaPadre, "La cédula del padre ya existe en el sistema.")
            '            Me.txtCedulaPadre.Focus()
            '            Return False
            '            Exit Function
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Function ValidarCedulaMadre()
        Dim objPCompara = New StbPersona
        Try
            'Validar que haya algo en la cédula
            If Me.txtCedulaMadre.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedulaMadre, My.Resources.MsgObligatorio)
                Me.txtCedulaPadre.Focus()
                Return False
                Exit Function
            End If
            'Validar que no haya espacios intermedios
            For intCaracter As Integer = 0 To Me.txtCedulaMadre.Text.Trim.Length - 1
                If Me.txtCedulaMadre.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtCedulaMadre, "Número de Cédula no válido")
                    Me.txtCedulaMadre.Focus()
                    Return False
                    Exit Function
                End If
            Next
            'Validar que la fecha de la cédula sea válida
            If Me.txtCedulaMadre.Text.Trim.Length = 16 Then
                If Me.CedulaValida(Me.txtCedulaMadre.Text) = False Then
                    Me.ErrPrv.SetError(Me.txtCedulaMadre, "Número de Cédula no válido")
                    Me.txtCedulaMadre.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Return False
                Exit Function
            End If

            ''1.2 Validar que no exista  una persona con la misma cédula
            'If Me.txtCedulaMadre.Text.Trim.Length <> 0 Then
            '    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedulaMadre.Text + "'")
            '    If objPCompara.Cedula <> Nothing Then
            '        If objPCompara.Cedula.Trim <> String.Empty Then
            '            Me.ErrPrv.SetError(Me.txtCedulaMadre, "La cédula del padre ya existe en el sistema.")
            '            Me.txtCedulaMadre.Focus()
            '            Return False
            '            Exit Function
            '        End If
            '    End If
            'End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Function ValidarCedulaResponsable()
        Dim objPCompara = New StbPersona
        Try
            'Validar que haya algo en la cédula
            If Me.txtCedulaResponsable.Text.Trim.Replace(" ", "").Replace("-", "").Trim.Length = 0 Then
                Me.ErrPrv.SetError(Me.txtCedulaResponsable, My.Resources.MsgObligatorio)
                Me.txtCedulaResponsable.Focus()
                Return False
                Exit Function
            End If
            'Validar que no haya espacios intermedios
            For intCaracter As Integer = 0 To Me.txtCedulaResponsable.Text.Trim.Length - 1
                If Me.txtCedulaResponsable.Text.Substring(intCaracter, 1).Trim.Length = 0 Then
                    Me.ErrPrv.SetError(Me.txtCedulaResponsable, "Número de Cédula no válido")
                    Me.txtCedulaResponsable.Focus()
                    Return False
                    Exit Function
                End If
            Next
            'Validar que la fecha de la cédula sea válida
            If Me.txtCedulaResponsable.Text.Trim.Length = 16 Then
                If Me.CedulaValida(Me.txtCedulaResponsable.Text) = False Then
                    Me.ErrPrv.SetError(Me.txtCedulaResponsable, "Número de Cédula no válido")
                    Me.txtCedulaResponsable.Focus()
                    Return False
                    Exit Function
                End If
            Else
                Return False
                Exit Function
            End If


            ''1.2 Validar que no exista  una persona con la misma cédula
            'If Me.txtCedulaResponsable.Text.Trim.Length <> 0 Then
            '    objPCompara.RetrieveByFilter("Cedula='" + Me.txtCedulaResponsable.Text + "'")
            '    If objPCompara.Cedula <> Nothing Then
            '        If objPCompara.Cedula.Trim <> String.Empty Then
            '            Me.ErrPrv.SetError(Me.txtCedulaResponsable, "La cédula del padre ya existe en el sistema.")
            '            Me.txtCedulaResponsable.Focus()
            '            Return False
            '            Exit Function
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#Region "Validar Datos "
    Private Function ValidarPersonasAlumno()

        'Validar el codigo MED
        'If Me.txtCodigoMined.Text.Trim.Length = 0 Then
        '    Me.ErrPrv.SetError(Me.txtCodigoMined, "Debe ingresar el codigo del MED")
        '    Me.txtCodigoMined.Focus()
        '    Return False
        '    Exit Function
        'End If

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
            Me.ErrPrv.SetError(Me.cmbGenero, "Debe especificar el género del alumno")
            Me.cmbGenero.Focus()
            Return False
            Exit Function
        End If
        'Validar Fecha de nacimiento
        If Me.dtpFechaNacimiento.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "Debe especificar la fecha de nacimiento")
            Me.dtpFechaNacimiento.Focus()
            Return False
            Exit Function
        End If
        'Validar Ciudad
        If Me.cmbciudad.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbciudad, "Debe especificar la ciudad del alumno")
            Me.cmbciudad.Focus()
            Return False
            Exit Function
        End If

        'Validar Responsable
        If Me.cmbResposable.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbResposable, "Debe especificar el responsable del alumno")
            Me.cmbResposable.Focus()
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


        If Not chkExtranjero.Checked Then
            If cmbResposable.Text = "Padre" Then
                If Me.ValidarCedulaPadre = False Then
                    MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del padre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If

            '    If cmbResposable.Text = "Padre" Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del padre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
            'Else
            '    If cmbResposable.Text = "Padre" And Me.ValidarCedulaPadre = False Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del padre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
        End If

        If Not chkExtrajeneroM.Checked Then
            If cmbResposable.Text = "Madre" Then
                If Me.ValidarCedulaMadre = False Then
                    MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos de la madre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If

            End If

            '    If cmbResposable.Text = "Madre" Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos de la madre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
            'Else
            '    If cmbResposable.Text = "Madre" And Me.ValidarCedulaMadre = False Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos de la madre.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
        End If


        If Not chkExtrajenjeroR.Checked Then
            If cmbResposable.Text <> "Madre" And cmbResposable.Text <> "Padre" Then
                If Me.ValidarCedulaResponsable = False Then
                    MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del responsable.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                    Return False
                    Exit Function
                End If
            End If

            '    If cmbResposable.Text <> "Madre" And cmbResposable.Text <> "Padre" Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del responsable.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
            'Else
            '    If cmbResposable.Text <> "Madre" And cmbResposable.Text <> "Padre" And Me.ValidarCedulaResponsable = False Then
            '        MsgBox("No se puede ingresar el registro del alumno." + vbCrLf + "Debe registrar los datos del responsable.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

            '        Return False
            '        Exit Function
            '    End If
        End If



        'Validar la cédula
        'If Me.ValidarCedula = False Then
        '    Me.txtCedula.Focus()
        '    Return False
        '    Exit Function
        'End If


        'Validar que la fecha de nacimiento sea igual al número de cédula
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

    Private Function ValidarPersonasPadre()
        If chkExtranjero.Checked Then
            Return True
            Exit Function
        End If
        'Validar la cédula
        If Me.ValidarCedulaPadre = False Then
            Me.txtCedulaPadre.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Function ValidarPersonasMadre()
        If chkExtrajeneroM.Checked Then
            Return True
            Exit Function
        End If
        'Validar la cédula
        If Me.ValidarCedulaMadre = False Then
            Me.txtCedulaMadre.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Function ValidarPersonasResponsable()
        If chkExtrajenjeroR.Checked Then
            Return True
            Exit Function
        End If
        'Validar la cédula
        If Me.ValidarCedulaResponsable = False Then
            Me.txtCedulaResponsable.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function
#End Region

#Region "Cargar Grid Contactos"
    Private Sub CargarGridContactosPadre()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID=" & Me.idpersonaPadre
            End Select

            frmStbAlumnosEdit.dtContactos = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactosPadre.SetDataBinding(frmStbAlumnosEdit.dtContactos, "", True)
            Me.tdbContactosPadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            Else
                Me.cmdEliminarContacto.Enabled = True
            End If

            Me.tdbContactosPadre.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub CargarGridContactosMadre()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID=" & Me.idpersonaMadre
            End Select

            frmStbAlumnosEdit.dtContactosMadre = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactosMadre.SetDataBinding(frmStbAlumnosEdit.dtContactosMadre, "", True)
            Me.tdbContactosMadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosMadre.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactosMadre.Rows.Count = 0 Then
                Me.cmdEliminarContactoM.Enabled = False
            Else
                Me.cmdEliminarContactoM.Enabled = True
            End If

            Me.tdbContactosMadre.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub

    Private Sub CargarGridContactosResponsable()
        Try

            Dim strFiltro As String = "1=1"
            Select Case Me.TyGui
                Case 1
                    strFiltro = "1=0"
                Case 2, 3
                    strFiltro = "objPersonaID=" & Me.idpersonaResponsable
            End Select

            frmStbAlumnosEdit.dtContactosResponsable = DAL.SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("objPersonaID,SecuencialContacto,objTipoEntradaID,TipoEntrada,Valor", "vwPersonaContactos", strFiltro))
            Me.tdbContactosResponsable.SetDataBinding(frmStbAlumnosEdit.dtContactosResponsable, "", True)
            Me.tdbContactosResponsable.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosResponsable.Rows.Count & ")"

            If frmStbAlumnosEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContactoR.Enabled = False
            Else
                Me.cmdEliminarContactoR.Enabled = True
            End If

            Me.tdbContactosResponsable.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try

    End Sub
#End Region

#Region "Eliminar Contactos"
    Private Sub EliminarContactosPadre()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmStbAlumnosEdit.dtContactos.Rows.RemoveAt(Me.tdbContactosPadre.Row)
            Else
                Exit Sub
            End If
            If frmStbAlumnosEdit.dtContactos.Rows.Count = 0 Then
                Me.cmdEliminarContacto.Enabled = False
            End If
            Me.tdbContactosPadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub EliminarContactosMadre()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmStbAlumnosEdit.dtContactosMadre.Rows.RemoveAt(Me.tdbContactosMadre.Row)
            Else
                Exit Sub
            End If
            If frmStbAlumnosEdit.dtContactosMadre.Rows.Count = 0 Then
                Me.cmdEliminarContactoM.Enabled = False
            End If
            Me.tdbContactosMadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosMadre.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub EliminarContactosResponsable()
        Try
            If MsgBox(My.Resources.MsgConfirmarEliminar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                frmStbAlumnosEdit.dtContactosResponsable.Rows.RemoveAt(Me.tdbContactosResponsable.Row)
            Else
                Exit Sub
            End If
            If frmStbAlumnosEdit.dtContactosResponsable.Rows.Count = 0 Then
                Me.cmdEliminarContactoR.Enabled = False
            End If
            Me.tdbContactosResponsable.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosResponsable.Rows.Count & ")"
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
            objContactos.frmLLamado = 0
            objContactos.TipoPersona = 0
            objContactos.ShowDialog()
            If dtContactos.Rows.Count > 0 Then
                Me.cmdEliminarContacto.Enabled = True
            End If
            Me.tdbContactosPadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactos.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarContactosTempResponsable()
        Try
            Dim objContactos As frmStbPersonasContactos
            objContactos = New frmStbPersonasContactos
            objContactos.frmLLamado = 0
            objContactos.TipoPersona = 2
            objContactos.ShowDialog()
            If frmStbAlumnosEdit.dtContactosResponsable.Rows.Count > 0 Then
                Me.cmdEliminarContactoR.Enabled = True
            End If
            Me.tdbContactosResponsable.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosResponsable.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub GuardarContactosTempMadre()
        Try
            Dim objContactos As frmStbPersonasContactos
            objContactos = New frmStbPersonasContactos
            objContactos.frmLLamado = 0
            objContactos.TipoPersona = 1
            objContactos.ShowDialog()
            If frmStbAlumnosEdit.dtContactosMadre.Rows.Count > 0 Then
                Me.cmdEliminarContactoM.Enabled = True
            End If
            Me.tdbContactosMadre.Caption = "Contactos (" & frmStbAlumnosEdit.dtContactosMadre.Rows.Count & ")"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Propertys"
    Dim id_perLec, id_perLecPadre, id_perLecMadre, id_perLecResponsable As String
    Dim TyGui_Lec, TyGuiEsc, Llamado_Lec, id_alumno As Integer

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

    Property idpersonaPadre() As String
        Get
            Return id_perLecPadre
        End Get
        Set(ByVal value As String)
            id_perLecPadre = value
        End Set
    End Property

    Property idpersonaMadre() As String
        Get
            Return id_perLecMadre
        End Get
        Set(ByVal value As String)
            id_perLecMadre = value
        End Set
    End Property

    Property idpersonaResponsable() As String
        Get
            Return id_perLecResponsable
        End Get
        Set(ByVal value As String)
            id_perLecResponsable = value
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
        'Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            'Me.txtCedula.Focus()
        End If
    End Sub

    Private Sub dtpFechaNacimiento_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        'Me.ErrPrv.SetError(Me.txtCedula, "")
    End Sub

    Private Sub txtCedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
        'Me.ErrPrv.SetError(Me.txtCedula, "")
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        'Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub txtCedula_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Me.txtCedula.Text = Me.txtCedula.Text.ToUpper
    End Sub

    Private Sub dtpFechaNacimiento_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        'Me.ErrPrv.SetError(Me.txtCedula, "")
        If Asc(e.KeyChar) = 13 Then
            'Me.txtCedula.Focus()
        End If
    End Sub
    Private Sub dtpFechaNacimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrPrv.SetError(Me.dtpFechaNacimiento, "")
        'Me.ErrPrv.SetError(Me.txtCedula, "")
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
            fechaServidor = clsProyecto.Conexion.FechaServidor

            Select Case Me.TyGui
                Case 1
                    Me.AgregarAlumno()
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

    Private Sub cmdEliminarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.EliminarContactosPadre()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarContacto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub spnOrdenCobro_ValueChanged(sender As Object, e As EventArgs)



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
    Private Sub cmbRuta_TextChanged(sender As Object, e As EventArgs) Handles cmbReligion.TextChanged
        Me.ErrPrv.SetError(cmbReligion, "")
    End Sub
#End Region

#Region "Cargar el Formulario"

    Private Sub frmStbPersonasEditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            boolPersonaExistente = False
            Me.CargarLongitudesMaximas()
            CargarGenero()
            CargarCiudad()
            CargarReligion()
            CargarEnfermedad()
            CargarLugarNacimiento()
            CargarResponsable()
            CargarParentesco()
            CargarEstadoCivilPadre()
            CargarEstadoCivilMadre()
            CargarEstadoCivilResponsable()
            Select Case Me.TyGui
                Case 1
                    Me.Text = "Agregar Nuevo Alumno"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True

                    CargarGridContactosPadre()
                    CargarGridContactosMadre()
                    CargarGridContactosResponsable()
                    CargarDetalleEnfermedades("1=0")
                Case 2
                    Me.Text = "Editanto datos del Alumno: " & Me.idpersona
                    Me.chkActivo.Enabled = True
                    Me.CargarDatosEditar()
                    Me.txtPrimerNombre.Focus()
                    Me.cmdBuscar.Enabled = False

                    CargarGridContactosPadre()
                    CargarGridContactosMadre()
                    CargarGridContactosResponsable()
                    CargarDetalleEnfermedades("objAumnoID=" + idalumno.ToString)

                Case 3
                    Me.Text = "Consultando datos del Alumno: " & Me.idpersona

                    Me.CargarDatosEditar()
                    CargarGridContactosPadre()
                    CargarGridContactosMadre()
                    CargarGridContactosResponsable()
                    CargarDetalleEnfermedades("objAumnoID=" + idalumno.ToString)

                    Me.txtPrimerNombre.Enabled = False
                    txtNombre1Madre.Enabled = False
                    txtNombre1Padre.Enabled = False
                    txtNombre1Responsable.Enabled = False

                    Me.txtSegundoNombre.Enabled = False
                    Me.txtNombre2Madre.Enabled = False
                    Me.txtNombre2Padre.Enabled = False
                    Me.txtNombre2Responsable.Enabled = False

                    Me.txtPrimerApellido.Enabled = False
                    Me.txtApellido1Madre.Enabled = False
                    Me.txtApellido1Padre.Enabled = False
                    Me.txtApellido1Responsable.Enabled = False

                    Me.txtSegundoApellido.Enabled = False
                    Me.txtApellido2Madre.Enabled = False
                    Me.txtApellido2Padre.Enabled = False
                    Me.txtApellido2Responsable.Enabled = False

                    Me.cmbGenero.Enabled = False

                    Me.txtCedulaPadre.Enabled = False
                    Me.txtCedulaMadre.Enabled = False
                    Me.txtCedulaResponsable.Enabled = False

                    Me.dtpFechaNacimiento.Enabled = False

                    Me.cmbciudad.Enabled = False
                    Me.txtDireccion.Enabled = False
                    Me.txtDireccionPadre.Enabled = False
                    Me.txtDireccionMadre.Enabled = False
                    Me.txtDireccionResponsable.Enabled = False

                    Me.cmbReligion.Enabled = False
                    Me.cmbReligionMadre.Enabled = False
                    Me.cmbReligionPadre.Enabled = False
                    Me.cmbReligionResponsable.Enabled = False
                    Me.cmbLugarNacimiento.Enabled = False
                    Me.cmbResposable.Enabled = False

                    Me.txtProfesionMadre.Enabled = False
                    Me.txtProfesionPadre.Enabled = False
                    Me.txtProfesionResponsable.Enabled = False

                    Me.txtOcupacionMadre.Enabled = False
                    Me.txtOcupacionPadre.Enabled = False
                    Me.txtOcupacionResponsable.Enabled = False

                    txtLugarTrabajoMadre.Enabled = False
                    txtLugarTrabajoPadre.Enabled = False
                    txtLugarTrabajoResponsable.Enabled = False

                    cmdAgregarContactoR.Enabled = False
                    cmdAgregar.Enabled = False
                    cmdAgregarContactoM.Enabled = False

                    cmdEliminarContacto.Enabled = False
                    cmdEliminarContactoM.Enabled = False
                    cmdEliminarContactoR.Enabled = False

                    txtObservaciones.Enabled = False
                    txtCausa.Enabled = False
                    txtImportancia.Enabled = False
                    txtInformacion.Enabled = False
                    txtEspera.Enabled = False
                    Me.cmdGuardar.Enabled = False
                    Me.cmdBuscar.Enabled = False
                    Me.cmdBuscarMadre.Enabled = False
                    Me.cmdBuscarPadre.Enabled = False
                    Me.cmdBuscarResponsable.Enabled = False

                    txtCodigoMined.Enabled = False

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
            objSeleccion.Filtro = "  StbPersonaID NOT IN (SELECT objPersonaID FROM StbAlumnos) "
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

    Private Sub CargarDetalleEnfermedades(ByVal strFiltro As String)
        DtDetalleEnfermedades = New DataTable
        Try
            DtDetalleEnfermedades = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("objEnfermedadID, Enfermedad", "vwAlumnoEnfermedad", strFiltro))
            Me.grdEnfermedades.DataSource = DtDetalleEnfermedades
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Tiene Valor"

    Private Function TieneValor(ByVal Valor As Object) As Boolean
        If Not Valor Is Nothing Then
            Return (Not IsDBNull(Valor)) AndAlso Valor.ToString.Trim.Length <> 0
        Else
            Return False
        End If
    End Function

#End Region

#Region "Eliminar sin Preguntar"
    Private Sub ElminarFilaSinPreguntar()
        Try
            If Me.DtDetalleEnfermedades.Rows.Count <> 0 Then
                Me.DtDetalleEnfermedades.Rows.RemoveAt(Me.grdEnfermedadesTabla.FocusedRowHandle) 'Borra la fila del datatable directo
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region

#Region "Eliminar Fila"
    Private Sub EliminarFila()
        If MsgBox("¿Seguro que desea eliminar la fila seleccionada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Sistema") = MsgBoxResult.Yes Then
            Try
                Me.DtDetalleEnfermedades.Rows.RemoveAt(Me.grdEnfermedadesTabla.FocusedRowHandle) 'Borra la fila del datatable directo
                boolExisteErroresGrid = False
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region

#Region "Es fila vacía"
    Private Function EsFilaVacia() As Boolean
        Dim blnRetorno As Boolean = False
        Dim Valor As New Object
        Try
            Valor = Me.grdEnfermedadesTabla.Columns("Enfermedad").View.GetRowCellValue(Me.grdEnfermedadesTabla.FocusedRowHandle, "Enfermedad")
            blnRetorno = Not Me.TieneValor(Valor)
        Catch ex As Exception
            blnRetorno = False
        End Try
        Return blnRetorno
    End Function
#End Region


    Private Sub grdEnfermedadesTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles grdEnfermedadesTabla.KeyDown
        '---- Delete
        If e.KeyCode = Keys.Delete Then
            Dim view As GridView = CType(sender, GridView)
            If view.RowCount <> 0 Then
                If Me.EsFilaVacia Then
                    Me.ElminarFilaSinPreguntar()
                Else
                    Me.EliminarFila()
                End If
            End If
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If ValidarEntradaDetalle() Then
            AgregarEnfermedad()
        End If
    End Sub


    '' Descripción:        Funcion encargada de validar la entrada del usuario
    Public Function ValidarEntradaDetalle() As Boolean

        If cmbEnfermedad.Text.Trim.Length = 0 Or cmbEnfermedad.SelectedValue = "0" Then
            ErrPrv.SetError(cmbEnfermedad, My.Resources.MsgObligatorio)
            Return False
            Exit Function
        End If

        'Buscar la enfermedad en la lista'
        If DtDetalleEnfermedades.Rows.Count > 0 Then
            Dim foundRows() As Data.DataRow
            foundRows = DtDetalleEnfermedades.Select("objEnfermedadID = " & cmbEnfermedad.SelectedValue)

            If foundRows.Length > 0 Then
                MsgBox("La enfermedad ya ha sido seleccionada para este alumno.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If
        End If

        Return True
    End Function

    Private Sub AgregarEnfermedad()
        Dim filas As DataRow
        Dim EnfermedadID As Integer
        Try
            filas = DtDetalleEnfermedades.NewRow
            EnfermedadID = cmbEnfermedad.SelectedValue

            filas("Enfermedad") = cmbEnfermedad.Text
            filas("objEnfermedadID") = EnfermedadID

            DtDetalleEnfermedades.Rows.Add(filas)

            ''Limpiar Controles
            cmbEnfermedad.Text = String.Empty

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#Region "Procedimientos varios"
    Private Sub CalcularEdad(dtFecha As Date)
        Dim intedad As Integer
        Try
            intedad = Now.Year - Convert.ToDateTime(dtpFechaNacimiento.Value).Year
            lblEdad.Text = intedad.ToString + " años"
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region
 

    Private Sub cmdNuevaEnfermedad_Click(sender As Object, e As EventArgs) Handles cmdNuevaEnfermedad.Click
        Dim objEnfermedad As frmSraEnfermedadEditar
        Try
            objEnfermedad = New frmSraEnfermedadEditar
            objEnfermedad.TypeGui = 1

            If objEnfermedad.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarEnfermedad()
                cmbEnfermedad.SelectedValue = enfermedadID

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles cmdAgregarContactoResp.Click
        Try
            Me.GuardarContactosTempResponsable()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarContactoM_Click(sender As Object, e As EventArgs) Handles cmdEliminarContactoM.Click
        Try
            Me.EliminarContactosMadre()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarContacto_Click_1(sender As Object, e As EventArgs) Handles cmdEliminarContacto.Click
        Try
            Me.EliminarContactosPadre()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarContactoR_Click(sender As Object, e As EventArgs) Handles cmdEliminarContactoR.Click
        Try
            Me.EliminarContactosResponsable()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregarContacto_Click_1(sender As Object, e As EventArgs) Handles cmdAgregarContacto.Click
        Try
            Me.GuardarContactosTemp()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub


    Private Sub cmdAgregarContactoM_Click(sender As Object, e As EventArgs) Handles cmdAgregarContactoM.Click
        Try
            Me.GuardarContactosTempMadre()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarPadre_Click(sender As Object, e As EventArgs) Handles cmdBuscarPadre.Click

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  1=1 "
            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idpersonaPadre = objSeleccion.Seleccion
                CargarPersonaPadre()
                VincularControlesPadre()
                ErrPrv.SetError(cmdBuscarPadre, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarMadre_Click(sender As Object, e As EventArgs) Handles cmdBuscarMadre.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  1=1 "
            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idpersonaMadre = objSeleccion.Seleccion
                CargarPersonaMadre()
                VincularControlesMadre()
                ErrPrv.SetError(cmdBuscarMadre, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdBuscarResponsable_Click(sender As Object, e As EventArgs) Handles cmdBuscarResponsable.Click
        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Filtro = "  1=1 "
            objSeleccion.Opcion = 3
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idpersonaResponsable = objSeleccion.Seleccion
                CargarPersonaResponsable()
                VincularControlesResponsable()
                ErrPrv.SetError(cmdBuscarResponsable, "")
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtCedulaPadre_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaPadre.TextChanged
        Me.ErrPrv.SetError(txtCedulaPadre, "")
    End Sub

    Private Sub txtCedulaMadre_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaMadre.TextChanged
        Me.ErrPrv.SetError(txtCedulaMadre, "")
    End Sub

    Private Sub txtCedulaResponsable_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaResponsable.TextChanged
        Me.ErrPrv.SetError(txtCedulaResponsable, "")
    End Sub

    Private Sub chkExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtranjero.CheckedChanged
        If chkExtranjero.Checked Then
            txtCedulaPadre.Enabled = False
            Me.ErrPrv.SetError(txtCedulaPadre, "")
        Else
            txtCedulaPadre.Enabled = True
        End If
    End Sub

    Private Sub chkExtrajenjeroR_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtrajenjeroR.CheckedChanged
        If chkExtrajenjeroR.Checked Then
            txtCedulaResponsable.Enabled = False
            Me.ErrPrv.SetError(txtCedulaResponsable, "")
        Else
            txtCedulaResponsable.Enabled = True
        End If
    End Sub

    Private Sub chkExtrajeneroM_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtrajeneroM.CheckedChanged
        If chkExtrajeneroM.Checked Then
            txtCedulaMadre.Enabled = False
            Me.ErrPrv.SetError(txtCedulaMadre, "")
        Else
            txtCedulaMadre.Enabled = True
        End If
    End Sub

    Private Sub txtCodigoMined_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoMined.TextChanged
        Me.ErrPrv.SetError(txtCodigoMined, "")
    End Sub

    Private Sub cmbResposable_TextChanged(sender As Object, e As EventArgs) Handles cmbResposable.TextChanged
        Me.ErrPrv.SetError(cmbResposable, "")
    End Sub

    Private Sub dtpFechaNacimiento_MouseLeave(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.MouseLeave
        Try
            If dtpFechaNacimiento.Text.Trim.Length <> 0 Then
                CalcularEdad(dtpFechaNacimiento.Value)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim objCiudad As frmSraCiudadEditar
        Try
            objCiudad = New frmSraCiudadEditar
            objCiudad.TypeGui = 1

            If objCiudad.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                CargarCiudad()
                cmbciudad.SelectedValue = CiudadID
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub chkAlumnoExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlumnoExtranjero.CheckedChanged
        Try
            If chkAlumnoExtranjero.Checked Then
                txtLugarNacimiento.Visible = True
            Else
                txtLugarNacimiento.Visible = False
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub dtpFechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.TextChanged
        Me.ErrPrv.SetError(dtpFechaNacimiento, "")
    End Sub
End Class

