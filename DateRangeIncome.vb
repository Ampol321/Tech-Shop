Imports System.Data.OleDb
Public Class DateRangeIncome
    Dim range As New IncomeDateRange
    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        datatable.Clear()
        Try
            'connection.ConnectionString = source
            'connection.Open()

            sql = "SELECT Orders.order_id, Customer.Cname, Orders.DateOrdered,Dateshipped,
                TechShop.ProductName,Sellprice, OrderDetail.ItemQty,totalprice, ProductType.Description
                FROM customer, orders, orderdetail, TechShop, ProductType
                WHERE Customer.customer_id = orders.customer_id
                AND Orders.order_id = Orderdetail.order_id
                AND OrderDetail.product_id = TechShop.product_id
                AND ProductType.Type_id = TechShop.Type_id
                AND DateShipped BETWEEN #" &
                   Convert.ToDateTime(DateTimeStart.Value).ToString("yyyy-MM-dd") & "#
                   AND " & "#" & Convert.ToDateTime(DateTimeEnd.Value).ToString("yyyy-MM-dd") & "#
                ORDER BY Orders.Order_id"

            cmd = New OleDbCommand(sql, connection)

            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()

            range.SetDataSource(datatable)
            DateRangeViewer.ReportSource = range
            DateRangeViewer.Refresh()
        Catch ex As Exception
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try

        connection.Close()
    End Sub

End Class