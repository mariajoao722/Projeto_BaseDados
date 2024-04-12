
Public Class fecho
    Public SQL As New SqlControl
    Public SQL2 As New SqlControl2

    Public Sub LoadGrid3()
        SQL.Executar("SELECT p.id_pedido, p.dia, p.hora, p.id_local, p.total_preco,p.total_custo FROM Pedido p")
        If SQL.HasException(True) Then Exit Sub

        dgvConsultar1.DataSource = SQL.DBDT
        dgvConsultar1.Columns(0).HeaderText = "Id Pedido"
        dgvConsultar1.Columns(1).HeaderText = "Dia"
        dgvConsultar1.Columns(2).HeaderText = "Hora"
        dgvConsultar1.Columns(3).HeaderText = "Id Local"
        dgvConsultar1.Columns(4).HeaderText = "Total"
        dgvConsultar1.Columns(5).HeaderText = "Custo"


        dgvConsultar1.Columns(0).Width = 100
        dgvConsultar1.Columns(1).Width = 100
        dgvConsultar1.Columns(2).Width = 100
        dgvConsultar1.Columns(3).Width = 100
        dgvConsultar1.Columns(4).Width = 100
        dgvConsultar1.Columns(5).Width = 100

    End Sub

    Public Sub dia()
        Dim dia As Double
        Dim totalGasto As Double
        Dim totalRecebido As Double
        Dim lucro As Double
        Dim count As Double
        Dim count2 As Double


        dia = diatxt.Text

        For i As Byte = 0 To dgvConsultar1.Rows.Count - 1
            If CDbl(dgvConsultar1.Rows(i).Cells(1).Value) = dia Then


                count = (CDbl(dgvConsultar1.Rows(i).Cells(5).Value)) + (totalGasto)
                totalGasto = count

                count2 = (CDbl(dgvConsultar1.Rows(i).Cells(4).Value)) + (totalRecebido)
                totalRecebido = count2



            End If
        Next
        lucro = totalRecebido - totalGasto




        SQL2.Executar("INSERT INTO Filial_Dia(dia, total_gasto, total_recebido, lucro, id_filial) VALUES('" & dia & "', " & totalGasto & ", " & totalRecebido & ", " & lucro & ", 1)")

    End Sub


    Public Sub bardia()
        Dim dia As Double
        Dim bar As Double
        Dim totalGasto As Double
        Dim totalRecebido As Double
        Dim lucro As Double
        Dim count As Double
        Dim count2 As Double
        Dim nome As String

        dia = diatxt.Text
        bar = idbartxt.Text

        For i As Byte = 0 To dgvConsultar1.Rows.Count - 1
            If (CDbl(dgvConsultar1.Rows(i).Cells(1).Value)) = dia And (CDbl(dgvConsultar1.Rows(i).Cells(3).Value)) = bar Then


                count = (CDbl(dgvConsultar1.Rows(i).Cells(5).Value)) + (totalGasto)
                totalGasto = count

                count2 = (CDbl(dgvConsultar1.Rows(i).Cells(4).Value)) + (totalRecebido)
                totalRecebido = count2



            End If
        Next

        If bar = 1 Then
            nome = "Sexta Fase"
        End If
        If bar = 2 Then
            nome = "Medicina"
        End If
        If bar = 4 Then
            nome = "Biblioteca"
        End If

        lucro = totalRecebido - totalGasto

        SQL2.Executar("INSERT INTO Filial_Dia_Bar(id_bar, nome_bar, dia_bar, total_gasto_bar, total_recebido_bar, lucro_bar, id_filial) VALUES(" & bar & ",'" & nome & "', " & dia & ", " & totalGasto & ", " & totalRecebido & ", " & lucro & ", 1)")

    End Sub





    Private Sub fecho_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Form1
        LoadGrid3()
    End Sub

    Private Sub fecharcaixa_Click(sender As Object, e As EventArgs) Handles fecharcaixa.Click
        dia()
        bardia()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class