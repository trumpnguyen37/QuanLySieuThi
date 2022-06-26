Imports System.Data.SqlClient
Public Class ReportNhanVien
    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub ReportNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Xuat_TT()
        Dim dt As New DataTable
        con.Open()
        Using cmd As New SqlCommand("select maNV,tenNV,SDT,email,chucVu,format(luong,'##,#\ VNĐ','es-ES') as luong 
                                        from NhanVien", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportNV.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\NhanVien.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportNV.RefreshReport()
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

    Dim dsNVVC As BindingManagerBase
    Private Sub Xuat_TTCV()
        Dim lenh As String
        'Khai báo câu lệnh truy vấn dùng để đọc bảng SinhVien
        lenh = "select maNV,tenNV,SDT,email,chucVu,format(luong,'##,#\ VNĐ','es-ES') as luong 
                from NhanVien
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
        With Me.ReportNV.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\NhanVien.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dttable))
        End With
        con.Close()
        Me.ReportNV.RefreshReport()
        con.Close()

        'khoi tao lien ket voi datatable.

        dsNVVC = Me.BindingContext(dttable)
    End Sub


    Private Sub cbbCV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCV.SelectedIndexChanged
        Xuat_TTCV()
    End Sub
End Class