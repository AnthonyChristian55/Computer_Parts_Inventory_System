<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageUsers
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManageUsers))
        dgvUsers = New DataGridView()
        TableLayoutPanel2 = New TableLayoutPanel()
        btnAddAcc = New Button()
        btnDel = New Button()
        btnUpd = New Button()
        txtUName = New TextBox()
        txtPW = New TextBox()
        txtFullName = New TextBox()
        cmbRole = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnBack = New Button()
        GroupBox1 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label5 = New Label()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToOrderColumns = True
        dgvUsers.Anchor = AnchorStyles.None
        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvUsers.BackgroundColor = Color.Gainsboro
        dgvUsers.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvUsers.DefaultCellStyle = DataGridViewCellStyle2
        dgvUsers.EnableHeadersVisualStyles = False
        dgvUsers.GridColor = SystemColors.InactiveCaptionText
        dgvUsers.Location = New Point(113, 164)
        dgvUsers.Margin = New Padding(3, 2, 3, 2)
        dgvUsers.Name = "dgvUsers"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Gray
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12.0F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvUsers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsers.Size = New Size(632, 408)
        dgvUsers.TabIndex = 0
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel2.Controls.Add(btnAddAcc, 0, 0)
        TableLayoutPanel2.Controls.Add(btnDel, 2, 0)
        TableLayoutPanel2.Controls.Add(btnUpd, 1, 0)
        TableLayoutPanel2.Location = New Point(6, 321)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel2.Size = New Size(403, 101)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' btnAddAcc
        ' 
        btnAddAcc.Anchor = AnchorStyles.None
        btnAddAcc.BackgroundImage = CType(resources.GetObject("btnAddAcc.BackgroundImage"), Image)
        btnAddAcc.BackgroundImageLayout = ImageLayout.Stretch
        btnAddAcc.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnAddAcc.ForeColor = SystemColors.ControlLightLight
        btnAddAcc.Location = New Point(13, 26)
        btnAddAcc.Margin = New Padding(3, 2, 3, 2)
        btnAddAcc.Name = "btnAddAcc"
        btnAddAcc.Size = New Size(107, 49)
        btnAddAcc.TabIndex = 5
        btnAddAcc.Text = "ADD"
        btnAddAcc.UseVisualStyleBackColor = True
        ' 
        ' btnDel
        ' 
        btnDel.Anchor = AnchorStyles.None
        btnDel.BackgroundImage = CType(resources.GetObject("btnDel.BackgroundImage"), Image)
        btnDel.BackgroundImageLayout = ImageLayout.Stretch
        btnDel.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnDel.ForeColor = SystemColors.ControlLightLight
        btnDel.Location = New Point(285, 26)
        btnDel.Margin = New Padding(3, 2, 3, 2)
        btnDel.Name = "btnDel"
        btnDel.Size = New Size(100, 49)
        btnDel.TabIndex = 6
        btnDel.Text = "DELETE"
        btnDel.UseVisualStyleBackColor = True
        ' 
        ' btnUpd
        ' 
        btnUpd.Anchor = AnchorStyles.None
        btnUpd.BackgroundImage = CType(resources.GetObject("btnUpd.BackgroundImage"), Image)
        btnUpd.BackgroundImageLayout = ImageLayout.Stretch
        btnUpd.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnUpd.ForeColor = SystemColors.ControlLightLight
        btnUpd.Location = New Point(150, 26)
        btnUpd.Margin = New Padding(3, 2, 3, 2)
        btnUpd.Name = "btnUpd"
        btnUpd.Size = New Size(102, 49)
        btnUpd.TabIndex = 7
        btnUpd.Text = "UPDATE"
        btnUpd.UseVisualStyleBackColor = True
        ' 
        ' txtUName
        ' 
        txtUName.Anchor = AnchorStyles.None
        txtUName.Font = New Font("Segoe UI", 15.0F)
        txtUName.Location = New Point(101, 39)
        txtUName.Margin = New Padding(3, 2, 3, 2)
        txtUName.Name = "txtUName"
        txtUName.Size = New Size(201, 34)
        txtUName.TabIndex = 1
        ' 
        ' txtPW
        ' 
        txtPW.Anchor = AnchorStyles.None
        txtPW.Font = New Font("Segoe UI", 15.0F)
        txtPW.Location = New Point(101, 113)
        txtPW.Margin = New Padding(3, 2, 3, 2)
        txtPW.Name = "txtPW"
        txtPW.PasswordChar = "*"c
        txtPW.Size = New Size(201, 34)
        txtPW.TabIndex = 2
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.None
        txtFullName.Font = New Font("Segoe UI", 15.0F)
        txtFullName.Location = New Point(101, 187)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(201, 34)
        txtFullName.TabIndex = 3
        ' 
        ' cmbRole
        ' 
        cmbRole.Anchor = AnchorStyles.None
        cmbRole.Font = New Font("Segoe UI", 15.0F)
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Staff"})
        cmbRole.Location = New Point(101, 263)
        cmbRole.Margin = New Padding(3, 2, 3, 2)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(201, 36)
        cmbRole.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 15.0F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(147, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 23)
        Label1.TabIndex = 8
        Label1.Text = "USERNAME:" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 15.0F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(147, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 23)
        Label2.TabIndex = 9
        Label2.Text = "PASSWORD:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 15.0F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(147, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 23)
        Label3.TabIndex = 10
        Label3.Text = "FULLNAME:"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 15.0F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(169, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 23)
        Label4.TabIndex = 11
        Label4.Text = "ROLE:"
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.BackgroundImageLayout = ImageLayout.Stretch
        btnBack.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        btnBack.ForeColor = SystemColors.ControlLightLight
        btnBack.Location = New Point(113, 86)
        btnBack.Margin = New Padding(3, 2, 3, 2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(100, 49)
        btnBack.TabIndex = 12
        btnBack.Text = "BACK"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.Controls.Add(TableLayoutPanel2)
        GroupBox1.Location = New Point(832, 150)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(415, 428)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label4, 0, 6)
        TableLayoutPanel1.Controls.Add(txtUName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label3, 0, 4)
        TableLayoutPanel1.Controls.Add(cmbRole, 0, 7)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(txtPW, 0, 3)
        TableLayoutPanel1.Controls.Add(txtFullName, 0, 5)
        TableLayoutPanel1.Location = New Point(6, 14)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 8
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10.3857565F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 9.198813F))
        TableLayoutPanel1.Size = New Size(403, 301)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 30.0F, FontStyle.Bold)
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(592, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(284, 47)
        Label5.TabIndex = 14
        Label5.Text = "Manage Users"
        ' 
        ' FormManageUsers
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1304, 622)
        Controls.Add(Label5)
        Controls.Add(btnBack)
        Controls.Add(dgvUsers)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormManageUsers"
        Text = "FormManageUsers"
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents txtUName As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnAddAcc As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnUpd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label5 As Label

End Class
