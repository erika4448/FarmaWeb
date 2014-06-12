Imports System.Data.Common
Namespace Medicamentos
    Public Class clMedMedicamento
        Inherits Comun.clBase
#Region "VARIABLES"
        Private _mmedIdMedicamento As Integer
        Public Property mmedIdMedicamento As Integer
            Get
                Return _mmedIdMedicamento
            End Get
            Set(value As Integer)
                _mmedIdMedicamento = value
            End Set
        End Property
        Private _mmedDrogIdUsuario As Integer
        Public Property mmedDrogIdUsuario As Integer
            Get
                Return _mmedDrogIdUsuario
            End Get
            Set(value As Integer)
                _mmedDrogIdUsuario = value
            End Set
        End Property

        Private _mmedCodigoCUM As String
        Public Property mmedCodigoCUM As String
            Get
                Return _mmedCodigoCUM
            End Get
            Set(value As String)
                _mmedCodigoCUM = value
            End Set
        End Property
        Private _mmedNombre As String
        Public Property mmedNombre As String
            Get
                Return _mmedNombre
            End Get
            Set(value As String)
                _mmedNombre = value
            End Set
        End Property

        Private _mmedLaborIdInfoPMed As Integer
        Public Property mmedLaborIdInfoPMed As Integer
            Get
                Return _mmedLaborIdInfoPMed
            End Get
            Set(value As Integer)
                _mmedLaborIdInfoPMed = value
            End Set
        End Property
        Private _mipmVidaUtil As Integer
        Public Property mipmVidaUtil As Integer
            Get
                Return _mipmVidaUtil
            End Get
            Set(value As Integer)
                _mipmVidaUtil = value
            End Set
        End Property
        Private _mipmRegistroSani As String
        Public Property mipmRegistroSani As String
            Get
                Return _mipmRegistroSani
            End Get
            Set(value As String)
                _mipmRegistroSani = value
            End Set
        End Property
        Private _mipmFFarmIdInfoPMed As Integer
        Public Property mipmFFarmIdInfoPMed As Integer
            Get
                Return _mipmFFarmIdInfoPMed
            End Get
            Set(value As Integer)
                _mipmFFarmIdInfoPMed = value
            End Set
        End Property
        Private _mipmTConcIdInfoPMed As Integer
        Public Property mipmTConcIdInfoPMed As Integer
            Get
                Return _mipmTConcIdInfoPMed
            End Get
            Set(value As Integer)
                _mipmTConcIdInfoPMed = value
            End Set
        End Property
        Private _mipmViaAdIdInfoPMed As Integer
        Public Property mipmViaAdIdInfoPMed As Integer
            Get
                Return _mipmViaAdIdInfoPMed
            End Get
            Set(value As Integer)
                _mipmViaAdIdInfoPMed = value
            End Set
        End Property
        Private _mipmTMedIdInfoPMed As Integer
        Public Property mipmTMedIdInfoPMed As Integer
            Get
                Return _mipmTMedIdInfoPMed
            End Get
            Set(value As Integer)
                _mipmTMedIdInfoPMed = value
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
        ''' METODO PARA CARGAR EL OBJETO LECTOR EN LAS VARIABLES DEL OBJETO
        ''' </summary>
        ''' <param name="parDrLector">LECTOR CON INFORMACION DEL OBJETO</param>
        ''' <remarks></remarks>
        Private Sub CargarDrLector(ByVal parDrLector As IDataReader)
            mmedIdMedicamento = IIf(IsDBNull(parDrLector("mmedIdMedicamento")), 0, parDrLector("mmedIdMedicamento"))
            mmedDrogIdUsuario = IIf(IsDBNull(parDrLector("mmedDrogIdUsuario")), 0, parDrLector("mmedDrogIdUsuario"))
            mmedCodigoCUM = IIf(IsDBNull(parDrLector("mmedCodigoCUM")), "", parDrLector("mmedCodigoCUM"))
            mmedNombre = IIf(IsDBNull(parDrLector("mmedNombre")), "", parDrLector("mmedNombre"))
            mmedLaborIdInfoPMed = IIf(IsDBNull(parDrLector("mmedLaborIdInfoPMed")), 0, parDrLector("mmedLaborIdInfoPMed"))
            mipmVidaUtil = IIf(IsDBNull(parDrLector("mipmVidaUtil")), 0, parDrLector("mipmVidaUtil"))
            mipmRegistroSani = IIf(IsDBNull(parDrLector("mipmRegistroSani")), "", parDrLector("mipmRegistroSani"))
            mipmFFarmIdInfoPMed = IIf(IsDBNull(parDrLector("mipmFFarmIdInfoPMed")), 0, parDrLector("mipmFFarmIdInfoPMed"))
            mipmTConcIdInfoPMed = IIf(IsDBNull(parDrLector("mipmTConcIdInfoPMed")), 0, parDrLector("mipmTConcIdInfoPMed"))
            mipmViaAdIdInfoPMed = IIf(IsDBNull(parDrLector("mipmViaAdIdInfoPMed")), 0, parDrLector("mipmViaAdIdInfoPMed"))
            mipmTMedIdInfoPMed = IIf(IsDBNull(parDrLector("mipmTMedIdInfoPMed")), 0, parDrLector("mipmTMedIdInfoPMed"))
            mipmIdEstado = IIf(IsDBNull(parDrLector("mipmIdEstado")), 0, parDrLector("mipmIdEstado"))
        End Sub
        ''' <summary>
        ''' METODO PARA GUARDAR INFORMACION DE MEDICAMENTO
        ''' </summary>
        ''' <param name="parObjTrans">OBJETO PARA CONTROLAR LA TRANSACCION</param>
        ''' <remarks></remarks>
        Public Sub GuardarInfoMedicamentoXIdMed(Optional ByVal parObjTrans As System.Data.Common.DbTransaction = Nothing)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGuardarInfoMedicamento")

            db.AddParameter(dbCommand, "mmedIdMedicamento", DbType.Int32, ParameterDirection.InputOutput, Nothing, DataRowVersion.Current, mmedIdMedicamento)
            db.AddInParameter(dbCommand, "mmedDrogIdUsuario", DbType.Int32, mmedDrogIdUsuario)
            db.AddInParameter(dbCommand, "mmedCodigoCUM", DbType.String, mmedCodigoCUM)
            db.AddInParameter(dbCommand, "mmedNombre", DbType.String, mmedNombre)
            db.AddInParameter(dbCommand, "mmedLaborIdInfoPMed", DbType.Int32, mmedLaborIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmVidaUtil", DbType.Int32, mipmVidaUtil)
            db.AddInParameter(dbCommand, "mipmRegistroSani", DbType.String, mipmRegistroSani)
            db.AddInParameter(dbCommand, "mipmFFarmIdInfoPMed", DbType.Int32, mipmFFarmIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmTConcIdInfoPMed", DbType.Int32, mipmTConcIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmViaAdIdInfoPMed", DbType.Int32, mipmViaAdIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmTMedIdInfoPMed", DbType.Int32, mipmTMedIdInfoPMed)
            db.AddInParameter(dbCommand, "mipmIdEstado", DbType.Int32, mipmIdEstado)

            If (parObjTrans Is Nothing) Then
                db.ExecuteNonQuery(dbCommand)
            Else
                db.ExecuteNonQuery(dbCommand, parObjTrans)
            End If

            mmedIdMedicamento = db.GetParameterValue(dbCommand, "mmedIdMedicamento")
        End Sub
        ''' <summary>
        ''' METODO PARA CAGAR INFORMACION DE MEDICAMENTO POR ID
        ''' </summary>
        ''' <param name="parIdMedicamento">IDENTIFICADOR DEL REGISTRO DE MEDICAMENTO SOLICITADO</param>
        ''' <remarks></remarks>
        Public Sub CargarInfoMedciamentoXIdMed(ByVal parIdMedicamento As Integer)
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedCargarInfoMedicamentoXIdMed")
            db.AddInParameter(dbCommand, "parIdMedicamento", DbType.Int32, parIdMedicamento)

            Using drLector As IDataReader = db.ExecuteReader(dbCommand)
                While drLector.Read
                    'SE CARGA EL LECTOR
                    Me.CargarDrLector(drLector)
                End While
            End Using
        End Sub

        ''' <summary>
        ''' METODO PARA CARGAR TABLA DE MEDICAMENTOS POR NOMBRE DE MEDICAMENTO DE CONSULTA
        ''' </summary>
        ''' <param name="parStrNombre">NOMBRE DEL MEDICAMENTO</param>
        ''' <param name="parIdUsuario">USUARIO DROGUERIA QUE REALIZA LA CONSULTA</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetTblMedicamentoXStrNom(ByVal parStrNombre As String, ByVal parIdUsuario As Integer) As Data.DataTable
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spMedGetTblMedicamentoXStrNom")
            db.AddInParameter(dbCommand, "parStrNombre", DbType.String, parStrNombre)
            db.AddInParameter(dbCommand, "parIdUsuario", DbType.Int32, parIdUsuario)

            Return db.ExecuteDataSet(dbCommand).Tables(0)
        End Function

    End Class
End Namespace