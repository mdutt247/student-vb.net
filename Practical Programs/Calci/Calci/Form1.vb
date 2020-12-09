Public Class Calci

    Private Sub Num1_Click(sender As Object, e As EventArgs) Handles Num1.Click
        Display.Text = Display.Text + "1"
    End Sub

    Private Sub Num2_Click(sender As Object, e As EventArgs) Handles Num2.Click
        Display.Text = Display.Text + "2"
    End Sub

    Private Sub Num3_Click(sender As Object, e As EventArgs) Handles Num3.Click
        Display.Text = Display.Text + "3"
    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        Display.Text = Display.Text + "4"
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        Display.Text = Display.Text + "5"
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        Display.Text = Display.Text + "6"
    End Sub

    Private Sub Num7_Click(sender As Object, e As EventArgs) Handles Num7.Click
        Display.Text = Display.Text + "7"
    End Sub

    Private Sub Num8_Click(sender As Object, e As EventArgs) Handles Num8.Click
        Display.Text = Display.Text + "8"
    End Sub

    Private Sub Num9_Click(sender As Object, e As EventArgs) Handles Num9.Click
        Display.Text = Display.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Num0.Click
        Display.Text = Display.Text + "0"
    End Sub

    Private Sub OpDivide_Click(sender As Object, e As EventArgs) Handles OpDivide.Click

    End Sub

    Private Sub OpDot_Click(sender As Object, e As EventArgs) Handles OpDot.Click
        Display.Text = Display.Text + "."
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
       
        Label2.Text = Display.Text

        Dim ans As Decimal
        ans = CDec(Label1.Text) + CDec(Label2.Text)
        Display.Text = ans.ToString()

    End Sub

    Private Sub OpAdd_Click(sender As Object, e As EventArgs) Handles OpAdd.Click
        Label1.Text = Display.Text
        Display.Text = ""
    End Sub
End Class
