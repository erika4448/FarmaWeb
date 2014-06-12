Public Class AdminInfoParamMed
    Inherits PagMaestra

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.pBoolIniPagina = True
        End If
    End Sub
#Region "PROPIEDADES"
    Public WriteOnly Property pBoolIniPagina() As Boolean
        Set(value As Boolean)
            If value Then
                Me.pVisualizaXAccion = enmAccion.Inicio
            End If
        End Set
    End Property
    'ENUMERACION PAR EL CONTROL DE ACCIONES QUE SE REALIZAN EN LA PAGINA
    Public Enum enmAccion
        Inicio = 1
        Nuevo = 2
        Cargar = 3
        SelTipoInfo = 4
    End Enum
    'PROPIEDAD PARA EL MANEJO DE VISUALIZACION DE LA PAGINA
    Public WriteOnly Property pVisualizaXAccion() As enmAccion
        Set(value As enmAccion)
            Select Case value
                Case enmAccion.Inicio
                    Me.pnlTIpoInfo.Visible = True
                    Me.pnlTIpoInfo.Enabled = True
                    Me.pnlGvInfoParam.Visible = False
                    Me.pnlInfoParamMed.Visible = False

                    Me.btnNuevo.Visible = False
                    Me.btnGuardar.Visible = False
                    Me.btnCerrar.Visible = False

                    'SE CARGAN LOS TIPOS DE INFORMACION
                    Me.CargarTipoInfo(1)

                Case enmAccion.Nuevo
                    Me.pnlTIpoInfo.Visible = True
                    Me.pnlTIpoInfo.Enabled = False
                    Me.pnlInfoParamMed.Visible = True

                    Me.btnNuevo.Visible = True
                    Me.btnGuardar.Visible = True
                    Me.btnCerrar.Visible = True

                    'SE CARGAN LOS ESTADOS
                    Me.CargarEstados()
                Case enmAccion.SelTipoInfo
                    Me.pnlTIpoInfo.Enabled = True
                    Me.pnlTIpoInfo.Visible = True
                    Me.pnlInfoParamMed.Visible = False

                    Me.btnNuevo.Visible = True
                    Me.btnGuardar.Visible = False
                    Me.btnCerrar.Visible = False

                Case enmAccion.Cargar
                    Me.pnlTIpoInfo.Visible = True
                    Me.pnlTIpoInfo.Enabled = False
                    Me.pnlInfoParamMed.Visible = True

                    Me.btnNuevo.Visible = True
                    Me.btnGuardar.Visible = True
                    Me.btnCerrar.Visible = True

                    'SE CARGAN LOS ESTADOS
                    Me.CargarEstados()
            End Select
        End Set
    End Property
    Public Property pIdInfoPMed As Integer
        Get
            Return ViewState("pIdInfoPMed")
        End Get
        Set(value As Integer)
            ViewState("pIdInfoPMed") = value
        End Set
    End Property
#End Region
#Region "PROTEGIDO"
    Protected Sub gvInfoParam_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvInfoParam.RowCommand
        Select Case e.CommandName
            Case "cmdEditar"
                Me.pIdInfoPMed = Me.gvInfoParam.DataKeys(e.CommandArgument).Value()

                If (Me.pIdInfoPMed > 0) Then
                    Me.pVisualizaXAccion = enmAccion.Cargar

                    'SE CARGA LA INFORMACION PARAMETRICA DEL MEDICAMENTO
                    Me.CargarInfoPMedXId(Me.pIdInfoPMed)
                End If
        End Select
        Me.upnlAdminInfoParam.Update()
    End Sub
    Protected Sub ddlTipoInfo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTipoInfo.SelectedIndexChanged
        If (Me.ddlTipoInfo.SelectedValue <> 0) Then
            Me.pVisualizaXAccion = enmAccion.SelTipoInfo
            'SE CARGA INFORMACION PARAMETRICA
            Me.CargarInfoParam()
        Else
            Me.pVisualizaXAccion = enmAccion.Inicio
        End If
        Me.upnlAdminInfoParam.Update()
    End Sub
    Protected Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.pVisualizaXAccion = enmAccion.Nuevo
        Me.upnlAdminInfoParam.Update()
    End Sub
    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If (Me.PermiteGuardar()) Then
            Me.GuardarInfoParamMed()

            If (Me.pIdInfoPMed > 0) Then
                Me.MostrarMensaje("Msj", "Se guardó correctamente")

                Me.Limpiar()
                Me.pVisualizaXAccion = enmAccion.SelTipoInfo

                Me.CargarInfoParam()
            End If
        End If
        Me.upnlAdminInfoParam.Update()
    End Sub
    Protected Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Limpiar()
        Me.pVisualizaXAccion = enmAccion.SelTipoInfo
        Me.CargarInfoParam()
        Me.upnlAdminInfoParam.Update()
    End Sub
#End Region
#Region "PRIVADO"
    Private Sub CargarTipoInfo(ByVal parIdEstado As Integer)
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim dtDatos As New Data.DataTable
        Try
            dtDatos = objSrvFarmaWeb.GetTblTipoInfoXIdEstado(parIdEstado)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar tipo información " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try
        Me.LlenarListaDesplegable(Me.ddlTipoInfo, dtDatos, "mtpiIdTipoInfo", "mtpiNombre")
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
    Private Function PermiteGuardar() As Boolean
        Dim strBuilder As New StringBuilder()
        Dim varBoolRtn As Boolean = True

        If (Trim(Me.txtNombre.Text).Length = 0) Then
            strBuilder.Append("- Debe ingresar nombre. \n")
            varBoolRtn = False
        End If
        If (Me.ddlEstado.SelectedValue = 0) Then
            strBuilder.Append("- Debe seleccionar estado. \n")
            varBoolRtn = False
        End If

        If Not varBoolRtn Then
            Me.MostrarMensaje("MsjValida", "Por favor verifique \n " & strBuilder.ToString)
        End If
        Return varBoolRtn
    End Function
    Private Sub GuardarInfoParamMed()
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim objInfoPMed As New srvFarmaWeb.clMedInfoParamMedica
        Dim objMsjRS As New srvFarmaWeb.clObjMsjRS

        Try

            objInfoPMed.mipmIdInfoPMed = Me.pIdInfoPMed
            objInfoPMed.mipmIdTipoInfo = Me.ddlTipoInfo.SelectedValue
            objInfoPMed.mipmValor = Trim(Me.txtNombre.Text)
            objInfoPMed.mipmIdEstado = Me.ddlEstado.SelectedValue
            objMsjRS = objSrvFarmaWeb.GuardarInfoParamMedica(objInfoPMed)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar guardar información " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try
        If (objMsjRS.pStrMessage.Length > 0) Then
            Me.MostrarMensaje("MsjError", "Error al intentar guardar información " & objMsjRS.pStrMessage)
        Else
            Me.pIdInfoPMed = objMsjRS.pIdRel
        End If
    End Sub
    Private Sub Limpiar()
        Me.pIdInfoPMed = 0
        Me.txtNombre.Text = ""
    End Sub
    Private Sub CargarInfoPMedXId(ByVal parIdInfoPMed As Integer)
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim objInfoPMed As New srvFarmaWeb.clMedInfoParamMedica

        Try
            objInfoPMed = objSrvFarmaWeb.CargarInfoParamMedicaXId(parIdInfoPMed)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar información " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try

        If (objInfoPMed.mipmIdInfoPMed > 0) Then
            Me.txtNombre.Text = objInfoPMed.mipmValor
            Me.ddlEstado.SelectedValue = objInfoPMed.mipmIdEstado
        End If
    End Sub
#End Region
#Region "PUBLICO"
    Public Function GetInfoParamMed(ByVal parIdTipoInfo As Integer) As Data.DataTable
        Dim objSrvFarmaWeb As New srvFarmaWeb.IsrvFarmaWebClient
        Dim dtDatos As New Data.DataTable
        Try
            dtDatos = objSrvFarmaWeb.GetTblInfoParamMedXIdTipoInfo(parIdTipoInfo, 0)
        Catch ex As Exception
            Me.MostrarMensaje("MsjError", "Error al intentar cargar información paramétrica " & ex.Message)
        Finally
            objSrvFarmaWeb.Close()
        End Try
        Return dtDatos
    End Function
#End Region
#Region "DATASOURCE INFO_PARAM_MED"
    Public Sub CargarInfoParam()
        Me.gvInfoParam.DataBind()

        If Me.gvInfoParam.Rows.Count > 0 Then
            Me.pnlGvInfoParam.Visible = True
        Else
            Me.pnlGvInfoParam.Visible = False
        End If
    End Sub
    Protected Sub odsInfoParam_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsInfoParam.Selecting
        e.InputParameters("parIdTipoInfo") = Me.ddlTipoInfo.SelectedValue
    End Sub
    Protected Sub odsInfoParams_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles odsInfoParam.Selected
        Me.gvInfoParam.Visible = True
    End Sub
    Protected Sub odsInfoParam_ObjectCreating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceEventArgs) Handles odsInfoParam.ObjectCreating
        e.ObjectInstance = New AdminInfoParamMed
    End Sub
#End Region
End Class