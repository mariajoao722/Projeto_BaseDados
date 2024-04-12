Public Class Dia
    Private SQL As New SQLControl
    Private Sub Dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid()

    End Sub

    Public Sub LoadGrid()
        SQL.Executar("SELECT f.designacao, d.dia, d.total_gasto, d.total_recebido, d.lucro FROM Filial as f, Filial_Dia as d 
WHERE d.id_filial = f.id_filial and d.dia like '%" & txtDia.Text & "%'")

        If SQL.HasException(True) Then Exit Sub
        dgv.DataSource = SQL.DBDT
        dgv.Columns(0).HeaderText = "Nome Filial"
        dgv.Columns(1).HeaderText = "Dia"
        dgv.Columns(2).HeaderText = "Total Gasto"
        dgv.Columns(3).HeaderText = "Total Recebido"
        dgv.Columns(4).HeaderText = "Lucro"


        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 60
        dgv.Columns(2).Width = 75
        dgv.Columns(3).Width = 70
        dgv.Columns(4).Width = 60

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadGrid()
    End Sub
End Class