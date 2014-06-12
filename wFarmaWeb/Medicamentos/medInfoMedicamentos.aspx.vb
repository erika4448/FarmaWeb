Public Class medInfoMedicamentos
    Inherits PagMaestra

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.pBoolIniPagina = True
        End If
    End Sub
#Region "PROPIEDADES"
    ''' <summary>
    ''' PROPIEDAD PARA LA INICIALIZACION DE LA PAGINA
    ''' </summary>
    ''' <value>BOOLEANO INDICADO SI SE DEBE O NO INICIALIZAR</value>
    ''' <remarks></remarks>
    Public WriteOnly Property pBoolIniPagina() As Boolean
        Set(value As Boolean)
            If value Then
                Me.pVisualizaXAccion = EnmAccion.Inicio
            End If
        End Set
    End Property
    ''' <summary>
    ''' ENUMERACION PARA EL CONTROL DE ACCIONES QUE SE PUEDEN REALIZAR EN LA PAGINA
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum EnmAccion
        Inicio = 0
        Buscar = 1
        Nuevo = 2
        Editar = 3
    End Enum
    ''' <summary>
    ''' PROPIEDAD PARA EL MANEJO DE LA VISUALIZACION DE LA PAGINA
    ''' </summary>
    ''' <value>VALOR DE TIPO ENUMERACION QUE INDICA QUE VISUALIZACION DEBE CARGARSE DE ACUERDO A LA ACCION REALIZADA POR EL USUAIRO</value>
    ''' <remarks></remarks>
    Public WriteOnly Property pVisualizaXAccion As EnmAccion
        Set(value As EnmAccion)
            Select Case value
                Case EnmAccion.Inicio
                    Me.pnlBuscaMedica.Visible = True
                    Me.pnlGvResultados.Visible = False
                    Me.pnlInfoMedicamentos.Visible = False

                    Me.btnNuevo.Visible = True
                    Me.btnCerrar.Visible = False
                    Me.btnGuardar.Visible = False

                Case EnmAccion.Buscar
                    Me.pnlBuscaMedica.Visible = True
                    Me.pnlGvResultados.Visible = False
                    Me.pnlInfoMedicamentos.Visible = False

                    Me.btnNuevo.Visible = True
                    Me.btnCerrar.Visible = False
                    Me.btnGuardar.Visible = False


                Case EnmAccion.Nuevo
                    Me.pnlBuscaMedica.Visible = True
                    Me.pnlGvResultados.Visible = False
                    Me.pnlInfoMedicamentos.Visible = True

                    Me.btnNuevo.Visible = False
                    Me.btnCerrar.Visible = True
                    Me.btnGuardar.Visible = True

                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.Entidad, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.FormasFarmacéuticas, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.TiposConcentración, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.VíasAdministración, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.TipoMedicamento, EnmEstado.Activo)

                    Me.CargarEstados()

                Case EnmAccion.Editar
                    Me.pnlBuscaMedica.Visible = True
                    Me.pnlGvResultados.Visible = False
                    Me.pnlInfoMedicamentos.Visible = True

                    Me.btnNuevo.Visible = False
                    Me.btnCerrar.Visible = True
                    Me.btnGuardar.Visible = True

                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.Entidad, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.FormasFarmacéuticas, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.TiposConcentración, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.VíasAdministración, EnmEstado.Activo)
                    Me.CargarInfoParamMedicaXIdTipoInfo(EnmTipoInfo.TipoMedicamento, EnmEstado.Activo)

                    Me.CargarEstados()
            End Select
        End Set
    End Property
    Public Enum EnmTipoInfo
        CTR = 1
        FormasFarmacéuticas = 2
        TiposConcentración = 3
        VíasAdministración = 4
        Entidad = 5
        TipoMedicamento = 6
    End Enum
    ''' <summary>
    ''' PROPIEDAD PARA EL ALMACENAMIENTO DEL IDENTIFICADOR DE MEDICAMENTO QUE SE MANIPULA
    ''' </summary>
    ''' <value>ENTERO</value>
    ''' <returns>ENTERO</returns>
    ''' <remarks></remarks>
    Public Property pIdMedicamento As Integer
        Get
            Return ViewState("pIdMedicamento")
        End Get
        Set(value As Integer)
            ViewState("pIdMedicamento") = value
        End Set
    End Property
#End Region
#Region "PROTEGIDO"
    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (Me.permiteGuardarMedicamento()) Then
            'SE GUARDA LA INFORMACION DEL MEDICAMENTO
            Me.GuardarMedicamento()
            If (Me.pIdMedicamento > 0) Then
                Me.MostrarMensaje("Msj", "Se guardó correctamente ID. " & Me.pIdMedicamento)

                Me.pVisualizaXAccion = EnmAccion.Inicio
                'SE LIMPIA EL CONTROL
                Me.Limpiar()
            End If
        End If
    End Sub
    Protected Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.pVisualizaXAccion = EnmAccion.Inicio
        Me.Limpiar()
    End Sub
    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.pVisualizaXAccion = EnmAccion.Nuevo
    End Sub
    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.pVisualizaXAccion = EnmAccion.Buscar
        Me.Buscar()
    End Sub
    Protected Sub gvMedicamentos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvMedicamentos.RowCommand
        Select Case e.CommandName
            Case "cmdEditar"
                Me.pIdMedicamento = Me.gvMedicamentos.DataKeys(e.CommandArgument).Value()

                If (Me.pIdMedicamento <> 0) Then
                    Me.pVisualizaXAccion = EnmAccion.Editar
                    'SE CARGA LA INFORMACION DEL MEDICAMENTO
                    Me.CargarInfoMedicamentoxId(Me.pIdMedicamento)
                End If
        End Select
    End Sub
#End Region
#Region "PRIVADO"
    Private Sub Buscar()
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim dtDatos As New Data.DataTable
        Try
            dtDatos = objSrvFarmaWeb.GetTblMedicamentoXStrNom(Trim(Me.txtMedicaBus.Text).ToUpper, 1)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar buscar medicamento " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try

        'SE CARGA LA GRILLA DE MEDICAMENTOS
        Me.CargarGvMedicamentos(dtDatos)
        'SE LIMPIA EL BUSCADOR
        Me.LimpiarBuscador()
    End Sub
    Private Sub CargarEstados()
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim dtDatos As New Data.DataTable
        Try
            dtDatos = objSrvFarmaWeb.GetTblEstado()
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar estado " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try
        Me.LlenarListaDesplegable(Me.ddlEstado, dtDatos, "sestIdEstado", "sestNombre")
    End Sub
    Private Sub CargarInfoParamMedicaXIdTipoInfo(ByVal parIdTipoInfo As EnmTipoInfo, ByVal parIdEstado As EnmEstado)
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim dtDatos As New Data.DataTable
        Try
            dtDatos = objSrvFarmaWeb.GetTblInfoParamMedXIdTipoInfo(parIdTipoInfo, parIdEstado)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar estado " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try

        If (parIdTipoInfo = EnmTipoInfo.Entidad) Then
            Me.LlenarListaDesplegable(Me.ddlEntidad, dtDatos, "mipmIdInfoPMed", "mipmValor")
        ElseIf (parIdTipoInfo = EnmTipoInfo.FormasFarmacéuticas) Then
            Me.LlenarListaDesplegable(Me.ddlFormaFarma, dtDatos, "mipmIdInfoPMed", "mipmValor")
        ElseIf (parIdTipoInfo = EnmTipoInfo.TiposConcentración) Then
            Me.LlenarListaDesplegable(Me.ddlTipoConcentra, dtDatos, "mipmIdInfoPMed", "mipmValor")
        ElseIf (parIdTipoInfo = EnmTipoInfo.VíasAdministración) Then
            Me.LlenarListaDesplegable(Me.ddlViaAdmin, dtDatos, "mipmIdInfoPMed", "mipmValor")
        ElseIf (parIdTipoInfo = EnmTipoInfo.TipoMedicamento) Then
            Me.LlenarListaDesplegable(Me.ddlTipoMedica, dtDatos, "mipmIdInfoPMed", "mipmValor")
        End If
    End Sub
    Private Function permiteGuardarMedicamento() As Boolean
        Dim strBuilder As New StringBuilder()
        Dim varBoolRtn As Boolean = True

        If (Trim(Me.txtCodCUM.Text).Length = 0) Then
            strBuilder.Append("- Debe ingresar Código CUM \n")
            varBoolRtn = False
        End If
        If (Trim(Me.txtNombre.Text).Length = 0) Then
            strBuilder.Append("- Debe ingresar Nombre \n")
            varBoolRtn = False
        End If
        If (Me.ddlEntidad.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Entidad \n")
            varBoolRtn = False
        End If
        If (Trim(Me.txtVidaUtil.Text).Length = 0) Then
            strBuilder.Append("- Debe ingresar Vida Útil \n")
            varBoolRtn = False
        End If
        If (Trim(Me.txtRegSanita.Text).Length = 0) Then
            strBuilder.Append("- Debe ingresar Registro Sanitario \n")
            varBoolRtn = False
        End If
        If (Me.ddlFormaFarma.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Forma Farmacéutica \n")
            varBoolRtn = False
        End If
        If (Me.ddlTipoConcentra.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Tipo Concentración \n")
            varBoolRtn = False
        End If
        If (Me.ddlViaAdmin.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Vía Administración \n")
            varBoolRtn = False
        End If
        If (Me.ddlTipoMedica.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Tipo Medicamento \n")
            varBoolRtn = False
        End If
        If (Me.ddlEstado.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar Estado \n")
            varBoolRtn = False
        End If
        If Not (varBoolRtn) Then
            Me.MostrarMensaje("MsjValida", "Por favor verifique \n" & strBuilder.ToString)
        End If

        Return varBoolRtn
    End Function
    Private Sub GuardarMedicamento()
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim objMedicamentos As New srvFarmaWeb.clMedMedicamento
        Dim objMsjRS As New srvFarmaWeb.clObjMsjRS

        Try

            objMedicamentos.mmedIdMedicamento = Me.pIdMedicamento
            objMedicamentos.mmedDrogIdUsuario = 1
            objMedicamentos.mmedCodigoCUM = Trim(Me.txtCodCUM.Text).ToUpper()
            objMedicamentos.mmedNombre = Trim(Me.txtNombre.Text).ToUpper()
            objMedicamentos.mmedLaborIdInfoPMed = Me.ddlEntidad.SelectedValue
            objMedicamentos.mipmVidaUtil = Trim(Me.txtVidaUtil.Text)
            objMedicamentos.mipmRegistroSani = Trim(Me.txtRegSanita.Text).ToUpper()
            objMedicamentos.mipmFFarmIdInfoPMed = Me.ddlFormaFarma.SelectedValue
            objMedicamentos.mipmTConcIdInfoPMed = Me.ddlTipoConcentra.SelectedValue
            objMedicamentos.mipmViaAdIdInfoPMed = Me.ddlViaAdmin.SelectedValue
            objMedicamentos.mipmTMedIdInfoPMed = Me.ddlTipoMedica.SelectedValue
            objMedicamentos.mipmIdEstado = Me.ddlEstado.SelectedValue


            objMsjRS = objSrvFarmaWeb.GuardarInfoMedicamentoXId(objMedicamentos)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar estado " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try
        If (objMsjRS.pStrMessage.Length > 0) Then
            Me.MostrarMensaje("MsjError", "Error al intentar guardar información " & objMsjRS.pStrMessage)
        Else
            Me.pIdMedicamento = objMsjRS.pIdRel
        End If
    End Sub
    Private Sub CargarGvMedicamentos(ByVal parDtDatos As Data.DataTable)
        Me.gvMedicamentos.DataSource = parDtDatos
        Me.gvMedicamentos.DataBind()

        If (Me.gvMedicamentos.Rows.Count > 0) Then
            Me.pnlGvResultados.Visible = True
        Else
            Me.pnlGvResultados.Visible = False
            Me.MostrarMensaje("MsjValida", "No se encontraron resultados con los criterios de consulta.")
        End If
    End Sub

    Private Sub CargarInfoMedicamentoxId(ByVal parIdMedicamento As Integer)
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim objMedicamento As New srvFarmaWeb.clMedMedicamento
        Try
            objMedicamento = objSrvFarmaWeb.CargarInfoMedciamentoXIdMed(parIdMedicamento)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar información medicamento " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try

        If (objMedicamento.mmedIdMedicamento <> 0) Then
            Me.txtCodCUM.Text = objMedicamento.mmedCodigoCUM
            Me.txtNombre.Text = objMedicamento.mmedNombre
            Me.ddlEntidad.SelectedValue = objMedicamento.mmedLaborIdInfoPMed
            Me.txtVidaUtil.Text = objMedicamento.mipmVidaUtil
            Me.txtRegSanita.Text = objMedicamento.mipmRegistroSani
            Me.ddlFormaFarma.SelectedValue = objMedicamento.mipmFFarmIdInfoPMed
            Me.ddlTipoConcentra.SelectedValue = objMedicamento.mipmTConcIdInfoPMed
            Me.ddlViaAdmin.SelectedValue = objMedicamento.mipmViaAdIdInfoPMed
            Me.ddlTipoMedica.SelectedValue = objMedicamento.mipmTMedIdInfoPMed
            Me.ddlEstado.SelectedValue = objMedicamento.mipmIdEstado
        End If

    End Sub
#End Region
#Region "PUBLICO"
    Public Sub Limpiar()
        Me.pIdMedicamento = 0

        Me.txtCodCUM.Text = ""
        Me.txtNombre.Text = ""
        Me.txtRegSanita.Text = ""
        Me.txtVidaUtil.Text = ""
    End Sub
    Public Sub LimpiarBuscador()
        Me.txtMedicaBus.Text = ""
    End Sub
#End Region
End Class