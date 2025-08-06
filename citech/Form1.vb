Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ensure the connection is open
        DBConnection.ConnectDB()

        Try
            ' Check if username or password is empty
            If String.IsNullOrEmpty(txtUName.Text) OrElse String.IsNullOrEmpty(txtPW.Text) Then
                MessageBox.Show("Please enter both username and password.", "Login Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Query to check if the username and hashed password match
            Dim query As String = "SELECT role FROM users WHERE username = @username AND password = MD5(@password)"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            ' Add parameters to prevent SQL injection
            cmd.Parameters.AddWithValue("@username", txtUName.Text)
            cmd.Parameters.AddWithValue("@password", txtPW.Text)

            ' Execute the query
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read() ' Read the data
                Dim role As String = reader("role").ToString() ' Get the user's role
                reader.Close()

                ' Redirect to the appropriate form based on the user's role
                Select Case role
                    Case "admin"
                        MessageBox.Show("Admin Login is Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FormAdmin.Show()
                    Case "staff"
                        MessageBox.Show("Staff Login is Successful", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        FormStaff.Show()
                    Case Else
                        MessageBox.Show("User role not recognized.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
                Me.Hide() ' Hide the login form
            Else
                ' Invalid credentials
                MessageBox.Show("Invalid credentials. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            ' Display error message
            MessageBox.Show("Error: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            DBConnection.CloseDB()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        GroupBox1.Location = New Point(
            (Me.ClientSize.Width - GroupBox1.Width) \ 2,
            (Me.ClientSize.Height - GroupBox1.Height) \ 2
        )
    End Sub

End Class
