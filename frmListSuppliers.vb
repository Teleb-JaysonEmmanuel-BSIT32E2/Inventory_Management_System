Imports System.Data.OleDb

Public Class frmListSuppliers

    Private Sub frmListSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
    End Sub

    Private Sub loadSuppliers()
        Try
            sql = "Select * from tblSuppliers"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("SupplierName").ToString())
                x.SubItems.Add(dr("ContactPerson").ToString())
                x.SubItems.Add(dr("Email").ToString())
                x.SubItems.Add(dr("Address").ToString())
                x.SubItems.Add(dr("SupplierID").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(ListViewLoading): " & ex.Message)
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
        sql = "Select SupplierName,ContactPerson,Email,Address, SupplierID from tblSuppliers where SupplierName LIKE ? OR ContactPerson LIKE ?"
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
            frmManageProducts.txtSupplierName.Text = ListView1.SelectedItems(0).SubItems(0).Text
            frmManageProducts.lblSupplierID.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.Close()
    End Sub
End Class