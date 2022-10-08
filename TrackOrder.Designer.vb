<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrackOrder
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
        Me.HistoryViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbocustomer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HistoryViewer
        '
        Me.HistoryViewer.ActiveViewIndex = -1
        Me.HistoryViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HistoryViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.HistoryViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HistoryViewer.Location = New System.Drawing.Point(0, 0)
        Me.HistoryViewer.Name = "HistoryViewer"
        Me.HistoryViewer.Size = New System.Drawing.Size(800, 450)
        Me.HistoryViewer.TabIndex = 0
        '
        'cbocustomer
        '
        Me.cbocustomer.BackColor = System.Drawing.Color.White
        Me.cbocustomer.BorderRadius = 15
        Me.cbocustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbocustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocustomer.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbocustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbocustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbocustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbocustomer.ItemHeight = 30
        Me.cbocustomer.Location = New System.Drawing.Point(16, 71)
        Me.cbocustomer.Name = "cbocustomer"
        Me.cbocustomer.Size = New System.Drawing.Size(166, 36)
        Me.cbocustomer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'TrackOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbocustomer)
        Me.Controls.Add(Me.HistoryViewer)
        Me.Name = "TrackOrder"
        Me.Text = "TrackOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HistoryViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbocustomer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
