Public Class Form4
    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click

    End Sub
    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Me.Hide()
        Form5.Show()
    End Sub
    Private Sub btnMeetings_Click(sender As Object, e As EventArgs) Handles btnMeetings.Click
        Me.Hide()
        Form7.Show()
    End Sub
    Private Sub btnSessions_Click(sender As Object, e As EventArgs) Handles btnSessions.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class