Module Module1

    Sub Main()
        ' First, a simple do loop that
        ' increments a counter
        Dim i As Integer = 0
        Console.WriteLine("Loop 1:")
        Do
            Console.WriteLine("I = {0}", i)
            i += 1
        Loop While i < 5
        ' Next, the same case, but using a 
        ' boolean rather than an index
        i = 0
        Dim done As Boolean = False
        Console.WriteLine(Constants.vbLf & "Loop 2:")
        Do
            Console.WriteLine("I = {0}", i)
            i += 1
            If i > 5 Then
                done = True
            End If
        Loop While Not done
        ' Finally, a conditional that is true before
        ' You get into the loop
        Do
            Console.WriteLine("Into Loop 3")
        Loop While Not done
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

