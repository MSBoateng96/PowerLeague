Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'Loads Register New User form
        frmRegister.Show()
        Me.Hide()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim conn As MySqlConnection
        'connect to Database
        conn = New MySqlConnection
        conn.ConnectionString = "Server =localhost;database=powerleague;user id=root;password=;"
        'check if connection failed
        Try
            conn.Open()
        Catch myerror As MySqlException
            MsgBox("Error connecting to database")
            
        End Try

        'Sql query
        Dim myAdapter As New MySqlDataAdapter
        Dim sqlquery = "SELECT * FROM users Where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'"
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = sqlquery
        'start query
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()

        'checks if user exists
        If myData.HasRows = 0 Then
            MsgBox("Invalid Login. Please Try again!", MsgBoxStyle.Critical, "Invalid Login")
            txtPassword.Text = ""
        Else
            MsgBox("Login Accepted!", MsgBoxStyle.Information, "Login successful")
            'Enters the program
            frmRentalDisplay.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub linkForgotPass_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkForgotPass.LinkClicked
        'loads Enter Security Code form
        frmEnterSecCode.Show()
        linkForgotPass.LinkColor = Color.Red
        linkForgotUser.LinkColor = Color.Blue
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub linkForgotUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkForgotUser.LinkClicked
        'loads Enter Security Code form
        frmEnterSecCode.Show()
        linkForgotUser.LinkColor = Color.Red
        linkForgotPass.LinkColor = Color.Blue
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class