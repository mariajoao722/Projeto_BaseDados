Public Class Form1
    Private Sub miConsultar_Click(sender As Object, e As EventArgs) Handles miConsultar.Click
        consultar.Show()
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        stock.Show()
    End Sub

    Private Sub miFzrPedido_Click(sender As Object, e As EventArgs) Handles miFzrPedido.Click
        FzrPedido.Show()
    End Sub

    Private Sub miFecho_Click(sender As Object, e As EventArgs) Handles miFecho.Click
        fecho.Show()
    End Sub
End Class
