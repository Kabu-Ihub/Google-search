Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SearchName As String = TextBox1.Text
        WebBrowser1.Navigate("https://www.google.com/search?q=" + SearchName)
    End Sub
End Class
