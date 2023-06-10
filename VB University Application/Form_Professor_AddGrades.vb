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
        If comboBoxID.SelectedIndex = -1 Or txtBoxGrade.TextLength = 0 Then
            MessageBox.Show("Missing Input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim data(1) As String
            data(0) = CInt(comboBoxID.Text)
            data(1) = CDec(txtBoxGrade.Text)

            If data(1) >= 0 And data(1) <= 100 Then
                Try
                    Professor.getRecentProfessor().AddGrades(data)
                    MessageBox.Show("Grade entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    Form_Welcome.CopyDatabaseToMainFolder()
                Catch ex As InvalidInputException
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End Try
            Else
                MessageBox.Show("The grade score must be between 0 and 100!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

        End If
    End Sub

    Private Sub Form_Professor_AddGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim students As List(Of Student) = Professor.getRecentProfessor().getStudents()

        If students.Count = 0 Then
            MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        dgvOutput.ColumnCount = 3

        dgvOutput.Columns(0).HeaderText = "ID"
        dgvOutput.Columns(1).HeaderText = "First Name"
        dgvOutput.Columns(2).HeaderText = "Last Name"

        For Each row As Student In students
            dgvOutput.Rows.Add(row.Id, row.Name, row.Surname)
            comboBoxID.Items.Add(row.Id)
        Next

        dgvOutput.AutoResizeColumns()
    End Sub
End Class