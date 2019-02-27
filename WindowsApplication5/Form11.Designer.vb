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
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.btnDone3 = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpChangePass.SuspendLayout()
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
        Me.grpChangePass.Location = New System.Drawing.Point(12, 14)
        Me.grpChangePass.Name = "grpChangePass"
        Me.grpChangePass.Size = New System.Drawing.Size(544, 203)
        Me.grpChangePass.TabIndex = 3
        Me.grpChangePass.TabStop = False
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(6, 174)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(115, 23)
        Me.btnCancel2.TabIndex = 8
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Confirm New Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Old Password:"
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(253, 110)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(157, 20)
        Me.txtConfPass.TabIndex = 5
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(253, 41)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.Size = New System.Drawing.Size(157, 20)
        Me.txtOldPass.TabIndex = 4
        '
        'btnDone3
        '
        Me.btnDone3.Location = New System.Drawing.Point(423, 174)
        Me.btnDone3.Name = "btnDone3"
        Me.btnDone3.Size = New System.Drawing.Size(115, 23)
        Me.btnDone3.TabIndex = 3
        Me.btnDone3.Text = "Done"
        Me.btnDone3.UseVisualStyleBackColor = True
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(253, 74)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(157, 20)
        Me.txtNewPass.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Password:"
        '
        'frmChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 231)
        Me.Controls.Add(Me.grpChangePass)
        Me.Name = "frmChangePass"
        Me.Text = "Change Password"
        Me.grpChangePass.ResumeLayout(False)
        Me.grpChangePass.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
