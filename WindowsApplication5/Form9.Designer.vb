<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.btnRentalDisplay3 = New System.Windows.Forms.Button()
        Me.btnChangeDeta = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnChangeUser = New System.Windows.Forms.Button()
        Me.grpbxUtilities.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxUtilities
        '
        Me.grpbxUtilities.Controls.Add(Me.btnRentalDisplay3)
        Me.grpbxUtilities.Controls.Add(Me.btnChangeDeta)
        Me.grpbxUtilities.Controls.Add(Me.btnChangePass)
        Me.grpbxUtilities.Controls.Add(Me.btnChangeUser)
        Me.grpbxUtilities.Location = New System.Drawing.Point(12, 12)
        Me.grpbxUtilities.Name = "grpbxUtilities"
        Me.grpbxUtilities.Size = New System.Drawing.Size(544, 257)
        Me.grpbxUtilities.TabIndex = 1
        Me.grpbxUtilities.TabStop = False
        '
        'btnRentalDisplay3
        '
        Me.btnRentalDisplay3.Location = New System.Drawing.Point(423, 228)
        Me.btnRentalDisplay3.Name = "btnRentalDisplay3"
        Me.btnRentalDisplay3.Size = New System.Drawing.Size(115, 23)
        Me.btnRentalDisplay3.TabIndex = 3
        Me.btnRentalDisplay3.Text = "Rental Display"
        Me.btnRentalDisplay3.UseVisualStyleBackColor = True
        '
        'btnChangeDeta
        '
        Me.btnChangeDeta.Location = New System.Drawing.Point(193, 173)
        Me.btnChangeDeta.Name = "btnChangeDeta"
        Me.btnChangeDeta.Size = New System.Drawing.Size(154, 23)
        Me.btnChangeDeta.TabIndex = 2
        Me.btnChangeDeta.Text = "Change Personal Details"
        Me.btnChangeDeta.UseVisualStyleBackColor = True
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(193, 116)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(154, 23)
        Me.btnChangePass.TabIndex = 1
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnChangeUser
        '
        Me.btnChangeUser.Location = New System.Drawing.Point(194, 59)
        Me.btnChangeUser.Name = "btnChangeUser"
        Me.btnChangeUser.Size = New System.Drawing.Size(154, 23)
        Me.btnChangeUser.TabIndex = 0
        Me.btnChangeUser.Text = "Change Username"
        Me.btnChangeUser.UseVisualStyleBackColor = True
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 281)
        Me.Controls.Add(Me.grpbxUtilities)
        Me.Name = "frmPreferences"
        Me.Text = "User Preferences"
        Me.grpbxUtilities.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxUtilities As System.Windows.Forms.GroupBox
    Friend WithEvents btnRentalDisplay3 As System.Windows.Forms.Button
    Friend WithEvents btnChangeDeta As System.Windows.Forms.Button
    Friend WithEvents btnChangePass As System.Windows.Forms.Button
    Friend WithEvents btnChangeUser As System.Windows.Forms.Button
End Class
