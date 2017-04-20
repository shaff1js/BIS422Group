
Public Class Form1
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'close the program
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'open the add window

        AddForm.ShowDialog()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'open the search window

        SearchForm.ShowDialog()
    End Sub
End Class
