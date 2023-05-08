<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Professor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.button_Average = New System.Windows.Forms.Button()
        Me.button_HighestScore = New System.Windows.Forms.Button()
        Me.button_Students = New System.Windows.Forms.Button()
        Me.button_LowestScore = New System.Windows.Forms.Button()
        Me.button_PassingStudents = New System.Windows.Forms.Button()
        Me.button_FailingStudents = New System.Windows.Forms.Button()
        Me.button_Grades = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comboBox_Course = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.button_Back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_Average
        '
        Me.button_Average.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Average.FlatAppearance.BorderSize = 0
        Me.button_Average.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_Average.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_Average.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Average.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_Average.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_Average.Location = New System.Drawing.Point(16, 165)
        Me.button_Average.Name = "button_Average"
        Me.button_Average.Size = New System.Drawing.Size(175, 54)
        Me.button_Average.TabIndex = 17
        Me.button_Average.Text = "4. Show course score average"
        Me.button_Average.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Average.UseVisualStyleBackColor = True
        '
        'button_HighestScore
        '
        Me.button_HighestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_HighestScore.FlatAppearance.BorderSize = 0
        Me.button_HighestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_HighestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_HighestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_HighestScore.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_HighestScore.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_HighestScore.Location = New System.Drawing.Point(18, 215)
        Me.button_HighestScore.Name = "button_HighestScore"
        Me.button_HighestScore.Size = New System.Drawing.Size(173, 55)
        Me.button_HighestScore.TabIndex = 15
        Me.button_HighestScore.Text = "5. Show student with highest score"
        Me.button_HighestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_HighestScore.UseVisualStyleBackColor = True
        '
        'button_Students
        '
        Me.button_Students.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Students.FlatAppearance.BorderSize = 0
        Me.button_Students.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_Students.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_Students.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Students.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_Students.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_Students.Location = New System.Drawing.Point(16, 83)
        Me.button_Students.Name = "button_Students"
        Me.button_Students.Size = New System.Drawing.Size(152, 32)
        Me.button_Students.TabIndex = 14
        Me.button_Students.Text = "2. Show students"
        Me.button_Students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Students.UseVisualStyleBackColor = True
        '
        'button_LowestScore
        '
        Me.button_LowestScore.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_LowestScore.FlatAppearance.BorderSize = 0
        Me.button_LowestScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_LowestScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_LowestScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_LowestScore.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_LowestScore.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_LowestScore.Location = New System.Drawing.Point(18, 264)
        Me.button_LowestScore.Name = "button_LowestScore"
        Me.button_LowestScore.Size = New System.Drawing.Size(152, 49)
        Me.button_LowestScore.TabIndex = 16
        Me.button_LowestScore.Text = "6. Show student with lowest score"
        Me.button_LowestScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_LowestScore.UseVisualStyleBackColor = True
        '
        'button_PassingStudents
        '
        Me.button_PassingStudents.BackColor = System.Drawing.SystemColors.Control
        Me.button_PassingStudents.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_PassingStudents.FlatAppearance.BorderSize = 0
        Me.button_PassingStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_PassingStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_PassingStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_PassingStudents.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_PassingStudents.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_PassingStudents.Location = New System.Drawing.Point(18, 121)
        Me.button_PassingStudents.Name = "button_PassingStudents"
        Me.button_PassingStudents.Size = New System.Drawing.Size(165, 50)
        Me.button_PassingStudents.TabIndex = 18
        Me.button_PassingStudents.Text = "3. Show passing students"
        Me.button_PassingStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_PassingStudents.UseCompatibleTextRendering = True
        Me.button_PassingStudents.UseVisualStyleBackColor = False
        '
        'button_FailingStudents
        '
        Me.button_FailingStudents.BackColor = System.Drawing.SystemColors.Control
        Me.button_FailingStudents.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_FailingStudents.FlatAppearance.BorderSize = 0
        Me.button_FailingStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_FailingStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_FailingStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_FailingStudents.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_FailingStudents.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_FailingStudents.Location = New System.Drawing.Point(22, 316)
        Me.button_FailingStudents.Name = "button_FailingStudents"
        Me.button_FailingStudents.Size = New System.Drawing.Size(175, 47)
        Me.button_FailingStudents.TabIndex = 18
        Me.button_FailingStudents.Text = "7. Show failing students"
        Me.button_FailingStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_FailingStudents.UseCompatibleTextRendering = True
        Me.button_FailingStudents.UseVisualStyleBackColor = False
        '
        'button_Grades
        '
        Me.button_Grades.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Grades.FlatAppearance.BorderSize = 0
        Me.button_Grades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_Grades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_Grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Grades.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.button_Grades.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_Grades.Location = New System.Drawing.Point(18, 41)
        Me.button_Grades.Name = "button_Grades"
        Me.button_Grades.Size = New System.Drawing.Size(152, 36)
        Me.button_Grades.TabIndex = 1
        Me.button_Grades.Text = "1. Add grades"
        Me.button_Grades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_Grades.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Controls.Add(Me.comboBox_Course)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(231, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 338)
        Me.Panel2.TabIndex = 21
        '
        'comboBox_Course
        '
        Me.comboBox_Course.BackColor = System.Drawing.Color.WhiteSmoke
        Me.comboBox_Course.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.comboBox_Course.ForeColor = System.Drawing.Color.DarkBlue
        Me.comboBox_Course.FormattingEnabled = True
        Me.comboBox_Course.Location = New System.Drawing.Point(77, 21)
        Me.comboBox_Course.Name = "comboBox_Course"
        Me.comboBox_Course.Size = New System.Drawing.Size(153, 25)
        Me.comboBox_Course.TabIndex = 19
        Me.comboBox_Course.Text = "Select Course"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(25, 67)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(267, 256)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.buttonExit)
        Me.Panel1.Controls.Add(Me.button_Back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.button_Grades)
        Me.Panel1.Controls.Add(Me.button_FailingStudents)
        Me.Panel1.Controls.Add(Me.button_PassingStudents)
        Me.Panel1.Controls.Add(Me.button_LowestScore)
        Me.Panel1.Controls.Add(Me.button_Students)
        Me.Panel1.Controls.Add(Me.button_HighestScore)
        Me.Panel1.Controls.Add(Me.button_Average)
        Me.Panel1.Location = New System.Drawing.Point(25, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(537, 369)
        Me.Panel1.TabIndex = 20
        '
        'buttonExit
        '
        Me.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.FlatAppearance.BorderSize = 0
        Me.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonExit.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Bold)
        Me.buttonExit.ForeColor = System.Drawing.Color.DarkBlue
        Me.buttonExit.Location = New System.Drawing.Point(493, 3)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(42, 26)
        Me.buttonExit.TabIndex = 13
        Me.buttonExit.Text = "X"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'button_Back
        '
        Me.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Back.FlatAppearance.BorderSize = 0
        Me.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Back.Font = New System.Drawing.Font("Lucida Console", 13.0!, System.Drawing.FontStyle.Bold)
        Me.button_Back.ForeColor = System.Drawing.Color.DarkBlue
        Me.button_Back.Location = New System.Drawing.Point(3, 5)
        Me.button_Back.Name = "button_Back"
        Me.button_Back.Size = New System.Drawing.Size(33, 32)
        Me.button_Back.TabIndex = 19
        Me.button_Back.Text = "<"
        Me.button_Back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 13.0!)
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(177, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Professor   Menu"
        '
        'Form_Professor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonExit
        Me.ClientSize = New System.Drawing.Size(597, 417)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form_Professor"
        Me.Text = "Application"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Average As Button
    Friend WithEvents button_HighestScore As Button
    Friend WithEvents button_Students As Button
    Friend WithEvents button_LowestScore As Button
    Friend WithEvents button_PassingStudents As Button
    Friend WithEvents button_FailingStudents As Button
    Friend WithEvents button_Grades As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents comboBox_Course As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonExit As Button
    Friend WithEvents button_Back As Button
End Class