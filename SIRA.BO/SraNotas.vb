Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraNotas		

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
	Protected m_Promedio As Nullable(Of Integer) 
	Protected m_PromedioC As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Cantidad As Nullable(Of Integer) 
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
	
	Public Property Promedio() As Nullable(Of Integer)
        Get
            Return (m_Promedio)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Promedio = Value
		End Set
    End Property
	
	Public Property PromedioC() As String
        Get
            Return (m_PromedioC)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("PromedioC", Value.ToString(), "Valor inv?lido para SraNotas.PromedioC. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_PromedioC = Value
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraNotas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraNotas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property Cantidad() As Nullable(Of Integer)
        Get
            Return (m_Cantidad)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Cantidad = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "PromedioC"
				Return	2
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
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
    ''' Salva un DataSet del tipo de la tabla SraNotas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraNotas </param>    
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
			cmdDelete.CommandText = "DELETE FROM  SraNotas WHERE SraNotasID= @SraNotasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@IND1", SqlDbType.Int, 4, "IND1")
			cmdInsert.Parameters.Add("@IND2", SqlDbType.Int, 4, "IND2")
			cmdInsert.Parameters.Add("@IND3", SqlDbType.Int, 4, "IND3")
			cmdInsert.Parameters.Add("@IND4", SqlDbType.Int, 4, "IND4")
			cmdInsert.Parameters.Add("@IND5", SqlDbType.Int, 4, "IND5")
			cmdInsert.Parameters.Add("@Promedio", SqlDbType.Int, 4, "Promedio")
			cmdInsert.Parameters.Add("@PromedioC", SqlDbType.VarChar, 2, "PromedioC")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdInsert.CommandText = "INSERT INTO SraNotas ( objGrupoID, objAlumnoID, objAsignaturaID, objParcialID, IND1, IND2, IND3, IND4, IND5, Promedio, PromedioC, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Cantidad) VALUES ( @objGrupoID, @objAlumnoID, @objAsignaturaID, @objParcialID, @IND1, @IND2, @IND3, @IND4, @IND5, @Promedio, @PromedioC, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Cantidad)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@IND1", SqlDbType.Int, 4, "IND1")
			cmdUpdate.Parameters.Add("@IND2", SqlDbType.Int, 4, "IND2")
			cmdUpdate.Parameters.Add("@IND3", SqlDbType.Int, 4, "IND3")
			cmdUpdate.Parameters.Add("@IND4", SqlDbType.Int, 4, "IND4")
			cmdUpdate.Parameters.Add("@IND5", SqlDbType.Int, 4, "IND5")
			cmdUpdate.Parameters.Add("@Promedio", SqlDbType.Int, 4, "Promedio")
			cmdUpdate.Parameters.Add("@PromedioC", SqlDbType.VarChar, 2, "PromedioC")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Cantidad", SqlDbType.Int, 4, "Cantidad")
			cmdUpdate.Parameters.Add("@wSraNotasID", SqlDbType.Int, 4, "SraNotasID")
			cmdUpdate.CommandText = "UPDATE SraNotas SET objGrupoID=@objGrupoID, objAlumnoID=@objAlumnoID, objAsignaturaID=@objAsignaturaID, objParcialID=@objParcialID, IND1=@IND1, IND2=@IND2, IND3=@IND3, IND4=@IND4, IND5=@IND5, Promedio=@Promedio, PromedioC=@PromedioC, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Cantidad=@Cantidad WHERE SraNotasID= @wSraNotasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraNotas")
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
    ''' Devuelve de la base de datos un objeto SraNotas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotas where " & " SraNotasID = " & p_SraNotasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraNotasID = dr("SraNotasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_IND1 = IIf(IsDBNull(dr("IND1")), Nothing, dr("IND1"))
				m_IND2 = IIf(IsDBNull(dr("IND2")), Nothing, dr("IND2"))
				m_IND3 = IIf(IsDBNull(dr("IND3")), Nothing, dr("IND3"))
				m_IND4 = IIf(IsDBNull(dr("IND4")), Nothing, dr("IND4"))
				m_IND5 = IIf(IsDBNull(dr("IND5")), Nothing, dr("IND5"))
				m_Promedio = IIf(IsDBNull(dr("Promedio")), Nothing, dr("Promedio"))
				m_PromedioC = IIf(IsDBNull(dr("PromedioC")), Nothing, dr("PromedioC"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))
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
    ''' Devuelve de la base de datos un objeto SraNotas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraNotasID = dr("SraNotasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_IND1 = IIf(IsDBNull(dr("IND1")), Nothing, dr("IND1"))
				m_IND2 = IIf(IsDBNull(dr("IND2")), Nothing, dr("IND2"))
				m_IND3 = IIf(IsDBNull(dr("IND3")), Nothing, dr("IND3"))
				m_IND4 = IIf(IsDBNull(dr("IND4")), Nothing, dr("IND4"))
				m_IND5 = IIf(IsDBNull(dr("IND5")), Nothing, dr("IND5"))
				m_Promedio = IIf(IsDBNull(dr("Promedio")), Nothing, dr("Promedio"))
				m_PromedioC = IIf(IsDBNull(dr("PromedioC")), Nothing, dr("PromedioC"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Cantidad = IIf(IsDBNull(dr("Cantidad")), Nothing, dr("Cantidad"))
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
    ''' Trae de la base de datos un conjunto de objetos SraNotas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraNotas"

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
			ds.Tables(0).TableName = "SraNotas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraNotas"

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
			ds.Tables(0).TableName = "SraNotas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraNotas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraNotas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraNotas("
		sCommand &= "objGrupoID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "objAsignaturaID,"
		sCommand &= "objParcialID,"
		sCommand &= "IND1,"
		sCommand &= "IND2,"
		sCommand &= "IND3,"
		sCommand &= "IND4,"
		sCommand &= "IND5,"
		sCommand &= "Promedio,"
		sCommand &= "PromedioC,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Cantidad) values ("		
		sCommand &= "@objGrupoID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objAsignaturaID,"
		sCommand &= "@objParcialID,"
		sCommand &= "@IND1,"
		sCommand &= "@IND2,"
		sCommand &= "@IND3,"
		sCommand &= "@IND4,"
		sCommand &= "@IND5,"
		sCommand &= "@Promedio,"
		sCommand &= "@PromedioC,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Cantidad)"		
	
		sCommand &= " select "
		sCommand &= "@SraNotasID = SraNotasID from SraNotas where "		
		sCommand &= "SraNotasID = SCOPE_IDENTITY()"
		
		
		Dim arParams(16) As SqlParameter
		arParams(0) = New SqlParameter("@SraNotasID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
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
		arParams(10) = New SqlParameter("@Promedio", SqlDbType.Int)		
		If IsDBNull(m_Promedio) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Promedio
        End If
		arParams(11) = New SqlParameter("@PromedioC", SqlDbType.VarChar)		
		If IsDBNull(m_PromedioC) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_PromedioC
        End If
		arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If
		arParams(16) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Cantidad
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraNotasID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraNotas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraNotas set "		
		sCommand &= "objGrupoID = @objGrupoID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objAsignaturaID = @objAsignaturaID,"
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "IND1 = @IND1,"
		sCommand &= "IND2 = @IND2,"
		sCommand &= "IND3 = @IND3,"
		sCommand &= "IND4 = @IND4,"
		sCommand &= "IND5 = @IND5,"
		sCommand &= "Promedio = @Promedio,"
		sCommand &= "PromedioC = @PromedioC,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Cantidad = @Cantidad"		
		sCommand &= " where "	
		sCommand &= "SraNotasID = @SraNotasID"					
		
		Dim arParams(16) As SqlParameter
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
		arParams(10) = New SqlParameter("@Promedio", SqlDbType.Int)		
		If IsDBNull(m_Promedio) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Promedio
        End If
		arParams(11) = New SqlParameter("@PromedioC", SqlDbType.VarChar)		
		If IsDBNull(m_PromedioC) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_PromedioC
        End If
		arParams(12) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaCreacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaModificacion
        End If
		arParams(15) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioModificacion
        End If
		arParams(16) = New SqlParameter("@Cantidad", SqlDbType.Int)		
		If IsDBNull(m_Cantidad) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Cantidad
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
    ''' Borra un objeto SraNotas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotas where " & " SraNotasID = " & m_SraNotasID
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
    ''' Borra un objeto SraNotas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotas where " & " SraNotasID = " & p_SraNotasID
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
    ''' Borra objetos SraNotas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotas where " & pWhere
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
