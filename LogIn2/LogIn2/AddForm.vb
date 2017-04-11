Public Class AddForm
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'return to portal
        Me.Hide()
    End Sub


    Private DB As New DBAccessClass

    Private Sub AddForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim IterationInteger, BranchIDInteger, BranchIDCountInteger, MaxOwnerIDInteger, MinOwnerIDInteger As Integer

        DB.ExecuteQuery("SELECT Count(BranchID) as BranchCount FROM HSHBranch")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        BranchIDCountInteger = DB.DBDataTable.Rows(0).Item(0)

        DB.ExecuteQuery("SELECT BranchID FROM HSHBranch")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        IterationInteger = 0

        Do
            BranchIDInteger = DB.DBDataTable.Rows(IterationInteger).Item(0)
            BranchIDComboBox.Items.Add(BranchIDInteger)
            IterationInteger = IterationInteger + 1

        Loop Until IterationInteger = BranchIDCountInteger

        'fill owner id dropdown
        DB.ExecuteQuery("SELECT Min(OwnerID) as MinOwnerID FROM HSHPropertyOwner")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If
        MinOwnerIDInteger = DB.DBDataTable.Rows(0).Item(0)

        DB.ExecuteQuery("SELECT Max(OwnerID) as MaxOwnerID FROM HSHPropertyOwner")

        If Not String.IsNullOrEmpty(DB.Exception) Then
            MessageBox.Show(DB.Exception)
            Exit Sub
        End If

        MaxOwnerIDInteger = DB.DBDataTable.Rows(0).Item(0)



        Do
            OwnerIDComboBox.Items.Add(MinOwnerIDInteger)
            MinOwnerIDInteger = MinOwnerIDInteger + 1
        Loop Until MinOwnerIDInteger > MaxOwnerIDInteger

        'set the property ID textbox
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
        ElseIf OwnerIDcombobox.Text = "" Then
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
            DB.AddParam("@OwnerID", OwnerIDComboBox.Text)
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
        OwnerIDComboBox.SelectedIndex = -1
        StreetAddressTextBox.Text = ""
        ZipcodeMaskedTextBox.Text = ""
        NumberofBedroomsMaskedTextBox.Text = ""
        NumberofBathroomsMaskedTextBox.Text = ""
        TotalSquareFeetMaskedTextBox.Text = ""
        YearbuildMaskedTextBox.Text = ""
        AskingPriceMaskedTextBox.Text = ""
        DescriptionRichTextBox.Text = ""

        BranchIDComboBox.Focus()

    End Sub
End Class