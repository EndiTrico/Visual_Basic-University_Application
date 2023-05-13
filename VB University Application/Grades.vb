Imports System.Data.OleDb

Public Class Grades
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"
    Private _gradeId As Integer
    Private _courseId As Integer
    Private _studentid As Integer
    Private _score As Integer

    Public Property GradeId As Integer
        Get
            Return _gradeId
        End Get
        Set(value As Integer)
            _gradeId = value
        End Set
    End Property

    Public Property CourseId As Integer
        Get
            Return _courseId
        End Get
        Set(value As Integer)
            _courseId = value
        End Set
    End Property

    Public Property Studentid As Integer
        Get
            Return _studentid
        End Get
        Set(value As Integer)
            _studentid = value
        End Set
    End Property

    Public Property Score As Integer
        Get
            Return _score
        End Get
        Set(value As Integer)
            _score = value
        End Set
    End Property

    Public Sub New(ByVal gradeId As Integer, ByVal subjectId As Integer, ByVal studentId As Integer, ByVal score As Integer)
        _gradeId = gradeId
        _courseId = subjectId
        _studentid = studentId
        _score = score
    End Sub

    Public Sub New()
    End Sub

    ' Function to Get All Grades from the Database
    Public Function readGrades() As List(Of Grades)
        Dim allGrades As New List(Of Grades)()

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim command As New OleDbCommand("SELECT * FROM Grades", connection)

            Using reader As OleDbDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim grade As New Grades(Convert.ToInt32(reader("Grade_ID")), Convert.ToInt32(reader("Course_ID")), Convert.ToInt32(reader("Student_ID")), Convert.ToInt32(reader("Grade_Score")))
                        allGrades.Add(grade)
                    End While
                End If
            End Using
        End Using

        Return allGrades
    End Function

    ' Function to Get the Grades for a Specific Student
    Public Function readGradesForAStudent(studentID As Integer) As List(Of Grades)
        Dim gradesListForAStudent As New List(Of Grades)()

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Dim command As New OleDbCommand("SELECT * FROM Grades WHERE Student_ID = @ID", connection)
            command.Parameters.AddWithValue("@ID", studentID)

            Using reader As OleDbDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    While reader.Read()
                        Dim grade As New Grades(Convert.ToInt32(reader("Grade_ID")), Convert.ToInt32(reader("Course_ID")), Convert.ToInt32(reader("Student_ID")), Convert.ToInt32(reader("Grade_Score")))
                        gradesListForAStudent.Add(grade)
                    End While
                End If
            End Using
        End Using

        Return gradesListForAStudent
    End Function

    ' Function to Get String Representation of Grades
    Public Overrides Function ToString() As String
        Return GradeId & "," & CourseId & ", " & Studentid & ", " & Score
    End Function
End Class
