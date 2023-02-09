Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraNotasEvidencias		

#Region " Variables Miembro " 
	Protected m_SraNotasEvidenciasID As Integer 
	Protected m_objGrupoID As Nullable(Of Integer) 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objCategoriaID As Nullable(Of Integer) 
	Protected m_objEvidenciaDetalleID As Nullable(Of Integer) 
	Protected m_objParcialID As Nullable(Of Integer) 
	Protected m_Nota As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SraNotasEvidenciasID() As Integer
        Get
            Return (m_SraNotasEvidenciasID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraNotasEvidenciasID = Value
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
	
	Public Property objCategoriaID() As Nullable(Of Integer)
        Get
            Return (m_objCategoriaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCategoriaID = Value
		End Set
    End Property
	
	Public Property objEvidenciaDetalleID() As Nullable(Of Integer)
        Get
            Return (m_objEvidenciaDetalleID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEvidenciaDetalleID = Value
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
	
	Public Property Nota() As String
        Get
            Return (m_Nota)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 4 Then
					Throw New ArgumentOutOfRangeException("Nota", Value.ToString(), "Valor inv?lido para SraNotasEvidencias.Nota. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (4).")
				End If
			End If
			m_Nota = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraNotasEvidencias.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraNotasEvidencias.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Nota"
				Return	4
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
    ''' Salva un DataSet del tipo de la tabla SraNotasEvidencias en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraNotasEvidencias </param>    
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
			cmdDelete.Parameters.Add("@SraNotasEvidenciasID", SqlDbType.Int, 4, "SraNotasEvidenciasID" )
			cmdDelete.CommandText = "DELETE FROM  SraNotasEvidencias WHERE SraNotasEvidenciasID= @SraNotasEvidenciasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdInsert.Parameters.Add("@objEvidenciaDetalleID", SqlDbType.Int, 4, "objEvidenciaDetalleID")
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@Nota", SqlDbType.VarChar, 4, "Nota")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SraNotasEvidencias ( objGrupoID, objAlumnoID, objCategoriaID, objEvidenciaDetalleID, objParcialID, Nota, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objGrupoID, @objAlumnoID, @objCategoriaID, @objEvidenciaDetalleID, @objParcialID, @Nota, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objCategoriaID", SqlDbType.Int, 4, "objCategoriaID")
			cmdUpdate.Parameters.Add("@objEvidenciaDetalleID", SqlDbType.Int, 4, "objEvidenciaDetalleID")
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@Nota", SqlDbType.VarChar, 4, "Nota")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSraNotasEvidenciasID", SqlDbType.Int, 4, "SraNotasEvidenciasID")
			cmdUpdate.CommandText = "UPDATE SraNotasEvidencias SET objGrupoID=@objGrupoID, objAlumnoID=@objAlumnoID, objCategoriaID=@objCategoriaID, objEvidenciaDetalleID=@objEvidenciaDetalleID, objParcialID=@objParcialID, Nota=@Nota, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SraNotasEvidenciasID= @wSraNotasEvidenciasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraNotasEvidencias")
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
    ''' Devuelve de la base de datos un objeto SraNotasEvidencias
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraNotasEvidenciasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotasEvidencias where " & " SraNotasEvidenciasID = " & p_SraNotasEvidenciasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraNotasEvidenciasID = dr("SraNotasEvidenciasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))
				m_objEvidenciaDetalleID = IIf(IsDBNull(dr("objEvidenciaDetalleID")), Nothing, dr("objEvidenciaDetalleID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_Nota = IIf(IsDBNull(dr("Nota")), Nothing, dr("Nota"))
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
    ''' Devuelve de la base de datos un objeto SraNotasEvidencias usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraNotasEvidencias where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraNotasEvidenciasID = dr("SraNotasEvidenciasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objCategoriaID = IIf(IsDBNull(dr("objCategoriaID")), Nothing, dr("objCategoriaID"))
				m_objEvidenciaDetalleID = IIf(IsDBNull(dr("objEvidenciaDetalleID")), Nothing, dr("objEvidenciaDetalleID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_Nota = IIf(IsDBNull(dr("Nota")), Nothing, dr("Nota"))
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
    ''' Trae de la base de datos un conjunto de objetos SraNotasEvidencias en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraNotasEvidencias"

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
			ds.Tables(0).TableName = "SraNotasEvidencias"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotasEvidencias en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraNotasEvidencias"

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
			ds.Tables(0).TableName = "SraNotasEvidencias"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraNotasEvidencias en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraNotasEvidencias"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraNotasEvidencias.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraNotasEvidencias("
		sCommand &= "objGrupoID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "objCategoriaID,"
		sCommand &= "objEvidenciaDetalleID,"
		sCommand &= "objParcialID,"
		sCommand &= "Nota,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objGrupoID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objCategoriaID,"
		sCommand &= "@objEvidenciaDetalleID,"
		sCommand &= "@objParcialID,"
		sCommand &= "@Nota,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SraNotasEvidenciasID = SraNotasEvidenciasID from SraNotasEvidencias where "		
		sCommand &= "SraNotasEvidenciasID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SraNotasEvidenciasID", SqlDbType.Int)		
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
		arParams(3) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCategoriaID
        End If
		arParams(4) = New SqlParameter("@objEvidenciaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objEvidenciaDetalleID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEvidenciaDetalleID
        End If
		arParams(5) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objParcialID
        End If
		arParams(6) = New SqlParameter("@Nota", SqlDbType.VarChar)		
		If IsDBNull(m_Nota) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Nota
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
			
			m_SraNotasEvidenciasID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraNotasEvidencias en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraNotasEvidencias set "		
		sCommand &= "objGrupoID = @objGrupoID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objCategoriaID = @objCategoriaID,"
		sCommand &= "objEvidenciaDetalleID = @objEvidenciaDetalleID,"
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "Nota = @Nota,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SraNotasEvidenciasID = @SraNotasEvidenciasID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SraNotasEvidenciasID", SqlDbType.Int)		
		If IsDBNull(m_SraNotasEvidenciasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraNotasEvidenciasID
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
		arParams(3) = New SqlParameter("@objCategoriaID", SqlDbType.Int)		
		If IsDBNull(m_objCategoriaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCategoriaID
        End If
		arParams(4) = New SqlParameter("@objEvidenciaDetalleID", SqlDbType.Int)		
		If IsDBNull(m_objEvidenciaDetalleID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEvidenciaDetalleID
        End If
		arParams(5) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objParcialID
        End If
		arParams(6) = New SqlParameter("@Nota", SqlDbType.VarChar)		
		If IsDBNull(m_Nota) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Nota
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
    ''' Borra un objeto SraNotasEvidencias de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasEvidencias where " & " SraNotasEvidenciasID = " & m_SraNotasEvidenciasID
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
    ''' Borra un objeto SraNotasEvidencias de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraNotasEvidenciasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasEvidencias where " & " SraNotasEvidenciasID = " & p_SraNotasEvidenciasID
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
    ''' Borra objetos SraNotasEvidencias de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraNotasEvidencias where " & pWhere
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
