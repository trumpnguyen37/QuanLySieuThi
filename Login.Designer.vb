<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.tenTK = New System.Windows.Forms.TextBox()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnDangKy = New System.Windows.Forms.Button()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(85, 42)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(391, 64)
        Me.Panel7.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(76, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 55)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Đăng nhập"
        '
        'passLB
        '
        Me.passLB.AutoSize = True
        Me.passLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLB.ForeColor = System.Drawing.SystemColors.Window
        Me.passLB.Location = New System.Drawing.Point(154, 257)
        Me.passLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.passLB.Name = "passLB"
        Me.passLB.Size = New System.Drawing.Size(91, 23)
        Me.passLB.TabIndex = 8
        Me.passLB.Text = "Mật khẩu"
        '
        'emailLB
        '
        Me.emailLB.AutoSize = True
        Me.emailLB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLB.ForeColor = System.Drawing.SystemColors.Window
        Me.emailLB.Location = New System.Drawing.Point(154, 169)
        Me.emailLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.emailLB.Name = "emailLB"
        Me.emailLB.Size = New System.Drawing.Size(94, 23)
        Me.emailLB.TabIndex = 7
        Me.emailLB.Text = "Tài khoản"
        '
        'matKhau
        '
        Me.matKhau.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matKhau.Location = New System.Drawing.Point(158, 288)
        Me.matKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.matKhau.Name = "matKhau"
        Me.matKhau.Size = New System.Drawing.Size(256, 30)
        Me.matKhau.TabIndex = 6
        Me.matKhau.UseSystemPasswordChar = True
        '
        'tenTK
        '
        Me.tenTK.BackColor = System.Drawing.SystemColors.Window
        Me.tenTK.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tenTK.Location = New System.Drawing.Point(158, 200)
        Me.tenTK.Margin = New System.Windows.Forms.Padding(4)
        Me.tenTK.Name = "tenTK"
        Me.tenTK.Size = New System.Drawing.Size(256, 30)
        Me.tenTK.TabIndex = 5
        '
        'btnDangNhap
        '
        Me.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnDangNhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangNhap.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDangNhap.Location = New System.Drawing.Point(81, 367)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(164, 56)
        Me.btnDangNhap.TabIndex = 9
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDangNhap.UseVisualStyleBackColor = False
        '
        'btnDangKy
        '
        Me.btnDangKy.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnDangKy.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangKy.ForeColor = System.Drawing.SystemColors.Window
        Me.btnDangKy.Location = New System.Drawing.Point(291, 367)
        Me.btnDangKy.Name = "btnDangKy"
        Me.btnDangKy.Size = New System.Drawing.Size(164, 56)
        Me.btnDangKy.TabIndex = 10
        Me.btnDangKy.Text = "Đăng ký"
        Me.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDangKy.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 487)
        Me.Controls.Add(Me.btnDangKy)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.passLB)
        Me.Controls.Add(Me.emailLB)
        Me.Controls.Add(Me.matKhau)
        Me.Controls.Add(Me.tenTK)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "Login"
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
    Friend WithEvents tenTK As TextBox
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents btnDangKy As Button
End Class
