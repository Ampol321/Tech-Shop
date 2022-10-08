Imports System.Data.OleDb
Public Class CustomerInfo
    Public password As String
    Private Sub CustomerInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DataGridOrders.Rows.Count > 0 Then
            DataGridOrders.DataSource.Clear()
        End If
        txtCustomerID.Text = customerid
        connection.ConnectionString = source
        Try
            connection.Open()
            query = "SELECT Orders.order_id AS OrderID, DateOrdered, DateShipped, 
                    ShipType AS Shipment_Mode, Mtype AS Method_of_Payments, ItemQty AS Quantity,
                    TotalPrice, ProductName AS Name_of_Product, Description AS OrderStatus
                    FROM Customer, Orders, Shipments, Method, OrderDetail, TechShop, OrderDesc
                    WHERE Customer.customer_id = Orders.customer_id
                    AND
                    Shipments.shipment_id = Orders.shipment_id
                    AND
                    Method.method_id = Orders.method_id
                    AND
                    Orders.order_id = OrderDetail.order_id
                    AND
                    TechShop.product_id = OrderDetail.product_id
                    AND
                    Orders.desc_id = Orderdesc.desc_id
                    AND
                    Customer.customer_id = " & customerid & "
                    AND
                    date() > DateShipped"
            dataAdpater.SelectCommand = New OleDbCommand(query, connection)
            dataAdpater.Fill(dataset, "Orders")
            DataGridOrders.DataSource = dataset.Tables("Orders")
        Catch ex As Exception
            MsgBox("Error in code. Error is 1 :" & ex.Message)
        End Try
        connection.Close()

        Try
            connection.Open()
            query = "SELECT * FROM customer WHERE customer_id = " & txtCustomerID.Text
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader
            reader.Read()

            txtCustomerID.Text = reader("customer_id")
            txtName.Text = reader("CName")
            txtEmail.Text = reader("CEmail")
            txtStreet.Text = reader("CStreet")
            txtCity.Text = reader("CCity")
            txtZipCode.Text = reader("CZipCode")
            password = reader("Cpass")
        Catch ex As Exception
            MsgBox("Error in code. Error is :" & ex.Message)
        End Try
        connection.Close()
        txtCustomerID.Enabled = False
        txtName.Enabled = False
        txtEmail.Enabled = False
        txtStreet.Enabled = False
        txtCity.Enabled = False
        txtZipCode.Enabled = False

        If customerid = 14 Then
            lblreports.Visible = True
            lblsupply.Visible = True
        Else
            lblreports.Visible = False
            lblsupply.Visible = False
        End If

    End Sub

    Private Sub lblEditInfo_Click(sender As Object, e As EventArgs) Handles lblEditInfo.Click
        Dim name = txtName.Text
        Dim email = txtEmail.Text
        Dim street = txtStreet.Text
        Dim city = txtCity.Text
        Dim zipcode = txtZipCode.Text

        If lblEditInfo.Text = "Edit Info" Then
            Dim ans = MessageBox.Show("Do you want to change your personal informations?", "Edit Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                lblEditInfo.Text = "Save"
                txtName.Enabled = True
                txtEmail.Enabled = True
                txtStreet.Enabled = True
                txtCity.Enabled = True
                txtZipCode.Enabled = True
                Exit Sub
            End If
        End If
        If lblEditInfo.Text = "Save" Then
            connection = New OleDbConnection(source)
            Dim answer = MessageBox.Show("Do you want to save the changes?", "Edit Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                lblEditInfo.Text = "Edit Info"
                connection.Open()
                Try

                    query = "UPDATE Customer SET CName = '" & name & "', CEmail = '" & email & "', CStreet = '" & street & "', CCity ='" & txtCity.Text & "', CZipCode = " & zipcode & " WHERE Customer.customer_id = " & CInt(txtCustomerID.Text)
                    cmd = New OleDbCommand(query, connection)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Changed Successfuly!")
                    Else
                        MsgBox("Failed to change")
                    End If
                Catch ex As Exception
                    MsgBox("Error in code. Error is : " & ex.Message)
                End Try
            End If
        End If
        connection.Close()
        Call CustomerInfo_Load(sender, e)
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        Lobby.Show()
    End Sub

    Private Sub lblChangePass_Click(sender As Object, e As EventArgs) Handles lblChangePass.Click
        Me.Hide()
        ChangePassword.Show()
    End Sub

    Private Sub BtnShowOrders_Click(sender As Object, e As EventArgs) Handles BtnShowOrders.Click
        Me.Hide()
        OngoingOrders.Show()
    End Sub

    Private Sub cmdlogout_Click(sender As Object, e As EventArgs) Handles cmdlogout.Click
        Dim ans = MessageBox.Show("Do you want to Log out?", "Log Out", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question)

        If (ans = DialogResult.Yes) Then
            txtCustomerID.Clear()
            txtName.Clear()
            txtEmail.Clear()
            txtStreet.Clear()
            txtCity.Clear()
            txtZipCode.Clear()
            LoginForm.Show()
            Me.Hide()
        Else

        End If
    End Sub

    Private Sub lblreports_Click(sender As Object, e As EventArgs) Handles lblreports.Click
        AdminForm.Show()
    End Sub

    Private Sub lblsupply_Click(sender As Object, e As EventArgs) Handles lblsupply.Click
        PCExpress.Show()
    End Sub
End Class