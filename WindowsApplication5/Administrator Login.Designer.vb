<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpbxLogin = New System.Windows.Forms.GroupBox()
        Me.linkForgotUser = New System.Windows.Forms.LinkLabel()
        Me.linkForgotPass = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpbxLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(111, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(196, 39)
        Me.txtUsername.MaxLength = 15
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(121, 24)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(196, 73)
        Me.txtPassword.MaxLength = 25
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(121, 24)
        Me.txtPassword.TabIndex = 2
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(6, 108)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(346, 108)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'grpbxLogin
        '
        Me.grpbxLogin.Controls.Add(Me.linkForgotUser)
        Me.grpbxLogin.Controls.Add(Me.linkForgotPass)
        Me.grpbxLogin.Controls.Add(Me.btnLogin)
        Me.grpbxLogin.Controls.Add(Me.Label1)
        Me.grpbxLogin.Controls.Add(Me.Label2)
        Me.grpbxLogin.Controls.Add(Me.txtUsername)
        Me.grpbxLogin.Controls.Add(Me.txtPassword)
        Me.grpbxLogin.Controls.Add(Me.btnRegister)
        Me.grpbxLogin.Location = New System.Drawing.Point(57, 138)
        Me.grpbxLogin.Name = "grpbxLogin"
        Me.grpbxLogin.Size = New System.Drawing.Size(427, 137)
        Me.grpbxLogin.TabIndex = 7
        Me.grpbxLogin.TabStop = False
        '
        'linkForgotUser
        '
        Me.linkForgotUser.AutoSize = True
        Me.linkForgotUser.LinkColor = System.Drawing.Color.Blue
        Me.linkForgotUser.Location = New System.Drawing.Point(150, 113)
        Me.linkForgotUser.Name = "linkForgotUser"
        Me.linkForgotUser.Size = New System.Drawing.Size(94, 13)
        Me.linkForgotUser.TabIndex = 6
        Me.linkForgotUser.TabStop = True
        Me.linkForgotUser.Text = "Forgot Username?"
        '
        'linkForgotPass
        '
        Me.linkForgotPass.AutoSize = True
        Me.linkForgotPass.LinkColor = System.Drawing.Color.Blue
        Me.linkForgotPass.Location = New System.Drawing.Point(248, 113)
        Me.linkForgotPass.Name = "linkForgotPass"
        Me.linkForgotPass.Size = New System.Drawing.Size(92, 13)
        Me.linkForgotPass.TabIndex = 5
        Me.linkForgotPass.TabStop = True
        Me.linkForgotPass.Text = "Forgot Password?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(169, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 118)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 281)
        Me.Controls.Add(Me.grpbxLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Login"
        Me.grpbxLogin.ResumeLayout(False)
        Me.grpbxLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents grpbxLogin As System.Windows.Forms.GroupBox
    Friend WithEvents linkForgotPass As System.Windows.Forms.LinkLabel
    Friend WithEvents linkForgotUser As System.Windows.Forms.LinkLabel
End Class
