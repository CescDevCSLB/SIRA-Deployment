Imports DAL
Imports System.Data.SqlClient

Partial Public Class SContSubSubCuentasContables		

#Region " Variables Miembro " 
	Protected m_SContSubSubCuentasContablesID As Integer 
	Protected m_objSContSubCuentasContablesID As Nullable(Of Integer) 
	Protected m_IDCuenta As String = Nothing 
	Protected m_Descripcion As String = Nothing 
	Protected m_Naturaleza As String = Nothing 
	Protected m_AceptaDatos As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SContSubSubCuentasContablesID() As Integer
        Get
            Return (m_SContSubSubCuentasContablesID)
        End Get
		Set(ByVal Value As Integer)					
			m_SContSubSubCuentasContablesID = Value
		End Set
    End Property
	
	Public Property objSContSubCuentasContablesID() As Nullable(Of Integer)
        Get
            Return (m_objSContSubCuentasContablesID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSContSubCuentasContablesID = Value
		End Set
    End Property
	
	Public Property IDCuenta() As String
        Get
            Return (m_IDCuenta)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("IDCuenta", Value.ToString(), "Valor inv?lido para SContSubSubCuentasContables.IDCuenta. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_IDCuenta = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SContSubSubCuentasContables.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property Naturaleza() As String
        Get
            Return (m_Naturaleza)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Naturaleza", Value.ToString(), "Valor inv?lido para SContSubSubCuentasContables.Naturaleza. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Naturaleza = Value
		End Set
    End Property
	
	Public Property AceptaDatos() As Nullable(Of Boolean)
        Get
            Return (m_AceptaDatos)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_AceptaDatos = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SContSubSubCuentasContables.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SContSubSubCuentasContables.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "IDCuenta"
				Return	50
			Case "Descripcion"
				Return	150
			Case "Naturaleza"
				Return	50
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
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
    ''' Salva un DataSet del tipo de la tabla SContSubSubCuentasContables en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SContSubSubCuentasContables </param>    
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
			cmdDelete.Parameters.Add("@SContSubSubCuentasContablesID", SqlDbType.Int, 4, "SContSubSubCuentasContablesID" )
			cmdDelete.CommandText = "DELETE FROM  SContSubSubCuentasContables WHERE SContSubSubCuentasContablesID= @SContSubSubCuentasContablesID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSContSubCuentasContablesID", SqlDbType.Int, 4, "objSContSubCuentasContablesID")
			cmdInsert.Parameters.Add("@IDCuenta", SqlDbType.VarChar, 50, "IDCuenta")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion")
			cmdInsert.Parameters.Add("@Naturaleza", SqlDbType.VarChar, 50, "Naturaleza")
			cmdInsert.Parameters.Add("@AceptaDatos", SqlDbType.Bit, 1, "AceptaDatos")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.CommandText = "INSERT INTO SContSubSubCuentasContables ( objSContSubCuentasContablesID, IDCuenta, Descripcion, Naturaleza, AceptaDatos, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Activo) VALUES ( @objSContSubCuentasContablesID, @IDCuenta, @Descripcion, @Naturaleza, @AceptaDatos, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Activo)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSContSubCuentasContablesID", SqlDbType.Int, 4, "objSContSubCuentasContablesID")
			cmdUpdate.Parameters.Add("@IDCuenta", SqlDbType.VarChar, 50, "IDCuenta")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion")
			cmdUpdate.Parameters.Add("@Naturaleza", SqlDbType.VarChar, 50, "Naturaleza")
			cmdUpdate.Parameters.Add("@AceptaDatos", SqlDbType.Bit, 1, "AceptaDatos")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@wSContSubSubCuentasContablesID", SqlDbType.Int, 4, "SContSubSubCuentasContablesID")
			cmdUpdate.CommandText = "UPDATE SContSubSubCuentasContables SET objSContSubCuentasContablesID=@objSContSubCuentasContablesID, IDCuenta=@IDCuenta, Descripcion=@Descripcion, Naturaleza=@Naturaleza, AceptaDatos=@AceptaDatos, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Activo=@Activo WHERE SContSubSubCuentasContablesID= @wSContSubSubCuentasContablesID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SContSubSubCuentasContables")
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
    ''' Devuelve de la base de datos un objeto SContSubSubCuentasContables
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SContSubSubCuentasContablesID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContSubSubCuentasContables where " & " SContSubSubCuentasContablesID = " & p_SContSubSubCuentasContablesID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SContSubSubCuentasContablesID = dr("SContSubSubCuentasContablesID")
				m_objSContSubCuentasContablesID = IIf(IsDBNull(dr("objSContSubCuentasContablesID")), Nothing, dr("objSContSubCuentasContablesID"))
				m_IDCuenta = IIf(IsDBNull(dr("IDCuenta")), Nothing, dr("IDCuenta"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_Naturaleza = IIf(IsDBNull(dr("Naturaleza")), Nothing, dr("Naturaleza"))
				m_AceptaDatos = IIf(IsDBNull(dr("AceptaDatos")), Nothing, dr("AceptaDatos"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
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
    ''' Devuelve de la base de datos un objeto SContSubSubCuentasContables usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContSubSubCuentasContables where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SContSubSubCuentasContablesID = dr("SContSubSubCuentasContablesID")
				m_objSContSubCuentasContablesID = IIf(IsDBNull(dr("objSContSubCuentasContablesID")), Nothing, dr("objSContSubCuentasContablesID"))
				m_IDCuenta = IIf(IsDBNull(dr("IDCuenta")), Nothing, dr("IDCuenta"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_Naturaleza = IIf(IsDBNull(dr("Naturaleza")), Nothing, dr("Naturaleza"))
				m_AceptaDatos = IIf(IsDBNull(dr("AceptaDatos")), Nothing, dr("AceptaDatos"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
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
    ''' Trae de la base de datos un conjunto de objetos SContSubSubCuentasContables en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SContSubSubCuentasContables"

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
			ds.Tables(0).TableName = "SContSubSubCuentasContables"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContSubSubCuentasContables en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SContSubSubCuentasContables"

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
			ds.Tables(0).TableName = "SContSubSubCuentasContables"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContSubSubCuentasContables en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SContSubSubCuentasContables"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SContSubSubCuentasContables.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SContSubSubCuentasContables("
		sCommand &= "objSContSubCuentasContablesID,"
		sCommand &= "IDCuenta,"
		sCommand &= "Descripcion,"
		sCommand &= "Naturaleza,"
		sCommand &= "AceptaDatos,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Activo) values ("		
		sCommand &= "@objSContSubCuentasContablesID,"
		sCommand &= "@IDCuenta,"
		sCommand &= "@Descripcion,"
		sCommand &= "@Naturaleza,"
		sCommand &= "@AceptaDatos,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Activo)"		
	
		sCommand &= " select "
		sCommand &= "@SContSubSubCuentasContablesID = SContSubSubCuentasContablesID from SContSubSubCuentasContables where "		
		sCommand &= "SContSubSubCuentasContablesID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SContSubSubCuentasContablesID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSContSubCuentasContablesID", SqlDbType.Int)		
		If IsDBNull(m_objSContSubCuentasContablesID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSContSubCuentasContablesID
        End If
		arParams(2) = New SqlParameter("@IDCuenta", SqlDbType.VarChar)		
		If IsDBNull(m_IDCuenta) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_IDCuenta
        End If
		arParams(3) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Descripcion
        End If
		arParams(4) = New SqlParameter("@Naturaleza", SqlDbType.VarChar)		
		If IsDBNull(m_Naturaleza) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Naturaleza
        End If
		arParams(5) = New SqlParameter("@AceptaDatos", SqlDbType.Bit)		
		If IsDBNull(m_AceptaDatos) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_AceptaDatos
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Activo
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SContSubSubCuentasContablesID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SContSubSubCuentasContables en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SContSubSubCuentasContables set "		
		sCommand &= "objSContSubCuentasContablesID = @objSContSubCuentasContablesID,"
		sCommand &= "IDCuenta = @IDCuenta,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "Naturaleza = @Naturaleza,"
		sCommand &= "AceptaDatos = @AceptaDatos,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Activo = @Activo"		
		sCommand &= " where "	
		sCommand &= "SContSubSubCuentasContablesID = @SContSubSubCuentasContablesID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SContSubSubCuentasContablesID", SqlDbType.Int)		
		If IsDBNull(m_SContSubSubCuentasContablesID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SContSubSubCuentasContablesID
        End If
		arParams(1) = New SqlParameter("@objSContSubCuentasContablesID", SqlDbType.Int)		
		If IsDBNull(m_objSContSubCuentasContablesID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSContSubCuentasContablesID
        End If
		arParams(2) = New SqlParameter("@IDCuenta", SqlDbType.VarChar)		
		If IsDBNull(m_IDCuenta) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_IDCuenta
        End If
		arParams(3) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Descripcion
        End If
		arParams(4) = New SqlParameter("@Naturaleza", SqlDbType.VarChar)		
		If IsDBNull(m_Naturaleza) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Naturaleza
        End If
		arParams(5) = New SqlParameter("@AceptaDatos", SqlDbType.Bit)		
		If IsDBNull(m_AceptaDatos) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_AceptaDatos
        End If
		arParams(6) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaCreacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaModificacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Activo
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
    ''' Borra un objeto SContSubSubCuentasContables de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContSubSubCuentasContables where " & " SContSubSubCuentasContablesID = " & m_SContSubSubCuentasContablesID
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
    ''' Borra un objeto SContSubSubCuentasContables de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SContSubSubCuentasContablesID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContSubSubCuentasContables where " & " SContSubSubCuentasContablesID = " & p_SContSubSubCuentasContablesID
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
    ''' Borra objetos SContSubSubCuentasContables de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContSubSubCuentasContables where " & pWhere
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
