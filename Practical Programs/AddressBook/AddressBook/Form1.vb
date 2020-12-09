Imports System.IO

Public Class Form1

    Dim i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Using reader As New StreamReader(New FileStream("DB.txt", FileMode.OpenOrCreate, FileAccess.Read))
            While reader.Peek <> -1

                Dim row As String = reader.ReadLine
                Dim columns() As String = row.Split(CChar("|"))
                LBId.Items.Add(columns(0))
                LBName.Items.Add(columns(1))
                LBPhone.Items.Add(columns(2))
                LBAddress.Items.Add(columns(3))

            End While
        End Using

        LBId2.Items.AddRange(LBId.Items)
        LBName2.Items.AddRange(LBName.Items)
        LBPhone2.Items.AddRange(LBPhone.Items)
        LBAddress2.Items.AddRange(LBAddress.Items)

        LBId3.Items.AddRange(LBId.Items)
        LBName3.Items.AddRange(LBName.Items)
        LBPhone3.Items.AddRange(LBPhone.Items)
        LBAddress3.Items.AddRange(LBAddress.Items)

        LBId4.Items.AddRange(LBId3.Items)
        LBName4.Items.AddRange(LBName3.Items)
        LBPhone4.Items.AddRange(LBPhone3.Items)
        LBAddress4.Items.AddRange(LBAddress3.Items)

        Dim temp As Int16
        Dim temp1 As String
        Dim temp2 As String
        Dim temp3 As String

        For i As Integer = 0 To LBId4.Items.Count - 1
            For j As Integer = i + 1 To LBId4.Items.Count - 1
                If CDec(LBId4.Items(j)) < CDec(LBId4.Items(i)) Then
                    'If LBId4.Items(j) > LBId4.Items(i) Then
                    temp = LBId4.Items(i)
                    LBId4.Items(i) = LBId4.Items(j)
                    LBId4.Items(j) = temp

                    temp1 = LBName4.Items(i)
                    LBName4.Items(i) = LBName4.Items(j)
                    LBName4.Items(j) = temp1

                    temp2 = LBPhone4.Items(i)
                    LBPhone4.Items(i) = LBPhone4.Items(j)
                    LBPhone4.Items(j) = temp2

                    temp3 = LBAddress4.Items(i)
                    LBAddress4.Items(i) = LBAddress4.Items(j)
                    LBAddress4.Items(j) = temp3

                End If
            Next
        Next

   

        LBId.Items.Clear()
        LBName.Items.Clear()
        LBPhone.Items.Clear()
        LBAddress.Items.Clear()

        LBId3.Items.Clear()
        LBName3.Items.Clear()
        LBPhone3.Items.Clear()
        LBAddress3.Items.Clear()

        LBId.Items.AddRange(LBId4.Items)
        LBName.Items.AddRange(LBName4.Items)
        LBPhone.Items.AddRange(LBPhone4.Items)
        LBAddress.Items.AddRange(LBAddress4.Items)

        LBId3.Items.AddRange(LBId4.Items)
        LBName3.Items.AddRange(LBName4.Items)
        LBPhone3.Items.AddRange(LBPhone4.Items)
        LBAddress3.Items.AddRange(LBAddress4.Items)

        'Writing sorted data in file

        Using trc As StreamWriter = New StreamWriter(File.Open("DB.txt", FileMode.Truncate))

        End Using

        Using writer As StreamWriter = New StreamWriter(File.Open("DB.txt", FileMode.Append))
            Dim n As Integer = LBId4.Items.Count - 1

            For num = 0 To n
                writer.Write(LBId4.Items(num))
                writer.Write("|")
                writer.Write(LBName4.Items(num))
                writer.Write("|")
                writer.Write(LBPhone4.Items(num))
                writer.Write("|")
                writer.Write(LBAddress4.Items(num))
                If num < n Then
                    writer.WriteLine("")
                End If
            Next

        End Using

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim frmAdd As New fAdd
        Me.Hide()
        frmAdd.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LBName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBName.SelectedIndexChanged
        LBId.SelectedIndex = LBName.SelectedIndex
        LBAddress.SelectedIndex = LBName.SelectedIndex
        LBPhone.SelectedIndex = LBName.SelectedIndex




    End Sub

    Private Sub LBId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBId.SelectedIndexChanged
        If LBId.SelectedIndex >= 0 Then
            'MsgBox("Selected")
            BySelectionToolStripMenuItem.Enabled = True
            BySelectionToolStripMenuItem1.Enabled = True
        Else
            'MsgBox("Noooo")
            BySelectionToolStripMenuItem.Enabled = False
            BySelectionToolStripMenuItem1.Enabled = False
        End If
        LBName.SelectedIndex = LBId.SelectedIndex
        LBAddress.SelectedIndex = LBId.SelectedIndex
        LBPhone.SelectedIndex = LBId.SelectedIndex

    End Sub

    Private Sub LBPhone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBPhone.SelectedIndexChanged
        LBName.SelectedIndex = LBPhone.SelectedIndex
        LBAddress.SelectedIndex = LBPhone.SelectedIndex
        LBId.SelectedIndex = LBPhone.SelectedIndex
    End Sub

    Private Sub LBAddress_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBAddress.SelectedIndexChanged
        LBName.SelectedIndex = LBAddress.SelectedIndex
        LBPhone.SelectedIndex = LBAddress.SelectedIndex
        LBId.SelectedIndex = LBAddress.SelectedIndex
    End Sub

    Private Sub BySelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BySelectionToolStripMenuItem.Click
        
        Dim id As Integer = LBId.SelectedIndex

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

        Me.Hide()
        Dim frmBlank As New Blank
        frmBlank.Show()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

    End Sub

    Private Sub ByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByIDToolStripMenuItem.Click
        Dim frmDel As New fDel
        frmDel.LBId.Items.AddRange(LBId3.Items)
        frmDel.LBName.Items.AddRange(LBName3.Items)
        frmDel.LBPhone.Items.AddRange(LBPhone3.Items)
        frmDel.LBAddress.Items.AddRange(LBAddress3.Items)
        Me.Hide()
        frmDel.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TSearch.TextChanged
        LBId.Items.Clear()
        LBName.Items.Clear()
        LBPhone.Items.Clear()
        LBAddress.Items.Clear()

        If TSearch.Text = "" Then

            LBId.Items.AddRange(LBId4.Items)
            LBName.Items.AddRange(LBName4.Items)
            LBPhone.Items.AddRange(LBPhone4.Items)
            LBAddress.Items.AddRange(LBAddress4.Items)

            If LBId.SelectedIndex >= 0 Then
                BySelectionToolStripMenuItem.Enabled = True
                BySelectionToolStripMenuItem1.Enabled = True
            Else
                BySelectionToolStripMenuItem.Enabled = False
                BySelectionToolStripMenuItem1.Enabled = False
            End If

        Else

            If SByIDToolStripMenuItem.Checked = True Then

                For a As Integer = 0 To LBId3.Items.Count - 1


                    If TSearch.Text <> String.Empty Then
                        i = LBId2.FindString(TSearch.Text)
                        If i <> -1 Then
                            LBId.Items.Add(LBId2.Items(i).ToString())
                            LBName.Items.Add(LBName2.Items(i).ToString())
                            LBPhone.Items.Add(LBPhone2.Items(i).ToString())
                            LBAddress.Items.Add(LBAddress2.Items(i).ToString())

                            LBId2.Items.RemoveAt(i)
                            LBName2.Items.RemoveAt(i)
                            LBPhone2.Items.RemoveAt(i)
                            LBAddress2.Items.RemoveAt(i)
                        Else
                            ' Button1.Enabled = False
                        End If

                    End If
                Next

                LBId2.Items.Clear()
                LBName2.Items.Clear()
                LBPhone2.Items.Clear()
                LBAddress2.Items.Clear()

                LBId2.Items.AddRange(LBId3.Items)
                LBName2.Items.AddRange(LBName3.Items)
                LBPhone2.Items.AddRange(LBPhone3.Items)
                LBAddress2.Items.AddRange(LBAddress3.Items)


            ElseIf SByNameToolStripMenuItem.Checked = True Then

                For b As Integer = 0 To LBId3.Items.Count - 1


                    If TSearch.Text <> String.Empty Then
                        i = LBName2.FindString(TSearch.Text)
                        If i <> -1 Then
                            LBId.Items.Add(LBId2.Items(i).ToString())
                            LBName.Items.Add(LBName2.Items(i).ToString())
                            LBPhone.Items.Add(LBPhone2.Items(i).ToString())
                            LBAddress.Items.Add(LBAddress2.Items(i).ToString())

                            LBId2.Items.RemoveAt(i)
                            LBName2.Items.RemoveAt(i)
                            LBPhone2.Items.RemoveAt(i)
                            LBAddress2.Items.RemoveAt(i)
                        Else
                            ' Button1.Enabled = False
                        End If

                    End If
                Next

                LBId2.Items.Clear()
                LBName2.Items.Clear()
                LBPhone2.Items.Clear()
                LBAddress2.Items.Clear()

                LBId2.Items.AddRange(LBId3.Items)
                LBName2.Items.AddRange(LBName3.Items)
                LBPhone2.Items.AddRange(LBPhone3.Items)
                LBAddress2.Items.AddRange(LBAddress3.Items)

            ElseIf SByPhoneToolStripMenuItem.Checked = True Then

                For c As Integer = 0 To LBId3.Items.Count - 1

                    If TSearch.Text <> String.Empty Then
                        i = LBPhone2.FindString(TSearch.Text)
                        If i <> -1 Then
                            LBId.Items.Add(LBId2.Items(i).ToString())
                            LBName.Items.Add(LBName2.Items(i).ToString())
                            LBPhone.Items.Add(LBPhone2.Items(i).ToString())
                            LBAddress.Items.Add(LBAddress2.Items(i).ToString())

                            LBId2.Items.RemoveAt(i)
                            LBName2.Items.RemoveAt(i)
                            LBPhone2.Items.RemoveAt(i)
                            LBAddress2.Items.RemoveAt(i)
                        Else
                            ' Button1.Enabled = False
                        End If

                    End If
                Next

                LBId2.Items.Clear()
                LBName2.Items.Clear()
                LBPhone2.Items.Clear()
                LBAddress2.Items.Clear()

                LBId2.Items.AddRange(LBId3.Items)
                LBName2.Items.AddRange(LBName3.Items)
                LBPhone2.Items.AddRange(LBPhone3.Items)
                LBAddress2.Items.AddRange(LBAddress3.Items)

            ElseIf SByAddressToolStripMenuItem.Checked = True Then

                For d As Integer = 0 To LBId3.Items.Count - 1

                    If TSearch.Text <> String.Empty Then
                        i = LBAddress2.FindString(TSearch.Text)
                        If i <> -1 Then
                            LBId.Items.Add(LBId2.Items(i).ToString())
                            LBName.Items.Add(LBName2.Items(i).ToString())
                            LBPhone.Items.Add(LBPhone2.Items(i).ToString())
                            LBAddress.Items.Add(LBAddress2.Items(i).ToString())

                            LBId2.Items.RemoveAt(i)
                            LBName2.Items.RemoveAt(i)
                            LBPhone2.Items.RemoveAt(i)
                            LBAddress2.Items.RemoveAt(i)
                        Else
                            ' Button1.Enabled = False
                        End If

                    End If

                Next

                LBId2.Items.Clear()
                LBName2.Items.Clear()
                LBPhone2.Items.Clear()
                LBAddress2.Items.Clear()

                LBId2.Items.AddRange(LBId3.Items)
                LBName2.Items.AddRange(LBName3.Items)
                LBPhone2.Items.AddRange(LBPhone3.Items)
                LBAddress2.Items.AddRange(LBAddress3.Items)

            Else
                MsgBox("Select a Search Criteria!")

            End If
        End If
    End Sub

    Private Sub ColorDef()
        LBId.BackColor = Color.White
        LBName.BackColor = Color.White
        LBPhone.BackColor = Color.White
        LBAddress.BackColor = Color.White
    End Sub
    
    Private Sub SByIDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SByIDToolStripMenuItem.Click
        TSearch.Clear()
        SByNameToolStripMenuItem.Checked = False
        SByPhoneToolStripMenuItem.Checked = False
        SByAddressToolStripMenuItem.Checked = False
        ColorDef()
        LBId.BackColor = Color.AliceBlue
    End Sub

    Private Sub SByPhoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SByPhoneToolStripMenuItem.Click
        TSearch.Clear()
        SByNameToolStripMenuItem.Checked = False
        SByIDToolStripMenuItem.Checked = False
        SByAddressToolStripMenuItem.Checked = False
        ColorDef()
        LBPhone.BackColor = Color.AliceBlue
    End Sub

    Private Sub SByAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SByAddressToolStripMenuItem.Click
        TSearch.Clear()
        SByNameToolStripMenuItem.Checked = False
        SByPhoneToolStripMenuItem.Checked = False
        SByIDToolStripMenuItem.Checked = False
        ColorDef()
        LBAddress.BackColor = Color.AliceBlue
    End Sub

    Private Sub SByNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SByNameToolStripMenuItem.Click
        TSearch.Clear()
        SByIDToolStripMenuItem.Checked = False
        SByPhoneToolStripMenuItem.Checked = False
        SByAddressToolStripMenuItem.Checked = False
        ColorDef()
        LBName.BackColor = Color.AliceBlue
    End Sub

    Private Sub ByOptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByOptionToolStripMenuItem.Click
        Dim frmMod As New fMod
        frmMod.LBId.Items.AddRange(LBId4.Items)
        frmMod.LBName.Items.AddRange(LBName4.Items)
        frmMod.LBPhone.Items.AddRange(LBPhone4.Items)
        frmMod.LBAddress.Items.AddRange(LBAddress4.Items)
        Me.Hide()
        frmMod.Show()
    End Sub

    Private Sub BySelectionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BySelectionToolStripMenuItem1.Click
        Dim frmMod As New fMod
        frmMod.LBId.Items.AddRange(LBId4.Items)
        frmMod.LBName.Items.AddRange(LBName4.Items)
        frmMod.LBPhone.Items.AddRange(LBPhone4.Items)
        frmMod.LBAddress.Items.AddRange(LBAddress4.Items)
        frmMod.TId.Text = LBId.SelectedItem.ToString()
        Me.Hide()
        frmMod.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub
End Class
