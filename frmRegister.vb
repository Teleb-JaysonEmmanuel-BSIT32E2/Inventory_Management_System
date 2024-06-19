Imports System.Data.OleDb

Public Class frmRegister
    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        Call connection()
    End Sub

    Private Sub chckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckPassword.CheckedChanged
        If chckPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub chckConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chckConfirmPassword.CheckedChanged
        If chckConfirmPassword.Checked = True Then
            txtConfirmPassword.UseSystemPasswordChar = False
            txtConfirmPassword.PasswordChar = ""
        Else
            txtConfirmPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtConfirmPassword.Text = "" Or cboRole.Text = "" Then
            MsgBox("Make sure you filled out completely the fields", MsgBoxStyle.Information, "Missing Input")
        ElseIf txtPassword.TextLength < 8 Then
            MsgBox("Your password is too weak! Make sure it contains more than 8 characters", MsgBoxStyle.Exclamation, "Password short")
            txtPassword.Focus()
        ElseIf txtPassword.Text <> txtConfirmPassword.Text Then
            MsgBox("Your password and confirm password are not match", MsgBoxStyle.Exclamation, "Invalid Input")
            txtPassword.Focus()
        Else
            Call checkUsername()
        End If
    End Sub

    Private Sub checkUsername()
        Try
            sql = "Select Username from tblUser where Username = @Username"
            cmd = New OleDbCommand(sql, cn)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Username: " & txtUsername.Text & " already exist. Please provide unique username", MsgBoxStyle.Exclamation, "Username")
                txtUsername.Focus()
            Else
                Call SaveAccount()
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmRegister(checkUsername): " & ex.Message)
        End Try
    End Sub

    Private Sub SaveAccount()
        Try
            sql = "Insert into tblUser (Username, [Password], [Role]) values (@Username, @Password, @Role)"
            cmd = New OleDbCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@Username", txtUsername.Text)
                .Parameters.AddWithValue("@Password", txtPassword.Text)
                .Parameters.AddWithValue("@Role", cboRole.Text)
                .ExecuteNonQuery()
            End With
            MsgBox("Account Recorded!", MsgBoxStyle.Information)
            frmLogin.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("An error occurred in frmRegister(checkPassword): " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLoginAccount_Click(sender As Object, e As EventArgs) Handles btnLoginAccount.Click
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.Show()
        Me.Close()
    End Sub
End Class
