<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangKy
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.passLB = New System.Windows.Forms.Label()
        Me.emailLB = New System.Windows.Forms.Label()
        Me.matKhau = New System.Windows.Forms.TextBox()
        Me.taiKhoan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nhapLaiMK = New System.Windows.Forms.TextBox()
        Me.btnQuayLai = New System.Windows.Forms.Button()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(103, 46)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(391, 64)
        Me.Panel7.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(76, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 55)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Đăng ký"
        '
        'passLB
        '
        Me.passLB.AutoSize = True
        Me.passLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLB.ForeColor = System.Drawing.SystemColors.Window
        Me.passLB.Location = New System.Drawing.Point(164, 242)
        Me.passLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passLB.Name = "passLB"
        Me.passLB.Size = New System.Drawing.Size(91, 23)
        Me.passLB.TabIndex = 12
        Me.passLB.Text = "Mật khẩu"
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.SystemColors.Window
        Me.emailLB.Location = New System.Drawing.Point(164, 154)
        Me.emailLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Size = New System.Drawing.Size(94, 23)
        Me.emailLB.TabIndex = 11
        Me.emailLB.Text = "Tài khoản"
        '
        'matKhau
        '
        Me.matKhau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matKhau.Location = New System.Drawing.Point(168, 273)
        Me.matKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.matKhau.Name = "matKhau"
        Me.matKhau.Size = New System.Drawing.Size(256, 30)
        Me.matKhau.TabIndex = 10
        Me.matKhau.UseSystemPasswordChar = True
        '
        'taiKhoan
        '
        Me.taiKhoan.BackColor = System.Drawing.SystemColors.Window
        Me.taiKhoan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taiKhoan.Location = New System.Drawing.Point(168, 185)
        Me.taiKhoan.Margin = New System.Windows.Forms.Padding(4)
        Me.taiKhoan.Name = "taiKhoan"
        Me.taiKhoan.Size = New System.Drawing.Size(256, 30)
        Me.taiKhoan.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(164, 328)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nhập lại mật khẩu"
        '
        'nhapLaiMK
        '
        Me.nhapLaiMK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nhapLaiMK.Location = New System.Drawing.Point(168, 359)
        Me.nhapLaiMK.Margin = New System.Windows.Forms.Padding(4)
        Me.nhapLaiMK.Name = "nhapLaiMK"
        Me.nhapLaiMK.Size = New System.Drawing.Size(256, 30)
        Me.nhapLaiMK.TabIndex = 13
        Me.nhapLaiMK.UseSystemPasswordChar = True
        '
        'btnQuayLai
        '
        Me.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnQuayLai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuayLai.ForeColor = System.Drawing.SystemColors.Window
        Me.btnQuayLai.Location = New System.Drawing.Point(311, 506)
        Me.btnQuayLai.Name = "btnQuayLai"
        Me.btnQuayLai.Size = New System.Drawing.Size(164, 56)
        Me.btnQuayLai.TabIndex = 16
        Me.btnQuayLai.Text = "Quay lại"
        Me.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuayLai.UseVisualStyleBackColor = False
        '
        'btnDangKy
        '
        Me.btnDangKy.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnDangKy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDangKy.Location = New System.Drawing.Point(101, 506)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(164, 56)
        Me.btnDangKy.TabIndex = 15
        Me.btnDangKy.Text = "Đăng ký"
        Me.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDangKy.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(164, 424)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Mã nhân viên"
        '
        'txtMaNV
        '
        Me.txtMaNV.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaNV.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaNV.Location = New System.Drawing.Point(168, 451)
        Me.txtMaNV.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(256, 30)
        Me.txtMaNV.TabIndex = 19
        '
        'DangKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(588, 595)
        Me.Controls.Add(Me.txtMaNV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnQuayLai)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nhapLaiMK)
        Me.Controls.Add(Me.passLB)
        Me.Controls.Add(Me.emailLB)
        Me.Controls.Add(Me.matKhau)
        Me.Controls.Add(Me.taiKhoan)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "DangKy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trung_48_Nhom07"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents passLB As Label
    Friend WithEvents emailLB As Label
    Friend WithEvents matKhau As TextBox
    Friend WithEvents taiKhoan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nhapLaiMK As TextBox
    Friend WithEvents btnQuayLai As Button
    Friend WithEvents btnDangKy As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaNV As TextBox
End Class
