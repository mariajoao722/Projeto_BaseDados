Public Class Inventario
    Public SQL As New SQLControl
    Public Sub LoadGrid()

        cbxItems.Items.Clear()
        cbxItems.Items.Add("Sineiro")
        cbxItems.Items.Add("Avenida")
        cbxItems.Items.Add("Sexta Fase")
        cbxItems.Items.Add("Medicina")
        cbxItems.Items.Add("Biblioteca")
        SQL.Executar("SELECT p.id_produto, u.designacao, p.preco_venda_unidade, pl.Qtd, c.fator FROM Produto as p, Prod_Local as pl, Local as l, Unidade as u, Conversao as c WHERE p.id_produto=pl.id_produto and pl.id_Um=u.id_Um and u.designacao LIKE '%" & txtProcura.Text & "%' and u.id_Um=c.De_Um and pl.id_local=l.id_local and l.localizacao LIKE '%" + cbxItems.Text + "%'")
        If SQL.HasException(True) Then Exit Sub

        dgv.DataSource = SQL.DBDT
        dgv.Columns(0).HeaderText = "ID Produto"
        dgv.Columns(1).HeaderText = "Nome Produto"
        dgv.Columns(2).HeaderText = "Preço"
        dgv.Columns(3).HeaderText = "Quantidade"
        dgv.Columns(4).HeaderText = "Fator"

        dgv.Columns(0).Width = 75
        dgv.Columns(1).Width = 130
        dgv.Columns(2).Width = 60
        dgv.Columns(3).Width = 70
        dgv.Columns(4).Width = 59
        soma()
    End Sub
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
    End Sub

    Private Sub Procurar_Click(sender As Object, e As EventArgs) Handles Procurar.Click
        LoadGrid()
    End Sub
    Private Sub soma()
        Dim soma As Double

        For i As Byte = 0 To dgv.Rows.Count - 1
            soma = soma + (CDbl(dgv.Rows(i).Cells(2).Value) * CDbl(dgv.Rows(i).Cells(3).Value) * CDbl(dgv.Rows(i).Cells(4).Value))
        Next
        txtSoma.Text = soma

    End Sub
End Class