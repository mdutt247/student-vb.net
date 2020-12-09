Module Module1
    Sub Main()
        Dim number As Integer = 1
        Do
            Console.WriteLine(number)
            number += 1
            If number <= 10 Then
                Continue Do
            Else
                Exit Do
            End If
        Loop
        Console.WriteLine("Series is breaked at number: " & number)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

