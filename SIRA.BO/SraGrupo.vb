Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraGrupo		

#Region " Variables Miembro " 
	Protected m_SraGrupoID As Integer 
	Protected m_objGradoID As Integer 
	Protected m_objSeccionID As Integer 
	Protected m_objPeriodoID As Integer 
	Protected m_objGuiaID As Nullable(Of Integer) 
	Protected m_objModalidadID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_EvaluacionCualitativa As Nullable(Of Boolean) 
	Protected m_EvaluacionCuantitativa As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SraGrupoID() As Integer
        Get
            Return (m_SraGrupoID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraGrupoID = Value
		End Set
    End Property
	
	Public Property objGradoID() As Integer
        Get
            Return (m_objGradoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objGradoID = Value
		End Set
    End Property
	
	Public Property objSeccionID() As Integer
        Get
            Return (m_objSeccionID)
        End Get
		Set(ByVal Value As Integer)					
			m_objSeccionID = Value
		End Set
    End Property
	
	Public Property objPeriodoID() As Integer
        Get
            Return (m_objPeriodoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objPeriodoID = Value
		End Set
    End Property
	
	Public Property objGuiaID() As Nullable(Of Integer)
        Get
            Return (m_objGuiaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGuiaID = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraGrupo.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraGrupo.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property Activo() As Nullable(Of Boolean)
        Get
            Return (m_Activo)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Activo = Value
		End Set
    End Property
	
	Public Property EvaluacionCualitativa() As Nullable(Of Boolean)
        Get
            Return (m_EvaluacionCualitativa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_EvaluacionCualitativa = Value
		End Set
    End Property
	
	Public Property EvaluacionCuantitativa() As Nullable(Of Boolean)
        Get
            Return (m_EvaluacionCuantitativa)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_EvaluacionCuantitativa = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
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
    ''' Salva un DataSet del tipo de la tabla SraGrupo en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraGrupo </param>    
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
			cmdDelete.Parameters.Add("@SraGrupoID", SqlDbType.Int, 4, "SraGrupoID" )
			cmdDelete.CommandText = "DELETE FROM  SraGrupo WHERE SraGrupoID= @SraGrupoID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
			cmdInsert.Parameters.Add("@objSeccionID", SqlDbType.Int, 4, "objSeccionID")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@objGuiaID", SqlDbType.Int, 4, "objGuiaID")
			cmdInsert.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@EvaluacionCualitativa", SqlDbType.Bit, 1, "EvaluacionCualitativa")
			cmdInsert.Parameters.Add("@EvaluacionCuantitativa", SqlDbType.Bit, 1, "EvaluacionCuantitativa")
			cmdInsert.CommandText = "INSERT INTO SraGrupo ( objGradoID, objSeccionID, objPeriodoID, objGuiaID, objModalidadID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, Activo, EvaluacionCualitativa, EvaluacionCuantitativa) VALUES ( @objGradoID, @objSeccionID, @objPeriodoID, @objGuiaID, @objModalidadID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @Activo, @EvaluacionCualitativa, @EvaluacionCuantitativa)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
			cmdUpdate.Parameters.Add("@objSeccionID", SqlDbType.Int, 4, "objSeccionID")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@objGuiaID", SqlDbType.Int, 4, "objGuiaID")
			cmdUpdate.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@EvaluacionCualitativa", SqlDbType.Bit, 1, "EvaluacionCualitativa")
			cmdUpdate.Parameters.Add("@EvaluacionCuantitativa", SqlDbType.Bit, 1, "EvaluacionCuantitativa")
			cmdUpdate.Parameters.Add("@wSraGrupoID", SqlDbType.Int, 4, "SraGrupoID")
			cmdUpdate.CommandText = "UPDATE SraGrupo SET objGradoID=@objGradoID, objSeccionID=@objSeccionID, objPeriodoID=@objPeriodoID, objGuiaID=@objGuiaID, objModalidadID=@objModalidadID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, Activo=@Activo, EvaluacionCualitativa=@EvaluacionCualitativa, EvaluacionCuantitativa=@EvaluacionCuantitativa WHERE SraGrupoID= @wSraGrupoID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraGrupo")
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
    ''' Devuelve de la base de datos un objeto SraGrupo
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraGrupoID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraGrupo where " & " SraGrupoID = " & p_SraGrupoID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraGrupoID = dr("SraGrupoID")
				m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
				m_objSeccionID = IIf(IsDBNull(dr("objSeccionID")), Nothing, dr("objSeccionID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objGuiaID = IIf(IsDBNull(dr("objGuiaID")), Nothing, dr("objGuiaID"))
				m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_EvaluacionCualitativa = IIf(IsDBNull(dr("EvaluacionCualitativa")), Nothing, dr("EvaluacionCualitativa"))
				m_EvaluacionCuantitativa = IIf(IsDBNull(dr("EvaluacionCuantitativa")), Nothing, dr("EvaluacionCuantitativa"))
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
    ''' Devuelve de la base de datos un objeto SraGrupo usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraGrupo where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraGrupoID = dr("SraGrupoID")
				m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
				m_objSeccionID = IIf(IsDBNull(dr("objSeccionID")), Nothing, dr("objSeccionID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objGuiaID = IIf(IsDBNull(dr("objGuiaID")), Nothing, dr("objGuiaID"))
				m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_EvaluacionCualitativa = IIf(IsDBNull(dr("EvaluacionCualitativa")), Nothing, dr("EvaluacionCualitativa"))
				m_EvaluacionCuantitativa = IIf(IsDBNull(dr("EvaluacionCuantitativa")), Nothing, dr("EvaluacionCuantitativa"))
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
    ''' Trae de la base de datos un conjunto de objetos SraGrupo en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraGrupo"

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
			ds.Tables(0).TableName = "SraGrupo"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraGrupo en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraGrupo"

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
			ds.Tables(0).TableName = "SraGrupo"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraGrupo en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraGrupo"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraGrupo.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraGrupo("
		sCommand &= "objGradoID,"
		sCommand &= "objSeccionID,"
		sCommand &= "objPeriodoID,"
		sCommand &= "objGuiaID,"
		sCommand &= "objModalidadID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "Activo,"
		sCommand &= "EvaluacionCualitativa,"
		sCommand &= "EvaluacionCuantitativa) values ("		
		sCommand &= "@objGradoID,"
		sCommand &= "@objSeccionID,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@objGuiaID,"
		sCommand &= "@objModalidadID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@Activo,"
		sCommand &= "@EvaluacionCualitativa,"
		sCommand &= "@EvaluacionCuantitativa)"		
	
		sCommand &= " select "
		sCommand &= "@SraGrupoID = SraGrupoID from SraGrupo where "		
		sCommand &= "SraGrupoID = SCOPE_IDENTITY()"
		
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SraGrupoID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objGradoID", SqlDbType.Int)		
		If IsDBNull(m_objGradoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objGradoID
        End If
		arParams(2) = New SqlParameter("@objSeccionID", SqlDbType.Int)		
		If IsDBNull(m_objSeccionID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSeccionID
        End If
		arParams(3) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objPeriodoID
        End If
		arParams(4) = New SqlParameter("@objGuiaID", SqlDbType.Int)		
		If IsDBNull(m_objGuiaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objGuiaID
        End If
		arParams(5) = New SqlParameter("@objModalidadID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objModalidadID
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Activo
        End If
		arParams(11) = New SqlParameter("@EvaluacionCualitativa", SqlDbType.Bit)		
		If IsDBNull(m_EvaluacionCualitativa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_EvaluacionCualitativa
        End If
		arParams(12) = New SqlParameter("@EvaluacionCuantitativa", SqlDbType.Bit)		
		If IsDBNull(m_EvaluacionCuantitativa) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_EvaluacionCuantitativa
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraGrupoID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraGrupo en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraGrupo set "		
		sCommand &= "objGradoID = @objGradoID,"
		sCommand &= "objSeccionID = @objSeccionID,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "objGuiaID = @objGuiaID,"
		sCommand &= "objModalidadID = @objModalidadID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "EvaluacionCualitativa = @EvaluacionCualitativa,"
		sCommand &= "EvaluacionCuantitativa = @EvaluacionCuantitativa"		
		sCommand &= " where "	
		sCommand &= "SraGrupoID = @SraGrupoID"					
		
		Dim arParams(12) As SqlParameter
		arParams(0) = New SqlParameter("@SraGrupoID", SqlDbType.Int)		
		If IsDBNull(m_SraGrupoID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraGrupoID
        End If
		arParams(1) = New SqlParameter("@objGradoID", SqlDbType.Int)		
		If IsDBNull(m_objGradoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objGradoID
        End If
		arParams(2) = New SqlParameter("@objSeccionID", SqlDbType.Int)		
		If IsDBNull(m_objSeccionID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objSeccionID
        End If
		arParams(3) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objPeriodoID
        End If
		arParams(4) = New SqlParameter("@objGuiaID", SqlDbType.Int)		
		If IsDBNull(m_objGuiaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objGuiaID
        End If
		arParams(5) = New SqlParameter("@objModalidadID", SqlDbType.Int)		
		If IsDBNull(m_objModalidadID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objModalidadID
        End If
		arParams(6) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioCreacion
        End If
		arParams(7) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_FechaCreacion
        End If
		arParams(8) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_UsuarioModificacion
        End If
		arParams(9) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_FechaModificacion
        End If
		arParams(10) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Activo
        End If
		arParams(11) = New SqlParameter("@EvaluacionCualitativa", SqlDbType.Bit)		
		If IsDBNull(m_EvaluacionCualitativa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_EvaluacionCualitativa
        End If
		arParams(12) = New SqlParameter("@EvaluacionCuantitativa", SqlDbType.Bit)		
		If IsDBNull(m_EvaluacionCuantitativa) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_EvaluacionCuantitativa
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
    ''' Borra un objeto SraGrupo de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraGrupo where " & " SraGrupoID = " & m_SraGrupoID
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
    ''' Borra un objeto SraGrupo de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraGrupoID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraGrupo where " & " SraGrupoID = " & p_SraGrupoID
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
    ''' Borra objetos SraGrupo de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraGrupo where " & pWhere
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
