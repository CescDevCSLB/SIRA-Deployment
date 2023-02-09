Public Class clsConsultas

#Region "Catalogos Generales"

    
    ''' <summary>
    ''' Recupera datos de la Tabla Parámetro
    ''' </summary>
    ''' <param name="strCampos">Campos a mostrar</param>
    ''' <param name="strFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerValorParametro(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM StbParametro " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function


    ''' <summary>
    ''' Obtiene los valores del catalogo especificado
    ''' </summary>
    ''' <param name="strCampos"></param>
    ''' <param name="strFiltro"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ObtenerCatalogoValor(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwStbCatValores " & _
                     " WHERE " & strFiltro

            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If

            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Shared Function ObtenerTasaCambioOficial(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwStbTasaCambioOficial " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Shared Function ObtenerNotaCredito(ByVal strCampos As String, Optional ByVal strFiltro As String = "1=1", Optional ByVal OrderBy As String = "") As String
        Dim strSQL As String
        Try
            strSQL = " SELECT " & strCampos & _
                     " FROM vwSccNotaCredito " & _
                     " WHERE " & strFiltro
            If OrderBy <> "" Then
                strSQL &= " ORDER BY " & OrderBy
            End If
            Return strSQL
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

#Region "Obtener Consulta General"

    Public Shared Function ObtenerConsultaGeneral(ByVal strCampos As String, ByVal strVista_Tabla As String, Optional ByVal strFiltro As String = "1=1") As String
        Dim Query As String
        Try
            Query = " SELECT " & strCampos & _
                     " FROM " & strVista_Tabla & _
                     " WHERE " & strFiltro
            Return Query
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Shared Function ObtenerProcedimientoGeneral(ByVal str As String) As String
        Dim Query As String
        Try
            Query = str
            Return Query
        Catch ex As Exception
            Throw
        End Try
    End Function

#End Region

#Region "Obtener Moneda"
    Public Shared Function ObtenerMoneda(ByVal strMoneda As String, ByVal strCodigo As String) As String
        Dim query As String
        Try
            query = " select [dbo].[FnValorCatalogoID]('" & strMoneda & "','" & strCodigo & "') as objMoneda"
                   
            Return query
        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region

    ''' <summary>
    ''' Método que actualiza una columna del dt
    ''' </summary>
    ''' <param name="objDataTable">origen de dato con la estructura previamiente definidos</param>
    ''' <param name="strnNombrellave">Nombre del campo de llave</param>
    ''' <param name="intIdLlave">Id del campo llave</param>
    ''' <param name="strNombreCampo">nombre del campo al cual se cambiará el valor</param>
    ''' <param name="strNuevoValor">nuevo valor del campo</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function actualizarColumnaDT(ByVal objDataTable As DataTable, ByVal strnNombrellave As String, ByVal intIdLlave As Integer, ByVal strNombreCampo As String, ByVal strNuevoValor As Object)

        Dim dtNuevaprjSeguridad As DataTable = objDataTable.Clone
        dtNuevaprjSeguridad = objDataTable
        Dim Filas() As DataRow = Nothing

        Filas = dtNuevaprjSeguridad.Select(String.Format("{0}={1}", strnNombrellave, intIdLlave))
        Filas(0)(strNombreCampo) = strNuevoValor
        dtNuevaprjSeguridad.AcceptChanges()
        Return dtNuevaprjSeguridad

    End Function

End Class
