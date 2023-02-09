Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraNotasReepetidas		

#Region " Variables Miembro " 
	Protected m_SraNotasID As Integer 
	Protected m_objGrupoID As Nullable(Of Integer) 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objAsignaturaID As Nullable(Of Integer) 
	Protected m_objParcialID As Nullable(Of Integer) 
	Protected m_IND1 As Nullable(Of Integer) 
	Protected m_IND2 As Nullable(Of Integer) 
	Protected m_IND3 As Nullable(Of Integer) 
	Protected m_IND4 As Nullable(Of Integer) 
	Protected m_IND5 As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SraNotasID() As Integer
        Get
            Return (m_SraNotasID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraNotasID = Value
		End Set
    End Property
	
	Public Property objGrupoID() As Nullable(Of Integer)
        Get
            Return (m_objGrupoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGrupoID = Value
		End Set
    End Property
	
	Public Property objAlumnoID() As Nullable(Of Integer)
        Get
            Return (m_objAlumnoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objAlumnoID = Value
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
	
	Public Property IND1() As Nullable(Of Integer)
        Get
            Return (m_IND1)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_IND1 = Value
		End Set
    End Property
	
	Public Property IND2() As Nullable(Of Integer)
        Get
            Return (m_IND2)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_IND2 = Value
		End Set
    End Property
	
	Public Property IND3() As Nullable(Of Integer)
        Get
            Return (m_IND3)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_IND3 = Value
		End Set
    End Property
	
	Public Property IND4() As Nullable(Of Integer)
        Get
            Return (m_IND4)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_IND4 = Value
		End Set
    End Property
	
	Public Property IND5() As Nullable(Of Integer)
        Get
            Return (m_IND5)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_IND5 = Value
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
    ''' Salva un DataSet del tipo de la tabla SraNotasReepetidas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraNotasReepetidas </param>    
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
			cmdDelete.Parameters.Add("@SraNotasID", SqlDbType.Int, 4, "SraNotasID" )
			cmdDelete.CommandText = "DELETE FROM  SraNotasReepetidas WHERE SraNotasID= @SraNotasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@SraNotasID", SqlDbType.Int, 4, "SraNotasID")
			cmdInsert.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@IND1", SqlDbType.Int, 4, "IND1")
			cmdInsert.Parameters.Add("@IND2", SqlDbType.Int, 4, "IND2")
			cmdInsert.Parameters.Add("@IND3", SqlDbType.Int, 4, "IND3")
			cmdInsert.Parameters.Add("@IND4", SqlDbType.Int, 4, "IND4")
			cmdInsert.Parameters.Add("@IND5", SqlDbType.Int, 4, "IND5")
			cmdInsert.CommandText = "INSERT INTO SraNotasReepetidas ( SraNotasID, objGrupoID, objAlumnoID, objAsignaturaID, objParcialID, IND1, IND2, IND3, IND4, IND5) VALUES ( @SraNotasID, @objGrupoID, @objAlumnoID, @objAsignaturaID, @objParcialID, @IND1, @IND2, @IND3, @IND4, @IND5)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@SraNotasID", SqlDbType.Int, 4, "SraNotasID")
			cmdUpdate.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@IND1", SqlDbType.Int, 4, "IND1")
			cmdUpdate.Parameters.Add("@IND2", SqlDbType.Int, 4, "IND2")
			cmdUpdate.Parameters.Add("@IND3", SqlDbType.Int, 4, "IND3")
			cmdUpdate.Parameters.Add("@IND4", SqlDbType.Int, 4, "IND4")
			cmdUpdate.Parameters.Add("@IND5", SqlDbType.Int, 4, "IND5")
			cmdUpdate.Parameters.Add("@wSraNotasID", SqlDbType.Int, 4, "SraNotasID")
			cmdUpdate.CommandText = "UPDATE SraNotasReepetidas SET SraNotasID=@SraNotasID, objGrupoID=@objGrupoID, objAlumnoID=@objAlumnoID, objAsignaturaID=@objAsignaturaID, objParcialID=@objParcialID, IND1=@IND1, IND2=@IND2, IND3=@IND3, IND4=@IND4, IND5=@IND5 WHERE SraNotasID= @wSraNotasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraNotasReepetidas")
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
    ''' Devuelve de la base de datos un objeto SraNotasReepetidas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotasReepetidas where " & " SraNotasID = " & p_SraNotasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraNotasID = IIf(IsDBNull(dr("SraNotasID")), Nothing, dr("SraNotasID"))
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_IND1 = IIf(IsDBNull(dr("IND1")), Nothing, dr("IND1"))
				m_IND2 = IIf(IsDBNull(dr("IND2")), Nothing, dr("IND2"))
				m_IND3 = IIf(IsDBNull(dr("IND3")), Nothing, dr("IND3"))
				m_IND4 = IIf(IsDBNull(dr("IND4")), Nothing, dr("IND4"))
				m_IND5 = IIf(IsDBNull(dr("IND5")), Nothing, dr("IND5"))
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
    ''' Devuelve de la base de datos un objeto SraNotasReepetidas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotasReepetidas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraNotasID = IIf(IsDBNull(dr("SraNotasID")), Nothing, dr("SraNotasID"))
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_IND1 = IIf(IsDBNull(dr("IND1")), Nothing, dr("IND1"))
				m_IND2 = IIf(IsDBNull(dr("IND2")), Nothing, dr("IND2"))
				m_IND3 = IIf(IsDBNull(dr("IND3")), Nothing, dr("IND3"))
				m_IND4 = IIf(IsDBNull(dr("IND4")), Nothing, dr("IND4"))
				m_IND5 = IIf(IsDBNull(dr("IND5")), Nothing, dr("IND5"))
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
    ''' Trae de la base de datos un conjunto de objetos SraNotasReepetidas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraNotasReepetidas"

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
			ds.Tables(0).TableName = "SraNotasReepetidas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotasReepetidas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraNotasReepetidas"

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
			ds.Tables(0).TableName = "SraNotasReepetidas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotasReepetidas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraNotasReepetidas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraNotasReepetidas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraNotasReepetidas("
		sCommand &= "SraNotasID,"
		sCommand &= "objGrupoID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "objAsignaturaID,"
		sCommand &= "objParcialID,"
		sCommand &= "IND1,"
		sCommand &= "IND2,"
		sCommand &= "IND3,"
		sCommand &= "IND4,"
		sCommand &= "IND5) values ("		
		sCommand &= "@SraNotasID,"
		sCommand &= "@objGrupoID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objAsignaturaID,"
		sCommand &= "@objParcialID,"
		sCommand &= "@IND1,"
		sCommand &= "@IND2,"
		sCommand &= "@IND3,"
		sCommand &= "@IND4,"
		sCommand &= "@IND5)"		
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SraNotasID", SqlDbType.Int)		
		If IsDBNull(m_SraNotasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraNotasID
        End If
		arParams(1) = New SqlParameter("@objGrupoID", SqlDbType.Int)		
		If IsDBNull(m_objGrupoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objGrupoID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objAsignaturaID
        End If
		arParams(4) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objParcialID
        End If
		arParams(5) = New SqlParameter("@IND1", SqlDbType.Int)		
		If IsDBNull(m_IND1) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_IND1
        End If
		arParams(6) = New SqlParameter("@IND2", SqlDbType.Int)		
		If IsDBNull(m_IND2) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_IND2
        End If
		arParams(7) = New SqlParameter("@IND3", SqlDbType.Int)		
		If IsDBNull(m_IND3) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_IND3
        End If
		arParams(8) = New SqlParameter("@IND4", SqlDbType.Int)		
		If IsDBNull(m_IND4) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_IND4
        End If
		arParams(9) = New SqlParameter("@IND5", SqlDbType.Int)		
		If IsDBNull(m_IND5) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_IND5
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
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraNotasReepetidas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraNotasReepetidas set "		
		sCommand &= "SraNotasID = @SraNotasID,"
		sCommand &= "objGrupoID = @objGrupoID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objAsignaturaID = @objAsignaturaID,"
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "IND1 = @IND1,"
		sCommand &= "IND2 = @IND2,"
		sCommand &= "IND3 = @IND3,"
		sCommand &= "IND4 = @IND4,"
		sCommand &= "IND5 = @IND5"		
		sCommand &= " where "	
		sCommand &= "SraNotasID = @SraNotasID"					
		
		Dim arParams(9) As SqlParameter
		arParams(0) = New SqlParameter("@SraNotasID", SqlDbType.Int)		
		If IsDBNull(m_SraNotasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraNotasID
        End If
		arParams(1) = New SqlParameter("@objGrupoID", SqlDbType.Int)		
		If IsDBNull(m_objGrupoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objGrupoID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objAsignaturaID
        End If
		arParams(4) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objParcialID
        End If
		arParams(5) = New SqlParameter("@IND1", SqlDbType.Int)		
		If IsDBNull(m_IND1) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_IND1
        End If
		arParams(6) = New SqlParameter("@IND2", SqlDbType.Int)		
		If IsDBNull(m_IND2) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_IND2
        End If
		arParams(7) = New SqlParameter("@IND3", SqlDbType.Int)		
		If IsDBNull(m_IND3) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_IND3
        End If
		arParams(8) = New SqlParameter("@IND4", SqlDbType.Int)		
		If IsDBNull(m_IND4) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_IND4
        End If
		arParams(9) = New SqlParameter("@IND5", SqlDbType.Int)		
		If IsDBNull(m_IND5) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_IND5
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
    ''' Borra un objeto SraNotasReepetidas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasReepetidas where " & " SraNotasID = " & m_SraNotasID
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
    ''' Borra un objeto SraNotasReepetidas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasReepetidas where " & " SraNotasID = " & p_SraNotasID
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
    ''' Borra objetos SraNotasReepetidas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasReepetidas where " & pWhere
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
