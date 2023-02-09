Imports DAL
Imports System.Data.SqlClient

Partial Public Class ScontMesCerrado		

#Region " Variables Miembro " 
	Protected m_ScontMesCerradoID As Integer 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_Mes As Nullable(Of Integer) 
	Protected m_Cerrado As Nullable(Of Boolean) 
	Protected m_Mayorizado As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaCierre As Nullable(Of Date) 
	Protected m_UsuarioCierre As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScontMesCerradoID() As Integer
        Get
            Return (m_ScontMesCerradoID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScontMesCerradoID = Value
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
	
	Public Property Mes() As Nullable(Of Integer)
        Get
            Return (m_Mes)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Mes = Value
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
	
	Public Property Mayorizado() As Nullable(Of Boolean)
        Get
            Return (m_Mayorizado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Mayorizado = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScontMesCerrado.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScontMesCerrado.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property FechaCierre() As Nullable(Of Date)
        Get
            Return (m_FechaCierre)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaCierre = Value
		End Set
    End Property
	
	Public Property UsuarioCierre() As String
        Get
            Return (m_UsuarioCierre)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCierre", Value.ToString(), "Valor inv?lido para ScontMesCerrado.UsuarioCierre. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCierre = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "UsuarioCierre"
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
    ''' Salva un DataSet del tipo de la tabla ScontMesCerrado en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScontMesCerrado </param>    
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
			cmdDelete.Parameters.Add("@ScontMesCerradoID", SqlDbType.Int, 4, "ScontMesCerradoID" )
			cmdDelete.CommandText = "DELETE FROM  ScontMesCerrado WHERE ScontMesCerradoID= @ScontMesCerradoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdInsert.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdInsert.Parameters.Add("@Mayorizado", SqlDbType.Bit, 1, "Mayorizado")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaCierre", SqlDbType.DateTime, 8, "FechaCierre")
			cmdInsert.Parameters.Add("@UsuarioCierre", SqlDbType.VarChar, 50, "UsuarioCierre")
			cmdInsert.CommandText = "INSERT INTO ScontMesCerrado ( objPeriodoID, Mes, Cerrado, Mayorizado, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, FechaCierre, UsuarioCierre) VALUES ( @objPeriodoID, @Mes, @Cerrado, @Mayorizado, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @FechaCierre, @UsuarioCierre)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdUpdate.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdUpdate.Parameters.Add("@Mayorizado", SqlDbType.Bit, 1, "Mayorizado")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaCierre", SqlDbType.DateTime, 8, "FechaCierre")
			cmdUpdate.Parameters.Add("@UsuarioCierre", SqlDbType.VarChar, 50, "UsuarioCierre")
			cmdUpdate.Parameters.Add("@wScontMesCerradoID", SqlDbType.Int, 4, "ScontMesCerradoID")
			cmdUpdate.CommandText = "UPDATE ScontMesCerrado SET objPeriodoID=@objPeriodoID, Mes=@Mes, Cerrado=@Cerrado, Mayorizado=@Mayorizado, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, FechaCierre=@FechaCierre, UsuarioCierre=@UsuarioCierre WHERE ScontMesCerradoID= @wScontMesCerradoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScontMesCerrado")
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
    ''' Devuelve de la base de datos un objeto ScontMesCerrado
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScontMesCerradoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontMesCerrado where " & " ScontMesCerradoID = " & p_ScontMesCerradoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ScontMesCerradoID = dr("ScontMesCerradoID")
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Mayorizado = IIf(IsDBNull(dr("Mayorizado")), Nothing, dr("Mayorizado"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaCierre = IIf(IsDBNull(dr("FechaCierre")), Nothing, dr("FechaCierre"))
				m_UsuarioCierre = IIf(IsDBNull(dr("UsuarioCierre")), Nothing, dr("UsuarioCierre"))
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
    ''' Devuelve de la base de datos un objeto ScontMesCerrado usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontMesCerrado where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ScontMesCerradoID = dr("ScontMesCerradoID")
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Mayorizado = IIf(IsDBNull(dr("Mayorizado")), Nothing, dr("Mayorizado"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaCierre = IIf(IsDBNull(dr("FechaCierre")), Nothing, dr("FechaCierre"))
				m_UsuarioCierre = IIf(IsDBNull(dr("UsuarioCierre")), Nothing, dr("UsuarioCierre"))
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
    ''' Trae de la base de datos un conjunto de objetos ScontMesCerrado en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScontMesCerrado"

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
			ds.Tables(0).TableName = "ScontMesCerrado"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontMesCerrado en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScontMesCerrado"

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
			ds.Tables(0).TableName = "ScontMesCerrado"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontMesCerrado en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScontMesCerrado"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScontMesCerrado.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScontMesCerrado("
		sCommand &= "objPeriodoID,"
		sCommand &= "Mes,"
		sCommand &= "Cerrado,"
		sCommand &= "Mayorizado,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaCierre,"
		sCommand &= "UsuarioCierre) values ("		
		sCommand &= "@objPeriodoID,"
		sCommand &= "@Mes,"
		sCommand &= "@Cerrado,"
		sCommand &= "@Mayorizado,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaCierre,"
		sCommand &= "@UsuarioCierre)"		
	
		sCommand &= " select "
		sCommand &= "@ScontMesCerradoID = ScontMesCerradoID from ScontMesCerrado where "		
		sCommand &= "ScontMesCerradoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontMesCerradoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPeriodoID
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cerrado
        End If
		arParams(4) = New SqlParameter("@Mayorizado", SqlDbType.Bit)		
		If IsDBNull(m_Mayorizado) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Mayorizado
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
		arParams(9) = New SqlParameter("@FechaCierre", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCierre) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCierre
        End If
		arParams(10) = New SqlParameter("@UsuarioCierre", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCierre) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCierre
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ScontMesCerradoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScontMesCerrado en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScontMesCerrado set "		
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "Mes = @Mes,"
		sCommand &= "Cerrado = @Cerrado,"
		sCommand &= "Mayorizado = @Mayorizado,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaCierre = @FechaCierre,"
		sCommand &= "UsuarioCierre = @UsuarioCierre"		
		sCommand &= " where "	
		sCommand &= "ScontMesCerradoID = @ScontMesCerradoID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontMesCerradoID", SqlDbType.Int)		
		If IsDBNull(m_ScontMesCerradoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScontMesCerradoID
        End If
		arParams(1) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPeriodoID
        End If
		arParams(2) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Mes
        End If
		arParams(3) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Cerrado
        End If
		arParams(4) = New SqlParameter("@Mayorizado", SqlDbType.Bit)		
		If IsDBNull(m_Mayorizado) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Mayorizado
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
		arParams(9) = New SqlParameter("@FechaCierre", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCierre) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaCierre
        End If
		arParams(10) = New SqlParameter("@UsuarioCierre", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCierre) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCierre
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
    ''' Borra un objeto ScontMesCerrado de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontMesCerrado where " & " ScontMesCerradoID = " & m_ScontMesCerradoID
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
    ''' Borra un objeto ScontMesCerrado de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScontMesCerradoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontMesCerrado where " & " ScontMesCerradoID = " & p_ScontMesCerradoID
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
    ''' Borra objetos ScontMesCerrado de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontMesCerrado where " & pWhere
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
