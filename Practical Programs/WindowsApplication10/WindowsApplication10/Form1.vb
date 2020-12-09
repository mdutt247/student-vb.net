Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Your order has been placed with quantity " + TextBox1.Text + ".")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As String In ListBox1.SelectedItems
            ListBox2.Items.Add(item)
        Next

        For Each item As String In ListBox2.Items
            ListBox1.Items.Remove(item)
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each item As String In ListBox2.SelectedItems
            ListBox1.Items.Add(item)
        Next

        For Each item As String In ListBox1.Items
            ListBox2.Items.Remove(item)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
