Imports System.Data.SqlClient
Public Class ReportKhachHang
    Dim con As New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub ReportKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable

        con.Open()
        Using cmd As New SqlCommand("select * from KhachHang", con)
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
        End Using

        With Me.ReportKH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\KhachHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        Me.ReportKH.RefreshReport()


    End Sub

    Public Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * From KhachHang WHERE CONCAT(tenKH, diaChiKH, Email) like '%" & valueToSearch & "%'"
        Dim cmd As New SqlCommand(searchQuery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)


        With Me.ReportKH.LocalReport
            .DataSources.Clear()
            .ReportPath = "D:\QuanLiSieuThi\KhachHang.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table))
        End With
        Me.ReportKH.RefreshReport()
    End Sub

    Private Sub TimBtn_Click(sender As Object, e As EventArgs) Handles TimBtn.Click
        FilterData(searchText.Text)
    End Sub

End Class