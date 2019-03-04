Imports MySql.Data.MySqlClient
Public Class frmResetPass

    Private Sub btnCancel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel7.Click
        'Cancel Password reset
        If MsgBox("Are you sure you want to cancel resetting your password?", MsgBoxStyle.YesNo, "Reset Password") = MsgBoxResult.Yes Then
            rchtxtEmail.Text = ""
            txtNewPass.Text = ""
            txtConfPass.Text = ""
            frmEnterSecCode.txtSecEmail.Text = ""
            frmEnterSecCode.txtSecCode.Text = ""
            frmLogin.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub rchtxtEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        rchtxtEmail.Text = frmEnterSecCode.txtSecEmail.Text
    End Sub

    Private Sub btnDone7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone7.Click
        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        Dim check As Integer
        Dim cmdUser As New MySqlCommand
        Dim daUser As New MySqlDataAdapter
        Dim dsUser As New DataSet

        If txtNewPass.Text <> txtConfPass.Text Then
            MessageBox.Show("Passwords do not match! Please Re-Enter", "Non-Identical Passwords", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Conn.Open()
                cmdUser = Conn.CreateCommand
                cmdUser.CommandText = "update users set Password='" + txtConfPass.Text + "' where (Email)=('" + rchtxtEmail.Text + "')"
                check = cmdUser.ExecuteReader.RecordsAffected
                If check > 0 Then
                    MsgBox("Password with email: " & Trim(rchtxtEmail.Text) & " succesfully reset! Proceed to Login.", MsgBoxStyle.OkOnly, "Reset User Password")
                Else
                    MsgBox("Password with email " & Trim(rchtxtEmail.Text) & " failed to be reset", MsgBoxStyle.OkOnly, "Reset User Password")
                End If
                Conn.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
            End Try

            'Clear textboxes and exit current form
            frmEnterSecCode.txtSecEmail.Text = ""
            frmEnterSecCode.txtSecCode.Text = ""
            rchtxtEmail.Text = ""
            txtNewPass.Text = ""
            txtConfPass.Text = ""

            Me.Hide()
            frmLogin.Show()
        End If

    End Sub
End Class