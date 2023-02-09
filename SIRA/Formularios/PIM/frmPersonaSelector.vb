Imports DAL
Imports Seguridad.Datos
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO

Public Class frmPersonaSelector

#Region "Variables del formulario"
    Public strFiltro, strSeleccion As String
    Public intOpcion, intPeriodo As Integer
    Public DtPersonas As DataTable
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

    Public Property PeriodoID() As Integer
        Get
            Return intPeriodo
        End Get
        Set(ByVal value As Integer)
            intPeriodo = value
        End Set
    End Property
#End Region

#Region "Procedimientos"

    '' Descripci�n:        Procedimiento encargado de cargar la informacion de personas 
    ''                     de una determinada clasificacion
    Public Sub CargarDatos()
        Dim strSQL As String = "1=1"
        If Opcion = 1 Then
            If String.IsNullOrEmpty(Me.Filtro) Then
                strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID", "vwPersonaClasificacion")
            Else
                strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID", "vwPersonaClasificacion", Filtro)
            End If
        Else
            If Opcion = 3 Then
                If String.IsNullOrEmpty(Me.Filtro) Then
                    strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID", "vwPersonaClasificacion")
                Else
                    strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID", "vwPersonaClasificacion", Filtro)
                End If
            Else
                If Opcion = 4 Then
                    If String.IsNullOrEmpty(Me.Filtro) Then
                        strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID,PersonaJuridica ", "vwPersonaClasificacionAlumnos", "len(rtrim(ltrim(NombreCompleto)))>0 AND objPeriodoID=" & PeriodoID)
                    Else
                        strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID,PersonaJuridica ", "vwPersonaClasificacionAlumnos", Filtro)
                    End If
                Else
                    If Opcion = 5 Then
                        If String.IsNullOrEmpty(Me.Filtro) Then
                            strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID,PersonaJuridica ", "vwPersonaClasificacionAlumnos", "len(rtrim(ltrim(NombreCompleto)))>0 ")
                        Else
                            strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar,Cedula,NombreCompleto, StbPersonaID,PersonaJuridica ", "vwPersonaClasificacionAlumnos", Filtro)
                        End If
                    Else
                        If Opcion = 6 Then
                            strSQL = ObtenerConsultaGeneral(" DISTINCT Genero,Codigo, Cast(0 AS BIT) AS Seleccionar, CodigoMED AS Cedula,NombreCompleto, StbPersonaID, 0 as PersonaJuridica ", "vwRptGruposAlumnosEstadoCuenta", Filtro)
                        Else
                            If Opcion = 7 Then
                                strSQL = ObtenerConsultaGeneral(" DISTINCT Genero, Cast(0 AS BIT) AS Seleccionar, Cedula AS Cedula,NombreCompleto, StbPersonaID, 0 as PersonaJuridica ", "vwStbEmpleados", "Activo=1")
                            End If
                        End If

                    End If
                End If
            End If

        End If

        DtPersonas = DAL.SqlHelper.ExecuteQueryDT(strSQL)
        If Opcion = 6 Then
            DtPersonas.DefaultView.Sort = "Genero, Codigo"
        Else
            DtPersonas.DefaultView.Sort = "Genero"
        End If

        Me.grdPersonas.DataSource = DtPersonas

        Me.grdPersonas.Text = "Personas (" & DtPersonas.Rows.Count & ")"
        Me.grdPersonas.Refresh()

        'If Opcion = 1 Then
        '    cmdNuevaPersona.Visible = False
        'End If
    End Sub

#End Region

#Region "Eventos del Formulario"

    Private Sub cmdNuevaPersona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNuevaPersona.Click
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

        Cantidad = Me.DtPersonas.Compute("Count(Seleccionar)", "Seleccionar=1")
        If Cantidad = 0 Then
            Exit Sub
        End If
        objClienteID = Me.DtPersonas.Select("Seleccionar = 1")(0)("StbPersonaID")
        If Not IsDBNull(objClienteID) Then
            Seleccion = objClienteID
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
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