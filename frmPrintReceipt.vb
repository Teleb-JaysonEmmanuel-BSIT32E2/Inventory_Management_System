Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class frmPrintReceipt
    Private Sub frmPrintReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVAT.Text = Val(lblTotal.Text) * 0.12
        Call loadReceipt()
    End Sub

    Private Sub loadReceipt()
        Try
            sql = "Select * from qryReceipt where TransactionNumber = @TransactionNumber"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@TransactionNumber", lblNo.Text)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("ProductName").ToString())
                x.SubItems.Add(dr("Description").ToString())
                x.SubItems.Add(dr("Price").ToString())
                x.SubItems.Add(dr("Quantity").ToString())
                x.SubItems.Add(dr("TotalPrice").ToString())
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmPrintReceipt(ListViewLoading): " & ex.Message)
        End Try
    End Sub

    Private Sub PrintForm()
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 625, 640)
        PrintPreviewDialog1.Size = New Size(800, 800)

        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Create a bitmap of the form size
        Dim formBitmap As New Bitmap(Me.Width, Me.Height)

        ' Create a graphics object from the bitmap
        Using g As Graphics = Graphics.FromImage(formBitmap)
            ' Draw the form on the bitmap
            Me.DrawToBitmap(formBitmap, New Rectangle(0, 0, Me.Width, Me.Height))
        End Using

        ' Draw the form's image on the PrintPage
        e.Graphics.DrawImage(formBitmap, 0, 0)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Visible = False
        Me.FormBorderStyle = FormBorderStyle.None
        Call PrintForm()
        Me.Close()
    End Sub
End Class