Imports DAL
Imports System.Data.SqlClient

Partial Public Class ScontComprobanteID		

#Region " Variables Miembro " 
	Protected m_ScontComprobanteID As Integer 
	Protected m_NumAsiento As String = Nothing 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_EsAjuste As Nullable(Of Boolean) 
	Protected m_Concepto As String = Nothing 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_objTipoAsientoID As Nullable(Of Integer) 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_Observaciones As String = Nothing 
	Protected m_ValorCordobas As Nullable(Of Decimal) 
	Protected m_ValorDolares As Nullable(Of Decimal) 
	Protected m_TasaCambio As Nullable(Of Decimal) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScontComprobanteID() As Integer
        Get
            Return (m_ScontComprobanteID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScontComprobanteID = Value
		End Set
    End Property
	
	Public Property NumAsiento() As String
        Get
            Return (m_NumAsiento)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("NumAsiento", Value.ToString(), "Valor inv?lido para ScontComprobanteID.NumAsiento. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_NumAsiento = Value
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
	
	Public Property EsAjuste() As Nullable(Of Boolean)
        Get
            Return (m_EsAjuste)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_EsAjuste = Value
		End Set
    End Property
	
	Public Property Concepto() As String
        Get
            Return (m_Concepto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Concepto", Value.ToString(), "Valor inv?lido para ScontComprobanteID.Concepto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Concepto = Value
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
	
	Public Property objTipoAsientoID() As Nullable(Of Integer)
        Get
            Return (m_objTipoAsientoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTipoAsientoID = Value
		End Set
    End Property
	
	Public Property objPeriodoID() As Nullable(Of Integer)
        Get
            Return (m_objPeriodoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPeriodoID = Value
		End Set
    End Property
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para ScontComprobanteID.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	
	Public Property ValorCordobas() As Nullable(Of Decimal)
        Get
            Return (m_ValorCordobas)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_ValorCordobas = Value
		End Set
    End Property
	
	Public Property ValorDolares() As Nullable(Of Decimal)
        Get
            Return (m_ValorDolares)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_ValorDolares = Value
		End Set
    End Property
	
	Public Property TasaCambio() As Nullable(Of Decimal)
        Get
            Return (m_TasaCambio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TasaCambio = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScontComprobanteID.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScontComprobanteID.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "NumAsiento"
				Return	50
			Case "Concepto"
				Return	2147483645
			Case "Observaciones"
				Return	2147483645
			Case "ValorCordobas"
				Return	18
			Case "ValorDolares"
				Return	18
			Case "TasaCambio"
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
			Case "ValorCordobas"
				Return	2
			Case "ValorDolares"
				Return	2
			Case "TasaCambio"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla ScontComprobanteID en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScontComprobanteID </param>    
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
			cmdDelete.Parameters.Add("@ScontComprobanteID", SqlDbType.Int, 4, "ScontComprobanteID" )
			cmdDelete.CommandText = "DELETE FROM  ScontComprobanteID WHERE ScontComprobanteID= @ScontComprobanteID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@NumAsiento", SqlDbType.VarChar, 50, "NumAsiento")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@EsAjuste", SqlDbType.Bit, 1, "EsAjuste")
			cmdInsert.Parameters.Add("@Concepto", SqlDbType.VarChar, -1, "Concepto")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@objTipoAsientoID", SqlDbType.Int, 4, "objTipoAsientoID")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, -1, "Observaciones")
			cmdInsert.Parameters.Add("@ValorCordobas", SqlDbType.Decimal, 9, "ValorCordobas")
			cmdInsert.Parameters.Add("@ValorDolares", SqlDbType.Decimal, 9, "ValorDolares")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScontComprobanteID ( NumAsiento, Fecha, EsAjuste, Concepto, objMonedaID, objTipoAsientoID, objPeriodoID, Observaciones, ValorCordobas, ValorDolares, TasaCambio, objEstadoID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @NumAsiento, @Fecha, @EsAjuste, @Concepto, @objMonedaID, @objTipoAsientoID, @objPeriodoID, @Observaciones, @ValorCordobas, @ValorDolares, @TasaCambio, @objEstadoID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@NumAsiento", SqlDbType.VarChar, 50, "NumAsiento")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@EsAjuste", SqlDbType.Bit, 1, "EsAjuste")
			cmdUpdate.Parameters.Add("@Concepto", SqlDbType.VarChar, -1, "Concepto")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@objTipoAsientoID", SqlDbType.Int, 4, "objTipoAsientoID")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, -1, "Observaciones")
			cmdUpdate.Parameters.Add("@ValorCordobas", SqlDbType.Decimal, 9, "ValorCordobas")
			cmdUpdate.Parameters.Add("@ValorDolares", SqlDbType.Decimal, 9, "ValorDolares")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScontComprobanteID", SqlDbType.Int, 4, "ScontComprobanteID")
			cmdUpdate.CommandText = "UPDATE ScontComprobanteID SET NumAsiento=@NumAsiento, Fecha=@Fecha, EsAjuste=@EsAjuste, Concepto=@Concepto, objMonedaID=@objMonedaID, objTipoAsientoID=@objTipoAsientoID, objPeriodoID=@objPeriodoID, Observaciones=@Observaciones, ValorCordobas=@ValorCordobas, ValorDolares=@ValorDolares, TasaCambio=@TasaCambio, objEstadoID=@objEstadoID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScontComprobanteID= @wScontComprobanteID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScontComprobanteID")
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
    ''' Devuelve de la base de datos un objeto ScontComprobanteID
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScontComprobanteID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontComprobanteID where " & " ScontComprobanteID = " & p_ScontComprobanteID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ScontComprobanteID = dr("ScontComprobanteID")
				m_NumAsiento = IIf(IsDBNull(dr("NumAsiento")), Nothing, dr("NumAsiento"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_EsAjuste = IIf(IsDBNull(dr("EsAjuste")), Nothing, dr("EsAjuste"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_objTipoAsientoID = IIf(IsDBNull(dr("objTipoAsientoID")), Nothing, dr("objTipoAsientoID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
				m_ValorCordobas = IIf(IsDBNull(dr("ValorCordobas")), Nothing, dr("ValorCordobas"))
				m_ValorDolares = IIf(IsDBNull(dr("ValorDolares")), Nothing, dr("ValorDolares"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
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
    ''' Devuelve de la base de datos un objeto ScontComprobanteID usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontComprobanteID where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ScontComprobanteID = dr("ScontComprobanteID")
				m_NumAsiento = IIf(IsDBNull(dr("NumAsiento")), Nothing, dr("NumAsiento"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_EsAjuste = IIf(IsDBNull(dr("EsAjuste")), Nothing, dr("EsAjuste"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_objTipoAsientoID = IIf(IsDBNull(dr("objTipoAsientoID")), Nothing, dr("objTipoAsientoID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
				m_ValorCordobas = IIf(IsDBNull(dr("ValorCordobas")), Nothing, dr("ValorCordobas"))
				m_ValorDolares = IIf(IsDBNull(dr("ValorDolares")), Nothing, dr("ValorDolares"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
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
    ''' Trae de la base de datos un conjunto de objetos ScontComprobanteID en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScontComprobanteID"

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
			ds.Tables(0).TableName = "ScontComprobanteID"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontComprobanteID en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScontComprobanteID"

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
			ds.Tables(0).TableName = "ScontComprobanteID"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontComprobanteID en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScontComprobanteID"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScontComprobanteID.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScontComprobanteID("
		sCommand &= "NumAsiento,"
		sCommand &= "Fecha,"
		sCommand &= "EsAjuste,"
		sCommand &= "Concepto,"
		sCommand &= "objMonedaID,"
		sCommand &= "objTipoAsientoID,"
		sCommand &= "objPeriodoID,"
		sCommand &= "Observaciones,"
		sCommand &= "ValorCordobas,"
		sCommand &= "ValorDolares,"
		sCommand &= "TasaCambio,"
		sCommand &= "objEstadoID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@NumAsiento,"
		sCommand &= "@Fecha,"
		sCommand &= "@EsAjuste,"
		sCommand &= "@Concepto,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@objTipoAsientoID,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@Observaciones,"
		sCommand &= "@ValorCordobas,"
		sCommand &= "@ValorDolares,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScontComprobanteID = ScontComprobanteID from ScontComprobanteID where "		
		sCommand &= "ScontComprobanteID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@ScontComprobanteID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@NumAsiento", SqlDbType.VarChar)		
		If IsDBNull(m_NumAsiento) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NumAsiento
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@EsAjuste", SqlDbType.Bit)		
		If IsDBNull(m_EsAjuste) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_EsAjuste
        End If
		arParams(4) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Concepto
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@objTipoAsientoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoAsientoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objTipoAsientoID
        End If
		arParams(7) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPeriodoID
        End If
		arParams(8) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Observaciones
        End If
		arParams(9) = New SqlParameter("@ValorCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_ValorCordobas) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ValorCordobas
        End If
		arParams(10) = New SqlParameter("@ValorDolares", SqlDbType.Decimal)		
		If IsDBNull(m_ValorDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ValorDolares
        End If
		arParams(11) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TasaCambio
        End If
		arParams(12) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objEstadoID
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
			
			m_ScontComprobanteID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScontComprobanteID en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScontComprobanteID set "		
		sCommand &= "NumAsiento = @NumAsiento,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "EsAjuste = @EsAjuste,"
		sCommand &= "Concepto = @Concepto,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "objTipoAsientoID = @objTipoAsientoID,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "Observaciones = @Observaciones,"
		sCommand &= "ValorCordobas = @ValorCordobas,"
		sCommand &= "ValorDolares = @ValorDolares,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScontComprobanteID = @ScontComprobanteID"					
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@ScontComprobanteID", SqlDbType.Int)		
		If IsDBNull(m_ScontComprobanteID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScontComprobanteID
        End If
		arParams(1) = New SqlParameter("@NumAsiento", SqlDbType.VarChar)		
		If IsDBNull(m_NumAsiento) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NumAsiento
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@EsAjuste", SqlDbType.Bit)		
		If IsDBNull(m_EsAjuste) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_EsAjuste
        End If
		arParams(4) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Concepto
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@objTipoAsientoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoAsientoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objTipoAsientoID
        End If
		arParams(7) = New SqlParameter("@objPeriodoID", SqlDbType.Int)


		m_objPeriodoID = Right(m_objPeriodoID, Len(m_objPeriodoID) - 3)
		If IsDBNull(m_objPeriodoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPeriodoID
        End If
		arParams(8) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Observaciones
        End If
		arParams(9) = New SqlParameter("@ValorCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_ValorCordobas) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ValorCordobas
        End If
		arParams(10) = New SqlParameter("@ValorDolares", SqlDbType.Decimal)		
		If IsDBNull(m_ValorDolares) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ValorDolares
        End If
		arParams(11) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_TasaCambio
        End If
		arParams(12) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_objEstadoID
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
    ''' Borra un objeto ScontComprobanteID de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontComprobanteID where " & " ScontComprobanteID = " & m_ScontComprobanteID
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
    ''' Borra un objeto ScontComprobanteID de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScontComprobanteID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontComprobanteID where " & " ScontComprobanteID = " & p_ScontComprobanteID
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
    ''' Borra objetos ScontComprobanteID de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontComprobanteID where " & pWhere
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
