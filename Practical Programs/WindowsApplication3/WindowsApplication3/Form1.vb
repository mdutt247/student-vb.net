Public Class frmInvoice

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If txtSubtotal.Text >= 500 Then
            txtDiscountPercent.Text = "0.2"
        ElseIf txtSubtotal.Text >= 250 And txtSubtotal.Text < 500 Then
            txtDiscountPercent.Text = "0.15"
        ElseIf txtSubtotal.Text >= 100 And txtSubtotal.Text < 250 Then
            txtDiscountPercent.Text = "0.1"
        Else
            txtDiscountPercent.Text = "0"
        End If

        txtDiscontAmount.Text = txtDiscountPercent.Text * txtSubtotal.Text
        txtTotal.Text = txtSubtotal.Text - txtDiscontAmount.Text
        txtTotal.Text = "Rs." + txtTotal.Text

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End

    End Sub
End Class
