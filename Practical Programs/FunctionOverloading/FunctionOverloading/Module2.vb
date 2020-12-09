


Module Module2
    Dim i As Integer = 10

    Sub change(ByRef i As Integer)
        i += 15
        Console.WriteLine(i)
    End Sub
    Sub Main()
        Console.WriteLine(i)
        change(i)
        Console.WriteLine(i)
        Console.ReadKey()
    End Sub
End Module




