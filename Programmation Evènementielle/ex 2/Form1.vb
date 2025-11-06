Public Class Form1

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        Dim nb1 As Double = Val(InputBox("Entrez le premier nombre :", "Nombre 1"))
        Dim nb2 As Double = Val(InputBox("Entrez le deuxième nombre :", "Nombre 2"))
        Dim somme As Double = nb1 + nb2
        Dim difference As Double = nb1 - nb2
        Dim produit As Double = nb1 * nb2
        Dim quotient As String
        If nb2 <> 0 Then
            quotient = (nb1 / nb2).ToString()
        Else
            quotient = "impossible"
        End If
        Labelres.Text = "somme=" & somme & ",difference=" & difference & ",produit=" & produit & ",quotient=" & quotient

    End Sub
End Class
