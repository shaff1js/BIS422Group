
Public Class Form1
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'close the program
        Me.Close()
    End Sub

    Private DB As New DBAccessClass
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click


        'log in to the realty portal
        DB.ExecuteQuery("SELECT EmployeeID, Password FROM HSHEmployee")

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        If UserIDTextBox.Text = "" And PasswordMaskedTextBox.Text = "" Then
            MessageBox.Show("Success")
        Else
            MessageBox.Show("Fail")

        End If

    End Sub
End Class
