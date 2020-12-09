Imports System.IO
Public Class BinaryWriterClass

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim myData(3) As String
        myData(0) = txtFName.Text
        myData(1) = txtLName.Text
        myData(2) = txtEmail.Text
        myData(3) = txtAddress.Text

        Dim fs As FileStream = Nothing
        Dim binaryWrite As BinaryWriter = Nothing
        Try
            fs = New FileStream("D:\BinaryData", FileMode.Append, FileAccess.Write)
            binaryWrite = New BinaryWriter(fs)

            For Each value As String In myData
                binaryWrite.Write(value)
            Next

            MsgBox("Data written to binary file", MsgBoxStyle.Information, "Save")
            ClearTextBox(Me)
            txtFName.Select()
        Catch ex As IOException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)
        Finally
            If binaryWrite IsNot Nothing Then
                binaryWrite.Close()
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Public Sub ClearTextBox(ByVal f As Form)
        For Each Ctl In f.Controls
            If TypeOf Ctl Is TextBox Then
                Ctl.Text = ""
            End If
        Next
    End Sub

    Private Sub TextGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.GotFocus, txtLName.GotFocus, txtEmail.GotFocus, txtAddress.GotFocus
        sender.BackColor = Color.Red
    End Sub

    Private Sub TextLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFName.LostFocus, txtLName.LostFocus, txtEmail.LostFocus, txtAddress.LostFocus
        sender.BackColor = Color.Pink
    End Sub

    Private Sub TextMouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.MouseEnter, txtFName.MouseEnter, txtEmail.MouseEnter, txtAddress.MouseEnter
        sender.BackColor = Color.Blue
    End Sub

    Private Sub TextMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.MouseLeave, txtFName.MouseLeave, txtEmail.MouseLeave, txtAddress.MouseLeave
        sender.BackColor = Color.OliveDrab
    End Sub
End Class
