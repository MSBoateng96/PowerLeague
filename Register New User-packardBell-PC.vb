Imports MySql.Data.MySqlClient
Public Class frmRegister
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Cancel registering new user
        frmLogin.Show()

        Me.Hide()

        'Clear textboxes
        txtUserSur.Text = ""
        txtUserFore.Text = ""
        txtUserAdd.Text = ""
        comboUserCounty.Text = "Select County..."
        comboUserCity.Text = "Select City..."
        txtUserPost.Text = ""
        txtUserTele.Text = ""
        txtUserMob.Text = ""
        txtUserEma.Text = ""
        txtUsername1.Text = ""
        txtPassword1.Text = ""
        txtConfPass.Text = ""
        txtSecCode.Text = ""
        txtConfCode.Text = ""
    End Sub

    Private Sub btnRegister1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister1.Click 
        'Register New User

        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        'connecting to my sql database
        Try
            Conn.Open()

        Catch ex As Exception
            MsgBox("Error connecting to database")

        End Try

        'Textbox Validation
        If txtUserSur.Text = "" Then
            MsgBox("Please enter your Surname", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserFore.Text = "" Then
            MsgBox("Please enter your Forename", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserAdd.Text = "" Then
            MsgBox("Please enter your address", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf comboUserCounty.Text = "Select County..." Then
            MsgBox("Please enter your County", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf comboUserCity.Text = "Select City..." Then
            MsgBox("Please enter your City", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserPost.Text = "" Then
            MsgBox("Please enter your Postcode", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserTele.Text = "" Then
            MsgBox("Please enter your Telephone", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserMob.Text = "" Then
            MsgBox("Please enter your Mobile", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUserEma.Text = "" Then
            MsgBox("Please enter your Email", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtUsername1.Text = "" Then
            MsgBox("Please enter your Username", MsgBoxStyle.Exclamation, "Empty Field")

        ElseIf txtSecCode.Text = "" Then
            MsgBox("Please enter your SecCode", MsgBoxStyle.Exclamation, "Empty Field")

            'Password verification
        ElseIf Not (txtConfPass.Text = txtPassword1.Text) Then
            MsgBox("Passwords do not match. Please re-enter!", MsgBoxStyle.Exclamation, "Failed Password")
            txtUsername1.Text = ""
            txtPassword1.Text = ""
            txtConfPass.Text = ""
            txtSecCode.Text = ""
            txtConfCode.Text = ""
            ElseIf Not (txtConfCode.Text = txtSecCode.Text) Then
                MsgBox("Security Codes do not match. Please re-enter!", MsgBoxStyle.Exclamation, "Failed Security Code")
                txtUsername1.Text = ""
                txtPassword1.Text = ""
                txtConfPass.Text = ""
                txtSecCode.Text = ""
                txtConfCode.Text = ""
        Else
            Dim MyAdapter As New MySqlDataAdapter
            Dim SQLQuery = "SELECT * FROM users"
            'selecting from my table
            Dim MyCommand As New MySqlCommand
            MyCommand.Connection = Conn

            MyCommand.CommandText = SQLQuery

            MyAdapter.SelectCommand = MyCommand

            Dim MyData As MySqlDataReader
            MyData = MyCommand.ExecuteReader()
            Conn.Close()
            Conn.Open()

            SQLQuery = "INSERT INTO users (UserID, Surname, Forename, Address, County, City, Postcode, Telephone, Mobile, Email, Username, Password, SecurityCode) VALUES('" + txtUserID.Text + "', '" + txtUserSur.Text + "', '" + txtUserFore.Text + "', '" + txtUserAdd.Text + "', '" + comboUserCounty.SelectedItem + "', '" + comboUserCity.SelectedItem + "', '" + txtUserPost.Text + "', '" + txtUserTele.Text + "', '" + txtUserMob.Text + "', '" + txtUserEma.Text + "', '" + txtUsername1.Text + "', '" + txtConfPass.Text + "', '" + txtConfCode.Text + "')"
            'choosing fields from form to be added to the database
            MyCommand.CommandText = SQLQuery


            'Complete the registery of a new uer
            MyData = MyCommand.ExecuteReader
            MsgBox("New User has been registered! Proceed to Login.", MsgBoxStyle.Information, "New User")

            'Amending UserID
            txtUserID.Text = txtUserID.Text + 1

            'used to clear the text boxes
            txtUserSur.Text = ""
            txtUserFore.Text = ""
            txtUserAdd.Text = ""
            comboUserCounty.Text = "Select County..."
            comboUserCity.Text = "Select City..."
            txtUserPost.Text = ""
            txtUserTele.Text = ""
            txtUserMob.Text = ""
            txtUserEma.Text = ""
            txtUsername1.Text = ""
            txtPassword1.Text = ""
            txtConfPass.Text = ""
            txtSecCode.Text = ""
            txtConfCode.Text = ""

            'Shows Login form
            frmLogin.Show()
            Me.Hide()
            End If
    End Sub

    Private Sub UserID()
        'Creates new UserID
        Dim Conn As New MySqlConnection("Server =localhost;database=powerleague;user id=root;password=;")

        Dim cmdString As String = "SELECT COUNT( UserID ) AS User_ID FROM(Users)"

        Dim cmd As New MySqlCommand(cmdString, Conn)

        Conn.Open()

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()

            'Displaying  the results of the count

            txtUserID.Text += reader("User_ID").ToString()
            Convert.ToInt32(txtUserID.Text)
            txtUserID.Text = txtUserID.Text + 500001

        End While
        Conn.Close()
    End Sub

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads UserID for new user
        Call UserID()
    End Sub

    Private Sub txtUserTele_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserTele.Validating
        'Length check
        If txtUserTele.Text.Length < 11 Then
            e.Cancel = True

            txtUserTele.SelectAll()
            ErrorProvider1.SetError(txtUserTele, "Telephone Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtUserMob_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserMob.Validating
        'Length check
        If txtUserMob.Text.Length < 11 Then
            e.Cancel = True

            txtUserMob.SelectAll()
            ErrorProvider1.SetError(txtUserMob, "Mobile Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtSecCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSecCode.Validating
        'Length check
        If txtSecCode.Text.Length < 8 Then
            e.Cancel = True

            txtSecCode.SelectAll()
            ErrorProvider1.SetError(txtSecCode, "Security Code must be 8 Digits")
        End If

        'Checks to see if only numeric values are entered
        If IsNumeric(txtSecCode.Text) = False Then
            e.Cancel = True

            ErrorProvider1.SetError(txtSecCode, "Security Code can only contain numbers")
        End If
    End Sub
End Class