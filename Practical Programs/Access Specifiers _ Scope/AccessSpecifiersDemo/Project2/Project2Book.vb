'base class of project2... to access this class add reference of Project2 in Project1
Public Class Project2Book
    Public Project2PubicTitle As String
    Private Project2PrivateCost As Integer
    Protected Project2ProtectedPage As Integer
    Friend Project2FriendAuthor As String
    Protected Friend Project2ProtectedFriendPublisher As String

    Public Sub Project2Display()
        Console.WriteLine("Project2 Tile : " & Project2PubicTitle)
        Console.WriteLine("Project2 Cost : " & Project2PrivateCost)
        Console.WriteLine("Project2 Page : " & Project2ProtectedPage)
        Console.WriteLine("Project2 Author : " & Project2FriendAuthor)
        Console.WriteLine("Project2 Publisher : " & Project2ProtectedFriendPublisher)
    End Sub
End Class
