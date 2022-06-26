Imports System.Data.SqlClient
Public Class MuaHang
    Private Sub MuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_TT()
        Xuat_SanPham()
        Xuat_NhanVien()
        Xuat_HoaDon()
    End Sub

    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private WithEvents dsSP As BindingManagerBase
    Private WithEvents dsNV As BindingManagerBase
    Private WithEvents dsMHD As BindingManagerBase


    Private Sub Xuat_SanPham()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("SanPham")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewSanPham.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsSP = Me.BindingContext(dttable)

    End Sub

    Private Sub ViewSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewSanPham.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewSanPham.Rows(e.RowIndex)
        txtMaSP.Text = selectedGD.Cells(0).Value
    End Sub

    Private Sub Xuat_NhanVien()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = " SELECT tenTK as N'Tài Khoản', matKhau as N'Mật khẩu',dbo.NhanVien.maNV as N'Mã nhân viên',tenNV as N'Tên nhân viên' 
                , SDT as N'Số điện thoại', email as 'E-mail',chucVu as N'Chức vụ',format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
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
        Dim dttable As New DataTable("NhanVien")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()

        'khoi tao lien ket voi datatable.

        dsNV = Me.BindingContext(dttable)

        txtMaNV.Text = dsNV.Current("Mã nhân viên")
        txtName.Text = dsNV.Current("Tên nhân viên")
        txtChucVu.Text = dsNV.Current("Chức vụ")
        txtSDT.Text = dsNV.Current("Số điện thoại")
    End Sub

    ' Xuất thông tin hóa đơn để lấy mã hóa đơn max
    Private Sub Xuat_HoaDon()

        Dim lenh As String

        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = " select MAX(maHD) as N'Mã hóa đơn' from HoaDon "
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("HoaDon")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        'khoi tao lien ket voi datatable.

        dsMHD = Me.BindingContext(dttable)


        txtMaHD.Text = dsMHD.Current("Mã hóa đơn")
    End Sub
    Private Sub btnThemHoaDon_Click(sender As Object, e As EventArgs) Handles btnThemHoaDon.Click
        Dim lenh As String
        Dim lenh1 As String
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If nameTXT.Text = "" Or DiaChiTXT.Text = "" Or txtSDT.Text = "" Or
            mailText.Text = "" Then
                MsgBox("Chưa nhập đủ thông tin")
            Else
                lenh = "insert into KhachHang(maKH,tenKH,diaChiKH,SDT,Email) 
                        values(dbo.fn_autoIDKH(),N'" & nameTXT.Text & "',N'" & DiaChiTXT.Text & "','" & txtSDT.Text & "','" & mailText.Text & "')"

                lenh1 = "insert into HoaDon 
                           values (GETDATE(),'" & txtMaNV.Text & "',dbo.makh_max())"

                Dim cmd As New SqlCommand(lenh, con)
                Dim cmd1 As New SqlCommand(lenh1, con)
                con.Open()
                cmd.ExecuteNonQuery()
                cmd1.ExecuteNonQuery()
                con.Close()

                Xuat_HoaDon()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub btnThemSP_Click(sender As Object, e As EventArgs) Handles btnThemSP.Click
        Dim lenh As String
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If txtSL.Text = "" Then
                MsgBox("Chưa nhập đủ thông tin")
            Else
                lenh = "insert into ChiTietHoaDon
                        values ('" & txtMaHD.Text & "','" & txtMaSP.Text & "','" & txtSL.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_HoaDon()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub btnBangBieu_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportMuaHang.Show()
    End Sub

    '' tìm kiếm cơ bản

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From SanPham WHERE CONCAT(maSP, tenSP) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewSanPham.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub
    'Lấy thông tin tên sản phẩm vào cbb
    Private Sub Xuat_TT()
        con.Open()
        Dim strsql As New SqlCommand("select distinct tenSP from SanPham", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader
        cbbTSP.Items.Clear()
        While myreader.Read()
            cbbTSP.Items.Add(myreader("tenSP"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private WithEvents dsTMH As BindingManagerBase
    Private Sub Xuat_TTCV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham 
                Where tenSP like '%" + cbbTSP.Text + "%'"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("MuaHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)

        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewSanPham.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsTMH = Me.BindingContext(dttable)
    End Sub

    Private Sub cbbTSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTSP.SelectedIndexChanged
        Xuat_TTCV()
    End Sub

    ' Hàm tìm kiếm
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Private Sub displayData(sql As String, dtg As DataGridView)
        Try
            con.Open()
            cmd = New SqlCommand
            da = New SqlDataAdapter
            dt = New DataTable

            With cmd
                .Connection = con
                .CommandText = sql
            End With

            With da
                .SelectCommand = cmd
                .Fill(dt)
            End With

            dtg.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Guna2RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton4.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where soLuongCon >= 1 and soLuongCon <= 1000"
        displayData(sql, ViewSanPham)
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton3.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where soLuongCon >1000"
        displayData(sql, ViewSanPham)
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where donGiaBan >= 1000000"
        displayData(sql, ViewSanPham)
    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton5.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá', soLuongCon as N'Số lượng còn'
                From SanPham
				where donGiaBan < 1000000"
        displayData(sql, ViewSanPham)
    End Sub
End Class