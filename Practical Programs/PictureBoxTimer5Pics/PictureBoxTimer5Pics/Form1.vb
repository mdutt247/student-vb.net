Public Class Form1
    Dim i As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
   
        i = i + 1
        Label1.Text = i.ToString()

        If i = 100 Then
            PictureBox1.Image = My.Resources.blank
        ElseIf i = 200 Then
            PictureBox1.Image = My.Resources.red
        ElseIf i = 300 Then
            PictureBox1.Image = My.Resources.yellow
        ElseIf i = 400 Then
            PictureBox1.Image = My.Resources.green
        ElseIf i = 500 Then
            PictureBox1.Image = My.Resources.Desert
            Timer1.Stop()
        End If

    End Sub

    
End Class
