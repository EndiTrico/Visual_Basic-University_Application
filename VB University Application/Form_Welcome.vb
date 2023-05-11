Public Class Form_Welcome
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_Welcome_Load(ByVal sender As Object, ByVal e As EventArgs)
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

    Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
        Application.[Exit]()
    End Sub

    Private Sub loginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loginToolStripMenuItem.Click
        Dim child As Form_Role = New Form_Role()
        child.MdiParent = Me
        child.Show()
        child.BringToFront()
    End Sub

End Class
