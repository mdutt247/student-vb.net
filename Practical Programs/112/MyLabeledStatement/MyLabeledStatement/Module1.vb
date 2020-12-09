Module Module1
    Sub Main()
        Dim x As Integer = 100, y As Integer = 4
        Dim count As Integer = 0
        Dim myArray As String(,) = New String(x - 1, y - 1) {}

        ' Initialize the array:
        For i As Integer = 0 To x - 1
            For j As Integer = 0 To y - 1
                count += 1
                myArray(i, j) = (count).ToString()
            Next j
        Next i

        ' Read input:
        Console.Write("Enter the Number to Search for:")

        ' Input a string:
        Dim myNumber As String = Console.ReadLine()

        ' Search:
        For i As Integer = 0 To x - 1
            For j As Integer = 0 To y - 1
                If myArray(i, j).Equals(myNumber) Then
                    GoTo Found
                End If
            Next j
        Next i

        Console.WriteLine("The Number {0} was not Found.", myNumber)
        GoTo Finish

Found:
        Console.WriteLine("The Number {0} is Found.", myNumber)

Finish:
        Console.WriteLine("End of Search.")
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

