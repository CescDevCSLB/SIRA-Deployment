Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccConsolidadoMora		

#Region " Variables Miembro " 
	Protected m_SccMoraID As Integer 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_Enero As Nullable(Of Decimal) 
	Protected m_Febrero As Nullable(Of Decimal) 
	Protected m_Marzo As Nullable(Of Decimal) 
	Protected m_Abril As Nullable(Of Decimal) 
	Protected m_Mayo As Nullable(Of Decimal) 
	Protected m_Junio As Nullable(Of Decimal) 
	Protected m_Julio As Nullable(Of Decimal) 
	Protected m_Agosto As Nullable(Of Decimal) 
	Protected m_Septiembre As Nullable(Of Decimal) 
	Protected m_Octubre As Nullable(Of Decimal) 
	Protected m_Noviembre As Nullable(Of Decimal) 
	Protected m_Diciembre As Nullable(Of Decimal) 
#End Region

#Region " Propiedades "
	Public Property SccMoraID() As Integer
        Get
            Return (m_SccMoraID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccMoraID = Value
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
	
	Public Property objPeriodoID() As Nullable(Of Integer)
        Get
            Return (m_objPeriodoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPeriodoID = Value
		End Set
    End Property
	
	Public Property Enero() As Nullable(Of Decimal)
        Get
            Return (m_Enero)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Enero = Value
		End Set
    End Property
	
	Public Property Febrero() As Nullable(Of Decimal)
        Get
            Return (m_Febrero)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Febrero = Value
		End Set
    End Property
	
	Public Property Marzo() As Nullable(Of Decimal)
        Get
            Return (m_Marzo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Marzo = Value
		End Set
    End Property
	
	Public Property Abril() As Nullable(Of Decimal)
        Get
            Return (m_Abril)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Abril = Value
		End Set
    End Property
	
	Public Property Mayo() As Nullable(Of Decimal)
        Get
            Return (m_Mayo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Mayo = Value
		End Set
    End Property
	
	Public Property Junio() As Nullable(Of Decimal)
        Get
            Return (m_Junio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Junio = Value
		End Set
    End Property
	
	Public Property Julio() As Nullable(Of Decimal)
        Get
            Return (m_Julio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Julio = Value
		End Set
    End Property
	
	Public Property Agosto() As Nullable(Of Decimal)
        Get
            Return (m_Agosto)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Agosto = Value
		End Set
    End Property
	
	Public Property Septiembre() As Nullable(Of Decimal)
        Get
            Return (m_Septiembre)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Septiembre = Value
		End Set
    End Property
	
	Public Property Octubre() As Nullable(Of Decimal)
        Get
            Return (m_Octubre)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Octubre = Value
		End Set
    End Property
	
	Public Property Noviembre() As Nullable(Of Decimal)
        Get
            Return (m_Noviembre)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Noviembre = Value
		End Set
    End Property
	
	Public Property Diciembre() As Nullable(Of Decimal)
        Get
            Return (m_Diciembre)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Diciembre = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Enero"
				Return	18
			Case "Febrero"
				Return	18
			Case "Marzo"
				Return	18
			Case "Abril"
				Return	18
			Case "Mayo"
				Return	18
			Case "Junio"
				Return	18
			Case "Julio"
				Return	18
			Case "Agosto"
				Return	18
			Case "Septiembre"
				Return	18
			Case "Octubre"
				Return	18
			Case "Noviembre"
				Return	18
			Case "Diciembre"
				Return	18
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Enero"
				Return	2
			Case "Febrero"
				Return	2
			Case "Marzo"
				Return	2
			Case "Abril"
				Return	2
			Case "Mayo"
				Return	2
			Case "Junio"
				Return	2
			Case "Julio"
				Return	2
			Case "Agosto"
				Return	2
			Case "Septiembre"
				Return	2
			Case "Octubre"
				Return	2
			Case "Noviembre"
				Return	2
			Case "Diciembre"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccConsolidadoMora en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccConsolidadoMora </param>    
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
			cmdDelete.Parameters.Add("@SccMoraID", SqlDbType.Int, 4, "SccMoraID" )
			cmdDelete.CommandText = "DELETE FROM  SccConsolidadoMora WHERE SccMoraID= @SccMoraID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@Enero", SqlDbType.Decimal, 9, "Enero")
			cmdInsert.Parameters.Add("@Febrero", SqlDbType.Decimal, 9, "Febrero")
			cmdInsert.Parameters.Add("@Marzo", SqlDbType.Decimal, 9, "Marzo")
			cmdInsert.Parameters.Add("@Abril", SqlDbType.Decimal, 9, "Abril")
			cmdInsert.Parameters.Add("@Mayo", SqlDbType.Decimal, 9, "Mayo")
			cmdInsert.Parameters.Add("@Junio", SqlDbType.Decimal, 9, "Junio")
			cmdInsert.Parameters.Add("@Julio", SqlDbType.Decimal, 9, "Julio")
			cmdInsert.Parameters.Add("@Agosto", SqlDbType.Decimal, 9, "Agosto")
			cmdInsert.Parameters.Add("@Septiembre", SqlDbType.Decimal, 9, "Septiembre")
			cmdInsert.Parameters.Add("@Octubre", SqlDbType.Decimal, 9, "Octubre")
			cmdInsert.Parameters.Add("@Noviembre", SqlDbType.Decimal, 9, "Noviembre")
			cmdInsert.Parameters.Add("@Diciembre", SqlDbType.Decimal, 9, "Diciembre")
			cmdInsert.CommandText = "INSERT INTO SccConsolidadoMora ( objAlumnoID, objPeriodoID, Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre) VALUES ( @objAlumnoID, @objPeriodoID, @Enero, @Febrero, @Marzo, @Abril, @Mayo, @Junio, @Julio, @Agosto, @Septiembre, @Octubre, @Noviembre, @Diciembre)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@Enero", SqlDbType.Decimal, 9, "Enero")
			cmdUpdate.Parameters.Add("@Febrero", SqlDbType.Decimal, 9, "Febrero")
			cmdUpdate.Parameters.Add("@Marzo", SqlDbType.Decimal, 9, "Marzo")
			cmdUpdate.Parameters.Add("@Abril", SqlDbType.Decimal, 9, "Abril")
			cmdUpdate.Parameters.Add("@Mayo", SqlDbType.Decimal, 9, "Mayo")
			cmdUpdate.Parameters.Add("@Junio", SqlDbType.Decimal, 9, "Junio")
			cmdUpdate.Parameters.Add("@Julio", SqlDbType.Decimal, 9, "Julio")
			cmdUpdate.Parameters.Add("@Agosto", SqlDbType.Decimal, 9, "Agosto")
			cmdUpdate.Parameters.Add("@Septiembre", SqlDbType.Decimal, 9, "Septiembre")
			cmdUpdate.Parameters.Add("@Octubre", SqlDbType.Decimal, 9, "Octubre")
			cmdUpdate.Parameters.Add("@Noviembre", SqlDbType.Decimal, 9, "Noviembre")
			cmdUpdate.Parameters.Add("@Diciembre", SqlDbType.Decimal, 9, "Diciembre")
			cmdUpdate.Parameters.Add("@wSccMoraID", SqlDbType.Int, 4, "SccMoraID")
			cmdUpdate.CommandText = "UPDATE SccConsolidadoMora SET objAlumnoID=@objAlumnoID, objPeriodoID=@objPeriodoID, Enero=@Enero, Febrero=@Febrero, Marzo=@Marzo, Abril=@Abril, Mayo=@Mayo, Junio=@Junio, Julio=@Julio, Agosto=@Agosto, Septiembre=@Septiembre, Octubre=@Octubre, Noviembre=@Noviembre, Diciembre=@Diciembre WHERE SccMoraID= @wSccMoraID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccConsolidadoMora")
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
    ''' Devuelve de la base de datos un objeto SccConsolidadoMora
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccMoraID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccConsolidadoMora where " & " SccMoraID = " & p_SccMoraID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccMoraID = dr("SccMoraID")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Enero = IIf(IsDBNull(dr("Enero")), Nothing, dr("Enero"))
				m_Febrero = IIf(IsDBNull(dr("Febrero")), Nothing, dr("Febrero"))
				m_Marzo = IIf(IsDBNull(dr("Marzo")), Nothing, dr("Marzo"))
				m_Abril = IIf(IsDBNull(dr("Abril")), Nothing, dr("Abril"))
				m_Mayo = IIf(IsDBNull(dr("Mayo")), Nothing, dr("Mayo"))
				m_Junio = IIf(IsDBNull(dr("Junio")), Nothing, dr("Junio"))
				m_Julio = IIf(IsDBNull(dr("Julio")), Nothing, dr("Julio"))
				m_Agosto = IIf(IsDBNull(dr("Agosto")), Nothing, dr("Agosto"))
				m_Septiembre = IIf(IsDBNull(dr("Septiembre")), Nothing, dr("Septiembre"))
				m_Octubre = IIf(IsDBNull(dr("Octubre")), Nothing, dr("Octubre"))
				m_Noviembre = IIf(IsDBNull(dr("Noviembre")), Nothing, dr("Noviembre"))
				m_Diciembre = IIf(IsDBNull(dr("Diciembre")), Nothing, dr("Diciembre"))
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
    ''' Devuelve de la base de datos un objeto SccConsolidadoMora usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccConsolidadoMora where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccMoraID = dr("SccMoraID")
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Enero = IIf(IsDBNull(dr("Enero")), Nothing, dr("Enero"))
				m_Febrero = IIf(IsDBNull(dr("Febrero")), Nothing, dr("Febrero"))
				m_Marzo = IIf(IsDBNull(dr("Marzo")), Nothing, dr("Marzo"))
				m_Abril = IIf(IsDBNull(dr("Abril")), Nothing, dr("Abril"))
				m_Mayo = IIf(IsDBNull(dr("Mayo")), Nothing, dr("Mayo"))
				m_Junio = IIf(IsDBNull(dr("Junio")), Nothing, dr("Junio"))
				m_Julio = IIf(IsDBNull(dr("Julio")), Nothing, dr("Julio"))
				m_Agosto = IIf(IsDBNull(dr("Agosto")), Nothing, dr("Agosto"))
				m_Septiembre = IIf(IsDBNull(dr("Septiembre")), Nothing, dr("Septiembre"))
				m_Octubre = IIf(IsDBNull(dr("Octubre")), Nothing, dr("Octubre"))
				m_Noviembre = IIf(IsDBNull(dr("Noviembre")), Nothing, dr("Noviembre"))
				m_Diciembre = IIf(IsDBNull(dr("Diciembre")), Nothing, dr("Diciembre"))
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
    ''' Trae de la base de datos un conjunto de objetos SccConsolidadoMora en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccConsolidadoMora"

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
			ds.Tables(0).TableName = "SccConsolidadoMora"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccConsolidadoMora en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccConsolidadoMora"

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
			ds.Tables(0).TableName = "SccConsolidadoMora"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccConsolidadoMora en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccConsolidadoMora"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccConsolidadoMora.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccConsolidadoMora("
		sCommand &= "objAlumnoID,"
		sCommand &= "objPeriodoID,"
		sCommand &= "Enero,"
		sCommand &= "Febrero,"
		sCommand &= "Marzo,"
		sCommand &= "Abril,"
		sCommand &= "Mayo,"
		sCommand &= "Junio,"
		sCommand &= "Julio,"
		sCommand &= "Agosto,"
		sCommand &= "Septiembre,"
		sCommand &= "Octubre,"
		sCommand &= "Noviembre,"
		sCommand &= "Diciembre) values ("		
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@Enero,"
		sCommand &= "@Febrero,"
		sCommand &= "@Marzo,"
		sCommand &= "@Abril,"
		sCommand &= "@Mayo,"
		sCommand &= "@Junio,"
		sCommand &= "@Julio,"
		sCommand &= "@Agosto,"
		sCommand &= "@Septiembre,"
		sCommand &= "@Octubre,"
		sCommand &= "@Noviembre,"
		sCommand &= "@Diciembre)"		
	
		sCommand &= " select "
		sCommand &= "@SccMoraID = SccMoraID from SccConsolidadoMora where "		
		sCommand &= "SccMoraID = SCOPE_IDENTITY()"
		
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SccMoraID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objPeriodoID
        End If
		arParams(3) = New SqlParameter("@Enero", SqlDbType.Decimal)		
		If IsDBNull(m_Enero) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Enero
        End If
		arParams(4) = New SqlParameter("@Febrero", SqlDbType.Decimal)		
		If IsDBNull(m_Febrero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Febrero
        End If
		arParams(5) = New SqlParameter("@Marzo", SqlDbType.Decimal)		
		If IsDBNull(m_Marzo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Marzo
        End If
		arParams(6) = New SqlParameter("@Abril", SqlDbType.Decimal)		
		If IsDBNull(m_Abril) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Abril
        End If
		arParams(7) = New SqlParameter("@Mayo", SqlDbType.Decimal)		
		If IsDBNull(m_Mayo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Mayo
        End If
		arParams(8) = New SqlParameter("@Junio", SqlDbType.Decimal)		
		If IsDBNull(m_Junio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Junio
        End If
		arParams(9) = New SqlParameter("@Julio", SqlDbType.Decimal)		
		If IsDBNull(m_Julio) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Julio
        End If
		arParams(10) = New SqlParameter("@Agosto", SqlDbType.Decimal)		
		If IsDBNull(m_Agosto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Agosto
        End If
		arParams(11) = New SqlParameter("@Septiembre", SqlDbType.Decimal)		
		If IsDBNull(m_Septiembre) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Septiembre
        End If
		arParams(12) = New SqlParameter("@Octubre", SqlDbType.Decimal)		
		If IsDBNull(m_Octubre) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Octubre
        End If
		arParams(13) = New SqlParameter("@Noviembre", SqlDbType.Decimal)		
		If IsDBNull(m_Noviembre) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Noviembre
        End If
		arParams(14) = New SqlParameter("@Diciembre", SqlDbType.Decimal)		
		If IsDBNull(m_Diciembre) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Diciembre
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccMoraID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccConsolidadoMora en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccConsolidadoMora set "		
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "Enero = @Enero,"
		sCommand &= "Febrero = @Febrero,"
		sCommand &= "Marzo = @Marzo,"
		sCommand &= "Abril = @Abril,"
		sCommand &= "Mayo = @Mayo,"
		sCommand &= "Junio = @Junio,"
		sCommand &= "Julio = @Julio,"
		sCommand &= "Agosto = @Agosto,"
		sCommand &= "Septiembre = @Septiembre,"
		sCommand &= "Octubre = @Octubre,"
		sCommand &= "Noviembre = @Noviembre,"
		sCommand &= "Diciembre = @Diciembre"		
		sCommand &= " where "	
		sCommand &= "SccMoraID = @SccMoraID"					
		
		Dim arParams(14) As SqlParameter
		arParams(0) = New SqlParameter("@SccMoraID", SqlDbType.Int)		
		If IsDBNull(m_SccMoraID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccMoraID
        End If
		arParams(1) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objAlumnoID
        End If
		arParams(2) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objPeriodoID
        End If
		arParams(3) = New SqlParameter("@Enero", SqlDbType.Decimal)		
		If IsDBNull(m_Enero) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Enero
        End If
		arParams(4) = New SqlParameter("@Febrero", SqlDbType.Decimal)		
		If IsDBNull(m_Febrero) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Febrero
        End If
		arParams(5) = New SqlParameter("@Marzo", SqlDbType.Decimal)		
		If IsDBNull(m_Marzo) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Marzo
        End If
		arParams(6) = New SqlParameter("@Abril", SqlDbType.Decimal)		
		If IsDBNull(m_Abril) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Abril
        End If
		arParams(7) = New SqlParameter("@Mayo", SqlDbType.Decimal)		
		If IsDBNull(m_Mayo) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Mayo
        End If
		arParams(8) = New SqlParameter("@Junio", SqlDbType.Decimal)		
		If IsDBNull(m_Junio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Junio
        End If
		arParams(9) = New SqlParameter("@Julio", SqlDbType.Decimal)		
		If IsDBNull(m_Julio) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Julio
        End If
		arParams(10) = New SqlParameter("@Agosto", SqlDbType.Decimal)		
		If IsDBNull(m_Agosto) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Agosto
        End If
		arParams(11) = New SqlParameter("@Septiembre", SqlDbType.Decimal)		
		If IsDBNull(m_Septiembre) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Septiembre
        End If
		arParams(12) = New SqlParameter("@Octubre", SqlDbType.Decimal)		
		If IsDBNull(m_Octubre) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Octubre
        End If
		arParams(13) = New SqlParameter("@Noviembre", SqlDbType.Decimal)		
		If IsDBNull(m_Noviembre) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_Noviembre
        End If
		arParams(14) = New SqlParameter("@Diciembre", SqlDbType.Decimal)		
		If IsDBNull(m_Diciembre) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Diciembre
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
    ''' Borra un objeto SccConsolidadoMora de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccConsolidadoMora where " & " SccMoraID = " & m_SccMoraID
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
    ''' Borra un objeto SccConsolidadoMora de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccMoraID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccConsolidadoMora where " & " SccMoraID = " & p_SccMoraID
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
    ''' Borra objetos SccConsolidadoMora de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccConsolidadoMora where " & pWhere
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
