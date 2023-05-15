Imports VB_University_Application.University_Application

Public Class Form_Admin_Add
    Inherits Form

    Private ReadOnly admin As Admin
    Private ReadOnly index As Integer

    Public Sub New(index As Integer, ByRef admin As Admin)
        InitializeComponent()
        Me.admin = admin
        Me.index = index

        If index = 1 Then
            lblWelcome.Text = "Add Professor"
            label6.Hide()
            comboBox1.Hide()
            lblFirstName.Text = "First Name:"
            lblLast_Name.Text = "Last Name:"
            lbl3.Text = "Username:"
            lbl4.Text = "Password:"
        End If

        If index = 2 Then
            lblWelcome.Text = "Add Student"
            lblFirstName.Text = "First Name:"
            lblLast_Name.Text = "Last Name:"
            lbl3.Text = "Username:"
            lbl4.Text = "Password:"
            label6.Text = "Major:"
            comboBox1.Text = "Select a Major"
        End If

        If index = 3 Then
            lblWelcome.Text = "Add Course"
            lblFirstName.Text = "Course Name:"
            lblLast_Name.Text = "Credits:"
            lbl3.Text = "Hours:"
            lbl4.Hide()
            label6.Text = "Professor:"
            textBox4.Hide()
            comboBox1.Items.Clear()
            comboBox1.Text = "Select a Professor"

            For i As Integer = 0 To admin.professorList.Count - 1
                comboBox1.Items.Add(admin.professorList.ElementAt(i).Id & " " + admin.professorList.ElementAt(i).Username)
            Next
        End If
    End Sub

    Public Sub addProfessor()
        Dim professor As New Professor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text)
        admin.addProfessor(professor)
    End Sub

    Public Sub addStudent()
        Dim student As New Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.SelectedItem.ToString())
        admin.addStudent(student)
    End Sub

    Public Sub addCourse()
        Dim course As New Courses(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))
        admin.addCourse(course, Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(" "c)(0)))
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If index = 1 Then
            Dim indexProfessor = admin.professorList.Count
            If textBox1.Text = "" OrElse textBox2.Text = "" OrElse textBox3.Text = "" OrElse textBox4.Text = "" Then
                MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                addProfessor()
                If admin.professorList.Count = indexProfessor + 1 Then
                    MessageBox.Show("Professor Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Dim admin_Form As New Form_Admin()
                    Close()
                    admin_Form.Show()
                End If
            End If
        End If


        If index = 2 Then
            Dim indexStudent = admin.studentList.Count
            If textBox1.Text = "" OrElse textBox2.Text = "" OrElse textBox3.Text = "" OrElse textBox4.Text = "" OrElse comboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                addStudent()
                If admin.studentList.Count = indexStudent + 1 Then
                    MessageBox.Show("Student Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Dim admin_form As New Form_Admin()
                    Close()
                    admin_form.Show()
                End If
            End If
        End If

        If index = 3 Then
            Dim indexNumber = admin.coursesList.Count
            If textBox1.Text = "" OrElse textBox2.Text = "" OrElse textBox3.Text = "" OrElse comboBox1.SelectedItem Is Nothing Then
                MessageBox.Show("Enter All Data!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                addCourse()
                If admin.coursesList.Count = indexNumber + 1 Then
                    MessageBox.Show("Course Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Dim admin_form As New Form_Admin()
                    Close()
                    admin_form.Show()
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim admin As New Form_Admin()
        Hide()
        admin.Show()
    End Sub

End Class