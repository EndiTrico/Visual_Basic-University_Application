Imports System.Data.OleDb

Public Class Courses
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"
    Private _id As Integer
    Private _courseName As String
    Private _credits As Integer
    Private _hours As Integer

    Private ReadOnly coursesList As New List(Of Courses)()

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property CourseName As String
        Get
            Return _courseName
        End Get
        Set(value As String)
            _courseName = value
        End Set
    End Property

    Public Property Credits As Integer
        Get
            Return _credits
        End Get
        Set(value As Integer)
            _credits = value
        End Set
    End Property

    Public Property Hours As Integer
        Get
            Return _hours
        End Get
        Set(value As Integer)
            _hours = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, courseName As String, credits As Integer, hours As Integer)
        Me.Id = id
        Me.CourseName = courseName
        Me.Credits = credits
        Me.Hours = hours
    End Sub

    Public Sub New(courseName As String, credits As Integer, hours As Integer)
        Me.CourseName = courseName
        Me.Credits = credits
        Me.Hours = hours
    End Sub

    ' Function to Read All Courses from the Database
    Public Function readCourses() As List(Of Courses)

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim coursesTable As New OleDbCommand("SELECT * FROM Courses", connection)
            Using readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()

                While readerCoursesTable.Read()
                    Dim course As New Courses(Convert.ToInt32(readerCoursesTable("Course_ID")), readerCoursesTable("Course_Name").ToString(), Convert.ToInt32(readerCoursesTable("Credits")), Convert.ToInt32(readerCoursesTable("Hours")))

                    coursesList.Add(course)
                End While

            End Using
        End Using

        Return coursesList
    End Function

    ' Fuction to Get a String Representation of Courses
    Public Overrides Function ToString() As String
        Return Id.ToString() & "," & CourseName & "," & Credits.ToString() & "," & Hours.ToString()
    End Function
End Class