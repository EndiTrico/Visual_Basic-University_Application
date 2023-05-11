<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Welcome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.optionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.loginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.optionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "menuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "menuStrip1"
        Me.optionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.optionsToolStripMenuItem.Font = New System.Drawing.Font("Corbel", 12.0F, System.Drawing.FontStyle.Bold)
        Me.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((34)))))), (CInt(((CByte((87)))))))
        Me.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem"
        Me.optionsToolStripMenuItem.Size = New System.Drawing.Size(101, 23)
        Me.optionsToolStripMenuItem.Text = "Application"
        Me.newToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loginToolStripMenuItem})
        Me.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((34)))))), (CInt(((CByte((87)))))))
        Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
        Me.newToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.newToolStripMenuItem.Text = "New"
        Me.loginToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((34)))))), (CInt(((CByte((87)))))))
        Me.loginToolStripMenuItem.Name = "loginToolStripMenuItem"
        Me.loginToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.loginToolStripMenuItem.Text = "Enter in the System"
        Me.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((34)))))), (CInt(((CByte((87)))))))
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.exitToolStripMenuItem.Text = "Exit"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((34)))))), (CInt(((CByte((87)))))))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 522)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Corbel", 9.75F, (CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic)), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "Form_Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "University System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents optionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents loginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As ToolStripMenuItem
End Class
