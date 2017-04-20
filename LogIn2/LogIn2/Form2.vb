Public Class AddForm
    Private DB As New DBAccessClass

    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshproperty' table. You can move, or remove it, as needed.
        Me.HshpropertyTableAdapter.Fill(Me.BIS422_33DataSet.hshproperty)
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshbranch' table. You can move, or remove it, as needed.
        Me.HshbranchTableAdapter.Fill(Me.BIS422_33DataSet.hshbranch)
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshpropertyowner' table. You can move, or remove it, as needed.
        Me.HshpropertyownerTableAdapter.Fill(Me.BIS422_33DataSet.hshpropertyowner)
        'TODO: This line of code loads data into the 'BIS422_33DataSet.hshrealestateagent' table. You can move, or remove it, as needed.
        Me.HshrealestateagentTableAdapter.Fill(Me.BIS422_33DataSet.hshrealestateagent)
        AgentIDComboBox.Text = ""
        OwnerIDComboBox.Text = ""
        OfficeIDComboBox.Text = ""

        DB.ExecuteQuery("Select Max(PropertyID) as MaxID FROM hshproperty")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        PropertyTextBox.Text = DB.DBDataTable.Rows(0).Item(0) + 1
    End Sub

    Private Sub addButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If AgentIDComboBox.Text = "" Then
            MessageBox.Show("Please enter the listing AgentID", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgentIDComboBox.Focus()
        ElseIf OwnerIDComboBox.Text = "" Then
            MessageBox.Show("Please enter current Owners ID", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OwnerIDComboBox.Focus()
        ElseIf AddressTextBox.Text = "" Then
            MessageBox.Show("Please enter the street addres", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddressTextBox.Focus()
        ElseIf ZipCodeMaskedTextBox.Text = "" Then
            MessageBox.Show("Please enter the Zip Code", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ZipCodeMaskedTextBox.Focus()
        ElseIf OfficeIDComboBox.Text = "" Then
            MessageBox.Show("Please enter the Office ID associated with this property", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OfficeIDComboBox.Focus()
        ElseIf BedroomsComboBox.Text = "" Then
            MessageBox.Show("Please enter the number of bedrooms", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BedroomsComboBox.Focus()
        ElseIf BathroomsComboBox.Text = "" Then
            MessageBox.Show("Please enther the number of bathrooms", "Missing Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BathroomsComboBox.Focus()
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
            DB.AddParam("@RealEstateAgentID", AgentIDComboBox.Text)
            DB.AddParam("@OwnerID", OwnerIDComboBox.Text)
            DB.AddParam("@StreetAddress", AddressTextBox.Text)
            DB.AddParam("@ZipCode", ZipCodeMaskedTextBox.Text)
            DB.AddParam("@OfficeID", OfficeIDComboBox.Text)
            DB.AddParam("@NumberOfBedrooms", BedroomsComboBox.Text)
            DB.AddParam("@NumberOfBathrooms", BathroomsComboBox.Text)
            DB.AddParam("@TotalSquareFeet", FootageMaskedTextBox.Text)
            DB.AddParam("@YearBuilt", YearBuiltTextBox.Text)
            DB.AddParam("@AskingPrice", PriceTextBox.Text)
            DB.AddParam("@Description", DescriptionTextBox.Text)

            DB.ExecuteQuery("INSERT INTO HSHProperty VALUES(?,?,?,?,?,?,?,?,?,?,?,?)")

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

            AgentIDComboBox.Text = ""
            OwnerIDComboBox.Text = ""
            AddressTextBox.Text = ""
            ZipCodeMaskedTextBox.Text = ""
            OfficeIDComboBox.Text = ""
            BedroomsComboBox.Text = ""
            BathroomsComboBox.Text = ""
            FootageMaskedTextBox.Text = ""
            YearBuiltTextBox.Text = ""
            PriceTextBox.Text = ""
            DescriptionTextBox.Text = ""

            PropertyTextBox.Focus()
        End If
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'Close the add form

        PropertyTextBox.Text = ""
        AgentIDComboBox.Text = ""
        OwnerIDComboBox.Text = ""
        AddressTextBox.Text = ""
        ZipCodeMaskedTextBox.Text = ""
        OfficeIDComboBox.Text = ""
        BedroomsComboBox.Text = ""
        BathroomsComboBox.Text = ""
        FootageMaskedTextBox.Text = ""
        YearBuiltTextBox.Text = ""
        PriceTextBox.Text = ""
        DescriptionTextBox.Text = ""

        Me.Close()
    End Sub
End Class