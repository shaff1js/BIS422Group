Public Class SearchForm
    Private DB As New DBAccessClass

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'return to portal
        Me.Hide()
    End Sub


    Private Sub Retrieve_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshrealestateagent' table. You can move, or remove it, as needed.
        Me.HshrealestateagentTableAdapter.Fill(Me.BIS422_33DataSet.hshrealestateagent)
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshcustomer' table. You can move, or remove it, as needed.
        Me.HshcustomerTableAdapter.Fill(Me.BIS422_33DataSet.hshcustomer)
        DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE Sold = 'n' ORDER BY PropertyID")
        If DB.Exception <> String.Empty Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        HSHPropertyDataGridView.DataSource = DB.DBDataTable

        PurchaseButton.Enabled = False


        DB.ExecuteQuery("SELECT CustomerID FROM HSHCustomer ORDER BY CustomerID")

        If DB.Exception <> String.Empty Then

            MessageBox.Show(DB.Exception)

            Exit Sub

        End If

        CustomerIDComboBox.DataSource = DB.DBDataTable

        DB.ExecuteQuery("SELECT RealEstateAgentID FROM HSHRealEstateAgent ORDER BY RealEstateAgentID")

        If DB.Exception <> String.Empty Then

            MessageBox.Show(DB.Exception)

            Exit Sub

        End If

        RealEstateAgentIDComboBox.DataSource = DB.DBDataTable
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

    Private Sub PurchaseButton_Click(sender As Object, e As EventArgs) Handles PurchaseButton.Click

        If CustomerIDComboBox.Text = "" Then

            MessageBox.Show("Please select a CustomerID.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            CustomerIDComboBox.Focus()

        ElseIf RealEstateAgentIDComboBox.Text = "" Then

            MessageBox.Show("Please select a RealEstateAgentID.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            RealEstateAgentIDComboBox.Focus()

        ElseIf SalePriceMaskedTextBox.Text = "" Then

            MessageBox.Show("Please enter a sale price.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            SalePriceMaskedTextBox.Focus()

        ElseIf DateSoldMaskedTextBox.Text = "" Then

            MessageBox.Show("Please enter the date sold.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            DateSoldMaskedTextBox.Focus()

        Else

            DB.AddParam("@PropertyID", PropertyIDTextBox.Text)

            DB.ExecuteQuery("UPDATE HSHProperty SET Sold = 'Y' WHERE PropertyID = ?")

            If DB.Exception <> String.Empty Then

                MessageBox.Show(DB.Exception)

                Exit Sub

            End If

            DB.AddParam("@SaleID", SaleIDTextBox.Text)

            DB.AddParam("@PropertyID", PropertyIDTextBox.Text)

            DB.AddParam("@RealEstateAgentID", RealEstateAgentIDComboBox.Text)

            DB.AddParam("@CustomerID", CustomerIDComboBox.Text)

            DB.AddParam("@DateSold", DateSoldMaskedTextBox.Text)

            DB.AddParam("@SalePrice", SaleIDTextBox.Text)

            DB.ExecuteQuery("INSERT into HSHClosingSale values(?,?,?,?,?,?)")

            If DB.Exception <> String.Empty Then

                MessageBox.Show(DB.Exception)

                Exit Sub

            End If

            PropertyIDTextBox.Text = ""

            RealEstateAgentIDComboBox.Text = ""

            CustomerIDComboBox.Text = ""

            DateSoldMaskedTextBox.Text = ""

            SalePriceMaskedTextBox.Text = ""

            DB.ExecuteQuery("SELECT PropertyID, PropertyStreetAddress, ZipCode, AskingPrice, NumberOfBedrooms, NumberOfBathrooms, TotalSquareFeet, YearBuilt FROM HSHProperty WHERE Sold = 'n' ORDER BY PropertyID")

            If DB.Exception <> String.Empty Then

                MessageBox.Show(DB.Exception)

                Exit Sub

            End If

            HSHPropertyDataGridView.DataSource = DB.DBDataTable

            PurchaseButton.Enabled = False

            ClearPurchaseButton.Enabled = False

        End If

    End Sub

    Private Sub HSHPropertyDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles HSHPropertyDataGridView.CellClick
        Dim PropertyID As Object
        Dim SaleIDInteger As Integer

        DB.ExecuteQuery("SELECT MAX(SaleID) as MaxID FROM HSHClosingSale")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        DateSoldMaskedTextBox.Text = String.Format("{0:yyyy/MM/dd}", DateTime.Now)

        If IsDBNull(DB.DBDataTable.Rows(0).Item(0)) Then
            SaleIDInteger = 1
        Else
            SaleIDInteger = DB.DBDataTable.Rows(0).Item(0) + 1
        End If

        SaleIDTextBox.Text = SaleIDInteger.ToString()

        If e.RowIndex > -1 Then
            PropertyID = HSHPropertyDataGridView.Rows(e.RowIndex).Cells(0).Value()



            PropertyIDTextBox.Text = PropertyID.ToString


            PurchaseButton.Enabled = True
        End If

    End Sub
End Class