Imports Project.Perls

Module MainModule
    Sub Main()
        ' This requires the Imports Project1.Perls directive.
        Website.Execute()

        ' Access namespace directly in a statement.
        Ruby.Website.Open()

        Console.ReadKey()
    End Sub
End Module