<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Student_Enroll
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
        Me.lblEnroll = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.comboBoxEnroll = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pictureBoxSUNYLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxSUNYLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.Snow
        Me.btnExit.Location = New System.Drawing.Point(535, 0)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
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
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblEnroll
        '
        Me.lblEnroll.AutoSize = True
        Me.lblEnroll.Font = New System.Drawing.Font("Corbel", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnroll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblEnroll.Location = New System.Drawing.Point(241, 9)
        Me.lblEnroll.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnroll.Name = "lblEnroll"
        Me.lblEnroll.Size = New System.Drawing.Size(145, 33)
        Me.lblEnroll.TabIndex = 16
        Me.lblEnroll.Text = "Enrollment"
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.BackColor = System.Drawing.Color.Transparent
        Me.lblChoose.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblChoose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.lblChoose.Location = New System.Drawing.Point(148, 76)
        Me.lblChoose.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(127, 19)
        Me.lblChoose.TabIndex = 17
        Me.lblChoose.Text = "Enroll in a Course"
        '
        'comboBoxEnroll
        '
        Me.comboBoxEnroll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comboBoxEnroll.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.comboBoxEnroll.FormattingEnabled = True
        Me.comboBoxEnroll.Location = New System.Drawing.Point(277, 74)
        Me.comboBoxEnroll.Margin = New System.Windows.Forms.Padding(2)
        Me.comboBoxEnroll.Name = "comboBoxEnroll"
        Me.comboBoxEnroll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.comboBoxEnroll.Size = New System.Drawing.Size(261, 26)
        Me.comboBoxEnroll.TabIndex = 18
        Me.comboBoxEnroll.Text = "Choose the Course"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Snow
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Corbel", 13.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.Snow
        Me.btnAdd.Location = New System.Drawing.Point(411, 135)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 34)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'pictureBoxSUNYLogo
        '
        Me.pictureBoxSUNYLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.pictureBoxSUNYLogo.Image = Global.VB_University_Application.My.Resources.Resources.SUNY_White_Logo
        Me.pictureBoxSUNYLogo.Location = New System.Drawing.Point(0, 0)
        Me.pictureBoxSUNYLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureBoxSUNYLogo.Name = "pictureBoxSUNYLogo"
        Me.pictureBoxSUNYLogo.Size = New System.Drawing.Size(142, 191)
        Me.pictureBoxSUNYLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBoxSUNYLogo.TabIndex = 14
        Me.pictureBoxSUNYLogo.TabStop = False
        '
        'Form_Student_Enroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 190)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.comboBoxEnroll)
        Me.Controls.Add(Me.lblChoose)
        Me.Controls.Add(Me.lblEnroll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.pictureBoxSUNYLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_Student_Enroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pictureBoxSUNYLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents pictureBoxSUNYLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblEnroll As Label
    Friend WithEvents lblChoose As Label
    Friend WithEvents comboBoxEnroll As ComboBox
    Friend WithEvents btnAdd As Button
End Class