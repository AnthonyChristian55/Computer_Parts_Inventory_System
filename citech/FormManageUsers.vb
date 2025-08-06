Imports MySql.Data.MySqlClient

Public Class FormManageUsers
    Private Sub FormManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized
        ' Load the users from the database
        LoadUsers()
    End Sub

    ' Method to load users into the DataGridView
    Private Sub LoadUsers()
        Try
            ' Create the SQL query to fetch users, including full name and role
            Dim query As String = "SELECT id, fullname, username, role FROM users"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with the query results
            adapter.Fill(dt)

            ' Bind the DataTable to the DataGridView
            dgvUsers.DataSource = dt

            ' Optional: Set some DataGridView formatting
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvUsers.ReadOnly = True

        Catch ex As Exception
            ' Handle any errors that occur during the data loading
            MessageBox.Show("Error loading users: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddAcc_Click(sender As Object, e As EventArgs) Handles btnAddAcc.Click
        ' Validate user inputs
        If String.IsNullOrWhiteSpace(txtFullName.Text) OrElse String.IsNullOrWhiteSpace(txtUName.Text) OrElse String.IsNullOrWhiteSpace(txtPW.Text) Then
            MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the values from the form
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUName.Text.Trim()
        Dim password As String = txtPW.Text.Trim()
        Dim role As String = cmbRole.SelectedItem?.ToString()

        ' Check if a role is selected
        If String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please select a role.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Hash the password using MD5
        Dim hashedPassword As String = ""
        Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim hashBytes As Byte() = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
            hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower()
        End Using

        ' SQL query to insert new user into the users table
        Try
            Dim query As String = "INSERT INTO users (fullname, username, password, role, date_created) VALUES (@FullName, @Username, @Password, @Role, NOW())"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            ' Add parameters to the query to avoid SQL injection
            cmd.Parameters.AddWithValue("@FullName", fullName)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", hashedPassword)
            cmd.Parameters.AddWithValue("@Role", role)

            ' Open the connection and execute the query
            DBConnection.conn.Open()
            cmd.ExecuteNonQuery()
            DBConnection.conn.Close()

            ' Notify the admin that the user was added
            MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the users in the DataGridView
            LoadUsers()

            ' Clear the input fields after adding the user
            txtFullName.Clear()
            txtUName.Clear()
            txtPW.Clear()
            cmbRole.SelectedIndex = -1

        Catch ex As Exception
            ' Handle errors during insertion
            MessageBox.Show("Error adding user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        ' Check if a user is selected
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("id").Value)

        Try
            ' SQL query to delete the user
            Dim query As String = "DELETE FROM users WHERE id = @UserId"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            ' Add parameter to the query
            cmd.Parameters.AddWithValue("@UserId", userId)

            ' Execute the query
            DBConnection.conn.Open()
            cmd.ExecuteNonQuery()
            DBConnection.conn.Close()

            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the users in the DataGridView
            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpd.Click
        ' Check if a user is selected
        If dgvUsers.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a user to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(dgvUsers.SelectedRows(0).Cells("id").Value)
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUName.Text.Trim()
        Dim role As String = cmbRole.SelectedItem?.ToString()

        ' Validate inputs
        If String.IsNullOrWhiteSpace(fullName) OrElse String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrEmpty(role) Then
            MessageBox.Show("Please fill all fields to update the user.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' SQL query to update the user
            Dim query As String = "UPDATE users SET fullname = @FullName, username = @Username, role = @Role WHERE id = @UserId"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            ' Add parameters to the query
            cmd.Parameters.AddWithValue("@FullName", fullName)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Role", role)
            cmd.Parameters.AddWithValue("@UserId", userId)

            ' Execute the query
            DBConnection.conn.Open()
            cmd.ExecuteNonQuery()
            DBConnection.conn.Close()

            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reload the users in the DataGridView
            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick

    End Sub
End Class
