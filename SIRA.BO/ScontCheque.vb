Imports DAL
Imports System.Data.SqlClient

Partial Public Class ScontCheque		

#Region " Variables Miembro " 
	Protected m_ScontChequeID As Integer 
	Protected m_NumCheque As String = Nothing 
	Protected m_Fecha As Nullable(Of Date) 
	Protected m_Concepto As String = Nothing 
	Protected m_objCentroCostoID As Nullable(Of Integer) 
	Protected m_Beneficiario As String = Nothing 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_objEstadoChequeID As Nullable(Of Integer) 
	Protected m_TasaCambio As Nullable(Of Decimal) 
	Protected m_ValorDolares As Nullable(Of Decimal) 
	Protected m_ValorCordobas As Nullable(Of Decimal) 
	Protected m_Notas As String = Nothing 
	Protected m_Activo As Nullable(Of Boolean) 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScontChequeID() As Integer
        Get
            Return (m_ScontChequeID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScontChequeID = Value
		End Set
    End Property
	
	Public Property NumCheque() As String
        Get
            Return (m_NumCheque)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("NumCheque", Value.ToString(), "Valor inv?lido para ScontCheque.NumCheque. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_NumCheque = Value
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
	
	Public Property Concepto() As String
        Get
            Return (m_Concepto)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Concepto", Value.ToString(), "Valor inv?lido para ScontCheque.Concepto. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Concepto = Value
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
	
	Public Property Beneficiario() As String
        Get
            Return (m_Beneficiario)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("Beneficiario", Value.ToString(), "Valor inv?lido para ScontCheque.Beneficiario. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_Beneficiario = Value
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
	
	Public Property objEstadoChequeID() As Nullable(Of Integer)
        Get
            Return (m_objEstadoChequeID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objEstadoChequeID = Value
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
	
	Public Property ValorDolares() As Nullable(Of Decimal)
        Get
            Return (m_ValorDolares)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_ValorDolares = Value
		End Set
    End Property
	
	Public Property ValorCordobas() As Nullable(Of Decimal)
        Get
            Return (m_ValorCordobas)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_ValorCordobas = Value
		End Set
    End Property
	
	Public Property Notas() As String
        Get
            Return (m_Notas)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Notas", Value.ToString(), "Valor inv?lido para ScontCheque.Notas. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Notas = Value
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
	
	Public Property objPeriodoID() As Nullable(Of Integer)
        Get
            Return (m_objPeriodoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPeriodoID = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScontCheque.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScontCheque.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "NumCheque"
				Return	50
			Case "Concepto"
				Return	2147483645
			Case "Beneficiario"
				Return	50
			Case "TasaCambio"
				Return	18
			Case "ValorDolares"
				Return	18
			Case "ValorCordobas"
				Return	18
			Case "Notas"
				Return	2147483645
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
			Case "TasaCambio"
				Return	2
			Case "ValorDolares"
				Return	2
			Case "ValorCordobas"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla ScontCheque en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScontCheque </param>    
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
			cmdDelete.Parameters.Add("@ScontChequeID", SqlDbType.Int, 4, "ScontChequeID" )
			cmdDelete.CommandText = "DELETE FROM  ScontCheque WHERE ScontChequeID= @ScontChequeID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@NumCheque", SqlDbType.VarChar, 50, "NumCheque")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@Concepto", SqlDbType.VarChar, -1, "Concepto")
			cmdInsert.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdInsert.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 50, "Beneficiario")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@objEstadoChequeID", SqlDbType.Int, 4, "objEstadoChequeID")
			cmdInsert.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdInsert.Parameters.Add("@ValorDolares", SqlDbType.Decimal, 9, "ValorDolares")
			cmdInsert.Parameters.Add("@ValorCordobas", SqlDbType.Decimal, 9, "ValorCordobas")
			cmdInsert.Parameters.Add("@Notas", SqlDbType.VarChar, -1, "Notas")
			cmdInsert.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScontCheque ( NumCheque, Fecha, Concepto, objCentroCostoID, Beneficiario, objMonedaID, objEstadoChequeID, TasaCambio, ValorDolares, ValorCordobas, Notas, Activo, objPeriodoID, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @NumCheque, @Fecha, @Concepto, @objCentroCostoID, @Beneficiario, @objMonedaID, @objEstadoChequeID, @TasaCambio, @ValorDolares, @ValorCordobas, @Notas, @Activo, @objPeriodoID, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@NumCheque", SqlDbType.VarChar, 50, "NumCheque")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@Concepto", SqlDbType.VarChar, -1, "Concepto")
			cmdUpdate.Parameters.Add("@objCentroCostoID", SqlDbType.Int, 4, "objCentroCostoID")
			cmdUpdate.Parameters.Add("@Beneficiario", SqlDbType.VarChar, 50, "Beneficiario")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@objEstadoChequeID", SqlDbType.Int, 4, "objEstadoChequeID")
			cmdUpdate.Parameters.Add("@TasaCambio", SqlDbType.Decimal, 9, "TasaCambio")
			cmdUpdate.Parameters.Add("@ValorDolares", SqlDbType.Decimal, 9, "ValorDolares")
			cmdUpdate.Parameters.Add("@ValorCordobas", SqlDbType.Decimal, 9, "ValorCordobas")
			cmdUpdate.Parameters.Add("@Notas", SqlDbType.VarChar, -1, "Notas")
			cmdUpdate.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScontChequeID", SqlDbType.Int, 4, "ScontChequeID")
			cmdUpdate.CommandText = "UPDATE ScontCheque SET NumCheque=@NumCheque, Fecha=@Fecha, Concepto=@Concepto, objCentroCostoID=@objCentroCostoID, Beneficiario=@Beneficiario, objMonedaID=@objMonedaID, objEstadoChequeID=@objEstadoChequeID, TasaCambio=@TasaCambio, ValorDolares=@ValorDolares, ValorCordobas=@ValorCordobas, Notas=@Notas, Activo=@Activo, objPeriodoID=@objPeriodoID, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScontChequeID= @wScontChequeID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScontCheque")
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
    ''' Devuelve de la base de datos un objeto ScontCheque
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScontChequeID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontCheque where " & " ScontChequeID = " & p_ScontChequeID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ScontChequeID = dr("ScontChequeID")
				m_NumCheque = IIf(IsDBNull(dr("NumCheque")), Nothing, dr("NumCheque"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_Beneficiario = IIf(IsDBNull(dr("Beneficiario")), Nothing, dr("Beneficiario"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_objEstadoChequeID = IIf(IsDBNull(dr("objEstadoChequeID")), Nothing, dr("objEstadoChequeID"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_ValorDolares = IIf(IsDBNull(dr("ValorDolares")), Nothing, dr("ValorDolares"))
				m_ValorCordobas = IIf(IsDBNull(dr("ValorCordobas")), Nothing, dr("ValorCordobas"))
				m_Notas = IIf(IsDBNull(dr("Notas")), Nothing, dr("Notas"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
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
    ''' Devuelve de la base de datos un objeto ScontCheque usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontCheque where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ScontChequeID = dr("ScontChequeID")
				m_NumCheque = IIf(IsDBNull(dr("NumCheque")), Nothing, dr("NumCheque"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_Concepto = IIf(IsDBNull(dr("Concepto")), Nothing, dr("Concepto"))
				m_objCentroCostoID = IIf(IsDBNull(dr("objCentroCostoID")), Nothing, dr("objCentroCostoID"))
				m_Beneficiario = IIf(IsDBNull(dr("Beneficiario")), Nothing, dr("Beneficiario"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_objEstadoChequeID = IIf(IsDBNull(dr("objEstadoChequeID")), Nothing, dr("objEstadoChequeID"))
				m_TasaCambio = IIf(IsDBNull(dr("TasaCambio")), Nothing, dr("TasaCambio"))
				m_ValorDolares = IIf(IsDBNull(dr("ValorDolares")), Nothing, dr("ValorDolares"))
				m_ValorCordobas = IIf(IsDBNull(dr("ValorCordobas")), Nothing, dr("ValorCordobas"))
				m_Notas = IIf(IsDBNull(dr("Notas")), Nothing, dr("Notas"))
				m_Activo = IIf(IsDBNull(dr("Activo")), Nothing, dr("Activo"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
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
    ''' Trae de la base de datos un conjunto de objetos ScontCheque en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScontCheque"

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
			ds.Tables(0).TableName = "ScontCheque"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontCheque en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScontCheque"

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
			ds.Tables(0).TableName = "ScontCheque"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontCheque en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScontCheque"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScontCheque.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScontCheque("
		sCommand &= "NumCheque,"
		sCommand &= "Fecha,"
		sCommand &= "Concepto,"
		sCommand &= "objCentroCostoID,"
		sCommand &= "Beneficiario,"
		sCommand &= "objMonedaID,"
		sCommand &= "objEstadoChequeID,"
		sCommand &= "TasaCambio,"
		sCommand &= "ValorDolares,"
		sCommand &= "ValorCordobas,"
		sCommand &= "Notas,"
		sCommand &= "Activo,"
		sCommand &= "objPeriodoID,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@NumCheque,"
		sCommand &= "@Fecha,"
		sCommand &= "@Concepto,"
		sCommand &= "@objCentroCostoID,"
		sCommand &= "@Beneficiario,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@objEstadoChequeID,"
		sCommand &= "@TasaCambio,"
		sCommand &= "@ValorDolares,"
		sCommand &= "@ValorCordobas,"
		sCommand &= "@Notas,"
		sCommand &= "@Activo,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScontChequeID = ScontChequeID from ScontCheque where "		
		sCommand &= "ScontChequeID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@ScontChequeID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@NumCheque", SqlDbType.VarChar)		
		If IsDBNull(m_NumCheque) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NumCheque
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Concepto
        End If
		arParams(4) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCentroCostoID
        End If
		arParams(5) = New SqlParameter("@Beneficiario", SqlDbType.VarChar)		
		If IsDBNull(m_Beneficiario) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Beneficiario
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@objEstadoChequeID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoChequeID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objEstadoChequeID
        End If
		arParams(8) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_TasaCambio
        End If
		arParams(9) = New SqlParameter("@ValorDolares", SqlDbType.Decimal)		
		If IsDBNull(m_ValorDolares) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ValorDolares
        End If
		arParams(10) = New SqlParameter("@ValorCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_ValorCordobas) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ValorCordobas
        End If
		arParams(11) = New SqlParameter("@Notas", SqlDbType.VarChar)		
		If IsDBNull(m_Notas) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Notas
        End If
		arParams(12) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Activo
        End If
		arParams(13) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objPeriodoID
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_ScontChequeID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScontCheque en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScontCheque set "		
		sCommand &= "NumCheque = @NumCheque,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "Concepto = @Concepto,"
		sCommand &= "objCentroCostoID = @objCentroCostoID,"
		sCommand &= "Beneficiario = @Beneficiario,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "objEstadoChequeID = @objEstadoChequeID,"
		sCommand &= "TasaCambio = @TasaCambio,"
		sCommand &= "ValorDolares = @ValorDolares,"
		sCommand &= "ValorCordobas = @ValorCordobas,"
		sCommand &= "Notas = @Notas,"
		sCommand &= "Activo = @Activo,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScontChequeID = @ScontChequeID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@ScontChequeID", SqlDbType.Int)		
		If IsDBNull(m_ScontChequeID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScontChequeID
        End If
		arParams(1) = New SqlParameter("@NumCheque", SqlDbType.VarChar)		
		If IsDBNull(m_NumCheque) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_NumCheque
        End If
		arParams(2) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_Fecha
        End If
		arParams(3) = New SqlParameter("@Concepto", SqlDbType.VarChar)		
		If IsDBNull(m_Concepto) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Concepto
        End If
		arParams(4) = New SqlParameter("@objCentroCostoID", SqlDbType.Int)		
		If IsDBNull(m_objCentroCostoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objCentroCostoID
        End If
		arParams(5) = New SqlParameter("@Beneficiario", SqlDbType.VarChar)		
		If IsDBNull(m_Beneficiario) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Beneficiario
        End If
		arParams(6) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaID
        End If
		arParams(7) = New SqlParameter("@objEstadoChequeID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoChequeID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objEstadoChequeID
        End If
		arParams(8) = New SqlParameter("@TasaCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TasaCambio) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_TasaCambio
        End If
		arParams(9) = New SqlParameter("@ValorDolares", SqlDbType.Decimal)		
		If IsDBNull(m_ValorDolares) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_ValorDolares
        End If
		arParams(10) = New SqlParameter("@ValorCordobas", SqlDbType.Decimal)		
		If IsDBNull(m_ValorCordobas) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_ValorCordobas
        End If
		arParams(11) = New SqlParameter("@Notas", SqlDbType.VarChar)		
		If IsDBNull(m_Notas) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Notas
        End If
		arParams(12) = New SqlParameter("@Activo", SqlDbType.Bit)		
		If IsDBNull(m_Activo) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_Activo
        End If
		arParams(13) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_objPeriodoID
        End If
		arParams(14) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_FechaCreacion
        End If
		arParams(15) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_UsuarioCreacion
        End If
		arParams(16) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_FechaModificacion
        End If
		arParams(17) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_UsuarioModificacion
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
    ''' Borra un objeto ScontCheque de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontCheque where " & " ScontChequeID = " & m_ScontChequeID
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
    ''' Borra un objeto ScontCheque de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScontChequeID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontCheque where " & " ScontChequeID = " & p_ScontChequeID
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
    ''' Borra objetos ScontCheque de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontCheque where " & pWhere
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
