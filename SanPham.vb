Imports System.Data.OleDb
Imports System.Data
Imports System.Data.SqlClient
Public Class SanPham
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub Load_Data()

        maSPText.Enabled = False
    End Sub
    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
        Xuat_TT()
        Xuat_SanPham()


    End Sub


    'Hiển thị db NhânViên
    Dim lenh As String
    Private WithEvents dsSP As BindingManagerBase
    Private Sub Xuat_SanPham()
        Dim lenh As String

        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá bán', soLuongCon as N'Số lượng còn'
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


        maSPText.Text = dsSP.Current("Mã sản phẩm")
        nameText.Text = dsSP.Current("Tên sản phẩm")
        giaText.Text = dsSP.Current("Đơn giá bán")
        soLuongText.Text = dsSP.Current("Số lượng còn")







    End Sub

    ' click rows hiển thị db ra màn hình
    Private Sub ViewSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewSanPham.CellClick
        Dim selectedGD As DataGridViewRow
        maSPText.Enabled = False
        selectedGD = ViewSanPham.Rows(e.RowIndex)
        maSPText.Text = selectedGD.Cells(0).Value
        nameText.Text = selectedGD.Cells(1).Value
        giaText.Text = selectedGD.Cells(2).Value
        soLuongText.Text = selectedGD.Cells(3).Value

    End Sub
    Private Sub ThemBtn_Click(sender As Object, e As EventArgs) Handles ThemBtn.Click
        maSPText.Text = ""
        nameText.Text = ""
        giaText.Text = ""
        soLuongText.Text = ""
    End Sub

    Private Sub LuuBtn_Click(sender As Object, e As EventArgs) Handles LuuBtn.Click
        If MsgBox("Bạn có muốn thêm không? ", vbYesNo, "Đã thêm") = MsgBoxResult.Yes Then
            If nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "insert into SanPham(maSP,tenSP, donGiaBan, soLuongCon) 
                        values(dbo.fn_autoID(),N'" & nameText.Text & "','" & giaText.Text & "','" & soLuongText.Text & "')"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                Xuat_SanPham()

                MsgBox("Thêm thành công!")
            End If
        End If
    End Sub

    Private Sub SuaBtn_Click(sender As Object, e As EventArgs) Handles SuaBtn.Click
        If MsgBox("Bạn có muốn sửa không? ", vbYesNo, "Đã cập nhật") = MsgBoxResult.Yes Then
            If maSPText.Text = "" Or nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "update  SanPham  set tenSP = N'" & nameText.Text & "',donGiaBan = N'" & giaText.Text & "',soLuongCon = '" & soLuongText.Text & "' 
                where maSP = '" & maSPText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SanPham()
                MsgBox("Cập nhật thành công!")
            End If
        End If
    End Sub

    Private Sub XoaBtn_Click(sender As Object, e As EventArgs) Handles XoaBtn.Click
        If MsgBox("Bạn có muốn xóa không? ", vbYesNo, "Đã xóa") = MsgBoxResult.Yes Then
            If maSPText.Text = "" Or nameText.Text = "" Or giaText.Text = "" Or
            soLuongText.Text = "" Then
                MsgBox("Chưa nhập đủ")
            Else


                lenh = "delete  SanPham  where maSP = '" & maSPText.Text & "'"
                Dim cmd As New SqlCommand(lenh, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Xuat_SanPham()
                MsgBox("Xóa thành công!")
            End If
        End If
    End Sub


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
    Private Sub InBtn_Click(sender As Object, e As EventArgs) Handles btnBangBieu.Click
        ReportSanPham.Show()

    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim imagebmp As New Bitmap(Me.ViewSanPham.Width, Me.ViewSanPham.Height)
        ViewSanPham.DrawToBitmap(imagebmp, New Rectangle(0, 0, Me.ViewSanPham.Width, Me.ViewSanPham.Height))
        e.Graphics.DrawImage(imagebmp, 100, 20)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub


    'Lấy thông tin chức vụ vào cbb
    Private Sub Xuat_TT()
        con.Open()
        Dim strsql As New SqlCommand("SELECT distinct tenSP
                                        From SanPham", con)
        Dim myreader As SqlClient.SqlDataReader = strsql.ExecuteReader

        cbbSP.Items.Clear()
        While myreader.Read()
            cbbSP.Items.Add(myreader("tenSP"))
        End While
        con.Close()
    End Sub


    '' Code xuất thông tin theo chức vụ
    Private WithEvents dsSPP As BindingManagerBase
    Private Sub Xuat_TTSP()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá bán', soLuongCon as N'Số lượng còn'
                From SanPham
                where tenSP like '%" + cbbSP.Text + "%'"
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
        dsSPP = Me.BindingContext(dttable)
    End Sub

    Private Sub cbbSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSP.SelectedIndexChanged
        Xuat_TTSP()
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
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá bán', soLuongCon as N'Số lượng còn'
                From SanPham
                where soLuongCon >=1 and soLuongCon <=500"
        displayData(sql, ViewSanPham)
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá bán', soLuongCon as N'Số lượng còn'
                From SanPham
                where soLuongCon >=500 and soLuongCon <=1000"
        displayData(sql, ViewSanPham)
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton3.CheckedChanged
        sql = "SELECT maSP As N'Mã sản phẩm',tenSP As N'Tên sản phẩm', format((donGiaBan),'##,#\ VNĐ','es-ES') As N'Đơn giá bán', soLuongCon as N'Số lượng còn'
                From SanPham
                where soLuongCon >1000"
        displayData(sql, ViewSanPham)
    End Sub
End Class