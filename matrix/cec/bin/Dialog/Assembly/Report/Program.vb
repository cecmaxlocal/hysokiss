Public Interface IProgram
    Public Shadows Event Freebasic As StrArgs
End Interface

Public Class Languages
    Sub New(freebasic As Object)
        _freebasic = freebasic
        Me.Freebasic = freebasic
    End Sub

    Public Property Freebasic as Object
    Public Property FreebasicObj as Object
End Class