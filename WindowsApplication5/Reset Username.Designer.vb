<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetUser
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
        Me.lblResetUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtConfUser = New System.Windows.Forms.TextBox()
        Me.lblConfUser = New System.Windows.Forms.Label()
        Me.btnDone7 = New System.Windows.Forms.Button()
        Me.btnCancel7 = New System.Windows.Forms.Button()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.lblNewUser = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.rchtxtEmail = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResetUsername
        '
        Me.lblResetUsername.AutoSize = True
        Me.lblResetUsername.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetUsername.Location = New System.Drawing.Point(189, 34)
        Me.lblResetUsername.Name = "lblResetUsername"
        Me.lblResetUsername.Size = New System.Drawing.Size(242, 34)
        Me.lblResetUsername.TabIndex = 18
        Me.lblResetUsername.Text = "Reset Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(30, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'txtConfUser
        '
        Me.txtConfUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtConfUser.Location = New System.Drawing.Point(188, 185)
        Me.txtConfUser.MaxLength = 15
        Me.txtConfUser.Name = "txtConfUser"
        Me.txtConfUser.Size = New System.Drawing.Size(232, 24)
        Me.txtConfUser.TabIndex = 2
        '
        'lblConfUser
        '
        Me.lblConfUser.AutoSize = True
        Me.lblConfUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblConfUser.Location = New System.Drawing.Point(12, 188)
        Me.lblConfUser.Name = "lblConfUser"
        Me.lblConfUser.Size = New System.Drawing.Size(172, 18)
        Me.lblConfUser.TabIndex = 16
        Me.lblConfUser.Text = "Confirm New Username:"
        '
        'btnDone7
        '
        Me.btnDone7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone7.Location = New System.Drawing.Point(452, 227)
        Me.btnDone7.Name = "btnDone7"
        Me.btnDone7.Size = New System.Drawing.Size(88, 28)
        Me.btnDone7.TabIndex = 3
        Me.btnDone7.Text = "Done"
        Me.btnDone7.UseVisualStyleBackColor = True
        '
        'btnCancel7
        '
        Me.btnCancel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel7.Location = New System.Drawing.Point(12, 227)
        Me.btnCancel7.Name = "btnCancel7"
        Me.btnCancel7.Size = New System.Drawing.Size(88, 28)
        Me.btnCancel7.TabIndex = 4
        Me.btnCancel7.Text = "Cancel"
        Me.btnCancel7.UseVisualStyleBackColor = True
        '
        'txtNewUser
        '
        Me.txtNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewUser.Location = New System.Drawing.Point(188, 144)
        Me.txtNewUser.MaxLength = 15
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(232, 24)
        Me.txtNewUser.TabIndex = 1
        '
        'lblNewUser
        '
        Me.lblNewUser.AutoSize = True
        Me.lblNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNewUser.Location = New System.Drawing.Point(69, 147)
        Me.lblNewUser.Name = "lblNewUser"
        Me.lblNewUser.Size = New System.Drawing.Size(115, 18)
        Me.lblNewUser.TabIndex = 12
        Me.lblNewUser.Text = "New Username:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblEmail.Location = New System.Drawing.Point(133, 106)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail.TabIndex = 11
        Me.lblEmail.Text = "Email:"
        '
        'rchtxtEmail
        '
        Me.rchtxtEmail.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rchtxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rchtxtEmail.Location = New System.Drawing.Point(188, 103)
        Me.rchtxtEmail.MaxLength = 40
        Me.rchtxtEmail.Name = "rchtxtEmail"
        Me.rchtxtEmail.ReadOnly = True
        Me.rchtxtEmail.Size = New System.Drawing.Size(339, 25)
        Me.rchtxtEmail.TabIndex = 9
        Me.rchtxtEmail.Text = ""
        '
        'frmResetUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 281)
        Me.Controls.Add(Me.lblResetUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtConfUser)
        Me.Controls.Add(Me.lblConfUser)
        Me.Controls.Add(Me.btnDone7)
        Me.Controls.Add(Me.btnCancel7)
        Me.Controls.Add(Me.txtNewUser)
        Me.Controls.Add(Me.lblNewUser)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.rchtxtEmail)
        Me.Name = "frmResetUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Username"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResetUsername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtConfUser As System.Windows.Forms.TextBox
    Friend WithEvents lblConfUser As System.Windows.Forms.Label
    Friend WithEvents btnDone7 As System.Windows.Forms.Button
    Friend WithEvents btnCancel7 As System.Windows.Forms.Button
    Friend WithEvents txtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents lblNewUser As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents rchtxtEmail As System.Windows.Forms.RichTextBox
End Class
