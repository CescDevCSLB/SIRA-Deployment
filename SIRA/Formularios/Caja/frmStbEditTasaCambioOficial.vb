
Imports DAL
Imports SIRA.BO
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frmStbEditTasaCambioOficial

#Region "Declaracion de Variables Locales y Objetos"
    Dim objTasaCambio As StbTasaCambioOficial
    Dim dtTasaCambio As New DataTable
    Dim dtMoneda As DataTable
    Dim dtMes As DataTable
    Dim decMontoMax As Decimal
    Dim strCampos As String
    Dim strFiltro As String
    Dim strOrden As String
    Dim strSQL As String
    Private m_EstadoRegistarda As Integer
    Private m_EstadoConfirmada As Integer
    Private intTasaCambioOficialID As Integer
    Dim TyGui_Lec As Integer

#End Region

#Region "Propiedades"
    Public Property TipoEstadoRegistarda() As Integer
        Get
            Return m_EstadoRegistarda
        End Get
        Set(ByVal value As Integer)
            m_EstadoRegistarda = value
        End Set
    End Property

    Public Property TipoEstadoConfirmada() As Integer
        Get
            Return m_EstadoConfirmada
        End Get
        Set(ByVal value As Integer)
            m_EstadoConfirmada = value
        End Set
    End Property

    Public Property TasaCambioOficialID() As Integer
        Get
            Return intTasaCambioOficialID
        End Get
        Set(ByVal value As Integer)
            intTasaCambioOficialID = value
        End Set
    End Property

    Property TypeID() As Integer
        Get
            Return TyGui_Lec
        End Get
        Set(ByVal value As Integer)
            TyGui_Lec = value
        End Set
    End Property
#End Region

#Region "Eventos del Formulario"

    Private Sub frmEditTasaCambioOficial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            objTasaCambio = New StbTasaCambioOficial

            Select Case TypeID
                Case 0
                    Me.Text = "Nueva tasa de cambio"
                    PropiedadesFormulario()
                Case 1
                    CargarDatosEditar()

            End Select

            clsProyecto.CargarTemaDefinido(Me)
            
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

#Region "Propiedades del Formulario"

     Private Sub PropiedadesFormulario()
        Dim P As Integer
        Dim S As Integer
        Try
            CargarComboMoneda()

            '-- Poner la fecha del Servidor
            Me.dtFecha.EditValue = clsProyecto.Conexion.FechaServidor

            '-- Obtener el Maximo valor para el monto de la Tasa de Cambio

            P = StbTasaCambioOficial.GetMaxLength("Monto")
            S = StbTasaCambioOficial.GetScale("Monto")
            Me.decMontoMax = ObtenerMaxValor(P, S)

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            P = Nothing
            S = Nothing
        End Try
    End Sub

    Private Sub CargarDatosEditar()
        Dim P As Integer
        Dim S As Integer
        Dim objTasaCambio As New StbTasaCambioOficial
        Try

            PropiedadesFormulario()
            Dim objarqueo As New SccArqueoCaja

            objTasaCambio.Retrieve(TasaCambioOficialID)
            Me.nmuMonto.Value = objTasaCambio.Monto
            dtFecha.EditValue = objTasaCambio.Fecha
            Me.cmbMoneda.SelectedValue = objTasaCambio.objMonedaID

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            P = Nothing
            S = Nothing
        End Try
    End Sub

#End Region

#Region "Combos"

    Private Sub CargarComboMoneda()
        Try
            strCampos = " StbValorCatalogoID, Descripcion"
            strFiltro = " Nombre='Moneda' AND NOT Codigo='COR' "
            strOrden = " Descripcion "
            strSQL = clsConsultas.ObtenerCatalogoValor(strCampos, strFiltro, strOrden)
            dtMoneda = SqlHelper.ExecuteQueryDT(strSQL)
            If dtMoneda.Rows.Count > 0 Then
                Me.cmbMoneda.DataSource = dtMoneda
                Me.cmbMoneda.ValueMember = "StbValorCatalogoID"
                Me.cmbMoneda.DisplayMember = "Descripcion"
                Me.cmbMoneda.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                Me.cmbMoneda.Splits(0).ExtendRightColumn = True
                If Me.dtMoneda.Rows.Count = 1 Then
                    Me.cmbMoneda.SelectedIndex = 0
                Else
                    Me.cmbMoneda.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbMoneda_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedValueChanged
        Me.ErrorProvider1.Clear()
    End Sub

  
    Private Sub cmbMes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.ErrorProvider1.Clear()
    End Sub

#End Region

#Region "Evento Botones Aceptar - Cancelar"

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Try
            Select Case TypeID
                Case 0
                    GuardarTasasCambioOficial()
                Case 1
                    UpdateTasa()
            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub

    Private Sub UpdateTasa()
        Dim T As New DAL.TransactionManager
        Dim objTasaCambio As New StbTasaCambioOficial
        Try
            T.BeginTran()
            If objTasaCambio.RetrieveByFilter("StbTasaCambioOficialID <> " & TasaCambioOficialID & " AND Mes = " & dtFecha.DateTime.Month & " AND Dia= " & dtFecha.DateTime.Day & "  AND Anio = " & dtFecha.DateTime.Year & " AND objMonedaID = " & cmbMoneda.SelectedValue, T) Then
                MsgBox("Ya existe una Tasa de cambio registrada para este año y mes", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Exit Sub
            Else
                objTasaCambio.Retrieve(TasaCambioOficialID)
                objTasaCambio.Mes = dtFecha.DateTime.Month
                objTasaCambio.Anio = dtFecha.DateTime.Year
                objTasaCambio.Dia = dtFecha.DateTime.Day
                objTasaCambio.Monto = Me.nmuMonto.Value
                objTasaCambio.Fecha = dtFecha.EditValue
                objTasaCambio.objMonedaID = Me.cmbMoneda.SelectedValue
                objTasaCambio.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objTasaCambio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objTasaCambio.Update(T)
            End If

            T.CommitTran()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub GuardarTasasCambioOficial()

        Dim blnAgregar As Boolean = False
        Try
            If ValidarDatos() Then

                '-----------------------------------------------------------
                '-- GUARDAR LAS TASAS DE CAMBIO
                '-----------------------------------------------------------

                '--Verificar que no exista una tasa de cambio para el mes y año seleccionado

                If Not objTasaCambio.RetrieveByFilter("Mes = " & dtFecha.DateTime.Month & " AND Dia= " & dtFecha.DateTime.Day & "  AND Anio = " & dtFecha.DateTime.Year & " AND objMonedaID = " & cmbMoneda.SelectedValue) Then
                    objTasaCambio.Mes = dtFecha.DateTime.Month
                    objTasaCambio.Anio = dtFecha.DateTime.Year
                    objTasaCambio.Dia = dtFecha.DateTime.Day
                    objTasaCambio.Monto = Me.nmuMonto.Value
                    objTasaCambio.Fecha = dtFecha.EditValue
                    objTasaCambio.objMonedaID = Me.cmbMoneda.SelectedValue
                    objTasaCambio.objEstadoID = Me.TipoEstadoRegistarda
                    objTasaCambio.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objTasaCambio.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objTasaCambio.Insert()
                    Me.TasaCambioOficialID = DAL.SqlHelper.ExecuteQueryDT("SELECT MAX(StbTasaCambioOficialID) as ID FROM StbTasaCambioOficial").DefaultView.Item(0)("ID")
                    blnAgregar = True
                Else
                    MsgBox("Ya existe una Tasa de cambio registrada para este año y mes", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                    Exit Sub
                End If

                '-----------------------------------------------------------
                '-- CONFIRMAR LAS TASAS DE CAMBIO
                '-----------------------------------------------------------
                '-- Verificar si se agregaron registros o si se actualizaron registros.
                If blnAgregar Then
                    Select Case MsgBox("¿Desea confirmar la tasa de cambio registrada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema)
                        Case MsgBoxResult.Yes
                            objTasaCambio.objEstadoID = Proyecto.Catalogos.Datos.ClsCatalogos.ObtenerIDSTbCatalogo("EstadoTasaCambio", "CONFIRMADO")
                            objTasaCambio.FechaModificacion = clsProyecto.Conexion.FechaServidor
                            objTasaCambio.UsuarioModificacion = clsProyecto.Conexion.Usuario
                            objTasaCambio.Update()
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                        Case MsgBoxResult.No
                            Me.DialogResult = Windows.Forms.DialogResult.OK
                    End Select
                End If
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Me.dtFecha.EditValue.ToString.Length = 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            Select Case MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNoCancel, clsProyecto.SiglasSistema)
                Case MsgBoxResult.Yes
                    GuardarTasasCambioOficial()
                Case MsgBoxResult.No
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Case MsgBoxResult.Cancel
            End Select
        End If
    End Sub


#End Region

#Region "Verificacion de las Entradas"

    Private Function ValidarDatos() As Boolean
        Dim Contador As Integer = 0
        Try
            If Me.cmbMoneda.Text = "" Then
                Me.ErrorProvider1.SetError(Me.cmbMoneda, "Campo obligatorio.")
                Me.cmbMoneda.Focus()
                Return False
            End If
            If Me.dtFecha.EditValue.ToString().Length = 0 Then
                Me.ErrorProvider1.SetError(Me.dtFecha, "Campo obligatorio.")
                Me.dtFecha.Focus()
                Return False
            End If
          
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

#End Region

#Region "Validacion de las Entradas"
    Private Sub txtAnio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not clsProyecto.NumerosSinEspacio(e.KeyChar) Then
            e.Handled = True
            e.KeyChar = Microsoft.VisualBasic.ChrW(0)
        End If

    End Sub

    Private Sub nmuMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nmuMonto.ValueChanged
        Me.ErrorProvider1.Clear()
    End Sub
#End Region


    
    
End Class