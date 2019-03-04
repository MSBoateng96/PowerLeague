<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooking
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
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.ComboSize = New System.Windows.Forms.ComboBox()
        Me.lblPitchSize = New System.Windows.Forms.Label()
        Me.comboboxPayment = New System.Windows.Forms.ComboBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.grpbxDateTime = New System.Windows.Forms.GroupBox()
        Me.lblDate1 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblStartPitch = New System.Windows.Forms.Label()
        Me.comboboxMM = New System.Windows.Forms.ComboBox()
        Me.comboboxHH = New System.Windows.Forms.ComboBox()
        Me.btnGetMember = New System.Windows.Forms.Button()
        Me.comboboxPitch = New System.Windows.Forms.ComboBox()
        Me.btnCancel3 = New System.Windows.Forms.Button()
        Me.txtFinalPrice = New System.Windows.Forms.TextBox()
        Me.btnConfBook = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBookEmail = New System.Windows.Forms.TextBox()
        Me.txtBookMemID = New System.Windows.Forms.TextBox()
        Me.lblFinalPrice = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPitchNumber = New System.Windows.Forms.Label()
        Me.lblMemberEmail = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxDateTime.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDate2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblTransID)
        Me.GroupBox1.Controls.Add(Me.ComboSize)
        Me.GroupBox1.Controls.Add(Me.lblPitchSize)
        Me.GroupBox1.Controls.Add(Me.comboboxPayment)
        Me.GroupBox1.Controls.Add(Me.lblPayment)
        Me.GroupBox1.Controls.Add(Me.grpbxDateTime)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblUserID)
        Me.GroupBox1.Controls.Add(Me.lblStartPitch)
        Me.GroupBox1.Controls.Add(Me.comboboxMM)
        Me.GroupBox1.Controls.Add(Me.comboboxHH)
        Me.GroupBox1.Controls.Add(Me.btnGetMember)
        Me.GroupBox1.Controls.Add(Me.comboboxPitch)
        Me.GroupBox1.Controls.Add(Me.btnCancel3)
        Me.GroupBox1.Controls.Add(Me.txtFinalPrice)
        Me.GroupBox1.Controls.Add(Me.btnConfBook)
        Me.GroupBox1.Controls.Add(Me.txtDate)
        Me.GroupBox1.Controls.Add(Me.txtBookEmail)
        Me.GroupBox1.Controls.Add(Me.txtBookMemID)
        Me.GroupBox1.Controls.Add(Me.lblFinalPrice)
        Me.GroupBox1.Controls.Add(Me.lblStartTime)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.lblPitchNumber)
        Me.GroupBox1.Controls.Add(Me.lblMemberEmail)
        Me.GroupBox1.Controls.Add(Me.lblMemberID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 379)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblDate2.Location = New System.Drawing.Point(396, 164)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(39, 18)
        Me.lblDate2.TabIndex = 39
        Me.lblDate2.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(290, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 18)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "£"
        '
        'lblTransID
        '
        Me.lblTransID.AutoSize = True
        Me.lblTransID.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblTransID.Location = New System.Drawing.Point(293, 16)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(60, 18)
        Me.lblTransID.TabIndex = 37
        Me.lblTransID.Text = "TransID"
        '
        'ComboSize
        '
        Me.ComboSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSize.FormattingEnabled = True
        Me.ComboSize.Items.AddRange(New Object() {"5-A-Side", "7-A-Side"})
        Me.ComboSize.Location = New System.Drawing.Point(290, 118)
        Me.ComboSize.Name = "ComboSize"
        Me.ComboSize.Size = New System.Drawing.Size(100, 26)
        Me.ComboSize.TabIndex = 4
        Me.ComboSize.Text = "Select Size"
        '
        'lblPitchSize
        '
        Me.lblPitchSize.AutoSize = True
        Me.lblPitchSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchSize.Location = New System.Drawing.Point(206, 121)
        Me.lblPitchSize.Name = "lblPitchSize"
        Me.lblPitchSize.Size = New System.Drawing.Size(78, 18)
        Me.lblPitchSize.TabIndex = 35
        Me.lblPitchSize.Text = "Pitch Size:"
        '
        'comboboxPayment
        '
        Me.comboboxPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxPayment.FormattingEnabled = True
        Me.comboboxPayment.Items.AddRange(New Object() {"Card", "Cash", "Online"})
        Me.comboboxPayment.Location = New System.Drawing.Point(290, 280)
        Me.comboboxPayment.Name = "comboboxPayment"
        Me.comboboxPayment.Size = New System.Drawing.Size(100, 26)
        Me.comboboxPayment.TabIndex = 9
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(160, 283)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(124, 18)
        Me.lblPayment.TabIndex = 34
        Me.lblPayment.Text = "Payment Method:"
        '
        'grpbxDateTime
        '
        Me.grpbxDateTime.Controls.Add(Me.lblDate1)
        Me.grpbxDateTime.Controls.Add(Me.lblTime)
        Me.grpbxDateTime.Location = New System.Drawing.Point(566, 9)
        Me.grpbxDateTime.Name = "grpbxDateTime"
        Me.grpbxDateTime.Size = New System.Drawing.Size(90, 53)
        Me.grpbxDateTime.TabIndex = 26
        Me.grpbxDateTime.TabStop = False
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.Location = New System.Drawing.Point(5, 32)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(41, 16)
        Me.lblDate1.TabIndex = 6
        Me.lblDate1.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(23, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(43, 16)
        Me.lblTime.TabIndex = 24
        Me.lblTime.Text = "Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "UserID:"
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(62, 9)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(56, 16)
        Me.lblUserID.TabIndex = 27
        Me.lblUserID.Text = "UserID"
        '
        'lblStartPitch
        '
        Me.lblStartPitch.AutoSize = True
        Me.lblStartPitch.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblStartPitch.Location = New System.Drawing.Point(396, 202)
        Me.lblStartPitch.Name = "lblStartPitch"
        Me.lblStartPitch.Size = New System.Drawing.Size(51, 18)
        Me.lblStartPitch.TabIndex = 32
        Me.lblStartPitch.Text = "Label1"
        '
        'comboboxMM
        '
        Me.comboboxMM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxMM.FormattingEnabled = True
        Me.comboboxMM.Items.AddRange(New Object() {"00", "15", "30", "45"})
        Me.comboboxMM.Location = New System.Drawing.Point(341, 239)
        Me.comboboxMM.Name = "comboboxMM"
        Me.comboboxMM.Size = New System.Drawing.Size(49, 26)
        Me.comboboxMM.TabIndex = 8
        Me.comboboxMM.Text = "MM"
        '
        'comboboxHH
        '
        Me.comboboxHH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxHH.FormattingEnabled = True
        Me.comboboxHH.Items.AddRange(New Object() {"09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.comboboxHH.Location = New System.Drawing.Point(290, 239)
        Me.comboboxHH.Name = "comboboxHH"
        Me.comboboxHH.Size = New System.Drawing.Size(45, 26)
        Me.comboboxHH.TabIndex = 7
        Me.comboboxHH.Text = "HH"
        '
        'btnGetMember
        '
        Me.btnGetMember.Location = New System.Drawing.Point(399, 39)
        Me.btnGetMember.Name = "btnGetMember"
        Me.btnGetMember.Size = New System.Drawing.Size(111, 26)
        Me.btnGetMember.TabIndex = 2
        Me.btnGetMember.Text = "Get Member"
        Me.btnGetMember.UseVisualStyleBackColor = True
        '
        'comboboxPitch
        '
        Me.comboboxPitch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxPitch.FormattingEnabled = True
        Me.comboboxPitch.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.comboboxPitch.Location = New System.Drawing.Point(290, 159)
        Me.comboboxPitch.Name = "comboboxPitch"
        Me.comboboxPitch.Size = New System.Drawing.Size(100, 26)
        Me.comboboxPitch.TabIndex = 5
        Me.comboboxPitch.Text = "Select Pitch"
        '
        'btnCancel3
        '
        Me.btnCancel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel3.Location = New System.Drawing.Point(6, 342)
        Me.btnCancel3.Name = "btnCancel3"
        Me.btnCancel3.Size = New System.Drawing.Size(75, 31)
        Me.btnCancel3.TabIndex = 12
        Me.btnCancel3.Text = "Cancel"
        Me.btnCancel3.UseVisualStyleBackColor = True
        '
        'txtFinalPrice
        '
        Me.txtFinalPrice.BackColor = System.Drawing.SystemColors.Control
        Me.txtFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalPrice.Location = New System.Drawing.Point(308, 321)
        Me.txtFinalPrice.Name = "txtFinalPrice"
        Me.txtFinalPrice.ReadOnly = True
        Me.txtFinalPrice.Size = New System.Drawing.Size(100, 24)
        Me.txtFinalPrice.TabIndex = 10
        '
        'btnConfBook
        '
        Me.btnConfBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfBook.Location = New System.Drawing.Point(484, 342)
        Me.btnConfBook.Name = "btnConfBook"
        Me.btnConfBook.Size = New System.Drawing.Size(153, 29)
        Me.btnConfBook.TabIndex = 11
        Me.btnConfBook.Text = "Confirm Booking"
        Me.btnConfBook.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.Location = New System.Drawing.Point(290, 200)
        Me.txtDate.MaxLength = 10
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(100, 24)
        Me.txtDate.TabIndex = 6
        '
        'txtBookEmail
        '
        Me.txtBookEmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtBookEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookEmail.Location = New System.Drawing.Point(290, 79)
        Me.txtBookEmail.MaxLength = 40
        Me.txtBookEmail.Name = "txtBookEmail"
        Me.txtBookEmail.ReadOnly = True
        Me.txtBookEmail.Size = New System.Drawing.Size(220, 24)
        Me.txtBookEmail.TabIndex = 3
        '
        'txtBookMemID
        '
        Me.txtBookMemID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookMemID.Location = New System.Drawing.Point(290, 40)
        Me.txtBookMemID.MaxLength = 6
        Me.txtBookMemID.Name = "txtBookMemID"
        Me.txtBookMemID.Size = New System.Drawing.Size(100, 24)
        Me.txtBookMemID.TabIndex = 1
        '
        'lblFinalPrice
        '
        Me.lblFinalPrice.AutoSize = True
        Me.lblFinalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalPrice.Location = New System.Drawing.Point(203, 324)
        Me.lblFinalPrice.Name = "lblFinalPrice"
        Me.lblFinalPrice.Size = New System.Drawing.Size(81, 18)
        Me.lblFinalPrice.TabIndex = 5
        Me.lblFinalPrice.Text = "Final Price:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Location = New System.Drawing.Point(204, 242)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(80, 18)
        Me.lblStartTime.TabIndex = 4
        Me.lblStartTime.Text = "Start Time:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(241, 203)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 18)
        Me.lblDate.TabIndex = 3
        Me.lblDate.Text = "Date:"
        '
        'lblPitchNumber
        '
        Me.lblPitchNumber.AutoSize = True
        Me.lblPitchNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchNumber.Location = New System.Drawing.Point(182, 162)
        Me.lblPitchNumber.Name = "lblPitchNumber"
        Me.lblPitchNumber.Size = New System.Drawing.Size(102, 18)
        Me.lblPitchNumber.TabIndex = 2
        Me.lblPitchNumber.Text = "Pitch Number:"
        '
        'lblMemberEmail
        '
        Me.lblMemberEmail.AutoSize = True
        Me.lblMemberEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberEmail.Location = New System.Drawing.Point(165, 82)
        Me.lblMemberEmail.Name = "lblMemberEmail"
        Me.lblMemberEmail.Size = New System.Drawing.Size(119, 18)
        Me.lblMemberEmail.TabIndex = 1
        Me.lblMemberEmail.Text = "Member's Email:"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(203, 43)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(81, 18)
        Me.lblMemberID.TabIndex = 0
        Me.lblMemberID.Text = "MemberID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pitch Booking"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RichTextBox1.Location = New System.Drawing.Point(641, 18)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(293, 53)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "Welcome to Pitch Booking!" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "This is where you can book pitches for customers today" & _
            "."
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(674, 153)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(260, 191)
        Me.RichTextBox2.TabIndex = 4
        Me.RichTextBox2.Text = "Booking a Pitch:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "1) Enter the member's ID" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Click 'Get Member'" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Select the " & _
            "member's pitch requirements" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "4) Click 'Book'"
        '
        'frmBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(946, 465)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pitch Booking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxDateTime.ResumeLayout(False)
        Me.grpbxDateTime.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxPitch As System.Windows.Forms.ComboBox
    Friend WithEvents txtFinalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtBookEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBookMemID As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalPrice As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblPitchNumber As System.Windows.Forms.Label
    Friend WithEvents lblMemberEmail As System.Windows.Forms.Label
    Friend WithEvents lblMemberID As System.Windows.Forms.Label
    Friend WithEvents btnConfBook As System.Windows.Forms.Button
    Friend WithEvents btnCancel3 As System.Windows.Forms.Button
    Friend WithEvents grpbxDateTime As System.Windows.Forms.GroupBox
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents comboboxMM As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxHH As System.Windows.Forms.ComboBox
    Friend WithEvents btnGetMember As System.Windows.Forms.Button
    Friend WithEvents lblStartPitch As System.Windows.Forms.Label
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents comboboxPayment As System.Windows.Forms.ComboBox
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents ComboSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblPitchSize As System.Windows.Forms.Label
    Friend WithEvents lblTransID As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
End Class
