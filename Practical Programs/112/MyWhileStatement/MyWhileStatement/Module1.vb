Module Module1

    Sub Main()
        ' An example of a simple while loop
        Console.WriteLine("Loop 1:")
        Dim i As Integer = 0
        Do While i < 5
            Console.WriteLine("I = {0}", i)
            i += 1
        Loop
        ' A while loop with a boolean
        Dim flag As Boolean = False
        i = 0
        Console.WriteLine(Constants.vbLf & "Loop 2:")
        Do While Not flag
            If i > 5 Then
                flag = True
            End If
            Console.WriteLine("I = {0}", i)
            i += 1
        Loop

        ' A loop that will never execute
        Console.WriteLine(Constants.vbLf & "Loop 3: ")
        Do While i < 5
            Console.WriteLine("I = {0}", i)
            i += 1
        Loop
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

