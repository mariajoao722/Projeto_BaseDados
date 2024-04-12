Public Class consultar
    Public SQL As New SqlControl

    Public Sub LoadGrid()
        cdxItems.Items.Clear()
        cdxItems.Items.Add("01/01")

        SQL.Executar("SELECT p.id_pedido, p.dia, p.hora, p.estado, p.total_preco, e.nome FROM Pedido p, Empregado e WHERE p.id_emp=e.id_emp and  p.dia LIKE '%" & txtSearch.Text & "%'")
        If SQL.HasException(True) Then Exit Sub

        dgvConsultar.DataSource = SQL.DBDT
        dgvConsultar.Columns(0).HeaderText = "Id Pedido"
        dgvConsultar.Columns(1).HeaderText = "Dia"
        dgvConsultar.Columns(2).HeaderText = "Hora"
        dgvConsultar.Columns(3).HeaderText = "Estado"
        dgvConsultar.Columns(4).HeaderText = "Total"
        dgvConsultar.Columns(5).HeaderText = "Empregado"




        dgvConsultar.Columns(0).Width = 75
        dgvConsultar.Columns(1).Width = 75
        dgvConsultar.Columns(2).Width = 75
        dgvConsultar.Columns(3).Width = 70
        dgvConsultar.Columns(4).Width = 70
        dgvConsultar.Columns(5).Width = 130



    End Sub
    Private Sub consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()
    End Sub

    Private Sub cmdAtualizar_Click(sender As Object, e As EventArgs) Handles cmdAtualizar.Click
        Atualizar()
        LoadGrid()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub Atualizar()
        Dim id As Integer
        Dim estado As Integer
        Dim qtd As Integer

        id = txtIdpedido.Text
        estado = txtEstado.Text
        qtd = 0


        SQL.Executar("UPDATE Pedido SET estado =" & estado & " WHERE id_pedido =" & id & "")
        If SQL.HasException(True) Then Exit Sub


    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        LoadGrid()
    End Sub
End Class