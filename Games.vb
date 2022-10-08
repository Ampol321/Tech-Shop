Imports System.Data.OleDb
Public Class Games
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Lobby.Show()
        Me.Hide()
    End Sub

    Private Sub chkering_Click(sender As Object, e As EventArgs) Handles chkering.Click
        qtyering = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyering = Nothing) Then
            chkering.Checked = False
        End If
    End Sub

    Private Sub chkdsouls_Click(sender As Object, e As EventArgs) Handles chkdsouls.Click
        qtydsouls = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtydsouls = Nothing) Then
            chkdsouls.Checked = False
        End If
    End Sub

    Private Sub chkmcraft_Click(sender As Object, e As EventArgs) Handles chkmcraft.Click
        qtymcraft = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymcraft = Nothing) Then
            chkmcraft.Checked = False
        End If
    End Sub

    Private Sub chkgta_Click(sender As Object, e As EventArgs) Handles chkgta.Click
        qtygta = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtygta = Nothing) Then
            chkgta.Checked = False
        End If
    End Sub

    Private Sub chksrim_Click(sender As Object, e As EventArgs) Handles chksrim.Click
        qtysrim = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtysrim = Nothing) Then
            chksrim.Checked = False
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

        If (chkering.Checked = False And chkdsouls.Checked = False And chkmcraft.Checked = False And chkgta.Checked = False And chksrim.Checked = False) Then
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

                If (chkering.Checked = True) Then
                    productid = 11
                    prodprice = 3371
                    totprice = prodprice * qtyering

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtyering & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtyering & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkdsouls.Checked = True) Then
                    productid = 12
                    prodprice = 2192
                    totprice = prodprice * qtydsouls

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtydsouls & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtydsouls & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkmcraft.Checked = True) Then
                    productid = 13
                    prodprice = 281
                    totprice = prodprice * qtymcraft

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtymcraft & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtymcraft & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkgta.Checked = True) Then
                    productid = 14
                    prodprice = 2248
                    totprice = prodprice * qtygta

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtygta & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtygta & "
                        WHERE product_id = " & productid & ""

                ElseIf (chksrim.Checked) Then
                    productid = 15
                    prodprice = 6296
                    totprice = prodprice * qtysrim

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtysrim & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtysrim & "
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