<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportSanPham
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
        Me.ReportSP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportSP
        '
        Me.ReportSP.Location = New System.Drawing.Point(10, 224)
        Me.ReportSP.Name = "ReportSP"
        Me.ReportSP.ServerReport.BearerToken = Nothing
        Me.ReportSP.Size = New System.Drawing.Size(1260, 717)
        Me.ReportSP.TabIndex = 0
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton3)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightBlue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(162, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(387, 191)
        Me.Guna2GroupBox1.TabIndex = 59
        '
        'Guna2RadioButton4
        '
        Me.Guna2RadioButton4.AutoSize = True
        Me.Guna2RadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton4.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton4.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton4.Location = New System.Drawing.Point(16, 54)
        Me.Guna2RadioButton4.Name = "Guna2RadioButton4"
        Me.Guna2RadioButton4.Size = New System.Drawing.Size(128, 21)
        Me.Guna2RadioButton4.TabIndex = 4
        Me.Guna2RadioButton4.Text = ">= 1 và <= 500"
        Me.Guna2RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton4.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RadioButton3
        '
        Me.Guna2RadioButton3.AutoSize = True
        Me.Guna2RadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton3.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton3.Location = New System.Drawing.Point(16, 151)
        Me.Guna2RadioButton3.Name = "Guna2RadioButton3"
        Me.Guna2RadioButton3.Size = New System.Drawing.Size(74, 21)
        Me.Guna2RadioButton3.TabIndex = 3
        Me.Guna2RadioButton3.Text = "> 1000"
        Me.Guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton3.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(16, 102)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(152, 21)
        Me.Guna2RadioButton2.TabIndex = 2
        Me.Guna2RadioButton2.Text = ">= 500 và <= 1000"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 19)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Số lượng còn:"
        '
        'ReportSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ReportSP)
        Me.Name = "ReportSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportSP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label6 As Label
End Class
