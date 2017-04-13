﻿Public Class SearchForm
    Private DB As New DBAccessClass

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'return to portal
        Me.Hide()
    End Sub


    Private Sub Retrieve_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE Sold = 'n' ORDER BY PropertyID")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        HSHPropertyDataGridView.DataSource = DB.DBDataTable

        PurchaseButton.Enabled = False
        ClearPurchaseButton.Enabled = False

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        DB.AddParam("@NumberOfBedrooms", NumberOfBedroomsComboBox.Text & "%")
        DB.AddParam("@NumberOfBathrooms", NumberOfBathroomsComboBox.Text & "%")
        DB.AddParam("@TotalSquareFeet", SquareFeetMaskedTextBox.Text & "%")
        If askingPriceMaskedTextBox.Text.Length = 0 Then
            DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE NumberOfBedrooms LIKE ? AND NumberOfBathrooms LIKE ? AND TotalSquareFeet >= ? AND Sold = 'n' ORDER BY PropertyID")
        Else
            DB.AddParam("@AskingPrice", askingPriceMaskedTextBox.Text & "%")

            DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE NumberOfBedrooms LIKE ? AND NumberOfBathrooms LIKE ? AND TotalSquareFeet >= ?  AND AskingPrice <= ? AND Sold = 'n' ORDER BY PropertyID")
        End If

        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        HSHPropertyDataGridView.DataSource = DB.DBDataTable
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NumberOfBathroomsComboBox.SelectedIndex = -1
        NumberOfBedroomsComboBox.SelectedIndex = -1
        SquareFeetMaskedTextBox.Text = ""
        askingPriceMaskedTextBox.Text = ""

        DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE Sold = 'n' ORDER BY PropertyID")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        HSHPropertyDataGridView.DataSource = DB.DBDataTable
    End Sub
End Class