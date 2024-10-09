Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form7
    Private Sub btnBack1_Click(sender As Object, e As EventArgs) Handles btnBack1.Click
        Me.Hide()
        Form4.Show()
    End Sub
    Private Async Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadMeetingsDataAsync()
    End Sub
    Private Async Function LoadMeetingsDataAsync() As Task
        Dim apiUrl As String = "https://api.openf1.org/v1/meetings"
        ' Create an HTTP client to send the GET request
        Using client As New HttpClient()
            Try
                ' Send the GET request and get the response
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)
                response.EnsureSuccessStatusCode()

                ' Read the response content as a string
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                ' Deserialize the JSON into a list of Meeting objects
                Dim meetings As List(Of Meeting) = JsonConvert.DeserializeObject(Of List(Of Meeting))(responseBody)

                ' Format the output to display specific meeting information
                Dim formattedOutput As New Text.StringBuilder()
                For Each meeting In meetings
                    formattedOutput.AppendLine($"Circuit: {meeting.circuit_short_name}, Country: {meeting.country_name}")
                    formattedOutput.AppendLine($"Location: {meeting.location}, Meeting: {meeting.meeting_name}")
                    formattedOutput.AppendLine($"Date Start: {meeting.date_start}, Year: {meeting.year}")
                    formattedOutput.AppendLine($"Official Name: {meeting.meeting_official_name}")
                    formattedOutput.AppendLine("------")
                Next

                ' Display the formatted meeting data in the TextBox (assuming the textbox is named txtMeetings)
                txtMeetingsData.Text = formattedOutput.ToString()

            Catch ex As Exception
                ' Handle any errors that occur during the API call
                MessageBox.Show("Error fetching meetings data. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Function

    ' Define the Meeting class based on the JSON structure
    Public Class Meeting
        Public Property circuit_key As Integer
        Public Property circuit_short_name As String
        Public Property country_code As String
        Public Property country_key As Integer
        Public Property country_name As String
        Public Property date_start As String
        Public Property gmt_offset As String
        Public Property location As String
        Public Property meeting_key As Integer
        Public Property meeting_name As String
        Public Property meeting_official_name As String
        Public Property year As Integer
    End Class
End Class