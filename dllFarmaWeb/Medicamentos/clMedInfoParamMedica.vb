Imports System.Data.Common
Namespace Medicamentos
    Public Class clMedInfoParamMedica
        Inherits Comun.clBase
#Region "VARIABLES"
        Private _mipmIdInfoPMed As Integer
        Public property mipmIdInfoPMed As Integer
            Get
                Return _mipmIdInfoPMed
            End Get
            Set(value As Integer)
                _mipmIdInfoPMed = value
            End Set
        End Property

        Private _mipmIdTipoInfo As Integer
        Public Property mipmIdTipoInfo As Integer
            Get
                Return _mipmIdTipoInfo
            End Get
            Set(value As Integer)
                _mipmIdTipoInfo = value
            End Set
        End Property

        Private _mipmValor As String
        Public Property mipmValor As String
            Get
                Return _mipmValor
            End Get
            Set(value As String)
                _mipmValor = value
            End Set
        End Property
        Private _mipmIdEstado As Integer
        Public Property mipmIdEstado As Integer
            Get
                Return _mipmIdEstado
            End Get
            Set(value As Integer)
                _mipmIdEstado = value
            End Set
        End Property
#End Region
        ''' <summary>
        ''' METODO PARA CARGAR INFORMACION DEL LECTOR EN LAS VARIABLES DEL OBJETO
        ''' </summary>
        ''' <param name="parDrLector">LECTOR DE BASE DE DATOS QUE CONTIENE INFORMACION DEL OBJETO</param>
        ''' <remarks></remarks>
        Private Sub cargarDrLector(ByVal parDrLector As IDataReader)
            mipmIdInfoPMed = IIf(IsDBNull(parDrLector("mipmIdInfoPMed")), 0, parDrLector("mipmIdInfoPMed"))
            mipmIdTipoInfo = IIf(IsDBNull(parDrLector("mipmIdTipoInfo")), 0, parDrLector("mipmIdTipoInfo"))
            mipmValor = IIf(IsDBNull(parDrLector("mipmValor")), "", parDrLector("mipmValor"))
            mipmIdEstado = IIf(IsDBNull(parDrLector("mipmIdEstado")), 0, parDrLector("mipmIdEstado"))
        End Sub

        ''' <summary>
        ''' METODO PARA GUARDAR INFORMACION PARAMETRICA DE MEDICAMENTOS EN EL SISTEMA
        ''' </summary>
        ''' <param name="parObjTrans">OBJETO PARA CONTROL LA TRANSACCION</param>
        ''' <remarks></remarks>
        Public Sub GuardarInfoParamMedica(Optional ByVal parObjTrans As System.Data.Common.DbTransaction = Nothing)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGuardarInfoParamMedica")

            db.AddParameter(dbCommand, "mipmIdInfoPMed", DbType.Int32, ParameterDirection.InputOutput, Nothing, DataRowVersion.Current, mipmIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmIdTipoInfo", DbType.Int32, mipmIdTipoInfo)
            db.AddInParameter(dbCommand, "mipmValor", DbType.String, mipmValor)
            db.AddInParameter(dbCommand, "mipmIdEstado", DbType.Int32, mipmIdEstado)

            If (parObjTrans Is Nothing) Then
                db.ExecuteNonQuery(dbCommand)
            Else
                db.ExecuteNonQuery(dbCommand, parObjTrans)
            End If

            mipmIdInfoPMed = db.GetParameterValue(dbCommand, "mipmIdInfoPMed")
        End Sub
        ''' <summary>
        ''' METODO PARA CARGAR INFORMACION PARAMETRICA POR ID
        ''' </summary>
        ''' <param name="parIdInfoPMed">IDENTIFICADOR DEL REGISTRO A CARGAR</param>
        ''' <remarks></remarks>
        Public Sub CargarInfoParamMedXId(ByVal parIdInfoPMed As Integer)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedCargarInfoParamMedXIdInfoPMed")

            db.AddInParameter(dbCommand, "parIdInfoPMed", DbType.Int32, parIdInfoPMed)

            Using drLector As IDataReader = db.ExecuteReader(dbCommand)
                While drLector.Read
                    'SE CARGA EL LECTOR
                    Me.cargarDrLector(drLector)
                End While
            End Using
        End Sub
        ''' <summary>
        ''' METODO PARA CAGAR INFORMACION PARAMETRICA PO ID_TIPO_INFO
        ''' </summary>
        ''' <param name="parIdTipoInfo">IDENTIFICADOR DEL TIPO DE INFORMACION A BUSCAR</param>
        ''' <returns>TABLA CON INFORMACION PARAMETRICA DE MEDICAMENTOS</returns>
        ''' <remarks></remarks>
        Public Function GetTblInfoParamMedXIdTipoInfo(ByVal parIdTipoInfo As Integer, ByVal parIdEstado As Integer) As Data.DataTable
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGetTblInfoParamMedXIdTipoInfo")

            db.AddInParameter(dbCommand, "parIdTipoInfo", DbType.Int32, parIdTipoInfo)
            db.AddInParameter(dbCommand, "parIdEstado", DbType.Int32, parIdEstado)

            Return db.ExecuteDataSet(dbCommand).Tables(0)
        End Function
    End Class
End Namespace
