Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccArqueoCajaCH		

#Region " Variables Miembro " 
	Protected m_ArqueoCHID As Integer 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_MontoInicial As Nullable(Of Decimal) 
	Protected m_Entrada As Nullable(Of Decimal) 
	Protected m_Salida As Nullable(Of Decimal) 
	Protected m_Faltante As Nullable(Of Decimal) 
	Protected m_AprobadoPor As String = Nothing 
	Protected m_objCajaID As Nullable(Of Integer) 
	Protected m_objCajeroID As Nullable(Of Integer) 
	Protected m_objConceptoID As Nullable(Of Integer) 
	Protected m_Cerrado As Nullable(Of Boolean) 
	Protected m_Observaciones As Byte() 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ArqueoCHID() As Integer
        Get
            Return (m_ArqueoCHID)
        End Get
		Set(ByVal Value As Integer)					
			m_ArqueoCHID = Value
		End Set
    End Property
	
	Public Property Fecha() As Nullable(Of Date)
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fecha = Value
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
	
	Public Property MontoInicial() As Nullable(Of Decimal)
        Get
            Return (m_MontoInicial)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoInicial = Value
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
	
	Public Property Faltante() As Nullable(Of Decimal)
        Get
            Return (m_Faltante)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Faltante = Value
		End Set
    End Property
	
	Public Property AprobadoPor() As String
        Get
            Return (m_AprobadoPor)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("AprobadoPor", Value.ToString(), "Valor inv?lido para SccArqueoCajaCH.AprobadoPor. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_AprobadoPor = Value
		End Set
    End Property
	
	Public Property objCajaID() As Nullable(Of Integer)
        Get
            Return (m_objCajaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaID = Value
		End Set
    End Property
	
	Public Property objCajeroID() As Nullable(Of Integer)
        Get
            Return (m_objCajeroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroID = Value
		End Set
    End Property
	
	Public Property objConceptoID() As Nullable(Of Integer)
        Get
            Return (m_objConceptoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objConceptoID = Value
		End Set
    End Property
	
	Public Property Cerrado() As Nullable(Of Boolean)
        Get
            Return (m_Cerrado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Cerrado = Value
		End Set
    End Property
	
	Public Property Observaciones() As Byte()
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As Byte())					
			m_Observaciones = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccArqueoCajaCH.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccArqueoCajaCH.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MontoInicial"
				Return	18
			Case "Entrada"
				Return	18
			Case "Salida"
				Return	18
			Case "Faltante"
				Return	18
			Case "AprobadoPor"
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
			Case "MontoInicial"
				Return	2
			Case "Entrada"
				Return	2
			Case "Salida"
				Return	2
			Case "Faltante"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccArqueoCajaCH en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccArqueoCajaCH </param>    
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
			cmdDelete.Parameters.Add("@ArqueoCHID", SqlDbType.Int, 4, "ArqueoCHID" )
			cmdDelete.CommandText = "DELETE FROM  SccArqueoCajaCH WHERE ArqueoCHID= @ArqueoCHID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@MontoInicial", SqlDbType.Decimal, 9, "MontoInicial")
			cmdInsert.Parameters.Add("@Entrada", SqlDbType.Decimal, 9, "Entrada")
			cmdInsert.Parameters.Add("@Salida", SqlDbType.Decimal, 9, "Salida")
			cmdInsert.Parameters.Add("@Faltante", SqlDbType.Decimal, 9, "Faltante")
			cmdInsert.Parameters.Add("@AprobadoPor", SqlDbType.VarChar, 50, "AprobadoPor")
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdInsert.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdInsert.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.Binary, -1, "Observaciones")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SccArqueoCajaCH ( Fecha, objMonedaID, MontoInicial, Entrada, Salida, Faltante, AprobadoPor, objCajaID, objCajeroID, objConceptoID, Cerrado, Observaciones, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @Fecha, @objMonedaID, @MontoInicial, @Entrada, @Salida, @Faltante, @AprobadoPor, @objCajaID, @objCajeroID, @objConceptoID, @Cerrado, @Observaciones, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@MontoInicial", SqlDbType.Decimal, 9, "MontoInicial")
			cmdUpdate.Parameters.Add("@Entrada", SqlDbType.Decimal, 9, "Entrada")
			cmdUpdate.Parameters.Add("@Salida", SqlDbType.Decimal, 9, "Salida")
			cmdUpdate.Parameters.Add("@Faltante", SqlDbType.Decimal, 9, "Faltante")
			cmdUpdate.Parameters.Add("@AprobadoPor", SqlDbType.VarChar, 50, "AprobadoPor")
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdUpdate.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdUpdate.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.Binary, -1, "Observaciones")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wArqueoCHID", SqlDbType.Int, 4, "ArqueoCHID")
			cmdUpdate.CommandText = "UPDATE SccArqueoCajaCH SET Fecha=@Fecha, objMonedaID=@objMonedaID, MontoInicial=@MontoInicial, Entrada=@Entrada, Salida=@Salida, Faltante=@Faltante, AprobadoPor=@AprobadoPor, objCajaID=@objCajaID, objCajeroID=@objCajeroID, objConceptoID=@objConceptoID, Cerrado=@Cerrado, Observaciones=@Observaciones, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ArqueoCHID= @wArqueoCHID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccArqueoCajaCH")
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
    ''' Devuelve de la base de datos un objeto SccArqueoCajaCH
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ArqueoCHID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCajaCH where " & " ArqueoCHID = " & p_ArqueoCHID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ArqueoCHID = dr("ArqueoCHID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_MontoInicial = IIf(IsDBNull(dr("MontoInicial")), Nothing, dr("MontoInicial"))
				m_Entrada = IIf(IsDBNull(dr("Entrada")), Nothing, dr("Entrada"))
				m_Salida = IIf(IsDBNull(dr("Salida")), Nothing, dr("Salida"))
				m_Faltante = IIf(IsDBNull(dr("Faltante")), Nothing, dr("Faltante"))
				m_AprobadoPor = IIf(IsDBNull(dr("AprobadoPor")), Nothing, dr("AprobadoPor"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
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
    ''' Devuelve de la base de datos un objeto SccArqueoCajaCH usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoCajaCH where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ArqueoCHID = dr("ArqueoCHID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_MontoInicial = IIf(IsDBNull(dr("MontoInicial")), Nothing, dr("MontoInicial"))
				m_Entrada = IIf(IsDBNull(dr("Entrada")), Nothing, dr("Entrada"))
				m_Salida = IIf(IsDBNull(dr("Salida")), Nothing, dr("Salida"))
				m_Faltante = IIf(IsDBNull(dr("Faltante")), Nothing, dr("Faltante"))
				m_AprobadoPor = IIf(IsDBNull(dr("AprobadoPor")), Nothing, dr("AprobadoPor"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
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
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaCH en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaCH"

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
			ds.Tables(0).TableName = "SccArqueoCajaCH"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaCH en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaCH"

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
			ds.Tables(0).TableName = "SccArqueoCajaCH"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoCajaCH en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccArqueoCajaCH"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccArqueoCajaCH.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccArqueoCajaCH("
		sCommand &= "Fecha,"
		sCommand &= "objMonedaID,"
		sCommand &= "MontoInicial,"
		sCommand &= "Entrada,"
		sCommand &= "Salida,"
		sCommand &= "Faltante,"
		sCommand &= "AprobadoPor,"
		sCommand &= "objCajaID,"
		sCommand &= "objCajeroID,"
		sCommand &= "objConceptoID,"
		sCommand &= "Cerrado,"
		sCommand &= "Observaciones,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@Fecha,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@MontoInicial,"
		sCommand &= "@Entrada,"
		sCommand &= "@Salida,"
		sCommand &= "@Faltante,"
		sCommand &= "@AprobadoPor,"
		sCommand &= "@objCajaID,"
		sCommand &= "@objCajeroID,"
		sCommand &= "@objConceptoID,"
		sCommand &= "@Cerrado,"
		sCommand &= "@Observaciones,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ArqueoCHID = ArqueoCHID from SccArqueoCajaCH where "		
		sCommand &= "ArqueoCHID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoCHID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMonedaID
        End If
		arParams(3) = New SqlParameter("@MontoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_MontoInicial) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_MontoInicial
        End If
		arParams(4) = New SqlParameter("@Entrada", SqlDbType.Decimal)		
		If IsDBNull(m_Entrada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Entrada
        End If
		arParams(5) = New SqlParameter("@Salida", SqlDbType.Decimal)		
		If IsDBNull(m_Salida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Salida
        End If
		arParams(6) = New SqlParameter("@Faltante", SqlDbType.Decimal)		
		If IsDBNull(m_Faltante) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Faltante
        End If
		arParams(7) = New SqlParameter("@AprobadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AprobadoPor) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_AprobadoPor
        End If
		arParams(8) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCajaID
        End If
		arParams(9) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objCajeroID
        End If
		arParams(10) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objConceptoID
        End If
		arParams(11) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Cerrado
        End If
		arParams(12) = New SqlParameter("@Observaciones", SqlDbType.Binary)		
		If IsDBNull(m_Observaciones) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Observaciones
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioCreacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ArqueoCHID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccArqueoCajaCH en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccArqueoCajaCH set "		
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "MontoInicial = @MontoInicial,"
		sCommand &= "Entrada = @Entrada,"
		sCommand &= "Salida = @Salida,"
		sCommand &= "Faltante = @Faltante,"
		sCommand &= "AprobadoPor = @AprobadoPor,"
		sCommand &= "objCajaID = @objCajaID,"
		sCommand &= "objCajeroID = @objCajeroID,"
		sCommand &= "objConceptoID = @objConceptoID,"
		sCommand &= "Cerrado = @Cerrado,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ArqueoCHID = @ArqueoCHID"					
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@ArqueoCHID", SqlDbType.Int)		
		If IsDBNull(m_ArqueoCHID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ArqueoCHID
        End If
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objMonedaID
        End If
		arParams(3) = New SqlParameter("@MontoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_MontoInicial) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_MontoInicial
        End If
		arParams(4) = New SqlParameter("@Entrada", SqlDbType.Decimal)		
		If IsDBNull(m_Entrada) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Entrada
        End If
		arParams(5) = New SqlParameter("@Salida", SqlDbType.Decimal)		
		If IsDBNull(m_Salida) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Salida
        End If
		arParams(6) = New SqlParameter("@Faltante", SqlDbType.Decimal)		
		If IsDBNull(m_Faltante) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Faltante
        End If
		arParams(7) = New SqlParameter("@AprobadoPor", SqlDbType.VarChar)		
		If IsDBNull(m_AprobadoPor) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_AprobadoPor
        End If
		arParams(8) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objCajaID
        End If
		arParams(9) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objCajeroID
        End If
		arParams(10) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objConceptoID
        End If
		arParams(11) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Cerrado
        End If
		arParams(12) = New SqlParameter("@Observaciones", SqlDbType.Binary)		
		If IsDBNull(m_Observaciones) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Observaciones
        End If
		arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
		arParams(14) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioCreacion
        End If
		arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
        End If
		arParams(16) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_UsuarioModificacion
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
    ''' Borra un objeto SccArqueoCajaCH de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaCH where " & " ArqueoCHID = " & m_ArqueoCHID
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
    ''' Borra un objeto SccArqueoCajaCH de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ArqueoCHID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaCH where " & " ArqueoCHID = " & p_ArqueoCHID
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
    ''' Borra objetos SccArqueoCajaCH de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoCajaCH where " & pWhere
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
