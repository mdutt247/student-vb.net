Module Module1

    Sub Main()
        Dim year As Integer
        Console.Write("Enter the year value (yyyy) :")
        year = Int32.Parse(Console.ReadLine())
        If (year Mod 4 = 0 AndAlso year Mod 100 <> 0) OrElse year Mod 400 = 0 Then
            Console.WriteLine("The year {0} is leap year ", year)
        Else
            Console.WriteLine("The year {0} is not leap year ", year)
        End If
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module
