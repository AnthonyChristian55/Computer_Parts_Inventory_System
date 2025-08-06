<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStaff))
        btnMngProd = New Button()
        btnViewSales = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' btnMngProd
        ' 
        btnMngProd.Anchor = AnchorStyles.None
        btnMngProd.BackgroundImage = CType(resources.GetObject("btnMngProd.BackgroundImage"), Image)
        btnMngProd.BackgroundImageLayout = ImageLayout.Stretch
        btnMngProd.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btnMngProd.ForeColor = SystemColors.ButtonHighlight
        btnMngProd.Location = New Point(222, 190)
        btnMngProd.Margin = New Padding(3, 2, 3, 2)
        btnMngProd.Name = "btnMngProd"
        btnMngProd.Size = New Size(205, 94)
        btnMngProd.TabIndex = 2
        btnMngProd.Text = "Manage Products"
        btnMngProd.UseVisualStyleBackColor = True
        ' 
        ' btnViewSales
        ' 
        btnViewSales.Anchor = AnchorStyles.None
        btnViewSales.BackgroundImage = CType(resources.GetObject("btnViewSales.BackgroundImage"), Image)
        btnViewSales.BackgroundImageLayout = ImageLayout.Stretch
        btnViewSales.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btnViewSales.ForeColor = SystemColors.ButtonHighlight
        btnViewSales.Location = New Point(525, 190)
        btnViewSales.Margin = New Padding(3, 2, 3, 2)
        btnViewSales.Name = "btnViewSales"
        btnViewSales.Size = New Size(205, 94)
        btnViewSales.TabIndex = 5
        btnViewSales.Text = "View Sales"
        btnViewSales.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.Font = New Font("Consolas", 15F, FontStyle.Bold)
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.Location = New Point(357, 333)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(244, 72)
        btnLogout.TabIndex = 6
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' FormStaff
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(983, 565)
        Controls.Add(btnLogout)
        Controls.Add(btnViewSales)
        Controls.Add(btnMngProd)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormStaff"
        Text = "FormStaff"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMngProd As Button
    Friend WithEvents btnViewSales As Button
    Friend WithEvents btnLogout As Button
End Class
