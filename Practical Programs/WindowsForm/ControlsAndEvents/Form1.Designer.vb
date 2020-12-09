<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOne
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOne))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtNo2 = New System.Windows.Forms.TextBox()
        Me.txtNo1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.txtEnterInList = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your name:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(100, 72)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(130, 13)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = "Ur name will appear here.."
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(103, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 20)
        Me.txtName.TabIndex = 2
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(103, 116)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(75, 23)
        Me.btnClick.TabIndex = 3
        Me.btnClick.Text = "Click Me"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.btnClick)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 168)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event examples"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSum)
        Me.GroupBox2.Controls.Add(Me.txtNo2)
        Me.GroupBox2.Controls.Add(Me.txtNo1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnSum)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 227)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sum of 2 nos"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(100, 151)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 13)
        Me.lblSum.TabIndex = 5
        '
        'txtNo2
        '
        Me.txtNo2.Location = New System.Drawing.Point(103, 106)
        Me.txtNo2.Name = "txtNo2"
        Me.txtNo2.Size = New System.Drawing.Size(100, 20)
        Me.txtNo2.TabIndex = 4
        '
        'txtNo1
        '
        Me.txtNo1.Location = New System.Drawing.Point(103, 63)
        Me.txtNo1.Name = "txtNo1"
        Me.txtNo1.Size = New System.Drawing.Size(100, 20)
        Me.txtNo1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Second No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First No"
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(103, 184)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(75, 23)
        Me.btnSum.TabIndex = 0
        Me.btnSum.Text = "Add"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'txtEnterInList
        '
        Me.txtEnterInList.Location = New System.Drawing.Point(21, 60)
        Me.txtEnterInList.Name = "txtEnterInList"
        Me.txtEnterInList.Size = New System.Drawing.Size(100, 20)
        Me.txtEnterInList.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstData)
        Me.GroupBox3.Controls.Add(Me.btnAddToList)
        Me.GroupBox3.Controls.Add(Me.txtEnterInList)
        Me.GroupBox3.Location = New System.Drawing.Point(418, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(348, 159)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Move Data from text box to list box"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.Items.AddRange(New Object() {"Green", "Red"})
        Me.lstData.Location = New System.Drawing.Point(182, 19)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(120, 95)
        Me.lstData.TabIndex = 8
        '
        'btnAddToList
        '
        Me.btnAddToList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.Location = New System.Drawing.Point(127, 60)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(34, 23)
        Me.btnAddToList.TabIndex = 7
        Me.btnAddToList.Text = ">"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(418, 218)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(348, 217)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'frmOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 470)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOne"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnClick As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents txtNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents txtEnterInList As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
