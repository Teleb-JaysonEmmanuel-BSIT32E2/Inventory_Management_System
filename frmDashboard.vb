Public Class frmDashboard

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmDataAnalytics.TopLevel = False
        pnlDashboard.Controls.Add(frmDataAnalytics)
        frmDataAnalytics.BringToFront()
        frmDataAnalytics.Show()
        Call connection()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.txtUsername.Focus()
        frmLogin.Show()
        Me.Close()
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