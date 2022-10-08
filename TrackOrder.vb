Imports System.Data.OleDb
Public Class TrackOrder
    Dim history As New TrackOrders
    Private Sub TrackOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'connection.ConnectionString = source
            'connection.Open()

            sql = "SELECT customer.cname FROM customer"

            cmd = New OleDbCommand(sql, connection)
            reader = cmd.ExecuteReader

            While reader.Read
                cbocustomer.Items.Add(reader("cname"))
            End While

        Catch ex As OleDbException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub cbocustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocustomer.SelectedIndexChanged
        datatable.Clear()
        Try
            connection.ConnectionString = source
            connection.Open()

            sql = "SELECT customer.cname, orders.dateordered, techshop.productname
                   FROM customer,orders,orderdetail,techshop
                   WHERE customer.customer_id = orders.customer_id
                   AND orders.order_id = orderdetail.order_id
                   AND orderdetail.product_id = techshop.product_id
                   AND customer.cname = '" & cbocustomer.Text & "'"

            cmd = New OleDbCommand(sql, connection)

            reader = cmd.ExecuteReader
            datatable.Load(reader)
            reader.Close()

            history.SetDataSource(datatable)
            HistoryViewer.ReportSource = history
            HistoryViewer.Refresh()

        Catch ex As OleDbException
            MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
        End Try
        connection.Close()
    End Sub
End Class