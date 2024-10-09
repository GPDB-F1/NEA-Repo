Imports System.Text.RegularExpressions
Imports System.Xml

Public Class Form2
    Private Sub FormCrAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set password textbox to asterisks
        txtPasswordCrAcc.PasswordChar = "*"c
    End Sub

    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        ' Display confirmation exit message
        Form1.Show()
        Hide()
    End Sub
    Sub User_Data_To_XML(Firstname As String, Lastname As String, Email As String, PhoneNum As String, Username As String, Password As String)
        Dim xmlFilePath As String = IO.Path.Combine(Application.StartupPath, "User_Data.xml")
        Dim doc As New XmlDocument()

        ' Load the XML file
        doc.Load(xmlFilePath)

        ' Create fields for user data
        Dim New_User As XmlElement = doc.CreateElement("User")
        Dim New_Firstname As XmlElement = doc.CreateElement("User_Firstname")
        Dim New_Lastname As XmlElement = doc.CreateElement("User_Lastname")
        Dim New_Email As XmlElement = doc.CreateElement("User_Email")
        Dim New_PhoneNum As XmlElement = doc.CreateElement("User_PhoneNum")
        Dim New_Username As XmlElement = doc.CreateElement("Username")
        Dim New_Password As XmlElement = doc.CreateElement("User_Password")

        ' Set the XmlElements to the passed variables
        New_Firstname.InnerText = Firstname
        New_Lastname.InnerText = Lastname
        New_Email.InnerText = Email
        New_PhoneNum.InnerText = PhoneNum
        New_Username.InnerText = Username
        New_Password.InnerText = Password

        ' Create child nodes from initial parent node of user data
        New_User.AppendChild(New_Firstname)
        New_User.AppendChild(New_Lastname)
        New_User.AppendChild(New_Email)
        New_User.AppendChild(New_PhoneNum)
        New_User.AppendChild(New_Username)
        New_User.AppendChild(New_Password)

        ' Save the Xml file
        doc.DocumentElement.AppendChild(New_User)
        doc.Save(xmlFilePath)

        ' Sort the users after adding new account
        SortAndSaveUsers(xmlFilePath)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Retrieve user details from textboxes
        Dim User_Firstname As String = txtFirstnameCrAcc.Text
        Dim User_Lastname As String = txtLastnameCrAcc.Text
        Dim User_Email As String = txtEmailCrAcc.Text
        Dim User_PhoneNum As String = txtPhoneNumCrAcc.Text
        Dim Username As String = txtUsernameCrAcc.Text
        Dim User_Password As String = txtPasswordCrAcc.Text

        ' Primary validation for textboxes (excluding password)
        Dim isFirstnameValid As Boolean = ValidateName(User_Firstname)
        Dim isLastnameValid As Boolean = ValidateName(User_Lastname)
        Dim isEmailValid As Boolean = ValidateEmail(User_Email)
        Dim isPhoneNumValid As Boolean = ValidatePhone(User_PhoneNum)
        Dim isUsernameValid As Boolean = ValidateUsername(Username)
        Dim isPasswordValid As Boolean = ValidatePassword(User_Password)

        ' Set conditions for all to be true
        If isFirstnameValid AndAlso isLastnameValid AndAlso isEmailValid AndAlso isPhoneNumValid AndAlso isUsernameValid AndAlso isPasswordValid Then
            ' All inputs are valid so proceed with hashing password
            Dim hasher As New PasswordHasher()
            Dim salt As String = hasher.GenerateSalt()

            ' Hash password with generated salt
            Dim hashedPassword As String = hasher.HashPassword(User_Password, salt)

            ' Store the salt and hashed password as one string in the XML (salt + hashedPassword)
            Dim combinedPassword As String = salt & hashedPassword

            ' Save user data (including salt + hashed password)
            User_Data_To_XML(User_Firstname, User_Lastname, User_Email, User_PhoneNum, Username, combinedPassword)

            MessageBox.Show("Account creation successful!", "Account Creation", MessageBoxButtons.OK)
        End If

        ' Validation error messages
        If Not isFirstnameValid Then
            MessageBox.Show("Your Firstname was invalid. Please check it and re-enter if necessary", "Firstname Error", MessageBoxButtons.OK)
        End If

        If Not isLastnameValid Then
            MessageBox.Show("Your Lastname was invalid. Please check it and re-enter if necessary", "Lastname Error", MessageBoxButtons.OK)
        End If

        If Not isEmailValid Then
            MessageBox.Show("Your email was invalid. Please check it and re-enter if necessary", "Email Error", MessageBoxButtons.OK)
        End If

        If Not isPhoneNumValid Then
            MessageBox.Show("Your Phone number was invalid. Please check it and re-enter if necessary", "Phone Number Error", MessageBoxButtons.OK)
        End If

        If Not isPasswordValid Then
            MessageBox.Show("Your Password was invalid. Please check it matches the criteria and re-enter if necessary", "Password Error", MessageBoxButtons.OK)
        End If
    End Sub

    ' Merge algorithm to sort users in XML file by Firstname and Lastname
    Private Function Merge(left As List(Of User), right As List(Of User)) As List(Of User)
        Dim result As New List(Of User)
        Dim i As Integer = 0, j As Integer = 0

        ' Compare by LastName, then FirstName
        While i < left.Count AndAlso j < right.Count
            If left(i).LastName < right(j).LastName OrElse (left(i).LastName = right(j).LastName AndAlso left(i).FirstName < right(j).FirstName) Then
                result.Add(left(i))
                i += 1
            Else
                result.Add(right(j))
                j += 1
            End If
        End While

        ' Append remaining elements
        While i < left.Count
            result.Add(left(i))
            i += 1
        End While
        While j < right.Count
            result.Add(right(j))
            j += 1
        End While

        Return result
    End Function

    ' Recursive merge sort function
    Private Function MergeSort(users As List(Of User)) As List(Of User)
        If users.Count <= 1 Then
            Return users
        End If

        Dim mid As Integer = users.Count \ 2
        Dim left As List(Of User) = MergeSort(users.GetRange(0, mid))
        Dim right As List(Of User) = MergeSort(users.GetRange(mid, users.Count - mid))

        Return Merge(left, right)
    End Function

    ' Sort and save users back to the XML
    Private Sub SortAndSaveUsers(xmlfilepath As String)
        Dim doc As New XmlDocument()
        doc.Load(xmlfilepath)

        ' Load users from XML into a list
        Dim users As New List(Of User)
        For Each userNode As XmlNode In doc.SelectNodes("/Users/User")
            Dim user As New User With {
                .FirstName = userNode.SelectSingleNode("User_Firstname").InnerText,
                .LastName = userNode.SelectSingleNode("User_Lastname").InnerText,
                .Password = userNode.SelectSingleNode("User_Password").InnerText,
                .Email = userNode.SelectSingleNode("User_Email").InnerText,
                .Username = userNode.SelectSingleNode("Username").InnerText,
                .PhoneNum = userNode.SelectSingleNode("User_PhoneNum").InnerText
            }
            users.Add(user)
        Next

        ' Sort users by LastName and FirstName using merge sort
        users = MergeSort(users)

        ' Clear current XML structure and rebuild
        doc.DocumentElement.RemoveAll()

        ' Append sorted users back to XML
        For Each user In users
            Dim newUser As XmlElement = doc.CreateElement("User")

            Dim newFirstName As XmlElement = doc.CreateElement("User_Firstname")
            newFirstName.InnerText = user.FirstName

            Dim newLastName As XmlElement = doc.CreateElement("User_Lastname")
            newLastName.InnerText = user.LastName

            Dim newPassword As XmlElement = doc.CreateElement("User_Password")
            newPassword.InnerText = user.Password

            Dim newEmail As XmlElement = doc.CreateElement("User_Email")
            newEmail.InnerText = user.Email

            Dim newUsername As XmlElement = doc.CreateElement("Username")
            newUsername.InnerText = user.Username

            Dim newPhoneNum As XmlElement = doc.CreateElement("User_PhoneNum")
            newPhoneNum.InnerText = user.PhoneNum

            newUser.AppendChild(newFirstName)
            newUser.AppendChild(newLastName)
            newUser.AppendChild(newPassword)
            newUser.AppendChild(newEmail)
            newUser.AppendChild(newUsername)
            newUser.AppendChild(newPhoneNum)

            doc.DocumentElement.AppendChild(newUser)
        Next

        ' Save the updated XML file
        doc.Save(xmlfilepath)
    End Sub

    Private Function ValidateName(name As String) As Boolean
        ' Regular expressions to allow for alphabetic characters (uppercase and lowercase)
        Dim regex As New Regex("^[a-zA-Z]+$")
        ' Return true if input complies with regex, otherwise it is false
        Return regex.IsMatch(name)
    End Function

    Private Function ValidateEmail(email As String) As Boolean
        ' Regular expression for validating user's email address
        Dim regex As New Regex("^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$")
        ' Return true if input complies with regex, otherwise it is false
        Return regex.IsMatch(email)
    End Function

    Private Function ValidatePhone(phone As String) As Boolean
        ' Regular expression for validating UK phone number (e.g., 077891 354778 or 077891354778 or 077891 354 778)
        Dim regex As New Regex("^(07\d{3}\s?\d{3}\s?\d{3})$")
        ' Return true if input complies with regex, otherwise it is false
        Return regex.IsMatch(phone)
    End Function

    Private Function ValidateUsername(username As String) As Boolean
        ' Regular expressions to allow for alphanumeric characters (upper and lowercase and numbers)
        Dim regex As New Regex("^[A-Za-z][A-Za-z0-9]{5,19}$")

        ' First, validate the username against the regex pattern
        If Not regex.IsMatch(username) Then
            Return False
        End If

        ' Path to the XML file
        Dim xmlFilePath As String = IO.Path.Combine(Application.StartupPath, "User_Data.xml")
        Dim doc As New XmlDocument()
        doc.Load(xmlFilePath)

        ' Check if the username already exists in the XML
        For Each userNode As XmlNode In doc.SelectNodes("/Users/User")
            Dim existingUsername As String = userNode.SelectSingleNode("Username").InnerText
            If existingUsername = username Then
                ' Username already exists
                MessageBox.Show("Username already exists. Please choose another one.", "Username Error", MessageBoxButtons.OK)
                Return False
            End If
        Next

        ' Username is valid and does not already exist
        Return True
    End Function

    Private Function ValidatePassword(password As String) As Boolean
        ' Check length of password
        If password.Length < 6 OrElse password.Length > 20 Then
            Return False
        End If

        ' Check if password contains at least one uppercase letter
        If Not password.Any(AddressOf Char.IsUpper) Then
            Return False
        End If

        ' Check if the password contains at least one number
        If Not password.Any(AddressOf Char.IsDigit) Then
            Return False
        End If

        ' Check if password contains at least one symbol
        If Not password.Any(Function(c) Char.IsPunctuation(c) OrElse Char.IsSymbol(c)) Then
            Return False
        End If

        ' If all conditions true, return true to main program
        Return True
    End Function
End Class
Public Class User
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property PhoneNum As String
    Public Property Username As String
    Public Property Password As String
End Class
