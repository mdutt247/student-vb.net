Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Picture Box - Stretch"
        PictureBox1.Image = My.Resources.images
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        PictureBox1.ClientSize = New Size(300, 300)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class