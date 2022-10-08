<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CanceledOrders
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
        Me.CanceledViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CanceledViewer
        '
        Me.CanceledViewer.ActiveViewIndex = -1
        Me.CanceledViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CanceledViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CanceledViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CanceledViewer.Location = New System.Drawing.Point(0, 0)
        Me.CanceledViewer.Name = "CanceledViewer"
        Me.CanceledViewer.Size = New System.Drawing.Size(800, 450)
        Me.CanceledViewer.TabIndex = 0
        '
        'CanceledOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CanceledViewer)
        Me.Name = "CanceledOrders"
        Me.Text = "CanceledOrders"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CanceledViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
