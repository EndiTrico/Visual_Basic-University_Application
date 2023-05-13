Imports System.Data.OleDb
Imports VB_University_Application.University_Application

Public Class Admin
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"

    Private _username As String = "admin"
    Private _password As String = "admin123"

    Public professorList As List(Of Professor) = New List(Of Professor)()
    Public studentList As List(Of Student) = New List(Of Student)()
    Public coursesList As List(Of Courses) = New List(Of Courses)()

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
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

    Public Sub New()
        readDatabase()
    End Sub

    ' Function to Validate If the Entered Credentials are Valid
    Public Function isUsernameAndPasswordValid(username As String, password As String) As Boolean
        If username.Equals(username) And password.Equals(password) Then Return True
        Throw New InvalidLoginInfoException("Username and Password do not match!")
    End Function

    ' Sub Procedure to Add the Professor to the Database
    Public Sub addProfessor(professor As Professor)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using professorTable As New OleDbCommand("INSERT INTO Professors ([First_Name], [Last_Name], [Username], [Password]) VALUES (?, ?, ?, ?)", connection)
                professorTable.Parameters.AddWithValue("@a", professor.Name)
                professorTable.Parameters.AddWithValue("@b", professor.Surname)
                professorTable.Parameters.AddWithValue("@c", professor.Username)
                professorTable.Parameters.AddWithValue("@d", professor.Password)
                Dim rowsAffected As Integer = professorTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Sub Procedure to Remove Professor from the Database
    Public Sub removeProfessor(professor As Professor)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Using professorsTable As New OleDbCommand("DELETE FROM Professors WHERE Professor_ID = ?", connection)
                professorsTable.Parameters.AddWithValue("@id", professor.Id)
                Dim rowsAffected As Integer = professorsTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Sub Procedure to Add the Student to the Database
    Public Sub addStudent(student As Student)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using studentsTable As New OleDbCommand("INSERT INTO Students ([First_Name], [Last_Name], [Username], [Password], [Major]) VALUES (@FirstName, @LastName, @Username, @Password, @Major)", connection)
                studentsTable.Parameters.AddWithValue("@FirstName", student.Name)
                studentsTable.Parameters.AddWithValue("@LastName", student.Surname)
                studentsTable.Parameters.AddWithValue("@Username", student.Username)
                studentsTable.Parameters.AddWithValue("@Password", student.Password)
                studentsTable.Parameters.AddWithValue("@Major", student.Major)
                Dim rowsAffected As Integer = studentsTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Sub Procedure to Remove Student from the Database
    Public Sub removeStudent(student As Student)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using studentsTable As New OleDbCommand("DELETE FROM Students WHERE Student_ID = @id", connection)
                studentsTable.Parameters.AddWithValue("@id", student.Id)
                Dim rowsAffected As Integer = studentsTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Sub Procedure to Add the Course to the Database
    Public Sub addCourse(course As Courses, professorID As Integer)
        Dim courseId As Integer

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using coursesTable As New OleDbCommand("INSERT INTO Courses (Course_Name, Credits, Hours) VALUES (?, ?, ?)", connection)
                coursesTable.Parameters.AddWithValue("@a", course.CourseName)
                coursesTable.Parameters.AddWithValue("@b", course.Credits)
                coursesTable.Parameters.AddWithValue("@c", course.Hours)
                Dim row As Integer = coursesTable.ExecuteNonQuery()
            End Using

            Using coursesTable1 As New OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = ?", connection)
                coursesTable1.Parameters.AddWithValue("@CourseName", course.CourseName)

                Using reader As OleDbDataReader = coursesTable1.ExecuteReader()
                    reader.Read()
                    courseId = Convert.ToInt32(reader("Course_ID").ToString())
                End Using
            End Using

            Using professorsStudentsTable As New OleDbCommand("INSERT INTO Professors_Courses Values (?, ?)", connection)
                professorsStudentsTable.Parameters.AddWithValue("@a", professorID)
                professorsStudentsTable.Parameters.AddWithValue("@b", courseId)
                Dim rowsAffected As Integer = professorsStudentsTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Sub Procedure to Remove Professor from the Database
    Public Sub removeCourse(course As Courses)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using coursesTable As New OleDbCommand("DELETE FROM Courses WHERE Course_ID = ?", connection)
                coursesTable.Parameters.AddWithValue("@id", course.Id)
                Dim rowsAffected As Integer = coursesTable.ExecuteNonQuery()
            End Using
        End Using

        readDatabase()
    End Sub

    ' Read the Tables Students, Professors, Courses from the Database and Save them to the List
    Private Sub readDatabase()
        studentList = New Student().readStudents()
        professorList = New Professor().readProfessors()
        coursesList = New Courses().readCourses()
    End Sub

    ' Fuction to Get a string Representation of Admin
    Public Overrides Function ToString() As String
        Return Username.ToString & ", " & Password.ToString()
    End Function
End Class
