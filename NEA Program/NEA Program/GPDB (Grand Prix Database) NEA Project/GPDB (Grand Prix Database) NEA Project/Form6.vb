Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form6
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Async Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Make API request and display result when Sessions form loads
        Await LoadSessionsDataAsync()
    End Sub
    Private Async Function LoadSessionsDataAsync() As Task
        Dim apiURL As String = "https://api.openf1.org/v1/sessions"
        ' Create an HTTP client to send the GET request
        Using client As New HttpClient()
            Try
                ' Send the GET request, await response
                Dim response As HttpResponseMessage = Await client.GetAsync(apiURL)
                response.EnsureSuccessStatusCode()

                ' Read the response content as a string
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON into a list of Session objects
                Dim sessions As List(Of Session) = JsonConvert.DeserializeObject(Of List(Of Session))(responseBody)

                ' Format the output to display specific session information
                Dim formattedOutput As New Text.StringBuilder()
                For Each session In sessions
                    formattedOutput.AppendLine($"Circuit: {session.circuit_short_name}, Country: {session.country_name}, Session: {session.session_name}")
                    formattedOutput.AppendLine($"Date Start: {session.date_start}, Date End: {session.date_end}")
                    formattedOutput.AppendLine($"Session Type: {session.session_type}, Location: {session.location}")
                    formattedOutput.AppendLine($"Year: {session.year}")
                    formattedOutput.AppendLine("------")
                Next

                ' Display session data in textbox
                txtSessionsData.Text = formattedOutput.ToString()

            Catch ex As Exception
                'Display error message if API call fails
                MessageBox.Show("Error fetching session data. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function
    Public Class Session
        Public Property circuit_key As Integer
        Public Property circuit_short_name As String
        Public Property country_code As String
        Public Property country_key As Integer
        Public Property country_name As String
        Public Property date_end As String
        Public Property date_start As String
        Public Property gmt_offset As String
        Public Property location As String
        Public Property meeting_key As Integer
        Public Property session_key As Integer
        Public Property session_name As String
        Public Property session_type As String
        Public Property year As Integer
    End Class
End Class