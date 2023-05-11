Public Class Form_Splash
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
        progressBar1.Increment(10)

        If progressBar1.Value = 100 Then
            timer1.[Stop]()
            Dim welcome As Form_Welcome = New Form_Welcome()
            Me.Hide()
            welcome.Show()
        End If
    End Sub

    Private Sub Form_Splash_Load(ByVal sender As Object, ByVal e As EventArgs)
        timer1.Start()
    End Sub
End Class
