Imports MySql.Data.MySqlClient

Public Class frmPrint
    Dim ds As DataSet
    Dim sqlcon As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim p As Integer
    Dim ssql As String

    Private Sub frmPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load the table's listview which is loaded in frmMembership


        'for printing listview for Members table
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1


        'for printing listview for Pitches table
        AddHandler PrintDocument2.PrintPage, AddressOf Me.PrintDocument2_PrintPage
        Me.PrintPreviewDialog2.Document = Me.PrintDocument2

        'for printing listview for Transactions table
        AddHandler PrintDocument3.PrintPage, AddressOf Me.PrintDocument3_PrintPage
        Me.PrintPreviewDialog3.Document = Me.PrintDocument3

        sqlcon = New MySqlConnection("Server = localhost; database=powerleague; uid=root;pwd= ")
        sqlcon.Open()

        If sqlcon.State = ConnectionState.Open Then
            Call showMemberData()
            Call showPitchesData()
            Call showTransData()
        Else
            MsgBox("error")
        End If
    End Sub

    Sub showMemberData()
        ds = New DataSet
        da = New MySqlDataAdapter("Select * from Members", sqlcon)
        da.Fill(ds, "Members")

        lvMembers.Items.Clear()

        'Loading members data into listview
        If ds.Tables("Members").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("Members").Rows.Count - 1
                With lvMembers.Items.Add(ds.Tables("Members").Rows(i).Item(0).ToString)     'MemberID

                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(1).ToString)    'Surname
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(2).ToString)    'Forename
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(3).ToString)    'Gender
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(4).ToString)    'Address
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(5).ToString)    'County
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(6).ToString)    'City
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(7).ToString)    'Postcode
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(8).ToString)    'Telephone
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(9).ToString)    'Mobile
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(10).ToString)   'Email
                    .SubItems.Add(ds.Tables("Members").Rows(i).Item(11).ToString)   'UserID

                End With
            Next
        End If
    End Sub

    Sub showPitchesData()
        ds = New DataSet
        da = New MySqlDataAdapter("Select * from Pitches", sqlcon)
        da.Fill(ds, "Pitches")

        lvPitches.Items.Clear()

        'Loading members data into listview
        If ds.Tables("Pitches").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("Pitches").Rows.Count - 1
                With lvPitches.Items.Add(ds.Tables("Pitches").Rows(i).Item(0).ToString) 'Pitch Number

                    .SubItems.Add(ds.Tables("Pitches").Rows(i).Item(1).ToString)    'Pitch Size
                    .SubItems.Add(ds.Tables("Pitches").Rows(i).Item(2).ToString)    'Price

                End With
            Next
        End If
    End Sub

    Sub showTransData()
        ds = New DataSet
        da = New MySqlDataAdapter("Select * from Transactions", sqlcon)
        da.Fill(ds, "Transactions")

        lvTrans.Items.Clear()

        'Loading members data into listview
        If ds.Tables("Transactions").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("Transactions").Rows.Count - 1
                With lvTrans.Items.Add(ds.Tables("Transactions").Rows(i).Item(0).ToString)     'TransID

                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(1).ToString)    'MemberID
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(2).ToString)    'Email
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(3).ToString)    'Pitch Number
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(4).ToString)    'Time Slot
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(5).ToString)    'Date Booked
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(6).ToString)    'Price
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(7).ToString)    'Payment Method
                    .SubItems.Add(ds.Tables("Transactions").Rows(i).Item(8).ToString)    'UserID

                End With
            Next
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If lvMembers.Visible = True Then
            Dim X, Y As Integer

            X = btnPrint.Left() : Y = btnPrint.Top ' PrintButton.Top
            btnPrint.Top = Y + 2 : btnPrint.Left = X + 2
            'Call Wait(200)
            btnPrint.Top = Y : btnPrint.Left = X

            Me.PrintPreviewDialog1.ShowDialog()
        End If

        If lvPitches.Visible = True Then
            Dim X, Y As Integer

            X = btnPrint.Left() : Y = btnPrint.Top ' PrintButton.Top
            btnPrint.Top = Y + 2 : btnPrint.Left = X + 2
            'Call Wait(200)
            btnPrint.Top = Y : btnPrint.Left = X

            Me.PrintPreviewDialog2.ShowDialog()
        End If

        If lvTrans.Visible = True Then
            Dim X, Y As Integer

            X = btnPrint.Left() : Y = btnPrint.Top ' PrintButton.Top
            btnPrint.Top = Y + 2 : btnPrint.Left = X + 2
            'Call Wait(200)
            btnPrint.Top = Y : btnPrint.Left = X

            Me.PrintPreviewDialog3.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Formatting the printing document
        Dim f As Font = New Font("Microsoft Sans Serif", 12)
        Dim ff As Font = New Font("Arial", 16, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim bluePen As New Pen(Color.Blue, 10)
        Dim X, Y, p As Integer

        'print document title
        e.Graphics.DrawString("Power League - Members Data", ff, Brushes.Blue, 120, 40)

        'print line
        e.Graphics.DrawLine(bluePen, 40, 80, 780, 80)

        'print hor.line data for members
        X = 40
        Y = 95
        For p = 0 To lvMembers.Items.Count - 1

            e.Graphics.DrawString(lvMembers.Items.Item(p).Text, f, br, X, Y)                    'MemberID
            e.Graphics.DrawString(lvMembers.Items(p).SubItems(1).Text, f, br, X + 80, Y)        'Surname
            e.Graphics.DrawString(lvMembers.Items(p).SubItems(2).Text, f, br, X + 230, Y)       'Forename
            e.Graphics.DrawString(lvMembers.Items(p).SubItems(3).Text, f, br, X + 330, Y)       'Gender
            e.Graphics.DrawString(lvMembers.Items(p).SubItems(9).Text, f, br, X + 400, Y)       'Mobile Number
            e.Graphics.DrawString(lvMembers.Items(p).SubItems(10).Text, f, br, X + 510, Y)      'Email

            Y = Y + 20
        Next

        'print power league logo
        e.Graphics.DrawImage(PictureBox1.Image, 40, 40)

    End Sub

    Private Sub btnCancel10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel10.Click
        'Exit form
        frmMembership.Show()
        Me.Hide()

        'Hide the listviews
        lvPitches.Visible = False
        lvMembers.Visible = False
        lvTrans.Visible = False

        'Reset label
        lblDataType.Text = "Type of Data"
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'Formatting the printing document
        Dim f As Font = New Font("Microsoft Sans Serif", 12)
        Dim ff As Font = New Font("Arial", 16, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim bluePen As New Pen(Color.Blue, 10)
        Dim X, Y, p As Integer

        'print document title
        e.Graphics.DrawString("Power League - Pitches Data", ff, Brushes.Blue, 120, 40)

        'print line
        e.Graphics.DrawLine(bluePen, 40, 80, 780, 80)

        'print hor.line data for members
        X = 40
        Y = 95
        For p = 0 To lvPitches.Items.Count - 1

            e.Graphics.DrawString(lvPitches.Items.Item(p).Text, f, br, X, Y)               'Pitch Number
            e.Graphics.DrawString(lvPitches.Items(p).SubItems(1).Text, f, br, X + 80, Y)       'Pitch Size
            e.Graphics.DrawString(lvPitches.Items(p).SubItems(2).Text, f, br, X + 230, Y)       'Price

            Y = Y + 20
        Next

        'print power league logo
        e.Graphics.DrawImage(PictureBox1.Image, 40, 40)

    End Sub

    Private Sub PrintDocument3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage
        'Formatting the printing document
        Dim f As Font = New Font("Microsoft Sans Serif", 12)
        Dim ff As Font = New Font("Arial", 16, FontStyle.Bold)
        Dim br As SolidBrush = New SolidBrush(Color.Black)
        Dim bluePen As New Pen(Color.Blue, 10)
        Dim X, Y, p As Integer

        'print document title
        e.Graphics.DrawString("Power League - Transactions Data", ff, Brushes.Blue, 120, 40)

        'print line
        e.Graphics.DrawLine(bluePen, 40, 80, 780, 80)

        'print hor.line data for members
        X = 40
        Y = 95
        For p = 0 To lvTrans.Items.Count - 1

            e.Graphics.DrawString(lvTrans.Items.Item(p).Text, f, br, X, Y)                    'TransID
            e.Graphics.DrawString(lvTrans.Items(p).SubItems(2).Text, f, br, X + 100, Y)       'Email
            e.Graphics.DrawString(lvTrans.Items(p).SubItems(3).Text, f, br, X + 350, Y)       'Pitch Number
            e.Graphics.DrawString(lvTrans.Items(p).SubItems(5).Text, f, br, X + 400, Y)       'Date Booked
            e.Graphics.DrawString(lvTrans.Items(p).SubItems(6).Text, f, br, X + 510, Y)       'Price

            Y = Y + 20
        Next

        'print power league logo
        e.Graphics.DrawImage(PictureBox1.Image, 40, 40)
    End Sub
End Class