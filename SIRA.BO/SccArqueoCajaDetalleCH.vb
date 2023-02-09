Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccArqueoCajaDetalleCH		

#Region " Variables Miembro " 
	Protected m_ArqueoDetalleCHID As Integer 
	Protected m_objArqueoCHID As Nullable(Of Integer) 
	Protected m_Moneda As String = Nothing 
	Protected m_Entrada As Nullable(Of Decimal) 
	Protected m_Salida As Nullable(Of Decimal) 
	Protected m_Concepto As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ArqueoDetalleCHID() As Integer
        Get
            Return (m_ArqueoDetalleCHID)
        End Get
		Set(ByVal Value As Integer)					
			m_ArqueoDetalleCHID = Value
		End Set
    End Property
	
	Public Property objArqueoCHID() As Nullable(Of Integer)
        Get
            Return (m_objArqueoCHID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objArqueoCHID = Value
		End Set
    End Property
	
	Public Property Moneda() As String
        Get
            Return (m_Moneda)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Moneda", Value.ToString(), "Valor inv?lido para SccArqueoCajaDetalleCH.Moneda. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Moneda = Value
		End Set
    End Property
	
	Public Property Entrada() As Nullable(Of Decimal)
        Get
            Return (m_Entrada)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Entrada = Value
		End Set
    End Property
	
	Public Property Salida() As Nullable(Of Decimal)
        Get
            Return (m_Salida)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Salida = Value
		End Set
    End Property
	
	Public Property Concepto() As String
        Get
            Return (m_Concepto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Concepto", Value.ToString(), "Valor inv?lido para SccArqueoCajaDetalleCH.Concepto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Concepto = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccArqueoCajaDetalleCH.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccArqueoCajaDetalleCH.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Moneda"
				Return	100
			Case "Entrada"
				Return	18
			Case "Salida"
				Return	18
			Case "Concepto"
				Return	100
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
			Case "Entrada"
				Return	2
			Case "Salida"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccArqueoCajaDetalleCH en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccArqueoCajaDetalleCH </param>    
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
			cmdDelete.Parameters.Add("@ArqueoDetalleCHID", SqlDbType.Int, 4, "ArqueoDetalleCHID" )
			cmdDelete.CommandText = "DELETE FROM  SccArqueoCajaDetalleCH WHERE ArqueoDetalleCHID= @ArqueoDetalleCHID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objArqueoCHID", SqlDbType.Int, 4, "objArqueoCHID")
			cmdInsert.Parameters.Add("@Moneda", SqlDbType.VarChar, 100, "Moneda")
			cmdInsert.Parameters.Add("@Entrada", SqlDbType.Decimal, 9, "Entrada")
			cmdInsert.Parameters.Add("@Salida", SqlDbType.Decimal, 9, "Salida")
			cmdInsert.Parameters.Add("@Concepto", SqlDbType.VarChar, 100, "Concepto")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SccArqueoCajaDetalleCH ( objArqueoCHID, Moneda, Entrada, Salida, Concepto, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objArqueoCHID, @Moneda, @Entrada, @Salida, @Concepto, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objArqueoCHID", SqlDbType.Int, 4, "objArqueoCHID")
			cmdUpdate.Parameters.Add("@Moneda", SqlDbType.VarChar, 100, "Moneda")
			cmdUpdate.Parameters.Add("@Entrada", SqlDbType.Decimal, 9, "Entrada")
			cmdUpdate.Parameters.Add("@Salida", SqlDbType.Decimal, 9, "Salida")
			cmdUpdate.Parameters.Add("@Concepto", SqlDbType.VarChar, 100, "Concepto")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wArqueoDetalleCHID", SqlDbType.Int, 4, "ArqueoDetalleCHID")
			cmdUpdate.CommandText = "UPDATE SccArqueoCajaDetalleCH SET objArqueoCHID=@objArqueoCHID, Moneda=@Moneda, Entrada=@Entrada, Salida=@Salida, Concepto=@Concepto, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ArqueoDetalleCHID= @wArqueoDetalleCHID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccArqueoCajaDetalleCH")
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
    ''' Devuelve de la base de datos un objeto SccArqueoCajaDetalleCH
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ArqueoDetalleCHID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCajaDetalleCH where " & " ArqueoDetalleCHID = " & p_ArqueoDetalleCHID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ArqueoDetalleCHID = dr("ArqueoDetalleCHID")
				m_objArqueoCHID = IIf(IsDBNull(dr("objArqueoCHID")), Nothing, dr("objArqueoCHID"))
				m_Moneda = IIf(IsDBNull(dr("Moneda")), Nothing, dr("Moneda"))
				m_Entrada = IIf(IsDBNull(dr("Entrada")), Nothing, dr("Entrada"))
				m_Salida = IIf(IsDBNull(dr("Salida")), Nothing, dr("Salida"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
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
    ''' Devuelve de la base de datos un objeto SccArqueoCajaDetalleCH usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCajaDetalleCH where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ArqueoDetalleCHID = dr("ArqueoDetalleCHID")
				m_objArqueoCHID = IIf(IsDBNull(dr("objArqueoCHID")), Nothing, dr("objArqueoCHID"))
				m_Moneda = IIf(IsDBNull(dr("Moneda")), Nothing, dr("Moneda"))
				m_Entrada = IIf(IsDBNull(dr("Entrada")), Nothing, dr("Entrada"))
				m_Salida = IIf(IsDBNull(dr("Salida")), Nothing, dr("Salida"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
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
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaDetalleCH en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaDetalleCH"

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
			ds.Tables(0).TableName = "SccArqueoCajaDetalleCH"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaDetalleCH en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaDetalleCH"

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
			ds.Tables(0).TableName = "SccArqueoCajaDetalleCH"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaDetalleCH en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaDetalleCH"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccArqueoCajaDetalleCH.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccArqueoCajaDetalleCH("
		sCommand &= "objArqueoCHID,"
		sCommand &= "Moneda,"
		sCommand &= "Entrada,"
		sCommand &= "Salida,"
		sCommand &= "Concepto,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objArqueoCHID,"
		sCommand &= "@Moneda,"
		sCommand &= "@Entrada,"
		sCommand &= "@Salida,"
		sCommand &= "@Concepto,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ArqueoDetalleCHID = ArqueoDetalleCHID from SccArqueoCajaDetalleCH where "		
		sCommand &= "ArqueoDetalleCHID = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoDetalleCHID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objArqueoCHID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoCHID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoCHID
        End If
		arParams(2) = New SqlParameter("@Moneda", SqlDbType.VarChar)		
		If IsDBNull(m_Moneda) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Moneda
        End If
		arParams(3) = New SqlParameter("@Entrada", SqlDbType.Decimal)		
		If IsDBNull(m_Entrada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Entrada
        End If
		arParams(4) = New SqlParameter("@Salida", SqlDbType.Decimal)		
		If IsDBNull(m_Salida) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Salida
        End If
		arParams(5) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Concepto
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
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ArqueoDetalleCHID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccArqueoCajaDetalleCH en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccArqueoCajaDetalleCH set "		
		sCommand &= "objArqueoCHID = @objArqueoCHID,"
		sCommand &= "Moneda = @Moneda,"
		sCommand &= "Entrada = @Entrada,"
		sCommand &= "Salida = @Salida,"
		sCommand &= "Concepto = @Concepto,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ArqueoDetalleCHID = @ArqueoDetalleCHID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoDetalleCHID", SqlDbType.Int)		
		If IsDBNull(m_ArqueoDetalleCHID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ArqueoDetalleCHID
        End If
		arParams(1) = New SqlParameter("@objArqueoCHID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoCHID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoCHID
        End If
		arParams(2) = New SqlParameter("@Moneda", SqlDbType.VarChar)		
		If IsDBNull(m_Moneda) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Moneda
        End If
		arParams(3) = New SqlParameter("@Entrada", SqlDbType.Decimal)		
		If IsDBNull(m_Entrada) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Entrada
        End If
		arParams(4) = New SqlParameter("@Salida", SqlDbType.Decimal)		
		If IsDBNull(m_Salida) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Salida
        End If
		arParams(5) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Concepto
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
    ''' Borra un objeto SccArqueoCajaDetalleCH de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaDetalleCH where " & " ArqueoDetalleCHID = " & m_ArqueoDetalleCHID
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
    ''' Borra un objeto SccArqueoCajaDetalleCH de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ArqueoDetalleCHID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaDetalleCH where " & " ArqueoDetalleCHID = " & p_ArqueoDetalleCHID
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
    ''' Borra objetos SccArqueoCajaDetalleCH de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaDetalleCH where " & pWhere
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
