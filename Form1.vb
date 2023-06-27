Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebView21.Source = New Uri("https://google.com")
        WebView21.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebView21.Source = New Uri("https://youtube.com")
        WebView21.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebView21.Source = New Uri("https://yahoo.com")
        WebView21.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Error finding Google Picasa servers.", 48, "Error")

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WebView21.Show()
        WebView21.Source = New Uri("https://bing.com")
    End Sub
End Class
