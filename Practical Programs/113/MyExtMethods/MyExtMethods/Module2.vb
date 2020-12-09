Module Module2

    Sub Main()
        Dim Sample As String = "Example of Extension Method"
        Sample.Display()
        Sample.ToUpper.Display()
        Console.Write(Constants.vbLf & "Press ENTER to quit....")
        Console.ReadLine()
    End Sub

End Module
