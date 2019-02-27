<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArchive
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
        Me.grpbxArchive = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.grpbxArchive1 = New System.Windows.Forms.GroupBox()
        Me.lblTotalMark = New System.Windows.Forms.Label()
        Me.txtTotalMark = New System.Windows.Forms.TextBox()
        Me.radbtnMarkAll = New System.Windows.Forms.RadioButton()
        Me.btnArchive1 = New System.Windows.Forms.Button()
        Me.btnRentalDisplay4 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpbxArchive.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxArchive1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxArchive
        '
        Me.grpbxArchive.BackColor = System.Drawing.SystemColors.Control
        Me.grpbxArchive.Controls.Add(Me.btnBack)
        Me.grpbxArchive.Controls.Add(Me.btnRentalDisplay4)
        Me.grpbxArchive.Controls.Add(Me.btnArchive1)
        Me.grpbxArchive.Controls.Add(Me.grpbxArchive1)
        Me.grpbxArchive.Controls.Add(Me.DataGridView1)
        Me.grpbxArchive.Location = New System.Drawing.Point(12, 12)
        Me.grpbxArchive.Name = "grpbxArchive"
        Me.grpbxArchive.Size = New System.Drawing.Size(544, 411)
        Me.grpbxArchive.TabIndex = 0
        Me.grpbxArchive.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 365)
        Me.DataGridView1.TabIndex = 0
        '
        'grpbxArchive1
        '
        Me.grpbxArchive1.Controls.Add(Me.radbtnMarkAll)
        Me.grpbxArchive1.Controls.Add(Me.txtTotalMark)
        Me.grpbxArchive1.Controls.Add(Me.lblTotalMark)
        Me.grpbxArchive1.Location = New System.Drawing.Point(312, 28)
        Me.grpbxArchive1.Name = "grpbxArchive1"
        Me.grpbxArchive1.Size = New System.Drawing.Size(200, 100)
        Me.grpbxArchive1.TabIndex = 1
        Me.grpbxArchive1.TabStop = False
        '
        'lblTotalMark
        '
        Me.lblTotalMark.AutoSize = True
        Me.lblTotalMark.Location = New System.Drawing.Point(6, 33)
        Me.lblTotalMark.Name = "lblTotalMark"
        Me.lblTotalMark.Size = New System.Drawing.Size(73, 13)
        Me.lblTotalMark.TabIndex = 0
        Me.lblTotalMark.Text = "Total Marked:"
        '
        'txtTotalMark
        '
        Me.txtTotalMark.Location = New System.Drawing.Point(85, 30)
        Me.txtTotalMark.Name = "txtTotalMark"
        Me.txtTotalMark.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMark.TabIndex = 2
        '
        'radbtnMarkAll
        '
        Me.radbtnMarkAll.AutoSize = True
        Me.radbtnMarkAll.Location = New System.Drawing.Point(74, 68)
        Me.radbtnMarkAll.Name = "radbtnMarkAll"
        Me.radbtnMarkAll.Size = New System.Drawing.Size(63, 17)
        Me.radbtnMarkAll.TabIndex = 3
        Me.radbtnMarkAll.TabStop = True
        Me.radbtnMarkAll.Text = "Mark All"
        Me.radbtnMarkAll.UseVisualStyleBackColor = True
        '
        'btnArchive1
        '
        Me.btnArchive1.Location = New System.Drawing.Point(397, 155)
        Me.btnArchive1.Name = "btnArchive1"
        Me.btnArchive1.Size = New System.Drawing.Size(115, 23)
        Me.btnArchive1.TabIndex = 2
        Me.btnArchive1.Text = "Archive Members"
        Me.btnArchive1.UseVisualStyleBackColor = True
        '
        'btnRentalDisplay4
        '
        Me.btnRentalDisplay4.Location = New System.Drawing.Point(397, 196)
        Me.btnRentalDisplay4.Name = "btnRentalDisplay4"
        Me.btnRentalDisplay4.Size = New System.Drawing.Size(115, 23)
        Me.btnRentalDisplay4.TabIndex = 3
        Me.btnRentalDisplay4.Text = "Rental Display"
        Me.btnRentalDisplay4.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(437, 236)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmArchive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(568, 435)
        Me.Controls.Add(Me.grpbxArchive)
        Me.Name = "frmArchive"
        Me.Text = "Archive Member Details"
        Me.grpbxArchive.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxArchive1.ResumeLayout(False)
        Me.grpbxArchive1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpbxArchive As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnRentalDisplay4 As System.Windows.Forms.Button
    Friend WithEvents btnArchive1 As System.Windows.Forms.Button
    Friend WithEvents grpbxArchive1 As System.Windows.Forms.GroupBox
    Friend WithEvents radbtnMarkAll As System.Windows.Forms.RadioButton
    Friend WithEvents txtTotalMark As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalMark As System.Windows.Forms.Label
End Class
