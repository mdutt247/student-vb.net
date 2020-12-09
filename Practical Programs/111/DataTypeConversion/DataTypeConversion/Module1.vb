Module Module1

    Sub Main()
        Dim dblData As Double
        Dim intData As Integer
        Dim boldata As Boolean
        Dim lngdata As Long
        dblData = 3.14159
        boldata = True
        intData = 9
        intData = CInt(dblData)
        boldata = CBool(intData)
        lngdata = CLng(boldata)
        Console.WriteLine("intData = " & Str(intData))
        Console.WriteLine("bolData = " & Str(boldata))
        Console.WriteLine("lngData = " & Str(lngdata))
        Console.ReadLine()

    End Sub

End Module
