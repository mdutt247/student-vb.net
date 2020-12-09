Imports System.IO
Public Class fAdd

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim array() As String = {Label4.Text, "|", TextBox1.Text, "|", TextBox2.Text, "|", TextBox3.Text}

        Using writer As StreamWriter = New StreamWriter(File.Open("DB.txt", FileMode.Append))

            writer.WriteLine()

            For Each value As String In array

                writer.Write(value)
            Next
        End Using

        MessageBox.Show("Contact Added Successfully!")
        Me.Hide()
        Dim frmHome As New Form1
        frmHome.Show()
    End Sub

    Private Sub fAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Label4.Visible = False
        Using reader As New StreamReader(New FileStream("DB.txt", FileMode.OpenOrCreate, FileAccess.Read))
            While reader.Peek <> -1

                Dim row As String = reader.ReadLine
                Dim columns() As String = row.Split(CChar("|"))
                Label4.Text = columns(0)
            End While
            Label4.Text = Label4.Text + 1

        End Using
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.TextLength = 10 Then
            TextBox3.Focus()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim frmHome As New Form1
        frmHome.Show()
    End Sub
End Class