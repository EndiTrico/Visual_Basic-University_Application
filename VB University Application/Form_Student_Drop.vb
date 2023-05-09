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

Partial Public Class Form_Student_Drop
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
        Dim student As Student = New Student()

        For Each stud As String In student.Courses
            comboBoxDrop.Items.Add(stud)
        Next
    End Sub

    Public Sub New(ByVal studentID As Integer, ByVal name As String, ByVal surname As String, ByVal username As String, ByVal password As String, ByVal major As String, ByVal courses As List(Of String))
        InitializeComponent()
        Me.StudentID = studentID
        Me.Name = name
        Me.Surname = surname
        Me.Username = username
        Me.Password = password
        Me.Major = major
        Me.Courses = courses

        For Each s As String In New Student(studentID, name, surname, username, password, major, courses).Courses
            comboBoxDrop.Items.Add(s)
        Next
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Dim student As Form_Student = New Form_Student(StudentID, Name, Surname, Username, Password, Major, Courses)
        Me.Hide()
        student.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDrop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDrop.Click
        If comboBoxDrop.SelectedIndex = -1 Then
            MessageBox.Show("You Need to Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            MessageBox.Show("The Course is Dropped Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim student = New Student(StudentID, Name, Surname, Username, Password, Major)
            student.drop(comboBoxDrop.Text, StudentID)
            Dim form_Student As Form_Student = New Form_Student(Username, Password)
            Me.Close()
            form_Student.Show()
        End If
    End Sub
End Class
