<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Student_Drop
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDrop = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.comboBoxDrop = New System.Windows.Forms.ComboBox()
        Me.btnDrop = New System.Windows.Forms.Button()
        Me.pictureBoxSUNYLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxSUNYLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(534, 0)
        Me.btnExit.Name = "btnClose"
        Me.btnExit.Size = New System.Drawing.Size(40, 40)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblDrop
        '
        Me.lblDrop.AutoSize = True
        Me.lblDrop.Font = New System.Drawing.Font("Corbel", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblDrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblDrop.Location = New System.Drawing.Point(254, 9)
        Me.lblDrop.Name = "lblDrop"
        Me.lblDrop.Size = New System.Drawing.Size(178, 33)
        Me.lblDrop.TabIndex = 16
        Me.lblDrop.Text = "Drop a Course"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChoose.ForeColor = System.Drawing.Color.Black
        Me.lblChoose.Location = New System.Drawing.Point(164, 77)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(107, 19)
        Me.lblChoose.TabIndex = 17
        Me.lblChoose.Text = "Course Name:"
        '
        'comboBoxDrop
        '
        Me.comboBoxDrop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxDrop.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.comboBoxDrop.FormattingEnabled = True
        Me.comboBoxDrop.Location = New System.Drawing.Point(277, 75)
        Me.comboBoxDrop.Name = "comboBoxDrop"
        Me.comboBoxDrop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboBoxDrop.Size = New System.Drawing.Size(261, 26)
        Me.comboBoxDrop.TabIndex = 18
        Me.comboBoxDrop.Text = "Choose a Course"
        '
        'btnDrop
        '
        Me.btnDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDrop.FlatAppearance.BorderSize = 0
        Me.btnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrop.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnDrop.ForeColor = System.Drawing.Color.Snow
        Me.btnDrop.Location = New System.Drawing.Point(411, 135)
        Me.btnDrop.Name = "btnDrop"
        Me.btnDrop.Size = New System.Drawing.Size(127, 34)
        Me.btnDrop.TabIndex = 19
        Me.btnDrop.Text = "Drop"
        Me.btnDrop.UseVisualStyleBackColor = False
        '
        'pictureBoxSUNYLogo
        '
        Me.pictureBoxSUNYLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pictureBoxSUNYLogo.Image = Global.VB_University_Application.My.Resources.Resources.SUNY_White_Logo
        Me.pictureBoxSUNYLogo.Location = New System.Drawing.Point(0, 0)
        Me.pictureBoxSUNYLogo.Name = "pictureBoxSUNYLogo"
        Me.pictureBoxSUNYLogo.Size = New System.Drawing.Size(142, 191)
        Me.pictureBoxSUNYLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBoxSUNYLogo.TabIndex = 14
        Me.pictureBoxSUNYLogo.TabStop = False
        '
        'Form_Student_Drop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 190)
        Me.Controls.Add(Me.btnDrop)
        Me.Controls.Add(Me.comboBoxDrop)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.lblDrop)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pictureBoxSUNYLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Student_Drop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBoxSUNYLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents pictureBoxSUNYLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDrop As Label
    Friend WithEvents lblChoose As Label
    Friend WithEvents comboBoxDrop As ComboBox
    Friend WithEvents btnDrop As Button
End Class