Module Module1
    Sub Main()
        Dim intValue As Integer = 2
        Console.WriteLine("{0}+{1}={2}", intValue, intValue, Add(intValue, intValue))
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
    Function Add(ByVal int1 As Integer, ByVal int2 As Integer) As Long
        Return int1 + int2
    End Function
End Module

