Public Structure Article
    Public code As Integer
    Public designation As String
    Public prix As Double
    Public quantite As Integer
End Structure

Public Module ArticleModule
    Public listArticles As New List(Of Article)

    Public Sub ajouterarticle(ByVal A As Article)
        Dim x As Integer = exist(A)
        If x >= 0 Then
            Dim temp As Article = listArticles(x)
            temp.quantite += A.quantite
            temp.prix = A.prix
            listArticles(x) = temp
        Else
            listArticles.Add(A)
        End If
    End Sub

    Private Function exist(A As Article) As Integer
        For i As Integer = 0 To listArticles.Count - 1
            If listArticles(i).code = A.code Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module
