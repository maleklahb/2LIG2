Imports System

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim A As Article
        If validerarticle(A) Then
            ajouterarticle(A)
            Init()
            MessageBox.Show("article ajouté avec succes", "information")
        End If
    End Sub

    Private Function validerarticle(ByRef A As Article) As Boolean
        Dim code As Integer
        Dim quantite As Integer
        Dim prix As Double
        Dim valide As Boolean = True
        'effacer les erreurs precedentes
        ErrorProvider1.Clear()
        ' --------code article ---------
        If Not Integer.TryParse(txtcode.Text, code) Then
            ErrorProvider1.SetError(txtcode, "code invalide")
            valide = False
        Else
            A.code = code
        End If
        '--------designation article ---------
        If String.IsNullOrWhiteSpace(txtdesignation.Text) Then
            ErrorProvider1.SetError(txtdesignation, "designation manquante")
            valide = False
        Else
            A.designation = txtdesignation.Text
        End If
        '--------prix article ---------
        If Not Double.TryParse(txtprix.Text, prix) OrElse prix <= 0 Then
            ErrorProvider1.SetError(txtprix, "prix invalide")
            valide = False
        Else
            A.prix = prix
        End If
        '--------quantite article ---------
        If Not Integer.TryParse(txtquanti.Text, quantite) OrElse quantite <= 0 Then
            ErrorProvider1.SetError(txtquanti, "quantite invalide")
            valide = False
        Else
            A.quantite = quantite
        End If

        Return valide
    End Function

    Private Sub Init()
        txtcode.Clear()
        txtdesignation.Clear()
        txtprix.Clear()
        txtquanti.Clear()
        ErrorProvider1.Clear()
        txtcode.Focus()
    End Sub
End Class



