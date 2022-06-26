Public Class MainForm
    Private currentButton As Button
    Private activeForm As Form
    Private random As Random
    Private tempIndex As Integer
    Public Sub New()
        InitializeComponent()
        random = New Random()
        currentButton = New Button()

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
    End Sub
    Private Function SelectThemeColor() As Color
        Dim index As Integer = random.[Next](ThemesColor.ColorList.Count)
        While tempIndex = index
            index = random.[Next](ThemesColor.ColorList.Count)
        End While
        tempIndex = index
        Dim color As String = ThemesColor.ColorList(index)
        Return ColorTranslator.FromHtml(color)
    End Function
    Private Sub ActivateButton(btnSender As Object)
        If btnSender IsNot Nothing Then
            If currentButton.Name <> CType(btnSender, Button).Name Then
                DisableButton()
                Dim color As Color = SelectThemeColor()
                currentButton = CType(btnSender, Button)
                currentButton.BackColor = Drawing.Color.FromArgb(48, 52, 54)
                currentButton.ForeColor = Color.White
                ThemesColor.PrimaryColor = color
                ThemesColor.SecondaryColor = ThemesColor.ChangeColorBrightness(color, -0.3)
            End If
        End If
    End Sub
    Private Sub DisableButton()
        For Each previousBtn As Control In menuPanel.Controls
            If previousBtn.[GetType]() = GetType(Button) Then
                previousBtn.BackColor = Drawing.Color.FromArgb(100, 193, 192) '51, 51, 76)
            End If
        Next
    End Sub
    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If activeForm IsNot Nothing Then activeForm.Close()
        ActivateButton(btnSender)
        activeForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.switchPanel.Controls.Add(childForm)
        Me.switchPanel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub close_Click(sender As Object, e As EventArgs) Handles close.Click
        If (Not (activeForm) Is Nothing) Then
            activeForm.Close()
        End If

        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenChildForm(New NhanVien(), sender)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenChildForm(New KhachHang(), sender)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenChildForm(New SanPham(), sender)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenChildForm(New NhapHang(), sender)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenChildForm(New HoaDon(), sender)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenChildForm(New MuaHang(), sender)
    End Sub

    Private Sub cbbTK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbTK.SelectedIndexChanged
        If cbbTK.Text = "Thông tin tài khoản" Then
            Me.Hide()
            ThongTinTaiKhoan.Show()
        Else
            If cbbTK.Text = "Thoát" Then
                Me.Hide()
                Login.tenTK.Text = ""
                Login.matKhau.Text = ""
                Login.Show()

            End If
        End If
    End Sub
End Class
