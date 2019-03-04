<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPassSecurity
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
        Me.lblPassword5 = New System.Windows.Forms.Label()
        Me.txtPassword5 = New System.Windows.Forms.TextBox()
        Me.btnCancel5 = New System.Windows.Forms.Button()
        Me.btnDone5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rchtxtSecCode = New System.Windows.Forms.RichTextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPassword5
        '
        Me.lblPassword5.AutoSize = True
        Me.lblPassword5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPassword5.Location = New System.Drawing.Point(193, 68)
        Me.lblPassword5.Name = "lblPassword5"
        Me.lblPassword5.Size = New System.Drawing.Size(79, 18)
        Me.lblPassword5.TabIndex = 0
        Me.lblPassword5.Text = "Password:"
        '
        'txtPassword5
        '
        Me.txtPassword5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtPassword5.Location = New System.Drawing.Point(278, 65)
        Me.txtPassword5.Name = "txtPassword5"
        Me.txtPassword5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword5.Size = New System.Drawing.Size(150, 24)
        Me.txtPassword5.TabIndex = 1
        '
        'btnCancel5
        '
        Me.btnCancel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel5.Location = New System.Drawing.Point(135, 102)
        Me.btnCancel5.Name = "btnCancel5"
        Me.btnCancel5.Size = New System.Drawing.Size(101, 30)
        Me.btnCancel5.TabIndex = 3
        Me.btnCancel5.Text = "Cancel"
        Me.btnCancel5.UseVisualStyleBackColor = True
        '
        'btnDone5
        '
        Me.btnDone5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone5.Location = New System.Drawing.Point(399, 102)
        Me.btnDone5.Name = "btnDone5"
        Me.btnDone5.Size = New System.Drawing.Size(101, 30)
        Me.btnDone5.TabIndex = 2
        Me.btnDone5.Text = "Done"
        Me.btnDone5.UseVisualStyleBackColor = True
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
        'rchtxtSecCode
        '
        Me.rchtxtSecCode.BackColor = System.Drawing.SystemColors.Control
        Me.rchtxtSecCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchtxtSecCode.Location = New System.Drawing.Point(171, 18)
        Me.rchtxtSecCode.Name = "rchtxtSecCode"
        Me.rchtxtSecCode.ReadOnly = True
        Me.rchtxtSecCode.Size = New System.Drawing.Size(310, 29)
        Me.rchtxtSecCode.TabIndex = 12
        Me.rchtxtSecCode.Text = "Please enter your password to proceed."
        '
        'frmPassSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(512, 144)
        Me.Controls.Add(Me.rchtxtSecCode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDone5)
        Me.Controls.Add(Me.btnCancel5)
        Me.Controls.Add(Me.txtPassword5)
        Me.Controls.Add(Me.lblPassword5)
        Me.Name = "frmPassSecurity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Security Code"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPassword5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword5 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel5 As System.Windows.Forms.Button
    Friend WithEvents btnDone5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rchtxtSecCode As System.Windows.Forms.RichTextBox
End Class
