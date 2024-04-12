Public Class Form1
    Private Sub miInventario_Click(sender As Object, e As EventArgs) Handles miInventario.Click
        Inventario.Show()
    End Sub

    Private Sub AtualizarStockArmazemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtualizarStockArmazemToolStripMenuItem.Click
        AtualizarArmazem.Show()
    End Sub

    Private Sub TransferirStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferirStockToolStripMenuItem.Click
        TransferirStock.Show()
    End Sub
End Class
