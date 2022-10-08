<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.Guna2Shapes1 = New Guna.UI2.WinForms.Guna2Shapes()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdchangepass = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNewPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPrevPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdback = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.Guna2Shapes1.TabIndex = 1
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(315, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'cmdchangepass
        '
        Me.cmdchangepass.BackColor = System.Drawing.Color.White
        Me.cmdchangepass.BorderRadius = 20
        Me.cmdchangepass.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdchangepass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdchangepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdchangepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdchangepass.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.cmdchangepass.ForeColor = System.Drawing.Color.White
        Me.cmdchangepass.Location = New System.Drawing.Point(300, 276)
        Me.cmdchangepass.Name = "cmdchangepass"
        Me.cmdchangepass.Size = New System.Drawing.Size(200, 45)
        Me.cmdchangepass.TabIndex = 7
        Me.cmdchangepass.Text = "Save"
        '
        'txtNewPass
        '
        Me.txtNewPass.BackColor = System.Drawing.Color.White
        Me.txtNewPass.BorderRadius = 15
        Me.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNewPass.DefaultText = ""
        Me.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNewPass.Location = New System.Drawing.Point(300, 213)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewPass.PlaceholderText = "New Password"
        Me.txtNewPass.SelectedText = ""
        Me.txtNewPass.Size = New System.Drawing.Size(200, 36)
        Me.txtNewPass.TabIndex = 6
        '
        'txtPrevPass
        '
        Me.txtPrevPass.BackColor = System.Drawing.Color.White
        Me.txtPrevPass.BorderRadius = 15
        Me.txtPrevPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrevPass.DefaultText = ""
        Me.txtPrevPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPrevPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPrevPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrevPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPrevPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrevPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPrevPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrevPass.Location = New System.Drawing.Point(300, 171)
        Me.txtPrevPass.Name = "txtPrevPass"
        Me.txtPrevPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrevPass.PlaceholderText = "Previous Password"
        Me.txtPrevPass.SelectedText = ""
        Me.txtPrevPass.Size = New System.Drawing.Size(200, 36)
        Me.txtPrevPass.TabIndex = 5
        '
        'cmdback
        '
        Me.cmdback.AutoSize = True
        Me.cmdback.BackColor = System.Drawing.Color.White
        Me.cmdback.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmdback.Location = New System.Drawing.Point(378, 324)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(41, 18)
        Me.cmdback.TabIndex = 8
        Me.cmdback.Text = "Back"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._103
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdback)
        Me.Controls.Add(Me.cmdchangepass)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.txtPrevPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdchangepass As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNewPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPrevPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdback As Label
End Class
