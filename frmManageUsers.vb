Imports System.Data.OleDb

Public Class frmManageUsers
    Private Sub frmManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadUsers()
        Call loadActivity()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub loadUsers()
        Try
            sql = "Select * from tblUser"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("Username").ToString())
                x.SubItems.Add(dr("Password").ToString())
                x.SubItems.Add(dr("Role").ToString())
                x.SubItems.Add(dr("UserID").ToString())
                ListView2.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(ListViewLoadingUsers): " & ex.Message)
        End Try
    End Sub

    Public Sub Activity()
        Call loadActivity()
    End Sub

    Private Sub loadActivity()
        Try
            sql = "Select * from tblActivity"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView3.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("Username").ToString())
                x.SubItems.Add(dr("Activity").ToString())
                x.SubItems.Add(dr("Details").ToString())
                x.SubItems.Add(dr("ActivityTime").ToString())
                x.SubItems.Add(dr("ActivityDate").ToString())
                x.SubItems.Add(dr("ActivityID").ToString())
                ListView3.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(ListViewLoadingActivity): " & ex.Message)
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
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        cboRole.Enabled = False
    End Sub

    Private Sub enableThings()
        txtUsername.Enabled = True
        txtPassword.Enabled = True
        cboRole.Enabled = True
    End Sub

    Private Sub clearThings()
        txtUsername.Clear()
        txtPassword.Clear()
        cboRole.SelectedIndex = -1
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

    Private Sub insertUser()
        Try
            sql = "INSERT INTO tblUser ([Username], [Password], [Role]) VALUES (@Username, @Password, @Role)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", txtUsername.Text)
                .Parameters.AddWithValue("@Password", txtPassword.Text)
                .Parameters.AddWithValue("@Role", cboRole.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully created!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("An error occurred in frmManageUsers(insertUser): " & ex.Message)
        End Try
    End Sub

    Private Sub updateUser()
        Try
            sql = "UPDATE tblUser SET [Username] = @Username, [Password] = @Password, [Role] = @Role WHERE UserID = @UserID"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", txtUsername.Text)
                .Parameters.AddWithValue("@Password", txtPassword.Text)
                .Parameters.AddWithValue("@Role", cboRole.Text)
                .Parameters.AddWithValue("@UserID", Convert.ToInt32(lblUserID.Text))
                .ExecuteNonQuery()
            End With
            MsgBox("Successfully updated!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("An error occurred in frmManageUsers(updateUser): " & ex.Message)
        End Try
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If MsgBox("Do you want to save?", vbYesNo) = vbYes Then
                If btnNew.Enabled = True And btnEdit.Enabled = False Then
                    Call insertUser()
                ElseIf btnNew.Enabled = False And btnEdit.Enabled = True Then
                    Call updateUser()
                End If
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUsers(btnSave): " & ex.Message)
        End Try
        Call loadUsers()
        Call clearThings()
        Call disableThings()
        Call startThings()
    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            lblUserID.Text = ListView2.SelectedItems(0).SubItems(3).Text
        End If

        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnNew.Enabled = False
    End Sub

    Private Sub lblUserID_TextChanged(sender As Object, e As EventArgs) Handles lblUserID.TextChanged
        Try
            sql = "Select Username, Password, Role, UserID from tblUser where UserID = @UserID"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@UserID", lblUserID.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                txtUsername.Text = dr(0).ToString()
                txtPassword.Text = dr(1).ToString()
                cboRole.Text = dr(2).ToString()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUser(lblUserID_TextChanged): " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("Do you want to delete?", vbYesNo) = vbYes Then
                sql = "DELETE from tblUser where UserID = @item"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@item", lblUserID.Text)
                    .ExecuteNonQuery()
                End With
                MsgBox("Record Deleted!")
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmManageUser(btnDelete_TextChanged): " & ex.Message)
        End Try
        Call clearThings()
        Call loadUsers()
        Call startThings()
        Call disableThings()
    End Sub

    Private Sub txtSearchUsername_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsername.TextChanged
        Dim dt As DataTable = SearchDatabase(txtSearchUsername.Text)
        PopulateListView(dt)
    End Sub

    Private Sub PopulateListView(dt As DataTable)
        ListView3.Items.Clear()
        For Each row As DataRow In dt.Rows
            ListView3.Items.Add(New ListViewItem(row.ItemArray.Select(Function(x) x.ToString()).ToArray()))
        Next
    End Sub

    Public Function SearchDatabase(searchTerm As String) As DataTable
        sql = "Select Username, Activity, Details, ActivityTime, ActivityDate, ActivityID from tblActivity where Username LIKE ?"
        cmd = New OleDbCommand(sql, cn)
        cmd.Parameters.Add(New OleDbParameter("searchTerm1", "%" & searchTerm & "%"))

        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)

        Return dt
    End Function
End Class