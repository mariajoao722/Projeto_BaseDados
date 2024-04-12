Imports System.Data.SqlClient
Public Class AtualizarArmazem
    Public SQL As New SQLControl()
    Dim connection As New SqlConnection("Server=LAPTOP-HH1B8343\SQLEXPRESS;Database=ZurrapaFilial;Trusted_Connection=True")

    Private Sub AtualizarArmazem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ZurrapaFilialDataSet.Prod_Local'. Você pode movê-la ou removê-la conforme necessário.
        Me.Prod_LocalTableAdapter.Fill(Me.ZurrapaFilialDataSet.Prod_Local)
        MdiParent = Form1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New SqlCommand("UPDATE Prod_Local SET Qtd= " & txtQTD.Text & " WHERE id_produto=" & txtID.Text & "", connection)

        If txtID.Text <= 0 Or txtQTD.Text <= 0 Or txtID.Text = "" Or txtQTD.Text = "" Or txtArm.Text < 3 Or txtArm.Text > 5 Or txtArm.Text = 4 Then
            MessageBox.Show("Valores Inválidos!")
        Else
            command.Parameters.Add("@num", SqlDbType.Int).Value = txtID.Text
            command.Parameters.Add("@qtd", SqlDbType.Int).Value = txtQTD.Text

            connection.Open()

            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Dados Não Atualizados!")
                connection.Close()

            Else
                MessageBox.Show("Dados Atualizados!")
                connection.Close()
            End If
        End If
        Dim id As Integer
        id = txtID.Text
        Dim arm As Integer
        arm = txtArm.Text
        SQL.Executar("Select pl.* From Produto p, Prod_Local pl Where pl.id_produto=" & id & " and pl.id_local=" & arm & "")
        If SQL.HasException(True) Then Exit Sub
        dgvData.DataSource = SQL.DBDT

    End Sub
End Class