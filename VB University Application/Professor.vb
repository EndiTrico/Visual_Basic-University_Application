Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Namespace University_Application
    Public Class Professor
        Inherits Person
        Implements Login

        ' data fields
        Private connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"
        Private coursesField As List(Of String) = New List(Of String)()
        Private coursesIds As List(Of String) = New List(Of String)()
        Private activeCourseField As String
        Private activeCourseId As Integer
        Private Shared loggedProfessorsField As List(Of Professor) = New List(Of Professor)()


        ' attributes
        Public Property Courses As List(Of String)
            Get
                Return coursesField
            End Get
            Set(ByVal value As List(Of String))
                coursesField = value
            End Set
        End Property
        Public Property ActiveCourse As String
            Get
                Return activeCourseField
            End Get
            Set(ByVal value As String)
                activeCourseField = value
            End Set
        End Property
        Public Shared Property LoggedProfessors As List(Of Professor)
            Get
                Return loggedProfessorsField
            End Get
            Set(ByVal value As List(Of Professor))
                loggedProfessorsField = value
            End Set
        End Property

        ' constructors

        Public Sub New()

        End Sub

        Public Sub New(ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String)
            Me.Username = username
            Me.Password = password
            Me.Name = name
            Me.Surname = surname
        End Sub
        Public Sub New(ByVal id As Integer, ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String)
            MyBase.New(id, name, surname, username, password)
        End Sub

        Public Sub New(ByVal username As String, ByVal password As String)
            Me.Username = username
            Me.Password = password

            Dim reader As OleDbDataReader = isUsernameAndPasswordValid(username, password)

            reader.Read()

            Me.id = Convert.ToInt32(reader(CStr("Professor_ID")).ToString())
            Me.Name = reader("First_Name").ToString()
            Me.Surname = reader("Last_Name").ToString()

            Dim con As OleDbConnection = New OleDbConnection(connection)

            If con.State <> Data.ConnectionState.Open Then
                con.Open()
            End If

            Dim sql = "SELECT * FROM Courses WHERE Course_ID IN (SELECT Course_ID from Professors_Courses WHERE Professor_ID = ?)"

            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            Dim paramCollection As OleDbParameterCollection = cmd.Parameters
            paramCollection.Add(New OleDbParameter("Professor_ID", Me.Id))

            Using courseReader As OleDbDataReader = cmd.ExecuteReader()


                If courseReader.HasRows Then
                    While courseReader.Read()
                        coursesIds.Add(courseReader(CStr("Course_ID")).ToString())
                        coursesField.Add(courseReader(CStr("Course_Name")).ToString())
                    End While

                End If
            End Using

        End Sub


        ' method to determine if the login info is valid
        Public Function isUsernameAndPasswordValid(ByVal username As String, ByVal password As String) As OleDbDataReader
            Dim con As OleDbConnection = New OleDbConnection(connection)

            If con.State <> Data.ConnectionState.Open Then
                con.Open()
            End If

            Dim sql = "SELECT * FROM Professors WHERE Username = ? AND Password = ?"
            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
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

        ' method to get the most recently logged professor
        Public Shared Function getRecentProfessor() As Professor
            Return LoggedProfessors.Last()
        End Function

        ' method to show the students of a professor's course
        Public Function getStudents() As List(Of Student)
            Dim students As List(Of Student) = New List(Of Student)()
            Dim student As Student = New Student()

            For Each stud As Student In student.readStudents()
                If stud.Courses.Contains(ActiveCourse) Then students.Add(stud)
            Next

            Return students
        End Function

        ' method to get student who is in the course from given ID
        Public Function getStudentFromID(ByVal Id As Integer) As Student
            For Each student As Student In getStudents()
                If student.Id.Equals(Id) Then Return student
            Next
            Return Nothing
        End Function

        ' method to get grades of course
        Public Function getGrades() As List(Of Grades)
            Dim gradeList As List(Of Grades) = New List(Of Grades)()
            Dim grade As Grades = New Grades()

            For Each grades As Grades In grade.readGrades()
                If grades.CourseID.Equals(activeCourseId) Then gradeList.Add(grades)
            Next

            Return gradeList
        End Function


        ' method to get all the scores of a professor's course
        Public Function getScores() As List(Of Integer)
            Dim gradeList As List(Of Integer) = New List(Of Integer)()

            For Each grades As Grades In getGrades()
                gradeList.Add(grades.Score)
            Next
            Return gradeList
        End Function

        ' method to add grades of a professor's course
        Public Sub AddGrades(ByVal data As String())
            If data.Length = 0 Then Throw New InvalidInputException("You did not enter any grades!" & vbLf & "The format is: STUDENTID,GRADE")

            For Each grade In data
                Dim inputs = grade.Split(","c)

                If inputs.Length <> 2 Then Throw New InvalidInputException("The input given was not correctly written!" & vbLf & "The format is: STUDENTID,GRADE")

                If getStudentFromID(Convert.ToInt32(inputs(0))) Is Nothing Then Throw New InvalidInputException("The student whose ID you entered is not enrolled in the course!")

                Dim con As OleDbConnection = New OleDbConnection(connection)

                If con.State <> System.Data.ConnectionState.Open Then
                    con.Open()
                End If
                Dim command As OleDbCommand = New OleDbCommand("select count(*) from Grades where Student_ID = ? AND Course_ID = ?", con)

                Dim paramCollection As OleDbParameterCollection = command.Parameters
                paramCollection.Add(New OleDbParameter("Student_ID", inputs(0)))
                paramCollection.Add(New OleDbParameter("Course_ID", activeCourseId))
                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                Dim sql As String
                If result = 0 Then
                    sql = "INSERT INTO Grades (Grade_Score, Student_ID, Course_ID) VALUES (?, ?, ?)"
                Else
                    sql = "UPDATE Grades SET Grade_Score = ? WHERE Student_ID = ? AND Course_ID = ?"
                End If

                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("@Grade_Score", inputs(1))
                cmd.Parameters.AddWithValue("@Student_ID", inputs(0))
                cmd.Parameters.AddWithValue("@Course_ID", activeCourseId)
                cmd.ExecuteNonQuery()
            Next

        End Sub

        ' method to show passing students
        Public Function showPassingStudents() As List(Of Student)
            Dim studentList As List(Of Student) = New List(Of Student)()
            Dim studentIds As List(Of Integer) = New List(Of Integer)()

            For Each grade As Grades In getGrades()
                If grade.Score > 59 Then studentIds.Add(grade.StudentID)
            Next

            For Each Id In studentIds
                studentList.Add(getStudentFromID(Id))
            Next

            Return studentList
        End Function

        ' method to show failing students
        Public Function showFailingStudents() As List(Of Student)
            Dim studentList As List(Of Student) = New List(Of Student)()
            Dim studentIds As List(Of Integer) = New List(Of Integer)()

            For Each grade As Grades In getGrades()

                If grade.Score <= 59 Then studentIds.Add(grade.StudentID)
            Next

            For Each Id In studentIds
                studentList.Add(getStudentFromID(Id))
            Next

            Return studentList
        End Function

        ' method to get the name of the lowest scoring student
        Public Function showLowestScoringStudent() As String
            Dim lowestScoring As Student = New Student()

            For Each grade As Grades In getGrades()
                If grade.Score = showMinGrade() Then
                    lowestScoring = getStudentFromID(grade.StudentID)
                    Exit For
                End If
            Next

            Return lowestScoring.Name.ToString() & " " + lowestScoring.Surname
        End Function

        ' method to get the name of the highest scoring student
        Public Function showHighestScoringStudent() As String
            Dim highestScoring As Student = New Student()

            For Each grade As Grades In getGrades()
                If grade.Score = showMaxGrade() Then
                    highestScoring = getStudentFromID(grade.StudentID)
                    Exit For
                End If
            Next

            Return highestScoring.Name.ToString() & " " + highestScoring.Surname
        End Function


        ' method to get the minimum grade of a professor's course
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

        ' method to get the maximum grade of a professor's course

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


        ' method to get the average grade of a professor's course

        Public Function showAverage() As Double
            Dim gradeList As List(Of Integer) = getScores()

            Dim total = 0.0
            If gradeList.Count = 0 Then Return total

            For Each grade In gradeList
                total += grade
            Next

            Return total / gradeList.Count
        End Function

        'method to set the Id of the active course
        Public Sub setActiveCourseId()
            If Not Equals(ActiveCourse, Nothing) Then
                Dim con As OleDbConnection = New OleDbConnection(connection)
                If con.State <> Data.ConnectionState.Open Then
                    con.Open()
                End If

                Dim sql = "SELECT * FROM Courses WHERE Course_Name = ?"


                Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
                Dim paramCollection As OleDbParameterCollection = cmd.Parameters
                paramCollection.Add(New OleDbParameter("Course_Name", activeCourseField))
                Dim reader As OleDbDataReader = cmd.ExecuteReader()


                If reader.HasRows Then
                    While reader.Read()
                        activeCourseId = reader.GetInt32(0)
                    End While
                End If
            End If

        End Sub

        ' method to get all professor data from DB
        Public Function readProfessors() As List(Of Professor)
            Dim professors As List(Of Professor) = New List(Of Professor)()
            Dim con As OleDbConnection = New OleDbConnection(connection)

            If con.State <> Data.ConnectionState.Open Then
                con.Open()
            End If
            Dim sql = "SELECT * FROM Professors"

            Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()


            If reader.HasRows Then

                While reader.Read()
                    Dim professorId = Convert.ToInt32(reader("Professor_ID"))
                    Dim table_firstName As String = reader("First_Name").ToString()
                    Dim table_lastName As String = reader("Last_Name").ToString()
                    Dim table_username As String = reader("Username").ToString()
                    Dim table_password As String = reader("Password").ToString()

                    Dim prof As Professor = New Professor(professorId, table_firstName, table_lastName, table_username, table_password)

                    Dim professorCoursesTable As OleDbCommand = New OleDbCommand("SELECT Course_ID FROM Professors_Courses WHERE Professor_ID = ?", con)

                    Dim paramCollection As OleDbParameterCollection = professorCoursesTable.Parameters
                    paramCollection.Add(New OleDbParameter("Professor_ID", professorId))
                    Dim readerProfessorCoursesTable As OleDbDataReader = professorCoursesTable.ExecuteReader()

                    While readerProfessorCoursesTable.Read()
                        Dim table_courseID = Convert.ToInt32(readerProfessorCoursesTable("Course_ID"))

                        Dim coursesTable As OleDbCommand = New OleDbCommand("SELECT Course_Name FROM Courses WHERE Course_ID = ?", con)
                        Dim coursesParamCollection As OleDbParameterCollection = coursesTable.Parameters
                        coursesParamCollection.Add(New OleDbParameter("Course_ID", table_courseID))
                        Dim readerCoursesTable As OleDbDataReader = coursesTable.ExecuteReader()
                        readerCoursesTable.Read()
                        prof.Courses.Add(readerCoursesTable(CStr("Course_Name")).ToString())
                        readerCoursesTable.Close()
                    End While
                    readerProfessorCoursesTable.Close()
                    professors.Add(prof)
                End While
            End If

            reader.Close()
            con.Close()
            Return professors
        End Function

        ' method to get a string representation of Professor
        Public Overrides Function ToString() As String
            If Courses Is Nothing Then
                Return Me.Name.ToString() & "," + Me.Surname.ToString() & "," + Me.Username.ToString() & "," + Me.Password
            Else

                Dim result As String = Me.Name.ToString() & "," + Me.Surname.ToString() & "," + Me.Username.ToString() & "," + Me.Password
                For i = 0 To Courses.Count - 1
                    result += "," & Courses(i)
                Next
                Return result
            End If
        End Function
    End Class
End Namespace
