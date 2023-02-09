Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmAsignaturasSelector

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion, intProfesor As Integer
    Public Shared dtAsignaturasS As DataTable
    Public dtAsignaturas As DataTable
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


    Public Sub CargarAsignaturasExistentes()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activa =1 AND AsignaturaID not in (select [SraAsignatura_ProfesorID] from [dbo].[SraAsignatura_Profesor] where [objProfesorID]= " + idprofesor.ToString + ")"
            dtAsignaturas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar,AsignaturaID, CodigoAsignarura, Nombre", "SraAsignaturas", strFiltro))
            dtAsignaturasS = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(0 as bit) as Seleccionar,AsignaturaID, CodigoAsignarura, Nombre", "SraAsignaturas", "1=0"))

            Me.grdAsignaturas.DataSource = dtAsignaturas
            Me.grdAsignaturas.Text = "Asignaturas (" & dtAsignaturas.Rows.Count & ")"
            Me.grdAsignaturas.Refresh()

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

            For I = 0 To grdvwAsignaturas.SelectedRowsCount() - 1
                If (grdvwAsignaturas.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdvwAsignaturas.GetDataRow(grdvwAsignaturas.GetSelectedRows()(I)))
                End If
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturas As DataRow = CType(Rows(I), DataRow)
                filas = dtAsignaturasS.NewRow
                filas("AsignaturaID") = CInt(drFilaAsignaturas("AsignaturaID"))
                filas("CodigoAsignarura") = drFilaAsignaturas("CodigoAsignarura").ToString
                filas("Nombre") = drFilaAsignaturas("Nombre").ToString
                dtAsignaturasS.Rows.Add(filas)
            Next

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    
    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CargarAsignaturasExistentes()
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
                Filas = dtAsignaturasS.Select("Seleccionar=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccionar") = 0
                    dtAsignaturasS.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class