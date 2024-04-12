Public Class Bar
    Private SQL As New SQLControl

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub

    Public Sub LoadGrid()
        SQL.Executar("SELECT f.designacao, b.id_bar, b.nome_bar, b.dia_bar, b.total_gasto_bar, b.total_recebido_bar, b.lucro_bar FROM Filial as f, Filial_Dia_Bar as b 
WHERE b.id_filial = f.id_filial and b.id_bar like '%" & txtBar.Text & "%' and b.dia_bar like '%" & txtDia.Text & "%'")

        If SQL.HasException(True) Then Exit Sub
        dgv.DataSource = SQL.DBDT
        dgv.Columns(0).HeaderText = "Nome Filial"
        dgv.Columns(1).HeaderText = "ID Bar"
        dgv.Columns(2).HeaderText = "Nome Bar"
        dgv.Columns(3).HeaderText = "Dia"
        dgv.Columns(4).HeaderText = "Total Gasto"
        dgv.Columns(5).HeaderText = "Total Recebido"
        dgv.Columns(6).HeaderText = "Lucro"


        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 60
        dgv.Columns(2).Width = 75
        dgv.Columns(3).Width = 60
        dgv.Columns(4).Width = 75
        dgv.Columns(5).Width = 75
        dgv.Columns(6).Width = 60

    End Sub

    Private Sub Bar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        MdiParent = Form1
    End Sub
End Class