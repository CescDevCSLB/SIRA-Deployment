Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraAsignaturasConfiguracion		

#Region " Variables Miembro " 
	Protected m_SraAsignaturasConfiguracion As Integer 
	Protected m_objAsignaturaID As Nullable(Of Integer) 
	Protected m_objParcialID As Nullable(Of Integer) 
	Protected m_objModalidadID As Nullable(Of Integer) 
	Protected m_Cualitativa As Nullable(Of Boolean) 
	Protected m_Cuantitativa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SraAsignaturasConfiguracion() As Integer
        Get
            Return (m_SraAsignaturasConfiguracion)
        End Get
		Set(ByVal Value As Integer)					
			m_SraAsignaturasConfiguracion = Value
		End Set
    End Property
	
	Public Property objAsignaturaID() As Nullable(Of Integer)
        Get
            Return (m_objAsignaturaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objAsignaturaID = Value
		End Set
    End Property
	
	Public Property objParcialID() As Nullable(Of Integer)
        Get
            Return (m_objParcialID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objParcialID = Value
		End Set
    End Property
	
	Public Property objModalidadID() As Nullable(Of Integer)
        Get
            Return (m_objModalidadID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objModalidadID = Value
		End Set
    End Property
	
	Public Property Cualitativa() As Nullable(Of Boolean)
        Get
            Return (m_Cualitativa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Cualitativa = Value
		End Set
    End Property
	
	Public Property Cuantitativa() As Nullable(Of Boolean)
        Get
            Return (m_Cuantitativa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Cuantitativa = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraAsignaturasConfiguracion.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraAsignaturasConfiguracion.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
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
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SraAsignaturasConfiguracion en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraAsignaturasConfiguracion </param>    
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
			cmdDelete.Parameters.Add("@SraAsignaturasConfiguracion", SqlDbType.Int, 4, "SraAsignaturasConfiguracion" )
			cmdDelete.CommandText = "DELETE FROM  SraAsignaturasConfiguracion WHERE SraAsignaturasConfiguracion= @SraAsignaturasConfiguracion" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
			cmdInsert.Parameters.Add("@Cualitativa", SqlDbType.Bit, 1, "Cualitativa")
			cmdInsert.Parameters.Add("@Cuantitativa", SqlDbType.Bit, 1, "Cuantitativa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SraAsignaturasConfiguracion ( objAsignaturaID, objParcialID, objModalidadID, Cualitativa, Cuantitativa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objAsignaturaID, @objParcialID, @objModalidadID, @Cualitativa, @Cuantitativa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
			cmdUpdate.Parameters.Add("@Cualitativa", SqlDbType.Bit, 1, "Cualitativa")
			cmdUpdate.Parameters.Add("@Cuantitativa", SqlDbType.Bit, 1, "Cuantitativa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSraAsignaturasConfiguracion", SqlDbType.Int, 4, "SraAsignaturasConfiguracion")
			cmdUpdate.CommandText = "UPDATE SraAsignaturasConfiguracion SET objAsignaturaID=@objAsignaturaID, objParcialID=@objParcialID, objModalidadID=@objModalidadID, Cualitativa=@Cualitativa, Cuantitativa=@Cuantitativa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SraAsignaturasConfiguracion= @wSraAsignaturasConfiguracion"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraAsignaturasConfiguracion")
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
    ''' Devuelve de la base de datos un objeto SraAsignaturasConfiguracion
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraAsignaturasConfiguracion as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraAsignaturasConfiguracion where " & " SraAsignaturasConfiguracion = " & p_SraAsignaturasConfiguracion		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraAsignaturasConfiguracion = dr("SraAsignaturasConfiguracion")
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
				m_Cualitativa = IIf(IsDBNull(dr("Cualitativa")), Nothing, dr("Cualitativa"))
				m_Cuantitativa = IIf(IsDBNull(dr("Cuantitativa")), Nothing, dr("Cuantitativa"))
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
    ''' Devuelve de la base de datos un objeto SraAsignaturasConfiguracion usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraAsignaturasConfiguracion where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraAsignaturasConfiguracion = dr("SraAsignaturasConfiguracion")
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
				m_Cualitativa = IIf(IsDBNull(dr("Cualitativa")), Nothing, dr("Cualitativa"))
				m_Cuantitativa = IIf(IsDBNull(dr("Cuantitativa")), Nothing, dr("Cuantitativa"))
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
    ''' Trae de la base de datos un conjunto de objetos SraAsignaturasConfiguracion en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraAsignaturasConfiguracion"

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
			ds.Tables(0).TableName = "SraAsignaturasConfiguracion"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraAsignaturasConfiguracion en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraAsignaturasConfiguracion"

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
			ds.Tables(0).TableName = "SraAsignaturasConfiguracion"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraAsignaturasConfiguracion en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraAsignaturasConfiguracion"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraAsignaturasConfiguracion.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraAsignaturasConfiguracion("
		sCommand &= "objAsignaturaID,"
		sCommand &= "objParcialID,"
		sCommand &= "objModalidadID,"
		sCommand &= "Cualitativa,"
		sCommand &= "Cuantitativa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objAsignaturaID,"
		sCommand &= "@objParcialID,"
		sCommand &= "@objModalidadID,"
		sCommand &= "@Cualitativa,"
		sCommand &= "@Cuantitativa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SraAsignaturasConfiguracion = SraAsignaturasConfiguracion from SraAsignaturasConfiguracion where "		
		sCommand &= "SraAsignaturasConfiguracion = SCOPE_IDENTITY()"
		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SraAsignaturasConfiguracion", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAsignaturaID
        End If
		arParams(2) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objParcialID
        End If
		arParams(3) = New SqlParameter("@objModalidadID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objModalidadID
        End If
		arParams(4) = New SqlParameter("@Cualitativa", SqlDbType.Bit)		
		If IsDBNull(m_Cualitativa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Cualitativa
        End If
		arParams(5) = New SqlParameter("@Cuantitativa", SqlDbType.Bit)		
		If IsDBNull(m_Cuantitativa) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Cuantitativa
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
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraAsignaturasConfiguracion = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraAsignaturasConfiguracion en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraAsignaturasConfiguracion set "		
		sCommand &= "objAsignaturaID = @objAsignaturaID,"
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "objModalidadID = @objModalidadID,"
		sCommand &= "Cualitativa = @Cualitativa,"
		sCommand &= "Cuantitativa = @Cuantitativa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SraAsignaturasConfiguracion = @SraAsignaturasConfiguracion"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SraAsignaturasConfiguracion", SqlDbType.Int)		
		If IsDBNull(m_SraAsignaturasConfiguracion) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraAsignaturasConfiguracion
        End If
		arParams(1) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAsignaturaID
        End If
		arParams(2) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objParcialID
        End If
		arParams(3) = New SqlParameter("@objModalidadID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objModalidadID
        End If
		arParams(4) = New SqlParameter("@Cualitativa", SqlDbType.Bit)		
		If IsDBNull(m_Cualitativa) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Cualitativa
        End If
		arParams(5) = New SqlParameter("@Cuantitativa", SqlDbType.Bit)		
		If IsDBNull(m_Cuantitativa) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Cuantitativa
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
    ''' Borra un objeto SraAsignaturasConfiguracion de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAsignaturasConfiguracion where " & " SraAsignaturasConfiguracion = " & m_SraAsignaturasConfiguracion
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
    ''' Borra un objeto SraAsignaturasConfiguracion de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraAsignaturasConfiguracion as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAsignaturasConfiguracion where " & " SraAsignaturasConfiguracion = " & p_SraAsignaturasConfiguracion
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
    ''' Borra objetos SraAsignaturasConfiguracion de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAsignaturasConfiguracion where " & pWhere
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
