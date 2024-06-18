<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.pnlLoginPage = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlLoginForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLoginAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRole = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.chckConfirmPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtConfirmPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.chckPassword = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlLoginPage.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginForm.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLoginPage
        '
        Me.pnlLoginPage.BackColor = System.Drawing.Color.White
        Me.pnlLoginPage.Controls.Add(Me.PictureBox5)
        Me.pnlLoginPage.Controls.Add(Me.Guna2PictureBox5)
        Me.pnlLoginPage.Controls.Add(Me.pnlLoginForm)
        Me.pnlLoginPage.Controls.Add(Me.Panel1)
        Me.pnlLoginPage.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLoginPage.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoginPage.Name = "pnlLoginPage"
        Me.pnlLoginPage.Size = New System.Drawing.Size(600, 768)
        Me.pnlLoginPage.TabIndex = 19
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(534, 359)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(339, -11)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Guna2PictureBox5.TabIndex = 18
        Me.Guna2PictureBox5.TabStop = False
        '
        'pnlLoginForm
        '
        Me.pnlLoginForm.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoginForm.BorderColor = System.Drawing.Color.White
        Me.pnlLoginForm.BorderRadius = 15
        Me.pnlLoginForm.BorderThickness = 1
        Me.pnlLoginForm.Controls.Add(Me.btnLoginAccount)
        Me.pnlLoginForm.Controls.Add(Me.Label6)
        Me.pnlLoginForm.Controls.Add(Me.Label5)
        Me.pnlLoginForm.Controls.Add(Me.Label4)
        Me.pnlLoginForm.Controls.Add(Me.btnRegister)
        Me.pnlLoginForm.Controls.Add(Me.Label1)
        Me.pnlLoginForm.Controls.Add(Me.cboRole)
        Me.pnlLoginForm.Controls.Add(Me.chckConfirmPassword)
        Me.pnlLoginForm.Controls.Add(Me.txtConfirmPassword)
        Me.pnlLoginForm.Controls.Add(Me.chckPassword)
        Me.pnlLoginForm.Controls.Add(Me.txtPassword)
        Me.pnlLoginForm.Controls.Add(Me.txtUsername)
        Me.pnlLoginForm.FillColor = System.Drawing.Color.White
        Me.pnlLoginForm.Location = New System.Drawing.Point(72, 96)
        Me.pnlLoginForm.Name = "pnlLoginForm"
        Me.pnlLoginForm.ShadowDecoration.BorderRadius = 15
        Me.pnlLoginForm.ShadowDecoration.Depth = 10
        Me.pnlLoginForm.ShadowDecoration.Enabled = True
        Me.pnlLoginForm.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(6)
        Me.pnlLoginForm.Size = New System.Drawing.Size(456, 577)
        Me.pnlLoginForm.TabIndex = 8
        '
        'btnLoginAccount
        '
        Me.btnLoginAccount.BorderRadius = 8
        Me.btnLoginAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoginAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLoginAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLoginAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoginAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoginAccount.FillColor = System.Drawing.Color.SeaGreen
        Me.btnLoginAccount.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginAccount.ForeColor = System.Drawing.Color.White
        Me.btnLoginAccount.Location = New System.Drawing.Point(34, 466)
        Me.btnLoginAccount.Name = "btnLoginAccount"
        Me.btnLoginAccount.Size = New System.Drawing.Size(385, 62)
        Me.btnLoginAccount.TabIndex = 5
        Me.btnLoginAccount.Text = "Already have account?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(250, 420)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "___________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(210, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "OR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(32, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "___________________________"
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 8
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRegister.FillColor = System.Drawing.Color.SandyBrown
        Me.btnRegister.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(34, 339)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(385, 62)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 26)
        Me.Label1.TabIndex = 1000
        Me.Label1.Text = "Role:"
        '
        'cboRole
        '
        Me.cboRole.BackColor = System.Drawing.Color.Transparent
        Me.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRole.FocusedColor = System.Drawing.Color.Black
        Me.cboRole.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.cboRole.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.cboRole.ForeColor = System.Drawing.Color.Black
        Me.cboRole.HoverState.BorderColor = System.Drawing.Color.Black
        Me.cboRole.ItemHeight = 30
        Me.cboRole.Items.AddRange(New Object() {"Cashier", "Admin"})
        Me.cboRole.Location = New System.Drawing.Point(105, 263)
        Me.cboRole.Name = "cboRole"
        Me.cboRole.Size = New System.Drawing.Size(314, 36)
        Me.cboRole.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.cboRole.TabIndex = 3
        '
        'chckConfirmPassword
        '
        Me.chckConfirmPassword.AutoSize = True
        Me.chckConfirmPassword.CheckedState.BorderColor = System.Drawing.Color.RosyBrown
        Me.chckConfirmPassword.CheckedState.BorderRadius = 0
        Me.chckConfirmPassword.CheckedState.BorderThickness = 0
        Me.chckConfirmPassword.CheckedState.FillColor = System.Drawing.Color.RosyBrown
        Me.chckConfirmPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.chckConfirmPassword.Location = New System.Drawing.Point(404, 204)
        Me.chckConfirmPassword.Name = "chckConfirmPassword"
        Me.chckConfirmPassword.Size = New System.Drawing.Size(15, 14)
        Me.chckConfirmPassword.TabIndex = 4
        Me.chckConfirmPassword.TabStop = False
        Me.chckConfirmPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckConfirmPassword.UncheckedState.BorderRadius = 0
        Me.chckConfirmPassword.UncheckedState.BorderThickness = 0
        Me.chckConfirmPassword.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPassword.DefaultText = ""
        Me.txtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.txtConfirmPassword.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtConfirmPassword.Location = New System.Drawing.Point(34, 179)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmPassword.PlaceholderText = "Confirm password"
        Me.txtConfirmPassword.SelectedText = ""
        Me.txtConfirmPassword.Size = New System.Drawing.Size(385, 62)
        Me.txtConfirmPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtConfirmPassword.TabIndex = 2
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'chckPassword
        '
        Me.chckPassword.AutoSize = True
        Me.chckPassword.CheckedState.BorderColor = System.Drawing.Color.RosyBrown
        Me.chckPassword.CheckedState.BorderRadius = 0
        Me.chckPassword.CheckedState.BorderThickness = 0
        Me.chckPassword.CheckedState.FillColor = System.Drawing.Color.RosyBrown
        Me.chckPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!)
        Me.chckPassword.Location = New System.Drawing.Point(404, 130)
        Me.chckPassword.Name = "chckPassword"
        Me.chckPassword.Size = New System.Drawing.Size(15, 14)
        Me.chckPassword.TabIndex = 2
        Me.chckPassword.TabStop = False
        Me.chckPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckPassword.UncheckedState.BorderRadius = 0
        Me.chckPassword.UncheckedState.BorderThickness = 0
        Me.chckPassword.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'txtPassword
        '
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(34, 105)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.PlaceholderText = "Enter password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(385, 62)
        Me.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(34, 31)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "Enter your username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(385, 62)
        Me.txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtUsername.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 36)
        Me.Panel1.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(549, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(51, 36)
        Me.btnClose.TabIndex = 20
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 768)
        Me.Controls.Add(Me.pnlLoginPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlLoginPage.ResumeLayout(False)
        Me.pnlLoginPage.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginForm.ResumeLayout(False)
        Me.pnlLoginForm.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLoginPage As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlLoginForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents chckPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chckConfirmPassword As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents txtConfirmPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboRole As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnLoginAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Button
End Class
