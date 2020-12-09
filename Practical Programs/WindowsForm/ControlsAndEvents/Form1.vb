Public Class frmOne

    Private Sub btnClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClick.Click
        lblResult.Text = "Hello " & txtName.Text
    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        lblResult.Text = txtName.Text
    End Sub

    Private Sub frmOne_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblResult.Text = "Setting text on run time by form's load event"
    End Sub

    Private Sub btnSum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSum.Click
        Dim no1, no2, sum As Integer
        no1 = CInt(txtNo1.Text)
        no2 = CInt(txtNo2.Text)
        sum = no1 + no2

        lblSum.Text = sum.ToString
    End Sub

    Private Sub btnAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToList.Click
        lstData.Items.Add(txtEnterInList.Text)
        txtEnterInList.Text = ""
        txtEnterInList.Select()
    End Sub

    Private Sub lstData_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstData.SelectedIndexChanged

        If lstData.SelectedItem = "Red" Then
            txtEnterInList.BackColor = Color.Red
            lstData.BackColor = Color.Red
        ElseIf lstData.SelectedItem = "Green" Then
            txtEnterInList.BackColor = Color.Green
            lstData.BackColor = Color.Green
        ElseIf lstData.SelectedItem = "Blue" Then
            txtEnterInList.BackColor = Color.Blue
            lstData.BackColor = Color.Blue
        ElseIf lstData.SelectedItem = "Orange" Then
            txtEnterInList.BackColor = Color.Orange
            lstData.BackColor = Color.Orange
        ElseIf lstData.SelectedItem = "Yellow" Then
            txtEnterInList.BackColor = Color.Yellow
            lstData.BackColor = Color.Yellow
        End If
    End Sub
End Class
