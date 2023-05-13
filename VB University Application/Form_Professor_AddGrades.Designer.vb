
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Professor_AddGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Professor_AddGrades))
        Me.button_Back = New System.Windows.Forms.Button()
        Me.button_Add = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBox_Input = New System.Windows.Forms.TextBox()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_Back
        '
        Me.button_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Back.FlatAppearance.BorderSize = 0
        Me.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Back.Font = New System.Drawing.Font("Lucida Console", 13.0!, System.Drawing.FontStyle.Bold)
        Me.button_Back.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button_Back.Location = New System.Drawing.Point(3, 0)
        Me.button_Back.Name = "button_Back"
        Me.button_Back.Size = New System.Drawing.Size(39, 42)
        Me.button_Back.TabIndex = 20
        Me.button_Back.Text = "<"
        Me.button_Back.UseVisualStyleBackColor = False
        '
        'button_Add
        '
        Me.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.button_Add.FlatAppearance.BorderSize = 2
        Me.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button_Add.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button_Add.Location = New System.Drawing.Point(315, 159)
        Me.button_Add.Name = "button_Add"
        Me.button_Add.Size = New System.Drawing.Size(87, 43)
        Me.button_Add.TabIndex = 4
        Me.button_Add.Text = "ADD"
        Me.button_Add.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.buttonExit.FlatAppearance.BorderSize = 0
        Me.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonExit.Font = New System.Drawing.Font("Lucida Console", 12.75!, System.Drawing.FontStyle.Bold)
        Me.buttonExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.Location = New System.Drawing.Point(417, 0)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(48, 35)
        Me.buttonExit.TabIndex = 14
        Me.buttonExit.Text = "X"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.button_Add)
        Me.panel1.Controls.Add(Me.buttonExit)
        Me.panel1.Controls.Add(Me.button_Back)
        Me.panel1.Controls.Add(Me.textBox_Input)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(465, 343)
        Me.panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(195, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Grades"
        '
        'textBox_Input
        '
        Me.textBox_Input.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!)
        Me.textBox_Input.ForeColor = System.Drawing.Color.Black
        Me.textBox_Input.Location = New System.Drawing.Point(22, 57)
        Me.textBox_Input.Multiline = True
        Me.textBox_Input.Name = "textBox_Input"
        Me.textBox_Input.Size = New System.Drawing.Size(221, 261)
        Me.textBox_Input.TabIndex = 2
        '
        'Form_Professor_AddGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.buttonExit
        Me.ClientSize = New System.Drawing.Size(464, 343)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Professor_AddGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Professor_AddGrades"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Back As Button
    Friend WithEvents button_Add As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents panel1 As Panel
    Friend WithEvents textBox_Input As TextBox
    Friend WithEvents Label1 As Label
End Class