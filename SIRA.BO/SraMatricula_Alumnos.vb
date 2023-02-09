Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraMatricula_Alumnos		

#Region " Variables Miembro " 
	Protected m_SraMatriculaAlumnos As Integer 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objGradoID As Nullable(Of Integer) 
	Protected m_objModalidadlD As Nullable(Of Integer) 
	Protected m_objBecaID As Nullable(Of Integer) 
	Protected m_objTipoMatriculaID As Nullable(Of Integer) 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_NumRecibo As String = Nothing 
	Protected m_EscuelaProcedente As String = Nothing 
	Protected m_Foto As Byte() 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_Recomendaciones As String = Nothing 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_FechaIngreso As Nullable(Of Date) 
	Protected m_IngresoPosterior As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SraMatriculaAlumnos() As Integer
        Get
            Return (m_SraMatriculaAlumnos)
        End Get
		Set(ByVal Value As Integer)					
			m_SraMatriculaAlumnos = Value
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
	
	Public Property objGradoID() As Nullable(Of Integer)
        Get
            Return (m_objGradoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGradoID = Value
		End Set
    End Property
	
	Public Property objModalidadlD() As Nullable(Of Integer)
        Get
            Return (m_objModalidadlD)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objModalidadlD = Value
		End Set
    End Property
	
	Public Property objBecaID() As Nullable(Of Integer)
        Get
            Return (m_objBecaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objBecaID = Value
		End Set
    End Property
	
	Public Property objTipoMatriculaID() As Nullable(Of Integer)
        Get
            Return (m_objTipoMatriculaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTipoMatriculaID = Value
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
	
	Public Property NumRecibo() As String
        Get
            Return (m_NumRecibo)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("NumRecibo", Value.ToString(), "Valor inv?lido para SraMatricula_Alumnos.NumRecibo. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_NumRecibo = Value
		End Set
    End Property
	
	Public Property EscuelaProcedente() As String
        Get
            Return (m_EscuelaProcedente)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("EscuelaProcedente", Value.ToString(), "Valor inv?lido para SraMatricula_Alumnos.EscuelaProcedente. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_EscuelaProcedente = Value
		End Set
    End Property
	
	Public Property Foto() As Byte()
        Get
            Return (m_Foto)
        End Get
		Set(ByVal Value As Byte())					
			m_Foto = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraMatricula_Alumnos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraMatricula_Alumnos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property Recomendaciones() As String
        Get
            Return (m_Recomendaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 150 Then
					Throw New ArgumentOutOfRangeException("Recomendaciones", Value.ToString(), "Valor inv?lido para SraMatricula_Alumnos.Recomendaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (150).")
				End If
			End If
			m_Recomendaciones = Value
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
	
	Public Property FechaIngreso() As Nullable(Of Date)
        Get
            Return (m_FechaIngreso)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_FechaIngreso = Value
		End Set
    End Property
	
	Public Property IngresoPosterior() As Nullable(Of Boolean)
        Get
            Return (m_IngresoPosterior)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_IngresoPosterior = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "NumRecibo"
				Return	50
			Case "EscuelaProcedente"
				Return	150
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	30
			Case "Recomendaciones"
				Return	150
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
    ''' Salva un DataSet del tipo de la tabla SraMatricula_Alumnos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraMatricula_Alumnos </param>    
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
			cmdDelete.Parameters.Add("@SraMatriculaAlumnos", SqlDbType.Int, 4, "SraMatriculaAlumnos" )
			cmdDelete.CommandText = "DELETE FROM  SraMatricula_Alumnos WHERE SraMatriculaAlumnos= @SraMatriculaAlumnos" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
			cmdInsert.Parameters.Add("@objModalidadlD", SqlDbType.Int, 4, "objModalidadlD")
			cmdInsert.Parameters.Add("@objBecaID", SqlDbType.Int, 4, "objBecaID")
			cmdInsert.Parameters.Add("@objTipoMatriculaID", SqlDbType.Int, 4, "objTipoMatriculaID")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@NumRecibo", SqlDbType.VarChar, 50, "NumRecibo")
			cmdInsert.Parameters.Add("@EscuelaProcedente", SqlDbType.VarChar, 150, "EscuelaProcedente")
			cmdInsert.Parameters.Add("@Foto", SqlDbType.Binary, 16, "Foto")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@Recomendaciones", SqlDbType.VarChar, 150, "Recomendaciones")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@FechaIngreso", SqlDbType.DateTime, 8, "FechaIngreso")
			cmdInsert.Parameters.Add("@IngresoPosterior", SqlDbType.Bit, 1, "IngresoPosterior")
			cmdInsert.CommandText = "INSERT INTO SraMatricula_Alumnos ( objAlumnoID, objGradoID, objModalidadlD, objBecaID, objTipoMatriculaID, Activo, NumRecibo, EscuelaProcedente, Foto, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, Recomendaciones, objPeriodoID, FechaIngreso, IngresoPosterior) VALUES ( @objAlumnoID, @objGradoID, @objModalidadlD, @objBecaID, @objTipoMatriculaID, @Activo, @NumRecibo, @EscuelaProcedente, @Foto, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @Recomendaciones, @objPeriodoID, @FechaIngreso, @IngresoPosterior)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
			cmdUpdate.Parameters.Add("@objModalidadlD", SqlDbType.Int, 4, "objModalidadlD")
			cmdUpdate.Parameters.Add("@objBecaID", SqlDbType.Int, 4, "objBecaID")
			cmdUpdate.Parameters.Add("@objTipoMatriculaID", SqlDbType.Int, 4, "objTipoMatriculaID")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@NumRecibo", SqlDbType.VarChar, 50, "NumRecibo")
			cmdUpdate.Parameters.Add("@EscuelaProcedente", SqlDbType.VarChar, 150, "EscuelaProcedente")
			cmdUpdate.Parameters.Add("@Foto", SqlDbType.Binary, 16, "Foto")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@Recomendaciones", SqlDbType.VarChar, 150, "Recomendaciones")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@FechaIngreso", SqlDbType.DateTime, 8, "FechaIngreso")
			cmdUpdate.Parameters.Add("@IngresoPosterior", SqlDbType.Bit, 1, "IngresoPosterior")
			cmdUpdate.Parameters.Add("@wSraMatriculaAlumnos", SqlDbType.Int, 4, "SraMatriculaAlumnos")
			cmdUpdate.CommandText = "UPDATE SraMatricula_Alumnos SET objAlumnoID=@objAlumnoID, objGradoID=@objGradoID, objModalidadlD=@objModalidadlD, objBecaID=@objBecaID, objTipoMatriculaID=@objTipoMatriculaID, Activo=@Activo, NumRecibo=@NumRecibo, EscuelaProcedente=@EscuelaProcedente, Foto=@Foto, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, Recomendaciones=@Recomendaciones, objPeriodoID=@objPeriodoID, FechaIngreso=@FechaIngreso, IngresoPosterior=@IngresoPosterior WHERE SraMatriculaAlumnos= @wSraMatriculaAlumnos"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraMatricula_Alumnos")
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
    ''' Devuelve de la base de datos un objeto SraMatricula_Alumnos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraMatriculaAlumnos as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraMatricula_Alumnos where " & " SraMatriculaAlumnos = " & p_SraMatriculaAlumnos		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraMatriculaAlumnos = dr("SraMatriculaAlumnos")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
				m_objModalidadlD = IIf(IsDBNull(dr("objModalidadlD")), Nothing, dr("objModalidadlD"))
				m_objBecaID = IIf(IsDBNull(dr("objBecaID")), Nothing, dr("objBecaID"))
				m_objTipoMatriculaID = IIf(IsDBNull(dr("objTipoMatriculaID")), Nothing, dr("objTipoMatriculaID"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_NumRecibo = IIf(IsDBNull(dr("NumRecibo")), Nothing, dr("NumRecibo"))
				m_EscuelaProcedente = IIf(IsDBNull(dr("EscuelaProcedente")), Nothing, dr("EscuelaProcedente"))
				m_Foto = IIf(IsDBNull(dr("Foto")), Nothing, dr("Foto"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Recomendaciones = IIf(IsDBNull(dr("Recomendaciones")), Nothing, dr("Recomendaciones"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_FechaIngreso = IIf(IsDBNull(dr("FechaIngreso")), Nothing, dr("FechaIngreso"))
				m_IngresoPosterior = IIf(IsDBNull(dr("IngresoPosterior")), Nothing, dr("IngresoPosterior"))
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
    ''' Devuelve de la base de datos un objeto SraMatricula_Alumnos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraMatricula_Alumnos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraMatriculaAlumnos = dr("SraMatriculaAlumnos")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
				m_objModalidadlD = IIf(IsDBNull(dr("objModalidadlD")), Nothing, dr("objModalidadlD"))
				m_objBecaID = IIf(IsDBNull(dr("objBecaID")), Nothing, dr("objBecaID"))
				m_objTipoMatriculaID = IIf(IsDBNull(dr("objTipoMatriculaID")), Nothing, dr("objTipoMatriculaID"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_NumRecibo = IIf(IsDBNull(dr("NumRecibo")), Nothing, dr("NumRecibo"))
				m_EscuelaProcedente = IIf(IsDBNull(dr("EscuelaProcedente")), Nothing, dr("EscuelaProcedente"))
				m_Foto = IIf(IsDBNull(dr("Foto")), Nothing, dr("Foto"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Recomendaciones = IIf(IsDBNull(dr("Recomendaciones")), Nothing, dr("Recomendaciones"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_FechaIngreso = IIf(IsDBNull(dr("FechaIngreso")), Nothing, dr("FechaIngreso"))
				m_IngresoPosterior = IIf(IsDBNull(dr("IngresoPosterior")), Nothing, dr("IngresoPosterior"))
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
    ''' Trae de la base de datos un conjunto de objetos SraMatricula_Alumnos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraMatricula_Alumnos"

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
			ds.Tables(0).TableName = "SraMatricula_Alumnos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraMatricula_Alumnos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraMatricula_Alumnos"

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
			ds.Tables(0).TableName = "SraMatricula_Alumnos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraMatricula_Alumnos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraMatricula_Alumnos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraMatricula_Alumnos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraMatricula_Alumnos("
		sCommand &= "objAlumnoID,"
		sCommand &= "objGradoID,"
		sCommand &= "objModalidadlD,"
		sCommand &= "objBecaID,"
		sCommand &= "objTipoMatriculaID,"
		sCommand &= "Activo,"
		sCommand &= "NumRecibo,"
		sCommand &= "EscuelaProcedente,"
		sCommand &= "Foto,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "Recomendaciones,"
		sCommand &= "objPeriodoID,"
		sCommand &= "FechaIngreso,"
		sCommand &= "IngresoPosterior) values ("		
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objGradoID,"
		sCommand &= "@objModalidadlD,"
		sCommand &= "@objBecaID,"
		sCommand &= "@objTipoMatriculaID,"
		sCommand &= "@Activo,"
		sCommand &= "@NumRecibo,"
		sCommand &= "@EscuelaProcedente,"
		sCommand &= "@Foto,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@Recomendaciones,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@FechaIngreso,"
		sCommand &= "@IngresoPosterior)"		
	
		sCommand &= " select "
		sCommand &= "@SraMatriculaAlumnos = SraMatriculaAlumnos from SraMatricula_Alumnos where "		
		sCommand &= "SraMatriculaAlumnos = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SraMatriculaAlumnos", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objGradoID", SqlDbType.Int)		
		If IsDBNull(m_objGradoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objGradoID
        End If
		arParams(3) = New SqlParameter("@objModalidadlD", SqlDbType.Int)		
		If IsDBNull(m_objModalidadlD) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objModalidadlD
        End If
		arParams(4) = New SqlParameter("@objBecaID", SqlDbType.Int)		
		If IsDBNull(m_objBecaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objBecaID
        End If
		arParams(5) = New SqlParameter("@objTipoMatriculaID", SqlDbType.Int)		
		If IsDBNull(m_objTipoMatriculaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoMatriculaID
        End If
		arParams(6) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activo
        End If
		arParams(7) = New SqlParameter("@NumRecibo", SqlDbType.VarChar)		
		If IsDBNull(m_NumRecibo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_NumRecibo
        End If
		arParams(8) = New SqlParameter("@EscuelaProcedente", SqlDbType.VarChar)		
		If IsDBNull(m_EscuelaProcedente) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_EscuelaProcedente
        End If
		arParams(9) = New SqlParameter("@Foto", SqlDbType.Binary)		
		If IsDBNull(m_Foto) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Foto
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
        End If
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@Recomendaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Recomendaciones) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Recomendaciones
        End If
		arParams(15) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_objPeriodoID
        End If
		arParams(16) = New SqlParameter("@FechaIngreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaIngreso) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaIngreso
        End If
		arParams(17) = New SqlParameter("@IngresoPosterior", SqlDbType.Bit)		
		If IsDBNull(m_IngresoPosterior) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_IngresoPosterior
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraMatriculaAlumnos = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraMatricula_Alumnos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraMatricula_Alumnos set "		
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objGradoID = @objGradoID,"
		sCommand &= "objModalidadlD = @objModalidadlD,"
		sCommand &= "objBecaID = @objBecaID,"
		sCommand &= "objTipoMatriculaID = @objTipoMatriculaID,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "NumRecibo = @NumRecibo,"
		sCommand &= "EscuelaProcedente = @EscuelaProcedente,"
		sCommand &= "Foto = @Foto,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "Recomendaciones = @Recomendaciones,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "FechaIngreso = @FechaIngreso,"
		sCommand &= "IngresoPosterior = @IngresoPosterior"		
		sCommand &= " where "	
		sCommand &= "SraMatriculaAlumnos = @SraMatriculaAlumnos"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SraMatriculaAlumnos", SqlDbType.Int)		
		If IsDBNull(m_SraMatriculaAlumnos) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraMatriculaAlumnos
        End If
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objGradoID", SqlDbType.Int)		
		If IsDBNull(m_objGradoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objGradoID
        End If
		arParams(3) = New SqlParameter("@objModalidadlD", SqlDbType.Int)		
		If IsDBNull(m_objModalidadlD) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objModalidadlD
        End If
		arParams(4) = New SqlParameter("@objBecaID", SqlDbType.Int)		
		If IsDBNull(m_objBecaID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objBecaID
        End If
		arParams(5) = New SqlParameter("@objTipoMatriculaID", SqlDbType.Int)		
		If IsDBNull(m_objTipoMatriculaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objTipoMatriculaID
        End If
		arParams(6) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activo
        End If
		arParams(7) = New SqlParameter("@NumRecibo", SqlDbType.VarChar)		
		If IsDBNull(m_NumRecibo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_NumRecibo
        End If
		arParams(8) = New SqlParameter("@EscuelaProcedente", SqlDbType.VarChar)		
		If IsDBNull(m_EscuelaProcedente) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_EscuelaProcedente
        End If
		arParams(9) = New SqlParameter("@Foto", SqlDbType.Binary)		
		If IsDBNull(m_Foto) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Foto
        End If
		arParams(10) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_UsuarioCreacion
        End If
		arParams(11) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_FechaCreacion
        End If
		arParams(12) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioModificacion
        End If
		arParams(13) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaModificacion
        End If
		arParams(14) = New SqlParameter("@Recomendaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Recomendaciones) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Recomendaciones
        End If
		arParams(15) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_objPeriodoID
        End If
		arParams(16) = New SqlParameter("@FechaIngreso", SqlDbType.DateTime)		
		If IsDBNull(m_FechaIngreso) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaIngreso
        End If
		arParams(17) = New SqlParameter("@IngresoPosterior", SqlDbType.Bit)		
		If IsDBNull(m_IngresoPosterior) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_IngresoPosterior
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
    ''' Borra un objeto SraMatricula_Alumnos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraMatricula_Alumnos where " & " SraMatriculaAlumnos = " & m_SraMatriculaAlumnos
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
    ''' Borra un objeto SraMatricula_Alumnos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraMatriculaAlumnos as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraMatricula_Alumnos where " & " SraMatriculaAlumnos = " & p_SraMatriculaAlumnos
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
    ''' Borra objetos SraMatricula_Alumnos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraMatricula_Alumnos where " & pWhere
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
