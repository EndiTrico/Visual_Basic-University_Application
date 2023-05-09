<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Role
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
        Me.lblSelectRole = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.comboBoxRole = New System.Windows.Forms.ComboBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblEmpire = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelectRole
        '
        Me.lblSelectRole.AutoSize = True
        Me.lblSelectRole.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectRole.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblSelectRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblSelectRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblSelectRole.Location = New System.Drawing.Point(12, 129)
        Me.lblSelectRole.Name = "lblSelectRole"
        Me.lblSelectRole.Size = New System.Drawing.Size(131, 24)
        Me.lblSelectRole.TabIndex = 7
        Me.lblSelectRole.Text = "Select a Role: "
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinue.Font = New System.Drawing.Font("Corbel", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnContinue.ForeColor = System.Drawing.Color.Snow
        Me.btnContinue.Location = New System.Drawing.Point(317, 160)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(160, 38)
        Me.btnContinue.TabIndex = 8
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'comboBoxRole
        '
        Me.comboBoxRole.BackColor = System.Drawing.Color.Snow
        Me.comboBoxRole.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboBoxRole.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxRole.FormattingEnabled = True
        Me.comboBoxRole.Items.AddRange(New Object() {"Admin", "Professor", "Student"})
        Me.comboBoxRole.Location = New System.Drawing.Point(149, 127)
        Me.comboBoxRole.Name = "comboBoxRole"
        Me.comboBoxRole.Size = New System.Drawing.Size(133, 26)
        Me.comboBoxRole.TabIndex = 3
        Me.comboBoxRole.Text = "Choose a Role"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Corbel", 24.75!, System.Drawing.FontStyle.Bold)
        Me.lblWelcome.ForeColor = System.Drawing.Color.Snow
        Me.lblWelcome.Location = New System.Drawing.Point(7, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(280, 40)
        Me.lblWelcome.TabIndex = 10
        Me.lblWelcome.Text = "Welcome to SUNY"
        '
        'lblEmpire
        '
        Me.lblEmpire.AutoSize = True
        Me.lblEmpire.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpire.Font = New System.Drawing.Font("Corbel", 24.75!, System.Drawing.FontStyle.Bold)
        Me.lblEmpire.ForeColor = System.Drawing.Color.Snow
        Me.lblEmpire.Location = New System.Drawing.Point(7, 49)
        Me.lblEmpire.Name = "lblEmpire"
        Me.lblEmpire.Size = New System.Drawing.Size(315, 40)
        Me.lblEmpire.TabIndex = 11
        Me.lblEmpire.Text = "Empire State College"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnExit)
        Me.panel1.Controls.Add(Me.lblEmpire)
        Me.panel1.Controls.Add(Me.lblWelcome)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(517, 93)
        Me.panel1.TabIndex = 12
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
        Me.btnExit.Location = New System.Drawing.Point(477, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pictureBoxLogo
        '
        Me.pictureBoxLogo.Image = Global.VB_University_Application.My.Resources.Resources.Empire_State_College_logo1
        Me.pictureBoxLogo.Location = New System.Drawing.Point(317, 0)
        Me.pictureBoxLogo.Name = "pictureBoxLogo"
        Me.pictureBoxLogo.Size = New System.Drawing.Size(160, 113)
        Me.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxLogo.TabIndex = 9
        Me.pictureBoxLogo.TabStop = False
        '
        'Form_Role
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(516, 226)
        Me.Controls.Add(Me.pictureBoxLogo)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.comboBoxRole)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblSelectRole)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(276, 91)
        Me.Name = "Form_Role"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Select_Role"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectRole As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents comboBoxRole As ComboBox
    Friend WithEvents pictureBoxLogo As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblEmpire As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents btnExit As Button

End Class
