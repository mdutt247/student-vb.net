Imports Microsoft.VisualBasic

Public Class Form1

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 89 And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
        '    e.Handled = True
        '    MsgBox("Numbers only.")
        'End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label1.Text = TextBox1.TextLength

        Dim ars() As String = Split(TextBox1.Text, " ")

        Label2.Text = ars.Count()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim numbr() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

        'Dim s As String = TextBox1.Text

        'Dim flag As Integer = 0

        ''  Label3.Text = s(0) & " " & numbr(9)

        ''For i As Integer = 0 To s.Length
        ''    MsgBox(s(i))
        ''    For j As Integer = 1 To 9
        ''        If s(i) = numbr(j) Then
        ''            MsgBox(s(i) & "  " & numbr(j))
        ''            flag = flag + 1
        ''        End If
        ''    Next
        ''Next

        'If IsNumeric(TextBox1.Text) Then
        '    MsgBox("num")
        'End If

    End Sub
End Class
