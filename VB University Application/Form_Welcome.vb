Imports System.IO

Public Class Form_Welcome
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_Welcome_Load(sender As Object, e As EventArgs)
        For Each ctl As Control In Me.Controls
            Dim ctlMDI As MdiClient

            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Color.WhiteSmoke
                MenuStrip1.Enabled = True
            Catch ex As InvalidCastException
                ex.ToString()
            End Try
        Next
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        CopyDatabaseToMainFolder()
        Application.[Exit]()
    End Sub

    Private Sub CopyDatabaseToMainFolder()
        Dim currentDirectory As String = Directory.GetCurrentDirectory()

        Dim databaseFilePath As String = Path.Combine(currentDirectory, "Database_University.mdb")

        Dim path1 As String = Path.Combine(currentDirectory)
        Dim path2 As String() = path1.Split("bin")

        Dim databaseFileName As String = "Database_University.mdb"
        Dim pa1 = path2(0)
        Dim pa2 = path2(1)
        Dim destinationDatabaseFilePath As String = Path.Combine(path1.Substring(0, path1.IndexOf("bin")), databaseFileName)

        File.Copy(databaseFilePath, destinationDatabaseFilePath, True)
    End Sub

    Private Sub loginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loginToolStripMenuItem.Click
        Dim child As Form_Role = New Form_Role()
        child.MdiParent = Me
        child.Show()
        child.BringToFront()
    End Sub

End Class
