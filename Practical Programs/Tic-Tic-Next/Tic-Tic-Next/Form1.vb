Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TicTicDBDataSet.tblStudent' table. You can move, or remove it, as needed.
        Me.TblStudentTableAdapter.Fill(Me.TicTicDBDataSet.tblStudent)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim sid As Integer = DataGridView1.SelectedRows(0).Cells(0).Value
            If MessageBox.Show("Do you want to delete the record with id " & sid & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                TblStudentTableAdapter.DeleteQuery(sid)
                'TblStudentBindingSource.EndEdit()
                TblStudentTableAdapter.Update(TicTicDBDataSet.tblStudent)
                MsgBox("Data deleted", MsgBoxStyle.Information, "Success")
                TblStudentTableAdapter.Fill(TicTicDBDataSet.tblStudent)
            End If
        Else
            MsgBox("Please select a row", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        If txtName.Text = "" Or txtAddress.Text = "" Then
            MsgBox("Name and address are not null field", MsgBoxStyle.Critical, "Entry error")
        Else
            '' '' '' '' '' Create a new row
            ' '' '' '' ''Dim newrow As TicTicDBDataSet.tblStudentRow
            ' '' '' '' ''newrow = TicTicDBDataSet.tblStudent.NewtblStudentRow
            ' '' '' '' ''newrow.stuName = txtName.Text
            ' '' '' '' ''newrow.stuAddress = txtAddress.Text
            '' '' '' '' '' Add the row to the tblStudent table
            ' '' '' '' ''TicTicDBDataSet.tblStudent.Rows.Add(newrow)
            '' '' '' '' '' Save the new row to the database
            ' '' '' '' ''TblStudentTableAdapter.Update(TicTicDBDataSet.tblStudent)
            TblStudentTableAdapter.InsertQuery(txtName.Text, txtAddress.Text)
            'TblStudentBindingSource.EndEdit()
            TblStudentTableAdapter.Update(TicTicDBDataSet.tblStudent)
            MsgBox("Data inserted", MsgBoxStyle.Information, "Success")
            txtAddress.Text = ""
            txtName.Text = ""
            Me.TblStudentTableAdapter.Fill(Me.TicTicDBDataSet.tblStudent)
        End If

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim sid As Integer = DataGridView1.SelectedRows(0).Cells(0).Value
            If MessageBox.Show("Do you want to update the record with id " & sid & "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If txtUname.Text = "" Or txtUaddress.Text = "" Then
                    MsgBox("Name and address are not null field", MsgBoxStyle.Critical, "Error")
                Else
                    TblStudentTableAdapter.UpdateQuery(txtUname.Text, txtUaddress.Text, sid)
                    'TblStudentBindingSource.EndEdit()
                    TblStudentTableAdapter.Update(TicTicDBDataSet.tblStudent)
                    MsgBox("Data updated", MsgBoxStyle.Information, "Success")
                    TblStudentTableAdapter.Fill(TicTicDBDataSet.tblStudent)
                End If
            End If
        Else
            MsgBox("Please select a row", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellClick

        Dim id As Integer = DataGridView1.CurrentCell.RowIndex
        txtUname.Text = TicTicDBDataSet.Tables(0).Rows(id)("stuName").ToString()
        txtUaddress.Text = TicTicDBDataSet.Tables(0).Rows(id)("stuAddress").ToString()

    End Sub
End Class
