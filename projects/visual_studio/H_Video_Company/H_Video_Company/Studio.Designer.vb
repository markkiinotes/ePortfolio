<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Studio
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
        Me.StudioDataSet1 = New StudioDataSet1()
        Me.StudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudioTableAdapter = New StudioDataSet1TableAdapters.StudioTableAdapter()
        Me.TableAdapterManager = New StudioDataSet1TableAdapters.TableAdapterManager()
        Me.StudioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StudioDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudioDataSet1
        '
        Me.StudioDataSet1.DataSetName = "StudioDataSet1"
        Me.StudioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudioBindingSource
        '
        Me.StudioBindingSource.DataMember = "Studio"
        Me.StudioBindingSource.DataSource = Me.StudioDataSet1
        '
        'StudioTableAdapter
        '
        Me.StudioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudioTableAdapter = Me.StudioTableAdapter
        Me.TableAdapterManager.UpdateOrder = StudioDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudioDataGridView
        '
        Me.StudioDataGridView.AutoGenerateColumns = False
        Me.StudioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.StudioDataGridView.DataSource = Me.StudioBindingSource
        Me.StudioDataGridView.Location = New System.Drawing.Point(174, 245)
        Me.StudioDataGridView.Name = "StudioDataGridView"
        Me.StudioDataGridView.Size = New System.Drawing.Size(442, 220)
        Me.StudioDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Studio ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Studio ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Studio Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Studio Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contact Person"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Studio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(791, 520)
        Me.Controls.Add(Me.StudioDataGridView)
        Me.Name = "Studio"
        Me.Text = "H Video -- Studio"
        Me.Controls.SetChildIndex(Me.StudioDataGridView, 0)
        CType(Me.StudioDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudioDataSet1 As StudioDataSet1
    Friend WithEvents StudioBindingSource As BindingSource
    Friend WithEvents StudioTableAdapter As StudioDataSet1TableAdapters.StudioTableAdapter
    Friend WithEvents TableAdapterManager As StudioDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents StudioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
