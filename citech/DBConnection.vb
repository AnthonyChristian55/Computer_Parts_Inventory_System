Imports MySql.Data.MySqlClient

Module DBConnection
    ' Declare the MySQL connection variable globally
    Public conn As MySqlConnection

    ' Create a function to connect to the database
    Public Sub ConnectDB()
        Try
            ' Define the connection string (replace with your own credentials)
            conn = New MySqlConnection("server=localhost;userid=root;password=;database=citech_db")
            conn.Open()  ' Open the connection

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        End Try
    End Sub

    ' Create a function to close the connection when done
    Public Sub CloseDB()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()

        End If
    End Sub
End Module
