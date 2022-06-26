Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class NhanVien
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()

        maNVText.Enabled = False
    End Sub
    Private Sub NhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_TT()
        Xuat_dsNV()

    End Sub


    'Hiển thị db NhânViên

    Private WithEvents dsNV As BindingManagerBase
    Private WithEvents dsNVVC As BindingManagerBase
    Dim lenh As String
    Private Sub Xuat_dsNV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                From NhanVien  "
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
        ViewNhanVien.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsNV = Me.BindingContext(dttable)

        maNVText.Text = dsNV.Current("Mã nhân viên")
        nameText.Text = dsNV.Current("Tên nhân viên")
        sdtText.Text = dsNV.Current("Số điện thoại")
        mailText.Text = dsNV.Current("Email")
        chucVuText.Text = dsNV.Current("Chức vụ")
        luongText.Text = dsNV.Current("Lương")




    End Sub

    'clock row trong ViewKhachHang có thể hiện thị
    Private Sub ViewNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewNhanVien.CellClick
        Dim selectedGD As DataGridViewRow
        selectedGD = ViewNhanVien.Rows(e.RowIndex)
        maNVText.Text = selectedGD.Cells(0).Value
        nameText.Text = selectedGD.Cells(1).Value
        sdtText.Text = selectedGD.Cells(2).Value
        mailText.Text = selectedGD.Cells(3).Value
        chucVuText.Text = selectedGD.Cells(4).Value
        luongText.Text = selectedGD.Cells(5).Value
    End Sub



    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maNVText.Text = ""
        nameText.Text = ""
        sdtText.Text = ""
        mailText.Text = ""
        chucVuText.Text = ""
        luongText.Text = ""
    End Sub

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If nameText.Text = "" Or sdtText.Text = "" Or
            mailText.Text = "" Or chucVuText.Text = "" Or luongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "insert into NhanVien(maNV,tenNV, SDT, email, chucVu,luong) 
                        values(dbo.fn_autoIDNV(),N'" & nameText.Text & "',N'" & sdtText.Text & "','" & mailText.Text & "',N'" & chucVuText.Text & "','" & luongText.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsNV()
                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không? ", vbYesNo, "Đã cập nhật") = MsgBoxResult.Yes Then
            If maNVText.Text = "" Or nameText.Text = "" Or sdtText.Text = "" Or
            mailText.Text = "" Or chucVuText.Text = "" Or luongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "update  NhanVien 
                        set tenNV = N'" & nameText.Text & "',SDT = N'" & sdtText.Text & "',email = '" & mailText.Text & "',chucVu = N'" & chucVuText.Text & "',luong = '" & luongText.Text & "' 
                        where maNV = '" & maNVText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsNV()
                MsgBox("Cập nhật thành công!")
            End If
        End If
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        If MsgBox("Bạn có muốn xóa không? ", vbYesNo, "Đã xóa") = MsgBoxResult.Yes Then
            If maNVText.Text = "" Or nameText.Text = "" Or sdtText.Text = "" Or
            mailText.Text = "" Or chucVuText.Text = "" Or luongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "delete  NhanVien  where maNV = '" & maNVText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_dsNV()
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub

    'Tìm kiếm theo combobox
    Private Sub CBB()
        con.Open()
        Dim filterCBB As New SqlCommand("")
    End Sub

    Public Sub FilterData(valueToSearch As String)


        Dim searchQuery As String = "SELECT * From NhanVien WHERE CONCAT(maNV, tenNV, email, chucVu) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        ViewNhanVien.DataSource = table



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
        Dim imagebmp As New Bitmap(Me.ViewNhanVien.Width, Me.ViewNhanVien.Height)
        ViewNhanVien.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewNhanVien.Width, Me.ViewNhanVien.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub btnBangBieu_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportNhanVien.Show()
    End Sub


    'Lấy thông tin chức vụ vào cbb
    Private Sub Xuat_TT()
        con.Open()
        Dim strsql As New SqlCommand("select distinct chucVu from NhanVien", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader
        cbbCV.Items.Clear()
        While myreader.Read()
            cbbCV.Items.Add(myreader("chucVu"))
        End While
        con.Close()
    End Sub

    '' Code xuất thông tin theo chức vụ
    Private Sub Xuat_TTCV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                From NhanVien  
                Where chucVu like '%" + cbbCV.Text + "%'"
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
        ViewNhanVien.DataSource = dttable
        'khoi tao lien ket voi datatable.

        dsNVVC = Me.BindingContext(dttable)
    End Sub


    Private Sub cbbCV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCV.SelectedIndexChanged
        Xuat_TTCV()
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

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        sql = "SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                From NhanVien
                Where luong >= 5000000"
        displayData(sql, ViewNhanVien)
    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton5.CheckedChanged
        sql = "SELECT maNV as N'Mã nhân viên', tenNV as N'Tên nhân viên', SDT as N'Số điện thoại', email as 'Email', chucVu as N'Chức vụ', format((luong),'##,#\ VNĐ','es-ES') as N'Lương'
                From NhanVien
                Where luong < 5000000"
        displayData(sql, ViewNhanVien)
    End Sub
End Class