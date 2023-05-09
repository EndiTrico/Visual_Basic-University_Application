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

Public Class Form_Login
    Inherits Form

    Private number As Integer

    Public Sub New(ByVal number As Integer)
        Me.number = number
        InitializeComponent()
        Me.label_Role_Name()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogIn.Click
        If txtBoxPassword.TextLength = 0 OrElse txtBoxUsername.TextLength = 0 Then
            MessageBox.Show("Enter Username and Password!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else

            If number = 0 Then

                Try
                    Dim admin As Admin = New Admin()

                    If admin.isUsernameAndPasswordValid(txtBoxUsername.Text, txtBoxPassword.Text) Then
                        Dim formAdmin As Form_Admin = New Form_Admin()
                        Me.Hide()
                        formAdmin.Show()
                    End If

                Catch ex As InvalidLoginInfoException
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            ElseIf number = 1 Then

                Try
                    Dim prof As Professor = New Professor(txtBoxUsername.Text, txtBoxPassword.Text)
                    Professor.LoggedProfessors.Add(prof)
                    Dim formProf As Form_Professor = New Form_Professor()
                    Me.Hide()
                    formProf.Show()
                Catch ex As InvalidLoginInfoException
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            ElseIf number = 2 Then

                Try
                    Dim student As Student = New Student(txtBoxUsername.Text, txtBoxPassword.Text)
                    Dim formStud As Form_Student = New Form_Student(txtBoxUsername.Text, txtBoxPassword.Text)
                    Me.Hide()
                    formStud.Show()
                Catch ex As InvalidLoginInfoException
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            Else
                MessageBox.Show("Something is Wrong!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If
        End If
    End Sub

    Private Sub CheckBoxShow_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxShow.CheckedChanged
        If checkBoxShow.Checked Then
            txtBoxPassword.UseSystemPasswordChar = False
        Else
            txtBoxPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Dim role As Form_Role = New Form_Role()
        Me.Hide()
        role.Show()
    End Sub

    Private Sub label_Role_Name()
        If number = 0 Then
            lblRole.Text = "Log In as Admin"
        ElseIf number = 1 Then
            lblRole.Text = "Log In as Professor"
        ElseIf number = 2 Then
            lblRole.Text = "Log In as Student"
        Else
            lblRole.Text = "Error Message"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
