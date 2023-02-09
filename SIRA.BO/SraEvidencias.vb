Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraEvidencias		

#Region " Variables Miembro " 
	Protected m_SraEvidenciasID As Integer 
	Protected m_NombreEvidencia As String = Nothing 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_Descripcion As String = Nothing 
	Protected m_OrdenEvidencia As Nullable(Of Integer) 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_objProfesorID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SraEvidenciasID() As Integer
        Get
            Return (m_SraEvidenciasID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraEvidenciasID = Value
		End Set
    End Property
	
	Public Property NombreEvidencia() As String
        Get
            Return (m_NombreEvidencia)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("NombreEvidencia", Value.ToString(), "Valor inv?lido para SraEvidencias.NombreEvidencia. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_NombreEvidencia = Value
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
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraEvidencias.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraEvidencias.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SraEvidencias.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property OrdenEvidencia() As Nullable(Of Integer)
        Get
            Return (m_OrdenEvidencia)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_OrdenEvidencia = Value
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
	
	Public Property objProfesorID() As Nullable(Of Integer)
        Get
            Return (m_objProfesorID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objProfesorID = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "NombreEvidencia"
				Return	50
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "Descripcion"
				Return	2147483645
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
    ''' Salva un DataSet del tipo de la tabla SraEvidencias en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraEvidencias </param>    
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
			cmdDelete.Parameters.Add("@SraEvidenciasID", SqlDbType.Int, 4, "SraEvidenciasID" )
			cmdDelete.CommandText = "DELETE FROM  SraEvidencias WHERE SraEvidenciasID= @SraEvidenciasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@NombreEvidencia", SqlDbType.VarChar, 50, "NombreEvidencia")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, -1, "Descripcion")
			cmdInsert.Parameters.Add("@OrdenEvidencia", SqlDbType.Int, 4, "OrdenEvidencia")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@objProfesorID", SqlDbType.Int, 4, "objProfesorID")
			cmdInsert.CommandText = "INSERT INTO SraEvidencias ( NombreEvidencia, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion, Descripcion, OrdenEvidencia, objPeriodoID, objProfesorID) VALUES ( @NombreEvidencia, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion, @Descripcion, @OrdenEvidencia, @objPeriodoID, @objProfesorID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@NombreEvidencia", SqlDbType.VarChar, 50, "NombreEvidencia")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, -1, "Descripcion")
			cmdUpdate.Parameters.Add("@OrdenEvidencia", SqlDbType.Int, 4, "OrdenEvidencia")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@objProfesorID", SqlDbType.Int, 4, "objProfesorID")
			cmdUpdate.Parameters.Add("@wSraEvidenciasID", SqlDbType.Int, 4, "SraEvidenciasID")
			cmdUpdate.CommandText = "UPDATE SraEvidencias SET NombreEvidencia=@NombreEvidencia, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion, Descripcion=@Descripcion, OrdenEvidencia=@OrdenEvidencia, objPeriodoID=@objPeriodoID, objProfesorID=@objProfesorID WHERE SraEvidenciasID= @wSraEvidenciasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraEvidencias")
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
    ''' Devuelve de la base de datos un objeto SraEvidencias
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraEvidenciasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraEvidencias where " & " SraEvidenciasID = " & p_SraEvidenciasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraEvidenciasID = dr("SraEvidenciasID")
				m_NombreEvidencia = IIf(IsDBNull(dr("NombreEvidencia")), Nothing, dr("NombreEvidencia"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_OrdenEvidencia = IIf(IsDBNull(dr("OrdenEvidencia")), Nothing, dr("OrdenEvidencia"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objProfesorID = IIf(IsDBNull(dr("objProfesorID")), Nothing, dr("objProfesorID"))
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
    ''' Devuelve de la base de datos un objeto SraEvidencias usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraEvidencias where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraEvidenciasID = dr("SraEvidenciasID")
				m_NombreEvidencia = IIf(IsDBNull(dr("NombreEvidencia")), Nothing, dr("NombreEvidencia"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_OrdenEvidencia = IIf(IsDBNull(dr("OrdenEvidencia")), Nothing, dr("OrdenEvidencia"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objProfesorID = IIf(IsDBNull(dr("objProfesorID")), Nothing, dr("objProfesorID"))
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
    ''' Trae de la base de datos un conjunto de objetos SraEvidencias en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraEvidencias"

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
			ds.Tables(0).TableName = "SraEvidencias"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraEvidencias en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraEvidencias"

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
			ds.Tables(0).TableName = "SraEvidencias"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraEvidencias en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraEvidencias"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraEvidencias.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraEvidencias("
		sCommand &= "NombreEvidencia,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "Descripcion,"
		sCommand &= "OrdenEvidencia,"
		sCommand &= "objPeriodoID,"
		sCommand &= "objProfesorID) values ("		
		sCommand &= "@NombreEvidencia,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@Descripcion,"
		sCommand &= "@OrdenEvidencia,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@objProfesorID)"		
	
		sCommand &= " select "
		sCommand &= "@SraEvidenciasID = SraEvidenciasID from SraEvidencias where "		
		sCommand &= "SraEvidenciasID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SraEvidenciasID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@NombreEvidencia", SqlDbType.VarChar)		
		If IsDBNull(m_NombreEvidencia) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NombreEvidencia
        End If
		arParams(2) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Activa
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Descripcion
        End If
		arParams(8) = New SqlParameter("@OrdenEvidencia", SqlDbType.Int)		
		If IsDBNull(m_OrdenEvidencia) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_OrdenEvidencia
        End If
		arParams(9) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objPeriodoID
        End If
		arParams(10) = New SqlParameter("@objProfesorID", SqlDbType.Int)		
		If IsDBNull(m_objProfesorID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objProfesorID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraEvidenciasID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraEvidencias en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraEvidencias set "		
		sCommand &= "NombreEvidencia = @NombreEvidencia,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "OrdenEvidencia = @OrdenEvidencia,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "objProfesorID = @objProfesorID"		
		sCommand &= " where "	
		sCommand &= "SraEvidenciasID = @SraEvidenciasID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SraEvidenciasID", SqlDbType.Int)		
		If IsDBNull(m_SraEvidenciasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraEvidenciasID
        End If
		arParams(1) = New SqlParameter("@NombreEvidencia", SqlDbType.VarChar)		
		If IsDBNull(m_NombreEvidencia) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NombreEvidencia
        End If
		arParams(2) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Activa
        End If
		arParams(3) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_FechaCreacion
        End If
		arParams(4) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_UsuarioCreacion
        End If
		arParams(5) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_FechaModificacion
        End If
		arParams(6) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_UsuarioModificacion
        End If
		arParams(7) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Descripcion
        End If
		arParams(8) = New SqlParameter("@OrdenEvidencia", SqlDbType.Int)		
		If IsDBNull(m_OrdenEvidencia) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_OrdenEvidencia
        End If
		arParams(9) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objPeriodoID
        End If
		arParams(10) = New SqlParameter("@objProfesorID", SqlDbType.Int)		
		If IsDBNull(m_objProfesorID) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_objProfesorID
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
    ''' Borra un objeto SraEvidencias de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraEvidencias where " & " SraEvidenciasID = " & m_SraEvidenciasID
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
    ''' Borra un objeto SraEvidencias de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraEvidenciasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraEvidencias where " & " SraEvidenciasID = " & p_SraEvidenciasID
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
    ''' Borra objetos SraEvidencias de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraEvidencias where " & pWhere
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
