Imports System.Data.OleDb
Public Class OngoingOrders
    Private Sub OngoingOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.ConnectionString = source
        CmbOrderID.Items.Clear()
        Try
            connection.Open()
            query = "SELECT Orders.order_id 
                    FROM customer, Orders , OrderDesc
                    WHERE 
                    Customer.customer_id = Orders.customer_id
                    AND
                    Orderdesc.desc_id = orders.desc_id
                    AND
                    date() < DateShipped
                    AND
                    Orderdesc.desc_id = 3
                    AND
                    Customer.customer_id =" & CustomerInfo.txtCustomerID.Text
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            Dim i As Integer = 0
            While reader.Read
                i += 1
                CmbOrderID.Items.Add(reader("order_id"))
            End While
            label1.Text = "You have " & i & " Order(s)"
        Catch ex As Exception
            MsgBox("Error in code. Error is :" & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        CustomerInfo.Show()
    End Sub
    Private Sub CmbOrderID_Click(sender As Object, e As EventArgs) Handles CmbOrderID.Click
        OngoingOrders_Load(sender, e)
    End Sub
    Private Sub CmbOrderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbOrderID.SelectedIndexChanged
        txtItems.Clear()
        connection.ConnectionString = source
        Try
            connection.Open()
            query = "SELECT Orders.order_id, ProductName, DateOrdered, DateShipped, ShipType, ShipFee, MType, ItemQty, SellPrice, description
                    FROM Orders, Shipments, Method, OrderDetail, TechShop, orderdesc
                    WHERE
                    Orders.order_id = OrderDetail.order_id
                    AND
                    Shipments.shipment_id = Orders.shipment_id
                    AND
                    Method.method_id = Orders.method_id
                    AND
                    TechShop.product_id = OrderDetail.product_id
                    AND
                    Orders.desc_id = OrderDesc.desc_id
                    AND 
                    date() < DateShipped
                    AND 
                    customer_id =" & CustomerInfo.txtCustomerID.Text & "
                    AND
                    Orders.order_id = " & CmbOrderID.SelectedItem
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            reader.Read()
            txtOrderDate.Text = reader("DateOrdered")
            txtShipDate.Text = reader("DateShipped")
            txtShipmentMode.Text = reader("ShipType")
            txtShipFee.Text = reader("ShipFee")
            txtMethodPay.Text = reader("MType")
            txtstatus.Text = reader("Description")

            reader.Close()
            query = "SELECT ProductName, ItemQty, SellPrice
                    FROM Orders, Shipments, Method, OrderDetail, TechShop
                    WHERE
                    Orders.order_id = OrderDetail.order_id
                    AND
                    Shipments.shipment_id = Orders.shipment_id
                    AND
                    Method.method_id = Orders.method_id
                    AND
                    TechShop.product_id = OrderDetail.product_id
                    AND 
                    date() < DateShipped
                    AND 
                    customer_id =" & CustomerInfo.txtCustomerID.Text & "
                    AND
                    Orders.order_id = " & CmbOrderID.SelectedItem & "
                    ORDER BY Orders.order_id ASC"
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            Dim TotalPrice As Decimal = 0
            While reader.Read()
                Dim total As Decimal = 0, shipfee As Decimal = txtShipFee.Text
                Dim sellprice As Decimal = reader("SellPrice")
                Dim quantity As Integer = reader("ItemQty")

                total = sellprice * quantity
                TotalPrice = TotalPrice + total
                txtItems.Text = txtItems.Text + "Product Name: " & reader("ProductName") + vbCrLf & "Quantity : " & quantity.ToString + vbCrLf & "Sell Price : " & sellprice.ToString("C2") + vbCrLf
            End While
            txtTotalPrice.Text = TotalPrice.ToString("C2")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        reader.Close()
        connection.Close()
    End Sub

    Private Sub BtnOrderCancel_Click(sender As Object, e As EventArgs) Handles BtnOrderCancel.Click
        Dim order = CmbOrderID.Text

        Dim ans = MessageBox.Show("Do you want to cancel this order?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then
            connection.Open()

            sql = "UPDATE Orders SET desc_id = 1 WHERE order_id = " & order & ""

            cmd = New OleDbCommand(sql, connection)
            cmd.ExecuteNonQuery()

            'sql1 = "DELETE FROM orderdetail WHERE order_id = " & order & ""

            'cmd1 = New OleDbCommand(sql1, connection)
            'cmd1.ExecuteNonQuery()
            MsgBox("Order successfully canceled!", MessageBoxIcon.Information)

            txtOrderDate.Clear()
            txtItems.Clear()
            txtShipDate.Clear()
            txtShipmentMode.Clear()
            txtShipFee.Clear()
            txtMethodPay.Clear()
            txtTotalPrice.Clear()
            txtstatus.Clear()
            CmbOrderID.Items.Clear()

            query = "SELECT Orders.order_id 
                    FROM customer, Orders , OrderDesc
                    WHERE 
                    Customer.customer_id = Orders.customer_id
                    AND
                    Orderdesc.desc_id = orders.desc_id
                    AND
                    date() < DateShipped
                    AND
                    Orderdesc.desc_id = 3
                    AND
                    Customer.customer_id =" & CustomerInfo.txtCustomerID.Text

            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            Dim i As Integer = 0

            While reader.Read
                i += 1
                CmbOrderID.Items.Add(reader("order_id"))
            End While
            label1.Text = "You have " & i & " Order(s)"
        Else

        End If
        connection.Close()
    End Sub

    Private Sub cmdcanceledorders_Click(sender As Object, e As EventArgs) Handles cmdcanceledorders.Click
        CanceledOrders.Show()
    End Sub

End Class