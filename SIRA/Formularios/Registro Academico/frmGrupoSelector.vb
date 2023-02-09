Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmGrupoSelector

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion, intPeriodo, intProfesor, intGrupoID As Integer
    Public DtPersonas As DataTable
    Public Shared dtAlumnosSeleccioandos As DataTable
    Dim intModalidad As Integer
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

    Public Property Periodo() As Integer
        Get
            Return intPeriodo
        End Get
        Set(ByVal value As Integer)
            intPeriodo = value
        End Set
    End Property


    Public Property Profesor() As Integer
        Get
            Return intProfesor
        End Get
        Set(ByVal value As Integer)
            intProfesor = value
        End Set
    End Property

    Public Property GrupoID() As Integer
        Get
            Return intGrupoID
        End Get
        Set(ByVal value As Integer)
            intGrupoID = value
        End Set
    End Property

    Property ModaidadID() As String
        Get
            Return intModalidad
        End Get
        Set(ByVal value As String)
            intModalidad = value
        End Set

    End Property
#End Region

#Region "Procedimientos"

    '' Descripción:        Procedimiento encargado de cargar la informacion de personas 
    ''                     de una determinada clasificacion
    Public Sub CargarDatos()
        Dim isSecretaria As Boolean

        Try
            Dim strSQL As String = "1=1"
            isSecretaria = False

            ''Si su rol es secretaria ver todos los grupos

            If Opcion = 2 Then
                If intProfesor <> 0 Then
                    If ModaidadID <> 0 Then
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesorEvaluacion", "Activo= 1 AND PeriodoID=" & intPeriodo & " and objProfesorID=" & intProfesor & " AND objModalidadIDGrupo=" & ModaidadID)

                    Else
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesorEvaluacion", "Activo= 1 AND PeriodoID=" & intPeriodo & " and objProfesorID=" & intProfesor)

                    End If
                Else
                    If ModaidadID <> 0 Then
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesorEvaluacion", "Activo= 1 AND PeriodoID=" + Periodo.ToString & " AND objModalidadIDGrupo=" & ModaidadID)

                    Else
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesorEvaluacion", "Activo= 1 AND PeriodoID=" + Periodo.ToString)

                    End If
                End If
            Else
                If Opcion = 3 Then
                    If intProfesor <> 0 Then
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesor", "Activo= 1 AND PeriodoID=" & intPeriodo & " and objProfesorID=" & intProfesor & " AND objModalidadIDGrupo=" & ModaidadID)
                    Else
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesor", "Activo= 1 AND PeriodoID=" + Periodo.ToString & " AND objModalidadIDGrupo=" & ModaidadID)
                    End If
                Else
                    If intProfesor <> 0 Then
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesor", "Activo= 1 AND PeriodoID=" & intPeriodo & " and objProfesorID=" & intProfesor)
                    Else
                        strSQL = ObtenerConsultaGeneral(" distinct Cast(0 AS BIT) AS Seleccionar, SraGrupoID, GradoID, Grado, Periodo, Seccion, Guia", "vwSraGruposProfesor", "Activo= 1 AND PeriodoID=" + Periodo.ToString)
                    End If
                End If
            End If


            DtPersonas = DAL.SqlHelper.ExecuteQueryDT(strSQL)
            Me.grdGrupos.DataSource = DtPersonas
            Me.grdGrupos.Text = "Grupos (" & DtPersonas.Rows.Count & ")"
            Me.grdGrupos.Refresh()

            'If Opcion = 1 Then
            '    cmdNuevaPersona.Visible = False
            'End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub cmdNuevaPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objPers As frmStbPersonasEditar
        objPers = New frmStbPersonasEditar
        objPers.TyGui = 1
        objPers.frmLlamado = Opcion
        If objPers.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.Seleccion = objPers.idpersona
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim objClienteID As New Object
        Dim Cantidad As New Object
        Dim T As New DAL.TransactionManager


        Dim intMaximo As Integer
        Try
            Cantidad = Me.DtPersonas.Compute("Count(Seleccionar)", "Seleccionar=1")
            If Cantidad = 0 Then
                Exit Sub
            End If
            objClienteID = Me.DtPersonas.Select("Seleccionar = 1")(0)("SraGrupoID")

            If Not IsDBNull(objClienteID) Then
                Seleccion = objClienteID
                Dim objSraAlumno_Grupo As New SraAlumno_Grupo
                Dim objSraAlumno_GrupoUPD As New SraAlumno_Grupo
                Dim objNotas As New SraNotas
                Dim objconsolidado As New SraConsolidadoNotas
                Dim dtNotasAsociadas As New DataTable
                Dim dtConsolidado As New DataTable
                T.BeginTran()

                Select Case Opcion
                    Case 0

                        For Each dr As DataRow In dtAlumnosSeleccioandos.Rows
                            intMaximo = 0
                            'Buscamos el codigo maximo
                            intMaximo = CInt(SraAlumno_Grupo.RetrieveDT("objGrupoID=" & objClienteID, , "isnull(max(codigo),0) as Maximo ", T).Rows(0)("Maximo").ToString)

                            ''Inactivar del grupo anterior

                            objSraAlumno_GrupoUPD.RetrieveByFilter("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & " and Activo=1 AND objMatriculaID=" & CInt(dr("SraMatriculaAlumnos").ToString), T)

                            If objSraAlumno_GrupoUPD.SraAlumno_GrupoID <> 0 Then
                                objSraAlumno_GrupoUPD.Activo = False
                                objSraAlumno_GrupoUPD.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objSraAlumno_GrupoUPD.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objSraAlumno_GrupoUPD.Update(T)
                            End If

                            objSraAlumno_Grupo.objGrupoID = objClienteID
                            objSraAlumno_Grupo.Codigo = intMaximo + 1
                            objSraAlumno_Grupo.objAlumnoID = CInt(dr("objAlumnoID").ToString)
                            objSraAlumno_Grupo.objMatriculaID = CInt(dr("SraMatriculaAlumnos").ToString)
                            objSraAlumno_Grupo.objModalidadID = CInt(dr("objModalidadlD").ToString)
                            objSraAlumno_Grupo.Activo = True
                            objSraAlumno_Grupo.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objSraAlumno_Grupo.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objSraAlumno_Grupo.Insert(T)

                            'Cambiar el grupo al que estan asociadas las notas'
                            dtNotasAsociadas = SraNotas.RetrieveDT("objAlumnoID=" & objSraAlumno_Grupo.objAlumnoID & " AND objGrupoID=" & objSraAlumno_GrupoUPD.objGrupoID)

                            For Each drnotas As DataRow In dtNotasAsociadas.Rows
                                objNotas.Retrieve(CInt(drnotas("SraNotasID").ToString), T)
                                objNotas.objGrupoID = objClienteID
                                objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objNotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objNotas.Update(T)
                            Next

                            ''Cambiar el grupo en el consolidado de notas
                            dtConsolidado = SraConsolidadoNotas.RetrieveDT("objAlumnoID=" & objSraAlumno_Grupo.objAlumnoID & " AND objGrupoID=" & objSraAlumno_GrupoUPD.objGrupoID)

                            For Each drconsolidado As DataRow In dtConsolidado.Rows
                                objconsolidado.Retrieve(CInt(drconsolidado("SraConsolidadoNotasID").ToString), T)
                                objconsolidado.objGrupoID = objClienteID
                                objconsolidado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objconsolidado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objconsolidado.Update(T)
                            Next
                           
                        Next
                        T.CommitTran()

                        MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Case 1

                        For Each dr As DataRow In dtAlumnosSeleccioandos.Rows
                            intMaximo = 0

                            ''Inactivar del grupo anterior
                            objSraAlumno_GrupoUPD.RetrieveByFilter("objAlumnoID=" & CInt(dr("objAlumnoID").ToString) & "  and Activo=1 AND objMatriculaID=" & CInt(dr("SraMatriculaAlumnos").ToString), T)

                            If objSraAlumno_GrupoUPD.SraAlumno_GrupoID <> 0 Then
                                objSraAlumno_GrupoUPD.Activo = False
                                objSraAlumno_GrupoUPD.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objSraAlumno_GrupoUPD.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objSraAlumno_GrupoUPD.Update(T)
                            End If
                           

                            'Buscamos el codigo maximo
                            intMaximo = CInt(SraAlumno_Grupo.RetrieveDT("objGrupoID=" & objClienteID, , "isnull(max(codigo),0) as Maximo ", T).Rows(0)("Maximo").ToString)

                            objSraAlumno_Grupo.objGrupoID = objClienteID
                            objSraAlumno_Grupo.Codigo = intMaximo + 1
                            objSraAlumno_Grupo.objAlumnoID = CInt(dr("objAlumnoID").ToString)
                            objSraAlumno_Grupo.objMatriculaID = CInt(dr("SraMatriculaAlumnos").ToString)
                            objSraAlumno_Grupo.objModalidadID = CInt(dr("objModalidadlD").ToString)
                            objSraAlumno_Grupo.Activo = True
                            objSraAlumno_Grupo.UsuarioCreacion = clsProyecto.Conexion.Usuario
                            objSraAlumno_Grupo.FechaCreacion = clsProyecto.Conexion.FechaServidor
                            objSraAlumno_Grupo.Insert(T)


                            'Cambiar el grupo al que estan asociadas las notas'
                            dtNotasAsociadas = SraNotas.RetrieveDT("objAlumnoID=" & objSraAlumno_Grupo.objAlumnoID & " AND objGrupoID=" & objSraAlumno_GrupoUPD.objGrupoID)

                            For Each drnotas As DataRow In dtNotasAsociadas.Rows
                                objNotas.Retrieve(CInt(drnotas("SraNotasID").ToString), T)
                                objNotas.objGrupoID = objClienteID
                                objNotas.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objNotas.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objNotas.Update(T)
                            Next


                            ''Cambiar el grupo en el consolidado de notas
                            dtConsolidado = SraConsolidadoNotas.RetrieveDT("objAlumnoID=" & objSraAlumno_Grupo.objAlumnoID & " AND objGrupoID=" & objSraAlumno_GrupoUPD.objGrupoID)

                            For Each drconsolidado As DataRow In dtConsolidado.Rows
                                objconsolidado.Retrieve(CInt(drconsolidado("SraConsolidadoNotasID").ToString), T)
                                objconsolidado.objGrupoID = objClienteID
                                objconsolidado.UsuarioModificacion = clsProyecto.Conexion.Usuario
                                objconsolidado.FechaModificacion = clsProyecto.Conexion.FechaServidor
                                objconsolidado.Update(T)
                            Next
                        Next
                        T.CommitTran()

                        MsgBox(My.Resources.MsgAgregado, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, clsProyecto.SiglasSistema)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Case 2, 3
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                End Select
                

               
            Else
                'objClienteID = Me.DtPersonas.Select("Seleccionar = 1")(0)("StbPersonaID")
                'If Not IsDBNull(objClienteID) Then
                '    Seleccion = objClienteID
                '    Me.DialogResult = Windows.Forms.DialogResult.OK
                'Else
                '    Me.DialogResult = Windows.Forms.DialogResult.None
                'End If
                Me.DialogResult = Windows.Forms.DialogResult.None
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub frmPersonaSelector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            CargarDatos()
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
                Filas = DtPersonas.Select("Seleccionar=1")
                For index As Integer = 0 To Filas.Length - 1
                    Filas(index)("Seleccionar") = 0
                    DtPersonas.AcceptChanges()
                Next
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub
End Class