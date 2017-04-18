<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.FootageMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BathroomsMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.BedroomsMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.ZipCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.AgentIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.OfficeIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
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
        Me.quitButton = New System.Windows.Forms.Button()
        Me.CurrentOwnerLable = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FootageMaskedTextBox
        '
        Me.FootageMaskedTextBox.Location = New System.Drawing.Point(327, 114)
        Me.FootageMaskedTextBox.Mask = "000000"
        Me.FootageMaskedTextBox.Name = "FootageMaskedTextBox"
        Me.FootageMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.FootageMaskedTextBox.TabIndex = 55
        '
        'BathroomsMaskedTextBox
        '
        Me.BathroomsMaskedTextBox.Location = New System.Drawing.Point(126, 196)
        Me.BathroomsMaskedTextBox.Mask = "00000"
        Me.BathroomsMaskedTextBox.Name = "BathroomsMaskedTextBox"
        Me.BathroomsMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.BathroomsMaskedTextBox.TabIndex = 54
        Me.BathroomsMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'BedroomsMaskedTextBox
        '
        Me.BedroomsMaskedTextBox.Location = New System.Drawing.Point(126, 161)
        Me.BedroomsMaskedTextBox.Mask = "00000"
        Me.BedroomsMaskedTextBox.Name = "BedroomsMaskedTextBox"
        Me.BedroomsMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.BedroomsMaskedTextBox.TabIndex = 53
        Me.BedroomsMaskedTextBox.ValidatingType = GetType(Integer)
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
        Me.ZipCodeMaskedTextBox.TabIndex = 51
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
        Me.AddressTextBox.TabIndex = 50
        '
        'OwnerIDMaskedTextBox
        '
        Me.OwnerIDMaskedTextBox.Location = New System.Drawing.Point(308, 15)
        Me.OwnerIDMaskedTextBox.Mask = "000000"
        Me.OwnerIDMaskedTextBox.Name = "OwnerIDMaskedTextBox"
        Me.OwnerIDMaskedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.OwnerIDMaskedTextBox.TabIndex = 48
        '
        'AgentIDMaskedTextBox
        '
        Me.AgentIDMaskedTextBox.Location = New System.Drawing.Point(191, 15)
        Me.AgentIDMaskedTextBox.Mask = "000000"
        Me.AgentIDMaskedTextBox.Name = "AgentIDMaskedTextBox"
        Me.AgentIDMaskedTextBox.Size = New System.Drawing.Size(77, 20)
        Me.AgentIDMaskedTextBox.TabIndex = 47
        '
        'OfficeIDMaskedTextBox
        '
        Me.OfficeIDMaskedTextBox.Location = New System.Drawing.Point(126, 114)
        Me.OfficeIDMaskedTextBox.Mask = "000000"
        Me.OfficeIDMaskedTextBox.Name = "OfficeIDMaskedTextBox"
        Me.OfficeIDMaskedTextBox.Size = New System.Drawing.Size(58, 20)
        Me.OfficeIDMaskedTextBox.TabIndex = 52
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
        Me.PriceTextBox.TabIndex = 57
        '
        'YearBuiltTextBox
        '
        Me.YearBuiltTextBox.Location = New System.Drawing.Point(327, 153)
        Me.YearBuiltTextBox.Mask = "0000"
        Me.YearBuiltTextBox.Name = "YearBuiltTextBox"
        Me.YearBuiltTextBox.Size = New System.Drawing.Size(58, 20)
        Me.YearBuiltTextBox.TabIndex = 56
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
        Me.DescriptionTextBox.TabIndex = 69
        '
        'PropertyLabel
        '
        Me.PropertyLabel.AutoSize = True
        Me.PropertyLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PropertyLabel.Location = New System.Drawing.Point(79, -1)
        Me.PropertyLabel.Name = "PropertyLabel"
        Me.PropertyLabel.Size = New System.Drawing.Size(60, 13)
        Me.PropertyLabel.TabIndex = 68
        Me.PropertyLabel.Text = "PropertyID:"
        '
        'PropertyTextBox
        '
        Me.PropertyTextBox.Enabled = False
        Me.PropertyTextBox.Location = New System.Drawing.Point(72, 15)
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
        'quitButton
        '
        Me.quitButton.Location = New System.Drawing.Point(269, 274)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(75, 23)
        Me.quitButton.TabIndex = 64
        Me.quitButton.Text = "Cancel"
        Me.quitButton.UseVisualStyleBackColor = True
        '
        'CurrentOwnerLable
        '
        Me.CurrentOwnerLable.AutoSize = True
        Me.CurrentOwnerLable.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CurrentOwnerLable.Location = New System.Drawing.Point(324, -1)
        Me.CurrentOwnerLable.Name = "CurrentOwnerLable"
        Me.CurrentOwnerLable.Size = New System.Drawing.Size(52, 13)
        Me.CurrentOwnerLable.TabIndex = 59
        Me.CurrentOwnerLable.Text = "OwnerID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(204, -1)
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
        Me.addButton.TabIndex = 63
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 312)
        Me.Controls.Add(Me.FootageMaskedTextBox)
        Me.Controls.Add(Me.BathroomsMaskedTextBox)
        Me.Controls.Add(Me.BedroomsMaskedTextBox)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.ZipCodeMaskedTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.OwnerIDMaskedTextBox)
        Me.Controls.Add(Me.AgentIDMaskedTextBox)
        Me.Controls.Add(Me.OfficeIDMaskedTextBox)
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
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.CurrentOwnerLable)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addButton)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FootageMaskedTextBox As MaskedTextBox
    Friend WithEvents BathroomsMaskedTextBox As MaskedTextBox
    Friend WithEvents BedroomsMaskedTextBox As MaskedTextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents ZipCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents AddressLabel As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents OwnerIDMaskedTextBox As MaskedTextBox
    Friend WithEvents AgentIDMaskedTextBox As MaskedTextBox
    Friend WithEvents OfficeIDMaskedTextBox As MaskedTextBox
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
    Friend WithEvents quitButton As Button
    Friend WithEvents CurrentOwnerLable As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addButton As Button
End Class
