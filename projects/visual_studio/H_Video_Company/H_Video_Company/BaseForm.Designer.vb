<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayStudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lbxVideoRental = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblRentalCustID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerRentalDataSet = New CustomerRentalDataSet()
        Me.CustomerRentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerRentalTableAdapter = New CustomerRentalDataSetTableAdapters.CustomerRentalTableAdapter()
        Me.TableAdapterManager = New CustomerRentalDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(801, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayStudioToolStripMenuItem, Me.DisplayVideoToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'DisplayStudioToolStripMenuItem
        '
        Me.DisplayStudioToolStripMenuItem.Name = "DisplayStudioToolStripMenuItem"
        Me.DisplayStudioToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DisplayStudioToolStripMenuItem.Text = "Display Studio"
        '
        'DisplayVideoToolStripMenuItem
        '
        Me.DisplayVideoToolStripMenuItem.Name = "DisplayVideoToolStripMenuItem"
        Me.DisplayVideoToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DisplayVideoToolStripMenuItem.Text = "Display Video"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'picLogo
        '
        Me.picLogo.Image = Global.BaseForm.My.Resources.Resources.H_Video_Image
        Me.picLogo.Location = New System.Drawing.Point(286, 40)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(219, 170)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lbxVideoRental
        '
        Me.lbxVideoRental.FormattingEnabled = True
        Me.lbxVideoRental.Location = New System.Drawing.Point(222, 366)
        Me.lbxVideoRental.Name = "lbxVideoRental"
        Me.lbxVideoRental.Size = New System.Drawing.Size(357, 121)
        Me.lbxVideoRental.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.GhostWhite
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Location = New System.Drawing.Point(363, 502)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblRentalCustID
        '
        Me.lblRentalCustID.AutoSize = True
        Me.lblRentalCustID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRentalCustID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblRentalCustID.Location = New System.Drawing.Point(222, 262)
        Me.lblRentalCustID.Name = "lblRentalCustID"
        Me.lblRentalCustID.Size = New System.Drawing.Size(144, 17)
        Me.lblRentalCustID.TabIndex = 5
        Me.lblRentalCustID.Text = "Customer ID:     00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(225, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Name:              John Doe"
        '
        'CustomerRentalDataSet
        '
        Me.CustomerRentalDataSet.DataSetName = "CustomerRentalDataSet"
        Me.CustomerRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerRentalBindingSource
        '
        Me.CustomerRentalBindingSource.DataMember = "CustomerRental"
        Me.CustomerRentalBindingSource.DataSource = Me.CustomerRentalDataSet
        '
        'CustomerRentalTableAdapter
        '
        Me.CustomerRentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerRentalTableAdapter = Me.CustomerRentalTableAdapter
        Me.TableAdapterManager.UpdateOrder = CustomerRentalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 553)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblRentalCustID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbxVideoRental)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BaseForm"
        Me.Text = "H Video Company"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayStudioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplayVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbxVideoRental As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblRentalCustID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomerRentalDataSet As CustomerRentalDataSet
    Friend WithEvents CustomerRentalBindingSource As BindingSource
    Friend WithEvents CustomerRentalTableAdapter As CustomerRentalDataSetTableAdapters.CustomerRentalTableAdapter
    Friend WithEvents TableAdapterManager As CustomerRentalDataSetTableAdapters.TableAdapterManager
End Class
