Public Class FormAdmin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMngUser.Click
        FormManageUsers.Show()
        Me.Hide()
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class