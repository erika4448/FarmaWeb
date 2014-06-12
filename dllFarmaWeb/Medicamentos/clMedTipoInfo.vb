Imports System.Data.Common
Namespace Medicamentos
    Public Class clMedTipoInfo
        Inherits Comun.clBase
#Region "VARIABLES"
        Public BmtpiIdTipoInfo As Integer
        Public BmtpiNombre As String
        Public BmtpiIdEstado As Integer
#End Region
        'FUNCION PARA CARGAR INFORMACION DEL LECTOR EN LAS VARIABLES
        Private Sub CargarDrLector(ByVal parDrLector As IDataReader)
            BmtpiIdTipoInfo = IIf(IsDBNull(parDrLector("BmtpiIdTipoInfo")), 0, parDrLector("BmtpiIdTipoInfo"))
            BmtpiNombre = IIf(IsDBNull(parDrLector("BmtpiNombre")), "", parDrLector("BmtpiNombre"))
            BmtpiIdEstado = IIf(IsDBNull(parDrLector("BmtpiIdEstado")), 0, parDrLector("BmtpiIdEstado"))
        End Sub
        'FUNCION PARA CARGAR INFORMACION DE MEDIO_TIPO_INFO POR ID_ESTADO
        Public Function GetTblTipoInfoXIdEstado(ByVal parIdEstado As Integer) As Data.DataTable
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGetTblTipoInfoXIdEstado")

            db.AddInParameter(dbCommand, "parIdEstado", DbType.Int32, parIdEstado)

            Return db.ExecuteDataSet(dbCommand).Tables(0)
        End Function
    End Class
End Namespace
