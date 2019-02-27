Imports MySql.Data.MySqlClient
Public Class frmSecCode

    Private Sub btnCancel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel6.Click
        'Exit form
        frmPreferences.Show()
        Me.Hide()
    End Sub

    Private Sub txtNewCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNewCode.Validating
        'Length check
        If txtNewCode.Text.Length < 8 Then
            e.Cancel = True

            txtNewCode.SelectAll()
            ErrorProvider1.SetError(txtNewCode, "Security Code must be 8 Characters")
        End If

        'Checks to see if only numeric values are entered
        If IsNumeric(txtNewCode.Text) = False Then
            e.Cancel = True

            ErrorProvider1.SetError(txtNewCode, "Security Code can only contain numbers")
        End If
    End Sub

    Private Sub btnDone6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone6.Click
        'Complete Password change

        'Password Verification
            Dim Conn As MySqlConnection
            Conn = New MySqlConnection
            Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
            Dim check As Integer
            Dim cmdUser As New MySqlCommand
            Dim daUser As New MySqlDataAdapter
            Dim dsUser As New DataSet

        'Verification check for Security Code
        If txtNewCode.Text <> txtConfCode.Text Then
            MsgBox("New Security Code and Confirm Security Code do not match! Please Re-Enter.", MsgBoxStyle.Exclamation, "Non-identical Security  Codes")
            txtConfCode.Text = ""
            txtNewCode.Text = ""
        ElseIf MsgBox("Are you sure to edit Security Code with Username: " & frmLogin.txtUsername.Text & " ?", MsgBoxStyle.YesNo, "Confirm Change") = MsgBoxResult.No Then
            ' do nothing
                Else
                    Try
                        Conn.Open()
                        cmdUser = Conn.CreateCommand
                cmdUser.CommandText = "update users set SecurityCode='" + txtConfCode.Text + "' where (Username)=('" + frmLogin.txtUsername.Text + "')"
                        check = cmdUser.ExecuteReader.RecordsAffected
                        If check > 0 Then
                    MsgBox("Security Code with username " & Trim(frmLogin.txtUsername.Text) & " succesfully edited!", MsgBoxStyle.OkOnly, "Change Security Code")
                        Else
                    MsgBox("Security Code with username " & Trim(frmLogin.txtUsername.Text) & " failed to be edited!", MsgBoxStyle.OkOnly, "Change Security Code")
                        End If
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
            End Try

            'Clear textboxes and edit form
            txtNewCode.Text = ""
            txtConfCode.Text = ""
            frmPreferences.Show()
            Me.Hide()
        End If
    End Sub
End Class