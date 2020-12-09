Public Class BookUser 'another base class BookUser
    Public Sub SomeMethod()
        Dim x As New Book()
        'Public member is accessible
        x.pubicTitle = "VB.NET Programming"

        'Private member of Book class is not accessible here
        'x.Cost = 156 'will result in error

        'Protected member of Book class is not accessible here
        'x.Page = 142 'will result in error

        'Friend member is accessible
        x.friendAuthor = "Harold Davis"

        'Protected Friend member is accessible
        x.protectedFriendPublisher = "O'Reilly Media"

        'print the values
        x.Display()
    End Sub
End Class
