
Public Class Book 'base class Book
    Public pubicTitle As String
    Private privateCost As Integer
    Protected protectedPage As Integer
    Friend friendAuthor As String
    Protected Friend protectedFriendPublisher As String

    Public Sub Display()
        Console.WriteLine("Tile : " & pubicTitle)
        Console.WriteLine("Cost : " & privateCost)
        Console.WriteLine("Page : " & protectedPage)
        Console.WriteLine("Author : " & friendAuthor)
        Console.WriteLine("Publisher : " & protectedFriendPublisher)
    End Sub
End Class

