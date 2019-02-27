' Import Data and SQL Client

Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmMembership

    Private Sub frmMembership_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        'Creates the MemberID when adding a new member
        Call MemberID()

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

        'Disable Members Table Button
        btnMembersTable.Enabled = False
        btnMembersTable.BackColor = Color.FromName("ControlDark")

        'Disable reset button in Edit Members tab
        btnResetGrid.Enabled = False
        btnResetGrid.BackColor = Color.FromName("ControlDark")

        'Disable reset button in Delete Members tab
        btnResetGrid1.Enabled = False
        btnResetGrid1.BackColor = Color.FromName("ControlDark")

        'Disable reset button in Display Members tab
        btnResetGrid2.Enabled = False
        btnResetGrid2.BackColor = Color.FromName("ControlDark")
    End Sub

    Private Sub btnRentalDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay.Click
        'Going back to the Rental Display
        frmRentalDisplay.Show()

        Me.Hide()

        'Clear all textboxes in all tabs of Membership form
        Call ClearDisplayTextboxes()
        Call ClearAddTextboxes()
        Call ClearEditTextBoxes()
        Call ClearDeleteTextBoxes()

    End Sub

    Private Sub btnRentalDisplay1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay1.Click
        'Going back to the Rental Display
        frmRentalDisplay.Show()

        Me.Hide()

        'Clear all textboxes in all tabs of Membership form
        Call ClearDisplayTextboxes()
        Call ClearAddTextboxes()
        Call ClearEditTextBoxes()
        Call ClearDeleteTextBoxes()
    End Sub

    Private Sub btnRentalDisplay2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay2.Click
        'Going back to the Rental Display
        frmRentalDisplay.Show()

        Me.Hide()

        'Clear all textboxes in all tabs of Membership form
        Call ClearDisplayTextboxes()
        Call ClearAddTextboxes()
        Call ClearEditTextBoxes()
        Call ClearDeleteTextBoxes()
    End Sub

    Private Sub btnRentalDisplay3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay3.Click
        'Going back to the Rental Display
        frmRentalDisplay.Show()

        Me.Hide()

        'Clear all textboxes in all tabs of Membership form
        Call ClearDisplayTextboxes()
        Call ClearAddTextboxes()
        Call ClearEditTextBoxes()
        Call ClearDeleteTextBoxes()
    End Sub

    Private Sub btnAddMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMember.Click
        'Registering a New Member

        'Verification for empty fields of textboxes
        If txtAddSur.Text = "" Then
            MsgBox("Please enter your Surname", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddFore.Text = "" Then
            MsgBox("Please enter your Forename", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddressAdd.Text = "" Then
            MsgBox("Please enter your address", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf comboAddCounty.Text = "Select County..." Then
            MsgBox("Please enter your County", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf comboAddCity.Text = "Select City..." Then
            MsgBox("Please enter your City", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddPost.Text = "" Then
            MsgBox("Please enter your Postcode", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddTele.Text = "" Then
            MsgBox("Please enter your Telephone", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddMob.Text = "" Then
            MsgBox("Please enter your Mobile", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtAddEmail.Text = "" Then
            MsgBox("Please enter your Email", MsgBoxStyle.Exclamation, "Empty Field")
        Else
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
            Dim SQLQuery = "SELECT * FROM members"
            'selecting from my table
            Dim MyCommand As New MySqlCommand
            MyCommand.Connection = Conn

            MyCommand.CommandText = SQLQuery

            MyAdapter.SelectCommand = MyCommand

            Dim MyData As MySqlDataReader
            MyData = MyCommand.ExecuteReader()
            Conn.Close()
            Conn.Open()

            ' Dim Registerfinal As New MySqlDataAdapter


            SQLQuery = "INSERT INTO members (MemberID, Forename, Surname, Gender, Address, County, City, Postcode, Telephone, Mobile, Email, TotalRentals, UserID) VALUES('" + txtAddMemID.Text + "', '" + txtAddFore.Text + "', '" + txtAddSur.Text + "', '" + comboAddGender.SelectedItem + "', '" + txtAddressAdd.Text + "', '" + comboAddCounty.SelectedItem + "', '" + comboAddCity.SelectedItem + "', '" + txtAddPost.Text + "', '" + txtAddTele.Text + "', '" + txtAddMob.Text + "', '" + txtAddEmail.Text + "', '" + lblTotalRentals.Text + "', '" + lblUserID.Text + "')"
            'choosing fields from form to be added to the database
            ' MyCommand.Connection = Conn
            MyCommand.CommandText = SQLQuery


            ' Registerfinal.SelectCommand = MyCommand
            MyData = MyCommand.ExecuteReader
            MsgBox("New Member has been registered!", MsgBoxStyle.Information, "New Member")
            Call ClearAddTextboxes()
            txtAddMemID.Text = txtAddMemID.Text + 1
            'used to clear the text box

            'Connect to the server with username/password etc

            'Loading members table in datagridviews
            Call ShowAddMemberData()
            Call ShowDeleteMemberData()
            Call ShowDisplayMemberData()
            Call ShowEditMemberData()
        End If

    End Sub

    Private Sub gridDisplay_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ShowDisplayMemberData()
    End Sub

    Private Sub btnDeleteMember1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMember1.Click 
            MsgBox("Are you sure you want to delete member?", MsgBoxStyle.YesNo, "Confirm Delete")
            If (MsgBoxResult.Yes) Then
            Call DeleteMemberTransactions()
            Call DeleteMember()

            'Refresh the datagridviews
            Call ShowDeleteMemberData()
            Call ShowAddMemberData()
            Call ShowDisplayMemberData()
            Call ShowEditMemberData()

            'Clears the textboxes
            Call ClearDeleteTextBoxes()

            'Resets the MemberID
            Call MemberID()
        End If
    End Sub

    Private Sub gridAdd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ShowAddMemberData()
    End Sub

    Private Sub gridEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ShowEditMemberData()
    End Sub

    Private Sub gridDelete_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call ShowDeleteMemberData()
    End Sub

    Private Sub ShowAddMemberData()
        'Connect to the server with username/password etc

        Dim AddConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim AddDataAdapter As New MySqlDataAdapter()
        Dim AddDataSet As New DataSet()

        'Set the selectCommand properties

        AddDataAdapter.SelectCommand = New MySqlCommand()
        AddDataAdapter.SelectCommand.Connection = AddConnection
        AddDataAdapter.SelectCommand.CommandText = _
            "SELECT MemberID, Surname, Forename, Gender, Address, County, City, Postcode, Telephone, Mobile, Email FROM members"
        AddDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        AddConnection.Open()

        ' Fill the data object with Data

        AddDataAdapter.Fill(AddDataSet, "members")

        ' Set the DataGridView to bind it to my data

        gridAdd.AutoGenerateColumns = True
        gridAdd.DataSource = AddDataSet
        gridAdd.DataMember = "members"

        ' Clean Up

        AddDataAdapter = Nothing
        AddConnection = Nothing
    End Sub

    Private Sub ShowDeleteMemberData()
        'Connect to the server with username/password etc

        Dim DelConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim DelDataAdapter As New MySqlDataAdapter()
        Dim DelDataSet As New DataSet()

        'Set the selectCommand properties

        DelDataAdapter.SelectCommand = New MySqlCommand()
        DelDataAdapter.SelectCommand.Connection = DelConnection
        DelDataAdapter.SelectCommand.CommandText = _
            "SELECT MemberID, Surname, Forename, Gender, Address, County, City, Postcode, Telephone, Mobile, Email FROM members"
        DelDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        DelConnection.Open()

        ' Fill the data object with Data

        DelDataAdapter.Fill(DelDataSet, "members")

        ' Set the DataGridView to bind it to my data

        gridDelete.AutoGenerateColumns = True
        gridDelete.DataSource = DelDataSet
        gridDelete.DataMember = "members"

        ' Clean Up

        DelDataAdapter = Nothing
        DelConnection = Nothing

    End Sub

    Private Sub ShowDisplayMemberData()
        'Connect to the server with username/password etc

        Dim DisplayConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim DisplayDataAdapter As New MySqlDataAdapter()
        Dim MemberDataSet As New DataSet()

        'Set the selectCommand properties

        DisplayDataAdapter.SelectCommand = New MySqlCommand()
        DisplayDataAdapter.SelectCommand.Connection = DisplayConnection
        DisplayDataAdapter.SelectCommand.CommandText = _
            "SELECT MemberID, Surname, Forename, Gender, Address, County, City, Postcode, Telephone, Mobile, Email, TotalRentals, LastRental FROM members"
        DisplayDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        DisplayConnection.Open()

        ' Fill the data object with Data

        DisplayDataAdapter.Fill(MemberDataSet, "members")

        ' Set the DataGridView to bind it to my data

        gridDisplay.AutoGenerateColumns = True
        gridDisplay.DataSource = MemberDataSet
        gridDisplay.DataMember = "members"

        ' Clean Up

        DisplayDataAdapter = Nothing
        DisplayConnection = Nothing
    End Sub

    Private Sub ShowEditMemberData()
        'Connect to the server with username/password etc

        Dim EditConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim EditDataAdapter As New MySqlDataAdapter()
        Dim MemberDataSet As New DataSet()

        'Set the selectCommand properties

        EditDataAdapter.SelectCommand = New MySqlCommand()
        EditDataAdapter.SelectCommand.Connection = EditConnection
        EditDataAdapter.SelectCommand.CommandText = _
            "SELECT MemberID, Surname, Forename, Gender, Address, County, City, Postcode, Telephone, Mobile, Email FROM members"
        EditDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        EditConnection.Open()

        ' Fill the data object with Data

        EditDataAdapter.Fill(MemberDataSet, "members")

        ' Set the DataGridView to bind it to my data

        gridEdit.AutoGenerateColumns = True
        gridEdit.DataSource = MemberDataSet
        gridEdit.DataMember = "members"

        ' Clean Up

        EditDataAdapter = Nothing
        EditConnection = Nothing
    End Sub

    Private Sub ClearDisplayTextboxes()
        txtMonthSales.Text = ""
        txtNumberMembers.Text = ""
        txtTodaySales.Text = ""
        txtTodayTrans.Text = ""
        txtYesterdaySales.Text = ""
        txtYesterdayTrans.Text = ""
        txtMonthSales.Text = ""
        txtYearSales.Text = ""
    End Sub

    Private Sub ClearAddTextboxes()
        txtAddFore.Text = ""
        txtAddSur.Text = ""
        comboAddGender.Text = "Select Gender..."
        txtAddressAdd.Text = ""
        comboAddCounty.Text = "Select County..."
        comboAddCity.Text = " Select City..."
        txtAddPost.Text = ""
        txtAddTele.Text = ""
        txtAddMob.Text = ""
        txtAddEmail.Text = ""
    End Sub

    Private Sub ClearEditTextBoxes()
        txtEditMemID.Text = ""
        txtEditFore.Text = ""
        txtEditSur.Text = ""
        comboEditGender.Text = "Select Gender..."
        txtEditAddress.Text = ""
        comboEditCounty.Text = "Select County..."
        comboEditCity.Text = "Select City..."
        txtEditPost.Text = ""
        txtEditTele.Text = ""
        txtEditMob.Text = ""
        txtEditEma.Text = ""
    End Sub

    Private Sub ClearDeleteTextBoxes()
        txtDelMemID.Text = ""
        txtDelSur.Text = ""
        txtDelFore.Text = ""
        txtDelAddress.Text = ""
        comboDelCounty.Text = "Select County..."
        comboDelCity.Text = "Select City..."
        txtDelPost.Text = ""
    End Sub

    Private Sub EnableEditTextboxes()
        txtEditFore.ReadOnly = False
        txtEditSur.ReadOnly = False
        comboEditGender.Enabled = True
        comboEditGender.BackColor = Color.FromName("Window")
        txtEditAddress.ReadOnly = False
        comboEditCounty.Enabled = True
        comboEditCounty.BackColor = Color.FromName("Window")
        comboEditCity.Enabled = True
        comboEditCity.BackColor = Color.FromName("Window")
        txtEditPost.ReadOnly = False
        txtEditTele.ReadOnly = False
        txtEditMob.ReadOnly = False
        txtEditEma.ReadOnly = False
    End Sub

    Private Sub DisableEditTextboxes()
        txtEditMemID.ReadOnly = True
        txtEditFore.ReadOnly = True
        txtEditSur.ReadOnly = True
        comboEditGender.Enabled = False And comboEditGender.BackColor = Color.FromName("Control")
        txtEditAddress.ReadOnly = True
        comboEditCounty.Enabled = False And comboEditCounty.BackColor = Color.FromName("Control")
        comboEditCity.Enabled = False And comboEditCity.BackColor = Color.FromName("Control")
        txtEditPost.ReadOnly = True
        txtEditTele.ReadOnly = True
        txtEditMob.ReadOnly = True
        txtEditEma.ReadOnly = True
    End Sub

    Private Sub gridEdit_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridEdit.CellContentClick
        'After selecting member, loads their data into textboxes
        Dim i As Integer
        i = gridEdit.CurrentRow.Index
        txtEditMemID.Text = gridEdit.Item(0, i).Value   'MemberID   
        txtEditSur.Text = gridEdit.Item(1, i).Value     'Surname
        txtEditFore.Text = gridEdit.Item(2, i).Value    'Forename
        comboEditGender.Text = gridEdit.Item(3, i).Value    'Gender
        txtEditAddress.Text = gridEdit.Item(4, i).Value 'Address
        comboEditCounty.Text = gridEdit.Item(5, i).Value    'County
        comboEditCity.Text = gridEdit.Item(6, i).Value  'City
        txtEditPost.Text = gridEdit.Item(7, i).Value    'Postcode
        txtEditTele.Text = gridEdit.Item(8, i).Value    'Telephone
        txtEditMob.Text = gridEdit.Item(9, i).Value     'Mobile
        txtEditEma.Text = gridEdit.Item(10, i).Value    'Email

        'Makes all textboxes read only before editing
        Call DisableEditTextboxes()
        btnUnlock.Text = "Unlock"
        btnUnlock.Visible = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Declares variables
        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        Dim check As Integer
        Dim cmdMember As New MySqlCommand
        Dim daMember As New MySqlDataAdapter
        Dim dsMember As New DataSet

        'Confirm editing of member information
        If btnUnlock.Text = "Lock" Then

            'Verification for empty fields of textboxes
            If txtEditMemID.Text = "" Then
                MessageBox.Show("Please Select a Member to Edit!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf txtEditSur.Text = "" Then
                MsgBox("Please enter your Surname", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditFore.Text = "" Then
                MsgBox("Please enter your Forename", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditAddress.Text = "" Then
                MsgBox("Please enter your address", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf comboEditCounty.Text = "Select County..." Then
                MsgBox("Please enter your County", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf comboEditCity.Text = "Select City..." Then
                MsgBox("Please enter your City", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditPost.Text = "" Then
                MsgBox("Please enter your Postcode", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditTele.Text = "" Then
                MsgBox("Please enter your Telephone", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditMob.Text = "" Then
                MsgBox("Please enter your Mobile", MsgBoxStyle.Exclamation, "Empty Field")

            ElseIf txtEditEma.Text = "" Then
                MsgBox("Please enter your Email", MsgBoxStyle.Exclamation, "Empty Field")

            Else
                If MsgBox("Are you sure to edit Member data with ID : " & txtEditMemID.Text & " ?", MsgBoxStyle.YesNo, "Edit confirm") = MsgBoxResult.No Then
                    ' do nothing
                Else
                    Try
                        Conn.Open()
                        cmdMember = Conn.CreateCommand
                        cmdMember.CommandText = "update members set Forename='" + txtEditFore.Text + "', Surname='" + txtEditSur.Text + "', Gender='" + comboEditGender.SelectedItem + "', Address='" + txtEditAddress.Text + "', County='" + comboEditCounty.SelectedItem + "', City='" + comboEditCity.SelectedItem + "', Postcode='" + txtEditPost.Text + "', Telephone='" + txtEditTele.Text + "', Mobile='" + txtEditMob.Text + "', Email='" + txtEditEma.Text + "' where (MemberID)=('" + txtEditMemID.Text + "')"
                        check = cmdMember.ExecuteReader.RecordsAffected
                        If check > 0 Then
                            MsgBox("Member With ID " & Trim(txtEditMemID.Text) & " Succesfully Edited", MsgBoxStyle.OkOnly, "Info Update Data Member ")
                        Else
                            MsgBox("Member With ID " & Trim(txtEditMemID.Text) & " Failure To Edit", MsgBoxStyle.OkOnly, "Info Update Data Member ")
                        End If
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                    End Try
                End If
            End If

            'Refreshes data in all datagridviews
            Call ShowEditMemberData()
            Call ShowAddMemberData()
            Call ShowDeleteMemberData()
            Call ShowDisplayMemberData()

            'Clears all the textboxes
            Call ClearEditTextBoxes()

            'Enable only forename and surname textboxes
            Call EnableSearchEditTextboxes()

        ElseIf btnUnlock.Text = "Unlock" Then
            MsgBox("Please unlock textboxes to allow member to be edited!", MsgBoxStyle.Information, "Unlock Textboxes")
        End If

    End Sub

    Private Sub gridDelete_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridDelete.CellContentClick
        'Using a checkbox to select a user and load their details into the textboxes
        If e.ColumnIndex = 0 Then
            If gridDelete(0, e.RowIndex).Value() = False Then
                gridDelete(0, e.RowIndex).Value = True
                Dim isChecked As Boolean = CType(Me.gridDelete(e.ColumnIndex, e.RowIndex).Value, Boolean)
                If isChecked Then
                    'If check box is checked, uncheck all the rows, the current row would be checked later.
                    For Each row As DataGridViewRow In Me.gridDelete.Rows
                        row.Cells(e.ColumnIndex).Value = False
                    Next
                    Dim i As Integer
                    i = gridDelete.CurrentRow.Index
                    txtDelMemID.Text = gridDelete.Item(1, i).Value  'MemberID
                    txtDelSur.Text = gridDelete.Item(2, i).Value    'Surname
                    txtDelFore.Text = gridDelete.Item(3, i).Value   'Forename
                    txtDelAddress.Text = gridDelete.Item(5, i).Value    'Address
                    comboDelCounty.Text = gridDelete.Item(6, i).Value   'County
                    comboDelCity.Text = gridDelete.Item(7, i).Value     'City
                    txtDelPost.Text = gridDelete.Item(8, i).Value   'Postcode
                Else
                    ClearDeleteTextBoxes()
                End If
            End If
        End If
    End Sub

    Private Sub btnUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnlock.Click
        'Enable edit textboxes
        If btnUnlock.Text = "Unlock" Then
            btnUnlock.Text = "Lock"
            Call EnableEditTextboxes()

            'Disable edit textboxes
        ElseIf btnUnlock.Text = "Lock" Then
            btnUnlock.Text = "Unlock"
            Call DisableEditTextboxes()
        End If
    End Sub

    Private Sub MemberID()

        'Creating the member ID
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT( MemberID ) AS Member_ID FROM(Members)"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count

            txtAddMemID.Text += reader("Member_ID").ToString()
            Convert.ToInt32(txtAddMemID.Text)
            txtAddMemID.Text = txtAddMemID.Text + 100001

        End While
        Conn.Close()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear all textboxes
        Call ClearDeleteTextBoxes()

    End Sub

    Private Sub btnPrintList2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintList2.Click
        'Show Print Form
        frmPrint.Show()
        Me.Hide()

        If btnMembersTable.BackColor = Color.FromName("ControlDark") Then
            frmPrint.lvMembers.Visible = True
            frmPrint.lblDataType.Text = "Members"
        ElseIf btnPitchesTable.BackColor = Color.FromName("ControlDark") Then
            frmPrint.lvPitches.Visible = True
            frmPrint.lblDataType.Text = "Pitches"
        ElseIf btnTransTable.BackColor = Color.FromName("ControlDark") Then
            frmPrint.lvTrans.Visible = True
            frmPrint.lblDataType.Text = "Transactions"
        End If
    End Sub

    Private Sub btnMembersTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMembersTable.Click
        'Present 'Members' Table Data
        Call ShowDisplayMemberData()

        'Remove possibility of double-clicking the button
        btnMembersTable.Enabled = False
        btnMembersTable.BackColor = Color.FromName("ControlDark")

        'Enable the other buttons
        Call EnablePitchesButton()
        Call EnableTransButton()

        'Show pitch number combo box
        If radbtnSearch.Checked = True Then
            lblPitchNumber.Visible = False
            cmbPitch.Visible = False
        End If

    End Sub


    Private Sub btnPitchesTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPitchesTable.Click
        'Present 'Pitches' Table Date
        'Connect to the server with username/password etc
        Dim DisplayConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim DisplayDataAdapter As New MySqlDataAdapter()
        Dim PitchesDataSet As New DataSet()

        'Set the selectCommand properties

        DisplayDataAdapter.SelectCommand = New MySqlCommand()
        DisplayDataAdapter.SelectCommand.Connection = DisplayConnection
        DisplayDataAdapter.SelectCommand.CommandText = _
            "SELECT PitchNumber, PitchSize, Price FROM pitches"
        DisplayDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        DisplayConnection.Open()

        ' Fill the data object with Data

        DisplayDataAdapter.Fill(PitchesDataSet, "pitches")

        ' Set the DataGridView to bind it to my data

        gridDisplay.AutoGenerateColumns = True
        gridDisplay.DataSource = PitchesDataSet
        gridDisplay.DataMember = "pitches"

        ' Clean Up

        DisplayDataAdapter = Nothing
        DisplayConnection = Nothing

        'Remove possibility of double-clicking the button
        btnPitchesTable.Enabled = False
        btnPitchesTable.BackColor = Color.FromName("ControlDark")

        'Enable other buttons
        Call EnableMembersButton()
        Call EnableTransButton()

        'Check statistics button
        radbtnStatistics.Checked = True

    End Sub

    Private Sub ShowTransactionsData()
        'Present 'Transactions' Table Date
        'Connect to the server with username/password etc
        Dim DisplayConnection As New MySqlConnection _
            ("Server =localhost;database=powerleague;user id=root;password=;")
        Dim DisplayDataAdapter As New MySqlDataAdapter()
        Dim TransDataSet As New DataSet()

        'Set the selectCommand properties

        DisplayDataAdapter.SelectCommand = New MySqlCommand()
        DisplayDataAdapter.SelectCommand.Connection = DisplayConnection
        DisplayDataAdapter.SelectCommand.CommandText = _
            "SELECT TransID, MemberID, Email, PitchNumber, TimeSlot, DateBooked, Price, PaymentMethod, UserID FROM transactions"
        DisplayDataAdapter.SelectCommand.CommandType = CommandType.Text

        ' Open the database connection

        DisplayConnection.Open()

        ' Fill the data object with Data

        DisplayDataAdapter.Fill(TransDataSet, "transactions")

        ' Set the DataGridView to bind it to my data

        gridDisplay.AutoGenerateColumns = True
        gridDisplay.DataSource = TransDataSet
        gridDisplay.DataMember = "transactions"

        ' Clean Up

        DisplayDataAdapter = Nothing
        DisplayConnection = Nothing

    End Sub


    Private Sub btnTransTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransTable.Click
        Call ShowTransactionsData()

        'Remove possibility of double-clicking the button
        btnTransTable.Enabled = False
        btnTransTable.BackColor = Color.FromName("ControlDark")

        'Enable other buttons
        Call EnableMembersButton()
        Call EnablePitchesButton()

        'Show pitch number combo box
        If radbtnSearch.Checked = True Then
            lblPitchNumber.Visible = True
            cmbPitch.Visible = True
        End If

    End Sub

    Private Sub EnableMembersButton()
        'Enable Members Button
        btnMembersTable.Enabled = True
        btnMembersTable.BackColor = Color.FromName("Control")
    End Sub

    Private Sub EnablePitchesButton()
        'Enable Pitches Button
        btnPitchesTable.Enabled = True
        btnPitchesTable.BackColor = Color.FromName("Control")
    End Sub

    Private Sub EnableTransButton()
        'Enable Transactions Button
        btnTransTable.Enabled = True
        btnTransTable.BackColor = Color.FromName("Control")
    End Sub

    Private Sub btnCalNoMembers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalNoMembers.Click
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT( MemberID ) AS Member_ID FROM(Members)"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count

            txtNumberMembers.Text += reader("Member_ID").ToString()

        End While
        Conn.Close()

    End Sub

    Private Sub btnTodaySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodaySales.Click
        'Setting today's date
        txtTodaySales.Text = System.DateTime.Now.ToString("yyyy/MM/dd")

        'Calculating today's total sales
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT SUM( Price ) AS Total_Sales FROM(Transactions) where (DateBooked)=('" & txtTodaySales.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the sum
            txtTodaySales.Text = ""
            txtTodaySales.ForeColor = Color.FromName("WindowText")
            txtTodaySales.Text += "£" + reader("Total_Sales").ToString
            If txtTodaySales.Text = "£" Then
                txtTodaySales.Text = "£0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub btnTodayTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodayTrans.Click
        'Setting toay's date
        txtTodayTrans.Text = System.DateTime.Now.ToString("yyyy/MM/dd")

        'Calculating today's total number of transactions
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT( TransID ) AS Total_Trans FROM(Transactions) where (DateBooked)=('" & txtTodayTrans.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtTodayTrans.Text = ""
            txtTodayTrans.ForeColor = Color.FromName("WindowText")
            txtTodayTrans.Text += reader("Total_Trans").ToString

        End While
        Conn.Close()
    End Sub

    Private Sub btnYesterdaySales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYesterdaySales.Click
        'Setting the previous day's date
        txtYesterdaySales.Text = System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd")

        'Calculating previous day's total sales
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT SUM( Price ) AS Total_Sales FROM(Transactions) where (DateBooked)=('" & txtYesterdaySales.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtYesterdaySales.Text = ""
            txtYesterdaySales.ForeColor = Color.FromName("WindowText")
            txtYesterdaySales.Text += "£" + reader("Total_Sales").ToString
            If txtYesterdaySales.Text = "£" Then
                txtYesterdaySales.Text = "£0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub btnYesterdayTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYesterdayTrans.Click
        'Setting today's date
        txtYesterdayTrans.Text = System.DateTime.Now.AddDays(-1).ToString("yyyy/MM/dd")

        'Calculating previous day's total number of transactions
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT(TransID) AS Total_Trans FROM(Transactions) where (DateBooked)=('" & txtYesterdayTrans.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtYesterdayTrans.Text = ""
            txtYesterdayTrans.ForeColor = Color.FromName("WindowText")
            txtYesterdayTrans.Text = reader("Total_Trans").ToString
            If txtYesterdayTrans.Text = "" Then
                txtYesterdayTrans.Text = "0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub txtAddTele_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAddTele.Validating
        'Length check
        If txtAddTele.Text.Length < 11 Then
            e.Cancel = True

            txtAddTele.SelectAll()
            ErrorProvider1.SetError(txtAddTele, "Telephone Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtAddMob_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAddMob.Validating
        'Length check
        If txtAddMob.Text.Length < 11 Then
            e.Cancel = True

            txtAddMob.SelectAll()
            ErrorProvider1.SetError(txtAddMob, "Mobile Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtEditTele_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEditTele.Validating
        'Length check
        If txtEditTele.Text.Length < 11 Then
            e.Cancel = True

            txtEditTele.SelectAll()
            ErrorProvider1.SetError(txtEditTele, "Telephone Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtEditMob_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEditMob.Validating
        'Length check
        If txtEditMob.Text.Length < 11 Then
            e.Cancel = True

            txtEditMob.SelectAll()
            ErrorProvider1.SetError(txtEditMob, "Mobile Number must be 11 Characters")
        End If
    End Sub

    Private Sub EnableSearchEditTextboxes()
        'Enables only forename and surname textboxes
        txtEditMemID.ReadOnly = True
        txtEditFore.ReadOnly = False
        txtEditSur.ReadOnly = False
        txtEditAddress.ReadOnly = True
        comboEditGender.Enabled = False And comboEditGender.BackColor = Color.FromName("Control")
        comboEditCounty.Enabled = False And comboEditCounty.BackColor = Color.FromName("Control")
        comboEditCity.Enabled = False And comboEditCity.BackColor = Color.FromName("Control")
        txtEditPost.ReadOnly = True
        txtEditTele.ReadOnly = True
        txtEditMob.ReadOnly = True
        txtEditEma.ReadOnly = True
    End Sub

    Private Sub btnClear2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear2.Click
        Call ClearEditTextBoxes()
        Call EnableSearchEditTextboxes()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Enable Reset Button
        btnResetGrid.Enabled = True
        btnResetGrid.BackColor = Color.FromName("Control")

        Dim con As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            'opening the connection
            con.Open()
            'store your select query to a variable(sql)
            sql = "SELECT * FROM members WHERE Forename = '" & txtEditFore.Text.ToString & "' AND Surname = '" & txtEditSur.Text.ToString & "' "
            'set a new specific table in the database
            dt = New DataTable
            'Set your MySQL COMMANDS
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter(sql, con)
            'set the MySqlDataAdapter to add or refresh rows in a specified range in the dataset 
            'to match those in the data source the data Table name.
            da.Fill(dt)
            'to get or set the data source to diplay in the DataGridView
            gridEdit.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Releases all resources used by the MySqlDataAdapter
        da.Dispose()

        Dim MyData As MySqlDataReader
        MyData = cmd.ExecuteReader()

        'checks if member exists
        If MyData.HasRows = 0 Then
            MsgBox("No Member exists with this search criteria. Please try again!", MsgBoxStyle.Exclamation, "No Member")
            btnResetGrid.PerformClick()
            Call ClearEditTextBoxes()
        Else
            Call ClearEditTextBoxes()

            'Enable Reset Button
            btnResetGrid.Enabled = True
            btnResetGrid.BackColor = Color.FromName("Control")
        End If

        'close the connection
        con.Close()

    End Sub

    Private Sub btnResetGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetGrid.Click
        'Edit Members Table

        'Present 'Members' Table Data
        Call ShowEditMemberData()

        'Remove possibility of double-clicking the button
        btnResetGrid.Enabled = False
        btnResetGrid.BackColor = Color.FromName("ControlDark")
    End Sub

    Private Sub btnSearch1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch1.Click
        'Enable Reset Button
        btnResetGrid1.Enabled = True
        btnResetGrid1.BackColor = Color.FromName("Control")

        Dim con As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            'opening the connection
            con.Open()
            'store your select query to a variable(sql)
            sql = "SELECT * FROM members WHERE Forename = '" & txtDelFore.Text.ToString & "' AND Surname = '" & txtDelSur.Text.ToString & "' "
            'set a new specific table in the database
            dt = New DataTable
            'Set your MySQL COMMANDS
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter(sql, con)
            'set the MySqlDataAdapter to add or refresh rows in a specified range in the dataset 
            'to match those in the data source the data Table name.
            da.Fill(dt)
            'to get or set the data source to diplay in the DataGridView
            gridDelete.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Releases all resources used by the MySqlDataAdapter
        da.Dispose()

        Dim MyData As MySqlDataReader
        MyData = cmd.ExecuteReader()

        'checks if member exists

        'If member doesn't exists
        If MyData.HasRows = 0 Then
            MsgBox("No Member exists with this search criteria. Please try again!", MsgBoxStyle.Exclamation, "No Member")
            btnResetGrid1.PerformClick()
            Call ClearDeleteTextBoxes()
        Else
            'If member does exist
            Call ClearDeleteTextBoxes()

            'Enable Reset Button
            btnResetGrid1.Enabled = True
            btnResetGrid1.BackColor = Color.FromName("Control")
        End If

        'close the connection
        con.Close()
    End Sub

    Private Sub btnResetGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetGrid1.Click
        'Delete Members Table

        'Present 'Members' Table Data
        Call ShowDeleteMemberData()

        'Remove possibility of double-clicking the button
        btnResetGrid1.Enabled = False
        btnResetGrid1.BackColor = Color.FromName("ControlDark")

    End Sub

    Private Sub btnMonthSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthSales.Click
        'Setting month period
        Dim thisMonth As New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
        Dim firstDayLastMonth As DateTime
        Dim lastDayLastMonth As DateTime

        firstDayLastMonth = thisMonth.AddMonths(-1)
        lastDayLastMonth = thisMonth.AddDays(-1)

        txtMonthSales.Text = firstDayLastMonth.ToString("yyyy/MM/dd")
        lblLastDayLastMonth.Text = lastDayLastMonth.ToString("yyyy/MM/dd")

        'Calculating previous month's total sales
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT SUM( Price ) AS Total_Sales FROM(Transactions) where (DateBooked) BETWEEN ('" & txtMonthSales.Text & "') AND ('" & lblLastDayLastMonth.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtMonthSales.Text = ""
            txtMonthSales.ForeColor = Color.FromName("WindowText")
            txtMonthSales.Text += "£" + reader("Total_Sales").ToString
            If txtMonthSales.Text = "£" Then
                txtMonthSales.Text = "£0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub btnYearSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYearSales.Click
        'Setting year period
        Dim thisYear As New DateTime(DateTime.Today.Year, 1, 1)
        Dim firstDayLastYear As DateTime
        Dim lastDayLastYear As DateTime

        firstDayLastYear = thisYear.AddYears(-1)
        lastDayLastYear = thisYear.AddDays(-1)

        txtYearSales.Text = firstDayLastYear.ToString("yyyy/MM/dd")
        lblLastDayLastYear.Text = lastDayLastYear.ToString("yyyy/MM/dd")

        'Calculating previous years's total sales
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT SUM( Price ) AS Total_Sales FROM(Transactions) where (DateBooked) BETWEEN ('" & txtYearSales.Text & "') AND ('" & lblLastDayLastYear.Text & "')"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtYearSales.Text = ""
            txtYearSales.ForeColor = Color.FromName("WindowText")
            txtYearSales.Text += "£" + reader("Total_Sales").ToString
            If txtYearSales.Text = "£" Then
                txtYearSales.Text = "£0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub btnOverallSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOverallSales.Click
        'Calculating overall total sales
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT SUM( Price ) AS Total_Sales FROM(Transactions)"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count
            txtOverallSales.Text = ""
            txtOverallSales.ForeColor = Color.FromName("WindowText")
            txtOverallSales.Text += "£" + reader("Total_Sales").ToString
            If txtOverallSales.Text = "£" Then
                txtOverallSales.Text = "£0"
            End If
        End While
        Conn.Close()
    End Sub

    Private Sub radbtnSearch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnSearch.CheckedChanged
        grpSearch.Show()

        grpStatistics.Hide()
    End Sub

    Private Sub radbtnStatistics_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radbtnStatistics.CheckedChanged
        grpStatistics.Show()

        grpSearch.Hide()
    End Sub

    Private Sub btnSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch2.Click
        'Enable Reset Button
        btnResetGrid2.Enabled = True
        btnResetGrid2.BackColor = Color.FromName("Control")

        If btnMembersTable.BackColor = Color.FromName("ControlDark") Then
            Call SearchMembersTable()
        ElseIf btnTransTable.BackColor = Color.FromName("ControlDark") Then
            Call SearchTransactionsTable()
        End If

        'If member does exist
        txtEmail.Text = ""
        cmbPitch.Text = ""

        'Enable Reset Button
        btnResetGrid2.Enabled = True
        btnResetGrid2.BackColor = Color.FromName("Control")
    End Sub

    Private Sub btnResetGrid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetGrid2.Click
        'Display Members Table

        'Present 'Members' Table Data
        If btnMembersTable.BackColor = Color.FromName("ControlDark") Then
            Call ShowDisplayMemberData()
        ElseIf btnTransTable.BackColor = Color.FromName("ControlDark") Then
            Call ShowTransactionsData()
        End If

        'Remove possibility of double-clicking the button
        btnResetGrid2.Enabled = False
        btnResetGrid2.BackColor = Color.FromName("ControlDark")
    End Sub

    Private Sub SearchMembersTable()
        Dim con As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            'opening the connection
            con.Open()
            'store your select query to a variable(sql)
            sql = "SELECT * FROM members WHERE Email = '" & txtEmail.Text.ToString & "' "
            'set a new specific table in the database
            dt = New DataTable
            'Set your MySQL COMMANDS
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter(sql, con)
            'set the MySqlDataAdapter to add or refresh rows in a specified range in the dataset 
            'to match those in the data source the data Table name.
            da.Fill(dt)
            'to get or set the data source to diplay in the DataGridView
            gridDisplay.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Releases all resources used by the MySqlDataAdapter
        da.Dispose()

        Dim MyData As MySqlDataReader
        MyData = cmd.ExecuteReader()

        'checks if member exists

        'If member doesn't exists
        If MyData.HasRows = 0 Then
            MsgBox("No Member exists with this search criteria. Please try again!", MsgBoxStyle.Exclamation, "No Member")
            btnResetGrid2.PerformClick()
            txtEmail.Text = ""
        End If

        'close the connection
        con.Close()
    End Sub

    Private Sub SearchTransactionsTable()
        Dim con As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable

        Try
            'opening the connection
            con.Open()
            'store your select query to a variable(sql)
            sql = "SELECT * FROM transactions WHERE Email = '" & txtEmail.Text.ToString & "' AND PitchNumber = '" & cmbPitch.SelectedItem.ToString & "' "
            'set a new specific table in the database
            dt = New DataTable
            'Set your MySQL COMMANDS
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da = New MySqlDataAdapter(sql, con)
            'set the MySqlDataAdapter to add or refresh rows in a specified range in the dataset 
            'to match those in the data source the data Table name.
            da.Fill(dt)
            'to get or set the data source to diplay in the DataGridView
            gridDisplay.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Releases all resources used by the MySqlDataAdapter
        da.Dispose()

        Dim MyData As MySqlDataReader
        MyData = cmd.ExecuteReader()

        'checks if transactions history exists

        'If member doesn't exists
        If MyData.HasRows = 0 Then
            MsgBox("No Transaction history exists with this search criteria. Please try again!", MsgBoxStyle.Exclamation, "No Transaction")
            btnResetGrid2.PerformClick()
            txtEmail.Text = ""
        End If

        'close the connection
        con.Close()
    End Sub

    Private Sub DeleteMember()
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
        Dim SQLQuery = "SELECT * FROM members"
        'selecting from my table
        Dim MyCommand As New MySqlCommand
        MyCommand.Connection = Conn

        MyCommand.CommandText = SQLQuery

        MyAdapter.SelectCommand = MyCommand

        Dim MyData As MySqlDataReader
        MyData = MyCommand.ExecuteReader()
        Conn.Close()
        Conn.Open()

        ' Dim Registerfinal As New MySqlDataAdapter


        SQLQuery = "Delete from members where (MemberID)=('" + txtDelMemID.Text + "')"
        'choosing fields from form to be added to the database
        ' MyCommand.Connection = Conn
        MyCommand.CommandText = SQLQuery


        ' Registerfinal.SelectCommand = MyCommand
        MyData = MyCommand.ExecuteReader
        MsgBox("Member has been deleted!", MsgBoxStyle.Information, "Deleted Member")
        txtDelMemID.Text = ""
        'used to clear the text box

        'Connect to the server with username/password etc
    End Sub

    Private Sub DeleteMemberTransactions()
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

        ' Dim Registerfinal As New MySqlDataAdapter


        SQLQuery = "Delete from transactions where (MemberID)=('" + txtDelMemID.Text + "')"
        'choosing fields from form to be added to the database
        ' MyCommand.Connection = Conn
        MyCommand.CommandText = SQLQuery


        ' Registerfinal.SelectCommand = MyCommand
        MyData = MyCommand.ExecuteReader
    End Sub
End Class
