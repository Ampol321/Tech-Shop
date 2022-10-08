Imports System.Data.OleDb
Public Class AdminForm
    Private Sub cmdsales_Click(sender As Object, e As EventArgs) Handles cmdsales.Click
        connection.ConnectionString = source
        connection.Open()
        IncomeSales.Show()
    End Sub

    Private Sub cmdshipments_Click(sender As Object, e As EventArgs) Handles cmdshipments.Click
        connection.ConnectionString = source
        connection.Open()
        Shipments.Show()
    End Sub

    Private Sub cmdpayments_Click(sender As Object, e As EventArgs) Handles cmdpayments.Click
        connection.ConnectionString = source
        connection.Open()
        PaymentTypes.Show()
    End Sub

    Private Sub cmdaccounts_Click(sender As Object, e As EventArgs) Handles cmdaccounts.Click
        connection.ConnectionString = source
        connection.Open()
        Privatefilesss.Show()
    End Sub

    Private Sub cmdrangeincome_Click(sender As Object, e As EventArgs) Handles cmdrangeincome.Click
        connection.ConnectionString = source
        connection.Open()
        DateRangeIncome.Show()
    End Sub

    Private Sub cmdhistory_Click(sender As Object, e As EventArgs) Handles cmdhistory.Click
        connection.ConnectionString = source
        connection.Open()
        TrackOrder.Show()
    End Sub

    Private Sub cmdonorders_Click(sender As Object, e As EventArgs) Handles cmdonorders.Click
        connection.ConnectionString = source
        connection.Open()
        OngoingOrdersvb.Show()
    End Sub

    Private Sub cmdrec_Click(sender As Object, e As EventArgs) Handles cmdrec.Click
        connection.ConnectionString = source
        connection.Open()
        ReceivedOrders.Show()
    End Sub
End Class