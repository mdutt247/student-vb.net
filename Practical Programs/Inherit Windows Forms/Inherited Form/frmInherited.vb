Public Class frmInherited

    Private Sub frmInherited_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Add Inherited Form
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MsgBox("Hi " & TextBox1.Text & " this is an example of form inheritance!")
    End Sub
End Class
