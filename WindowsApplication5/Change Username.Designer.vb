<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeUser
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
        Me.grpChangeUser = New System.Windows.Forms.GroupBox()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfUser = New System.Windows.Forms.TextBox()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.btnDone2 = New System.Windows.Forms.Button()
        Me.lblChangeUsername = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpChangeUser.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpChangeUser
        '
        Me.grpChangeUser.Controls.Add(Me.btnCancel1)
        Me.grpChangeUser.Controls.Add(Me.Label2)
        Me.grpChangeUser.Controls.Add(Me.Label1)
        Me.grpChangeUser.Controls.Add(Me.txtConfUser)
        Me.grpChangeUser.Controls.Add(Me.txtNewUser)
        Me.grpChangeUser.Controls.Add(Me.btnDone2)
        Me.grpChangeUser.Location = New System.Drawing.Point(12, 66)
        Me.grpChangeUser.Name = "grpChangeUser"
        Me.grpChangeUser.Size = New System.Drawing.Size(544, 203)
        Me.grpChangeUser.TabIndex = 2
        Me.grpChangeUser.TabStop = False
        '
        'btnCancel1
        '
        Me.btnCancel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel1.Location = New System.Drawing.Point(6, 164)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(115, 33)
        Me.btnCancel1.TabIndex = 8
        Me.btnCancel1.Text = "Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(105, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Confirm New Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(162, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "New Username:"
        '
        'txtConfUser
        '
        Me.txtConfUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtConfUser.Location = New System.Drawing.Point(283, 105)
        Me.txtConfUser.MaxLength = 15
        Me.txtConfUser.Name = "txtConfUser"
        Me.txtConfUser.Size = New System.Drawing.Size(157, 24)
        Me.txtConfUser.TabIndex = 2
        '
        'txtNewUser
        '
        Me.txtNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewUser.Location = New System.Drawing.Point(283, 51)
        Me.txtNewUser.MaxLength = 15
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(157, 24)
        Me.txtNewUser.TabIndex = 1
        '
        'btnDone2
        '
        Me.btnDone2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone2.Location = New System.Drawing.Point(423, 164)
        Me.btnDone2.Name = "btnDone2"
        Me.btnDone2.Size = New System.Drawing.Size(115, 33)
        Me.btnDone2.TabIndex = 3
        Me.btnDone2.Text = "Done"
        Me.btnDone2.UseVisualStyleBackColor = True
        '
        'lblChangeUsername
        '
        Me.lblChangeUsername.AutoSize = True
        Me.lblChangeUsername.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeUsername.Location = New System.Drawing.Point(175, 19)
        Me.lblChangeUsername.Name = "lblChangeUsername"
        Me.lblChangeUsername.Size = New System.Drawing.Size(270, 34)
        Me.lblChangeUsername.TabIndex = 15
        Me.lblChangeUsername.Text = "Change Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'frmChangeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 281)
        Me.Controls.Add(Me.lblChangeUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpChangeUser)
        Me.Name = "frmChangeUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Username"
        Me.grpChangeUser.ResumeLayout(False)
        Me.grpChangeUser.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpChangeUser As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfUser As System.Windows.Forms.TextBox
    Friend WithEvents txtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents btnDone2 As System.Windows.Forms.Button
    Friend WithEvents lblChangeUsername As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
