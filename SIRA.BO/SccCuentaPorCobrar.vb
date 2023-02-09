Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccCuentaPorCobrar		

#Region " Variables Miembro " 
	Protected m_SccCuentaID As Integer 
	Protected m_Numero As String = Nothing 
	Protected m_objAlumnoID As Integer 
	Protected m_objPeriodoID As Integer 
	Protected m_objGradoID As Integer 
	Protected m_objEstadoID As Nullable(Of Integer) 
	Protected m_objModalidadID As Nullable(Of Integer) 
    Protected m_PagoMensual As Nullable(Of Decimal)
    Protected m_objMonedaPagoMensualidadID As Nullable(Of Integer)
    Protected m_SaldoInicial As Nullable(Of Decimal)
    Protected m_Saldo As Decimal
    Protected m_Activa As Nullable(Of Boolean)
    Protected m_UsuarioCreacion As String = Nothing
    Protected m_FechaCreacion As Nullable(Of Date)
    Protected m_UsuarioModificacion As String = Nothing
    Protected m_FechaModificacion As Nullable(Of Date)
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
                    Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
                End If
            End If
            m_Numero = Value
        End Set
    End Property

    Public Property objAlumnoID() As Integer
        Get
            Return (m_objAlumnoID)
        End Get
        Set(ByVal Value As Integer)
            m_objAlumnoID = Value
        End Set
    End Property

    Public Property objPeriodoID() As Integer
        Get
            Return (m_objPeriodoID)
        End Get
        Set(ByVal Value As Integer)
            m_objPeriodoID = Value
        End Set
    End Property

    Public Property objGradoID() As Integer
        Get
            Return (m_objGradoID)
        End Get
        Set(ByVal Value As Integer)
            m_objGradoID = Value
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

    Public Property objModalidadID() As Nullable(Of Integer)
        Get
            Return (m_objModalidadID)
        End Get
        Set(ByVal Value As Nullable(Of Integer))
            m_objModalidadID = Value
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
                    Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
                    Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccCuentaPorCobrar.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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


    Public Shared Function GetMaxLength(ProperyName As String) As Integer
        Select Case ProperyName
            Case "Numero"
                Return 2147483645
            Case "PagoMensual"
                Return 18
            Case "SaldoInicial"
                Return 11
            Case "Saldo"
                Return 11
            Case "UsuarioCreacion"
                Return 50
            Case "UsuarioModificacion"
                Return 50
            Case Else
                Throw New Exception("Nombre de propiedad desconocida.")
        End Select
    End Function

    Public Shared Function GetScale(ProperyName As String) As Integer
        Select Case ProperyName
            Case "PagoMensual"
                Return 2
            Case "SaldoInicial"
                Return 2
            Case "Saldo"
                Return 2
            Case Else
                Throw New Exception("Nombre de propiedad desconocida.")
        End Select
    End Function
#End Region

#Region " Batch Update "
    ''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccCuentaPorCobrar en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccCuentaPorCobrar </param>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo BatchUpdate.</param>
    ''' <remarks>Usado para realizar actualizaciones en Batch.</remarks>
    Public Shared Sub BatchUpdate(DS As DataSet, Optional ByVal pTransac As TransactionManager = Nothing)
        Dim cmdInsert As SqlCommand = Nothing
        Dim cmdUpdate As SqlCommand = Nothing
        Dim cmdDelete As SqlCommand = Nothing

        Try
            cmdInsert = New SqlCommand
            cmdUpdate = New SqlCommand
            cmdDelete = New SqlCommand
            'CREACION DEL COMANDO DELETE
            cmdDelete.Parameters.Add("@SccCuentaID", SqlDbType.Int, 4, "SccCuentaID")
            cmdDelete.CommandText = "DELETE FROM  SccCuentaPorCobrar WHERE SccCuentaID= @SccCuentaID"

            'CREACION DEL COMANDO INSERT
            cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
            cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
            cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
            cmdInsert.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
            cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
            cmdInsert.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
            cmdInsert.Parameters.Add("@PagoMensual", SqlDbType.Decimal, 9, "PagoMensual")
            cmdInsert.Parameters.Add("@objMonedaPagoMensualidadID", SqlDbType.Int, 4, "objMonedaPagoMensualidadID")
            cmdInsert.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
            cmdInsert.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
            cmdInsert.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
            cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
            cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
            cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
            cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
            cmdInsert.CommandText = "INSERT INTO SccCuentaPorCobrar ( Numero, objAlumnoID, objPeriodoID, objGradoID, objEstadoID, objModalidadID, PagoMensual, objMonedaPagoMensualidadID, SaldoInicial, Saldo, Activa, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion) VALUES ( @Numero, @objAlumnoID, @objPeriodoID, @objGradoID, @objEstadoID, @objModalidadID, @PagoMensual, @objMonedaPagoMensualidadID, @SaldoInicial, @Saldo, @Activa, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion)"

            'CREACION DEL COMANDO UPDATE
            cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
            cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
            cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
            cmdUpdate.Parameters.Add("@objGradoID", SqlDbType.Int, 4, "objGradoID")
            cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
            cmdUpdate.Parameters.Add("@objModalidadID", SqlDbType.Int, 4, "objModalidadID")
            cmdUpdate.Parameters.Add("@PagoMensual", SqlDbType.Decimal, 9, "PagoMensual")
            cmdUpdate.Parameters.Add("@objMonedaPagoMensualidadID", SqlDbType.Int, 4, "objMonedaPagoMensualidadID")
            cmdUpdate.Parameters.Add("@SaldoInicial", SqlDbType.Decimal, 9, "SaldoInicial")
            cmdUpdate.Parameters.Add("@Saldo", SqlDbType.Decimal, 9, "Saldo")
            cmdUpdate.Parameters.Add("@Activa", SqlDbType.Bit, 1, "Activa")
            cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
            cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
            cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
            cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
            cmdUpdate.Parameters.Add("@wSccCuentaID", SqlDbType.Int, 4, "SccCuentaID")
            cmdUpdate.CommandText = "UPDATE SccCuentaPorCobrar SET Numero=@Numero, objAlumnoID=@objAlumnoID, objPeriodoID=@objPeriodoID, objGradoID=@objGradoID, objEstadoID=@objEstadoID, objModalidadID=@objModalidadID, PagoMensual=@PagoMensual, objMonedaPagoMensualidadID=@objMonedaPagoMensualidadID, SaldoInicial=@SaldoInicial, Saldo=@Saldo, Activa=@Activa, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion WHERE SccCuentaID= @wSccCuentaID"
            If Not pTransac Is Nothing Then
                cmdDelete.Connection = pTransac.Transaction.Connection
                cmdDelete.Transaction = pTransac.Transaction

                cmdInsert.Connection = pTransac.Transaction.Connection
                cmdInsert.Transaction = pTransac.Transaction

                cmdUpdate.Connection = pTransac.Transaction.Connection
                cmdUpdate.Transaction = pTransac.Transaction
            End If

            sqlHelper.UpdateDataset(cmdInsert, cmdDelete, cmdUpdate, DS, "SccCuentaPorCobrar")
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrar
    ''' </summary>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(ByVal p_SccCuentaID As Integer, Optional ByVal pTransac As TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrar where " & " SccCuentaID = " & p_SccCuentaID
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
                m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
                m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
                m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
                m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
                m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
                m_PagoMensual = IIf(IsDBNull(dr("PagoMensual")), Nothing, dr("PagoMensual"))
                m_objMonedaPagoMensualidadID = IIf(IsDBNull(dr("objMonedaPagoMensualidadID")), Nothing, dr("objMonedaPagoMensualidadID"))
                m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
                m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
                m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
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
    ''' Devuelve de la base de datos un objeto SccCuentaPorCobrar usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter As String, Optional ByVal pTransac As TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccCuentaPorCobrar where " & pFilter
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
                m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
                m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
                m_objGradoID = IIf(IsDBNull(dr("objGradoID")), Nothing, dr("objGradoID"))
                m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
                m_objModalidadID = IIf(IsDBNull(dr("objModalidadID")), Nothing, dr("objModalidadID"))
                m_PagoMensual = IIf(IsDBNull(dr("PagoMensual")), Nothing, dr("PagoMensual"))
                m_objMonedaPagoMensualidadID = IIf(IsDBNull(dr("objMonedaPagoMensualidadID")), Nothing, dr("objMonedaPagoMensualidadID"))
                m_SaldoInicial = IIf(IsDBNull(dr("SaldoInicial")), Nothing, dr("SaldoInicial"))
                m_Saldo = IIf(IsDBNull(dr("Saldo")), Nothing, dr("Saldo"))
                m_Activa = IIf(IsDBNull(dr("Activa")), Nothing, dr("Activa"))
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
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields & " from SccCuentaPorCobrar"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet
        Try
            If pTransac Is Nothing Then
                ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
            Else
                ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
            End If
            ds.Tables(0).TableName = "SccCuentaPorCobrar"
            Return (ds.Tables(0))
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields & " from SccCuentaPorCobrar"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim ds As DataSet
        Try
            If pTransac Is Nothing Then
                ds = SqlHelper.ExecuteDataset(CommandType.Text, sSQL)
            Else
                ds = SqlHelper.ExecuteDataset(pTransac.Transaction, CommandType.Text, sSQL)
            End If
            ds.Tables(0).TableName = "SccCuentaPorCobrar"
            Return (ds)
        Catch ex As Exception
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccCuentaPorCobrar en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional ByVal pFields As String = "*", Optional ByVal pTransac As TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields & " from SccCuentaPorCobrar"

        If sFilter <> "" Then
            sSQL &= " where " & sFilter
        End If

        If OrderBy <> "" Then
            sSQL &= " order by " & OrderBy
        End If

        Dim dr As SqlDataReader = Nothing
        Try
            If pTransac Is Nothing Then
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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccCuentaPorCobrar.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
    Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
        Dim sCommand As String = "insert into SccCuentaPorCobrar("
        sCommand &= "Numero,"
        sCommand &= "objAlumnoID,"
        sCommand &= "objPeriodoID,"
        sCommand &= "objGradoID,"
        sCommand &= "objEstadoID,"
        sCommand &= "objModalidadID,"
        sCommand &= "PagoMensual,"
        sCommand &= "objMonedaPagoMensualidadID,"
        sCommand &= "SaldoInicial,"
        sCommand &= "Saldo,"
        sCommand &= "Activa,"
        sCommand &= "UsuarioCreacion,"
        sCommand &= "FechaCreacion,"
        sCommand &= "UsuarioModificacion,"
        sCommand &= "FechaModificacion) values ("
        sCommand &= "@Numero,"
        sCommand &= "@objAlumnoID,"
        sCommand &= "@objPeriodoID,"
        sCommand &= "@objGradoID,"
        sCommand &= "@objEstadoID,"
        sCommand &= "@objModalidadID,"
        sCommand &= "@PagoMensual,"
        sCommand &= "@objMonedaPagoMensualidadID,"
        sCommand &= "@SaldoInicial,"
        sCommand &= "@Saldo,"
        sCommand &= "@Activa,"
        sCommand &= "@UsuarioCreacion,"
        sCommand &= "@FechaCreacion,"
        sCommand &= "@UsuarioModificacion,"
        sCommand &= "@FechaModificacion)"

        sCommand &= " select "
        sCommand &= "@SccCuentaID = SccCuentaID from SccCuentaPorCobrar where "
        sCommand &= "SccCuentaID = SCOPE_IDENTITY()"


        Dim arParams(15) As SqlParameter
        arParams(0) = New SqlParameter("@SccCuentaID", SqlDbType.Int)
        arParams(0).Direction = ParameterDirection.Output
        arParams(1) = New SqlParameter("@Numero", SqlDbType.VarChar)
        If IsDBNull(m_Numero) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_Numero
        End If
        arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)
        If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
        arParams(3) = New SqlParameter("@objPeriodoID", SqlDbType.Int)
        If IsDBNull(m_objPeriodoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objPeriodoID
        End If
        arParams(4) = New SqlParameter("@objGradoID", SqlDbType.Int)
        If IsDBNull(m_objGradoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objGradoID
        End If
        arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)
        If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
        arParams(6) = New SqlParameter("@objModalidadID", SqlDbType.Int)
        If IsDBNull(m_objModalidadID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objModalidadID
        End If
        arParams(7) = New SqlParameter("@PagoMensual", SqlDbType.Decimal)
        If IsDBNull(m_PagoMensual) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_PagoMensual
        End If
        arParams(8) = New SqlParameter("@objMonedaPagoMensualidadID", SqlDbType.Int)
        If IsDBNull(m_objMonedaPagoMensualidadID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objMonedaPagoMensualidadID
        End If
        arParams(9) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)
        If IsDBNull(m_SaldoInicial) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_SaldoInicial
        End If
        arParams(10) = New SqlParameter("@Saldo", SqlDbType.Decimal)
        If IsDBNull(m_Saldo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Saldo
        End If
        arParams(11) = New SqlParameter("@Activa", SqlDbType.Bit)
        If IsDBNull(m_Activa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activa
        End If
        arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
        arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
        arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
        arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
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
    ''' 	Actualiza el objeto SccCuentaPorCobrar en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
    Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)
        Dim sCommand As String = "update SccCuentaPorCobrar set "
        sCommand &= "Numero = @Numero,"
        sCommand &= "objAlumnoID = @objAlumnoID,"
        sCommand &= "objPeriodoID = @objPeriodoID,"
        sCommand &= "objGradoID = @objGradoID,"
        sCommand &= "objEstadoID = @objEstadoID,"
        sCommand &= "objModalidadID = @objModalidadID,"
        sCommand &= "PagoMensual = @PagoMensual,"
        sCommand &= "objMonedaPagoMensualidadID = @objMonedaPagoMensualidadID,"
        sCommand &= "SaldoInicial = @SaldoInicial,"
        sCommand &= "Saldo = @Saldo,"
        sCommand &= "Activa = @Activa,"
        sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
        sCommand &= "FechaCreacion = @FechaCreacion,"
        sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
        sCommand &= "FechaModificacion = @FechaModificacion"
        sCommand &= " where "
        sCommand &= "SccCuentaID = @SccCuentaID"

        Dim arParams(15) As SqlParameter
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
        arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)
        If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
        arParams(3) = New SqlParameter("@objPeriodoID", SqlDbType.Int)
        If IsDBNull(m_objPeriodoID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objPeriodoID
        End If
        arParams(4) = New SqlParameter("@objGradoID", SqlDbType.Int)
        If IsDBNull(m_objGradoID) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_objGradoID
        End If
        arParams(5) = New SqlParameter("@objEstadoID", SqlDbType.Int)
        If IsDBNull(m_objEstadoID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objEstadoID
        End If
        arParams(6) = New SqlParameter("@objModalidadID", SqlDbType.Int)
        If IsDBNull(m_objModalidadID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objModalidadID
        End If
        arParams(7) = New SqlParameter("@PagoMensual", SqlDbType.Decimal)
        If IsDBNull(m_PagoMensual) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_PagoMensual
        End If
        arParams(8) = New SqlParameter("@objMonedaPagoMensualidadID", SqlDbType.Int)
        If IsDBNull(m_objMonedaPagoMensualidadID) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_objMonedaPagoMensualidadID
        End If
        arParams(9) = New SqlParameter("@SaldoInicial", SqlDbType.Decimal)
        If IsDBNull(m_SaldoInicial) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_SaldoInicial
        End If
        arParams(10) = New SqlParameter("@Saldo", SqlDbType.Decimal)
        If IsDBNull(m_Saldo) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Saldo
        End If
        arParams(11) = New SqlParameter("@Activa", SqlDbType.Bit)
        If IsDBNull(m_Activa) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_Activa
        End If
        arParams(12) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioCreacion) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_UsuarioCreacion
        End If
        arParams(13) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaCreacion) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_FechaCreacion
        End If
        arParams(14) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)
        If IsDBNull(m_UsuarioModificacion) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_UsuarioModificacion
        End If
        arParams(15) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)
        If IsDBNull(m_FechaModificacion) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_FechaModificacion
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
    ''' Borra un objeto SccCuentaPorCobrar de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & " SccCuentaID = " & m_SccCuentaID
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
    ''' Borra un objeto SccCuentaPorCobrar de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccCuentaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & " SccCuentaID = " & p_SccCuentaID
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
    ''' Borra objetos SccCuentaPorCobrar de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccCuentaPorCobrar where " & pWhere
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
