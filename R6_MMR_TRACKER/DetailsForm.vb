Public Class DetailsForm

    Public theDataToShow As Object

    Sub showData()
        detailsBox.Text = theDataToShow
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Sub closeme() Handles Me.Closing
        Form1.Show()
    End Sub
End Class