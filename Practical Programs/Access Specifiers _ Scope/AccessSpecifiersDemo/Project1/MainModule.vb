Imports Project2

Module MainModule

    Sub Main()
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("============From same class example=============")
        'Create object of Book class
        Dim b As New Book()
        'Call Display() procedure, however you will not get any values printed as they have not been initialized 
        b.Display()
        'You can access public, friend and protected friend members, set their values
        b.pubicTitle = "Some title"
        b.friendAuthor = "Some author"
        b.protectedFriendPublisher = "Some publisher"
        'Call again Display() procedure, now you see above set values
        b.Display()
        Console.WriteLine("================================================")

        Console.BackgroundColor = ConsoleColor.DarkBlue
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("===========From other class example=============")
        'create object of BookUser class
        Dim bu As New BookUser()
        'Call SomeMethod() procedure of BookUser class
        bu.SomeMethod()
        Console.WriteLine("================================================")

        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("===========From derived class example===========")
        'create object of DerivedBook class
        Dim db As New DerivedBook()
        'Call AnotherMethod() procedure of DerivedBook class
        db.AnotherMethod()
        Console.WriteLine("================================================")

        Console.BackgroundColor = ConsoleColor.Red
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("===========From other project example===========")
        'create object of Project2Book class
        'to do so first add reference of Project2 in this project
        'and import Project2 by Imports statement like: 
        'Imports Project2 at the top of this file
        Dim p2obj As New Project2Book()
        'access the members. You can access only public members of Project2Book class
        p2obj.Project2PubicTitle = "Project 2 book title"
        'call Project2Display() procedure
        p2obj.Project2Display()
        Console.WriteLine("================================================")

        Console.ReadKey()
    End Sub

End Module
