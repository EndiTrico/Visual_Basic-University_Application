Imports System.Data.OleDb

Public Class Professor
    Inherits Person
    Implements Login

    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"
    Private _courses As New List(Of String)()
    Private ReadOnly coursesIds As New List(Of String)()
    Private _activeCourse As String
    Private _activeCourseId As Integer
    Private Shared _loggedProfessors As New List(Of Professor)()

    Public Property Courses As List(Of String)
        Get
            Return _courses
        End Get
        Set(value As List(Of String))
            _courses = value
        End Set
    End Property

    Public Shared Property LoggedProfessors As List(Of Professor)
        Get
            Return _loggedProfessors
        End Get
        Set(value As List(Of Professor))
            _loggedProfessors = value
        End Set
    End Property

    Public Property ActiveCourseId As Integer
        Get
            Return _activeCourseId
        End Get
        Set(value As Integer)
            _activeCourseId = value
        End Set
    End Property

    Public Property ActiveCourse As String
        Get
            Return _activeCourse
        End Get
        Set(value As String)
            _activeCourse = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(name As String, surname As String, username As String, password As String)
        Me.Username = username
        Me.Password = password
        Me.Name = name
        Me.Surname = surname
    End Sub

    Public Sub New(id As Integer, name As String, surname As String, username As String, password As String)
        MyBase.New(id, name, surname, username, password)
    End Sub

    Public Sub New(username As String, password As String)
        Me.Username = username
        Me.Password = password

        Dim reader As OleDbDataReader = isUsernameAndPasswordValid(username, password)

        reader.Read()

        Me.Id = Convert.ToInt32(reader("Professor_ID").ToString())
        Me.Name = reader("First_Name").ToString()
        Me.Surname = reader("Last_Name").ToString()

        Dim con As OleDbConnection = New OleDbConnection(connectionString)

        If con.State <> ConnectionState.Open Then
            con.Open()
        End If

        Dim sql = "SELECT * FROM Courses WHERE Course_ID IN (SELECT Course_ID from Professors_Courses WHERE Professor_ID = ?)"

        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        Dim paramCollection As OleDbParameterCollection = cmd.Parameters
        paramCollection.Add(New OleDbParameter("Professor_ID", Me.Id))

        Dim courseReader As OleDbDataReader = cmd.ExecuteReader()

        If courseReader.HasRows Then
            While courseReader.Read()
                coursesIds.Add(courseReader("Course_ID").ToString())
                Courses.Add(courseReader("Course_Name").ToString())
            End While

        End If
    End Sub

    ' Fuction to Verify if the Entered Credentials are Valid or Not
    Public Function isUsernameAndPasswordValid(username As String, password As String) As OleDbDataReader Implements Login.isUsernameAndPasswordValid
        Dim connection As New OleDbConnection(connectionString)

        connection.Open()

        Dim command As New OleDbCommand("SELECT * FROM Professors WHERE Username = ? AND Password = ?", connection)
        Dim paramCollection As OleDbParameterCollection = command.Parameters
        paramCollection.Add(New OleDbParameter("Username", username))
        paramCollection.Add(New OleDbParameter("Password", password))

        Dim reader As OleDbDataReader = command.ExecuteReader()

        If reader.HasRows Then
            Return reader
        Else
            Throw New InvalidLoginInfoException("Username and Password do not match!")
        End If
    End Function

    ' Fuction to Get the Most Recently Logged Professor
    Public Shared Function getRecentProfessor() As Professor
        Return LoggedProfessors.Last()
    End Function

    ' Function to Display the Students of a Professor's Course
    Public Function getStudents() As List(Of Student)
        Dim students As New List(Of Student)()
        Dim student As New Student()

        For Each stud As Student In student.readStudents()
            If stud.Courses.Contains(ActiveCourse) Then
                students.Add(stud)
            End If
        Next

        Return students
    End Function

    ' Function to Get the Students who is in the Course from the Given ID
    Public Function getStudentFromID(studID As Integer) As Student
        For Each student As Student In getStudents()
            If student.Id.Equals(studID) Then
                Return student
            End If
        Next
        Return Nothing
    End Function

    ' Function to Get Grades for a Course
    Public Function getGrades() As List(Of Grades)
        Dim gradeList As New List(Of Grades)()
        Dim grade As New Grades()

        For Each grades As Grades In grade.readGrades()
            If grades.CourseId.Equals(ActiveCourseId) Then
                gradeList.Add(grades)
            End If
        Next

        Return gradeList
    End Function


    ' Function to Get All the Scores from a Specific Course that the Professor Offers
    Public Function getScores() As List(Of Integer)
        Dim gradeList As New List(Of Integer)()

        For Each grades As Grades In getGrades()
            gradeList.Add(grades.Score)
        Next

        Return gradeList
    End Function

    ' Sub Procedure to Add Grades of a Professor's Course
    Public Sub AddGrades(data As String())
        If data.Length = 0 Then Throw New InvalidInputException("You did not enter any grades!" & vbLf & "The format is: STUDENTID,GRADE")

        For Each grade In data
            Dim inputs = grade.Split(","c)

            If inputs.Length <> 2 Then Throw New InvalidInputException("The input given was not correctly written!" & vbLf & "The format is: STUDENTID,GRADE")

            If getStudentFromID(Convert.ToInt32(inputs(0))) Is Nothing Then Throw New InvalidInputException("The student whose ID you entered is not enrolled in the course!")

            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim command As New OleDbCommand("SELECT count(*) from Grades where Student_ID = ? AND Course_ID = ?", connection)

                Dim paramCollection As OleDbParameterCollection = command.Parameters
                paramCollection.Add(New OleDbParameter("Student_ID", inputs(0)))
                paramCollection.Add(New OleDbParameter("Course_ID", ActiveCourseId))
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Dim sql As String
                If result = 0 Then
                    sql = "INSERT INTO Grades (Grade_Score, Student_ID, Course_ID) VALUES (?, ?, ?)"
                Else
                    sql = "UPDATE Grades SET Grade_Score = ? WHERE Student_ID = ? AND Course_ID = ?"
                End If

                Dim command1 As New OleDbCommand(sql, connection)
                command1.Parameters.AddWithValue("@Grade_Score", inputs(1))
                command1.Parameters.AddWithValue("@Student_ID", inputs(0))
                command1.Parameters.AddWithValue("@Course_ID", ActiveCourseId)
                command1.ExecuteNonQuery()
            End Using
        Next
    End Sub

    ' Function to Display Passing Students
    Public Function showPassingStudents() As List(Of Student)
        Dim studentList As New List(Of Student)()
        Dim studentIds As New List(Of Integer)()

        For Each grade As Grades In getGrades()
            If grade.Score > 59 Then
                studentIds.Add(grade.Studentid)
            End If
        Next

        For Each sId In studentIds
            studentList.Add(getStudentFromID(sId))
        Next

        Return studentList
    End Function

    ' Function to Display Failing Students
    Public Function showFailingStudents() As List(Of Student)
        Dim studentList As New List(Of Student)()
        Dim studentIds As New List(Of Integer)()

        For Each grade As Grades In getGrades()
            If grade.Score <= 59 Then
                studentIds.Add(grade.Studentid)
            End If
        Next

        For Each sId In studentIds
            studentList.Add(getStudentFromID(sId))
        Next

        Return studentList
    End Function

    ' Function to Get the Name of the Lowest Scoring Student
    Public Function showLowestScoringStudent() As String
        Dim lowestScoring As New Student()

        For Each grade As Grades In getGrades()
            If grade.Score = showMinGrade() Then
                lowestScoring = getStudentFromID(grade.Studentid)
            End If
        Next

        Return lowestScoring.Name.ToString() & " " + lowestScoring.Surname
    End Function

    ' Function to Get the Name of the Highest Scoring Student
    Public Function showHighestScoringStudent() As String
        Dim highestScoring As New Student()

        For Each grade As Grades In getGrades()
            If grade.Score = showMaxGrade() Then
                highestScoring = getStudentFromID(grade.Studentid)
            End If
        Next

        Return highestScoring.Name.ToString() & " " + highestScoring.Surname
    End Function


    ' Function to Get the Minimum Grade of a Professor's Course
    Public Function showMinGrade() As Double
        Dim gradeList As List(Of Integer) = getScores()

        Dim min As Double = gradeList.ElementAt(0)

        For i = 1 To gradeList.Count - 1
            If gradeList.ElementAt(i) < min Then
                min = gradeList.ElementAt(i)
            End If
        Next

        Return min
    End Function

    ' Method to Get the Maximum Grade of a Professor's Course
    Public Function showMaxGrade() As Double
        Dim gradeList As List(Of Integer) = getScores()

        Dim max As Double = gradeList.ElementAt(0)
        For i = 1 To gradeList.Count - 1
            If gradeList.ElementAt(i) > max Then
                max = gradeList.ElementAt(i)
            End If
        Next

        Return max
    End Function


    ' Function to Get the Average Grade of a Professor's Course
    Public Function showAverage() As Double
        Dim gradeList As List(Of Integer) = getScores()

        Dim total = 0.0
        If gradeList.Count = 0 Then Return total

        For Each grade In gradeList
            total += grade
        Next

        Return total / gradeList.Count
    End Function

    'Sub Procedure to Set the Id of the Active Course
    Public Sub setActiveCourseId()
        If Not Equals(ActiveCourse, Nothing) Then
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim command As New OleDbCommand("SELECT * FROM Courses WHERE Course_Name = ?", connection)
                Dim paramCollection As OleDbParameterCollection = command.Parameters
                paramCollection.Add(New OleDbParameter("Course_Name", ActiveCourse))

                Using reader As OleDbDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ActiveCourseId = reader.GetInt32(0)
                        End While
                    End If
                End Using
            End Using
        End If
    End Sub

    ' Function to Get All Professors from Database
    Public Function readProfessors() As List(Of Professor)
        Dim professors As New List(Of Professor)()
        Using connection As New OleDbConnection(Me.connectionString)
            connection.Open()

            Dim command As New OleDbCommand("SELECT * FROM Professors", connection)

            Using reader As OleDbDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim professorId = Convert.ToInt32(reader("Professor_ID"))
                        Dim table_firstName As String = reader("First_Name").ToString()
                        Dim table_lastName As String = reader("Last_Name").ToString()
                        Dim table_username As String = reader("Username").ToString()
                        Dim table_password As String = reader("Password").ToString()

                        Dim prof As New Professor(professorId, table_firstName, table_lastName, table_username, table_password)

                        Dim professorCoursesTable As New OleDbCommand("SELECT Course_ID FROM Professors_Courses WHERE Professor_ID = ?", connection)

                        Dim paramCollection As OleDbParameterCollection = professorCoursesTable.Parameters
                        paramCollection.Add(New OleDbParameter("Professor_ID", professorId))
                        Using readerProfessorCoursesTable As OleDbDataReader = professorCoursesTable.ExecuteReader()

                            While readerProfessorCoursesTable.Read()
                                Dim table_courseID = Convert.ToInt32(readerProfessorCoursesTable("Course_ID"))

                                Dim coursesTable As New OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = ?", connection)
                                Dim coursesParamCollection As OleDbParameterCollection = coursesTable.Parameters
                                coursesParamCollection.Add(New OleDbParameter("Course_ID", table_courseID))
                                Dim readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()
                                readerCoursesTable.Read()
                                prof.Courses.Add(readerCoursesTable("Course_Name").ToString())
                                readerCoursesTable.Close()
                            End While
                            professors.Add(prof)
                        End Using
                    End While
                End If
            End Using
        End Using

        Return professors
    End Function

    ' Function to Get a String Tepresentation of Professor
    Public Overrides Function ToString() As String
        If Courses Is Nothing Then
            Return Name.ToString() & ", " + Surname.ToString() & ", " + Username.ToString() & ", " + Password
        Else
            Dim result As String = Name.ToString() & ", " + Surname.ToString() & ", " + Username.ToString() & ", " + Password
            For i = 0 To Courses.Count - 1
                result += "," & Courses(i)
            Next
            Return result
        End If
    End Function
End Class