Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccMora		

#Region " Variables Miembro " 
	Protected m_SccMoraID As Integer 
	Protected m_Fecha As Date 
	Protected m_Mes As Nullable(Of Integer) 
	Protected m_Monto As Decimal 
	Protected m_Descripcion As String = Nothing 
	Protected m_objEstadoID As Integer 
	Protected m_objSccCuentaID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_objSccCuentaPorCobrarDetalleID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SccMoraID() As Integer
        Get
            Return (m_SccMoraID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccMoraID = Value
		End Set
    End Property
	
	Public Property Fecha() As Date
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Date)					
			m_Fecha = Value
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
	
	Public Property Monto() As Decimal
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Decimal)					
			m_Monto = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 300 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SccMora.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (300).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Integer
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property objSccCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccMora.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property FechaCreacion() As Date
        Get
            Return (m_FechaCreacion)
        End Get
		Set(ByVal Value As Date)					
			m_FechaCreacion = Value
		End Set
    End Property
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccMora.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
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
	
	Public Property objSccCuentaPorCobrarDetalleID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaPorCobrarDetalleID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaPorCobrarDetalleID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Monto"
				Return	11
			Case "Descripcion"
				Return	300
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
    ''' Salva un DataSet del tipo de la tabla SccMora en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccMora </param>    
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
			cmdDelete.Parameters.Add("@SccMoraID", SqlDbType.Int, 4, "SccMoraID" )
			cmdDelete.CommandText = "DELETE FROM  SccMora WHERE SccMoraID= @SccMoraID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, 300, "Descripcion")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@objSccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "objSccCuentaPorCobrarDetalleID")
			cmdInsert.CommandText = "INSERT INTO SccMora ( Fecha, Mes, Monto, Descripcion, objEstadoID, objSccCuentaID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, objSccCuentaPorCobrarDetalleID) VALUES ( @Fecha, @Mes, @Monto, @Descripcion, @objEstadoID, @objSccCuentaID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @objSccCuentaPorCobrarDetalleID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, 300, "Descripcion")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@objSccCuentaPorCobrarDetalleID", SqlDbType.Int, 4, "objSccCuentaPorCobrarDetalleID")
			cmdUpdate.Parameters.Add("@wSccMoraID", SqlDbType.Int, 4, "SccMoraID")
			cmdUpdate.CommandText = "UPDATE SccMora SET Fecha=@Fecha, Mes=@Mes, Monto=@Monto, Descripcion=@Descripcion, objEstadoID=@objEstadoID, objSccCuentaID=@objSccCuentaID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, objSccCuentaPorCobrarDetalleID=@objSccCuentaPorCobrarDetalleID WHERE SccMoraID= @wSccMoraID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccMora")
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
    ''' Devuelve de la base de datos un objeto SccMora
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccMoraID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccMora where " & " SccMoraID = " & p_SccMoraID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccMoraID = dr("SccMoraID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objSccCuentaPorCobrarDetalleID = IIf(IsDBNull(dr("objSccCuentaPorCobrarDetalleID")), Nothing, dr("objSccCuentaPorCobrarDetalleID"))
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
    ''' Devuelve de la base de datos un objeto SccMora usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccMora where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccMoraID = dr("SccMoraID")
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_objSccCuentaPorCobrarDetalleID = IIf(IsDBNull(dr("objSccCuentaPorCobrarDetalleID")), Nothing, dr("objSccCuentaPorCobrarDetalleID"))
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
    ''' Trae de la base de datos un conjunto de objetos SccMora en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccMora"

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
			ds.Tables(0).TableName = "SccMora"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccMora en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccMora"

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
			ds.Tables(0).TableName = "SccMora"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccMora en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccMora"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccMora.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccMora("
		sCommand &= "Fecha,"
		sCommand &= "Mes,"
		sCommand &= "Monto,"
		sCommand &= "Descripcion,"
		sCommand &= "objEstadoID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "objSccCuentaPorCobrarDetalleID) values ("		
		sCommand &= "@Fecha,"
		sCommand &= "@Mes,"
		sCommand &= "@Monto,"
		sCommand &= "@Descripcion,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@objSccCuentaPorCobrarDetalleID)"		
	
		sCommand &= " select "
		sCommand &= "@SccMoraID = SccMoraID from SccMora where "		
		sCommand &= "SccMoraID = SCOPE_IDENTITY()"
		
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccMoraID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Descripcion
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objSccCuentaID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objSccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaPorCobrarDetalleID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objSccCuentaPorCobrarDetalleID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccMoraID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccMora en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccMora set "		
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "Mes = @Mes,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "objSccCuentaPorCobrarDetalleID = @objSccCuentaPorCobrarDetalleID"		
		sCommand &= " where "	
		sCommand &= "SccMoraID = @SccMoraID"					
		
		Dim arParams(11) As SqlParameter
		arParams(0) = New SqlParameter("@SccMoraID", SqlDbType.Int)		
		If IsDBNull(m_SccMoraID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccMoraID
        End If
		arParams(1) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Fecha
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Descripcion
        End If
		arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
		arParams(6) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objSccCuentaID
        End If
		arParams(7) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCreacion
        End If
		arParams(8) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_FechaCreacion
        End If
		arParams(9) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_UsuarioModificacion
        End If
		arParams(10) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaModificacion
        End If
		arParams(11) = New SqlParameter("@objSccCuentaPorCobrarDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaPorCobrarDetalleID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objSccCuentaPorCobrarDetalleID
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
    ''' Borra un objeto SccMora de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccMora where " & " SccMoraID = " & m_SccMoraID
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
    ''' Borra un objeto SccMora de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccMoraID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccMora where " & " SccMoraID = " & p_SccMoraID
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
    ''' Borra objetos SccMora de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccMora where " & pWhere
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
