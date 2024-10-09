Imports System.Xml
Public Class Form3
    Private Sub FormSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set password textbox to asterisks
        txtPasswordSignIn.PasswordChar = "*"c
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Hide()
    End Sub
    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        ' Retrieve user input
        Dim usernameInput As String = txtUsernameSignIn.Text
        Dim passwordInput As String = txtPasswordSignIn.Text

        ' Load users from XML
        Dim xmlFilePath As String = IO.Path.Combine(Application.StartupPath, "User_Data.xml")
        Dim doc As New XmlDocument()
        doc.Load(xmlFilePath)

        ' Load users into a list
        Dim users As New List(Of User)
        For Each userNode As XmlNode In doc.SelectNodes("/Users/User")
            Dim user As New User With {
                .Username = userNode.SelectSingleNode("Username").InnerText,
                .Password = userNode.SelectSingleNode("User_Password").InnerText ' Stored as salt + hashed password
            }
            users.Add(user)
        Next

        'Sort users by username in binary search
        users.Sort(Function(x, y) String.Compare(x.Username, y.Username))

        ' Perform binary search to find user by last and first name
        Dim foundUser As User = BinarySearchUser(users, usernameInput)
        If foundUser IsNot Nothing Then
            ' User found, now validate the password
            Dim hasher As New PasswordHasher()

            ' Extract the salt and hashed password from stored password
            Dim storedSalt As String = foundUser.Password.Substring(0, 24)
            Dim storedHashedPassword As String = foundUser.Password.Substring(24)

            ' Hash the input password with the stored salt
            Dim hashedInputPassword As String = hasher.HashPassword(passwordInput, storedSalt)

            ' Compare hashed input password with stored hashed password
            If hashedInputPassword = storedHashedPassword Then
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK)
                'Trigger main page
                Form4.Show()
                Hide()
            Else
                MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK)
        End If
    End Sub

    ' Binary search implementation for finding a user by their username
    Private Function BinarySearchUser(users As List(Of User), username As String) As User
        Dim low As Integer = 0
        Dim high As Integer = users.Count - 1

        While low <= high
            Dim mid As Integer = (low + high) \ 2
            Dim comparison As Integer = String.Compare(users(mid).Username, username)

            If comparison = 0 Then
                ' Username matches
                Return users(mid)
            ElseIf comparison < 0 Then
                low = mid + 1
            Else
                high = mid - 1
            End If
        End While

        Return Nothing ' User not found
    End Function

    ' Class for storing user information
    Public Class User
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Email As String
        Public Property PhoneNum As String
        Public Property Username As String
        Public Property Password As String ' This includes both the salt and hashed password
    End Class
End Class
