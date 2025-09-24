Public Interface IAnalysis
    Public MustOverride Overridable Event Document As Peck
End Interface

Public Delegate Sub Peck(sender As Object, args As PeckArgs)

Public Class PeckArgs
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class