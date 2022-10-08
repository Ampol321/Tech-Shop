Imports System.Data.OleDb
Public Class Privatefilesss
    Dim PrivateFillles As New PrivateFile
    Private Sub Privatefilesss_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        'connection.ConnectionString = source
        Try
            'connection.Open()
            query = "SELECT * FROM customer Order By customer_id"
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()
            PrivateFillles.SetDataSource(datatable)
            PrivateFilesViewer.ReportSource = PrivateFillles
            PrivateFilesViewer.Refresh()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
        connection.Close()
    End Sub
End Class