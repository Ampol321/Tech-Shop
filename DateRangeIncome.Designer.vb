<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateRangeIncome
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
        Me.DateRangeViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DateTimeStart = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateRangeViewer
        '
        Me.DateRangeViewer.ActiveViewIndex = -1
        Me.DateRangeViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateRangeViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateRangeViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateRangeViewer.Location = New System.Drawing.Point(0, 0)
        Me.DateRangeViewer.Name = "DateRangeViewer"
        Me.DateRangeViewer.Size = New System.Drawing.Size(800, 450)
        Me.DateRangeViewer.TabIndex = 0
        '
        'DateTimeStart
        '
        Me.DateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeStart.Location = New System.Drawing.Point(79, 134)
        Me.DateTimeStart.Name = "DateTimeStart"
        Me.DateTimeStart.Size = New System.Drawing.Size(102, 20)
        Me.DateTimeStart.TabIndex = 1
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeEnd.Location = New System.Drawing.Point(79, 185)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(102, 20)
        Me.DateTimeEnd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "End"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'BtnReport
        '
        Me.BtnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.Location = New System.Drawing.Point(55, 224)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(91, 39)
        Me.BtnReport.TabIndex = 4
        Me.BtnReport.Text = "Report"
        Me.BtnReport.UseVisualStyleBackColor = True
        '
        'DateRangeIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimeEnd)
        Me.Controls.Add(Me.DateTimeStart)
        Me.Controls.Add(Me.DateRangeViewer)
        Me.Name = "DateRangeIncome"
        Me.Text = "DateRangeIncome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateRangeViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DateTimeStart As DateTimePicker
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnReport As Button
End Class
