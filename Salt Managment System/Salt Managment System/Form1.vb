Public Class Form1
    Private Sub ProductmasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductmasterToolStripMenuItem.Click
        Dim d As New Product_master
        d.MdiParent = Me
        d.Show()
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ProductmasterToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub LabourmasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LabourmasterToolStripMenuItem.Click
        Dim d As New Labour_master
        d.MdiParent = Me
        d.Show()
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LabourmasterToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        LedgermasterToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub LedgermasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LedgermasterToolStripMenuItem.Click
        Dim d As New Ledger_master
        d.MdiParent = Me
        d.Show()
    End Sub
    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
