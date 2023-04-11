Public Class BaseForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub DisplayStudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayStudioToolStripMenuItem.Click
        Dim frmStudio As New Studio

        frmStudio.ShowDialog()
    End Sub

    Private Sub DisplayVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        Dim frmVideo As New Video

        frmVideo.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frmAbout As New About
        frmAbout.ShowDialog()
    End Sub




End Class
