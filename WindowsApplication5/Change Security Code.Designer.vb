<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecCode
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
        Me.components = New System.ComponentModel.Container()
        Me.grpChangeCode = New System.Windows.Forms.GroupBox()
        Me.lblNewCode = New System.Windows.Forms.Label()
        Me.txtNewCode = New System.Windows.Forms.TextBox()
        Me.btnCancel6 = New System.Windows.Forms.Button()
        Me.lblConfCode = New System.Windows.Forms.Label()
        Me.txtConfCode = New System.Windows.Forms.TextBox()
        Me.btnDone6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblChangeSecCode = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtNewCde = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpChangeCode.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpChangeCode
        '
        Me.grpChangeCode.Controls.Add(Me.lblNewCode)
        Me.grpChangeCode.Controls.Add(Me.txtNewCode)
        Me.grpChangeCode.Controls.Add(Me.btnCancel6)
        Me.grpChangeCode.Controls.Add(Me.lblConfCode)
        Me.grpChangeCode.Controls.Add(Me.txtConfCode)
        Me.grpChangeCode.Controls.Add(Me.btnDone6)
        Me.grpChangeCode.Location = New System.Drawing.Point(12, 76)
        Me.grpChangeCode.Name = "grpChangeCode"
        Me.grpChangeCode.Size = New System.Drawing.Size(544, 151)
        Me.grpChangeCode.TabIndex = 4
        Me.grpChangeCode.TabStop = False
        '
        'lblNewCode
        '
        Me.lblNewCode.AutoSize = True
        Me.lblNewCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNewCode.Location = New System.Drawing.Point(114, 35)
        Me.lblNewCode.Name = "lblNewCode"
        Me.lblNewCode.Size = New System.Drawing.Size(139, 18)
        Me.lblNewCode.TabIndex = 10
        Me.lblNewCode.Text = "New Security Code:"
        '
        'txtNewCode
        '
        Me.txtNewCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewCode.Location = New System.Drawing.Point(259, 32)
        Me.txtNewCode.MaxLength = 8
        Me.txtNewCode.Name = "txtNewCode"
        Me.txtNewCode.Size = New System.Drawing.Size(159, 24)
        Me.txtNewCode.TabIndex = 1
        '
        'btnCancel6
        '
        Me.btnCancel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCancel6.Location = New System.Drawing.Point(6, 107)
        Me.btnCancel6.Name = "btnCancel6"
        Me.btnCancel6.Size = New System.Drawing.Size(115, 33)
        Me.btnCancel6.TabIndex = 4
        Me.btnCancel6.Text = "Cancel"
        Me.btnCancel6.UseVisualStyleBackColor = True
        '
        'lblConfCode
        '
        Me.lblConfCode.AutoSize = True
        Me.lblConfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblConfCode.Location = New System.Drawing.Point(114, 74)
        Me.lblConfCode.Name = "lblConfCode"
        Me.lblConfCode.Size = New System.Drawing.Size(139, 18)
        Me.lblConfCode.TabIndex = 7
        Me.lblConfCode.Text = "Confirm New Code:"
        '
        'txtConfCode
        '
        Me.txtConfCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtConfCode.Location = New System.Drawing.Point(259, 71)
        Me.txtConfCode.MaxLength = 8
        Me.txtConfCode.Name = "txtConfCode"
        Me.txtConfCode.Size = New System.Drawing.Size(159, 24)
        Me.txtConfCode.TabIndex = 2
        '
        'btnDone6
        '
        Me.btnDone6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnDone6.Location = New System.Drawing.Point(423, 107)
        Me.btnDone6.Name = "btnDone6"
        Me.btnDone6.Size = New System.Drawing.Size(115, 33)
        Me.btnDone6.TabIndex = 3
        Me.btnDone6.Text = "Done"
        Me.btnDone6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'lblChangeSecCode
        '
        Me.lblChangeSecCode.AutoSize = True
        Me.lblChangeSecCode.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeSecCode.Location = New System.Drawing.Point(138, 27)
        Me.lblChangeSecCode.Name = "lblChangeSecCode"
        Me.lblChangeSecCode.Size = New System.Drawing.Size(325, 34)
        Me.lblChangeSecCode.TabIndex = 13
        Me.lblChangeSecCode.Text = "Change Security Code"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtNewCde
        '
        Me.txtNewCde.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.txtNewCde.Location = New System.Drawing.Point(259, 69)
        Me.txtNewCde.Name = "txtNewCde"
        Me.txtNewCde.Size = New System.Drawing.Size(159, 24)
        Me.txtNewCde.TabIndex = 2
        '
        'frmSecCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 236)
        Me.Controls.Add(Me.lblChangeSecCode)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpChangeCode)
        Me.Name = "frmSecCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Security Code"
        Me.ToolTip1.SetToolTip(Me, "8 Digits")
        Me.grpChangeCode.ResumeLayout(False)
        Me.grpChangeCode.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpChangeCode As System.Windows.Forms.GroupBox
    Friend WithEvents lblNewCode As System.Windows.Forms.Label
    Friend WithEvents txtNewCode As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel6 As System.Windows.Forms.Button
    Friend WithEvents lblConfCode As System.Windows.Forms.Label
    Friend WithEvents txtConfCode As System.Windows.Forms.TextBox
    Friend WithEvents btnDone6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblChangeSecCode As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtNewCde As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
