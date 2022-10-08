<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceivedOrders
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
        Me.ReceivedViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'ReceivedViewer
        '
        Me.ReceivedViewer.ActiveViewIndex = -1
        Me.ReceivedViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReceivedViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.ReceivedViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReceivedViewer.Location = New System.Drawing.Point(0, 0)
        Me.ReceivedViewer.Name = "ReceivedViewer"
        Me.ReceivedViewer.Size = New System.Drawing.Size(800, 450)
        Me.ReceivedViewer.TabIndex = 0
        '
        'ReceivedOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReceivedViewer)
        Me.Name = "ReceivedOrders"
        Me.Text = "ReceivedOrders"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReceivedViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
