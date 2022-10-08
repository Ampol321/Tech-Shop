Imports System.Data.OleDb
Public Class PasswordForm
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        RegistrationForm.Show()
    End Sub

    Private Sub cmdregister_Click(sender As Object, e As EventArgs) Handles cmdregister.Click
        If txtConfirmPass.Text = txtSetPass.Text Then
            Dim ans = MessageBox.Show("Do you want to create your account?", "Account registration", MessageBoxButtons.YesNo)
            If ans = DialogResult.Yes Then
                Dim name = RegistrationForm.txtCname.Text
                Dim email = RegistrationForm.txtEmail.Text
                Dim street = RegistrationForm.txtStreet.Text
                Dim city = RegistrationForm.txtCity.Text
                Dim zipcode = RegistrationForm.txtZipcode.Text
                Dim pass = txtConfirmPass.Text
                connection.ConnectionString = source
                connection.Open()
                sql = "INSERT INTO customer(CName, CEmail, CStreet, CCity, CZipCode, CPass) VALUES ('" & name & "','" & email & "','" & street & "','" &
                      city & "'," & zipcode & ",'" & pass & "')"
                cmd = New OleDbCommand(sql, connection)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                    MsgBox("Account successfully created")
                Else
                    MsgBox("Failed to create your account :(")
                End If
            End If
            connection.Close()
        Else
            MsgBox("Passwords must be the same!")
        End If
    End Sub
End Class