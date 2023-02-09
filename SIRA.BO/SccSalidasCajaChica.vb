Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccSalidasCajaChica		

#Region " Variables Miembro " 
	Protected m_SccSalidasCajaChicaID As Integer 
	Protected m_objCajaChicaID As Nullable(Of Integer) 
	Protected m_objCajeroID As Nullable(Of Integer) 
	Protected m_objConceptoID As Nullable(Of Integer) 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_Disponible As Nullable(Of Decimal) 
	Protected m_Monto As Nullable(Of Decimal) 
	Protected m_TasaCambio As Nullable(Of Decimal) 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_Descripcion As String = Nothing 
	Protected m_Beneficiario As String = Nothing 
	Protected m_objCentroCostoID As Nullable(Of Integer) 
	Protected m_Generado As Nullable(Of Boolean) 
#End Region

#Region " Propiedades "
	Public Property SccSalidasCajaChicaID() As Integer
        Get
            Return (m_SccSalidasCajaChicaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccSalidasCajaChicaID = Value
		End Set
    End Property
	
	Public Property objCajaChicaID() As Nullable(Of Integer)
        Get
            Return (m_objCajaChicaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaChicaID = Value
		End Set
    End Property
	
	Public Property objCajeroID() As Nullable(Of Integer)
        Get
            Return (m_objCajeroID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajeroID = Value
		End Set
    End Property
	
	Public Property objConceptoID() As Nullable(Of Integer)
        Get
            Return (m_objConceptoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objConceptoID = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoID = Value
		End Set
    End Property
	
	Public Property objMonedaID() As Nullable(Of Integer)
        Get
            Return (m_objMonedaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objMonedaID = Value
		End Set
    End Property
	
	Public Property Disponible() As Nullable(Of Decimal)
        Get
            Return (m_Disponible)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Disponible = Value
		End Set
    End Property
	
	Public Property Monto() As Nullable(Of Decimal)
        Get
            Return (m_Monto)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Monto = Value
		End Set
    End Property
	
	Public Property TasaCambio() As Nullable(Of Decimal)
        Get
            Return (m_TasaCambio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TasaCambio = Value
		End Set
    End Property
	
	Public Property Fecha() As Nullable(Of Date)
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Nullable(Of Date))					
			m_Fecha = Value
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccSalidasCajaChica.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccSalidasCajaChica.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioCreacion = Value
		End Set
    End Property
	
	Public Property Descripcion() As String
        Get
            Return (m_Descripcion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Descripcion", Value.ToString(), "Valor inv?lido para SccSalidasCajaChica.Descripcion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Descripcion = Value
		End Set
    End Property
	
	Public Property Beneficiario() As String
        Get
            Return (m_Beneficiario)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("Beneficiario", Value.ToString(), "Valor inv?lido para SccSalidasCajaChica.Beneficiario. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_Beneficiario = Value
		End Set
    End Property
	
	Public Property objCentroCostoID() As Nullable(Of Integer)
        Get
            Return (m_objCentroCostoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCentroCostoID = Value
		End Set
    End Property
	
	Public Property Generado() As Nullable(Of Boolean)
        Get
            Return (m_Generado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Generado = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Disponible"
				Return	18
			Case "Monto"
				Return	18
			Case "TasaCambio"
				Return	18
			Case "UsuarioModificacion"
				Return	50
			Case "UsuarioCreacion"
				Return	50
			Case "Descripcion"
				Return	2147483645
			Case "Beneficiario"
				Return	100
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Disponible"
				Return	2
			Case "Monto"
				Return	2
			Case "TasaCambio"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccSalidasCajaChica en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccSalidasCajaChica </param>    
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
			cmdDelete.Parameters.Add("@SccSalidasCajaChicaID", SqlDbType.Int, 4, "SccSalidasCajaChicaID" )
			cmdDelete.CommandText = "DELETE FROM  SccSalidasCajaChica WHERE SccSalidasCajaChicaID= @SccSalidasCajaChicaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objCajaChicaID", SqlDbType.Int, 4, "objCajaChicaID")
			cmdInsert.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdInsert.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@Disponible", SqlDbType.Decimal, 9, "Disponible")
			cmdInsert.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@Descripcion", SqlDbType.VarChar, -1, "Descripcion")
			cmdInsert.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 100, "Beneficiario")
			cmdInsert.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdInsert.Parameters.Add("@Generado", SqlDbType.Bit, 1, "Generado")
			cmdInsert.CommandText = "INSERT INTO SccSalidasCajaChica ( objCajaChicaID, objCajeroID, objConceptoID, objEstadoID, objMonedaID, Disponible, Monto, TasaCambio, Fecha, FechaCreacion, UsuarioModificacion, FechaModificacion, UsuarioCreacion, Descripcion, Beneficiario, objCentroCostoID, Generado) VALUES ( @objCajaChicaID, @objCajeroID, @objConceptoID, @objEstadoID, @objMonedaID, @Disponible, @Monto, @TasaCambio, @Fecha, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @UsuarioCreacion, @Descripcion, @Beneficiario, @objCentroCostoID, @Generado)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objCajaChicaID", SqlDbType.Int, 4, "objCajaChicaID")
			cmdUpdate.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdUpdate.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@Disponible", SqlDbType.Decimal, 9, "Disponible")
			cmdUpdate.Parameters.Add("@Monto", SqlDbType.Decimal, 9, "Monto")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@Descripcion", SqlDbType.VarChar, -1, "Descripcion")
			cmdUpdate.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 100, "Beneficiario")
			cmdUpdate.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdUpdate.Parameters.Add("@Generado", SqlDbType.Bit, 1, "Generado")
			cmdUpdate.Parameters.Add("@wSccSalidasCajaChicaID", SqlDbType.Int, 4, "SccSalidasCajaChicaID")
			cmdUpdate.CommandText = "UPDATE SccSalidasCajaChica SET objCajaChicaID=@objCajaChicaID, objCajeroID=@objCajeroID, objConceptoID=@objConceptoID, objEstadoID=@objEstadoID, objMonedaID=@objMonedaID, Disponible=@Disponible, Monto=@Monto, TasaCambio=@TasaCambio, Fecha=@Fecha, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, UsuarioCreacion=@UsuarioCreacion, Descripcion=@Descripcion, Beneficiario=@Beneficiario, objCentroCostoID=@objCentroCostoID, Generado=@Generado WHERE SccSalidasCajaChicaID= @wSccSalidasCajaChicaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccSalidasCajaChica")
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
    ''' Devuelve de la base de datos un objeto SccSalidasCajaChica
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccSalidasCajaChicaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccSalidasCajaChica where " & " SccSalidasCajaChicaID = " & p_SccSalidasCajaChicaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccSalidasCajaChicaID = dr("SccSalidasCajaChicaID")
				m_objCajaChicaID = IIf(IsDBNull(dr("objCajaChicaID")), Nothing, dr("objCajaChicaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Disponible = IIf(IsDBNull(dr("Disponible")), Nothing, dr("Disponible"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_Beneficiario = IIf(IsDBNull(dr("Beneficiario")), Nothing, dr("Beneficiario"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_Generado = IIf(IsDBNull(dr("Generado")), Nothing, dr("Generado"))
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
    ''' Devuelve de la base de datos un objeto SccSalidasCajaChica usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccSalidasCajaChica where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccSalidasCajaChicaID = dr("SccSalidasCajaChicaID")
				m_objCajaChicaID = IIf(IsDBNull(dr("objCajaChicaID")), Nothing, dr("objCajaChicaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_Disponible = IIf(IsDBNull(dr("Disponible")), Nothing, dr("Disponible"))
				m_Monto = IIf(IsDBNull(dr("Monto")), Nothing, dr("Monto"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_Descripcion = IIf(IsDBNull(dr("Descripcion")), Nothing, dr("Descripcion"))
				m_Beneficiario = IIf(IsDBNull(dr("Beneficiario")), Nothing, dr("Beneficiario"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_Generado = IIf(IsDBNull(dr("Generado")), Nothing, dr("Generado"))
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
    ''' Trae de la base de datos un conjunto de objetos SccSalidasCajaChica en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccSalidasCajaChica"

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
			ds.Tables(0).TableName = "SccSalidasCajaChica"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccSalidasCajaChica en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccSalidasCajaChica"

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
			ds.Tables(0).TableName = "SccSalidasCajaChica"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccSalidasCajaChica en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccSalidasCajaChica"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccSalidasCajaChica.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccSalidasCajaChica("
		sCommand &= "objCajaChicaID,"
		sCommand &= "objCajeroID,"
		sCommand &= "objConceptoID,"
		sCommand &= "objEstadoID,"
		sCommand &= "objMonedaID,"
		sCommand &= "Disponible,"
		sCommand &= "Monto,"
		sCommand &= "TasaCambio,"
		sCommand &= "Fecha,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "Descripcion,"
		sCommand &= "Beneficiario,"
		sCommand &= "objCentroCostoID,"
		sCommand &= "Generado) values ("		
		sCommand &= "@objCajaChicaID,"
		sCommand &= "@objCajeroID,"
		sCommand &= "@objConceptoID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@Disponible,"
		sCommand &= "@Monto,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@Fecha,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@Descripcion,"
		sCommand &= "@Beneficiario,"
		sCommand &= "@objCentroCostoID,"
		sCommand &= "@Generado)"		
	
		sCommand &= " select "
		sCommand &= "@SccSalidasCajaChicaID = SccSalidasCajaChicaID from SccSalidasCajaChica where "		
		sCommand &= "SccSalidasCajaChicaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccSalidasCajaChicaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objCajaChicaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaChicaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaChicaID
        End If
		arParams(2) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroID
        End If
		arParams(3) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objConceptoID
        End If
		arParams(4) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEstadoID
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@Disponible", SqlDbType.Decimal)		
		If IsDBNull(m_Disponible) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Disponible
        End If
		arParams(7) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Monto
        End If
		arParams(8) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_TasaCambio
        End If
		arParams(9) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Fecha
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Descripcion
        End If
		arParams(15) = New SqlParameter("@Beneficiario", SqlDbType.VarChar)		
		If IsDBNull(m_Beneficiario) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Beneficiario
        End If
		arParams(16) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objCentroCostoID
        End If
		arParams(17) = New SqlParameter("@Generado", SqlDbType.Bit)		
		If IsDBNull(m_Generado) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Generado
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccSalidasCajaChicaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccSalidasCajaChica en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccSalidasCajaChica set "		
		sCommand &= "objCajaChicaID = @objCajaChicaID,"
		sCommand &= "objCajeroID = @objCajeroID,"
		sCommand &= "objConceptoID = @objConceptoID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "Disponible = @Disponible,"
		sCommand &= "Monto = @Monto,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "Descripcion = @Descripcion,"
		sCommand &= "Beneficiario = @Beneficiario,"
		sCommand &= "objCentroCostoID = @objCentroCostoID,"
		sCommand &= "Generado = @Generado"		
		sCommand &= " where "	
		sCommand &= "SccSalidasCajaChicaID = @SccSalidasCajaChicaID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccSalidasCajaChicaID", SqlDbType.Int)		
		If IsDBNull(m_SccSalidasCajaChicaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccSalidasCajaChicaID
        End If
		arParams(1) = New SqlParameter("@objCajaChicaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaChicaID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objCajaChicaID
        End If
		arParams(2) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCajeroID
        End If
		arParams(3) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objConceptoID
        End If
		arParams(4) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objEstadoID
        End If
		arParams(5) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objMonedaID
        End If
		arParams(6) = New SqlParameter("@Disponible", SqlDbType.Decimal)		
		If IsDBNull(m_Disponible) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Disponible
        End If
		arParams(7) = New SqlParameter("@Monto", SqlDbType.Decimal)		
		If IsDBNull(m_Monto) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_Monto
        End If
		arParams(8) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_TasaCambio
        End If
		arParams(9) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Fecha
        End If
		arParams(10) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_FechaCreacion
        End If
		arParams(11) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_UsuarioModificacion
        End If
		arParams(12) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_FechaModificacion
        End If
		arParams(13) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_UsuarioCreacion
        End If
		arParams(14) = New SqlParameter("@Descripcion", SqlDbType.VarChar)		
		If IsDBNull(m_Descripcion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_Descripcion
        End If
		arParams(15) = New SqlParameter("@Beneficiario", SqlDbType.VarChar)		
		If IsDBNull(m_Beneficiario) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_Beneficiario
        End If
		arParams(16) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objCentroCostoID
        End If
		arParams(17) = New SqlParameter("@Generado", SqlDbType.Bit)		
		If IsDBNull(m_Generado) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Generado
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
    ''' Borra un objeto SccSalidasCajaChica de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasCajaChica where " & " SccSalidasCajaChicaID = " & m_SccSalidasCajaChicaID
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
    ''' Borra un objeto SccSalidasCajaChica de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccSalidasCajaChicaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasCajaChica where " & " SccSalidasCajaChicaID = " & p_SccSalidasCajaChicaID
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
    ''' Borra objetos SccSalidasCajaChica de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccSalidasCajaChica where " & pWhere
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
