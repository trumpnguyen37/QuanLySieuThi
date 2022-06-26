<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportHoaDon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportHoaDon))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Demo1 = New QuanLiSieuThi.demo1()
        Me.ReportHD = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable1TableAdapter = New QuanLiSieuThi.demo1TableAdapters.DataTable1TableAdapter()
        Me.KhachHangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KhachHangTableAdapter = New QuanLiSieuThi.demo1TableAdapters.KhachHangTableAdapter()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.d2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.d1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Demo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KhachHangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Demo1
        '
        'Demo1
        '
        Me.Demo1.DataSetName = "demo1"
        Me.Demo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportHD
        '
        Me.ReportHD.AutoSize = True
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportHD.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportHD.LocalReport.ReportEmbeddedResource = "QuanLiSieuThi.HoaDon.rdlc"
        Me.ReportHD.Location = New System.Drawing.Point(12, 140)
        Me.ReportHD.Name = "ReportHD"
        Me.ReportHD.ServerReport.BearerToken = Nothing
        Me.ReportHD.Size = New System.Drawing.Size(1258, 800)
        Me.ReportHD.TabIndex = 19
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'KhachHangBindingSource
        '
        Me.KhachHangBindingSource.DataMember = "KhachHang"
        Me.KhachHangBindingSource.DataSource = Me.Demo1
        '
        'KhachHangTableAdapter
        '
        Me.KhachHangTableAdapter.ClearBeforeFill = True
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(313, 42)
        Me.TimBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 47
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(114, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Đến"
        '
        'd2
        '
        Me.d2.Checked = True
        Me.d2.CustomFormat = "dd/MM/yyyy"
        Me.d2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d2.Location = New System.Drawing.Point(12, 78)
        Me.d2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(264, 36)
        Me.d2.TabIndex = 45
        Me.d2.Value = New Date(2022, 6, 18, 4, 40, 6, 229)
        '
        'd1
        '
        Me.d1.Checked = True
        Me.d1.CustomFormat = "dd/MM/yyyy"
        Me.d1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.d1.Location = New System.Drawing.Point(12, 12)
        Me.d1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(264, 36)
        Me.d1.TabIndex = 44
        Me.d1.Value = New Date(2022, 6, 18, 4, 41, 3, 741)
        '
        'ReportHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1282, 953)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.ReportHD)
        Me.Name = "ReportHoaDon"
        Me.Text = "Trung_48_Nhom07"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Demo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KhachHangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportHD As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Demo1 As demo1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As demo1TableAdapters.DataTable1TableAdapter
    Friend WithEvents KhachHangBindingSource As BindingSource
    Friend WithEvents KhachHangTableAdapter As demo1TableAdapters.KhachHangTableAdapter
    Friend WithEvents TimBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents d2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents d1 As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
