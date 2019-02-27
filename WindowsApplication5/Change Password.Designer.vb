<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePass
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
        Me.grpChangePass = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.btnDone3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpChangePass.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpChangePass
        '
        Me.grpChangePass.Controls.Add(Me.Label3)
        Me.grpChangePass.Controls.Add(Me.txtNewPass)
        Me.grpChangePass.Controls.Add(Me.btnCancel2)
        Me.grpChangePass.Controls.Add(Me.Label2)
        Me.grpChangePass.Controls.Add(Me.Label1)
        Me.grpChangePass.Controls.Add(Me.txtConfPass)
        Me.grpChangePass.Controls.Add(Me.txtOldPass)
        Me.grpChangePass.Controls.Add(Me.btnDone3)
        Me.grpChangePass.Location = New System.Drawing.Point(12, 68)
        Me.grpChangePass.Name = "grpChangePass"
        Me.grpChangePass.Size = New System.Drawing.Size(544, 203)
        Me.grpChangePass.TabIndex = 3
        Me.grpChangePass.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(163, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Password:"
        '
        'txtNewPass
        '
        Me.txtNewPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewPass.Location = New System.Drawing.Point(282, 70)
        Me.txtNewPass.MaxLength = 25
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPass.Size = New System.Drawing.Size(157, 24)
        Me.txtNewPass.TabIndex = 2
        '
        'btnCancel2
        '
        Me.btnCancel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel2.Location = New System.Drawing.Point(6, 164)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(115, 33)
        Me.btnCancel2.TabIndex = 5
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(106, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Confirm New Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(170, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Old Password:"
        '
        'txtConfPass
        '
        Me.txtConfPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtConfPass.Location = New System.Drawing.Point(282, 106)
        Me.txtConfPass.MaxLength = 25
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfPass.Size = New System.Drawing.Size(157, 24)
        Me.txtConfPass.TabIndex = 3
        '
        'txtOldPass
        '
        Me.txtOldPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtOldPass.Location = New System.Drawing.Point(282, 37)
        Me.txtOldPass.MaxLength = 25
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtOldPass.Size = New System.Drawing.Size(157, 24)
        Me.txtOldPass.TabIndex = 1
        '
        'btnDone3
        '
        Me.btnDone3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone3.Location = New System.Drawing.Point(423, 164)
        Me.btnDone3.Name = "btnDone3"
        Me.btnDone3.Size = New System.Drawing.Size(115, 33)
        Me.btnDone3.TabIndex = 4
        Me.btnDone3.Text = "Done"
        Me.btnDone3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(179, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 34)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Change Password"
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 282)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpChangePass)
        Me.Name = "frmChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.grpChangePass.ResumeLayout(False)
        Me.grpChangePass.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpChangePass As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPass As System.Windows.Forms.TextBox
    Friend WithEvents btnDone3 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
