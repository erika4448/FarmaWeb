' NOTE: You can use the "Rename" command on the context menu to change the class name "srvFarmaWeb" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select srvFarmaWeb.svc or srvFarmaWeb.svc.vb at the Solution Explorer and start debugging.
Public Class srvFarmaWeb
    Implements IsrvFarmaWeb
    ''' <summary>
    ''' METODO PARA CARGAR TIPO_INFORMACION DEL SISTEMA POR ID ESTADO
    ''' </summary>
    ''' <param name="parIdEstado"> ESTADO DEL REGISTRO</param>
    ''' <remarks></remarks>
    Public Function GetTblTipoInfoXIdEstado(ByVal parIdEstado As Integer) As Data.DataTable Implements IsrvFarmaWeb.GetTblTipoInfoXIdEstado
        Dim objTipoInfo As New dllFarmaWeb.Medicamentos.clMedTipoInfo

        Return objTipoInfo.GetTblTipoInfoXIdEstado(parIdEstado)
    End Function
    ''' <summary>
    ''' METODO PARA GUARDAR INFORMACION PARAMETRICA DE MODULO MEDICAMENTOS
    ''' </summary>
    ''' <remarks></remarks>
    Public Function GuardarInfoParamMedica(ByVal parObjInfoParamMedica As dllFarmaWeb.Medicamentos.clMedInfoParamMedica) As Message.clObjMsjRS Implements IsrvFarmaWeb.GuardarInfoParamMedica
        Dim objMsgRS As New Message.clObjMsjRS
        Dim objTrans As New dllFarmaWeb.Comun.clObjTrans
        Try
            objTrans.transCreaTrans()
            parObjInfoParamMedica.GuardarInfoParamMedica(objTrans.transTransaction)
            objMsgRS.pIdRel = parObjInfoParamMedica.mipmIdInfoPMed
            objTrans.transAceptaTrans()
        Catch ex As Exception
            objTrans.transErrorTrans()
            objMsgRS.pStrMessage = "Error al intentar guardar información paramétrica " & ex.Message
        End Try

        Return objMsgRS
    End Function
    ''' <summary>
    ''' METODO PARA CARGAR INFORMACION PARAMETRICA POR ID
    ''' </summary>
    ''' <param name="parIdInfoPMed">ID REGISTRO PARA REALIZAR LA BUSQUEDA</param>
    ''' <returns>OBJETO DE INFO_PARAMETRICA</returns>
    ''' <remarks></remarks>
    Public Function CargarInfoParamMedicaXId(ByVal parIdInfoPMed As Integer) As dllFarmaWeb.Medicamentos.clMedInfoParamMedica Implements IsrvFarmaWeb.CargarInfoParamMedicaXId
        Dim objInfoParamMed As New dllFarmaWeb.Medicamentos.clMedInfoParamMedica
        objInfoParamMed.CargarInfoParamMedXId(parIdInfoPMed)
        Return objInfoParamMed
    End Function
    ''' <summary>
    ''' METODO PARA CARGAR LOS ESTADOS EXISTENTES EN EL SISTEMA
    ''' </summary>
    ''' <returns>TABLA DE ESTADOS DEL SISTEMA</returns>
    ''' <remarks></remarks>
    Public Function GetTblEstado() As Data.DataTable Implements IsrvFarmaWeb.GetTblEstado
        Dim objEstado As New dllFarmaWeb.Sistema.clSisEstado

        Return objEstado.GetTblEstado()
    End Function
    ''' <summary>
    ''' METODO PARA CAGAR INFORMACION PARAMETRICA PO ID_TIPO_INFO
    ''' </summary>
    ''' <param name="parIdTipoInfo">IDENTIFICADOR DEL TIPO DE INFORMACION A BUSCAR</param>
    ''' <returns>TABLA CON INFORMACION PARAMETRICA DE MEDICAMENTOS</returns>
    ''' <remarks></remarks>
    Public Function GetTblInfoParamMedXIdTipoInfo(ByVal parIdTipoInfo As Integer, ByVal parIdEstado As Integer) As Data.DataTable Implements IsrvFarmaWeb.GetTblInfoParamMedXIdTipoInfo
        Dim objInfoParamMed As New dllFarmaWeb.Medicamentos.clMedInfoParamMedica
        Return objInfoParamMed.GetTblInfoParamMedXIdTipoInfo(parIdTipoInfo, parIdEstado)
    End Function
    Public Function GuardarInfoMedicamentoXId(ByVal parObjMedicamento As dllFarmaWeb.Medicamentos.clMedMedicamento) As Message.clObjMsjRS Implements IsrvFarmaWeb.GuardarInfoMedicamentoXId
        Dim objMsgRS As New Message.clObjMsjRS
        Dim objTrans As New dllFarmaWeb.Comun.clObjTrans
        Try
            objTrans.transCreaTrans()
            parObjMedicamento.GuardarInfoMedicamentoXIdMed(objTrans.transTransaction)
            objMsgRS.pIdRel = parObjMedicamento.mmedIdMedicamento
            objTrans.transAceptaTrans()
        Catch ex As Exception
            objTrans.transErrorTrans()
            objMsgRS.pStrMessage = "Error al intentar guardar información medicamento " & ex.Message
        End Try

        Return objMsgRS
    End Function
    ''' <summary>
    ''' METODO PARA CARGAR TABLA DE MEDICAMENTOS POR NOMBRE DE MEDICAMENTO DE CONSULTA
    ''' </summary>
    ''' <param name="parStrNombre">NOMBRE DEL MEDICAMENTO</param>
    ''' <param name="parIdUsuario">USUARIO DROGUERIA QUE REALIZA LA CONSULTA</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetTblMedicamentoXStrNom(ByVal parStrNombre As String, ByVal parIdUsuario As Integer) As Data.DataTable Implements IsrvFarmaWeb.GetTblMedicamentoXStrNom
        Dim objMedicamentos As New dllFarmaWeb.Medicamentos.clMedMedicamento

        Return objMedicamentos.GetTblMedicamentoXStrNom(parStrNombre, parIdUsuario)
    End Function
    ''' <summary>
    ''' METODO PARA CARGAR INFORMACION DE MEDICAMENTO POR ID_MEDICAMENTO
    ''' </summary>
    ''' <param name="parIdMedicamento">IDENTIFICADOR DEL MEDICAMENTO</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CargarInfoMedciamentoXIdMed(ByVal parIdMedicamento As Integer) As dllFarmaWeb.Medicamentos.clMedMedicamento Implements IsrvFarmaWeb.CargarInfoMedciamentoXIdMed
        Dim objMedicamento As New dllFarmaWeb.Medicamentos.clMedMedicamento

        objMedicamento.CargarInfoMedciamentoXIdMed(parIdMedicamento)

        Return objMedicamento
    End Function
    ''' <summary>
    ''' METODO PARA GUARDAR INFORMACION DE PRESENTACION MEDICAMENTO
    ''' </summary>
    ''' <param name="parObjPresentacionMed">OBJETO PRESENTACION MEDICAMENTO A GUARDAR</param>
    ''' <remarks></remarks>
    Public Function GuardarInfoPresentacionMed(ByVal parObjPresentacionMed As dllFarmaWeb.Medicamentos.clMedPresentacionMed) As Message.clObjMsjRS Implements IsrvFarmaWeb.GuardarInfoPresentacionMed
        Dim objMsgRS As New Message.clObjMsjRS
        Dim objTrans As New dllFarmaWeb.Comun.clObjTrans
        Try
            objTrans.transCreaTrans()
            parObjPresentacionMed.GuardarInfoPresentacionMed(objTrans.transTransaction)
            objMsgRS.pIdRel = parObjPresentacionMed.mprmIdPresenMed
            objTrans.transAceptaTrans()
        Catch ex As Exception
            objTrans.transErrorTrans()
            objMsgRS.pStrMessage = "Error al intentar guardar información presentación medicamento " & ex.Message
        End Try

        Return objMsgRS
    End Function
    ''' <summary>
    ''' METODO PARA CARGAR INFORMACION DE PRESENTACION MEDICAMENTO POR ID
    ''' </summary>
    ''' <param name="parIdPresenMed">IDENTIFICADOR DEL OBJETO</param>
    ''' <remarks></remarks>
    Public Function CargarInfoPresentacionMedXIdPMed(ByVal parIdPresenMed As Integer) As dllFarmaWeb.Medicamentos.clMedPresentacionMed Implements IsrvFarmaWeb.CargarInfoPresentacionMedXIdPMed
        Dim objPresentacionMed As New dllFarmaWeb.Medicamentos.clMedPresentacionMed

        objPresentacionMed.CargarInfoPresentacionMedXIdPMed(parIdPresenMed)

        Return objPresentacionMed
    End Function
    ''' <summary>
    ''' METODOD PARA CARGAR PRESENTACIONES DE MEDICAMENTO POR ID_MEDICAMENTO
    ''' </summary>
    ''' <param name="parIdMedicamento">IDENTIFICADOR DEL MEDICAMENTO</param>
    ''' <returns>TABLA CON OBJETOS DE PRESENTACION MEDICAMENTO</returns>
    ''' <remarks></remarks>
    Public Function GetTblPresentacionMedXIdMed(ByVal parIdMedicamento As Integer) As Data.DataTable Implements IsrvFarmaWeb.GetTblPresentacionMedXIdMed
        Dim objPresentacionMed As New dllFarmaWeb.Medicamentos.clMedPresentacionMed

        Return objPresentacionMed.GetTblPresentacionMedXIdMed(parIdMedicamento)
    End Function
End Class
