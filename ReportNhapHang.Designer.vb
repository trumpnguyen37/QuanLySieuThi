<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportNhapHang
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportNhapHang))
        Me.ReportNH = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.d1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.d2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNhapHang = New QuanLiSieuThi.DSNhapHang()
        Me.DataTable1TableAdapter = New QuanLiSieuThi.DSNhapHangTableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNhapHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportNH
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportNH.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportNH.LocalReport.ReportEmbeddedResource = "QuanLiSieuThi.NhapHang.rdlc"
        Me.ReportNH.Location = New System.Drawing.Point(16, 140)
        Me.ReportNH.Name = "ReportNH"
        Me.ReportNH.ServerReport.BearerToken = Nothing
        Me.ReportNH.Size = New System.Drawing.Size(1254, 801)
        Me.ReportNH.TabIndex = 14
        '
        'd1
        '
        Me.d1.Checked = True
        Me.d1.CustomFormat = "dd/MM/yyyy"
        Me.d1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(74, 12)
        Me.d1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(264, 36)
        Me.d1.TabIndex = 15
        Me.d1.Value = New Date(2022, 6, 18, 4, 41, 3, 741)
        '
        'd2
        '
        Me.d2.Checked = True
        Me.d2.CustomFormat = "dd/MM/yyyy"
        Me.d2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d2.Location = New System.Drawing.Point(74, 78)
        Me.d2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(264, 36)
        Me.d2.TabIndex = 16
        Me.d2.Value = New Date(2022, 6, 18, 4, 40, 6, 229)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(176, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Đến"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(375, 42)
        Me.TimBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 43
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DSNhapHang
        '
        'DSNhapHang
        '
        Me.DSNhapHang.DataSetName = "DSNhapHang"
        Me.DSNhapHang.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'ReportNhapHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.ReportNH)
        Me.Name = "ReportNhapHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNhapHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportNH As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents d1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents d2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DSNhapHang As DSNhapHang
    Friend WithEvents DataTable1TableAdapter As DSNhapHangTableAdapters.DataTable1TableAdapter
End Class
