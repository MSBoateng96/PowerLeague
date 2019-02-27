Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmPersonal
    'Sql connection
    Private objConnection As New MySqlConnection("Server=localhost;database=powerleague;user id=root;password= ")
    Private objDataAdapter As New MySqlDataAdapter("SELECT * FROM Users where (Username)=('" + frmLogin.txtUsername.Text + "')", objConnection)
    Private objDataSet As DataSet
    Private objDataView As DataView

    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click
        'Exit current from
        frmPreferences.Show()

        Me.Hide()
    End Sub

    Private Sub btnDone4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone4.Click
        'Confirm edit of personal details
        Dim Conn As MySqlConnection
        Conn = New MySqlConnection
        Conn.ConnectionString = ("Server=localhost;database=powerleague;user id=root;password= ")
        Dim check As Integer
        Dim cmdUser As New MySqlCommand
        Dim daUser As New MySqlDataAdapter
        Dim dsUser As New DataSet

        If txtUserID1.Text = "" Then
            MessageBox.Show("No User ID available, Details cannot be edited", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtUserSur1.Text = "" Or txtUserFore1.Text = "" Or txtUserAdd1.Text = "" Or txtUserPost1.Text = "" Or txtUserTele1.Text = "" Or txtUserPost1.Text = "" Or txtUserEma1.Text = "" Or ComboBox1.Text = "Select County..." Or ComboBox2.Text = "Select City..." Then
                MsgBox("Some textboxes are empty, Please Enter Info!", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            ElseIf MsgBox("Are you sure to edit User with Username : " & frmLogin.txtUsername.Text & " ?", MsgBoxStyle.YesNo, "Edit confirm") = MsgBoxResult.No Then
                ' do nothing
            Else
                Try
                    Conn.Open()
                    cmdUser = Conn.CreateCommand
                    cmdUser.CommandText = "update users set Forename='" + txtUserFore1.Text + "', Surname='" + txtUserSur1.Text + "', Address='" + txtUserAdd1.Text + "', County='" + ComboBox1.SelectedItem + "', City='" + ComboBox2.SelectedItem + "', Postcode='" + txtUserPost1.Text + "', Telephone='" + txtUserTele1.Text + "', Mobile='" + txtUserMob1.Text + "', Email='" + txtUserEma1.Text + "' where (UserID)=('" + txtUserID1.Text + "')"
                    check = cmdUser.ExecuteReader.RecordsAffected
                    If check > 0 Then
                        MsgBox("User with username " & Trim(frmLogin.txtUsername.Text) & " Succesfully Edited", MsgBoxStyle.OkOnly, "Info Update Data User")
                    Else
                        MsgBox("User with username " & Trim(frmLogin.txtUsername.Text) & " Failure To Edit", MsgBoxStyle.OkOnly, "Info Update Data User")
                    End If
                    Conn.Close()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
                End Try

                'Clear textboxes and exit current form
                txtUserFore1.Text = ""
                txtUserSur1.Text = ""
                txtUserAdd1.Text = ""
                ComboBox1.Text = "Select County..."
                ComboBox2.Text = "Select City..."
                txtUserPost1.Text = ""
                txtUserTele1.Text = ""
                txtUserMob1.Text = ""
                txtUserEma1.Text = ""
                Me.Hide()
                frmPreferences.Show()
            End If
        End If
    End Sub

    Private Sub frmPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load user data
        Call FillDataSetAndView()
    End Sub

    Private Sub FillDataSetAndView()
        'Present data from current logged-in user in textboxes
        objDataSet = New DataSet()
        objDataAdapter.Fill(objDataSet, "Users")
        objDataView = New DataView(objDataSet.Tables("Users"))

        txtUserID1.DataBindings.Clear()
        txtUserSur1.DataBindings.Clear()
        txtUserFore1.DataBindings.Clear()
        txtUserAdd1.DataBindings.Clear()
        ComboBox1.DataBindings.Clear()
        ComboBox2.DataBindings.Clear()
        txtUserPost1.DataBindings.Clear()
        txtUserTele1.DataBindings.Clear()
        txtUserMob1.DataBindings.Clear()
        txtUserEma1.DataBindings.Clear()
        txtUserID1.DataBindings.Add("Text", objDataView, "UserID")
        txtUserSur1.DataBindings.Add("Text", objDataView, "Surname")
        txtUserFore1.DataBindings.Add("Text", objDataView, "Forename")
        txtUserAdd1.DataBindings.Add("Text", objDataView, "Address")
        ComboBox1.DataBindings.Add("Text", objDataView, "County")
        ComboBox2.DataBindings.Add("Text", objDataView, "City")
        txtUserPost1.DataBindings.Add("Text", objDataView, "Postcode")
        txtUserTele1.DataBindings.Add("Text", objDataView, "Telephone")
        txtUserMob1.DataBindings.Add("Text", objDataView, "Mobile")
        txtUserEma1.DataBindings.Add("Text", objDataView, "Email")

    End Sub

    Private Sub txtUserTele1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserTele1.Validating
        'Length check
        If txtUserTele1.Text.Length < 11 Then
            e.Cancel = True

            txtUserTele1.SelectAll()
            ErrorProvider1.SetError(txtUserTele1, "Telephone Number must be 11 Characters")
        End If
    End Sub

    Private Sub txtUserMob_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtUserMob1.Validating
        'Length check
        If txtUserMob1.Text.Length < 11 Then
            e.Cancel = True

            txtUserMob1.SelectAll()
            ErrorProvider1.SetError(txtUserMob1, "Mobile Number must be 11 Characters")
        End If
    End Sub
End Class