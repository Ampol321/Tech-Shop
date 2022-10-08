Imports System.Data.OleDb
Public Class IncomeSales
    Dim sales As New IncomeSaless
    Private Sub IncomeSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        'connection.ConnectionString = source
        'connection.Open()

        sql = "SELECT Orders.order_id, Customer.Cname, Orders.DateOrdered,Dateshipped,
                TechShop.ProductName,Sellprice, OrderDetail.ItemQty,totalprice, ProductType.Description
                FROM customer, orders, orderdetail, TechShop, ProductType
                WHERE Customer.customer_id = orders.customer_id
                AND Orders.order_id = Orderdetail.order_id
                AND OrderDetail.product_id = TechShop.product_id
                AND ProductType.Type_id = TechShop.Type_id ORDER BY Orders.Order_id"

        cmd = New OleDbCommand(sql, connection)

        reader = cmd.ExecuteReader
        datatable.Load(reader)
        reader.Close()

        sales.SetDataSource(datatable)
        SalesViewer.ReportSource = sales
        SalesViewer.Refresh()
        connection.Close()
    End Sub
End Class