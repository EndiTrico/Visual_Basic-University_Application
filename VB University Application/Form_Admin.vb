Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports University_Application

Public Class Form_Admin
    Inherits Form

    Private admin As Admin

    Public Sub New()
        InitializeComponent()
        admin = New Admin()
    End Sub

    Private Sub Form_Admin_Load(ByVal sender As Object, ByVal e As EventArgs)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Dim role As Form_Role = New Form_Role()
        Me.Hide()
        role.Show()
    End Sub

    Private Sub btnAddProfessor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddProfessor.Click
        Dim child1 As Form_Admin_Add = New Form_Admin_Add(1, admin)
        Me.Hide()
        child1.Show()
    End Sub

    Private Sub btnAddStudent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddStudent.Click
        Dim child1 As Form_Admin_Add = New Form_Admin_Add(2, admin)
        Me.Hide()
        child1.Show()
    End Sub

    Private Sub btnAddCourse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddCourse.Click
        Dim child1 As Form_Admin_Add = New Form_Admin_Add(3, admin)
        Me.Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveProfessor_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveProfessor.Click

        Dim child1 As Form_Admin_Remove = New Form_Admin_Remove(4, admin)
        Me.Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveStudent_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveStudent.Click
        Dim child1 As Form_Admin_Remove = New Form_Admin_Remove(5, admin)
        Me.Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveCourse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveCourse.Click
        Dim child1 As Form_Admin_Remove = New Form_Admin_Remove(6, admin)
        Me.Hide()
        child1.Show()
    End Sub
End Class
