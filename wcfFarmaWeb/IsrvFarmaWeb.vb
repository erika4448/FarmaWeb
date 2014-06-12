Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IsrvFarmaWeb" in both code and config file together.
<ServiceContract()>
Public Interface IsrvFarmaWeb

    <OperationContract()>
    Function GetTblTipoInfoXIdEstado(ByVal parIdEstado As Integer) As Data.DataTable

    <OperationContract()>
    Function GuardarInfoParamMedica(ByVal parObjInfoParamMedica As dllFarmaWeb.Medicamentos.clMedInfoParamMedica) As Message.clObjMsjRS

    <OperationContract()>
    Function CargarInfoParamMedicaXId(ByVal parIdInfoPMed As Integer) As dllFarmaWeb.Medicamentos.clMedInfoParamMedica

    <OperationContract()>
    Function GetTblEstado() As Data.DataTable
    <OperationContract()>
    Function GetTblInfoParamMedXIdTipoInfo(ByVal parIdTipoInfo As Integer, ByVal parIdEstado As Integer) As Data.DataTable
    <OperationContract()>
    Function GuardarInfoMedicamentoXId(ByVal parObjMedicamento As dllFarmaWeb.Medicamentos.clMedMedicamento) As Message.clObjMsjRS
    <OperationContract()>
    Function GetTblMedicamentoXStrNom(ByVal parStrNombre As String, ByVal parIdUsuario As Integer) As Data.DataTable
    <OperationContract()>
    Function CargarInfoMedciamentoXIdMed(ByVal parIdMedicamento As Integer) As dllFarmaWeb.Medicamentos.clMedMedicamento
    <OperationContract()>
    Function GuardarInfoPresentacionMed(ByVal parObjPresentacionMed As dllFarmaWeb.Medicamentos.clMedPresentacionMed) As Message.clObjMsjRS
    <OperationContract()>
    Function CargarInfoPresentacionMedXIdPMed(ByVal parIdPresenMed As Integer) As dllFarmaWeb.Medicamentos.clMedPresentacionMed
    <OperationContract()>
    Function GetTblPresentacionMedXIdMed(ByVal parIdMedicamento As Integer) As Data.DataTable
End Interface

