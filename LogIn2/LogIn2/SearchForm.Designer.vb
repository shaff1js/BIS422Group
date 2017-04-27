<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.HSHPropertyDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.askingPriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SquareFeetMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.NumberOfBathroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumberOfBedroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RealEstateAgentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.CustomerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PurchaseButton = New System.Windows.Forms.Button()
        Me.DateSoldMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SalePriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PropertyIDTextBox = New System.Windows.Forms.TextBox()
        Me.SaleIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.HSHPropertyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(779, 548)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HSHPropertyDataGridView
        '
        Me.HSHPropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HSHPropertyDataGridView.Location = New System.Drawing.Point(28, 233)
        Me.HSHPropertyDataGridView.Name = "HSHPropertyDataGridView"
        Me.HSHPropertyDataGridView.Size = New System.Drawing.Size(861, 150)
        Me.HSHPropertyDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.askingPriceMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.SquareFeetMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.SearchButton)
        Me.GroupBox1.Controls.Add(Me.NumberOfBathroomsComboBox)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumberOfBedroomsComboBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(163, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 196)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Properties"
        '
        'askingPriceMaskedTextBox
        '
        Me.askingPriceMaskedTextBox.Location = New System.Drawing.Point(214, 146)
        Me.askingPriceMaskedTextBox.Mask = "0000000000"
        Me.askingPriceMaskedTextBox.Name = "askingPriceMaskedTextBox"
        Me.askingPriceMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.askingPriceMaskedTextBox.TabIndex = 5
        '
        'SquareFeetMaskedTextBox
        '
        Me.SquareFeetMaskedTextBox.Location = New System.Drawing.Point(214, 110)
        Me.SquareFeetMaskedTextBox.Mask = "000000000"
        Me.SquareFeetMaskedTextBox.Name = "SquareFeetMaskedTextBox"
        Me.SquareFeetMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SquareFeetMaskedTextBox.TabIndex = 4
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(411, 113)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 39)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear Search"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(411, 48)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 39)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'NumberOfBathroomsComboBox
        '
        Me.NumberOfBathroomsComboBox.FormattingEnabled = True
        Me.NumberOfBathroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.NumberOfBathroomsComboBox.Location = New System.Drawing.Point(214, 71)
        Me.NumberOfBathroomsComboBox.Name = "NumberOfBathroomsComboBox"
        Me.NumberOfBathroomsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NumberOfBathroomsComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Asking Price:"
        '
        'NumberOfBedroomsComboBox
        '
        Me.NumberOfBedroomsComboBox.FormattingEnabled = True
        Me.NumberOfBedroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.NumberOfBedroomsComboBox.Location = New System.Drawing.Point(214, 35)
        Me.NumberOfBedroomsComboBox.Name = "NumberOfBedroomsComboBox"
        Me.NumberOfBedroomsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NumberOfBedroomsComboBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Square Feet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of Bathrooms:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Bedrooms:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RealEstateAgentIDComboBox)
        Me.GroupBox3.Controls.Add(Me.CustomerIDComboBox)
        Me.GroupBox3.Controls.Add(Me.PurchaseButton)
        Me.GroupBox3.Controls.Add(Me.DateSoldMaskedTextBox)
        Me.GroupBox3.Controls.Add(Me.SalePriceMaskedTextBox)
        Me.GroupBox3.Controls.Add(Me.PropertyIDTextBox)
        Me.GroupBox3.Controls.Add(Me.SaleIDTextBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(163, 404)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(573, 184)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Detail"
        '
        'RealEstateAgentIDComboBox
        '
        Me.RealEstateAgentIDComboBox.Enabled = False
        Me.RealEstateAgentIDComboBox.FormattingEnabled = True
        Me.RealEstateAgentIDComboBox.Location = New System.Drawing.Point(214, 90)
        Me.RealEstateAgentIDComboBox.Name = "RealEstateAgentIDComboBox"
        Me.RealEstateAgentIDComboBox.Size = New System.Drawing.Size(100, 21)
        Me.RealEstateAgentIDComboBox.TabIndex = 18
        '
        'CustomerIDComboBox
        '
        Me.CustomerIDComboBox.Enabled = False
        Me.CustomerIDComboBox.FormattingEnabled = True
        Me.CustomerIDComboBox.Location = New System.Drawing.Point(214, 65)
        Me.CustomerIDComboBox.Name = "CustomerIDComboBox"
        Me.CustomerIDComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CustomerIDComboBox.TabIndex = 18
        '
        'PurchaseButton
        '
        Me.PurchaseButton.Location = New System.Drawing.Point(424, 41)
        Me.PurchaseButton.Name = "PurchaseButton"
        Me.PurchaseButton.Size = New System.Drawing.Size(75, 23)
        Me.PurchaseButton.TabIndex = 16
        Me.PurchaseButton.Text = "Purchase"
        Me.PurchaseButton.UseVisualStyleBackColor = True
        '
        'DateSoldMaskedTextBox
        '
        Me.DateSoldMaskedTextBox.Location = New System.Drawing.Point(214, 144)
        Me.DateSoldMaskedTextBox.Mask = "0000/00/00"
        Me.DateSoldMaskedTextBox.Name = "DateSoldMaskedTextBox"
        Me.DateSoldMaskedTextBox.ReadOnly = True
        Me.DateSoldMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DateSoldMaskedTextBox.TabIndex = 15
        Me.DateSoldMaskedTextBox.ValidatingType = GetType(Date)
        '
        'SalePriceMaskedTextBox
        '
        Me.SalePriceMaskedTextBox.Location = New System.Drawing.Point(214, 115)
        Me.SalePriceMaskedTextBox.Mask = "0000000000"
        Me.SalePriceMaskedTextBox.Name = "SalePriceMaskedTextBox"
        Me.SalePriceMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SalePriceMaskedTextBox.TabIndex = 14
        '
        'PropertyIDTextBox
        '
        Me.PropertyIDTextBox.Location = New System.Drawing.Point(214, 41)
        Me.PropertyIDTextBox.Name = "PropertyIDTextBox"
        Me.PropertyIDTextBox.ReadOnly = True
        Me.PropertyIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PropertyIDTextBox.TabIndex = 8
        '
        'SaleIDTextBox
        '
        Me.SaleIDTextBox.Location = New System.Drawing.Point(214, 16)
        Me.SaleIDTextBox.Name = "SaleIDTextBox"
        Me.SaleIDTextBox.ReadOnly = True
        Me.SaleIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SaleIDTextBox.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Sale ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Sale Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Real Estate Agent ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(76, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Customer ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Property ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date Sold:"
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 600)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HSHPropertyDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "SearchForm"
        Me.Text = "Search for Property"
        CType(Me.HSHPropertyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents HSHPropertyDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents NumberOfBathroomsComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NumberOfBedroomsComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents askingPriceMaskedTextBox As MaskedTextBox
    Friend WithEvents SquareFeetMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PurchaseButton As Button
    Friend WithEvents DateSoldMaskedTextBox As MaskedTextBox
    Friend WithEvents SalePriceMaskedTextBox As MaskedTextBox
    Friend WithEvents PropertyIDTextBox As TextBox
    Friend WithEvents SaleIDTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RealEstateAgentIDComboBox As ComboBox
    Friend WithEvents CustomerIDComboBox As ComboBox
End Class
