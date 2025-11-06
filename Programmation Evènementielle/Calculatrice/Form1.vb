Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim res As String
    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If txta.Text = "" Then
            MessageBox.Show("entier invalide", "erreur")
            res = "erreur"
        End If
        If txtb.Text = "" Then
            MessageBox.Show("entier invalide", "erreur")
            res = "erreur"
        End If
        If txta.Text <> "" And txtb.Text <> "" Then
            a = txta.Text
            b = txtb.Text
            res = txta.Text & "+" & txtb.Text & "=" & (a + b)
        End If
        a = Val(txta.Text)
        b = Val(txtb.Text)


        lblresultat.Text = res

    End Sub
End Class
