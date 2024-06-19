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
        frmManagePayment.lblGrandTotal.Text = Me.lblGrandTotal.Text
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

    Dim i As ListViewItem
    Dim amount As Double

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        Try
            Dim j As String = InputBox("Enter the number of products", "Quantity")
            If j = "" Or j = 0 Then
                MsgBox("Please enter number of products")
            Else
                If Val(j) > Val(txtStock.Text) Then
                    MsgBox("Inputted Quantity is greater than Stock", MsgBoxStyle.Information)
                    Call replenishMessage()
                    MsgBox("Please Input Quantity within stock", MsgBoxStyle.Information)
                Else
                    If Val(txtStock.Text) < 10 Then
                        Call replenishMessage()
                        txtStock.Text = Val(txtStock.Text) - Val(j)
                        amount = Val(txtPrice.Text) * Val(j)
                        i = Me.ListView1.Items.Add(txtProductName.Text) 'Product Name
                        i.SubItems.Add(txtDescription.Text) 'Description
                        i.SubItems.Add(txtPrice.Text) 'Amount
                        i.SubItems.Add(j) 'Quantity
                        i.SubItems.Add(amount) 'Total Amount
                    End If
                End If
            End If
            Call getTotal()
            Call getTotalItems()
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(AddtoCart): " & ex.Message)
        End Try
    End Sub

    Private Sub replenishMessage()
        Try
            sql = "Insert into tblMessage (ReplenishMessage, MessageSent, Status) values (@ReplenishMessage, @MessageSent, @Status)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@ReplenishMessage", "Need to Restock on Product: '" & txtProductName.Text & "'")
                .Parameters.AddWithValue("@MessageSent", DateTime.Parse(lblDate.Text))
                .Parameters.AddWithValue("@Status", "Unread")
                .ExecuteNonQuery()
            End With
            MsgBox("Sending a Replenishment Message, Product might be out of stock or stock is less than 10", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(replenishMessage): " & ex.Message)
        End Try
    End Sub

    Private Sub getTotal()
        Const col As Integer = 4
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lblGrandTotal.Text = Format(Val(total), "0.00")
    End Sub

    Private Sub getTotalItems()
        Const col As Integer = 3
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lblTotalProductSold.Text = Val(total)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If MsgBox("Are you sure you want to remove this item?", vbQuestion + vbYesNo, "Please confirm") = vbYes Then
            If ListView1.Items.Count = 0 Then
                MsgBox("No product selected! Please select product to remove", MsgBoxStyle.Critical, "Please select product")
            Else
                If ListView1.SelectedItems.Count > 0 Then
                    Dim listValue As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(3).Text)
                    Dim newQty As Integer = listValue + Val(txtStock.Text)
                    txtStock.Text = newQty
                    ListView1.Items.Remove(ListView1.FocusedItem)
                    Call getTotalItems()
                    Call getTotal()
                End If
            End If
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            If MsgBox("Do you want to save transaction?", vbQuestion + vbYesNo) = vbYes Then
                If Val(lblAmountPaid.Text) < Val(lblGrandTotal.Text) Then
                    MsgBox("Insufficient Amount Paid!", MsgBoxStyle.Critical, "Please re-enter the payment")
                Else
                    Call insertSales()
                    Call insertSalesDetails()
                    Call insertPayment()
                    MsgBox("Transaction Record Successfully Saved!", MsgBoxStyle.Information)
                    ListView1.Items.Clear()
                End If
            End If
            Call getTransactionNumber()
            Call clearThings()
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(btnConfirm): " & ex.Message)
        End Try
    End Sub

    Private Sub insertSales()
        Try
            sql = "Insert into tblSales (Username, TransactionNumber, SalesDate, TotalAmount) values (@Username, @TransactionNumber, @SalesDate, @TotalAmount)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", lblUsername.Text)
                .Parameters.AddWithValue("@TransactionNumber", lblTransactNo.Text)
                .Parameters.AddWithValue("@SalesDate", DateTime.Parse(lblDate.Text))
                .Parameters.AddWithValue("@TotalAmount", lblGrandTotal.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(insertSales): " & ex.Message)
        End Try
    End Sub

    Private Sub insertSalesDetails()
        Try
            For Each i As ListViewItem In ListView1.Items
                sql = "Insert into tblSalesDetails (TransactionNumber, ProductName, Price, Quantity, TotalPrice) values (@TransactionNumber, @ProductName, @Price, @Quantity, @TotalPrice)"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@TransactionNumber", lblTransactNo.Text)
                    .Parameters.AddWithValue("@ProductName", i.Text)
                    .Parameters.AddWithValue("@Quantity", i.SubItems(3).Text)
                    .Parameters.AddWithValue("@Price", i.SubItems(2).Text)
                    .Parameters.AddWithValue("@TotalPrice", i.SubItems(4).Text)
                    .ExecuteNonQuery()
                End With
            Next

            sql = "Update tblProducts Set Stock = Stock - @Quantity Where ProductName = @ProductName"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Quantity", i.SubItems(3).Text)
                .Parameters.AddWithValue("@ProductName", i.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(insertSalesDetails): " & ex.Message)
        End Try
    End Sub

    Private Sub insertPayment()
        Try
            sql = "Insert into tblPayments (TransactionNumber, PaymentDate, Amount, PaymentMethod) values (@TransactionNumber, @PaymentDate, @Amount, @PaymentMethod)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@TransactionNumber", lblTransactNo.Text)
                .Parameters.AddWithValue("@PaymentDate", DateTime.Parse(lblDate.Text))
                .Parameters.AddWithValue("@Amount", lblGrandTotal.Text)
                .Parameters.AddWithValue("@PaymentMethod", lblMOP.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(insertPayment): " & ex.Message)
        End Try
    End Sub

    Private Sub clearThings()
        lblTotalProductSold.Text = "0"
        lblAmountPaid.Text = "0.00"
        lblAmountChange.Text = "0.00"
        lblMOP.Text = " "
        lblRefNo.Text = " "
        lblGrandTotal.Text = "0.00"
        txtProductName.Clear()
        txtDescription.Clear()
        txtPrice.Clear()
        txtStock.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearThings()
    End Sub
End Class