Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraAlumnos_Notas		

#Region " Variables Miembro " 
	Protected m_SraAlumnosNotaID As Integer 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objAsignaturaID As Nullable(Of Integer) 
	Protected m_objGrupoID As Nullable(Of Integer) 
	Protected m_objParcialID As Nullable(Of Integer) 
	Protected m_objSraNotas_CualitativaID As Nullable(Of Integer) 
	Protected m_Evaluacion1 As Nullable(Of Decimal) 
	Protected m_Evaluacion2 As Nullable(Of Decimal) 
	Protected m_Evaluacion3 As Nullable(Of Decimal) 
	Protected m_Evaluacion4 As Nullable(Of Decimal) 
	Protected m_Evaluacion5 As Nullable(Of Decimal) 
	Protected m_Evaluacion6 As Nullable(Of Decimal) 
	Protected m_Evaluacion7 As Nullable(Of Decimal) 
	Protected m_Evaluacion8 As Nullable(Of Decimal) 
	Protected m_Evaluacion9 As Nullable(Of Decimal) 
	Protected m_Evaluacion10 As Nullable(Of Decimal) 
	Protected m_Promedio As Nullable(Of Decimal) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As Nullable(Of Decimal) 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SraAlumnosNotaID() As Integer
        Get
            Return (m_SraAlumnosNotaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraAlumnosNotaID = Value
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
	
	Public Property objGrupoID() As Nullable(Of Integer)
        Get
            Return (m_objGrupoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objGrupoID = Value
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
	
	Public Property objSraNotas_CualitativaID() As Nullable(Of Integer)
        Get
            Return (m_objSraNotas_CualitativaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSraNotas_CualitativaID = Value
		End Set
    End Property
	
	Public Property Evaluacion1() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion1)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion1 = Value
		End Set
    End Property
	
	Public Property Evaluacion2() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion2)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion2 = Value
		End Set
    End Property
	
	Public Property Evaluacion3() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion3)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion3 = Value
		End Set
    End Property
	
	Public Property Evaluacion4() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion4)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion4 = Value
		End Set
    End Property
	
	Public Property Evaluacion5() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion5)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion5 = Value
		End Set
    End Property
	
	Public Property Evaluacion6() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion6)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion6 = Value
		End Set
    End Property
	
	Public Property Evaluacion7() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion7)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion7 = Value
		End Set
    End Property
	
	Public Property Evaluacion8() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion8)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion8 = Value
		End Set
    End Property
	
	Public Property Evaluacion9() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion9)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion9 = Value
		End Set
    End Property
	
	Public Property Evaluacion10() As Nullable(Of Decimal)
        Get
            Return (m_Evaluacion10)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Evaluacion10 = Value
		End Set
    End Property
	
	Public Property Promedio() As Nullable(Of Decimal)
        Get
            Return (m_Promedio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Promedio = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraAlumnos_Notas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
				End If
			End If
			m_UsuarioCreacion = Value
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
	
	Public Property UsuarioModificacion() As Nullable(Of Decimal)
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Evaluacion1"
				Return	18
			Case "Evaluacion2"
				Return	18
			Case "Evaluacion3"
				Return	18
			Case "Evaluacion4"
				Return	18
			Case "Evaluacion5"
				Return	18
			Case "Evaluacion6"
				Return	18
			Case "Evaluacion7"
				Return	18
			Case "Evaluacion8"
				Return	18
			Case "Evaluacion9"
				Return	18
			Case "Evaluacion10"
				Return	18
			Case "Promedio"
				Return	18
			Case "UsuarioCreacion"
				Return	30
			Case "UsuarioModificacion"
				Return	18
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Evaluacion1"
				Return	12
			Case "Evaluacion2"
				Return	12
			Case "Evaluacion3"
				Return	12
			Case "Evaluacion4"
				Return	12
			Case "Evaluacion5"
				Return	12
			Case "Evaluacion6"
				Return	12
			Case "Evaluacion7"
				Return	12
			Case "Evaluacion8"
				Return	12
			Case "Evaluacion9"
				Return	12
			Case "Evaluacion10"
				Return	12
			Case "Promedio"
				Return	2
			Case "UsuarioModificacion"
				Return	12
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SraAlumnos_Notas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraAlumnos_Notas </param>    
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
			cmdDelete.Parameters.Add("@SraAlumnosNotaID", SqlDbType.Int, 4, "SraAlumnosNotaID" )
			cmdDelete.CommandText = "DELETE FROM  SraAlumnos_Notas WHERE SraAlumnosNotaID= @SraAlumnosNotaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdInsert.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdInsert.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdInsert.Parameters.Add("@objSraNotas_CualitativaID", SqlDbType.Int, 4, "objSraNotas_CualitativaID")
			cmdInsert.Parameters.Add("@Evaluacion1", SqlDbType.Decimal, 9, "Evaluacion1")
			cmdInsert.Parameters.Add("@Evaluacion2", SqlDbType.Decimal, 9, "Evaluacion2")
			cmdInsert.Parameters.Add("@Evaluacion3", SqlDbType.Decimal, 9, "Evaluacion3")
			cmdInsert.Parameters.Add("@Evaluacion4", SqlDbType.Decimal, 9, "Evaluacion4")
			cmdInsert.Parameters.Add("@Evaluacion5", SqlDbType.Decimal, 9, "Evaluacion5")
			cmdInsert.Parameters.Add("@Evaluacion6", SqlDbType.Decimal, 9, "Evaluacion6")
			cmdInsert.Parameters.Add("@Evaluacion7", SqlDbType.Decimal, 9, "Evaluacion7")
			cmdInsert.Parameters.Add("@Evaluacion8", SqlDbType.Decimal, 9, "Evaluacion8")
			cmdInsert.Parameters.Add("@Evaluacion9", SqlDbType.Decimal, 9, "Evaluacion9")
			cmdInsert.Parameters.Add("@Evaluacion10", SqlDbType.Decimal, 9, "Evaluacion10")
			cmdInsert.Parameters.Add("@Promedio", SqlDbType.Decimal, 9, "Promedio")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.Decimal, 9, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SraAlumnos_Notas ( objAlumnoID, objAsignaturaID, objGrupoID, objParcialID, objSraNotas_CualitativaID, Evaluacion1, Evaluacion2, Evaluacion3, Evaluacion4, Evaluacion5, Evaluacion6, Evaluacion7, Evaluacion8, Evaluacion9, Evaluacion10, Promedio, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objAlumnoID, @objAsignaturaID, @objGrupoID, @objParcialID, @objSraNotas_CualitativaID, @Evaluacion1, @Evaluacion2, @Evaluacion3, @Evaluacion4, @Evaluacion5, @Evaluacion6, @Evaluacion7, @Evaluacion8, @Evaluacion9, @Evaluacion10, @Promedio, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdUpdate.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdUpdate.Parameters.Add("@objParcialID", SqlDbType.Int, 4, "objParcialID")
			cmdUpdate.Parameters.Add("@objSraNotas_CualitativaID", SqlDbType.Int, 4, "objSraNotas_CualitativaID")
			cmdUpdate.Parameters.Add("@Evaluacion1", SqlDbType.Decimal, 9, "Evaluacion1")
			cmdUpdate.Parameters.Add("@Evaluacion2", SqlDbType.Decimal, 9, "Evaluacion2")
			cmdUpdate.Parameters.Add("@Evaluacion3", SqlDbType.Decimal, 9, "Evaluacion3")
			cmdUpdate.Parameters.Add("@Evaluacion4", SqlDbType.Decimal, 9, "Evaluacion4")
			cmdUpdate.Parameters.Add("@Evaluacion5", SqlDbType.Decimal, 9, "Evaluacion5")
			cmdUpdate.Parameters.Add("@Evaluacion6", SqlDbType.Decimal, 9, "Evaluacion6")
			cmdUpdate.Parameters.Add("@Evaluacion7", SqlDbType.Decimal, 9, "Evaluacion7")
			cmdUpdate.Parameters.Add("@Evaluacion8", SqlDbType.Decimal, 9, "Evaluacion8")
			cmdUpdate.Parameters.Add("@Evaluacion9", SqlDbType.Decimal, 9, "Evaluacion9")
			cmdUpdate.Parameters.Add("@Evaluacion10", SqlDbType.Decimal, 9, "Evaluacion10")
			cmdUpdate.Parameters.Add("@Promedio", SqlDbType.Decimal, 9, "Promedio")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.Decimal, 9, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSraAlumnosNotaID", SqlDbType.Int, 4, "SraAlumnosNotaID")
			cmdUpdate.CommandText = "UPDATE SraAlumnos_Notas SET objAlumnoID=@objAlumnoID, objAsignaturaID=@objAsignaturaID, objGrupoID=@objGrupoID, objParcialID=@objParcialID, objSraNotas_CualitativaID=@objSraNotas_CualitativaID, Evaluacion1=@Evaluacion1, Evaluacion2=@Evaluacion2, Evaluacion3=@Evaluacion3, Evaluacion4=@Evaluacion4, Evaluacion5=@Evaluacion5, Evaluacion6=@Evaluacion6, Evaluacion7=@Evaluacion7, Evaluacion8=@Evaluacion8, Evaluacion9=@Evaluacion9, Evaluacion10=@Evaluacion10, Promedio=@Promedio, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SraAlumnosNotaID= @wSraAlumnosNotaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraAlumnos_Notas")
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
    ''' Devuelve de la base de datos un objeto SraAlumnos_Notas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraAlumnosNotaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraAlumnos_Notas where " & " SraAlumnosNotaID = " & p_SraAlumnosNotaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraAlumnosNotaID = dr("SraAlumnosNotaID")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objSraNotas_CualitativaID = IIf(IsDBNull(dr("objSraNotas_CualitativaID")), Nothing, dr("objSraNotas_CualitativaID"))
				m_Evaluacion1 = IIf(IsDBNull(dr("Evaluacion1")), Nothing, dr("Evaluacion1"))
				m_Evaluacion2 = IIf(IsDBNull(dr("Evaluacion2")), Nothing, dr("Evaluacion2"))
				m_Evaluacion3 = IIf(IsDBNull(dr("Evaluacion3")), Nothing, dr("Evaluacion3"))
				m_Evaluacion4 = IIf(IsDBNull(dr("Evaluacion4")), Nothing, dr("Evaluacion4"))
				m_Evaluacion5 = IIf(IsDBNull(dr("Evaluacion5")), Nothing, dr("Evaluacion5"))
				m_Evaluacion6 = IIf(IsDBNull(dr("Evaluacion6")), Nothing, dr("Evaluacion6"))
				m_Evaluacion7 = IIf(IsDBNull(dr("Evaluacion7")), Nothing, dr("Evaluacion7"))
				m_Evaluacion8 = IIf(IsDBNull(dr("Evaluacion8")), Nothing, dr("Evaluacion8"))
				m_Evaluacion9 = IIf(IsDBNull(dr("Evaluacion9")), Nothing, dr("Evaluacion9"))
				m_Evaluacion10 = IIf(IsDBNull(dr("Evaluacion10")), Nothing, dr("Evaluacion10"))
				m_Promedio = IIf(IsDBNull(dr("Promedio")), Nothing, dr("Promedio"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
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
    ''' Devuelve de la base de datos un objeto SraAlumnos_Notas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraAlumnos_Notas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraAlumnosNotaID = dr("SraAlumnosNotaID")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objParcialID = IIf(IsDBNull(dr("objParcialID")), Nothing, dr("objParcialID"))
				m_objSraNotas_CualitativaID = IIf(IsDBNull(dr("objSraNotas_CualitativaID")), Nothing, dr("objSraNotas_CualitativaID"))
				m_Evaluacion1 = IIf(IsDBNull(dr("Evaluacion1")), Nothing, dr("Evaluacion1"))
				m_Evaluacion2 = IIf(IsDBNull(dr("Evaluacion2")), Nothing, dr("Evaluacion2"))
				m_Evaluacion3 = IIf(IsDBNull(dr("Evaluacion3")), Nothing, dr("Evaluacion3"))
				m_Evaluacion4 = IIf(IsDBNull(dr("Evaluacion4")), Nothing, dr("Evaluacion4"))
				m_Evaluacion5 = IIf(IsDBNull(dr("Evaluacion5")), Nothing, dr("Evaluacion5"))
				m_Evaluacion6 = IIf(IsDBNull(dr("Evaluacion6")), Nothing, dr("Evaluacion6"))
				m_Evaluacion7 = IIf(IsDBNull(dr("Evaluacion7")), Nothing, dr("Evaluacion7"))
				m_Evaluacion8 = IIf(IsDBNull(dr("Evaluacion8")), Nothing, dr("Evaluacion8"))
				m_Evaluacion9 = IIf(IsDBNull(dr("Evaluacion9")), Nothing, dr("Evaluacion9"))
				m_Evaluacion10 = IIf(IsDBNull(dr("Evaluacion10")), Nothing, dr("Evaluacion10"))
				m_Promedio = IIf(IsDBNull(dr("Promedio")), Nothing, dr("Promedio"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
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
    ''' Trae de la base de datos un conjunto de objetos SraAlumnos_Notas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraAlumnos_Notas"

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
			ds.Tables(0).TableName = "SraAlumnos_Notas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraAlumnos_Notas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraAlumnos_Notas"

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
			ds.Tables(0).TableName = "SraAlumnos_Notas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraAlumnos_Notas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraAlumnos_Notas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraAlumnos_Notas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraAlumnos_Notas("
		sCommand &= "objAlumnoID,"
		sCommand &= "objAsignaturaID,"
		sCommand &= "objGrupoID,"
		sCommand &= "objParcialID,"
		sCommand &= "objSraNotas_CualitativaID,"
		sCommand &= "Evaluacion1,"
		sCommand &= "Evaluacion2,"
		sCommand &= "Evaluacion3,"
		sCommand &= "Evaluacion4,"
		sCommand &= "Evaluacion5,"
		sCommand &= "Evaluacion6,"
		sCommand &= "Evaluacion7,"
		sCommand &= "Evaluacion8,"
		sCommand &= "Evaluacion9,"
		sCommand &= "Evaluacion10,"
		sCommand &= "Promedio,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objAsignaturaID,"
		sCommand &= "@objGrupoID,"
		sCommand &= "@objParcialID,"
		sCommand &= "@objSraNotas_CualitativaID,"
		sCommand &= "@Evaluacion1,"
		sCommand &= "@Evaluacion2,"
		sCommand &= "@Evaluacion3,"
		sCommand &= "@Evaluacion4,"
		sCommand &= "@Evaluacion5,"
		sCommand &= "@Evaluacion6,"
		sCommand &= "@Evaluacion7,"
		sCommand &= "@Evaluacion8,"
		sCommand &= "@Evaluacion9,"
		sCommand &= "@Evaluacion10,"
		sCommand &= "@Promedio,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SraAlumnosNotaID = SraAlumnosNotaID from SraAlumnos_Notas where "		
		sCommand &= "SraAlumnosNotaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SraAlumnosNotaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAsignaturaID
        End If
		arParams(3) = New SqlParameter("@objGrupoID", SqlDbType.Int)		
		If IsDBNull(m_objGrupoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objGrupoID
        End If
		arParams(4) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objParcialID
        End If
		arParams(5) = New SqlParameter("@objSraNotas_CualitativaID", SqlDbType.Int)		
		If IsDBNull(m_objSraNotas_CualitativaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objSraNotas_CualitativaID
        End If
		arParams(6) = New SqlParameter("@Evaluacion1", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion1) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Evaluacion1
        End If
		arParams(7) = New SqlParameter("@Evaluacion2", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion2) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Evaluacion2
        End If
		arParams(8) = New SqlParameter("@Evaluacion3", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion3) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Evaluacion3
        End If
		arParams(9) = New SqlParameter("@Evaluacion4", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion4) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Evaluacion4
        End If
		arParams(10) = New SqlParameter("@Evaluacion5", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion5) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Evaluacion5
        End If
		arParams(11) = New SqlParameter("@Evaluacion6", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion6) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Evaluacion6
        End If
		arParams(12) = New SqlParameter("@Evaluacion7", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion7) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Evaluacion7
        End If
		arParams(13) = New SqlParameter("@Evaluacion8", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion8) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Evaluacion8
        End If
		arParams(14) = New SqlParameter("@Evaluacion9", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion9) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Evaluacion9
        End If
		arParams(15) = New SqlParameter("@Evaluacion10", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion10) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Evaluacion10
        End If
		arParams(16) = New SqlParameter("@Promedio", SqlDbType.Decimal)		
		If IsDBNull(m_Promedio) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Promedio
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.Decimal)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraAlumnosNotaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraAlumnos_Notas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraAlumnos_Notas set "		
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objAsignaturaID = @objAsignaturaID,"
		sCommand &= "objGrupoID = @objGrupoID,"
		sCommand &= "objParcialID = @objParcialID,"
		sCommand &= "objSraNotas_CualitativaID = @objSraNotas_CualitativaID,"
		sCommand &= "Evaluacion1 = @Evaluacion1,"
		sCommand &= "Evaluacion2 = @Evaluacion2,"
		sCommand &= "Evaluacion3 = @Evaluacion3,"
		sCommand &= "Evaluacion4 = @Evaluacion4,"
		sCommand &= "Evaluacion5 = @Evaluacion5,"
		sCommand &= "Evaluacion6 = @Evaluacion6,"
		sCommand &= "Evaluacion7 = @Evaluacion7,"
		sCommand &= "Evaluacion8 = @Evaluacion8,"
		sCommand &= "Evaluacion9 = @Evaluacion9,"
		sCommand &= "Evaluacion10 = @Evaluacion10,"
		sCommand &= "Promedio = @Promedio,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SraAlumnosNotaID = @SraAlumnosNotaID"					
		
		Dim arParams(20) As SqlParameter
		arParams(0) = New SqlParameter("@SraAlumnosNotaID", SqlDbType.Int)		
		If IsDBNull(m_SraAlumnosNotaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraAlumnosNotaID
        End If
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objAsignaturaID", SqlDbType.Int)		
		If IsDBNull(m_objAsignaturaID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAsignaturaID
        End If
		arParams(3) = New SqlParameter("@objGrupoID", SqlDbType.Int)		
		If IsDBNull(m_objGrupoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objGrupoID
        End If
		arParams(4) = New SqlParameter("@objParcialID", SqlDbType.Int)		
		If IsDBNull(m_objParcialID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objParcialID
        End If
		arParams(5) = New SqlParameter("@objSraNotas_CualitativaID", SqlDbType.Int)		
		If IsDBNull(m_objSraNotas_CualitativaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objSraNotas_CualitativaID
        End If
		arParams(6) = New SqlParameter("@Evaluacion1", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion1) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Evaluacion1
        End If
		arParams(7) = New SqlParameter("@Evaluacion2", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion2) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Evaluacion2
        End If
		arParams(8) = New SqlParameter("@Evaluacion3", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion3) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Evaluacion3
        End If
		arParams(9) = New SqlParameter("@Evaluacion4", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion4) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Evaluacion4
        End If
		arParams(10) = New SqlParameter("@Evaluacion5", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion5) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Evaluacion5
        End If
		arParams(11) = New SqlParameter("@Evaluacion6", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion6) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Evaluacion6
        End If
		arParams(12) = New SqlParameter("@Evaluacion7", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion7) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Evaluacion7
        End If
		arParams(13) = New SqlParameter("@Evaluacion8", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion8) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Evaluacion8
        End If
		arParams(14) = New SqlParameter("@Evaluacion9", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion9) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Evaluacion9
        End If
		arParams(15) = New SqlParameter("@Evaluacion10", SqlDbType.Decimal)		
		If IsDBNull(m_Evaluacion10) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Evaluacion10
        End If
		arParams(16) = New SqlParameter("@Promedio", SqlDbType.Decimal)		
		If IsDBNull(m_Promedio) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Promedio
        End If
		arParams(17) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioCreacion
        End If
		arParams(18) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_FechaCreacion
        End If
		arParams(19) = New SqlParameter("@UsuarioModificacion", SqlDbType.Decimal)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioModificacion
        End If
		arParams(20) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaModificacion
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
    ''' Borra un objeto SraAlumnos_Notas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAlumnos_Notas where " & " SraAlumnosNotaID = " & m_SraAlumnosNotaID
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
    ''' Borra un objeto SraAlumnos_Notas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraAlumnosNotaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAlumnos_Notas where " & " SraAlumnosNotaID = " & p_SraAlumnosNotaID
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
    ''' Borra objetos SraAlumnos_Notas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraAlumnos_Notas where " & pWhere
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
