Imports Proyecto.Configuracion
Imports SIRA.BO.clsConsultas
Imports DevExpress.XtraReports.UI

Public Class frmRptGruposAlumnos

    Dim dtGrupos As DataTable
    Dim GrupoID As Integer
    Dim intPeriodoID As Integer

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Try

            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = frmPrincipal.glbPeriodoSeleccionado
            objPersonas.Opcion = 2

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion
                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then
                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    rbTodos.Checked = False
                End If
                'Seguridad()
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

    Public Function ValidarEntrada() As Boolean

        Try
            If rbTodos.Checked = False And txtGrado.Text = String.Empty Then
                ErrorProv.SetError(txtGrado, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbTodos.CheckedChanged
        Try
            If rbTodos.Checked = True Then
                txtGrado.Text = String.Empty
                GrupoID = 0
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim ds As DataSet
        Try

            Dim objjReporte As New rptGruposAlumnos()
            If ValidarEntrada() Then
                If rbTodos.Checked = False Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID,CodigoMED, PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptGruposAlumnos", "SraGrupoID=" & GrupoID & " AND PeriodoID=" & PeriodoID & " ORDER BY Genero, Codigo ASC"))
                Else
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("SraGrupoID, CodigoMED,PeriodoID, GradoID, Grado, Periodo, Seccion, Guia, EvaluacionCualitativa, EvaluacionCuantitativa, Activo, Modalidad, SraAlumno_GrupoID, Codigo, NombreCompleto, Genero, Edad, Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha", "vwRptGruposAlumnos", "PeriodoID=" & PeriodoID & " ORDER BY Genero, Codigo ASC"))
                End If
               
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub
End Class