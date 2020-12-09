Public Class Form2
    Dim isDataSaved As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paymentForm As New Form1
        Dim selectedButton As DialogResult = paymentForm.ShowDialog()
        If selectedButton = Windows.Forms.DialogResult.OK Then
            Label3.Text = Form1.Tag.ToString
        End If
    End Sub

    Private Sub DataChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged, Label3.TextChanged
        isDataSaved = False
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isDataSaved = False Then

            Dim message As String = "This form contains unsaved data" & vbCrLf & vbCrLf & "Do you want to save it?"

            Dim button As DialogResult = MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)


            If button = DialogResult.Yes Then
                If IsValidData() Then
                    Me.SaveData()
                Else
                    e.Cancel = True
                End If
            ElseIf button = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If

        End If
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Mike Smith")
        ComboBox1.Items.Add("Nancy Jones")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IsValidData() Then
            Me.SaveData()
        End If
    End Sub

    Private Function IsValidData() As Boolean
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("You must select a customer.", "Entry Error")
            ComboBox1.Select()
            Return False
        End If
        If Label3.Text = "" Then
            MessageBox.Show("You must enter a payment.", "Entry Error")
            Return True
        End If
        Return True
    End Function

    Private Sub SaveData()
        ComboBox1.SelectedIndex = -1
        Label3.Text = ""
        isDataSaved = True
        ComboBox1.Select()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class