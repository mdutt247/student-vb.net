Public Class frmBase

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Change the Output type to Class Library
        'About Button - Modifiers=Private
        'Help Button - Modifiers=Protected

        'Build the project
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("About appears here!")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Help appears here!")
    End Sub
End Class
