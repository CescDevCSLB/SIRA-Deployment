Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccCuotasAplicadas		

#Region " Variables Miembro " 
	Protected m_SccAplicadoID As Integer 
	Protected m_objCuentaID As Nullable(Of Integer) 
	Protected m_objCuentaDetalleID As Nullable(Of Integer) 
	Protected m_Monto As Nullable(Of Decimal) 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_ComprobanteGenerado As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SccAplicadoID() As Integer
        Get
            Return (m_SccAplicadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccAplicadoID = Value
		End Set
    End Property
	
	Public Property objCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaID = Value
		End Set
    End Property
	
	Public Property objCuentaDetalleID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaDetalleID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaDetalleID = Value
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
	
	Public Property Activa() As Nullable(Of Boolean)
        Get
            Return (m_Activa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activa = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuotasAplicadas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuotasAplicadas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property ComprobanteGenerado() As Nullable(Of Boolean)
        Get
            Return (m_ComprobanteGenerado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_ComprobanteGenerado = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
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
    ''' Salva un DataSet del tipo de la tabla SccCuotasAplicadas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuotasAplicadas </param>    
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
			cmdDelete.Parameters.Add("@SccAplicadoID", SqlDbType.Int, 4, "SccAplicadoID" )
			cmdDelete.CommandText = "DELETE FROM  SccCuotasAplicadas WHERE SccAplicadoID= @SccAplicadoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCuentaID", SqlDbType.Int, 4, "objCuentaID")
			cmdInsert.Parameters.Add("@objCuentaDetalleID", SqlDbType.Int, 4, "objCuentaDetalleID")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@ComprobanteGenerado", SqlDbType.Bit, 1, "ComprobanteGenerado")
			cmdInsert.CommandText = "INSERT INTO SccCuotasAplicadas ( objCuentaID, objCuentaDetalleID, Monto, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, ComprobanteGenerado) VALUES ( @objCuentaID, @objCuentaDetalleID, @Monto, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @ComprobanteGenerado)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCuentaID", SqlDbType.Int, 4, "objCuentaID")
			cmdUpdate.Parameters.Add("@objCuentaDetalleID", SqlDbType.Int, 4, "objCuentaDetalleID")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@ComprobanteGenerado", SqlDbType.Bit, 1, "ComprobanteGenerado")
			cmdUpdate.Parameters.Add("@wSccAplicadoID", SqlDbType.Int, 4, "SccAplicadoID")
			cmdUpdate.CommandText = "UPDATE SccCuotasAplicadas SET objCuentaID=@objCuentaID, objCuentaDetalleID=@objCuentaDetalleID, Monto=@Monto, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, ComprobanteGenerado=@ComprobanteGenerado WHERE SccAplicadoID= @wSccAplicadoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuotasAplicadas")
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
    ''' Devuelve de la base de datos un objeto SccCuotasAplicadas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccAplicadoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuotasAplicadas where " & " SccAplicadoID = " & p_SccAplicadoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccAplicadoID = dr("SccAplicadoID")
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))
				m_objCuentaDetalleID = IIf(IsDBNull(dr("objCuentaDetalleID")), Nothing, dr("objCuentaDetalleID"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_ComprobanteGenerado = IIf(IsDBNull(dr("ComprobanteGenerado")), Nothing, dr("ComprobanteGenerado"))
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
    ''' Devuelve de la base de datos un objeto SccCuotasAplicadas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuotasAplicadas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccAplicadoID = dr("SccAplicadoID")
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))
				m_objCuentaDetalleID = IIf(IsDBNull(dr("objCuentaDetalleID")), Nothing, dr("objCuentaDetalleID"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_ComprobanteGenerado = IIf(IsDBNull(dr("ComprobanteGenerado")), Nothing, dr("ComprobanteGenerado"))
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
    ''' Trae de la base de datos un conjunto de objetos SccCuotasAplicadas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCuotasAplicadas"

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
			ds.Tables(0).TableName = "SccCuotasAplicadas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuotasAplicadas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCuotasAplicadas"

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
			ds.Tables(0).TableName = "SccCuotasAplicadas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuotasAplicadas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCuotasAplicadas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuotasAplicadas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCuotasAplicadas("
		sCommand &= "objCuentaID,"
		sCommand &= "objCuentaDetalleID,"
		sCommand &= "Monto,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "ComprobanteGenerado) values ("		
		sCommand &= "@objCuentaID,"
		sCommand &= "@objCuentaDetalleID,"
		sCommand &= "@Monto,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@ComprobanteGenerado)"		
	
		sCommand &= " select "
		sCommand &= "@SccAplicadoID = SccAplicadoID from SccCuotasAplicadas where "		
		sCommand &= "SccAplicadoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SccAplicadoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCuentaID
        End If
		arParams(2) = New SqlParameter("@objCuentaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaDetalleID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaDetalleID
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activa
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@ComprobanteGenerado", SqlDbType.Bit)		
		If IsDBNull(m_ComprobanteGenerado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ComprobanteGenerado
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccAplicadoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCuotasAplicadas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCuotasAplicadas set "		
		sCommand &= "objCuentaID = @objCuentaID,"
		sCommand &= "objCuentaDetalleID = @objCuentaDetalleID,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "ComprobanteGenerado = @ComprobanteGenerado"		
		sCommand &= " where "	
		sCommand &= "SccAplicadoID = @SccAplicadoID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SccAplicadoID", SqlDbType.Int)		
		If IsDBNull(m_SccAplicadoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccAplicadoID
        End If
		arParams(1) = New SqlParameter("@objCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCuentaID
        End If
		arParams(2) = New SqlParameter("@objCuentaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaDetalleID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaDetalleID
        End If
		arParams(3) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Monto
        End If
		arParams(4) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Activa
        End If
		arParams(5) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaCreacion
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaModificacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@ComprobanteGenerado", SqlDbType.Bit)		
		If IsDBNull(m_ComprobanteGenerado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ComprobanteGenerado
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
    ''' Borra un objeto SccCuotasAplicadas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuotasAplicadas where " & " SccAplicadoID = " & m_SccAplicadoID
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
    ''' Borra un objeto SccCuotasAplicadas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccAplicadoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuotasAplicadas where " & " SccAplicadoID = " & p_SccAplicadoID
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
    ''' Borra objetos SccCuotasAplicadas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuotasAplicadas where " & pWhere
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