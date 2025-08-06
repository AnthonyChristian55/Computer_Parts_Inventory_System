<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageProducts))
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        cmbCat = New ComboBox()
        txtSearch = New TextBox()
        Panel1 = New Panel()
        btnClear = New Button()
        btnSearch = New Button()
        dgvProd = New DataGridView()
        GroupBox1 = New GroupBox()
        TableLayoutPanel3 = New TableLayoutPanel()
        btnDelete = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnUpldImg = New Button()
        btnEdit = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        txtProdDesc = New TextBox()
        Label1 = New Label()
        txtProdName = New TextBox()
        Label2 = New Label()
        txtProdPrice = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        txtProdStk = New TextBox()
        pbProd = New PictureBox()
        Panel2 = New Panel()
        btnExport = New Button()
        btnAdd = New Button()
        GroupBox2 = New GroupBox()
        btnBack = New Button()
        Panel1.SuspendLayout()
        CType(dgvProd, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(pbProd, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' cmbCat
        ' 
        cmbCat.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCat.Font = New Font("Segoe UI", 12F)
        cmbCat.FormattingEnabled = True
        cmbCat.Location = New Point(66, 13)
        cmbCat.Margin = New Padding(3, 2, 3, 2)
        cmbCat.Name = "cmbCat"
        cmbCat.Size = New Size(133, 29)
        cmbCat.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F)
        txtSearch.Location = New Point(265, 13)
        txtSearch.Margin = New Padding(3, 2, 3, 2)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(117, 29)
        txtSearch.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(btnClear)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(cmbCat)
        Panel1.Controls.Add(txtSearch)
        Panel1.Location = New Point(6, 15)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(784, 51)
        Panel1.TabIndex = 3
        ' 
        ' btnClear
        ' 
        btnClear.BackgroundImage = CType(resources.GetObject("btnClear.BackgroundImage"), Image)
        btnClear.BackgroundImageLayout = ImageLayout.Stretch
        btnClear.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnClear.ForeColor = SystemColors.ControlLightLight
        btnClear.Location = New Point(573, 9)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 35)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), Image)
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch
        btnSearch.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnSearch.ForeColor = SystemColors.ControlLightLight
        btnSearch.Location = New Point(414, 9)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(103, 35)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dgvProd
        ' 
        dgvProd.Anchor = AnchorStyles.None
        dgvProd.BackgroundColor = Color.Gainsboro
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Black
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = Color.Black
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvProd.DefaultCellStyle = DataGridViewCellStyle5
        dgvProd.EnableHeadersVisualStyles = False
        dgvProd.GridColor = Color.Black
        dgvProd.Location = New Point(6, 71)
        dgvProd.Margin = New Padding(3, 2, 3, 2)
        dgvProd.Name = "dgvProd"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.Gray
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.AppWorkspace
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvProd.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvProd.RowHeadersWidth = 51
        dgvProd.Size = New Size(784, 313)
        dgvProd.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(TableLayoutPanel3)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Location = New Point(92, 88)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(324, 483)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.BackColor = Color.Transparent
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(btnDelete, 0, 0)
        TableLayoutPanel3.Location = New Point(6, 409)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(312, 69)
        TableLayoutPanel3.TabIndex = 12
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.None
        btnDelete.BackColor = Color.Transparent
        btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), Image)
        btnDelete.BackgroundImageLayout = ImageLayout.Stretch
        btnDelete.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(101, 11)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 46)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.BackColor = Color.Transparent
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(btnUpldImg, 0, 0)
        TableLayoutPanel2.Controls.Add(btnEdit, 1, 0)
        TableLayoutPanel2.Location = New Point(6, 343)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel2.Size = New Size(312, 71)
        TableLayoutPanel2.TabIndex = 11
        ' 
        ' btnUpldImg
        ' 
        btnUpldImg.Anchor = AnchorStyles.None
        btnUpldImg.BackColor = Color.Transparent
        btnUpldImg.BackgroundImage = CType(resources.GetObject("btnUpldImg.BackgroundImage"), Image)
        btnUpldImg.BackgroundImageLayout = ImageLayout.Stretch
        btnUpldImg.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpldImg.ForeColor = SystemColors.ButtonHighlight
        btnUpldImg.Location = New Point(23, 12)
        btnUpldImg.Margin = New Padding(3, 2, 3, 2)
        btnUpldImg.Name = "btnUpldImg"
        btnUpldImg.Size = New Size(110, 46)
        btnUpldImg.TabIndex = 9
        btnUpldImg.Text = "Upload"
        btnUpldImg.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.None
        btnEdit.BackColor = Color.Transparent
        btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), Image)
        btnEdit.BackgroundImageLayout = ImageLayout.Stretch
        btnEdit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(179, 12)
        btnEdit.Margin = New Padding(3, 2, 3, 2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(110, 46)
        btnEdit.TabIndex = 10
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.None
        TableLayoutPanel1.BackColor = Color.Transparent
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(txtProdDesc, 0, 7)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(txtProdName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(txtProdPrice, 0, 3)
        TableLayoutPanel1.Controls.Add(Label4, 0, 6)
        TableLayoutPanel1.Controls.Add(Label3, 0, 4)
        TableLayoutPanel1.Controls.Add(txtProdStk, 0, 5)
        TableLayoutPanel1.Location = New Point(6, 13)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        TableLayoutPanel1.Size = New Size(312, 324)
        TableLayoutPanel1.TabIndex = 10
        ' 
        ' txtProdDesc
        ' 
        txtProdDesc.Anchor = AnchorStyles.None
        txtProdDesc.Location = New Point(84, 290)
        txtProdDesc.Margin = New Padding(3, 2, 3, 2)
        txtProdDesc.Name = "txtProdDesc"
        txtProdDesc.Size = New Size(144, 23)
        txtProdDesc.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(127, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 6
        Label1.Text = "Name:"
        ' 
        ' txtProdName
        ' 
        txtProdName.Anchor = AnchorStyles.None
        txtProdName.Font = New Font("Segoe UI", 11F)
        txtProdName.Location = New Point(85, 46)
        txtProdName.Margin = New Padding(3, 2, 3, 2)
        txtProdName.Name = "txtProdName"
        txtProdName.Size = New Size(142, 27)
        txtProdName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(131, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 23)
        Label2.TabIndex = 7
        Label2.Text = "Price:"
        ' 
        ' txtProdPrice
        ' 
        txtProdPrice.Anchor = AnchorStyles.None
        txtProdPrice.Font = New Font("Segoe UI", 11F)
        txtProdPrice.Location = New Point(113, 126)
        txtProdPrice.Margin = New Padding(3, 2, 3, 2)
        txtProdPrice.Name = "txtProdPrice"
        txtProdPrice.Size = New Size(86, 27)
        txtProdPrice.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(109, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 23)
        Label4.TabIndex = 9
        Label4.Text = "Description:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(130, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 23)
        Label3.TabIndex = 8
        Label3.Text = "Stock:"
        ' 
        ' txtProdStk
        ' 
        txtProdStk.Anchor = AnchorStyles.None
        txtProdStk.Font = New Font("Segoe UI", 11F)
        txtProdStk.Location = New Point(111, 206)
        txtProdStk.Margin = New Padding(3, 2, 3, 2)
        txtProdStk.Name = "txtProdStk"
        txtProdStk.Size = New Size(89, 27)
        txtProdStk.TabIndex = 4
        ' 
        ' pbProd
        ' 
        pbProd.Anchor = AnchorStyles.None
        pbProd.BackColor = Color.DimGray
        pbProd.BorderStyle = BorderStyle.Fixed3D
        pbProd.Location = New Point(1294, 170)
        pbProd.Margin = New Padding(3, 2, 3, 2)
        pbProd.Name = "pbProd"
        pbProd.Size = New Size(262, 313)
        pbProd.TabIndex = 0
        pbProd.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.BackColor = Color.DimGray
        Panel2.Controls.Add(btnExport)
        Panel2.Controls.Add(btnAdd)
        Panel2.Location = New Point(6, 388)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(784, 58)
        Panel2.TabIndex = 5
        ' 
        ' btnExport
        ' 
        btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), Image)
        btnExport.BackgroundImageLayout = ImageLayout.Stretch
        btnExport.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnExport.ForeColor = SystemColors.ButtonHighlight
        btnExport.Location = New Point(511, 4)
        btnExport.Margin = New Padding(3, 2, 3, 2)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(121, 50)
        btnExport.TabIndex = 3
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), Image)
        btnAdd.BackgroundImageLayout = ImageLayout.Stretch
        btnAdd.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = SystemColors.ControlLightLight
        btnAdd.Location = New Point(163, 4)
        btnAdd.Margin = New Padding(3, 2, 3, 2)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(171, 52)
        btnAdd.TabIndex = 2
        btnAdd.Text = "Add New Stock Item"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.None
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(dgvProd)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Location = New Point(460, 101)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(796, 454)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.Transparent
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.BackgroundImageLayout = ImageLayout.Stretch
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(92, 38)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 46)
        btnBack.TabIndex = 8
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' FormManageProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1603, 656)
        Controls.Add(btnBack)
        Controls.Add(GroupBox1)
        Controls.Add(pbProd)
        Controls.Add(GroupBox2)
        DoubleBuffered = True
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormManageProducts"
        Text = "FormManageProducts"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvProd, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(pbProd, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbCat As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtProdDesc As TextBox
    Friend WithEvents txtProdStk As TextBox
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents pbProd As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExport As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnBack As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpldImg As Button
    Friend WithEvents btnEdit As Button
End Class
