Public Class Form1

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim months() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

        For Each m As String In months
            ComboBox1.Items.Add(m)
        Next
        ComboBox1.Text = "Select a month"


        ComboBox2.Text = "Select a year"

        Dim year As Integer = DateTime.Today.Year
        Dim endYear As Integer = year + 8

        Do While year < endYear
            ComboBox2.Items.Add(year)
            year += 1
        Loop


        ListBox1.Items.Clear()
        ListBox1.Items.Add("Visa")
        ListBox1.Items.Add("Master Card")
        ListBox1.Items.Add("American Express")
        ListBox1.SelectedIndex = 0

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
