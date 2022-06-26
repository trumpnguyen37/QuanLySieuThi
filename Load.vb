Public Class Load

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgress.Increment(3)
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            Login.Show()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
End Class