Imports DAL
Imports Proyecto.Configuracion
Imports System.Windows.Forms.Cursors
Imports SIRA.BO.clsConsultas
Imports SIRA.BO
Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports Proyecto.Catalogos.Datos

Public Class frmSraSeleccionarParametros

#Region "Declaracion de Variables"
    Public dtPeriodos, dtModalidad, dtAlumnos, dtGrupos, DtParcial, dtSemestres As DataTable
    Public intTypeGui As Integer
    Public intPeriodoID, intPantalla, GrupoID, idPersona, IdAlumno As Integer
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

    Property Pantalla() As Integer
        Get
            Return intPantalla
        End Get
        Set(ByVal value As Integer)
            intPantalla = value
        End Set
    End Property

    Property PeriodoID() As Integer
        Get
            Return intPeriodoID
        End Get
        Set(ByVal value As Integer)
            intPeriodoID = value
        End Set
    End Property

#End Region

#Region "Configruacion"

    '' Descripción:        Procedimiento encargado de configurar la interfaz según el modo en que se encuentre
    Public Sub ConfigurarGUI()
        Try
            CargarPeriodos()
            CargarModalidad()
            rbParcial.Checked = True
            spnDesde.Enabled = False
            spnHasta.Enabled = False
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

#End Region

#Region "Seleccionar Periodo"

    '' Descripción:        Procedimiento encargado de guardar tienda
    Public Sub SeleccionarPeriodo()
        Dim T As New DAL.TransactionManager
        Try
            intPeriodoID = cmbPeriodo.SelectedValue

            Select Case TypeGui
                Case 0
                    If cmbModalidad.Text <> "Educacion Inicial" Then
                        Pantalla = 0
                    Else
                        Pantalla = 1
                    End If

            End Select
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            T.RollbackTran()
            clsError.CaptarError(ex)
        End Try
    End Sub


#End Region

#Region "Cargar combos"

    Private Sub CargarParcial()
        DtParcial = DAL.SqlHelper.ExecuteQueryDT(ObtenerProcedimientoGeneral(" EXEC sp_SraCargarParcial '" & clsProyecto.Conexion.Usuario & "'"))
        DtParcial.DefaultView.Sort = "Descripcion"
        With cmbBusqueda
            .Properties.DataSource = DtParcial
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
            .ItemIndex = 0
        End With
    End Sub

    Private Sub CargarSemestres()
        dtSemestres = ClsCatalogos.GetValoresCatalogo("SEMESTRES", "StbValorCatalogoID,Descripcion", "")
        dtSemestres.DefaultView.Sort = "Descripcion"
        With cmbBusqueda
            .Properties.DataSource = dtSemestres
            .Properties.DisplayMember = "Descripcion"
            .Properties.ValueMember = "StbValorCatalogoID"
            .Properties.PopulateColumns()
            .Properties.Columns("StbValorCatalogoID").Visible = False
            .Properties.AutoHeight = True
            .Properties.ShowHeader = False
            .ItemIndex = 0
        End With
    End Sub

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

    '' Descripción:        Procedimiento encargado de cargar los valores de Profesores
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

#End Region




    Public Sub CargarAlumnos()
        Try
            Dim strFiltro As String = ""
            strFiltro = "PeriodoID= " & cmbPeriodo.SelectedValue & " AND StbPersonaID = '" & idPersona.ToString & "'"
            dtAlumnos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("AlumnoID, NombreCompleto, StbPersonaID, Grupo, PeriodoID, Guia", "vwSraAlumnosCalificaciones", strFiltro))
            Me.spnDesde.Enabled = False
            Me.spnHasta.Enabled = False
            Me.spnDesde.Value = 1
            Me.spnHasta.Value = 10
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    '' Descripción:        Función encargada de validar la entrada del usuario
    Public Function ValidarEntrada() As Boolean

        Try
            If cmbPeriodo.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbPeriodo, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


            If cmbModalidad.Text.Trim.Length = 0 Then
                ErrorProv.SetError(cmbModalidad, My.Resources.MsgObligatorio)
                Return False
                Exit Function
            End If


        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
        Return True
    End Function

    Private Sub ReportePrimaria1()
        Dim ds As New DataSet
        Dim objBusqueda As New StbValorCatalogo
        Try
            Dim objjReporte As New rptEvaluacionPrimaria1()
            If chkTodosGrupos.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", " PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
            Else
                If txtAlumno.Text.Trim <> String.Empty Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", "AlumnoID=" & IdAlumno & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                Else
                    If GrupoID <> 0 Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", " SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                        ''    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, (select top 1 Foto from SraMatricula_Alumnos ma where ma.objAlumnoID=AlumnoID and objPeriodoID= " & cmbPeriodo.SelectedValue & " ) as Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Parcial_I, Parcial_I_C, Nota2, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3, Parcial_III, Parcial_III_C, Nota4, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo", "vwRptSraCalificaciones", " Codigo >= " & spnDesde.Value & " and Codigo <= " & spnHasta.Value & " and SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))

                    Else
                        MsgBox("Indique un criterio para el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If

                End If
            End If
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName

                    If rbParcial.Checked Then
                        objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                        Select Case objBusqueda.Codigo

                            Case "000001"
                                objjReporte.Nota2.Visible = False
                                ''objjReporte.NotaS1.Visible = False
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIIC.Visible = False
                                ''objjReporte.xraPromedioIS.Visible = False
                                ''objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False

                                objjReporte.xrNotaFinal.Visible = False
                            Case "000002"
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                ''  objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                ''objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                objjReporte.xrNotaFinal.Visible = False

                            Case "000003"
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xrNotaFinal.Visible = False

                            Case "000004"
                                objjReporte.NF.Visible = False
                        End Select

                    Else
                        If rbSemestre.Checked Then
                            objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                            Select Case objBusqueda.Codigo
                                Case "01"
                                    objjReporte.Nota3.Visible = False
                                    objjReporte.Nota4.Visible = False
                                    ''objjReporte.NotaS2.Visible = False
                                    objjReporte.xraPromedioIIIC.Visible = False
                                    objjReporte.xraPromedioIVC.Visible = False
                                    objjReporte.NF.Visible = False
                                    '' objjReporte.xraPromedioIIS.Visible = False
                                    objjReporte.xrNotaFinal.Visible = False
                                Case "02"
                                    objjReporte.NF.Visible = False
                            End Select
                        End If
                    End If
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub ReportePrimaria2()
        Dim ds As New DataSet
        Dim objBusqueda As New StbValorCatalogo
        Try
            Dim objjReporte As New rptEvaluacionPrimaria2()
            If chkTodosGrupos.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", " PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
            Else
                If txtAlumno.Text.Trim <> String.Empty Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", "AlumnoID=" & IdAlumno & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                Else
                    If GrupoID <> 0 Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral("DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Codigo, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2, Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, NS1SC, Nota3, Nota3SC, Parcial_III, Parcial_III_C, Nota4, Nota4SC, Parcial_IV, Semestre_II, NS2, NS2SC, NF, NFSC, Nota_Final, ordenboletin, isCualitativa", "vwRptSraCalificaciones", " SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                    Else
                        MsgBox("Indique un criterio para el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If

                End If
            End If
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    ''objjReporte.DataSource.ConnectionOptions.DbCommandTimeout = 0
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName

                    If rbParcial.Checked Then
                        objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                        Select Case objBusqueda.Codigo

                            Case "000001"
                                objjReporte.Nota2.Visible = False
                                '' objjReporte.NotaS1.Visible = False
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIIC.Visible = False
                                ''objjReporte.xraPromedioIS.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False

                                objjReporte.xrNotaFinal.Visible = False

                            Case "000002"
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                objjReporte.xrNotaFinal.Visible = False
                            Case "000003"
                                objjReporte.Nota4.Visible = False
                                ''objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xrNotaFinal.Visible = False
                            Case "000004"
                                objjReporte.NF.Visible = False
                        End Select

                    Else
                        If rbSemestre.Checked Then
                            objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                            Select Case objBusqueda.Codigo
                                Case "01"
                                    objjReporte.Nota3.Visible = False
                                    objjReporte.Nota4.Visible = False
                                    ''  objjReporte.NotaS2.Visible = False
                                    objjReporte.xraPromedioIIIC.Visible = False
                                    objjReporte.xraPromedioIVC.Visible = False
                                    objjReporte.NF.Visible = False
                                    '' objjReporte.xraPromedioIIS.Visible = False
                                    objjReporte.xrNotaFinal.Visible = False
                                Case "02"
                                    objjReporte.NF.Visible = False
                            End Select
                        End If
                    End If
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ReporteEducacionInicial()
        Dim ds As New DataSet
        Dim objBusqueda As New StbValorCatalogo
        Try
            Dim objjReporte As New rptEvaluacionInicial()

            If chkTodosGrupos.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, NombreCompleto, CodigoMED,  SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, objEvidenciasID, NombreEvidencia, SraEvidenciasDetalleID, EvidenciaDetalle, Nota,NotaBoletin, Guia,OrdenEvidencia ", "vwRptSraCalificacionesEI", " objParcialID= " & cmbBusqueda.EditValue & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " order by AlumnoID, OrdenEvidencia, SraEvidenciasDetalleID"))
            Else
                If txtAlumno.Text.Trim <> String.Empty Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, NombreCompleto, CodigoMED,  SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, objEvidenciasID, NombreEvidencia, SraEvidenciasDetalleID, EvidenciaDetalle, Nota,NotaBoletin, Guia,OrdenEvidencia", "vwRptSraCalificacionesEI", " objParcialID= " & cmbBusqueda.EditValue & " AND  AlumnoID=" & IdAlumno & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " order by AlumnoID, OrdenEvidencia, SraEvidenciasDetalleID"))
                Else
                    If GrupoID <> 0 Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" DISTINCT Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, AlumnoID, NombreCompleto, CodigoMED,  SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, objEvidenciasID, NombreEvidencia, SraEvidenciasDetalleID, EvidenciaDetalle, Nota,NotaBoletin, Guia,OrdenEvidencia", "vwRptSraCalificacionesEI", " objParcialID= " & cmbBusqueda.EditValue & " AND  SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " order by  AlumnoID, OrdenEvidencia, SraEvidenciasDetalleID"))
                    Else
                        MsgBox("Indique un criterio para el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If

                End If
            End If

            If Not rbNotaFinal.Checked Then
                objjReporte.XrTitulo.Text = cmbBusqueda.Text
            Else
                objjReporte.XrTitulo.Text = "NOTA FINAL"
            End If


            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub ReporteSecundaria()
        Dim ds As New DataSet
        Dim objBusqueda As New StbValorCatalogo
        Try
            Dim objjReporte As New rptEvaluacionSecundaria()
            If chkTodosGrupos.Checked Then
                ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, (select top 1 Foto from SraMatricula_Alumnos ma where ma.objAlumnoID=AlumnoID and objPeriodoID= " & cmbPeriodo.SelectedValue & " ) as Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1,Nota1SC, Parcial_I, Parcial_I_C, Nota2,Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3,Nota3SC, Parcial_III, Parcial_III_C, Nota4,Nota4SC, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo, isCualitativa", "vwRptSraCalificacionesSecundaria", " PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
            Else
                If txtAlumno.Text.Trim <> String.Empty Then
                    ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, (select top 1 Foto from SraMatricula_Alumnos ma where ma.objAlumnoID=AlumnoID and objPeriodoID= " & cmbPeriodo.SelectedValue & " ) as Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Nota1SC, Parcial_I, Parcial_I_C, Nota2,Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3, Nota3SC,Parcial_III, Parcial_III_C, Nota4,Nota4SC, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo, isCualitativa", "vwRptSraCalificacionesSecundaria", "AlumnoID=" & IdAlumno & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                Else
                    If GrupoID <> 0 Then
                        ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, (select top 1 Foto from SraMatricula_Alumnos ma where ma.objAlumnoID=AlumnoID and objPeriodoID= " & cmbPeriodo.SelectedValue & " ) as Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1,Nota1SC, Parcial_I, Parcial_I_C, Nota2,Nota2SC, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3,Nota3SC, Parcial_III, Parcial_III_C, Nota4,Nota4SC, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo, isCualitativa", "vwRptSraCalificacionesSecundaria", " SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))

                        'ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, (select top 1 Foto from SraMatricula_Alumnos ma where ma.objAlumnoID=AlumnoID and objPeriodoID= " & cmbPeriodo.SelectedValue & " ) as Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Parcial_I, Parcial_I_C, Nota2, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3, Parcial_III, Parcial_III_C, Nota4, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo", "vwRptSraCalificaciones", " Codigo >= " & spnDesde.Value & " and Codigo <= " & spnHasta.Value & " and SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))
                        ''ds = DAL.SqlHelper.ExecuteQueryDS(ObtenerConsultaGeneral(" Empresa, DireccionEmpresa, TelefonosEmpresa, EmailEmpresa, Fecha, NotaBoletin, AlumnoID, NombreCompleto, CodigoMED, Foto, SraGrupoID, GradoID, Grado, Seccion, Periodo, PeriodoID, AsignaturaID, Asignatura, Nota1, Parcial_I, Parcial_I_C, Nota2, Parcial_II, Parcial_II_C, Semestre_I, NS1, Nota3, Parcial_III, Parcial_III_C, Nota4, Parcial_IV, Semestre_II, NS2, NF, Nota_Final,ordenboletin,Codigo", "vwRtpBoletin", " SraGrupoID=" & GrupoID & " AND PeriodoID=" & cmbPeriodo.SelectedValue & " ORDER BY ordenboletin,Codigo"))

                    Else
                        MsgBox("Indique un criterio para el reporte", MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                    End If

                End If
            End If
            If ds.Tables.Count > 0 Then
                If ds.Tables(0).Rows.Count <> 0 Then
                    objjReporte.DataSource = ds
                    objjReporte.DataMember = ds.Tables(0).TableName

                    If rbParcial.Checked Then
                        objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                        Select Case objBusqueda.Codigo

                            Case "000001"
                                objjReporte.Nota2.Visible = False
                                '' objjReporte.NotaS1.Visible = False
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIIC.Visible = False
                                '' objjReporte.xraPromedioIS.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False

                                objjReporte.xrNotaFinal.Visible = False

                            Case "000002"
                                objjReporte.Nota3.Visible = False
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                '' objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xraPromedioIIIC.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                objjReporte.xrNotaFinal.Visible = False
                            Case "000003"
                                objjReporte.Nota4.Visible = False
                                '' objjReporte.NotaS2.Visible = False
                                objjReporte.NF.Visible = False
                                objjReporte.xraPromedioIVC.Visible = False
                                ''objjReporte.xraPromedioIIS.Visible = False
                                objjReporte.xrNotaFinal.Visible = False
                            Case "000004"
                                objjReporte.NF.Visible = False
                        End Select

                    Else
                        If rbSemestre.Checked Then
                            objBusqueda.RetrieveByFilter("StbValorCatalogoID=" & cmbBusqueda.EditValue)

                            Select Case objBusqueda.Codigo
                                Case "01"
                                    objjReporte.Nota3.Visible = False
                                    objjReporte.Nota4.Visible = False
                                    ''  objjReporte.NotaS2.Visible = False
                                    objjReporte.xraPromedioIIIC.Visible = False
                                    objjReporte.xraPromedioIVC.Visible = False
                                    objjReporte.NF.Visible = False
                                    ''objjReporte.xraPromedioIIS.Visible = False
                                    objjReporte.xrNotaFinal.Visible = False
                                Case "02"
                                    objjReporte.NF.Visible = False
                            End Select
                        End If
                    End If
                    Dim pt As New ReportPrintTool(objjReporte)
                    pt.ShowPreview()
                Else
                    MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
                End If
            Else
                MsgBox(My.Resources.MsgReporte, MsgBoxStyle.Information, clsProyecto.SiglasSistema)
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
    Private Sub GenerarReporte()
        Dim ds As New DataSet
        Dim objBusqueda As New StbValorCatalogo
        Dim objgrupo As New SraGrupo
        Dim objgrados As New SraGrado
        Try
            If cmbModalidad.Text <> "Educacion Inicial" Then
                If cmbModalidad.Text = "PRIMARIA" Then
                    ''Buscar el grado 
                    objgrupo.Retrieve(GrupoID)
                    ''Buscar el grado
                    objgrados.Retrieve(objgrupo.objGradoID)

                    If objgrados.CodigoGrado = "000017" Or objgrados.CodigoGrado = "000019" Then
                        ReportePrimaria1()
                    Else
                        ReportePrimaria2()
                    End If
                Else
                    ReporteSecundaria()
                End If
            Else
                ReporteEducacionInicial()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub
#Region "Eventos del formulario"

    Private Sub frmBodegasEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigurarGUI()

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        If ValidarEntrada() Then
            GenerarReporte()
        End If

    End Sub

    Private Sub BuscarGrupo()
        Dim objPersonas As frmGrupoSelector
        Dim dtGradoE As New DataTable
        Try
            chkTodosGrupos.Checked = False
            objPersonas = New frmGrupoSelector
            objPersonas.Periodo = cmbPeriodo.SelectedValue
            txtAlumno.Text = String.Empty
            IdAlumno = 0

            objPersonas.Opcion = 2
            objPersonas.ModaidadID = cmbModalidad.SelectedValue

            If objPersonas.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                GrupoID = objPersonas.Seleccion

                dtGrupos = DAL.SqlHelper.ExecuteQueryDT(ObtenerConsultaGeneral("SraGrupoID, GradoID, Grado, Periodo, Seccion, Grado + ' - ' + Seccion as Grupo, Guia, EvaluacionCualitativa, EvaluacionCuantitativa", "vwSraGrupos", "SraGrupoID=" + GrupoID.ToString))

                If dtGrupos.Rows.Count > 0 Then
                    Me.txtGrado.Text = dtGrupos.Rows(0)("Grupo")
                    Me.txtGuia.Text = dtGrupos.Rows(0)("Guia")
                    Me.spnDesde.Enabled = True
                    Me.spnHasta.Enabled = True
                Else
                    Me.spnDesde.Enabled = False
                    Me.spnHasta.Enabled = False
                    Me.spnDesde.Value = 1
                    Me.spnHasta.Value = 10
                End If
            End If

        Catch ex As Exception
            clsError.CaptarError(ex)
        Finally
            objPersonas = Nothing

        End Try
    End Sub

#End Region


    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        BuscarGrupo()
    End Sub

    Private Sub chkTodosGrupos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodosGrupos.CheckedChanged
        If chkTodosGrupos.Checked = True Then
            cmdBuscar.Enabled = False
            txtAlumno.Text = String.Empty
            txtGrado.Text = String.Empty
            txtGuia.Text = String.Empty
        Else
            cmdBuscar.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAlumno.Click
        Dim objverificarMatricula As New SraMatricula_Alumnos

        Try
            Dim objSeleccion As frmPersonaSelector
            objSeleccion = New frmPersonaSelector
            objSeleccion.Opcion = 4
            ''objSeleccion.PeriodoID = cmbPeriodo.SelectedValue
            objSeleccion.Filtro = "objPeriodoID = " & cmbPeriodo.SelectedValue & " AND objModalidadlD=" & cmbModalidad.SelectedValue
            If objSeleccion.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Me.idPersona = objSeleccion.Seleccion
                CargarAlumnos()
                Me.IdAlumno = dtAlumnos.Rows(0)("AlumnoID")
                VincularControles()
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Public Sub VincularControles()
        Try
            Me.txtAlumno.DataBindings.Clear()
            Me.txtGrado.DataBindings.Clear()
            Me.txtGuia.DataBindings.Clear()

            Me.idPersona = dtAlumnos.Rows(0)("StbPersonaID")
            Me.IdAlumno = dtAlumnos.Rows(0)("AlumnoID")
            Me.txtAlumno.DataBindings.Add("text", dtAlumnos, "NombreCompleto", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtGrado.DataBindings.Add("text", dtAlumnos, "Grupo", False, DataSourceUpdateMode.OnPropertyChanged)
            Me.txtGuia.DataBindings.Add("text", dtAlumnos, "Guia", False, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try
    End Sub

    Private Sub cmbPeriodo_TextChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.TextChanged
        Me.ErrorProv.SetError(cmbPeriodo, "")
    End Sub

    Private Sub cmbModalidad_TextChanged(sender As Object, e As EventArgs) Handles cmbModalidad.TextChanged
        Try
            Me.ErrorProv.SetError(cmbModalidad, "")
            If cmbModalidad.Text = "Educacion Inicial" Then
                rbNotaFinal.Enabled = False
                rbSemestre.Enabled = False
                rbParcial.Enabled = True
            Else
                rbNotaFinal.Enabled = True
                rbSemestre.Enabled = True
                rbParcial.Enabled = True
            End If
        Catch ex As Exception
            clsError.CaptarError(ex)
        End Try

    End Sub

    Private Sub rbParcial_CheckedChanged(sender As Object, e As EventArgs) Handles rbParcial.CheckedChanged
        If rbNotaFinal.Checked Then
            cmbBusqueda.Text = String.Empty
            cmbBusqueda.Enabled = False
        Else
            If rbSemestre.Checked Then
                cmbBusqueda.Enabled = True
                CargarSemestres()
            Else
                cmbBusqueda.Enabled = True
                CargarParcial()
            End If
        End If
    End Sub

    Private Sub rbSemestre_CheckedChanged(sender As Object, e As EventArgs) Handles rbSemestre.CheckedChanged
        If rbSemestre.Checked Then
            cmbBusqueda.Enabled = True
            CargarSemestres()
        Else
            If rbParcial.Checked Then
                cmbBusqueda.Enabled = True
                CargarParcial()
            Else
                cmbBusqueda.Text = String.Empty
                cmbBusqueda.Enabled = False
            End If
        End If
    End Sub

    Private Sub rbNotaFinal_CheckedChanged(sender As Object, e As EventArgs) Handles rbNotaFinal.CheckedChanged
        If rbNotaFinal.Checked Then
            cmbBusqueda.Text = String.Empty
            cmbBusqueda.Enabled = False
        End If
    End Sub
End Class