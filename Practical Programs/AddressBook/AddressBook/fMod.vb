Imports System.IO
Public Class fMod
    Dim i As Integer

    Private Sub TId_TextChanged(sender As Object, e As EventArgs) Handles TId.TextChanged

        TName.Clear()
        TPhone.Clear()
        TAddress.Clear()
        If TId.Text <> String.Empty Then
            i = LBId.FindStringExact(TId.Text)
            If i <> -1 Then
                TName.Text = LBName.Items(i).ToString()
                TPhone.Text = LBPhone.Items(i).ToString()
                TAddress.Text = LBAddress.Items(i).ToString()
                Button1.Enabled = True
            Else
                Button1.Enabled = False
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim id As Integer

        If TId.Text <> String.Empty Then
            i = LBId.FindString(TId.Text)
            If i <> -1 Then
                id = i
            Else

            End If

        End If

        ' id = id - 1

        LBId.Items.RemoveAt(id)
        LBName.Items.RemoveAt(id)
        LBPhone.Items.RemoveAt(id)
        LBAddress.Items.RemoveAt(id)

        LBId.Items.Add(TId.Text)
        LBName.Items.Add(TName.Text)
        LBPhone.Items.Add(TPhone.Text)
        LBAddress.Items.Add(TAddress.Text)

        Using trc As StreamWriter = New StreamWriter(File.Open("DB.txt", FileMode.Truncate))


        End Using


        Using writer As StreamWriter = New StreamWriter(File.Open("DB.txt", FileMode.Append))
            Dim n As Integer = LBId.Items.Count - 1

            For num = 0 To n
                writer.Write(LBId.Items(num))
                writer.Write("|")
                writer.Write(LBName.Items(num))
                writer.Write("|")
                writer.Write(LBPhone.Items(num))
                writer.Write("|")
                writer.Write(LBAddress.Items(num))
                If num < n Then
                    writer.WriteLine("")
                End If
            Next

        End Using

        MsgBox("Contact Modified Successfully")
        Me.Hide()

        Dim frmHome As New Form1
        frmHome.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim frmHome As New Form1
        frmHome.Show()
    End Sub
End Class