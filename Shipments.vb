Imports System.Data.OleDb
Public Class Shipments
    Dim shipments As New ShipmentReport
    Private Sub Shipments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datatable.Clear()
        Try
            'connection.ConnectionString = source
            'connection.Open()
            query = "SELECT CName, ProductName,DateOrdered, DateShipped, ShipType, ItemQty, SellPrice, (ItemQty * SellPrice) AS TotalPrice
                    FROM Customer, Orders, Shipments, Method, OrderDetail, TechShop
                    WHERE Customer.customer_id = Orders.customer_id
                    AND
                    Shipments.shipment_id = Orders.shipment_id
                    AND
                    Method.method_id = Orders.method_id
                    AND
                    Orders.order_id = OrderDetail.order_id
                    AND
                    TechShop.product_id = OrderDetail.product_id"
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()
            shipments.SetDataSource(datatable)
            ShipmentReport.ReportSource = shipments
            ShipmentReport.Refresh()
        Catch ex As Exception
            MsgBox("Error :" & ex.Message)
        End Try
        connection.Close()
    End Sub
End Class