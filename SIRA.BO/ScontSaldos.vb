Imports DAL
Imports System.Data.SqlClient

Partial Public Class ScontSaldos		

#Region " Variables Miembro " 
	Protected m_ScontSaldosID As Integer 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_objCuentaContableID As Nullable(Of Integer) 
	Protected m_Anio As Nullable(Of Integer) 
	Protected m_Mes As Nullable(Of Integer) 
	Protected m_Cerrado As Nullable(Of Boolean) 
	Protected m_Saldo As Nullable(Of Decimal) 
	Protected m_FechaCreacion As Nullable(Of Date) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_UsuarioModificacion As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property ScontSaldosID() As Integer
        Get
            Return (m_ScontSaldosID)
        End Get
		Set(ByVal Value As Integer)					
			m_ScontSaldosID = Value
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
	
	Public Property objCuentaContableID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaContableID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaContableID = Value
		End Set
    End Property
	
	Public Property Anio() As Nullable(Of Integer)
        Get
            Return (m_Anio)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Anio = Value
		End Set
    End Property
	
	Public Property Mes() As Nullable(Of Integer)
        Get
            Return (m_Mes)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_Mes = Value
		End Set
    End Property
	
	Public Property Cerrado() As Nullable(Of Boolean)
        Get
            Return (m_Cerrado)
        End Get
		Set(ByVal Value As Nullable(Of Boolean))					
			m_Cerrado = Value
		End Set
    End Property
	
	Public Property Saldo() As Nullable(Of Decimal)
        Get
            Return (m_Saldo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_Saldo = Value
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
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para ScontSaldos.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para ScontSaldos.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
				End If
			End If
			m_UsuarioModificacion = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "Saldo"
				Return	18
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
			Case "Saldo"
				Return	4
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla ScontSaldos en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla ScontSaldos </param>    
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
			cmdDelete.Parameters.Add("@ScontSaldosID", SqlDbType.Int, 4, "ScontSaldosID" )
			cmdDelete.CommandText = "DELETE FROM  ScontSaldos WHERE ScontSaldosID= @ScontSaldosID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdInsert.Parameters.Add("@Anio", SqlDbType.Int, 4, "Anio")
			cmdInsert.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdInsert.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.CommandText = "INSERT INTO ScontSaldos ( objPeriodoID, objCuentaContableID, Anio, Mes, Cerrado, Saldo, FechaCreacion, UsuarioCreacion, FechaModificacion, UsuarioModificacion) VALUES ( @objPeriodoID, @objCuentaContableID, @Anio, @Mes, @Cerrado, @Saldo, @FechaCreacion, @UsuarioCreacion, @FechaModificacion, @UsuarioModificacion)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@objCuentaContableID", SqlDbType.Int, 4, "objCuentaContableID")
			cmdUpdate.Parameters.Add("@Anio", SqlDbType.Int, 4, "Anio")
			cmdUpdate.Parameters.Add("@Mes", SqlDbType.Int, 4, "Mes")
			cmdUpdate.Parameters.Add("@Cerrado", SqlDbType.Bit, 1, "Cerrado")
			cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@wScontSaldosID", SqlDbType.Int, 4, "ScontSaldosID")
			cmdUpdate.CommandText = "UPDATE ScontSaldos SET objPeriodoID=@objPeriodoID, objCuentaContableID=@objCuentaContableID, Anio=@Anio, Mes=@Mes, Cerrado=@Cerrado, Saldo=@Saldo, FechaCreacion=@FechaCreacion, UsuarioCreacion=@UsuarioCreacion, FechaModificacion=@FechaModificacion, UsuarioModificacion=@UsuarioModificacion WHERE ScontSaldosID= @wScontSaldosID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "ScontSaldos")
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
    ''' Devuelve de la base de datos un objeto ScontSaldos
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_ScontSaldosID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontSaldos where " & " ScontSaldosID = " & p_ScontSaldosID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_ScontSaldosID = dr("ScontSaldosID")
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_Anio = IIf(IsDBNull(dr("Anio")), Nothing, dr("Anio"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
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
    ''' Devuelve de la base de datos un objeto ScontSaldos usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from ScontSaldos where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_ScontSaldosID = dr("ScontSaldosID")
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_objCuentaContableID = IIf(IsDBNull(dr("objCuentaContableID")), Nothing, dr("objCuentaContableID"))
				m_Anio = IIf(IsDBNull(dr("Anio")), Nothing, dr("Anio"))
				m_Mes = IIf(IsDBNull(dr("Mes")), Nothing, dr("Mes"))
				m_Cerrado = IIf(IsDBNull(dr("Cerrado")), Nothing, dr("Cerrado"))
				m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
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
    ''' Trae de la base de datos un conjunto de objetos ScontSaldos en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from ScontSaldos"

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
			ds.Tables(0).TableName = "ScontSaldos"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontSaldos en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from ScontSaldos"

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
			ds.Tables(0).TableName = "ScontSaldos"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos ScontSaldos en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from ScontSaldos"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase ScontSaldos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into ScontSaldos("
		sCommand &= "objPeriodoID,"
		sCommand &= "objCuentaContableID,"
		sCommand &= "Anio,"
		sCommand &= "Mes,"
		sCommand &= "Cerrado,"
		sCommand &= "Saldo,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "UsuarioModificacion) values ("		
		sCommand &= "@objPeriodoID,"
		sCommand &= "@objCuentaContableID,"
		sCommand &= "@Anio,"
		sCommand &= "@Mes,"
		sCommand &= "@Cerrado,"
		sCommand &= "@Saldo,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@UsuarioModificacion)"		
	
		sCommand &= " select "
		sCommand &= "@ScontSaldosID = ScontSaldosID from ScontSaldos where "		
		sCommand &= "ScontSaldosID = SCOPE_IDENTITY()"
		
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontSaldosID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPeriodoID
        End If
		arParams(2) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaContableID
        End If
		arParams(3) = New SqlParameter("@Anio", SqlDbType.Int)		
		If IsDBNull(m_Anio) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Anio
        End If
		arParams(4) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Mes
        End If
		arParams(5) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Cerrado
        End If
		arParams(6) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Saldo
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
			
			m_ScontSaldosID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto ScontSaldos en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update ScontSaldos set "		
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "objCuentaContableID = @objCuentaContableID,"
		sCommand &= "Anio = @Anio,"
		sCommand &= "Mes = @Mes,"
		sCommand &= "Cerrado = @Cerrado,"
		sCommand &= "Saldo = @Saldo,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion"		
		sCommand &= " where "	
		sCommand &= "ScontSaldosID = @ScontSaldosID"					
		
		Dim arParams(10) As SqlParameter
		arParams(0) = New SqlParameter("@ScontSaldosID", SqlDbType.Int)		
		If IsDBNull(m_ScontSaldosID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_ScontSaldosID
        End If
		arParams(1) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objPeriodoID
        End If
		arParams(2) = New SqlParameter("@objCuentaContableID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaContableID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objCuentaContableID
        End If
		arParams(3) = New SqlParameter("@Anio", SqlDbType.Int)		
		If IsDBNull(m_Anio) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_Anio
        End If
		arParams(4) = New SqlParameter("@Mes", SqlDbType.Int)		
		If IsDBNull(m_Mes) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_Mes
        End If
		arParams(5) = New SqlParameter("@Cerrado", SqlDbType.Bit)		
		If IsDBNull(m_Cerrado) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_Cerrado
        End If
		arParams(6) = New SqlParameter("@Saldo", SqlDbType.Decimal)		
		If IsDBNull(m_Saldo) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_Saldo
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
    ''' Borra un objeto ScontSaldos de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontSaldos where " & " ScontSaldosID = " & m_ScontSaldosID
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
    ''' Borra un objeto ScontSaldos de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_ScontSaldosID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontSaldos where " & " ScontSaldosID = " & p_ScontSaldosID
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
    ''' Borra objetos ScontSaldos de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from ScontSaldos where " & pWhere
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