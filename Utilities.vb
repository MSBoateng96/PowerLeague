Imports MySql.Data.MySqlClient
Public Class frmUtilities

    Private Sub btnCancel8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel8.Click
        'Cancels price change and resets original price
        Call PitchPrice5()
        Call PitchPrice7()
        frmRentalDisplay.Show()
        Me.Hide()
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        'Give you freedom to change price
        txtPrice5.ReadOnly = False
        txtPrice7.ReadOnly = False
    End Sub

    Private Sub btnDone8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone8.Click
        If (txtPrice5.ReadOnly And txtPrice7.ReadOnly) = True Then
            MsgBox("Please click the change button to enable ability to change prices!", MsgBoxStyle.Exclamation, "Change Prices")
        ElseIf MsgBox("Set price of 5-A-Side to £" & Trim(txtPrice5.Text) & " and" + Environment.NewLine + "7-A-Side to £" & Trim(txtPrice7.Text) & "?", MsgBoxStyle.YesNo, "Change Prices") = MsgBoxResult.Yes Then
            'Change Price of both pitches
            Call ChangePrice5()
            Call ChangePrice7()
            MsgBox("Prices have been changed!", MsgBoxStyle.Information, "Change Prices")
            txtPrice5.ReadOnly = True
            txtPrice7.ReadOnly = True
            frmRentalDisplay.Show()
            Me.Hide()

        Else
            'Do Nothing and show original price
            Call PitchPrice5()
            Call PitchPrice7()
            txtPrice5.ReadOnly = True
            txtPrice7.ReadOnly = True
            End If
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click
        If MsgBox("Are you sure you want to delete your user account?", MsgBoxStyle.YesNo, "Confirm Delete") = MsgBoxResult.Yes Then
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

            ' Dim Registerfinal As New MySqlDataAdapter


            SQLQuery = "Delete from users where (UserID)=('" + lblUserID.Text + "')"
            'choosing fields from form to be added to the database
            ' MyCommand.Connection = Conn
            MyCommand.CommandText = SQLQuery


            ' Registerfinal.SelectCommand = MyCommand
            MyData = MyCommand.ExecuteReader
            MsgBox("You have successfully deleted your account!" + Environment.NewLine + Environment.NewLine + "You have now been logged out of the system!", MsgBoxStyle.Information, "Deleted User")

            'Takes you to Login form
            frmLogin.Show()
            Me.Hide()
            frmLogin.txtUsername.Text = ""
            frmLogin.txtPassword.Text = ""
            'used to clear the text box

            'Connect to the server with username/password etc
        Else
            'Do Nothing
        End If
    End Sub

    Private Sub frmUtilities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loads Prices into textboxes
        Call PitchPrice5()
        Call PitchPrice7()

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
    End Sub

    Private Sub PitchPrice5()
        'Shows current price of a 5-A-Side pitch in the textbox
        Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
        Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Pitches where (PitchNumber)=('" + lblPitch1.Text + "')", objConnection)
        Dim objDataSet As DataSet
        Dim objDataView As DataView

        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Pitches")
        objDataView = New DataView(objDataSet.Tables("Pitches"))

        txtPrice5.DataBindings.Clear()
        txtPrice5.DataBindings.Add("Text", objDataView, "Price")
    End Sub

    Private Sub PitchPrice7()
        'Shows current price of a 7-A-Side pitch in the textbox
        Dim objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
        Dim objDataAdapter As New MySqlDataAdapter("SELECT * FROM Pitches where (PitchNumber)=('" + lblPitch6.Text + "')", objConnection)
        Dim objDataSet As DataSet
        Dim objDataView As DataView

        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Pitches")
        objDataView = New DataView(objDataSet.Tables("Pitches"))

        txtPrice7.DataBindings.Clear()
        txtPrice7.DataBindings.Add("Text", objDataView, "Price")
    End Sub

    Private Sub ChangePrice5()
        'Changes price of a 5-A-Side pitch
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
            cmdMember.CommandText = "update pitches set Price='" + txtPrice5.Text + "' where (PitchSize)='5-A-Side'"
            check = cmdMember.ExecuteReader.RecordsAffected
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
    End Sub

    Private Sub ChangePrice7()
        'Changes price of a 7-A-Side pitch
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
            cmdMember.CommandText = "update pitches set Price='" + txtPrice7.Text + "' where (PitchSize)='7-A-Side'"
            check = cmdMember.ExecuteReader.RecordsAffected
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
        End Try
    End Sub
End Class