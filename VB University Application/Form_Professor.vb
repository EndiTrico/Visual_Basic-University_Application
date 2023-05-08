Public Class Form_Professor
    Private Sub Form_Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = $"Welcome Professor {Professor.getRecentProfessor().Name} !"

        For Each course As String In Professor.getRecentProfessor().Courses
            comboBox_Course.Items.Add(course)
        Next
    End Sub

    Private Sub button_Grades_Click(sender As Object, e As EventArgs) Handles button_Grades.Click
        If comboBox_Course.SelectedIndex <> -1 Then
            Dim form As Form_Professor_AddGrades = New Form_Professor_AddGrades()
            Me.Hide()
            form.Show()
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_Students_Click(sender As Object, e As EventArgs) Handles button_Students.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

            If students.Count = 0 Then
                MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            For Each student As Student In students
                RichTextBox1.AppendText(student.Name & " " + student.Surname & vbLf)
            Next
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_PassingStudents_Click(sender As Object, e As EventArgs) Handles button_PassingStudents.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim students As List(Of Student) = Professor.getRecentProfessor().showPassingStudents()

            If students.Count = 0 Then
                MessageBox.Show("There are no passing students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            For Each student As Student In students
                RichTextBox1.AppendText(student.Name & " " + student.Surname & vbLf)
            Next
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_Average_Click(sender As Object, e As EventArgs) Handles button_Average.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim scores As List(Of Double) = Professor.getRecentProfessor().getScores()
            Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

            If scores.Count = 0 Then
                MessageBox.Show("There are no grades in the system for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            ElseIf students.Count = 0 Then
                MessageBox.Show("There are no students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            RichTextBox1.AppendText($"The course score average is {Professor.getRecentProfessor().showAverage()}.")
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_HighestScore_Click(sender As Object, e As EventArgs) Handles button_HighestScore.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim scores As List(Of Double) = Professor.getRecentProfessor().getScores()
            Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

            If scores.Count = 0 Then
                MessageBox.Show("There are no grades in the system for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            ElseIf students.Count = 0 Then
                MessageBox.Show("There are no students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            RichTextBox1.Text = $"The student with the highest score is {Professor.getRecentProfessor().showHighestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().showMaxGrade()}."
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_LowestScore_Click(sender As Object, e As EventArgs) Handles button_LowestScore.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim scores As List(Of Double) = Professor.getRecentProfessor().getScores()
            Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

            If scores.Count = 0 Then
                MessageBox.Show("There are no grades in the system for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            ElseIf students.Count = 0 Then
                MessageBox.Show("There are no students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            RichTextBox1.Text = $"The student with the lowest score is {Professor.getRecentProfessor().showLowestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().showMinGrade()}."
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub button_FailingStudents_Click(sender As Object, e As EventArgs) Handles button_FailingStudents.Click
        RichTextBox1.Clear()

        If comboBox_Course.SelectedIndex <> -1 Then
            Dim scores As List(Of Double) = Professor.getRecentProfessor().getScores()
            Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

            If scores.Count = 0 Then
                MessageBox.Show("There are no grades in the system for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            ElseIf students.Count = 0 Then
                MessageBox.Show("There are no students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return
            End If

            RichTextBox1.Text = $"The student with the lowest score is {Professor.getRecentProfessor().showLowestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().showMinGrade()}."
        Else
            MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Professor.LoggedProfessors.RemoveAt(Professor.LoggedProfessors.Count - 1)
        Me.Close()
    End Sub

    Private Sub button_Back_Click(sender As Object, e As EventArgs) Handles button_Back.Click
        Dim role As Form_LogIn = New Form_LogIn()
        Me.Hide()
        role.Show()
    End Sub

    Private Sub comboBox_Course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBox_Course.SelectedIndexChanged
        Professor.getRecentProfessor().ActiveCourse = CStr(comboBox_Course.SelectedItem)
    End Sub
End Class