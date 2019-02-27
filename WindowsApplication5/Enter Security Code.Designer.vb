<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterSecCode
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
        Me.btnDone5 = New System.Windows.Forms.Button()
        Me.btnCancel5 = New System.Windows.Forms.Button()
        Me.txtSecCode = New System.Windows.Forms.TextBox()
        Me.lblSecurityCode = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rchtxtSecCode = New System.Windows.Forms.RichTextBox()
        Me.txtSecEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDone5
        '
        Me.btnDone5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone5.Location = New System.Drawing.Point(399, 155)
        Me.btnDone5.Name = "btnDone5"
        Me.btnDone5.Size = New System.Drawing.Size(101, 30)
        Me.btnDone5.TabIndex = 4
        Me.btnDone5.Text = "Done"
        Me.btnDone5.UseVisualStyleBackColor = True
        '
        'btnCancel5
        '
        Me.btnCancel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel5.Location = New System.Drawing.Point(12, 155)
        Me.btnCancel5.Name = "btnCancel5"
        Me.btnCancel5.Size = New System.Drawing.Size(101, 30)
        Me.btnCancel5.TabIndex = 3
        Me.btnCancel5.Text = "Cancel"
        Me.btnCancel5.UseVisualStyleBackColor = True
        '
        'txtSecCode
        '
        Me.txtSecCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtSecCode.Location = New System.Drawing.Point(191, 105)
        Me.txtSecCode.MaxLength = 8
        Me.txtSecCode.Name = "txtSecCode"
        Me.txtSecCode.Size = New System.Drawing.Size(117, 24)
        Me.txtSecCode.TabIndex = 2
        '
        'lblSecurityCode
        '
        Me.lblSecurityCode.AutoSize = True
        Me.lblSecurityCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblSecurityCode.Location = New System.Drawing.Point(80, 108)
        Me.lblSecurityCode.Name = "lblSecurityCode"
        Me.lblSecurityCode.Size = New System.Drawing.Size(105, 18)
        Me.lblSecurityCode.TabIndex = 6
        Me.lblSecurityCode.Text = "Security Code:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'rchtxtSecCode
        '
        Me.rchtxtSecCode.BackColor = System.Drawing.SystemColors.Control
        Me.rchtxtSecCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rchtxtSecCode.Location = New System.Drawing.Point(120, 12)
        Me.rchtxtSecCode.Name = "rchtxtSecCode"
        Me.rchtxtSecCode.ReadOnly = True
        Me.rchtxtSecCode.Size = New System.Drawing.Size(380, 31)
        Me.rchtxtSecCode.TabIndex = 11
        Me.rchtxtSecCode.Text = "Please enter your email and security code to proceed."
        '
        'txtSecEmail
        '
        Me.txtSecEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtSecEmail.Location = New System.Drawing.Point(191, 69)
        Me.txtSecEmail.MaxLength = 40
        Me.txtSecEmail.Name = "txtSecEmail"
        Me.txtSecEmail.Size = New System.Drawing.Size(293, 24)
        Me.txtSecEmail.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblEmail.Location = New System.Drawing.Point(136, 72)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(49, 18)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email:"
        '
        'frmEnterSecCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(512, 211)
        Me.Controls.Add(Me.txtSecEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.rchtxtSecCode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDone5)
        Me.Controls.Add(Me.btnCancel5)
        Me.Controls.Add(Me.txtSecCode)
        Me.Controls.Add(Me.lblSecurityCode)
        Me.Name = "frmEnterSecCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Security Code"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDone5 As System.Windows.Forms.Button
    Friend WithEvents btnCancel5 As System.Windows.Forms.Button
    Friend WithEvents txtSecCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSecurityCode As System.Windows.Forms.Label
    Friend WithEvents rchtxtSecCode As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSecEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
End Class
