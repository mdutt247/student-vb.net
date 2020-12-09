Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub



    Sub ChangeFormColor(FormName As Form1)
        Randomize()
        FormName.BackColor = Color.FromArgb(Rnd() * 256, Rnd() * 256, Rnd() * 256)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 200
            ChangeFormColor(Me)
            Button1.Text = i.ToString()
            MessageBox.Show("")
        Next
    End Sub
End Class
