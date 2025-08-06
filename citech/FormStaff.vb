Public Class FormStaff
    Private Sub btnMngProd_Click(sender As Object, e As EventArgs) Handles btnMngProd.Click
        FormManageProducts.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnViewSales_Click(sender As Object, e As EventArgs) Handles btnViewSales.Click
        FormSalesOverview.Show()
        Me.Hide()
    End Sub

    Private Sub FormStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class