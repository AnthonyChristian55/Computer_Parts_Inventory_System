Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LandingPage

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LandingPage_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Center the Button
        Button2.Location = New Point(
            (Me.ClientSize.Width - Button2.Width) \ 2,  ' Center horizontally
            (Me.ClientSize.Height - Button2.Height) \ 2 + (Me.ClientSize.Height \ 4)' Center vertically
        )
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Hide()
    End Sub
End Class