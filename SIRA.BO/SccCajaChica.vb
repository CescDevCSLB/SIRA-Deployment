Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccCajaChica		

#Region " Variables Miembro " 
	Protected m_SccCajaChicaID As Integer 
	Protected m_objCajeraID As Nullable(Of Integer) 
	Protected m_Codigo As String = Nothing 
	Protected m_FechaApertura As Nullable(Of Date) 
	Protected m_Disponible As Nullable(Of Decimal) 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCierreID As Nullable(Of Date) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SccCajaChicaID() As Integer
        Get
            Return (m_SccCajaChicaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccCajaChicaID = Value
		End Set
    End Property
	
	Public Property objCajeraID() As Nullable(Of Integer)
        Get
            Return (m_objCajeraID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeraID = Value
		End Set
    End Property
	
	Public Property Codigo() As String
        Get
            Return (m_Codigo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Codigo", Value.ToString(), "Valor inv?lido para SccCajaChica.Codigo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Codigo = Value
		End Set
    End Property
	
	Public Property FechaApertura() As Nullable(Of Date)
        Get
            Return (m_FechaApertura)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaApertura = Value
		End Set
    End Property
	
	Public Property Disponible() As Nullable(Of Decimal)
        Get
            Return (m_Disponible)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Disponible = Value
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
	
	Public Property Activa() As Nullable(Of Boolean)
        Get
            Return (m_Activa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activa = Value
		End Set
    End Property
	
	Public Property FechaCierreID() As Nullable(Of Date)
        Get
            Return (m_FechaCierreID)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCierreID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCajaChica.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCajaChica.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Codigo"
				Return	50
			Case "Disponible"
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
			Case "Disponible"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCajaChica en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCajaChica </param>    
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
			cmdDelete.Parameters.Add("@SccCajaChicaID", SqlDbType.Int, 4, "SccCajaChicaID" )
			cmdDelete.CommandText = "DELETE FROM  SccCajaChica WHERE SccCajaChicaID= @SccCajaChicaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCajeraID", SqlDbType.Int, 4, "objCajeraID")
			cmdInsert.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdInsert.Parameters.Add("@FechaApertura", SqlDbType.DateTime, 8, "FechaApertura")
			cmdInsert.Parameters.Add("@Disponible", SqlDbType.Decimal, 9, "Disponible")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCierreID", SqlDbType.DateTime, 8, "FechaCierreID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SccCajaChica ( objCajeraID, Codigo, FechaApertura, Disponible, objMonedaID, Activa, FechaCierreID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objCajeraID, @Codigo, @FechaApertura, @Disponible, @objMonedaID, @Activa, @FechaCierreID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCajeraID", SqlDbType.Int, 4, "objCajeraID")
			cmdUpdate.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo")
			cmdUpdate.Parameters.Add("@FechaApertura", SqlDbType.DateTime, 8, "FechaApertura")
			cmdUpdate.Parameters.Add("@Disponible", SqlDbType.Decimal, 9, "Disponible")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCierreID", SqlDbType.DateTime, 8, "FechaCierreID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSccCajaChicaID", SqlDbType.Int, 4, "SccCajaChicaID")
			cmdUpdate.CommandText = "UPDATE SccCajaChica SET objCajeraID=@objCajeraID, Codigo=@Codigo, FechaApertura=@FechaApertura, Disponible=@Disponible, objMonedaID=@objMonedaID, Activa=@Activa, FechaCierreID=@FechaCierreID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SccCajaChicaID= @wSccCajaChicaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCajaChica")
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
    ''' Devuelve de la base de datos un objeto SccCajaChica
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCajaChicaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCajaChica where " & " SccCajaChicaID = " & p_SccCajaChicaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccCajaChicaID = dr("SccCajaChicaID")
				m_objCajeraID = IIf(IsDBNull(dr("objCajeraID")), Nothing, dr("objCajeraID"))
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))
				m_FechaApertura = IIf(IsDBNull(dr("FechaApertura")), Nothing, dr("FechaApertura"))
				m_Disponible = IIf(IsDBNull(dr("Disponible")), Nothing, dr("Disponible"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCierreID = IIf(IsDBNull(dr("FechaCierreID")), Nothing, dr("FechaCierreID"))
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
    ''' Devuelve de la base de datos un objeto SccCajaChica usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCajaChica where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccCajaChicaID = dr("SccCajaChicaID")
				m_objCajeraID = IIf(IsDBNull(dr("objCajeraID")), Nothing, dr("objCajeraID"))
				m_Codigo = IIf(IsDBNull(dr("Codigo")), Nothing, dr("Codigo"))
				m_FechaApertura = IIf(IsDBNull(dr("FechaApertura")), Nothing, dr("FechaApertura"))
				m_Disponible = IIf(IsDBNull(dr("Disponible")), Nothing, dr("Disponible"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCierreID = IIf(IsDBNull(dr("FechaCierreID")), Nothing, dr("FechaCierreID"))
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
    ''' Trae de la base de datos un conjunto de objetos SccCajaChica en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCajaChica"

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
			ds.Tables(0).TableName = "SccCajaChica"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCajaChica en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCajaChica"

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
			ds.Tables(0).TableName = "SccCajaChica"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCajaChica en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCajaChica"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCajaChica.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCajaChica("
		sCommand &= "objCajeraID,"
		sCommand &= "Codigo,"
		sCommand &= "FechaApertura,"
		sCommand &= "Disponible,"
		sCommand &= "objMonedaID,"
		sCommand &= "Activa,"
		sCommand &= "FechaCierreID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objCajeraID,"
		sCommand &= "@Codigo,"
		sCommand &= "@FechaApertura,"
		sCommand &= "@Disponible,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCierreID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccCajaChicaID = SccCajaChicaID from SccCajaChica where "		
		sCommand &= "SccCajaChicaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccCajaChicaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCajeraID", SqlDbType.Int)		
		If IsDBNull(m_objCajeraID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajeraID
        End If
		arParams(2) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Codigo
        End If
		arParams(3) = New SqlParameter("@FechaApertura", SqlDbType.DateTime)		
		If IsDBNull(m_FechaApertura) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaApertura
        End If
		arParams(4) = New SqlParameter("@Disponible", SqlDbType.Decimal)		
		If IsDBNull(m_Disponible) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Disponible
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activa
        End If
		arParams(7) = New SqlParameter("@FechaCierreID", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCierreID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCierreID
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccCajaChicaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCajaChica en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCajaChica set "		
		sCommand &= "objCajeraID = @objCajeraID,"
		sCommand &= "Codigo = @Codigo,"
		sCommand &= "FechaApertura = @FechaApertura,"
		sCommand &= "Disponible = @Disponible,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCierreID = @FechaCierreID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SccCajaChicaID = @SccCajaChicaID"					
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccCajaChicaID", SqlDbType.Int)		
		If IsDBNull(m_SccCajaChicaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCajaChicaID
        End If
		arParams(1) = New SqlParameter("@objCajeraID", SqlDbType.Int)		
		If IsDBNull(m_objCajeraID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajeraID
        End If
		arParams(2) = New SqlParameter("@Codigo", SqlDbType.VarChar)		
		If IsDBNull(m_Codigo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Codigo
        End If
		arParams(3) = New SqlParameter("@FechaApertura", SqlDbType.DateTime)		
		If IsDBNull(m_FechaApertura) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaApertura
        End If
		arParams(4) = New SqlParameter("@Disponible", SqlDbType.Decimal)		
		If IsDBNull(m_Disponible) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Disponible
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activa
        End If
		arParams(7) = New SqlParameter("@FechaCierreID", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCierreID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCierreID
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioCreacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SccCajaChica de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajaChica where " & " SccCajaChicaID = " & m_SccCajaChicaID
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
    ''' Borra un objeto SccCajaChica de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCajaChicaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajaChica where " & " SccCajaChicaID = " & p_SccCajaChicaID
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
    ''' Borra objetos SccCajaChica de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCajaChica where " & pWhere
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
