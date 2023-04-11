Public Class Video
    Private Sub VideoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VideoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VBVideoDataSet1)

    End Sub

    Private Sub Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VBVideoDataSet1.Video' table. You can move, or remove it, as needed.
        Me.VideoTableAdapter.Fill(Me.VBVideoDataSet1.Video)

    End Sub
End Class
