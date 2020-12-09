Module Module5

    Sub Main()

        Dim marks(2, 4) As Integer
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}

        Dim i, j As Integer

        For i = 0 To 1
            For j = 0 To 3
                Console.Write("Enter (" & i & " " & j & ") : ")
                marks(i, j) = CInt(Console.ReadLine())
            Next
        Next

        For i = 0 To 1
            For j = 0 To 3
                Console.Write((marks(i, j) & " "))
            Next
        Next

        Console.ReadKey()
    End Sub
End Module
