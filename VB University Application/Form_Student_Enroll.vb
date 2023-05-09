Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports University_Application

Public Class Form_Student_Enroll
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
            Return StudentID
        End Get
        Set(ByVal value As Integer)
            StudentID = value
        End Set
    End Property

    Public Overloads Property Name As String
        Get
            Return Name
        End Get
        Set(ByVal value As String)
            Name = value
        End Set
    End Property

    Public Property Surname As String
        Get
            Return Surname
        End Get
        Set(ByVal value As String)
            surname = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return Username
        End Get
        Set(ByVal value As String)
            username = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            password = value
        End Set
    End Property

    Public Property Major As String
        Get
            Return Major
        End Get
        Set(ByVal value As String)
            major = value
        End Set
    End Property

    Public Property Courses As List(Of String)
        Get
            Return Courses
        End Get
        Set(ByVal value As List(Of String))
            courses = value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()

        For Each s As String In New Student().allCoursesExcludingStudentCourses()
            comboBoxEnroll.Items.Add(s)
        Next
    End Sub

    Public Sub New(ByVal studentID As Integer, ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String, ByVal major As String, ByVal courses As List(Of String))
        InitializeComponent()
        Me.StudentID = studentID
        Me.Name = name
        Me.surname = surname
        Me.username = username
        Me.password = password
        Me.major = major
        Me.courses = courses

        For Each s As String In New Student(studentID, name, surname, username, password, major, courses).allCoursesExcludingStudentCourses()
            comboBoxEnroll.Items.Add(s)
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim student As Form_Student = New Form_Student(StudentID, Name, surname, username, password, major, courses)
        Me.Hide()
        student.Show()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
        If comboBoxEnroll.SelectedIndex = -1 Then
            MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim student = New Student(StudentID, Name, Surname, Username, Password, Major)
            student.enroll(comboBoxEnroll.Text, StudentID)
            MessageBox.Show("The Course is Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim form_Student As Form_Student = New Form_Student(username, password)
            Me.Close()
            form_Student.Show()
        End If
    End Sub

    Private Sub Form_Student_Enroll_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub
End Class
