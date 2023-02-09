Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmCuentaSelector

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion, intProfesor As Integer
    Public Shared dtCuentasSelect As DataTable
    Public dtCuentas As DataTable
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

    Public Property Opcion() As Integer
        Get
            Return intOpcion
        End Get
        Set(ByVal value As Integer)
            intOpcion = value
        End Set
    End Property

    Public Property idprofesor() As Integer
        Get
            Return intProfesor
        End Get
        Set(ByVal value As Integer)
            intProfesor = value
        End Set
    End Property
#End Region

#Region "Procedimientos"


    Public Sub CargarCuentasContables()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo =1 "
            dtCuentas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Activo", "vwSContCuentasContables", strFiltro))
            dtCuentasSelect = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar, SContCuentasContablesID, IDCuenta, Descripcion, Activo", "vwSContCuentasContables", "1=0"))

            Me.grdCuentas.DataSource = dtCuentas
            Me.grdCuentas.Text = "Cuentas (" & dtCuentas.Rows.Count & ")"
            Me.grdCuentas.Refresh()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            Dim Rows As New ArrayList()
            Dim filas As DataRow
            Dim I As Integer

            Select Case Opcion
                Case 1
                    For I = 0 To grdvwGrados.SelectedRowsCount() - 1
                        If (grdvwGrados.GetSelectedRows()(I) >= 0) Then
                            Rows.Add(grdvwGrados.GetDataRow(grdvwGrados.GetSelectedRows()(I)))
                        End If
                    Next

                    For I = 0 To Rows.Count - 1
                        Dim drFilaAsignaturas As DataRow = CType(Rows(I), DataRow)
                        filas = dtCuentasSelect.NewRow
                        filas("SContCuentasContablesID") = CInt(drFilaAsignaturas("SContCuentasContablesID"))
                        filas("IDCuenta") = drFilaAsignaturas("IDCuenta").ToString
                        filas("Descripcion") = drFilaAsignaturas("Descripcion").ToString
                        dtCuentasSelect.Rows.Add(filas)
                    Next

            End Select


            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CargarCuentasContables()
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
                Filas = dtCuentasSelect.Select("Seleccionar=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccionar") = 0
                    dtCuentasSelect.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class