Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmChangePass

    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click
        'Exit Form
        frmPreferences.Show()

        Me.Hide()
    End Sub

    Private Sub btnDone3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone3.Click
        'Complete Password change

        'Password Verification
        If txtOldPass.Text <> frmLogin.txtPassword.Text Then
            MsgBox("Old Password is not correct! Please Re-Enter.", MsgBoxStyle.Exclamation, "Old Password")
            txtOldPass.Text = ""
        Else
            Dim Conn As MySqlConnection
            Conn = New MySqlConnection
            Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
            Dim check As Integer
            Dim cmdUser As New MySqlCommand
            Dim daUser As New MySqlDataAdapter
            Dim dsUser As New DataSet

            If txtNewPass.Text <> txtConfPass.Text Then
                MsgBox("New Password and Confirm Password do not match! Please Re-Enter.", MsgBoxStyle.Exclamation, "Non-identical Passwords")
                txtOldPass.Text = ""
                txtNewPass.Text = ""
                txtConfPass.Text = ""
            Else
                If MsgBox("Are you sure you want to edit Password with Username : " & frmLogin.txtUsername.Text & " ?", MsgBoxStyle.YesNo, "Confirm Change") = MsgBoxResult.No Then
                    ' do nothing
                Else
                    Try
                        Conn.Open()
                        cmdUser = Conn.CreateCommand
                        cmdUser.CommandText = "update users set Password='" + txtConfPass.Text + "' where (Username)=('" + frmLogin.txtUsername.Text + "')"
                        check = cmdUser.ExecuteReader.RecordsAffected
                        If check > 0 Then
                            MsgBox("Password with username " & Trim(frmLogin.txtUsername.Text) & " Succesfully Edited", MsgBoxStyle.OkOnly, "Info Update Data User")
                        Else
                            MsgBox("Password with username " & Trim(frmLogin.txtUsername.Text) & " Failure To Edit", MsgBoxStyle.OkOnly, "Info Update Data User")
                        End If
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                    End Try

                    'After password has been changed, you are logged out
                    MsgBox("You are about to be logged out, please log in with new password!", MsgBoxStyle.Information, "Logging Out")

                    'Clear textboxes
                    txtOldPass.Text = ""
                    txtNewPass.Text = ""
                    txtConfPass.Text = ""

                    'Logs user out and clear frmlogin textboxes
                    Me.Hide()
                    frmLogin.Show()
                    frmLogin.txtUsername.Text = ""
                    frmLogin.txtPassword.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub frmChangePass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class