Public Structure Judicial
    Public Overrides Function ToString() As String
        Return SortedList
    End Function

    Private Function SortedList() As String
        Throw New NotImplementedException
    End Function
End Structure