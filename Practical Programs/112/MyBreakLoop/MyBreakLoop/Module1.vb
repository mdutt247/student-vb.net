Module Module1
    Sub Main()
        ' Breaking Loop 1 using Exit For statement.
        Dim i As Integer
        Console.WriteLine("Loop 1:")
        For i = 0 To 4
            If i = 3 Then
                Exit For
            End If
            Console.WriteLine("I = {0}", i)
        Next i
        ' Breaking Loop 2 using Boolean value.
        Dim done As Boolean = False
        Console.WriteLine(Constants.vbLf & "Loop 2:")
        i = 0
        Do While i < 5 AndAlso done = False
            If i = 2 Then
                done = True
            End If
            Console.WriteLine("I = {0}", i)
            i += 1
        Loop
        ' Breaking Loop 3 using GoTo statement.
        done = False
        Dim counter As Integer = 0
        Console.WriteLine(Constants.vbLf & "Loop 3:")
        Do
            If counter = 5 Then
                GoTo handle_done
            End If
            Console.WriteLine("Counter: {0}", counter)
            counter += 1
            GoTo not_done

handle_done:
            done = True
not_done:
            Console.WriteLine("End of Loop 3")
            ' Normal Execution of Loop 4 .
        Loop While Not done
        Console.WriteLine(Constants.vbLf & "Loop 4:")
        For i = 0 To 4
            If i = 2 Then
                i = 5
            End If
            Console.WriteLine("I = {0}", i)
        Next i
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

