<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesOverview
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesOverview))
        dgvSalesOverview = New DataGridView()
        dtpStartDate = New DateTimePicker()
        dtpEndDate = New DateTimePicker()
        btnFilter = New Button()
        btnBack = New Button()
        Timer1 = New Timer(components)
        btnExport = New Button()
        GroupBox1 = New GroupBox()
        CType(dgvSalesOverview, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvSalesOverview
        ' 
        dgvSalesOverview.Anchor = AnchorStyles.None
        dgvSalesOverview.BackgroundColor = Color.Gainsboro
        dgvSalesOverview.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Black
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvSalesOverview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvSalesOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = Color.Black
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvSalesOverview.DefaultCellStyle = DataGridViewCellStyle2
        dgvSalesOverview.EnableHeadersVisualStyles = False
        dgvSalesOverview.GridColor = Color.Black
        dgvSalesOverview.Location = New Point(217, 251)
        dgvSalesOverview.Name = "dgvSalesOverview"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.Gray
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvSalesOverview.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvSalesOverview.RowHeadersWidth = 51
        dgvSalesOverview.Size = New Size(965, 389)
        dgvSalesOverview.TabIndex = 0
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Anchor = AnchorStyles.None
        dtpStartDate.CalendarFont = New Font("Segoe UI", 12F)
        dtpStartDate.CalendarMonthBackground = Color.White
        dtpStartDate.Font = New Font("Segoe UI", 12F)
        dtpStartDate.Location = New Point(161, 44)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(293, 34)
        dtpStartDate.TabIndex = 1
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Anchor = AnchorStyles.None
        dtpEndDate.CalendarFont = New Font("Segoe UI", 12F)
        dtpEndDate.Font = New Font("Segoe UI", 12F)
        dtpEndDate.Location = New Point(517, 44)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(250, 34)
        dtpEndDate.TabIndex = 2
        ' 
        ' btnFilter
        ' 
        btnFilter.Anchor = AnchorStyles.None
        btnFilter.BackgroundImage = CType(resources.GetObject("btnFilter.BackgroundImage"), Image)
        btnFilter.BackgroundImageLayout = ImageLayout.Stretch
        btnFilter.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnFilter.ForeColor = SystemColors.ButtonHighlight
        btnFilter.Location = New Point(814, 36)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(121, 51)
        btnFilter.TabIndex = 3
        btnFilter.Text = "Filter"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Anchor = AnchorStyles.None
        btnBack.BackColor = Color.Transparent
        btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), Image)
        btnBack.BackgroundImageLayout = ImageLayout.Stretch
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnBack.ForeColor = SystemColors.ButtonHighlight
        btnBack.Location = New Point(199, 76)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(126, 61)
        btnBack.TabIndex = 4
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' btnExport
        ' 
        btnExport.Anchor = AnchorStyles.None
        btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), Image)
        btnExport.BackgroundImageLayout = ImageLayout.Stretch
        btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnExport.ForeColor = SystemColors.ButtonHighlight
        btnExport.Location = New Point(625, 712)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(195, 80)
        btnExport.TabIndex = 5
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(btnFilter)
        GroupBox1.Controls.Add(dtpEndDate)
        GroupBox1.Controls.Add(dtpStartDate)
        GroupBox1.Location = New Point(199, 144)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1002, 543)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        ' 
        ' FormSalesOverview
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1387, 828)
        Controls.Add(btnExport)
        Controls.Add(btnBack)
        Controls.Add(dgvSalesOverview)
        Controls.Add(GroupBox1)
        DoubleBuffered = True
        Name = "FormSalesOverview"
        Text = "FormSalesOverview"
        CType(dgvSalesOverview, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvSalesOverview As DataGridView
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnExport As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
