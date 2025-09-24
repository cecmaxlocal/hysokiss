Public Structure Onu
    Public Shared Property NameProperty as Object

    Public Shared Function GetPropertyName(ByVal element As DependencyObject) As PropertyType
        Return element.GetValue(NameProperty)
    End Function

    Public Shared Sub SetPropertyName(element As DependencyObject, ByVal value As PropertyType)
        element.SetValue(NameProperty, value)
    End Sub
End Structure

Public Class PropertyMetadata
    Public ReadOnly Property O As Object

    Public Sub New()
        Me.New(Nothing)
    End Sub

    Public Sub New(o As Object)
        Me.O = o
        Throw New NotImplementedException
    End Sub
End Class

Public Class DependencyObject
    Public Function SetValue(nameProperty As Object, propertyType As PropertyType) As PropertyType
        Throw New NotImplementedException
    End Function

    Public Function GetValue(nameProperty As Object) As PropertyType
        Throw New NotImplementedException
    End Function
End Class

Public Class PropertyType
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class