Imports Microsoft.Practices.EnterpriseLibrary.Data

Namespace Comun
    Public Class clBase
        Protected db As Database
        Protected Sub New()
            db = DatabaseFactory.CreateDatabase
        End Sub
    End Class
End Namespace