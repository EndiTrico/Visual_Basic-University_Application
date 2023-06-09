Public Class Form_Professor_AddGrades

    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Professor.LoggedProfessors.RemoveAt(Professor.LoggedProfessors.Count - 1)
        Me.Close()
    End Sub

    Private Sub button_Back_Click(sender As Object, e As EventArgs) Handles button_Back.Click
        Dim prof As New Form_Professor()
        Me.Hide()
        prof.Show()
    End Sub

    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        If txtBoxStudentID.TextLength = 0 Or txtBoxGrade.TextLength = 0 Then
            MessageBox.Show("Missing Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim data(1) As String
            data(0) = CInt(txtBoxStudentID.Text)
            data(1) = CDec(txtBoxGrade.Text)

            If data(1) >= 0 And data(1) <= 100 Then
                Try
                    Professor.getRecentProfessor().AddGrades(data)
                    MessageBox.Show("Grades entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As InvalidInputException
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            Else
                MessageBox.Show("The grade score must be between 0 and 100!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

        End If
    End Sub

    Private Sub Form_Professor_AddGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listBoxStudentNames.Items.Clear()

        Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

        If students.Count = 0 Then
            MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        For Each student As Student In students
            listBoxStudentNames.Items.Add(CStr(student.Id) + " " + student.Name & " " + student.Surname & vbLf)
        Next
    End Sub
End Class