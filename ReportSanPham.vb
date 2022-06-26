Imports System.Data.SqlClient
Public Class ReportSanPham
    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")

    Private Sub ReportSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportSP.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\SanPham.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportSP.RefreshReport()
    End Sub

    Private Sub Guna2RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton4.CheckedChanged
        Dim dt As New DataTable
        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham where soLuongCon >=1 and soLuongCon <=500", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportSP.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\SanPham.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportSP.RefreshReport()
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton2.CheckedChanged
        Dim dt As New DataTable
        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham where soLuongCon >=500 and soLuongCon <=1000", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportSP.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\SanPham.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportSP.RefreshReport()
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton3.CheckedChanged
        Dim dt As New DataTable
        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham
                                        where soLuongCon >1000", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportSP.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\SanPham.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportSP.RefreshReport()
    End Sub
End Class