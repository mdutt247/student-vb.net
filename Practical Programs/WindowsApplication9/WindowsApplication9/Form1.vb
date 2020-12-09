Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
       

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
       
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True Or RadioButton2.Checked = True) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If (RadioButton3.Checked = True Or RadioButton4.Checked = True) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton1.Checked = True Or RadioButton2.Checked = True) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True Or RadioButton4.Checked = True) Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CheckBox1.Checked = True) Then
            If (RadioButton2.Checked = True) Then
                MessageBox.Show("Answer is Correct")
            Else
                MessageBox.Show("Answer is Wrong")
            End If
        ElseIf (CheckBox2.Checked = True) Then
            If (RadioButton4.Checked = True) Then
                MessageBox.Show("Answer is Correct")
            Else
                MessageBox.Show("Answer is Wrong")
            End If
        End If
    End Sub
End Class
