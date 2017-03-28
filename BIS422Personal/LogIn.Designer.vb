<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.LogInButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'LogInButton
        '
        Me.LogInButton.Location = New System.Drawing.Point(104, 169)
        Me.LogInButton.Name = "LogInButton"
        Me.LogInButton.Size = New System.Drawing.Size(75, 23)
        Me.LogInButton.TabIndex = 0
        Me.LogInButton.Text = "Log In"
        Me.LogInButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(237, 169)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.Location = New System.Drawing.Point(212, 74)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(102, 20)
        Me.UserIDTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password:"
        '
        'PasswordMaskedTextBox
        '
        Me.PasswordMaskedTextBox.Location = New System.Drawing.Point(212, 114)
        Me.PasswordMaskedTextBox.Name = "PasswordMaskedTextBox"
        Me.PasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordMaskedTextBox.TabIndex = 6
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 226)
        Me.Controls.Add(Me.PasswordMaskedTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LogInButton)
        Me.Name = "LogIn"
        Me.Text = "Realty Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogInButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordMaskedTextBox As MaskedTextBox
End Class
