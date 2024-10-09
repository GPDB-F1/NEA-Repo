Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form5
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Async Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make API request and display result when Drivers form loads
        Await LoadDriverDataAsync()
    End Sub

    Private Async Function LoadDriverDataAsync() As Task
        'Declare API URL as variable
        Dim apiURL As String = "https://api.openf1.org/v1/drivers"
        'Use HttpClient to send GET request
        Using client As New HttpClient()
            Try
                'Send GET request, await response
                Dim response As HttpResponseMessage = Await client.GetAsync(apiURL)
                response.EnsureSuccessStatusCode()

                'Read response content as string
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                'Deserialise JSON into life of Driver objects
                Dim drivers As List(Of Driver) = JsonConvert.DeserializeObject(Of List(Of Driver))(responseBody)

                'Format to display driver name, team and country
                Dim formattedOutput As New Text.StringBuilder()
                For Each driver In drivers
                    formattedOutput.AppendLine($"Driver: {driver.full_name}, Team: {driver.team_name}, Country: {driver.country_code}")
                Next

                'Dispay API data in textbox
                txtDriverData.Text = formattedOutput.ToString()

            Catch ex As Exception
                'Display error message if API call fails
                MessageBox.Show("Error fetching driver data. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function
    'Define Driver class
    Public Class Driver
        Public Property driver_number As Integer
        Public Property broadcast_name As String
        Public Property full_name As String
        Public Property name_acronym As String
        Public Property team_name As String
        Public Property team_colour As String
        Public Property first_name As String
        Public Property last_name As String
        Public Property country_code As String
        Public Property session_key As Integer
        Public Property meeting_key As Integer
    End Class
End Class