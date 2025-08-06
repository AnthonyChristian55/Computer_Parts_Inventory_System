Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class FormManageProducts
    ' Declare selectedProductId at the class level
    Private selectedProductId As Integer

    Private Sub LoadFilterCategories()
        Try
            ' Fetch categories from the database
            Dim query As String = "SELECT id, category_name FROM categories"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable with categories
            adapter.Fill(dt)

            ' Debug: Ensure the table has data
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No categories found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Add "All Categories" at the top
            Dim allRow As DataRow = dt.NewRow()
            allRow("id") = 0
            allRow("category_name") = "All Categories"
            dt.Rows.InsertAt(allRow, 0)

            ' Debug: Check if "All Categories" is added
            For Each row As DataRow In dt.Rows
                Debug.WriteLine($"ID: {row("id")}, Name: {row("category_name")}")
            Next

            ' Bind the DataTable to the ComboBox
            cmbCat.DataSource = dt
            cmbCat.DisplayMember = "category_name"
            cmbCat.ValueMember = "id"
            cmbCat.SelectedIndex = 0 ' Default to "All Categories"

        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadProducts(Optional categoryId As Integer = 0)
        Try
            Dim query As String

            If categoryId = 0 Then
                query = "SELECT p.id, p.product_name, c.category_name, p.price, p.stock, p.description, p.image_url " &
                    "FROM products p " &
                    "INNER JOIN categories c ON p.category_id = c.id"
            Else
                query = "SELECT p.id, p.product_name, c.category_name, p.price, p.stock, p.description, p.image_url " &
                    "FROM products p " &
                    "INNER JOIN categories c ON p.category_id = c.id " &
                    "WHERE p.category_id = @CategoryId"
            End If

            Dim cmd As New MySqlCommand(query, DBConnection.conn)

            If categoryId <> 0 Then
                cmd.Parameters.AddWithValue("@CategoryId", categoryId)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            dgvProd.DataSource = dt
            dgvProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvProd.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged
        ' Ensure the ComboBox has a valid selection
        If cmbCat.SelectedIndex <> -1 Then
            Dim selectedCategoryId As Integer

            ' Check if SelectedValue is not Nothing and extract the ID
            If TypeOf cmbCat.SelectedValue Is DataRowView Then
                selectedCategoryId = Convert.ToInt32(DirectCast(cmbCat.SelectedItem, DataRowView)("id"))
            Else
                selectedCategoryId = Convert.ToInt32(cmbCat.SelectedValue)
            End If

            ' Load products for the selected category
            If selectedCategoryId = 0 Then
                LoadProducts() ' Load all products when "All Categories" is selected
            Else
                LoadProducts(selectedCategoryId) ' Load products for the specific category
            End If
        End If
    End Sub

    Private Sub FormManageProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CenterToScreen()
        Me.WindowState = FormWindowState.Maximized

        LoadFilterCategories()

        ' Load all products initially
        LoadProducts()

        dgvProd.Columns("image_url").Visible = False
    End Sub

    Private Sub LoadCategories()
        Try
            ' Fetch category data from the database
            Dim query As String = "SELECT id, category_name FROM categories"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()

            ' Fill the DataTable and bind it to the ComboBox
            adapter.Fill(dt)

            For Each row As DataRow In dt.Rows
                Debug.WriteLine($"ID: {row("id")}, Name: {row("category_name")}")
            Next

            ' Set the data source and bind category_id to ValueMember
            cmbCat.DataSource = dt
            cmbCat.DisplayMember = "category_name"  ' Display the category names
            cmbCat.ValueMember = "id"  ' Use the category id for the selected value

            cmbCat.SelectedIndex = -1 ' No category selected by default
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Button Click Event to Add Product
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Validate the form inputs
        If String.IsNullOrWhiteSpace(txtProdName.Text) OrElse cmbCat.SelectedIndex = -1 OrElse
       String.IsNullOrWhiteSpace(txtProdPrice.Text) OrElse String.IsNullOrWhiteSpace(txtProdStk.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the product details from the form
        Dim productName As String = txtProdName.Text.Trim()
        ' Get the selected category ID directly from the ComboBox's SelectedValue
        Dim selectedCategoryId As Integer = Convert.ToInt32(cmbCat.SelectedValue)
        Dim price As Decimal
        Dim stock As Integer

        ' Try parsing the price and stock values
        If Not Decimal.TryParse(txtProdPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not Integer.TryParse(txtProdStk.Text, stock) Then
            MessageBox.Show("Please enter a valid stock quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the description and image (if any)
        Dim description As String = txtProdDesc.Text.Trim()
        Dim imagePath As String = ""

        ' Check if an image is selected and save it
        If pbProd.Image IsNot Nothing Then
            imagePath = SaveImage(pbProd.Image) ' Assuming SaveImage function handles saving image path
        End If

        ' Insert the product into the database
        Try
            ' Use category_id directly in the query
            Dim query As String = "INSERT INTO products (product_name, category_id, price, stock, description, image_url, created_at) " &
                              "VALUES (@ProductName, @CategoryId, @Price, @Stock, @Description, @ImageUrl, NOW())"

            ' Prepare SQL command
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@ProductName", productName)
            cmd.Parameters.AddWithValue("@CategoryId", selectedCategoryId) ' Use selected category ID
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.Parameters.AddWithValue("@Stock", stock)
            cmd.Parameters.AddWithValue("@Description", description)
            cmd.Parameters.AddWithValue("@ImageUrl", imagePath)

            ' Open database connection
            DBConnection.conn.Open()

            ' Execute query
            cmd.ExecuteNonQuery()

            ' Close the connection
            DBConnection.conn.Close()

            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Optionally clear the form
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub

    ' Helper method to save the product image locally and return the file path
    Private Function SaveImage(image As Image) As String
        ' Get the directory of the current executing project
        Dim rootDirectory As String = AppDomain.CurrentDomain.BaseDirectory

        ' Define the path to the "pictures" folder in the root directory
        Dim picturesDirectory As String = Path.Combine(rootDirectory, "pictures")

        ' Ensure the "pictures" directory exists
        If Not Directory.Exists(picturesDirectory) Then
            Directory.CreateDirectory(picturesDirectory)
        End If

        ' Generate a unique filename for the image
        Dim fileName As String = Path.Combine(picturesDirectory, Guid.NewGuid().ToString() & ".jpg")

        ' Save the image to the file system
        image.Save(fileName)

        ' Return the image file path
        Return fileName
    End Function

    ' Clear the form fields after successful product addition
    Private Sub ClearForm()
        txtProdName.Clear()
        cmbCat.SelectedIndex = -1
        txtProdPrice.Clear()
        txtProdStk.Clear()
        txtProdDesc.Clear()
        pbProd.Image = Nothing
    End Sub

    ' Button Click Event for Uploading Product Image
    Private Sub btnUpldImg_Click(sender As Object, e As EventArgs) Handles btnUpldImg.Click
        ' Open file dialog to select an image
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pbProd.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            ' Ensure a row is selected
            If dgvProd.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Get selected product ID
            Dim selectedRow As DataGridViewRow = dgvProd.SelectedRows(0)
            selectedProductId = Convert.ToInt32(selectedRow.Cells("id").Value)

            ' If the button text is "Edit", populate the form with the selected product details
            If btnEdit.Text = "Edit" Then
                Dim query As String = "SELECT * FROM products WHERE id = @ProductId"
                Dim cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@ProductId", selectedProductId)

                ' Open connection, execute the query, and fill the form
                DBConnection.conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Load product details into the form
                If reader.Read() Then
                    txtProdName.Text = reader("product_name").ToString()
                    cmbCat.SelectedValue = Convert.ToInt32(reader("category_id"))
                    txtProdPrice.Text = reader("price").ToString()
                    txtProdStk.Text = reader("stock").ToString()
                    txtProdDesc.Text = reader("description").ToString()

                    ' Load product image if available
                    Dim imageUrl As String = reader("image_url").ToString()
                    If Not String.IsNullOrEmpty(imageUrl) AndAlso File.Exists(imageUrl) Then
                        pbProd.Image = Image.FromFile(imageUrl)
                    Else
                        pbProd.Image = Nothing
                    End If
                End If
                reader.Close()
                DBConnection.conn.Close()

                ' Change button text to "Save"
                btnEdit.Text = "Save"

            ElseIf btnEdit.Text = "Save" Then
                ' Validate inputs before saving
                If String.IsNullOrWhiteSpace(txtProdName.Text) OrElse cmbCat.SelectedIndex = -1 OrElse
            String.IsNullOrWhiteSpace(txtProdPrice.Text) OrElse String.IsNullOrWhiteSpace(txtProdStk.Text) Then
                    MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Collect updated details
                Dim productName As String = txtProdName.Text.Trim()
                Dim selectedCategoryId As Integer = Convert.ToInt32(cmbCat.SelectedValue)
                Dim price As Decimal
                Dim stock As Integer

                ' Validate numeric fields
                If Not Decimal.TryParse(txtProdPrice.Text, price) Then
                    MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                If Not Integer.TryParse(txtProdStk.Text, stock) Then
                    MessageBox.Show("Please enter a valid stock quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Get the current stock value from the database to compare with the updated stock value
                Dim currentStock As Integer
                Dim getCurrentStockQuery As String = "SELECT stock FROM products WHERE id = @ProductId"
                Dim getStockCmd As New MySqlCommand(getCurrentStockQuery, DBConnection.conn)
                getStockCmd.Parameters.AddWithValue("@ProductId", selectedProductId)

                DBConnection.conn.Open()
                currentStock = Convert.ToInt32(getStockCmd.ExecuteScalar())
                DBConnection.conn.Close()

                ' Calculate the number of products sold
                Dim soldQuantity As Integer = currentStock - stock
                If soldQuantity > 0 Then
                    ' Record the sale in the sales table
                    RecordSale(selectedProductId, soldQuantity)
                End If

                ' Save or update the product
                Dim description As String = txtProdDesc.Text.Trim()
                Dim imagePath As String = ""

                ' Save new image if one is uploaded
                If pbProd.Image IsNot Nothing Then
                    imagePath = SaveImage(pbProd.Image)
                End If

                ' Open connection for the UPDATE operation
                DBConnection.conn.Open()

                ' Update the product in the database
                Dim updateQuery As String = "UPDATE products SET product_name = @ProductName, category_id = @CategoryId, price = @Price, " &
                                   "stock = @Stock, description = @Description, image_url = @ImageUrl WHERE id = @ProductId"
                Dim cmd As New MySqlCommand(updateQuery, DBConnection.conn)
                cmd.Parameters.AddWithValue("@ProductName", productName)
                cmd.Parameters.AddWithValue("@CategoryId", selectedCategoryId)
                cmd.Parameters.AddWithValue("@Price", price)
                cmd.Parameters.AddWithValue("@Stock", stock)
                cmd.Parameters.AddWithValue("@Description", description)
                cmd.Parameters.AddWithValue("@ImageUrl", imagePath)
                cmd.Parameters.AddWithValue("@ProductId", selectedProductId)

                cmd.ExecuteNonQuery()
                DBConnection.conn.Close()

                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reload products and reset the form
                LoadProducts()
                ClearForm()

                ' Change button text back to "Edit"
                btnEdit.Text = "Edit"
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub

    Private Sub RecordSale(productId As Integer, soldQuantity As Integer)
        Try
            ' Fetch the category_id and price for the given product
            Dim categoryId As Integer
            Dim price As Decimal
            Dim query As String = "SELECT category_id, price FROM products WHERE id = @ProductId"
            Dim cmd As New MySqlCommand(query, DBConnection.conn)
            cmd.Parameters.AddWithValue("@ProductId", productId)

            If DBConnection.conn.State <> ConnectionState.Open Then
                DBConnection.conn.Open()
            End If

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                categoryId = Convert.ToInt32(reader("category_id"))
                price = Convert.ToDecimal(reader("price"))
            Else
                Throw New Exception("Product not found.")
            End If
            reader.Close()

            ' Calculate revenue
            Dim revenue As Decimal = soldQuantity * price

            ' Insert the sale record into the sales table
            Dim insertQuery As String = "INSERT INTO sales (product_id, quantity, revenue, category_id) VALUES (@ProductId, @SoldQuantity, @Revenue, @CategoryId)"
            Dim insertCmd As New MySqlCommand(insertQuery, DBConnection.conn)
            insertCmd.Parameters.AddWithValue("@ProductId", productId)
            insertCmd.Parameters.AddWithValue("@SoldQuantity", soldQuantity)
            insertCmd.Parameters.AddWithValue("@Revenue", revenue)
            insertCmd.Parameters.AddWithValue("@CategoryId", categoryId)

            insertCmd.ExecuteNonQuery()

            MessageBox.Show("Sale recorded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error recording sale: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DBConnection.conn.State = ConnectionState.Open Then
                DBConnection.conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a product is selected in the DataGridView
        If dgvProd.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a product to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the selected product ID from the DataGridView
        Dim productId As Integer = Convert.ToInt32(dgvProd.SelectedRows(0).Cells("id").Value)

        ' Confirm deletion with the user
        Dim dialogResult As DialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialogResult = DialogResult.Yes Then
            Try
                ' Prepare the SQL query to delete the selected product
                Dim query As String = "DELETE FROM products WHERE id = @ProductId"

                ' Create MySqlCommand
                Dim cmd As New MySqlCommand(query, DBConnection.conn)
                cmd.Parameters.AddWithValue("@ProductId", productId)

                ' Open the database connection
                If DBConnection.conn.State = ConnectionState.Closed Then
                    DBConnection.conn.Open()
                End If

                ' Execute the query
                cmd.ExecuteNonQuery()

                ' Close the connection
                DBConnection.conn.Close()

                ' Show success message
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Reload the products after deletion
                LoadProducts()

            Catch ex As Exception
                ' Handle error and show message
                MessageBox.Show("Error deleting product: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed after the operation
                If DBConnection.conn.State = ConnectionState.Open Then
                    DBConnection.conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormStaff.Show()
        Me.Hide
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            ' Create an Excel application object using late binding
            Dim excelApp As Object = CreateObject("Excel.Application")

            ' Create a new workbook and get the first worksheet
            Dim workBook As Object = excelApp.Workbooks.Add()
            Dim workSheet As Object = workBook.Sheets(1)

            ' Add column headers to the worksheet, skip "image_url"
            Dim colIndex As Integer = 0
            For Each col As DataGridViewColumn In dgvProd.Columns
                If col.Name <> "image_url" Then ' Skip the image_url column
                    workSheet.Cells(1, colIndex + 1) = col.HeaderText
                    colIndex += 1
                End If
            Next

            ' Add data to the worksheet starting from row 2, skip "image_url" column
            For rowIndex As Integer = 0 To dgvProd.Rows.Count - 1
                colIndex = 0
                For Each col As DataGridViewColumn In dgvProd.Columns
                    If col.Name <> "image_url" Then ' Skip the image_url column
                        If dgvProd.Rows(rowIndex).Cells(col.Index).Value IsNot Nothing Then
                            workSheet.Cells(rowIndex + 2, colIndex + 1) = dgvProd.Rows(rowIndex).Cells(col.Index).Value.ToString()
                        End If
                        colIndex += 1
                    End If
                Next
            Next

            ' Make Excel visible (optional)
            excelApp.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            ' Get the search keyword from the text box
            Dim searchKeyword As String = txtSearch.Text.Trim()

            ' Ensure the keyword is not empty
            If String.IsNullOrEmpty(searchKeyword) Then
                MessageBox.Show("Please enter a keyword to search.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Temporarily suspend the CurrencyManager to avoid the invisible row issue
            Dim currencyManager As CurrencyManager = CType(BindingContext(dgvProd.DataSource), CurrencyManager)
            currencyManager.SuspendBinding()

            ' Loop through the DataGridView rows, excluding the new row
            For Each row As DataGridViewRow In dgvProd.Rows
                If Not row.IsNewRow Then
                    ' Check if any cell in the row contains the search keyword (case-insensitive)
                    Dim matchFound As Boolean = False
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchKeyword.ToLower()) Then
                            matchFound = True
                            Exit For
                        End If
                    Next

                    ' Show the row if a match is found, otherwise hide it
                    row.Visible = matchFound
                End If
            Next

            ' Resume the CurrencyManager after processing
            currencyManager.ResumeBinding()

        Catch ex As Exception
            MessageBox.Show("Error during search: " & ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Show all rows in the DataGridView
        For Each row As DataGridViewRow In dgvProd.Rows
            row.Visible = True
            txtSearch.Clear()
        Next
    End Sub

    Private Sub dgvProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProd.CellContentClick
        Try
            ' Ensure the click is on a valid row and not a header
            If e.RowIndex >= 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = dgvProd.Rows(e.RowIndex)

                ' Retrieve the image URL from the DataGridView (assuming 'image_url' is the name of the column)
                Dim imageUrl As String = selectedRow.Cells("image_url").Value?.ToString()

                ' Load the image if the URL is valid
                If Not String.IsNullOrEmpty(imageUrl) AndAlso IO.File.Exists(imageUrl) Then
                    ' If the image exists, load it into the PictureBox
                    pbProd.Image = Image.FromFile(imageUrl)
                    pbProd.SizeMode = PictureBoxSizeMode.Zoom ' Ensures image fits inside the PictureBox
                Else
                    ' If the image URL is invalid or not found, use a placeholder image
                    ' Define the path to your placeholder image
                    Dim placeholderPath As String = "C:\Users\antho\OneDrive\Documents\winFormSchoolProjects\citech\pictures\stock.jpg"

                    ' Check if the placeholder image exists
                    If IO.File.Exists(placeholderPath) Then
                        pbProd.Image = Image.FromFile(placeholderPath)
                        pbProd.SizeMode = PictureBoxSizeMode.Zoom ' Ensures placeholder image fits inside the PictureBox
                    Else
                        ' If the placeholder image is also missing, show a warning
                        MessageBox.Show("Placeholder image not found.", "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        pbProd.Image = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            ' Handle any exceptions
            MessageBox.Show("Error displaying image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class