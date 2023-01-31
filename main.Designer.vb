<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatigoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutonumerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(16, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ManageUserToolStripMenuItem, Me.AutonumerToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.StockReturnToolStripMenuItem, Me.TransctionToolStripMenuItem, Me.StockToolStripMenuItem, Me.RequestItemToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.SMSToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 100)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 83)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(78, 79)
        Me.FileToolStripMenuItem.Text = "Home"
        Me.FileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatigoryToolStripMenuItem, Me.MODELToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(96, 79)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        Me.SettingsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CatigoryToolStripMenuItem
        '
        Me.CatigoryToolStripMenuItem.Name = "CatigoryToolStripMenuItem"
        Me.CatigoryToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
        Me.CatigoryToolStripMenuItem.Text = "Catigory"
        '
        'MODELToolStripMenuItem
        '
        Me.MODELToolStripMenuItem.Name = "MODELToolStripMenuItem"
        Me.MODELToolStripMenuItem.Size = New System.Drawing.Size(161, 30)
        Me.MODELToolStripMenuItem.Text = "MODEL"
        '
        'ManageUserToolStripMenuItem
        '
        Me.ManageUserToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ManageUserToolStripMenuItem.Image = CType(resources.GetObject("ManageUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ManageUserToolStripMenuItem.Name = "ManageUserToolStripMenuItem"
        Me.ManageUserToolStripMenuItem.Size = New System.Drawing.Size(141, 79)
        Me.ManageUserToolStripMenuItem.Text = "Manage User"
        Me.ManageUserToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AutonumerToolStripMenuItem
        '
        Me.AutonumerToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutonumerToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutonumerToolStripMenuItem.Image = CType(resources.GetObject("AutonumerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AutonumerToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AutonumerToolStripMenuItem.Name = "AutonumerToolStripMenuItem"
        Me.AutonumerToolStripMenuItem.Size = New System.Drawing.Size(127, 79)
        Me.AutonumerToolStripMenuItem.Text = "Autonumer"
        Me.AutonumerToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AutonumerToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(94, 79)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StockReturnToolStripMenuItem
        '
        Me.StockReturnToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.StockReturnToolStripMenuItem.Image = CType(resources.GetObject("StockReturnToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockReturnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockReturnToolStripMenuItem.Name = "StockReturnToolStripMenuItem"
        Me.StockReturnToolStripMenuItem.Size = New System.Drawing.Size(140, 79)
        Me.StockReturnToolStripMenuItem.Text = "Stock Return"
        Me.StockReturnToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TransctionToolStripMenuItem
        '
        Me.TransctionToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TransctionToolStripMenuItem.Image = CType(resources.GetObject("TransctionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TransctionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TransctionToolStripMenuItem.Name = "TransctionToolStripMenuItem"
        Me.TransctionToolStripMenuItem.Size = New System.Drawing.Size(135, 79)
        Me.TransctionToolStripMenuItem.Text = "Transactions"
        Me.TransctionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TransctionToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.StockToolStripMenuItem.Image = CType(resources.GetObject("StockToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(74, 79)
        Me.StockToolStripMenuItem.Text = "Stock"
        Me.StockToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RequestItemToolStripMenuItem
        '
        Me.RequestItemToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.RequestItemToolStripMenuItem.Image = CType(resources.GetObject("RequestItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RequestItemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RequestItemToolStripMenuItem.Name = "RequestItemToolStripMenuItem"
        Me.RequestItemToolStripMenuItem.Size = New System.Drawing.Size(140, 79)
        Me.RequestItemToolStripMenuItem.Text = "Request Item"
        Me.RequestItemToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RequestItemToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.ServicesToolStripMenuItem.Image = CType(resources.GetObject("ServicesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(96, 79)
        Me.ServicesToolStripMenuItem.Text = "Services"
        Me.ServicesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SMSToolStripMenuItem
        '
        Me.SMSToolStripMenuItem.Image = CType(resources.GetObject("SMSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SMSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem"
        Me.SMSToolStripMenuItem.Size = New System.Drawing.Size(64, 79)
        Me.SMSToolStripMenuItem.Text = "SMS"
        Me.SMSToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(89, 79)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(556, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 29)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1370, 100)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Motor Trade Inventory System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Supplier"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button12)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 183)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 566)
        Me.Panel1.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 521)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Reservation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Orders"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Credit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Customer"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 79)
        Me.Button4.TabIndex = 26
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(11, 113)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(110, 79)
        Me.Button5.TabIndex = 27
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(11, 234)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 78)
        Me.Button8.TabIndex = 30
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(12, 343)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(109, 68)
        Me.Button12.TabIndex = 34
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 71)
        Me.Button2.TabIndex = 24
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(452, 279)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(670, 359)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteTableToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(187, 30)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'DeleteTableToolStripMenuItem
        '
        Me.DeleteTableToolStripMenuItem.Name = "DeleteTableToolStripMenuItem"
        Me.DeleteTableToolStripMenuItem.Size = New System.Drawing.Size(191, 30)
        Me.DeleteTableToolStripMenuItem.Text = "Delete Table"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents AutonumerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CatigoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TransctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
