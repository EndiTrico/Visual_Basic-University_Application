Imports VB_University_Application.University_Application

Public Class Form_Professor_AddGrades
    Private Sub buttonExit_Click(sender As Object, e As EventArgs) Handles buttonExit.Click
        Professor.LoggedProfessors.RemoveAt(Professor.LoggedProfessors.Count - 1)
        Me.Close()
    End Sub

    Private Sub button_Back_Click(sender As Object, e As EventArgs) Handles button_Back.Click
        Dim prof As Form_Professor = New Form_Professor()
        Me.Hide()
        prof.Show()
    End Sub

    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        If textBox_Input.TextLength = 0 Then
            MessageBox.Show("Missing Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim data As String() = textBox_Input.Text.Split(vbLf)

            Try
                Professor.getRecentProfessor().AddGrades(data)
                MessageBox.Show("Grades entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Catch ex As InvalidInputException
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End If
    End Sub
End Class