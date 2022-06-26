<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NhapHang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NhapHang))
        Me.ViewNhapHang = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.TimBtn = New System.Windows.Forms.Button()
        Me.searchText = New System.Windows.Forms.TextBox()
        Me.InBtn = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnNhap = New System.Windows.Forms.Button()
        Me.emailLB = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.btnBangBieu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2RadioButton4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbbTSP = New System.Windows.Forms.ComboBox()
        Me.Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.d2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.d1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ViewNhapHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewNhapHang
        '
        Me.ViewNhapHang.AllowUserToAddRows = False
        Me.ViewNhapHang.AllowUserToDeleteRows = False
        Me.ViewNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewNhapHang.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ViewNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewNhapHang.Location = New System.Drawing.Point(326, 193)
        Me.ViewNhapHang.Name = "ViewNhapHang"
        Me.ViewNhapHang.RowHeadersWidth = 51
        Me.ViewNhapHang.RowTemplate.Height = 24
        Me.ViewNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewNhapHang.Size = New System.Drawing.Size(759, 370)
        Me.ViewNhapHang.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Title)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1267, 96)
        Me.Panel2.TabIndex = 8
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Title.Location = New System.Drawing.Point(409, 23)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(358, 32)
        Me.Title.TabIndex = 3
        Me.Title.Text = "DANH SÁCH NHẬP HÀNG"
        '
        'TimBtn
        '
        Me.TimBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TimBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.TimBtn.Image = CType(resources.GetObject("TimBtn.Image"), System.Drawing.Image)
        Me.TimBtn.Location = New System.Drawing.Point(672, 130)
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
        Me.searchText.Location = New System.Drawing.Point(327, 141)
        Me.searchText.Name = "searchText"
        Me.searchText.Size = New System.Drawing.Size(314, 27)
        Me.searchText.TabIndex = 41
        '
        'InBtn
        '
        Me.InBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.InBtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.InBtn.Image = CType(resources.GetObject("InBtn.Image"), System.Drawing.Image)
        Me.InBtn.Location = New System.Drawing.Point(933, 130)
        Me.InBtn.Name = "InBtn"
        Me.InBtn.Size = New System.Drawing.Size(152, 46)
        Me.InBtn.TabIndex = 46
        Me.InBtn.Text = "IN"
        Me.InBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InBtn.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btnNhap
        '
        Me.btnNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNhap.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnNhap.Location = New System.Drawing.Point(729, 627)
        Me.btnNhap.Name = "btnNhap"
        Me.btnNhap.Size = New System.Drawing.Size(152, 46)
        Me.btnNhap.TabIndex = 49
        Me.btnNhap.Text = "NHẬP HÀNG"
        Me.btnNhap.UseVisualStyleBackColor = False
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.emailLB.Location = New System.Drawing.Point(1114, 293)
        Me.emailLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Size = New System.Drawing.Size(91, 23)
        Me.emailLB.TabIndex = 52
        Me.emailLB.Text = "Số lượng:"
        '
        'txtSL
        '
        Me.txtSL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSL.Location = New System.Drawing.Point(1118, 320)
        Me.txtSL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(152, 30)
        Me.txtSL.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1114, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Mã sản phẩm:"
        '
        'txtMaSP
        '
        Me.txtMaSP.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaSP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaSP.Location = New System.Drawing.Point(1118, 220)
        Me.txtMaSP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(152, 30)
        Me.txtMaSP.TabIndex = 53
        '
        'btnBangBieu
        '
        Me.btnBangBieu.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBangBieu.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBangBieu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBangBieu.Location = New System.Drawing.Point(1118, 130)
        Me.btnBangBieu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBangBieu.Name = "btnBangBieu"
        Me.btnBangBieu.Size = New System.Drawing.Size(152, 46)
        Me.btnBangBieu.TabIndex = 55
        Me.btnBangBieu.Text = "BẢNG BIỂU"
        Me.btnBangBieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBangBieu.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.d2)
        Me.GroupBox1.Controls.Add(Me.d1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Guna2GroupBox1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cbbTSP)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 543)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bộ lọc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(138, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Đến"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(6, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 19)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Ngày nhập từ:"
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton1)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2RadioButton2)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightBlue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(122, 120)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(187, 224)
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
        Me.Guna2RadioButton4.Location = New System.Drawing.Point(20, 54)
        Me.Guna2RadioButton4.Name = "Guna2RadioButton4"
        Me.Guna2RadioButton4.Size = New System.Drawing.Size(98, 21)
        Me.Guna2RadioButton4.TabIndex = 4
        Me.Guna2RadioButton4.Text = ">= 1 triệu "
        Me.Guna2RadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton4.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Guna2RadioButton2
        '
        Me.Guna2RadioButton2.AutoSize = True
        Me.Guna2RadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton2.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton2.Location = New System.Drawing.Point(20, 112)
        Me.Guna2RadioButton2.Name = "Guna2RadioButton2"
        Me.Guna2RadioButton2.Size = New System.Drawing.Size(135, 21)
        Me.Guna2RadioButton2.TabIndex = 2
        Me.Guna2RadioButton2.Text = "> 500 <= 1 triệu"
        Me.Guna2RadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 19)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Đơn giá nhập:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 61)
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
        Me.cbbTSP.Location = New System.Drawing.Point(122, 59)
        Me.cbbTSP.Name = "cbbTSP"
        Me.cbbTSP.Size = New System.Drawing.Size(187, 25)
        Me.cbbTSP.TabIndex = 50
        Me.cbbTSP.Text = "Tên sản phẩm"
        '
        'Guna2RadioButton1
        '
        Me.Guna2RadioButton1.AutoSize = True
        Me.Guna2RadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2RadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2RadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2RadioButton1.CheckedState.InnerOffset = -4
        Me.Guna2RadioButton1.Location = New System.Drawing.Point(20, 165)
        Me.Guna2RadioButton1.Name = "Guna2RadioButton1"
        Me.Guna2RadioButton1.Size = New System.Drawing.Size(75, 21)
        Me.Guna2RadioButton1.TabIndex = 5
        Me.Guna2RadioButton1.Text = "<= 500"
        Me.Guna2RadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2RadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2RadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'd2
        '
        Me.d2.Checked = True
        Me.d2.CustomFormat = " "
        Me.d2.FillColor = System.Drawing.Color.LightBlue
        Me.d2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.d2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d2.Location = New System.Drawing.Point(10, 490)
        Me.d2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(299, 36)
        Me.d2.TabIndex = 61
        Me.d2.Value = New Date(2022, 6, 18, 0, 39, 24, 706)
        '
        'd1
        '
        Me.d1.Checked = True
        Me.d1.CustomFormat = "dd/MM/yyyy"
        Me.d1.FillColor = System.Drawing.Color.LightBlue
        Me.d1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.d1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d1.Location = New System.Drawing.Point(10, 407)
        Me.d1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.d1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(299, 36)
        Me.d1.TabIndex = 60
        Me.d1.Value = New Date(2022, 6, 18, 0, 39, 24, 706)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(327, 629)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 46)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "OK"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'NhapHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1271, 700)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBangBieu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.emailLB)
        Me.Controls.Add(Me.txtSL)
        Me.Controls.Add(Me.btnNhap)
        Me.Controls.Add(Me.InBtn)
        Me.Controls.Add(Me.TimBtn)
        Me.Controls.Add(Me.searchText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ViewNhapHang)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "NhapHang"
        Me.Text = "Trung_48_Nhom07"
        CType(Me.ViewNhapHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewNhapHang As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Title As Label
    Friend WithEvents TimBtn As Button
    Friend WithEvents searchText As TextBox
    Friend WithEvents InBtn As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnNhap As Button
    Friend WithEvents emailLB As Label
    Friend WithEvents txtSL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents btnBangBieu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2RadioButton4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbbTSP As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents d2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents d1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Button1 As Button
End Class
