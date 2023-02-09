Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccArqueoRecibo		

#Region " Variables Miembro " 
	Protected m_SccArqueoReciboID As Integer 
	Protected m_objArqueoID As Nullable(Of Integer) 
	Protected m_objConceptoID As Nullable(Of Integer) 
	Protected m_objSccReciboCajaID As Nullable(Of Integer) 
	Protected m_objCajaID As Nullable(Of Integer) 
	Protected m_objTipoPagoID As Nullable(Of Integer) 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_Alumno As String = Nothing 
	Protected m_NumRecibo As String = Nothing 
	Protected m_TotalRecibido As Nullable(Of Decimal) 
	Protected m_Contabilizado As Nullable(Of Boolean) 
	Protected m_FechaContabilizacion As Nullable(Of Date) 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_TotalCordobas As Nullable(Of Decimal) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SccArqueoReciboID() As Integer
        Get
            Return (m_SccArqueoReciboID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccArqueoReciboID = Value
		End Set
    End Property
	
	Public Property objArqueoID() As Nullable(Of Integer)
        Get
            Return (m_objArqueoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objArqueoID = Value
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
	
	Public Property objSccReciboCajaID() As Nullable(Of Integer)
        Get
            Return (m_objSccReciboCajaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccReciboCajaID = Value
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
	
	Public Property objTipoPagoID() As Nullable(Of Integer)
        Get
            Return (m_objTipoPagoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTipoPagoID = Value
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
	
	Public Property Alumno() As String
        Get
            Return (m_Alumno)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Alumno", Value.ToString(), "Valor inv?lido para SccArqueoRecibo.Alumno. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Alumno = Value
		End Set
    End Property
	
	Public Property NumRecibo() As String
        Get
            Return (m_NumRecibo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("NumRecibo", Value.ToString(), "Valor inv?lido para SccArqueoRecibo.NumRecibo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_NumRecibo = Value
		End Set
    End Property
	
	Public Property TotalRecibido() As Nullable(Of Decimal)
        Get
            Return (m_TotalRecibido)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalRecibido = Value
		End Set
    End Property
	
	Public Property Contabilizado() As Nullable(Of Boolean)
        Get
            Return (m_Contabilizado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Contabilizado = Value
		End Set
    End Property
	
	Public Property FechaContabilizacion() As Nullable(Of Date)
        Get
            Return (m_FechaContabilizacion)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaContabilizacion = Value
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
	
	Public Property TotalCordobas() As Nullable(Of Decimal)
        Get
            Return (m_TotalCordobas)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalCordobas = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccArqueoRecibo.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccArqueoRecibo.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Alumno"
				Return	50
			Case "NumRecibo"
				Return	50
			Case "TotalRecibido"
				Return	18
			Case "TotalCordobas"
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
			Case "TotalRecibido"
				Return	2
			Case "TotalCordobas"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccArqueoRecibo en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccArqueoRecibo </param>    
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
			cmdDelete.Parameters.Add("@SccArqueoReciboID", SqlDbType.Int, 4, "SccArqueoReciboID" )
			cmdDelete.CommandText = "DELETE FROM  SccArqueoRecibo WHERE SccArqueoReciboID= @SccArqueoReciboID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objArqueoID", SqlDbType.Int, 4, "objArqueoID")
			cmdInsert.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdInsert.Parameters.Add("@objSccReciboCajaID", SqlDbType.Int, 4, "objSccReciboCajaID")
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.Parameters.Add("@objTipoPagoID", SqlDbType.Int, 4, "objTipoPagoID")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@Alumno", SqlDbType.VarChar, 50, "Alumno")
			cmdInsert.Parameters.Add("@NumRecibo", SqlDbType.VarChar, 50, "NumRecibo")
			cmdInsert.Parameters.Add("@TotalRecibido", SqlDbType.Decimal, 9, "TotalRecibido")
			cmdInsert.Parameters.Add("@Contabilizado", SqlDbType.Bit, 1, "Contabilizado")
			cmdInsert.Parameters.Add("@FechaContabilizacion", SqlDbType.DateTime, 8, "FechaContabilizacion")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SccArqueoRecibo ( objArqueoID, objConceptoID, objSccReciboCajaID, objCajaID, objTipoPagoID, objMonedaID, Alumno, NumRecibo, TotalRecibido, Contabilizado, FechaContabilizacion, Fecha, TotalCordobas, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objArqueoID, @objConceptoID, @objSccReciboCajaID, @objCajaID, @objTipoPagoID, @objMonedaID, @Alumno, @NumRecibo, @TotalRecibido, @Contabilizado, @FechaContabilizacion, @Fecha, @TotalCordobas, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objArqueoID", SqlDbType.Int, 4, "objArqueoID")
			cmdUpdate.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdUpdate.Parameters.Add("@objSccReciboCajaID", SqlDbType.Int, 4, "objSccReciboCajaID")
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@objTipoPagoID", SqlDbType.Int, 4, "objTipoPagoID")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@Alumno", SqlDbType.VarChar, 50, "Alumno")
			cmdUpdate.Parameters.Add("@NumRecibo", SqlDbType.VarChar, 50, "NumRecibo")
			cmdUpdate.Parameters.Add("@TotalRecibido", SqlDbType.Decimal, 9, "TotalRecibido")
			cmdUpdate.Parameters.Add("@Contabilizado", SqlDbType.Bit, 1, "Contabilizado")
			cmdUpdate.Parameters.Add("@FechaContabilizacion", SqlDbType.DateTime, 8, "FechaContabilizacion")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@TotalCordobas", SqlDbType.Decimal, 9, "TotalCordobas")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSccArqueoReciboID", SqlDbType.Int, 4, "SccArqueoReciboID")
			cmdUpdate.CommandText = "UPDATE SccArqueoRecibo SET objArqueoID=@objArqueoID, objConceptoID=@objConceptoID, objSccReciboCajaID=@objSccReciboCajaID, objCajaID=@objCajaID, objTipoPagoID=@objTipoPagoID, objMonedaID=@objMonedaID, Alumno=@Alumno, NumRecibo=@NumRecibo, TotalRecibido=@TotalRecibido, Contabilizado=@Contabilizado, FechaContabilizacion=@FechaContabilizacion, Fecha=@Fecha, TotalCordobas=@TotalCordobas, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SccArqueoReciboID= @wSccArqueoReciboID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccArqueoRecibo")
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
    ''' Devuelve de la base de datos un objeto SccArqueoRecibo
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccArqueoReciboID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoRecibo where " & " SccArqueoReciboID = " & p_SccArqueoReciboID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccArqueoReciboID = dr("SccArqueoReciboID")
				m_objArqueoID = IIf(IsDBNull(dr("objArqueoID")), Nothing, dr("objArqueoID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objSccReciboCajaID = IIf(IsDBNull(dr("objSccReciboCajaID")), Nothing, dr("objSccReciboCajaID"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objTipoPagoID = IIf(IsDBNull(dr("objTipoPagoID")), Nothing, dr("objTipoPagoID"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Alumno = IIf(IsDBNull(dr("Alumno")), Nothing, dr("Alumno"))
				m_NumRecibo = IIf(IsDBNull(dr("NumRecibo")), Nothing, dr("NumRecibo"))
				m_TotalRecibido = IIf(IsDBNull(dr("TotalRecibido")), Nothing, dr("TotalRecibido"))
				m_Contabilizado = IIf(IsDBNull(dr("Contabilizado")), Nothing, dr("Contabilizado"))
				m_FechaContabilizacion = IIf(IsDBNull(dr("FechaContabilizacion")), Nothing, dr("FechaContabilizacion"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))
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
    ''' Devuelve de la base de datos un objeto SccArqueoRecibo usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccArqueoRecibo where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccArqueoReciboID = dr("SccArqueoReciboID")
				m_objArqueoID = IIf(IsDBNull(dr("objArqueoID")), Nothing, dr("objArqueoID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objSccReciboCajaID = IIf(IsDBNull(dr("objSccReciboCajaID")), Nothing, dr("objSccReciboCajaID"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objTipoPagoID = IIf(IsDBNull(dr("objTipoPagoID")), Nothing, dr("objTipoPagoID"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Alumno = IIf(IsDBNull(dr("Alumno")), Nothing, dr("Alumno"))
				m_NumRecibo = IIf(IsDBNull(dr("NumRecibo")), Nothing, dr("NumRecibo"))
				m_TotalRecibido = IIf(IsDBNull(dr("TotalRecibido")), Nothing, dr("TotalRecibido"))
				m_Contabilizado = IIf(IsDBNull(dr("Contabilizado")), Nothing, dr("Contabilizado"))
				m_FechaContabilizacion = IIf(IsDBNull(dr("FechaContabilizacion")), Nothing, dr("FechaContabilizacion"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_TotalCordobas = IIf(IsDBNull(dr("TotalCordobas")), Nothing, dr("TotalCordobas"))
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
    ''' Trae de la base de datos un conjunto de objetos SccArqueoRecibo en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccArqueoRecibo"

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
			ds.Tables(0).TableName = "SccArqueoRecibo"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoRecibo en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccArqueoRecibo"

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
			ds.Tables(0).TableName = "SccArqueoRecibo"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccArqueoRecibo en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccArqueoRecibo"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccArqueoRecibo.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccArqueoRecibo("
		sCommand &= "objArqueoID,"
		sCommand &= "objConceptoID,"
		sCommand &= "objSccReciboCajaID,"
		sCommand &= "objCajaID,"
		sCommand &= "objTipoPagoID,"
		sCommand &= "objMonedaID,"
		sCommand &= "Alumno,"
		sCommand &= "NumRecibo,"
		sCommand &= "TotalRecibido,"
		sCommand &= "Contabilizado,"
		sCommand &= "FechaContabilizacion,"
		sCommand &= "Fecha,"
		sCommand &= "TotalCordobas,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objArqueoID,"
		sCommand &= "@objConceptoID,"
		sCommand &= "@objSccReciboCajaID,"
		sCommand &= "@objCajaID,"
		sCommand &= "@objTipoPagoID,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@Alumno,"
		sCommand &= "@NumRecibo,"
		sCommand &= "@TotalRecibido,"
		sCommand &= "@Contabilizado,"
		sCommand &= "@FechaContabilizacion,"
		sCommand &= "@Fecha,"
		sCommand &= "@TotalCordobas,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccArqueoReciboID = SccArqueoReciboID from SccArqueoRecibo where "		
		sCommand &= "SccArqueoReciboID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccArqueoReciboID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objArqueoID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoID
        End If
		arParams(2) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objConceptoID
        End If
		arParams(3) = New SqlParameter("@objSccReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_objSccReciboCajaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccReciboCajaID
        End If
		arParams(4) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCajaID
        End If
		arParams(5) = New SqlParameter("@objTipoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoPagoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoPagoID
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@Alumno", SqlDbType.VarChar)		
		If IsDBNull(m_Alumno) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Alumno
        End If
		arParams(8) = New SqlParameter("@NumRecibo", SqlDbType.VarChar)		
		If IsDBNull(m_NumRecibo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_NumRecibo
        End If
		arParams(9) = New SqlParameter("@TotalRecibido", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibido) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_TotalRecibido
        End If
		arParams(10) = New SqlParameter("@Contabilizado", SqlDbType.Bit)		
		If IsDBNull(m_Contabilizado) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Contabilizado
        End If
		arParams(11) = New SqlParameter("@FechaContabilizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaContabilizacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaContabilizacion
        End If
		arParams(12) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Fecha
        End If
		arParams(13) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalCordobas
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
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccArqueoReciboID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccArqueoRecibo en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccArqueoRecibo set "		
		sCommand &= "objArqueoID = @objArqueoID,"
		sCommand &= "objConceptoID = @objConceptoID,"
		sCommand &= "objSccReciboCajaID = @objSccReciboCajaID,"
		sCommand &= "objCajaID = @objCajaID,"
		sCommand &= "objTipoPagoID = @objTipoPagoID,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "Alumno = @Alumno,"
		sCommand &= "NumRecibo = @NumRecibo,"
		sCommand &= "TotalRecibido = @TotalRecibido,"
		sCommand &= "Contabilizado = @Contabilizado,"
		sCommand &= "FechaContabilizacion = @FechaContabilizacion,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "TotalCordobas = @TotalCordobas,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SccArqueoReciboID = @SccArqueoReciboID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccArqueoReciboID", SqlDbType.Int)		
		If IsDBNull(m_SccArqueoReciboID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccArqueoReciboID
        End If
		arParams(1) = New SqlParameter("@objArqueoID", SqlDbType.Int)		
		If IsDBNull(m_objArqueoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objArqueoID
        End If
		arParams(2) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objConceptoID
        End If
		arParams(3) = New SqlParameter("@objSccReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_objSccReciboCajaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccReciboCajaID
        End If
		arParams(4) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCajaID
        End If
		arParams(5) = New SqlParameter("@objTipoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoPagoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoPagoID
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@Alumno", SqlDbType.VarChar)		
		If IsDBNull(m_Alumno) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Alumno
        End If
		arParams(8) = New SqlParameter("@NumRecibo", SqlDbType.VarChar)		
		If IsDBNull(m_NumRecibo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_NumRecibo
        End If
		arParams(9) = New SqlParameter("@TotalRecibido", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibido) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_TotalRecibido
        End If
		arParams(10) = New SqlParameter("@Contabilizado", SqlDbType.Bit)		
		If IsDBNull(m_Contabilizado) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Contabilizado
        End If
		arParams(11) = New SqlParameter("@FechaContabilizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaContabilizacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaContabilizacion
        End If
		arParams(12) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Fecha
        End If
		arParams(13) = New SqlParameter("@TotalCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_TotalCordobas) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalCordobas
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
    ''' Borra un objeto SccArqueoRecibo de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoRecibo where " & " SccArqueoReciboID = " & m_SccArqueoReciboID
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
    ''' Borra un objeto SccArqueoRecibo de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccArqueoReciboID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoRecibo where " & " SccArqueoReciboID = " & p_SccArqueoReciboID
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
    ''' Borra objetos SccArqueoRecibo de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccArqueoRecibo where " & pWhere
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
