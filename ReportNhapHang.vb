Imports System.Data.SqlClient
Public Class ReportNhapHang
    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub ReportNhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataTable1TableAdapter.Fill(Me.DSNhapHang.DataTable1)
        Dim dt As New DataTable

        con.Open()
        Using cmd As New SqlCommand("select SP.maSP , tenSP , format(donGiaNhap,'##,#\ VNĐ','es-ES') as donGiaNhap, ngayNhapHang
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportNH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\NhapHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()

        Me.ReportNH.RefreshReport()
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        con.Open()
        Dim cmd1 As SqlCommand = New SqlCommand("select SP.maSP , tenSP , format(donGiaNhap,'##,#\ VNĐ','es-ES') as donGiaNhap, ngayNhapHang
                from PhieuNhap as PN, ChiTietPhieuNhap as CT, SanPham as SP
                where PN.maPN = CT.maPN and CT.maSP = SP.maSP and ngayNhapHang between @dt1 and @dt2 order by ngayNhapHang desc", con)
        cmd1.Parameters.Add("dt1", SqlDbType.DateTime).Value = d1.Value
        cmd1.Parameters.Add("dt2", SqlDbType.DateTime).Value = d2.Value
        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        With Me.ReportNH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\NhapHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With


        con.Close()
        Me.ReportNH.RefreshReport()
    End Sub
End Class