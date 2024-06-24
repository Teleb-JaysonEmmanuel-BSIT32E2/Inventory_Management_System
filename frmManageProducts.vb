Imports System.Data.OleDb

Public Class frmManageProducts
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        frmListSuppliers.Show()
    End Sub

    Private Sub frmManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub loadProducts()
        Try
            sql = "Select * from qryProducts"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Price").ToString())
                x.SubItems.Add(dr("Stock").ToString())
                x.SubItems.Add(dr("SupplierName").ToString())
                x.SubItems.Add(dr("ProductID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(ListViewLoading): " & ex.Message)
        End Try
    End Sub

    Private Sub startThings()
        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub disableThings()
        txtSupplierName.Enabled = False
        txtProductName.Enabled = False
        txtPrice.Enabled = False
        txtDescription.Enabled = False
        txtStock.Enabled = False
        btnSearch.Enabled = False
    End Sub

    Private Sub enableThings()
        txtProductName.Enabled = True
        txtPrice.Enabled = True
        txtDescription.Enabled = True
        txtStock.Enabled = True
    End Sub

    Private Sub clearThings()
        txtSupplierName.Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtDescription.Clear()
        txtStock.Clear()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnSearch.Enabled = True
        btnEdit.Enabled = False

        Call clearThings()
        Call enableThings()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True
        btnSearch.Enabled = True
        btnNew.Enabled = False

        Call enableThings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearThings()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub insertProducts()
        Try
            If txtProductName.Text = "" Or txtDescription.Text = "" Or txtSupplierName.Text = "" Or txtStock.Text = "" Or txtPrice.Text = "" Then
                MsgBox("Please Fill out the Fields", MsgBoxStyle.Exclamation)
            Else
                sql = "Select ProductName from tblProducts where ProductName = @ProductName"
                cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    MsgBox("ProductName: '" & txtProductName.Text & "' Already Exist", MsgBoxStyle.Exclamation)
                Else
                    sql = "Insert into tblProducts (ProductName, Description, Price, Stock, SupplierID) values (@ProductName, @Description, @Price, @Stock, @SupplierID)"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                        .Parameters.AddWithValue("@Description", txtDescription.Text)
                        .Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
                        .Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text))
                        .Parameters.AddWithValue("@SupplierID", Convert.ToInt32(lblSupplierID.Text))
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Successfully created!", MsgBoxStyle.Information)
                    Call ActivityLogs("Insert Product Info", txtProductName.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(insertProducts): " & ex.Message)
        End Try
    End Sub

    Private Sub updateProducts()
        Try
            sql = "Update tblProducts SET ProductName = @ProductName, Description = @Description, Price = @Price, Stock = @Stock, SupplierID = @SupplierID where ProductID = @ProductID"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@ProductName", txtProductName.Text)
                .Parameters.AddWithValue("@Description", txtDescription.Text)
                .Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
                .Parameters.AddWithValue("@Stock", txtStock.Text)
                .Parameters.AddWithValue("@SupplierID", Convert.ToInt32(lblSupplierID.Text))
                .Parameters.AddWithValue("@ProductID", Convert.ToInt32(lblProductID.Text))
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully updated!", MsgBoxStyle.Information)
            Call ActivityLogs("Update Product Info", txtProductName.Text)
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(updateProducts): " & ex.Message)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            sql = "Select ProductName from tblProducts where ProductName = @ProductName"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            dr = cmd.ExecuteReader
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                If btnNew.Enabled = True And btnEdit.Enabled = False Then
                    Call insertProducts()
                ElseIf btnNew.Enabled = False And btnEdit.Enabled = True Then
                    Call updateProducts()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(btnSave): " & ex.Message)
        End Try
        Call loadProducts()
        Call frmManageUsers.Activity()
        Call clearThings()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            txtProductName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            txtDescription.Text = ListView1.SelectedItems(0).SubItems(1).Text
            txtPrice.Text = ListView1.SelectedItems(0).SubItems(2).Text
            txtStock.Text = ListView1.SelectedItems(0).SubItems(3).Text
            txtSupplierName.Text = ListView1.SelectedItems(0).SubItems(4).Text
            lblProductID.Text = ListView1.SelectedItems(0).SubItems(5).Text
        End If

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnNew.Enabled = False
    End Sub

    'Private Sub lblProductID_TextChanged(sender As Object, e As EventArgs) Handles lblProductID.TextChanged
    '    Try
    '        Dim productID As Integer
    '        If Integer.TryParse(lblProductID.Text, productID) Then
    '            sql = "Select ProductName, Description, Price, Stock, SupplierName from qryProducts where ProductID = @ProductID"
    '            cmd = New OleDbCommand(sql, cn)
    '            cmd.Parameters.AddWithValue("@ProductID", productID)
    '            dr = cmd.ExecuteReader
    '            If dr.Read = True Then
    '                txtProductName.Text = dr(0).ToString()
    '                txtDescription.Text = dr(1).ToString()
    '                txtPrice.Text = dr(2).ToString()
    '                txtStock.Text = dr(3).ToString()
    '                txtSupplierName.Text = dr(4).ToString()
    '            End If
    '        Else
    '            MsgBox("Product ID is not a valid integer.")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("An error occurred frmManageProducts(lblProductID_TextChanged): " & ex.Message)
    '    End Try
    'End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearchProduct.Text)
        PopulateListView(dt)
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select ProductName, Description, Price, Stock, SupplierName, ProductID from qryProducts where ProductName LIKE ? OR Description LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New OleDbParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                sql = "DELETE FROM tblProducts WHERE ProductID = @item"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", lblProductID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Record Deleted!")
                Call ActivityLogs("Delete Supplier Info", txtProductName.Text)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageProducts(btnDelete_TextChanged): " & ex.Message)
        End Try
        Call clearThings()
        Call loadProducts()
        Call frmManageUsers.Activity()
        Call startThings()
        Call disableThings()
    End Sub

    Private Sub ActivityLogs(activity As String, details As String)
        Try
            sql = "INSERT INTO tblActivity (Username, Activity, Details, ActivityTime, ActivityDate) VALUES (@Username, @Activity, @Details, @ActivityTime, @ActivityDate)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", frmDashboard.lblUsername.Text)
                .Parameters.AddWithValue("@Activity", activity)
                .Parameters.AddWithValue("@Details", details)
                .Parameters.AddWithValue("@ActivityTime", DateTime.Now.ToString("hh:mm tt"))
                .Parameters.AddWithValue("@ActivityDate", DateTime.Now.ToString("yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(ActivityLogs): " & ex.Message)
        End Try
    End Sub

    Private Sub txtSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSupplierName.TextChanged
        Try
            sql = "Select SupplierID from tblSuppliers where SupplierName = @SupplierName"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSupplierID.Text = dr(0).ToString()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(txtSupplierName_TextChanged): " & ex.Message)
        End Try
    End Sub
End Class