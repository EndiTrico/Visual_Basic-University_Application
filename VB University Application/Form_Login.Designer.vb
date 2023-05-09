<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtBoxUsername = New System.Windows.Forms.TextBox()
        Me.checkBoxShow = New System.Windows.Forms.CheckBox()
        Me.txtBoxPassword = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.pictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogIn.ForeColor = System.Drawing.Color.Snow
        Me.btnLogIn.Location = New System.Drawing.Point(144, 146)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(126, 40)
        Me.btnLogIn.TabIndex = 6
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(10, 66)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(101, 23)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(15, 104)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(96, 23)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password:"
        '
        'txtBoxUsername
        '
        Me.txtBoxUsername.AllowDrop = True
        Me.txtBoxUsername.BackColor = System.Drawing.Color.White
        Me.txtBoxUsername.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBoxUsername.Location = New System.Drawing.Point(117, 66)
        Me.txtBoxUsername.Name = "txtBoxUsername"
        Me.txtBoxUsername.Size = New System.Drawing.Size(153, 23)
        Me.txtBoxUsername.TabIndex = 10
        '
        'checkBoxShow
        '
        Me.checkBoxShow.AutoSize = True
        Me.checkBoxShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBoxShow.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.checkBoxShow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.checkBoxShow.Location = New System.Drawing.Point(276, 105)
        Me.checkBoxShow.Name = "checkBoxShow"
        Me.checkBoxShow.Size = New System.Drawing.Size(61, 23)
        Me.checkBoxShow.TabIndex = 15
        Me.checkBoxShow.Text = "Show"
        Me.checkBoxShow.UseVisualStyleBackColor = True
        '
        'txtBoxPassword
        '
        Me.txtBoxPassword.AllowDrop = True
        Me.txtBoxPassword.BackColor = System.Drawing.Color.White
        Me.txtBoxPassword.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtBoxPassword.Location = New System.Drawing.Point(117, 105)
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.Size = New System.Drawing.Size(153, 23)
        Me.txtBoxPassword.TabIndex = 16
        Me.txtBoxPassword.UseSystemPasswordChar = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblRole
        '
        Me.lblRole.BackColor = System.Drawing.Color.Transparent
        Me.lblRole.Font = New System.Drawing.Font("Corbel", 24.75!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(40, -2)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(297, 40)
        Me.lblRole.TabIndex = 21
        Me.lblRole.Text = "Role"
        Me.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBoxLogo
        '
        Me.pictureBoxLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pictureBoxLogo.Image = Global.VB_University_Application.My.Resources.Resources.Empire_State_College_White_Logo
        Me.pictureBoxLogo.Location = New System.Drawing.Point(-1, 3)
        Me.pictureBoxLogo.Name = "pictureBoxLogo"
        Me.pictureBoxLogo.Size = New System.Drawing.Size(254, 195)
        Me.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBoxLogo.TabIndex = 13
        Me.pictureBoxLogo.TabStop = False
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.pictureBoxLogo)
        Me.panel1.Location = New System.Drawing.Point(343, -2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(256, 237)
        Me.panel1.TabIndex = 22
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(213, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form_Login
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(597, 198)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.checkBoxShow)
        Me.Controls.Add(Me.txtBoxUsername)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University System"
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtBoxUsername As TextBox
    Friend WithEvents checkBoxShow As CheckBox
    Friend WithEvents txtBoxPassword As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblRole As Label
    Friend WithEvents pictureBoxLogo As PictureBox
    Friend WithEvents panel1 As Panel
    Friend WithEvents btnExit As Button
End Class
