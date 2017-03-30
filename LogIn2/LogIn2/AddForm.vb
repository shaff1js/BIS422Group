Public Class AddForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'return to portal
        Me.Hide()
    End Sub


    Private DB As New DBAccessClass

    Private Sub AddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.ExecuteQuery("SELECT MAX(PropertyID) as MaxProperty FROM HSHProperty")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        PropertyTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1
    End Sub

    Private Sub AddPropertyButton_Click(sender As Object, e As EventArgs) Handles AddPropertyButton.Click

        If BranchIDComboBox.Text = "" Then
            MessageBox.Show("Please enter a Branch ID.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf OwnerIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Owner ID.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf StreetAddressTextBox.Text = "" Then
            MessageBox.Show("Please enter the Street Address.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ZipcodeMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Zipcode.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NumberofBedroomsMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Number of Bedrooms.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf NumberofBathroomsMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Number of Barthrooms.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TotalSquareFeetMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Total Square Feet.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf YearbuildMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the year built.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf AskingPriceMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Asking Price.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf DescriptionRichTextBox.Text = "" Then
            MessageBox.Show("Please enter a Description.", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            DB.AddParam("@PropertyID", PropertyTextBox.Text)
            DB.AddParam("@BranchID", BranchIDComboBox.Text)
            DB.AddParam("@OwnerID", OwnerIDMaskedTextBox.Text)
            DB.AddParam("@PropertyStreetAddress", StreetAddressTextBox.Text)
            DB.AddParam("@Zipcode", ZipcodeMaskedTextBox.Text)
            DB.AddParam("@NumberOfBedrooms", NumberofBedroomsMaskedTextBox.Text)
            DB.AddParam("@NumberOfBathrooms", NumberofBathroomsMaskedTextBox.Text)
            DB.AddParam("@TotalSquareFeet", TotalSquareFeetMaskedTextBox.Text)
            DB.AddParam("@YearBuilt", YearbuildMaskedTextBox.Text)
            DB.AddParam("@AskingPrice", AskingPriceMaskedTextBox.Text)
            DB.AddParam("@Description", DescriptionRichTextBox.Text)
            DB.AddParam("@Sold", "N")

            DB.ExecuteQuery("INSERT INTO HSHProperty VALUES (?, ?, ?,?,?,?,?,?,?,?,?,?)")

            If Not String.IsNullOrEmpty(DB.Exception) Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

        End If

        DB.ExecuteQuery("SELECT MAX(PropertyID) as MaxProperty FROM HSHProperty")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        PropertyTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1

        BranchIDComboBox.SelectedIndex = -1
        OwnerIDMaskedTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        ZipcodeMaskedTextBox.Text = ""
        NumberofBedroomsMaskedTextBox.Text = ""
        NumberofBathroomsMaskedTextBox.Text = ""
        TotalSquareFeetMaskedTextBox.Text = ""
        YearbuildMaskedTextBox.Text = ""
        AskingPriceMaskedTextBox.Text = ""
        DescriptionRichTextBox.Text = ""

        OwnerIDMaskedTextBox.Focus()

    End Sub
End Class