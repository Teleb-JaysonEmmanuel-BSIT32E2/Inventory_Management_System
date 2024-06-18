﻿Imports System.Data.OleDb

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        frmRegister.TopLevel = False
        pnlLoginPage.Controls.Add(frmRegister)
        frmRegister.BringToFront()
        frmRegister.Show()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Me.IsHandleCreated Then
            Try
                sql = "Select Role from tblUser where Username = @Username"
                cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    lblRole.Text = dr(0).ToString
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmLogin(txtUsernameTextChanged): " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Make sure you filled out completely the fields", MsgBoxStyle.Information, "Missing Input")
                txtUsername.Focus()
            Else
                sql = "Select Username, Password from tblUser where Username = @Username and Password = @Password"
                cmd = New OleDbCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    MsgBox("Logging In!", MsgBoxStyle.Information)
                    If lblRole.Text = "Cashier" Then
                        frmPOSCashier.Show()
                        Me.Hide()
                    Else
                        frmDashboard.Show()
                        Me.Hide()
                    End If
                End If
                'sql = "Select Username, Password from tblUser where Username = @Username and Password = @Password"
                'cmd = New OleDbCommand(sql, cn)
                'cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                'cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                'dr = cmd.ExecuteReader
                'If dr.Read = True Then
                '    MsgBox("Logging In!", MsgBoxStyle.Information)
                '    If lblRole.Text = "Cashier" Then
                '        frmPOSCashier.Show()
                '        Me.Hide()
                '    Else
                '        frmDashboard.Show()
                '        Me.Hide()
                '    End If
                'Else
                '    MsgBox("Account Credentials Invalid", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmLogin(btnLogin): " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class