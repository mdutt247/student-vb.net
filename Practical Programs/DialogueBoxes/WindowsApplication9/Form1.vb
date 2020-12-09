Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim text As String = "In document_PrintPage method."
        Dim printFont As New System.Drawing.Font("Arial", 35, System.Drawing.FontStyle.Regular)

        ' Draw the content.
        e.Graphics.DrawString(text, printFont, System.Drawing.Brushes.Black, 10, 10)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'NOT part of dialogue boxes
        PrintForm1.Form = Me
        PrintForm1.Print()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg*)|*.jpg"
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
        Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, RichTextBox1.Text, True)
        End If
    End Sub

  
End Class
