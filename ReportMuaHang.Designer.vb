<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportMuaHang
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
        Me.ReportMH = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton5 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportMH
        '
        Me.ReportMH.AutoSize = True
        Me.ReportMH.Location = New System.Drawing.Point(12, 152)
        Me.ReportMH.Name = "ReportMH"
        Me.ReportMH.ServerReport.BearerToken = Nothing
        Me.ReportMH.Size = New System.Drawing.Size(1258, 788)
        Me.ReportMH.TabIndex = 11
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2RadioButton5)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightBlue
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(145, 12)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(243, 125)
        Me.Guna2GroupBox2.TabIndex = 61
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(18, 55)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(94, 21)
        Me.Guna2RadioButton1.TabIndex = 4
        Me.Guna2RadioButton1.Text = ">= 1 triệu"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UseVisualStyleBackColor = False
        '
        'Guna2RadioButton5
        '
        Me.Guna2RadioButton5.AutoSize = True
        Me.Guna2RadioButton5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Guna2RadioButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton5.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton5.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton5.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton5.Location = New System.Drawing.Point(18, 93)
        Me.Guna2RadioButton5.Name = "Guna2RadioButton5"
        Me.Guna2RadioButton5.Size = New System.Drawing.Size(85, 21)
        Me.Guna2RadioButton5.TabIndex = 3
        Me.Guna2RadioButton5.Text = "< 1 triệu"
        Me.Guna2RadioButton5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton5.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton5.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton5.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton5.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Đơn giá bán:"
        '
        'ReportMuaHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ReportMH)
        Me.Name = "ReportMuaHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportMH As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton5 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label13 As Label
End Class
