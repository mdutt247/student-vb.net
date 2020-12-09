Module Module3
    Sub goto1()
        Dim x As Integer = 100, y As Integer = 4
        Dim count As Integer = 0
        Dim myArray As String(,) = New String(x - 1, y - 1) {}
        For i As Integer = 0 To x - 1
            For j As Integer = 0 To y - 1
                count += 1
                myArray(i, j) = count.ToString()
            Next
        Next

        Console.Write("Enter the number to search:")
        Dim myNumber As String = Console.ReadLine()
        For i As Integer = 0 To x - 1
            For j As Integer = 0 To y - 1
                If myArray(i, j).Equals(myNumber) Then
                    GoTo Found
                End If
            Next
        Next

        Console.WriteLine("The number {0} was not found", myNumber)
        GoTo Finish
Found:
        Console.WriteLine("The number {0} was found", myNumber)
        Console.WriteLine("End of search")
        Console.ReadLine()
Finish:
        Console.ReadKey()
    End Sub

End Module
