Public Class Squids
    Public Class Onu
        Shared Overrides Friend Policy(OpenAccess)

        Private Shared Function OpenAccess() As Integer
            Throw New NotImplementedException
        End Function
    End Class

    Public Overrides Dialog As SortedList
    Public Overrides PathCurrent As SampleActivity(Of SortedList)
    public Overrides DialogShapes As SortedList(Of Onu, SortedList)
End Class