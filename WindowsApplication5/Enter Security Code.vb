Imports MySql.Data.MySqlClient
Public Class frmEnterSecCode

    Private Sub btnCancel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel5.Click
        'Cancels entering security code

        txtSecCode.Text = ""
        txtSecEmail.Text = ""
        Me.Hide()
        frmLogin.linkForgotUser.LinkColor = Color.Blue
        frmLogin.linkForgotPass.LinkColor = Color.Blue
    End Sub

    Private Sub btnDone5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone5.Click
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
        Dim sqlquery = "SELECT * FROM users Where email = '" + txtSecEmail.Text + "' AND SecurityCode = '" + txtSecCode.Text + "'"
        Dim myCommand As New MySqlCommand()
        myCommand.Connection = conn
        myCommand.CommandText = sqlquery
        'start query
        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()
        'see if user exits
        If myData.HasRows = 0 Then
            MsgBox("Invalid Email/Security Code. Please Try again!", MsgBoxStyle.Exclamation, "Invalid Password")
            txtSecEmail.Text = ""
            txtSecCode.Text = ""

            'If user forgot their username
        ElseIf frmLogin.linkForgotUser.LinkColor = Color.Red Then
            frmResetUser.Show()

            frmLogin.Hide()
            Me.Hide()
            frmLogin.linkForgotUser.LinkColor = Color.Blue
            frmLogin.linkForgotPass.LinkColor = Color.Blue

            'If user forgot their password
        ElseIf frmLogin.linkForgotPass.LinkColor = Color.Red Then
            frmResetPass.Show()

            frmLogin.Hide()
            Me.Hide()
            frmLogin.linkForgotUser.LinkColor = Color.Blue
            frmLogin.linkForgotPass.LinkColor = Color.Blue

        End If
    End Sub
End Class