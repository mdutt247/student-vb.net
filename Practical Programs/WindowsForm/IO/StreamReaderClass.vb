Imports System.IO

Public Class StreamReaderClass

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub btnShowData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowData.Click

        Dim fs As FileStream = Nothing
        Dim streamReader As StreamReader = Nothing

        Try
            fs = New FileStream("D:\TextData", FileMode.Open, FileAccess.Read)
            streamReader = New StreamReader(fs)

            RichTextBox1.Text = streamReader.ReadToEnd

        Catch ex As IOException
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.ToString)
        Finally
            If streamReader IsNot Nothing Then
                streamReader.Close()
            End If
        End Try
    End Sub

End Class