Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.Text

Namespace University_Application
    Public Class Courses
        Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"

        Private idField As Integer
        Private courseNameField As String
        Private creditsField As Integer
        Private hoursField As Integer

        Public Property Id As Integer
            Get
                Return idField
            End Get
            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property
        Public Property CourseName As String
            Get
                Return courseNameField
            End Get
            Set(ByVal value As String)
                courseNameField = value
            End Set
        End Property
        Public Property Credits As Integer
            Get
                Return creditsField
            End Get
            Set(ByVal value As Integer)
                creditsField = value
            End Set
        End Property
        Public Property Hours As Integer
            Get
                Return hoursField
            End Get
            Set(ByVal value As Integer)
                hoursField = value
            End Set
        End Property

        Public Sub New()

        End Sub
        Public Sub New(ByVal id As Integer, ByVal courseName As String, ByVal credits As Integer, ByVal hours As Integer)
            Me.Id = id
            Me.CourseName = courseName
            Me.Credits = credits
            Me.Hours = hours
        End Sub

        Public Sub New(ByVal courseName As String, ByVal credits As Integer, ByVal hours As Integer)
            Me.CourseName = courseName
            Me.Credits = credits
            Me.Hours = hours
        End Sub

        Public Function readCourses() As List(Of Courses)
            Dim connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()

            Dim coursesTable As OleDbCommand = New OleDbCommand("SELECT * FROM Courses", connection)
            Dim readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()

            Dim coursesList As List(Of Courses) = New List(Of Courses)()

            While readerCoursesTable.Read()
                Dim course As Courses = New Courses(Convert.ToInt32(readerCoursesTable("Course_ID")), readerCoursesTable("Course_Name").ToString(), Convert.ToInt32(readerCoursesTable("Credits")), Convert.ToInt32(readerCoursesTable("Hours")))

                coursesList.Add(course)
            End While

            readerCoursesTable.Close()
            connection.Close()

            Return coursesList
        End Function

        Public Overrides Function ToString() As String
            Return Id.ToString() & "," & CourseName & "," & Credits.ToString() & "," & Hours.ToString()
        End Function
    End Class
End Namespace
