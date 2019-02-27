Public Class frmArchive

    Private Sub btnRentalDisplay4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRentalDisplay4.Click
        frmRentalDisplay.Show()

        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmUtilities.Show()

        Me.Hide()
    End Sub
End Class