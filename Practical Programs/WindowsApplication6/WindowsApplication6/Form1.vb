Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If Label1.Text = 0 Then PictureBox1.BackColor = Color.BlueViolet
        'If Label1.Text = 1 Then PictureBox1.BackColor = Color.Brown
        'If Label1.Text = 2 Then PictureBox1.BackColor = Color.Red
        'If Label1.Text = 3 Then PictureBox1.BackColor = Color.Green
        'If Label1.Text = 4 Then PictureBox1.BackColor = Color.Yellow
        'If Label1.Text = 5 Then PictureBox1.BackColor = Color.Aqua
        'If Label1.Text = 6 Then PictureBox1.BackColor = Color.CadetBlue
        'If Label1.Text = 7 Then PictureBox1.BackColor = Color.Purple
        'If Label1.Text = 8 Then PictureBox1.BackColor = Color.Black
        'If Label1.Text = 9 Then PictureBox1.BackColor = Color.Tomato

        If Label1.Text = 0 Then PictureBox1.Image = My.Resources.Jellyfish
        If Label1.Text = 1 Then PictureBox1.Image = My.Resources.Penguins
        If Label1.Text = 2 Then PictureBox1.Image = My.Resources.Desert
        If Label1.Text = 3 Then PictureBox1.Image = My.Resources.Chrysanthemum
        If Label1.Text = 4 Then PictureBox1.Image = My.Resources.Hydrangeas

        ListBox1.Items.Add(Val(Label1.Text))
        Label1.Text = Val(Label1.Text) + 1
        If Label1.Text = 5 Then Timer1.Enabled = False
        If Label1.Text = 5 Then Button1.Enabled = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True


    End Sub
End Class
