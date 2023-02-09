Imports DAL
Imports System.Data.SqlClient

Partial Public Class SContCuentasContables		

#Region " Variables Miembro " 
	Protected m_SContCuentasContablesID As Integer 
	Protected m_IDCuenta As String = Nothing 
	Protected m_Descripcion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_objNaturalezaID As Nullable(Of Integer) 
	Protected m_Nivel As Nullable(Of Integer) 
	Protected m_RecibeMovimiento As Nullable(Of Boolean) 
	Protected m_CentroCosto As Nullable(Of Boolean) 
	Protected m_TieneAuxilar As Nullable(Of Boolean) 
	Protected m_CuentaPadre As String = Nothing 
	Protected m_CuentaBalance As Nullable(Of Boolean) 
	Protected m_CuentaEstadoResultado As Nullable(Of Boolean) 
	Protected m_objClasificacionID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SContCuentasContablesID() As Integer
        Get
            Return (m_SContCuentasContablesID)
        End Get
		Set(ByVal Value As Integer)					
			m_SContCuentasContablesID = Value
		End Set
    End Property
	
	Public Property IDCuenta() As String
        Get
            Return (m_IDCuenta)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("IDCuenta", Value.ToString(), "Valor inv?lido para SContCuentasContables.IDCuenta. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SContCuentasContables.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Descripcion = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SContCuentasContables.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SContCuentasContables.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property objNaturalezaID() As Nullable(Of Integer)
        Get
            Return (m_objNaturalezaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objNaturalezaID = Value
		End Set
    End Property
	
	Public Property Nivel() As Nullable(Of Integer)
        Get
            Return (m_Nivel)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Nivel = Value
		End Set
    End Property
	
	Public Property RecibeMovimiento() As Nullable(Of Boolean)
        Get
            Return (m_RecibeMovimiento)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_RecibeMovimiento = Value
		End Set
    End Property
	
	Public Property CentroCosto() As Nullable(Of Boolean)
        Get
            Return (m_CentroCosto)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CentroCosto = Value
		End Set
    End Property
	
	Public Property TieneAuxilar() As Nullable(Of Boolean)
        Get
            Return (m_TieneAuxilar)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_TieneAuxilar = Value
		End Set
    End Property
	
	Public Property CuentaPadre() As String
        Get
            Return (m_CuentaPadre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("CuentaPadre", Value.ToString(), "Valor inv?lido para SContCuentasContables.CuentaPadre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_CuentaPadre = Value
		End Set
    End Property
	
	Public Property CuentaBalance() As Nullable(Of Boolean)
        Get
            Return (m_CuentaBalance)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CuentaBalance = Value
		End Set
    End Property
	
	Public Property CuentaEstadoResultado() As Nullable(Of Boolean)
        Get
            Return (m_CuentaEstadoResultado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_CuentaEstadoResultado = Value
		End Set
    End Property
	
	Public Property objClasificacionID() As Nullable(Of Integer)
        Get
            Return (m_objClasificacionID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objClasificacionID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "IDCuenta"
				Return	50
			Case "Descripcion"
				Return	150
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "CuentaPadre"
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
    ''' Salva un DataSet del tipo de la tabla SContCuentasContables en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SContCuentasContables </param>    
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
			cmdDelete.Parameters.Add("@SContCuentasContablesID", SqlDbType.Int, 4, "SContCuentasContablesID" )
			cmdDelete.CommandText = "DELETE FROM  SContCuentasContables WHERE SContCuentasContablesID= @SContCuentasContablesID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@IDCuenta", SqlDbType.VarChar, 50, "IDCuenta")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@objNaturalezaID", SqlDbType.Int, 4, "objNaturalezaID")
			cmdInsert.Parameters.Add("@Nivel", SqlDbType.Int, 4, "Nivel")
			cmdInsert.Parameters.Add("@RecibeMovimiento", SqlDbType.Bit, 1, "RecibeMovimiento")
			cmdInsert.Parameters.Add("@CentroCosto", SqlDbType.Bit, 1, "CentroCosto")
			cmdInsert.Parameters.Add("@TieneAuxilar", SqlDbType.Bit, 1, "TieneAuxilar")
			cmdInsert.Parameters.Add("@CuentaPadre", SqlDbType.VarChar, 50, "CuentaPadre")
			cmdInsert.Parameters.Add("@CuentaBalance", SqlDbType.Bit, 1, "CuentaBalance")
			cmdInsert.Parameters.Add("@CuentaEstadoResultado", SqlDbType.Bit, 1, "CuentaEstadoResultado")
			cmdInsert.Parameters.Add("@objClasificacionID", SqlDbType.Int, 4, "objClasificacionID")
			cmdInsert.CommandText = "INSERT INTO SContCuentasContables ( IDCuenta, Descripcion, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Activo, objNaturalezaID, Nivel, RecibeMovimiento, CentroCosto, TieneAuxilar, CuentaPadre, CuentaBalance, CuentaEstadoResultado, objClasificacionID) VALUES ( @IDCuenta, @Descripcion, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Activo, @objNaturalezaID, @Nivel, @RecibeMovimiento, @CentroCosto, @TieneAuxilar, @CuentaPadre, @CuentaBalance, @CuentaEstadoResultado, @objClasificacionID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@IDCuenta", SqlDbType.VarChar, 50, "IDCuenta")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 150, "Descripcion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@objNaturalezaID", SqlDbType.Int, 4, "objNaturalezaID")
			cmdUpdate.Parameters.Add("@Nivel", SqlDbType.Int, 4, "Nivel")
			cmdUpdate.Parameters.Add("@RecibeMovimiento", SqlDbType.Bit, 1, "RecibeMovimiento")
			cmdUpdate.Parameters.Add("@CentroCosto", SqlDbType.Bit, 1, "CentroCosto")
			cmdUpdate.Parameters.Add("@TieneAuxilar", SqlDbType.Bit, 1, "TieneAuxilar")
			cmdUpdate.Parameters.Add("@CuentaPadre", SqlDbType.VarChar, 50, "CuentaPadre")
			cmdUpdate.Parameters.Add("@CuentaBalance", SqlDbType.Bit, 1, "CuentaBalance")
			cmdUpdate.Parameters.Add("@CuentaEstadoResultado", SqlDbType.Bit, 1, "CuentaEstadoResultado")
			cmdUpdate.Parameters.Add("@objClasificacionID", SqlDbType.Int, 4, "objClasificacionID")
			cmdUpdate.Parameters.Add("@wSContCuentasContablesID", SqlDbType.Int, 4, "SContCuentasContablesID")
			cmdUpdate.CommandText = "UPDATE SContCuentasContables SET IDCuenta=@IDCuenta, Descripcion=@Descripcion, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Activo=@Activo, objNaturalezaID=@objNaturalezaID, Nivel=@Nivel, RecibeMovimiento=@RecibeMovimiento, CentroCosto=@CentroCosto, TieneAuxilar=@TieneAuxilar, CuentaPadre=@CuentaPadre, CuentaBalance=@CuentaBalance, CuentaEstadoResultado=@CuentaEstadoResultado, objClasificacionID=@objClasificacionID WHERE SContCuentasContablesID= @wSContCuentasContablesID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SContCuentasContables")
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
    ''' Devuelve de la base de datos un objeto SContCuentasContables
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SContCuentasContablesID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContCuentasContables where " & " SContCuentasContablesID = " & p_SContCuentasContablesID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SContCuentasContablesID = dr("SContCuentasContablesID")
				m_IDCuenta = IIf(IsDBNull(dr("IDCuenta")), Nothing, dr("IDCuenta"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_objNaturalezaID = IIf(IsDBNull(dr("objNaturalezaID")), Nothing, dr("objNaturalezaID"))
				m_Nivel = IIf(IsDBNull(dr("Nivel")), Nothing, dr("Nivel"))
				m_RecibeMovimiento = IIf(IsDBNull(dr("RecibeMovimiento")), Nothing, dr("RecibeMovimiento"))
				m_CentroCosto = IIf(IsDBNull(dr("CentroCosto")), Nothing, dr("CentroCosto"))
				m_TieneAuxilar = IIf(IsDBNull(dr("TieneAuxilar")), Nothing, dr("TieneAuxilar"))
				m_CuentaPadre = IIf(IsDBNull(dr("CuentaPadre")), Nothing, dr("CuentaPadre"))
				m_CuentaBalance = IIf(IsDBNull(dr("CuentaBalance")), Nothing, dr("CuentaBalance"))
				m_CuentaEstadoResultado = IIf(IsDBNull(dr("CuentaEstadoResultado")), Nothing, dr("CuentaEstadoResultado"))
				m_objClasificacionID = IIf(IsDBNull(dr("objClasificacionID")), Nothing, dr("objClasificacionID"))
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
    ''' Devuelve de la base de datos un objeto SContCuentasContables usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContCuentasContables where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SContCuentasContablesID = dr("SContCuentasContablesID")
				m_IDCuenta = IIf(IsDBNull(dr("IDCuenta")), Nothing, dr("IDCuenta"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_objNaturalezaID = IIf(IsDBNull(dr("objNaturalezaID")), Nothing, dr("objNaturalezaID"))
				m_Nivel = IIf(IsDBNull(dr("Nivel")), Nothing, dr("Nivel"))
				m_RecibeMovimiento = IIf(IsDBNull(dr("RecibeMovimiento")), Nothing, dr("RecibeMovimiento"))
				m_CentroCosto = IIf(IsDBNull(dr("CentroCosto")), Nothing, dr("CentroCosto"))
				m_TieneAuxilar = IIf(IsDBNull(dr("TieneAuxilar")), Nothing, dr("TieneAuxilar"))
				m_CuentaPadre = IIf(IsDBNull(dr("CuentaPadre")), Nothing, dr("CuentaPadre"))
				m_CuentaBalance = IIf(IsDBNull(dr("CuentaBalance")), Nothing, dr("CuentaBalance"))
				m_CuentaEstadoResultado = IIf(IsDBNull(dr("CuentaEstadoResultado")), Nothing, dr("CuentaEstadoResultado"))
				m_objClasificacionID = IIf(IsDBNull(dr("objClasificacionID")), Nothing, dr("objClasificacionID"))
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
    ''' Trae de la base de datos un conjunto de objetos SContCuentasContables en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SContCuentasContables"

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
			ds.Tables(0).TableName = "SContCuentasContables"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContCuentasContables en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SContCuentasContables"

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
			ds.Tables(0).TableName = "SContCuentasContables"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContCuentasContables en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SContCuentasContables"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SContCuentasContables.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SContCuentasContables("
		sCommand &= "IDCuenta,"
		sCommand &= "Descripcion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Activo,"
		sCommand &= "objNaturalezaID,"
		sCommand &= "Nivel,"
		sCommand &= "RecibeMovimiento,"
		sCommand &= "CentroCosto,"
		sCommand &= "TieneAuxilar,"
		sCommand &= "CuentaPadre,"
		sCommand &= "CuentaBalance,"
		sCommand &= "CuentaEstadoResultado,"
		sCommand &= "objClasificacionID) values ("		
		sCommand &= "@IDCuenta,"
		sCommand &= "@Descripcion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Activo,"
		sCommand &= "@objNaturalezaID,"
		sCommand &= "@Nivel,"
		sCommand &= "@RecibeMovimiento,"
		sCommand &= "@CentroCosto,"
		sCommand &= "@TieneAuxilar,"
		sCommand &= "@CuentaPadre,"
		sCommand &= "@CuentaBalance,"
		sCommand &= "@CuentaEstadoResultado,"
		sCommand &= "@objClasificacionID)"		
	
		sCommand &= " select "
		sCommand &= "@SContCuentasContablesID = SContCuentasContablesID from SContCuentasContables where "		
		sCommand &= "SContCuentasContablesID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@SContCuentasContablesID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@IDCuenta", SqlDbType.VarChar)		
		If IsDBNull(m_IDCuenta) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_IDCuenta
        End If
		arParams(2) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Descripcion
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Activo
        End If
		arParams(8) = New SqlParameter("@objNaturalezaID", SqlDbType.Int)		
		If IsDBNull(m_objNaturalezaID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objNaturalezaID
        End If
		arParams(9) = New SqlParameter("@Nivel", SqlDbType.Int)		
		If IsDBNull(m_Nivel) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Nivel
        End If
		arParams(10) = New SqlParameter("@RecibeMovimiento", SqlDbType.Bit)		
		If IsDBNull(m_RecibeMovimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_RecibeMovimiento
        End If
		arParams(11) = New SqlParameter("@CentroCosto", SqlDbType.Bit)		
		If IsDBNull(m_CentroCosto) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_CentroCosto
        End If
		arParams(12) = New SqlParameter("@TieneAuxilar", SqlDbType.Bit)		
		If IsDBNull(m_TieneAuxilar) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TieneAuxilar
        End If
		arParams(13) = New SqlParameter("@CuentaPadre", SqlDbType.VarChar)		
		If IsDBNull(m_CuentaPadre) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_CuentaPadre
        End If
		arParams(14) = New SqlParameter("@CuentaBalance", SqlDbType.Bit)		
		If IsDBNull(m_CuentaBalance) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_CuentaBalance
        End If
		arParams(15) = New SqlParameter("@CuentaEstadoResultado", SqlDbType.Bit)		
		If IsDBNull(m_CuentaEstadoResultado) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CuentaEstadoResultado
        End If
		arParams(16) = New SqlParameter("@objClasificacionID", SqlDbType.Int)		
		If IsDBNull(m_objClasificacionID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objClasificacionID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SContCuentasContablesID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SContCuentasContables en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SContCuentasContables set "		
		sCommand &= "IDCuenta = @IDCuenta,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "objNaturalezaID = @objNaturalezaID,"
		sCommand &= "Nivel = @Nivel,"
		sCommand &= "RecibeMovimiento = @RecibeMovimiento,"
		sCommand &= "CentroCosto = @CentroCosto,"
		sCommand &= "TieneAuxilar = @TieneAuxilar,"
		sCommand &= "CuentaPadre = @CuentaPadre,"
		sCommand &= "CuentaBalance = @CuentaBalance,"
		sCommand &= "CuentaEstadoResultado = @CuentaEstadoResultado,"
		sCommand &= "objClasificacionID = @objClasificacionID"		
		sCommand &= " where "	
		sCommand &= "SContCuentasContablesID = @SContCuentasContablesID"					
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@SContCuentasContablesID", SqlDbType.Int)		
		If IsDBNull(m_SContCuentasContablesID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SContCuentasContablesID
        End If
		arParams(1) = New SqlParameter("@IDCuenta", SqlDbType.VarChar)		
		If IsDBNull(m_IDCuenta) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_IDCuenta
        End If
		arParams(2) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Descripcion
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Activo
        End If
		arParams(8) = New SqlParameter("@objNaturalezaID", SqlDbType.Int)		
		If IsDBNull(m_objNaturalezaID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objNaturalezaID
        End If
		arParams(9) = New SqlParameter("@Nivel", SqlDbType.Int)		
		If IsDBNull(m_Nivel) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Nivel
        End If
		arParams(10) = New SqlParameter("@RecibeMovimiento", SqlDbType.Bit)		
		If IsDBNull(m_RecibeMovimiento) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_RecibeMovimiento
        End If
		arParams(11) = New SqlParameter("@CentroCosto", SqlDbType.Bit)		
		If IsDBNull(m_CentroCosto) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_CentroCosto
        End If
		arParams(12) = New SqlParameter("@TieneAuxilar", SqlDbType.Bit)		
		If IsDBNull(m_TieneAuxilar) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TieneAuxilar
        End If
		arParams(13) = New SqlParameter("@CuentaPadre", SqlDbType.VarChar)		
		If IsDBNull(m_CuentaPadre) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_CuentaPadre
        End If
		arParams(14) = New SqlParameter("@CuentaBalance", SqlDbType.Bit)		
		If IsDBNull(m_CuentaBalance) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_CuentaBalance
        End If
		arParams(15) = New SqlParameter("@CuentaEstadoResultado", SqlDbType.Bit)		
		If IsDBNull(m_CuentaEstadoResultado) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_CuentaEstadoResultado
        End If
		arParams(16) = New SqlParameter("@objClasificacionID", SqlDbType.Int)		
		If IsDBNull(m_objClasificacionID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objClasificacionID
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
    ''' Borra un objeto SContCuentasContables de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContCuentasContables where " & " SContCuentasContablesID = " & m_SContCuentasContablesID
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
    ''' Borra un objeto SContCuentasContables de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SContCuentasContablesID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContCuentasContables where " & " SContCuentasContablesID = " & p_SContCuentasContablesID
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
    ''' Borra objetos SContCuentasContables de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContCuentasContables where " & pWhere
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
