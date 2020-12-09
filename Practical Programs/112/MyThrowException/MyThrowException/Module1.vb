Module Module1
    Sub Main()
        Dim number As Integer
        Console.Write("Enter a Number:")
        number = Integer.Parse(Console.ReadLine())
        Try
            If number > 10 Then
                Throw New Exception("Maximum Limit is 10")
            End If
        Catch e As Exception
            Console.WriteLine("Exception has been Occured")
        Finally
            Console.WriteLine("This is the Last Statement")
            Console.Write(Constants.vbLf & "Press ENTER to quit...")
            Console.ReadLine()
        End Try
    End Sub
End Module

