Module Module1

    Sub Main()
        Dim a(1000) As Integer
        Dim sum As Integer = 0
        Dim num As Integer

        Console.Write("Enter No. of Elments to be entered upto 1000: ")
        num = CInt(Console.ReadLine())

        For i As Integer = 0 To num - 1
            Console.WriteLine("Enter Element " & i & ": ")
            a(i) = CInt(Console.ReadLine())
        Next

        For i As Integer = 0 To num - 1
            sum = sum + a(i)
        Next

        Console.WriteLine("Sum of all elements of the array is: " & sum)

        'Ascending Order

        Dim temp As Integer

        Console.Write("Ascending: ")
        For i As Integer = 0 To num - 1
            For j As Integer = i + 1 To num - 1
                If a(i) > a(j) Then
                    temp = a(i)
                    a(i) = a(j)
                    a(j) = temp
                End If
            Next j
        Next i


        For i As Integer = 0 To num - 1
            Console.Write(a(i) & "  ")
        Next

        Dim cube(num) As Integer

        For i As Integer = 0 To num - 1
            cube(i) = a(i) * a(i) * a(i)
        Next

        Console.WriteLine("")
        Console.Write("Cube: ")
        For i As Integer = 0 To num - 1
            Console.Write(cube(i) & "  ")
        Next
        Console.ReadKey()
    End Sub

End Module
