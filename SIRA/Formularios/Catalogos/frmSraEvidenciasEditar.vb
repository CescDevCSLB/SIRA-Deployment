Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSraEvidenciasEditar

#Region "Declaración de Variables propias del formulario"
    Public Shared dtDetalleEdidencias, dtDetalleEdidenciasEliminadas As DataTable
    Dim intEvidenciaID, intParcialID As Integer
    Private strNombre As String

#End Region

#Region "Propiedades"
    Property Nombre() As String
        Get
            Return strNombre
        End Get
        Set(ByVal value As String)
            strNombre = value
        End Set
    End Property
    Property EvidenciaID() As Integer
        Get
            Return intEvidenciaID
        End Get
        Set(ByVal value As Integer)
            intEvidenciaID = value
        End Set
    End Property

    Property ParcialID() As Integer
        Get
            Return intParcialID
        End Get
        Set(ByVal value As Integer)
            intParcialID = value
        End Set
    End Property

#End Region

#Region "Busqueda"

    Public Sub CargarDatosEvidencias()
        Dim objEvidencias As SraEvidencias
        Try
            objEvidencias = New SraEvidencias
            objEvidencias.Retrieve(EvidenciaID)

            txtTitulo.Text = objEvidencias.NombreEvidencia
            chkActivo.Checked = objEvidencias.Activa

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objEvidencias = Nothing
        End Try
    End Sub

        Public Sub CargarEvidencias()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtDetalleEdidencias = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  SraEvidenciasDetalleID, objEvidenciasID, Nombre, Activo", "SraEvidenciaDetalle", "objParcialID= " & ParcialID & " and objEvidenciasID=" + EvidenciaID.ToString + " AND " + strFiltro))
            dtDetalleEdidenciasEliminadas = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar, SraEvidenciasDetalleID, objEvidenciasID, Nombre, Activo", "SraEvidenciaDetalle", "objParcialID= " & ParcialID & " and objEvidenciasID=" + EvidenciaID.ToString & " AND Activo=0"))

            grdAsigmacion.DataSource = dtDetalleEdidencias
            grdAsigmacion.ForceInitialize()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

    Public Sub EstablecerPropiedades()
        Try
            txtTitulo.MaxLength = SraEvidencias.GetMaxLength("NombreEvidencia")

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            EstablecerPropiedades()
            Me.Text = "Agregar evidencias"
            CargarEvidencias()
            txtTitulo.Text = Nombre
            Me.chkActivo.Enabled = False
            Me.chkActivo.Checked = True
            cmdAgregar.Enabled = True
            cmdEliminar.Enabled = True
            cmdGuardar.Enabled = True
            txtTitulo.Enabled = False

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim filas As DataRow
     
        Try
            If txtEvidencia.Text.Trim.Length = 0 Then
                ErrPrv.SetError(txtEvidencia, My.Resources.MsgObligatorio)
                Exit Sub
            Else
                filas = dtDetalleEdidencias.NewRow
                filas("SraEvidenciasDetalleID") = 0
                filas("Nombre") = txtEvidencia.Text
                filas("objEvidenciasID") = EvidenciaID
                filas("Activo") = True
                dtDetalleEdidencias.Rows.Add(filas)

                ''Limpiar Controles
                txtEvidencia.Text = String.Empty
                txtEvidencia.Focus()
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer

            For I = 0 To grdAsignacionTable.SelectedRowsCount() - 1
                If (grdAsignacionTable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdAsignacionTable.GetDataRow(grdAsignacionTable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                If (drFilaAsignaturaEliminadas("SraEvidenciasDetalleID").ToString.Trim <> String.Empty) Then
                    filas = dtDetalleEdidenciasEliminadas.NewRow
                    filas("SraEvidenciasDetalleID") = Int(drFilaAsignaturaEliminadas("SraEvidenciasDetalleID"))

                    Dim stri As String = (drFilaAsignaturaEliminadas("SraEvidenciasDetalleID"))
                    filas("Nombre") = drFilaAsignaturaEliminadas("Nombre").ToString
                    filas("objEvidenciasID") = Int(drFilaAsignaturaEliminadas("objEvidenciasID"))
                    filas("Activo") = False
                    dtDetalleEdidenciasEliminadas.Rows.Add(filas)
                End If


            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)

                dtDetalleEdidencias.Rows.Remove(drFilaAsignaturasE)


            Next


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub



    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim T As New DAL.TransactionManager
        Dim objEvidencia As SraEvidenciaDetalle

        Try
            If dtDetalleEdidencias.Rows.Count = 0 Then
                MsgBox("Debe agregar el detalle de la evidencia.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                Exit Sub
            End If

            T.BeginTran()
            objEvidencia = New SraEvidenciaDetalle

            ''Eliminar Datos
            For Each dr As DataRow In dtDetalleEdidenciasEliminadas.Rows

                objEvidencia.Retrieve(CInt(dr("SraEvidenciasDetalleID").ToString), T)
                objEvidencia.Nombre = dr("Nombre").ToString
                objEvidencia.Activo = False
                objEvidencia.UsuarioModificacion = clsProyecto.Conexion.Usuario
                objEvidencia.FechaModificacion = clsProyecto.Conexion.FechaServidor
                objEvidencia.Update(T)
            Next

            For Each dr As DataRow In dtDetalleEdidencias.Rows
                objEvidencia = New SraEvidenciaDetalle

                objEvidencia.Retrieve(dr("SraEvidenciasDetalleID"))

                'objEvidencia.RetrieveByFilter("Nombre='" & dr("Nombre").ToString.Trim & "' AND objEvidenciasID=" & intEvidenciaID.ToString, T)
                If objEvidencia.SraEvidenciasDetalleID = 0 Then
                    objEvidencia.objEvidenciasID = intEvidenciaID.ToString
                    objEvidencia.Nombre = dr("Nombre").ToString
                    objEvidencia.Activo = True
                    objEvidencia.objParcialID = ParcialID
                    objEvidencia.UsuarioCreacion = clsProyecto.Conexion.Usuario
                    objEvidencia.FechaCreacion = clsProyecto.Conexion.FechaServidor
                    objEvidencia.Insert(T)
                Else
                    Dim objSraEvidenciasDetalle As SraEvidenciaDetalle = New SraEvidenciaDetalle
                    objSraEvidenciasDetalle.Retrieve(dr("SraEvidenciasDetalleID"))
                    objEvidencia.Nombre = dr("Nombre").ToString
                    objEvidencia.UsuarioModificacion = clsProyecto.Conexion.Usuario
                    objEvidencia.FechaModificacion = clsProyecto.Conexion.FechaServidor
                    objEvidencia.Update(T)
                End If
            Next


            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Try

            Dim objSeleccion As frmBuscarEvidencias
            objSeleccion = New frmBuscarEvidencias

            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim filas As DataRow
                For Each dr As DataRow In frmBuscarEvidencias.dtEvidenciaselect.Rows

                    filas = dtDetalleEdidencias.NewRow
                    filas("SraEvidenciasDetalleID") = 0
                    filas("Nombre") = (dr("Nombre").ToString)
                    filas("objEvidenciasID") = EvidenciaID
                    filas("Activo") = True
                    dtDetalleEdidencias.Rows.Add(filas)
                Next
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub txtEvidencia_TextChanged(sender As Object, e As EventArgs) Handles txtEvidencia.TextChanged
        ErrPrv.SetError(txtEvidencia, "")
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        ErrPrv.SetError(txtTitulo, "")
    End Sub


End Class