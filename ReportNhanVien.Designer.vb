<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportNhanVien
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
        Me.ReportNV = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbCV = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ReportNV
        '
        Me.ReportNV.AutoSize = True
        Me.ReportNV.Location = New System.Drawing.Point(12, 76)
        Me.ReportNV.Name = "ReportNV"
        Me.ReportNV.ServerReport.BearerToken = Nothing
        Me.ReportNV.Size = New System.Drawing.Size(1258, 865)
        Me.ReportNV.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Chức vụ :"
        '
        'cbbCV
        '
        Me.cbbCV.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbCV.FormattingEnabled = True
        Me.cbbCV.Items.AddRange(New Object() {"Mã sản phẩm"})
        Me.cbbCV.Location = New System.Drawing.Point(110, 12)
        Me.cbbCV.Name = "cbbCV"
        Me.cbbCV.Size = New System.Drawing.Size(148, 25)
        Me.cbbCV.TabIndex = 54
        Me.cbbCV.Text = "Chức vụ"
        '
        'ReportNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbbCV)
        Me.Controls.Add(Me.ReportNV)
        Me.Name = "ReportNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportNV As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbCV As ComboBox
End Class
