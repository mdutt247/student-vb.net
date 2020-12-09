Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = 0 Then
            PictureBox1.Image = My.Resources.red
        End If

        If Label1.Text = 31 Then
            PictureBox1.Image = My.Resources.blank
            PictureBox2.Image = My.Resources.yellow
        End If

        If Label1.Text = 36 Then
            PictureBox2.Image = My.Resources.blank
            PictureBox3.Image = My.Resources.green
        End If

        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = 60 Then Timer1.Enabled = False

    End Sub
End Class
