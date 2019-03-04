Imports MySql.Data.MySqlClient

Public Class frmResetUser

    Private Sub btnCancel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel7.Click
        'Cancel Username reset
        If MsgBox("Are you sure you want to cancel resetting your username?", MsgBoxStyle.YesNo, "Reset Username") = MsgBoxResult.Yes Then
            rchtxtEmail.Text = ""
            txtNewUser.Text = ""
            txtConfUser.Text = ""
            frmEnterSecCode.txtSecEmail.Text = ""
            frmEnterSecCode.txtSecCode.Text = ""
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnDone7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone7.Click
        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        Dim check As Integer
        Dim cmdUser As New MySqlCommand
        Dim daUser As New MySqlDataAdapter
        Dim dsUser As New DataSet

        'presence checks
        If txtNewUser.Text = "" Then
            MsgBox("Username cannot be empty! Please Enter.", MsgBoxStyle.Exclamation, "Empty Field")

            'Verification checks so the usernames match
        ElseIf txtNewUser.Text <> txtConfUser.Text Then
            MessageBox.Show("Usernames do not match! Please Re-Enter", "Non-Identical Usernames", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                Conn.Open()
                cmdUser = Conn.CreateCommand
                cmdUser.CommandText = "update users set Username='" + txtConfUser.Text + "' where (Email)=('" + rchtxtEmail.Text + "')"
                check = cmdUser.ExecuteReader.RecordsAffected
                If check > 0 Then
                    MsgBox("Username with email: " & Trim(rchtxtEmail.Text) & " succesfully reset! Proceed to Login.", MsgBoxStyle.OkOnly, "Reset Username")
                Else
                    MsgBox("Username with email " & Trim(rchtxtEmail.Text) & " failed to be reset", MsgBoxStyle.OkOnly, "Reset Username")
                End If
                Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
            End Try

            'Clear textboxes and exit current form
            frmEnterSecCode.txtSecEmail.Text = ""
            frmEnterSecCode.txtSecCode.Text = ""
            rchtxtEmail.Text = ""
            txtNewUser.Text = ""
            txtConfUser.Text = ""

            Me.Hide()
            frmLogin.Show()
        End If
    End Sub

    Private Sub rchtxtEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        rchtxtEmail.Text = frmEnterSecCode.txtSecEmail.Text
    End Sub
End Class