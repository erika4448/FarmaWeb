Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports dllFarmaWeb.Medicamentos

<TestClass()> Public Class utMedMedicamentos

    <TestMethod()> Public Sub GuardarInfoMedicamento()
        Dim mmedIdMedicamento As Integer = 2 'MEDICAMENTO EXISTENTE
        Dim mmedDrogIdUsuario As Integer = 1
        Dim mmedCodigoCUM As String = "45465"
        Dim mmedNombre As String = "Medicamento Prueba"
        Dim mmedLaborIdInfoPMed As Integer = 9
        Dim mipmVidaUtil As Integer = 3
        Dim mipmRegistroSani As String = "dasdsa342qsq"
        Dim mipmFFarmIdInfoPMed As Integer = 11
        Dim mipmTConcIdInfoPMed As Integer = 14
        Dim mipmViaAdIdInfoPMed As Integer = 16
        Dim mipmTMedIdInfoPMed As Integer = 18
        Dim mipmIdEstado As Integer = 1

        Dim expected As Integer = 2

        Dim objMedicamento As New clMedMedicamento

        objMedicamento.GuardarInfoMedicamentoXIdMed()

        Assert.AreEqual(expected, objMedicamento.mmedIdMedicamento, 0.001, "El ID Medicamento no es el esperado")
    End Sub

End Class