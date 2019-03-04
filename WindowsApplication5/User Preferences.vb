Public Class frmPreferences

    'Buttons to enter new forms
    Private Sub btnRentalDisplay3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay3.Click
        frmRentalDisplay.Show()

        Me.Hide()
    End Sub

    Private Sub btnChangeUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeUser.Click
        frmChangeUser.Show()

        Me.Hide()
    End Sub

    Private Sub btnChangePass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePass.Click
        frmChangePass.Show()

        Me.Hide()
    End Sub

    Private Sub btnChangeDeta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeDeta.Click
        frmPersonal.Show()

        Me.Hide()
    End Sub

    Private Sub btnChangeSecurity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeSecurity.Click
        frmPassSecurity.Show()
    End Sub
End Class