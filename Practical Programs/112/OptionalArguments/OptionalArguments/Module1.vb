Module Module1
    Sub Main()
        DisplayMessage()
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
    Sub DisplayMessage(Optional ByVal strText As String = "Hello from Visual Basic")
        Console.WriteLine(strText)
    End Sub
End Module

