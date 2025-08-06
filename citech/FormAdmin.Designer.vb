<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdmin))
        btnMngUser = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' btnMngUser
        ' 
        btnMngUser.Anchor = AnchorStyles.None
        btnMngUser.BackgroundImage = CType(resources.GetObject("btnMngUser.BackgroundImage"), Image)
        btnMngUser.BackgroundImageLayout = ImageLayout.Stretch
        btnMngUser.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        btnMngUser.ForeColor = SystemColors.ButtonHighlight
        btnMngUser.Location = New Point(485, 202)
        btnMngUser.Margin = New Padding(3, 2, 3, 2)
        btnMngUser.Name = "btnMngUser"
        btnMngUser.Size = New Size(205, 94)
        btnMngUser.TabIndex = 0
        btnMngUser.Text = "Manage Users"
        btnMngUser.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.Font = New Font("Consolas", 15F, FontStyle.Bold)
        btnLogout.ForeColor = SystemColors.ButtonHighlight
        btnLogout.Location = New Point(465, 332)
        btnLogout.Margin = New Padding(3, 2, 3, 2)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(244, 72)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1156, 545)
        Controls.Add(btnLogout)
        Controls.Add(btnMngUser)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormAdmin"
        Text = "FormAdmin"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMngUser As Button
    Friend WithEvents btnLogout As Button
End Class
