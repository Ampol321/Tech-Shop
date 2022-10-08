<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OngoingOrdersvb
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
        Me.OngoingViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'OngoingViewer
        '
        Me.OngoingViewer.ActiveViewIndex = -1
        Me.OngoingViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OngoingViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.OngoingViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OngoingViewer.Location = New System.Drawing.Point(0, 0)
        Me.OngoingViewer.Name = "OngoingViewer"
        Me.OngoingViewer.Size = New System.Drawing.Size(800, 450)
        Me.OngoingViewer.TabIndex = 0
        '
        'OngoingOrdersvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OngoingViewer)
        Me.Name = "OngoingOrdersvb"
        Me.Text = "OngoingOrdersvb"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OngoingViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
