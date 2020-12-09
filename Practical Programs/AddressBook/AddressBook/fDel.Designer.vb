<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDel
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TId = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LBId = New System.Windows.Forms.ListBox()
        Me.LBAddress = New System.Windows.Forms.ListBox()
        Me.LBPhone = New System.Windows.Forms.ListBox()
        Me.LBName = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(34, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Delete Contact"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Address:"
        '
        'TAddress
        '
        Me.TAddress.Enabled = False
        Me.TAddress.Location = New System.Drawing.Point(75, 171)
        Me.TAddress.Name = "TAddress"
        Me.TAddress.Size = New System.Drawing.Size(172, 20)
        Me.TAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Phone:"
        '
        'TPhone
        '
        Me.TPhone.Enabled = False
        Me.TPhone.Location = New System.Drawing.Point(75, 131)
        Me.TPhone.MaxLength = 10
        Me.TPhone.Name = "TPhone"
        Me.TPhone.Size = New System.Drawing.Size(172, 20)
        Me.TPhone.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'TName
        '
        Me.TName.Enabled = False
        Me.TName.Location = New System.Drawing.Point(75, 94)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(172, 20)
        Me.TName.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Delete By ID", "Delete By Name", "Delete By Phone"})
        Me.ComboBox1.Location = New System.Drawing.Point(64, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(154, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID:"
        '
        'TId
        '
        Me.TId.Enabled = False
        Me.TId.Location = New System.Drawing.Point(75, 55)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(172, 20)
        Me.TId.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(148, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Return Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LBId
        '
        Me.LBId.FormattingEnabled = True
        Me.LBId.Location = New System.Drawing.Point(5, 3)
        Me.LBId.Name = "LBId"
        Me.LBId.Size = New System.Drawing.Size(15, 30)
        Me.LBId.TabIndex = 20
        Me.LBId.Visible = False
        '
        'LBAddress
        '
        Me.LBAddress.FormattingEnabled = True
        Me.LBAddress.Location = New System.Drawing.Point(53, 3)
        Me.LBAddress.Name = "LBAddress"
        Me.LBAddress.Size = New System.Drawing.Size(15, 30)
        Me.LBAddress.TabIndex = 19
        Me.LBAddress.Visible = False
        '
        'LBPhone
        '
        Me.LBPhone.FormattingEnabled = True
        Me.LBPhone.Location = New System.Drawing.Point(37, 3)
        Me.LBPhone.Name = "LBPhone"
        Me.LBPhone.Size = New System.Drawing.Size(15, 30)
        Me.LBPhone.TabIndex = 18
        Me.LBPhone.Visible = False
        '
        'LBName
        '
        Me.LBName.FormattingEnabled = True
        Me.LBName.Location = New System.Drawing.Point(21, 3)
        Me.LBName.Name = "LBName"
        Me.LBName.Size = New System.Drawing.Size(15, 30)
        Me.LBName.TabIndex = 17
        Me.LBName.Visible = False
        '
        'fDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 245)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LBId)
        Me.Controls.Add(Me.LBAddress)
        Me.Controls.Add(Me.LBPhone)
        Me.Controls.Add(Me.LBName)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "fDel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Contact By Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TName As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TId As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents LBId As System.Windows.Forms.ListBox
    Public WithEvents LBAddress As System.Windows.Forms.ListBox
    Public WithEvents LBPhone As System.Windows.Forms.ListBox
    Public WithEvents LBName As System.Windows.Forms.ListBox
End Class
