Public Class Studio
    Private Sub StudioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudioDataSet1)

    End Sub

    Private Sub Studio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudioDataSet1.Studio' table. You can move, or remove it, as needed.
        Me.StudioTableAdapter.Fill(Me.StudioDataSet1.Studio)

    End Sub
End Class
