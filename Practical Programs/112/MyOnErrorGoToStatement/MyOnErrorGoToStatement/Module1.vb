Module Module1
    Sub Main()
        Dim int1 = 0, int2 = 1, int3 As Integer
        On Error GoTo Handler
        int3 = int2 / int1
        Console.WriteLine("Program completed...")
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
Handler:
        If (TypeOf Err.GetException() Is OverflowException) Then
            Console.WriteLine("Overflow error!")
            Resume Next
        End If
    End Sub
End Module

