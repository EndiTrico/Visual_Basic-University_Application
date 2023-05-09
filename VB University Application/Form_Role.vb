Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports University_Application

Partial Public Class Form_Role
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnContinue_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnContinue.Click
        If comboBoxRole.SelectedIndex = -1 Then
            MessageBox.Show("Select a Role!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Dim formLog As Form_Login = New Form_Login(comboBoxRole.SelectedIndex)
            Me.Hide()
            formLog.Show()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class