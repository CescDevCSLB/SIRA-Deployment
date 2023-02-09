Imports DAL
Imports System.Data.SqlClient

Partial Public Class StbAlumnos		

#Region " Variables Miembro " 
	Protected m_AlumnoID As Integer 
	Protected m_objPersonaID As Nullable(Of Integer) 
	Protected m_CodigoMED As String = Nothing 
	Protected m_objLugarNacimientoID As Nullable(Of Integer) 
	Protected m_objReligionID As Nullable(Of Integer) 
	Protected m_InformacionCentro As String = Nothing 
	Protected m_CausaIngreso As String = Nothing 
	Protected m_Importancia As String = Nothing 
	Protected m_Recomendaciones As String = Nothing 
	Protected m_Espera As String = Nothing 
	Protected m_Observaciones As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objResponsableID As Nullable(Of Integer) 
	Protected m_Extranjero As Nullable(Of Boolean) 
	Protected m_LugarNacimientoExtranjero As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property AlumnoID() As Integer
        Get
            Return (m_AlumnoID)
        End Get
		Set(ByVal Value As Integer)					
			m_AlumnoID = Value
		End Set
    End Property
	
	Public Property objPersonaID() As Nullable(Of Integer)
        Get
            Return (m_objPersonaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPersonaID = Value
		End Set
    End Property
	
	Public Property CodigoMED() As String
        Get
            Return (m_CodigoMED)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("CodigoMED", Value.ToString(), "Valor inv?lido para StbAlumnos.CodigoMED. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_CodigoMED = Value
		End Set
    End Property
	
	Public Property objLugarNacimientoID() As Nullable(Of Integer)
        Get
            Return (m_objLugarNacimientoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objLugarNacimientoID = Value
		End Set
    End Property
	
	Public Property objReligionID() As Nullable(Of Integer)
        Get
            Return (m_objReligionID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objReligionID = Value
		End Set
    End Property
	
	Public Property InformacionCentro() As String
        Get
            Return (m_InformacionCentro)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("InformacionCentro", Value.ToString(), "Valor inv?lido para StbAlumnos.InformacionCentro. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_InformacionCentro = Value
		End Set
    End Property
	
	Public Property CausaIngreso() As String
        Get
            Return (m_CausaIngreso)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("CausaIngreso", Value.ToString(), "Valor inv?lido para StbAlumnos.CausaIngreso. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_CausaIngreso = Value
		End Set
    End Property
	
	Public Property Importancia() As String
        Get
            Return (m_Importancia)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("Importancia", Value.ToString(), "Valor inv?lido para StbAlumnos.Importancia. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_Importancia = Value
		End Set
    End Property
	
	Public Property Recomendaciones() As String
        Get
            Return (m_Recomendaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("Recomendaciones", Value.ToString(), "Valor inv?lido para StbAlumnos.Recomendaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_Recomendaciones = Value
		End Set
    End Property
	
	Public Property Espera() As String
        Get
            Return (m_Espera)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("Espera", Value.ToString(), "Valor inv?lido para StbAlumnos.Espera. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_Espera = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 200 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para StbAlumnos.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (200).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activo = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbAlumnos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Nullable(Of Date)
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbAlumnos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	
	Public Property objResponsableID() As Nullable(Of Integer)
        Get
            Return (m_objResponsableID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objResponsableID = Value
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
	
	Public Property LugarNacimientoExtranjero() As String
        Get
            Return (m_LugarNacimientoExtranjero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("LugarNacimientoExtranjero", Value.ToString(), "Valor inv?lido para StbAlumnos.LugarNacimientoExtranjero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_LugarNacimientoExtranjero = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "CodigoMED"
				Return	50
			Case "InformacionCentro"
				Return	200
			Case "CausaIngreso"
				Return	200
			Case "Importancia"
				Return	200
			Case "Recomendaciones"
				Return	200
			Case "Espera"
				Return	200
			Case "Observaciones"
				Return	200
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "LugarNacimientoExtranjero"
				Return	30
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
    ''' Salva un DataSet del tipo de la tabla StbAlumnos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbAlumnos </param>    
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
			cmdDelete.Parameters.Add("@AlumnoID", SqlDbType.Int, 4, "AlumnoID" )
			cmdDelete.CommandText = "DELETE FROM  StbAlumnos WHERE AlumnoID= @AlumnoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdInsert.Parameters.Add("@CodigoMED", SqlDbType.VarChar, 50, "CodigoMED")
			cmdInsert.Parameters.Add("@objLugarNacimientoID", SqlDbType.Int, 4, "objLugarNacimientoID")
			cmdInsert.Parameters.Add("@objReligionID", SqlDbType.Int, 4, "objReligionID")
			cmdInsert.Parameters.Add("@InformacionCentro", SqlDbType.VarChar, 200, "InformacionCentro")
			cmdInsert.Parameters.Add("@CausaIngreso", SqlDbType.VarChar, 200, "CausaIngreso")
			cmdInsert.Parameters.Add("@Importancia", SqlDbType.VarChar, 200, "Importancia")
			cmdInsert.Parameters.Add("@Recomendaciones", SqlDbType.VarChar, 200, "Recomendaciones")
			cmdInsert.Parameters.Add("@Espera", SqlDbType.VarChar, 200, "Espera")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, 200, "Observaciones")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objResponsableID", SqlDbType.Int, 4, "objResponsableID")
			cmdInsert.Parameters.Add("@Extranjero", SqlDbType.Bit, 1, "Extranjero")
			cmdInsert.Parameters.Add("@LugarNacimientoExtranjero", SqlDbType.VarChar, 30, "LugarNacimientoExtranjero")
			cmdInsert.CommandText = "INSERT INTO StbAlumnos ( objPersonaID, CodigoMED, objLugarNacimientoID, objReligionID, InformacionCentro, CausaIngreso, Importancia, Recomendaciones, Espera, Observaciones, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objResponsableID, Extranjero, LugarNacimientoExtranjero) VALUES ( @objPersonaID, @CodigoMED, @objLugarNacimientoID, @objReligionID, @InformacionCentro, @CausaIngreso, @Importancia, @Recomendaciones, @Espera, @Observaciones, @Activo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objResponsableID, @Extranjero, @LugarNacimientoExtranjero)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdUpdate.Parameters.Add("@CodigoMED", SqlDbType.VarChar, 50, "CodigoMED")
			cmdUpdate.Parameters.Add("@objLugarNacimientoID", SqlDbType.Int, 4, "objLugarNacimientoID")
			cmdUpdate.Parameters.Add("@objReligionID", SqlDbType.Int, 4, "objReligionID")
			cmdUpdate.Parameters.Add("@InformacionCentro", SqlDbType.VarChar, 200, "InformacionCentro")
			cmdUpdate.Parameters.Add("@CausaIngreso", SqlDbType.VarChar, 200, "CausaIngreso")
			cmdUpdate.Parameters.Add("@Importancia", SqlDbType.VarChar, 200, "Importancia")
			cmdUpdate.Parameters.Add("@Recomendaciones", SqlDbType.VarChar, 200, "Recomendaciones")
			cmdUpdate.Parameters.Add("@Espera", SqlDbType.VarChar, 200, "Espera")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, 200, "Observaciones")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objResponsableID", SqlDbType.Int, 4, "objResponsableID")
			cmdUpdate.Parameters.Add("@Extranjero", SqlDbType.Bit, 1, "Extranjero")
			cmdUpdate.Parameters.Add("@LugarNacimientoExtranjero", SqlDbType.VarChar, 30, "LugarNacimientoExtranjero")
			cmdUpdate.Parameters.Add("@wAlumnoID", SqlDbType.Int, 4, "AlumnoID")
			cmdUpdate.CommandText = "UPDATE StbAlumnos SET objPersonaID=@objPersonaID, CodigoMED=@CodigoMED, objLugarNacimientoID=@objLugarNacimientoID, objReligionID=@objReligionID, InformacionCentro=@InformacionCentro, CausaIngreso=@CausaIngreso, Importancia=@Importancia, Recomendaciones=@Recomendaciones, Espera=@Espera, Observaciones=@Observaciones, Activo=@Activo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objResponsableID=@objResponsableID, Extranjero=@Extranjero, LugarNacimientoExtranjero=@LugarNacimientoExtranjero WHERE AlumnoID= @wAlumnoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbAlumnos")
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
    ''' Devuelve de la base de datos un objeto StbAlumnos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_AlumnoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbAlumnos where " & " AlumnoID = " & p_AlumnoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_AlumnoID = dr("AlumnoID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))
				m_CodigoMED = IIf(IsDBNull(dr("CodigoMED")), Nothing, dr("CodigoMED"))
				m_objLugarNacimientoID = IIf(IsDBNull(dr("objLugarNacimientoID")), Nothing, dr("objLugarNacimientoID"))
				m_objReligionID = IIf(IsDBNull(dr("objReligionID")), Nothing, dr("objReligionID"))
				m_InformacionCentro = IIf(IsDBNull(dr("InformacionCentro")), Nothing, dr("InformacionCentro"))
				m_CausaIngreso = IIf(IsDBNull(dr("CausaIngreso")), Nothing, dr("CausaIngreso"))
				m_Importancia = IIf(IsDBNull(dr("Importancia")), Nothing, dr("Importancia"))
				m_Recomendaciones = IIf(IsDBNull(dr("Recomendaciones")), Nothing, dr("Recomendaciones"))
				m_Espera = IIf(IsDBNull(dr("Espera")), Nothing, dr("Espera"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objResponsableID = IIf(IsDBNull(dr("objResponsableID")), Nothing, dr("objResponsableID"))
				m_Extranjero = IIf(IsDBNull(dr("Extranjero")), Nothing, dr("Extranjero"))
				m_LugarNacimientoExtranjero = IIf(IsDBNull(dr("LugarNacimientoExtranjero")), Nothing, dr("LugarNacimientoExtranjero"))
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
    ''' Devuelve de la base de datos un objeto StbAlumnos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbAlumnos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_AlumnoID = dr("AlumnoID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))
				m_CodigoMED = IIf(IsDBNull(dr("CodigoMED")), Nothing, dr("CodigoMED"))
				m_objLugarNacimientoID = IIf(IsDBNull(dr("objLugarNacimientoID")), Nothing, dr("objLugarNacimientoID"))
				m_objReligionID = IIf(IsDBNull(dr("objReligionID")), Nothing, dr("objReligionID"))
				m_InformacionCentro = IIf(IsDBNull(dr("InformacionCentro")), Nothing, dr("InformacionCentro"))
				m_CausaIngreso = IIf(IsDBNull(dr("CausaIngreso")), Nothing, dr("CausaIngreso"))
				m_Importancia = IIf(IsDBNull(dr("Importancia")), Nothing, dr("Importancia"))
				m_Recomendaciones = IIf(IsDBNull(dr("Recomendaciones")), Nothing, dr("Recomendaciones"))
				m_Espera = IIf(IsDBNull(dr("Espera")), Nothing, dr("Espera"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objResponsableID = IIf(IsDBNull(dr("objResponsableID")), Nothing, dr("objResponsableID"))
				m_Extranjero = IIf(IsDBNull(dr("Extranjero")), Nothing, dr("Extranjero"))
				m_LugarNacimientoExtranjero = IIf(IsDBNull(dr("LugarNacimientoExtranjero")), Nothing, dr("LugarNacimientoExtranjero"))
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
    ''' Trae de la base de datos un conjunto de objetos StbAlumnos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbAlumnos"

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
			ds.Tables(0).TableName = "StbAlumnos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbAlumnos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbAlumnos"

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
			ds.Tables(0).TableName = "StbAlumnos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbAlumnos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbAlumnos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbAlumnos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbAlumnos("
		sCommand &= "objPersonaID,"
		sCommand &= "CodigoMED,"
		sCommand &= "objLugarNacimientoID,"
		sCommand &= "objReligionID,"
		sCommand &= "InformacionCentro,"
		sCommand &= "CausaIngreso,"
		sCommand &= "Importancia,"
		sCommand &= "Recomendaciones,"
		sCommand &= "Espera,"
		sCommand &= "Observaciones,"
		sCommand &= "Activo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objResponsableID,"
		sCommand &= "Extranjero,"
		sCommand &= "LugarNacimientoExtranjero) values ("		
		sCommand &= "@objPersonaID,"
		sCommand &= "@CodigoMED,"
		sCommand &= "@objLugarNacimientoID,"
		sCommand &= "@objReligionID,"
		sCommand &= "@InformacionCentro,"
		sCommand &= "@CausaIngreso,"
		sCommand &= "@Importancia,"
		sCommand &= "@Recomendaciones,"
		sCommand &= "@Espera,"
		sCommand &= "@Observaciones,"
		sCommand &= "@Activo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objResponsableID,"
		sCommand &= "@Extranjero,"
		sCommand &= "@LugarNacimientoExtranjero)"		
	
		sCommand &= " select "
		sCommand &= "@AlumnoID = AlumnoID from StbAlumnos where "		
		sCommand &= "AlumnoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@AlumnoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@CodigoMED", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoMED) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_CodigoMED
        End If
		arParams(3) = New SqlParameter("@objLugarNacimientoID", SqlDbType.Int)		
		If IsDBNull(m_objLugarNacimientoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objLugarNacimientoID
        End If
		arParams(4) = New SqlParameter("@objReligionID", SqlDbType.Int)		
		If IsDBNull(m_objReligionID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objReligionID
        End If
		arParams(5) = New SqlParameter("@InformacionCentro", SqlDbType.VarChar)		
		If IsDBNull(m_InformacionCentro) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_InformacionCentro
        End If
		arParams(6) = New SqlParameter("@CausaIngreso", SqlDbType.VarChar)		
		If IsDBNull(m_CausaIngreso) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CausaIngreso
        End If
		arParams(7) = New SqlParameter("@Importancia", SqlDbType.VarChar)		
		If IsDBNull(m_Importancia) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Importancia
        End If
		arParams(8) = New SqlParameter("@Recomendaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Recomendaciones) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Recomendaciones
        End If
		arParams(9) = New SqlParameter("@Espera", SqlDbType.VarChar)		
		If IsDBNull(m_Espera) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Espera
        End If
		arParams(10) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Observaciones
        End If
		arParams(11) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activo
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@objResponsableID", SqlDbType.Int)		
		If IsDBNull(m_objResponsableID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objResponsableID
        End If
		arParams(17) = New SqlParameter("@Extranjero", SqlDbType.Bit)		
		If IsDBNull(m_Extranjero) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Extranjero
        End If
		arParams(18) = New SqlParameter("@LugarNacimientoExtranjero", SqlDbType.VarChar)		
		If IsDBNull(m_LugarNacimientoExtranjero) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_LugarNacimientoExtranjero
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_AlumnoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbAlumnos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbAlumnos set "		
		sCommand &= "objPersonaID = @objPersonaID,"
		sCommand &= "CodigoMED = @CodigoMED,"
		sCommand &= "objLugarNacimientoID = @objLugarNacimientoID,"
		sCommand &= "objReligionID = @objReligionID,"
		sCommand &= "InformacionCentro = @InformacionCentro,"
		sCommand &= "CausaIngreso = @CausaIngreso,"
		sCommand &= "Importancia = @Importancia,"
		sCommand &= "Recomendaciones = @Recomendaciones,"
		sCommand &= "Espera = @Espera,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objResponsableID = @objResponsableID,"
		sCommand &= "Extranjero = @Extranjero,"
		sCommand &= "LugarNacimientoExtranjero = @LugarNacimientoExtranjero"		
		sCommand &= " where "	
		sCommand &= "AlumnoID = @AlumnoID"					
		
		Dim arParams(18) As SqlParameter
		arParams(0) = New SqlParameter("@AlumnoID", SqlDbType.Int)		
		If IsDBNull(m_AlumnoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_AlumnoID
        End If
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@CodigoMED", SqlDbType.VarChar)		
		If IsDBNull(m_CodigoMED) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_CodigoMED
        End If
		arParams(3) = New SqlParameter("@objLugarNacimientoID", SqlDbType.Int)		
		If IsDBNull(m_objLugarNacimientoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objLugarNacimientoID
        End If
		arParams(4) = New SqlParameter("@objReligionID", SqlDbType.Int)		
		If IsDBNull(m_objReligionID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objReligionID
        End If
		arParams(5) = New SqlParameter("@InformacionCentro", SqlDbType.VarChar)		
		If IsDBNull(m_InformacionCentro) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_InformacionCentro
        End If
		arParams(6) = New SqlParameter("@CausaIngreso", SqlDbType.VarChar)		
		If IsDBNull(m_CausaIngreso) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_CausaIngreso
        End If
		arParams(7) = New SqlParameter("@Importancia", SqlDbType.VarChar)		
		If IsDBNull(m_Importancia) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Importancia
        End If
		arParams(8) = New SqlParameter("@Recomendaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Recomendaciones) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Recomendaciones
        End If
		arParams(9) = New SqlParameter("@Espera", SqlDbType.VarChar)		
		If IsDBNull(m_Espera) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Espera
        End If
		arParams(10) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Observaciones
        End If
		arParams(11) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activo
        End If
		arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@objResponsableID", SqlDbType.Int)		
		If IsDBNull(m_objResponsableID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objResponsableID
        End If
		arParams(17) = New SqlParameter("@Extranjero", SqlDbType.Bit)		
		If IsDBNull(m_Extranjero) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Extranjero
        End If
		arParams(18) = New SqlParameter("@LugarNacimientoExtranjero", SqlDbType.VarChar)		
		If IsDBNull(m_LugarNacimientoExtranjero) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_LugarNacimientoExtranjero
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
    ''' Borra un objeto StbAlumnos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbAlumnos where " & " AlumnoID = " & m_AlumnoID
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
    ''' Borra un objeto StbAlumnos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_AlumnoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbAlumnos where " & " AlumnoID = " & p_AlumnoID
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
    ''' Borra objetos StbAlumnos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbAlumnos where " & pWhere
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
