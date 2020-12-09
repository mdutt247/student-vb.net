Module Module1

    Sub Main()
        Dim strText1 As String = "Hey, look here"
        Dim strText2 As String
        Dim strText3 As String
        strText2 = Mid(strText1, 6, 4)
        strText3 = strText1.Substring(5, 4)
        Console.WriteLine(strText2)
        Console.WriteLine(strText3)
        Console.ReadLine()
    End Sub

End Module
