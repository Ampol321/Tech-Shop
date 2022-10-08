Imports System.Data.OleDb
Public Class PaymentTypes
    Dim payments As New PaymentTypess

    Private Sub PaymentTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        Try
            'connection.ConnectionString = source
            'connection.Open()
            query = "SELECT Orders.Order_id, Customer.Cname, TechShop.ProductName, Orders.DateOrdered,DateShipped,
                     Method.Mtype FROM Customer,Method,Orders,OrderDetail,TechShop
                     WHERE Customer.customer_id = orders.customer_id
                     AND Method.Method_id = Orders.Method_id
                     AND Orders.order_id = Orderdetail.order_id
                     AND OrderDetail.product_id = TechShop.product_id"

            cmd = New OleDbCommand(query, connection)

            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()

            payments.SetDataSource(datatable)
            PaymentViewer.ReportSource = payments
            PaymentViewer.Refresh()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
        connection.Close()
    End Sub
End Class