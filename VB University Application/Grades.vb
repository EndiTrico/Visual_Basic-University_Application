Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Grades
    Private connection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database_University.mdb"
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

    Public Function readGrades() As List(Of Grades)
        Dim list As List(Of Grades) = New List(Of Grades)()
        Dim con As OleDbConnection = New OleDbConnection(connection)

        If con.State <> System.Data.ConnectionState.Open Then
            con.Open()
        End If

        Dim sql As String = "SELECT * FROM Grades"
        Dim cmd As OleDbCommand = New OleDbCommand(sql, con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then

            While reader.Read()
                Dim grade As Grades = New Grades(Convert.ToInt32(reader("Grade_ID")), Convert.ToInt32(reader("Course_ID")), Convert.ToInt32(reader("Student_ID")), Convert.ToInt32(reader("Grade_Score")))
                list.Add(grade)
            End While
        End If

        reader.Close()
        Return list
    End Function

    Public Function readGradesForAStudent(ByVal studentID As Integer) As List(Of Grades)
        Dim list As List(Of Grades) = New List(Of Grades)()
        Dim con As OleDbConnection = New OleDbConnection(connection)

        If con.State <> System.Data.ConnectionState.Open Then
            con.Open()
        End If

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Grades WHERE Student_ID = @ID", con)
        cmd.Parameters.AddWithValue("@ID", studentID)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        If reader.HasRows Then

            While reader.Read()
                Dim grade As Grades = New Grades(Convert.ToInt32(reader("Grade_ID")), Convert.ToInt32(reader("Course_ID")), Convert.ToInt32(reader("Student_ID")), Convert.ToInt32(reader("Grade_Score")))
                list.Add(grade)
            End While
        End If

        reader.Close()
        Return list
    End Function

    Public Overrides Function ToString() As String
        Return Me.GradeId & "," & Me.CourseId & ", " & Me.Studentid & ", " & Me.Score
    End Function
End Class
