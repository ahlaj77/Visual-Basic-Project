Public Class summaryForm

    Private Sub summaryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display summary of days totals.
        With Me
            .numberofshirtorderTextBox.Text = shirtorderForm.totalnumberofshirtsDecimal.ToString()
            .numberoforderTextBox.Text = shirtorderForm.totalnumberofordersDecimal.ToString()
            .numberoftotaldollarTextBox.Text = shirtorderForm.dollartotalorderDecimal.ToString("C")
        End With
        With Me.backButton
            .Focus()
            .Select()
        End With
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        'Close form
        Me.Close()
    End Sub
End Class