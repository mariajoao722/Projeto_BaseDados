﻿Imports System.Data.SqlClient

Public Class SqlControl

    Private DBCon As New SqlConnection("Server=LAPTOP-HH1B8343\SQLEXPRESS;Database=ZurrapaFilial;Trusted_Connection=True")

    Private DBCmd As SqlCommand

        'DB DATA
        Public DBDA As SqlDataAdapter
        Public DBDT As DataTable

        'QUERY PARAMETERS
        Public Params As New List(Of SqlParameter)

        'QUERY STATISTICS
        Public RecordCount As Integer
        Public Exception As String

        Public Sub New()

        End Sub

        'ALLOW CONECTION STRING OVERRIDE
        Public Sub New(ConnectionString As String)
            DBCon = New SqlConnection(ConnectionString)
        End Sub

        'EXECUTE QUERY SUB
        Public Sub Executar(Query As String)
            ' RESET QUERY STATS
            RecordCount = 0
            Exception = ""

            Try
                DBCon.Open()

                'DATABSE COMAND
                ' CREATE DB COMAND
                DBCmd = New SqlCommand(Query, DBCon)
                ' LOAD PARAMS INTO DB COMAND
                Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

                'CLEAR PAARAM LIST
                Params.Clear()

                'EXECUTE COMAND AND FILL DATASET
                DBDT = New DataTable
                DBDA = New SqlDataAdapter(DBCmd)
                RecordCount = DBDA.Fill(DBDT)

            Catch ex As Exception
                'CAPTURE ERROR
                Exception = "ExecQuery Error : " & vbNewLine & ex.Message

            Finally
                'CLOSE CONNECTION
                If DBCon.State = ConnectionState.Open Then DBCon.Close()
            End Try
        End Sub

        'ADD PARMS
        Public Sub AddParam(Name As String, Value As Object)
            Dim NewParam As New SqlParameter(Name, Value)
            Params.Add(NewParam)
        End Sub


        'ERROR CHECKING
        Public Function HasException(Optional ByVal report As Boolean = False) As Boolean
            If String.IsNullOrEmpty(Exception) Then Return False
            If report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
            Return True
        End Function


End Class
