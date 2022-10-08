Imports System.Data.OleDb
Public Class PCExpress
    Private Sub rbtheadset_Click(sender As Object, e As EventArgs) Handles rbtheadset.Click
        qtyhea = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyhea = Nothing) Then
            rbtheadset.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtyhea & " WHERE product_id = 1"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Peripheral(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Peripheral(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtkeyboard_Click(sender As Object, e As EventArgs) Handles rbtkeyboard.Click
        qtykey = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtykey = Nothing) Then
            rbtkeyboard.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtykey & " WHERE product_id = 2"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Peripheral(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Peripheral(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtmouse_Click(sender As Object, e As EventArgs) Handles rbtmouse.Click
        qtymou = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymou = Nothing) Then
            rbtmouse.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtymou & " WHERE product_id = 3"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Peripheral(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Peripheral(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtprinter_Click(sender As Object, e As EventArgs) Handles rbtprinter.Click
        qtypri = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtypri = Nothing) Then
            rbtprinter.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtypri & " WHERE product_id = 4"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Peripheral(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Peripheral(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtmonitor_Click(sender As Object, e As EventArgs) Handles rbtmonitor.Click
        qtymon = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymon = Nothing) Then
            rbtmonitor.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtymon & " WHERE product_id = 5"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Peripheral(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Peripheral(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtprocessor_Click(sender As Object, e As EventArgs) Handles rbtprocessor.Click
        qtypro = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtypro = Nothing) Then
            rbtprocessor.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtypro & " WHERE product_id = 6"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Component(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Component(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtmcard_Click(sender As Object, e As EventArgs) Handles rbtmcard.Click
        qtymem = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymem = Nothing) Then
            rbtmcard.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtymem & " WHERE product_id = 7"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Component(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Component(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtgcard_Click(sender As Object, e As EventArgs) Handles rbtgcard.Click
        qtygra = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtygra = Nothing) Then
            rbtgcard.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtygra & " WHERE product_id = 8"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Component(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Component(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtmboard_Click(sender As Object, e As EventArgs) Handles rbtmboard.Click
        qtymot = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymot = Nothing) Then
            rbtmboard.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtymot & " WHERE product_id = 9"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Component(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Component(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtram_Click(sender As Object, e As EventArgs) Handles rbtram.Click
        qtyram = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyram = Nothing) Then
            rbtram.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtyram & " WHERE product_id = 10"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Component(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Component(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtering_Click(sender As Object, e As EventArgs) Handles rbtering.Click
        qtyeld = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtyeld = Nothing) Then
            rbtering.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtyeld & " WHERE product_id = 11"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Game(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Game(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtdsouls_Click(sender As Object, e As EventArgs) Handles rbtdsouls.Click
        qtydar = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtydar = Nothing) Then
            rbtdsouls.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtydar & " WHERE product_id = 12"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Game(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Game(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtmcraft_Click(sender As Object, e As EventArgs) Handles rbtmcraft.Click
        qtymin = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtymin = Nothing) Then
            rbtmcraft.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtymin & " WHERE product_id = 13"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Game(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Game(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtgta_Click(sender As Object, e As EventArgs) Handles rbtgta.Click
        qtygta = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtygta = Nothing) Then
            rbtgta.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtygta & " WHERE product_id = 14"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Game(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Game(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub

    Private Sub rbtskyrim_Click(sender As Object, e As EventArgs) Handles rbtskyrim.Click
        qtysky = Val(InputBox("Enter Item Quantity", "ITEM QUANTITY"))
        If (qtysky = Nothing) Then
            rbtskyrim.Checked = False
        Else
            Try
                connection.ConnectionString = source
                connection.Open()

                sql = "UPDATE techshop SET stockqty = stockqty + " & qtysky & " WHERE product_id = 15"

                cmd = New OleDbCommand(sql, connection)
                Dim y As Integer = cmd.ExecuteNonQuery()

                If (y > 0) Then
                    MsgBox("Game(s) is successfully supplied", MessageBoxButtons.OK)
                Else
                    MsgBox("Failed to supply Game(s)")
                End If
            Catch ex As Exception
                MsgBox("Error in collecting data from Database. Error is :" & ex.Message)
            End Try
        End If
        connection.Close()
    End Sub
End Class