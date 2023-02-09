Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmBuscarEvidencias

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public Shared dtEvidenciaselect As DataTable
    Public dtPeriodos, DtParcial, dtCategorias, dtEvidencias As DataTable
#End Region

#Region "Propiedades"
    Public Property Filtro() As String
        Get
            Return strFiltro
        End Get
        Set(ByVal value As String)
            strFiltro = value
        End Set
    End Property

    Public Property Seleccion() As String
        Get
            Return strSeleccion
        End Get
        Set(ByVal value As String)
            strSeleccion = value
        End Set
    End Property


#End Region

#Region "Procedimientos"

    Public Sub CargarPeriodos()
        Try
            dtPeriodos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" PeriodoID, Periodo, Activo", "SraPeriodos", "1=1 ORDER BY Periodo desc"))

            cmbPeriodo.ValueMember = "PeriodoID"
            cmbPeriodo.DisplayMember = "Periodo"
            cmbPeriodo.DataSource = dtPeriodos

            cmbPeriodo.Splits(0).DisplayColumns("PeriodoID").Visible = False
            cmbPeriodo.Splits(0).DisplayColumns("Activo").Visible = False
            cmbPeriodo.ColumnHeaders = False
            cmbPeriodo.ExtendRightColumn = True
            cmbPeriodo.SelectedIndex = 0
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarParcial()
        Try
            DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
            DtParcial.DefaultView.Sort = "Descripcion"

            cmbParcial.ValueMember = "StbValorCatalogoID"
            cmbParcial.DisplayMember = "Descripcion"
            cmbParcial.DataSource = DtParcial
            cmbParcial.Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
            cmbParcial.ColumnHeaders = False
            cmbParcial.ExtendRightColumn = True
            cmbParcial.SelectedIndex = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Public Sub CargarCategorias()
        Try
            Dim strFiltro As String = ""
            strFiltro = "objPeriodoID = " & cmbPeriodo.SelectedValue & " AND Activa =1 "
            dtCategorias = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SraEvidenciasID, NombreEvidencia", "vwSraEvidencias", strFiltro))

            cmbCategoria.ValueMember = "SraEvidenciasID"
            cmbCategoria.DisplayMember = "NombreEvidencia"
            cmbCategoria.DataSource = dtCategorias

            cmbCategoria.Splits(0).DisplayColumns("SraEvidenciasID").Visible = False
            cmbCategoria.ColumnHeaders = False
            cmbCategoria.ExtendRightColumn = True
            cmbCategoria.SelectedIndex = 0

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarEvidencias()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo =1 AND objEvidenciasID=" & cmbCategoria.SelectedValue

            dtEvidencias = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SraEvidenciasDetalleID, Nombre", "SraEvidenciaDetalle", strFiltro))
            dtEvidenciaselect = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SraEvidenciasDetalleID, Nombre", "SraEvidenciaDetalle", "1=0"))

            Me.grdCuentas.DataSource = dtEvidencias
            Me.grdCuentas.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Function ValidarEntrada()

        If Me.cmbPeriodo.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbPeriodo, "Debe seleccionar el período")
            Me.cmbPeriodo.Focus()
            Return False
            Exit Function
        End If

        If Me.cmbParcial.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbParcial, "Debe seleccionar el parcial")
            Me.cmbParcial.Focus()
            Return False
            Exit Function
        End If

        If Me.cmbCategoria.Text.Trim.Length = 0 Then
            Me.ErrPrv.SetError(Me.cmbCategoria, "Debe seleccionar el categoría")
            Me.cmbCategoria.Focus()
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        If ValidarEntrada() Then
            CargarEvidencias()
        End If
    End Sub

    Private Sub cmbCategoria_Enter(sender As Object, e As EventArgs) Handles cmbCategoria.Enter
        Try
            If cmbPeriodo.Text = String.Empty Then
                MsgBox("Debe seleccionar el período.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            Else
                CargarCategorias()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        cmbCategoria.SelectedIndex = -1
        ErrPrv.SetError(cmbCategoria, "")
    End Sub

    Private Sub cmbParcial_TextChanged(sender As Object, e As EventArgs) Handles cmbParcial.TextChanged
        ErrPrv.SetError(cmbParcial, "")
    End Sub

    Private Sub cmbCategoria_TextChanged(sender As Object, e As EventArgs) Handles cmbCategoria.TextChanged
        ErrPrv.SetError(cmbCategoria, "")
    End Sub

#End Region

#Region "Eventos del Formulario"


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Dim Rows As New ArrayList()
            Dim filas As DataRow
            Dim I As Integer

            For I = 0 To grdvwGrados.SelectedRowsCount() - 1
                If (grdvwGrados.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdvwGrados.GetDataRow(grdvwGrados.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturas As DataRow = CType(Rows(I), DataRow)
                filas = dtEvidenciaselect.NewRow
                filas("SraEvidenciasDetalleID") = CInt(drFilaAsignaturas("SraEvidenciasDetalleID"))
                filas("Nombre") = drFilaAsignaturas("Nombre").ToString

                dtEvidenciaselect.Rows.Add(filas)
            Next


            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CargarPeriodos()
            CargarParcial()
        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            Me.Cursor = [Default]
        End Try
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub
#End Region

    Private Sub chkSeleccionado_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionado.CheckedChanged
        Try
            Dim blnSeleccionar As Boolean
            Dim Filas() As DataRow = Nothing

            blnSeleccionar = CType(sender, DevExpress.XtraEditors.CheckEdit).Checked
            If blnSeleccionar Then
                Filas = dtEvidenciaselect.Select("Seleccionar=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccionar") = 0
                    dtEvidenciaselect.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class