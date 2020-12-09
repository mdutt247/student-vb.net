Public Class Form1

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)


    End Sub

    Private Sub HScrollBar1_Scroll_1(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        'TextBox1.Text = TextBox1.Size.ToString()
        TextBox1.Width = HScrollBar1.Value
        TextBox1.Height = HScrollBar1.Value / 4
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Dim fnt As Font
        fnt = TextBox1.Font
        TextBox1.Font = New Font("Microsoft Sans Serif", HScrollBar2.Value, FontStyle.Bold)
        'TextBox1.Text = HScrollBar2.Value.ToString

        TextBox1.Width = HScrollBar2.Value * 8
        TextBox1.Height = HScrollBar2.Value * 2

    End Sub

    Private Sub HScrollBar3_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar3.Scroll

        TextBox1.Location = New Point(HScrollBar3.Value, 29)


    End Sub
End Class
