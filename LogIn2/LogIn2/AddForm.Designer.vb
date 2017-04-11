<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OwnerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PropertyTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BranchIDComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ZipCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.AskingPriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.YearbuildMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TotalSquareFeetMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NumberofBathroomsMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NumberofBedroomsMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DescriptionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.AddPropertyButton = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(323, 572)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 36)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Branch ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Owner ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Street Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Zipcode:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Number of Bedrooms:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(240, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Number of Bathrooms:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Square Feet:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Year Built:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 189)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Asking Price:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OwnerIDComboBox)
        Me.GroupBox1.Controls.Add(Me.PropertyTextBox)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.BranchIDComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 70)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administrative"
        '
        'OwnerIDComboBox
        '
        Me.OwnerIDComboBox.FormattingEnabled = True
        Me.OwnerIDComboBox.Location = New System.Drawing.Point(279, 26)
        Me.OwnerIDComboBox.Name = "OwnerIDComboBox"
        Me.OwnerIDComboBox.Size = New System.Drawing.Size(49, 21)
        Me.OwnerIDComboBox.TabIndex = 7
        '
        'PropertyTextBox
        '
        Me.PropertyTextBox.Location = New System.Drawing.Point(403, 28)
        Me.PropertyTextBox.Name = "PropertyTextBox"
        Me.PropertyTextBox.ReadOnly = True
        Me.PropertyTextBox.Size = New System.Drawing.Size(61, 20)
        Me.PropertyTextBox.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Property ID:"
        '
        'BranchIDComboBox
        '
        Me.BranchIDComboBox.FormattingEnabled = True
        Me.BranchIDComboBox.Location = New System.Drawing.Point(96, 27)
        Me.BranchIDComboBox.Name = "BranchIDComboBox"
        Me.BranchIDComboBox.Size = New System.Drawing.Size(114, 21)
        Me.BranchIDComboBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.StateTextBox)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CityTextBox)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ZipCodeComboBox)
        Me.GroupBox2.Controls.Add(Me.StreetAddressTextBox)
        Me.GroupBox2.Controls.Add(Me.AskingPriceMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.YearbuildMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.TotalSquareFeetMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.NumberofBathroomsMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.NumberofBedroomsMaskedTextBox)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 405)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Property Details"
        '
        'ZipCodeComboBox
        '
        Me.ZipCodeComboBox.FormattingEnabled = True
        Me.ZipCodeComboBox.Location = New System.Drawing.Point(82, 71)
        Me.ZipCodeComboBox.Name = "ZipCodeComboBox"
        Me.ZipCodeComboBox.Size = New System.Drawing.Size(66, 21)
        Me.ZipCodeComboBox.TabIndex = 11
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(113, 37)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(306, 20)
        Me.StreetAddressTextBox.TabIndex = 1
        '
        'AskingPriceMaskedTextBox
        '
        Me.AskingPriceMaskedTextBox.Location = New System.Drawing.Point(102, 186)
        Me.AskingPriceMaskedTextBox.Mask = "0000000000"
        Me.AskingPriceMaskedTextBox.Name = "AskingPriceMaskedTextBox"
        Me.AskingPriceMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.AskingPriceMaskedTextBox.TabIndex = 7
        '
        'YearbuildMaskedTextBox
        '
        Me.YearbuildMaskedTextBox.Location = New System.Drawing.Point(301, 148)
        Me.YearbuildMaskedTextBox.Mask = "0000"
        Me.YearbuildMaskedTextBox.Name = "YearbuildMaskedTextBox"
        Me.YearbuildMaskedTextBox.Size = New System.Drawing.Size(40, 20)
        Me.YearbuildMaskedTextBox.TabIndex = 6
        '
        'TotalSquareFeetMaskedTextBox
        '
        Me.TotalSquareFeetMaskedTextBox.Location = New System.Drawing.Point(128, 148)
        Me.TotalSquareFeetMaskedTextBox.Mask = "000000000"
        Me.TotalSquareFeetMaskedTextBox.Name = "TotalSquareFeetMaskedTextBox"
        Me.TotalSquareFeetMaskedTextBox.Size = New System.Drawing.Size(64, 20)
        Me.TotalSquareFeetMaskedTextBox.TabIndex = 5
        '
        'NumberofBathroomsMaskedTextBox
        '
        Me.NumberofBathroomsMaskedTextBox.Location = New System.Drawing.Point(358, 110)
        Me.NumberofBathroomsMaskedTextBox.Mask = "00"
        Me.NumberofBathroomsMaskedTextBox.Name = "NumberofBathroomsMaskedTextBox"
        Me.NumberofBathroomsMaskedTextBox.Size = New System.Drawing.Size(21, 20)
        Me.NumberofBathroomsMaskedTextBox.TabIndex = 4
        '
        'NumberofBedroomsMaskedTextBox
        '
        Me.NumberofBedroomsMaskedTextBox.Location = New System.Drawing.Point(142, 110)
        Me.NumberofBedroomsMaskedTextBox.Mask = "00"
        Me.NumberofBedroomsMaskedTextBox.Name = "NumberofBedroomsMaskedTextBox"
        Me.NumberofBedroomsMaskedTextBox.Size = New System.Drawing.Size(26, 20)
        Me.NumberofBedroomsMaskedTextBox.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DescriptionRichTextBox)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(413, 136)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Description"
        '
        'DescriptionRichTextBox
        '
        Me.DescriptionRichTextBox.Location = New System.Drawing.Point(16, 24)
        Me.DescriptionRichTextBox.Name = "DescriptionRichTextBox"
        Me.DescriptionRichTextBox.Size = New System.Drawing.Size(383, 94)
        Me.DescriptionRichTextBox.TabIndex = 0
        Me.DescriptionRichTextBox.Text = ""
        '
        'AddPropertyButton
        '
        Me.AddPropertyButton.Location = New System.Drawing.Point(113, 572)
        Me.AddPropertyButton.Name = "AddPropertyButton"
        Me.AddPropertyButton.Size = New System.Drawing.Size(75, 36)
        Me.AddPropertyButton.TabIndex = 13
        Me.AddPropertyButton.Text = "Add Property"
        Me.AddPropertyButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(154, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(188, 72)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.ReadOnly = True
        Me.CityTextBox.Size = New System.Drawing.Size(153, 20)
        Me.CityTextBox.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(348, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "State:"
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(389, 72)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.ReadOnly = True
        Me.StateTextBox.Size = New System.Drawing.Size(30, 20)
        Me.StateTextBox.TabIndex = 15
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 649)
        Me.Controls.Add(Me.AddPropertyButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "AddForm"
        Me.Text = "Add Property"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BranchIDComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DescriptionRichTextBox As RichTextBox
    Friend WithEvents AddPropertyButton As Button
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents AskingPriceMaskedTextBox As MaskedTextBox
    Friend WithEvents YearbuildMaskedTextBox As MaskedTextBox
    Friend WithEvents TotalSquareFeetMaskedTextBox As MaskedTextBox
    Friend WithEvents NumberofBathroomsMaskedTextBox As MaskedTextBox
    Friend WithEvents NumberofBedroomsMaskedTextBox As MaskedTextBox
    Friend WithEvents PropertyTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents OwnerIDComboBox As ComboBox
    Friend WithEvents ZipCodeComboBox As ComboBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents Label11 As Label
End Class
