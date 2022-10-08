Imports System.Data.OleDb
Public Class ChangePassword
    Private Sub cmdsignup_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        CustomerInfo.Show()
    End Sub

    Private Sub cmdchangepass_Click(sender As Object, e As EventArgs) Handles cmdchangepass.Click
        If txtPrevPass.Text = CustomerInfo.password Then
            Dim ans = MessageBox.Show("Are you sure do you want to save password?", "Change Password", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If ans = DialogResult.Yes Then
                connection.ConnectionString = source
                Try
                    connection.Open()
                    sql = "UPDATE customer SET Cpass = '" & txtNewPass.Text & "' WHERE customer_id =" & CustomerInfo.txtCustomerID.Text & ""
                    cmd = New OleDbCommand(sql, connection)
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Succesfully change!")
                    Else
                        MsgBox("Failed to change")
                    End If
                Catch ex As Exception
                    MsgBox("Error in code. Error is :" & ex.Message)
                End Try
                Me.Hide()
                CustomerInfo.Show()
            End If
        Else
            MessageBox.Show("Incorrect previous password. In order to change your password you need to enter your correct previous password",
                        "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        connection.Close()
    End Sub
End Class