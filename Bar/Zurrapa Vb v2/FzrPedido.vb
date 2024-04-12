Public Class FzrPedido
    Public SQL As New SqlControl
    Public Sub LoadGrid2()
        cdxlocal.Items.Clear()
        cdxlocal.Items.Add("Sexta Fase")
        cdxlocal.Items.Add("Medicina")
        cdxlocal.Items.Add("Biblioteca")

        SQL.Executar("SELECT Pedido.id_pedido,Empregado.nome,Empregado.id_emp,Local.id_local,Produto.designacao,Prod_Pedido.quantidade_paga,Pedido.total_preco,Produto.preco_venda_unidade,Produto.preco_custo, Pedido.dia,Pedido.hora, Local.localizacao, Local.tempo_repor FROM Local,Pedido,Produto,Prod_Pedido,Empregado 
WHERE Prod_Pedido.id_pedido = Pedido.id_pedido and Pedido.id_emp = Empregado.id_emp and Prod_Pedido.id_produto = Produto.id_produto and Pedido.id_local = Local.id_local and Local.localizacao LIKE '%" & cdxlocal.Text & "'")
        dgvPedido.DataSource = SQL.DBDT
        If SQL.HasException(True) Then Exit Sub

        dgvPedido.Columns(0).HeaderText = "Id Pedido"
        dgvPedido.Columns(1).HeaderText = "Empregado"
        dgvPedido.Columns(2).HeaderText = "Id Emp"
        dgvPedido.Columns(3).HeaderText = "Id Local"
        dgvPedido.Columns(4).HeaderText = "Produto"
        dgvPedido.Columns(5).HeaderText = "Qtd"
        dgvPedido.Columns(6).HeaderText = "Total"
        dgvPedido.Columns(7).HeaderText = "Preco Venda"
        dgvPedido.Columns(8).HeaderText = "Preco Custo"
        dgvPedido.Columns(9).HeaderText = "Dia"
        dgvPedido.Columns(10).HeaderText = "Hora"
        dgvPedido.Columns(11).HeaderText = "Localizacao"
        dgvPedido.Columns(12).HeaderText = "Tempo Repor"


        dgvPedido.Columns(0).Width = 60
        dgvPedido.Columns(1).Width = 140
        dgvPedido.Columns(2).Width = 60
        dgvPedido.Columns(3).Width = 60
        dgvPedido.Columns(4).Width = 110
        dgvPedido.Columns(5).Width = 60
        dgvPedido.Columns(6).Width = 75
        dgvPedido.Columns(7).Width = 75
        dgvPedido.Columns(8).Width = 75
        dgvPedido.Columns(9).Width = 60
        dgvPedido.Columns(10).Width = 60
        dgvPedido.Columns(11).Width = 130
        dgvPedido.Columns(12).Width = 75


    End Sub

    Private Sub FzrPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid2()
    End Sub

    Public Sub Comecar()
        Dim dia As String
        Dim hora As String
        Dim Idemp As Integer
        Dim IdLocal As Integer
        Dim estado As Integer
        Dim totalP As Double
        Dim totalC As Double

        dia = txtdia.Text
        hora = txthora.Text
        Idemp = txtemp.Text
        IdLocal = txt_local.Text
        totalP = 0
        totalC = 0


        SQL.Executar("INSERT INTO Pedido(dia, hora, estado, total_preco, total_custo, id_emp, id_local) VALUES( ' " & dia & " ' , ' " & hora & " ', ' " & 1 & " ', " & totalP & ", " & totalC & " , " & Idemp & ", " & IdLocal & ")")
        MessageBox.Show("Comecado!")
        LoadGrid2()
    End Sub



    Private Sub Procurar_Click(sender As Object, e As EventArgs) Handles Procurar.Click
        LoadGrid2()
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        Comecar()
    End Sub

    Private Sub btnaAdd_Click(sender As Object, e As EventArgs) Handles btnaAdd.Click
        Adicionar()

    End Sub

    Public Sub Adicionar()
        Dim produtopedido As String
        Dim qtd As Integer
        Dim idprodutopedido As Integer
        Dim idpedido As Integer
        Dim tempo_repor As String

        qtd = txtquantidade.Text
        produtopedido = txtproduto.Text
        idprodutopedido = 0
        idpedido = txtIDPEDIDO.Text

        For i As Byte = 0 To (dgvPedido.Rows.Count - 1)

            tempo_repor = CDbl(dgvPedido.Rows(i).Cells(12).Value)
        Next

        If qtd = 0 Then
            MessageBox.Show(tempo_repor)
        End If

        If produtopedido = "Pao" Then
            idprodutopedido = 1
        End If

        If produtopedido = "Agua" Then
            idprodutopedido = 2
        End If

        If produtopedido = "Cerveja" Then
            idprodutopedido = 3
        End If

        If produtopedido = "Batatas" Then
            idprodutopedido = 4
        End If

        If produtopedido = "Prego" Then
            idprodutopedido = 5
        End If

        If produtopedido = "Pastilhas" Then
            idprodutopedido = 6
        End If

        If produtopedido = "Pizza" Then
            idprodutopedido = 7
        End If

        If produtopedido = "Refrigerantes" Then
            idprodutopedido = 8
        End If

        SQL.Executar("INSERT INTO Prod_Pedido(quantidade_servida, quantidade_paga, id_pedido, id_produto) VALUES(" & 0 & ", " & qtd & ", " & idpedido & ", " & idprodutopedido & ")")


        MessageBox.Show("Adicionado!")
    End Sub

    Public Sub Finalizar()
        Dim totalCusto As Double
        Dim totalPreco As Double
        Dim idpedido As Integer
        Dim count As Double
        Dim count2 As Double

        idpedido = txtIDPEDIDO.Text
        count = 0
        count2 = 0

        For i As Byte = 0 To dgvPedido.Rows.Count - 1
            If idpedido = (CDbl(dgvPedido.Rows(i).Cells(0).Value)) Then

                totalPreco = (((CDbl(dgvPedido.Rows(i).Cells(5).Value)) * (CDbl(dgvPedido.Rows(i).Cells(7).Value))) + (count))
                count = totalPreco


            End If
        Next

        For i As Byte = 0 To dgvPedido.Rows.Count - 1
            If idpedido = (CDbl(dgvPedido.Rows(i).Cells(0).Value)) Then

                totalCusto = (((CDbl(dgvPedido.Rows(i).Cells(5).Value)) * (CDbl(dgvPedido.Rows(i).Cells(8).Value))) + (count2))
                count2 = totalCusto


            End If
        Next

        SQL.Executar("UPDATE Pedido SET total_preco =" & count & " WHERE id_pedido =" & idpedido & "")
        SQL.Executar("UPDATE Pedido SET total_custo =" & count2 & " WHERE id_pedido =" & idpedido & "")

    End Sub

    Private Sub btnatualizar_Click(sender As Object, e As EventArgs) Handles btnatualizar.Click
        LoadGrid2()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Finalizar()
    End Sub
End Class