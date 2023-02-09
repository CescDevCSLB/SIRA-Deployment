Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccCuentaPorCobrarDetalleEmpleados		

#Region " Variables Miembro " 
	Protected m_SccCuentaPorCobrarDetalleID As Integer 
	Protected m_objSccCuentaPorCobrarID As Nullable(Of Integer) 
	Protected m_Mes As Nullable(Of Integer) 
	Protected m_MontoInicial As Nullable(Of Decimal) 
	Protected m_MontoPagado As Nullable(Of Decimal) 
	Protected m_FechaVencimiento As Nullable(Of Date) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SccCuentaPorCobrarDetalleID() As Integer
        Get
            Return (m_SccCuentaPorCobrarDetalleID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccCuentaPorCobrarDetalleID = Value
		End Set
    End Property
	
	Public Property objSccCuentaPorCobrarID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaPorCobrarID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaPorCobrarID = Value
		End Set
    End Property
	
	Public Property Mes() As Nullable(Of Integer)
        Get
            Return (m_Mes)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Mes = Value
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
	
	Public Property MontoPagado() As Nullable(Of Decimal)
        Get
            Return (m_MontoPagado)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoPagado = Value
		End Set
    End Property
	
	Public Property FechaVencimiento() As Nullable(Of Date)
        Get
            Return (m_FechaVencimiento)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaVencimiento = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarDetalleEmpleados.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarDetalleEmpleados.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "MontoInicial"
				Return	18
			Case "MontoPagado"
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
			Case "MontoInicial"
				Return	2
			Case "MontoPagado"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCuentaPorCobrarDetalleEmpleados en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuentaPorCobrarDetalleEmpleados </param>    
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
			cmdDelete.Parameters.Add("@SccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "SccCuentaPorCobrarDetalleID" )
			cmdDelete.CommandText = "DELETE FROM  SccCuentaPorCobrarDetalleEmpleados WHERE SccCuentaPorCobrarDetalleID= @SccCuentaPorCobrarDetalleID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objSccCuentaPorCobrarID", SqlDbType.Int, 4, "objSccCuentaPorCobrarID")
			cmdInsert.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdInsert.Parameters.Add("@MontoInicial", SqlDbType.Decimal, 9, "MontoInicial")
			cmdInsert.Parameters.Add("@MontoPagado", SqlDbType.Decimal, 9, "MontoPagado")
			cmdInsert.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SccCuentaPorCobrarDetalleEmpleados ( objSccCuentaPorCobrarID, Mes, MontoInicial, MontoPagado, FechaVencimiento, objEstadoID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objSccCuentaPorCobrarID, @Mes, @MontoInicial, @MontoPagado, @FechaVencimiento, @objEstadoID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objSccCuentaPorCobrarID", SqlDbType.Int, 4, "objSccCuentaPorCobrarID")
			cmdUpdate.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdUpdate.Parameters.Add("@MontoInicial", SqlDbType.Decimal, 9, "MontoInicial")
			cmdUpdate.Parameters.Add("@MontoPagado", SqlDbType.Decimal, 9, "MontoPagado")
			cmdUpdate.Parameters.Add("@FechaVencimiento", SqlDbType.DateTime, 8, "FechaVencimiento")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "SccCuentaPorCobrarDetalleID")
			cmdUpdate.CommandText = "UPDATE SccCuentaPorCobrarDetalleEmpleados SET objSccCuentaPorCobrarID=@objSccCuentaPorCobrarID, Mes=@Mes, MontoInicial=@MontoInicial, MontoPagado=@MontoPagado, FechaVencimiento=@FechaVencimiento, objEstadoID=@objEstadoID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SccCuentaPorCobrarDetalleID= @wSccCuentaPorCobrarDetalleID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuentaPorCobrarDetalleEmpleados")
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarDetalleEmpleados
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCuentaPorCobrarDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarDetalleEmpleados where " & " SccCuentaPorCobrarDetalleID = " & p_SccCuentaPorCobrarDetalleID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccCuentaPorCobrarDetalleID = dr("SccCuentaPorCobrarDetalleID")
				m_objSccCuentaPorCobrarID = IIf(IsDBNull(dr("objSccCuentaPorCobrarID")), Nothing, dr("objSccCuentaPorCobrarID"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_MontoInicial = IIf(IsDBNull(dr("MontoInicial")), Nothing, dr("MontoInicial"))
				m_MontoPagado = IIf(IsDBNull(dr("MontoPagado")), Nothing, dr("MontoPagado"))
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarDetalleEmpleados usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarDetalleEmpleados where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccCuentaPorCobrarDetalleID = dr("SccCuentaPorCobrarDetalleID")
				m_objSccCuentaPorCobrarID = IIf(IsDBNull(dr("objSccCuentaPorCobrarID")), Nothing, dr("objSccCuentaPorCobrarID"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_MontoInicial = IIf(IsDBNull(dr("MontoInicial")), Nothing, dr("MontoInicial"))
				m_MontoPagado = IIf(IsDBNull(dr("MontoPagado")), Nothing, dr("MontoPagado"))
				m_FechaVencimiento = IIf(IsDBNull(dr("FechaVencimiento")), Nothing, dr("FechaVencimiento"))
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
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalleEmpleados en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalleEmpleados"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarDetalleEmpleados"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalleEmpleados en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalleEmpleados"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarDetalleEmpleados"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarDetalleEmpleados en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarDetalleEmpleados"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuentaPorCobrarDetalleEmpleados.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCuentaPorCobrarDetalleEmpleados("
		sCommand &= "objSccCuentaPorCobrarID,"
		sCommand &= "Mes,"
		sCommand &= "MontoInicial,"
		sCommand &= "MontoPagado,"
		sCommand &= "FechaVencimiento,"
		sCommand &= "objEstadoID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objSccCuentaPorCobrarID,"
		sCommand &= "@Mes,"
		sCommand &= "@MontoInicial,"
		sCommand &= "@MontoPagado,"
		sCommand &= "@FechaVencimiento,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SccCuentaPorCobrarDetalleID = SccCuentaPorCobrarDetalleID from SccCuentaPorCobrarDetalleEmpleados where "		
		sCommand &= "SccCuentaPorCobrarDetalleID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objSccCuentaPorCobrarID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaPorCobrarID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaPorCobrarID
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@MontoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_MontoInicial) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_MontoInicial
        End If
		arParams(4) = New SqlParameter("@MontoPagado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoPagado) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_MontoPagado
        End If
		arParams(5) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaVencimiento
        End If
		arParams(6) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoID
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
			
			m_SccCuentaPorCobrarDetalleID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCuentaPorCobrarDetalleEmpleados en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCuentaPorCobrarDetalleEmpleados set "		
		sCommand &= "objSccCuentaPorCobrarID = @objSccCuentaPorCobrarID,"
		sCommand &= "Mes = @Mes,"
		sCommand &= "MontoInicial = @MontoInicial,"
		sCommand &= "MontoPagado = @MontoPagado,"
		sCommand &= "FechaVencimiento = @FechaVencimiento,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SccCuentaPorCobrarDetalleID = @SccCuentaPorCobrarDetalleID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		If IsDBNull(m_SccCuentaPorCobrarDetalleID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCuentaPorCobrarDetalleID
        End If
		arParams(1) = New SqlParameter("@objSccCuentaPorCobrarID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaPorCobrarID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objSccCuentaPorCobrarID
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@MontoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_MontoInicial) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_MontoInicial
        End If
		arParams(4) = New SqlParameter("@MontoPagado", SqlDbType.Decimal)		
		If IsDBNull(m_MontoPagado) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_MontoPagado
        End If
		arParams(5) = New SqlParameter("@FechaVencimiento", SqlDbType.DateTime)		
		If IsDBNull(m_FechaVencimiento) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaVencimiento
        End If
		arParams(6) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objEstadoID
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
    ''' Borra un objeto SccCuentaPorCobrarDetalleEmpleados de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalleEmpleados where " & " SccCuentaPorCobrarDetalleID = " & m_SccCuentaPorCobrarDetalleID
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
    ''' Borra un objeto SccCuentaPorCobrarDetalleEmpleados de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCuentaPorCobrarDetalleID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalleEmpleados where " & " SccCuentaPorCobrarDetalleID = " & p_SccCuentaPorCobrarDetalleID
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
    ''' Borra objetos SccCuentaPorCobrarDetalleEmpleados de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarDetalleEmpleados where " & pWhere
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
