<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerInfo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblsupply = New System.Windows.Forms.Label()
        Me.lblreports = New System.Windows.Forms.Label()
        Me.cbosearch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmdback = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblChangePass = New System.Windows.Forms.Label()
        Me.lblEditInfo = New System.Windows.Forms.Label()
        Me.txtZipCode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCustomerID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnShowOrders = New Guna.UI2.WinForms.Guna2Button()
        Me.txtStreet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridOrders = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdlogout = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblsupply)
        Me.Panel1.Controls.Add(Me.lblreports)
        Me.Panel1.Controls.Add(Me.cbosearch)
        Me.Panel1.Controls.Add(Me.cmdback)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 46)
        Me.Panel1.TabIndex = 4
        '
        'lblsupply
        '
        Me.lblsupply.AutoSize = True
        Me.lblsupply.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsupply.ForeColor = System.Drawing.Color.White
        Me.lblsupply.Location = New System.Drawing.Point(556, 9)
        Me.lblsupply.Name = "lblsupply"
        Me.lblsupply.Size = New System.Drawing.Size(79, 22)
        Me.lblsupply.TabIndex = 6
        Me.lblsupply.Text = "Supply  |"
        '
        'lblreports
        '
        Me.lblreports.AutoSize = True
        Me.lblreports.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreports.ForeColor = System.Drawing.Color.White
        Me.lblreports.Location = New System.Drawing.Point(641, 9)
        Me.lblreports.Name = "lblreports"
        Me.lblreports.Size = New System.Drawing.Size(91, 22)
        Me.lblreports.TabIndex = 5
        Me.lblreports.Text = "Reports   |"
        Me.lblreports.Visible = False
        '
        'cbosearch
        '
        Me.cbosearch.BackColor = System.Drawing.Color.Transparent
        Me.cbosearch.BorderRadius = 15
        Me.cbosearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbosearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosearch.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbosearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbosearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbosearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbosearch.ItemHeight = 30
        Me.cbosearch.Location = New System.Drawing.Point(141, 4)
        Me.cbosearch.Name = "cbosearch"
        Me.cbosearch.Size = New System.Drawing.Size(200, 36)
        Me.cbosearch.TabIndex = 4
        '
        'cmdback
        '
        Me.cmdback.AutoSize = True
        Me.cmdback.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.ForeColor = System.Drawing.Color.White
        Me.cmdback.Location = New System.Drawing.Point(738, 9)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(50, 22)
        Me.cmdback.TabIndex = 1
        Me.cmdback.Text = "Back"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._4
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(135, 41)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lblChangePass)
        Me.Panel2.Controls.Add(Me.lblEditInfo)
        Me.Panel2.Controls.Add(Me.txtZipCode)
        Me.Panel2.Controls.Add(Me.txtCustomerID)
        Me.Panel2.Controls.Add(Me.txtCity)
        Me.Panel2.Controls.Add(Me.BtnShowOrders)
        Me.Panel2.Controls.Add(Me.txtStreet)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 408)
        Me.Panel2.TabIndex = 5
        '
        'lblChangePass
        '
        Me.lblChangePass.AutoSize = True
        Me.lblChangePass.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePass.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblChangePass.Location = New System.Drawing.Point(73, 384)
        Me.lblChangePass.Name = "lblChangePass"
        Me.lblChangePass.Size = New System.Drawing.Size(125, 18)
        Me.lblChangePass.TabIndex = 20
        Me.lblChangePass.Text = "Change Password"
        '
        'lblEditInfo
        '
        Me.lblEditInfo.AutoSize = True
        Me.lblEditInfo.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditInfo.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblEditInfo.Location = New System.Drawing.Point(96, 155)
        Me.lblEditInfo.Name = "lblEditInfo"
        Me.lblEditInfo.Size = New System.Drawing.Size(63, 18)
        Me.lblEditInfo.TabIndex = 19
        Me.lblEditInfo.Text = "Edit Info"
        '
        'txtZipCode
        '
        Me.txtZipCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtZipCode.BorderRadius = 10
        Me.txtZipCode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZipCode.DefaultText = ""
        Me.txtZipCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtZipCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtZipCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtZipCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtZipCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtZipCode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtZipCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtZipCode.Location = New System.Drawing.Point(33, 304)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtZipCode.PlaceholderText = ""
        Me.txtZipCode.SelectedText = ""
        Me.txtZipCode.Size = New System.Drawing.Size(200, 26)
        Me.txtZipCode.TabIndex = 17
        '
        'txtCustomerID
        '
        Me.txtCustomerID.BackColor = System.Drawing.SystemColors.Control
        Me.txtCustomerID.BorderRadius = 10
        Me.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerID.DefaultText = ""
        Me.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCustomerID.Location = New System.Drawing.Point(182, 176)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCustomerID.PlaceholderText = ""
        Me.txtCustomerID.SelectedText = ""
        Me.txtCustomerID.Size = New System.Drawing.Size(51, 26)
        Me.txtCustomerID.TabIndex = 14
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.SystemColors.Control
        Me.txtCity.BorderRadius = 10
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.DefaultText = ""
        Me.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(33, 272)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.PlaceholderText = ""
        Me.txtCity.SelectedText = ""
        Me.txtCity.Size = New System.Drawing.Size(200, 26)
        Me.txtCity.TabIndex = 16
        '
        'BtnShowOrders
        '
        Me.BtnShowOrders.BorderRadius = 20
        Me.BtnShowOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnShowOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnShowOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnShowOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnShowOrders.FillColor = System.Drawing.Color.Black
        Me.BtnShowOrders.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowOrders.ForeColor = System.Drawing.Color.White
        Me.BtnShowOrders.Location = New System.Drawing.Point(33, 336)
        Me.BtnShowOrders.Name = "BtnShowOrders"
        Me.BtnShowOrders.Size = New System.Drawing.Size(200, 45)
        Me.BtnShowOrders.TabIndex = 22
        Me.BtnShowOrders.Text = "My Orders"
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.SystemColors.Control
        Me.txtStreet.BorderRadius = 10
        Me.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStreet.DefaultText = ""
        Me.txtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.Location = New System.Drawing.Point(33, 240)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.PlaceholderText = ""
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.Size = New System.Drawing.Size(200, 26)
        Me.txtStreet.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmail.BorderRadius = 10
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(33, 208)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(200, 26)
        Me.txtEmail.TabIndex = 14
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.BorderRadius = 10
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(33, 176)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.Size = New System.Drawing.Size(143, 26)
        Me.txtName.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 33)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Account Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._111
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(76, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DataGridOrders
        '
        Me.DataGridOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrders.Location = New System.Drawing.Point(270, 109)
        Me.DataGridOrders.Name = "DataGridOrders"
        Me.DataGridOrders.Size = New System.Drawing.Size(518, 318)
        Me.DataGridOrders.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(445, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 33)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Order History"
        '
        'cmdlogout
        '
        Me.cmdlogout.AutoSize = True
        Me.cmdlogout.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogout.ForeColor = System.Drawing.Color.Red
        Me.cmdlogout.Location = New System.Drawing.Point(267, 430)
        Me.cmdlogout.Name = "cmdlogout"
        Me.cmdlogout.Size = New System.Drawing.Size(61, 18)
        Me.cmdlogout.TabIndex = 21
        Me.cmdlogout.Text = "Log Out"
        '
        'CustomerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.cmdlogout)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridOrders)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CustomerInfo"
        Me.Text = "CustomerInfo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbosearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmdback As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtZipCode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStreet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCustomerID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridOrders As DataGridView
    Friend WithEvents lblEditInfo As Label
    Friend WithEvents lblChangePass As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnShowOrders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdlogout As Label
    Friend WithEvents lblreports As Label
    Friend WithEvents lblsupply As Label
End Class
