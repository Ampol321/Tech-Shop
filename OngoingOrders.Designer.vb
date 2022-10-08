<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OngoingOrders
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
        Me.cbosearch = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmdback = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtstatus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTotalPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtMethodPay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtShipFee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtShipmentMode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtShipDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtOrderDate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CmbOrderID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.BtnOrderCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdcanceledorders = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cbosearch)
        Me.Panel1.Controls.Add(Me.cmdback)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 46)
        Me.Panel1.TabIndex = 5
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
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtstatus)
        Me.Panel2.Controls.Add(Me.txtTotalPrice)
        Me.Panel2.Controls.Add(Me.txtMethodPay)
        Me.Panel2.Controls.Add(Me.txtShipFee)
        Me.Panel2.Controls.Add(Me.txtShipmentMode)
        Me.Panel2.Controls.Add(Me.txtShipDate)
        Me.Panel2.Controls.Add(Me.txtOrderDate)
        Me.Panel2.Controls.Add(Me.CmbOrderID)
        Me.Panel2.Controls.Add(Me.label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 404)
        Me.Panel2.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Order Information"
        '
        'txtstatus
        '
        Me.txtstatus.BorderRadius = 15
        Me.txtstatus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtstatus.DefaultText = ""
        Me.txtstatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtstatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtstatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtstatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtstatus.Location = New System.Drawing.Point(16, 333)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtstatus.PlaceholderText = "Status"
        Me.txtstatus.SelectedText = ""
        Me.txtstatus.Size = New System.Drawing.Size(97, 36)
        Me.txtstatus.TabIndex = 20
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.BorderRadius = 15
        Me.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalPrice.DefaultText = ""
        Me.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(119, 333)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalPrice.PlaceholderText = "Total Price"
        Me.txtTotalPrice.SelectedText = ""
        Me.txtTotalPrice.Size = New System.Drawing.Size(114, 36)
        Me.txtTotalPrice.TabIndex = 19
        '
        'txtMethodPay
        '
        Me.txtMethodPay.BorderRadius = 15
        Me.txtMethodPay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMethodPay.DefaultText = ""
        Me.txtMethodPay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMethodPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMethodPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMethodPay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMethodPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMethodPay.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMethodPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMethodPay.Location = New System.Drawing.Point(16, 291)
        Me.txtMethodPay.Name = "txtMethodPay"
        Me.txtMethodPay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMethodPay.PlaceholderText = "Method Of Payment"
        Me.txtMethodPay.SelectedText = ""
        Me.txtMethodPay.Size = New System.Drawing.Size(217, 36)
        Me.txtMethodPay.TabIndex = 18
        '
        'txtShipFee
        '
        Me.txtShipFee.BorderRadius = 15
        Me.txtShipFee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipFee.DefaultText = ""
        Me.txtShipFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtShipFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtShipFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipFee.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtShipFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipFee.Location = New System.Drawing.Point(16, 249)
        Me.txtShipFee.Name = "txtShipFee"
        Me.txtShipFee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShipFee.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtShipFee.PlaceholderText = "Delivery Charge"
        Me.txtShipFee.SelectedText = ""
        Me.txtShipFee.Size = New System.Drawing.Size(217, 36)
        Me.txtShipFee.TabIndex = 17
        '
        'txtShipmentMode
        '
        Me.txtShipmentMode.BorderRadius = 15
        Me.txtShipmentMode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipmentMode.DefaultText = ""
        Me.txtShipmentMode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtShipmentMode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtShipmentMode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipmentMode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipmentMode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipmentMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtShipmentMode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipmentMode.Location = New System.Drawing.Point(16, 207)
        Me.txtShipmentMode.Name = "txtShipmentMode"
        Me.txtShipmentMode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShipmentMode.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtShipmentMode.PlaceholderText = "Shipment Mode"
        Me.txtShipmentMode.SelectedText = ""
        Me.txtShipmentMode.Size = New System.Drawing.Size(217, 36)
        Me.txtShipmentMode.TabIndex = 16
        '
        'txtShipDate
        '
        Me.txtShipDate.BorderRadius = 15
        Me.txtShipDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtShipDate.DefaultText = ""
        Me.txtShipDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtShipDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtShipDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtShipDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtShipDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtShipDate.Location = New System.Drawing.Point(16, 165)
        Me.txtShipDate.Name = "txtShipDate"
        Me.txtShipDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtShipDate.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtShipDate.PlaceholderText = "Shipment Date"
        Me.txtShipDate.SelectedText = ""
        Me.txtShipDate.Size = New System.Drawing.Size(217, 36)
        Me.txtShipDate.TabIndex = 15
        '
        'txtOrderDate
        '
        Me.txtOrderDate.BorderRadius = 15
        Me.txtOrderDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrderDate.DefaultText = ""
        Me.txtOrderDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOrderDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOrderDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOrderDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOrderDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOrderDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtOrderDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOrderDate.Location = New System.Drawing.Point(16, 123)
        Me.txtOrderDate.Name = "txtOrderDate"
        Me.txtOrderDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrderDate.PlaceholderForeColor = System.Drawing.Color.Silver
        Me.txtOrderDate.PlaceholderText = "Date Ordered"
        Me.txtOrderDate.SelectedText = ""
        Me.txtOrderDate.Size = New System.Drawing.Size(217, 36)
        Me.txtOrderDate.TabIndex = 14
        '
        'CmbOrderID
        '
        Me.CmbOrderID.BackColor = System.Drawing.Color.Transparent
        Me.CmbOrderID.BorderRadius = 15
        Me.CmbOrderID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CmbOrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOrderID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmbOrderID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CmbOrderID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CmbOrderID.ItemHeight = 30
        Me.CmbOrderID.Location = New System.Drawing.Point(16, 42)
        Me.CmbOrderID.Name = "CmbOrderID"
        Me.CmbOrderID.Size = New System.Drawing.Size(217, 36)
        Me.CmbOrderID.TabIndex = 13
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(23, 17)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(141, 22)
        Me.label1.TabIndex = 12
        Me.label1.Text = "You have orders:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(459, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 33)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Your Item(s):"
        '
        'txtItems
        '
        Me.txtItems.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItems.Location = New System.Drawing.Point(281, 100)
        Me.txtItems.Multiline = True
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(507, 273)
        Me.txtItems.TabIndex = 23
        '
        'BtnOrderCancel
        '
        Me.BtnOrderCancel.BorderRadius = 20
        Me.BtnOrderCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnOrderCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnOrderCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnOrderCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnOrderCancel.FillColor = System.Drawing.Color.Black
        Me.BtnOrderCancel.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrderCancel.ForeColor = System.Drawing.Color.White
        Me.BtnOrderCancel.Location = New System.Drawing.Point(608, 393)
        Me.BtnOrderCancel.Name = "BtnOrderCancel"
        Me.BtnOrderCancel.Size = New System.Drawing.Size(180, 45)
        Me.BtnOrderCancel.TabIndex = 24
        Me.BtnOrderCancel.Text = "Cancel Order"
        '
        'cmdcanceledorders
        '
        Me.cmdcanceledorders.BorderRadius = 20
        Me.cmdcanceledorders.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdcanceledorders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdcanceledorders.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdcanceledorders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdcanceledorders.FillColor = System.Drawing.Color.Black
        Me.cmdcanceledorders.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcanceledorders.ForeColor = System.Drawing.Color.White
        Me.cmdcanceledorders.Location = New System.Drawing.Point(281, 393)
        Me.cmdcanceledorders.Name = "cmdcanceledorders"
        Me.cmdcanceledorders.Size = New System.Drawing.Size(321, 45)
        Me.cmdcanceledorders.TabIndex = 25
        Me.cmdcanceledorders.Text = "My Canceled Orders"
        '
        'OngoingOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdcanceledorders)
        Me.Controls.Add(Me.BtnOrderCancel)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OngoingOrders"
        Me.Text = "OngoingOrders"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbosearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmdback As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents label1 As Label
    Friend WithEvents CmbOrderID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtTotalPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMethodPay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtShipFee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtShipmentMode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtShipDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtOrderDate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItems As TextBox
    Friend WithEvents BtnOrderCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdcanceledorders As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtstatus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
