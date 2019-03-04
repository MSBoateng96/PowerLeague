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
        Me.grpbxPreferences = New System.Windows.Forms.GroupBox()
        Me.btnChangeSecurity = New System.Windows.Forms.Button()
        Me.btnRentalDisplay3 = New System.Windows.Forms.Button()
        Me.btnChangeDeta = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnChangeUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblUserPreferences = New System.Windows.Forms.Label()
        Me.grpbxPreferences.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbxPreferences
        '
        Me.grpbxPreferences.Controls.Add(Me.btnChangeSecurity)
        Me.grpbxPreferences.Controls.Add(Me.btnRentalDisplay3)
        Me.grpbxPreferences.Controls.Add(Me.btnChangeDeta)
        Me.grpbxPreferences.Controls.Add(Me.btnChangePass)
        Me.grpbxPreferences.Controls.Add(Me.btnChangeUser)
        Me.grpbxPreferences.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.grpbxPreferences.Location = New System.Drawing.Point(12, 68)
        Me.grpbxPreferences.Name = "grpbxPreferences"
        Me.grpbxPreferences.Size = New System.Drawing.Size(544, 257)
        Me.grpbxPreferences.TabIndex = 1
        Me.grpbxPreferences.TabStop = False
        '
        'btnChangeSecurity
        '
        Me.btnChangeSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnChangeSecurity.Location = New System.Drawing.Point(175, 138)
        Me.btnChangeSecurity.Name = "btnChangeSecurity"
        Me.btnChangeSecurity.Size = New System.Drawing.Size(193, 30)
        Me.btnChangeSecurity.TabIndex = 3
        Me.btnChangeSecurity.Text = "Change Security Code"
        Me.btnChangeSecurity.UseVisualStyleBackColor = True
        '
        'btnRentalDisplay3
        '
        Me.btnRentalDisplay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnRentalDisplay3.Location = New System.Drawing.Point(389, 222)
        Me.btnRentalDisplay3.Name = "btnRentalDisplay3"
        Me.btnRentalDisplay3.Size = New System.Drawing.Size(149, 29)
        Me.btnRentalDisplay3.TabIndex = 4
        Me.btnRentalDisplay3.Text = "Rental Display"
        Me.btnRentalDisplay3.UseVisualStyleBackColor = True
        '
        'btnChangeDeta
        '
        Me.btnChangeDeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnChangeDeta.Location = New System.Drawing.Point(175, 187)
        Me.btnChangeDeta.Name = "btnChangeDeta"
        Me.btnChangeDeta.Size = New System.Drawing.Size(193, 30)
        Me.btnChangeDeta.TabIndex = 2
        Me.btnChangeDeta.Text = "Change Personal Details"
        Me.btnChangeDeta.UseVisualStyleBackColor = True
        '
        'btnChangePass
        '
        Me.btnChangePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnChangePass.Location = New System.Drawing.Point(175, 89)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(193, 30)
        Me.btnChangePass.TabIndex = 1
        Me.btnChangePass.Text = "Change Password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnChangeUser
        '
        Me.btnChangeUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnChangeUser.Location = New System.Drawing.Point(175, 40)
        Me.btnChangeUser.Name = "btnChangeUser"
        Me.btnChangeUser.Size = New System.Drawing.Size(193, 30)
        Me.btnChangeUser.TabIndex = 0
        Me.btnChangeUser.Text = "Change Username"
        Me.btnChangeUser.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblUserPreferences
        '
        Me.lblUserPreferences.AutoSize = True
        Me.lblUserPreferences.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserPreferences.Location = New System.Drawing.Point(154, 20)
        Me.lblUserPreferences.Name = "lblUserPreferences"
        Me.lblUserPreferences.Size = New System.Drawing.Size(252, 34)
        Me.lblUserPreferences.TabIndex = 6
        Me.lblUserPreferences.Text = "User Preferences"
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 337)
        Me.Controls.Add(Me.lblUserPreferences)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpbxPreferences)
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Preferences"
        Me.grpbxPreferences.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxPreferences As System.Windows.Forms.GroupBox
    Friend WithEvents btnRentalDisplay3 As System.Windows.Forms.Button
    Friend WithEvents btnChangePass As System.Windows.Forms.Button
    Friend WithEvents btnChangeUser As System.Windows.Forms.Button
    Friend WithEvents btnChangeDeta As System.Windows.Forms.Button
    Friend WithEvents btnChangeSecurity As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserPreferences As System.Windows.Forms.Label
End Class
