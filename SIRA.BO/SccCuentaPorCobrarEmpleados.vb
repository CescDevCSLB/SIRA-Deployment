Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccCuentaPorCobrarEmpleados		

#Region " Variables Miembro " 
	Protected m_SccCuentaID As Integer 
	Protected m_Numero As String = Nothing 
	Protected m_objEmpleadoID As Integer 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_Plazo As Nullable(Of Integer) 
	Protected m_PagoMensual As Nullable(Of Decimal) 
	Protected m_objMonedaPagoMensualidadID As Nullable(Of Integer) 
	Protected m_SaldoInicial As Nullable(Of Decimal) 
	Protected m_Saldo As Decimal 
	Protected m_Activa As Nullable(Of Boolean) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_MesInicio As Nullable(Of Integer) 
	Protected m_AnioInicio As Nullable(Of Integer) 
	Protected m_objCuentaContableID As Nullable(Of Integer) 
	Protected m_objContraCuentaID As Nullable(Of Integer) 
#End Region

#Region " Propiedades "
	Public Property SccCuentaID() As Integer
        Get
            Return (m_SccCuentaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccCuentaID = Value
		End Set
    End Property
	
	Public Property Numero() As String
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarEmpleados.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Numero = Value
		End Set
    End Property
	
	Public Property objEmpleadoID() As Integer
        Get
            Return (m_objEmpleadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEmpleadoID = Value
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
	
	Public Property Plazo() As Nullable(Of Integer)
        Get
            Return (m_Plazo)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Plazo = Value
		End Set
    End Property
	
	Public Property PagoMensual() As Nullable(Of Decimal)
        Get
            Return (m_PagoMensual)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_PagoMensual = Value
		End Set
    End Property
	
	Public Property objMonedaPagoMensualidadID() As Nullable(Of Integer)
        Get
            Return (m_objMonedaPagoMensualidadID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objMonedaPagoMensualidadID = Value
		End Set
    End Property
	
	Public Property SaldoInicial() As Nullable(Of Decimal)
        Get
            Return (m_SaldoInicial)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_SaldoInicial = Value
		End Set
    End Property
	
	Public Property Saldo() As Decimal
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Decimal)					
			m_Saldo = Value
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
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarEmpleados.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrarEmpleados.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property MesInicio() As Nullable(Of Integer)
        Get
            Return (m_MesInicio)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_MesInicio = Value
		End Set
    End Property
	
	Public Property AnioInicio() As Nullable(Of Integer)
        Get
            Return (m_AnioInicio)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_AnioInicio = Value
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
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Numero"
				Return	2147483645
			Case "PagoMensual"
				Return	18
			Case "SaldoInicial"
				Return	11
			Case "Saldo"
				Return	11
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
			Case "PagoMensual"
				Return	2
			Case "SaldoInicial"
				Return	2
			Case "Saldo"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCuentaPorCobrarEmpleados en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuentaPorCobrarEmpleados </param>    
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
			cmdDelete.Parameters.Add("@SccCuentaID", SqlDbType.Int, 4, "SccCuentaID" )
			cmdDelete.CommandText = "DELETE FROM  SccCuentaPorCobrarEmpleados WHERE SccCuentaID= @SccCuentaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
			cmdInsert.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@Plazo", SqlDbType.Int, 4, "Plazo")
			cmdInsert.Parameters.Add("@PagoMensual", SqlDbType.Decimal, 9, "PagoMensual")
			cmdInsert.Parameters.Add("@objMonedaPagoMensualidadID", SqlDbType.Int, 4, "objMonedaPagoMensualidadID")
			cmdInsert.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@MesInicio", SqlDbType.Int, 4, "MesInicio")
			cmdInsert.Parameters.Add("@AnioInicio", SqlDbType.Int, 4, "AnioInicio")
			cmdInsert.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdInsert.Parameters.Add("@objContraCuentaID", SqlDbType.Int, 4, "objContraCuentaID")
			cmdInsert.CommandText = "INSERT INTO SccCuentaPorCobrarEmpleados ( Numero, objEmpleadoID, objEstadoID, Plazo, PagoMensual, objMonedaPagoMensualidadID, SaldoInicial, Saldo, Activa, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, MesInicio, AnioInicio, objCuentaContableID, objContraCuentaID) VALUES ( @Numero, @objEmpleadoID, @objEstadoID, @Plazo, @PagoMensual, @objMonedaPagoMensualidadID, @SaldoInicial, @Saldo, @Activa, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @MesInicio, @AnioInicio, @objCuentaContableID, @objContraCuentaID)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
			cmdUpdate.Parameters.Add("@objEmpleadoID", SqlDbType.Int, 4, "objEmpleadoID")
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@Plazo", SqlDbType.Int, 4, "Plazo")
			cmdUpdate.Parameters.Add("@PagoMensual", SqlDbType.Decimal, 9, "PagoMensual")
			cmdUpdate.Parameters.Add("@objMonedaPagoMensualidadID", SqlDbType.Int, 4, "objMonedaPagoMensualidadID")
			cmdUpdate.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@MesInicio", SqlDbType.Int, 4, "MesInicio")
			cmdUpdate.Parameters.Add("@AnioInicio", SqlDbType.Int, 4, "AnioInicio")
			cmdUpdate.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdUpdate.Parameters.Add("@objContraCuentaID", SqlDbType.Int, 4, "objContraCuentaID")
			cmdUpdate.Parameters.Add("@wSccCuentaID", SqlDbType.Int, 4, "SccCuentaID")
			cmdUpdate.CommandText = "UPDATE SccCuentaPorCobrarEmpleados SET Numero=@Numero, objEmpleadoID=@objEmpleadoID, objEstadoID=@objEstadoID, Plazo=@Plazo, PagoMensual=@PagoMensual, objMonedaPagoMensualidadID=@objMonedaPagoMensualidadID, SaldoInicial=@SaldoInicial, Saldo=@Saldo, Activa=@Activa, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, MesInicio=@MesInicio, AnioInicio=@AnioInicio, objCuentaContableID=@objCuentaContableID, objContraCuentaID=@objContraCuentaID WHERE SccCuentaID= @wSccCuentaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuentaPorCobrarEmpleados")
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarEmpleados
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccCuentaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarEmpleados where " & " SccCuentaID = " & p_SccCuentaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccCuentaID = dr("SccCuentaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_Plazo = IIf(IsDBNull(dr("Plazo")), Nothing, dr("Plazo"))
				m_PagoMensual = IIf(IsDBNull(dr("PagoMensual")), Nothing, dr("PagoMensual"))
				m_objMonedaPagoMensualidadID = IIf(IsDBNull(dr("objMonedaPagoMensualidadID")), Nothing, dr("objMonedaPagoMensualidadID"))
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_MesInicio = IIf(IsDBNull(dr("MesInicio")), Nothing, dr("MesInicio"))
				m_AnioInicio = IIf(IsDBNull(dr("AnioInicio")), Nothing, dr("AnioInicio"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_objContraCuentaID = IIf(IsDBNull(dr("objContraCuentaID")), Nothing, dr("objContraCuentaID"))
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrarEmpleados usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrarEmpleados where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccCuentaID = dr("SccCuentaID")
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))
				m_objEmpleadoID = IIf(IsDBNull(dr("objEmpleadoID")), Nothing, dr("objEmpleadoID"))
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_Plazo = IIf(IsDBNull(dr("Plazo")), Nothing, dr("Plazo"))
				m_PagoMensual = IIf(IsDBNull(dr("PagoMensual")), Nothing, dr("PagoMensual"))
				m_objMonedaPagoMensualidadID = IIf(IsDBNull(dr("objMonedaPagoMensualidadID")), Nothing, dr("objMonedaPagoMensualidadID"))
				m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
				m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_MesInicio = IIf(IsDBNull(dr("MesInicio")), Nothing, dr("MesInicio"))
				m_AnioInicio = IIf(IsDBNull(dr("AnioInicio")), Nothing, dr("AnioInicio"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_objContraCuentaID = IIf(IsDBNull(dr("objContraCuentaID")), Nothing, dr("objContraCuentaID"))
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
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarEmpleados en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarEmpleados"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarEmpleados"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarEmpleados en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarEmpleados"

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
			ds.Tables(0).TableName = "SccCuentaPorCobrarEmpleados"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrarEmpleados en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccCuentaPorCobrarEmpleados"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuentaPorCobrarEmpleados.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccCuentaPorCobrarEmpleados("
		sCommand &= "Numero,"
		sCommand &= "objEmpleadoID,"
		sCommand &= "objEstadoID,"
		sCommand &= "Plazo,"
		sCommand &= "PagoMensual,"
		sCommand &= "objMonedaPagoMensualidadID,"
		sCommand &= "SaldoInicial,"
		sCommand &= "Saldo,"
		sCommand &= "Activa,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "MesInicio,"
		sCommand &= "AnioInicio,"
		sCommand &= "objCuentaContableID,"
		sCommand &= "objContraCuentaID) values ("		
		sCommand &= "@Numero,"
		sCommand &= "@objEmpleadoID,"
		sCommand &= "@objEstadoID,"
		sCommand &= "@Plazo,"
		sCommand &= "@PagoMensual,"
		sCommand &= "@objMonedaPagoMensualidadID,"
		sCommand &= "@SaldoInicial,"
		sCommand &= "@Saldo,"
		sCommand &= "@Activa,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@MesInicio,"
		sCommand &= "@AnioInicio,"
		sCommand &= "@objCuentaContableID,"
		sCommand &= "@objContraCuentaID)"		
	
		sCommand &= " select "
		sCommand &= "@SccCuentaID = SccCuentaID from SccCuentaPorCobrarEmpleados where "		
		sCommand &= "SccCuentaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEmpleadoID
        End If
		arParams(3) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEstadoID
        End If
		arParams(4) = New SqlParameter("@Plazo", SqlDbType.Int)		
		If IsDBNull(m_Plazo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Plazo
        End If
		arParams(5) = New SqlParameter("@PagoMensual", SqlDbType.Decimal)		
		If IsDBNull(m_PagoMensual) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_PagoMensual
        End If
		arParams(6) = New SqlParameter("@objMonedaPagoMensualidadID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaPagoMensualidadID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaPagoMensualidadID
        End If
		arParams(7) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_SaldoInicial
        End If
		arParams(8) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Saldo
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
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
		arParams(14) = New SqlParameter("@MesInicio", SqlDbType.Int)		
		If IsDBNull(m_MesInicio) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_MesInicio
        End If
		arParams(15) = New SqlParameter("@AnioInicio", SqlDbType.Int)		
		If IsDBNull(m_AnioInicio) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_AnioInicio
        End If
		arParams(16) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objCuentaContableID
        End If
		arParams(17) = New SqlParameter("@objContraCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objContraCuentaID) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_objContraCuentaID
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccCuentaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccCuentaPorCobrarEmpleados en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccCuentaPorCobrarEmpleados set "		
		sCommand &= "Numero = @Numero,"
		sCommand &= "objEmpleadoID = @objEmpleadoID,"
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "Plazo = @Plazo,"
		sCommand &= "PagoMensual = @PagoMensual,"
		sCommand &= "objMonedaPagoMensualidadID = @objMonedaPagoMensualidadID,"
		sCommand &= "SaldoInicial = @SaldoInicial,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "Activa = @Activa,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "MesInicio = @MesInicio,"
		sCommand &= "AnioInicio = @AnioInicio,"
		sCommand &= "objCuentaContableID = @objCuentaContableID,"
		sCommand &= "objContraCuentaID = @objContraCuentaID"		
		sCommand &= " where "	
		sCommand &= "SccCuentaID = @SccCuentaID"					
		
		Dim arParams(17) As SqlParameter
		arParams(0) = New SqlParameter("@SccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_SccCuentaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccCuentaID
        End If
		arParams(1) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
		arParams(2) = New SqlParameter("@objEmpleadoID", SqlDbType.Int)		
		If IsDBNull(m_objEmpleadoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objEmpleadoID
        End If
		arParams(3) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objEstadoID
        End If
		arParams(4) = New SqlParameter("@Plazo", SqlDbType.Int)		
		If IsDBNull(m_Plazo) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Plazo
        End If
		arParams(5) = New SqlParameter("@PagoMensual", SqlDbType.Decimal)		
		If IsDBNull(m_PagoMensual) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_PagoMensual
        End If
		arParams(6) = New SqlParameter("@objMonedaPagoMensualidadID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaPagoMensualidadID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objMonedaPagoMensualidadID
        End If
		arParams(7) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)		
		If IsDBNull(m_SaldoInicial) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_SaldoInicial
        End If
		arParams(8) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Saldo
        End If
		arParams(9) = New SqlParameter("@Activa", SqlDbType.Bit)		
		If IsDBNull(m_Activa) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_Activa
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
		arParams(14) = New SqlParameter("@MesInicio", SqlDbType.Int)		
		If IsDBNull(m_MesInicio) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_MesInicio
        End If
		arParams(15) = New SqlParameter("@AnioInicio", SqlDbType.Int)		
		If IsDBNull(m_AnioInicio) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_AnioInicio
        End If
		arParams(16) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_objCuentaContableID
        End If
		arParams(17) = New SqlParameter("@objContraCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objContraCuentaID) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_objContraCuentaID
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
    ''' Borra un objeto SccCuentaPorCobrarEmpleados de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarEmpleados where " & " SccCuentaID = " & m_SccCuentaID
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
    ''' Borra un objeto SccCuentaPorCobrarEmpleados de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCuentaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarEmpleados where " & " SccCuentaID = " & p_SccCuentaID
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
    ''' Borra objetos SccCuentaPorCobrarEmpleados de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrarEmpleados where " & pWhere
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
