Imports DAL
Imports System.Data.SqlClient

Partial Public Class SContConceptosCuentas		

#Region " Variables Miembro " 
	Protected m_SContConceptosCuentasID As Integer 
	Protected m_TipoConcepto As String = Nothing 
	Protected m_objConceptoID As Nullable(Of Integer) 
	Protected m_objCentroCostoID As Nullable(Of Integer) 
	Protected m_objCuentaContableID As Nullable(Of Integer) 
	Protected m_objContraCuentaID As Nullable(Of Integer) 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SContConceptosCuentasID() As Integer
        Get
            Return (m_SContConceptosCuentasID)
        End Get
		Set(ByVal Value As Integer)					
			m_SContConceptosCuentasID = Value
		End Set
    End Property
	
	Public Property TipoConcepto() As String
        Get
            Return (m_TipoConcepto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("TipoConcepto", Value.ToString(), "Valor inv?lido para SContConceptosCuentas.TipoConcepto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_TipoConcepto = Value
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
	
	Public Property objCentroCostoID() As Nullable(Of Integer)
        Get
            Return (m_objCentroCostoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCentroCostoID = Value
		End Set
    End Property
	
	Public Property objCuentaContableID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaContableID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaContableID = Value
		End Set
    End Property
	
	Public Property objContraCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objContraCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objContraCuentaID = Value
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SContConceptosCuentas.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SContConceptosCuentas.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "TipoConcepto"
				Return	50
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
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
    ''' Salva un DataSet del tipo de la tabla SContConceptosCuentas en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SContConceptosCuentas </param>    
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
			cmdDelete.Parameters.Add("@SContConceptosCuentasID", SqlDbType.Int, 4, "SContConceptosCuentasID" )
			cmdDelete.CommandText = "DELETE FROM  SContConceptosCuentas WHERE SContConceptosCuentasID= @SContConceptosCuentasID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@TipoConcepto", SqlDbType.VarChar, 50, "TipoConcepto")
			cmdInsert.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdInsert.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdInsert.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdInsert.Parameters.Add("@objContraCuentaID", SqlDbType.Int, 4, "objContraCuentaID")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO SContConceptosCuentas ( TipoConcepto, objConceptoID, objCentroCostoID, objCuentaContableID, objContraCuentaID, Activa, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @TipoConcepto, @objConceptoID, @objCentroCostoID, @objCuentaContableID, @objContraCuentaID, @Activa, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@TipoConcepto", SqlDbType.VarChar, 50, "TipoConcepto")
			cmdUpdate.Parameters.Add("@objConceptoID", SqlDbType.Int, 4, "objConceptoID")
			cmdUpdate.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdUpdate.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdUpdate.Parameters.Add("@objContraCuentaID", SqlDbType.Int, 4, "objContraCuentaID")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wSContConceptosCuentasID", SqlDbType.Int, 4, "SContConceptosCuentasID")
			cmdUpdate.CommandText = "UPDATE SContConceptosCuentas SET TipoConcepto=@TipoConcepto, objConceptoID=@objConceptoID, objCentroCostoID=@objCentroCostoID, objCuentaContableID=@objCuentaContableID, objContraCuentaID=@objContraCuentaID, Activa=@Activa, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE SContConceptosCuentasID= @wSContConceptosCuentasID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SContConceptosCuentas")
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
    ''' Devuelve de la base de datos un objeto SContConceptosCuentas
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SContConceptosCuentasID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContConceptosCuentas where " & " SContConceptosCuentasID = " & p_SContConceptosCuentasID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SContConceptosCuentasID = dr("SContConceptosCuentasID")
				m_TipoConcepto = IIf(IsDBNull(dr("TipoConcepto")), Nothing, dr("TipoConcepto"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_objContraCuentaID = IIf(IsDBNull(dr("objContraCuentaID")), Nothing, dr("objContraCuentaID"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
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
    ''' Devuelve de la base de datos un objeto SContConceptosCuentas usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SContConceptosCuentas where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SContConceptosCuentasID = dr("SContConceptosCuentasID")
				m_TipoConcepto = IIf(IsDBNull(dr("TipoConcepto")), Nothing, dr("TipoConcepto"))
				m_objConceptoID = IIf(IsDBNull(dr("objConceptoID")), Nothing, dr("objConceptoID"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_objContraCuentaID = IIf(IsDBNull(dr("objContraCuentaID")), Nothing, dr("objContraCuentaID"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
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
    ''' Trae de la base de datos un conjunto de objetos SContConceptosCuentas en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SContConceptosCuentas"

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
			ds.Tables(0).TableName = "SContConceptosCuentas"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContConceptosCuentas en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SContConceptosCuentas"

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
			ds.Tables(0).TableName = "SContConceptosCuentas"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SContConceptosCuentas en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SContConceptosCuentas"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SContConceptosCuentas.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SContConceptosCuentas("
		sCommand &= "TipoConcepto,"
		sCommand &= "objConceptoID,"
		sCommand &= "objCentroCostoID,"
		sCommand &= "objCuentaContableID,"
		sCommand &= "objContraCuentaID,"
		sCommand &= "Activa,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@TipoConcepto,"
		sCommand &= "@objConceptoID,"
		sCommand &= "@objCentroCostoID,"
		sCommand &= "@objCuentaContableID,"
		sCommand &= "@objContraCuentaID,"
		sCommand &= "@Activa,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@SContConceptosCuentasID = SContConceptosCuentasID from SContConceptosCuentas where "		
		sCommand &= "SContConceptosCuentasID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SContConceptosCuentasID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@TipoConcepto", SqlDbType.VarChar)		
		If IsDBNull(m_TipoConcepto) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_TipoConcepto
        End If
		arParams(2) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objConceptoID
        End If
		arParams(3) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCentroCostoID
        End If
		arParams(4) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCuentaContableID
        End If
		arParams(5) = New SqlParameter("@objContraCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objContraCuentaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objContraCuentaID
        End If
		arParams(6) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activa
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
			
			m_SContConceptosCuentasID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SContConceptosCuentas en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SContConceptosCuentas set "		
		sCommand &= "TipoConcepto = @TipoConcepto,"
		sCommand &= "objConceptoID = @objConceptoID,"
		sCommand &= "objCentroCostoID = @objCentroCostoID,"
		sCommand &= "objCuentaContableID = @objCuentaContableID,"
		sCommand &= "objContraCuentaID = @objContraCuentaID,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "SContConceptosCuentasID = @SContConceptosCuentasID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@SContConceptosCuentasID", SqlDbType.Int)		
		If IsDBNull(m_SContConceptosCuentasID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SContConceptosCuentasID
        End If
		arParams(1) = New SqlParameter("@TipoConcepto", SqlDbType.VarChar)		
		If IsDBNull(m_TipoConcepto) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_TipoConcepto
        End If
		arParams(2) = New SqlParameter("@objConceptoID", SqlDbType.Int)		
		If IsDBNull(m_objConceptoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objConceptoID
        End If
		arParams(3) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objCentroCostoID
        End If
		arParams(4) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCuentaContableID
        End If
		arParams(5) = New SqlParameter("@objContraCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objContraCuentaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objContraCuentaID
        End If
		arParams(6) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Activa
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
    ''' Borra un objeto SContConceptosCuentas de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContConceptosCuentas where " & " SContConceptosCuentasID = " & m_SContConceptosCuentasID
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
    ''' Borra un objeto SContConceptosCuentas de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SContConceptosCuentasID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContConceptosCuentas where " & " SContConceptosCuentasID = " & p_SContConceptosCuentasID
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
    ''' Borra objetos SContConceptosCuentas de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SContConceptosCuentas where " & pWhere
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
