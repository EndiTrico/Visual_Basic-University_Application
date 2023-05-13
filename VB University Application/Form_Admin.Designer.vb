<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Admin))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddProfessor = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.btnRemoveCourse = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRemoveStudent = New System.Windows.Forms.Button()
        Me.btnRemoveProfessor = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel2.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(123, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(131, 36)
        Me.lblWelcome.TabIndex = 22
        Me.lblWelcome.Text = "Welcome"
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
        Me.btnBack.ForeColor = System.Drawing.Color.Snow
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddProfessor
        '
        Me.btnAddProfessor.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddProfessor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProfessor.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnAddProfessor.FlatAppearance.BorderSize = 0
        Me.btnAddProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProfessor.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddProfessor.ForeColor = System.Drawing.Color.Snow
        Me.btnAddProfessor.Location = New System.Drawing.Point(34, 70)
        Me.btnAddProfessor.Name = "btnAddProfessor"
        Me.btnAddProfessor.Size = New System.Drawing.Size(182, 35)
        Me.btnAddProfessor.TabIndex = 2
        Me.btnAddProfessor.Text = "1. Add Professor"
        Me.btnAddProfessor.UseVisualStyleBackColor = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnAddStudent.FlatAppearance.BorderSize = 0
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddStudent.ForeColor = System.Drawing.Color.Snow
        Me.btnAddStudent.Location = New System.Drawing.Point(34, 118)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(182, 35)
        Me.btnAddStudent.TabIndex = 3
        Me.btnAddStudent.Text = "2. Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCourse.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnAddCourse.FlatAppearance.BorderSize = 0
        Me.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCourse.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCourse.ForeColor = System.Drawing.Color.Snow
        Me.btnAddCourse.Location = New System.Drawing.Point(34, 168)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(182, 35)
        Me.btnAddCourse.TabIndex = 4
        Me.btnAddCourse.Text = "3. Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panel2.BackgroundImage = Global.VB_University_Application.My.Resources.Resources.SUNY_White_Logo
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panel2.Controls.Add(Me.lblAdmin)
        Me.panel2.Controls.Add(Me.btnRemoveCourse)
        Me.panel2.Controls.Add(Me.btnExit)
        Me.panel2.Controls.Add(Me.btnRemoveStudent)
        Me.panel2.Controls.Add(Me.btnRemoveProfessor)
        Me.panel2.Location = New System.Drawing.Point(251, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(250, 251)
        Me.panel2.TabIndex = 25
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Corbel", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.Snow
        Me.lblAdmin.Location = New System.Drawing.Point(3, 9)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(98, 36)
        Me.lblAdmin.TabIndex = 28
        Me.lblAdmin.Text = "Admin"
        '
        'btnRemoveCourse
        '
        Me.btnRemoveCourse.BackColor = System.Drawing.Color.Snow
        Me.btnRemoveCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveCourse.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnRemoveCourse.FlatAppearance.BorderSize = 0
        Me.btnRemoveCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCourse.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveCourse.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveCourse.Location = New System.Drawing.Point(37, 168)
        Me.btnRemoveCourse.Name = "btnRemoveCourse"
        Me.btnRemoveCourse.Size = New System.Drawing.Size(182, 35)
        Me.btnRemoveCourse.TabIndex = 30
        Me.btnRemoveCourse.Text = "6. Remove Course"
        Me.btnRemoveCourse.UseVisualStyleBackColor = False
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
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(210, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRemoveStudent
        '
        Me.btnRemoveStudent.BackColor = System.Drawing.Color.Snow
        Me.btnRemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveStudent.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnRemoveStudent.FlatAppearance.BorderSize = 0
        Me.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveStudent.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveStudent.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveStudent.Location = New System.Drawing.Point(37, 118)
        Me.btnRemoveStudent.Name = "btnRemoveStudent"
        Me.btnRemoveStudent.Size = New System.Drawing.Size(182, 35)
        Me.btnRemoveStudent.TabIndex = 24
        Me.btnRemoveStudent.Text = "5. Remove Student"
        Me.btnRemoveStudent.UseVisualStyleBackColor = False
        '
        'btnRemoveProfessor
        '
        Me.btnRemoveProfessor.BackColor = System.Drawing.Color.Snow
        Me.btnRemoveProfessor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveProfessor.FlatAppearance.BorderColor = System.Drawing.Color.Orange
        Me.btnRemoveProfessor.FlatAppearance.BorderSize = 0
        Me.btnRemoveProfessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProfessor.Font = New System.Drawing.Font("Corbel", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemoveProfessor.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveProfessor.Location = New System.Drawing.Point(37, 70)
        Me.btnRemoveProfessor.Name = "btnRemoveProfessor"
        Me.btnRemoveProfessor.Size = New System.Drawing.Size(182, 35)
        Me.btnRemoveProfessor.TabIndex = 29
        Me.btnRemoveProfessor.Text = "4. Remove Professor"
        Me.btnRemoveProfessor.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Image = Global.VB_University_Application.My.Resources.Resources.SUNY_Blue_Logo
        Me.pictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(256, 251)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox1.TabIndex = 27
        Me.pictureBox1.TabStop = False
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(500, 250)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.btnAddProfessor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pictureBox1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI", 13.8!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Admin"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Page "
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddProfessor As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnRemoveProfessor As Button
    Friend WithEvents btnRemoveStudent As Button
    Friend WithEvents btnRemoveCourse As Button
    Friend WithEvents pictureBox1 As PictureBox
    Friend WithEvents lblAdmin As Label
End Class
