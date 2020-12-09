Imports System.IO
Public Class StreamWriterClass

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim myData As String = txtFName.Text & ":" & txtLName.Text & ":" & txtEmail.Text & ":" & txtAddress.Text
        Dim fs As FileStream = Nothing
        Dim streamWrite As StreamWriter = Nothing
        Try
            fs = New FileStream("D:\TextData", FileMode.Append, FileAccess.Write)
            streamWrite = New StreamWriter(fs)

            streamWrite.WriteLine(myData)

            MsgBox("Data written to binary file", MsgBoxStyle.Information, "Save")
            ClearTextBox(Me)
            txtFName.Select()
        Catch ex As IOException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)
        Finally
            If streamWrite IsNot Nothing Then
                streamWrite.Close()
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

    Private Sub TextMouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.MouseEnter, txtFName.MouseEnter, txtEmail.MouseEnter, txtAddress.MouseEnter
        sender.BackColor = Color.Bisque
    End Sub

    Private Sub TextMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLName.MouseLeave, txtFName.MouseLeave, txtEmail.MouseLeave, txtAddress.MouseLeave
        sender.BackColor = Color.White
    End Sub
End Class
