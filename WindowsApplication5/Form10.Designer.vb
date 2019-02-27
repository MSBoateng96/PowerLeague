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
        Me.grpbxUtilities = New System.Windows.Forms.GroupBox()
        Me.btnDone2 = New System.Windows.Forms.Button()
        Me.txtNewUser = New System.Windows.Forms.TextBox()
        Me.txtConfUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.grpbxUtilities.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxUtilities
        '
        Me.grpbxUtilities.Controls.Add(Me.btnCancel1)
        Me.grpbxUtilities.Controls.Add(Me.Label2)
        Me.grpbxUtilities.Controls.Add(Me.Label1)
        Me.grpbxUtilities.Controls.Add(Me.txtConfUser)
        Me.grpbxUtilities.Controls.Add(Me.txtNewUser)
        Me.grpbxUtilities.Controls.Add(Me.btnDone2)
        Me.grpbxUtilities.Location = New System.Drawing.Point(12, 12)
        Me.grpbxUtilities.Name = "grpbxUtilities"
        Me.grpbxUtilities.Size = New System.Drawing.Size(544, 203)
        Me.grpbxUtilities.TabIndex = 2
        Me.grpbxUtilities.TabStop = False
        '
        'btnDone2
        '
        Me.btnDone2.Location = New System.Drawing.Point(423, 174)
        Me.btnDone2.Name = "btnDone2"
        Me.btnDone2.Size = New System.Drawing.Size(115, 23)
        Me.btnDone2.TabIndex = 3
        Me.btnDone2.Text = "Done"
        Me.btnDone2.UseVisualStyleBackColor = True
        '
        'txtNewUser
        '
        Me.txtNewUser.Location = New System.Drawing.Point(253, 56)
        Me.txtNewUser.Name = "txtNewUser"
        Me.txtNewUser.Size = New System.Drawing.Size(157, 20)
        Me.txtNewUser.TabIndex = 4
        '
        'txtConfUser
        '
        Me.txtConfUser.Location = New System.Drawing.Point(253, 110)
        Me.txtConfUser.Name = "txtConfUser"
        Me.txtConfUser.Size = New System.Drawing.Size(157, 20)
        Me.txtConfUser.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "New Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Confirm New Username:"
        '
        'btnCancel1
        '
        Me.btnCancel1.Location = New System.Drawing.Point(6, 174)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(115, 23)
        Me.btnCancel1.TabIndex = 8
        Me.btnCancel1.Text = "Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'frmChangeUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 231)
        Me.Controls.Add(Me.grpbxUtilities)
        Me.Name = "frmChangeUser"
        Me.Text = "Change Username"
        Me.grpbxUtilities.ResumeLayout(False)
        Me.grpbxUtilities.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxUtilities As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfUser As System.Windows.Forms.TextBox
    Friend WithEvents txtNewUser As System.Windows.Forms.TextBox
    Friend WithEvents btnDone2 As System.Windows.Forms.Button
End Class
