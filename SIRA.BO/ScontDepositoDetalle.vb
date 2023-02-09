Imports DAL
Imports System.Data.SqlClient

Partial Public Class ScontDepositoDetalle		

#Region " Variables Miembro " 
	Protected m_ScontDepositoDetalleID As Integer 
	Protected m_objDepositoID As Nullable(Of Integer) 
	Protected m_objCuentaContableID As Nullable(Of Integer) 
	Protected m_Banco As String = Nothing 
	Protected m_Voucher As String = Nothing 
	Protected m_Monto As Nullable(Of Decimal) 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScontDepositoDetalleID() As Integer
        Get
            Return (m_ScontDepositoDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScontDepositoDetalleID = Value
		End Set
    End Property
	
	Public Property objDepositoID() As Nullable(Of Integer)
        Get
            Return (m_objDepositoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objDepositoID = Value
		End Set
    End Property
	
	Public Property objCuentaContableID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaContableID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaContableID = Value
		End Set
    End Property
	
	Public Property Banco() As String
        Get
            Return (m_Banco)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Banco", Value.ToString(), "Valor inv?lido para ScontDepositoDetalle.Banco. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Banco = Value
		End Set
    End Property
	
	Public Property Voucher() As String
        Get
            Return (m_Voucher)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Voucher", Value.ToString(), "Valor inv?lido para ScontDepositoDetalle.Voucher. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Voucher = Value
		End Set
    End Property
	
	Public Property Monto() As Nullable(Of Decimal)
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Monto = Value
		End Set
    End Property
	
	Public Property objMonedaID() As Nullable(Of Integer)
        Get
            Return (m_objMonedaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objMonedaID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScontDepositoDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScontDepositoDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Banco"
				Return	50
			Case "Voucher"
				Return	50
			Case "Monto"
				Return	18
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
			Case "Monto"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla ScontDepositoDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScontDepositoDetalle </param>    
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
			cmdDelete.Parameters.Add("@ScontDepositoDetalleID", SqlDbType.Int, 4, "ScontDepositoDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  ScontDepositoDetalle WHERE ScontDepositoDetalleID= @ScontDepositoDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objDepositoID", SqlDbType.Int, 4, "objDepositoID")
			cmdInsert.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdInsert.Parameters.Add("@Banco", SqlDbType.VarChar, 50, "Banco")
			cmdInsert.Parameters.Add("@Voucher", SqlDbType.VarChar, 50, "Voucher")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScontDepositoDetalle ( objDepositoID, objCuentaContableID, Banco, Voucher, Monto, objMonedaID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objDepositoID, @objCuentaContableID, @Banco, @Voucher, @Monto, @objMonedaID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objDepositoID", SqlDbType.Int, 4, "objDepositoID")
			cmdUpdate.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdUpdate.Parameters.Add("@Banco", SqlDbType.VarChar, 50, "Banco")
			cmdUpdate.Parameters.Add("@Voucher", SqlDbType.VarChar, 50, "Voucher")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScontDepositoDetalleID", SqlDbType.Int, 4, "ScontDepositoDetalleID")
			cmdUpdate.CommandText = "UPDATE ScontDepositoDetalle SET objDepositoID=@objDepositoID, objCuentaContableID=@objCuentaContableID, Banco=@Banco, Voucher=@Voucher, Monto=@Monto, objMonedaID=@objMonedaID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScontDepositoDetalleID= @wScontDepositoDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScontDepositoDetalle")
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
    ''' Devuelve de la base de datos un objeto ScontDepositoDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScontDepositoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontDepositoDetalle where " & " ScontDepositoDetalleID = " & p_ScontDepositoDetalleID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ScontDepositoDetalleID = dr("ScontDepositoDetalleID")
				m_objDepositoID = IIf(IsDBNull(dr("objDepositoID")), Nothing, dr("objDepositoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_Banco = IIf(IsDBNull(dr("Banco")), Nothing, dr("Banco"))
				m_Voucher = IIf(IsDBNull(dr("Voucher")), Nothing, dr("Voucher"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
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
    ''' Devuelve de la base de datos un objeto ScontDepositoDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontDepositoDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ScontDepositoDetalleID = dr("ScontDepositoDetalleID")
				m_objDepositoID = IIf(IsDBNull(dr("objDepositoID")), Nothing, dr("objDepositoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_Banco = IIf(IsDBNull(dr("Banco")), Nothing, dr("Banco"))
				m_Voucher = IIf(IsDBNull(dr("Voucher")), Nothing, dr("Voucher"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
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
    ''' Trae de la base de datos un conjunto de objetos ScontDepositoDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScontDepositoDetalle"

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
			ds.Tables(0).TableName = "ScontDepositoDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontDepositoDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScontDepositoDetalle"

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
			ds.Tables(0).TableName = "ScontDepositoDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontDepositoDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScontDepositoDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScontDepositoDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScontDepositoDetalle("
		sCommand &= "objDepositoID,"
		sCommand &= "objCuentaContableID,"
		sCommand &= "Banco,"
		sCommand &= "Voucher,"
		sCommand &= "Monto,"
		sCommand &= "objMonedaID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objDepositoID,"
		sCommand &= "@objCuentaContableID,"
		sCommand &= "@Banco,"
		sCommand &= "@Voucher,"
		sCommand &= "@Monto,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScontDepositoDetalleID = ScontDepositoDetalleID from ScontDepositoDetalle where "		
		sCommand &= "ScontDepositoDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontDepositoDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objDepositoID", SqlDbType.Int)		
		If IsDBNull(m_objDepositoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objDepositoID
        End If
		arParams(2) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaContableID
        End If
		arParams(3) = New SqlParameter("@Banco", SqlDbType.VarChar)		
		If IsDBNull(m_Banco) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Banco
        End If
		arParams(4) = New SqlParameter("@Voucher", SqlDbType.VarChar)		
		If IsDBNull(m_Voucher) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Voucher
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ScontDepositoDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScontDepositoDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScontDepositoDetalle set "		
		sCommand &= "objDepositoID = @objDepositoID,"
		sCommand &= "objCuentaContableID = @objCuentaContableID,"
		sCommand &= "Banco = @Banco,"
		sCommand &= "Voucher = @Voucher,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScontDepositoDetalleID = @ScontDepositoDetalleID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontDepositoDetalleID", SqlDbType.Int)		
		If IsDBNull(m_ScontDepositoDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScontDepositoDetalleID
        End If
		arParams(1) = New SqlParameter("@objDepositoID", SqlDbType.Int)		
		If IsDBNull(m_objDepositoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objDepositoID
        End If
		arParams(2) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaContableID
        End If
		arParams(3) = New SqlParameter("@Banco", SqlDbType.VarChar)		
		If IsDBNull(m_Banco) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Banco
        End If
		arParams(4) = New SqlParameter("@Voucher", SqlDbType.VarChar)		
		If IsDBNull(m_Voucher) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Voucher
        End If
		arParams(5) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Monto
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioCreacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioModificacion
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
    ''' Borra un objeto ScontDepositoDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontDepositoDetalle where " & " ScontDepositoDetalleID = " & m_ScontDepositoDetalleID
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
    ''' Borra un objeto ScontDepositoDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScontDepositoDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontDepositoDetalle where " & " ScontDepositoDetalleID = " & p_ScontDepositoDetalleID
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
    ''' Borra objetos ScontDepositoDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontDepositoDetalle where " & pWhere
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
