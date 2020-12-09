Module Module1

    Sub Main()
        ' Illustrate a simple for loop that counts from 1 to 5
        For i As Integer = 0 To 4
            Console.WriteLine("I = {0}", i)
        Next i

        ' Illustrate two loops to first find a letter in a string
        ' and then to print it out until a space is encountered.
        ' This shows you how to skip initialization in the second
        ' loop
        Dim nPos As Integer = 0
        Dim s As String = "this is a test of the emergency broadcast system"

        For nPos = 0 To s.Length - 1
            If s.Chars(nPos) = "b"c Then
                Exit For
            End If
        Next nPos
        For nPos = nPos To s.Length
            If s.Chars(nPos) = " "c Then
                Exit For
            End If
            Console.Write(s.Chars(nPos))
        Next
        Do While nPos < s.Length
            If s.Chars(nPos) = " "c Then
                Exit Do
            End If
            Console.Write(s.Chars(nPos))
            nPos += 1
        Loop
        Console.WriteLine(Constants.vbLf)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub

End Module

