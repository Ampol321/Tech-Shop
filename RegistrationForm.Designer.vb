<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtStreet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCity = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtZipcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdnext = New Guna.UI2.WinForms.Guna2Button()
        Me.cmdback = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(328, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Register"
        '
        'Guna2Shapes1
        '
        Me.Guna2Shapes1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Shapes1.FillColor = System.Drawing.Color.White
        Me.Guna2Shapes1.Location = New System.Drawing.Point(222, 12)
        Me.Guna2Shapes1.Name = "Guna2Shapes1"
        Me.Guna2Shapes1.PolygonSkip = 1
        Me.Guna2Shapes1.Rotate = 0!
        Me.Guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded
        Me.Guna2Shapes1.Size = New System.Drawing.Size(355, 438)
        Me.Guna2Shapes1.TabIndex = 2
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderRadius = 15
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(299, 186)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(200, 36)
        Me.txtEmail.TabIndex = 5
        '
        'txtCname
        '
        Me.txtCname.BackColor = System.Drawing.Color.White
        Me.txtCname.BorderRadius = 15
        Me.txtCname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCname.DefaultText = ""
        Me.txtCname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCname.Location = New System.Drawing.Point(299, 144)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCname.PlaceholderText = "Name"
        Me.txtCname.SelectedText = ""
        Me.txtCname.Size = New System.Drawing.Size(200, 36)
        Me.txtCname.TabIndex = 4
        '
        'txtStreet
        '
        Me.txtStreet.BackColor = System.Drawing.Color.White
        Me.txtStreet.BorderRadius = 15
        Me.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStreet.DefaultText = ""
        Me.txtStreet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStreet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStreet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStreet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtStreet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStreet.Location = New System.Drawing.Point(299, 228)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreet.PlaceholderText = "Street"
        Me.txtStreet.SelectedText = ""
        Me.txtStreet.Size = New System.Drawing.Size(200, 36)
        Me.txtStreet.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.BorderRadius = 15
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.DefaultText = ""
        Me.txtCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(299, 270)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCity.PlaceholderText = "City"
        Me.txtCity.SelectedText = ""
        Me.txtCity.Size = New System.Drawing.Size(118, 36)
        Me.txtCity.TabIndex = 7
        '
        'txtZipcode
        '
        Me.txtZipcode.BackColor = System.Drawing.Color.White
        Me.txtZipcode.BorderRadius = 15
        Me.txtZipcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtZipcode.DefaultText = ""
        Me.txtZipcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtZipcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtZipcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtZipcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtZipcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtZipcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtZipcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtZipcode.Location = New System.Drawing.Point(423, 270)
        Me.txtZipcode.Name = "txtZipcode"
        Me.txtZipcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtZipcode.PlaceholderText = "ZipCode"
        Me.txtZipcode.SelectedText = ""
        Me.txtZipcode.Size = New System.Drawing.Size(76, 36)
        Me.txtZipcode.TabIndex = 8
        '
        'cmdnext
        '
        Me.cmdnext.BackColor = System.Drawing.Color.White
        Me.cmdnext.BorderRadius = 20
        Me.cmdnext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdnext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdnext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdnext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdnext.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.cmdnext.ForeColor = System.Drawing.Color.White
        Me.cmdnext.Location = New System.Drawing.Point(299, 312)
        Me.cmdnext.Name = "cmdnext"
        Me.cmdnext.Size = New System.Drawing.Size(200, 45)
        Me.cmdnext.TabIndex = 9
        Me.cmdnext.Text = "Next"
        '
        'cmdback
        '
        Me.cmdback.AutoSize = True
        Me.cmdback.BackColor = System.Drawing.Color.White
        Me.cmdback.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmdback.Location = New System.Drawing.Point(366, 360)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(62, 18)
        Me.cmdback.TabIndex = 10
        Me.cmdback.Text = "Go Back"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdback)
        Me.Controls.Add(Me.cmdnext)
        Me.Controls.Add(Me.txtZipcode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreet)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtCname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtStreet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCity As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtZipcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdnext As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmdback As Label
End Class
