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
        Me.components = New System.ComponentModel.Container()
        Me.FootageMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.OfficeIDLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.YearBuiltTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PropertyLabel = New System.Windows.Forms.Label()
        Me.PropertyTextBox = New System.Windows.Forms.TextBox()
        Me.BedroomsLable = New System.Windows.Forms.Label()
        Me.BathroomsLabel = New System.Windows.Forms.Label()
        Me.FootageLabel = New System.Windows.Forms.Label()
        Me.YearBuiltLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CurrentOwnerLable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.AgentIDComboBox = New System.Windows.Forms.ComboBox()
        Me.HshrealestateagentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BIS422_33DataSet = New LogIn2.BIS422_33DataSet()
        Me.OwnerIDComboBox = New System.Windows.Forms.ComboBox()
        Me.HshpropertyownerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OfficeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.HshbranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BedroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.HshpropertyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BathroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.HshrealestateagentTableAdapter = New LogIn2.BIS422_33DataSetTableAdapters.hshrealestateagentTableAdapter()
        Me.HshpropertyownerTableAdapter = New LogIn2.BIS422_33DataSetTableAdapters.hshpropertyownerTableAdapter()
        Me.HshbranchTableAdapter = New LogIn2.BIS422_33DataSetTableAdapters.hshbranchTableAdapter()
        Me.HshpropertyTableAdapter = New LogIn2.BIS422_33DataSetTableAdapters.hshpropertyTableAdapter()
        Me.HshpropertyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HshpropertyBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.HshrealestateagentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BIS422_33DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HshpropertyownerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HshbranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HshpropertyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HshpropertyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HshpropertyBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FootageMaskedTextBox
        '
        Me.FootageMaskedTextBox.Location = New System.Drawing.Point(327, 114)
        Me.FootageMaskedTextBox.Mask = "000000"
        Me.FootageMaskedTextBox.Name = "FootageMaskedTextBox"
        Me.FootageMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.FootageMaskedTextBox.TabIndex = 8
        Me.FootageMaskedTextBox.TabStop = False
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(268, 75)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(53, 13)
        Me.ZipCodeLabel.TabIndex = 72
        Me.ZipCodeLabel.Text = "Zip Code:"
        '
        'ZipCodeMaskedTextBox
        '
        Me.ZipCodeMaskedTextBox.Location = New System.Drawing.Point(327, 72)
        Me.ZipCodeMaskedTextBox.Mask = "00000"
        Me.ZipCodeMaskedTextBox.Name = "ZipCodeMaskedTextBox"
        Me.ZipCodeMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.ZipCodeMaskedTextBox.TabIndex = 4
        Me.ZipCodeMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 79)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(76, 13)
        Me.AddressLabel.TabIndex = 49
        Me.AddressLabel.Text = "Street Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(94, 72)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(174, 20)
        Me.AddressTextBox.TabIndex = 3
        '
        'OfficeIDLabel
        '
        Me.OfficeIDLabel.AutoSize = True
        Me.OfficeIDLabel.Location = New System.Drawing.Point(57, 121)
        Me.OfficeIDLabel.Name = "OfficeIDLabel"
        Me.OfficeIDLabel.Size = New System.Drawing.Size(52, 13)
        Me.OfficeIDLabel.TabIndex = 71
        Me.OfficeIDLabel.Text = "Office ID:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(327, 192)
        Me.PriceTextBox.Mask = "$000,000"
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(58, 20)
        Me.PriceTextBox.TabIndex = 10
        Me.PriceTextBox.TabStop = False
        '
        'YearBuiltTextBox
        '
        Me.YearBuiltTextBox.Location = New System.Drawing.Point(327, 153)
        Me.YearBuiltTextBox.Mask = "0000"
        Me.YearBuiltTextBox.Name = "YearBuiltTextBox"
        Me.YearBuiltTextBox.Size = New System.Drawing.Size(58, 20)
        Me.YearBuiltTextBox.TabIndex = 9
        Me.YearBuiltTextBox.TabStop = False
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.Location = New System.Drawing.Point(46, 242)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescriptionLabel.TabIndex = 70
        Me.DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(126, 235)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(259, 20)
        Me.DescriptionTextBox.TabIndex = 11
        '
        'PropertyLabel
        '
        Me.PropertyLabel.AutoSize = True
        Me.PropertyLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PropertyLabel.Location = New System.Drawing.Point(68, 9)
        Me.PropertyLabel.Name = "PropertyLabel"
        Me.PropertyLabel.Size = New System.Drawing.Size(60, 13)
        Me.PropertyLabel.TabIndex = 68
        Me.PropertyLabel.Text = "PropertyID:"
        '
        'PropertyTextBox
        '
        Me.PropertyTextBox.Enabled = False
        Me.PropertyTextBox.Location = New System.Drawing.Point(62, 26)
        Me.PropertyTextBox.Name = "PropertyTextBox"
        Me.PropertyTextBox.ReadOnly = True
        Me.PropertyTextBox.Size = New System.Drawing.Size(77, 20)
        Me.PropertyTextBox.TabIndex = 67
        '
        'BedroomsLable
        '
        Me.BedroomsLable.AutoSize = True
        Me.BedroomsLable.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BedroomsLable.Location = New System.Drawing.Point(46, 164)
        Me.BedroomsLable.Name = "BedroomsLable"
        Me.BedroomsLable.Size = New System.Drawing.Size(79, 13)
        Me.BedroomsLable.TabIndex = 66
        Me.BedroomsLable.Text = "# of Bedrooms:"
        '
        'BathroomsLabel
        '
        Me.BathroomsLabel.AutoSize = True
        Me.BathroomsLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BathroomsLabel.Location = New System.Drawing.Point(46, 203)
        Me.BathroomsLabel.Name = "BathroomsLabel"
        Me.BathroomsLabel.Size = New System.Drawing.Size(82, 13)
        Me.BathroomsLabel.TabIndex = 65
        Me.BathroomsLabel.Text = "# of Bathrooms:"
        '
        'FootageLabel
        '
        Me.FootageLabel.AutoSize = True
        Me.FootageLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FootageLabel.Location = New System.Drawing.Point(213, 121)
        Me.FootageLabel.Name = "FootageLabel"
        Me.FootageLabel.Size = New System.Drawing.Size(108, 13)
        Me.FootageLabel.TabIndex = 62
        Me.FootageLabel.Text = "Total square footage:"
        '
        'YearBuiltLabel
        '
        Me.YearBuiltLabel.AutoSize = True
        Me.YearBuiltLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.YearBuiltLabel.Location = New System.Drawing.Point(213, 160)
        Me.YearBuiltLabel.Name = "YearBuiltLabel"
        Me.YearBuiltLabel.Size = New System.Drawing.Size(55, 13)
        Me.YearBuiltLabel.TabIndex = 61
        Me.YearBuiltLabel.Text = "Year Built:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PriceLabel.Location = New System.Drawing.Point(213, 199)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(67, 13)
        Me.PriceLabel.TabIndex = 60
        Me.PriceLabel.Text = "Listing Price:"
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(269, 274)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'CurrentOwnerLable
        '
        Me.CurrentOwnerLable.AutoSize = True
        Me.CurrentOwnerLable.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CurrentOwnerLable.Location = New System.Drawing.Point(324, 9)
        Me.CurrentOwnerLable.Name = "CurrentOwnerLable"
        Me.CurrentOwnerLable.Size = New System.Drawing.Size(52, 13)
        Me.CurrentOwnerLable.TabIndex = 59
        Me.CurrentOwnerLable.Text = "OwnerID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(188, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Agent ID:"
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(126, 274)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 12
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'AgentIDComboBox
        '
        Me.AgentIDComboBox.DataSource = Me.HshrealestateagentBindingSource
        Me.AgentIDComboBox.DisplayMember = "RealEstateAgentID"
        Me.AgentIDComboBox.FormattingEnabled = True
        Me.AgentIDComboBox.Location = New System.Drawing.Point(175, 25)
        Me.AgentIDComboBox.Name = "AgentIDComboBox"
        Me.AgentIDComboBox.Size = New System.Drawing.Size(77, 21)
        Me.AgentIDComboBox.TabIndex = 1
        '
        'HshrealestateagentBindingSource
        '
        Me.HshrealestateagentBindingSource.DataMember = "hshrealestateagent"
        Me.HshrealestateagentBindingSource.DataSource = Me.BIS422_33DataSet
        '
        'BIS422_33DataSet
        '
        Me.BIS422_33DataSet.DataSetName = "BIS422_33DataSet"
        Me.BIS422_33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OwnerIDComboBox
        '
        Me.OwnerIDComboBox.DataSource = Me.HshpropertyownerBindingSource
        Me.OwnerIDComboBox.DisplayMember = "OwnerID"
        Me.OwnerIDComboBox.FormattingEnabled = True
        Me.OwnerIDComboBox.Location = New System.Drawing.Point(308, 25)
        Me.OwnerIDComboBox.Name = "OwnerIDComboBox"
        Me.OwnerIDComboBox.Size = New System.Drawing.Size(77, 21)
        Me.OwnerIDComboBox.TabIndex = 2
        Me.OwnerIDComboBox.TabStop = False
        '
        'HshpropertyownerBindingSource
        '
        Me.HshpropertyownerBindingSource.DataMember = "hshpropertyowner"
        Me.HshpropertyownerBindingSource.DataSource = Me.BIS422_33DataSet
        '
        'OfficeIDComboBox
        '
        Me.OfficeIDComboBox.DataSource = Me.HshbranchBindingSource
        Me.OfficeIDComboBox.DisplayMember = "BranchID"
        Me.OfficeIDComboBox.FormattingEnabled = True
        Me.OfficeIDComboBox.Location = New System.Drawing.Point(126, 113)
        Me.OfficeIDComboBox.Name = "OfficeIDComboBox"
        Me.OfficeIDComboBox.Size = New System.Drawing.Size(58, 21)
        Me.OfficeIDComboBox.TabIndex = 5
        Me.OfficeIDComboBox.TabStop = False
        '
        'HshbranchBindingSource
        '
        Me.HshbranchBindingSource.DataMember = "hshbranch"
        Me.HshbranchBindingSource.DataSource = Me.BIS422_33DataSet
        '
        'BedroomsComboBox
        '
        Me.BedroomsComboBox.FormattingEnabled = True
        Me.BedroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.BedroomsComboBox.Location = New System.Drawing.Point(126, 156)
        Me.BedroomsComboBox.Name = "BedroomsComboBox"
        Me.BedroomsComboBox.Size = New System.Drawing.Size(58, 21)
        Me.BedroomsComboBox.TabIndex = 6
        Me.BedroomsComboBox.TabStop = False
        '
        'HshpropertyBindingSource
        '
        Me.HshpropertyBindingSource.DataMember = "hshproperty"
        Me.HshpropertyBindingSource.DataSource = Me.BIS422_33DataSet
        '
        'BathroomsComboBox
        '
        Me.BathroomsComboBox.FormattingEnabled = True
        Me.BathroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.BathroomsComboBox.Location = New System.Drawing.Point(126, 195)
        Me.BathroomsComboBox.Name = "BathroomsComboBox"
        Me.BathroomsComboBox.Size = New System.Drawing.Size(58, 21)
        Me.BathroomsComboBox.TabIndex = 7
        Me.BathroomsComboBox.TabStop = False
        '
        'HshrealestateagentTableAdapter
        '
        Me.HshrealestateagentTableAdapter.ClearBeforeFill = True
        '
        'HshpropertyownerTableAdapter
        '
        Me.HshpropertyownerTableAdapter.ClearBeforeFill = True
        '
        'HshbranchTableAdapter
        '
        Me.HshbranchTableAdapter.ClearBeforeFill = True
        '
        'HshpropertyTableAdapter
        '
        Me.HshpropertyTableAdapter.ClearBeforeFill = True
        '
        'HshpropertyBindingSource1
        '
        Me.HshpropertyBindingSource1.DataMember = "hshproperty"
        Me.HshpropertyBindingSource1.DataSource = Me.BIS422_33DataSet
        '
        'HshpropertyBindingSource2
        '
        Me.HshpropertyBindingSource2.DataMember = "hshproperty"
        Me.HshpropertyBindingSource2.DataSource = Me.BIS422_33DataSet
        '
        'AddForm
        '
        Me.AcceptButton = Me.addButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(439, 312)
        Me.Controls.Add(Me.BathroomsComboBox)
        Me.Controls.Add(Me.BedroomsComboBox)
        Me.Controls.Add(Me.OfficeIDComboBox)
        Me.Controls.Add(Me.OwnerIDComboBox)
        Me.Controls.Add(Me.AgentIDComboBox)
        Me.Controls.Add(Me.FootageMaskedTextBox)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeMaskedTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.OfficeIDLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.YearBuiltTextBox)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PropertyLabel)
        Me.Controls.Add(Me.PropertyTextBox)
        Me.Controls.Add(Me.BedroomsLable)
        Me.Controls.Add(Me.BathroomsLabel)
        Me.Controls.Add(Me.FootageLabel)
        Me.Controls.Add(Me.YearBuiltLabel)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.CurrentOwnerLable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Name = "AddForm"
        Me.Text = "Add New Property"
        CType(Me.HshrealestateagentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BIS422_33DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HshpropertyownerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HshbranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HshpropertyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HshpropertyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HshpropertyBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FootageMaskedTextBox As MaskedTextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents ZipCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents OfficeIDLabel As Label
    Friend WithEvents PriceTextBox As MaskedTextBox
    Friend WithEvents YearBuiltTextBox As MaskedTextBox
    Friend WithEvents DescriptionLabel As Label
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PropertyLabel As Label
    Friend WithEvents PropertyTextBox As TextBox
    Friend WithEvents BedroomsLable As Label
    Friend WithEvents BathroomsLabel As Label
    Friend WithEvents FootageLabel As Label
    Friend WithEvents YearBuiltLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents CurrentOwnerLable As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addButton As Button
    Friend WithEvents AgentIDComboBox As ComboBox
    Friend WithEvents OwnerIDComboBox As ComboBox
    Friend WithEvents OfficeIDComboBox As ComboBox
    Friend WithEvents BedroomsComboBox As ComboBox
    Friend WithEvents BathroomsComboBox As ComboBox
    Friend WithEvents BIS422_33DataSet As BIS422_33DataSet
    Friend WithEvents HshrealestateagentBindingSource As BindingSource
    Friend WithEvents HshrealestateagentTableAdapter As BIS422_33DataSetTableAdapters.hshrealestateagentTableAdapter
    Friend WithEvents HshpropertyownerBindingSource As BindingSource
    Friend WithEvents HshpropertyownerTableAdapter As BIS422_33DataSetTableAdapters.hshpropertyownerTableAdapter
    Friend WithEvents HshbranchBindingSource As BindingSource
    Friend WithEvents HshbranchTableAdapter As BIS422_33DataSetTableAdapters.hshbranchTableAdapter
    Friend WithEvents HshpropertyBindingSource As BindingSource
    Friend WithEvents HshpropertyTableAdapter As BIS422_33DataSetTableAdapters.hshpropertyTableAdapter
    Friend WithEvents HshpropertyBindingSource1 As BindingSource
    Friend WithEvents HshpropertyBindingSource2 As BindingSource
End Class
