<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResetPass
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
        Me.rchtxtEmail = New System.Windows.Forms.RichTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNewPass = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.btnCancel7 = New System.Windows.Forms.Button()
        Me.btnDone7 = New System.Windows.Forms.Button()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.lblConfPass = New System.Windows.Forms.Label()
        Me.lblResetPassword = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rchtxtEmail
        '
        Me.rchtxtEmail.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rchtxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.rchtxtEmail.Location = New System.Drawing.Point(188, 109)
        Me.rchtxtEmail.MaxLength = 40
        Me.rchtxtEmail.Name = "rchtxtEmail"
        Me.rchtxtEmail.ReadOnly = True
        Me.rchtxtEmail.Size = New System.Drawing.Size(339, 25)
        Me.rchtxtEmail.TabIndex = 5
        Me.rchtxtEmail.Text = ""
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblEmail.Location = New System.Drawing.Point(133, 112)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail.TabIndex = 1
        Me.lblEmail.Text = "Email:"
        '
        'lblNewPass
        '
        Me.lblNewPass.AutoSize = True
        Me.lblNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNewPass.Location = New System.Drawing.Point(69, 153)
        Me.lblNewPass.Name = "lblNewPass"
        Me.lblNewPass.Size = New System.Drawing.Size(113, 18)
        Me.lblNewPass.TabIndex = 2
        Me.lblNewPass.Text = "New Password:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewPass.Location = New System.Drawing.Point(188, 150)
        Me.txtNewPass.MaxLength = 25
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPass.Size = New System.Drawing.Size(232, 24)
        Me.txtNewPass.TabIndex = 1
        '
        'btnCancel7
        '
        Me.btnCancel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel7.Location = New System.Drawing.Point(12, 233)
        Me.btnCancel7.Name = "btnCancel7"
        Me.btnCancel7.Size = New System.Drawing.Size(88, 28)
        Me.btnCancel7.TabIndex = 4
        Me.btnCancel7.Text = "Cancel"
        Me.btnCancel7.UseVisualStyleBackColor = True
        '
        'btnDone7
        '
        Me.btnDone7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone7.Location = New System.Drawing.Point(452, 233)
        Me.btnDone7.Name = "btnDone7"
        Me.btnDone7.Size = New System.Drawing.Size(88, 28)
        Me.btnDone7.TabIndex = 3
        Me.btnDone7.Text = "Done"
        Me.btnDone7.UseVisualStyleBackColor = True
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtConfPass.Location = New System.Drawing.Point(188, 191)
        Me.txtConfPass.MaxLength = 25
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfPass.Size = New System.Drawing.Size(232, 24)
        Me.txtConfPass.TabIndex = 2
        '
        'lblConfPass
        '
        Me.lblConfPass.AutoSize = True
        Me.lblConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblConfPass.Location = New System.Drawing.Point(12, 194)
        Me.lblConfPass.Name = "lblConfPass"
        Me.lblConfPass.Size = New System.Drawing.Size(170, 18)
        Me.lblConfPass.TabIndex = 6
        Me.lblConfPass.Text = "Confirm New Password:"
        '
        'lblResetPassword
        '
        Me.lblResetPassword.AutoSize = True
        Me.lblResetPassword.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResetPassword.Location = New System.Drawing.Point(201, 40)
        Me.lblResetPassword.Name = "lblResetPassword"
        Me.lblResetPassword.Size = New System.Drawing.Size(239, 34)
        Me.lblResetPassword.TabIndex = 8
        Me.lblResetPassword.Text = "Reset Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(30, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 277)
        Me.Controls.Add(Me.lblResetPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.lblConfPass)
        Me.Controls.Add(Me.btnDone7)
        Me.Controls.Add(Me.btnCancel7)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.lblNewPass)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.rchtxtEmail)
        Me.Name = "frmResetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rchtxtEmail As System.Windows.Forms.RichTextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblNewPass As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel7 As System.Windows.Forms.Button
    Friend WithEvents btnDone7 As System.Windows.Forms.Button
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents lblConfPass As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblResetPassword As System.Windows.Forms.Label
End Class
