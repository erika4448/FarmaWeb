Imports System.Data.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data

Namespace Comun
    Public Class clObjTrans
        Inherits Comun.clBase
#Region "Metodos para Manejo de transacciones"
        Dim transConn As DbConnection
        Public transTransaction As DbTransaction
        Public Sub transCreaTrans()
            db = DatabaseFactory.CreateDatabase
            transConn = db.CreateConnection
            transConn.Open()
            transTransaction = transConn.BeginTransaction()
        End Sub
        Public Sub transAceptaTrans()
            transTransaction.Commit()
            transConn.Close()
        End Sub
        Public Sub transErrorTrans()
            transTransaction.Rollback()
            transConn.Close()
        End Sub

#End Region
    End Class
End Namespace