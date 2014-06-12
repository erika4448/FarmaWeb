Namespace Message
    Public Class clObjMsjRS

        Public Sub New()
            Me.pIdRel = 0
            Me.pStrMessage = ""
        End Sub
        Private _IdRel As Integer
        Public Property pIdRel As Integer
            Get
                Return _IdRel
            End Get
            Set(value As Integer)
                _IdRel = value
            End Set
        End Property

        Private _strMessage As String
        Public Property pStrMessage As String
            Get
                Return _strMessage
            End Get
            Set(value As String)
                _strMessage = value
            End Set
        End Property
    End Class

End Namespace
