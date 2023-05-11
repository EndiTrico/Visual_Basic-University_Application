<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Splash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.pictureBoxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblVersion.Location = New System.Drawing.Point(-1, 268)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(621, 28)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timer1
        '
        Me.timer1.Interval = 700
        '
        'progressBar1
        '
        Me.progressBar1.ForeColor = System.Drawing.Color.Red
        Me.progressBar1.Location = New System.Drawing.Point(-1, 311)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(621, 23)
        Me.progressBar1.TabIndex = 3
        '
        'pictureBoxLogo
        '
        Me.pictureBoxLogo.Image = Global.VB_University_Application.My.Resources.Resources.Empire_State_College_White_Logo
        Me.pictureBoxLogo.Location = New System.Drawing.Point(-3, -52)
        Me.pictureBoxLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pictureBoxLogo.Name = "pictureBoxLogo"
        Me.pictureBoxLogo.Size = New System.Drawing.Size(623, 398)
        Me.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBoxLogo.TabIndex = 4
        Me.pictureBoxLogo.TabStop = False
        '
        'Form_Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(621, 336)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.pictureBoxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Splash"
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents timer1 As Timer
    Friend WithEvents progressBar1 As ProgressBar
    Friend WithEvents pictureBoxLogo As PictureBox
End Class
