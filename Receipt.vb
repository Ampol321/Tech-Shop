Imports System.Data.OleDb
Public Class Receipt
    Dim receipts As New Resibo
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        connection.ConnectionString = source
        connection.Open()


        sql = "SELECT Orders.order_id,customer.cname, ProductName, DateOrdered, ShipType, ShipFee, MType, ItemQty, SellPrice, description
               FROM Customer,Orders, Shipments, Method, OrderDetail, TechShop, orderdesc
               WHERE Customer.customer_id = orders.customer_id
               AND Orders.order_id = OrderDetail.order_id
               AND Shipments.shipment_id = Orders.shipment_id
               AND Method.method_id = Orders.method_id
               AND TechShop.product_id = OrderDetail.product_id
               AND Orders.desc_id = OrderDesc.desc_id
               AND orders.dateordered = date()
               AND customer.customer_id = " & customerid & " "

        cmd = New OleDbCommand(sql, connection)

        reader = cmd.ExecuteReader
        datatable.Load(reader)
        reader.Close()

        receipts.SetDataSource(datatable)
        receiptviewer.ReportSource = receipts
        receiptviewer.Refresh()
        connection.Close()
    End Sub
End Class