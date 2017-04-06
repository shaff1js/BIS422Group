Public Class SearchForm

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
        If askingPriceMaskedTextBox.text.length = 0 Then
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

    Private Sub HSHPropertyDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles HSHPropertyDataGridView.CellClick
        Dim SaleIDInteger As Integer
        Dim SaleIDString As String
        'select the property to sell by clicking on the row in the grid
        Dim PropertyID As Object
        If e.RowIndex > -1 Then
            PropertyID = HSHPropertyDataGridView.Rows(e.RowIndex).Cells(0).Value()
        End If

        PropertyIDTextBox.Text = PropertyID.ToString

        DB.ExecuteQuery("SELECT MAX(SaleId) as MaxSaleID FROM HSHClosingSale")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        'SaleIDTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1


        If IsDBNull(DB.DBDataTable.Rows(0).Item(0)) Then
            SaleIDInteger = 1
        Else
            SaleIDInteger = DB.DBDataTable.Rows(0).Item(0) + 1
        End If

        SaleIDTextBox.Text = SaleIDInteger.ToString()

        DateSoldMaskedTextBox.Text = String.Format("{0:yyyy/MM/dd}", DateTime.Now)

        'enable the sales buttons
        PurchaseButton.Enabled = True
        ClearPurchaseButton.Enabled = True

    End Sub

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click



        'validate entries
        'still need to figure out how to ensure that customer and real estate values are validated against their respective data bases
        If CustomerIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Customer ID", "Missing Sales Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CustomerIDMaskedTextBox.Focus()
        ElseIf RealEstateAgentIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Real Estate Agent ID", "Missing Sales Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RealEstateAgentIDMaskedTextBox.Focus()
        ElseIf SalePriceMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Sale Price", "Missing Sales Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SalePriceMaskedTextBox.Focus()
        Else
            DB.AddParam("@SaleID", SaleIDTextBox.Text)
            DB.AddParam("@PropertyID", PropertyIDTextBox.Text)
            DB.AddParam("@RealEstateAgentID", RealEstateAgentIDMaskedTextBox.Text)
            DB.AddParam("@CustomerID", CustomerIDMaskedTextBox.Text)
            DB.AddParam("@DateSold", DateSoldMaskedTextBox.Text)
            DB.AddParam("@SalePrice", SalePriceMaskedTextBox.Text)

            'create hshclosing insert
            DB.ExecuteQuery("INSERT INTO HSHClosingSale VALUES (?, ?, ?, ?, ?, ?)")

            If Not String.IsNullOrEmpty(DB.Exception) Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            'update hshproperty to reflect sold status
            DB.AddParam("@propertyid", PropertyIDTextBox.Text)
            DB.ExecuteQuery("UPDATE HSHProperty SET Sold = 'y' WHERE PropertyID = ?")


            If Not String.IsNullOrEmpty(DB.Exception) Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If


            'clear sales boxes and disable sales buttons
            SaleIDTextBox.Clear()
            PropertyIDTextBox.Clear()
            RealEstateAgentIDMaskedTextBox.Clear()
            CustomerIDMaskedTextBox.Clear()
            DateSoldMaskedTextBox.Clear()
            SalePriceMaskedTextBox.Clear()

            PurchaseButton.Enabled = False
            ClearPurchaseButton.Enabled = False

            'reload table
            DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE Sold = 'n' ORDER BY PropertyID")
            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            HSHPropertyDataGridView.DataSource = DB.DBDataTable
        End If


    End Sub

    Private Sub ClearPurchaseButton_Click(sender As Object, e As EventArgs) Handles ClearPurchaseButton.Click

        'clear the purchase area and disable the purchase buttons
        SaleIDTextBox.Clear()
        PropertyIDTextBox.Clear()
        RealEstateAgentIDMaskedTextBox.Clear()
        CustomerIDMaskedTextBox.Clear()
        DateSoldMaskedTextBox.Clear()
        SalePriceMaskedTextBox.Clear()

        PurchaseButton.Enabled = False
        ClearPurchaseButton.Enabled = False

    End Sub
End Class