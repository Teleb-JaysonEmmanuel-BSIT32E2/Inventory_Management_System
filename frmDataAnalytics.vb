Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmDataAnalytics
    Private Sub frmDataAnalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getTotalSold()
        Call getTotalGross()
        Call loadTopProducts()
    End Sub

    Private Sub loadTopProducts()
        Try
            sql = "Select * from qrySalesDetails"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("TotalQuantity").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmDataAnalytics(ListViewLoading): " & ex.Message)
        End Try
    End Sub

    Private Sub getTotalSold()
        Try
            sql = "Select SUM(Quantity) from tblSalesDetails"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblSoldProducts.Text = Val(dr(0))
            Else
                lblSoldProducts.Text = 0
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmDataAnalytics(getTotalSold): " & ex.Message)
        End Try
    End Sub

    Private Sub getTotalGross()
        Try
            sql = "Select SUM(TotalPrice) from tblSalesDetails"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblTotalRevenue.Text = Val(dr(0))
            Else
                lblTotalRevenue.Text = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class