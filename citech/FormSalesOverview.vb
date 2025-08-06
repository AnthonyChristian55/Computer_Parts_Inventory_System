Imports MySql.Data.MySqlClient

Public Class FormSalesOverview
    ' Start the Timer for real-time updates
    Private Sub FormSalesOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized

        ' Load sales overview on form load
        LoadSalesOverview()

        ' Start the timer for real-time updates
        Timer1.Interval = 10000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Refresh sales data every time the timer ticks
        LoadSalesOverview()
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        ' Load sales overview with date filter
        LoadSalesOverview(dtpStartDate.Value, dtpEndDate.Value)
    End Sub

    Private Sub LoadSalesOverview(Optional startDate As Date = Nothing, Optional endDate As Date = Nothing)
        Try
            Dim query As String

            ' Query without date filter, including latest date per product
            If startDate = Nothing OrElse endDate = Nothing Then
                query = "SELECT p.product_name, MAX(s.date) AS latest_date, SUM(s.quantity) AS total_quantity_sold, SUM(s.revenue) AS total_revenue " &
                    "FROM sales s INNER JOIN products p ON s.product_id = p.id " &
                    "GROUP BY p.product_name"
            Else
                ' Query with date filter, including latest date per product
                query = "SELECT p.product_name, MAX(s.date) AS latest_date, SUM(s.quantity) AS total_quantity_sold, SUM(s.revenue) AS total_revenue " &
                    "FROM sales s INNER JOIN products p ON s.product_id = p.id " &
                    "WHERE s.date BETWEEN @StartDate AND @EndDate " &
                    "GROUP BY p.product_name"
            End If

            ' Connect to database
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=citech_db")
                Using cmd As New MySqlCommand(query, conn)
                    If startDate <> Nothing AndAlso endDate <> Nothing Then
                        cmd.Parameters.AddWithValue("@StartDate", startDate)
                        cmd.Parameters.AddWithValue("@EndDate", endDate)
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()

                    conn.Open()
                    adapter.Fill(dt)
                    conn.Close()

                    ' Bind the data to the DataGridView
                    dgvSalesOverview.DataSource = dt

                    ' Optional: Format the DataGridView
                    dgvSalesOverview.Columns("product_name").HeaderText = "Product Name"
                    dgvSalesOverview.Columns("latest_date").HeaderText = "Date"
                    dgvSalesOverview.Columns("total_quantity_sold").HeaderText = "Total Quantity Sold"
                    dgvSalesOverview.Columns("total_revenue").HeaderText = "Total Revenue"
                    dgvSalesOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sales overview: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            ' Create an Excel application object using late binding
            Dim excelApp As Object = CreateObject("Excel.Application")

            ' Create a new workbook and get the first worksheet
            Dim workBook As Object = excelApp.Workbooks.Add()
            Dim workSheet As Object = workBook.Sheets(1)

            ' Add column headers to the worksheet
            Dim colIndex As Integer = 0
            For Each col As DataGridViewColumn In dgvSalesOverview.Columns
                workSheet.Cells(1, colIndex + 1) = col.HeaderText
                colIndex += 1
            Next

            ' Add data to the worksheet starting from row 2
            For rowIndex As Integer = 0 To dgvSalesOverview.Rows.Count - 1
                colIndex = 0
                For Each col As DataGridViewColumn In dgvSalesOverview.Columns
                    If dgvSalesOverview.Rows(rowIndex).Cells(col.Index).Value IsNot Nothing Then
                        workSheet.Cells(rowIndex + 2, colIndex + 1) = dgvSalesOverview.Rows(rowIndex).Cells(col.Index).Value.ToString()
                    End If
                    colIndex += 1
                Next
            Next

            ' Make Excel visible (optional)
            excelApp.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
