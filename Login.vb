Imports System.Data.SqlClient
Public Class Login

    Dim sqlStr As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        If tenTK.Text = "" Or matKhau.Text = "" Then
            MessageBox.Show("Vui lòng điền thông tin đầy đủ")
            Exit Sub
        End If
        sqlStr = "Select * from TaiKhoan where tenTK ='" & tenTK.Text & "' and matKhau = '" & matKhau.Text & "' "
        con.Open()
        Dim Cmd As New SqlCommand(sqlStr, con)
        Dim D As SqlDataReader
        D = Cmd.ExecuteReader
        If (D.Read) Then
            MessageBox.Show("Đăng nhập thành công")
            Me.Hide()
            MainForm.cbbTK.Text = "Trung.48.Nhom07"
            MainForm.Show()


        Else
            MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác")
        End If
        con.Close()

    End Sub

    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        DangKy.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class