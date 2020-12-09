Module Module1

    Sub Main()
        Dim bookTitles As String() = New String() {"Alice in Wonderland", "Pelican Brief",
           "Ignited Minds"}
        Console.WriteLine("The available book titles are: ")
        For Each i As String In bookTitles
            Console.WriteLine(Constants.vbTab & i)
        Next i
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

