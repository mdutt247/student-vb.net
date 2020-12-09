Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Load("C:\Users\Admin\Pictures\green.png")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (PictureBox1.Equals(Nothing)) Then
            MessageBox.Show("1 no pic")
        ElseIf (PictureBox2.Equals(Nothing)) Then
            MessageBox.Show("2 no pic")
        Else
            MessageBox.Show("ayyyyyyyyyyyyyyyyyyyy")
        End If
        'PictureBox2.Load(PictureBox1.ImageLocation)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Load(PictureBox1.ImageLocation)
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Application.Exit()
    End Sub
End Class
