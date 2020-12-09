<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar3 = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 29)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(135, 33)
        Me.TextBox1.TabIndex = 0
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(17, 122)
        Me.HScrollBar1.Maximum = 200
        Me.HScrollBar1.Minimum = 135
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(333, 42)
        Me.HScrollBar1.TabIndex = 4
        Me.HScrollBar1.Value = 135
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(17, 183)
        Me.HScrollBar2.Maximum = 72
        Me.HScrollBar2.Minimum = 8
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(333, 42)
        Me.HScrollBar2.TabIndex = 5
        Me.HScrollBar2.Value = 8
        '
        'HScrollBar3
        '
        Me.HScrollBar3.Location = New System.Drawing.Point(17, 241)
        Me.HScrollBar3.Maximum = 230
        Me.HScrollBar3.Minimum = 29
        Me.HScrollBar3.Name = "HScrollBar3"
        Me.HScrollBar3.Size = New System.Drawing.Size(333, 42)
        Me.HScrollBar3.TabIndex = 6
        Me.HScrollBar3.Value = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 433)
        Me.Controls.Add(Me.HScrollBar3)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents HScrollBar3 As System.Windows.Forms.HScrollBar

End Class
