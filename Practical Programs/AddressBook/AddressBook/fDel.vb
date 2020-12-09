Imports System.IO
Public Class fDel
    Dim i As Integer
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem = "Delete By ID" Then
            TId.Enabled = True
            TName.Enabled = False
            TPhone.Enabled = False
            TId.Focus()
        ElseIf ComboBox1.SelectedItem = "Delete By Name" Then
            TName.Enabled = True
            TId.Enabled = False
            TPhone.Enabled = False
            TName.Focus()
        ElseIf ComboBox1.SelectedItem = "Delete By Phone" Then
            TPhone.Enabled = True
            TId.Enabled = False
            TName.Enabled = False
            TPhone.Focus()
        Else
            TId.Enabled = False
            TName.Enabled = False
            TPhone.Enabled = False
        End If
    End Sub

    Dim s As Integer
    Private Sub Button2_click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim frmHome As New Form1
        frmHome.Show()

    End Sub

    Private Sub TId_TextChanged(sender As Object, e As EventArgs) Handles TId.TextChanged
        If TName.Enabled = False And TPhone.Enabled = False Then

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

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = i

        LBId.Items.RemoveAt(id)
        LBName.Items.RemoveAt(id)
        LBPhone.Items.RemoveAt(id)
        LBAddress.Items.RemoveAt(id)

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
        MsgBox("Contact Deleted Successfully")
        Me.Hide()
        Dim frmHome As New Form1
        frmHome.Show()
    End Sub

    Private Sub TName_TextChanged(sender As Object, e As EventArgs) Handles TName.TextChanged
        If TId.Enabled = False And TPhone.Enabled = False Then

            TId.Clear()
            TPhone.Clear()
            TAddress.Clear()
            If TName.Text <> String.Empty Then
                i = LBName.FindStringExact(TName.Text)
                If i <> -1 Then
                    TId.Text = LBId.Items(i).ToString()
                    TPhone.Text = LBPhone.Items(i).ToString()
                    TAddress.Text = LBAddress.Items(i).ToString()
                    Button1.Enabled = True
                Else
                    Button1.Enabled = False
                End If
            End If

        End If
    End Sub

    Private Sub TPhone_TextChanged(sender As Object, e As EventArgs) Handles TPhone.TextChanged
        If TId.Enabled = False And TName.Enabled = False Then

            TName.Clear()
            TId.Clear()
            TAddress.Clear()

            If TPhone.Text <> String.Empty Then
                i = LBPhone.FindStringExact(TPhone.Text)
                If i <> -1 Then
                    TName.Text = LBName.Items(i).ToString()
                    TId.Text = LBId.Items(i).ToString()
                    TAddress.Text = LBAddress.Items(i).ToString()
                    Button1.Enabled = True
                Else
                    Button1.Enabled = False
                End If
            End If

        End If
    End Sub

    Private Sub fDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TAddress_TextChanged(sender As Object, e As EventArgs) Handles TAddress.TextChanged

    End Sub
End Class