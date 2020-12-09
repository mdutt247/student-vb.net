Public Class DerivedBook 'derived class DerivedBook from Book class
    Inherits Book

    Public Sub AnotherMethod()
        'Private member is not accessible in derived class
        'Cost = 152  'will result in error

        'Public member is accessible in derived class
        pubicTitle = ".NET Framework"

        'Protected member is accessible in derived class
        protectedPage = 50

        'Friend member is accessible in derived class
        friendAuthor = "Microsoft"

        'Protected Friend member is accessible in derived class
        protectedFriendPublisher = "M Pub"

        'print the values
        Display()
    End Sub
End Class
