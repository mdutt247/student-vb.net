Imports System.IO
Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Please select a text file."
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Try
                Using sr As New StreamReader(OpenFileDialog1.FileName)
                    Dim line As String
                    line = sr.ReadToEnd()
                    frmOpen.rtxShowContent.Text = line
                    frmOpen.MdiParent = Me
                    frmOpen.Dock = DockStyle.Fill
                    frmOpen.Text = OpenFileDialog1.FileName
                    frmOpen.Show()
                End Using
            Catch exp As Exception
                MsgBox(exp.Message)
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim sfd As New SaveFileDialog
        Dim filename As String
        sfd.ShowDialog()
        filename = sfd.FileName
        Dim fout As New StreamWriter(filename)
        fout.Write(frmOpen.rtxShowContent.Text)
        fout.Close()
    End Sub

    Private Sub ModifyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyToolStripMenuItem.Click
        frmOpen.rtxShowContent.Enabled = True
    End Sub
End Class
