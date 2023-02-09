'-----------------------------------------------------------------------
''----------------------------------------------------------------------
''-------------------------------------------------------------------------
''--    Formulario de Edición y Modificación 
''-------------------------------------------------------------------------
Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports Proyecto.Catalogos.Datos
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports SIRA.BO
Imports SIRA.BO.clsConsultas

Public Class frmSccEditMora
    Dim DtEmpleado, dtBeca, dtCajas As DataTable
    Dim m_IDCuenta As String
    Dim m_IDTienda As Integer
    Dim dtConcepto As DataTable
    Dim dtEstado As DataTable
    Dim m_TypeGui As Integer
    Dim m_IDNotaDebito As Integer
    Dim DtFacturas As New DataTable

    Property IDNotaDebito() As Integer
        Get
            IDNotaDebito = Me.m_IDNotaDebito
        End Get
        Set(ByVal value As Integer)
            Me.m_IDNotaDebito = value
        End Set
    End Property

    Property TypeGui() As Integer
        Get
            TypeGui = Me.m_TypeGui
        End Get
        Set(ByVal value As Integer)
            Me.m_TypeGui = value
        End Set
    End Property


    Property IdCuenta() As String
        Get
            IdCuenta = Me.m_IDCuenta
        End Get
        Set(ByVal value As String)
            Me.m_IDCuenta = value
        End Set
    End Property

    Property IDTienda() As Integer
        Get
            IDTienda = Me.m_IDTienda
        End Get
        Set(ByVal value As Integer)
            Me.m_IDTienda = value
        End Set
    End Property



#Region "Cargar Becas"

    '' Descripción:        Procedimiento encargado de cargar el combo de jefe de tienda
    Private Sub CargarBecas()
        Try
            dtBeca = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("BecaID,Descripcion", "SraBecas", "Activo=1"))
            Me.cmbBeca.DataSource = dtBeca
            Me.cmbBeca.DisplayMember = "Descripcion"
            Me.cmbBeca.ValueMember = "BecaID"
            Me.cmbBeca.Splits(0).DisplayColumns("BecaID").Visible = False
            Me.cmbBeca.ExtendRightColumn = True
            Me.cmbBeca.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)

        End Try
    End Sub
#End Region

    ''' <summary>
    ''' Procedimiento encargado de seleccionar la cuenta. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SeleccionarCuenta()
        Try
            Dim objCuentasSeleccion As New frmSccSeleccionCuentas
            If objCuentasSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.txtNumCuenta.Text = objCuentasSeleccion.NumeroCuenta
                Me.IdCuenta = objCuentasSeleccion.SccCuentaID
                Me.txtCliente.Text = objCuentasSeleccion.AlumnoID
                Me.cmdGuardar.Enabled = True

            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    

    Private Function ValidarDatos() As Boolean
        Dim obj As Object
        Try
            If Not Me.DtFacturas Is Nothing Then
                obj = Me.DtFacturas.Compute("COUNT(Seleccion)", "Seleccion=1")
                If Not IsDBNull(obj) Then
                    If obj = 0 Then
                        MsgBox("Necesita Seleccionar una Factura", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                        Return False
                        Exit Function
                    End If
                End If
            Else
                MsgBox("No hay facturas cargadas", MsgBoxStyle.Critical, clsProyecto.SiglasSistema)
                Return False
                Exit Function
            End If


            If IsDBNull(Me.dtpFecha.Value) Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Campo Obligatorio")
                Return False
                Exit Function
            End If

            If Me.dtpFecha.Value > clsProyecto.Conexion.FechaServidor Then
                Me.ErrorProv.SetError(Me.dtpFecha, "Fecha de Nota de Crédito Incorrecta")
                Return False
                Exit Function
            End If

            If Me.numMonto.Value <= 0 Then
                Me.ErrorProv.SetError(Me.numMonto, "Monto debe ser mayor que cero")
                Return False
                Exit Function
            End If
            Return True
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function

    Private Sub cmdExpediente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Me.SeleccionarCuenta()
    End Sub

#Region "Guardado de Datos"
    Private Function GuardarND() As Boolean
        Dim T As New TransactionManager
        Dim objNC As New SccMora
        Dim BoolRst As Boolean
        Dim DtDatos(1) As DataRow
        Try
            Try

                BoolRst = False
                T.BeginTran()
                objNC.Descripcion = Me.txtDescripcion.Text
                objNC.Fecha = Me.dtpFecha.Value
                objNC.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objNC.Monto = Me.numMonto.Value
                objNC.objEstadoID = Me.cmbEstado.SelectedValue

                'objNC.Numero = SccNotaDebito.RetrieveDT(, , "(ISNULL(MAX(Numero),0) + 1) as Maximo", T).DefaultView.Item(0)("Maximo")
                objNC.UsuarioCreacion = clsProyecto.Conexion.Usuario

                objNC.objSccCuentaID = Me.IdCuenta
                DtDatos = Me.DtFacturas.Select("Seleccion = 1")
                'objNC.objFacturaID = DtDatos(0)("SfaFacturaID")

                'objNC.objCajaID = cmbCajas.SelectedValue
                objNC.Insert(T)
                Me.IDNotaDebito = objNC.SccMoraID

                T.CommitTran()
                MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)

                BoolRst = True
            Catch ex As Exception
                T.RollbackTran()
                clsError.CaptarError(ex)
            End Try
        Finally
            DtDatos = Nothing
            objNC = Nothing
            T = Nothing
        End Try

        Return BoolRst
    End Function
#End Region

    Private Sub frmSccEditNotaCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargaDatos()

    End Sub

    ''' <summary>
    ''' Procedimiento principal de Carga de Datos
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargaDatos()
        Try
            Me.CargarEstado()
            CargarBecas()
            If Me.TypeGui > 0 Then
                Me.CargarDatosEdicion()
                If Me.TypeGui = 2 Then
                    Me.dtpFecha.Enabled = False
                    Me.txtDescripcion.Enabled = False
                    txtCliente.Enabled = False
                    txtNumCuenta.Enabled = False
                    Me.numMonto.Enabled = False
                    Me.cmdGuardar.Enabled = False
                End If

            End If

           
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las estados posibles de las notas de credito
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarEstado()
        Try
            dtEstado = New DataTable
            dtEstado = ClsCatalogos.ObtenerValCat("ESTADOMORA")
            With Me.cmbEstado
                .DataSource = Me.dtEstado
                .ValueMember = "StbValorCatalogoID"
                .DisplayMember = "Descripcion"
                .Splits(0).DisplayColumns("Codigo").Visible = False
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .Splits(0).DisplayColumns("Activo").Visible = False
                .ExtendRightColumn = True
                .ColumnHeaders = False
            End With

            If Me.TypeGui = 0 Then
                Me.cmbEstado.SelectedValue = ClsCatalogos.ObtenerIDSTbCatalogo("ESTADOMORA", "REGISTRADA")
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento encargado de cargar las notas de credito en Modo edicion y Consulta
    '

    Private Sub CargarDatosEdicion()
        Dim dtDatos As New DataTable
        Dim objNotDeb As New SccMora
        Try
            Try

                dtDatos = SqlHelper.ExecuteQueryDT(clsConsultas.ObtenerConsultaGeneral("Direccion, objBecaID, Grupo, Mes, SccMoraID, Fecha, Monto, Descripcion, objEstadoID, SccCuentaID, StbPersonaID, Alumno, Estado, NumCuenta", "vwSccMora", "SccMoraID=" & Me.IDNotaDebito.ToString))
                Me.cmbEstado.SelectedValue = dtDatos.DefaultView.Item(0)("objEstadoID")
                Me.txtNumero.Text = dtDatos.DefaultView.Item(0)("Mes")
                Me.txtDescripcion.Text = dtDatos.DefaultView.Item(0)("Descripcion")
                Me.txtDireccion.Text = dtDatos.DefaultView.Item(0)("Direccion")
                If Not IsDBNull(dtDatos.DefaultView.Item(0)("Alumno")) Then
                    Me.txtCliente.Text = dtDatos.DefaultView.Item(0)("Alumno")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("objBecaID")) Then
                    Me.cmbBeca.SelectedValue = dtDatos.DefaultView.Item(0)("objBecaID")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("Grupo")) Then
                    Me.txtGrupo.Text = dtDatos.DefaultView.Item(0)("Grupo")
                End If

                If Not IsDBNull(dtDatos.DefaultView.Item(0)("NumCuenta")) Then
                    Me.txtNumCuenta.Text = dtDatos.DefaultView.Item(0)("NumCuenta")
                End If

                Me.numMonto.Value = dtDatos.DefaultView.Item(0)("Monto")
                Me.dtpFecha.Value = dtDatos.DefaultView.Item(0)("Fecha")
                objNotDeb.Retrieve(Me.IDNotaDebito)

                If Not objNotDeb.objSccCuentaID Then
                    Me.IdCuenta = objNotDeb.objSccCuentaID
                End If

             
            Catch ex As Exception
                clsError.CaptarError(ex)
            End Try
        Finally
            dtDatos = Nothing
            objNotDeb = Nothing
        End Try
    End Sub






    ''' <summary>
    ''' Procedimiento encargad de Actualizar Nota de Credito.

    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function ActualizarND() As Boolean
        Dim T As New TransactionManager
        Dim objNotaDebito As New SccMora
        Dim boolrst As Boolean
        Try
            boolrst = False
            objNotaDebito.Retrieve(Me.IDNotaDebito)
            T.BeginTran()
            objNotaDebito.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objNotaDebito.FechaModificacion = clsProyecto.Conexion.FechaServidor
            objNotaDebito.Fecha = Me.dtpFecha.Value
            objNotaDebito.Monto = Me.numMonto.Value
            objNotaDebito.SccMoraID = Me.IDNotaDebito
            objNotaDebito.Update(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            boolrst = True
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
        Return boolrst
    End Function

    Private Sub numMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMonto.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub cmbConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ErrorProv.Clear()
    End Sub

    Private Sub dtpFecha_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.TextChanged
        Me.ErrorProv.Clear()
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Me.ErrorProv.Clear()
    End Sub


    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        If Me.ValidarDatos Then
            Select Case Me.TypeGui
                Case 0
                    If Me.GuardarND Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Case 1
                    If Me.ActualizarND Then
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
            End Select
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub numMonto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles numMonto.Validating
        Dim p As Integer
        Dim s As Integer
        Dim ValorMaximo As Decimal
        Try
            p = SccCuentaPorCobrarDetalle.GetMaxLength("MontoTotal")
            s = SccCuentaPorCobrarDetalle.GetScale("MontoTotal")
            ValorMaximo = ObtenerMaxValor(p, s)

            If Me.numMonto.Value > ValorMaximo Then
                Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
                Me.numMonto.Value = 0
            Else
                Me.ErrorProv.Clear()
            End If

        Catch ex As Exception
            Me.ErrorProv.SetError(Me.numMonto, "Valor fuera de rango. Valor Máximo : " & ValorMaximo)
            Me.numMonto.Value = 0
        End Try
    End Sub
End Class