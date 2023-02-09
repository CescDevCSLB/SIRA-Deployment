Imports DAL
Imports System.Data.SqlClient

Partial Public Class SraConsolidadoNotas		

#Region " Variables Miembro " 
	Protected m_SraConsolidadoNotasID As Integer 
	Protected m_objGrupoID As Nullable(Of Integer) 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objAsignaturaID As Nullable(Of Integer) 
	Protected m_Parcial_I As Integer 
	Protected m_Parcial_I_C As String = Nothing 
	Protected m_Parcial_II As Nullable(Of Integer) 
	Protected m_Parcial_II_C As String = Nothing 
	Protected m_Semestre_I As Nullable(Of Integer) 
	Protected m_Semestre_I_C As String = Nothing 
	Protected m_Parcial_III As Nullable(Of Integer) 
	Protected m_Parcial_III_C As String = Nothing 
	Protected m_Parcial_IV As Nullable(Of Integer) 
	Protected m_Parcial_IV_C As String = Nothing 
	Protected m_Semestre_II As Nullable(Of Integer) 
	Protected m_Semestre_II_C As String = Nothing 
	Protected m_Nota_Final As Nullable(Of Integer) 
	Protected m_Nota_Final_C As String = Nothing 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
#End Region

#Region " Propiedades "
	Public Property SraConsolidadoNotasID() As Integer
        Get
            Return (m_SraConsolidadoNotasID)
        End Get
		Set(ByVal Value As Integer)					
			m_SraConsolidadoNotasID = Value
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
	
	Public Property Parcial_I() As Integer
        Get
            Return (m_Parcial_I)
        End Get
		Set(ByVal Value As Integer)					
			m_Parcial_I = Value
		End Set
    End Property
	
	Public Property Parcial_I_C() As String
        Get
            Return (m_Parcial_I_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Parcial_I_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Parcial_I_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Parcial_I_C = Value
		End Set
    End Property
	
	Public Property Parcial_II() As Nullable(Of Integer)
        Get
            Return (m_Parcial_II)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Parcial_II = Value
		End Set
    End Property
	
	Public Property Parcial_II_C() As String
        Get
            Return (m_Parcial_II_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Parcial_II_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Parcial_II_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Parcial_II_C = Value
		End Set
    End Property
	
	Public Property Semestre_I() As Nullable(Of Integer)
        Get
            Return (m_Semestre_I)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Semestre_I = Value
		End Set
    End Property
	
	Public Property Semestre_I_C() As String
        Get
            Return (m_Semestre_I_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Semestre_I_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Semestre_I_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Semestre_I_C = Value
		End Set
    End Property
	
	Public Property Parcial_III() As Nullable(Of Integer)
        Get
            Return (m_Parcial_III)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Parcial_III = Value
		End Set
    End Property
	
	Public Property Parcial_III_C() As String
        Get
            Return (m_Parcial_III_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Parcial_III_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Parcial_III_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Parcial_III_C = Value
		End Set
    End Property
	
	Public Property Parcial_IV() As Nullable(Of Integer)
        Get
            Return (m_Parcial_IV)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Parcial_IV = Value
		End Set
    End Property
	
	Public Property Parcial_IV_C() As String
        Get
            Return (m_Parcial_IV_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Parcial_IV_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Parcial_IV_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Parcial_IV_C = Value
		End Set
    End Property
	
	Public Property Semestre_II() As Nullable(Of Integer)
        Get
            Return (m_Semestre_II)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Semestre_II = Value
		End Set
    End Property
	
	Public Property Semestre_II_C() As String
        Get
            Return (m_Semestre_II_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Semestre_II_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Semestre_II_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Semestre_II_C = Value
		End Set
    End Property
	
	Public Property Nota_Final() As Nullable(Of Integer)
        Get
            Return (m_Nota_Final)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Nota_Final = Value
		End Set
    End Property
	
	Public Property Nota_Final_C() As String
        Get
            Return (m_Nota_Final_C)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2 Then
					Throw New ArgumentOutOfRangeException("Nota_Final_C", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.Nota_Final_C. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2).")
				End If
			End If
			m_Nota_Final_C = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	
	Public Property UsuarioModificacion() As String
        Get
            Return (m_UsuarioModificacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 30 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SraConsolidadoNotas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (30).")
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Parcial_I_C"
				Return	2
			Case "Parcial_II_C"
				Return	2
			Case "Semestre_I_C"
				Return	2
			Case "Parcial_III_C"
				Return	2
			Case "Parcial_IV_C"
				Return	2
			Case "Semestre_II_C"
				Return	2
			Case "Nota_Final_C"
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
    ''' Salva un DataSet del tipo de la tabla SraConsolidadoNotas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SraConsolidadoNotas </param>    
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
			cmdDelete.Parameters.Add("@SraConsolidadoNotasID", SqlDbType.Int, 4, "SraConsolidadoNotasID" )
			cmdDelete.CommandText = "DELETE FROM  SraConsolidadoNotas WHERE SraConsolidadoNotasID= @SraConsolidadoNotasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdInsert.Parameters.Add("@Parcial_I", SqlDbType.Int, 4, "Parcial_I")
			cmdInsert.Parameters.Add("@Parcial_I_C", SqlDbType.VarChar, 2, "Parcial_I_C")
			cmdInsert.Parameters.Add("@Parcial_II", SqlDbType.Int, 4, "Parcial_II")
			cmdInsert.Parameters.Add("@Parcial_II_C", SqlDbType.VarChar, 2, "Parcial_II_C")
			cmdInsert.Parameters.Add("@Semestre_I", SqlDbType.Int, 4, "Semestre_I")
			cmdInsert.Parameters.Add("@Semestre_I_C", SqlDbType.VarChar, 2, "Semestre_I_C")
			cmdInsert.Parameters.Add("@Parcial_III", SqlDbType.Int, 4, "Parcial_III")
			cmdInsert.Parameters.Add("@Parcial_III_C", SqlDbType.VarChar, 2, "Parcial_III_C")
			cmdInsert.Parameters.Add("@Parcial_IV", SqlDbType.Int, 4, "Parcial_IV")
			cmdInsert.Parameters.Add("@Parcial_IV_C", SqlDbType.VarChar, 2, "Parcial_IV_C")
			cmdInsert.Parameters.Add("@Semestre_II", SqlDbType.Int, 4, "Semestre_II")
			cmdInsert.Parameters.Add("@Semestre_II_C", SqlDbType.VarChar, 2, "Semestre_II_C")
			cmdInsert.Parameters.Add("@Nota_Final", SqlDbType.Int, 4, "Nota_Final")
			cmdInsert.Parameters.Add("@Nota_Final_C", SqlDbType.VarChar, 2, "Nota_Final_C")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.CommandText = "INSERT INTO SraConsolidadoNotas ( objGrupoID, objAlumnoID, objAsignaturaID, Parcial_I, Parcial_I_C, Parcial_II, Parcial_II_C, Semestre_I, Semestre_I_C, Parcial_III, Parcial_III_C, Parcial_IV, Parcial_IV_C, Semestre_II, Semestre_II_C, Nota_Final, Nota_Final_C, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @objGrupoID, @objAlumnoID, @objAsignaturaID, @Parcial_I, @Parcial_I_C, @Parcial_II, @Parcial_II_C, @Semestre_I, @Semestre_I_C, @Parcial_III, @Parcial_III_C, @Parcial_IV, @Parcial_IV_C, @Semestre_II, @Semestre_II_C, @Nota_Final, @Nota_Final_C, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objGrupoID", SqlDbType.Int, 4, "objGrupoID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objAsignaturaID", SqlDbType.Int, 4, "objAsignaturaID")
			cmdUpdate.Parameters.Add("@Parcial_I", SqlDbType.Int, 4, "Parcial_I")
			cmdUpdate.Parameters.Add("@Parcial_I_C", SqlDbType.VarChar, 2, "Parcial_I_C")
			cmdUpdate.Parameters.Add("@Parcial_II", SqlDbType.Int, 4, "Parcial_II")
			cmdUpdate.Parameters.Add("@Parcial_II_C", SqlDbType.VarChar, 2, "Parcial_II_C")
			cmdUpdate.Parameters.Add("@Semestre_I", SqlDbType.Int, 4, "Semestre_I")
			cmdUpdate.Parameters.Add("@Semestre_I_C", SqlDbType.VarChar, 2, "Semestre_I_C")
			cmdUpdate.Parameters.Add("@Parcial_III", SqlDbType.Int, 4, "Parcial_III")
			cmdUpdate.Parameters.Add("@Parcial_III_C", SqlDbType.VarChar, 2, "Parcial_III_C")
			cmdUpdate.Parameters.Add("@Parcial_IV", SqlDbType.Int, 4, "Parcial_IV")
			cmdUpdate.Parameters.Add("@Parcial_IV_C", SqlDbType.VarChar, 2, "Parcial_IV_C")
			cmdUpdate.Parameters.Add("@Semestre_II", SqlDbType.Int, 4, "Semestre_II")
			cmdUpdate.Parameters.Add("@Semestre_II_C", SqlDbType.VarChar, 2, "Semestre_II_C")
			cmdUpdate.Parameters.Add("@Nota_Final", SqlDbType.Int, 4, "Nota_Final")
			cmdUpdate.Parameters.Add("@Nota_Final_C", SqlDbType.VarChar, 2, "Nota_Final_C")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 30, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 30, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@wSraConsolidadoNotasID", SqlDbType.Int, 4, "SraConsolidadoNotasID")
			cmdUpdate.CommandText = "UPDATE SraConsolidadoNotas SET objGrupoID=@objGrupoID, objAlumnoID=@objAlumnoID, objAsignaturaID=@objAsignaturaID, Parcial_I=@Parcial_I, Parcial_I_C=@Parcial_I_C, Parcial_II=@Parcial_II, Parcial_II_C=@Parcial_II_C, Semestre_I=@Semestre_I, Semestre_I_C=@Semestre_I_C, Parcial_III=@Parcial_III, Parcial_III_C=@Parcial_III_C, Parcial_IV=@Parcial_IV, Parcial_IV_C=@Parcial_IV_C, Semestre_II=@Semestre_II, Semestre_II_C=@Semestre_II_C, Nota_Final=@Nota_Final, Nota_Final_C=@Nota_Final_C, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SraConsolidadoNotasID= @wSraConsolidadoNotasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SraConsolidadoNotas")
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
    ''' Devuelve de la base de datos un objeto SraConsolidadoNotas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SraConsolidadoNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraConsolidadoNotas where " & " SraConsolidadoNotasID = " & p_SraConsolidadoNotasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SraConsolidadoNotasID = dr("SraConsolidadoNotasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_Parcial_I = IIf(IsDBNull(dr("Parcial_I")), Nothing, dr("Parcial_I"))
				m_Parcial_I_C = IIf(IsDBNull(dr("Parcial_I_C")), Nothing, dr("Parcial_I_C"))
				m_Parcial_II = IIf(IsDBNull(dr("Parcial_II")), Nothing, dr("Parcial_II"))
				m_Parcial_II_C = IIf(IsDBNull(dr("Parcial_II_C")), Nothing, dr("Parcial_II_C"))
				m_Semestre_I = IIf(IsDBNull(dr("Semestre_I")), Nothing, dr("Semestre_I"))
				m_Semestre_I_C = IIf(IsDBNull(dr("Semestre_I_C")), Nothing, dr("Semestre_I_C"))
				m_Parcial_III = IIf(IsDBNull(dr("Parcial_III")), Nothing, dr("Parcial_III"))
				m_Parcial_III_C = IIf(IsDBNull(dr("Parcial_III_C")), Nothing, dr("Parcial_III_C"))
				m_Parcial_IV = IIf(IsDBNull(dr("Parcial_IV")), Nothing, dr("Parcial_IV"))
				m_Parcial_IV_C = IIf(IsDBNull(dr("Parcial_IV_C")), Nothing, dr("Parcial_IV_C"))
				m_Semestre_II = IIf(IsDBNull(dr("Semestre_II")), Nothing, dr("Semestre_II"))
				m_Semestre_II_C = IIf(IsDBNull(dr("Semestre_II_C")), Nothing, dr("Semestre_II_C"))
				m_Nota_Final = IIf(IsDBNull(dr("Nota_Final")), Nothing, dr("Nota_Final"))
				m_Nota_Final_C = IIf(IsDBNull(dr("Nota_Final_C")), Nothing, dr("Nota_Final_C"))
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
    ''' Devuelve de la base de datos un objeto SraConsolidadoNotas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SraConsolidadoNotas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SraConsolidadoNotasID = dr("SraConsolidadoNotasID")
				m_objGrupoID = IIf(IsDBNull(dr("objGrupoID")), Nothing, dr("objGrupoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objAsignaturaID = IIf(IsDBNull(dr("objAsignaturaID")), Nothing, dr("objAsignaturaID"))
				m_Parcial_I = IIf(IsDBNull(dr("Parcial_I")), Nothing, dr("Parcial_I"))
				m_Parcial_I_C = IIf(IsDBNull(dr("Parcial_I_C")), Nothing, dr("Parcial_I_C"))
				m_Parcial_II = IIf(IsDBNull(dr("Parcial_II")), Nothing, dr("Parcial_II"))
				m_Parcial_II_C = IIf(IsDBNull(dr("Parcial_II_C")), Nothing, dr("Parcial_II_C"))
				m_Semestre_I = IIf(IsDBNull(dr("Semestre_I")), Nothing, dr("Semestre_I"))
				m_Semestre_I_C = IIf(IsDBNull(dr("Semestre_I_C")), Nothing, dr("Semestre_I_C"))
				m_Parcial_III = IIf(IsDBNull(dr("Parcial_III")), Nothing, dr("Parcial_III"))
				m_Parcial_III_C = IIf(IsDBNull(dr("Parcial_III_C")), Nothing, dr("Parcial_III_C"))
				m_Parcial_IV = IIf(IsDBNull(dr("Parcial_IV")), Nothing, dr("Parcial_IV"))
				m_Parcial_IV_C = IIf(IsDBNull(dr("Parcial_IV_C")), Nothing, dr("Parcial_IV_C"))
				m_Semestre_II = IIf(IsDBNull(dr("Semestre_II")), Nothing, dr("Semestre_II"))
				m_Semestre_II_C = IIf(IsDBNull(dr("Semestre_II_C")), Nothing, dr("Semestre_II_C"))
				m_Nota_Final = IIf(IsDBNull(dr("Nota_Final")), Nothing, dr("Nota_Final"))
				m_Nota_Final_C = IIf(IsDBNull(dr("Nota_Final_C")), Nothing, dr("Nota_Final_C"))
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
    ''' Trae de la base de datos un conjunto de objetos SraConsolidadoNotas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SraConsolidadoNotas"

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
			ds.Tables(0).TableName = "SraConsolidadoNotas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraConsolidadoNotas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SraConsolidadoNotas"

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
			ds.Tables(0).TableName = "SraConsolidadoNotas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SraConsolidadoNotas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SraConsolidadoNotas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SraConsolidadoNotas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SraConsolidadoNotas("
		sCommand &= "objGrupoID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "objAsignaturaID,"
		sCommand &= "Parcial_I,"
		sCommand &= "Parcial_I_C,"
		sCommand &= "Parcial_II,"
		sCommand &= "Parcial_II_C,"
		sCommand &= "Semestre_I,"
		sCommand &= "Semestre_I_C,"
		sCommand &= "Parcial_III,"
		sCommand &= "Parcial_III_C,"
		sCommand &= "Parcial_IV,"
		sCommand &= "Parcial_IV_C,"
		sCommand &= "Semestre_II,"
		sCommand &= "Semestre_II_C,"
		sCommand &= "Nota_Final,"
		sCommand &= "Nota_Final_C,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion) values ("		
		sCommand &= "@objGrupoID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objAsignaturaID,"
		sCommand &= "@Parcial_I,"
		sCommand &= "@Parcial_I_C,"
		sCommand &= "@Parcial_II,"
		sCommand &= "@Parcial_II_C,"
		sCommand &= "@Semestre_I,"
		sCommand &= "@Semestre_I_C,"
		sCommand &= "@Parcial_III,"
		sCommand &= "@Parcial_III_C,"
		sCommand &= "@Parcial_IV,"
		sCommand &= "@Parcial_IV_C,"
		sCommand &= "@Semestre_II,"
		sCommand &= "@Semestre_II_C,"
		sCommand &= "@Nota_Final,"
		sCommand &= "@Nota_Final_C,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SraConsolidadoNotasID = SraConsolidadoNotasID from SraConsolidadoNotas where "		
		sCommand &= "SraConsolidadoNotasID = SCOPE_IDENTITY()"
		
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@SraConsolidadoNotasID", SqlDbType.Int)		
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
		arParams(4) = New SqlParameter("@Parcial_I", SqlDbType.Int)		
		If IsDBNull(m_Parcial_I) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Parcial_I
        End If
		arParams(5) = New SqlParameter("@Parcial_I_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_I_C) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Parcial_I_C
        End If
		arParams(6) = New SqlParameter("@Parcial_II", SqlDbType.Int)		
		If IsDBNull(m_Parcial_II) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Parcial_II
        End If
		arParams(7) = New SqlParameter("@Parcial_II_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_II_C) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Parcial_II_C
        End If
		arParams(8) = New SqlParameter("@Semestre_I", SqlDbType.Int)		
		If IsDBNull(m_Semestre_I) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Semestre_I
        End If
		arParams(9) = New SqlParameter("@Semestre_I_C", SqlDbType.VarChar)		
		If IsDBNull(m_Semestre_I_C) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Semestre_I_C
        End If
		arParams(10) = New SqlParameter("@Parcial_III", SqlDbType.Int)		
		If IsDBNull(m_Parcial_III) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Parcial_III
        End If
		arParams(11) = New SqlParameter("@Parcial_III_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_III_C) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Parcial_III_C
        End If
		arParams(12) = New SqlParameter("@Parcial_IV", SqlDbType.Int)		
		If IsDBNull(m_Parcial_IV) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Parcial_IV
        End If
		arParams(13) = New SqlParameter("@Parcial_IV_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_IV_C) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Parcial_IV_C
        End If
		arParams(14) = New SqlParameter("@Semestre_II", SqlDbType.Int)		
		If IsDBNull(m_Semestre_II) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Semestre_II
        End If
		arParams(15) = New SqlParameter("@Semestre_II_C", SqlDbType.VarChar)		
		If IsDBNull(m_Semestre_II_C) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Semestre_II_C
        End If
		arParams(16) = New SqlParameter("@Nota_Final", SqlDbType.Int)		
		If IsDBNull(m_Nota_Final) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Nota_Final
        End If
		arParams(17) = New SqlParameter("@Nota_Final_C", SqlDbType.VarChar)		
		If IsDBNull(m_Nota_Final_C) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Nota_Final_C
        End If
		arParams(18) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_UsuarioCreacion
        End If
		arParams(19) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_FechaCreacion
        End If
		arParams(20) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_UsuarioModificacion
        End If
		arParams(21) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FechaModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SraConsolidadoNotasID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SraConsolidadoNotas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SraConsolidadoNotas set "		
		sCommand &= "objGrupoID = @objGrupoID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objAsignaturaID = @objAsignaturaID,"
		sCommand &= "Parcial_I = @Parcial_I,"
		sCommand &= "Parcial_I_C = @Parcial_I_C,"
		sCommand &= "Parcial_II = @Parcial_II,"
		sCommand &= "Parcial_II_C = @Parcial_II_C,"
		sCommand &= "Semestre_I = @Semestre_I,"
		sCommand &= "Semestre_I_C = @Semestre_I_C,"
		sCommand &= "Parcial_III = @Parcial_III,"
		sCommand &= "Parcial_III_C = @Parcial_III_C,"
		sCommand &= "Parcial_IV = @Parcial_IV,"
		sCommand &= "Parcial_IV_C = @Parcial_IV_C,"
		sCommand &= "Semestre_II = @Semestre_II,"
		sCommand &= "Semestre_II_C = @Semestre_II_C,"
		sCommand &= "Nota_Final = @Nota_Final,"
		sCommand &= "Nota_Final_C = @Nota_Final_C,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion"		
		sCommand &= " where "	
		sCommand &= "SraConsolidadoNotasID = @SraConsolidadoNotasID"					
		
		Dim arParams(21) As SqlParameter
		arParams(0) = New SqlParameter("@SraConsolidadoNotasID", SqlDbType.Int)		
		If IsDBNull(m_SraConsolidadoNotasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SraConsolidadoNotasID
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
		arParams(4) = New SqlParameter("@Parcial_I", SqlDbType.Int)		
		If IsDBNull(m_Parcial_I) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Parcial_I
        End If
		arParams(5) = New SqlParameter("@Parcial_I_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_I_C) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Parcial_I_C
        End If
		arParams(6) = New SqlParameter("@Parcial_II", SqlDbType.Int)		
		If IsDBNull(m_Parcial_II) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Parcial_II
        End If
		arParams(7) = New SqlParameter("@Parcial_II_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_II_C) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Parcial_II_C
        End If
		arParams(8) = New SqlParameter("@Semestre_I", SqlDbType.Int)		
		If IsDBNull(m_Semestre_I) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Semestre_I
        End If
		arParams(9) = New SqlParameter("@Semestre_I_C", SqlDbType.VarChar)		
		If IsDBNull(m_Semestre_I_C) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Semestre_I_C
        End If
		arParams(10) = New SqlParameter("@Parcial_III", SqlDbType.Int)		
		If IsDBNull(m_Parcial_III) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Parcial_III
        End If
		arParams(11) = New SqlParameter("@Parcial_III_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_III_C) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Parcial_III_C
        End If
		arParams(12) = New SqlParameter("@Parcial_IV", SqlDbType.Int)		
		If IsDBNull(m_Parcial_IV) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Parcial_IV
        End If
		arParams(13) = New SqlParameter("@Parcial_IV_C", SqlDbType.VarChar)		
		If IsDBNull(m_Parcial_IV_C) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Parcial_IV_C
        End If
		arParams(14) = New SqlParameter("@Semestre_II", SqlDbType.Int)		
		If IsDBNull(m_Semestre_II) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Semestre_II
        End If
		arParams(15) = New SqlParameter("@Semestre_II_C", SqlDbType.VarChar)		
		If IsDBNull(m_Semestre_II_C) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Semestre_II_C
        End If
		arParams(16) = New SqlParameter("@Nota_Final", SqlDbType.Int)		
		If IsDBNull(m_Nota_Final) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_Nota_Final
        End If
		arParams(17) = New SqlParameter("@Nota_Final_C", SqlDbType.VarChar)		
		If IsDBNull(m_Nota_Final_C) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Nota_Final_C
        End If
		arParams(18) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_UsuarioCreacion
        End If
		arParams(19) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_FechaCreacion
        End If
		arParams(20) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_UsuarioModificacion
        End If
		arParams(21) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_FechaModificacion
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
    ''' Borra un objeto SraConsolidadoNotas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraConsolidadoNotas where " & " SraConsolidadoNotasID = " & m_SraConsolidadoNotasID
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
    ''' Borra un objeto SraConsolidadoNotas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SraConsolidadoNotasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraConsolidadoNotas where " & " SraConsolidadoNotasID = " & p_SraConsolidadoNotasID
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
    ''' Borra objetos SraConsolidadoNotas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SraConsolidadoNotas where " & pWhere
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
