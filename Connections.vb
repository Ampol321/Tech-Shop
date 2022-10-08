Imports System.Data.OleDb
Module Connections
    Public connection As New OleDbConnection
    Public source As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\SCHOOL FOLDER\THIRD SEMESTER\COMPUTER PRGORAMMING 3\MS ACCESS\TechShop.accdb"
    Public cmd, cmd1, cmd2 As New OleDbCommand
    Public dataAdpater, dataAdpater1 As New OleDbDataAdapter
    Public dataset As New DataSet
    Public datatable As New DataTable
    Public reader, reader1 As OleDbDataReader
    Public query, query1 As String
    Public sql, sql1, sql2, q1, q2, q3, q4, q5 As String

    Public qtyhea, qtykey, qtymou, qtypri, qtymon As Integer
    Public qtypro, qtymem, qtygra, qtymot, qtyram As Integer
    Public qtyeld, qtydar, qtymin, qtygta, qtysky As Integer

    Public qtyprocessor As Integer
    Public qtymboard As Integer
    Public qtygcard As Integer
    Public qtymcard As Integer
    Public qtymouse As Integer
    Public qtykboard As Integer
    Public qtyhset As Integer
    Public qtyprinter As Integer
    Public qtymonitor As Integer
    Public qtyering As Integer
    Public qtydsouls As Integer
    Public qtymcraft As Integer
    Public qtysrim As Integer
    Public customerid As Integer
    Public orderid As Integer
    Public productid As Integer
    Public prodprice As Integer
    Public totprice As Integer
    Public shipprice As Integer
    Public ninjavan As Integer = 1
    Public standard As Integer = 2
    Public jt As Integer = 3
    Public cod As Integer = 1
    Public gcash As Integer = 2
    Public paypal As Integer = 3
    Public shipmentid As Integer
    Public methodid As Integer
End Module
