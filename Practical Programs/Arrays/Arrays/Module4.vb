Module Module4
    Sub Main()

        Dim jag(5)() As Integer

        jag(0) = {1, 2, 3, 4, 5}
        jag(1) = {6, 7, 8, 9}
        jag(2) = {9, 7, 5}
        jag(3) = {2, 5, 7, 4, 7, 5, 4}
        jag(4) = {1, 3}
        jag(5) = {6}

        Console.WriteLine(jag(1)(2))

        Console.ReadKey()
    End Sub

End Module
