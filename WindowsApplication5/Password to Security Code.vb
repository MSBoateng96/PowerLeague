Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmPassSecurity

    Private Sub btnDone5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone5.Click
        'Confirms correct security code and enters
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
            Dim sqlquery = "SELECT * FROM users Where username = '" + frmLogin.txtUsername.Text + "' AND password = '" + txtPassword5.Text + "'"
            Dim myCommand As New MySqlCommand()
            myCommand.Connection = conn
            myCommand.CommandText = sqlquery
            'start query
            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader
            myData = myCommand.ExecuteReader()
            'see if user exits
            If myData.HasRows = 0 Then
                MsgBox("Invalid Password. Please Try again!", MsgBoxStyle.Exclamation, "Invalid Password")
                txtPassword5.Text = ""
        Else
            'Exits the form
            frmSecCode.Show()

            Me.Hide()
            frmPreferences.Hide()
            txtPassword5.Text = ""
            End If
    End Sub

    Private Sub btnCancel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel5.Click
        'Exits form
        frmPreferences.Show()
        Me.Hide()
        txtPassword5.Text = ""
    End Sub
End Class