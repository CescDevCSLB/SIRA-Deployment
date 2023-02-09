Imports DAL
Imports System.Data.SqlClient

Partial Public Class SccReciboCaja		

#Region " Variables Miembro " 
	Protected m_SccReciboCajaID As Integer 
	Protected m_objEstadoID As Integer 
	Protected m_objAlumnoID As Nullable(Of Integer) 
	Protected m_objSccCuentaID As Nullable(Of Integer) 
	Protected m_AtencionA As String = Nothing 
	Protected m_objCajaID As Nullable(Of Integer) 
	Protected m_objCajeroID As Nullable(Of Integer) 
	Protected m_objPeriodoID As Nullable(Of Integer) 
	Protected m_Numero As String = Nothing 
	Protected m_objTipoPagoID As Nullable(Of Integer) 
	Protected m_Fecha As Date 
	Protected m_objMonedaID As Nullable(Of Integer) 
	Protected m_TipoCambio As Nullable(Of Decimal) 
	Protected m_TotalRecibido As Decimal 
	Protected m_TotalRecibidoCordoba As Nullable(Of Decimal) 
	Protected m_MontoRecibidoEfectivo As Nullable(Of Decimal) 
	Protected m_MontoRecibidoEfectivoCordoba As Nullable(Of Decimal) 
	Protected m_Nota As String = Nothing 
	Protected m_objCuentaID As Nullable(Of Integer) 
	Protected m_UsuarioCreacion As String = Nothing 
	Protected m_FechaCreacion As Date 
	Protected m_UsuarioModificacion As String = Nothing 
	Protected m_FechaModificacion As Nullable(Of Date) 
	Protected m_Observaciones As String = Nothing 
#End Region

#Region " Propiedades "
	Public Property SccReciboCajaID() As Integer
        Get
            Return (m_SccReciboCajaID)
        End Get
		Set(ByVal Value As Integer)					
			m_SccReciboCajaID = Value
		End Set
    End Property
	
	Public Property objEstadoID() As Integer
        Get
            Return (m_objEstadoID)
        End Get
		Set(ByVal Value As Integer)					
			m_objEstadoID = Value
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
	
	Public Property objSccCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objSccCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objSccCuentaID = Value
		End Set
    End Property
	
	Public Property AtencionA() As String
        Get
            Return (m_AtencionA)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 100 Then
					Throw New ArgumentOutOfRangeException("AtencionA", Value.ToString(), "Valor inv?lido para SccReciboCaja.AtencionA. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (100).")
				End If
			End If
			m_AtencionA = Value
		End Set
    End Property
	
	Public Property objCajaID() As Nullable(Of Integer)
        Get
            Return (m_objCajaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCajaID = Value
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
	
	Public Property objPeriodoID() As Nullable(Of Integer)
        Get
            Return (m_objPeriodoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objPeriodoID = Value
		End Set
    End Property
	
	Public Property Numero() As String
        Get
            Return (m_Numero)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Numero", Value.ToString(), "Valor inv?lido para SccReciboCaja.Numero. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Numero = Value
		End Set
    End Property
	
	Public Property objTipoPagoID() As Nullable(Of Integer)
        Get
            Return (m_objTipoPagoID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objTipoPagoID = Value
		End Set
    End Property
	
	Public Property Fecha() As Date
        Get
            Return (m_Fecha)
        End Get
		Set(ByVal Value As Date)					
			m_Fecha = Value
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
	
	Public Property TipoCambio() As Nullable(Of Decimal)
        Get
            Return (m_TipoCambio)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TipoCambio = Value
		End Set
    End Property
	
	Public Property TotalRecibido() As Decimal
        Get
            Return (m_TotalRecibido)
        End Get
		Set(ByVal Value As Decimal)					
			m_TotalRecibido = Value
		End Set
    End Property
	
	Public Property TotalRecibidoCordoba() As Nullable(Of Decimal)
        Get
            Return (m_TotalRecibidoCordoba)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_TotalRecibidoCordoba = Value
		End Set
    End Property
	
	Public Property MontoRecibidoEfectivo() As Nullable(Of Decimal)
        Get
            Return (m_MontoRecibidoEfectivo)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoRecibidoEfectivo = Value
		End Set
    End Property
	
	Public Property MontoRecibidoEfectivoCordoba() As Nullable(Of Decimal)
        Get
            Return (m_MontoRecibidoEfectivoCordoba)
        End Get
		Set(ByVal Value As Nullable(Of Decimal))					
			m_MontoRecibidoEfectivoCordoba = Value
		End Set
    End Property
	
	Public Property Nota() As String
        Get
            Return (m_Nota)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Nota", Value.ToString(), "Valor inv?lido para SccReciboCaja.Nota. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Nota = Value
		End Set
    End Property
	
	Public Property objCuentaID() As Nullable(Of Integer)
        Get
            Return (m_objCuentaID)
        End Get
		Set(ByVal Value As Nullable(Of Integer))					
			m_objCuentaID = Value
		End Set
    End Property
	
	Public Property UsuarioCreacion() As String
        Get
            Return (m_UsuarioCreacion)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioCreacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioCreacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
				If Value.Length > 50 Then
					Throw New ArgumentOutOfRangeException("UsuarioModificacion", Value.ToString(), "Valor inv?lido para SccReciboCaja.UsuarioModificacion. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (50).")
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
	
	Public Property Observaciones() As String
        Get
            Return (m_Observaciones)
        End Get
		Set(ByVal Value As String)		
			If Not Value Is Nothing Then
				If Value.Length > 2147483645 Then
					Throw New ArgumentOutOfRangeException("Observaciones", Value.ToString(), "Valor inv?lido para SccReciboCaja.Observaciones. La longitud del valor (" & Value.Length & ") excede la longitud m?xima de la propiedad (2147483645).")
				End If
			End If
			m_Observaciones = Value
		End Set
    End Property
	

	Public Shared Function GetMaxLength(ProperyName as String) as Integer
		Select Case ProperyName
			Case "AtencionA"
				Return	100
			Case "Numero"
				Return	2147483645
			Case "TipoCambio"
				Return	18
			Case "TotalRecibido"
				Return	11
			Case "TotalRecibidoCordoba"
				Return	11
			Case "MontoRecibidoEfectivo"
				Return	11
			Case "MontoRecibidoEfectivoCordoba"
				Return	11
			Case "Nota"
				Return	2147483645
			Case "UsuarioCreacion"
				Return	50
			Case "UsuarioModificacion"
				Return	50
			Case "Observaciones"
				Return	2147483645
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
	
	Public Shared Function GetScale(ProperyName as String) as Integer
		Select Case ProperyName
			Case "TipoCambio"
				Return	0
			Case "TotalRecibido"
				Return	2
			Case "TotalRecibidoCordoba"
				Return	2
			Case "MontoRecibidoEfectivo"
				Return	2
			Case "MontoRecibidoEfectivoCordoba"
				Return	2
			Case Else
				Throw New Exception("Nombre de propiedad desconocida.")
		End Select
	End Function
#End Region

#Region " Batch Update " 
	''' <summary>
    ''' Salva un DataSet del tipo de la tabla SccReciboCaja en la base de datos.
    ''' </summary>
    ''' <param name="DS">Dataset a salvar. El DS debe necesariamente ser un select a la tabla SccReciboCaja </param>    
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
			cmdDelete.Parameters.Add("@SccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID" )
			cmdDelete.CommandText = "DELETE FROM  SccReciboCaja WHERE SccReciboCajaID= @SccReciboCajaID" 	

			'CREACION DEL COMANDO INSERT
			cmdInsert.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdInsert.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdInsert.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdInsert.Parameters.Add("@AtencionA", SqlDbType.VarChar, 100, "AtencionA")
			cmdInsert.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdInsert.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdInsert.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdInsert.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
			cmdInsert.Parameters.Add("@objTipoPagoID", SqlDbType.Int, 4, "objTipoPagoID")
			cmdInsert.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdInsert.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdInsert.Parameters.Add("@TipoCambio", SqlDbType.Decimal, 9, "TipoCambio")
			cmdInsert.Parameters.Add("@TotalRecibido", SqlDbType.Decimal, 9, "TotalRecibido")
			cmdInsert.Parameters.Add("@TotalRecibidoCordoba", SqlDbType.Decimal, 9, "TotalRecibidoCordoba")
			cmdInsert.Parameters.Add("@MontoRecibidoEfectivo", SqlDbType.Decimal, 9, "MontoRecibidoEfectivo")
			cmdInsert.Parameters.Add("@MontoRecibidoEfectivoCordoba", SqlDbType.Decimal, 9, "MontoRecibidoEfectivoCordoba")
			cmdInsert.Parameters.Add("@Nota", SqlDbType.VarChar, -1, "Nota")
			cmdInsert.Parameters.Add("@objCuentaID", SqlDbType.Int, 4, "objCuentaID")
			cmdInsert.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdInsert.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdInsert.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdInsert.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdInsert.Parameters.Add("@Observaciones", SqlDbType.VarChar, -1, "Observaciones")
			cmdInsert.CommandText = "INSERT INTO SccReciboCaja ( objEstadoID, objAlumnoID, objSccCuentaID, AtencionA, objCajaID, objCajeroID, objPeriodoID, Numero, objTipoPagoID, Fecha, objMonedaID, TipoCambio, TotalRecibido, TotalRecibidoCordoba, MontoRecibidoEfectivo, MontoRecibidoEfectivoCordoba, Nota, objCuentaID, UsuarioCreacion, FechaCreacion, UsuarioModificacion, FechaModificacion, Observaciones) VALUES ( @objEstadoID, @objAlumnoID, @objSccCuentaID, @AtencionA, @objCajaID, @objCajeroID, @objPeriodoID, @Numero, @objTipoPagoID, @Fecha, @objMonedaID, @TipoCambio, @TotalRecibido, @TotalRecibidoCordoba, @MontoRecibidoEfectivo, @MontoRecibidoEfectivoCordoba, @Nota, @objCuentaID, @UsuarioCreacion, @FechaCreacion, @UsuarioModificacion, @FechaModificacion, @Observaciones)"

			'CREACION DEL COMANDO UPDATE
			cmdUpdate.Parameters.Add("@objEstadoID", SqlDbType.Int, 4, "objEstadoID")
			cmdUpdate.Parameters.Add("@objAlumnoID", SqlDbType.Int, 4, "objAlumnoID")
			cmdUpdate.Parameters.Add("@objSccCuentaID", SqlDbType.Int, 4, "objSccCuentaID")
			cmdUpdate.Parameters.Add("@AtencionA", SqlDbType.VarChar, 100, "AtencionA")
			cmdUpdate.Parameters.Add("@objCajaID", SqlDbType.Int, 4, "objCajaID")
			cmdUpdate.Parameters.Add("@objCajeroID", SqlDbType.Int, 4, "objCajeroID")
			cmdUpdate.Parameters.Add("@objPeriodoID", SqlDbType.Int, 4, "objPeriodoID")
			cmdUpdate.Parameters.Add("@Numero", SqlDbType.VarChar, -1, "Numero")
			cmdUpdate.Parameters.Add("@objTipoPagoID", SqlDbType.Int, 4, "objTipoPagoID")
			cmdUpdate.Parameters.Add("@Fecha", SqlDbType.DateTime, 8, "Fecha")
			cmdUpdate.Parameters.Add("@objMonedaID", SqlDbType.Int, 4, "objMonedaID")
			cmdUpdate.Parameters.Add("@TipoCambio", SqlDbType.Decimal, 9, "TipoCambio")
			cmdUpdate.Parameters.Add("@TotalRecibido", SqlDbType.Decimal, 9, "TotalRecibido")
			cmdUpdate.Parameters.Add("@TotalRecibidoCordoba", SqlDbType.Decimal, 9, "TotalRecibidoCordoba")
			cmdUpdate.Parameters.Add("@MontoRecibidoEfectivo", SqlDbType.Decimal, 9, "MontoRecibidoEfectivo")
			cmdUpdate.Parameters.Add("@MontoRecibidoEfectivoCordoba", SqlDbType.Decimal, 9, "MontoRecibidoEfectivoCordoba")
			cmdUpdate.Parameters.Add("@Nota", SqlDbType.VarChar, -1, "Nota")
			cmdUpdate.Parameters.Add("@objCuentaID", SqlDbType.Int, 4, "objCuentaID")
			cmdUpdate.Parameters.Add("@UsuarioCreacion", SqlDbType.VarChar, 50, "UsuarioCreacion")
			cmdUpdate.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 8, "FechaCreacion")
			cmdUpdate.Parameters.Add("@UsuarioModificacion", SqlDbType.VarChar, 50, "UsuarioModificacion")
			cmdUpdate.Parameters.Add("@FechaModificacion", SqlDbType.DateTime, 8, "FechaModificacion")
			cmdUpdate.Parameters.Add("@Observaciones", SqlDbType.VarChar, -1, "Observaciones")
			cmdUpdate.Parameters.Add("@wSccReciboCajaID", SqlDbType.Int, 4, "SccReciboCajaID")
			cmdUpdate.CommandText = "UPDATE SccReciboCaja SET objEstadoID=@objEstadoID, objAlumnoID=@objAlumnoID, objSccCuentaID=@objSccCuentaID, AtencionA=@AtencionA, objCajaID=@objCajaID, objCajeroID=@objCajeroID, objPeriodoID=@objPeriodoID, Numero=@Numero, objTipoPagoID=@objTipoPagoID, Fecha=@Fecha, objMonedaID=@objMonedaID, TipoCambio=@TipoCambio, TotalRecibido=@TotalRecibido, TotalRecibidoCordoba=@TotalRecibidoCordoba, MontoRecibidoEfectivo=@MontoRecibidoEfectivo, MontoRecibidoEfectivoCordoba=@MontoRecibidoEfectivoCordoba, Nota=@Nota, objCuentaID=@objCuentaID, UsuarioCreacion=@UsuarioCreacion, FechaCreacion=@FechaCreacion, UsuarioModificacion=@UsuarioModificacion, FechaModificacion=@FechaModificacion, Observaciones=@Observaciones WHERE SccReciboCajaID= @wSccReciboCajaID"
			If Not pTransac Is Nothing Then
				cmdDelete.Connection = pTransac.Transaction.Connection
				cmdDelete.Transaction = pTransac.Transaction
	
				cmdInsert.Connection = pTransac.Transaction.Connection
				cmdInsert.Transaction = pTransac.Transaction
	
				cmdUpdate.Connection = pTransac.Transaction.Connection
				cmdUpdate.Transaction = pTransac.Transaction
			End If
				
			sqlHelper.UpdateDataset (cmdInsert, cmdDelete, cmdUpdate, DS, "SccReciboCaja")
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja
    ''' </summary>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    	
    Public Function Retrieve(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID		
		Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
			
			If dr.Read() Then
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))
				m_objTipoPagoID = IIf(IsDBNull(dr("objTipoPagoID")), Nothing, dr("objTipoPagoID"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_TipoCambio = IIf(IsDBNull(dr("TipoCambio")), Nothing, dr("TipoCambio"))
				m_TotalRecibido = IIf(IsDBNull(dr("TotalRecibido")), Nothing, dr("TotalRecibido"))
				m_TotalRecibidoCordoba = IIf(IsDBNull(dr("TotalRecibidoCordoba")), Nothing, dr("TotalRecibidoCordoba"))
				m_MontoRecibidoEfectivo = IIf(IsDBNull(dr("MontoRecibidoEfectivo")), Nothing, dr("MontoRecibidoEfectivo"))
				m_MontoRecibidoEfectivoCordoba = IIf(IsDBNull(dr("MontoRecibidoEfectivoCordoba")), Nothing, dr("MontoRecibidoEfectivoCordoba"))
				m_Nota = IIf(IsDBNull(dr("Nota")), Nothing, dr("Nota"))
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
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
    ''' Devuelve de la base de datos un objeto SccReciboCaja usando un filter.
    ''' </summary>
    ''' <param name="pFilter">Filtro a aplicar en el select que carga la clase</param>    
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Retrieve.</param>    
    Public Function RetrieveByFilter(ByVal pFilter as String, optional Byval pTransac as TransactionManager = Nothing) As Boolean
        Dim sSQL As String = "select * from SccReciboCaja where " & pFilter				
        Dim dr As SqlDataReader = Nothing
		
        Try
            If pTransac Is Nothing Then
                dr = SqlHelper.ExecuteReader(CommandType.Text, sSQL)
            Else
                dr = SqlHelper.ExecuteReader(pTransac.Transaction, CommandType.Text, sSQL)
            End If
				
			If dr.Read() Then  				
				m_SccReciboCajaID = dr("SccReciboCajaID")
				m_objEstadoID = IIf(IsDBNull(dr("objEstadoID")), Nothing, dr("objEstadoID"))
				m_objAlumnoID = IIf(IsDBNull(dr("objAlumnoID")), Nothing, dr("objAlumnoID"))
				m_objSccCuentaID = IIf(IsDBNull(dr("objSccCuentaID")), Nothing, dr("objSccCuentaID"))
				m_AtencionA = IIf(IsDBNull(dr("AtencionA")), Nothing, dr("AtencionA"))
				m_objCajaID = IIf(IsDBNull(dr("objCajaID")), Nothing, dr("objCajaID"))
				m_objCajeroID = IIf(IsDBNull(dr("objCajeroID")), Nothing, dr("objCajeroID"))
				m_objPeriodoID = IIf(IsDBNull(dr("objPeriodoID")), Nothing, dr("objPeriodoID"))
				m_Numero = IIf(IsDBNull(dr("Numero")), Nothing, dr("Numero"))
				m_objTipoPagoID = IIf(IsDBNull(dr("objTipoPagoID")), Nothing, dr("objTipoPagoID"))
				m_Fecha = IIf(IsDBNull(dr("Fecha")), Nothing, dr("Fecha"))
				m_objMonedaID = IIf(IsDBNull(dr("objMonedaID")), Nothing, dr("objMonedaID"))
				m_TipoCambio = IIf(IsDBNull(dr("TipoCambio")), Nothing, dr("TipoCambio"))
				m_TotalRecibido = IIf(IsDBNull(dr("TotalRecibido")), Nothing, dr("TotalRecibido"))
				m_TotalRecibidoCordoba = IIf(IsDBNull(dr("TotalRecibidoCordoba")), Nothing, dr("TotalRecibidoCordoba"))
				m_MontoRecibidoEfectivo = IIf(IsDBNull(dr("MontoRecibidoEfectivo")), Nothing, dr("MontoRecibidoEfectivo"))
				m_MontoRecibidoEfectivoCordoba = IIf(IsDBNull(dr("MontoRecibidoEfectivoCordoba")), Nothing, dr("MontoRecibidoEfectivoCordoba"))
				m_Nota = IIf(IsDBNull(dr("Nota")), Nothing, dr("Nota"))
				m_objCuentaID = IIf(IsDBNull(dr("objCuentaID")), Nothing, dr("objCuentaID"))
				m_UsuarioCreacion = IIf(IsDBNull(dr("UsuarioCreacion")), Nothing, dr("UsuarioCreacion"))
				m_FechaCreacion = IIf(IsDBNull(dr("FechaCreacion")), Nothing, dr("FechaCreacion"))
				m_UsuarioModificacion = IIf(IsDBNull(dr("UsuarioModificacion")), Nothing, dr("UsuarioModificacion"))
				m_FechaModificacion = IIf(IsDBNull(dr("FechaModificacion")), Nothing, dr("FechaModificacion"))
				m_Observaciones = IIf(IsDBNull(dr("Observaciones")), Nothing, dr("Observaciones"))
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
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataTable
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDT(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataTable
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds.Tables(0))
		Catch ex As Exception
			Throw        
        End Try		
    End Function

	''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataSet
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns> 
    Public Shared Function RetrieveDS(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As DataSet
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
			ds.Tables(0).TableName = "SccReciboCaja"
			Return (ds)
		Catch ex As Exception
			Throw        
        End Try	
    End Function

    ''' <summary>
    ''' Trae de la base de datos un conjunto de objetos SccReciboCaja en un objeto DataReader
    ''' </summary>
    ''' <param name="sFilter">Condici?n que filtra los objetos a traer (WHERE)</param>
    ''' <param name="OrderBy">Campos por los que se ordenar? la salida</param>
    ''' <returns></returns>
    Public Shared Function RetrieveDR(Optional ByVal sFilter As String = "", Optional ByVal OrderBy As String = "", Optional Byval pFields as String = "*", optional Byval pTransac as TransactionManager = Nothing) As SqlDataReader
        Dim sSQL As String = "select " & pFields &" from SccReciboCaja"

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
    ''' 	Inserta en la base de datos una nueva instancia de la clase SccReciboCaja.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el m?todo Insert.</param>
    ''' <remarks></remarks>
	Public Sub Insert(Optional ByRef pTransac As TransactionManager = Nothing)
		Dim sCommand As String = "insert into SccReciboCaja("
		sCommand &= "objEstadoID,"
		sCommand &= "objAlumnoID,"
		sCommand &= "objSccCuentaID,"
		sCommand &= "AtencionA,"
		sCommand &= "objCajaID,"
		sCommand &= "objCajeroID,"
		sCommand &= "objPeriodoID,"
		sCommand &= "Numero,"
		sCommand &= "objTipoPagoID,"
		sCommand &= "Fecha,"
		sCommand &= "objMonedaID,"
		sCommand &= "TipoCambio,"
		sCommand &= "TotalRecibido,"
		sCommand &= "TotalRecibidoCordoba,"
		sCommand &= "MontoRecibidoEfectivo,"
		sCommand &= "MontoRecibidoEfectivoCordoba,"
		sCommand &= "Nota,"
		sCommand &= "objCuentaID,"
		sCommand &= "UsuarioCreacion,"
		sCommand &= "FechaCreacion,"
		sCommand &= "UsuarioModificacion,"
		sCommand &= "FechaModificacion,"
		sCommand &= "Observaciones) values ("		
		sCommand &= "@objEstadoID,"
		sCommand &= "@objAlumnoID,"
		sCommand &= "@objSccCuentaID,"
		sCommand &= "@AtencionA,"
		sCommand &= "@objCajaID,"
		sCommand &= "@objCajeroID,"
		sCommand &= "@objPeriodoID,"
		sCommand &= "@Numero,"
		sCommand &= "@objTipoPagoID,"
		sCommand &= "@Fecha,"
		sCommand &= "@objMonedaID,"
		sCommand &= "@TipoCambio,"
		sCommand &= "@TotalRecibido,"
		sCommand &= "@TotalRecibidoCordoba,"
		sCommand &= "@MontoRecibidoEfectivo,"
		sCommand &= "@MontoRecibidoEfectivoCordoba,"
		sCommand &= "@Nota,"
		sCommand &= "@objCuentaID,"
		sCommand &= "@UsuarioCreacion,"
		sCommand &= "@FechaCreacion,"
		sCommand &= "@UsuarioModificacion,"
		sCommand &= "@FechaModificacion,"
		sCommand &= "@Observaciones)"		
	
		sCommand &= " select "
		sCommand &= "@SccReciboCajaID = SccReciboCajaID from SccReciboCaja where "		
		sCommand &= "SccReciboCajaID = SCOPE_IDENTITY()"
		
		
		Dim arParams(23) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		arParams(0).Direction = ParameterDirection.Output
		arParams(1) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEstadoID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccCuentaID
        End If
		arParams(4) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_AtencionA
        End If
		arParams(5) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objCajaID
        End If
		arParams(6) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objCajeroID
        End If
		arParams(7) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPeriodoID
        End If
		arParams(8) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Numero
        End If
		arParams(9) = New SqlParameter("@objTipoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoPagoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objTipoPagoID
        End If
		arParams(10) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Fecha
        End If
		arParams(11) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objMonedaID
        End If
		arParams(12) = New SqlParameter("@TipoCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TipoCambio) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TipoCambio
        End If
		arParams(13) = New SqlParameter("@TotalRecibido", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibido) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalRecibido
        End If
		arParams(14) = New SqlParameter("@TotalRecibidoCordoba", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibidoCordoba) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TotalRecibidoCordoba
        End If
		arParams(15) = New SqlParameter("@MontoRecibidoEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_MontoRecibidoEfectivo) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_MontoRecibidoEfectivo
        End If
		arParams(16) = New SqlParameter("@MontoRecibidoEfectivoCordoba", SqlDbType.Decimal)		
		If IsDBNull(m_MontoRecibidoEfectivoCordoba) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_MontoRecibidoEfectivoCordoba
        End If
		arParams(17) = New SqlParameter("@Nota", SqlDbType.VarChar)		
		If IsDBNull(m_Nota) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Nota
        End If
		arParams(18) = New SqlParameter("@objCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaID) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_objCuentaID
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaCreacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
        End If
		arParams(22) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_FechaModificacion
        End If
		arParams(23) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_Observaciones
        End If
	
		Try
            If pTransac Is Nothing Then
				SqlHelper.ExecuteNonQuery(CommandType.Text, sCommand, arParams)        
			Else
				SqlHelper.ExecuteNonQuery(pTransac.Transaction, CommandType.Text, sCommand, arParams)        
			End If					
			
			m_SccReciboCajaID = arParams(0).Value
        Catch ex As Exception
            Throw        
        End Try
    End Sub	
#End Region
 
#Region " Update "

	''' <summary>
    ''' 	Actualiza el objeto SccReciboCaja en la base de datos.
    ''' </summary>	
    ''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' <remarks></remarks>
	Public Sub Update(Optional ByRef pTransac As TransactionManager = Nothing)        		
		Dim sCommand As String = "update SccReciboCaja set "		
		sCommand &= "objEstadoID = @objEstadoID,"
		sCommand &= "objAlumnoID = @objAlumnoID,"
		sCommand &= "objSccCuentaID = @objSccCuentaID,"
		sCommand &= "AtencionA = @AtencionA,"
		sCommand &= "objCajaID = @objCajaID,"
		sCommand &= "objCajeroID = @objCajeroID,"
		sCommand &= "objPeriodoID = @objPeriodoID,"
		sCommand &= "Numero = @Numero,"
		sCommand &= "objTipoPagoID = @objTipoPagoID,"
		sCommand &= "Fecha = @Fecha,"
		sCommand &= "objMonedaID = @objMonedaID,"
		sCommand &= "TipoCambio = @TipoCambio,"
		sCommand &= "TotalRecibido = @TotalRecibido,"
		sCommand &= "TotalRecibidoCordoba = @TotalRecibidoCordoba,"
		sCommand &= "MontoRecibidoEfectivo = @MontoRecibidoEfectivo,"
		sCommand &= "MontoRecibidoEfectivoCordoba = @MontoRecibidoEfectivoCordoba,"
		sCommand &= "Nota = @Nota,"
		sCommand &= "objCuentaID = @objCuentaID,"
		sCommand &= "UsuarioCreacion = @UsuarioCreacion,"
		sCommand &= "FechaCreacion = @FechaCreacion,"
		sCommand &= "UsuarioModificacion = @UsuarioModificacion,"
		sCommand &= "FechaModificacion = @FechaModificacion,"
		sCommand &= "Observaciones = @Observaciones"		
		sCommand &= " where "	
		sCommand &= "SccReciboCajaID = @SccReciboCajaID"					
		
		Dim arParams(23) As SqlParameter
		arParams(0) = New SqlParameter("@SccReciboCajaID", SqlDbType.Int)		
		If IsDBNull(m_SccReciboCajaID) Then
            arParams(0).Value = DBNull.Value
        Else
            arParams(0).Value = m_SccReciboCajaID
        End If
		arParams(1) = New SqlParameter("@objEstadoID", SqlDbType.Int)		
		If IsDBNull(m_objEstadoID) Then
            arParams(1).Value = DBNull.Value
        Else
            arParams(1).Value = m_objEstadoID
        End If
		arParams(2) = New SqlParameter("@objAlumnoID", SqlDbType.Int)		
		If IsDBNull(m_objAlumnoID) Then
            arParams(2).Value = DBNull.Value
        Else
            arParams(2).Value = m_objAlumnoID
        End If
		arParams(3) = New SqlParameter("@objSccCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objSccCuentaID) Then
            arParams(3).Value = DBNull.Value
        Else
            arParams(3).Value = m_objSccCuentaID
        End If
		arParams(4) = New SqlParameter("@AtencionA", SqlDbType.VarChar)		
		If IsDBNull(m_AtencionA) Then
            arParams(4).Value = DBNull.Value
        Else
            arParams(4).Value = m_AtencionA
        End If
		arParams(5) = New SqlParameter("@objCajaID", SqlDbType.Int)		
		If IsDBNull(m_objCajaID) Then
            arParams(5).Value = DBNull.Value
        Else
            arParams(5).Value = m_objCajaID
        End If
		arParams(6) = New SqlParameter("@objCajeroID", SqlDbType.Int)		
		If IsDBNull(m_objCajeroID) Then
            arParams(6).Value = DBNull.Value
        Else
            arParams(6).Value = m_objCajeroID
        End If
		arParams(7) = New SqlParameter("@objPeriodoID", SqlDbType.Int)		
		If IsDBNull(m_objPeriodoID) Then
            arParams(7).Value = DBNull.Value
        Else
            arParams(7).Value = m_objPeriodoID
        End If
		arParams(8) = New SqlParameter("@Numero", SqlDbType.VarChar)		
		If IsDBNull(m_Numero) Then
            arParams(8).Value = DBNull.Value
        Else
            arParams(8).Value = m_Numero
        End If
		arParams(9) = New SqlParameter("@objTipoPagoID", SqlDbType.Int)		
		If IsDBNull(m_objTipoPagoID) Then
            arParams(9).Value = DBNull.Value
        Else
            arParams(9).Value = m_objTipoPagoID
        End If
		arParams(10) = New SqlParameter("@Fecha", SqlDbType.DateTime)		
		If IsDBNull(m_Fecha) Then
            arParams(10).Value = DBNull.Value
        Else
            arParams(10).Value = m_Fecha
        End If
		arParams(11) = New SqlParameter("@objMonedaID", SqlDbType.Int)		
		If IsDBNull(m_objMonedaID) Then
            arParams(11).Value = DBNull.Value
        Else
            arParams(11).Value = m_objMonedaID
        End If
		arParams(12) = New SqlParameter("@TipoCambio", SqlDbType.Decimal)		
		If IsDBNull(m_TipoCambio) Then
            arParams(12).Value = DBNull.Value
        Else
            arParams(12).Value = m_TipoCambio
        End If
		arParams(13) = New SqlParameter("@TotalRecibido", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibido) Then
            arParams(13).Value = DBNull.Value
        Else
            arParams(13).Value = m_TotalRecibido
        End If
		arParams(14) = New SqlParameter("@TotalRecibidoCordoba", SqlDbType.Decimal)		
		If IsDBNull(m_TotalRecibidoCordoba) Then
            arParams(14).Value = DBNull.Value
        Else
            arParams(14).Value = m_TotalRecibidoCordoba
        End If
		arParams(15) = New SqlParameter("@MontoRecibidoEfectivo", SqlDbType.Decimal)		
		If IsDBNull(m_MontoRecibidoEfectivo) Then
            arParams(15).Value = DBNull.Value
        Else
            arParams(15).Value = m_MontoRecibidoEfectivo
        End If
		arParams(16) = New SqlParameter("@MontoRecibidoEfectivoCordoba", SqlDbType.Decimal)		
		If IsDBNull(m_MontoRecibidoEfectivoCordoba) Then
            arParams(16).Value = DBNull.Value
        Else
            arParams(16).Value = m_MontoRecibidoEfectivoCordoba
        End If
		arParams(17) = New SqlParameter("@Nota", SqlDbType.VarChar)		
		If IsDBNull(m_Nota) Then
            arParams(17).Value = DBNull.Value
        Else
            arParams(17).Value = m_Nota
        End If
		arParams(18) = New SqlParameter("@objCuentaID", SqlDbType.Int)		
		If IsDBNull(m_objCuentaID) Then
            arParams(18).Value = DBNull.Value
        Else
            arParams(18).Value = m_objCuentaID
        End If
		arParams(19) = New SqlParameter("@UsuarioCreacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioCreacion) Then
            arParams(19).Value = DBNull.Value
        Else
            arParams(19).Value = m_UsuarioCreacion
        End If
		arParams(20) = New SqlParameter("@FechaCreacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaCreacion) Then
            arParams(20).Value = DBNull.Value
        Else
            arParams(20).Value = m_FechaCreacion
        End If
		arParams(21) = New SqlParameter("@UsuarioModificacion", SqlDbType.VarChar)		
		If IsDBNull(m_UsuarioModificacion) Then
            arParams(21).Value = DBNull.Value
        Else
            arParams(21).Value = m_UsuarioModificacion
        End If
		arParams(22) = New SqlParameter("@FechaModificacion", SqlDbType.DateTime)		
		If IsDBNull(m_FechaModificacion) Then
            arParams(22).Value = DBNull.Value
        Else
            arParams(22).Value = m_FechaModificacion
        End If
		arParams(23) = New SqlParameter("@Observaciones", SqlDbType.VarChar)		
		If IsDBNull(m_Observaciones) Then
            arParams(23).Value = DBNull.Value
        Else
            arParams(23).Value = m_Observaciones
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
    ''' Borra un objeto SccReciboCaja de la base de datos.
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    ''' </summary>    
    Public Sub Delete(optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & m_SccReciboCajaID
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
    ''' Borra un objeto SccReciboCaja de la base de datos
    ''' </summary>    
    Public Shared Sub Delete(Byval p_SccReciboCajaID as Integer, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & " SccReciboCajaID = " & p_SccReciboCajaID
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
    ''' Borra objetos SccReciboCaja de la base de datos en base al par?metro WHERE
    ''' </summary>
    ''' <param name="pWhere">Condici?n usada para borrar los objetos de la base de datos.</param>
	''' <param name="pTransac">Opcional. La transacci?n en cuyo ?mbito ser? ejecutado el Update del objeto.</param>
    Public Shared Sub DeleteByFilter(Byval pWhere as String, optional Byval pTransac as TransactionManager = Nothing)
		Try
			Dim sSQL As String = "delete from SccReciboCaja where " & pWhere
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
