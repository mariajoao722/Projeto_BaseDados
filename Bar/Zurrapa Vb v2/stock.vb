Public Class stock
    Public SQL As New SqlControl

    Public Sub LoadGrid1()
        cbxItems.Items.Clear()
        cbxItems.Items.Add("Sineiro")
        cbxItems.Items.Add("Avenida")
        cbxItems.Items.Add("Sexta Fase")
        cbxItems.Items.Add("Medicina")
        cbxItems.Items.Add("Biblioteca")
        SQL.Executar("SELECT p.id_produto, p.preco_venda_unidade, pl.Qtd, u.designacao, c.fator FROM Produto as p, Prod_Local as pl, Local as l, Unidade as u, Conversao as c 
WHERE p.id_produto=pl.id_produto and pl.id_Um=u.id_Um and u.designacao LIKE '%" & txtProduto.Text & "%'  and u.id_Um=c.De_Um and pl.id_local=l.id_local and l.localizacao LIKE '%" + cbxItems.Text + "%'")
        If SQL.HasException(True) Then Exit Sub
        dgvProdutos.DataSource = SQL.DBDT
        soma()

    End Sub
    Private Sub stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid1()

    End Sub

    Private Sub soma()
        Dim soma As Double

        For i As Byte = 0 To dgvProdutos.Rows.Count - 1
            soma = soma + (CDbl(dgvProdutos.Rows(i).Cells(1).Value) * CDbl(dgvProdutos.Rows(i).Cells(2).Value) * CDbl(dgvProdutos.Rows(i).Cells(4).Value))
        Next
        txtValorInv.Text = soma

    End Sub

    Private Sub btnprocurar_Click(sender As Object, e As EventArgs) Handles btnprocurar.Click
        LoadGrid1()
    End Sub
End Class