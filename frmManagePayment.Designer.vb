<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManagePayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboPayment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txtRefNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.txtAmountPaid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel30 = New System.Windows.Forms.Panel()
        Me.Panel31 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel32 = New System.Windows.Forms.Panel()
        Me.Panel33 = New System.Windows.Forms.Panel()
        Me.Panel34 = New System.Windows.Forms.Panel()
        Me.Panel35 = New System.Windows.Forms.Panel()
        Me.Panel36 = New System.Windows.Forms.Panel()
        Me.lblAmountChange = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel37 = New System.Windows.Forms.Panel()
        Me.Panel39 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel40 = New System.Windows.Forms.Panel()
        Me.Panel41 = New System.Windows.Forms.Panel()
        Me.Panel42 = New System.Windows.Forms.Panel()
        Me.Panel43 = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel29.SuspendLayout()
        Me.Panel31.SuspendLayout()
        Me.Panel36.SuspendLayout()
        Me.Panel39.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 10)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cboPayment)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(472, 59)
        Me.Panel3.TabIndex = 1
        '
        'cboPayment
        '
        Me.cboPayment.BackColor = System.Drawing.Color.Transparent
        Me.cboPayment.Dock = System.Windows.Forms.DockStyle.Left
        Me.cboPayment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboPayment.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.cboPayment.ForeColor = System.Drawing.Color.Black
        Me.cboPayment.ItemHeight = 30
        Me.cboPayment.Items.AddRange(New Object() {"Cash", "E-Payment", "Card"})
        Me.cboPayment.Location = New System.Drawing.Point(154, 10)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(279, 36)
        Me.cboPayment.TabIndex = 60
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(144, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(10, 39)
        Me.Panel7.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 39)
        Me.Panel4.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label1.Location = New System.Drawing.Point(0, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Payment:"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(134, 10)
        Me.Panel8.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(10, 49)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(462, 10)
        Me.Panel6.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(462, 10)
        Me.Panel5.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 59)
        Me.Panel2.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtRefNo)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Controls.Add(Me.Panel11)
        Me.Panel9.Controls.Add(Me.Panel13)
        Me.Panel9.Controls.Add(Me.Panel18)
        Me.Panel9.Controls.Add(Me.Panel19)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 69)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(472, 59)
        Me.Panel9.TabIndex = 2
        '
        'txtRefNo
        '
        Me.txtRefNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRefNo.DefaultText = ""
        Me.txtRefNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRefNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRefNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRefNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRefNo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtRefNo.Enabled = False
        Me.txtRefNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefNo.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtRefNo.ForeColor = System.Drawing.Color.Black
        Me.txtRefNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRefNo.Location = New System.Drawing.Point(154, 10)
        Me.txtRefNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRefNo.PlaceholderText = ""
        Me.txtRefNo.SelectedText = ""
        Me.txtRefNo.Size = New System.Drawing.Size(279, 39)
        Me.txtRefNo.TabIndex = 81
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(144, 10)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 39)
        Me.Panel10.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(10, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(134, 39)
        Me.Panel11.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label3.Location = New System.Drawing.Point(0, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Reference No:"
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(134, 10)
        Me.Panel12.TabIndex = 34
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(10, 49)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(462, 10)
        Me.Panel13.TabIndex = 3
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(10, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(462, 10)
        Me.Panel18.TabIndex = 2
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(10, 59)
        Me.Panel19.TabIndex = 1
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.lblGrandTotal)
        Me.Panel20.Controls.Add(Me.Label10)
        Me.Panel20.Controls.Add(Me.Panel28)
        Me.Panel20.Controls.Add(Me.Panel23)
        Me.Panel20.Controls.Add(Me.Panel25)
        Me.Panel20.Controls.Add(Me.Panel26)
        Me.Panel20.Controls.Add(Me.Panel27)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(0, 128)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(472, 59)
        Me.Panel20.TabIndex = 3
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandTotal.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblGrandTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblGrandTotal.Location = New System.Drawing.Point(164, 21)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(108, 19)
        Me.lblGrandTotal.TabIndex = 35
        Me.lblGrandTotal.Text = "XXXXXXXXX"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(144, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 19)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "₱"
        '
        'Panel28
        '
        Me.Panel28.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel28.Location = New System.Drawing.Point(144, 10)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(328, 11)
        Me.Panel28.TabIndex = 36
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.Label4)
        Me.Panel23.Controls.Add(Me.Panel24)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel23.Location = New System.Drawing.Point(10, 10)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(134, 39)
        Me.Panel23.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(0, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Grand Total:"
        '
        'Panel24
        '
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(134, 10)
        Me.Panel24.TabIndex = 34
        '
        'Panel25
        '
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel25.Location = New System.Drawing.Point(10, 49)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(462, 10)
        Me.Panel25.TabIndex = 3
        '
        'Panel26
        '
        Me.Panel26.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel26.Location = New System.Drawing.Point(10, 0)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(462, 10)
        Me.Panel26.TabIndex = 2
        '
        'Panel27
        '
        Me.Panel27.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel27.Location = New System.Drawing.Point(0, 0)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(10, 59)
        Me.Panel27.TabIndex = 1
        '
        'Panel29
        '
        Me.Panel29.Controls.Add(Me.txtAmountPaid)
        Me.Panel29.Controls.Add(Me.Panel30)
        Me.Panel29.Controls.Add(Me.Panel31)
        Me.Panel29.Controls.Add(Me.Panel33)
        Me.Panel29.Controls.Add(Me.Panel34)
        Me.Panel29.Controls.Add(Me.Panel35)
        Me.Panel29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel29.Location = New System.Drawing.Point(0, 187)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(472, 59)
        Me.Panel29.TabIndex = 4
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmountPaid.DefaultText = ""
        Me.txtAmountPaid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAmountPaid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAmountPaid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPaid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAmountPaid.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtAmountPaid.Enabled = False
        Me.txtAmountPaid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPaid.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtAmountPaid.ForeColor = System.Drawing.Color.Black
        Me.txtAmountPaid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAmountPaid.Location = New System.Drawing.Point(154, 10)
        Me.txtAmountPaid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAmountPaid.PlaceholderText = ""
        Me.txtAmountPaid.SelectedText = ""
        Me.txtAmountPaid.Size = New System.Drawing.Size(279, 39)
        Me.txtAmountPaid.TabIndex = 81
        '
        'Panel30
        '
        Me.Panel30.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel30.Location = New System.Drawing.Point(144, 10)
        Me.Panel30.Name = "Panel30"
        Me.Panel30.Size = New System.Drawing.Size(10, 39)
        Me.Panel30.TabIndex = 2
        '
        'Panel31
        '
        Me.Panel31.Controls.Add(Me.Label6)
        Me.Panel31.Controls.Add(Me.Panel32)
        Me.Panel31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel31.Location = New System.Drawing.Point(10, 10)
        Me.Panel31.Name = "Panel31"
        Me.Panel31.Size = New System.Drawing.Size(134, 39)
        Me.Panel31.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(0, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Amount Paid:"
        '
        'Panel32
        '
        Me.Panel32.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel32.Location = New System.Drawing.Point(0, 0)
        Me.Panel32.Name = "Panel32"
        Me.Panel32.Size = New System.Drawing.Size(134, 10)
        Me.Panel32.TabIndex = 34
        '
        'Panel33
        '
        Me.Panel33.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel33.Location = New System.Drawing.Point(10, 49)
        Me.Panel33.Name = "Panel33"
        Me.Panel33.Size = New System.Drawing.Size(462, 10)
        Me.Panel33.TabIndex = 3
        '
        'Panel34
        '
        Me.Panel34.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel34.Location = New System.Drawing.Point(10, 0)
        Me.Panel34.Name = "Panel34"
        Me.Panel34.Size = New System.Drawing.Size(462, 10)
        Me.Panel34.TabIndex = 2
        '
        'Panel35
        '
        Me.Panel35.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel35.Location = New System.Drawing.Point(0, 0)
        Me.Panel35.Name = "Panel35"
        Me.Panel35.Size = New System.Drawing.Size(10, 59)
        Me.Panel35.TabIndex = 1
        '
        'Panel36
        '
        Me.Panel36.Controls.Add(Me.lblAmountChange)
        Me.Panel36.Controls.Add(Me.Label9)
        Me.Panel36.Controls.Add(Me.Panel37)
        Me.Panel36.Controls.Add(Me.Panel39)
        Me.Panel36.Controls.Add(Me.Panel41)
        Me.Panel36.Controls.Add(Me.Panel42)
        Me.Panel36.Controls.Add(Me.Panel43)
        Me.Panel36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel36.Location = New System.Drawing.Point(0, 246)
        Me.Panel36.Name = "Panel36"
        Me.Panel36.Size = New System.Drawing.Size(472, 59)
        Me.Panel36.TabIndex = 5
        '
        'lblAmountChange
        '
        Me.lblAmountChange.AutoSize = True
        Me.lblAmountChange.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountChange.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAmountChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmountChange.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblAmountChange.Location = New System.Drawing.Point(164, 21)
        Me.lblAmountChange.Name = "lblAmountChange"
        Me.lblAmountChange.Size = New System.Drawing.Size(108, 19)
        Me.lblAmountChange.TabIndex = 35
        Me.lblAmountChange.Text = "XXXXXXXXX"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label9.Location = New System.Drawing.Point(144, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 19)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "₱"
        '
        'Panel37
        '
        Me.Panel37.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel37.Location = New System.Drawing.Point(144, 10)
        Me.Panel37.Name = "Panel37"
        Me.Panel37.Size = New System.Drawing.Size(328, 11)
        Me.Panel37.TabIndex = 36
        '
        'Panel39
        '
        Me.Panel39.Controls.Add(Me.Label8)
        Me.Panel39.Controls.Add(Me.Panel40)
        Me.Panel39.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel39.Location = New System.Drawing.Point(10, 10)
        Me.Panel39.Name = "Panel39"
        Me.Panel39.Size = New System.Drawing.Size(134, 39)
        Me.Panel39.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label8.Location = New System.Drawing.Point(0, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 18)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Amount Change:"
        '
        'Panel40
        '
        Me.Panel40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel40.Location = New System.Drawing.Point(0, 0)
        Me.Panel40.Name = "Panel40"
        Me.Panel40.Size = New System.Drawing.Size(134, 10)
        Me.Panel40.TabIndex = 34
        '
        'Panel41
        '
        Me.Panel41.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel41.Location = New System.Drawing.Point(10, 49)
        Me.Panel41.Name = "Panel41"
        Me.Panel41.Size = New System.Drawing.Size(462, 10)
        Me.Panel41.TabIndex = 3
        '
        'Panel42
        '
        Me.Panel42.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel42.Location = New System.Drawing.Point(10, 0)
        Me.Panel42.Name = "Panel42"
        Me.Panel42.Size = New System.Drawing.Size(462, 10)
        Me.Panel42.TabIndex = 2
        '
        'Panel43
        '
        Me.Panel43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel43.Location = New System.Drawing.Point(0, 0)
        Me.Panel43.Name = "Panel43"
        Me.Panel43.Size = New System.Drawing.Size(10, 59)
        Me.Panel43.TabIndex = 1
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.btnCancel)
        Me.pnlBody.Controls.Add(Me.Panel36)
        Me.pnlBody.Controls.Add(Me.btnConfirm)
        Me.pnlBody.Controls.Add(Me.Panel29)
        Me.pnlBody.Controls.Add(Me.Panel20)
        Me.pnlBody.Controls.Add(Me.Panel9)
        Me.pnlBody.Controls.Add(Me.Panel3)
        Me.pnlBody.Controls.Add(Me.Panel1)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 56)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(472, 399)
        Me.pnlBody.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 8
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.SeaGreen
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCancel.Location = New System.Drawing.Point(270, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(163, 40)
        Me.btnCancel.TabIndex = 91
        Me.btnCancel.Text = "Cancel"
        '
        'btnConfirm
        '
        Me.btnConfirm.BorderRadius = 8
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirm.FillColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.Location = New System.Drawing.Point(45, 332)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.PressedDepth = 20
        Me.btnConfirm.Size = New System.Drawing.Size(163, 40)
        Me.btnConfirm.TabIndex = 90
        Me.btnConfirm.Text = "Confirm"
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label2)
        Me.Panel15.Controls.Add(Me.Panel16)
        Me.Panel15.Controls.Add(Me.Panel17)
        Me.Panel15.Controls.Add(Me.Panel22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(265, 56)
        Me.Panel15.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Payment"
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel16.Location = New System.Drawing.Point(0, 15)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(10, 31)
        Me.Panel16.TabIndex = 13
        '
        'Panel17
        '
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 46)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(265, 10)
        Me.Panel17.TabIndex = 13
        '
        'Panel22
        '
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(265, 15)
        Me.Panel22.TabIndex = 13
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel14.Controls.Add(Me.Panel15)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(472, 56)
        Me.Panel14.TabIndex = 1
        '
        'frmManagePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 455)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.Panel14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmManagePayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel29.ResumeLayout(False)
        Me.Panel31.ResumeLayout(False)
        Me.Panel31.PerformLayout()
        Me.Panel36.ResumeLayout(False)
        Me.Panel36.PerformLayout()
        Me.Panel39.ResumeLayout(False)
        Me.Panel39.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboPayment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents txtRefNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Panel26 As Panel
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Panel29 As Panel
    Friend WithEvents txtAmountPaid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel30 As Panel
    Friend WithEvents Panel31 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel32 As Panel
    Friend WithEvents Panel33 As Panel
    Friend WithEvents Panel34 As Panel
    Friend WithEvents Panel35 As Panel
    Friend WithEvents Panel36 As Panel
    Friend WithEvents lblAmountChange As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel37 As Panel
    Friend WithEvents Panel39 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel40 As Panel
    Friend WithEvents Panel41 As Panel
    Friend WithEvents Panel42 As Panel
    Friend WithEvents Panel43 As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
End Class
