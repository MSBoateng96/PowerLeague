<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegUserDetails
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAnswer2 = New System.Windows.Forms.TextBox()
        Me.txtSecQuestion2 = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.txtUsername1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancel8 = New System.Windows.Forms.Button()
        Me.btnRegister1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegister1)
        Me.GroupBox1.Controls.Add(Me.btnCancel8)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtAnswer2)
        Me.GroupBox1.Controls.Add(Me.txtSecQuestion2)
        Me.GroupBox1.Controls.Add(Me.txtConfPass)
        Me.GroupBox1.Controls.Add(Me.txtPassword1)
        Me.GroupBox1.Controls.Add(Me.txtUsername1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(613, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(227, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 18)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Answer:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(158, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 18)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Security Question:"
        '
        'txtAnswer2
        '
        Me.txtAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer2.Location = New System.Drawing.Point(294, 174)
        Me.txtAnswer2.Name = "txtAnswer2"
        Me.txtAnswer2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAnswer2.Size = New System.Drawing.Size(166, 24)
        Me.txtAnswer2.TabIndex = 40
        '
        'txtSecQuestion2
        '
        Me.txtSecQuestion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecQuestion2.Location = New System.Drawing.Point(294, 147)
        Me.txtSecQuestion2.Name = "txtSecQuestion2"
        Me.txtSecQuestion2.Size = New System.Drawing.Size(166, 24)
        Me.txtSecQuestion2.TabIndex = 39
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfPass.Location = New System.Drawing.Point(294, 120)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(166, 24)
        Me.txtConfPass.TabIndex = 38
        '
        'txtPassword1
        '
        Me.txtPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword1.Location = New System.Drawing.Point(294, 94)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword1.Size = New System.Drawing.Size(166, 24)
        Me.txtPassword1.TabIndex = 37
        '
        'txtUsername1
        '
        Me.txtUsername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername1.Location = New System.Drawing.Point(294, 68)
        Me.txtUsername1.Name = "txtUsername1"
        Me.txtUsername1.Size = New System.Drawing.Size(166, 24)
        Me.txtUsername1.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(152, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 18)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Confirm Password:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(209, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Password:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(207, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Username:"
        '
        'btnCancel8
        '
        Me.btnCancel8.Location = New System.Drawing.Point(6, 237)
        Me.btnCancel8.Name = "btnCancel8"
        Me.btnCancel8.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel8.TabIndex = 43
        Me.btnCancel8.Text = "Cancel"
        Me.btnCancel8.UseVisualStyleBackColor = True
        '
        'btnRegister1
        '
        Me.btnRegister1.Location = New System.Drawing.Point(532, 237)
        Me.btnRegister1.Name = "btnRegister1"
        Me.btnRegister1.Size = New System.Drawing.Size(75, 23)
        Me.btnRegister1.TabIndex = 44
        Me.btnRegister1.Text = "REGISTER"
        Me.btnRegister1.UseVisualStyleBackColor = True
        '
        'frmRegUserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(637, 290)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRegUserDetails"
        Me.Text = "Register User Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRegister1 As System.Windows.Forms.Button
    Friend WithEvents btnCancel8 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAnswer2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSecQuestion2 As System.Windows.Forms.TextBox
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
