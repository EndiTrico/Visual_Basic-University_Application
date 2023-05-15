Public Class Form_Admin
    Inherits Form

    Private admin As Admin

    Public Sub New()
        InitializeComponent()
        admin = New Admin()
    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim role As New Form_Role()
        Hide()
        role.Show()
    End Sub

    Private Sub btnAddProfessor_Click(sender As Object, e As EventArgs) Handles btnAddProfessor.Click
        Dim child1 As New Form_Admin_Add(1, admin)
        Hide()
        child1.Show()
    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        Dim child1 As New Form_Admin_Add(2, admin)
        Hide()
        child1.Show()
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim child1 As New Form_Admin_Add(3, admin)
        Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveProfessor_Click(sender As Object, e As EventArgs) Handles btnRemoveProfessor.Click
        Dim child1 As New Form_Admin_Remove(4, admin)
        Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveStudent_Click(sender As Object, e As EventArgs) Handles btnRemoveStudent.Click
        Dim child1 As New Form_Admin_Remove(5, admin)
        Hide()
        child1.Show()
    End Sub

    Private Sub btnRemoveCourse_Click(sender As Object, e As EventArgs) Handles btnRemoveCourse.Click
        Dim child1 As New Form_Admin_Remove(6, admin)
        Hide()
        child1.Show()
    End Sub
End Class
