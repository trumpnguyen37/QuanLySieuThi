Imports System.Data.SqlClient
Public Class ReportHoaDon
    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub ReportHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    
        'TODO: This line of code loads data into the 'Demo1.KhachHang' table. You can move, or remove it, as needed.
        Me.KhachHangTableAdapter.Fill(Me.Demo1.KhachHang)
        'TODO: This line of code loads data into the 'Demo1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.Demo1.DataTable1)
        Dim dt As New DataTable

        con.Open()
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "MM/dd/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "MM/dd/yyyy"

        Using cmd As New SqlCommand("select HD.maHD ,HD.ngayTaoHD ,NV.tenNV,KH.tenKH ,SP.maSP, SP.tenSP,CT.soLuongDat,format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as Column1, SP.donGiaBan ,sum(CT.soLuongDat * SP.donGiaBan) as Column2
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV               
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using


        With Me.ReportHD.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\HoaDon.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportHD.RefreshReport()

    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("select HD.maHD ,HD.ngayTaoHD ,NV.tenNV,KH.tenKH ,SP.maSP, SP.tenSP,CT.soLuongDat
                ,format(SP.donGiaBan,'##,#\ VNĐ','es-ES') as Column1, SP.donGiaBan ,sum(CT.soLuongDat * SP.donGiaBan) as Column2
                from SanPham as SP, ChiTietHoaDon as CT, HoaDon as HD, NhanVien as NV, KhachHang as KH, TaiKhoan as TK
                where SP.maSP = CT.maSP and CT.maHD = HD.maHD  and HD.maKH = KH.maKH and HD.maNV = NV.maNV and NV.maNV = TK.maNV and ngayTaoHD between @dt1 and @dt2 		                
                GROUP BY HD.maHD, HD.ngayTaoHD,NV.tenNV,KH.tenKH, SP.maSP, SP.tenSP, CT.soLuongDat, SP.donGiaBan ", con)
        cmd1.Parameters.Add("dt1", SqlDbType.DateTime).Value = d1.Value
        cmd1.Parameters.Add("dt2", SqlDbType.DateTime).Value = d2.Value
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)


        With Me.ReportHD.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\HoaDon.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportHD.RefreshReport()
    End Sub

End Class