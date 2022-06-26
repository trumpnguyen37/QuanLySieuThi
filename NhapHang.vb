Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhapHang
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub NhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_TT()
        Xuat_NhapHang()
    End Sub

    'Hiển thị db Nhập hàng
    Dim lenh As String
    Private WithEvents dsNH As BindingManagerBase
    Private WithEvents dsNHTT As BindingManagerBase
    Private Sub Xuat_NhapHang()

        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"


        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP "
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("NhapHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewNhapHang.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsNH = Me.BindingContext(dttable)

    End Sub

    '' Nhập hàng ->> cập nhật số lượng cho sản phẩm
    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Thêm hàng") = MsgBoxResult.Yes Then
            If txtMaSP.Text = "" Or txtSL.Text = "" Then
                MsgBox("Vùi lòng đủ thông tin")
            Else
                lenh = "update  SanPham  
                        set soLuongCon = soLuongCon + '" & txtSL.Text & "'
                        where maSP = '" & txtMaSP.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_NhapHang()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub ViewNhapHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewNhapHang.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewNhapHang.Rows(e.RowIndex)
        txtMaSP.Text = selectedGD.Cells(0).Value
    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "select SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập'
                , ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and CONCAT(SP.maSP,SP.tenSP,donGiaNhap,ngayNhapHang) like '%" & valueToSearch & "%' 
                group by SP.maSP,SP.tenSP,donGiaNhap,ngayNhapHang"

        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewNhapHang.DataSource = table
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
        Dim imagebmp As New Bitmap(Me.ViewNhapHang.Width, Me.ViewNhapHang.Height)
        ViewNhapHang.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewNhapHang.Width, Me.ViewNhapHang.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub btnBangBieu_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportNhapHang.Show()
    End Sub


    'Lấy thông tin chức vụ vào cbb
    Private Sub Xuat_TT()
        con.Open()
        Dim strsql As New SqlCommand("select distinct SP.tenSP 
                From PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader

        cbbTSP.Items.Clear()
        While myreader.Read()
            cbbTSP.Items.Add(myreader("tenSP"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private Sub Xuat_TTNH()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select SP.maSP as N'Mã sản phẩm', SP.tenSP as N'Tên sản phẩm', donGiaNhap as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and SP.tenSP like '%" + cbbTSP.Text + "%'"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("NhapHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)

        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewNhapHang.DataSource = dttable
        'khoi tao lien ket voi datatable.
        dsNHTT = Me.BindingContext(dttable)
    End Sub

    Private Sub cbbTenSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTSP.SelectedIndexChanged
        Xuat_TTNH()
    End Sub


    ''Tìm kiếm theo tiền

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
        sql = "select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and  donGiaNhap > 1000000"
        displayData(sql, ViewNhapHang)
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        sql = "select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and  donGiaNhap  <=1000000 and donGiaNhap > 500000"
        displayData(sql, ViewNhapHang)
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        sql = "select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập', ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and  donGiaNhap <=500000"
        displayData(sql, ViewNhapHang)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("select SP.maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', format((donGiaNhap),'##,#\ VNĐ','es-ES') as N'Đơn giá nhập'
                , ngayNhapHang as N'Ngày nhập hàng' 
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and ngayNhapHang between @dt1 and @dt2 order by ngayNhapHang desc", con)
        cmd1.Parameters.Add("dt1", SqlDbType.DateTime).Value = d1.Value
        cmd1.Parameters.Add("dt2", SqlDbType.DateTime).Value = d2.Value
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        ViewNhapHang.DataSource = dt
        con.Close()
    End Sub
End Class