Imports System.Data.OleDb
Public Class LoginForm
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        If txtpassword.Text = "" And txtusername.Text = "" Then
            MessageBox.Show("Please enter username and password", "Credentials", MessageBoxButtons.OK)
            Exit Sub
        Else
            connection.ConnectionString = source
            connection.Open()
            query = "SELECT * FROM Customer WHERE Cpass='" & txtpassword.Text & "'AND CEmail='" & txtusername.Text & "';"
            cmd = New OleDbCommand(query, connection)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                MessageBox.Show("Account exist, Would you like to continue?", "Confirmation", MessageBoxButtons.YesNo)

                query1 = "SELECT customer.customer_id FROM customer WHERE cpass= '" & txtpassword.Text & "' AND CEmail='" & txtusername.Text & "'"

                cmd = New OleDbCommand(query1, connection)
                reader = cmd.ExecuteReader()
                reader.Read()
                customerid = reader("customer_id")

                txtusername.Clear()
                txtpassword.Clear()
                Lobby.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username and password doesn't exist!", "Error", MessageBoxButtons.OK)
                txtpassword.Text = ""
                txtusername.Text = ""
            End If
        End If
        connection.Close()
    End Sub

    Private Sub cmdsignup_Click(sender As Object, e As EventArgs) Handles cmdsignup.Click
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmdtoggle_CheckedChanged(sender As Object, e As EventArgs) Handles cmdtoggle.CheckedChanged
        txtpassword.UseSystemPasswordChar = Not cmdtoggle.Checked
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpassword.UseSystemPasswordChar = Not cmdtoggle.Checked
    End Sub
End Class
