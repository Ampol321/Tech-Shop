Imports System.Data.OleDb
Public Class ReceivedOrders
    Dim received As New ReceivedOrderss
    Private Sub ReceivedOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        Try
            'connection.ConnectionString = source
            'connection.Open()

            sql = "SELECT orders.order_id, Customer.cname, Orders.DateOrdered, TechShop.ProductName,
                   OrderDesc.Description FROM customer, orders, orderdesc, orderdetail, techshop
                   WHERE customer.customer_id = orders.customer_id
                   AND orderdesc.desc_id = orders.desc_id
                   AND orders.order_id = orderdetail.order_id
                   AND orderdetail.product_id = techshop.product_id
                   AND orderdesc.desc_id = 2;"

            cmd = New OleDbCommand(sql, connection)

            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()

            received.SetDataSource(datatable)
            ReceivedViewer.ReportSource = received
            ReceivedViewer.Refresh()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        connection.Close()
    End Sub
End Class