<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.cmdregister = New Guna.UI2.WinForms.Guna2Button()
        Me.txtConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSetPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmdback = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(317, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Password"
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
        Me.Guna2Shapes1.TabIndex = 4
        Me.Guna2Shapes1.Text = "Guna2Shapes1"
        Me.Guna2Shapes1.Zoom = 80
        '
        'cmdregister
        '
        Me.cmdregister.BackColor = System.Drawing.Color.White
        Me.cmdregister.BorderRadius = 20
        Me.cmdregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cmdregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cmdregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cmdregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cmdregister.Font = New System.Drawing.Font("Montserrat", 12.0!)
        Me.cmdregister.ForeColor = System.Drawing.Color.White
        Me.cmdregister.Location = New System.Drawing.Point(299, 272)
        Me.cmdregister.Name = "cmdregister"
        Me.cmdregister.Size = New System.Drawing.Size(200, 45)
        Me.cmdregister.TabIndex = 8
        Me.cmdregister.Text = "Register"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.BackColor = System.Drawing.Color.White
        Me.txtConfirmPass.BorderRadius = 15
        Me.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPass.DefaultText = ""
        Me.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPass.Location = New System.Drawing.Point(299, 215)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPass.PlaceholderText = "Confirm Password"
        Me.txtConfirmPass.SelectedText = ""
        Me.txtConfirmPass.Size = New System.Drawing.Size(200, 36)
        Me.txtConfirmPass.TabIndex = 7
        '
        'txtSetPass
        '
        Me.txtSetPass.BackColor = System.Drawing.Color.White
        Me.txtSetPass.BorderRadius = 15
        Me.txtSetPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSetPass.DefaultText = ""
        Me.txtSetPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSetPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSetPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSetPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSetPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSetPass.Location = New System.Drawing.Point(299, 173)
        Me.txtSetPass.Name = "txtSetPass"
        Me.txtSetPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSetPass.PlaceholderText = "Set Password"
        Me.txtSetPass.SelectedText = ""
        Me.txtSetPass.Size = New System.Drawing.Size(200, 36)
        Me.txtSetPass.TabIndex = 6
        '
        'cmdback
        '
        Me.cmdback.AutoSize = True
        Me.cmdback.BackColor = System.Drawing.Color.White
        Me.cmdback.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdback.ForeColor = System.Drawing.Color.DodgerBlue
        Me.cmdback.Location = New System.Drawing.Point(367, 320)
        Me.cmdback.Name = "cmdback"
        Me.cmdback.Size = New System.Drawing.Size(62, 18)
        Me.cmdback.TabIndex = 11
        Me.cmdback.Text = "Go Back"
        '
        'PasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._10
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdback)
        Me.Controls.Add(Me.cmdregister)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.txtSetPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Shapes1)
        Me.Name = "PasswordForm"
        Me.Text = "PasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Shapes1 As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents cmdregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtConfirmPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSetPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmdback As Label
End Class
