Imports System.Data.SqlClient
Public Class ThongTinTaiKhoan
    Dim lenh As String
    Dim lenh1 As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Dim TK As BindingManagerBase
    Private Sub ThongTinTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_TK()
        txtMaNV.Enabled = False
        txtLuong.Enabled = False
    End Sub
    Private Sub Xuat_TK()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT tenTK as N'Tài Khoản', matKhau as N'Mật khẩu',dbo.NhanVien.maNV as N'Mã nhân viên',tenNV as N'Tên nhân viên' , SDT as N'Số điện thoại'
        , email as 'E-mail',chucVu as N'Chức vụ',format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
					FROM    dbo.TaiKhoan INNER JOIN
					  dbo.NhanVien   ON dbo.NhanVien.maNV  = dbo.TaiKhoan.maNV
					  and tenTK = '" & Login.tenTK.Text & "'"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("ThongTinTaiKhoan")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewThongTin.DataSource = dttable

        'khoi tao lien ket voi datatable.

        TK = Me.BindingContext(dttable)

    End Sub

    ' Chức năng click vào rows của datagridview
    Private Sub ViewThongTin_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewThongTin.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewThongTin.Rows(e.RowIndex)

        txtTK.Text = selectedGD.Cells(0).Value
        txtMK.Text = selectedGD.Cells(1).Value
        txtMaNV.Text = selectedGD.Cells(2).Value
        txtName.Text = selectedGD.Cells(3).Value
        txtSDT.Text = selectedGD.Cells(4).Value
        txtMail.Text = selectedGD.Cells(5).Value
        txtChucVu.Text = selectedGD.Cells(6).Value
        txtLuong.Text = selectedGD.Cells(7).Value
    End Sub

    'Chức năng cập nhật thông tin tài khoản
    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        If MsgBox("Bạn có muốn sửa không? ", vbYesNo, "CẬP NHẬT") = MsgBoxResult.Yes Then
            If txtTK.Text = "" Or txtMK.Text = "" Or txtMaNV.Text = "" Or txtName.Text = "" Or
                txtSDT.Text = "" Or txtMail.Text = "" Or txtChucVu.Text = "" Or txtLuong.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else

                Dim luong As String
                luong = Convert.ToString(txtLuong.Text)

                lenh = "update  TaiKhoan  
                        set tenTK = N'" & txtTK.Text & "',matKhau = '" & txtMK.Text & "' 
                        where tenTK = '" & txtTK.Text & "'"
                lenh1 = "update  NhanVien  
                        set tenNV =N'" & txtName.Text & "', SDT = N'" & txtSDT.Text & "',email = '" & txtMail.Text & "' ,chucVu = '" & txtChucVu.Text & "'
                        where maNV = '" & txtMaNV.Text & "'
"
                Dim cmd As New SqlCommand(lenh, con)
                Dim cmd1 As New SqlCommand(lenh1, con)
                con.Open()
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                Xuat_TK()
                MsgBox("Cập nhật thành công!")
            End If
        End If
    End Sub


    ' Tìm kiếm cơ bản
    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT tenTK as N'Tài Khoản', matKhau as N'Mật khẩu',NV.maNV as N'Mã nhân viên',tenNV as N'Tên nhân viên' , SDT as N'Số điện thoại', email as 'E-mail'
                                    ,chucVu as N'Chức vụ',format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                                    From TaiKhoan as TK, NhanVien as NV 
                                    WHERE   CONCAT(tenTK, matKhau, NV.maNV, tenNV, SDT, email, chucVu, luong) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewThongTin.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Hide()
        MainForm.cbbTK.Text = "Trung.48.Nhom07"
        MainForm.Show()
    End Sub
End Class