Imports System.Data.Common
Namespace Sistema
    Public Class clSisEstado
        Inherits Comun.clBase
#Region "VARIABLES"
        Private _sestIdEstado As Integer
        Public Property sestIdEstado As Integer
            Get
                Return _sestIdEstado
            End Get
            Set(value As Integer)
                _sestIdEstado = value
            End Set
        End Property

        Private _sestNombre As String
        Public Property sestNombre As String
            Get
                Return _sestNombre
            End Get
            Set(value As String)
                _sestNombre = value
            End Set
        End Property
#End Region

        Public Function GetTblEstado() As Data.DataTable
            Dim dbCommand As DbCommand = db.GetStoredProcCommand("spSisGetTblEstado")

            Return db.ExecuteDataSet(dbCommand).Tables(0)
        End Function
    End Class
End Namespace
