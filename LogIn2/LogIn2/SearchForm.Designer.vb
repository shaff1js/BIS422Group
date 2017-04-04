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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumberOfBedroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.NumberOfBathroomsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SquareFeetMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.askingPriceMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        CType(Me.HSHPropertyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(814, 554)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HSHPropertyDataGridView
        '
        Me.HSHPropertyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HSHPropertyDataGridView.Location = New System.Drawing.Point(28, 235)
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
        Me.GroupBox1.Location = New System.Drawing.Point(215, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 182)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Properties"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Bedrooms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Number of Bathrooms:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Square Feet:"
        '
        'NumberOfBedroomsComboBox
        '
        Me.NumberOfBedroomsComboBox.FormattingEnabled = True
        Me.NumberOfBedroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.NumberOfBedroomsComboBox.Location = New System.Drawing.Point(157, 34)
        Me.NumberOfBedroomsComboBox.Name = "NumberOfBedroomsComboBox"
        Me.NumberOfBedroomsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NumberOfBedroomsComboBox.TabIndex = 1
        '
        'NumberOfBathroomsComboBox
        '
        Me.NumberOfBathroomsComboBox.FormattingEnabled = True
        Me.NumberOfBathroomsComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.NumberOfBathroomsComboBox.Location = New System.Drawing.Point(157, 70)
        Me.NumberOfBathroomsComboBox.Name = "NumberOfBathroomsComboBox"
        Me.NumberOfBathroomsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.NumberOfBathroomsComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Asking Price:"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(340, 51)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 39)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(340, 103)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 39)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear Search"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SquareFeetMaskedTextBox
        '
        Me.SquareFeetMaskedTextBox.Location = New System.Drawing.Point(157, 105)
        Me.SquareFeetMaskedTextBox.Mask = "000000000"
        Me.SquareFeetMaskedTextBox.Name = "SquareFeetMaskedTextBox"
        Me.SquareFeetMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.SquareFeetMaskedTextBox.TabIndex = 4
        '
        'askingPriceMaskedTextBox
        '
        Me.askingPriceMaskedTextBox.Location = New System.Drawing.Point(157, 142)
        Me.askingPriceMaskedTextBox.Mask = "0000000000"
        Me.askingPriceMaskedTextBox.Name = "askingPriceMaskedTextBox"
        Me.askingPriceMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.askingPriceMaskedTextBox.TabIndex = 5
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 600)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HSHPropertyDataGridView)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "SearchForm"
        Me.Text = "SearchForm"
        CType(Me.HSHPropertyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
End Class
