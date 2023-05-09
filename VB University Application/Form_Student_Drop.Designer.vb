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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_Student_Drop))
        btnClose = New Button()
        pictureBoxSUNYLogo = New PictureBox()
        btnBack = New Button()
        lblDrop = New Label()
        lblChoose = New Label()
        comboBoxDrop = New ComboBox()
        btnDrop = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CType(pictureBoxSUNYLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.FromArgb(CByte(0), CByte(34), CByte(87))
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
        btnClose.FlatAppearance.MouseOverBackColor = Color.Silver
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Corbel", 13.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnClose.ForeColor = Color.Snow
        btnClose.Location = New Point(534, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(40, 40)
        btnClose.TabIndex = 13
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' pictureBoxSUNYLogo
        ' 
        pictureBoxSUNYLogo.Image = CType(resources.GetObject("pictureBoxSUNYLogo.Image"), Image)
        pictureBoxSUNYLogo.Location = New Point(0, 0)
        pictureBoxSUNYLogo.Name = "pictureBoxSUNYLogo"
        pictureBoxSUNYLogo.Size = New Size(142, 191)
        pictureBoxSUNYLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxSUNYLogo.TabIndex = 14
        pictureBoxSUNYLogo.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(0), CByte(34), CByte(87))
        btnBack.Cursor = Cursors.Hand
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke
        btnBack.FlatAppearance.MouseOverBackColor = Color.Silver
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Corbel", 13.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.ForeColor = Color.Snow
        btnBack.Location = New Point(0, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(40, 40)
        btnBack.TabIndex = 15
        btnBack.Text = "<"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' lblDrop
        ' 
        lblDrop.AutoSize = True
        lblDrop.Font = New Font("Corbel", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblDrop.ForeColor = Color.FromArgb(CByte(0), CByte(34), CByte(87))
        lblDrop.Location = New Point(254, 9)
        lblDrop.Name = "lblDrop"
        lblDrop.Size = New Size(178, 33)
        lblDrop.TabIndex = 16
        lblDrop.Text = "Drop"
        ' 
        ' lblChoose
        ' 
        lblChoose.AutoSize = True
        lblChoose.Font = New Font("Corbel", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblChoose.ForeColor = Color.Black
        lblChoose.Location = New Point(148, 76)
        lblChoose.Name = "lblChoose"
        lblChoose.Size = New Size(123, 22)
        lblChoose.TabIndex = 17
        lblChoose.Text = "Course Name:"
        ' 
        ' comboBoxDrop
        ' 
        comboBoxDrop.Cursor = Cursors.Hand
        comboBoxDrop.Font = New Font("Corbel", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        comboBoxDrop.FormattingEnabled = True
        comboBoxDrop.Location = New Point(277, 75)
        comboBoxDrop.Name = "comboBoxDrop"
        comboBoxDrop.RightToLeft = RightToLeft.No
        comboBoxDrop.Size = New Size(261, 26)
        comboBoxDrop.TabIndex = 18
        comboBoxDrop.Text = "Choose a Course"
        ' 
        ' btnConfirm
        ' 
        btnDrop.BackColor = Color.FromArgb(CByte(7), CByte(51), CByte(126))
        btnDrop.FlatAppearance.BorderSize = 0
        btnDrop.FlatStyle = FlatStyle.Flat
        btnDrop.Font = New Font("Corbel", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDrop.ForeColor = Color.Snow
        btnDrop.Location = New Point(503, 144)
        btnDrop.Name = "btnConfirm"
        btnDrop.Size = New Size(87, 34)
        btnDrop.TabIndex = 19
        btnDrop.Text = "Confirm"
        btnDrop.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Form_Student_Drop
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(602, 190)
        Controls.Add(btnDrop)
        Controls.Add(comboBoxDrop)
        Controls.Add(lblChoose)
        Controls.Add(lblDrop)
        Controls.Add(btnClose)
        Controls.Add(btnBack)
        Controls.Add(pictureBoxSUNYLogo)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form_Student_Drop"
        StartPosition = FormStartPosition.CenterScreen
        CType(pictureBoxSUNYLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents pictureBoxSUNYLogo As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents lblDrop As Label
    Friend WithEvents lblChoose As Label
    Friend WithEvents comboBoxDrop As ComboBox
    Friend WithEvents btnDrop As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class