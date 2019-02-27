Public Class frmConfLogout

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        frmLogin.Show()

        Me.Hide()
        frmRentalDisplay.Hide()
    End Sub

    Private Sub btnNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNO.Click
        frmRentalDisplay.Show()

        Me.Hide()
    End Sub
End Class