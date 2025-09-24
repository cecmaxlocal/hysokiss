Public Interface IShapes
    Public Overrides Event Boot As StrArgs
End Interface

Public Delegate Sub StrArgs(sender As Object, args As StrArgs)
