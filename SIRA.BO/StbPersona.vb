Imports DAL
Imports System.Data.SqlClient

''' <summary>
''' Almacén principal de datos de personas
''' </summary>
Partial Public Class StbPersona		

#Region " Variables Miembro " 
	Protected m_StbPersonaID As Integer 
	Protected m_Nombre1 As String = Nothing 
	Protected m_Nombre2 As String = Nothing 
	Protected m_Apellido1 As String = Nothing 
	Protected m_Apellido2 As String = Nothing 
	Protected m_objGeneroID As Nullable(Of Integer) 
	Protected m_Extranjero As Nullable(Of Boolean) 
	Protected m_Cedula As String = Nothing 
	Protected m_objPaisID As Nullable(Of Integer) 
	Protected m_objCiudadID As Nullable(Of Integer) 
	Protected m_Direccion As String = Nothing 
	Protected m_Referencia As String = Nothing 
	Protected m_FechaNacimiento As Nullable(Of Date) 
	Protected m_objEstadoCivilID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_PersonaJuridica As Nullable(Of Boolean) 
	Protected m_RazonSocial As String = Nothing 
	Protected m_SiglasEmpresa As String = Nothing 
	Protected m_RUC As String = Nothing 
	Protected m_CodigoEnlace As Nullable(Of Integer) 
	Protected m_CodigoMined As String = Nothing 
	Protected m_LugarNacimiento As String = Nothing 
	Protected m_Religion As String = Nothing 
	Protected m_INFORMACIONCENTRO As String = Nothing 
	Protected m_CAUSAINGRESO As String = Nothing 
	Protected m_IMPORTANCIA As String = Nothing 
	Protected m_RECOMENDACIONES As String = Nothing 
	Protected m_ESPERA As String = Nothing 
	Protected m_OBSERVACIONES As String = Nothing 
	Protected m_Correo As String = Nothing 
	Protected m_Telefono As String = Nothing 
	Protected m_Estado As Nullable(Of Boolean) 
	Protected m_Profesor As Nullable(Of Boolean) 
	Protected m_Madre As Nullable(Of Boolean) 
	Protected m_Padre As Nullable(Of Boolean) 
	Protected m_Responsable As Nullable(Of Boolean) 
	Protected m_PROFESION As String = Nothing 
	Protected m_OCUPACION As String = Nothing 
	Protected m_LUGAR_TRABAJO As String = Nothing 
	Protected m_NIVEL_ACADEMICO As String = Nothing 
	Protected m_RELIGION_P As String = Nothing 
	Protected m_TELEFONO_CASA As String = Nothing 
	Protected m_TELEFONO_TRABAJO As String = Nothing 
	Protected m_CELULAR_P As String = Nothing 
	Protected m_CEDULA_P As String = Nothing 
	Protected m_SEXO As String = Nothing 
#End Region

#Region " Propiedades "
	''' <summary>
	''' Llave primaria, identificador único de personas.
	''' </summary>
	Public Property StbPersonaID() As Integer
        Get
            Return (m_StbPersonaID)
        End Get
		Set(ByVal Value As Integer)					
			m_StbPersonaID = Value
		End Set
    End Property
	
	''' <summary>
	''' 1er Nombre de la Persona
	''' </summary>
	Public Property Nombre1() As String
        Get
            Return (m_Nombre1)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Nombre1", Value.ToString(), "Valor inv?lido para StbPersona.Nombre1. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Nombre1 = Value
		End Set
    End Property
	
	''' <summary>
	''' 2do Nombre de la Persona
	''' </summary>
	Public Property Nombre2() As String
        Get
            Return (m_Nombre2)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Nombre2", Value.ToString(), "Valor inv?lido para StbPersona.Nombre2. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Nombre2 = Value
		End Set
    End Property
	
	''' <summary>
	''' 1er Apellido de Persona
	''' </summary>
	Public Property Apellido1() As String
        Get
            Return (m_Apellido1)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Apellido1", Value.ToString(), "Valor inv?lido para StbPersona.Apellido1. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Apellido1 = Value
		End Set
    End Property
	
	''' <summary>
	''' 2do Apellido de Persona
	''' </summary>
	Public Property Apellido2() As String
        Get
            Return (m_Apellido2)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("Apellido2", Value.ToString(), "Valor inv?lido para StbPersona.Apellido2. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_Apellido2 = Value
		End Set
    End Property
	
	''' <summary>
	''' Id del género de la persona.
	''' </summary>
	Public Property objGeneroID() As Nullable(Of Integer)
        Get
            Return (m_objGeneroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGeneroID = Value
		End Set
    End Property
	
	Public Property Extranjero() As Nullable(Of Boolean)
        Get
            Return (m_Extranjero)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Extranjero = Value
		End Set
    End Property
	
	''' <summary>
	''' Número de cédula
	''' </summary>
	Public Property Cedula() As String
        Get
            Return (m_Cedula)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Cedula", Value.ToString(), "Valor inv?lido para StbPersona.Cedula. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Cedula = Value
		End Set
    End Property
	
	Public Property objPaisID() As Nullable(Of Integer)
        Get
            Return (m_objPaisID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPaisID = Value
		End Set
    End Property
	
	Public Property objCiudadID() As Nullable(Of Integer)
        Get
            Return (m_objCiudadID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCiudadID = Value
		End Set
    End Property
	
	Public Property Direccion() As String
        Get
            Return (m_Direccion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 500 Then
					Throw New ArgumentOutOfRangeException("Direccion", Value.ToString(), "Valor inv?lido para StbPersona.Direccion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (500).")
				End If
			End If
			m_Direccion = Value
		End Set
    End Property
	
	Public Property Referencia() As String
        Get
            Return (m_Referencia)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Referencia", Value.ToString(), "Valor inv?lido para StbPersona.Referencia. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Referencia = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de nacimiento
	''' </summary>
	Public Property FechaNacimiento() As Nullable(Of Date)
        Get
            Return (m_FechaNacimiento)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaNacimiento = Value
		End Set
    End Property
	
	''' <summary>
	''' ID del estado civil de la persona.
	''' </summary>
	Public Property objEstadoCivilID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoCivilID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoCivilID = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de creación del registro
	''' </summary>
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Usuario creador del registro
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 45 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbPersona.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (45).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha de modificación del registro
	''' </summary>
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Usuario modificador del registro.
	''' </summary>
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbPersona.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property PersonaJuridica() As Nullable(Of Boolean)
        Get
            Return (m_PersonaJuridica)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_PersonaJuridica = Value
		End Set
    End Property
	
	Public Property RazonSocial() As String
        Get
            Return (m_RazonSocial)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("RazonSocial", Value.ToString(), "Valor inv?lido para StbPersona.RazonSocial. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_RazonSocial = Value
		End Set
    End Property
	
	Public Property SiglasEmpresa() As String
        Get
            Return (m_SiglasEmpresa)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("SiglasEmpresa", Value.ToString(), "Valor inv?lido para StbPersona.SiglasEmpresa. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_SiglasEmpresa = Value
		End Set
    End Property
	
	Public Property RUC() As String
        Get
            Return (m_RUC)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 16 Then
					Throw New ArgumentOutOfRangeException("RUC", Value.ToString(), "Valor inv?lido para StbPersona.RUC. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (16).")
				End If
			End If
			m_RUC = Value
		End Set
    End Property
	
	Public Property CodigoEnlace() As Nullable(Of Integer)
        Get
            Return (m_CodigoEnlace)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_CodigoEnlace = Value
		End Set
    End Property
	
	Public Property CodigoMined() As String
        Get
            Return (m_CodigoMined)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("CodigoMined", Value.ToString(), "Valor inv?lido para StbPersona.CodigoMined. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_CodigoMined = Value
		End Set
    End Property
	
	Public Property LugarNacimiento() As String
        Get
            Return (m_LugarNacimiento)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("LugarNacimiento", Value.ToString(), "Valor inv?lido para StbPersona.LugarNacimiento. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_LugarNacimiento = Value
		End Set
    End Property
	
	Public Property Religion() As String
        Get
            Return (m_Religion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Religion", Value.ToString(), "Valor inv?lido para StbPersona.Religion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Religion = Value
		End Set
    End Property
	
	Public Property INFORMACIONCENTRO() As String
        Get
            Return (m_INFORMACIONCENTRO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("INFORMACIONCENTRO", Value.ToString(), "Valor inv?lido para StbPersona.INFORMACIONCENTRO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_INFORMACIONCENTRO = Value
		End Set
    End Property
	
	Public Property CAUSAINGRESO() As String
        Get
            Return (m_CAUSAINGRESO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("CAUSAINGRESO", Value.ToString(), "Valor inv?lido para StbPersona.CAUSAINGRESO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_CAUSAINGRESO = Value
		End Set
    End Property
	
	Public Property IMPORTANCIA() As String
        Get
            Return (m_IMPORTANCIA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("IMPORTANCIA", Value.ToString(), "Valor inv?lido para StbPersona.IMPORTANCIA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_IMPORTANCIA = Value
		End Set
    End Property
	
	Public Property RECOMENDACIONES() As String
        Get
            Return (m_RECOMENDACIONES)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("RECOMENDACIONES", Value.ToString(), "Valor inv?lido para StbPersona.RECOMENDACIONES. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_RECOMENDACIONES = Value
		End Set
    End Property
	
	Public Property ESPERA() As String
        Get
            Return (m_ESPERA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("ESPERA", Value.ToString(), "Valor inv?lido para StbPersona.ESPERA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_ESPERA = Value
		End Set
    End Property
	
	Public Property OBSERVACIONES() As String
        Get
            Return (m_OBSERVACIONES)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 255 Then
					Throw New ArgumentOutOfRangeException("OBSERVACIONES", Value.ToString(), "Valor inv?lido para StbPersona.OBSERVACIONES. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (255).")
				End If
			End If
			m_OBSERVACIONES = Value
		End Set
    End Property
	
	Public Property Correo() As String
        Get
            Return (m_Correo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Correo", Value.ToString(), "Valor inv?lido para StbPersona.Correo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Correo = Value
		End Set
    End Property
	
	Public Property Telefono() As String
        Get
            Return (m_Telefono)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Telefono", Value.ToString(), "Valor inv?lido para StbPersona.Telefono. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Telefono = Value
		End Set
    End Property
	
	Public Property Estado() As Nullable(Of Boolean)
        Get
            Return (m_Estado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Estado = Value
		End Set
    End Property
	
	Public Property Profesor() As Nullable(Of Boolean)
        Get
            Return (m_Profesor)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Profesor = Value
		End Set
    End Property
	
	Public Property Madre() As Nullable(Of Boolean)
        Get
            Return (m_Madre)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Madre = Value
		End Set
    End Property
	
	Public Property Padre() As Nullable(Of Boolean)
        Get
            Return (m_Padre)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Padre = Value
		End Set
    End Property
	
	Public Property Responsable() As Nullable(Of Boolean)
        Get
            Return (m_Responsable)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Responsable = Value
		End Set
    End Property
	
	Public Property PROFESION() As String
        Get
            Return (m_PROFESION)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("PROFESION", Value.ToString(), "Valor inv?lido para StbPersona.PROFESION. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_PROFESION = Value
		End Set
    End Property
	
	Public Property OCUPACION() As String
        Get
            Return (m_OCUPACION)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("OCUPACION", Value.ToString(), "Valor inv?lido para StbPersona.OCUPACION. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_OCUPACION = Value
		End Set
    End Property
	
	Public Property LUGAR_TRABAJO() As String
        Get
            Return (m_LUGAR_TRABAJO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("LUGAR_TRABAJO", Value.ToString(), "Valor inv?lido para StbPersona.LUGAR_TRABAJO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_LUGAR_TRABAJO = Value
		End Set
    End Property
	
	Public Property NIVEL_ACADEMICO() As String
        Get
            Return (m_NIVEL_ACADEMICO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("NIVEL_ACADEMICO", Value.ToString(), "Valor inv?lido para StbPersona.NIVEL_ACADEMICO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_NIVEL_ACADEMICO = Value
		End Set
    End Property
	
	Public Property RELIGION_P() As String
        Get
            Return (m_RELIGION_P)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("RELIGION_P", Value.ToString(), "Valor inv?lido para StbPersona.RELIGION_P. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_RELIGION_P = Value
		End Set
    End Property
	
	Public Property TELEFONO_CASA() As String
        Get
            Return (m_TELEFONO_CASA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("TELEFONO_CASA", Value.ToString(), "Valor inv?lido para StbPersona.TELEFONO_CASA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_TELEFONO_CASA = Value
		End Set
    End Property
	
	Public Property TELEFONO_TRABAJO() As String
        Get
            Return (m_TELEFONO_TRABAJO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("TELEFONO_TRABAJO", Value.ToString(), "Valor inv?lido para StbPersona.TELEFONO_TRABAJO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_TELEFONO_TRABAJO = Value
		End Set
    End Property
	
	Public Property CELULAR_P() As String
        Get
            Return (m_CELULAR_P)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("CELULAR_P", Value.ToString(), "Valor inv?lido para StbPersona.CELULAR_P. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_CELULAR_P = Value
		End Set
    End Property
	
	Public Property CEDULA_P() As String
        Get
            Return (m_CEDULA_P)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("CEDULA_P", Value.ToString(), "Valor inv?lido para StbPersona.CEDULA_P. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_CEDULA_P = Value
		End Set
    End Property
	
	Public Property SEXO() As String
        Get
            Return (m_SEXO)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("SEXO", Value.ToString(), "Valor inv?lido para StbPersona.SEXO. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_SEXO = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nombre1"
				Return	255
			Case "Nombre2"
				Return	255
			Case "Apellido1"
				Return	255
			Case "Apellido2"
				Return	255
			Case "Cedula"
				Return	50
			Case "Direccion"
				Return	500
			Case "Referencia"
				Return	150
			Case "UsuarioCreacion"
				Return	45
			Case "UsuarioModificacion"
				Return	30
			Case "RazonSocial"
				Return	255
			Case "SiglasEmpresa"
				Return	255
			Case "RUC"
				Return	16
			Case "CodigoMined"
				Return	50
			Case "LugarNacimiento"
				Return	50
			Case "Religion"
				Return	50
			Case "INFORMACIONCENTRO"
				Return	255
			Case "CAUSAINGRESO"
				Return	255
			Case "IMPORTANCIA"
				Return	255
			Case "RECOMENDACIONES"
				Return	255
			Case "ESPERA"
				Return	255
			Case "OBSERVACIONES"
				Return	255
			Case "Correo"
				Return	50
			Case "Telefono"
				Return	50
			Case "PROFESION"
				Return	2147483645
			Case "OCUPACION"
				Return	2147483645
			Case "LUGAR_TRABAJO"
				Return	2147483645
			Case "NIVEL_ACADEMICO"
				Return	2147483645
			Case "RELIGION_P"
				Return	2147483645
			Case "TELEFONO_CASA"
				Return	2147483645
			Case "TELEFONO_TRABAJO"
				Return	2147483645
			Case "CELULAR_P"
				Return	2147483645
			Case "CEDULA_P"
				Return	2147483645
			Case "SEXO"
				Return	50
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla StbPersona en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbPersona </param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo BatchUpdate.</param>
    ''' <remarks>Usado para realizar actualizaciones en Batch.</remarks>
	public Shared Sub BatchUpdate( DS as Dataset, optional Byval pTransac as TransactionManager = Nothing )
	    Dim cmdInsert As SqlCommand = Nothing
        Dim cmdUpdate As SqlCommand = Nothing
        Dim cmdDelete As SqlCommand = Nothing
		
		Try
			cmdInsert = New SqlCommand
			cmdUpdate = New SqlCommand
			cmdDelete = New SqlCommand
			'CREACION DEL COMANDO DELETE
			cmdDelete.Parameters.Add("@StbPersonaID", SqlDbType.Int, 4, "StbPersonaID" )
			cmdDelete.CommandText = "DELETE FROM  StbPersona WHERE StbPersonaID= @StbPersonaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Nombre1", SqlDbType.VarChar, 255, "Nombre1")
			cmdInsert.Parameters.Add("@Nombre2", SqlDbType.VarChar, 255, "Nombre2")
			cmdInsert.Parameters.Add("@Apellido1", SqlDbType.VarChar, 255, "Apellido1")
			cmdInsert.Parameters.Add("@Apellido2", SqlDbType.VarChar, 255, "Apellido2")
			cmdInsert.Parameters.Add("@objGeneroID", SqlDbType.Int, 4, "objGeneroID")
			cmdInsert.Parameters.Add("@Extranjero", SqlDbType.Bit, 1, "Extranjero")
			cmdInsert.Parameters.Add("@Cedula", SqlDbType.VarChar, 50, "Cedula")
			cmdInsert.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdInsert.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdInsert.Parameters.Add("@Direccion", SqlDbType.VarChar, 500, "Direccion")
			cmdInsert.Parameters.Add("@Referencia", SqlDbType.VarChar, 150, "Referencia")
			cmdInsert.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 8, "FechaNacimiento")
			cmdInsert.Parameters.Add("@objEstadoCivilID", SqlDbType.Int, 4, "objEstadoCivilID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 45, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@PersonaJuridica", SqlDbType.Bit, 1, "PersonaJuridica")
			cmdInsert.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255, "RazonSocial")
			cmdInsert.Parameters.Add("@SiglasEmpresa", SqlDbType.VarChar, 255, "SiglasEmpresa")
			cmdInsert.Parameters.Add("@RUC", SqlDbType.VarChar, 16, "RUC")
			cmdInsert.Parameters.Add("@CodigoEnlace", SqlDbType.Int, 4, "CodigoEnlace")
			cmdInsert.Parameters.Add("@CodigoMined", SqlDbType.VarChar, 50, "CodigoMined")
			cmdInsert.Parameters.Add("@LugarNacimiento", SqlDbType.VarChar, 50, "LugarNacimiento")
			cmdInsert.Parameters.Add("@Religion", SqlDbType.VarChar, 50, "Religion")
			cmdInsert.Parameters.Add("@INFORMACIONCENTRO", SqlDbType.VarChar, 255, "INFORMACIONCENTRO")
			cmdInsert.Parameters.Add("@CAUSAINGRESO", SqlDbType.VarChar, 255, "CAUSAINGRESO")
			cmdInsert.Parameters.Add("@IMPORTANCIA", SqlDbType.VarChar, 255, "IMPORTANCIA")
			cmdInsert.Parameters.Add("@RECOMENDACIONES", SqlDbType.VarChar, 255, "RECOMENDACIONES")
			cmdInsert.Parameters.Add("@ESPERA", SqlDbType.VarChar, 255, "ESPERA")
			cmdInsert.Parameters.Add("@OBSERVACIONES", SqlDbType.VarChar, 255, "OBSERVACIONES")
			cmdInsert.Parameters.Add("@Correo", SqlDbType.VarChar, 50, "Correo")
			cmdInsert.Parameters.Add("@Telefono", SqlDbType.VarChar, 50, "Telefono")
			cmdInsert.Parameters.Add("@Estado", SqlDbType.Bit, 1, "Estado")
			cmdInsert.Parameters.Add("@Profesor", SqlDbType.Bit, 1, "Profesor")
			cmdInsert.Parameters.Add("@Madre", SqlDbType.Bit, 1, "Madre")
			cmdInsert.Parameters.Add("@Padre", SqlDbType.Bit, 1, "Padre")
			cmdInsert.Parameters.Add("@Responsable", SqlDbType.Bit, 1, "Responsable")
			cmdInsert.Parameters.Add("@PROFESION", SqlDbType.VarChar, -1, "PROFESION")
			cmdInsert.Parameters.Add("@OCUPACION", SqlDbType.VarChar, -1, "OCUPACION")
			cmdInsert.Parameters.Add("@LUGAR_TRABAJO", SqlDbType.VarChar, -1, "LUGAR_TRABAJO")
			cmdInsert.Parameters.Add("@NIVEL_ACADEMICO", SqlDbType.VarChar, -1, "NIVEL_ACADEMICO")
			cmdInsert.Parameters.Add("@RELIGION_P", SqlDbType.VarChar, -1, "RELIGION_P")
			cmdInsert.Parameters.Add("@TELEFONO_CASA", SqlDbType.VarChar, -1, "TELEFONO_CASA")
			cmdInsert.Parameters.Add("@TELEFONO_TRABAJO", SqlDbType.VarChar, -1, "TELEFONO_TRABAJO")
			cmdInsert.Parameters.Add("@CELULAR_P", SqlDbType.VarChar, -1, "CELULAR_P")
			cmdInsert.Parameters.Add("@CEDULA_P", SqlDbType.VarChar, -1, "CEDULA_P")
			cmdInsert.Parameters.Add("@SEXO", SqlDbType.VarChar, 50, "SEXO")
			cmdInsert.CommandText = "INSERT INTO StbPersona ( Nombre1, Nombre2, Apellido1, Apellido2, objGeneroID, Extranjero, Cedula, objPaisID, objCiudadID, Direccion, Referencia, FechaNacimiento, objEstadoCivilID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, PersonaJuridica, RazonSocial, SiglasEmpresa, RUC, CodigoEnlace, CodigoMined, LugarNacimiento, Religion, INFORMACIONCENTRO, CAUSAINGRESO, IMPORTANCIA, RECOMENDACIONES, ESPERA, OBSERVACIONES, Correo, Telefono, Estado, Profesor, Madre, Padre, Responsable, PROFESION, OCUPACION, LUGAR_TRABAJO, NIVEL_ACADEMICO, RELIGION_P, TELEFONO_CASA, TELEFONO_TRABAJO, CELULAR_P, CEDULA_P, SEXO) VALUES ( @Nombre1, @Nombre2, @Apellido1, @Apellido2, @objGeneroID, @Extranjero, @Cedula, @objPaisID, @objCiudadID, @Direccion, @Referencia, @FechaNacimiento, @objEstadoCivilID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @PersonaJuridica, @RazonSocial, @SiglasEmpresa, @RUC, @CodigoEnlace, @CodigoMined, @LugarNacimiento, @Religion, @INFORMACIONCENTRO, @CAUSAINGRESO, @IMPORTANCIA, @RECOMENDACIONES, @ESPERA, @OBSERVACIONES, @Correo, @Telefono, @Estado, @Profesor, @Madre, @Padre, @Responsable, @PROFESION, @OCUPACION, @LUGAR_TRABAJO, @NIVEL_ACADEMICO, @RELIGION_P, @TELEFONO_CASA, @TELEFONO_TRABAJO, @CELULAR_P, @CEDULA_P, @SEXO)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Nombre1", SqlDbType.VarChar, 255, "Nombre1")
			cmdUpdate.Parameters.Add("@Nombre2", SqlDbType.VarChar, 255, "Nombre2")
			cmdUpdate.Parameters.Add("@Apellido1", SqlDbType.VarChar, 255, "Apellido1")
			cmdUpdate.Parameters.Add("@Apellido2", SqlDbType.VarChar, 255, "Apellido2")
			cmdUpdate.Parameters.Add("@objGeneroID", SqlDbType.Int, 4, "objGeneroID")
			cmdUpdate.Parameters.Add("@Extranjero", SqlDbType.Bit, 1, "Extranjero")
			cmdUpdate.Parameters.Add("@Cedula", SqlDbType.VarChar, 50, "Cedula")
			cmdUpdate.Parameters.Add("@objPaisID", SqlDbType.Int, 4, "objPaisID")
			cmdUpdate.Parameters.Add("@objCiudadID", SqlDbType.Int, 4, "objCiudadID")
			cmdUpdate.Parameters.Add("@Direccion", SqlDbType.VarChar, 500, "Direccion")
			cmdUpdate.Parameters.Add("@Referencia", SqlDbType.VarChar, 150, "Referencia")
			cmdUpdate.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 8, "FechaNacimiento")
			cmdUpdate.Parameters.Add("@objEstadoCivilID", SqlDbType.Int, 4, "objEstadoCivilID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 45, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@PersonaJuridica", SqlDbType.Bit, 1, "PersonaJuridica")
			cmdUpdate.Parameters.Add("@RazonSocial", SqlDbType.VarChar, 255, "RazonSocial")
			cmdUpdate.Parameters.Add("@SiglasEmpresa", SqlDbType.VarChar, 255, "SiglasEmpresa")
			cmdUpdate.Parameters.Add("@RUC", SqlDbType.VarChar, 16, "RUC")
			cmdUpdate.Parameters.Add("@CodigoEnlace", SqlDbType.Int, 4, "CodigoEnlace")
			cmdUpdate.Parameters.Add("@CodigoMined", SqlDbType.VarChar, 50, "CodigoMined")
			cmdUpdate.Parameters.Add("@LugarNacimiento", SqlDbType.VarChar, 50, "LugarNacimiento")
			cmdUpdate.Parameters.Add("@Religion", SqlDbType.VarChar, 50, "Religion")
			cmdUpdate.Parameters.Add("@INFORMACIONCENTRO", SqlDbType.VarChar, 255, "INFORMACIONCENTRO")
			cmdUpdate.Parameters.Add("@CAUSAINGRESO", SqlDbType.VarChar, 255, "CAUSAINGRESO")
			cmdUpdate.Parameters.Add("@IMPORTANCIA", SqlDbType.VarChar, 255, "IMPORTANCIA")
			cmdUpdate.Parameters.Add("@RECOMENDACIONES", SqlDbType.VarChar, 255, "RECOMENDACIONES")
			cmdUpdate.Parameters.Add("@ESPERA", SqlDbType.VarChar, 255, "ESPERA")
			cmdUpdate.Parameters.Add("@OBSERVACIONES", SqlDbType.VarChar, 255, "OBSERVACIONES")
			cmdUpdate.Parameters.Add("@Correo", SqlDbType.VarChar, 50, "Correo")
			cmdUpdate.Parameters.Add("@Telefono", SqlDbType.VarChar, 50, "Telefono")
			cmdUpdate.Parameters.Add("@Estado", SqlDbType.Bit, 1, "Estado")
			cmdUpdate.Parameters.Add("@Profesor", SqlDbType.Bit, 1, "Profesor")
			cmdUpdate.Parameters.Add("@Madre", SqlDbType.Bit, 1, "Madre")
			cmdUpdate.Parameters.Add("@Padre", SqlDbType.Bit, 1, "Padre")
			cmdUpdate.Parameters.Add("@Responsable", SqlDbType.Bit, 1, "Responsable")
			cmdUpdate.Parameters.Add("@PROFESION", SqlDbType.VarChar, -1, "PROFESION")
			cmdUpdate.Parameters.Add("@OCUPACION", SqlDbType.VarChar, -1, "OCUPACION")
			cmdUpdate.Parameters.Add("@LUGAR_TRABAJO", SqlDbType.VarChar, -1, "LUGAR_TRABAJO")
			cmdUpdate.Parameters.Add("@NIVEL_ACADEMICO", SqlDbType.VarChar, -1, "NIVEL_ACADEMICO")
			cmdUpdate.Parameters.Add("@RELIGION_P", SqlDbType.VarChar, -1, "RELIGION_P")
			cmdUpdate.Parameters.Add("@TELEFONO_CASA", SqlDbType.VarChar, -1, "TELEFONO_CASA")
			cmdUpdate.Parameters.Add("@TELEFONO_TRABAJO", SqlDbType.VarChar, -1, "TELEFONO_TRABAJO")
			cmdUpdate.Parameters.Add("@CELULAR_P", SqlDbType.VarChar, -1, "CELULAR_P")
			cmdUpdate.Parameters.Add("@CEDULA_P", SqlDbType.VarChar, -1, "CEDULA_P")
			cmdUpdate.Parameters.Add("@SEXO", SqlDbType.VarChar, 50, "SEXO")
			cmdUpdate.Parameters.Add("@wStbPersonaID", SqlDbType.Int, 4, "StbPersonaID")
			cmdUpdate.CommandText = "UPDATE StbPersona SET Nombre1=@Nombre1, Nombre2=@Nombre2, Apellido1=@Apellido1, Apellido2=@Apellido2, objGeneroID=@objGeneroID, Extranjero=@Extranjero, Cedula=@Cedula, objPaisID=@objPaisID, objCiudadID=@objCiudadID, Direccion=@Direccion, Referencia=@Referencia, FechaNacimiento=@FechaNacimiento, objEstadoCivilID=@objEstadoCivilID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, PersonaJuridica=@PersonaJuridica, RazonSocial=@RazonSocial, SiglasEmpresa=@SiglasEmpresa, RUC=@RUC, CodigoEnlace=@CodigoEnlace, CodigoMined=@CodigoMined, LugarNacimiento=@LugarNacimiento, Religion=@Religion, INFORMACIONCENTRO=@INFORMACIONCENTRO, CAUSAINGRESO=@CAUSAINGRESO, IMPORTANCIA=@IMPORTANCIA, RECOMENDACIONES=@RECOMENDACIONES, ESPERA=@ESPERA, OBSERVACIONES=@OBSERVACIONES, Correo=@Correo, Telefono=@Telefono, Estado=@Estado, Profesor=@Profesor, Madre=@Madre, Padre=@Padre, Responsable=@Responsable, PROFESION=@PROFESION, OCUPACION=@OCUPACION, LUGAR_TRABAJO=@LUGAR_TRABAJO, NIVEL_ACADEMICO=@NIVEL_ACADEMICO, RELIGION_P=@RELIGION_P, TELEFONO_CASA=@TELEFONO_CASA, TELEFONO_TRABAJO=@TELEFONO_TRABAJO, CELULAR_P=@CELULAR_P, CEDULA_P=@CEDULA_P, SEXO=@SEXO WHERE StbPersonaID= @wStbPersonaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbPersona")
		Catch ex As Exception
            Throw
        Finally
            If Not cmdInsert Is Nothing Then
                cmdInsert.Dispose()
            End If
            If Not cmdUpdate Is Nothing Then
                cmdUpdate.Dispose()
            End If
            If Not cmdDelete Is Nothing Then
                cmdDelete.Dispose()
            End If
        End Try
	End Sub 
#End Region

#Region " Retrieve "
	''' <summary>
    ''' Devuelve de la base de datos un objeto StbPersona
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StbPersonaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbPersona where " & " StbPersonaID = " & p_StbPersonaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_StbPersonaID = dr("StbPersonaID")
				m_Nombre1 = IIf(IsDBNull(dr("Nombre1")), Nothing, dr("Nombre1"))
				m_Nombre2 = IIf(IsDBNull(dr("Nombre2")), Nothing, dr("Nombre2"))
				m_Apellido1 = IIf(IsDBNull(dr("Apellido1")), Nothing, dr("Apellido1"))
				m_Apellido2 = IIf(IsDBNull(dr("Apellido2")), Nothing, dr("Apellido2"))
				m_objGeneroID = IIf(IsDBNull(dr("objGeneroID")), Nothing, dr("objGeneroID"))
				m_Extranjero = IIf(IsDBNull(dr("Extranjero")), Nothing, dr("Extranjero"))
				m_Cedula = IIf(IsDBNull(dr("Cedula")), Nothing, dr("Cedula"))
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))
				m_Direccion = IIf(IsDBNull(dr("Direccion")), Nothing, dr("Direccion"))
				m_Referencia = IIf(IsDBNull(dr("Referencia")), Nothing, dr("Referencia"))
				m_FechaNacimiento = IIf(IsDBNull(dr("FechaNacimiento")), Nothing, dr("FechaNacimiento"))
				m_objEstadoCivilID = IIf(IsDBNull(dr("objEstadoCivilID")), Nothing, dr("objEstadoCivilID"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_PersonaJuridica = IIf(IsDBNull(dr("PersonaJuridica")), Nothing, dr("PersonaJuridica"))
				m_RazonSocial = IIf(IsDBNull(dr("RazonSocial")), Nothing, dr("RazonSocial"))
				m_SiglasEmpresa = IIf(IsDBNull(dr("SiglasEmpresa")), Nothing, dr("SiglasEmpresa"))
				m_RUC = IIf(IsDBNull(dr("RUC")), Nothing, dr("RUC"))
				m_CodigoEnlace = IIf(IsDBNull(dr("CodigoEnlace")), Nothing, dr("CodigoEnlace"))
				m_CodigoMined = IIf(IsDBNull(dr("CodigoMined")), Nothing, dr("CodigoMined"))
				m_LugarNacimiento = IIf(IsDBNull(dr("LugarNacimiento")), Nothing, dr("LugarNacimiento"))
				m_Religion = IIf(IsDBNull(dr("Religion")), Nothing, dr("Religion"))
				m_INFORMACIONCENTRO = IIf(IsDBNull(dr("INFORMACIONCENTRO")), Nothing, dr("INFORMACIONCENTRO"))
				m_CAUSAINGRESO = IIf(IsDBNull(dr("CAUSAINGRESO")), Nothing, dr("CAUSAINGRESO"))
				m_IMPORTANCIA = IIf(IsDBNull(dr("IMPORTANCIA")), Nothing, dr("IMPORTANCIA"))
				m_RECOMENDACIONES = IIf(IsDBNull(dr("RECOMENDACIONES")), Nothing, dr("RECOMENDACIONES"))
				m_ESPERA = IIf(IsDBNull(dr("ESPERA")), Nothing, dr("ESPERA"))
				m_OBSERVACIONES = IIf(IsDBNull(dr("OBSERVACIONES")), Nothing, dr("OBSERVACIONES"))
				m_Correo = IIf(IsDBNull(dr("Correo")), Nothing, dr("Correo"))
				m_Telefono = IIf(IsDBNull(dr("Telefono")), Nothing, dr("Telefono"))
				m_Estado = IIf(IsDBNull(dr("Estado")), Nothing, dr("Estado"))
				m_Profesor = IIf(IsDBNull(dr("Profesor")), Nothing, dr("Profesor"))
				m_Madre = IIf(IsDBNull(dr("Madre")), Nothing, dr("Madre"))
				m_Padre = IIf(IsDBNull(dr("Padre")), Nothing, dr("Padre"))
				m_Responsable = IIf(IsDBNull(dr("Responsable")), Nothing, dr("Responsable"))
				m_PROFESION = IIf(IsDBNull(dr("PROFESION")), Nothing, dr("PROFESION"))
				m_OCUPACION = IIf(IsDBNull(dr("OCUPACION")), Nothing, dr("OCUPACION"))
				m_LUGAR_TRABAJO = IIf(IsDBNull(dr("LUGAR_TRABAJO")), Nothing, dr("LUGAR_TRABAJO"))
				m_NIVEL_ACADEMICO = IIf(IsDBNull(dr("NIVEL_ACADEMICO")), Nothing, dr("NIVEL_ACADEMICO"))
				m_RELIGION_P = IIf(IsDBNull(dr("RELIGION_P")), Nothing, dr("RELIGION_P"))
				m_TELEFONO_CASA = IIf(IsDBNull(dr("TELEFONO_CASA")), Nothing, dr("TELEFONO_CASA"))
				m_TELEFONO_TRABAJO = IIf(IsDBNull(dr("TELEFONO_TRABAJO")), Nothing, dr("TELEFONO_TRABAJO"))
				m_CELULAR_P = IIf(IsDBNull(dr("CELULAR_P")), Nothing, dr("CELULAR_P"))
				m_CEDULA_P = IIf(IsDBNull(dr("CEDULA_P")), Nothing, dr("CEDULA_P"))
				m_SEXO = IIf(IsDBNull(dr("SEXO")), Nothing, dr("SEXO"))
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Devuelve de la base de datos un objeto StbPersona usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbPersona where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_StbPersonaID = dr("StbPersonaID")
				m_Nombre1 = IIf(IsDBNull(dr("Nombre1")), Nothing, dr("Nombre1"))
				m_Nombre2 = IIf(IsDBNull(dr("Nombre2")), Nothing, dr("Nombre2"))
				m_Apellido1 = IIf(IsDBNull(dr("Apellido1")), Nothing, dr("Apellido1"))
				m_Apellido2 = IIf(IsDBNull(dr("Apellido2")), Nothing, dr("Apellido2"))
				m_objGeneroID = IIf(IsDBNull(dr("objGeneroID")), Nothing, dr("objGeneroID"))
				m_Extranjero = IIf(IsDBNull(dr("Extranjero")), Nothing, dr("Extranjero"))
				m_Cedula = IIf(IsDBNull(dr("Cedula")), Nothing, dr("Cedula"))
				m_objPaisID = IIf(IsDBNull(dr("objPaisID")), Nothing, dr("objPaisID"))
				m_objCiudadID = IIf(IsDBNull(dr("objCiudadID")), Nothing, dr("objCiudadID"))
				m_Direccion = IIf(IsDBNull(dr("Direccion")), Nothing, dr("Direccion"))
				m_Referencia = IIf(IsDBNull(dr("Referencia")), Nothing, dr("Referencia"))
				m_FechaNacimiento = IIf(IsDBNull(dr("FechaNacimiento")), Nothing, dr("FechaNacimiento"))
				m_objEstadoCivilID = IIf(IsDBNull(dr("objEstadoCivilID")), Nothing, dr("objEstadoCivilID"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_PersonaJuridica = IIf(IsDBNull(dr("PersonaJuridica")), Nothing, dr("PersonaJuridica"))
				m_RazonSocial = IIf(IsDBNull(dr("RazonSocial")), Nothing, dr("RazonSocial"))
				m_SiglasEmpresa = IIf(IsDBNull(dr("SiglasEmpresa")), Nothing, dr("SiglasEmpresa"))
				m_RUC = IIf(IsDBNull(dr("RUC")), Nothing, dr("RUC"))
				m_CodigoEnlace = IIf(IsDBNull(dr("CodigoEnlace")), Nothing, dr("CodigoEnlace"))
				m_CodigoMined = IIf(IsDBNull(dr("CodigoMined")), Nothing, dr("CodigoMined"))
				m_LugarNacimiento = IIf(IsDBNull(dr("LugarNacimiento")), Nothing, dr("LugarNacimiento"))
				m_Religion = IIf(IsDBNull(dr("Religion")), Nothing, dr("Religion"))
				m_INFORMACIONCENTRO = IIf(IsDBNull(dr("INFORMACIONCENTRO")), Nothing, dr("INFORMACIONCENTRO"))
				m_CAUSAINGRESO = IIf(IsDBNull(dr("CAUSAINGRESO")), Nothing, dr("CAUSAINGRESO"))
				m_IMPORTANCIA = IIf(IsDBNull(dr("IMPORTANCIA")), Nothing, dr("IMPORTANCIA"))
				m_RECOMENDACIONES = IIf(IsDBNull(dr("RECOMENDACIONES")), Nothing, dr("RECOMENDACIONES"))
				m_ESPERA = IIf(IsDBNull(dr("ESPERA")), Nothing, dr("ESPERA"))
				m_OBSERVACIONES = IIf(IsDBNull(dr("OBSERVACIONES")), Nothing, dr("OBSERVACIONES"))
				m_Correo = IIf(IsDBNull(dr("Correo")), Nothing, dr("Correo"))
				m_Telefono = IIf(IsDBNull(dr("Telefono")), Nothing, dr("Telefono"))
				m_Estado = IIf(IsDBNull(dr("Estado")), Nothing, dr("Estado"))
				m_Profesor = IIf(IsDBNull(dr("Profesor")), Nothing, dr("Profesor"))
				m_Madre = IIf(IsDBNull(dr("Madre")), Nothing, dr("Madre"))
				m_Padre = IIf(IsDBNull(dr("Padre")), Nothing, dr("Padre"))
				m_Responsable = IIf(IsDBNull(dr("Responsable")), Nothing, dr("Responsable"))
				m_PROFESION = IIf(IsDBNull(dr("PROFESION")), Nothing, dr("PROFESION"))
				m_OCUPACION = IIf(IsDBNull(dr("OCUPACION")), Nothing, dr("OCUPACION"))
				m_LUGAR_TRABAJO = IIf(IsDBNull(dr("LUGAR_TRABAJO")), Nothing, dr("LUGAR_TRABAJO"))
				m_NIVEL_ACADEMICO = IIf(IsDBNull(dr("NIVEL_ACADEMICO")), Nothing, dr("NIVEL_ACADEMICO"))
				m_RELIGION_P = IIf(IsDBNull(dr("RELIGION_P")), Nothing, dr("RELIGION_P"))
				m_TELEFONO_CASA = IIf(IsDBNull(dr("TELEFONO_CASA")), Nothing, dr("TELEFONO_CASA"))
				m_TELEFONO_TRABAJO = IIf(IsDBNull(dr("TELEFONO_TRABAJO")), Nothing, dr("TELEFONO_TRABAJO"))
				m_CELULAR_P = IIf(IsDBNull(dr("CELULAR_P")), Nothing, dr("CELULAR_P"))
				m_CEDULA_P = IIf(IsDBNull(dr("CEDULA_P")), Nothing, dr("CEDULA_P"))
				m_SEXO = IIf(IsDBNull(dr("SEXO")), Nothing, dr("SEXO"))
				Return True
			Else
				Return False
			End If			
        Catch ex As Exception
            Throw
        Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try			
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbPersona"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet 
		Try
			If pTransac is nothing Then 
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "StbPersona"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbPersona"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

		Dim ds As DataSet 
		Try
			If pTransac Is Nothing then
				ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
			Else
				ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			ds.Tables(0).TableName = "StbPersona"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbPersona en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbPersona"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If
		
		Dim dr As SqlDataReader = Nothing
		Try
			If pTransac is nothing then
				dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
			Else
				dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
			End If
			Return (dr)
		Catch ex As Exception
			Throw        
		Finally
            If Not dr Is Nothing Then
                If Not dr.IsClosed Then
                    dr.Close()
                End If
                dr = Nothing
            End If
        End Try	
    End Function
#End Region

#Region " Insert "

	''' <summary>
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbPersona.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbPersona("
		sCommand &= "Nombre1,"
		sCommand &= "Nombre2,"
		sCommand &= "Apellido1,"
		sCommand &= "Apellido2,"
		sCommand &= "objGeneroID,"
		sCommand &= "Extranjero,"
		sCommand &= "Cedula,"
		sCommand &= "objPaisID,"
		sCommand &= "objCiudadID,"
		sCommand &= "Direccion,"
		sCommand &= "Referencia,"
		sCommand &= "FechaNacimiento,"
		sCommand &= "objEstadoCivilID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "PersonaJuridica,"
		sCommand &= "RazonSocial,"
		sCommand &= "SiglasEmpresa,"
		sCommand &= "RUC,"
		sCommand &= "CodigoEnlace,"
		sCommand &= "CodigoMined,"
		sCommand &= "LugarNacimiento,"
		sCommand &= "Religion,"
		sCommand &= "INFORMACIONCENTRO,"
		sCommand &= "CAUSAINGRESO,"
		sCommand &= "IMPORTANCIA,"
		sCommand &= "RECOMENDACIONES,"
		sCommand &= "ESPERA,"
		sCommand &= "OBSERVACIONES,"
		sCommand &= "Correo,"
		sCommand &= "Telefono,"
		sCommand &= "Estado,"
		sCommand &= "Profesor,"
		sCommand &= "Madre,"
		sCommand &= "Padre,"
		sCommand &= "Responsable,"
		sCommand &= "PROFESION,"
		sCommand &= "OCUPACION,"
		sCommand &= "LUGAR_TRABAJO,"
		sCommand &= "NIVEL_ACADEMICO,"
		sCommand &= "RELIGION_P,"
		sCommand &= "TELEFONO_CASA,"
		sCommand &= "TELEFONO_TRABAJO,"
		sCommand &= "CELULAR_P,"
		sCommand &= "CEDULA_P,"
		sCommand &= "SEXO) values ("		
		sCommand &= "@Nombre1,"
		sCommand &= "@Nombre2,"
		sCommand &= "@Apellido1,"
		sCommand &= "@Apellido2,"
		sCommand &= "@objGeneroID,"
		sCommand &= "@Extranjero,"
		sCommand &= "@Cedula,"
		sCommand &= "@objPaisID,"
		sCommand &= "@objCiudadID,"
		sCommand &= "@Direccion,"
		sCommand &= "@Referencia,"
		sCommand &= "@FechaNacimiento,"
		sCommand &= "@objEstadoCivilID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@PersonaJuridica,"
		sCommand &= "@RazonSocial,"
		sCommand &= "@SiglasEmpresa,"
		sCommand &= "@RUC,"
		sCommand &= "@CodigoEnlace,"
		sCommand &= "@CodigoMined,"
		sCommand &= "@LugarNacimiento,"
		sCommand &= "@Religion,"
		sCommand &= "@INFORMACIONCENTRO,"
		sCommand &= "@CAUSAINGRESO,"
		sCommand &= "@IMPORTANCIA,"
		sCommand &= "@RECOMENDACIONES,"
		sCommand &= "@ESPERA,"
		sCommand &= "@OBSERVACIONES,"
		sCommand &= "@Correo,"
		sCommand &= "@Telefono,"
		sCommand &= "@Estado,"
		sCommand &= "@Profesor,"
		sCommand &= "@Madre,"
		sCommand &= "@Padre,"
		sCommand &= "@Responsable,"
		sCommand &= "@PROFESION,"
		sCommand &= "@OCUPACION,"
		sCommand &= "@LUGAR_TRABAJO,"
		sCommand &= "@NIVEL_ACADEMICO,"
		sCommand &= "@RELIGION_P,"
		sCommand &= "@TELEFONO_CASA,"
		sCommand &= "@TELEFONO_TRABAJO,"
		sCommand &= "@CELULAR_P,"
		sCommand &= "@CEDULA_P,"
		sCommand &= "@SEXO)"		
	
		sCommand &= " select "
		sCommand &= "@StbPersonaID = StbPersonaID from StbPersona where "		
		sCommand &= "StbPersonaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(48) As SqlParameter
		arParams(0) = New SqlParameter("@StbPersonaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Nombre1", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre1) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre1
        End If
		arParams(2) = New SqlParameter("@Nombre2", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre2) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre2
        End If
		arParams(3) = New SqlParameter("@Apellido1", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido1) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Apellido1
        End If
		arParams(4) = New SqlParameter("@Apellido2", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido2) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Apellido2
        End If
		arParams(5) = New SqlParameter("@objGeneroID", SqlDbType.Int)		
		If IsDBNull(m_objGeneroID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objGeneroID
        End If
		arParams(6) = New SqlParameter("@Extranjero", SqlDbType.Bit)		
		If IsDBNull(m_Extranjero) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Extranjero
        End If
		arParams(7) = New SqlParameter("@Cedula", SqlDbType.VarChar)		
		If IsDBNull(m_Cedula) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Cedula
        End If
		arParams(8) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objPaisID
        End If
		arParams(9) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objCiudadID
        End If
		arParams(10) = New SqlParameter("@Direccion", SqlDbType.VarChar)		
		If IsDBNull(m_Direccion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Direccion
        End If
		arParams(11) = New SqlParameter("@Referencia", SqlDbType.VarChar)		
		If IsDBNull(m_Referencia) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Referencia
        End If
		arParams(12) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaNacimiento) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaNacimiento
        End If
		arParams(13) = New SqlParameter("@objEstadoCivilID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoCivilID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objEstadoCivilID
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
        End If
		arParams(18) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)		
		If IsDBNull(m_PersonaJuridica) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_PersonaJuridica
        End If
		arParams(19) = New SqlParameter("@RazonSocial", SqlDbType.VarChar)		
		If IsDBNull(m_RazonSocial) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_RazonSocial
        End If
		arParams(20) = New SqlParameter("@SiglasEmpresa", SqlDbType.VarChar)		
		If IsDBNull(m_SiglasEmpresa) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_SiglasEmpresa
        End If
		arParams(21) = New SqlParameter("@RUC", SqlDbType.VarChar)		
		If IsDBNull(m_RUC) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_RUC
        End If
		arParams(22) = New SqlParameter("@CodigoEnlace", SqlDbType.Int)		
		If IsDBNull(m_CodigoEnlace) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_CodigoEnlace
        End If
		arParams(23) = New SqlParameter("@CodigoMined", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoMined) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_CodigoMined
        End If
		arParams(24) = New SqlParameter("@LugarNacimiento", SqlDbType.VarChar)		
		If IsDBNull(m_LugarNacimiento) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_LugarNacimiento
        End If
		arParams(25) = New SqlParameter("@Religion", SqlDbType.VarChar)		
		If IsDBNull(m_Religion) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_Religion
        End If
		arParams(26) = New SqlParameter("@INFORMACIONCENTRO", SqlDbType.VarChar)		
		If IsDBNull(m_INFORMACIONCENTRO) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_INFORMACIONCENTRO
        End If
		arParams(27) = New SqlParameter("@CAUSAINGRESO", SqlDbType.VarChar)		
		If IsDBNull(m_CAUSAINGRESO) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_CAUSAINGRESO
        End If
		arParams(28) = New SqlParameter("@IMPORTANCIA", SqlDbType.VarChar)		
		If IsDBNull(m_IMPORTANCIA) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_IMPORTANCIA
        End If
		arParams(29) = New SqlParameter("@RECOMENDACIONES", SqlDbType.VarChar)		
		If IsDBNull(m_RECOMENDACIONES) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_RECOMENDACIONES
        End If
		arParams(30) = New SqlParameter("@ESPERA", SqlDbType.VarChar)		
		If IsDBNull(m_ESPERA) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_ESPERA
        End If
		arParams(31) = New SqlParameter("@OBSERVACIONES", SqlDbType.VarChar)		
		If IsDBNull(m_OBSERVACIONES) Then
            arParams(31).Value = DBNull.Value
        Else
            arParams(31).Value = m_OBSERVACIONES
        End If
		arParams(32) = New SqlParameter("@Correo", SqlDbType.VarChar)		
		If IsDBNull(m_Correo) Then
            arParams(32).Value = DBNull.Value
        Else
            arParams(32).Value = m_Correo
        End If
		arParams(33) = New SqlParameter("@Telefono", SqlDbType.VarChar)		
		If IsDBNull(m_Telefono) Then
            arParams(33).Value = DBNull.Value
        Else
            arParams(33).Value = m_Telefono
        End If
		arParams(34) = New SqlParameter("@Estado", SqlDbType.Bit)		
		If IsDBNull(m_Estado) Then
            arParams(34).Value = DBNull.Value
        Else
            arParams(34).Value = m_Estado
        End If
		arParams(35) = New SqlParameter("@Profesor", SqlDbType.Bit)		
		If IsDBNull(m_Profesor) Then
            arParams(35).Value = DBNull.Value
        Else
            arParams(35).Value = m_Profesor
        End If
		arParams(36) = New SqlParameter("@Madre", SqlDbType.Bit)		
		If IsDBNull(m_Madre) Then
            arParams(36).Value = DBNull.Value
        Else
            arParams(36).Value = m_Madre
        End If
		arParams(37) = New SqlParameter("@Padre", SqlDbType.Bit)		
		If IsDBNull(m_Padre) Then
            arParams(37).Value = DBNull.Value
        Else
            arParams(37).Value = m_Padre
        End If
		arParams(38) = New SqlParameter("@Responsable", SqlDbType.Bit)		
		If IsDBNull(m_Responsable) Then
            arParams(38).Value = DBNull.Value
        Else
            arParams(38).Value = m_Responsable
        End If
		arParams(39) = New SqlParameter("@PROFESION", SqlDbType.VarChar)		
		If IsDBNull(m_PROFESION) Then
            arParams(39).Value = DBNull.Value
        Else
            arParams(39).Value = m_PROFESION
        End If
		arParams(40) = New SqlParameter("@OCUPACION", SqlDbType.VarChar)		
		If IsDBNull(m_OCUPACION) Then
            arParams(40).Value = DBNull.Value
        Else
            arParams(40).Value = m_OCUPACION
        End If
		arParams(41) = New SqlParameter("@LUGAR_TRABAJO", SqlDbType.VarChar)		
		If IsDBNull(m_LUGAR_TRABAJO) Then
            arParams(41).Value = DBNull.Value
        Else
            arParams(41).Value = m_LUGAR_TRABAJO
        End If
		arParams(42) = New SqlParameter("@NIVEL_ACADEMICO", SqlDbType.VarChar)		
		If IsDBNull(m_NIVEL_ACADEMICO) Then
            arParams(42).Value = DBNull.Value
        Else
            arParams(42).Value = m_NIVEL_ACADEMICO
        End If
		arParams(43) = New SqlParameter("@RELIGION_P", SqlDbType.VarChar)		
		If IsDBNull(m_RELIGION_P) Then
            arParams(43).Value = DBNull.Value
        Else
            arParams(43).Value = m_RELIGION_P
        End If
		arParams(44) = New SqlParameter("@TELEFONO_CASA", SqlDbType.VarChar)		
		If IsDBNull(m_TELEFONO_CASA) Then
            arParams(44).Value = DBNull.Value
        Else
            arParams(44).Value = m_TELEFONO_CASA
        End If
		arParams(45) = New SqlParameter("@TELEFONO_TRABAJO", SqlDbType.VarChar)		
		If IsDBNull(m_TELEFONO_TRABAJO) Then
            arParams(45).Value = DBNull.Value
        Else
            arParams(45).Value = m_TELEFONO_TRABAJO
        End If
		arParams(46) = New SqlParameter("@CELULAR_P", SqlDbType.VarChar)		
		If IsDBNull(m_CELULAR_P) Then
            arParams(46).Value = DBNull.Value
        Else
            arParams(46).Value = m_CELULAR_P
        End If
		arParams(47) = New SqlParameter("@CEDULA_P", SqlDbType.VarChar)		
		If IsDBNull(m_CEDULA_P) Then
            arParams(47).Value = DBNull.Value
        Else
            arParams(47).Value = m_CEDULA_P
        End If
		arParams(48) = New SqlParameter("@SEXO", SqlDbType.VarChar)		
		If IsDBNull(m_SEXO) Then
            arParams(48).Value = DBNull.Value
        Else
            arParams(48).Value = m_SEXO
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_StbPersonaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbPersona en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbPersona set "		
		sCommand &= "Nombre1 = @Nombre1,"
		sCommand &= "Nombre2 = @Nombre2,"
		sCommand &= "Apellido1 = @Apellido1,"
		sCommand &= "Apellido2 = @Apellido2,"
		sCommand &= "objGeneroID = @objGeneroID,"
		sCommand &= "Extranjero = @Extranjero,"
		sCommand &= "Cedula = @Cedula,"
		sCommand &= "objPaisID = @objPaisID,"
		sCommand &= "objCiudadID = @objCiudadID,"
		sCommand &= "Direccion = @Direccion,"
		sCommand &= "Referencia = @Referencia,"
		sCommand &= "FechaNacimiento = @FechaNacimiento,"
		sCommand &= "objEstadoCivilID = @objEstadoCivilID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "PersonaJuridica = @PersonaJuridica,"
		sCommand &= "RazonSocial = @RazonSocial,"
		sCommand &= "SiglasEmpresa = @SiglasEmpresa,"
		sCommand &= "RUC = @RUC,"
		sCommand &= "CodigoEnlace = @CodigoEnlace,"
		sCommand &= "CodigoMined = @CodigoMined,"
		sCommand &= "LugarNacimiento = @LugarNacimiento,"
		sCommand &= "Religion = @Religion,"
		sCommand &= "INFORMACIONCENTRO = @INFORMACIONCENTRO,"
		sCommand &= "CAUSAINGRESO = @CAUSAINGRESO,"
		sCommand &= "IMPORTANCIA = @IMPORTANCIA,"
		sCommand &= "RECOMENDACIONES = @RECOMENDACIONES,"
		sCommand &= "ESPERA = @ESPERA,"
		sCommand &= "OBSERVACIONES = @OBSERVACIONES,"
		sCommand &= "Correo = @Correo,"
		sCommand &= "Telefono = @Telefono,"
		sCommand &= "Estado = @Estado,"
		sCommand &= "Profesor = @Profesor,"
		sCommand &= "Madre = @Madre,"
		sCommand &= "Padre = @Padre,"
		sCommand &= "Responsable = @Responsable,"
		sCommand &= "PROFESION = @PROFESION,"
		sCommand &= "OCUPACION = @OCUPACION,"
		sCommand &= "LUGAR_TRABAJO = @LUGAR_TRABAJO,"
		sCommand &= "NIVEL_ACADEMICO = @NIVEL_ACADEMICO,"
		sCommand &= "RELIGION_P = @RELIGION_P,"
		sCommand &= "TELEFONO_CASA = @TELEFONO_CASA,"
		sCommand &= "TELEFONO_TRABAJO = @TELEFONO_TRABAJO,"
		sCommand &= "CELULAR_P = @CELULAR_P,"
		sCommand &= "CEDULA_P = @CEDULA_P,"
		sCommand &= "SEXO = @SEXO"		
		sCommand &= " where "	
		sCommand &= "StbPersonaID = @StbPersonaID"					
		
		Dim arParams(48) As SqlParameter
		arParams(0) = New SqlParameter("@StbPersonaID", SqlDbType.Int)		
		If IsDBNull(m_StbPersonaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbPersonaID
        End If
		arParams(1) = New SqlParameter("@Nombre1", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre1) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Nombre1
        End If
		arParams(2) = New SqlParameter("@Nombre2", SqlDbType.VarChar)		
		If IsDBNull(m_Nombre2) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Nombre2
        End If
		arParams(3) = New SqlParameter("@Apellido1", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido1) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Apellido1
        End If
		arParams(4) = New SqlParameter("@Apellido2", SqlDbType.VarChar)		
		If IsDBNull(m_Apellido2) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Apellido2
        End If
		arParams(5) = New SqlParameter("@objGeneroID", SqlDbType.Int)		
		If IsDBNull(m_objGeneroID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objGeneroID
        End If
		arParams(6) = New SqlParameter("@Extranjero", SqlDbType.Bit)		
		If IsDBNull(m_Extranjero) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Extranjero
        End If
		arParams(7) = New SqlParameter("@Cedula", SqlDbType.VarChar)		
		If IsDBNull(m_Cedula) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Cedula
        End If
		arParams(8) = New SqlParameter("@objPaisID", SqlDbType.Int)		
		If IsDBNull(m_objPaisID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objPaisID
        End If
		arParams(9) = New SqlParameter("@objCiudadID", SqlDbType.Int)		
		If IsDBNull(m_objCiudadID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objCiudadID
        End If
		arParams(10) = New SqlParameter("@Direccion", SqlDbType.VarChar)		
		If IsDBNull(m_Direccion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Direccion
        End If
		arParams(11) = New SqlParameter("@Referencia", SqlDbType.VarChar)		
		If IsDBNull(m_Referencia) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Referencia
        End If
		arParams(12) = New SqlParameter("@FechaNacimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaNacimiento) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaNacimiento
        End If
		arParams(13) = New SqlParameter("@objEstadoCivilID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoCivilID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objEstadoCivilID
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
        End If
		arParams(18) = New SqlParameter("@PersonaJuridica", SqlDbType.Bit)		
		If IsDBNull(m_PersonaJuridica) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_PersonaJuridica
        End If
		arParams(19) = New SqlParameter("@RazonSocial", SqlDbType.VarChar)		
		If IsDBNull(m_RazonSocial) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_RazonSocial
        End If
		arParams(20) = New SqlParameter("@SiglasEmpresa", SqlDbType.VarChar)		
		If IsDBNull(m_SiglasEmpresa) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_SiglasEmpresa
        End If
		arParams(21) = New SqlParameter("@RUC", SqlDbType.VarChar)		
		If IsDBNull(m_RUC) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_RUC
        End If
		arParams(22) = New SqlParameter("@CodigoEnlace", SqlDbType.Int)		
		If IsDBNull(m_CodigoEnlace) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_CodigoEnlace
        End If
		arParams(23) = New SqlParameter("@CodigoMined", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoMined) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_CodigoMined
        End If
		arParams(24) = New SqlParameter("@LugarNacimiento", SqlDbType.VarChar)		
		If IsDBNull(m_LugarNacimiento) Then
            arParams(24).Value = DBNull.Value
        Else
            arParams(24).Value = m_LugarNacimiento
        End If
		arParams(25) = New SqlParameter("@Religion", SqlDbType.VarChar)		
		If IsDBNull(m_Religion) Then
            arParams(25).Value = DBNull.Value
        Else
            arParams(25).Value = m_Religion
        End If
		arParams(26) = New SqlParameter("@INFORMACIONCENTRO", SqlDbType.VarChar)		
		If IsDBNull(m_INFORMACIONCENTRO) Then
            arParams(26).Value = DBNull.Value
        Else
            arParams(26).Value = m_INFORMACIONCENTRO
        End If
		arParams(27) = New SqlParameter("@CAUSAINGRESO", SqlDbType.VarChar)		
		If IsDBNull(m_CAUSAINGRESO) Then
            arParams(27).Value = DBNull.Value
        Else
            arParams(27).Value = m_CAUSAINGRESO
        End If
		arParams(28) = New SqlParameter("@IMPORTANCIA", SqlDbType.VarChar)		
		If IsDBNull(m_IMPORTANCIA) Then
            arParams(28).Value = DBNull.Value
        Else
            arParams(28).Value = m_IMPORTANCIA
        End If
		arParams(29) = New SqlParameter("@RECOMENDACIONES", SqlDbType.VarChar)		
		If IsDBNull(m_RECOMENDACIONES) Then
            arParams(29).Value = DBNull.Value
        Else
            arParams(29).Value = m_RECOMENDACIONES
        End If
		arParams(30) = New SqlParameter("@ESPERA", SqlDbType.VarChar)		
		If IsDBNull(m_ESPERA) Then
            arParams(30).Value = DBNull.Value
        Else
            arParams(30).Value = m_ESPERA
        End If
		arParams(31) = New SqlParameter("@OBSERVACIONES", SqlDbType.VarChar)		
		If IsDBNull(m_OBSERVACIONES) Then
            arParams(31).Value = DBNull.Value
        Else
            arParams(31).Value = m_OBSERVACIONES
        End If
		arParams(32) = New SqlParameter("@Correo", SqlDbType.VarChar)		
		If IsDBNull(m_Correo) Then
            arParams(32).Value = DBNull.Value
        Else
            arParams(32).Value = m_Correo
        End If
		arParams(33) = New SqlParameter("@Telefono", SqlDbType.VarChar)		
		If IsDBNull(m_Telefono) Then
            arParams(33).Value = DBNull.Value
        Else
            arParams(33).Value = m_Telefono
        End If
		arParams(34) = New SqlParameter("@Estado", SqlDbType.Bit)		
		If IsDBNull(m_Estado) Then
            arParams(34).Value = DBNull.Value
        Else
            arParams(34).Value = m_Estado
        End If
		arParams(35) = New SqlParameter("@Profesor", SqlDbType.Bit)		
		If IsDBNull(m_Profesor) Then
            arParams(35).Value = DBNull.Value
        Else
            arParams(35).Value = m_Profesor
        End If
		arParams(36) = New SqlParameter("@Madre", SqlDbType.Bit)		
		If IsDBNull(m_Madre) Then
            arParams(36).Value = DBNull.Value
        Else
            arParams(36).Value = m_Madre
        End If
		arParams(37) = New SqlParameter("@Padre", SqlDbType.Bit)		
		If IsDBNull(m_Padre) Then
            arParams(37).Value = DBNull.Value
        Else
            arParams(37).Value = m_Padre
        End If
		arParams(38) = New SqlParameter("@Responsable", SqlDbType.Bit)		
		If IsDBNull(m_Responsable) Then
            arParams(38).Value = DBNull.Value
        Else
            arParams(38).Value = m_Responsable
        End If
		arParams(39) = New SqlParameter("@PROFESION", SqlDbType.VarChar)		
		If IsDBNull(m_PROFESION) Then
            arParams(39).Value = DBNull.Value
        Else
            arParams(39).Value = m_PROFESION
        End If
		arParams(40) = New SqlParameter("@OCUPACION", SqlDbType.VarChar)		
		If IsDBNull(m_OCUPACION) Then
            arParams(40).Value = DBNull.Value
        Else
            arParams(40).Value = m_OCUPACION
        End If
		arParams(41) = New SqlParameter("@LUGAR_TRABAJO", SqlDbType.VarChar)		
		If IsDBNull(m_LUGAR_TRABAJO) Then
            arParams(41).Value = DBNull.Value
        Else
            arParams(41).Value = m_LUGAR_TRABAJO
        End If
		arParams(42) = New SqlParameter("@NIVEL_ACADEMICO", SqlDbType.VarChar)		
		If IsDBNull(m_NIVEL_ACADEMICO) Then
            arParams(42).Value = DBNull.Value
        Else
            arParams(42).Value = m_NIVEL_ACADEMICO
        End If
		arParams(43) = New SqlParameter("@RELIGION_P", SqlDbType.VarChar)		
		If IsDBNull(m_RELIGION_P) Then
            arParams(43).Value = DBNull.Value
        Else
            arParams(43).Value = m_RELIGION_P
        End If
		arParams(44) = New SqlParameter("@TELEFONO_CASA", SqlDbType.VarChar)		
		If IsDBNull(m_TELEFONO_CASA) Then
            arParams(44).Value = DBNull.Value
        Else
            arParams(44).Value = m_TELEFONO_CASA
        End If
		arParams(45) = New SqlParameter("@TELEFONO_TRABAJO", SqlDbType.VarChar)		
		If IsDBNull(m_TELEFONO_TRABAJO) Then
            arParams(45).Value = DBNull.Value
        Else
            arParams(45).Value = m_TELEFONO_TRABAJO
        End If
		arParams(46) = New SqlParameter("@CELULAR_P", SqlDbType.VarChar)		
		If IsDBNull(m_CELULAR_P) Then
            arParams(46).Value = DBNull.Value
        Else
            arParams(46).Value = m_CELULAR_P
        End If
		arParams(47) = New SqlParameter("@CEDULA_P", SqlDbType.VarChar)		
		If IsDBNull(m_CEDULA_P) Then
            arParams(47).Value = DBNull.Value
        Else
            arParams(47).Value = m_CEDULA_P
        End If
		arParams(48) = New SqlParameter("@SEXO", SqlDbType.VarChar)		
		If IsDBNull(m_SEXO) Then
            arParams(48).Value = DBNull.Value
        Else
            arParams(48).Value = m_SEXO
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
        Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region
	
#Region " Delete "

	''' <summary>
    ''' Borra un objeto StbPersona de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & " StbPersonaID = " & m_StbPersonaID
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub

    ''' <summary>
    ''' Borra un objeto StbPersona de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StbPersonaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & " StbPersonaID = " & p_StbPersonaID
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub	

    ''' <summary>
    ''' Borra objetos StbPersona de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbPersona where " & pWhere
			If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sSQL)
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sSQL)
			End If
		Catch ex As Exception
            Throw        
        End Try
    End Sub
#End Region

End Class
