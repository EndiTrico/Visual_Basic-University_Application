Public Class Form_Admin_Remove
    Inherits Form

    Private index As Integer
    Private admin As Admin

    Public Sub New(index As Integer, ByRef admin As Admin)
        InitializeComponent()
        Me.index = index
        Me.admin = admin

        If index = 4 Then
            lblRemove.Text = "Remove Professor"
            comboBoxRemove.Text = "Select a Professor to Remove"

            For i As Integer = 0 To admin.professorList.Count - 1
                comboBoxRemove.Items.Add(admin.professorList.ElementAt(i).Name & " " + admin.professorList.ElementAt(i).Surname)
            Next
        End If

        If index = 5 Then
            lblRemove.Text = "Remove Student"
            comboBoxRemove.Text = "Select a Professor to Remove"

            For i As Integer = 0 To admin.studentList.Count - 1
                comboBoxRemove.Items.Add(admin.studentList.ElementAt(i).Name & " " + admin.studentList.ElementAt(i).Surname)
            Next
        End If

        If index = 6 Then
            lblRemove.Text = "Remove Course"
            comboBoxRemove.Text = "Select a Professor to Remove"

            For i As Integer = 0 To admin.coursesList.Count - 1
                comboBoxRemove.Items.Add(admin.coursesList.ElementAt(i).CourseName)
            Next
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If index = 4 Then

            If comboBoxRemove.SelectedItem Is Nothing Then
                MessageBox.Show("Select a Professor!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                admin.removeProfessor(admin.professorList.ElementAt(comboBoxRemove.SelectedIndex))
                MessageBox.Show("Professor Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim admin_Form As Form_Admin = New Form_Admin()
                Close()
                admin_Form.Show()
            End If
        End If

        If index = 5 Then

            If comboBoxRemove.SelectedItem Is Nothing Then
                MessageBox.Show("Select a Student!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Else
                admin.removeStudent(admin.studentList.ElementAt(comboBoxRemove.SelectedIndex))
                MessageBox.Show("Student Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim admin_Form As Form_Admin = New Form_Admin()
                Close()
                admin_Form.Show()
            End If
        End If

        If index = 6 Then

            If comboBoxRemove.SelectedItem Is Nothing Then
                MessageBox.Show("Select a Course!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                admin.removeCourse(admin.coursesList.ElementAt(comboBoxRemove.SelectedIndex))
                MessageBox.Show("Course Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Dim admin_Form As Form_Admin = New Form_Admin()
                Close()
                admin_Form.Show()
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim admin As Form_Admin = New Form_Admin()
        Hide()
        admin.Show()
    End Sub
End Class
