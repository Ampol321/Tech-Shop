<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lobby
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdprofile = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdcomponents = New System.Windows.Forms.Button()
        Me.cmdgames = New System.Windows.Forms.Button()
        Me.cmdperipherals = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.cbosearch)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.cmdprofile)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 46)
        Me.Panel1.TabIndex = 0
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
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._3
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(674, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 40)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._4
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 41)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmdprofile
        '
        Me.cmdprofile.AutoSize = True
        Me.cmdprofile.BackColor = System.Drawing.Color.Transparent
        Me.cmdprofile.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprofile.ForeColor = System.Drawing.Color.White
        Me.cmdprofile.Location = New System.Drawing.Point(719, 9)
        Me.cmdprofile.Name = "cmdprofile"
        Me.cmdprofile.Size = New System.Drawing.Size(62, 22)
        Me.cmdprofile.TabIndex = 1
        Me.cmdprofile.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Shop By Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 545)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "COMPONENTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 545)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PERIPHERALS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(573, 545)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PC GAMES"
        '
        'cmdcomponents
        '
        Me.cmdcomponents.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._1
        Me.cmdcomponents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdcomponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdcomponents.Location = New System.Drawing.Point(56, 336)
        Me.cmdcomponents.Name = "cmdcomponents"
        Me.cmdcomponents.Size = New System.Drawing.Size(220, 206)
        Me.cmdcomponents.TabIndex = 14
        Me.cmdcomponents.UseVisualStyleBackColor = True
        '
        'cmdgames
        '
        Me.cmdgames.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._32
        Me.cmdgames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdgames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgames.Location = New System.Drawing.Point(508, 336)
        Me.cmdgames.Name = "cmdgames"
        Me.cmdgames.Size = New System.Drawing.Size(220, 206)
        Me.cmdgames.TabIndex = 13
        Me.cmdgames.UseVisualStyleBackColor = True
        '
        'cmdperipherals
        '
        Me.cmdperipherals.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._2
        Me.cmdperipherals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdperipherals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdperipherals.Location = New System.Drawing.Point(282, 336)
        Me.cmdperipherals.Name = "cmdperipherals"
        Me.cmdperipherals.Size = New System.Drawing.Size(220, 206)
        Me.cmdperipherals.TabIndex = 12
        Me.cmdperipherals.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TECH_FINALS.My.Resources.Resources._17
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 223)
        Me.Panel2.TabIndex = 1
        '
        'Lobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 583)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdcomponents)
        Me.Controls.Add(Me.cmdgames)
        Me.Controls.Add(Me.cmdperipherals)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Lobby"
        Me.Text = "Lobby"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdprofile As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbosearch As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdperipherals As Button
    Friend WithEvents cmdgames As Button
    Friend WithEvents cmdcomponents As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
