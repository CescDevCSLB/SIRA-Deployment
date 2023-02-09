Imports DAL
Imports System.Data.SqlClient

Partial Public Class SContComprobanteDetalle		

#Region " Variables Miembro " 
	Protected m_SContComprobanteDetalleID As Integer 
	Protected m_objSContCompronanteID As Nullable(Of Integer) 
	Protected m_SContContablesID As Nullable(Of Integer) 
	Protected m_objCentroCostoID As Nullable(Of Integer) 
	Protected m_MontoAcreditar As Nullable(Of Decimal) 
	Protected m_MontoDebitar As Nullable(Of Decimal) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_SaldoInicial As Nullable(Of Decimal) 
	Protected m_SaldoFInal As Nullable(Of Decimal) 
	Protected m_FechaContabilizacion As Nullable(Of Date) 
	Protected m_SaldoFInalCC As Nullable(Of Decimal) 
	Protected m_SaldoInicialCC As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	Public Property SContComprobanteDetalleID() As Integer
        Get
            Return (m_SContComprobanteDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SContComprobanteDetalleID = Value
		End Set
    End Property
	
	Public Property objSContCompronanteID() As Nullable(Of Integer)
        Get
            Return (m_objSContCompronanteID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSContCompronanteID = Value
		End Set
    End Property
	
	Public Property SContContablesID() As Nullable(Of Integer)
        Get
            Return (m_SContContablesID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_SContContablesID = Value
		End Set
    End Property
	
	Public Property objCentroCostoID() As Nullable(Of Integer)
        Get
            Return (m_objCentroCostoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCentroCostoID = Value
		End Set
    End Property
	
	Public Property MontoAcreditar() As Nullable(Of Decimal)
        Get
            Return (m_MontoAcreditar)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoAcreditar = Value
		End Set
    End Property
	
	Public Property MontoDebitar() As Nullable(Of Decimal)
        Get
            Return (m_MontoDebitar)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoDebitar = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SContComprobanteDetalle.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SContComprobanteDetalle.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property Saldo() As Nullable(Of Decimal)
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Saldo = Value
		End Set
    End Property
	
	Public Property SaldoInicial() As Nullable(Of Decimal)
        Get
            Return (m_SaldoInicial)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoInicial = Value
		End Set
    End Property
	
	Public Property SaldoFInal() As Nullable(Of Decimal)
        Get
            Return (m_SaldoFInal)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoFInal = Value
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
	
	Public Property SaldoFInalCC() As Nullable(Of Decimal)
        Get
            Return (m_SaldoFInalCC)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoFInalCC = Value
		End Set
    End Property
	
	Public Property SaldoInicialCC() As Nullable(Of Decimal)
        Get
            Return (m_SaldoInicialCC)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoInicialCC = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MontoAcreditar"
				Return	18
			Case "MontoDebitar"
				Return	18
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "Saldo"
				Return	18
			Case "SaldoInicial"
				Return	18
			Case "SaldoFInal"
				Return	18
			Case "SaldoFInalCC"
				Return	18
			Case "SaldoInicialCC"
				Return	18
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MontoAcreditar"
				Return	2
			Case "MontoDebitar"
				Return	2
			Case "Saldo"
				Return	2
			Case "SaldoInicial"
				Return	2
			Case "SaldoFInal"
				Return	2
			Case "SaldoFInalCC"
				Return	2
			Case "SaldoInicialCC"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SContComprobanteDetalle en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SContComprobanteDetalle </param>    
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
			cmdDelete.Parameters.Add("@SContComprobanteDetalleID", SqlDbType.Int, 4, "SContComprobanteDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SContComprobanteDetalle WHERE SContComprobanteDetalleID= @SContComprobanteDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSContCompronanteID", SqlDbType.Int, 4, "objSContCompronanteID")
			cmdInsert.Parameters.Add("@SContContablesID", SqlDbType.Int, 4, "SContContablesID")
			cmdInsert.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdInsert.Parameters.Add("@MontoAcreditar", SqlDbType.Decimal, 9, "MontoAcreditar")
			cmdInsert.Parameters.Add("@MontoDebitar", SqlDbType.Decimal, 9, "MontoDebitar")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdInsert.Parameters.Add("@SaldoFInal", SqlDbType.Decimal, 9, "SaldoFInal")
			cmdInsert.Parameters.Add("@FechaContabilizacion", SqlDbType.DateTime, 8, "FechaContabilizacion")
			cmdInsert.Parameters.Add("@SaldoFInalCC", SqlDbType.Decimal, 9, "SaldoFInalCC")
			cmdInsert.Parameters.Add("@SaldoInicialCC", SqlDbType.Decimal, 9, "SaldoInicialCC")
			cmdInsert.CommandText = "INSERT INTO SContComprobanteDetalle ( objSContCompronanteID, SContContablesID, objCentroCostoID, MontoAcreditar, MontoDebitar, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Saldo, SaldoInicial, SaldoFInal, FechaContabilizacion, SaldoFInalCC, SaldoInicialCC) VALUES ( @objSContCompronanteID, @SContContablesID, @objCentroCostoID, @MontoAcreditar, @MontoDebitar, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Saldo, @SaldoInicial, @SaldoFInal, @FechaContabilizacion, @SaldoFInalCC, @SaldoInicialCC)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSContCompronanteID", SqlDbType.Int, 4, "objSContCompronanteID")
			cmdUpdate.Parameters.Add("@SContContablesID", SqlDbType.Int, 4, "SContContablesID")
			cmdUpdate.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdUpdate.Parameters.Add("@MontoAcreditar", SqlDbType.Decimal, 9, "MontoAcreditar")
			cmdUpdate.Parameters.Add("@MontoDebitar", SqlDbType.Decimal, 9, "MontoDebitar")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdUpdate.Parameters.Add("@SaldoFInal", SqlDbType.Decimal, 9, "SaldoFInal")
			cmdUpdate.Parameters.Add("@FechaContabilizacion", SqlDbType.DateTime, 8, "FechaContabilizacion")
			cmdUpdate.Parameters.Add("@SaldoFInalCC", SqlDbType.Decimal, 9, "SaldoFInalCC")
			cmdUpdate.Parameters.Add("@SaldoInicialCC", SqlDbType.Decimal, 9, "SaldoInicialCC")
			cmdUpdate.Parameters.Add("@wSContComprobanteDetalleID", SqlDbType.Int, 4, "SContComprobanteDetalleID")
			cmdUpdate.CommandText = "UPDATE SContComprobanteDetalle SET objSContCompronanteID=@objSContCompronanteID, SContContablesID=@SContContablesID, objCentroCostoID=@objCentroCostoID, MontoAcreditar=@MontoAcreditar, MontoDebitar=@MontoDebitar, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Saldo=@Saldo, SaldoInicial=@SaldoInicial, SaldoFInal=@SaldoFInal, FechaContabilizacion=@FechaContabilizacion, SaldoFInalCC=@SaldoFInalCC, SaldoInicialCC=@SaldoInicialCC WHERE SContComprobanteDetalleID= @wSContComprobanteDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SContComprobanteDetalle")
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
    ''' Devuelve de la base de datos un objeto SContComprobanteDetalle
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SContComprobanteDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContComprobanteDetalle where " & " SContComprobanteDetalleID = " & p_SContComprobanteDetalleID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SContComprobanteDetalleID = dr("SContComprobanteDetalleID")
				m_objSContCompronanteID = IIf(IsDBNull(dr("objSContCompronanteID")), Nothing, dr("objSContCompronanteID"))
				m_SContContablesID = IIf(IsDBNull(dr("SContContablesID")), Nothing, dr("SContContablesID"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_MontoAcreditar = IIf(IsDBNull(dr("MontoAcreditar")), Nothing, dr("MontoAcreditar"))
				m_MontoDebitar = IIf(IsDBNull(dr("MontoDebitar")), Nothing, dr("MontoDebitar"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
				m_SaldoFInal = IIf(IsDBNull(dr("SaldoFInal")), Nothing, dr("SaldoFInal"))
				m_FechaContabilizacion = IIf(IsDBNull(dr("FechaContabilizacion")), Nothing, dr("FechaContabilizacion"))
				m_SaldoFInalCC = IIf(IsDBNull(dr("SaldoFInalCC")), Nothing, dr("SaldoFInalCC"))
				m_SaldoInicialCC = IIf(IsDBNull(dr("SaldoInicialCC")), Nothing, dr("SaldoInicialCC"))
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
    ''' Devuelve de la base de datos un objeto SContComprobanteDetalle usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContComprobanteDetalle where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SContComprobanteDetalleID = dr("SContComprobanteDetalleID")
				m_objSContCompronanteID = IIf(IsDBNull(dr("objSContCompronanteID")), Nothing, dr("objSContCompronanteID"))
				m_SContContablesID = IIf(IsDBNull(dr("SContContablesID")), Nothing, dr("SContContablesID"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_MontoAcreditar = IIf(IsDBNull(dr("MontoAcreditar")), Nothing, dr("MontoAcreditar"))
				m_MontoDebitar = IIf(IsDBNull(dr("MontoDebitar")), Nothing, dr("MontoDebitar"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
				m_SaldoFInal = IIf(IsDBNull(dr("SaldoFInal")), Nothing, dr("SaldoFInal"))
				m_FechaContabilizacion = IIf(IsDBNull(dr("FechaContabilizacion")), Nothing, dr("FechaContabilizacion"))
				m_SaldoFInalCC = IIf(IsDBNull(dr("SaldoFInalCC")), Nothing, dr("SaldoFInalCC"))
				m_SaldoInicialCC = IIf(IsDBNull(dr("SaldoInicialCC")), Nothing, dr("SaldoInicialCC"))
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
    ''' Trae de la base de datos un conjunto de objetos SContComprobanteDetalle en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SContComprobanteDetalle"

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
			ds.Tables(0).TableName = "SContComprobanteDetalle"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContComprobanteDetalle en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SContComprobanteDetalle"

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
			ds.Tables(0).TableName = "SContComprobanteDetalle"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContComprobanteDetalle en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SContComprobanteDetalle"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SContComprobanteDetalle.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SContComprobanteDetalle("
		sCommand &= "objSContCompronanteID,"
		sCommand &= "SContContablesID,"
		sCommand &= "objCentroCostoID,"
		sCommand &= "MontoAcreditar,"
		sCommand &= "MontoDebitar,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Saldo,"
		sCommand &= "SaldoInicial,"
		sCommand &= "SaldoFInal,"
		sCommand &= "FechaContabilizacion,"
		sCommand &= "SaldoFInalCC,"
		sCommand &= "SaldoInicialCC) values ("		
		sCommand &= "@objSContCompronanteID,"
		sCommand &= "@SContContablesID,"
		sCommand &= "@objCentroCostoID,"
		sCommand &= "@MontoAcreditar,"
		sCommand &= "@MontoDebitar,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Saldo,"
		sCommand &= "@SaldoInicial,"
		sCommand &= "@SaldoFInal,"
		sCommand &= "@FechaContabilizacion,"
		sCommand &= "@SaldoFInalCC,"
		sCommand &= "@SaldoInicialCC)"		
	
		sCommand &= " select "
		sCommand &= "@SContComprobanteDetalleID = SContComprobanteDetalleID from SContComprobanteDetalle where "		
		sCommand &= "SContComprobanteDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SContComprobanteDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSContCompronanteID", SqlDbType.Int)		
		If IsDBNull(m_objSContCompronanteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSContCompronanteID
        End If
		arParams(2) = New SqlParameter("@SContContablesID", SqlDbType.Int)		
		If IsDBNull(m_SContContablesID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_SContContablesID
        End If
		arParams(3) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCentroCostoID
        End If
		arParams(4) = New SqlParameter("@MontoAcreditar", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAcreditar) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_MontoAcreditar
        End If
		arParams(5) = New SqlParameter("@MontoDebitar", SqlDbType.Decimal)		
		If IsDBNull(m_MontoDebitar) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_MontoDebitar
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
		arParams(10) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Saldo
        End If
		arParams(11) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_SaldoInicial
        End If
		arParams(12) = New SqlParameter("@SaldoFInal", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoFInal) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_SaldoFInal
        End If
		arParams(13) = New SqlParameter("@FechaContabilizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaContabilizacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaContabilizacion
        End If
		arParams(14) = New SqlParameter("@SaldoFInalCC", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoFInalCC) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_SaldoFInalCC
        End If
		arParams(15) = New SqlParameter("@SaldoInicialCC", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicialCC) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_SaldoInicialCC
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SContComprobanteDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SContComprobanteDetalle en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SContComprobanteDetalle set "		
		sCommand &= "objSContCompronanteID = @objSContCompronanteID,"
		sCommand &= "SContContablesID = @SContContablesID,"
		sCommand &= "objCentroCostoID = @objCentroCostoID,"
		sCommand &= "MontoAcreditar = @MontoAcreditar,"
		sCommand &= "MontoDebitar = @MontoDebitar,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "SaldoInicial = @SaldoInicial,"
		sCommand &= "SaldoFInal = @SaldoFInal,"
		sCommand &= "FechaContabilizacion = @FechaContabilizacion,"
		sCommand &= "SaldoFInalCC = @SaldoFInalCC,"
		sCommand &= "SaldoInicialCC = @SaldoInicialCC"		
		sCommand &= " where "	
		sCommand &= "SContComprobanteDetalleID = @SContComprobanteDetalleID"					
		
		Dim arParams(15) As SqlParameter
		arParams(0) = New SqlParameter("@SContComprobanteDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SContComprobanteDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SContComprobanteDetalleID
        End If
		arParams(1) = New SqlParameter("@objSContCompronanteID", SqlDbType.Int)		
		If IsDBNull(m_objSContCompronanteID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSContCompronanteID
        End If
		arParams(2) = New SqlParameter("@SContContablesID", SqlDbType.Int)		
		If IsDBNull(m_SContContablesID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_SContContablesID
        End If
		arParams(3) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCentroCostoID
        End If
		arParams(4) = New SqlParameter("@MontoAcreditar", SqlDbType.Decimal)		
		If IsDBNull(m_MontoAcreditar) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_MontoAcreditar
        End If
		arParams(5) = New SqlParameter("@MontoDebitar", SqlDbType.Decimal)		
		If IsDBNull(m_MontoDebitar) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_MontoDebitar
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
		arParams(10) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Saldo
        End If
		arParams(11) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_SaldoInicial
        End If
		arParams(12) = New SqlParameter("@SaldoFInal", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoFInal) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_SaldoFInal
        End If
		arParams(13) = New SqlParameter("@FechaContabilizacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaContabilizacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaContabilizacion
        End If
		arParams(14) = New SqlParameter("@SaldoFInalCC", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoFInalCC) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_SaldoFInalCC
        End If
		arParams(15) = New SqlParameter("@SaldoInicialCC", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicialCC) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_SaldoInicialCC
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
    ''' Borra un objeto SContComprobanteDetalle de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContComprobanteDetalle where " & " SContComprobanteDetalleID = " & m_SContComprobanteDetalleID
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
    ''' Borra un objeto SContComprobanteDetalle de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SContComprobanteDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContComprobanteDetalle where " & " SContComprobanteDetalleID = " & p_SContComprobanteDetalleID
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
    ''' Borra objetos SContComprobanteDetalle de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContComprobanteDetalle where " & pWhere
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
