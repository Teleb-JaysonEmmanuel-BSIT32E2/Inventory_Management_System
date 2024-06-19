Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmPOS
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub bntLogout_Click(sender As Object, e As EventArgs) Handles bntLogout.Click
        Me.Close()
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Focus()
        frmLogin.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        frmManagePayment.Show()
    End Sub

    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getTransactionNumber()
    End Sub

    Private Sub getTransactionNumber()
        Try
            sql = "Select TransactionNumber from tblSales Order By TransactionNumber Desc"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblTransactNo.Text = Val(dr(0)) + 1
            Else
                lblTransactNo.Text = 1
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(TransactionNumber): " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmListProducts.Show()
    End Sub
End Class