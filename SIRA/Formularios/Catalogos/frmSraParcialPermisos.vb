Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports System.IO
Imports Proyecto.Catalogos.Datos


Public Class frmSraParcialPermisos

#Region "Declaración de Variables propias del formulario"
    Public Shared DtParcial, dtRolesAgregados, dtRolesEliminados, dtRoles As DataTable
    Dim intParcialID As Integer

#End Region

#Region "Propiedades"

    Property ParcialID() As Integer
        Get
            Return intParcialID
        End Get
        Set(ByVal value As Integer)
            intParcialID = value
        End Set
    End Property


#End Region

#Region "Procedimientos"
    Private Sub CargarParcial()
        Try
            DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" StbValorCatalogoID,Descripcion", "vwSraParcialActivoEvaluacionAll", " 1=1"))
            DtParcial.DefaultView.Sort = "Descripcion"
            With cmbParcial
                .DataSource = DtParcial
                .DisplayMember = "Descripcion"
                .ValueMember = "StbValorCatalogoID"
                .Splits(0).DisplayColumns("StbValorCatalogoID").Visible = False
                .ColumnHeaders = False
                .ExtendRightColumn = True
            End With
            cmbParcial.SelectedValue = intParcialID
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try


    End Sub

    Public Sub CargarRoles()
        Try
            dtRoles = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral(" SsgRolID, Nombre", "SsgRol", "1=1"))

            cmbRoles.ValueMember = "SsgRolID"
            cmbRoles.DisplayMember = "Nombre"
            cmbRoles.DataSource = dtRoles

            cmbRoles.Splits(0).DisplayColumns("SsgRolID").Visible = False
            cmbRoles.ColumnHeaders = False
            cmbRoles.ExtendRightColumn = True
            cmbRoles.SelectedIndex = -1
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub CargarAsignaciones()
        Try
            Dim strFiltro As String = ""
            strFiltro = "Activo=1"
            dtRolesAgregados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  objParcialID, SsgRolID, Rol", "vwSraPermisosParcial", "objParcialID=" & ParcialID & " and " + strFiltro))
            dtRolesEliminados = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("cast(1 as bit) as Seleccionar,  objParcialID, SsgRolID, Rol", "vwSraPermisosParcial", "objParcialID=" & ParcialID & " and Activo=0"))

            grdRolesAsignados.DataSource = dtRolesAgregados
            grdRolesAsignados.ForceInitialize()

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub Guardar()
        Dim T As New DAL.TransactionManager
        Dim objAsignar As SraParcialReportes

        Try
            T.BeginTran()
            objAsignar = New SraParcialReportes

            ''Eliminar Datos
            SraParcialReportes.DeleteByFilter("objParcialID=" & intParcialID.ToString, T)

            ''Guardar permiso al rolr
            For Each dr As DataRow In dtRolesAgregados.Rows
                objAsignar.objParcialID = intParcialID.ToString
                objAsignar.objRolID = CInt(dr("SsgRolID").ToString)
                objAsignar.Activo = True
                objAsignar.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignar.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignar.Insert(T)
            Next

            For Each dr As DataRow In dtRolesEliminados.Rows
                objAsignar.objParcialID = intParcialID.ToString
                objAsignar.objRolID = CInt(dr("SsgRolID").ToString)
                objAsignar.Activo = False
                objAsignar.UsuarioCreacion = clsProyecto.Conexion.Usuario
                objAsignar.FechaCreacion = clsProyecto.Conexion.FechaServidor
                objAsignar.Insert(T)
            Next


            T.CommitTran()

            MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            clsError.CaptarError(ex)
            T.RollbackTran()
        End Try
    End Sub
#End Region

#Region "Eventos del formulario"

    Private Sub frmSraAsignaturasProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarParcial()
            CargarRoles()
            CargarAsignaciones()
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Function ValidarExisteTabla(intProfesor As Integer, intAsignatura As Integer) As Boolean
        Try

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Function
    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim filas As DataRow
        Dim existe As Boolean
        Try
            ''Buscamos que el rol no este en la lista
            existe = False
            For Each dr As DataRow In dtRolesAgregados.Rows
                If cmbRoles.SelectedValue = CInt(dr("SsgRolID").ToString) Then
                    existe = True
                    Exit For
                End If
            Next

            If existe Then
                MsgBox("El rol seleccionado ya se encuentra en la lista.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
            Else
                filas = dtRolesAgregados.NewRow
                filas("Rol") = cmbRoles.Text
                filas("SsgRolID") = cmbRoles.SelectedValue
                cmbRoles.Text = String.Empty

                dtRolesAgregados.Rows.Add(filas)
                cmbRoles.Text = String.Empty
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Try
            Dim Rows As New ArrayList()
            Dim I As Integer
            For I = 0 To grdRolesAsignadosTable.SelectedRowsCount() - 1
                If (grdRolesAsignadosTable.GetSelectedRows()(I) >= 0) Then
                    Rows.Add(grdRolesAsignadosTable.GetDataRow(grdRolesAsignadosTable.GetSelectedRows()(I)))
                End If
            Next

            Dim filas As DataRow
            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturaEliminadas As DataRow = CType(Rows(I), DataRow)
                filas = dtRolesEliminados.NewRow
                filas("SsgRolID") = drFilaAsignaturaEliminadas("SsgRolID").ToString
                filas("Rol") = drFilaAsignaturaEliminadas("Rol").ToString
                dtRolesEliminados.Rows.Add(filas)
            Next

            For I = 0 To Rows.Count - 1
                Dim drFilaAsignaturasE As DataRow = CType(Rows(I), DataRow)
                dtRolesAgregados.Rows.Remove(drFilaAsignaturasE)
            Next

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub


    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Guardar()

    End Sub


#End Region

End Class