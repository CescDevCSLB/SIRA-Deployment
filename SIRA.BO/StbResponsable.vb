Imports DAL
Imports System.Data.SqlClient

Partial Public Class StbResponsable		

#Region " Variables Miembro " 
	Protected m_ResponsableID As Integer 
	Protected m_objPersonaID As Nullable(Of Integer) 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_Ocupacion As String = Nothing 
	Protected m_LugarTrabajo As String = Nothing 
	Protected m_NivelAcademico As String = Nothing 
	Protected m_objReligionID As Nullable(Of Integer) 
	Protected m_objParentescoID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_Profesion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ResponsableID() As Integer
        Get
            Return (m_ResponsableID)
        End Get
		Set(ByVal Value As Integer)					
			m_ResponsableID = Value
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
	
	Public Property objAlumnoID() As Nullable(Of Integer)
        Get
            Return (m_objAlumnoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objAlumnoID = Value
		End Set
    End Property
	
	Public Property Ocupacion() As String
        Get
            Return (m_Ocupacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Ocupacion", Value.ToString(), "Valor inv?lido para StbResponsable.Ocupacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Ocupacion = Value
		End Set
    End Property
	
	Public Property LugarTrabajo() As String
        Get
            Return (m_LugarTrabajo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("LugarTrabajo", Value.ToString(), "Valor inv?lido para StbResponsable.LugarTrabajo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_LugarTrabajo = Value
		End Set
    End Property
	
	Public Property NivelAcademico() As String
        Get
            Return (m_NivelAcademico)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("NivelAcademico", Value.ToString(), "Valor inv?lido para StbResponsable.NivelAcademico. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_NivelAcademico = Value
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
	
	Public Property objParentescoID() As Nullable(Of Integer)
        Get
            Return (m_objParentescoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objParentescoID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para StbResponsable.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para StbResponsable.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property Profesion() As String
        Get
            Return (m_Profesion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Profesion", Value.ToString(), "Valor inv?lido para StbResponsable.Profesion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Profesion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Ocupacion"
				Return	150
			Case "LugarTrabajo"
				Return	150
			Case "NivelAcademico"
				Return	150
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "Profesion"
				Return	150
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
    ''' Salva un DataSet del tipo de la tabla StbResponsable en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbResponsable </param>    
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
			cmdDelete.Parameters.Add("@ResponsableID", SqlDbType.Int, 4, "ResponsableID" )
			cmdDelete.CommandText = "DELETE FROM  StbResponsable WHERE ResponsableID= @ResponsableID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@Ocupacion", SqlDbType.VarChar, 150, "Ocupacion")
			cmdInsert.Parameters.Add("@LugarTrabajo", SqlDbType.VarChar, 150, "LugarTrabajo")
			cmdInsert.Parameters.Add("@NivelAcademico", SqlDbType.VarChar, 150, "NivelAcademico")
			cmdInsert.Parameters.Add("@objReligionID", SqlDbType.Int, 4, "objReligionID")
			cmdInsert.Parameters.Add("@objParentescoID", SqlDbType.Int, 4, "objParentescoID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@Profesion", SqlDbType.VarChar, 150, "Profesion")
			cmdInsert.CommandText = "INSERT INTO StbResponsable ( objPersonaID, objAlumnoID, Ocupacion, LugarTrabajo, NivelAcademico, objReligionID, objParentescoID, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, Profesion) VALUES ( @objPersonaID, @objAlumnoID, @Ocupacion, @LugarTrabajo, @NivelAcademico, @objReligionID, @objParentescoID, @Activo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @Profesion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPersonaID", SqlDbType.Int, 4, "objPersonaID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@Ocupacion", SqlDbType.VarChar, 150, "Ocupacion")
			cmdUpdate.Parameters.Add("@LugarTrabajo", SqlDbType.VarChar, 150, "LugarTrabajo")
			cmdUpdate.Parameters.Add("@NivelAcademico", SqlDbType.VarChar, 150, "NivelAcademico")
			cmdUpdate.Parameters.Add("@objReligionID", SqlDbType.Int, 4, "objReligionID")
			cmdUpdate.Parameters.Add("@objParentescoID", SqlDbType.Int, 4, "objParentescoID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@Profesion", SqlDbType.VarChar, 150, "Profesion")
			cmdUpdate.Parameters.Add("@wResponsableID", SqlDbType.Int, 4, "ResponsableID")
			cmdUpdate.CommandText = "UPDATE StbResponsable SET objPersonaID=@objPersonaID, objAlumnoID=@objAlumnoID, Ocupacion=@Ocupacion, LugarTrabajo=@LugarTrabajo, NivelAcademico=@NivelAcademico, objReligionID=@objReligionID, objParentescoID=@objParentescoID, Activo=@Activo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, Profesion=@Profesion WHERE ResponsableID= @wResponsableID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbResponsable")
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
    ''' Devuelve de la base de datos un objeto StbResponsable
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ResponsableID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbResponsable where " & " ResponsableID = " & p_ResponsableID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ResponsableID = dr("ResponsableID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_Ocupacion = IIf(IsDBNull(dr("Ocupacion")), Nothing, dr("Ocupacion"))
				m_LugarTrabajo = IIf(IsDBNull(dr("LugarTrabajo")), Nothing, dr("LugarTrabajo"))
				m_NivelAcademico = IIf(IsDBNull(dr("NivelAcademico")), Nothing, dr("NivelAcademico"))
				m_objReligionID = IIf(IsDBNull(dr("objReligionID")), Nothing, dr("objReligionID"))
				m_objParentescoID = IIf(IsDBNull(dr("objParentescoID")), Nothing, dr("objParentescoID"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Profesion = IIf(IsDBNull(dr("Profesion")), Nothing, dr("Profesion"))
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
    ''' Devuelve de la base de datos un objeto StbResponsable usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbResponsable where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ResponsableID = dr("ResponsableID")
				m_objPersonaID = IIf(IsDBNull(dr("objPersonaID")), Nothing, dr("objPersonaID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_Ocupacion = IIf(IsDBNull(dr("Ocupacion")), Nothing, dr("Ocupacion"))
				m_LugarTrabajo = IIf(IsDBNull(dr("LugarTrabajo")), Nothing, dr("LugarTrabajo"))
				m_NivelAcademico = IIf(IsDBNull(dr("NivelAcademico")), Nothing, dr("NivelAcademico"))
				m_objReligionID = IIf(IsDBNull(dr("objReligionID")), Nothing, dr("objReligionID"))
				m_objParentescoID = IIf(IsDBNull(dr("objParentescoID")), Nothing, dr("objParentescoID"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Profesion = IIf(IsDBNull(dr("Profesion")), Nothing, dr("Profesion"))
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
    ''' Trae de la base de datos un conjunto de objetos StbResponsable en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbResponsable"

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
			ds.Tables(0).TableName = "StbResponsable"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbResponsable en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbResponsable"

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
			ds.Tables(0).TableName = "StbResponsable"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbResponsable en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbResponsable"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbResponsable.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbResponsable("
		sCommand &= "objPersonaID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "Ocupacion,"
		sCommand &= "LugarTrabajo,"
		sCommand &= "NivelAcademico,"
		sCommand &= "objReligionID,"
		sCommand &= "objParentescoID,"
		sCommand &= "Activo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "Profesion) values ("		
		sCommand &= "@objPersonaID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@Ocupacion,"
		sCommand &= "@LugarTrabajo,"
		sCommand &= "@NivelAcademico,"
		sCommand &= "@objReligionID,"
		sCommand &= "@objParentescoID,"
		sCommand &= "@Activo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@Profesion)"		
	
		sCommand &= " select "
		sCommand &= "@ResponsableID = ResponsableID from StbResponsable where "		
		sCommand &= "ResponsableID = SCOPE_IDENTITY()"
		
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@ResponsableID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@Ocupacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ocupacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Ocupacion
        End If
		arParams(4) = New SqlParameter("@LugarTrabajo", SqlDbType.VarChar)		
		If IsDBNull(m_LugarTrabajo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_LugarTrabajo
        End If
		arParams(5) = New SqlParameter("@NivelAcademico", SqlDbType.VarChar)		
		If IsDBNull(m_NivelAcademico) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_NivelAcademico
        End If
		arParams(6) = New SqlParameter("@objReligionID", SqlDbType.Int)		
		If IsDBNull(m_objReligionID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objReligionID
        End If
		arParams(7) = New SqlParameter("@objParentescoID", SqlDbType.Int)		
		If IsDBNull(m_objParentescoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objParentescoID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@Profesion", SqlDbType.VarChar)		
		If IsDBNull(m_Profesion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Profesion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ResponsableID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbResponsable en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbResponsable set "		
		sCommand &= "objPersonaID = @objPersonaID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "Ocupacion = @Ocupacion,"
		sCommand &= "LugarTrabajo = @LugarTrabajo,"
		sCommand &= "NivelAcademico = @NivelAcademico,"
		sCommand &= "objReligionID = @objReligionID,"
		sCommand &= "objParentescoID = @objParentescoID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "Profesion = @Profesion"		
		sCommand &= " where "	
		sCommand &= "ResponsableID = @ResponsableID"					
		
		Dim arParams(13) As SqlParameter
		arParams(0) = New SqlParameter("@ResponsableID", SqlDbType.Int)		
		If IsDBNull(m_ResponsableID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ResponsableID
        End If
		arParams(1) = New SqlParameter("@objPersonaID", SqlDbType.Int)		
		If IsDBNull(m_objPersonaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPersonaID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@Ocupacion", SqlDbType.VarChar)		
		If IsDBNull(m_Ocupacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Ocupacion
        End If
		arParams(4) = New SqlParameter("@LugarTrabajo", SqlDbType.VarChar)		
		If IsDBNull(m_LugarTrabajo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_LugarTrabajo
        End If
		arParams(5) = New SqlParameter("@NivelAcademico", SqlDbType.VarChar)		
		If IsDBNull(m_NivelAcademico) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_NivelAcademico
        End If
		arParams(6) = New SqlParameter("@objReligionID", SqlDbType.Int)		
		If IsDBNull(m_objReligionID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objReligionID
        End If
		arParams(7) = New SqlParameter("@objParentescoID", SqlDbType.Int)		
		If IsDBNull(m_objParentescoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objParentescoID
        End If
		arParams(8) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Activo
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@Profesion", SqlDbType.VarChar)		
		If IsDBNull(m_Profesion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Profesion
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
    ''' Borra un objeto StbResponsable de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbResponsable where " & " ResponsableID = " & m_ResponsableID
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
    ''' Borra un objeto StbResponsable de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ResponsableID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbResponsable where " & " ResponsableID = " & p_ResponsableID
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
    ''' Borra objetos StbResponsable de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbResponsable where " & pWhere
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
