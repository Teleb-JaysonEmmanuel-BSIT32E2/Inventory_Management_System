Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmNotification
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        frmMessage.Show()
    End Sub

    Private Sub frmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadMessage()
    End Sub

    Public Sub getLoadMessage()
        Call loadMessage()
    End Sub

    Private Sub loadMessage()
        Try
            sql = "Select * from tblMessage"
            cmd = New OleDbCommand(sql, cn)
            dr = cmd.ExecuteReader()
            Dim x As ListViewItem
            ListView2.Items.Clear()

            Do While dr.Read()
                x = New ListViewItem(dr("ReplenishMessage").ToString())
                x.SubItems.Add(dr("MessageSent").ToString())
                x.SubItems.Add(dr("Status").ToString())
                x.SubItems.Add(dr("MessageID").ToString())
                ListView2.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox("An error occurred frmNotification(ListViewLoading): " & ex.Message)
        End Try
    End Sub
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            frmMessage.txtMessage.Text = ListView2.SelectedItems(0).SubItems(0).Text
            frmMessage.txtMessageSent.Text = ListView2.SelectedItems(0).SubItems(1).Text
            frmMessage.lblMessageID.Text = ListView2.SelectedItems(0).SubItems(3).Text
        End If
    End Sub
End Class