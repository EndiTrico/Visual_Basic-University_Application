<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Admin_Remove
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
        Me.comboBoxRemove = New System.Windows.Forms.ComboBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRemove = New System.Windows.Forms.Label()
        Me.lblRemove1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()

        ' 
        ' comboBoxRemove
        ' 
        Me.comboBoxRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxRemove.Font = New System.Drawing.Font("Corbel", 12.0F, System.Drawing.GraphicsUnit.Point)
        Me.comboBoxRemove.ForeColor = System.Drawing.Color.Black
        Me.comboBoxRemove.FormattingEnabled = True
        Me.comboBoxRemove.Location = New System.Drawing.Point(93, 85)
        Me.comboBoxRemove.Name = "comboBoxRemove"
        Me.comboBoxRemove.Size = New System.Drawing.Size(346, 27)
        Me.comboBoxRemove.TabIndex = 0
        ' 
        ' btnRemove
        ' 
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.ForeColor = System.Drawing.Color.Snow
        Me.btnRemove.Location = New System.Drawing.Point(338, 132)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(101, 39)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        ' 
        ' lblRemove
        ' 
        Me.lblRemove.BackColor = System.Drawing.Color.Transparent
        Me.lblRemove.Font = New System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold)
        Me.lblRemove.ForeColor = System.Drawing.Color.Snow
        Me.lblRemove.Location = New System.Drawing.Point(48, 9)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(372, 31)
        Me.lblRemove.TabIndex = 2
        Me.lblRemove.Text = "Select item to remove:"
        Me.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        ' 
        ' buttonExit
        ' 
        Me.buttonExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.FlatAppearance.BorderSize = 0
        Me.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonExit.Font = New System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold)
        Me.buttonExit.ForeColor = System.Drawing.Color.Snow
        Me.buttonExit.Location = New System.Drawing.Point(426, 0)
        Me.buttonExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(40, 40)
        Me.buttonExit.TabIndex = 14
        Me.buttonExit.Text = "X"
        Me.buttonExit.UseVisualStyleBackColor = False
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.panel1.Controls.Add(Me.btnBack)
        Me.panel1.Controls.Add(Me.buttonExit)
        Me.panel1.Controls.Add(Me.lblRemove)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(466, 55)
        Me.panel1.TabIndex = 15
        ' 
        ' btnBack
        ' 
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Corbel", 13.0F, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.Color.Snow
        Me.btnBack.Location = New System.Drawing.Point(0, 0)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblRemove1
        ' 
        Me.lblRemove1.AutoSize = True
        Me.lblRemove1.Font = New System.Drawing.Font("Corbel", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblRemove1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblRemove1.Location = New System.Drawing.Point(12, 89)
        Me.lblRemove1.Name = "lblRemove1"
        Me.lblRemove1.Size = New System.Drawing.Size(75, 21)
        Me.lblRemove1.TabIndex = 16
        Me.lblRemove1.Text = "Remove:"
        ' 
        ' Form_Admin_Remove
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 21.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(466, 183)
        Me.Controls.Add(Me.lblRemove1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.comboBoxRemove)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0F)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Admin_Remove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()


    End Sub

    Friend WithEvents comboBoxRemove As ComboBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents buttonExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblRemove As Label
    Friend WithEvents lblRemove1 As Label
    Friend WithEvents panel1 As Panel
End Class
