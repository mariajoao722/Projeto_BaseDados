Public Class TransferirStock
    Private SQL As New SQLControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Trocar()
    End Sub
    Public Sub LoadGrid()
        SQL.Executar("SELECT l.tipo_de_local, l.localizacao, l.id_local, p.id_produto, u.designacao, p.preco_venda_unidade, pl.Qtd FROM Produto p, Prod_Local pl, Local l, Unidade u WHERE p.id_produto=pl.id_produto and pl.id_produto=u.id_Um and pl.id_local=l.id_local")
        If Sql.HasException(True) Then Exit Sub
        dgv.DataSource = SQL.DBDT
        dgv.Columns(0).HeaderText = "Tipo Local"
        dgv.Columns(1).HeaderText = "Nome Local"
        dgv.Columns(2).HeaderText = "Codigo do Local"
        dgv.Columns(3).HeaderText = "Codigo Produto"
        dgv.Columns(4).HeaderText = "Nome Produto"
        dgv.Columns(5).HeaderText = "Preco"
        dgv.Columns(6).HeaderText = "Quantidade"

        dgv.Columns(0).Width = 75
        dgv.Columns(1).Width = 75
        dgv.Columns(2).Width = 75
        dgv.Columns(3).Width = 70
        dgv.Columns(4).Width = 130
        dgv.Columns(5).Width = 70
        dgv.Columns(6).Width = 75


    End Sub

    Public Sub Trocar()
        Dim id As Integer
        Dim bar As Integer
        Dim arm As Integer
        Dim qtd As Integer
        Dim a As Integer
        Dim soma As Integer
        Dim subt As Integer

        id = txtID.Text - 1
        bar = txtBar.Text
        arm = txtArm.Text
        qtd = txtQtd.Text

        For i As Byte = 0 To dgv.Rows.Count - 1
            If id = i Then
                a = CDbl(dgv.Rows(i).Cells(6).Value)
            End If
        Next

        If a < qtd Then
            MessageBox.Show("Não temos essa quantidade!")
        Else
            soma = bar + a
            subt = arm - a
            SQL.Executar("UPDATE Prod_Local SET Prod_Local.Qtd=" & subt & " WHERE Prod_Local.id_produto=" & txtID.Text & " and Prod_Local.id_local=" & txtArm.Text & "")
            SQL.Executar("UPDATE Prod_Local SET Prod_Local.Qtd=" & soma & " WHERE Prod_Local.id_produto=" & txtID.Text & " and Prod_Local.id_local=" & txtBar.Text & "")
            MessageBox.Show("Transferência Concluída!")

        End If

    End Sub

    Private Sub TransferirStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoadGrid()
    End Sub
End Class