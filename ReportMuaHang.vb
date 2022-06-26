Imports System.Data.SqlClient
Public Class ReportMuaHang

    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub ReportMuaHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable

        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportMH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\MuaHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportMH.RefreshReport()
    End Sub


    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton1.CheckedChanged
        Dim dt As New DataTable

        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham
				where donGiaBan >= 1000000", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportMH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\MuaHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportMH.RefreshReport()

    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2RadioButton5.CheckedChanged
        Dim dt As New DataTable

        con.Open()
        Using cmd As New SqlCommand("select maSP,tenSP,format(donGiaBan,'##,#\ VNĐ','es-ES') as donGiaBan,format(soLuongCon,'##,#','es-ES') as soLuongCon
                                        from SanPham
				where donGiaBan < 1000000", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportMH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\MuaHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        con.Close()
        Me.ReportMH.RefreshReport()

    End Sub

End Class