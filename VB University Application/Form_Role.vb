Public Class Form_Role
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If comboBoxRole.SelectedIndex = -1 Then
            MessageBox.Show("Select a Role!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim formLog As Form_Login = New Form_Login(comboBoxRole.SelectedIndex)
            Hide()
            formLog.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class