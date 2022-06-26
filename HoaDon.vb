Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class HoaDon
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()

        txtMaHD.Enabled = False
    End Sub
    Private Sub HoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_TTKH()
        Xuat_HoaDon()
    End Sub

    'Hiển thị db Hóa Đơn
    Private WithEvents dsHD As BindingManagerBase
    Private Sub Xuat_HoaDon()

        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"

        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng'
                ,SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
                , format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = '" & Login.tenTK.Text & "'
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"
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
        ViewHD.DataSource = dttable
        'khoi tao lien ket voi datatable.
        dsHD = Me.BindingContext(dttable)



    End Sub




    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán'
                            ,KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
                            , format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = '" & Login.tenTK.Text & "' and CONCAT(HD.maHD, KH.tenKH, NV.tenNV) like '%" & valueToSearch & "%'
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"


        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewHD.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewHD.Width, Me.ViewHD.Height)
        ViewHD.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewHD.Width, Me.ViewHD.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub ViewHoaDon(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    ' Click vào row ở view Hóa Đơn

    Private Sub CellClickHoaDon(sender As Object, e As DataGridViewCellEventArgs) Handles ViewHD.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewHD.Rows(e.RowIndex)
        txtMaHD.Text = selectedGD.Cells(0).Value
        txtTenKH.Text = selectedGD.Cells(3).Value
        txtDateHD.Text = selectedGD.Cells(1).Value
        txtNV.Text = selectedGD.Cells(2).Value
        txtMaSP.Text = selectedGD.Cells(4).Value
        txtTT.Text = selectedGD.Cells(7).Value

    End Sub

    Private Sub btnBangBieu_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportHoaDon.Show()
    End Sub

    ''
    'Lấy thông tin tên KH vào cbb
    Private Sub Xuat_TTKH()
        con.Open()
        Dim strsql As New SqlCommand("select distinct KH.tenKH 
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = '" & Login.tenTK.Text & "'
                GROUP BY KH.tenKH", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader
        cbbTKH.Items.Clear()
        While myreader.Read()
            cbbTKH.Items.Add(myreader("tenKH"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private WithEvents dsTKH As BindingManagerBase
    Private Sub Xuat_TTTKH()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng'
,SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán'
,format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = '" & Login.tenTK.Text & "' and tenKH like '%" + cbbTKH.Text + "%'
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"

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
        ViewHD.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsTKH = Me.BindingContext(dttable)
    End Sub



    Private Sub cbbTKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTKH.SelectedIndexChanged
        Xuat_TTTKH()
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
        sql = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán'
,KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
, format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' and soLuongDat >=1  and	soLuongDat< 1000
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"
        displayData(sql, ViewHD)
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton3.CheckedChanged
        sql = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán'
,KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
, format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' and soLuongDat >=1000
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan"
        displayData(sql, ViewHD)
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        sql = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán'
,KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
, format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' 
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan
				Having sum(CT.soLuongDat * SP.donGiaBan) >= 500000"
        displayData(sql, ViewHD)
    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton5.CheckedChanged
        sql = "select HD.maHD as N'Mã hóa đơn',HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán'
,KH.tenKH as N'Tên khách hàng',SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt'
, format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán',format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV
		                and tenTK = 'tuan' 
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan
				Having sum(CT.soLuongDat * SP.donGiaBan) < 500000"
        displayData(sql, ViewHD)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("select HD.maHD as N'Mã hóa đơn'
                ,HD.ngayTaoHD as N'Ngày tạo hóa đơn',NV.tenNV as N'Nhân viên thanh toán',KH.tenKH as N'Tên khách hàng'
                ,SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm',CT.soLuongDat as N'Số lượng đặt', format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as N'Đơn giá bán'
                ,format(sum(CT.soLuongDat * SP.donGiaBan),'##,#\ VNĐ','es-ES') as N'Thành tiền'  
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV and ngayTaoHD between @dt1 and @dt2 
		                and tenTK = '" & Login.tenTK.Text & "'
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan ", con)
        cmd1.Parameters.Add("dt1", SqlDbType.DateTime).Value = d1.Value
        cmd1.Parameters.Add("dt2", SqlDbType.DateTime).Value = d2.Value
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        ViewHD.DataSource = dt
        con.Close()
    End Sub
End Class