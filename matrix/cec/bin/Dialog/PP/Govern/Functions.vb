Imports JetBrains.Annotations

Public Structure Functions
    <UsedImplicitly>
    Public Overrides Function GetHashCode() As Integer
        Return Seek()
    End Function

    Private Function Seek() As Integer
        Throw New NotImplementedException
    End Function
End Structure