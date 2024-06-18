Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmManageSupplier
    Private Sub frmManageSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadSuppliers()
        Call disableThings()
        Call startThings()
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


    Private Sub startThings()
        btnNew.Enabled = True
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub disableThings()
        txtSupplierName.Enabled = False
        txtAddress.Enabled = False
        txtEmail.Enabled = False
        txtContactPerson.Enabled = False
    End Sub

    Private Sub enableThings()
        txtSupplierName.Enabled = True
        txtAddress.Enabled = True
        txtEmail.Enabled = True
        txtContactPerson.Enabled = True
    End Sub

    Private Sub clearThings()
        txtSupplierName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()
        txtContactPerson.Clear()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnEdit.Enabled = False

        Call clearThings()
        Call enableThings()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnDelete.Enabled = True
        btnNew.Enabled = False

        Call enableThings()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearThings()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub insertSupplier()
        Try
            sql = "INSERT INTO tblSuppliers (SupplierName, ContactPerson, Email, Address) VALUES (@SupplierName, @ContactPerson, @Email, @Address)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@SupplierName", txtSupplierName.Text)
                .Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text)
                .Parameters.AddWithValue("@Email", txtEmail.Text)
                .Parameters.AddWithValue("@Address", txtAddress.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully created!", MsgBoxStyle.Information)
            Call ActivityLogs("Insert Supplier Info", txtSupplierName.Text)
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(insertSupplier): " & ex.Message)
        End Try
    End Sub

    Private Sub updateSupplier()
        Try
            sql = "UPDATE tblSuppliers SET SupplierName = @SupplierName, ContactPerson = @ContactPerson, Email = @Email, Address = @Address WHERE SupplierID = @SupplierID"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@SupplierName", txtSupplierName.Text)
                .Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text)
                .Parameters.AddWithValue("@Email", txtEmail.Text)
                .Parameters.AddWithValue("@Address", txtAddress.Text)
                .Parameters.AddWithValue("@SupplierID", Convert.ToInt32(lblSupplierID.Text))
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully updated!", MsgBoxStyle.Information)
            Call ActivityLogs("Update Supplier Info", txtSupplierName.Text)
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(updateSupplier): " & ex.Message)
        End Try
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                If btnNew.Enabled = True And btnEdit.Enabled = False Then
                    Call insertSupplier()
                ElseIf btnNew.Enabled = False And btnEdit.Enabled = True Then
                    Call updateSupplier()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(btnSave): " & ex.Message)
        End Try
        Call loadSuppliers()
        Call frmManageUsers.Activity()
        Call clearThings()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            lblSupplierID.Text = ListView1.SelectedItems(0).SubItems(4).Text
        End If

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnNew.Enabled = False
    End Sub

    Private Sub lblSupplierID_TextChanged(sender As Object, e As EventArgs) Handles lblSupplierID.TextChanged
        Try
            sql = "Select SupplierName, ContactPerson, Email, Address, SupplierID from tblSuppliers where SupplierID = @SupplierID"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@SupplierID", lblSupplierID.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtSupplierName.Text = dr(0).ToString()
                txtContactPerson.Text = dr(1).ToString()
                txtEmail.Text = dr(2).ToString()
                txtAddress.Text = dr(3).ToString()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(lblSupplierID_TextChanged): " & ex.Message)
        End Try
    End Sub

    Private Sub txtSearchSupplierName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupplierName.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearchSupplierName.Text)
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                sql = "DELETE FROM tblSuppliers WHERE SupplierID = @item"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", lblSupplierID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Record Deleted!")
                Call ActivityLogs("Delete Supplier Info", txtSupplierName.Text)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageSupplier(btnDelete_TextChanged): " & ex.Message)
        End Try
        Call clearThings()
        Call loadSuppliers()
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

End Class