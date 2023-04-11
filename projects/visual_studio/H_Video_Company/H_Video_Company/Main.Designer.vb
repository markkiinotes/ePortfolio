<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim WorkPhoneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.VBVideoDataSet = New BaseForm.VBVideoDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New BaseForm.VBVideoDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New BaseForm.VBVideoDataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.grpAddress = New System.Windows.Forms.GroupBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.grpCustomerInfo = New System.Windows.Forms.GroupBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.WorkPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.HomePhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.btnRentals = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        WorkPhoneLabel = New System.Windows.Forms.Label()
        CType(Me.VBVideoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.grpAddress.SuspendLayout()
        Me.grpCustomerInfo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(554, 108)
        LastNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(106, 20)
        LastNameLabel.TabIndex = 13
        LastNameLabel.Text = "Last Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(6, 105)
        FirstNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(108, 20)
        FirstNameLabel.TabIndex = 11
        FirstNameLabel.Text = "First Name:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(6, 40)
        CustomerIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(121, 20)
        CustomerIDLabel.TabIndex = 9
        CustomerIDLabel.Text = "Customer ID:"
        '
        'StreetLabel
        '
        StreetLabel.AutoSize = True
        StreetLabel.Location = New System.Drawing.Point(22, 57)
        StreetLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(66, 20)
        StreetLabel.TabIndex = 0
        StreetLabel.Text = "Street:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(22, 131)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(48, 20)
        CityLabel.TabIndex = 2
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(543, 131)
        StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(59, 20)
        StateLabel.TabIndex = 4
        StateLabel.Text = "State:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(777, 131)
        ZipCodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(89, 20)
        ZipCodeLabel.TabIndex = 6
        ZipCodeLabel.Text = "Zip Code:"
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Location = New System.Drawing.Point(136, 62)
        HomePhoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(122, 20)
        HomePhoneLabel.TabIndex = 3
        HomePhoneLabel.Text = "Home Phone:"
        '
        'WorkPhoneLabel
        '
        WorkPhoneLabel.AutoSize = True
        WorkPhoneLabel.Location = New System.Drawing.Point(650, 62)
        WorkPhoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        WorkPhoneLabel.Name = "WorkPhoneLabel"
        WorkPhoneLabel.Size = New System.Drawing.Size(116, 20)
        WorkPhoneLabel.TabIndex = 4
        WorkPhoneLabel.Text = "Work Phone:"
        '
        'VBVideoDataSet
        '
        Me.VBVideoDataSet.DataSetName = "VBVideoDataSet"
        Me.VBVideoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.VBVideoDataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.UpdateOrder = BaseForm.VBVideoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 35)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(1202, 33)
        Me.CustomerBindingNavigator.TabIndex = 3
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 33)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 33)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'grpAddress
        '
        Me.grpAddress.Controls.Add(ZipCodeLabel)
        Me.grpAddress.Controls.Add(Me.ZipCodeTextBox)
        Me.grpAddress.Controls.Add(StateLabel)
        Me.grpAddress.Controls.Add(Me.StateTextBox)
        Me.grpAddress.Controls.Add(CityLabel)
        Me.grpAddress.Controls.Add(Me.CityTextBox)
        Me.grpAddress.Controls.Add(StreetLabel)
        Me.grpAddress.Controls.Add(Me.StreetTextBox)
        Me.grpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grpAddress.Location = New System.Drawing.Point(69, 487)
        Me.grpAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpAddress.Name = "grpAddress"
        Me.grpAddress.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpAddress.Size = New System.Drawing.Size(1062, 200)
        Me.grpAddress.TabIndex = 9
        Me.grpAddress.TabStop = False
        Me.grpAddress.Text = "Address"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(882, 126)
        Me.ZipCodeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(148, 26)
        Me.ZipCodeTextBox.TabIndex = 7
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(604, 126)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(64, 26)
        Me.StateTextBox.TabIndex = 5
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(98, 126)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(398, 26)
        Me.CityTextBox.TabIndex = 3
        '
        'StreetTextBox
        '
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Street", True))
        Me.StreetTextBox.Location = New System.Drawing.Point(98, 52)
        Me.StreetTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(932, 26)
        Me.StreetTextBox.TabIndex = 1
        '
        'grpCustomerInfo
        '
        Me.grpCustomerInfo.Controls.Add(LastNameLabel)
        Me.grpCustomerInfo.Controls.Add(Me.LastNameTextBox)
        Me.grpCustomerInfo.Controls.Add(FirstNameLabel)
        Me.grpCustomerInfo.Controls.Add(Me.FirstNameTextBox)
        Me.grpCustomerInfo.Controls.Add(CustomerIDLabel)
        Me.grpCustomerInfo.Controls.Add(Me.CustomerIDTextBox)
        Me.grpCustomerInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerInfo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.grpCustomerInfo.Location = New System.Drawing.Point(69, 311)
        Me.grpCustomerInfo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpCustomerInfo.Name = "grpCustomerInfo"
        Me.grpCustomerInfo.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpCustomerInfo.Size = New System.Drawing.Size(1062, 165)
        Me.grpCustomerInfo.TabIndex = 10
        Me.grpCustomerInfo.TabStop = False
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(670, 103)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(368, 26)
        Me.LastNameTextBox.TabIndex = 14
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(134, 100)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(380, 26)
        Me.FirstNameTextBox.TabIndex = 12
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(134, 35)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(148, 26)
        Me.CustomerIDTextBox.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(WorkPhoneLabel)
        Me.GroupBox3.Controls.Add(Me.WorkPhoneMaskedTextBox)
        Me.GroupBox3.Controls.Add(HomePhoneLabel)
        Me.GroupBox3.Controls.Add(Me.HomePhoneMaskedTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(69, 725)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(1062, 140)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Phone Informatoin"
        '
        'WorkPhoneMaskedTextBox
        '
        Me.WorkPhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "WorkPhone", True))
        Me.WorkPhoneMaskedTextBox.Location = New System.Drawing.Point(780, 57)
        Me.WorkPhoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WorkPhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.WorkPhoneMaskedTextBox.Name = "WorkPhoneMaskedTextBox"
        Me.WorkPhoneMaskedTextBox.Size = New System.Drawing.Size(140, 26)
        Me.WorkPhoneMaskedTextBox.TabIndex = 5
        '
        'HomePhoneMaskedTextBox
        '
        Me.HomePhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "HomePhone", True))
        Me.HomePhoneMaskedTextBox.Location = New System.Drawing.Point(270, 57)
        Me.HomePhoneMaskedTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HomePhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.HomePhoneMaskedTextBox.Name = "HomePhoneMaskedTextBox"
        Me.HomePhoneMaskedTextBox.Size = New System.Drawing.Size(142, 26)
        Me.HomePhoneMaskedTextBox.TabIndex = 4
        '
        'btnRentals
        '
        Me.btnRentals.BackColor = System.Drawing.Color.GhostWhite
        Me.btnRentals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRentals.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnRentals.Location = New System.Drawing.Point(320, 903)
        Me.btnRentals.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRentals.Name = "btnRentals"
        Me.btnRentals.Size = New System.Drawing.Size(112, 35)
        Me.btnRentals.TabIndex = 12
        Me.btnRentals.Text = "Rentals"
        Me.btnRentals.UseVisualStyleBackColor = False
        '
        'btnCheckOut
        '
        Me.btnCheckOut.BackColor = System.Drawing.Color.GhostWhite
        Me.btnCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCheckOut.Location = New System.Drawing.Point(768, 903)
        Me.btnCheckOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(112, 35)
        Me.btnCheckOut.TabIndex = 12
        Me.btnCheckOut.Text = "Check Out"
        Me.btnCheckOut.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(1202, 971)
        Me.Controls.Add(Me.btnCheckOut)
        Me.Controls.Add(Me.btnRentals)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpCustomerInfo)
        Me.Controls.Add(Me.grpAddress)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Main"
        Me.Text = "H Video -- Main"
        Me.Controls.SetChildIndex(Me.CustomerBindingNavigator, 0)
        Me.Controls.SetChildIndex(Me.grpAddress, 0)
        Me.Controls.SetChildIndex(Me.grpCustomerInfo, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnRentals, 0)
        Me.Controls.SetChildIndex(Me.btnCheckOut, 0)
        CType(Me.VBVideoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.grpAddress.ResumeLayout(False)
        Me.grpAddress.PerformLayout()
        Me.grpCustomerInfo.ResumeLayout(False)
        Me.grpCustomerInfo.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VBVideoDataSet As VBVideoDataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As VBVideoDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As VBVideoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents grpAddress As GroupBox
    Friend WithEvents grpCustomerInfo As GroupBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents WorkPhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents HomePhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents btnRentals As Button
    Friend WithEvents btnCheckOut As Button
End Class
