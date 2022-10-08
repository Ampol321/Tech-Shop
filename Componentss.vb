Imports System.Data.OleDb
Public Class Componentss
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Lobby.Show()
        Me.Hide()
        rbtcod.Checked = False
        rbtgcash.Checked = False
        rbtppal.Checked = False
        rbtnvan.Checked = False
        rbtstrd.Checked = False
        rbtjt.Checked = False
    End Sub

    Private Sub chkprocessor_Click(sender As Object, e As EventArgs) Handles chkprocessor.Click
        qtyprocessor = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyprocessor = Nothing) Then
            chkprocessor.Checked = False
        End If
    End Sub

    Private Sub chkboard_Click(sender As Object, e As EventArgs) Handles chkboard.Click
        qtymboard = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymboard = Nothing) Then
            chkboard.Checked = False
        End If
    End Sub

    Private Sub chkram_Click(sender As Object, e As EventArgs) Handles chkram.Click
        qtyram = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyram = Nothing) Then
            chkram.Checked = False
        End If
    End Sub

    Private Sub chkgcard_Click(sender As Object, e As EventArgs) Handles chkgcard.Click
        qtygcard = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtygcard = Nothing) Then
            chkgcard.Checked = False
        End If
    End Sub

    Private Sub chkmcard_Click(sender As Object, e As EventArgs) Handles chkmcard.Click
        qtymcard = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymcard = Nothing) Then
            chkmcard.Checked = False
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

        If (chkboard.Checked = False And chkgcard.Checked = False And chkmcard.Checked = False And chkprocessor.Checked = False And chkram.Checked = False) Then
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

                If (chkprocessor.Checked = True) Then
                    productid = 6
                    prodprice = 6999
                    totprice = prodprice * qtyprocessor

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtyprocessor & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtyprocessor & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkboard.Checked = True) Then
                    productid = 9
                    prodprice = 12000
                    totprice = prodprice * qtymboard

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtymboard & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtymboard & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkram.Checked = True) Then
                    productid = 10
                    prodprice = 4000
                    totprice = prodprice * qtyram

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtyram & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtyram & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkgcard.Checked = True) Then
                    productid = 8
                    prodprice = 10000
                    totprice = prodprice * qtygcard

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtygcard & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtygcard & "
                        WHERE product_id = " & productid & ""

                ElseIf (chkmcard.Checked) Then
                    productid = 7
                    prodprice = 1300
                    totprice = prodprice * qtymcard

                    sql1 = "INSERT INTO orderdetail (order_id,product_id,itemqty,totalprice)
                            VALUES ( " & orderid & ", " & productid & ", " & qtymcard & ", " & totprice & ")"

                    q1 = "UPDATE Techshop SET stockqty = stockqty - " & qtymcard & "
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

    Private Sub Componentss_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        Lobby.Show()
    End Sub
End Class