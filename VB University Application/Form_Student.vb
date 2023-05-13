Public Class Form_Student
    Inherits Form

    Private _studentID As Integer
    Private _name As String
    Private _surname As String
    Private _username As String
    Private _password As String
    Private _major As String
    Private _courses As List(Of String)

    Public Property StudentID As Integer
        Get
            Return _studentID
        End Get
        Set(value As Integer)
            _studentID = value
        End Set
    End Property

    Public Overloads Property Name As String
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

    Public Property Major As String
        Get
            Return _major
        End Get
        Set(value As String)
            _major = value
        End Set
    End Property

    Public Property Courses As List(Of String)
        Get
            Return _courses
        End Get
        Set(value As List(Of String))
            _courses = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(username As String, password As String)
        InitializeComponent()
        Dim student As New Student(username, password)
        Me.Name = student.Name
        Me.Surname = student.Surname
        Me.Username = student.Username
        Me.Password = student.Password
        Me.StudentID = student.Id
        Me.Major = student.Major
        Me.Courses = student.Courses
        lblName.Text = "Welcome " & Name & " " + Surname
    End Sub

    Public Sub New(studentID As Integer, name As String, surname As String, username As String, password As String, major As String, courses As List(Of String))
        InitializeComponent()
        Me.Name = name
        Me.Surname = surname
        Me.Username = username
        Me.Password = password
        Me.StudentID = studentID
        Me.Major = major
        Me.Courses = courses
        lblName.Text = "Welcome " & name & " " + surname
    End Sub

    Private Sub btnEnroll_Click(sender As Object, e As EventArgs) Handles btnEnroll.Click
        Dim form As New Form_Student_Enroll(StudentID, Name, Surname, Username, Password, Major, Courses)
        Hide()
        form.Show()
    End Sub

    Private Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click
        Dim form As New Form_Student_Drop(StudentID, Name, Surname, Username, Password, Major, Courses)
        Hide()
        form.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim role As New Form_Role()
        Hide()
        role.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMyCourses_Click(sender As Object, e As EventArgs) Handles btnMyCourses.Click
        richTxtBoxResult.Clear()
        Dim myCourses As List(Of String) = New Student(StudentID, Name, Surname, Username, Password, Major, Courses).Courses

        If myCourses.Count <> 0 Then
            richTxtBoxResult.AppendText("The Courses That I Am Taking Are: " & Environment.NewLine)

            For Each courses As String In myCourses
                richTxtBoxResult.AppendText(courses & Environment.NewLine)
            Next
        Else
            MessageBox.Show("You Are Not Registered in any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnMyGrades_Click(sender As Object, e As EventArgs) Handles btnMyGrades.Click
        richTxtBoxResult.Clear()
        Dim grades As List(Of String) = New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showGrades()

        If grades.Count <> 0 Then
            richTxtBoxResult.AppendText("The Grades of My Courses Are: " & Environment.NewLine)

            For Each grade As String In grades
                richTxtBoxResult.AppendText(grade & Environment.NewLine)
            Next
        Else
            MessageBox.Show("You Do Not Have any Grade in the System!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnAllCourses_Click(sender As Object, e As EventArgs) Handles btnAllCourses.Click
        richTxtBoxResult.Clear()
        Dim allCourses As List(Of String) = New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showAllCourses()

        If allCourses.Count <> 0 Then
            richTxtBoxResult.AppendText("The Courses in the University Are: " & Environment.NewLine)

            For Each course As String In allCourses
                richTxtBoxResult.AppendText(course & Environment.NewLine)
            Next
        Else
            MessageBox.Show("The University Does Not Have any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnAllCredits_Click(sender As Object, e As EventArgs) Handles btnAllCredits.Click
        richTxtBoxResult.Clear()
        Dim allCourses As List(Of String) = New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showAllCredits()

        If allCourses.Count <> 0 Then
            richTxtBoxResult.AppendText("Credits of All the Courses are: " & Environment.NewLine)

            For Each course As String In allCourses
                richTxtBoxResult.AppendText(course & Environment.NewLine)
            Next
        Else
            MessageBox.Show("The University Does Not Have any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnMyCredits_Click(sender As Object, e As EventArgs) Handles btnMyCredits.Click
        richTxtBoxResult.Clear()
        Dim myCoursesCredits As List(Of String) = New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showStudentCredits()

        If myCoursesCredits.Count <> 0 Then
            richTxtBoxResult.AppendText("Credits of My Courses are: " & Environment.NewLine)

            For Each credit As String In myCoursesCredits
                richTxtBoxResult.AppendText(credit & Environment.NewLine)
            Next
        Else
            MessageBox.Show("The Student is Not Enrolled in any Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnMyGPA_Click(sender As Object, e As EventArgs) Handles btnMyGPA.Click
        richTxtBoxResult.Clear()

        If New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showGPA() = -1 Then
            MessageBox.Show("There is Not Any Grade to Calculate!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            richTxtBoxResult.AppendText("My GPA is: " & New Student(StudentID, Name, Surname, Username, Password, Major, Courses).showGPA() & Environment.NewLine)
        End If
    End Sub

End Class
