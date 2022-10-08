Imports System.Data.OleDb
Public Class Peripherals
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Lobby.Show()
        Me.Hide()
    End Sub

    Private Sub chkmouse_Click(sender As Object, e As EventArgs) Handles chkmouse.Click
        qtymouse = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymouse = Nothing) Then
            chkmouse.Checked = False
        End If
    End Sub

    Private Sub chkkboard_Click(sender As Object, e As EventArgs) Handles chkkboard.Click
        qtykboard = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtykboard = Nothing) Then
            chkkboard.Checked = False
        End If
    End Sub

    Private Sub chkhset_Click(sender As Object, e As EventArgs) Handles chkhset.Click
        qtyhset = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyhset = Nothing) Then
            chkhset.Checked = False
        End If
    End Sub

    Private Sub chkprinter_Click(sender As Object, e As EventArgs) Handles chkprinter.Click
        qtyprinter = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyprinter = Nothing) Then
            chkprinter.Checked = False
        End If
    End Sub

    Private Sub chkmonitor_Click(sender As Object, e As EventArgs) Handles chkmonitor.Click
        qtymonitor = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymonitor = Nothing) Then
            chkmonitor.Checked = False
        End If
    End Sub

    Private Sub cmdbuy_Click(sender As Object, e As EventArgs) Handles cmdbuy.Click
        If (rbtcod.Checked) Then
            methodid = cod
        ElseIf (rbtgcash.Checked) Then
            methodid = gcash
        ElseIf (rbtppal.Checked) Then
            methodid = paypal
        End If

        If (chkmouse.Checked = False And chkkboard.Checked = False And chkhset.Checked = False And chkprinter.Checked = False And chkmonitor.Checked = False) Then
            MsgBox("Please Select an item first")
        ElseIf (rbtnvan.Checked = False And rbtstrd.Checked = False And rbtjt.Checked = False) Then
            MsgBox("Please Select a Shipment")
        ElseIf (rbtcod.Checked = False And rbtgcash.Checked = False And rbtppal.Checked = False) Then
            MsgBox("Please Select a Mode of Payment")
        Else
            Dim message = MessageBox.Show("Do you want to confirm this Purchase?", "Purchase?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If message = vbYes Then
                connection.ConnectionString = source
                connection.Open()

                If (rbtnvan.Checked) Then
                    shipprice = 120
                    shipmentid = ninjavan
                    sql = "INSERT INTO orders (customer_id,dateordered,dateshipped,shipment_id,method_id,Desc_id)
                        VALUES (" & customerid & " ,date(),date()+3, " & shipmentid & ", " & methodid & ",3)"
                ElseIf (rbtstrd.Checked) Then
                    shipprice = 80
                    shipmentid = standard
                    sql = "INSERT INTO orders (customer_id,dateordered,dateshipped,shipment_id,method_id,Desc_id)
                    VALUES (" & customerid & " ,date(),date()+5, " & shipmentid & ", " & methodid & ",3)"
                ElseIf (rbtjt.Checked) Then
                    shipprice = 100
                    shipmentid = jt
                    sql = "INSERT INTO orders (customer_id,dateordered,dateshipped,shipment_id,method_id,Desc_id)
                    VALUES (" & customerid & " ,date(),date()+4, " & shipmentid & ", " & methodid & ",3)"
                End If

                dataAdpater.InsertCommand = New OleDbCommand(sql, connection)
                dataAdpater.InsertCommand.ExecuteNonQuery()

                query1 = "SELECT orders.order_id FROM orders WHERE order_id = (SELECT Max(order_id) FROM orders)"

                cmd = New OleDbCommand(query1, connection)
                reader = cmd.ExecuteReader()
                reader.Read()
                orderid = reader("order_id")

                If (chkmouse.Checked = True) Then
                    productid = 3
                    prodprice = 549
                    totprice = prodprice * qtymouse

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtymouse & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtymouse & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkkboard.Checked = True) Then
                    productid = 2
                    prodprice = 550
                    totprice = prodprice * qtykboard

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtykboard & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtykboard & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkhset.Checked = True) Then
                    productid = 1
                    prodprice = 750
                    totprice = prodprice * qtyhset

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtyhset & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtyhset & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkprinter.Checked = True) Then
                    productid = 4
                    prodprice = 4000
                    totprice = prodprice * qtyprinter

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtyprinter & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtyprinter & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkmonitor.Checked) Then
                    productid = 5
                    prodprice = 2999
                    totprice = prodprice * qtymonitor

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtymonitor & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtymonitor & "
                        WHERE product_id = " & productid & ""

                End If
                dataAdpater.InsertCommand = New OleDbCommand(sql1, connection)
                dataAdpater.InsertCommand.ExecuteNonQuery()
                dataAdpater1.UpdateCommand = New OleDbCommand(q1, connection)
                dataAdpater1.UpdateCommand.ExecuteNonQuery()
                MsgBox("Purchased Successfully")
                connection.Close()

                Dim ans = MessageBox.Show("Do you want to make a purchase again", "Purchase Again", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If ans = vbNo Then
                    Receipt.Show()
                End If
            End If
        End If
    End Sub

    Private Sub cmdprofile_Click(sender As Object, e As EventArgs) Handles cmdprofile.Click
        Me.Hide()
        CustomerInfo.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Lobby.Show()
    End Sub
End Class