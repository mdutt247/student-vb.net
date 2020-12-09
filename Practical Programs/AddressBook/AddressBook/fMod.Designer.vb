<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMod
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
        Me.LBId = New System.Windows.Forms.ListBox()
        Me.LBAddress = New System.Windows.Forms.ListBox()
        Me.LBPhone = New System.Windows.Forms.ListBox()
        Me.LBName = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LBId
        '
        Me.LBId.FormattingEnabled = True
        Me.LBId.Location = New System.Drawing.Point(4, 3)
        Me.LBId.Name = "LBId"
        Me.LBId.Size = New System.Drawing.Size(15, 30)
        Me.LBId.TabIndex = 35
        Me.LBId.Visible = False
        '
        'LBAddress
        '
        Me.LBAddress.FormattingEnabled = True
        Me.LBAddress.Location = New System.Drawing.Point(52, 3)
        Me.LBAddress.Name = "LBAddress"
        Me.LBAddress.Size = New System.Drawing.Size(15, 30)
        Me.LBAddress.TabIndex = 34
        Me.LBAddress.Visible = False
        '
        'LBPhone
        '
        Me.LBPhone.FormattingEnabled = True
        Me.LBPhone.Location = New System.Drawing.Point(36, 3)
        Me.LBPhone.Name = "LBPhone"
        Me.LBPhone.Size = New System.Drawing.Size(15, 30)
        Me.LBPhone.TabIndex = 33
        Me.LBPhone.Visible = False
        '
        'LBName
        '
        Me.LBName.FormattingEnabled = True
        Me.LBName.Location = New System.Drawing.Point(20, 3)
        Me.LBName.Name = "LBName"
        Me.LBName.Size = New System.Drawing.Size(15, 30)
        Me.LBName.TabIndex = 32
        Me.LBName.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Return Home"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "ID:"
        '
        'TId
        '
        Me.TId.Location = New System.Drawing.Point(73, 23)
        Me.TId.Name = "TId"
        Me.TId.Size = New System.Drawing.Size(172, 20)
        Me.TId.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(32, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Modify Contact"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Address:"
        '
        'TAddress
        '
        Me.TAddress.Location = New System.Drawing.Point(73, 139)
        Me.TAddress.Name = "TAddress"
        Me.TAddress.Size = New System.Drawing.Size(172, 20)
        Me.TAddress.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Phone:"
        '
        'TPhone
        '
        Me.TPhone.Location = New System.Drawing.Point(73, 99)
        Me.TPhone.MaxLength = 10
        Me.TPhone.Name = "TPhone"
        Me.TPhone.Size = New System.Drawing.Size(172, 20)
        Me.TPhone.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Name:"
        '
        'TName
        '
        Me.TName.Location = New System.Drawing.Point(73, 62)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(172, 20)
        Me.TName.TabIndex = 24
        '
        'fMod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 216)
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
        Me.Controls.Add(Me.LBId)
        Me.Controls.Add(Me.LBAddress)
        Me.Controls.Add(Me.LBPhone)
        Me.Controls.Add(Me.LBName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "fMod"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify Contact By Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents LBId As System.Windows.Forms.ListBox
    Public WithEvents LBAddress As System.Windows.Forms.ListBox
    Public WithEvents LBPhone As System.Windows.Forms.ListBox
    Public WithEvents LBName As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TId As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TName As System.Windows.Forms.TextBox
End Class
