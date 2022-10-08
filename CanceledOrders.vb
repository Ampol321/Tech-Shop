Imports System.Data.OleDb
Public Class CanceledOrders
    Dim cancel As New Canceled
    Private Sub CanceledOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        connection.ConnectionString = source
        connection.Open()


        sql = "SELECT Orders.order_id, Customer.Cname, Orders.DateOrdered, TechShop.ProductName,
               OrderDetail.ItemQty FROM customer,orders,orderdetail,techshop
               WHERE Customer.customer_id = orders.customer_id
               AND orders.order_id = OrderDetail.order_id
               AND OrderDetail.Product_id = TechShop.Product_ID
               AND Orders.desc_id = 1
               AND customer.customer_id = " & CustomerInfo.txtCustomerID.Text & ""

        cmd = New OleDbCommand(sql, connection)

        reader = cmd.ExecuteReader
        datatable.Load(reader)
        reader.Close()

        cancel.SetDataSource(datatable)
        CanceledViewer.ReportSource = cancel
        CanceledViewer.Refresh()
        connection.Close()
    End Sub
End Class