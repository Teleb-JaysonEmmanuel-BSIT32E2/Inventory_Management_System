Public Class frmManagePayment
    Private Sub cboPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayment.SelectedIndexChanged
        If cboPayment.Text = "Cash" Then
            txtRefNo.Enabled = False
            txtAmountPaid.Clear()
            txtAmountPaid.Enabled = True
        Else
            txtRefNo.Enabled = True
            txtAmountPaid.Text = lblGrandTotal.Text
            lblAmountChange.Text = "0.00"
            txtAmountPaid.Enabled = False
        End If
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        Dim change As Double
        change = Val(txtAmountPaid.Text) - Val(lblGrandTotal.Text)
        lblAmountChange.Text = Format(Val(change), "0.00")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click '
        If cboPayment.Text = "E-Payment" Or cboPayment.Text = "Card" Then
            If txtRefNo.Text = "" Then
                MsgBox("Please provide the Reference Number", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
        End If

        If Val(txtAmountPaid.Text) < Val(lblGrandTotal.Text) Then
            MsgBox("Insufficient Balance Payment!", MsgBoxStyle.Critical, "Please try again")
        Else
            frmPOS.lblAmountPaid.Text = Me.txtAmountPaid.Text
            frmPOS.lblAmountChange.Text = Me.lblAmountChange.Text
            frmPOS.lblMOP.Text = Me.cboPayment.Text
            frmPOS.lblRefNo.Text = Me.txtRefNo.Text
            frmPOS.btnConfirm.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class