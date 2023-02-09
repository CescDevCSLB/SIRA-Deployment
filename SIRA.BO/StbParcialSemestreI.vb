Imports DAL
Imports System.Data.SqlClient

Partial Public Class StbParcialSemestreI		

#Region " Variables Miembro " 
	Protected m_StbParcialSemestreID As Integer 
	Protected m_objParcialID As Nullable(Of Integer) 
	Protected m_objSemestreID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property StbParcialSemestreID() As Integer
        Get
            Return (m_StbParcialSemestreID)
        End Get
		Set(ByVal Value As Integer)					
			m_StbParcialSemestreID = Value
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
	
	Public Property objSemestreID() As Nullable(Of Integer)
        Get
            Return (m_objSemestreID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSemestreID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
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
    ''' Salva un DataSet del tipo de la tabla StbParcialSemestreI en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla StbParcialSemestreI </param>    
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
			cmdDelete.Parameters.Add("@StbParcialSemestreID", SqlDbType.Int, 4, "StbParcialSemestreID" )
			cmdDelete.CommandText = "DELETE FROM  StbParcialSemestreI WHERE StbParcialSemestreID= @StbParcialSemestreID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@objSemestreID", SqlDbType.Int, 4, "objSemestreID")
			cmdInsert.CommandText = "INSERT INTO StbParcialSemestreI ( objParcialID, objSemestreID) VALUES ( @objParcialID, @objSemestreID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@objSemestreID", SqlDbType.Int, 4, "objSemestreID")
			cmdUpdate.Parameters.Add("@wStbParcialSemestreID", SqlDbType.Int, 4, "StbParcialSemestreID")
			cmdUpdate.CommandText = "UPDATE StbParcialSemestreI SET objParcialID=@objParcialID, objSemestreID=@objSemestreID WHERE StbParcialSemestreID= @wStbParcialSemestreID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "StbParcialSemestreI")
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
    ''' Devuelve de la base de datos un objeto StbParcialSemestreI
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_StbParcialSemestreID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbParcialSemestreI where " & " StbParcialSemestreID = " & p_StbParcialSemestreID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_StbParcialSemestreID = dr("StbParcialSemestreID")
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objSemestreID = IIf(IsDBNull(dr("objSemestreID")), Nothing, dr("objSemestreID"))
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
    ''' Devuelve de la base de datos un objeto StbParcialSemestreI usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from StbParcialSemestreI where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_StbParcialSemestreID = dr("StbParcialSemestreID")
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objSemestreID = IIf(IsDBNull(dr("objSemestreID")), Nothing, dr("objSemestreID"))
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
    ''' Trae de la base de datos un conjunto de objetos StbParcialSemestreI en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from StbParcialSemestreI"

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
			ds.Tables(0).TableName = "StbParcialSemestreI"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbParcialSemestreI en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from StbParcialSemestreI"

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
			ds.Tables(0).TableName = "StbParcialSemestreI"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos StbParcialSemestreI en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from StbParcialSemestreI"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase StbParcialSemestreI.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into StbParcialSemestreI("
		sCommand &= "objParcialID,"
		sCommand &= "objSemestreID) values ("		
		sCommand &= "@objParcialID,"
		sCommand &= "@objSemestreID)"		
	
		sCommand &= " select "
		sCommand &= "@StbParcialSemestreID = StbParcialSemestreID from StbParcialSemestreI where "		
		sCommand &= "StbParcialSemestreID = SCOPE_IDENTITY()"
		
		
		Dim arParams(2) As SqlParameter
		arParams(0) = New SqlParameter("@StbParcialSemestreID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objParcialID
        End If
		arParams(2) = New SqlParameter("@objSemestreID", SqlDbType.Int)		
		If IsDBNull(m_objSemestreID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSemestreID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_StbParcialSemestreID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto StbParcialSemestreI en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update StbParcialSemestreI set "		
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "objSemestreID = @objSemestreID"		
		sCommand &= " where "	
		sCommand &= "StbParcialSemestreID = @StbParcialSemestreID"					
		
		Dim arParams(2) As SqlParameter
		arParams(0) = New SqlParameter("@StbParcialSemestreID", SqlDbType.Int)		
		If IsDBNull(m_StbParcialSemestreID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_StbParcialSemestreID
        End If
		arParams(1) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objParcialID
        End If
		arParams(2) = New SqlParameter("@objSemestreID", SqlDbType.Int)		
		If IsDBNull(m_objSemestreID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSemestreID
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
    ''' Borra un objeto StbParcialSemestreI de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbParcialSemestreI where " & " StbParcialSemestreID = " & m_StbParcialSemestreID
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
    ''' Borra un objeto StbParcialSemestreI de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_StbParcialSemestreID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbParcialSemestreI where " & " StbParcialSemestreID = " & p_StbParcialSemestreID
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
    ''' Borra objetos StbParcialSemestreI de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from StbParcialSemestreI where " & pWhere
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
