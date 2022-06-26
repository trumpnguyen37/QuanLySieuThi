Imports System.Data.SqlClient
Public Class DangKy
    Dim lenh As String
    Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-8GKPO1M;Persist Security Info=True;Password=Trung@2305;User ID=sa;Initial Catalog=QuanLySieuThi")
    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        If MsgBox("Bạn có muốn tạo tài khoản không? ", vbYesNo, "TẠO TÀI KHOẢN") = MsgBoxResult.Yes Then
            If taiKhoan.Text = "" Or matKhau.Text = "" Or nhapLaiMK.Text = "" Then
                MsgBox("Chưa nhập đủ thông tin")
            Else

                Dim mk As String

                If (matKhau.Text <> nhapLaiMK.Text) Then
                    MessageBox.Show("Mật khẩu không trùng nhau. Vui lòng nhập lại mật khẩu!!!")
                Else
                    mk = matKhau.Text
                    lenh = "insert into TaiKhoan(tenTK, matKhau, maNV) values('" & taiKhoan.Text & "','" & mk & "','" & txtMaNV.Text & "')"
                    Dim cmd As New SqlCommand(lenh, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()

                    MsgBox("Tạo tài khoản thành công!")
                    Me.Hide()
                    Login.Show()
                End If


            End If
        End If
    End Sub

    Private Sub btnQuayLai_Click(sender As Object, e As EventArgs) Handles btnQuayLai.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class