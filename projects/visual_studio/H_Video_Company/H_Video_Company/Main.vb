Public Class Main
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBVideoDataSet)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBVideoDataSet.Customer' table. You can move, or remove it, as needed.
        CustomerTableAdapter.Fill(VBVideoDataSet.Customer)

    End Sub
End Class
