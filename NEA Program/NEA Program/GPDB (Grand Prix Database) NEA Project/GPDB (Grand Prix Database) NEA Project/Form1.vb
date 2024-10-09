Public Class Form1
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        'Trigger sign in page
        Form3.Show()
        'Hide title screen
        Hide()
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        'Trigger account creation page
        Form2.Show()
        'Hide title screen
        Hide()
    End Sub
End Class
