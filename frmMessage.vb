Imports System.Data.OleDb

Public Class frmMessage
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            sql = "Update tblMessage SET Status = @Status where MessageID = @MessageID"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Status", "Read")
                .Parameters.AddWithValue("@MessageID", lblMessageID.Text)
                .ExecuteNonQuery()
            End With
            Call frmNotification.getLoadMessage()
            Call frmDashboard.getMessCount()
            Me.Close()
        Catch ex As Exception
            MsgBox("An error occurred frmMessage(btnConfirm): " & ex.Message)
        End Try
    End Sub
End Class