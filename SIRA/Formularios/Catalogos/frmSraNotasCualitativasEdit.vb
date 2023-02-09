Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient

Public Class frmSraNotasCualitativasEdit

#Region "Declaracion de Variables"
    Public intTypeGui As Integer
    Public intNotaID As Integer
    Public boolEditado As Boolean
    Dim fechaServidor As Date
    Dim dtModalidad As DataTable
    Public Shared dtGradosA, dtGradosEliminadas As DataTable

#End Region

#Region "Propiedades"
    Property TypeGui() As Integer
        Get
            Return intTypeGui
        End Get
        Set(ByVal value As Integer)
            intTypeGui = value
        End Set
    End Property

    Property NotaID() As Integer
        Get
            Return intNotaID
        End Get
        Set(ByVal value As Integer)
            intNotaID = value
        End Set
    End Property

#End Region

#Region "Carga de Datos"

    Private Sub CargarModalidad()
        Try
            'Modalidad
            dtModalidad = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("StbValorCatalogoID,Descripcion", "StbValorCatalogo", "objCatalogoID=(SELECT StbCatalogoID FROM StbCatalogo WHERE Nombre='MODALIDAD')"))
            Me.cmbModalidad.DataSource = dtModalidad
            Me.cmbModalidad.DisplayMember = "Descripcion"
            Me.cmbModalidad.ValueMember = "StbValorCatalogoID"
            Me.cmbModalidad.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            Me.cmbModalidad.ExtendRightColumn = True
            Me.cmbModalidad.SelectedValue = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub


    '' Descripción:        Procedimiento encargado de mostrar los datos de un grupo en modo de edición
    Public Sub CargarDatosNota()
        Dim objNotaCualitativa As SraNotas_Cualitativas
        Try
            objNotaCualitativa = New SraNotas_Cualitativas
            objNotaCualitativa.Retrieve(NotaID)

            txtValor.Text = objNotaCualitativa.Valor
            spnDesde.Value = objNotaCualitativa.Desde
            spnHasta.Value = objNotaCualitativa.Hasta
            chkActivo.Checked = objNotaCualitativa.Activo
            cmbModalidad.SelectedValue = objNotaCualitativa.objModalidadID

            lblFechaIngreso.Text = "Fecha de Ingreso: " + objNotaCualitativa.FechaCreacion
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objNotaCualitativa = Nothing
        End Try
    End Sub


#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarModalidad()
            Select Case TypeGui

                Case 1
                    Me.Text = "Nuevo rango de notas cualitativas"
                    Me.chkActivo.Enabled = False
                    Me.chkActivo.Checked = True
                Case 2
                    Me.Text = "Editar rango de notas cualitativas"
                    Me.chkActivo.Enabled = True
                    Me.CargarDatosNota()
                Case 3
                    Me.Text = "Consultar de notas cualitativas"
                    Me.CargarDatosNota()

                    Me.chkActivo.Enabled = False
                    Me.cmdGuardar.Enabled = False

            End Select
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de configurar la longitud maxima de los controles de entrada de texto
    Public Sub EstablecerPropiedades()
        Try
            'txtNombre.MaxLength = StbTienda.GetMaxLength("Nombre")
            'txtCodigo.MaxLength = StbTienda.GetMaxLength("Codigo")
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Guardar Notas cualitativas"

    '' Descripción:        Procedimiento encargado de guardar Notas cualitativas
    Public Sub GuardarNotas()
        Dim T As New DAL.TransactionManager
        Try
            fechaServidor = clsProyecto.Conexion.FechaServidor
            T.BeginTran()
            CrearNotas(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de guardar los datos de una asignatura
    Public Sub CrearNotas(ByVal T As DAL.TransactionManager)
        Dim objNotas As SraNotas_Cualitativas
        Dim objGradosNotas As New SraRangosGrados

        Try
            objNotas = New SraNotas_Cualitativas
            objNotas.Valor = txtValor.Text
            objNotas.Desde = spnDesde.Value
            objNotas.Hasta = spnHasta.Value

            objNotas.Activo = chkActivo.Checked
            objNotas.objModalidadID = cmbModalidad.SelectedValue

            objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objNotas.FechaCreacion = fechaServidor
            objNotas.Insert(T)
            NotaID = objNotas.SraNotas_CualitativaID

            ''Eliminar Datos
            SraRangosGrados.DeleteByFilter("objNotaCualitativaID=" & NotaID, T)

            ''Guardar Grados
            For Each dr As DataRow In dtGradosA.Rows
                objGradosNotas.objNotaCualitativaID = NotaID
                objGradosNotas.objGradoID = CInt(dr("GradoID").ToString)
                objGradosNotas.Activo = True
                objGradosNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosNotas.Insert(T)
            Next

            For Each dr As DataRow In dtGradosEliminadas.Rows
                objGradosNotas.objNotaCualitativaID = NotaID
                objGradosNotas.objGradoID = CInt(dr("GradoID").ToString)
                objGradosNotas.Activo = False
                objGradosNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosNotas.Insert(T)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#End Region

#Region "Actualizar Notas_Cualitativas"

    '' Descripción:        Procedimiento encargado de actualizar Notas_Cualitativas
    Public Sub ActualizarNotas()
        Dim T As New DAL.TransactionManager
        Try
            T.BeginTran()
            fechaServidor = clsProyecto.Conexion.FechaServidor
            ModificarDatosGrupo(T)
            T.CommitTran()
            MsgBox(My.Resources.MsgActualizado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.boolEditado = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Procedimiento encargado de modificar los datos de un grNotas_Cualitativasupo
    Public Sub ModificarDatosGrupo(ByVal T As DAL.TransactionManager)
        Dim objNotas As SraNotas_Cualitativas
        Dim objGradosNotas As New SraRangosGrados
        Try

            objNotas = New SraNotas_Cualitativas
            objNotas.Retrieve(NotaID)

            objNotas.Valor = txtValor.Text
            objNotas.Desde = spnDesde.Value
            objNotas.Hasta = spnHasta.Value
            objNotas.Activo = chkActivo.Checked
            objNotas.objModalidadID = cmbModalidad.SelectedValue

            objNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
            objNotas.FechaCreacion = fechaServidor
            objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
            objNotas.FechaModificacion = fechaServidor
            objNotas.Update(T)


            ''Eliminar Datos
            SraRangosGrados.DeleteByFilter("objNotaCualitativaID=" & NotaID, T)

            ''Guardar Grados
            For Each dr As DataRow In dtGradosA.Rows
                objGradosNotas.objNotaCualitativaID = NotaID
                objGradosNotas.objGradoID = CInt(dr("GradoID").ToString)
                objGradosNotas.Activo = True
                objGradosNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosNotas.Insert(T)
            Next

            For Each dr As DataRow In dtGradosEliminadas.Rows
                objGradosNotas.objNotaCualitativaID = NotaID
                objGradosNotas.objGradoID = CInt(dr("GradoID").ToString)
                objGradosNotas.Activo = False
                objGradosNotas.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objGradosNotas.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objGradosNotas.Insert(T)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objNotas = Nothing
        End Try
    End Sub

#End Region

#Region "Funciones"

#Region "Validaciones"

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If cmbModalidad.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbModalidad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If txtValor.Text.Trim.Length = 0 Then
                ErrorProv.SetError(txtValor, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If spnDesde.Text.Trim.Length = 0 Then
                ErrorProv.SetError(spnDesde, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If
            If spnHasta.Text.Trim.Length = 0 Then
                ErrorProv.SetError(spnHasta, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function
#End Region

#End Region

#Region "Eventos del formulario"

    Public Sub CargarGradosAsignadas()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtGradosA = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, SraRangosGradosID, objNotaCualitativaID, GradoID, CodigoGrado, Grado", "vwSraGradosRangos", "objNotaCualitativaID= " + NotaID.ToString + " and " + strFiltro))
            dtGradosEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("Seleccionar, SraRangosGradosID, objNotaCualitativaID, GradoID, CodigoGrado, Grado", "vwSraGradosRangos", "objNotaCualitativaID= " + NotaID.ToString + " and Activo=0"))

            grdGradosA.DataSource = dtGradosA
            grdGradosA.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstablecerPropiedades()
        ConfigurarGUI()
        CargarGradosAsignadas()
        'txtNombre.Focus()
        boolEditado = False
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            Select Case TypeGui
                Case 1
                    GuardarNotas()
                Case 2
                    ActualizarNotas()
            End Select
        End If
    End Sub



#End Region

#Region "KeyPress controles"

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.Clear()
        boolEditado = True
    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs)
        ErrorProv.SetError(txtValor, "")
        boolEditado = True
    End Sub

    Private Sub frmBodegasEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If boolEditado Then
            If MsgBox(My.Resources.MsgConfirmarGuardar, MsgBoxStyle.Question + MsgBoxStyle.YesNo, clsProyecto.SiglasSistema) = MsgBoxResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            'If Me.txtNombre.Text.Trim.Length <> 0 Then
            '    Me.txtCodigo.Focus()
            'End If
        End If
    End Sub


    Private Sub chkActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.cmdGuardar.Focus()
        End If
    End Sub


#End Region


    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        ErrorProv.SetError(cmbModalidad, "")
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        ErrorProv.SetError(txtValor, "")
    End Sub

   
    Private Sub spnDesde_TextChanged(sender As Object, e As EventArgs) Handles spnDesde.TextChanged
        ErrorProv.SetError(spnDesde, "")
    End Sub

    Private Sub spnHasta_TextChanged(sender As Object, e As EventArgs) Handles spnHasta.TextChanged
        ErrorProv.SetError(spnHasta, "")
    End Sub

    Private Sub cmdAgregarGrados_Click(sender As Object, e As EventArgs) Handles cmdAgregarGrados.Click
        Try

            Dim objSeleccion As frmGradosSelector
            objSeleccion = New frmGradosSelector

            objSeleccion.Opcion = 1
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim filas As DataRow
                For Each dr As DataRow In frmGradosSelector.dtGradosSelect.Rows
                    filas = dtGradosA.NewRow
                    filas("GradoID") = CInt(dr("GradoID").ToString)
                    filas("CodigoGrado") = (dr("CodigoGrado").ToString)
                    filas("Grado") = (dr("Grado").ToString)
                    dtGradosA.Rows.Add(filas)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminarGrados_Click(sender As Object, e As EventArgs) Handles cmdEliminarGrados.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdGradosATable.SelectedRowsCount() - 1
                If (grdGradosATable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdGradosATable.GetDataRow(grdGradosATable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaGradosEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtGradosEliminadas.NewRow
                filas("GradoID") = CInt(drFilaGradosEliminadas("GradoID"))
                filas("CodigoGrado") = drFilaGradosEliminadas("CodigoGrado").ToString
                filas("Grado") = drFilaGradosEliminadas("Grado").ToString
                dtGradosEliminadas.Rows.Add(filas)

            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaGradosE As DataRow = CType(Rows(I), DataRow)
                dtGradosA.Rows.Remove(drFilaGradosE)
            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
End Class