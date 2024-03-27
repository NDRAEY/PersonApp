Public Class Person
    Private _FirstName As String
    Private _SecondName As String

    Public Property FirstName As String
        Get
            Return _FirstName
        End Get
        Set(value As String)
            _FirstName = value
        End Set
    End Property

    Public Property SecondName As String
        Get
            Return _SecondName
        End Get
        Set(value As String)
            _SecondName = value
        End Set
    End Property

    Public Function Age(Birthday As Date) As Integer
        Return Convert.ToInt32(Date.Now.Subtract(Birthday).Days / 365.25F)
    End Function
End Class
