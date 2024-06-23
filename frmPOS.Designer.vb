<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPOS))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTransactNo = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnConfirm = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.lblMOP = New System.Windows.Forms.Label()
        Me.lblAmountChange = New System.Windows.Forms.Label()
        Me.lblAmountPaid = New System.Windows.Forms.Label()
        Me.lblTotalProductSold = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.bntLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPayment = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddCart = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStock = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel5.Controls.Add(Me.lblProductID)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lblTransactNo)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1366, 50)
        Me.Panel5.TabIndex = 2
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(514, 31)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(39, 13)
        Me.lblProductID.TabIndex = 6
        Me.lblProductID.Text = "Label2"
        Me.lblProductID.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1061, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Transaction No: "
        '
        'lblTransactNo
        '
        Me.lblTransactNo.AutoSize = True
        Me.lblTransactNo.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTransactNo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactNo.ForeColor = System.Drawing.Color.White
        Me.lblTransactNo.Location = New System.Drawing.Point(1236, 15)
        Me.lblTransactNo.Name = "lblTransactNo"
        Me.lblTransactNo.Size = New System.Drawing.Size(120, 22)
        Me.lblTransactNo.TabIndex = 4
        Me.lblTransactNo.Text = "xxxxxxxxxx"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1356, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 35)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Point of Sale System"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(10, 35)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 15)
        Me.Panel1.TabIndex = 2
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.White
        Me.pnlBody.Controls.Add(Me.btnSearch)
        Me.pnlBody.Controls.Add(Me.Panel7)
        Me.pnlBody.Controls.Add(Me.btnCancel)
        Me.pnlBody.Controls.Add(Me.btnConfirm)
        Me.pnlBody.Controls.Add(Me.GroupBox3)
        Me.pnlBody.Controls.Add(Me.GroupBox2)
        Me.pnlBody.Controls.Add(Me.GroupBox1)
        Me.pnlBody.Controls.Add(Me.txtStock)
        Me.pnlBody.Controls.Add(Me.Label7)
        Me.pnlBody.Controls.Add(Me.txtPrice)
        Me.pnlBody.Controls.Add(Me.Label6)
        Me.pnlBody.Controls.Add(Me.txtDescription)
        Me.pnlBody.Controls.Add(Me.Label5)
        Me.pnlBody.Controls.Add(Me.txtProductName)
        Me.pnlBody.Controls.Add(Me.Label4)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 50)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1366, 699)
        Me.pnlBody.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 8
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(242, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(45, 36)
        Me.btnSearch.TabIndex = 78
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.lblUsername)
        Me.Panel7.Controls.Add(Me.Panel13)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.lblTime)
        Me.Panel7.Controls.Add(Me.Panel12)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.lblDate)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 664)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1366, 35)
        Me.Panel7.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(873, 7)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 22)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Username:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(991, 7)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(65, 22)
        Me.lblUsername.TabIndex = 15
        Me.lblUsername.Text = "xxxxx"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label16)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel13.Location = New System.Drawing.Point(1056, 7)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(20, 28)
        Me.Panel13.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 22)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "|"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1076, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 22)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTime.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(1142, 7)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(65, 22)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "xxxxx"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Label18)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel12.Location = New System.Drawing.Point(1207, 7)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(20, 28)
        Me.Panel12.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 22)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "|"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1227, 7)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 22)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Date:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(1291, 7)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(65, 22)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "xxxxx"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1356, 7)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(10, 28)
        Me.Panel10.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(10, 28)
        Me.Panel11.TabIndex = 13
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1366, 7)
        Me.Panel8.TabIndex = 0
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
        Me.btnCancel.Location = New System.Drawing.Point(1188, 456)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.PressedDepth = 20
        Me.btnCancel.Size = New System.Drawing.Size(163, 40)
        Me.btnCancel.TabIndex = 90
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
        Me.btnConfirm.Enabled = False
        Me.btnConfirm.FillColor = System.Drawing.Color.SeaGreen
        Me.btnConfirm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnConfirm.Location = New System.Drawing.Point(1001, 456)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.PressedDepth = 20
        Me.btnConfirm.Size = New System.Drawing.Size(163, 40)
        Me.btnConfirm.TabIndex = 89
        Me.btnConfirm.Text = "Confirm"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGrandTotal)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.SandyBrown
        Me.GroupBox3.Location = New System.Drawing.Point(1001, 321)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 117)
        Me.GroupBox3.TabIndex = 88
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GRAND TOTAL"
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrandTotal.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblGrandTotal.Location = New System.Drawing.Point(57, 35)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(115, 55)
        Me.lblGrandTotal.TabIndex = 88
        Me.lblGrandTotal.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label13.Location = New System.Drawing.Point(9, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 55)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "₱"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblRefNo)
        Me.GroupBox2.Controls.Add(Me.lblMOP)
        Me.GroupBox2.Controls.Add(Me.lblAmountChange)
        Me.GroupBox2.Controls.Add(Me.lblAmountPaid)
        Me.GroupBox2.Controls.Add(Me.lblTotalProductSold)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(1001, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 208)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label14.Location = New System.Drawing.Point(168, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 19)
        Me.Label14.TabIndex = 94
        Me.Label14.Text = "₱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label2.Location = New System.Drawing.Point(168, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 19)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "₱"
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRefNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblRefNo.Location = New System.Drawing.Point(188, 176)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(27, 19)
        Me.lblRefNo.TabIndex = 92
        Me.lblRefNo.Text = "***"
        '
        'lblMOP
        '
        Me.lblMOP.AutoSize = True
        Me.lblMOP.BackColor = System.Drawing.Color.Transparent
        Me.lblMOP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMOP.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblMOP.Location = New System.Drawing.Point(188, 135)
        Me.lblMOP.Name = "lblMOP"
        Me.lblMOP.Size = New System.Drawing.Size(27, 19)
        Me.lblMOP.TabIndex = 91
        Me.lblMOP.Text = "***"
        '
        'lblAmountChange
        '
        Me.lblAmountChange.AutoSize = True
        Me.lblAmountChange.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountChange.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountChange.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblAmountChange.Location = New System.Drawing.Point(188, 97)
        Me.lblAmountChange.Name = "lblAmountChange"
        Me.lblAmountChange.Size = New System.Drawing.Size(40, 19)
        Me.lblAmountChange.TabIndex = 90
        Me.lblAmountChange.Text = "0.00"
        '
        'lblAmountPaid
        '
        Me.lblAmountPaid.AutoSize = True
        Me.lblAmountPaid.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountPaid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPaid.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblAmountPaid.Location = New System.Drawing.Point(188, 60)
        Me.lblAmountPaid.Name = "lblAmountPaid"
        Me.lblAmountPaid.Size = New System.Drawing.Size(40, 19)
        Me.lblAmountPaid.TabIndex = 89
        Me.lblAmountPaid.Text = "0.00"
        '
        'lblTotalProductSold
        '
        Me.lblTotalProductSold.AutoSize = True
        Me.lblTotalProductSold.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalProductSold.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProductSold.ForeColor = System.Drawing.Color.SandyBrown
        Me.lblTotalProductSold.Location = New System.Drawing.Point(188, 18)
        Me.lblTotalProductSold.Name = "lblTotalProductSold"
        Me.lblTotalProductSold.Size = New System.Drawing.Size(18, 19)
        Me.lblTotalProductSold.TabIndex = 88
        Me.lblTotalProductSold.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label12.Location = New System.Drawing.Point(7, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 19)
        Me.Label12.TabIndex = 86
        Me.Label12.Text = "Reference No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label11.Location = New System.Drawing.Point(7, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 19)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Mode of Payment:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label10.Location = New System.Drawing.Point(7, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 19)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Amount Change:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label9.Location = New System.Drawing.Point(7, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 19)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Amount Paid:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label8.Location = New System.Drawing.Point(7, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 19)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Total Product(s) Sold:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.bntLogout)
        Me.GroupBox1.Controls.Add(Me.btnPayment)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        Me.GroupBox1.Controls.Add(Me.btnAddCart)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Location = New System.Drawing.Point(13, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 539)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CART"
        '
        'bntLogout
        '
        Me.bntLogout.BorderRadius = 8
        Me.bntLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.bntLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.bntLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.bntLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.bntLogout.FillColor = System.Drawing.Color.SeaGreen
        Me.bntLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.bntLogout.ForeColor = System.Drawing.Color.White
        Me.bntLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.bntLogout.Location = New System.Drawing.Point(819, 469)
        Me.bntLogout.Name = "bntLogout"
        Me.bntLogout.PressedDepth = 20
        Me.bntLogout.Size = New System.Drawing.Size(140, 40)
        Me.bntLogout.TabIndex = 87
        Me.bntLogout.Text = "Logout"
        '
        'btnPayment
        '
        Me.btnPayment.BorderRadius = 8
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPayment.FillColor = System.Drawing.Color.SeaGreen
        Me.btnPayment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnPayment.Location = New System.Drawing.Point(343, 469)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.PressedDepth = 20
        Me.btnPayment.Size = New System.Drawing.Size(140, 40)
        Me.btnPayment.TabIndex = 86
        Me.btnPayment.Text = "Payment"
        '
        'btnRemove
        '
        Me.btnRemove.BorderRadius = 8
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.SeaGreen
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnRemove.Location = New System.Drawing.Point(177, 469)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.PressedDepth = 20
        Me.btnRemove.Size = New System.Drawing.Size(140, 40)
        Me.btnRemove.TabIndex = 85
        Me.btnRemove.Text = "Remove Item"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListView1)
        Me.Panel4.Location = New System.Drawing.Point(14, 25)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(945, 420)
        Me.Panel4.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(945, 420)
        Me.ListView1.TabIndex = 38
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Description"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 380
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Stock"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'btnAddCart
        '
        Me.btnAddCart.BorderRadius = 8
        Me.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddCart.FillColor = System.Drawing.Color.SeaGreen
        Me.btnAddCart.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddCart.ForeColor = System.Drawing.Color.White
        Me.btnAddCart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAddCart.Location = New System.Drawing.Point(14, 469)
        Me.btnAddCart.Name = "btnAddCart"
        Me.btnAddCart.PressedDepth = 20
        Me.btnAddCart.Size = New System.Drawing.Size(140, 40)
        Me.btnAddCart.TabIndex = 84
        Me.btnAddCart.Text = "Add to Cart"
        '
        'txtStock
        '
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.DefaultText = ""
        Me.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStock.Enabled = False
        Me.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStock.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtStock.ForeColor = System.Drawing.Color.Black
        Me.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStock.Location = New System.Drawing.Point(922, 38)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStock.PlaceholderText = ""
        Me.txtStock.SelectedText = ""
        Me.txtStock.Size = New System.Drawing.Size(261, 36)
        Me.txtStock.TabIndex = 86
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label7.Location = New System.Drawing.Point(921, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 19)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Stock"
        '
        'txtPrice
        '
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.DefaultText = ""
        Me.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrice.Enabled = False
        Me.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtPrice.ForeColor = System.Drawing.Color.Black
        Me.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(683, 38)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PlaceholderText = ""
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.Size = New System.Drawing.Size(214, 36)
        Me.txtPrice.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label6.Location = New System.Drawing.Point(682, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Price"
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.DefaultText = ""
        Me.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescription.Enabled = False
        Me.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtDescription.ForeColor = System.Drawing.Color.Black
        Me.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescription.Location = New System.Drawing.Point(314, 38)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.PlaceholderText = ""
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.Size = New System.Drawing.Size(348, 36)
        Me.txtDescription.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label5.Location = New System.Drawing.Point(313, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Description"
        '
        'txtProductName
        '
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.Enabled = False
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Location = New System.Drawing.Point(13, 38)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderText = ""
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.Size = New System.Drawing.Size(216, 36)
        Me.txtProductName.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SandyBrown
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 19)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Product Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTransactNo As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents txtStock As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPayment As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnAddCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnConfirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bntLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lblRefNo As Label
    Friend WithEvents lblMOP As Label
    Friend WithEvents lblAmountChange As Label
    Friend WithEvents lblAmountPaid As Label
    Friend WithEvents lblTotalProductSold As Label
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblProductID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
End Class
