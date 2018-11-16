Imports System.Text.RegularExpressions

Public Class VBRegexTester
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim _REGEX As String = TextBox1.Text
        Dim Target As String = TextBox2.Text
        Dim Results As String = ""

        Dim hits As MatchCollection
        Try
            hits = Regex.Matches(Target, _REGEX, RegexOptions.Multiline)

            For Each hit In hits
                Results = Results + hit.ToString() + vbCrLf
            Next
        Catch ex As Exception
            Results = ex.Message
        End Try
        If Results = "" Then
            TextBox3.Text = "No matches" + vbCrLf
        Else
            TextBox3.Text = Results
        End If
        Return
    End Sub
End Class
