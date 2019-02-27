<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembership
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAddMember = New System.Windows.Forms.TabPage()
        Me.tabDeleteMember = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpbxAddMember = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnPrintList = New System.Windows.Forms.Button()
        Me.btnPrintDetails = New System.Windows.Forms.Button()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.btnRentalDisplay = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabAddMember.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxAddMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAddMember)
        Me.TabControl1.Controls.Add(Me.tabDeleteMember)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(544, 411)
        Me.TabControl1.TabIndex = 0
        '
        'tabAddMember
        '
        Me.tabAddMember.Controls.Add(Me.btnRentalDisplay)
        Me.tabAddMember.Controls.Add(Me.btnAddMember)
        Me.tabAddMember.Controls.Add(Me.btnPrintDetails)
        Me.tabAddMember.Controls.Add(Me.btnPrintList)
        Me.tabAddMember.Controls.Add(Me.grpbxAddMember)
        Me.tabAddMember.Controls.Add(Me.DataGridView1)
        Me.tabAddMember.Location = New System.Drawing.Point(4, 22)
        Me.tabAddMember.Name = "tabAddMember"
        Me.tabAddMember.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAddMember.Size = New System.Drawing.Size(536, 385)
        Me.tabAddMember.TabIndex = 0
        Me.tabAddMember.Text = "Add Member"
        Me.tabAddMember.UseVisualStyleBackColor = True
        '
        'tabDeleteMember
        '
        Me.tabDeleteMember.Location = New System.Drawing.Point(4, 22)
        Me.tabDeleteMember.Name = "tabDeleteMember"
        Me.tabDeleteMember.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDeleteMember.Size = New System.Drawing.Size(536, 385)
        Me.tabDeleteMember.TabIndex = 1
        Me.tabDeleteMember.Text = "TabPage2"
        Me.tabDeleteMember.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(536, 385)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(274, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'grpbxAddMember
        '
        Me.grpbxAddMember.Controls.Add(Me.TextBox7)
        Me.grpbxAddMember.Controls.Add(Me.TextBox6)
        Me.grpbxAddMember.Controls.Add(Me.TextBox5)
        Me.grpbxAddMember.Controls.Add(Me.TextBox4)
        Me.grpbxAddMember.Controls.Add(Me.TextBox3)
        Me.grpbxAddMember.Controls.Add(Me.TextBox2)
        Me.grpbxAddMember.Controls.Add(Me.TextBox1)
        Me.grpbxAddMember.Controls.Add(Me.Label7)
        Me.grpbxAddMember.Controls.Add(Me.Label6)
        Me.grpbxAddMember.Controls.Add(Me.Label5)
        Me.grpbxAddMember.Controls.Add(Me.Label4)
        Me.grpbxAddMember.Controls.Add(Me.Label3)
        Me.grpbxAddMember.Controls.Add(Me.Label2)
        Me.grpbxAddMember.Controls.Add(Me.Label1)
        Me.grpbxAddMember.Location = New System.Drawing.Point(307, 18)
        Me.grpbxAddMember.Name = "grpbxAddMember"
        Me.grpbxAddMember.Size = New System.Drawing.Size(211, 254)
        Me.grpbxAddMember.TabIndex = 1
        Me.grpbxAddMember.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Forename:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Surname:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address2:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Postcode:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(94, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(94, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 10
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(94, 151)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 11
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(94, 182)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(94, 213)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        '
        'btnPrintList
        '
        Me.btnPrintList.Location = New System.Drawing.Point(18, 321)
        Me.btnPrintList.Name = "btnPrintList"
        Me.btnPrintList.Size = New System.Drawing.Size(93, 48)
        Me.btnPrintList.TabIndex = 2
        Me.btnPrintList.Text = "Print Membership List"
        Me.btnPrintList.UseVisualStyleBackColor = True
        '
        'btnPrintDetails
        '
        Me.btnPrintDetails.Location = New System.Drawing.Point(190, 321)
        Me.btnPrintDetails.Name = "btnPrintDetails"
        Me.btnPrintDetails.Size = New System.Drawing.Size(102, 48)
        Me.btnPrintDetails.TabIndex = 1
        Me.btnPrintDetails.Text = "Print and Email Membership Details"
        Me.btnPrintDetails.UseVisualStyleBackColor = True
        '
        'btnAddMember
        '
        Me.btnAddMember.Location = New System.Drawing.Point(423, 295)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(95, 23)
        Me.btnAddMember.TabIndex = 3
        Me.btnAddMember.Text = "Add Member"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'btnRentalDisplay
        '
        Me.btnRentalDisplay.Location = New System.Drawing.Point(423, 334)
        Me.btnRentalDisplay.Name = "btnRentalDisplay"
        Me.btnRentalDisplay.Size = New System.Drawing.Size(95, 23)
        Me.btnRentalDisplay.TabIndex = 4
        Me.btnRentalDisplay.Text = "Rental Display"
        Me.btnRentalDisplay.UseVisualStyleBackColor = True
        '
        'frmMembership
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 435)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMembership"
        Me.Text = "Membership"
        Me.TabControl1.ResumeLayout(False)
        Me.tabAddMember.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxAddMember.ResumeLayout(False)
        Me.grpbxAddMember.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabAddMember As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tabDeleteMember As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents grpbxAddMember As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddMember As System.Windows.Forms.Button
    Friend WithEvents btnPrintDetails As System.Windows.Forms.Button
    Friend WithEvents btnPrintList As System.Windows.Forms.Button
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRentalDisplay As System.Windows.Forms.Button
End Class
