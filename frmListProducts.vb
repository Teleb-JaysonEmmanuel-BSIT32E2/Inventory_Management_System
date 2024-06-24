Imports System.Data.OleDb

Public Class frmListProducts
    Private Sub frmListProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadProducts()
    End Sub

    Private Sub loadProducts()
        Try
            sql = "Select * from tblProducts"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Price").ToString())
                x.SubItems.Add(dr("Stock").ToString())
                x.SubItems.Add(dr("ProductID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmListProducts(ListViewLoading): " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearchBar.Text)
        PopulateListView(dt)
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView1.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView1.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select ProductName, Description, Price, Stock, ProductID from tblProducts where ProductName LIKE ? OR Description LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))
        cmd.Parameters.Add(New OleDbParameter("searchTerm2", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            frmPOS.txtProductName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            frmPOS.txtDescription.Text = ListView1.SelectedItems(0).SubItems(1).Text
            frmPOS.txtPrice.Text = ListView1.SelectedItems(0).SubItems(2).Text
            frmPOS.txtStock.Text = ListView1.SelectedItems(0).SubItems(3).Text
            frmPOS.lblProductID.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        frmPOS.btnAddCart.Enabled = True
        Me.Close()
    End Sub
End Class