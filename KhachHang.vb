Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient

Public Class KhachHang
    Dim lenh As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()
        maKHText.Enabled = False
    End Sub

    Private Sub KhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_TTDC()
        Xuat_TTTKH()
        Load_Data()
        Xuat_dsKH()
    End Sub

    'Hiển thị db 

    Private WithEvents dsKH As BindingManagerBase
    Private Sub Xuat_dsKH()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select maKH as N'Mã khách hàng', tenKH as N'Tên khách hàng', diaChiKH as N'Địa chỉ', SDT as N'Số điện thoại', Email as 'E-mail' 
                from KhachHang
                "
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("KhachHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)
        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewKhachHang.DataSource = dttable
        'khoi tao lien ket voi datatable.
        dsKH = Me.BindingContext(dttable)
    End Sub

    'clock row trong ViewKhachHang có thể hiện thị
    Private Sub ViewKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewKhachHang.CellClick

        Dim selectedGD As DataGridViewRow
        selectedGD = ViewKhachHang.Rows(e.RowIndex)
        maKHText.Text = selectedGD.Cells(0).Value
        nameText.Text = selectedGD.Cells(1).Value
        dChiText.Text = selectedGD.Cells(2).Value
        sdtText.Text = selectedGD.Cells(3).Value
        mailText.Text = selectedGD.Cells(4).Value

    End Sub



    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maKHText.Text = ""
        nameText.Text = ""
        dChiText.Text = ""
        sdtText.Text = ""
        mailText.Text = ""


    End Sub

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If nameText.Text = "" Or dChiText.Text = "" Or
            sdtText.Text = "" Or mailText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "insert into KhachHang(maKH,tenKH, diaChiKH, SDT, Email) values(dbo.fn_autoIDKH(),N'" & nameText.Text & "',N'" & dChiText.Text & "','" & sdtText.Text & "','" & mailText.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsKH()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không? ", vbYesNo, "Đã sửa") = MsgBoxResult.Yes Then
            If maKHText.Text = "" Or nameText.Text = "" Or dChiText.Text = "" Or
            sdtText.Text = "" Or mailText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "update  KhachHang  set tenKH = N'" & nameText.Text & "',diaChiKH = N'" & dChiText.Text & "',SDT = '" & sdtText.Text & "',Email = '" & mailText.Text & "' where maKH = '" & maKHText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsKH()
                MsgBox("Cập nhật thành công!")
            End If
        End If
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        If MsgBox("Bạn có muốn xóa không? ", vbYesNo, "Đã xóa") = MsgBoxResult.Yes Then
            If maKHText.Text = "" Or nameText.Text = "" Or dChiText.Text = "" Or
            sdtText.Text = "" Or mailText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "delete  KhachHang  where maKH = '" & maKHText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsKH()
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub


    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From KhachHang WHERE CONCAT(tenKH, diaChiKH, Email) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewKhachHang.DataSource = table
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

    Private Sub InBtn_Click(sender As Object, e As EventArgs) Handles InBtn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewKhachHang.Width, Me.ViewKhachHang.Height)
        ViewKhachHang.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewKhachHang.Width, Me.ViewKhachHang.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub btnBangBieu_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportKhachHang.Show()
    End Sub


    ''
    'Lấy thông tin tên khách hàng vào cbb
    Private Sub Xuat_TTTKH()
        con.Open()
        Dim strsql As New SqlCommand("select distinct tenKH from KhachHang", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader
        cbbTKH.Items.Clear()
        While myreader.Read()
            cbbTKH.Items.Add(myreader("tenKH"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private WithEvents dsTTKH As BindingManagerBase
    Private Sub Xuat_TTCV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select maKH as N'Mã khách hàng', tenKH as N'Tên khách hàng', diaChiKH as N'Địa chỉ', SDT as N'Số điện thoại', Email as 'E-mail' 
                from KhachHang
                Where tenKH like '%" + cbbTKH.Text + "%'"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("KhachHang")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)

        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewKhachHang.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsTTKH = Me.BindingContext(dttable)
    End Sub

    ''
    'Lấy thông tin địa chỉ KH vào cbb
    Private Sub Xuat_TTDC()
        con.Open()
        Dim strsql As New SqlCommand("select distinct diaChiKH from KhachHang", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader
        cbbDC.Items.Clear()
        While myreader.Read()
            cbbDC.Items.Add(myreader("diaChiKH"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private WithEvents dsTDC As BindingManagerBase
    Private Sub Xuat_TTDCKH()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select maKH as N'Mã khách hàng', tenKH as N'Tên khách hàng', diaChiKH as N'Địa chỉ', SDT as N'Số điện thoại', Email as 'E-mail' 
                from KhachHang
                Where diaChiKH like '%" + cbbDC.Text + "%'"
        'Khai báo đối tượng Command dùng để thực hiện câu lệnh truy vấn
        Dim cmd As New SqlCommand(lenh, con)
        'Trước khi đọc cần mở kết nối ra
        con.Open()
        'Sử dụng phương thức ExecuteReader để đọc và trả về cho đối tượng DataReader
        Dim bang_doc As SqlDataReader = cmd.ExecuteReader
        'Khai báo DataTable để nhận kết quả là các dòng đọc được
        Dim dttable As New DataTable("DiaChi")
        'Sử dụng phương thức Load và gởi vào DataReader để bắt đầu đọc các dòng ra
        dttable.Load(bang_doc, LoadOption.OverwriteChanges)

        'Sau khi đọc cần đóng kết nối lại
        con.Close()
        ViewKhachHang.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsTDC = Me.BindingContext(dttable)
    End Sub

    Private Sub cbbTKH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTKH.SelectedIndexChanged
        Xuat_TTCV()
    End Sub

    Private Sub cbbDC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbDC.SelectedIndexChanged
        Xuat_TTDCKH()
    End Sub
End Class