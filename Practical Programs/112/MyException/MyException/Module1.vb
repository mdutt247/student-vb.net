Module Module1
    Sub Main()
        Dim number As Integer = 0
        Dim div As Integer = 0
        Try
            div = 100 \ number
        Catch e1 As DivideByZeroException
            Console.WriteLine("Exception Occured")
        End Try
        Console.WriteLine("Result is : " & div)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

