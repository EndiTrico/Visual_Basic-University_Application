<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Student
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
        Me.studentPanel = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnMyGPA = New System.Windows.Forms.Button()
        Me.btnMyCredits = New System.Windows.Forms.Button()
        Me.btnAllCredits = New System.Windows.Forms.Button()
        Me.btnAllCourses = New System.Windows.Forms.Button()
        Me.btnMyGrades = New System.Windows.Forms.Button()
        Me.btnMyCourses = New System.Windows.Forms.Button()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.btnEnroll = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.richTxtBoxResult = New System.Windows.Forms.RichTextBox()
        Me.studentPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'studentPanel
        '
        Me.studentPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.studentPanel.Controls.Add(Me.btnBack)
        Me.studentPanel.Controls.Add(Me.btnMyGPA)
        Me.studentPanel.Controls.Add(Me.btnMyCredits)
        Me.studentPanel.Controls.Add(Me.btnAllCredits)
        Me.studentPanel.Controls.Add(Me.btnAllCourses)
        Me.studentPanel.Controls.Add(Me.btnMyGrades)
        Me.studentPanel.Controls.Add(Me.btnMyCourses)
        Me.studentPanel.Controls.Add(Me.btnDrop)
        Me.studentPanel.Controls.Add(Me.btnEnroll)
        Me.studentPanel.Controls.Add(Me.lblName)
        Me.studentPanel.Location = New System.Drawing.Point(0, 0)
        Me.studentPanel.Name = "studentPanel"
        Me.studentPanel.Size = New System.Drawing.Size(400, 283)
        Me.studentPanel.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.Snow
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnMyGPA
        '
        Me.btnMyGPA.BackColor = System.Drawing.Color.Snow
        Me.btnMyGPA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyGPA.FlatAppearance.BorderSize = 0
        Me.btnMyGPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyGPA.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyGPA.ForeColor = System.Drawing.Color.Black
        Me.btnMyGPA.Location = New System.Drawing.Point(211, 203)
        Me.btnMyGPA.Name = "btnMyGPA"
        Me.btnMyGPA.Size = New System.Drawing.Size(182, 35)
        Me.btnMyGPA.TabIndex = 8
        Me.btnMyGPA.Text = "8. Show My GPA"
        Me.btnMyGPA.UseVisualStyleBackColor = False
        '
        'btnMyCredits
        '
        Me.btnMyCredits.BackColor = System.Drawing.Color.Snow
        Me.btnMyCredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyCredits.FlatAppearance.BorderSize = 0
        Me.btnMyCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCredits.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyCredits.ForeColor = System.Drawing.Color.Black
        Me.btnMyCredits.Location = New System.Drawing.Point(211, 159)
        Me.btnMyCredits.Name = "btnMyCredits"
        Me.btnMyCredits.Size = New System.Drawing.Size(182, 35)
        Me.btnMyCredits.TabIndex = 7
        Me.btnMyCredits.Text = "7. Show Credits of My Courses"
        Me.btnMyCredits.UseVisualStyleBackColor = False
        '
        'btnAllCredits
        '
        Me.btnAllCredits.BackColor = System.Drawing.Color.Snow
        Me.btnAllCredits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllCredits.FlatAppearance.BorderSize = 0
        Me.btnAllCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllCredits.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAllCredits.ForeColor = System.Drawing.Color.Black
        Me.btnAllCredits.Location = New System.Drawing.Point(211, 114)
        Me.btnAllCredits.Name = "btnAllCredits"
        Me.btnAllCredits.Size = New System.Drawing.Size(182, 35)
        Me.btnAllCredits.TabIndex = 6
        Me.btnAllCredits.Text = "6. Show Credits of All Courses"
        Me.btnAllCredits.UseVisualStyleBackColor = False
        '
        'btnAllCourses
        '
        Me.btnAllCourses.BackColor = System.Drawing.Color.Snow
        Me.btnAllCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAllCourses.FlatAppearance.BorderSize = 0
        Me.btnAllCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllCourses.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAllCourses.ForeColor = System.Drawing.Color.Black
        Me.btnAllCourses.Location = New System.Drawing.Point(211, 72)
        Me.btnAllCourses.Name = "btnAllCourses"
        Me.btnAllCourses.Size = New System.Drawing.Size(182, 35)
        Me.btnAllCourses.TabIndex = 5
        Me.btnAllCourses.Text = "5. Show All Courses"
        Me.btnAllCourses.UseVisualStyleBackColor = False
        '
        'btnMyGrades
        '
        Me.btnMyGrades.BackColor = System.Drawing.Color.Snow
        Me.btnMyGrades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyGrades.FlatAppearance.BorderSize = 0
        Me.btnMyGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyGrades.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyGrades.ForeColor = System.Drawing.Color.Black
        Me.btnMyGrades.Location = New System.Drawing.Point(10, 203)
        Me.btnMyGrades.Name = "btnMyGrades"
        Me.btnMyGrades.Size = New System.Drawing.Size(182, 35)
        Me.btnMyGrades.TabIndex = 4
        Me.btnMyGrades.Text = "4. Show My Grades"
        Me.btnMyGrades.UseVisualStyleBackColor = False
        '
        'btnMyCourses
        '
        Me.btnMyCourses.BackColor = System.Drawing.Color.Snow
        Me.btnMyCourses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyCourses.FlatAppearance.BorderSize = 0
        Me.btnMyCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyCourses.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyCourses.ForeColor = System.Drawing.Color.Black
        Me.btnMyCourses.Location = New System.Drawing.Point(10, 159)
        Me.btnMyCourses.Name = "btnMyCourses"
        Me.btnMyCourses.Size = New System.Drawing.Size(182, 35)
        Me.btnMyCourses.TabIndex = 3
        Me.btnMyCourses.Text = "3. Show My Courses"
        Me.btnMyCourses.UseVisualStyleBackColor = False
        '
        'btnDrop
        '
        Me.btnDrop.BackColor = System.Drawing.Color.Snow
        Me.btnDrop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDrop.FlatAppearance.BorderSize = 0
        Me.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrop.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDrop.ForeColor = System.Drawing.Color.Black
        Me.btnDrop.Location = New System.Drawing.Point(10, 114)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(182, 35)
        Me.btnDrop.TabIndex = 2
        Me.btnDrop.Text = "2. Drop a Class"
        Me.btnDrop.UseVisualStyleBackColor = False
        '
        'btnEnroll
        '
        Me.btnEnroll.BackColor = System.Drawing.Color.Snow
        Me.btnEnroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnroll.FlatAppearance.BorderSize = 0
        Me.btnEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnroll.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnroll.ForeColor = System.Drawing.Color.Black
        Me.btnEnroll.Location = New System.Drawing.Point(10, 72)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(182, 35)
        Me.btnEnroll.TabIndex = 1
        Me.btnEnroll.Text = "1. Enroll in a Class"
        Me.btnEnroll.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Corbel", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.Snow
        Me.lblName.Location = New System.Drawing.Point(46, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(351, 33)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Student Menu"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblResult.Font = New System.Drawing.Font("Corbel", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblResult.Location = New System.Drawing.Point(524, 45)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(71, 24)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(665, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'richTxtBoxResult
        '
        Me.richTxtBoxResult.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.richTxtBoxResult.Location = New System.Drawing.Point(417, 72)
        Me.richTxtBoxResult.Name = "richTxtBoxResult"
        Me.richTxtBoxResult.Size = New System.Drawing.Size(276, 169)
        Me.richTxtBoxResult.TabIndex = 12
        Me.richTxtBoxResult.Text = ""
        '
        'Form_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(705, 280)
        Me.Controls.Add(Me.richTxtBoxResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.studentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.studentPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents studentPanel As Panel
    Friend WithEvents btnMyGPA As Button
    Friend WithEvents btnMyCredits As Button
    Friend WithEvents btnAllCredits As Button
    Friend WithEvents btnAllCourses As Button
    Friend WithEvents btnMyGrades As Button
    Friend WithEvents btnMyCourses As Button
    Friend WithEvents btnDrop As Button
    Friend WithEvents btnEnroll As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents richTxtBoxResult As RichTextBox
End Class