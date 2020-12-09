Module Module1
    Sub Main()
        DisplayMessage("Hello from Visual Basic")
    End Sub
    Sub DisplayMessage(ByVal strText As String)
        Console.WriteLine(strText)
        Console.Write(Constants.vbLf & "Press ENTER to quit...")
        Console.ReadLine()
    End Sub
End Module

