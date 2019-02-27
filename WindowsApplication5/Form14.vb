Imports MySql.Data.MySqlClient
Public Class frmLogin

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        frmRegister.Show()

        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim conn As MySqlConnection
        'connect to DB
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
        'see if user exits
        If myData.HasRows = 0 Then
            MsgBox("Invalid Login.Please Try again!", MsgBoxStyle.Critical, "Invalid Login")
            txtUsername.Text = ""
            txtPassword.Text = ""
        Else
            MsgBox("Login Accepted!", MsgBoxStyle.Information, "Login successful")
            frmRentalDisplay.Show()

            Me.Hide()
        End If

    End Sub
End Class