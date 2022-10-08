Imports System.Data.OleDb
Public Class Lobby

    Private Sub cmdcomponents_Click(sender As Object, e As EventArgs) Handles cmdcomponents.Click
        Me.Hide()
        Componentss.Show()
    End Sub

    Private Sub cmdperipherals_Click(sender As Object, e As EventArgs) Handles cmdperipherals.Click
        Me.Hide()
        Peripherals.Show()
    End Sub

    Private Sub cmdgames_Click(sender As Object, e As EventArgs) Handles cmdgames.Click
        Me.Hide()
        Games.Show()
    End Sub

    Private Sub cmdprofile_Click(sender As Object, e As EventArgs) Handles cmdprofile.Click
        Me.Hide()
        CustomerInfo.Show()
    End Sub

End Class