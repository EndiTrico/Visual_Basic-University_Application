Public MustInherit Class Person
    Private _id As Integer
    Private _name As String
    Private _surname As String
    Private _username As String
    Private _password As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Sub New(id As Integer, name As String, surname As String, username As String, password As String)
        Me.Id = id
        Me.Name = name
        Me.Surname = surname
        Me.Username = username
        Me.Password = password
    End Sub

    Public Sub New()
    End Sub

    ' Fuction to Get a String Representation of Person
    Public Overrides Function ToString() As String
        Return Id & "," & Name & "," + Surname & "," + Username & "," + Password
    End Function
End Class
