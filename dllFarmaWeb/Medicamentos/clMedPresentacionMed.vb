Imports System.Data.Common

Namespace Medicamentos
    Public Class clMedPresentacionMed
        Inherits Comun.clBase
#Region "VARIABLES"
        Private _mprmIdPresenMed As Integer
        Public Property mprmIdPresenMed As Integer
            Get
                Return _mprmIdPresenMed
            End Get
            Set(value As Integer)
                _mprmIdPresenMed = value
            End Set
        End Property

        Private _munmIdMedicamento As Integer
        Public Property munmIdMedicamento As Integer
            Get
                Return _munmIdMedicamento
            End Get
            Set(value As Integer)
                _munmIdMedicamento = value
            End Set
        End Property
        Private _mprmCodigo As String
        Public Property mprmCodigo As String
            Get
                Return _mprmCodigo
            End Get
            Set(value As String)
                _mprmCodigo = value
            End Set
        End Property

        Private _mprmNombre As String
        Public Property mprmNombre As String
            Get
                Return _mprmNombre
            End Get
            Set(value As String)
                _mprmNombre = value
            End Set
        End Property
        Private _mprmIdUnidadMed As Integer
        Public Property mprmIdUnidadMed As Integer
            Get
                Return _mprmIdUnidadMed
            End Get
            Set(value As Integer)
                _mprmIdUnidadMed = value
            End Set
        End Property
        Private _munmCantidad As Integer
        Public Property munmCantidad As Integer
            Get
                Return _munmCantidad
            End Get
            Set(value As Integer)
                _munmCantidad = value
            End Set
        End Property
        Private _munmIdEstado As Integer
        Public Property munmIdEstado As Integer
            Get
                Return _munmIdEstado
            End Get
            Set(value As Integer)
                _munmIdEstado = value
            End Set
        End Property
#End Region
        ''' <summary>
        ''' METODO PARA CARGAR INFORMACION DEL LECTOR EN LAS VARIABLES DEL OBJETO
        ''' </summary>
        ''' <param name="parDrLector">OBJETO LECTOR</param>
        ''' <remarks></remarks>
        Private Sub CargarDrLector(ByVal parDrLector As IDataReader)
            mprmIdPresenMed = IIf(IsDBNull(parDrLector("mprmIdPresenMed")), 0, parDrLector("mprmIdPresenMed"))
            munmIdMedicamento = IIf(IsDBNull(parDrLector("munmIdMedicamento")), 0, parDrLector("munmIdMedicamento"))
            mprmCodigo = IIf(IsDBNull(parDrLector("mprmCodigo")), "", parDrLector("mprmCodigo"))
            mprmNombre = IIf(IsDBNull(parDrLector("mprmNombre")), "", parDrLector("mprmNombre"))
            mprmIdUnidadMed = IIf(IsDBNull(parDrLector("mprmIdUnidadMed")), 0, parDrLector("mprmIdUnidadMed"))
            munmCantidad = IIf(IsDBNull(parDrLector("munmCantidad")), 0, parDrLector("munmCantidad"))
            munmIdEstado = IIf(IsDBNull(parDrLector("munmIdEstado")), 0, parDrLector("munmIdEstado"))
        End Sub
        ''' <summary>
        ''' METODO PARA GUARDAR INFORMACION DE PRESENTACION MEDICAMENTO
        ''' </summary>
        ''' <param name="parObjTrans">OBJETO DE CONTROL DE TRANSACCION</param>
        ''' <remarks></remarks>
        Public Sub GuardarInfoPresentacionMed(Optional ByVal parObjTrans As System.Data.Common.DbTransaction = Nothing)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGuardarInfoPresentacionMed")

            db.AddParameter(dbCommand, "mprmIdPresenMed", DbType.Int32, ParameterDirection.InputOutput, Nothing, DataRowVersion.Current, mprmIdPresenMed)
            db.AddInParameter(dbCommand, "munmIdMedicamento", DbType.Int32, munmIdMedicamento)
            db.AddInParameter(dbCommand, "mprmCodigo", DbType.String, mprmCodigo)
            db.AddInParameter(dbCommand, "mprmNombre", DbType.String, mprmNombre)
            db.AddInParameter(dbCommand, "mprmIdUnidadMed", DbType.Int32, mprmIdUnidadMed)
            db.AddInParameter(dbCommand, "munmCantidad", DbType.Int32, munmCantidad)
            db.AddInParameter(dbCommand, "munmIdEstado", DbType.Int32, munmIdEstado)

            If (parObjTrans Is Nothing) Then
                db.ExecuteNonQuery(dbCommand)
            Else
                db.ExecuteNonQuery(dbCommand, parObjTrans)
            End If
            mprmIdPresenMed = db.GetParameterValue(dbCommand, "mprmIdPresenMed")
        End Sub
        ''' <summary>
        ''' METODO PARA CARGAR INFORMACION DE PRESENTACION MEDICAMENTO POR ID
        ''' </summary>
        ''' <param name="parIdPresenMed">IDENTIFICADOR DEL OBJETO</param>
        ''' <remarks></remarks>
        Public Sub CargarInfoPresentacionMedXIdPMed(ByVal parIdPresenMed As Integer)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGuardarInfoPresentacionMed")
            db.AddInParameter(dbCommand, "parIdPresenMed", DbType.Int32, parIdPresenMed)

            Using drLector As IDataReader = db.ExecuteReader(dbCommand)
                While drLector.Read
                    'SE CARGA EL LECTOR
                    Me.CargarDrLector(drLector)
                End While
            End Using
        End Sub
        ''' <summary>
        ''' METODOD PARA CARGAR PRESENTACIONES DE MEDICAMENTO POR ID_MEDICAMENTO
        ''' </summary>
        ''' <param name="parIdMedicamento">IDENTIFICADOR DEL MEDICAMENTO</param>
        ''' <returns>TABLA CON OBJETOS DE PRESENTACION MEDICAMENTO</returns>
        ''' <remarks></remarks>
        Public Function GetTblPresentacionMedXIdMed(ByVal parIdMedicamento As Integer) As Data.DataTable
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGetTblPresentacionMedXIdMed")
            db.AddInParameter(dbCommand, "parIdMedicamento", DbType.Int32, parIdMedicamento)

            Return db.ExecuteDataSet(dbCommand).Tables(0)
        End Function
    End Class
End Namespace
