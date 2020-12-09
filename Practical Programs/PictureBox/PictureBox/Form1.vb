Public Class Form1
    Dim a As Image = My.Resources.images
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Image = a
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Move image of picture box to another picture box
        If (PictureBox1.Image Is a) Then
            PictureBox2.Image = a
            PictureBox1.Image = Nothing
        ElseIf (PictureBox2.Image Is a) Then
            PictureBox1.Image = a
            PictureBox2.Image = Nothing
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Copy image of picture box to another picture box
        If (PictureBox1.Image Is a) Then
            PictureBox2.Image = a
        ElseIf (PictureBox2.Image Is a) Then
            PictureBox1.Image = a
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Picture Box - Load/Copy/Move"
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myForm As New Form2
        myForm.Show()
    End Sub
End Class
