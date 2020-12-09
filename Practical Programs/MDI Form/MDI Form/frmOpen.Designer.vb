<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpen
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
        Me.rtxShowContent = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'rtxShowContent
        '
        Me.rtxShowContent.Enabled = False
        Me.rtxShowContent.Location = New System.Drawing.Point(2, 3)
        Me.rtxShowContent.Name = "rtxShowContent"
        Me.rtxShowContent.Size = New System.Drawing.Size(461, 318)
        Me.rtxShowContent.TabIndex = 0
        Me.rtxShowContent.Text = ""
        '
        'frmOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 322)
        Me.Controls.Add(Me.rtxShowContent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpen"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Open"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtxShowContent As System.Windows.Forms.RichTextBox
End Class
