Imports DAL
Imports System.Data.SqlClient

Partial Public Class SContPeriodos		

#Region " Variables Miembro " 
	Protected m_SContPeriodoID As Integer 
	Protected m_Periodo As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioCierre As String = Nothing 
	Protected m_Fechaierre As Nullable(Of Date) 
	Protected m_Cerrado As Nullable(Of Long) 
#End Region

#Region " Propiedades "
	Public Property SContPeriodoID() As Integer
        Get
            Return (m_SContPeriodoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SContPeriodoID = Value
		End Set
    End Property
	
	Public Property Periodo() As String
        Get
            Return (m_Periodo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Periodo", Value.ToString(), "Valor inv?lido para SContPeriodos.Periodo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Periodo = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SContPeriodos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SContPeriodos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property UsuarioCierre() As String
        Get
            Return (m_UsuarioCierre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCierre", Value.ToString(), "Valor inv?lido para SContPeriodos.UsuarioCierre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCierre = Value
		End Set
    End Property
	
	Public Property Fechaierre() As Nullable(Of Date)
        Get
            Return (m_Fechaierre)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fechaierre = Value
		End Set
    End Property
	
	Public Property Cerrado() As Nullable(Of Long)
        Get
            Return (m_Cerrado)
        End Get
		Set(ByVal Value As Nullable(Of Long))					
			m_Cerrado = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Periodo"
				Return	100
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "UsuarioCierre"
				Return	30
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
    ''' Salva un DataSet del tipo de la tabla SContPeriodos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SContPeriodos </param>    
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
			cmdDelete.Parameters.Add("@SContPeriodoID", SqlDbType.Int, 4, "SContPeriodoID" )
			cmdDelete.CommandText = "DELETE FROM  SContPeriodos WHERE SContPeriodoID= @SContPeriodoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Periodo", SqlDbType.VarChar, 100, "Periodo")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioCierre", SqlDbType.VarChar, 30, "UsuarioCierre")
			cmdInsert.Parameters.Add("@Fechaierre", SqlDbType.DateTime, 8, "Fechaierre")
			cmdInsert.Parameters.Add("@Cerrado", SqlDbType.BigInt, 8, "Cerrado")
			cmdInsert.CommandText = "INSERT INTO SContPeriodos ( Periodo, Activo, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, UsuarioCierre, Fechaierre, Cerrado) VALUES ( @Periodo, @Activo, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @UsuarioCierre, @Fechaierre, @Cerrado)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Periodo", SqlDbType.VarChar, 100, "Periodo")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioCierre", SqlDbType.VarChar, 30, "UsuarioCierre")
			cmdUpdate.Parameters.Add("@Fechaierre", SqlDbType.DateTime, 8, "Fechaierre")
			cmdUpdate.Parameters.Add("@Cerrado", SqlDbType.BigInt, 8, "Cerrado")
			cmdUpdate.Parameters.Add("@wSContPeriodoID", SqlDbType.Int, 4, "SContPeriodoID")
			cmdUpdate.CommandText = "UPDATE SContPeriodos SET Periodo=@Periodo, Activo=@Activo, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, UsuarioCierre=@UsuarioCierre, Fechaierre=@Fechaierre, Cerrado=@Cerrado WHERE SContPeriodoID= @wSContPeriodoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SContPeriodos")
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
    ''' Devuelve de la base de datos un objeto SContPeriodos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SContPeriodoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContPeriodos where " & " SContPeriodoID = " & p_SContPeriodoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SContPeriodoID = dr("SContPeriodoID")
				m_Periodo = IIf(IsDBNull(dr("Periodo")), Nothing, dr("Periodo"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioCierre = IIf(IsDBNull(dr("UsuarioCierre")), Nothing, dr("UsuarioCierre"))
				m_Fechaierre = IIf(IsDBNull(dr("Fechaierre")), Nothing, dr("Fechaierre"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
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
    ''' Devuelve de la base de datos un objeto SContPeriodos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContPeriodos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SContPeriodoID = dr("SContPeriodoID")
				m_Periodo = IIf(IsDBNull(dr("Periodo")), Nothing, dr("Periodo"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioCierre = IIf(IsDBNull(dr("UsuarioCierre")), Nothing, dr("UsuarioCierre"))
				m_Fechaierre = IIf(IsDBNull(dr("Fechaierre")), Nothing, dr("Fechaierre"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
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
    ''' Trae de la base de datos un conjunto de objetos SContPeriodos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SContPeriodos"

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
			ds.Tables(0).TableName = "SContPeriodos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContPeriodos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SContPeriodos"

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
			ds.Tables(0).TableName = "SContPeriodos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContPeriodos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SContPeriodos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SContPeriodos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SContPeriodos("
		sCommand &= "Periodo,"
		sCommand &= "Activo,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioCierre,"
		sCommand &= "Fechaierre,"
		sCommand &= "Cerrado) values ("		
		sCommand &= "@Periodo,"
		sCommand &= "@Activo,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioCierre,"
		sCommand &= "@Fechaierre,"
		sCommand &= "@Cerrado)"		
	
		sCommand &= " select "
		sCommand &= "@SContPeriodoID = SContPeriodoID from SContPeriodos where "		
		sCommand &= "SContPeriodoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SContPeriodoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Periodo", SqlDbType.VarChar)		
		If IsDBNull(m_Periodo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Periodo
        End If
		arParams(2) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Activo
        End If
		arParams(3) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_UsuarioCreacion
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
        End If
		arParams(5) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioModificacion
        End If
		arParams(6) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaModificacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCierre", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCierre) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCierre
        End If
		arParams(8) = New SqlParameter("@Fechaierre", SqlDbType.DateTime)		
		If IsDBNull(m_Fechaierre) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Fechaierre
        End If
		arParams(9) = New SqlParameter("@Cerrado", SqlDbType.BigInt)		
		If IsDBNull(m_Cerrado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Cerrado
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SContPeriodoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SContPeriodos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SContPeriodos set "		
		sCommand &= "Periodo = @Periodo,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioCierre = @UsuarioCierre,"
		sCommand &= "Fechaierre = @Fechaierre,"
		sCommand &= "Cerrado = @Cerrado"		
		sCommand &= " where "	
		sCommand &= "SContPeriodoID = @SContPeriodoID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SContPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_SContPeriodoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SContPeriodoID
        End If
		arParams(1) = New SqlParameter("@Periodo", SqlDbType.VarChar)		
		If IsDBNull(m_Periodo) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Periodo
        End If
		arParams(2) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Activo
        End If
		arParams(3) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_UsuarioCreacion
        End If
		arParams(4) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_FechaCreacion
        End If
		arParams(5) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_UsuarioModificacion
        End If
		arParams(6) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_FechaModificacion
        End If
		arParams(7) = New SqlParameter("@UsuarioCierre", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCierre) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_UsuarioCierre
        End If
		arParams(8) = New SqlParameter("@Fechaierre", SqlDbType.DateTime)		
		If IsDBNull(m_Fechaierre) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Fechaierre
        End If
		arParams(9) = New SqlParameter("@Cerrado", SqlDbType.BigInt)		
		If IsDBNull(m_Cerrado) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Cerrado
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
    ''' Borra un objeto SContPeriodos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContPeriodos where " & " SContPeriodoID = " & m_SContPeriodoID
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
    ''' Borra un objeto SContPeriodos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SContPeriodoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContPeriodos where " & " SContPeriodoID = " & p_SContPeriodoID
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
    ''' Borra objetos SContPeriodos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContPeriodos where " & pWhere
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
