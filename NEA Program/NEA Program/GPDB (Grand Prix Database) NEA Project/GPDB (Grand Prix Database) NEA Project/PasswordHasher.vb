Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordHasher
    ' Method to generate a random salt
    Public Function GenerateSalt() As String
        Dim saltBytes(15) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(saltBytes)
        End Using
        Return Convert.ToBase64String(saltBytes)
    End Function

    ' Method to hash password with salt
    Public Function HashPassword(password As String, salt As String) As String
        Dim combinedPasswordSalt As String = password & salt
        Using sha256 As SHA256 = SHA256.Create()
            Dim hashBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(combinedPasswordSalt))
            Dim hashString As New StringBuilder()
            For Each b As Byte In hashBytes
                hashString.Append(b.ToString("x2"))
            Next
            Return hashString.ToString()
        End Using
    End Function
End Class
