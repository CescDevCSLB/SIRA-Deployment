Imports DAL
Imports System.Data.SqlClient

''' <summary>
''' Cuentas de Usuario.
''' </summary>
Partial Public Class SsgCuenta		

#Region " Variables Miembro " 
	Protected m_SsgCuentaID As Integer 
	Protected m_Login As String = Nothing 
	Protected m_Clave As String = Nothing 
	Protected m_Activo As Boolean 
	Protected m_FechaExpiracion As Nullable(Of Date) 
	Protected m_objEmpleadoID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	''' <summary>
	''' Llave Principal de la Tabla SsgCuenta
	''' </summary>
	Public Property SsgCuentaID() As Integer
        Get
            Return (m_SsgCuentaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SsgCuentaID = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del usuario. Varchar (20). No permite Null.
	''' </summary>
	Public Property Login() As String
        Get
            Return (m_Login)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Login", Value.ToString(), "Valor inv?lido para SsgCuenta.Login. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Login = Value
		End Set
    End Property
	
	''' <summary>
	''' Clave del usuario. Varchar (10). No permite Null.
	''' </summary>
	Public Property Clave() As String
        Get
            Return (m_Clave)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 80 Then
					Throw New ArgumentOutOfRangeException("Clave", Value.ToString(), "Valor inv?lido para SsgCuenta.Clave. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (80).")
				End If
			End If
			m_Clave = Value
		End Set
    End Property
	
	''' <summary>
	''' Indica si la cuenta de usuario está Activa o no. No permite null.
	''' </summary>
	Public Property Activo() As Boolean
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Boolean)					
			m_Activo = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha en que expira la cuenta de usuario. Permite Null.
	''' </summary>
	Public Property FechaExpiracion() As Nullable(Of Date)
        Get
            Return (m_FechaExpiracion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaExpiracion = Value
		End Set
    End Property
	
	''' <summary>
	''' ID del empleado asociado a la cuenta de usuario del sistema.
	''' </summary>
	Public Property objEmpleadoID() As Nullable(Of Integer)
        Get
            Return (m_objEmpleadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEmpleadoID = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del Usuario que creó el registro. Varchar (30). No permite Null.
	''' </summary>
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SsgCuenta.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Fecha en que se crea la cuenta de usuario. Por defecto es la fecha del sistema. No permite Null.
	''' </summary>
	Public Property FechaCreacion() As Nullable(Of Date)
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCreacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Login del último usuario que modificó el registro. Varchar (30). Permite Null.
	''' </summary>
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SsgCuenta.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	''' <summary>
	''' Última fecha en que se modificó el registro. Corresponde a la fecha del servidor de base de datos. Permite Null, sin embargo al llenarse el dato UsuarioModificacion debe llenarse éste también.
	''' </summary>
	Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return (m_FechaModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Login"
				Return	50
			Case "Clave"
				Return	80
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
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
    ''' Salva un DataSet del tipo de la tabla SsgCuenta en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SsgCuenta </param>    
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
			cmdDelete.Parameters.Add("@SsgCuentaID", SqlDbType.Int, 4, "SsgCuentaID" )
			cmdDelete.CommandText = "DELETE FROM  SsgCuenta WHERE SsgCuentaID= @SsgCuentaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Login", SqlDbType.VarChar, 50, "Login")
			cmdInsert.Parameters.Add("@Clave", SqlDbType.VarChar, 80, "Clave")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@FechaExpiracion", SqlDbType.DateTime, 8, "FechaExpiracion")
			cmdInsert.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SsgCuenta ( Login, Clave, Activo, FechaExpiracion, objEmpleadoID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @Login, @Clave, @Activo, @FechaExpiracion, @objEmpleadoID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Login", SqlDbType.VarChar, 50, "Login")
			cmdUpdate.Parameters.Add("@Clave", SqlDbType.VarChar, 80, "Clave")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@FechaExpiracion", SqlDbType.DateTime, 8, "FechaExpiracion")
			cmdUpdate.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSsgCuentaID", SqlDbType.Int, 4, "SsgCuentaID")
			cmdUpdate.CommandText = "UPDATE SsgCuenta SET Login=@Login, Clave=@Clave, Activo=@Activo, FechaExpiracion=@FechaExpiracion, objEmpleadoID=@objEmpleadoID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SsgCuentaID= @wSsgCuentaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SsgCuenta")
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
    ''' Devuelve de la base de datos un objeto SsgCuenta
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SsgCuentaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SsgCuenta where " & " SsgCuentaID = " & p_SsgCuentaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SsgCuentaID = dr("SsgCuentaID")
				m_Login = IIf(IsDBNull(dr("Login")), Nothing, dr("Login"))
				m_Clave = IIf(IsDBNull(dr("Clave")), Nothing, dr("Clave"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_FechaExpiracion = IIf(IsDBNull(dr("FechaExpiracion")), Nothing, dr("FechaExpiracion"))
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
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
    ''' Devuelve de la base de datos un objeto SsgCuenta usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SsgCuenta where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SsgCuentaID = dr("SsgCuentaID")
				m_Login = IIf(IsDBNull(dr("Login")), Nothing, dr("Login"))
				m_Clave = IIf(IsDBNull(dr("Clave")), Nothing, dr("Clave"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_FechaExpiracion = IIf(IsDBNull(dr("FechaExpiracion")), Nothing, dr("FechaExpiracion"))
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
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
    ''' Trae de la base de datos un conjunto de objetos SsgCuenta en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SsgCuenta"

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
			ds.Tables(0).TableName = "SsgCuenta"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SsgCuenta en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SsgCuenta"

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
			ds.Tables(0).TableName = "SsgCuenta"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SsgCuenta en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SsgCuenta"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SsgCuenta.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SsgCuenta("
		sCommand &= "Login,"
		sCommand &= "Clave,"
		sCommand &= "Activo,"
		sCommand &= "FechaExpiracion,"
		sCommand &= "objEmpleadoID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@Login,"
		sCommand &= "@Clave,"
		sCommand &= "@Activo,"
		sCommand &= "@FechaExpiracion,"
		sCommand &= "@objEmpleadoID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SsgCuentaID = SsgCuentaID from SsgCuenta where "		
		sCommand &= "SsgCuentaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SsgCuentaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Login", SqlDbType.VarChar)		
		If IsDBNull(m_Login) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Login
        End If
		arParams(2) = New SqlParameter("@Clave", SqlDbType.VarChar)		
		If IsDBNull(m_Clave) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Clave
        End If
		arParams(3) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Activo
        End If
		arParams(4) = New SqlParameter("@FechaExpiracion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaExpiracion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaExpiracion
        End If
		arParams(5) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEmpleadoID
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SsgCuentaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SsgCuenta en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SsgCuenta set "		
		sCommand &= "Login = @Login,"
		sCommand &= "Clave = @Clave,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "FechaExpiracion = @FechaExpiracion,"
		sCommand &= "objEmpleadoID = @objEmpleadoID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SsgCuentaID = @SsgCuentaID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SsgCuentaID", SqlDbType.Int)		
		If IsDBNull(m_SsgCuentaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SsgCuentaID
        End If
		arParams(1) = New SqlParameter("@Login", SqlDbType.VarChar)		
		If IsDBNull(m_Login) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Login
        End If
		arParams(2) = New SqlParameter("@Clave", SqlDbType.VarChar)		
		If IsDBNull(m_Clave) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Clave
        End If
		arParams(3) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Activo
        End If
		arParams(4) = New SqlParameter("@FechaExpiracion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaExpiracion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaExpiracion
        End If
		arParams(5) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEmpleadoID
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
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
    ''' Borra un objeto SsgCuenta de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgCuenta where " & " SsgCuentaID = " & m_SsgCuentaID
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
    ''' Borra un objeto SsgCuenta de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SsgCuentaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgCuenta where " & " SsgCuentaID = " & p_SsgCuentaID
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
    ''' Borra objetos SsgCuenta de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SsgCuenta where " & pWhere
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