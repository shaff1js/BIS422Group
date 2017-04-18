Public Class Form2
    Private DB As New DBAccessClass

    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.ExecuteQuery("Select Max(PropertyID) as MaxID FROM hshproperty")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        PropertyTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1
    End Sub


    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If AgentIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the listing AgentID", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgentIDMaskedTextBox.Focus()
        ElseIf OwnerIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter current Owners ID", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OwnerIDMaskedTextBox.Focus()
        ElseIf AddressTextBox.Text = "" Then
            MessageBox.Show("Please enter the street addres", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
        ElseIf ZipCodeMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Zip Code", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ZipCodeMaskedTextBox.Focus()
        ElseIf OfficeIDMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Office ID associated with this property", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OfficeIDMaskedTextBox.Focus()
        ElseIf BedroomsMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the number of bedrooms", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BedroomsMaskedTextBox.Focus()
        ElseIf BathroomsMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enther the number of bathrooms", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BathroomsMaskedTextBox.Focus()
        ElseIf FootageMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the square footage", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FootageMaskedTextBox.Focus()
        ElseIf YearBuiltTextBox.Text = "" Then
            MessageBox.Show("Please enter the year the property was built", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            YearBuiltTextBox.Focus()
        ElseIf PriceTextBox.Text = "" Then
            MessageBox.Show("Please enter the listing price", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PriceTextBox.Focus()
        ElseIf DescriptionTextBox.Text Then
            MessageBox.Show("Please enter property description", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DescriptionTextBox.Focus()
        Else
            DB.AddParam("@PropertyID", PropertyTextBox.Text)
            DB.AddParam("@RealEstateAgentID", AgentIDMaskedTextBox.Text)
            DB.AddParam("@OwnerID", OwnerIDMaskedTextBox.Text)
            DB.AddParam("@StreetAddress", AddressTextBox.Text)
            DB.AddParam("@ZipCode", ZipCodeMaskedTextBox.Text)
            DB.AddParam("@OfficeID", OfficeIDMaskedTextBox.Text)
            DB.AddParam("@NumberOfBedrooms", BedroomsMaskedTextBox.Text)
            DB.AddParam("@NumberOfBathrooms", BathroomsMaskedTextBox.Text)
            DB.AddParam("@TotalSquareFeet", FootageMaskedTextBox.Text)
            DB.AddParam("@YearBuilt", YearBuiltTextBox.Text)
            DB.AddParam("@AskingPrice", PriceTextBox.Text)
            DB.AddParam("@Description", DescriptionTextBox.Text)

            DB.ExecuteQuery("InsertKeyMode Into item values(?,?,?,?,?,?,?,?,?,?,?,?)")
            'austin try using this query instead "INSERT INTO HSHProperty VALUES(?,?,?,?,?,?,?,?,?,?,?,?)" - Jon
            If Not String.IsNullOrEmpty(DB.Exception) Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If

            DB.ExecuteQuery("SELECT MAX(PropertyID) as MaxID FROM hshproperty")
            If Not String.IsNullOrEmpty(DB.Exception) Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            End If
            PropertyTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1

            AgentIDMaskedTextBox.Text = ""
            OwnerIDMaskedTextBox.Text = ""
            AddressTextBox.Text = ""
            ZipCodeMaskedTextBox.Text = ""
            OfficeIDMaskedTextBox.Text = ""
            BedroomsMaskedTextBox.Text = ""
            BathroomsMaskedTextBox.Text = ""
            FootageMaskedTextBox.Text = ""
            YearBuiltTextBox.Text = ""
            PriceTextBox.Text = ""
            DescriptionTextBox.Text = ""

            PropertyTextBox.Focus()
        End If
    End Sub

    Private Sub quitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PropertyTextBox.Text = ""
        AgentIDMaskedTextBox.Text = ""
        OwnerIDMaskedTextBox.Text = ""
        AddressTextBox.Text = ""
        ZipCodeMaskedTextBox.Text = ""
        OfficeIDMaskedTextBox.Text = ""
        BedroomsMaskedTextBox.Text = ""
        BathroomsMaskedTextBox.Text = ""
        FootageMaskedTextBox.Text = ""
        YearBuiltTextBox.Text = ""
        PriceTextBox.Text = ""
        DescriptionTextBox.Text = ""

        Me.Close()
    End Sub

    Private Sub addButton_Click_1(sender As Object, e As EventArgs) Handles addButton.Click

    End Sub
End Class