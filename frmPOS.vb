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
        Call ActivityLogs()
        frmLogin.txtUsername.Focus()
        frmLogin.Show()
    End Sub
    Private Sub ActivityLogs()
        Try
            sql = "Insert into tblActivity (Username, Activity, Details, ActivityTime, ActivityDate) values (@Username, @Activity, @Details, @ActivityTime, @ActivityDate)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", lblUsername.Text)
                .Parameters.AddWithValue("@Activity", "Logout")
                .Parameters.AddWithValue("@Details", "Logout")
                .Parameters.AddWithValue("@ActivityTime", DateTime.Now.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@ActivityDate", DateTime.Now.ToString("yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(ActivityLogs): " & ex.Message)
        End Try
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
    Dim replenishReason As String = ""

    Private Sub btnAddCart_Click(sender As Object, e As EventArgs) Handles btnAddCart.Click
        Try
            Dim j As String = InputBox("Enter Quantity", "Quantity")

            ' Handle the scenario when the user cancels or closes the input dialog
            If j = "" Then
                Return
            End If

            ' Check if input is valid
            If String.IsNullOrEmpty(j) OrElse Val(j) <= 0 Then
                MsgBox("Please enter a valid number of quantity")
                Return
            End If

            ' Check stock availability
            If Val(j) > Val(txtStock.Text) Then
                MsgBox("Inputted Quantity is greater than Stock", MsgBoxStyle.Information)
                replenishReason = "A customer requested more of this product than is currently available in stock."
                Call replenishMessage()
                MsgBox("Please Input Quantity within stock", MsgBoxStyle.Information)
            Else
                ' Call replenishMessage if stock is less than 10
                If Val(txtStock.Text) < 10 Then
                    replenishReason = "The stock for this product is running low."
                    Call replenishMessage()
                End If

                ' Proceed to add to the cart if stock is sufficient
                If Val(txtStock.Text) > 0 Then
                    txtStock.Text = Val(txtStock.Text) - Val(j)
                    amount = Val(txtPrice.Text) * Val(j)
                    i = Me.ListView1.Items.Add(txtProductName.Text) ' Product Name
                    i.SubItems.Add(txtDescription.Text) ' Description
                    i.SubItems.Add(txtPrice.Text) ' Amount
                    i.SubItems.Add(j) ' Quantity
                    i.SubItems.Add(amount) ' Total Amount
                Else
                    MsgBox("No stock available to add to the cart", MsgBoxStyle.Information)
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
                .Parameters.AddWithValue("@ReplenishMessage", "Attention: Need to restock on product: '" & txtProductName.Text & "'. " & replenishReason & " Current stock for product: '" & txtStock.Text & "'. Please take necessary action.")
                .Parameters.AddWithValue("@MessageSent", DateTime.Now.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@Status", "Unread")
                .ExecuteNonQuery()
            End With
            MsgBox("Sending a Replenishment Message, Product might be out of stock or stock is less than 10", MsgBoxStyle.Information)
            Call frmDashboard.getMessCount()
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
                    frmPrintReceipt.lblNo.Text = lblTransactNo.Text
                    frmPrintReceipt.lblDate.Text = lblDate.Text
                    frmPrintReceipt.lblTime.Text = lblTime.Text
                    frmPrintReceipt.lblCashierName.Text = lblUsername.Text
                    frmPrintReceipt.lblTotal.Text = lblGrandTotal.Text
                    frmPrintReceipt.Show()
                End If
                End If
            Call getTransactionNumber()
            Call clearThings()
            btnAddCart.Enabled = False
            btnConfirm.Enabled = False
        Catch ex As Exception
            MsgBox("An error occurred frmPOS(btnConfirm): " & ex.Message)
        End Try
    End Sub

    Private Sub insertSales()
        Try
            sql = "Insert into tblSales (Username, TransactionNumber, SalesDate, SalesTime, TotalAmount) values (@Username, @TransactionNumber, @SalesDate, @SalesTime, @TotalAmount)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", lblUsername.Text)
                .Parameters.AddWithValue("@TransactionNumber", lblTransactNo.Text)
                .Parameters.AddWithValue("@SalesDate", DateTime.Now.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@SalesTime", DateTime.Now.ToString("hh:mm tt"))
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
                ' Insert into tblSalesDetails for each item
                sql = "Insert into tblSalesDetails (TransactionNumber, ProductName, Price, Quantity, TotalPrice, ProductID) values (@TransactionNumber, @ProductName, @Price, @Quantity, @TotalPrice, @ProductID)"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@TransactionNumber", lblTransactNo.Text)
                    .Parameters.AddWithValue("@ProductName", i.Text)
                    .Parameters.AddWithValue("@Price", i.SubItems(2).Text)
                    .Parameters.AddWithValue("@Quantity", i.SubItems(3).Text)
                    .Parameters.AddWithValue("@TotalPrice", i.SubItems(4).Text)
                    .Parameters.AddWithValue("@ProductID", lblProductID.Text) ' Ensure lblProductID is set correctly for each item
                    .ExecuteNonQuery()
                End With

                ' Update stock for each product
                sql = "Update tblProducts Set Stock = Stock - @Quantity Where ProductName = @ProductName"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@Quantity", i.SubItems(3).Text)
                    .Parameters.AddWithValue("@ProductName", i.Text)
                    .ExecuteNonQuery()
                End With
            Next
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
                .Parameters.AddWithValue("@PaymentDate", DateTime.Now.ToString("yyyy-MM-dd"))
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
        ListView1.Items.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearThings()
    End Sub
End Class