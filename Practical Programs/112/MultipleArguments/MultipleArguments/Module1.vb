Module Module1
    Sub Main()
        DisplayMessage("First message:", "Hi")
        DisplayMessage("Second message:", "Hello", "there")
        Dim TextArray() As String = {"Hello", "from", "Visual", "Basic"}
        DisplayMessage("Third message:", TextArray)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
    Sub DisplayMessage(ByVal Title As String, ByVal ParamArray MessageText() As String)
        Dim intLoopIndex As Integer
        Console.WriteLine(Title)
        For intLoopIndex = 0 To UBound(MessageText)
            Console.WriteLine(MessageText(intLoopIndex))
        Next intLoopIndex
    End Sub
End Module

