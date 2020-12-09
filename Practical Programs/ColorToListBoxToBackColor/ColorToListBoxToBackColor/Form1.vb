Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ListBox1.Items.Contains(TextBox1.Text) = True Then

            MsgBox("Item exists")
        Else
            ListBox1.Items.Add(TextBox1.Text)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Blue" Then
            Me.BackColor = Color.Blue
        ElseIf ListBox1.SelectedItem = "Red" Then
            Me.BackColor = Color.Red
        ElseIf ListBox1.SelectedItem = "Green" Then
            Me.BackColor = Color.Green
        ElseIf ListBox1.SelectedItem = "Yellow" Then
            Me.BackColor = Color.Yellow
        ElseIf ListBox1.SelectedItem = "Pink" Then
            Me.BackColor = Color.Pink
        Else
            MsgBox("Unknown Color")
        End If
    End Sub
End Class
