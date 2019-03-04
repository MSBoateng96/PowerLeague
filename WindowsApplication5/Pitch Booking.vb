Imports MySql.Data.MySqlClient

Public Class frmBooking
    Private TargetDT As DateTime
    Dim SetTime As Integer

    Private Sub btnCancel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel3.Click
        'Cancel Booking
        frmRentalDisplay.Show()
        Me.Hide()

        'Clear Booking Fields
        txtBookMemID.Text = ""
        txtBookEmail.Text = ""
        ComboSize.Text = "Select Size"
        comboboxPitch.Text = "Select Pitch"
        comboboxHH.Text = "HH"
        comboboxMM.Text = "MM"
        comboboxPayment.Text = ""
        txtFinalPrice.Text = ""

    End Sub

    Private Sub btnConfBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfBook.Click
        'Verification Checks for Fields so they are not blank
        If txtBookMemID.Text = "" Then
            MessageBox.Show("Please enter a Customer's Member ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ComboSize.Text = "Select Size" Then
            MessageBox.Show("Please select a Pitch Size!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf comboboxPitch.Text = "Select Pitch" Then
            MessageBox.Show("Please select a Pitch Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf comboboxHH.Text = "hh" And comboboxMM.Text = "mm" Then
            MessageBox.Show("Please select a time for the pitch rental!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf comboboxPayment.Text = "" Then
            MessageBox.Show("Please select a Payment method!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Completing Pitch Booking
        ElseIf MsgBox("Are you sure you want to book Pitch " & Trim(comboboxPitch.SelectedItem) & "?", MsgBoxStyle.YesNo, "Pitch Booking") = MsgBoxResult.Yes Then
            lblStartPitch.Text = comboboxHH.SelectedItem + ":" + comboboxMM.SelectedItem
            Call MembersBooking()
            Call TransactionsBooking()
            lblTransID.Text = lblTransID.Text + 1

            'Authorising Chosen Pitch
            If comboboxPitch.SelectedItem = "1" Then
                frmRentalDisplay.lblPitch1.Text = "Pitch1"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If

            If comboboxPitch.SelectedItem = "2" Then
                frmRentalDisplay.lblPitch2.Text = "Pitch2"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "3" Then
                frmRentalDisplay.lblPitch3.Text = "Pitch3"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "4" Then
                frmRentalDisplay.lblPitch4.Text = "Pitch4"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "5" Then
                frmRentalDisplay.lblPitch5.Text = "Pitch5"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "6" Then
                frmRentalDisplay.lblPitch6.Text = "Pitch6"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "7" Then
                frmRentalDisplay.lblPitch7.Text = "Pitch7"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "8" Then
                frmRentalDisplay.lblPitch8.Text = "Pitch8"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "9" Then
                frmRentalDisplay.lblPitch9.Text = "Pitch9"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "10" Then
                frmRentalDisplay.lblPitch10.Text = "Pitch10"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "11" Then
                frmRentalDisplay.lblPitch11.Text = "Pitch11"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If
            If comboboxPitch.SelectedItem = "12" Then
                frmRentalDisplay.lblPitch12.Text = "Pitch12"
                frmRentalDisplay.Show()
                Me.Hide()
                frmRentalDisplay.start_pause.PerformClick()
            End If

            'Clear textboxes
            txtBookMemID.Text = ""
            txtBookEmail.Text = ""
            ComboSize.Text = "Select Size"
            comboboxPitch.Text = "Select Pitch"
            comboboxHH.Text = "HH"
            comboboxMM.Text = "MM"
            comboboxPayment.Text = ""
            txtFinalPrice.Text = ""
        End If

    End Sub

    Private Sub frmBooking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Sets Current Date and Time
        lblDate1.Text = System.DateTime.Now.ToString("dd/MM/yyyy")
        lblTime.Text = System.DateTime.Now.ToString("HH:mm")
        txtDate.Text = lblDate1.Text
        lblDate2.Text = System.DateTime.Now.ToString("yyyy/MM/dd")

        'Shows UserID for User that is currently logged in
        Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
        Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Users where (Username)=('" + frmLogin.txtUsername.Text + "')", objConnection)
        Dim objDataSet As DataSet
        Dim objDataView As DataView
        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Users")
        objDataView = New DataView(objDataSet.Tables("Users"))
        lblUserID.DataBindings.Clear()
        lblUserID.DataBindings.Add("Text", objDataView, "UserID")

        'Create TransactionID for Booking
        Call TransactionID()

    End Sub

    Private Sub btnGetMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetMember.Click
        'Shows member's email in testbox (member who wants to book a pitch) 
        Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
        Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Members where (MemberID)=('" + txtBookMemID.Text + "')", objConnection)
        Dim objDataSet As DataSet
        Dim objDataView As DataView
        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Members")
        objDataView = New DataView(objDataSet.Tables("Members"))

        txtBookEmail.DataBindings.Clear()
        txtBookEmail.DataBindings.Add("Text", objDataView, "Email")
        If txtBookEmail.Text = "" Then
            MsgBox("No Member with this ID exists. Please Try Again", MsgBoxStyle.Exclamation, "Non-existing Member ID")
        End If

    End Sub

    Private Sub MembersBooking()
        'Update Members Table

        'Declaring SQL Variables
        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        Dim check As Integer
        Dim cmdMember As New MySqlCommand
        Dim daMember As New MySqlDataAdapter
        Dim dsMember As New DataSet

        Try
            Conn.Open()
            cmdMember = Conn.CreateCommand
            cmdMember.CommandText = "update members set LastRental='" + txtDate.Text + "', TimeSlot='" + lblStartPitch.Text + "', TotalRentals = TotalRentals+1 where (MemberID)=('" + txtBookMemID.Text + "')"
            check = cmdMember.ExecuteReader.RecordsAffected

            'Confirming the booking
            If check > 0 Then
                MsgBox("Member with ID: " & Trim(txtBookMemID.Text) & " has successfully booked Pitch " & Trim(comboboxPitch.SelectedItem) & " today at " & Trim(lblStartPitch.Text) & ".", MsgBoxStyle.OkOnly, "Pitch Booking")
            Else
                MsgBox("Booking Failed! Please try again!", MsgBoxStyle.OkOnly, "Pitch Booking")
            End If
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.Critical, "Connection Error !!")
        End Try
    End Sub

    Private Sub TransactionsBooking()
        'Update Transactions Table

        'All online payements are card payments
        If comboboxPayment.SelectedItem = "Online" Then
            comboboxPayment.SelectedItem = "Card"
        End If

        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        'connecting to my sql database
        Try
            Conn.Open()

        Catch ex As Exception
            MsgBox("Error connecting to database")

        End Try
        Dim MyAdapter As New MySqlDataAdapter
        Dim SQLQuery = "SELECT * FROM transactions"
        'selecting from my table
        Dim MyCommand As New MySqlCommand
        MyCommand.Connection = Conn

        MyCommand.CommandText = SQLQuery

        MyAdapter.SelectCommand = MyCommand

        Dim MyData As MySqlDataReader
        MyData = MyCommand.ExecuteReader()
        Conn.Close()
        Conn.Open()

        'Adding data to the transactions tables
        SQLQuery = "INSERT INTO transactions (TransID, MemberID, Email, PitchNumber, TimeSlot, DateBooked, Price, PaymentMethod, UserID) VALUES('" + lblTransID.Text + "', '" + txtBookMemID.Text + "', '" + txtBookEmail.Text + "', '" + comboboxPitch.SelectedItem + "', '" + lblStartPitch.Text + "', '" + lblDate2.Text + "', '" + txtFinalPrice.Text + "', '" + comboboxPayment.SelectedItem + "', '" + lblUserID.Text + "')"
        MyCommand.CommandText = SQLQuery

        MyData = MyCommand.ExecuteReader
    End Sub

    Private Sub TransactionID()
        'Creates a new transactionID

        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT( TransID ) AS Trans_ID FROM(Transactions)"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count

            lblTransID.Text = reader("Trans_ID").ToString()
            Convert.ToInt32(lblTransID.Text)

            If lblTransID.Text < 899999999 Then
                lblTransID.Text = lblTransID.Text + 100000001
            End If

        End While
        Conn.Close()
    End Sub

    Private Sub ComboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboSize.SelectedIndexChanged
        If ComboSize.SelectedItem = "5-A-Side" Then
            'Show Price of a 5-A-Side Pitch
            Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
            Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Pitches where (PitchNumber)=('" + frmUtilities.lblPitch1.Text + "')", objConnection)
            Dim objDataSet As DataSet
            Dim objDataView As DataView

            objDataSet = New DataSet()
            objDataAdapter.Fill(objDataSet, "Pitches")
            objDataView = New DataView(objDataSet.Tables("Pitches"))

            txtFinalPrice.DataBindings.Clear()
            txtFinalPrice.DataBindings.Add("Text", objDataView, "Price")

            'If 5-A-Side pitch chosen, remove 7-A-Side pitches
            comboboxPitch.Items.Remove("6")
            comboboxPitch.Items.Remove("7")
            comboboxPitch.Items.Remove("8")
            comboboxPitch.Items.Remove("9")
            comboboxPitch.Items.Remove("10")
            comboboxPitch.Items.Remove("11")
            comboboxPitch.Items.Remove("12")

            'If all the items are removed due to a change in pitch selection
            If comboboxPitch.Items.Count = 0 Then
                comboboxPitch.Items.Add("1")
                comboboxPitch.Items.Add("2")
                comboboxPitch.Items.Add("3")
                comboboxPitch.Items.Add("4")
                comboboxPitch.Items.Add("5")
            End If

        ElseIf ComboSize.SelectedItem = "7-A-Side" Then
            'Show Price of a 7-A-Side Pitch
            Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
            Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Pitches where (PitchNumber)=('" + frmUtilities.lblPitch6.Text + "')", objConnection)
            Dim objDataSet As DataSet
            Dim objDataView As DataView

            objDataSet = New DataSet()
            objDataAdapter.Fill(objDataSet, "Pitches")
            objDataView = New DataView(objDataSet.Tables("Pitches"))

            txtFinalPrice.DataBindings.Clear()
            txtFinalPrice.DataBindings.Add("Text", objDataView, "Price")

            'If 7-A-Side pitch chosen, remove 5-A-Side pitches
            comboboxPitch.Items.Remove("1")
            comboboxPitch.Items.Remove("2")
            comboboxPitch.Items.Remove("3")
            comboboxPitch.Items.Remove("4")
            comboboxPitch.Items.Remove("5")

            'If all the items are removed due to a change in pitch selection
            If comboboxPitch.Items.Count = 0 Then
                comboboxPitch.Items.Add("6")
                comboboxPitch.Items.Add("7")
                comboboxPitch.Items.Add("8")
                comboboxPitch.Items.Add("9")
                comboboxPitch.Items.Add("10")
                comboboxPitch.Items.Add("11")
                comboboxPitch.Items.Add("12")
            End If
            End If
    End Sub
End Class