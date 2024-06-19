Imports System.Data.OleDb

Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDataAnalytics.TopLevel = False
        pnlDashboard.Controls.Add(frmDataAnalytics)
        frmDataAnalytics.BringToFront()
        frmDataAnalytics.Show()
        Call connection()
        Call getMessageCount()
        frmPOS.bntLogout.Enabled = False
        frmPOS.lblUsername.Text = Me.lblUsername.Text
    End Sub

    Public Sub getMessCount()
        Call getMessageCount()
    End Sub

    Private Sub getMessageCount()
        Try
            sql = "Select COUNT(ReplenishMessage) from tblMessage where Status = 'Unread'"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblNotif.Text = Val(dr(0))
            Else
                lblNotif.Text = 0
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmDashboard(NotifNumber): " & ex.Message)
        End Try
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Focus()
        Call ActivityLogs()
        frmLogin.Show()
        Me.Close()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        frmDataAnalytics.TopLevel = False
        pnlDashboard.Controls.Add(frmDataAnalytics)
        frmDataAnalytics.BringToFront()
        frmDataAnalytics.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        frmManageSupplier.TopLevel = False
        pnlDashboard.Controls.Add(frmManageSupplier)
        frmManageSupplier.BringToFront()
        frmManageSupplier.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        frmManageUsers.TopLevel = False
        pnlDashboard.Controls.Add(frmManageUsers)
        frmManageUsers.BringToFront()
        frmManageUsers.Show()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmManageProducts.TopLevel = False
        pnlDashboard.Controls.Add(frmManageProducts)
        frmManageProducts.BringToFront()
        frmManageProducts.Show()
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        frmPOS.Show()
        'frmPOSAdmin.TopLevel = False
        'pnlDashboard.Controls.Add(frmPOSAdmin)
        'frmPOSAdmin.BringToFront()
        'frmPOSAdmin.Show()
    End Sub

    Private Sub btnNotif_Click(sender As Object, e As EventArgs) Handles btnNotif.Click
        frmNotification.Show()
    End Sub
End Class