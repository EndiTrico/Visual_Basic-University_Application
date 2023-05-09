Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports University_Application
Imports System.Data.OleDb
Imports System.Linq
Imports System.Windows.Forms
Imports System.Diagnostics
Imports VB_University_Application.University_Application

Public Class Student
    Inherits Person
    Implements Login

    Private _major As String
    Private _courses As List(Of String) = New List(Of String)()
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"

    Public Property Courses As List(Of String)
        Get
            Return _courses
        End Get
        Set(value As List(Of String))
            _courses = value
        End Set
    End Property

    Public Property Major As String
        Get
            Return _major
        End Get
        Set(value As String)
            _major = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal studentID As Integer, ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String, ByVal major As String, ByVal courses As List(Of String))
        MyBase.New(studentID, name, surname, username, password)
        Me.Major = major
        Me.Courses = courses
    End Sub

    Public Sub New(ByVal studentID As Integer, ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String, ByVal major As String)
        MyBase.New(studentID, name, surname, username, password)
        Me.Major = major
    End Sub

    Public Sub New(ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String, ByVal major As String)
        Me.Name = name
        Me.Surname = surname
        Me.Username = username
        Me.Password = password
        Me.Major = major
    End Sub

    Public Sub New(ByVal username As String, ByVal password As String)
        Me.Username = username
        Me.Password = password
        Dim con As OleDbConnection = New OleDbConnection(connectionString)
        con.Open()
        Dim reader As OleDbDataReader = isUsernameAndPasswordValid(username, password)
        reader.Read()
        Me.Id = Convert.ToInt32(reader("Student_ID").ToString())
        Me.Name = reader("First_Name").ToString()
        Me.Surname = reader("Last_Name").ToString()
        Dim sql As String = "SELECT * FROM Courses WHERE Course_Id IN (SELECT Course_Id from Students_Courses WHERE Student_Id=" & Me.Id & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        Dim courseReader As OleDbDataReader = cmd.ExecuteReader()

        If courseReader.HasRows Then
            While courseReader.Read()
                Courses.Add(courseReader("Course_Name").ToString())
            End While
        End If

        courseReader.Close()
        con.Close()
    End Sub

    Public Function readStudents() As List(Of Student)
        Dim student As Student = Nothing

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim sql As String = "
                SELECT s.Student_ID, s.First_Name, s.Last_Name, s.Username, s.Password, s.Major, c.Course_Name
                FROM (Students s LEFT JOIN Students_Courses sc ON s.Student_ID = sc.Student_ID)
                LEFT JOIN Courses c ON sc.Course_ID = c.Course_ID"
            Dim students = New Dictionary(Of Integer, Student)()

            Using command As OleDbCommand = New OleDbCommand(sql, connection)

                Using reader As OleDbDataReader = command.ExecuteReader()

                    While reader.Read()
                        Dim studentID As Integer = Convert.ToInt32(reader("Student_ID").ToString())

                        If Not students.TryGetValue(studentID, student) Then
                            student = New Student With {
                                .Id = studentID,
                                .Name = reader("First_Name").ToString(),
                                .Surname = reader("Last_Name").ToString(),
                                .Username = reader("Username").ToString(),
                                .Password = reader("Password").ToString(),
                                .major = reader("Major").ToString(),
                                .Courses = New List(Of String)()
                            }
                            students.Add(studentID, student)
                        End If

                        student.Courses.Add(reader("Course_Name").ToString())
                    End While
                End Using
            End Using

            Return students.Values.ToList()
        End Using
    End Function

    Public Function showAllCourses() As List(Of String)
        Dim allCourses As List(Of String) = New List(Of String)()

        For Each course As Courses In New Courses().readCourses()
            allCourses.Add(course.CourseName)
        Next

        Return allCourses
    End Function

    Public Function showGrades() As List(Of String)
        Dim myGrades As List(Of String) = New List(Of String)()

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()

            For Each grades As Grades In New Grades().readGradesForAStudent(Me.Id)
                Dim coursesTable As OleDbCommand = New OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = ?", connection)
                Dim paramCollection As OleDbParameterCollection = coursesTable.Parameters
                paramCollection.Add(New OleDbParameter("Course_ID", grades.CourseId))

                Using readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()
                    readerCoursesTable.Read()
                    myGrades.Add(readerCoursesTable("Course_Name").ToString() & " " & grades.Score)
                End Using
            Next
        End Using

        Return myGrades
    End Function

    Public Sub enroll(ByVal courseName As String, ByVal studID As Integer)
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim coursesTable As OleDbCommand = New OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = @CourseName", connection)
            coursesTable.Parameters.AddWithValue("@Student_ID", courseName)

            Using readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()
                readerCoursesTable.Read()
                Dim studentsCoursesTable As OleDbCommand = New OleDbCommand("INSERT INTO Students_Courses VALUES (@StudentID, @CourseID)", connection)
                studentsCoursesTable.Parameters.AddWithValue("@StudentID", studID)
                studentsCoursesTable.Parameters.AddWithValue("@CourseID", Convert.ToInt32(readerCoursesTable("Course_ID").ToString()))
                Dim rowsAffected As Integer = studentsCoursesTable.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub drop(ByVal courseName As String, ByVal studid As Integer)
        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim coursesTable As OleDbCommand = New OleDbCommand("SELECT Course_ID from Courses WHERE Course_Name = @CourseName", connection)
            coursesTable.Parameters.AddWithValue("@CourseName", courseName)

            Using readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()
                readerCoursesTable.Read()
                Dim studentsCoursesTable As OleDbCommand = New OleDbCommand("DELETE FROM Students_Courses WHERE Student_ID = @StudentID AND Course_ID = @CourseID", connection)
                studentsCoursesTable.Parameters.AddWithValue("@StudentID", studid)
                studentsCoursesTable.Parameters.AddWithValue("@CourseID", Convert.ToInt32(readerCoursesTable("Course_ID").ToString()))
                Dim rowsAffected As Integer = studentsCoursesTable.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function allCoursesExcludingStudentCourses() As List(Of String)
        Dim availableCourses As List(Of String) = New List(Of String)()

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim excludedCourseNameString As String = String.Join(",", Courses.[Select](Function(x) $"'{x}'"))
            Dim coursesTable As OleDbCommand = New OleDbCommand($"SELECT Course_Name FROM Courses WHERE Course_Name NOT IN ({excludedCourseNameString})", connection)

            Using readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()

                While readerCoursesTable.Read()
                    availableCourses.Add(readerCoursesTable.GetString(0))
                End While
            End Using
        End Using

        Return availableCourses
    End Function

    Public Function showStudentCredits() As List(Of String)
        Dim myCredits As List(Of String) = New List(Of String)()

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand("SELECT c.Course_Name, c.Credits FROM Courses c 
                INNER JOIN Students_Courses sc ON c.Course_ID = sc.Course_ID WHERE sc.Student_ID = @StudentID", connection)
            command.Parameters.AddWithValue("@StudentID", Id)

            Using reader As OleDbDataReader = command.ExecuteReader()

                While reader.Read()
                    myCredits.Add(reader("Course_Name").ToString() & " - " & reader("Credits").ToString() & " credits")
                End While
            End Using
        End Using

        Return myCredits
    End Function

    Public Function showAllCredits() As List(Of String)
        Dim allCourses As List(Of String) = New List(Of String)()

        For Each course As Courses In New Courses().readCourses()
            allCourses.Add(course.CourseName & " - " + course.Credits & " credits")
        Next

        Return allCourses
    End Function

    Public Function showGPA() As Double
        Dim gradeCredits As Double() = New Double(1) {}

        Using connection As OleDbConnection = New OleDbConnection(connectionString)
            connection.Open()
            Dim command As OleDbCommand = New OleDbCommand("SELECT g.Grade_Score, c.Credits FROM Grades g
                    INNER JOIN Courses c ON g.Course_ID = c.Course_ID
                    WHERE g.Student_ID = @StudentID", connection)
            command.Parameters.AddWithValue("@StudentID", Id)
            Dim gradesReader As OleDbDataReader = command.ExecuteReader()
            Dim grade As Double = 0.00

            If gradesReader.HasRows Then

                While gradesReader.Read()
                    grade = Convert.ToInt32(gradesReader("Grade_Score").ToString())

                    If grade < 59.5 Then
                        grade = 0.00
                    ElseIf grade < 62.5 Then
                        grade = 0.67
                    ElseIf grade < 66.5 Then
                        grade = 1.0
                    ElseIf grade < 69.5 Then
                        grade = 1.33
                    ElseIf grade < 72.5 Then
                        grade = 1.67
                    ElseIf grade < 76.5 Then
                        grade = 2.0
                    ElseIf grade < 79.5 Then
                        grade = 2.33
                    ElseIf grade < 82.5 Then
                        grade = 2.67
                    ElseIf grade < 86.5 Then
                        grade = 3.0
                    ElseIf grade < 89.5 Then
                        grade = 3.33
                    ElseIf grade < 95.5 Then
                        grade = 3.67
                    Else
                        grade = 4.0
                    End If

                    gradeCredits(0) += grade * Convert.ToInt32(gradesReader("Credits").ToString())
                    gradeCredits(1) += Convert.ToInt32(gradesReader("Credits").ToString())
                End While
            End If

            gradesReader.Close()

            If gradeCredits(1) <> 0 Then
                Return Math.Round(gradeCredits(0) / gradeCredits(1), 2)
            End If

            Return -1
        End Using
    End Function

    Public Overrides Function ToString() As String
        If Me.Courses Is Nothing Then
            Return Me.Name & "," + Me.Surname & "," + Me.Username & "," + Me.Password & "," + Me.Id & "," & Me.major
        Else
            Dim result As String = Me.Name & "," + Me.Surname & "," + Me.Username & "," + Me.Password & "," + Me.Id & "," & Me.major

            For j As Integer = 0 To Me.Courses.Count - 1
                result += "," & Me.Courses(j)
            Next

            Return result
        End If
    End Function

    Public Function isUsernameAndPasswordValid(username As String, password As String) As OleDbDataReader Implements Login.isUsernameAndPasswordValid
        Dim con As OleDbConnection = New OleDbConnection(connectionString)

        If con.State <> System.Data.ConnectionState.Open Then
            con.Open()
        End If

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Students WHERE Username = ? AND Password = ?", con)
        Dim paramCollection As OleDbParameterCollection = cmd.Parameters
        paramCollection.Add(New OleDbParameter("Username", username))
        paramCollection.Add(New OleDbParameter("Password", password))
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            Return reader
        Else
            Throw New InvalidLoginInfoException("Username and Password do not match!")
        End If
    End Function
End Class
