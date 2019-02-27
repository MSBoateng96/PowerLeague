Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChangeUser

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel1.Click
        'Exit Form
        frmPreferences.Show()

        Me.Hide()
    End Sub

    
    Private Sub btnDone2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone2.Click
        'Verification that the username textboxes are not empty
        If txtNewUser.Text = "" Or txtConfUser.Text = "" Then
            MessageBox.Show("Please enter new username details to change username.", "Change Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim Conn As MySqlConnection
            Conn = New MySqlConnection
            Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
            Dim check As Integer
            Dim cmdUser As New MySqlCommand
            Dim daUser As New MySqlDataAdapter
            Dim dsUser As New DataSet

            'Verification for new username
            If txtNewUser.Text <> txtConfUser.Text Then
                MsgBox("New Username and Confirm Username do not match! Please Re-Enter.", MsgBoxStyle.Exclamation, "Non-identical Usernames")
                txtNewUser.Text = ""
                txtConfUser.Text = ""
            Else
                'Confirmation of username change
                If MsgBox("Are you sure to edit your current Username?", MsgBoxStyle.YesNo, "Edit confirm") = MsgBoxResult.No Then
                    txtNewUser.Text = ""
                    txtConfUser.Text = ""
                Else
                    Try
                        Conn.Open()
                        cmdUser = Conn.CreateCommand
                        cmdUser.CommandText = "update users set Username='" + txtConfUser.Text + "' where (Username)=('" + frmLogin.txtUsername.Text + "')"
                        check = cmdUser.ExecuteReader.RecordsAffected
                        If check > 0 Then
                            MsgBox("Username Succesfully Edited to " & txtConfUser.Text & "", MsgBoxStyle.OkOnly, "Change Username")
                        Else
                            MsgBox("Failed in editing Username", MsgBoxStyle.OkOnly, "Change Username")
                        End If
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                    End Try

                    'Clears textboxes and logs the user out
                    MsgBox("You are about to be logged out, please log in with new username!", MsgBoxStyle.Information, "Logging Out")
                    txtNewUser.Text = ""
                    txtConfUser.Text = ""
                    Me.Hide()
                    frmLogin.Show()
                    frmLogin.txtUsername.Text = ""
                    frmLogin.txtPassword.Text = ""
                End If
            End If
        End If
    End Sub
End Class