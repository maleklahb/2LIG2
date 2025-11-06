Public Class Form1
    Private Sub Btnafficher_Click(sender As Object, e As EventArgs) Handles Btnafficher.Click
        Dim nom As String = InputBox("Entrez votre nom :", "Nom")
        Dim age As String = InputBox("Entrez votre âge :", "Âge")
        MessageBox.Show("Bonjour " & nom & ", vous avez " & age & " ans.", "Message")
    End Sub
End Class
