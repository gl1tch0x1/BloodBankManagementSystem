<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CampaignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CertificateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CertificateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IncreaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DecreaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateDonoruserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloodTestDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BloodToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BloodTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TestDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.CampaignToolStripMenuItem, Me.CertificateToolStripMenuItem, Me.StockToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.BloodToolStripMenuItem, Me.BloodToolStripMenuItem1, Me.LogoutToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 38)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDonorToolStripMenuItem, Me.DetailsToolStripMenuItem, Me.DeleteDonorToolStripMenuItem, Me.AddUserToolStripMenuItem})
        Me.AddToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.donor
        Me.AddToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(85, 34)
        Me.AddToolStripMenuItem.Text = "ADD"
        '
        'AddDonorToolStripMenuItem
        '
        Me.AddDonorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddDonorToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.AddDonorToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem"
        Me.AddDonorToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.AddDonorToolStripMenuItem.Text = "Add Donor"
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DetailsToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.details
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.DetailsToolStripMenuItem.Text = "Donor Details"
        '
        'DeleteDonorToolStripMenuItem
        '
        Me.DeleteDonorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DeleteDonorToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.delete
        Me.DeleteDonorToolStripMenuItem.Name = "DeleteDonorToolStripMenuItem"
        Me.DeleteDonorToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.DeleteDonorToolStripMenuItem.Text = "Delete donor"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(213, 34)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'CampaignToolStripMenuItem
        '
        Me.CampaignToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CampaignToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.campaign
        Me.CampaignToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CampaignToolStripMenuItem.Name = "CampaignToolStripMenuItem"
        Me.CampaignToolStripMenuItem.Size = New System.Drawing.Size(135, 34)
        Me.CampaignToolStripMenuItem.Text = "Campaign"
        '
        'CertificateToolStripMenuItem
        '
        Me.CertificateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CertificateToolStripMenuItem1})
        Me.CertificateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CertificateToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.certificate1
        Me.CertificateToolStripMenuItem.Name = "CertificateToolStripMenuItem"
        Me.CertificateToolStripMenuItem.Size = New System.Drawing.Size(135, 34)
        Me.CertificateToolStripMenuItem.Text = "Certificate"
        '
        'CertificateToolStripMenuItem1
        '
        Me.CertificateToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CertificateToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CertificateToolStripMenuItem1.Name = "CertificateToolStripMenuItem1"
        Me.CertificateToolStripMenuItem1.Size = New System.Drawing.Size(180, 34)
        Me.CertificateToolStripMenuItem1.Text = "Certificate"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseToolStripMenuItem, Me.DecreaseToolStripMenuItem, Me.ViewDetailsToolStripMenuItem})
        Me.StockToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(74, 34)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'IncreaseToolStripMenuItem
        '
        Me.IncreaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.IncreaseToolStripMenuItem.Name = "IncreaseToolStripMenuItem"
        Me.IncreaseToolStripMenuItem.Size = New System.Drawing.Size(196, 34)
        Me.IncreaseToolStripMenuItem.Text = "Increase"
        '
        'DecreaseToolStripMenuItem
        '
        Me.DecreaseToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DecreaseToolStripMenuItem.Name = "DecreaseToolStripMenuItem"
        Me.DecreaseToolStripMenuItem.Size = New System.Drawing.Size(196, 34)
        Me.DecreaseToolStripMenuItem.Text = "Decrease"
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(196, 34)
        Me.ViewDetailsToolStripMenuItem.Text = "View details"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateDonoruserToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.update
        Me.UpdateToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(108, 34)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'UpdateDonoruserToolStripMenuItem
        '
        Me.UpdateDonoruserToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UpdateDonoruserToolStripMenuItem.Name = "UpdateDonoruserToolStripMenuItem"
        Me.UpdateDonoruserToolStripMenuItem.Size = New System.Drawing.Size(217, 34)
        Me.UpdateDonoruserToolStripMenuItem.Text = "Update Donor"
        '
        'BloodToolStripMenuItem
        '
        Me.BloodToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BloodTestDetailsToolStripMenuItem})
        Me.BloodToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodToolStripMenuItem.Name = "BloodToolStripMenuItem"
        Me.BloodToolStripMenuItem.Size = New System.Drawing.Size(12, 34)
        '
        'BloodTestDetailsToolStripMenuItem
        '
        Me.BloodTestDetailsToolStripMenuItem.Name = "BloodTestDetailsToolStripMenuItem"
        Me.BloodTestDetailsToolStripMenuItem.Size = New System.Drawing.Size(187, 34)
        Me.BloodTestDetailsToolStripMenuItem.Text = "Blood Test "
        '
        'BloodToolStripMenuItem1
        '
        Me.BloodToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BloodTestToolStripMenuItem, Me.TestDetailsToolStripMenuItem})
        Me.BloodToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BloodToolStripMenuItem1.Name = "BloodToolStripMenuItem1"
        Me.BloodToolStripMenuItem1.Size = New System.Drawing.Size(78, 34)
        Me.BloodToolStripMenuItem1.Text = "Blood"
        '
        'BloodTestToolStripMenuItem
        '
        Me.BloodTestToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BloodTestToolStripMenuItem.Name = "BloodTestToolStripMenuItem"
        Me.BloodTestToolStripMenuItem.Size = New System.Drawing.Size(188, 34)
        Me.BloodTestToolStripMenuItem.Text = "blood test"
        '
        'TestDetailsToolStripMenuItem
        '
        Me.TestDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TestDetailsToolStripMenuItem.Name = "TestDetailsToolStripMenuItem"
        Me.TestDetailsToolStripMenuItem.Size = New System.Drawing.Size(188, 34)
        Me.TestDetailsToolStripMenuItem.Text = "Test details"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonorToolStripMenuItem})
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.search
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(98, 34)
        Me.LogoutToolStripMenuItem.Text = "Search"
        '
        'DonorToolStripMenuItem
        '
        Me.DonorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DonorToolStripMenuItem.Name = "DonorToolStripMenuItem"
        Me.DonorToolStripMenuItem.Size = New System.Drawing.Size(209, 30)
        Me.DonorToolStripMenuItem.Text = "Search Donor"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(89, 34)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(891, 522)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampaignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CertificateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDonoruserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodTestDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CertificateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
