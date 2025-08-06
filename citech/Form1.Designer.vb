<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        Button1 = New Button()
        txtPW = New TextBox()
        txtUName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(TableLayoutPanel1)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(274, 186)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(447, 359)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(Button1, 0, 4)
        TableLayoutPanel1.Controls.Add(txtPW, 0, 3)
        TableLayoutPanel1.Controls.Add(txtUName, 0, 1)
        TableLayoutPanel1.Controls.Add(Label2, 0, 2)
        TableLayoutPanel1.Controls.Add(Label1, 0, 0)
        TableLayoutPanel1.Location = New Point(6, 14)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 5
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 40F))
        TableLayoutPanel1.Size = New Size(435, 332)
        TableLayoutPanel1.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Font = New Font("Consolas", 15F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(95, 228)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(244, 72)
        Button1.TabIndex = 2
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtPW
        ' 
        txtPW.Anchor = AnchorStyles.None
        txtPW.Font = New Font("Segoe UI", 15F)
        txtPW.Location = New Point(116, 154)
        txtPW.Margin = New Padding(3, 2, 3, 2)
        txtPW.Name = "txtPW"
        txtPW.PasswordChar = "*"c
        txtPW.Size = New Size(203, 34)
        txtPW.TabIndex = 1
        ' 
        ' txtUName
        ' 
        txtUName.Anchor = AnchorStyles.None
        txtUName.Font = New Font("Segoe UI", 15F)
        txtUName.Location = New Point(120, 56)
        txtUName.Margin = New Padding(3, 2, 3, 2)
        txtUName.Name = "txtUName"
        txtUName.Size = New Size(194, 34)
        txtUName.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(163, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 23)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD:"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(157, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 23)
        Label1.TabIndex = 3
        Label1.Text = "USERNAME: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(924, 585)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtPW As TextBox
    Friend WithEvents txtUName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
