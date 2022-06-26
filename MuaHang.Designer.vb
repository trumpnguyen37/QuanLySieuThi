<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MuaHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MuaHang))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.ViewSanPham = New System.Windows.Forms.DataGridView()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.mailText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sdtText = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiaChiTXT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameTXT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnThemHoaDon = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtChucVu = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSDT = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnThemSP = New System.Windows.Forms.Button()
        Me.btnBangBieu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton5 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbTSP = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1241, 96)
        Me.Panel2.TabIndex = 10
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(451, 27)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(235, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "MUA SẢN PHẨM"
        '
        'ViewSanPham
        '
        Me.ViewSanPham.AllowUserToAddRows = False
        Me.ViewSanPham.AllowUserToDeleteRows = False
        Me.ViewSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewSanPham.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewSanPham.Location = New System.Drawing.Point(457, 179)
        Me.ViewSanPham.Name = "ViewSanPham"
        Me.ViewSanPham.RowHeadersWidth = 51
        Me.ViewSanPham.RowTemplate.Height = 24
        Me.ViewSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewSanPham.Size = New System.Drawing.Size(772, 247)
        Me.ViewSanPham.TabIndex = 11
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(907, 111)
        Me.TimBtn.Name = "TimBtn"
        Me.TimBtn.Size = New System.Drawing.Size(152, 46)
        Me.TimBtn.TabIndex = 42
        Me.TimBtn.Text = "TÌM"
        Me.TimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TimBtn.UseVisualStyleBackColor = False
        '
        'searchText
        '
        Me.searchText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.searchText.Location = New System.Drawing.Point(457, 122)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(428, 27)
        Me.searchText.TabIndex = 41
        '
        'mailText
        '
        Me.mailText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.mailText.Location = New System.Drawing.Point(959, 678)
        Me.mailText.Name = "mailText"
        Me.mailText.Size = New System.Drawing.Size(270, 27)
        Me.mailText.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(868, 680)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 19)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "E-mail:"
        '
        'sdtText
        '
        Me.sdtText.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sdtText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.sdtText.Location = New System.Drawing.Point(957, 630)
        Me.sdtText.Name = "sdtText"
        Me.sdtText.Size = New System.Drawing.Size(272, 27)
        Me.sdtText.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(866, 632)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "SĐT:"
        '
        'DiaChiTXT
        '
        Me.DiaChiTXT.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiaChiTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DiaChiTXT.Location = New System.Drawing.Point(957, 580)
        Me.DiaChiTXT.Name = "DiaChiTXT"
        Me.DiaChiTXT.Size = New System.Drawing.Size(272, 27)
        Me.DiaChiTXT.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(866, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 19)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Địa chỉ:"
        '
        'nameTXT
        '
        Me.nameTXT.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameTXT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.nameTXT.Location = New System.Drawing.Point(957, 530)
        Me.nameTXT.Name = "nameTXT"
        Me.nameTXT.Size = New System.Drawing.Size(270, 27)
        Me.nameTXT.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(866, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Họ tên:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(864, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 32)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Thông tin khách hàng:"
        '
        'btnThemHoaDon
        '
        Me.btnThemHoaDon.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnThemHoaDon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemHoaDon.ForeColor = System.Drawing.SystemColors.Window
        Me.btnThemHoaDon.Location = New System.Drawing.Point(1007, 727)
        Me.btnThemHoaDon.Name = "btnThemHoaDon"
        Me.btnThemHoaDon.Size = New System.Drawing.Size(164, 56)
        Me.btnThemHoaDon.TabIndex = 52
        Me.btnThemHoaDon.Text = "Thêm hóa đơn"
        Me.btnThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThemHoaDon.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(358, 453)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(265, 32)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Thông tin sản phẩm:"
        '
        'txtMaHD
        '
        Me.txtMaHD.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaHD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaHD.Location = New System.Drawing.Point(487, 540)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(268, 27)
        Me.txtMaHD.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(360, 543)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 19)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Mã hóa đơn:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(12, 453)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(285, 32)
        Me.Label21.TabIndex = 86
        Me.Label21.Text = "Nhân viên thanh toán:"
        '
        'txtChucVu
        '
        Me.txtChucVu.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChucVu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtChucVu.Location = New System.Drawing.Point(103, 664)
        Me.txtChucVu.Name = "txtChucVu"
        Me.txtChucVu.Size = New System.Drawing.Size(194, 27)
        Me.txtChucVu.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 668)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Chức vụ:"
        '
        'txtSDT
        '
        Me.txtSDT.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtSDT.Location = New System.Drawing.Point(103, 727)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(194, 27)
        Me.txtSDT.TabIndex = 92
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(14, 735)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 19)
        Me.Label22.TabIndex = 91
        Me.Label22.Text = "SĐT:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(103, 603)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(194, 27)
        Me.txtName.TabIndex = 90
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(14, 606)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 19)
        Me.Label23.TabIndex = 89
        Me.Label23.Text = "Họ tên:"
        '
        'txtMaNV
        '
        Me.txtMaNV.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaNV.Location = New System.Drawing.Point(103, 543)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(194, 27)
        Me.txtMaNV.TabIndex = 88
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(14, 546)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 19)
        Me.Label24.TabIndex = 87
        Me.Label24.Text = "Mã NV:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(323, 453)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(12, 330)
        Me.ProgressBar1.TabIndex = 95
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(801, 453)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(12, 330)
        Me.ProgressBar2.TabIndex = 96
        '
        'txtMaSP
        '
        Me.txtMaSP.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMaSP.Location = New System.Drawing.Point(487, 603)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(268, 27)
        Me.txtMaSP.TabIndex = 98
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(360, 606)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 19)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Mã sản phẩm:"
        '
        'txtSL
        '
        Me.txtSL.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtSL.Location = New System.Drawing.Point(487, 665)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(268, 27)
        Me.txtSL.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(360, 668)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 19)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "Số lượng:"
        '
        'btnThemSP
        '
        Me.btnThemSP.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnThemSP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemSP.ForeColor = System.Drawing.SystemColors.Window
        Me.btnThemSP.Location = New System.Drawing.Point(487, 727)
        Me.btnThemSP.Name = "btnThemSP"
        Me.btnThemSP.Size = New System.Drawing.Size(164, 56)
        Me.btnThemSP.TabIndex = 101
        Me.btnThemSP.Text = "Thêm sản phẩm"
        Me.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnThemSP.UseVisualStyleBackColor = False
        '
        'btnBangBieu
        '
        Me.btnBangBieu.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBangBieu.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBangBieu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBangBieu.Location = New System.Drawing.Point(1077, 111)
        Me.btnBangBieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBangBieu.Name = "btnBangBieu"
        Me.btnBangBieu.Size = New System.Drawing.Size(152, 46)
        Me.btnBangBieu.TabIndex = 102
        Me.btnBangBieu.Text = "BẢNG BIỂU"
        Me.btnBangBieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBangBieu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guna2GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Guna2GroupBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbbTSP)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 332)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bộ lọc"
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2RadioButton5)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightBlue
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(154, 201)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(243, 125)
        Me.Guna2GroupBox2.TabIndex = 59
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.AutoSize = True
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
        '
        'Guna2RadioButton5
        '
        Me.Guna2RadioButton5.AutoSize = True
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
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(25, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 19)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Đơn giá bán:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton3)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightBlue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(152, 73)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(245, 122)
        Me.Guna2GroupBox1.TabIndex = 57
        '
        'Guna2RadioButton4
        '
        Me.Guna2RadioButton4.AutoSize = True
        Me.Guna2RadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton4.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton4.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton4.Location = New System.Drawing.Point(20, 53)
        Me.Guna2RadioButton4.Name = "Guna2RadioButton4"
        Me.Guna2RadioButton4.Size = New System.Drawing.Size(136, 21)
        Me.Guna2RadioButton4.TabIndex = 4
        Me.Guna2RadioButton4.Text = ">= 1 và <= 1000"
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
        Me.Guna2RadioButton3.Location = New System.Drawing.Point(20, 89)
        Me.Guna2RadioButton3.Name = "Guna2RadioButton3"
        Me.Guna2RadioButton3.Size = New System.Drawing.Size(74, 21)
        Me.Guna2RadioButton3.TabIndex = 3
        Me.Guna2RadioButton3.Text = "> 1000"
        Me.Guna2RadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton3.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(19, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 19)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Số lượng còn:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(19, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Tên :"
        '
        'cbbTSP
        '
        Me.cbbTSP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbTSP.FormattingEnabled = True
        Me.cbbTSP.Items.AddRange(New Object() {"Mã sản phẩm"})
        Me.cbbTSP.Location = New System.Drawing.Point(152, 33)
        Me.cbbTSP.Name = "cbbTSP"
        Me.cbbTSP.Size = New System.Drawing.Size(245, 25)
        Me.cbbTSP.TabIndex = 50
        Me.cbbTSP.Text = "Tên sản phẩm"
        '
        'MuaHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1243, 830)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBangBieu)
        Me.Controls.Add(Me.btnThemSP)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtChucVu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnThemHoaDon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mailText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sdtText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiaChiTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nameTXT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.ViewSanPham)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "MuaHang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ViewSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents ViewSanPham As DataGridView
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents mailText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sdtText As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DiaChiTXT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nameTXT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnThemHoaDon As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtChucVu As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSDT As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtMaNV As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSL As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnThemSP As Button
    Friend WithEvents btnBangBieu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbbTSP As ComboBox
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton5 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label13 As Label
End Class
