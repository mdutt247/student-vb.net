Module Module1

    Sub Main()
        Dim strText1 As String = "1234"
        Dim intValue1 As Integer
        intValue1 = Val(strText1)
        strText1 = Str(intValue1)
        Console.WriteLine(strText1)
        Console.ReadLine()

    End Sub

End Module
