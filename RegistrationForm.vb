Public Class RegistrationForm
    Private Sub cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        If txtCname.Text = "" Or txtEmail.Text = "" Or txtStreet.Text = "" Or txtCity.Text = "" Or txtZipcode.Text = "" Then
            MessageBox.Show("All fields are required!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Me.Hide()
            PasswordForm.Show()
        End If
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class