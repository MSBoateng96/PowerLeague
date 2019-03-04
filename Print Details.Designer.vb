<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.lvMembers = New System.Windows.Forms.ListView()
        Me.MemberID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Surname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Forename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Gender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.County = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.City = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Postcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Mobile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnCancel10 = New System.Windows.Forms.Button()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lvPitches = New System.Windows.Forms.ListView()
        Me.PitchNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PitchSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog2 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument3 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog3 = New System.Windows.Forms.PrintPreviewDialog()
        Me.lvTrans = New System.Windows.Forms.ListView()
        Me.TransID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MemberID1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PitchNumber1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeSlot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateBooked = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PaymentMethod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UserID1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDataType = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvMembers
        '
        Me.lvMembers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MemberID, Me.Surname, Me.Forename, Me.Gender, Me.Address, Me.County, Me.City, Me.Postcode, Me.Telephone, Me.Mobile, Me.Email, Me.UserID})
        Me.lvMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMembers.Location = New System.Drawing.Point(12, 78)
        Me.lvMembers.Name = "lvMembers"
        Me.lvMembers.Size = New System.Drawing.Size(931, 233)
        Me.lvMembers.TabIndex = 0
        Me.lvMembers.UseCompatibleStateImageBehavior = False
        Me.lvMembers.View = System.Windows.Forms.View.Details
        Me.lvMembers.Visible = False
        '
        'MemberID
        '
        Me.MemberID.Text = "MemberID"
        Me.MemberID.Width = 79
        '
        'Surname
        '
        Me.Surname.Text = "Surname"
        Me.Surname.Width = 86
        '
        'Forename
        '
        Me.Forename.Text = "Forename"
        Me.Forename.Width = 90
        '
        'Gender
        '
        Me.Gender.Text = "Gender"
        Me.Gender.Width = 64
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 86
        '
        'County
        '
        Me.County.Text = "County"
        Me.County.Width = 85
        '
        'City
        '
        Me.City.Text = "City"
        Me.City.Width = 78
        '
        'Postcode
        '
        Me.Postcode.Text = "Postcode"
        Me.Postcode.Width = 81
        '
        'Telephone
        '
        Me.Telephone.Text = "Telephone"
        Me.Telephone.Width = 80
        '
        'Mobile
        '
        Me.Mobile.Text = "Mobile"
        Me.Mobile.Width = 78
        '
        'Email
        '
        Me.Email.Text = "Email"
        '
        'UserID
        '
        Me.UserID.Text = "UserID"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(12, 326)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 37)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btnCancel10
        '
        Me.btnCancel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel10.Location = New System.Drawing.Point(855, 326)
        Me.btnCancel10.Name = "btnCancel10"
        Me.btnCancel10.Size = New System.Drawing.Size(88, 37)
        Me.btnCancel10.TabIndex = 2
        Me.btnCancel10.Text = "Cancel"
        Me.btnCancel10.UseVisualStyleBackColor = True
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrint.Location = New System.Drawing.Point(307, 24)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(357, 34)
        Me.lblPrint.TabIndex = 5
        Me.lblPrint.Text = "Print Power League Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication5.My.Resources.Resources.Icon
        Me.PictureBox1.Location = New System.Drawing.Point(16, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lvPitches
        '
        Me.lvPitches.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.PitchNumber, Me.PitchSize, Me.Price})
        Me.lvPitches.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPitches.Location = New System.Drawing.Point(12, 78)
        Me.lvPitches.Name = "lvPitches"
        Me.lvPitches.Size = New System.Drawing.Size(931, 233)
        Me.lvPitches.TabIndex = 6
        Me.lvPitches.UseCompatibleStateImageBehavior = False
        Me.lvPitches.View = System.Windows.Forms.View.Details
        Me.lvPitches.Visible = False
        '
        'PitchNumber
        '
        Me.PitchNumber.Text = "Pitch Number"
        Me.PitchNumber.Width = 200
        '
        'PitchSize
        '
        Me.PitchSize.Text = "Pitch Size"
        Me.PitchSize.Width = 200
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 200
        '
        'PrintDocument2
        '
        '
        'PrintPreviewDialog2
        '
        Me.PrintPreviewDialog2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog2.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog2.Enabled = True
        Me.PrintPreviewDialog2.Icon = CType(resources.GetObject("PrintPreviewDialog2.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog2.Name = "PrintPreviewDialog2"
        Me.PrintPreviewDialog2.Visible = False
        '
        'PrintDocument3
        '
        '
        'PrintPreviewDialog3
        '
        Me.PrintPreviewDialog3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog3.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog3.Enabled = True
        Me.PrintPreviewDialog3.Icon = CType(resources.GetObject("PrintPreviewDialog3.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog3.Name = "PrintPreviewDialog3"
        Me.PrintPreviewDialog3.Visible = False
        '
        'lvTrans
        '
        Me.lvTrans.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TransID, Me.MemberID1, Me.Email1, Me.PitchNumber1, Me.TimeSlot, Me.DateBooked, Me.Price1, Me.PaymentMethod, Me.UserID1})
        Me.lvTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvTrans.Location = New System.Drawing.Point(12, 78)
        Me.lvTrans.Name = "lvTrans"
        Me.lvTrans.Size = New System.Drawing.Size(931, 233)
        Me.lvTrans.TabIndex = 7
        Me.lvTrans.UseCompatibleStateImageBehavior = False
        Me.lvTrans.View = System.Windows.Forms.View.Details
        Me.lvTrans.Visible = False
        '
        'TransID
        '
        Me.TransID.Text = "TransID"
        Me.TransID.Width = 76
        '
        'MemberID1
        '
        Me.MemberID1.Text = "MemberID"
        Me.MemberID1.Width = 81
        '
        'Email1
        '
        Me.Email1.Text = "Email"
        Me.Email1.Width = 248
        '
        'PitchNumber1
        '
        Me.PitchNumber1.Text = "Pitch Number"
        Me.PitchNumber1.Width = 99
        '
        'TimeSlot
        '
        Me.TimeSlot.Text = "TimeSlot"
        Me.TimeSlot.Width = 73
        '
        'DateBooked
        '
        Me.DateBooked.Text = "Date Booked"
        Me.DateBooked.Width = 99
        '
        'Price1
        '
        Me.Price1.Text = "Price"
        '
        'PaymentMethod
        '
        Me.PaymentMethod.Text = "Payment Method"
        Me.PaymentMethod.Width = 124
        '
        'UserID1
        '
        Me.UserID1.Text = "UserID"
        Me.UserID1.Width = 80
        '
        'lblDataType
        '
        Me.lblDataType.AutoSize = True
        Me.lblDataType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataType.Location = New System.Drawing.Point(839, 57)
        Me.lblDataType.Name = "lblDataType"
        Me.lblDataType.Size = New System.Drawing.Size(104, 18)
        Me.lblDataType.TabIndex = 8
        Me.lblDataType.Text = "Type of Data"
        Me.lblDataType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(955, 371)
        Me.Controls.Add(Me.lblDataType)
        Me.Controls.Add(Me.lvTrans)
        Me.Controls.Add(Me.lvPitches)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lvMembers)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvMembers As System.Windows.Forms.ListView
    Friend WithEvents MemberID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Surname As System.Windows.Forms.ColumnHeader
    Friend WithEvents Forename As System.Windows.Forms.ColumnHeader
    Friend WithEvents Gender As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
    Friend WithEvents County As System.Windows.Forms.ColumnHeader
    Friend WithEvents City As System.Windows.Forms.ColumnHeader
    Friend WithEvents Postcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Mobile As System.Windows.Forms.ColumnHeader
    Friend WithEvents Email As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserID As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnCancel10 As System.Windows.Forms.Button
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lvPitches As System.Windows.Forms.ListView
    Friend WithEvents PitchNumber As System.Windows.Forms.ColumnHeader
    Friend WithEvents PitchSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintDocument2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog2 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog3 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents lvTrans As System.Windows.Forms.ListView
    Friend WithEvents TransID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MemberID1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Email1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PitchNumber1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TimeSlot As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateBooked As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PaymentMethod As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserID1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDataType As System.Windows.Forms.Label
End Class
